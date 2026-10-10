/*
 * Dumped With: roblox-dumper 3.6
 * Created by: Jonah (jonahw on Discord)
 * Github: https://git.jonah.cool/jonah/roblox-dumper
 * Roblox Version: version-cec3ad5889b447cf
 * Time Taken: 2384 ms (2.384000 seconds)
 * Total Offsets: 5
 */

#pragma once
#include <cstdint>

// clang-format off
#pragma pack(push, 1)
namespace structs {

    struct VisualEngine {
        char pad_0[0x1B0];
        Matrix4x4 ViewMatrix;  // 0x1B0
        char pad_1[0x920];
        Vector2 Dimensions;  // 0xB10
        char pad_2[0x118];
        uintptr_t RenderView;  // 0xC30
    };  // sizeof = 0xC38

} // namespace structs
#pragma pack(pop)
