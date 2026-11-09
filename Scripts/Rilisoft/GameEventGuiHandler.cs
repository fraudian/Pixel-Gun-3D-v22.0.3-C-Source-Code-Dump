using UnityEngine;

namespace Rilisoft
{
    internal sealed class GameEventGuiHandler : BannerWindow, 丑且丆万丏丝丘丙丟
    {
        // Fields
        private static System.Action<Rilisoft.丛且世丐丆上七业丁> 业丙丘丈七不下下丐;
        internal static string 丞业业丄丁丒丛三上;
        private static Rilisoft.GameEventGuiHandler <不丁丄七丛不丆丁丕>k__BackingField;
        private static Rilisoft.AbstractGameEventGui <丝万丝丟丅丝一丒丟>k__BackingField;
        private System.Action 丏丐世且丑丅丘丅丟;
        private static bool 上丄丛丆世丄丞七丗;
        
        // Properties
        private static Rilisoft.GameEventGuiHandler 丆丕丝丒不丙且丐丗 { get; set; }
        internal static Rilisoft.AbstractGameEventGui 丁丌丏上丂丈一丘丂 { get; set; }
        internal static bool 东且丈丄丕丘东丁且 { get; }
        
        // Methods
        internal static void 万专丆且七丈业丅丁(System.Action<Rilisoft.丛且世丐丆上七业丁> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  Rilisoft.GameEventGuiHandler.业丙丘丈七不下下丐, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 丟丑丟丑丂丄丕丆丌(System.Action<Rilisoft.丛且世丐丆上七业丁> 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  Rilisoft.GameEventGuiHandler.业丙丘丈七不下下丐, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        private static Rilisoft.GameEventGuiHandler 丑七不且上丗丁一世()
        {
            null = null;
            return (Rilisoft.GameEventGuiHandler)Rilisoft.GameEventGuiHandler.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(Rilisoft.GameEventGuiHandler 丙业与丙丗丝不丈东)
        {
            null = null;
            Rilisoft.GameEventGuiHandler.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static Rilisoft.AbstractGameEventGui 丄丒且业不丟丙丈上()
        {
            null = null;
            return (Rilisoft.AbstractGameEventGui)Rilisoft.GameEventGuiHandler.<丝万丝丟丅丝一丒丟>k__BackingField;
        }
        private static void 丒丝丒丅丑丁丗万丈(Rilisoft.AbstractGameEventGui 丙业与丙丗丝不丈东)
        {
            null = null;
            Rilisoft.GameEventGuiHandler.<丝万丝丟丅丝一丒丟>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static bool 丄丏丂丘丌万世丛与()
        {
            null = null;
            return (bool)Rilisoft.GameEventGuiHandler.上丄丛丆世丄丞七丗;
        }
        internal static void 且丘丕不不七丕丝丁(bool 丙业与丙丗丝不丈东)
        {
            var val_4;
            var val_5;
            System.Action val_7;
            val_4 = null;
            val_4 = null;
            Rilisoft.GameEventGuiHandler.上丄丛丆世丄丞七丗 = 丙业与丙丗丝不丈东;
            if(丙业与丙丗丝不丈东 == false)
            {
                    return;
            }
            
            val_5 = null;
            val_5 = null;
            val_7 = GameEventGuiHandler.<>c.<>9__16_0;
            if(val_7 == null)
            {
                    System.Action val_2 = null;
                val_7 = val_2;
                val_2 = new System.Action(object:  GameEventGuiHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Void GameEventGuiHandler.<>c::上不与七丈丌丅丈丅());
                GameEventGuiHandler.<>c.<>9__16_0 = val_7;
            }
            
            UnityEngine.Coroutine val_3 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  val_2, 丆丐七丅丆丗丛上与:  4f);
        }
        internal static void 丞丙丗丁丙丏七专丑(string 丟丟丄专上丟丁丐丝, System.Nullable<UnityEngine.Vector3> 业万与下且万丕丈丑, bool 丈丈不丒丗与丝不丗 = False)
        {
            bool val_17;
            var val_18;
            var val_19;
            MainMenuController val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            val_17 = 丈丈不丒丗与丝不丗;
            val_18 = null;
            val_18 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_19 = null;
                val_19 = null;
                val_20 = MainMenuController.丄丞丁丈与业上丞丟;
                if(val_20.丂丙丈与世专上丒上() == true)
            {
                    return;
            }
            
            }
            
            val_20 = BannerWindowController.与丅与丒丅专丙丐丗();
            if((val_20.不且丝丆丈三与世东(丈丈不丒丗与丝不丗:  W3 & 1)) == true)
            {
                    return;
            }
            
            if(ClanWarUI.丈丐丞丐上丑且丕万() == true)
            {
                    return;
            }
            
            val_20 = 1152921505152585728;
            val_21 = null;
            val_21 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗 != 0)
            {
                    val_22 = null;
                val_22 = null;
                if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == true)
            {
                    return;
            }
            
            }
            
            UnityEngine.SceneManagement.Scene val_9 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if((System.String.op_Equality(a:  val_9.m_Handle.name, b:  "FortFieldBuild")) == true)
            {
                    return;
            }
            
            if((System.String.op_Equality(a:  val_9.m_Handle.name, b:  "ClanTankBuild")) == true)
            {
                    return;
            }
            
            val_23 = null;
            val_23 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_24 = null;
                val_24 = null;
                if(MainMenuController.丄丞丁丈与业上丞丟.与丙七丞丞不丒丙丘() == true)
            {
                    return;
            }
            
            }
            
            Rilisoft.GameEventGuiHandler.且丘丕不不七丕丝丁(丙业与丙丗丝不丈东:  true);
            Rilisoft.AbstractGameEventGui.丌丒丗丕专东丐上丗 = 业万与下且万丕丈丑.HasValue;
            Rilisoft.AbstractGameEventGui.丌丒丗丕专东丐上丗.__il2cppRuntimeField_8 = val_17;
            Rilisoft.GameEventGuiHandler.丞业业丄丁丒丛三上 = 丟丟丄专上丟丁丐丝;
            val_17 = BannerWindowController.与丅与丒丅专丙丐丗();
            val_17.ForceShowBanner(丌丅丕一丛丛丄一万:  25, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
        }
        internal static void 丝东丐丝东三丈世丝()
        {
            var val_11;
            if(Rilisoft.GameEventGuiHandler.丑七不且上丗丁一世() != 0)
            {
                    Rilisoft.GameEventGuiHandler.丑七不且上丗丁一世().万万丄丌与丐丘东三(世丌丒丌上丗丛丈丒:  25);
                if(Rilisoft.GameEventGuiHandler.丄丒且业不丟丙丈上() != 0)
            {
                    PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  Rilisoft.GameEventGuiHandler.丑七不且上丗丁一世());
            }
            
                Rilisoft.GameEventGuiHandler.且丘丕不不七丕丝丁(丙业与丙丗丝不丈东:  false);
                val_11 = Rilisoft.GameEventGuiHandler.丑七不且上丗丁一世();
                if(val_8.丏丐世且丑丅丘丅丟 == null)
            {
                    return;
            }
            
                Rilisoft.GameEventGuiHandler val_9 = Rilisoft.GameEventGuiHandler.丑七不且上丗丁一世();
                val_9.丏丐世且丑丅丘丅丟.Invoke();
                val_11 = Rilisoft.GameEventGuiHandler.丑七不且上丗丁一世();
                val_10.丏丐世且丑丅丘丅丟 = 0;
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "cant Back,Instance == null");
        }
        internal static void 丆三丘丅且东万与丘()
        {
            if(Rilisoft.GameEventGuiHandler.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            Rilisoft.GameEventGuiHandler.丑七不且上丗丁一世().万万丄丌与丐丘东三(世丌丒丌上丗丛丈丒:  25);
        }
        internal static void 丁一丂丌丟丙丞万七(System.Action 丏丐世且丑丅丘丅丟)
        {
            if(Rilisoft.GameEventGuiHandler.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            Rilisoft.GameEventGuiHandler val_3 = Rilisoft.GameEventGuiHandler.丑七不且上丗丁一世();
            val_3.丏丐世且丑丅丘丅丟 = 丏丐世且丑丅丘丅丟;
        }
        protected override void Awake()
        {
            this.Awake();
            Rilisoft.GameEventGuiHandler.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
        }
        public override void Show()
        {
            this.Show();
            PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  Rilisoft.GameEventGuiHandler.丑七不且上丗丁一世());
            this.世丞丒三丙丕七丗丆();
            Rilisoft.AbstractGameEventGui val_3 = Rilisoft.GameEventGuiHandler.丄丒且业不丟丙丈上();
            if(val_3 == null)
            {
                    return;
            }
            
            val_3.三上丞丅丗专丝东世();
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            this.丏丐世且丑丅丘丅丟 = 0;
        }
        private void 世丞丒三丙丕七丗丆()
        {
            var val_42;
            var val_43;
            var val_44;
            var val_45;
            val_42 = null;
            val_42 = null;
            Rilisoft.GameEventGuiHandler.丞业业丄丁丒丛三上 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  Rilisoft.GameEventGuiHandler.丞业业丄丁丒丛三上)) != false)
            {
                    UnityEngine.Debug.LogError(message:  "event id is null or empty");
                return;
            }
            
            if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丝上且七丕丒丙丂丆(丟丟丄专上丟丁丐丝:  Rilisoft.GameEventGuiHandler.丞业业丄丁丒丛三上)) == false)
            {
                goto label_11;
            }
            
            Rilisoft.丛且世丐丆上七业丁 val_5 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丟丟丄专上丟丁丐丝:  Rilisoft.GameEventGuiHandler.丞业业丄丁丒丛三上);
            if(Rilisoft.GameEventGuiHandler.丄丒且业不丟丙丈上() == 0)
            {
                goto label_19;
            }
            
            if((Rilisoft.GameEventGuiHandler.丄丒且业不丟丙丈上().Context == null) || (Rilisoft.GameEventGuiHandler.丄丒且业不丟丙丈上().Context.丁专丗万三上丟三丆() == null))
            {
                goto label_34;
            }
            
            Rilisoft.GameEventData val_15 = Rilisoft.GameEventGuiHandler.丄丒且业不丟丙丈上().Context.丁专丗万三上丟三丆();
            if((System.String.op_Equality(a:  val_15.EventId, b:  Rilisoft.GameEventGuiHandler.丞业业丄丁丒丛三上)) == false)
            {
                goto label_34;
            }
            
            Rilisoft.AbstractGameEventGui val_17 = Rilisoft.GameEventGuiHandler.丄丒且业不丟丙丈上();
            Rilisoft.丛且世丐丆上七业丁 val_19 = Rilisoft.GameEventGuiHandler.丄丒且业不丟丙丈上().Context;
            val_43 = PGCompany.业专丝丆与下丙丒丑.丑七不且上丗丁一世();
            val_43.一东丁世丆与丆万丌(丈七丄丆丅丂东丄一:  (Rilisoft.GameEventGuiHandler.丄丒且业不丟丙丈上().Context.不业丙丒丂丞下丆丙() == 100) ? (2 + 1) : 2);
            val_44 = null;
            val_44 = null;
            if(Rilisoft.GameEventGuiHandler.业丙丘丈七不下下丐 == null)
            {
                    return;
            }
            
            Rilisoft.GameEventGuiHandler.业丙丘丈七不下下丐.Invoke(obj:  val_5);
            return;
            label_11:
            object[] val_25 = new object[1];
            val_25[0] = Rilisoft.GameEventGuiHandler.丞业业丄丁丒丛三上;
            UnityEngine.Debug.LogErrorFormat(format:  "event with id \'{0}\' not found", args:  val_25);
            return;
            label_34:
            Rilisoft.AbstractGameEventGui val_26 = Rilisoft.GameEventGuiHandler.丄丒且业不丟丙丈上();
            Rilisoft.GameEventGuiHandler.丒丝丒丅丑丁丗万丈(丙业与丙丗丝不丈东:  0);
            label_19:
            UnityEngine.Transform val_27 = this.transform;
            Rilisoft.AbstractGameEventGui val_28 = GameEventsHalper.业一丁丙丏专下丟丗<Rilisoft.AbstractGameEventGui>(丅东专与不三丂丁丝:  val_5, 丒丘丏上丙丟丑丕丈:  "main", 丈东丘丏与丌东东下:  val_27, 丛下丅丏丄且丁一业:  false);
            if(val_28 == null)
            {
                goto label_54;
            }
            
            if(null != null)
            {
                goto label_56;
            }
            
            mem2[0] = GameEventsHalper.业一丁丙丏专下丟丗<Rilisoft.GameEventExtendedEventInfoView>(丅东专与不三丂丁丝:  val_5, 丒丘丏上丙丟丑丕丈:  "info", 丈东丘丏与丌东东下:  val_28.transform, 丛下丅丏丄且丁一业:  false);
            mem2[0] = GameEventsHalper.业一丁丙丏专下丟丗<Rilisoft.GameEventRewardView>(丅东专与不三丂丁丝:  val_5, 丒丘丏上丙丟丑丕丈:  "rewardview", 丈东丘丏与丌东东下:  val_28.transform, 丛下丅丏丄且丁一业:  false);
            goto label_56;
            label_54:
            label_56:
            int val_36 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_28.gameObject, 不东丛三丂丌丑专丆:  val_27.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_28, 丏业丟一东丂东丘丛:  true);
            Rilisoft.GameEventGuiHandler.丒丝丒丅丑丁丗万丈(丙业与丙丗丝不丈东:  val_28);
            val_43 = PGCompany.业专丝丆与下丙丒丑.丑七不且上丗丁一世();
            val_43.一东丁世丆与丆万丌(丈七丄丆丅丂东丄一:  (Rilisoft.GameEventGuiHandler.丄丒且业不丟丙丈上().Context.不业丙丒丂丞下丆丙() == 100) ? (2 + 1) : 2);
            val_45 = null;
            val_45 = null;
            if(Rilisoft.GameEventGuiHandler.业丙丘丈七不下下丐 == null)
            {
                    return;
            }
            
            Rilisoft.GameEventGuiHandler.业丙丘丈七不下下丐.Invoke(obj:  val_5);
        }
        public void TurnOn()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  Rilisoft.GameEventGuiHandler.丑七不且上丗丁一世(), 丏业丟一东丂东丘丛:  true);
        }
        public void TurnOff()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  Rilisoft.GameEventGuiHandler.丑七不且上丗丁一世(), 丏业丟一东丂东丘丛:  false);
        }
        public bool IsVisibleLobbyMenu()
        {
            return false;
        }
        public bool IsEnabledLobbyCamera()
        {
            return false;
        }
        public float GetDelayTurnOff()
        {
            var val_4 = null;
            Rilisoft.丛且世丐丆上七业丁 val_2 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丌丐东业专丑丘丑丗(丟丟丄专上丟丁丐丝:  Rilisoft.GameEventGuiHandler.丞业业丄丁丒丛三上);
            if(val_2 == null)
            {
                    return 0.5f;
            }
            
            if(val_2.不业丙丒丂丞下丆丙() == 100)
            {
                    return 0.5f;
            }
            
            return 0.5f;
        }
        public GameEventGuiHandler()
        {
        
        }
        private static GameEventGuiHandler()
        {
        
        }
    
    }

}
