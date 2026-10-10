/*
 * Dumped With: roblox-dumper 3.6
 * Created by: Jonah (jonahw on Discord)
 * Github: https://git.jonah.cool/jonah/roblox-dumper
 * Roblox Version: version-cec3ad5889b447cf
 * Time Taken: 37712 ms (37.712000 seconds)
 * Total Offsets: 315
 */

using System;

namespace RobloxOffsets
{
    public static class Metadata
    {
        public const string RobloxVersion = "version-cec3ad5889b447cf";
    }

    public static class AirProperties
    {
        public const ulong AirDensity = 0x18;
        public const ulong GlobalWind = 0x3C;
    }

    public static class Atmosphere
    {
        public const ulong Color = 0xA8;
        public const ulong Decay = 0xB4;
        public const ulong Density = 0xC0;
        public const ulong Glare = 0xC4;
        public const ulong Haze = 0xC8;
        public const ulong Offset = 0xCC;
    }

    public static class BasePart
    {
        public const ulong CastShadow = 0x125;
        public const ulong Color3 = 0x198;
        public const ulong Locked = 0x126;
        public const ulong Massless = 0x127;
        public const ulong Primitive = 0x178;
        public const ulong Reflectance = 0xFC;
        public const ulong Shape = 0x1A8;
        public const ulong Transparency = 0x120;
    }

    public static class BloomEffect
    {
        public const ulong Intensity = 0xA8;
        public const ulong Size = 0xAC;
        public const ulong Threshold = 0xB0;
    }

    public static class CachedItem
    {
        public const ulong FileMeshData = 0x40;
    }

    public static class Camera
    {
        public const ulong CFrame = 0xC8;
        public const ulong CameraSubject = 0xB8;
        public const ulong FieldOfView = 0x130;
        public const ulong Position = 0xEC;
        public const ulong Rotation = 0xC8;
        public const ulong ViewportInt16 = 0x28C;
        public const ulong ViewportSize = 0x2CC;
    }

    public static class CharacterMesh
    {
        public const ulong BaseTextureId = 0xB8;
        public const ulong BodyPart = 0x138;
        public const ulong MeshId = 0xE8;
        public const ulong OverlayTextureId = 0x118;
    }

    public static class ClassDescriptor
    {
        public const ulong ClassName = 0x8;
        public const ulong Creator = 0x230;
        public const ulong EventDescriptors = 0x88;
        public const ulong FunctionDescriptors = 0xD0;
        public const ulong PropertyDescriptors = 0x40;
    }

    public static class Creator
    {
        public const ulong MapEnd = 0x83DEC00;
        public const ulong MapStart = 0x83DEBF8;
    }

    public static class DataModel
    {
        public const ulong CreatorId = 0x178;
        public const ulong GameId = 0x180;
        public const ulong GameLoaded = 0x5D0;
        public const ulong JobId = 0x110;
        public const ulong PlaceId = 0x188;
        public const ulong ServerIP = 0x5B8;
        public const ulong Workspace = 0x150;
    }

    public static class Descriptor
    {
        public const ulong Name = 0x8;
    }

    public static class FakeDataModel
    {
        public const ulong Pointer = 0x8BCFD50;
        public const ulong RealDataModel = 0x1F8;
    }

    public static class FileMeshData
    {
        public const ulong AabbMax = 0x18C;
        public const ulong AabbMin = 0x180;
        public const ulong Faces = 0x30;
        public const ulong FacesEnd = 0x38;
        public const ulong Vertices = 0x0;
        public const ulong VerticesEnd = 0x8;
    }

    public static class Fire
    {
        public const ulong FireProximityPrompt = 0x30E9D90;
    }

    public static class FunctionDescriptor
    {
        public const ulong Function = 0x80;
    }

    public static class Functions
    {
        public const ulong Clone = 0xFFFF81EB8B541278;
        public const ulong Destroy = 0xFFFF81EB8B541298;
        public const ulong FindPartOnRay = 0xFFFF81EB8B620978;
        public const ulong FindPartOnRayWithIgnoreList = 0xFFFF81EB8B6209F8;
        public const ulong FindPartOnRayWithWhitelist = 0xFFFF81EB8B620A58;
        public const ulong FireServer = 0xFFFF81EB8B6BEE78;
        public const ulong Print = 0x1C65A30;
        public const ulong RaisePropertyChanged = 0xDEE980;
        public const ulong Raycast = 0xFFFF81EB8B6206B8;
        public const ulong SetParent = 0xD00010;
        public const ulong SetParentInternal = 0x1CAFEB0;
        public const ulong Shapecast = 0xFFFF81EB8B620758;
    }

    public static class GuiBase2D
    {
        public const ulong AbsolutePosition = 0xF8;
        public const ulong AbsoluteRotation = 0xD8;
        public const ulong AbsoluteSize = 0x104;
    }

    public static class GuiObject
    {
        public const ulong Active = 0x598;
        public const ulong AnchorPoint = 0x548;
        public const ulong AutomaticSize = 0x550;
        public const ulong BackgroundColor3 = 0x530;
        public const ulong BackgroundTransparency = 0x554;
        public const ulong BorderColor3 = 0x53C;
        public const ulong BorderMode = 0x558;
        public const ulong BorderSizePixel = 0x55C;
        public const ulong ClipsDescendants = 0x599;
        public const ulong GuiState = 0x568;
        public const ulong Interactable = 0x59B;
        public const ulong LayoutOrder = 0x56C;
        public const ulong Position = 0x500;
        public const ulong Rotation = 0xD8;
        public const ulong Selectable = 0x59C;
        public const ulong SelectionOrder = 0x588;
        public const ulong Size = 0x520;
        public const ulong SizeConstraint = 0x590;
        public const ulong Visible = 0x59D;
        public const ulong ZIndex = 0x594;
    }

    public static class Highlight
    {
        public const ulong Adornee = 0xA8;
        public const ulong DepthMode = 0xD0;
        public const ulong Enabled = 0xE4;
        public const ulong FillColor = 0xB8;
        public const ulong FillTransparency = 0xD4;
        public const ulong OutlineColor = 0xC4;
        public const ulong OutlineTransparency = 0xDC;
    }

    public static class HopperBin
    {
        public const ulong BinType = 0x458;
    }

    public static class Humanoid
    {
        public const ulong AutoJumpEnabled = 0x1C4;
        public const ulong AutoRotate = 0x1C5;
        public const ulong AutomaticScalingEnabled = 0x1C6;
        public const ulong BreakJointsOnDeath = 0x1C7;
        public const ulong CameraOffset = 0x118;
        public const ulong DisplayDistanceType = 0x170;
        public const ulong EvaluateStateMachine = 0x1C8;
        public const ulong Health = 0x180;
        public const ulong HealthDisplayDistance = 0x178;
        public const ulong HealthDisplayType = 0x17C;
        public const ulong HipHeight = 0x184;
        public const ulong JumpHeight = 0x190;
        public const ulong JumpPower = 0x194;
        public const ulong MaxHealth = 0x198;
        public const ulong MaxSlopeAngle = 0x19C;
        public const ulong NameDisplayDistance = 0x1A0;
        public const ulong NameOcclusion = 0x1A4;
        public const ulong RequiresNeck = 0x1CD;
        public const ulong RigType = 0x1B0;
        public const ulong SeatPart = 0xF8;
        public const ulong Sit = 0x1CE;
        public const ulong TargetPoint = 0x13C;
        public const ulong UseJumpPower = 0x1D0;
        public const ulong WalkSpeed = 0x1C0;
        public const ulong WalkSpeedCheck = 0x39C;
        public const ulong WalkToPoint = 0x154;
    }

    public static class ICreator
    {
        public const ulong Create = 0x0;
    }

    public static class InputObject
    {
        public const ulong MousePosition = 0xD4;
    }

    public static class Instance
    {
        public const ulong ChildrenEnd = 0x8;
        public const ulong ChildrenStart = 0x78;
        public const ulong ClassDescriptor = 0x18;
        public const ulong Name = 0x8;
        public const ulong NameContainer = 0x70;
        public const ulong Parent = 0x68;
    }

    public static class Lighting
    {
        public const ulong Ambient = 0xC0;
        public const ulong Atmosphere = 0x1C8;
        public const ulong Brightness = 0x108;
        public const ulong ClockTime = 0xB8;
        public const ulong ColorShift_Bottom = 0xCC;
        public const ulong ColorShift_Top = 0xD8;
        public const ulong EnvironmentDiffuseScale = 0x10C;
        public const ulong EnvironmentSpecularScale = 0x110;
        public const ulong ExposureCompensation = 0x114;
        public const ulong FogColor = 0xE4;
        public const ulong FogEnd = 0x11C;
        public const ulong FogStart = 0x120;
        public const ulong OutdoorAmbient = 0xF0;
        public const ulong ShadowSoftness = 0x12C;
        public const ulong Sky = 0x1B8;
    }

    // these are in the lighting service
    public static class LightingParameters
    {
        public const ulong GeographicLatitude = 0x124;
        public const ulong LightColor = 0x14C;
        public const ulong LightDirection = 0x158;
        public const ulong SkyAmbient = 0x140;
        public const ulong SkyAmbient2 = 0x128;
        public const ulong Source = 0x164;
        public const ulong TrueMoonPosition = 0x174;
        public const ulong TrueSunPosition = 0x168;
    }

    public static class LruHolder
    {
        public const ulong MemEnforcedLRUCache = 0x20;
    }

    public static class LruNode
    {
        public const ulong CachedItem = 0x40;
        public const ulong MeshId = 0x10;
        public const ulong Next = 0x0;
    }

    public static class MaterialColors
    {
        public const ulong Asphalt = 0x90;
        public const ulong Basalt = 0x87;
        public const ulong Brick = 0x6F;
        public const ulong Cobblestone = 0x93;
        public const ulong Concrete = 0x6C;
        public const ulong CrackedLava = 0x8D;
        public const ulong Glacier = 0x7B;
        public const ulong Grass = 0x66;
        public const ulong Ground = 0x8A;
        public const ulong Ice = 0x96;
        public const ulong LeafyGrass = 0x99;
        public const ulong Limestone = 0x9F;
        public const ulong Mud = 0x84;
        public const ulong Pavement = 0xA2;
        public const ulong Rock = 0x78;
        public const ulong Salt = 0x9C;
        public const ulong Sand = 0x72;
        public const ulong Sandstone = 0x81;
        public const ulong Slate = 0x69;
        public const ulong Snow = 0x7E;
        public const ulong WoodPlanks = 0x75;
    }

    public static class MemEnforcedLRUCache
    {
        public const ulong Head = 0x8;
    }

    public static class MeshContentProvider
    {
        public const ulong LruHolder = 0xC8;
    }

    public static class MeshPart
    {
        public const ulong MeshId = 0x300;
        public const ulong TextureId = 0x330;
    }

    public static class Model
    {
        public const ulong PrimaryPart = 0x248;
        public const ulong Scale = 0x134;
    }

    public static class ModuleScript
    {
        public const ulong IsRobloxScript = 0x158;
    }

    public static class MouseService
    {
        public const ulong InputObject = 0xF0;
    }

    public static class Player
    {
        public const ulong Character = 0x288;
        public const ulong UserId = 0xC0;
    }

    public static class Players
    {
        public const ulong LocalPlayer = 0x120;
    }

    public static class Primitive
    {
        public const ulong AssemblyAngularVelocity = 0xEC;
        public const ulong AssemblyLinearVelocity = 0xE0;
        public const ulong CFrame = 0xB0;
        public const ulong Material = 0x246;
        public const ulong Orientation = 0xB0;
        public const ulong Part = 0x210;
        public const ulong Position = 0xD4;
        public const ulong PrimitiveFlags = 0x1B6;
        public const ulong Rotation = 0xB0;
        public const ulong Size = 0x1BC;
    }

    public static class PrimitiveFlags
    {
        public const ulong Anchored = 0x2;
        public const ulong CanCollide = 0x8;
        public const ulong CanQuery = 0x20;
        public const ulong CanTouch = 0x10;
    }

    public static class PropertyDescriptor
    {
        public const ulong GetSetImpl = 0x98;
        public const ulong TType = 0x70;
    }

    public static class ProximityPrompt
    {
        public const ulong ActionText = 0xA0;
        public const ulong Enabled = 0x126;
        public const ulong HoldDuration = 0x110;
        public const ulong KeyboardKeyCode = 0x114;
        public const ulong MaxActivationDistance = 0x118;
        public const ulong ObjectText = 0xC0;
        public const ulong RequiresLineOfSight = 0x127;
    }

    public static class RenderView
    {
        public const ulong DeviceD3D11 = 0x8;
        public const ulong LightingValid = 0x278;
        public const ulong SkyboxValid = 0x28D;
    }

    public static class ScriptContext
    {
        public const ulong RequireBypass = 0x975;
    }

    public static class Seat
    {
        public const ulong Occupant = 0x208;
    }

    public static class Sky
    {
        public const ulong MoonAngularSize = 0x234;
        public const ulong MoonTextureId = 0xB8;
        public const ulong SkyboxBk = 0xE8;
        public const ulong SkyboxDn = 0x118;
        public const ulong SkyboxFt = 0x148;
        public const ulong SkyboxLf = 0x178;
        public const ulong SkyboxOrientation = 0x228;
        public const ulong SkyboxRt = 0x1A8;
        public const ulong SkyboxUp = 0x1D8;
        public const ulong StarCount = 0x238;
        public const ulong SunAngularSize = 0x23C;
        public const ulong SunTextureId = 0x208;
    }

    public static class SpecialMesh
    {
        public const ulong MeshId = 0xE8;
        public const ulong Offset = 0xA8;
        public const ulong Scale = 0xB4;
        public const ulong TextureId = 0x118;
    }

    public static class TaskScheduler
    {
        public const ulong JobEnd = 0xD0;
        public const ulong JobName = 0x18;
        public const ulong JobStart = 0xC8;
        public const ulong Pointer = 0x8B79128;
    }

    public static class Team
    {
        public const ulong TeamColor = 0xA8;
    }

    public static class Terrain
    {
        public const ulong GrassLength = 0x1E0;
        public const ulong MaterialColors = 0x280;
        public const ulong WaterColor = 0x1D0;
        public const ulong WaterReflectance = 0x1E8;
        public const ulong WaterTransparency = 0x1EC;
        public const ulong WaterWaveSize = 0x1F0;
        public const ulong WaterWaveSpeed = 0x1F4;
    }

    public static class TextButton
    {
        public const ulong AutoButtonColor = 0x9E4;
        public const ulong ContentText = 0xE20;
        public const ulong LineHeight = 0xF38;
        public const ulong LocalizedText = 0xE20;
        public const ulong MaxVisibleGraphemes = 0x1154;
        public const ulong Modal = 0x9E5;
        public const ulong RichText = 0x1036;
        public const ulong Selected = 0x9E6;
        public const ulong Text = 0xE20;
        public const ulong TextColor3 = 0x1138;
        public const ulong TextDirection = 0xFD8;
        public const ulong TextScaled = 0xE09;
        public const ulong TextSize = 0x115C;
        public const ulong TextStrokeColor3 = 0x1144;
        public const ulong TextStrokeTransparency = 0x1160;
        public const ulong TextTransparency = 0x1164;
        public const ulong TextTruncate = 0x1168;
        public const ulong TextWrapped = 0x1030;
        public const ulong TextXAlignment = 0x116C;
        public const ulong TextYAlignment = 0xF80;
    }

    public static class TextLabel
    {
        public const ulong ContentText = 0xBA0;
        public const ulong LineHeight = 0xCB8;
        public const ulong LocalizedText = 0xBA0;
        public const ulong MaxVisibleGraphemes = 0xED4;
        public const ulong RichText = 0xDB6;
        public const ulong Text = 0xBA0;
        public const ulong TextColor3 = 0xEB8;
        public const ulong TextDirection = 0xD58;
        public const ulong TextScaled = 0xB89;
        public const ulong TextSize = 0xEDC;
        public const ulong TextStrokeColor3 = 0xEC4;
        public const ulong TextStrokeTransparency = 0xEE0;
        public const ulong TextTransparency = 0xEE4;
        public const ulong TextTruncate = 0xEE8;
        public const ulong TextWrapped = 0xDB0;
        public const ulong TextXAlignment = 0xEEC;
        public const ulong TextYAlignment = 0xD00;
    }

    public static class Tool
    {
        public const ulong CanBeDropped = 0x4A8;
        public const ulong Enabled = 0x4A9;
        public const ulong Grip = 0x478;
        public const ulong GripForward = 0x490;
        public const ulong GripPos = 0x49C;
        public const ulong GripRight = 0x478;
        public const ulong GripUp = 0x484;
        public const ulong ManualActivationOnly = 0x4AA;
        public const ulong RequiresHandle = 0x4AB;
        public const ulong Tooltip = 0x458;
    }

    public static class Types
    {
        public const ulong AllTypes = 0x8B64578;
    }

    public static class Value
    {
        public const ulong Value = 0xA8;
    }

    public static class VehicleSeat
    {
        public const ulong MaxSpeed = 0x218;
        public const ulong Occupant = 0x1F8;
        public const ulong SteerFloat = 0x21C;
        public const ulong ThrottleFloat = 0x220;
        public const ulong Torque = 0x224;
        public const ulong TurnSpeed = 0x228;
    }

    public static class VisualEngine
    {
        public const ulong Dimensions = 0xB10;
        public const ulong FakeDataModel = 0xAF0;
        public const ulong Pointer = 0x8656E40;
        public const ulong RenderView = 0xC30;
        public const ulong ViewMatrix = 0x1B0;
    }

    public static class Workspace
    {
        public const ulong CurrentCamera = 0x4A8;
        public const ulong ReadOnlyGravity = 0x9C8;
        public const ulong World = 0x400;
    }

    public static class World
    {
        public const ulong AirProperties = 0x238;
        public const ulong Gravity = 0x220;
        public const ulong Primitives = 0x2C8;
        public const ulong WorldSteps = 0x740;
    }

    public enum ReflectionType
    {
        Null = 0x0,
        Bool = 0x1,
        Int = 0x2,
        Int64 = 0x3,
        Float = 0x4,
        Double = 0x5,
        String = 0x6,
        ProtectedString = 0x7,
        Instance = 0x8,
        Instances = 0x9,
        Ray = 0xA,
        Vector2 = 0xB,
        Vector3 = 0xC,
        Vector2int16 = 0xD,
        Vector3int16 = 0xE,
        Rect2D = 0xF,
        CoordinateFrame = 0x10,
        Color3 = 0x11,
        Color3uint8 = 0x12,
        UDim = 0x13,
        UDim2 = 0x14,
        Faces = 0x15,
        Axes = 0x16,
        Region3 = 0x17,
        Region3int16 = 0x18,
        CellId = 0x19,
        GuidData = 0x1A,
        PhysicalProperties = 0x1B,
        BrickColor = 0x1C,
        SystemAddress = 0x1D,
        BinaryString = 0x1E,
        Surface = 0x1F,
        CollectionHandle = 0x20,
        Enum = 0x21,
        Property = 0x22,
        Tuple = 0x23,
        Array = 0x24,
        Dictionary = 0x25,
        Map = 0x26,
        Variant = 0x27,
        GenericFunction = 0x28,
        Function = 0x29,
        ColorSequence = 0x2A,
        ColorSequenceKeypoint = 0x2B,
        NumberRange = 0x2C,
        NumberSequence = 0x2D,
        NumberSequenceKeypoint = 0x2E,
        Connection = 0x30,
        ContentId = 0x31,
        DescribedBase = 0x32,
        RefType = 0x33,
        EventInstance = 0x36,
        TweenInfo = 0x37,
        DockWidgetPluginGuiInfo = 0x38,
        PluginDrag = 0x39,
        Random = 0x3A,
        PathWaypoint = 0x3B,
        FloatCurveKey = 0x3C,
        RotationCurveKey = 0x3D,
        ValueCurveKey = 0x3E,
        SharedString = 0x3F,
        DateTime = 0x40,
        RaycastParams = 0x41,
        RaycastResult = 0x42,
        OverlapParams = 0x43,
        LazyTable = 0x44,
        DebugTable = 0x45,
        CatalogSearchParams = 0x46,
        OptionalCoordinateFrame = 0x47,
        CSGPropertyData = 0x48,
        UniqueId = 0x49,
        Font = 0x4A,
        SharedTable = 0x4B,
        SharedTableIterator = 0x4C,
        AnimationMask = 0x4D,
        AnimationPose = 0x4E,
        ClipEvaluator = 0x4F,
        OpenCloudModel = 0x50,
        InstanceRef = 0x51,
        SecurityCapabilities = 0x52,
        ArticulatedJoint = 0x53,
        AnimationContext = 0x54,
        Secret = 0x55,
        Buffer = 0x56,
        Integer = 0x57,
        Path2DControlPoint = 0x58,
        ReplicationPV = 0x59,
        FacsReplicationData = 0x5A,
        AnimationMaskModifier = 0x5B,
        Content = 0x5C,
        NetAssetHandle = 0x5D,
        NetAssetRef = 0x5E,
        Object = 0x5F,
        AdReward = 0x60,
        AssetContentMap = 0x61,
        SlimReplicationData = 0x62,
        User = 0x63,
        WebViewParams = 0x64,
        AnimTrackPlayState = 0x65,
        AnimTrackMetadata = 0x66,
        AnimTrackWeight = 0x67,
        ScopedInstanceIdentity = 0x68,
    }

} // namespace RobloxOffsets
