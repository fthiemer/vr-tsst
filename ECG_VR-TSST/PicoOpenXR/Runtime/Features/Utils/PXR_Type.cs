﻿using System;
using System.Runtime.InteropServices;
using Unity.XR.OpenXR.Features.PICOSupport;

namespace Unity.XR.PXR
{
                   
    [StructLayout(LayoutKind.Sequential)]
    public struct XrFuturePollInfoEXT
    {
        public XrStructureType type;
        public IntPtr next;
        public ulong future;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XrFuturePollResultEXT
    {
        public XrStructureType type;
        public IntPtr next;
        public PxrFutureState state;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSenseDataProviderCreateInfoBaseHeader
    {
        public XrStructureType type;
        public IntPtr next;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSenseDataProviderStartCompletion
    {
        public XrStructureType type;
        public IntPtr next;
        public PxrResult futureResult;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSenseDataQueryCompletion
    {
        public XrStructureType type;
        public IntPtr next;
        public PxrResult futureResult;
        public ulong snapshotHandle;
    }

    public struct PxrUuid
    {
        public ulong value0;
        public ulong value1;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSpatialAnchorCompletion
    {
        public XrStructureType type;
        public IntPtr next;
        public PxrResult futureResult;
        public ulong anchorHandle;
        public PxrUuid uuid;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XrSpatialAnchorPersistInfo
    {
        public XrStructureType type;
        public IntPtr next;
        public PxrPersistenceLocation location;
        public ulong anchorHandle;
    }

    public enum PxrPersistenceLocation
    {
        Local = 0,
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSenseDataQueryInfo
    {
        public XrStructureType type;
        public IntPtr next;
        public IntPtr filter; //PxrSenseDataQueryFilterBaseHeader
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSenseDataFilterUuid
    {
        public XrStructureType type;
        public IntPtr next;
        public uint uuidCount;
        public IntPtr uuidList; //=>PxrUuid[]
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSenseDataFilterSemantic
    {
        public XrStructureType type;
        public IntPtr next;
        public uint semanticCount;
        public IntPtr semantics; //=>PxrSemanticLabel[]
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct XrQueriedSenseDataGetInfo
    {
        public XrStructureType type;
        public IntPtr next;
        public ulong snapshotHandle;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct XrQueriedSenseData
    {
        public XrStructureType type;
        public IntPtr next;
        public uint queriedSpatialEntityCapacityInput;
        public uint queriedSpatialEntityCountOutput;
        public IntPtr queriedSpatialEntities;//PxrQueriedSpatialEntityInfo[]
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct PxrQueriedSpatialEntityInfo
    {
        public XrStructureType type;
        public IntPtr next;
        public ulong spatialEntity;
        public ulong time;
        public PxrUuid uuid;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSpatialEntityAnchorRetrieveInfo
    {
        public XrStructureType type;
        public IntPtr next;
        public ulong spatialEntity;
    }
   
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSpaceLocation
    {
        public XrStructureType type;
        public IntPtr next;
        public ulong locationFlags; //PxrSpaceLocationFlags
        public PxrPosef pose;
    }
    public enum PxrSpaceLocationFlags
    {
        OrientationValid = 0x00000001,
        PositionValidBit = 0x00000002,
        OrientationTracked = 0x00000004,
        PositionTracked = 0x00000008
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSpatialAnchorUnpersistInfo
    {
        public XrStructureType type;
        public IntPtr next;
        public PxrPersistenceLocation location;
        public ulong anchorHandle;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XrSceneCaptureStartCompletion
    {
        public XrStructureType type;
        public IntPtr next;
        public PxrResult futureResult;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSpatialEntityComponentGetInfoBaseHeader
    {
        public XrStructureType type;
        public IntPtr next;
        public ulong entity;
        public PxrSceneComponentType componentType;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSpatialEntityComponentDataBaseHeader
    {
        public XrStructureType type;
        public IntPtr next;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSpatialEntityGetInfo
    {
        public XrStructureType type;
        public IntPtr next;
        public ulong entity;
        public PxrSceneComponentType componentType;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSpatialEntitySemanticData
    {
        public XrStructureType type;
        public IntPtr next;
        public uint semanticCapacityInput;
        public uint semanticCountOutput;
        public IntPtr semanticLabels;//PxrSemanticLabel[]
    }
    
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSpatialEntityLocationGetInfo
    {
        public XrStructureType type;
        public IntPtr next;
        public ulong entity;
        public PxrSceneComponentType componentType;
        public ulong baseSpace;
        public ulong time;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XrSpaceLocationData
    {
        public ulong locationFlags;
        public PxrPosef pose;
    } 
    
    [StructLayout(LayoutKind.Sequential)]
    public struct XrSpatialEntityLocationData
    {
        public XrStructureType type;
        public IntPtr next;
        public XrSpaceLocationData location;
    }
    

    [StructLayout(LayoutKind.Sequential)]
    public struct XrSpatialEntityBoundingBox3DData
    {
        public XrStructureType type;
        public IntPtr next;
        public PxrBoxf box3D;
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct PxrBoxf
    {
        public PxrPosef center;
        public XrExtent3Df extents;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XrSpatialEntityBoundingBox2DData
    {
        public XrStructureType type;
        public IntPtr next;
        public PxrSceneBox2D box2D;
    }

    [StructLayout(LayoutKind.Sequential)]
    public struct XrSpatialEntityPolygonData
    {
        public XrStructureType type;
        public IntPtr next;
        public uint polygonCapacityInput;
        public uint polygonCountOutput;
        public IntPtr vertices; //PxrVector2f[]
    }
    [StructLayout(LayoutKind.Sequential)]
    public struct PxrTriangleMeshInfo
    {
        public XrStructureType type;
        public IntPtr next;
        public uint vertexCapacityInput;
        public uint vertexCountOutput;
        public IntPtr vertices;//PxrVector3f[];
        public uint indexCapacityInput;
        public uint indexCountOutput;
        public IntPtr indices;// uint16_t[]
    }
    public enum XrStructureType
    {
        XR_TYPE_UNKNOWN = 0,
        XR_TYPE_API_LAYER_PROPERTIES = 1,
        XR_TYPE_EXTENSION_PROPERTIES = 2,
        XR_TYPE_INSTANCE_CREATE_INFO = 3,
        XR_TYPE_SYSTEM_GET_INFO = 4,
        XR_TYPE_SYSTEM_PROPERTIES = 5,
        XR_TYPE_VIEW_LOCATE_INFO = 6,
        XR_TYPE_VIEW = 7,
        XR_TYPE_SESSION_CREATE_INFO = 8,
        XR_TYPE_SWAPCHAIN_CREATE_INFO = 9,
        XR_TYPE_SESSION_BEGIN_INFO = 10,
        XR_TYPE_VIEW_STATE = 11,
        XR_TYPE_FRAME_END_INFO = 12,
        XR_TYPE_HAPTIC_VIBRATION = 13,
        XR_TYPE_EVENT_DATA_BUFFER = 16,
        XR_TYPE_EVENT_DATA_INSTANCE_LOSS_PENDING = 17,
        XR_TYPE_EVENT_DATA_SESSION_STATE_CHANGED = 18,
        XR_TYPE_ACTION_STATE_BOOLEAN = 23,
        XR_TYPE_ACTION_STATE_FLOAT = 24,
        XR_TYPE_ACTION_STATE_VECTOR2F = 25,
        XR_TYPE_ACTION_STATE_POSE = 27,
        XR_TYPE_ACTION_SET_CREATE_INFO = 28,
        XR_TYPE_ACTION_CREATE_INFO = 29,
        XR_TYPE_INSTANCE_PROPERTIES = 32,
        XR_TYPE_FRAME_WAIT_INFO = 33,
        XR_TYPE_COMPOSITION_LAYER_PROJECTION = 35,
        XR_TYPE_COMPOSITION_LAYER_QUAD = 36,
        XR_TYPE_REFERENCE_SPACE_CREATE_INFO = 37,
        XR_TYPE_ACTION_SPACE_CREATE_INFO = 38,
        XR_TYPE_EVENT_DATA_REFERENCE_SPACE_CHANGE_PENDING = 40,
        XR_TYPE_VIEW_CONFIGURATION_VIEW = 41,
        XR_TYPE_SPACE_LOCATION = 42,
        XR_TYPE_SPACE_VELOCITY = 43,
        XR_TYPE_FRAME_STATE = 44,
        XR_TYPE_VIEW_CONFIGURATION_PROPERTIES = 45,
        XR_TYPE_FRAME_BEGIN_INFO = 46,
        XR_TYPE_COMPOSITION_LAYER_PROJECTION_VIEW = 48,
        XR_TYPE_EVENT_DATA_EVENTS_LOST = 49,
        XR_TYPE_INTERACTION_PROFILE_SUGGESTED_BINDING = 51,
        XR_TYPE_EVENT_DATA_INTERACTION_PROFILE_CHANGED = 52,
        XR_TYPE_INTERACTION_PROFILE_STATE = 53,
        XR_TYPE_SWAPCHAIN_IMAGE_ACQUIRE_INFO = 55,
        XR_TYPE_SWAPCHAIN_IMAGE_WAIT_INFO = 56,
        XR_TYPE_SWAPCHAIN_IMAGE_RELEASE_INFO = 57,
        XR_TYPE_ACTION_STATE_GET_INFO = 58,
        XR_TYPE_HAPTIC_ACTION_INFO = 59,
        XR_TYPE_SESSION_ACTION_SETS_ATTACH_INFO = 60,
        XR_TYPE_ACTIONS_SYNC_INFO = 61,
        XR_TYPE_BOUND_SOURCES_FOR_ACTION_ENUMERATE_INFO = 62,
        XR_TYPE_INPUT_SOURCE_LOCALIZED_NAME_GET_INFO = 63,
        XR_TYPE_SPACES_LOCATE_INFO = 1000471000,
        XR_TYPE_SPACE_LOCATIONS = 1000471001,
        XR_TYPE_SPACE_VELOCITIES = 1000471002,
        XR_TYPE_COMPOSITION_LAYER_CUBE_KHR = 1000006000,
        XR_TYPE_INSTANCE_CREATE_INFO_ANDROID_KHR = 1000008000,
        XR_TYPE_COMPOSITION_LAYER_DEPTH_INFO_KHR = 1000010000,
        XR_TYPE_VULKAN_SWAPCHAIN_FORMAT_LIST_CREATE_INFO_KHR = 1000014000,
        XR_TYPE_EVENT_DATA_PERF_SETTINGS_EXT = 1000015000,
        XR_TYPE_COMPOSITION_LAYER_CYLINDER_KHR = 1000017000,
        XR_TYPE_COMPOSITION_LAYER_EQUIRECT_KHR = 1000018000,
        XR_TYPE_DEBUG_UTILS_OBJECT_NAME_INFO_EXT = 1000019000,
        XR_TYPE_DEBUG_UTILS_MESSENGER_CALLBACK_DATA_EXT = 1000019001,
        XR_TYPE_DEBUG_UTILS_MESSENGER_CREATE_INFO_EXT = 1000019002,
        XR_TYPE_DEBUG_UTILS_LABEL_EXT = 1000019003,
        XR_TYPE_GRAPHICS_BINDING_OPENGL_WIN32_KHR = 1000023000,
        XR_TYPE_GRAPHICS_BINDING_OPENGL_XLIB_KHR = 1000023001,
        XR_TYPE_GRAPHICS_BINDING_OPENGL_XCB_KHR = 1000023002,
        XR_TYPE_GRAPHICS_BINDING_OPENGL_WAYLAND_KHR = 1000023003,
        XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_KHR = 1000023004,
        XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_KHR = 1000023005,
        XR_TYPE_GRAPHICS_BINDING_OPENGL_ES_ANDROID_KHR = 1000024001,
        XR_TYPE_SWAPCHAIN_IMAGE_OPENGL_ES_KHR = 1000024002,
        XR_TYPE_GRAPHICS_REQUIREMENTS_OPENGL_ES_KHR = 1000024003,
        XR_TYPE_GRAPHICS_BINDING_VULKAN_KHR = 1000025000,
        XR_TYPE_SWAPCHAIN_IMAGE_VULKAN_KHR = 1000025001,
        XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN_KHR = 1000025002,
        XR_TYPE_GRAPHICS_BINDING_D3D11_KHR = 1000027000,
        XR_TYPE_SWAPCHAIN_IMAGE_D3D11_KHR = 1000027001,
        XR_TYPE_GRAPHICS_REQUIREMENTS_D3D11_KHR = 1000027002,
        XR_TYPE_GRAPHICS_BINDING_D3D12_KHR = 1000028000,
        XR_TYPE_SWAPCHAIN_IMAGE_D3D12_KHR = 1000028001,
        XR_TYPE_GRAPHICS_REQUIREMENTS_D3D12_KHR = 1000028002,
        XR_TYPE_SYSTEM_EYE_GAZE_INTERACTION_PROPERTIES_EXT = 1000030000,
        XR_TYPE_EYE_GAZE_SAMPLE_TIME_EXT = 1000030001,
        XR_TYPE_VISIBILITY_MASK_KHR = 1000031000,
        XR_TYPE_EVENT_DATA_VISIBILITY_MASK_CHANGED_KHR = 1000031001,
        XR_TYPE_SESSION_CREATE_INFO_OVERLAY_EXTX = 1000033000,
        XR_TYPE_EVENT_DATA_MAIN_SESSION_VISIBILITY_CHANGED_EXTX = 1000033003,
        XR_TYPE_COMPOSITION_LAYER_COLOR_SCALE_BIAS_KHR = 1000034000,
        XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_MSFT = 1000039000,
        XR_TYPE_SPATIAL_ANCHOR_SPACE_CREATE_INFO_MSFT = 1000039001,
        XR_TYPE_COMPOSITION_LAYER_IMAGE_LAYOUT_FB = 1000040000,
        XR_TYPE_COMPOSITION_LAYER_ALPHA_BLEND_FB = 1000041001,
        XR_TYPE_VIEW_CONFIGURATION_DEPTH_RANGE_EXT = 1000046000,
        XR_TYPE_GRAPHICS_BINDING_EGL_MNDX = 1000048004,
        XR_TYPE_SPATIAL_GRAPH_NODE_SPACE_CREATE_INFO_MSFT = 1000049000,
        XR_TYPE_SPATIAL_GRAPH_STATIC_NODE_BINDING_CREATE_INFO_MSFT = 1000049001,
        XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_GET_INFO_MSFT = 1000049002,
        XR_TYPE_SPATIAL_GRAPH_NODE_BINDING_PROPERTIES_MSFT = 1000049003,
        XR_TYPE_SYSTEM_HAND_TRACKING_PROPERTIES_EXT = 1000051000,
        XR_TYPE_HAND_TRACKER_CREATE_INFO_EXT = 1000051001,
        XR_TYPE_HAND_JOINTS_LOCATE_INFO_EXT = 1000051002,
        XR_TYPE_HAND_JOINT_LOCATIONS_EXT = 1000051003,
        XR_TYPE_HAND_JOINT_VELOCITIES_EXT = 1000051004,
        XR_TYPE_SYSTEM_HAND_TRACKING_MESH_PROPERTIES_MSFT = 1000052000,
        XR_TYPE_HAND_MESH_SPACE_CREATE_INFO_MSFT = 1000052001,
        XR_TYPE_HAND_MESH_UPDATE_INFO_MSFT = 1000052002,
        XR_TYPE_HAND_MESH_MSFT = 1000052003,
        XR_TYPE_HAND_POSE_TYPE_INFO_MSFT = 1000052004,
        XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SESSION_BEGIN_INFO_MSFT = 1000053000,
        XR_TYPE_SECONDARY_VIEW_CONFIGURATION_STATE_MSFT = 1000053001,
        XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_STATE_MSFT = 1000053002,
        XR_TYPE_SECONDARY_VIEW_CONFIGURATION_FRAME_END_INFO_MSFT = 1000053003,
        XR_TYPE_SECONDARY_VIEW_CONFIGURATION_LAYER_INFO_MSFT = 1000053004,
        XR_TYPE_SECONDARY_VIEW_CONFIGURATION_SWAPCHAIN_CREATE_INFO_MSFT = 1000053005,
        XR_TYPE_CONTROLLER_MODEL_KEY_STATE_MSFT = 1000055000,
        XR_TYPE_CONTROLLER_MODEL_NODE_PROPERTIES_MSFT = 1000055001,
        XR_TYPE_CONTROLLER_MODEL_PROPERTIES_MSFT = 1000055002,
        XR_TYPE_CONTROLLER_MODEL_NODE_STATE_MSFT = 1000055003,
        XR_TYPE_CONTROLLER_MODEL_STATE_MSFT = 1000055004,
        XR_TYPE_VIEW_CONFIGURATION_VIEW_FOV_EPIC = 1000059000,
        XR_TYPE_HOLOGRAPHIC_WINDOW_ATTACHMENT_MSFT = 1000063000,
        XR_TYPE_COMPOSITION_LAYER_REPROJECTION_INFO_MSFT = 1000066000,
        XR_TYPE_COMPOSITION_LAYER_REPROJECTION_PLANE_OVERRIDE_MSFT = 1000066001,
        XR_TYPE_ANDROID_SURFACE_SWAPCHAIN_CREATE_INFO_FB = 1000070000,
        XR_TYPE_COMPOSITION_LAYER_SECURE_CONTENT_FB = 1000072000,
        XR_TYPE_BODY_TRACKER_CREATE_INFO_FB = 1000076001,
        XR_TYPE_BODY_JOINTS_LOCATE_INFO_FB = 1000076002,
        XR_TYPE_SYSTEM_BODY_TRACKING_PROPERTIES_FB = 1000076004,
        XR_TYPE_BODY_JOINT_LOCATIONS_FB = 1000076005,
        XR_TYPE_BODY_SKELETON_FB = 1000076006,
        XR_TYPE_INTERACTION_PROFILE_DPAD_BINDING_EXT = 1000078000,
        XR_TYPE_INTERACTION_PROFILE_ANALOG_THRESHOLD_VALVE = 1000079000,
        XR_TYPE_HAND_JOINTS_MOTION_RANGE_INFO_EXT = 1000080000,
        XR_TYPE_LOADER_INIT_INFO_ANDROID_KHR = 1000089000,
        XR_TYPE_VULKAN_INSTANCE_CREATE_INFO_KHR = 1000090000,
        XR_TYPE_VULKAN_DEVICE_CREATE_INFO_KHR = 1000090001,
        XR_TYPE_VULKAN_GRAPHICS_DEVICE_GET_INFO_KHR = 1000090003,
        XR_TYPE_COMPOSITION_LAYER_EQUIRECT2_KHR = 1000091000,
        XR_TYPE_SCENE_OBSERVER_CREATE_INFO_MSFT = 1000097000,
        XR_TYPE_SCENE_CREATE_INFO_MSFT = 1000097001,
        XR_TYPE_NEW_SCENE_COMPUTE_INFO_MSFT = 1000097002,
        XR_TYPE_VISUAL_MESH_COMPUTE_LOD_INFO_MSFT = 1000097003,
        XR_TYPE_SCENE_COMPONENTS_MSFT = 1000097004,
        XR_TYPE_SCENE_COMPONENTS_GET_INFO_MSFT = 1000097005,
        XR_TYPE_SCENE_COMPONENT_LOCATIONS_MSFT = 1000097006,
        XR_TYPE_SCENE_COMPONENTS_LOCATE_INFO_MSFT = 1000097007,
        XR_TYPE_SCENE_OBJECTS_MSFT = 1000097008,
        XR_TYPE_SCENE_COMPONENT_PARENT_FILTER_INFO_MSFT = 1000097009,
        XR_TYPE_SCENE_OBJECT_TYPES_FILTER_INFO_MSFT = 1000097010,
        XR_TYPE_SCENE_PLANES_MSFT = 1000097011,
        XR_TYPE_SCENE_PLANE_ALIGNMENT_FILTER_INFO_MSFT = 1000097012,
        XR_TYPE_SCENE_MESHES_MSFT = 1000097013,
        XR_TYPE_SCENE_MESH_BUFFERS_GET_INFO_MSFT = 1000097014,
        XR_TYPE_SCENE_MESH_BUFFERS_MSFT = 1000097015,
        XR_TYPE_SCENE_MESH_VERTEX_BUFFER_MSFT = 1000097016,
        XR_TYPE_SCENE_MESH_INDICES_UINT32_MSFT = 1000097017,
        XR_TYPE_SCENE_MESH_INDICES_UINT16_MSFT = 1000097018,
        XR_TYPE_SERIALIZED_SCENE_FRAGMENT_DATA_GET_INFO_MSFT = 1000098000,
        XR_TYPE_SCENE_DESERIALIZE_INFO_MSFT = 1000098001,
        XR_TYPE_EVENT_DATA_DISPLAY_REFRESH_RATE_CHANGED_FB = 1000101000,
        XR_TYPE_VIVE_TRACKER_PATHS_HTCX = 1000103000,
        XR_TYPE_EVENT_DATA_VIVE_TRACKER_CONNECTED_HTCX = 1000103001,
        XR_TYPE_SYSTEM_FACIAL_TRACKING_PROPERTIES_HTC = 1000104000,
        XR_TYPE_FACIAL_TRACKER_CREATE_INFO_HTC = 1000104001,
        XR_TYPE_FACIAL_EXPRESSIONS_HTC = 1000104002,
        XR_TYPE_SYSTEM_COLOR_SPACE_PROPERTIES_FB = 1000108000,
        XR_TYPE_HAND_TRACKING_MESH_FB = 1000110001,
        XR_TYPE_HAND_TRACKING_SCALE_FB = 1000110003,
        XR_TYPE_HAND_TRACKING_AIM_STATE_FB = 1000111001,
        XR_TYPE_HAND_TRACKING_CAPSULES_STATE_FB = 1000112000,
        XR_TYPE_SYSTEM_SPATIAL_ENTITY_PROPERTIES_FB = 1000113004,
        XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_FB = 1000113003,
        XR_TYPE_SPACE_COMPONENT_STATUS_SET_INFO_FB = 1000113007,
        XR_TYPE_SPACE_COMPONENT_STATUS_FB = 1000113001,
        XR_TYPE_EVENT_DATA_SPATIAL_ANCHOR_CREATE_COMPLETE_FB = 1000113005,
        XR_TYPE_EVENT_DATA_SPACE_SET_STATUS_COMPLETE_FB = 1000113006,
        XR_TYPE_FOVEATION_PROFILE_CREATE_INFO_FB = 1000114000,
        XR_TYPE_SWAPCHAIN_CREATE_INFO_FOVEATION_FB = 1000114001,
        XR_TYPE_SWAPCHAIN_STATE_FOVEATION_FB = 1000114002,
        XR_TYPE_FOVEATION_LEVEL_PROFILE_CREATE_INFO_FB = 1000115000,
        XR_TYPE_KEYBOARD_SPACE_CREATE_INFO_FB = 1000116009,
        XR_TYPE_KEYBOARD_TRACKING_QUERY_FB = 1000116004,
        XR_TYPE_SYSTEM_KEYBOARD_TRACKING_PROPERTIES_FB = 1000116002,
        XR_TYPE_TRIANGLE_MESH_CREATE_INFO_FB = 1000117001,
        XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES_FB = 1000118000,
        XR_TYPE_PASSTHROUGH_CREATE_INFO_FB = 1000118001,
        XR_TYPE_PASSTHROUGH_LAYER_CREATE_INFO_FB = 1000118002,
        XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_FB = 1000118003,
        XR_TYPE_GEOMETRY_INSTANCE_CREATE_INFO_FB = 1000118004,
        XR_TYPE_GEOMETRY_INSTANCE_TRANSFORM_FB = 1000118005,
        XR_TYPE_SYSTEM_PASSTHROUGH_PROPERTIES2_FB = 1000118006,
        XR_TYPE_PASSTHROUGH_STYLE_FB = 1000118020,
        XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_RGBA_FB = 1000118021,
        XR_TYPE_PASSTHROUGH_COLOR_MAP_MONO_TO_MONO_FB = 1000118022,
        XR_TYPE_PASSTHROUGH_BRIGHTNESS_CONTRAST_SATURATION_FB = 1000118023,
        XR_TYPE_EVENT_DATA_PASSTHROUGH_STATE_CHANGED_FB = 1000118030,
        XR_TYPE_RENDER_MODEL_PATH_INFO_FB = 1000119000,
        XR_TYPE_RENDER_MODEL_PROPERTIES_FB = 1000119001,
        XR_TYPE_RENDER_MODEL_BUFFER_FB = 1000119002,
        XR_TYPE_RENDER_MODEL_LOAD_INFO_FB = 1000119003,
        XR_TYPE_SYSTEM_RENDER_MODEL_PROPERTIES_FB = 1000119004,
        XR_TYPE_RENDER_MODEL_CAPABILITIES_REQUEST_FB = 1000119005,
        XR_TYPE_BINDING_MODIFICATIONS_KHR = 1000120000,
        XR_TYPE_VIEW_LOCATE_FOVEATED_RENDERING_VARJO = 1000121000,
        XR_TYPE_FOVEATED_VIEW_CONFIGURATION_VIEW_VARJO = 1000121001,
        XR_TYPE_SYSTEM_FOVEATED_RENDERING_PROPERTIES_VARJO = 1000121002,
        XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_VARJO = 1000122000,
        XR_TYPE_SYSTEM_MARKER_TRACKING_PROPERTIES_VARJO = 1000124000,
        XR_TYPE_EVENT_DATA_MARKER_TRACKING_UPDATE_VARJO = 1000124001,
        XR_TYPE_MARKER_SPACE_CREATE_INFO_VARJO = 1000124002,
        XR_TYPE_FRAME_END_INFO_ML = 1000135000,
        XR_TYPE_GLOBAL_DIMMER_FRAME_END_INFO_ML = 1000136000,
        XR_TYPE_COORDINATE_SPACE_CREATE_INFO_ML = 1000137000,
        XR_TYPE_SYSTEM_MARKER_UNDERSTANDING_PROPERTIES_ML = 1000138000,
        XR_TYPE_MARKER_DETECTOR_CREATE_INFO_ML = 1000138001,
        XR_TYPE_MARKER_DETECTOR_ARUCO_INFO_ML = 1000138002,
        XR_TYPE_MARKER_DETECTOR_SIZE_INFO_ML = 1000138003,
        XR_TYPE_MARKER_DETECTOR_APRIL_TAG_INFO_ML = 1000138004,
        XR_TYPE_MARKER_DETECTOR_CUSTOM_PROFILE_INFO_ML = 1000138005,
        XR_TYPE_MARKER_DETECTOR_SNAPSHOT_INFO_ML = 1000138006,
        XR_TYPE_MARKER_DETECTOR_STATE_ML = 1000138007,
        XR_TYPE_MARKER_SPACE_CREATE_INFO_ML = 1000138008,
        XR_TYPE_LOCALIZATION_MAP_ML = 1000139000,
        XR_TYPE_EVENT_DATA_LOCALIZATION_CHANGED_ML = 1000139001,
        XR_TYPE_MAP_LOCALIZATION_REQUEST_INFO_ML = 1000139002,
        XR_TYPE_LOCALIZATION_MAP_IMPORT_INFO_ML = 1000139003,
        XR_TYPE_LOCALIZATION_ENABLE_EVENTS_INFO_ML = 1000139004,
        XR_TYPE_EVENT_DATA_HEADSET_FIT_CHANGED_ML = 1000472000,
        XR_TYPE_EVENT_DATA_EYE_CALIBRATION_CHANGED_ML = 1000472001,
        XR_TYPE_USER_CALIBRATION_ENABLE_EVENTS_INFO_ML = 1000472002,
        XR_TYPE_SPATIAL_ANCHOR_PERSISTENCE_INFO_MSFT = 1000142000,
        XR_TYPE_SPATIAL_ANCHOR_FROM_PERSISTED_ANCHOR_CREATE_INFO_MSFT = 1000142001,
        XR_TYPE_SCENE_MARKERS_MSFT = 1000147000,
        XR_TYPE_SCENE_MARKER_TYPE_FILTER_MSFT = 1000147001,
        XR_TYPE_SCENE_MARKER_QR_CODES_MSFT = 1000147002,
        XR_TYPE_SPACE_QUERY_INFO_FB = 1000156001,
        XR_TYPE_SPACE_QUERY_RESULTS_FB = 1000156002,
        XR_TYPE_SPACE_STORAGE_LOCATION_FILTER_INFO_FB = 1000156003,
        XR_TYPE_SPACE_UUID_FILTER_INFO_FB = 1000156054,
        XR_TYPE_SPACE_COMPONENT_FILTER_INFO_FB = 1000156052,
        XR_TYPE_EVENT_DATA_SPACE_QUERY_RESULTS_AVAILABLE_FB = 1000156103,
        XR_TYPE_EVENT_DATA_SPACE_QUERY_COMPLETE_FB = 1000156104,
        XR_TYPE_SPACE_SAVE_INFO_FB = 1000158000,
        XR_TYPE_SPACE_ERASE_INFO_FB = 1000158001,
        XR_TYPE_EVENT_DATA_SPACE_SAVE_COMPLETE_FB = 1000158106,
        XR_TYPE_EVENT_DATA_SPACE_ERASE_COMPLETE_FB = 1000158107,
        XR_TYPE_SWAPCHAIN_IMAGE_FOVEATION_VULKAN_FB = 1000160000,
        XR_TYPE_SWAPCHAIN_STATE_ANDROID_SURFACE_DIMENSIONS_FB = 1000161000,
        XR_TYPE_SWAPCHAIN_STATE_SAMPLER_OPENGL_ES_FB = 1000162000,
        XR_TYPE_SWAPCHAIN_STATE_SAMPLER_VULKAN_FB = 1000163000,
        XR_TYPE_SPACE_SHARE_INFO_FB = 1000169001,
        XR_TYPE_EVENT_DATA_SPACE_SHARE_COMPLETE_FB = 1000169002,
        XR_TYPE_COMPOSITION_LAYER_SPACE_WARP_INFO_FB = 1000171000,
        XR_TYPE_SYSTEM_SPACE_WARP_PROPERTIES_FB = 1000171001,
        XR_TYPE_HAPTIC_AMPLITUDE_ENVELOPE_VIBRATION_FB = 1000173001,
        XR_TYPE_SEMANTIC_LABELS_FB = 1000175000,
        XR_TYPE_ROOM_LAYOUT_FB = 1000175001,
        XR_TYPE_BOUNDARY_2D_FB = 1000175002,
        XR_TYPE_SEMANTIC_LABELS_SUPPORT_INFO_FB = 1000175010,
        XR_TYPE_DIGITAL_LENS_CONTROL_ALMALENCE = 1000196000,
        XR_TYPE_EVENT_DATA_SCENE_CAPTURE_COMPLETE_FB = 1000198001,
        XR_TYPE_SCENE_CAPTURE_REQUEST_INFO_FB = 1000198050,
        XR_TYPE_SPACE_CONTAINER_FB = 1000199000,
        XR_TYPE_FOVEATION_EYE_TRACKED_PROFILE_CREATE_INFO_META = 1000200000,
        XR_TYPE_FOVEATION_EYE_TRACKED_STATE_META = 1000200001,
        XR_TYPE_SYSTEM_FOVEATION_EYE_TRACKED_PROPERTIES_META = 1000200002,
        XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES_FB = 1000201004,
        XR_TYPE_FACE_TRACKER_CREATE_INFO_FB = 1000201005,
        XR_TYPE_FACE_EXPRESSION_INFO_FB = 1000201002,
        XR_TYPE_FACE_EXPRESSION_WEIGHTS_FB = 1000201006,
        XR_TYPE_EYE_TRACKER_CREATE_INFO_FB = 1000202001,
        XR_TYPE_EYE_GAZES_INFO_FB = 1000202002,
        XR_TYPE_EYE_GAZES_FB = 1000202003,
        XR_TYPE_SYSTEM_EYE_TRACKING_PROPERTIES_FB = 1000202004,
        XR_TYPE_PASSTHROUGH_KEYBOARD_HANDS_INTENSITY_FB = 1000203002,
        XR_TYPE_COMPOSITION_LAYER_SETTINGS_FB = 1000204000,
        XR_TYPE_HAPTIC_PCM_VIBRATION_FB = 1000209001,
        XR_TYPE_DEVICE_PCM_SAMPLE_RATE_STATE_FB = 1000209002,
        XR_TYPE_COMPOSITION_LAYER_DEPTH_TEST_FB = 1000212000,
        XR_TYPE_LOCAL_DIMMING_FRAME_END_INFO_META = 1000216000,
        XR_TYPE_PASSTHROUGH_PREFERENCES_META = 1000217000,
        XR_TYPE_SYSTEM_VIRTUAL_KEYBOARD_PROPERTIES_META = 1000219001,
        XR_TYPE_VIRTUAL_KEYBOARD_CREATE_INFO_META = 1000219002,
        XR_TYPE_VIRTUAL_KEYBOARD_SPACE_CREATE_INFO_META = 1000219003,
        XR_TYPE_VIRTUAL_KEYBOARD_LOCATION_INFO_META = 1000219004,
        XR_TYPE_VIRTUAL_KEYBOARD_MODEL_VISIBILITY_SET_INFO_META = 1000219005,
        XR_TYPE_VIRTUAL_KEYBOARD_ANIMATION_STATE_META = 1000219006,
        XR_TYPE_VIRTUAL_KEYBOARD_MODEL_ANIMATION_STATES_META = 1000219007,
        XR_TYPE_VIRTUAL_KEYBOARD_TEXTURE_DATA_META = 1000219009,
        XR_TYPE_VIRTUAL_KEYBOARD_INPUT_INFO_META = 1000219010,
        XR_TYPE_VIRTUAL_KEYBOARD_TEXT_CONTEXT_CHANGE_INFO_META = 1000219011,
        XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_COMMIT_TEXT_META = 1000219014,
        XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_BACKSPACE_META = 1000219015,
        XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_ENTER_META = 1000219016,
        XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_SHOWN_META = 1000219017,
        XR_TYPE_EVENT_DATA_VIRTUAL_KEYBOARD_HIDDEN_META = 1000219018,
        XR_TYPE_EXTERNAL_CAMERA_OCULUS = 1000226000,
        XR_TYPE_VULKAN_SWAPCHAIN_CREATE_INFO_META = 1000227000,
        XR_TYPE_PERFORMANCE_METRICS_STATE_META = 1000232001,
        XR_TYPE_PERFORMANCE_METRICS_COUNTER_META = 1000232002,
        XR_TYPE_SPACE_LIST_SAVE_INFO_FB = 1000238000,
        XR_TYPE_EVENT_DATA_SPACE_LIST_SAVE_COMPLETE_FB = 1000238001,
        XR_TYPE_SPACE_USER_CREATE_INFO_FB = 1000241001,
        XR_TYPE_SYSTEM_HEADSET_ID_PROPERTIES_META = 1000245000,
        XR_TYPE_RECOMMENDED_LAYER_RESOLUTION_META = 1000254000,
        XR_TYPE_RECOMMENDED_LAYER_RESOLUTION_GET_INFO_META = 1000254001,
        XR_TYPE_SYSTEM_PASSTHROUGH_COLOR_LUT_PROPERTIES_META = 1000266000,
        XR_TYPE_PASSTHROUGH_COLOR_LUT_CREATE_INFO_META = 1000266001,
        XR_TYPE_PASSTHROUGH_COLOR_LUT_UPDATE_INFO_META = 1000266002,
        XR_TYPE_PASSTHROUGH_COLOR_MAP_LUT_META = 1000266100,
        XR_TYPE_PASSTHROUGH_COLOR_MAP_INTERPOLATED_LUT_META = 1000266101,
        XR_TYPE_SPACE_TRIANGLE_MESH_GET_INFO_META = 1000269001,
        XR_TYPE_SPACE_TRIANGLE_MESH_META = 1000269002,
        XR_TYPE_SYSTEM_FACE_TRACKING_PROPERTIES2_FB = 1000287013,
        XR_TYPE_FACE_TRACKER_CREATE_INFO2_FB = 1000287014,
        XR_TYPE_FACE_EXPRESSION_INFO2_FB = 1000287015,
        XR_TYPE_FACE_EXPRESSION_WEIGHTS2_FB = 1000287016,
        XR_TYPE_ENVIRONMENT_DEPTH_PROVIDER_CREATE_INFO_META = 1000291000,
        XR_TYPE_ENVIRONMENT_DEPTH_SWAPCHAIN_CREATE_INFO_META = 1000291001,
        XR_TYPE_ENVIRONMENT_DEPTH_SWAPCHAIN_STATE_META = 1000291002,
        XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_ACQUIRE_INFO_META = 1000291003,
        XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_VIEW_META = 1000291004,
        XR_TYPE_ENVIRONMENT_DEPTH_IMAGE_META = 1000291005,
        XR_TYPE_ENVIRONMENT_DEPTH_HAND_REMOVAL_SET_INFO_META = 1000291006,
        XR_TYPE_SYSTEM_ENVIRONMENT_DEPTH_PROPERTIES_META = 1000291007,
        XR_TYPE_PASSTHROUGH_CREATE_INFO_HTC = 1000317001,
        XR_TYPE_PASSTHROUGH_COLOR_HTC = 1000317002,
        XR_TYPE_PASSTHROUGH_MESH_TRANSFORM_INFO_HTC = 1000317003,
        XR_TYPE_COMPOSITION_LAYER_PASSTHROUGH_HTC = 1000317004,
        XR_TYPE_FOVEATION_APPLY_INFO_HTC = 1000318000,
        XR_TYPE_FOVEATION_DYNAMIC_MODE_INFO_HTC = 1000318001,
        XR_TYPE_FOVEATION_CUSTOM_MODE_INFO_HTC = 1000318002,
        XR_TYPE_SYSTEM_ANCHOR_PROPERTIES_HTC = 1000319000,
        XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO_HTC = 1000319001,
        XR_TYPE_ACTIVE_ACTION_SET_PRIORITIES_EXT = 1000373000,
        XR_TYPE_SYSTEM_FORCE_FEEDBACK_CURL_PROPERTIES_MNDX = 1000375000,
        XR_TYPE_FORCE_FEEDBACK_CURL_APPLY_LOCATIONS_MNDX = 1000375001,
        XR_TYPE_HAND_TRACKING_DATA_SOURCE_INFO_EXT = 1000428000,
        XR_TYPE_HAND_TRACKING_DATA_SOURCE_STATE_EXT = 1000428001,
        XR_TYPE_PLANE_DETECTOR_CREATE_INFO_EXT = 1000429001,
        XR_TYPE_PLANE_DETECTOR_BEGIN_INFO_EXT = 1000429002,
        XR_TYPE_PLANE_DETECTOR_GET_INFO_EXT = 1000429003,
        XR_TYPE_PLANE_DETECTOR_LOCATIONS_EXT = 1000429004,
        XR_TYPE_PLANE_DETECTOR_LOCATION_EXT = 1000429005,
        XR_TYPE_PLANE_DETECTOR_POLYGON_BUFFER_EXT = 1000429006,
        XR_TYPE_SYSTEM_PLANE_DETECTION_PROPERTIES_EXT = 1000429007,
        XR_TYPE_FUTURE_CANCEL_INFO_EXT = 1000469000,
        XR_TYPE_FUTURE_POLL_INFO_EXT = 1000469001,
        XR_TYPE_FUTURE_COMPLETION_EXT = 1000469002,
        XR_TYPE_FUTURE_POLL_RESULT_EXT = 1000469003,
        XR_TYPE_EVENT_DATA_USER_PRESENCE_CHANGED_EXT = 1000470000,
        XR_TYPE_SYSTEM_USER_PRESENCE_PROPERTIES_EXT = 1000470001,
        XR_TYPE_GRAPHICS_BINDING_VULKAN2_KHR = XR_TYPE_GRAPHICS_BINDING_VULKAN_KHR,
        XR_TYPE_SWAPCHAIN_IMAGE_VULKAN2_KHR = XR_TYPE_SWAPCHAIN_IMAGE_VULKAN_KHR,
        XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN2_KHR = XR_TYPE_GRAPHICS_REQUIREMENTS_VULKAN_KHR,
        XR_TYPE_DEVICE_PCM_SAMPLE_RATE_GET_INFO_FB = XR_TYPE_DEVICE_PCM_SAMPLE_RATE_STATE_FB,
        XR_TYPE_SPACES_LOCATE_INFO_KHR = XR_TYPE_SPACES_LOCATE_INFO,
        XR_TYPE_SPACE_LOCATIONS_KHR = XR_TYPE_SPACE_LOCATIONS,
        XR_TYPE_SPACE_VELOCITIES_KHR = XR_TYPE_SPACE_VELOCITIES,

        //pico system
        XR_TYPE_EVENT_CONTROLLER_STATE_CHANGED_PICO = 1200006064,
        XR_TYPE_EVENT_SEETHROUGH_STATE_CHANGED = 1200006065,
        XR_TYPE_EVENT_KEY_EVENT = 1200006067,
        XR_TYPE_EVENT_MRC_STATUS_CHANGED = 1200006072,
        XR_TYPE_EVENT_LOG_LEVEL_CHANGE = 1200006086,

        //motiontracking
        XR_TYPE_EVENT_MOTION_TRACKING_MDOE_CHANGED_EVENT_BD = 1200006403,
        XR_TYPE_EVENT_MOTION_TRACKER_KEY_EVENT_BD = 1200006404,
        XR_TYPE_EVENT_EXT_DEV_CONNECT_STATE_EVENT_BD = 1200006405,
        XR_TYPE_EVENT_EXT_DEV_BATTERY_STATE_EVENT_BD = 1200006406,
        XR_TYPE_EVENT_EXT_DEV_PASS_DATA_EVENT_BD = 1200006407,
        
        //MR
        XR_TYPE_SPATIAL_ENTITY_LOCATION_GET_INFO = 1200389002,
        XR_TYPE_SPATIAL_ENTITY_LOCATION_DATA = 1200389003,
        XR_TYPE_SPATIAL_ENTITY_SEMANTIC_GET_INFO = 1200389004,
        XR_TYPE_SPATIAL_ENTITY_SEMANTIC_DATA = 1200389005,
        XR_TYPE_SPATIAL_ENTITY_BOUNDING_BOX_2D_GET_INFO = 1200389006,
        XR_TYPE_SPATIAL_ENTITY_BOUNDING_BOX_2D_DATA = 1200389007,
        XR_TYPE_SPATIAL_ENTITY_POLYGON_GET_INFO = 1200389008,
        XR_TYPE_SPATIAL_ENTITY_POLYGON_DATA = 1200389009,
        XR_TYPE_SPATIAL_ENTITY_BOUNDING_BOX_3D_GET_INFO = 1200389010,
        XR_TYPE_SPATIAL_ENTITY_BOUNDING_BOX_3D_DATA = 1200389011,
        XR_TYPE_SPATIAL_ENTITY_TRIANGLE_MESH_GET_INFO = 1200389012,
        XR_TYPE_SPATIAL_ENTITY_TRIANGLE_MESH_DATA = 1200389013,
        XR_TYPE_SENSE_DATA_PROVIDER_START_COMPLETION = 1200389014,
        XR_TYPE_EVENT_DATA_SENSE_DATA_PROVIDER_STATE_CHANGED = 1200389015,
        XR_TYPE_SENSE_DATA_FILTER_UUID = 1200389016,
        XR_TYPE_SENSE_DATA_FILTER_SEMANTIC = 1200389017,
        XR_TYPE_SENSE_DATA_QUERY_INFO = 1200389018,
        XR_TYPE_SENSE_DATA_QUERY_COMPLETION = 1200389019,
        XR_TYPE_QUERIED_SENSE_DATA_GET_INFO = 1200389020,
        XR_TYPE_EVENT_DATA_SENSE_DATA_UPDATED = 1200389023,
        XR_TYPE_SPATIAL_ENTITY_ANCHOR_RETRIEVE_INFO = 1200389025,
        XR_TYPE_SENSE_DATA_PROVIDER_CREATE_INFO_SPATIAL_ANCHOR = 1200390001,
        XR_TYPE_SPATIAL_ANCHOR_CREATE_INFO  = 1200390002,
        XR_TYPE_SPATIAL_ANCHOR_CREATE_COMPLETION  = 1200390003,
        XR_TYPE_SPATIAL_ANCHOR_PERSIST_INFO  = 1200390004,
        XR_TYPE_SPATIAL_ANCHOR_PERSIST_COMPLETION  = 1200390005,
        XR_TYPE_SPATIAL_ANCHOR_UNPERSIST_INFO  = 1200390006,
        XR_TYPE_SPATIAL_ANCHOR_UNPERSIST_COMPLETION  = 1200390007,
        XR_TYPE_SCENE_CAPTURE_START_COMPLETION = 1200392002,
        XR_TYPE_SENSE_DATA_PROVIDER_CREATE_INFO_SCENE_CAPTURE = 1200392003,
        XR_TYPE_SENSE_DATA_PROVIDER_CREATE_INFO_SPATIAL_MESH = 1200393001,
        XR_TYPE_SENSE_DATA_PROVIDER_CREATE_INFO_AUTO_SCENE_CAPTURE = 1200394001,
        XR_TYPE_SENSE_DATA_PROVIDER_CREATE_INFO_SEMI_AUTO_SCENE_CAPTURE = 1200395001,


        XR_STRUCTURE_TYPE_MAX_ENUM = 0x7FFFFFFF
    } 
    
    public enum XrDeviceEventType
    {
        XR_DEVICE_CONNECTCHANGED = 0,
        XR_DEVICE_MAIN_CHANGED = 1,
        XR_DEVICE_VERSION = 2,
        XR_DEVICE_SN = 3,
        XR_DEVICE_BIND_STATUS = 4,
        XR_STATION_STATUS = 5,
        XR_DEVICE_IOBUSY = 6,
        XR_DEVICE_OTASTAUS = 7,
        XR_DEVICE_ID = 8,
        XR_DEVICE_OTASATAION_PROGRESS = 9,
        XR_DEVICE_OTASATAION_CODE = 10,
        XR_DEVICE_OTACONTROLLER_PROGRESS = 11,
        XR_DEVICE_OTACONTROLLER_CODE = 12,
        XR_DEVICE_OTA_SUCCESS = 13,
        XR_DEVICE_BLEMAC = 14,
        XR_DEVICE_HANDNESS_CHANGED = 15,
        XR_DEVICE_CHANNEL = 16,
        XR_DEVICE_LOSSRATE = 17,
        XR_DEVICE_THREAD_STARTED = 18,
        XR_DEVICE_MENUPRESSED_STATE =19,
        XR_DEVICE_HANDTRACKING_SETTING = 20,
        XR_DEVICE_INPUTDEVICE_CHANGED = 21,
        XR_DEVICE_SYSTEMGESTURE_STATE = 22,
        XR_DEVICE_FITNESSBAND_STATE = 23,
        XR_DEVICE_FITNESSBAND_BATTERY = 24,
        XR_DEVICE_BODYTRACKING_STATE_ERROR_CODE = 25,
        XR_DEVICE_BODYTRACKING_ACTION = 26
    }
}