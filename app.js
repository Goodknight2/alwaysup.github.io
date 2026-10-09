let currentVersion = "";
let currentFormat = "json";
let currentData = null;
let rawFileCache = {};

const elements = {
  versionSelect: document.getElementById("version-select"),
  searchInput: document.getElementById("search-input"),
  formatTabs: document.querySelectorAll(".tab-btn"),
  tableView: document.getElementById("table-view"),
  codeView: document.getElementById("code-view").querySelector("code"),
  metaVersion: document.getElementById("meta-version"),
  metaTotal: document.getElementById("meta-total"),
  metaDumper: document.getElementById("meta-dumper"),
  copyRawBtn: document.getElementById("copy-raw-btn"),
  toast: document.getElementById("toast")
};

// Initialize App
async function init() {
  try {
    const res = await fetch("./data/versions.json?t=" + Date.now());
    const versions = await res.json();

    elements.versionSelect.innerHTML = versions
      .map(v => `<option value="${v}">${v}</option>`)
      .join("");

    currentVersion = versions[0];
    await loadVersionData(currentVersion);

    // Event Listeners
    elements.versionSelect.addEventListener("change", e => {
      currentVersion = e.target.value;
      rawFileCache = {}; // clear cache on version change
      loadVersionData(currentVersion);
    });

    elements.searchInput.addEventListener("input", filterData);

    elements.formatTabs.forEach(tab => {
      tab.addEventListener("click", () => {
        elements.formatTabs.forEach(t => t.classList.remove("active"));
        tab.classList.add("active");
        currentFormat = tab.dataset.format;
        switchFormat(currentFormat);
      });
    });

    elements.copyRawBtn.addEventListener("click", copyCurrentView);
  } catch (e) {
    console.error("Failed to initialize tracker site:", e);
  }
}

// Load Json Data & Meta
async function loadVersionData(version) {
  const jsonRes = await fetch(`./data/${version}/offsets.json?t=` + Date.now());
  currentData = await jsonRes.json();

  // Populate Meta
  elements.metaVersion.innerText = currentData.metadata.roblox_version;
  elements.metaTotal.innerText = currentData.metadata.total_offsets;
  elements.metaDumper.innerText = currentData.metadata.dumper;

  switchFormat(currentFormat);
}

// Format Switcher
async function switchFormat(format) {
  if (format === "json") {
    document.getElementById("table-view").classList.add("active");
    document.getElementById("code-view").classList.remove("active");
    renderTable(currentData.offsets);
  } else {
    document.getElementById("table-view").classList.remove("active");
    document.getElementById("code-view").classList.add("active");

    const fileMap = {
      cpp: "offsets.h",
      structs: "structs.h",
      cs: "offsets.cs",
      py: "offsets.py"
    };

    const fileName = fileMap[format];
    if (!rawFileCache[fileName]) {
      const res = await fetch(`./data/${currentVersion}/${fileName}?t=` + Date.now());
      rawFileCache[fileName] = await res.text();
    }

    elements.codeView.innerText = rawFileCache[fileName];
  }
}

// Render JSON Table
function renderTable(offsets) {
  const query = elements.searchInput.value.toLowerCase().trim();
  elements.tableView.innerHTML = "";

  const grid = document.createElement("div");
  grid.className = "class-grid";

  for (const [className, properties] of Object.entries(offsets)) {
    const matchingProps = [];

    for (const [propName, value] of Object.entries(properties)) {
      const hexVal = "0x" + value.toString(16).toUpperCase();
      const decVal = value.toString();

      if (
        !query ||
        className.toLowerCase().includes(query) ||
        propName.toLowerCase().includes(query) ||
        hexVal.toLowerCase().includes(query) ||
        decVal.includes(query)
      ) {
        matchingProps.push({ propName, hexVal, decVal });
      }
    }

    if (matchingProps.length > 0) {
      const card = document.createElement("div");
      card.className = "class-card";

      let rowsHtml = matchingProps
        .map(
          p => `
          <div class="offset-row" onclick="copyText('${p.propName} = ${p.hexVal}')">
            <span class="offset-name">${p.propName}</span>
            <span class="offset-value">${p.hexVal}</span>
          </div>`
        )
        .join("");

      card.innerHTML = `
        <div class="class-header">${className}</div>
        <div class="class-body">${rowsHtml}</div>
      `;

      grid.appendChild(card);
    }
  }

  elements.tableView.appendChild(grid);
}

function filterData() {
  if (currentFormat === "json") {
    renderTable(currentData.offsets);
  }
}

function copyText(text) {
  navigator.clipboard.writeText(text);
  showToast(`Copied: ${text}`);
}

function copyCurrentView() {
  if (currentFormat === "json") {
    navigator.clipboard.writeText(JSON.stringify(currentData, null, 2));
    showToast("Copied raw JSON to clipboard!");
  } else {
    navigator.clipboard.writeText(elements.codeView.innerText);
    showToast("Copied raw file to clipboard!");
  }
}

function showToast(msg) {
  elements.toast.innerText = msg;
  elements.toast.classList.add("show");
  setTimeout(() => elements.toast.classList.remove("show"), 2000);
}

init();