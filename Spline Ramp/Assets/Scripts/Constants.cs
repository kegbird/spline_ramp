﻿using UnityEngine; 

namespace Assets.Scripts
{
    public static class Constants
    {
        public const int MAX_ORT_SIZE = 10;
        public const int MIN_ORT_SIZE = 3;
        public const float ZOOM_SPEED = 5f;
        public const float PAN_SPEED = 10f;
        public const float MOVE_SPEED = 10f;
        public const int ROTATION_PIVOT_INDEX = 0;
        public const float ACCELERATION_FACTOR = 0.1f;
        public const float ACCELERATION_TICK = 0.1f;
        public const float MAX_X_BOUNDARY = 0f;
        public const float RAMP_EDGE_RADIUS = 0.4f;
        public const float Y_KILL = -20f;
        public static int GOAL_LAYER_MASK= LayerMask.NameToLayer("Goal");
        public static int RAMP_LAYER_MASK= LayerMask.NameToLayer("Ramp");
        public static int ROTATION_GIZMO_LAYER_MASK= LayerMask.NameToLayer("RotationGizmo");
        public static int TRANSLATION_GIZMO_LAYER_MASK = LayerMask.NameToLayer("TranslationGizmo");
        public static int SUPPORT_NODE_LAYER_MASK = LayerMask.NameToLayer("SupportNode");
        public static int ARROW_LAYER_MASK = LayerMask.NameToLayer("Arrow");
        public static int COIN_LAYER_MASK = LayerMask.NameToLayer("Coin");
        public static int CURVE_STEPS = 20;
        public static float DERIVATIVE_MAGNITUDE = 5f;
        public static int BSPLINE_DEGREE = 3;
        public static int COIN_NUMBER = 3;
        public static int LEVEL_NUMBER = 6;
        public static int MENU_SCENE_INDEX = 8;
        public static float[] KNOTS_4 = { 0f, 0f, 0f, 1f, 2f, 2f, 2f, 2f};
        public static float[] KNOTS_5 = { 0f, 0f, 0f, 0f, 1f, 2f, 2f, 2f, 2f };
        public static float[] KNOTS_6 = { 0f, 0f, 0f, 0f, 1f, 2f, 3f, 3f, 3f, 3f };
    }
}
