﻿namespace GameMain
{
    /// <summary>
    /// 游戏入口。
    /// </summary>
    public partial class GameEntry
    {
        private static void InitCustomComponents()
        {
            Database = UnityGameFramework.Runtime.GameEntry.GetComponent<DatabaseComponent>();
            FairyGui = UnityGameFramework.Runtime.GameEntry.GetComponent<FairyGuiComponent>();
            Lua = UnityGameFramework.Runtime.GameEntry.GetComponent<LuaComponent>();
            AppConfig = UnityGameFramework.Runtime.GameEntry.GetComponent<AppConfigComponent>();
            Camera = UnityGameFramework.Runtime.GameEntry.GetComponent<CameraComponent>();
            Input = UnityGameFramework.Runtime.GameEntry.GetComponent<InputComponent>();
            Timer = UnityGameFramework.Runtime.GameEntry.GetComponent<TimerComponent>();
            BT = UnityGameFramework.Runtime.GameEntry.GetComponent<BehaviorTreeComponent>();
            Level = UnityGameFramework.Runtime.GameEntry.GetComponent<LevelComponent>();
            Coroutinue = UnityGameFramework.Runtime.GameEntry.GetComponent<CoroutinueComponent>();

            Database.Init();
            FairyGui.Init();
            Lua.Init();
            AppConfig.Init();
            Camera.Init();
            Input.Init();
            Timer.Init();
            BT.Init();
            Level.Init();
            Coroutinue.Init();
        }

        private static void ClearCustomComponents()
        {
            //Database.Clear();
            FairyGui.Clear();
            Lua.Clear();
            AppConfig.Clear();
            Camera.Clear();
            Input.Clear();
            Timer.Clear();
            BT.Clear();
            Level.Clear();
            Coroutinue.Clear();
        }

        public static DatabaseComponent Database
        {
            get;
            private set;
        }

        public static FairyGuiComponent FairyGui
        {
            get;
            private set;
        }

        public static AppConfigComponent AppConfig
        {
            get;
            private set;
        }

        public static LuaComponent Lua
        {
            get;
            private set;
        }

        public static CameraComponent Camera
        {
            get;
            private set;
        }

        public static InputComponent Input
        {
            get;
            private set;
        }

        public static BehaviorTreeComponent BT
        {
            get;
            private set;
        }

        public static TimerComponent Timer
        {
            get;
            protected set;
        }

        public static LevelComponent Level
        {
            get;
            protected set;
        }

        public static CoroutinueComponent Coroutinue
        {
            get;
            protected set;
        }
    }
}
