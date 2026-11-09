using UnityEngine;

namespace Rilisoft.PushNotifications
{
    public sealed class PushNotificationHandler : MonoBehaviour
    {
        // Fields
        private readonly System.Collections.Generic.List<System.Func<bool>> 丕业丝丅丛丞一丈世;
        private bool 三与专与丐丟丗丏一;
        private static Rilisoft.PushNotifications.PushNotificationHandler <不丁丄七丛不丆丁丕>k__BackingField;
        private bool <丞丕丈一三丏七丒丈>k__BackingField;
        private bool <丌东七七业丁丌一万>k__BackingField;
        
        // Properties
        internal static Rilisoft.PushNotifications.PushNotificationHandler 丆丕丝丒不丙且丐丗 { get; set; }
        public bool 丞专丗丞世丂丝丈丒 { get; set; }
        internal bool 世丝丛丟业世丂上上 { get; set; }
        
        // Methods
        private PushNotificationHandler()
        {
            this.丕业丝丅丛丞一丈世 = new System.Collections.Generic.List<System.Func<System.Boolean>>();
            this.丕业丝丅丛丞一丈世.Add(item:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean Rilisoft.PushNotifications.PushNotificationHandler::专丕上丝三丅丆丌丁()));
            this.丕业丝丅丛丞一丈世.Add(item:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean Rilisoft.PushNotifications.PushNotificationHandler::丑且丐丝丛丆丅丈上()));
            this.丕业丝丅丛丞一丈世.Add(item:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean Rilisoft.PushNotifications.PushNotificationHandler::七丆上丅业丅上三丝()));
            this.丕业丝丅丛丞一丈世.Add(item:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean Rilisoft.PushNotifications.PushNotificationHandler::丕丌丒丁世下业丈七()));
            this.丕业丝丅丛丞一丈世.Add(item:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean Rilisoft.PushNotifications.PushNotificationHandler::三东丞业丞且专万专()));
            this.丕业丝丅丛丞一丈世.Add(item:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean Rilisoft.PushNotifications.PushNotificationHandler::丒丌丅丙丄世万丈丕()));
            this.丕业丝丅丛丞一丈世.Add(item:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean Rilisoft.PushNotifications.PushNotificationHandler::与丄专下专丈丑丆与()));
            this.丕业丝丅丛丞一丈世.Add(item:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean Rilisoft.PushNotifications.PushNotificationHandler::丁丒七丞丗丑丂一丝()));
            this.丕业丝丅丛丞一丈世.Add(item:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean Rilisoft.PushNotifications.PushNotificationHandler::上七一业上丐三丌上()));
            this.丕业丝丅丛丞一丈世.Add(item:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean Rilisoft.PushNotifications.PushNotificationHandler::丐丐丛业一丟丄上七()));
            this.丕业丝丅丛丞一丈世.Add(item:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean Rilisoft.PushNotifications.PushNotificationHandler::丕丂丅专丗丟丐且丘()));
            this.丕业丝丅丛丞一丈世.Add(item:  new System.Func<System.Boolean>(object:  this, method:  System.Boolean Rilisoft.PushNotifications.PushNotificationHandler::丌世丐业下专丞不且()));
        }
        internal static Rilisoft.PushNotifications.PushNotificationHandler 丑七不且上丗丁一世()
        {
            return (Rilisoft.PushNotifications.PushNotificationHandler)Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(Rilisoft.PushNotifications.PushNotificationHandler 丙业与丙丗丝不丈东)
        {
            Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_Active()
        {
            return (bool)this.<丞丕丈一三丏七丒丈>k__BackingField;
        }
        private void 上三万丐一与上丆丐(bool 丙业与丙丗丝不丈东)
        {
            this.<丞丕丈一三丏七丒丈>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal bool 万七丂一丂丄上丁丟()
        {
            return (bool)this.<丌东七七业丁丌一万>k__BackingField;
        }
        private void 丝业丑丂丒专丛一且(bool 丙业与丙丗丝不丈东)
        {
            this.<丌东七七业丁丌一万>k__BackingField = 丙业与丙丗丝不丈东;
        }
        private void Awake()
        {
            Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField = this;
            UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
            MainMenuController.丄丈丝丕世丕且东丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void Rilisoft.PushNotifications.PushNotificationHandler::丌丘丙三丛丗万丁丏()));
            this.三与专与丐丟丗丏一 = false;
        }
        private void 丌丘丙三丛丗万丁丏()
        {
            this.<丌东七七业丁丌一万>k__BackingField = true;
        }
        private void Update()
        {
            var val_4;
            System.Func<System.Func<System.Boolean>, System.Boolean> val_6;
            if((this.<丞丕丈一三丏七丒丈>k__BackingField) == false)
            {
                    return;
            }
            
            if(this.丛丐丟下丁丒丗丈一() == false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            val_6 = PushNotificationHandler.<>c.<>9__17_0;
            if(val_6 == null)
            {
                    System.Func<System.Func<System.Boolean>, System.Boolean> val_2 = null;
                val_6 = val_2;
                val_2 = new System.Func<System.Func<System.Boolean>, System.Boolean>(object:  PushNotificationHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean PushNotificationHandler.<>c::丑丕丛丅丐丝万丒丝(System.Func<bool> 丏丕丅一一与下丑丏));
                PushNotificationHandler.<>c.<>9__17_0 = val_6;
            }
            
            bool val_3 = System.Linq.Enumerable.Any<System.Func<System.Boolean>>(source:  this.丕业丝丅丛丞一丈世, predicate:  val_2);
            if(this.三与专与丐丟丗丏一 != true)
            {
                    this.<丞丕丈一三丏七丒丈>k__BackingField = false;
            }
            
            this.三与专与丐丟丗丏一 = true;
        }
        private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
        {
            if(东丗七丕丄不丐专丒 == false)
            {
                    return;
            }
            
            this.三与专与丐丟丗丏一 = false;
        }
        public void Activate(bool 东丅丞丁丗万且丁丗)
        {
            if(this.三与专与丐丟丗丏一 != false)
            {
                    return;
            }
            
            this.<丞丕丈一三丏七丒丈>k__BackingField = 东丅丞丁丗万且丁丗;
        }
        private bool 丛丐丟下丁丒丗丈一()
        {
            var val_3;
            if(MainMenuController.丈一丏一丂丟三且丌() != false)
            {
                    var val_2 = ((this.<丌东七七业丁丌一万>k__BackingField) == true) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        private bool 专丕上丝三丅丆丌丁()
        {
            var val_11;
            var val_12;
            var val_13;
            string val_8 = 0;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[PushNotificationHandler] [CheckClanSquadPush()]");
            }
            
            val_12 = null;
            if(Rilisoft.PushNotifications.下丝丛三与专丄东丐.东专世且丈下下丒丘() == false)
            {
                goto label_14;
            }
            
            val_11 = Rilisoft.Singleton<ClansController>.Instance;
            if(val_11.丞丗丑丈一丅丗丌丟() == null)
            {
                goto label_8;
            }
            
            val_11 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁();
            bool val_9 = Rilisoft.PushNotifications.下丝丛三与专丄东丐.丐丝与丁七万丝东丑(丅一丞万丑专丅丅与: out  val_8);
            bool val_10 = val_11.Equals(value:  val_8);
            if(val_10 == false)
            {
                goto label_14;
            }
            
            label_8:
            val_10.丐下丐世丁丞丞丞专();
            val_13 = 1;
            return (bool)val_13;
            label_14:
            val_13 = 0;
            return (bool)val_13;
        }
        private bool 丑且丐丝丛丆丅丈上()
        {
            int val_11;
            var val_12;
            var val_13;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[PushNotificationHandler] [CheckClanWarSquadPush()]");
            }
            
            val_12 = null;
            if(Rilisoft.PushNotifications.下丝丛三与专丄东丐.丕一且丞业一丞丂丝() == false)
            {
                goto label_14;
            }
            
            val_11 = System.String.alignConst;
            int val_8 = val_11;
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
            {
                goto label_8;
            }
            
            bool val_9 = Rilisoft.PushNotifications.下丝丛三与专丄东丐.丐丝与丁七万丝东丑(丅一丞万丑专丅丅与: out  val_8);
            val_11 = val_8;
            bool val_10 = val_11.StartsWith(value:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁());
            if(val_10 == false)
            {
                goto label_14;
            }
            
            label_8:
            val_10.丟丕一业丘丛三万业(丅一丞万丑专丅丅与:  val_11);
            val_13 = 1;
            return (bool)val_13;
            label_14:
            val_13 = 0;
            return (bool)val_13;
        }
        private bool 七丆上丅业丅上三丝()
        {
            int val_11;
            var val_12;
            var val_13;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[PushNotificationHandler] [CheckClanWarTestModeSquadPush()]");
            }
            
            val_12 = null;
            if(Rilisoft.PushNotifications.下丝丛三与专丄东丐.丑与丘下丈丁丏上专() == false)
            {
                goto label_14;
            }
            
            val_11 = System.String.alignConst;
            int val_8 = val_11;
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
            {
                goto label_8;
            }
            
            bool val_9 = Rilisoft.PushNotifications.下丝丛三与专丄东丐.丐丝与丁七万丝东丑(丅一丞万丑专丅丅与: out  val_8);
            val_11 = val_8;
            bool val_10 = val_11.StartsWith(value:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁());
            if(val_10 == false)
            {
                goto label_14;
            }
            
            label_8:
            val_10.七丌与丙丕丕丆七丂(丅一丞万丑专丅丅与:  val_11);
            val_13 = 1;
            return (bool)val_13;
            label_14:
            val_13 = 0;
            return (bool)val_13;
        }
        private bool 丕丌丒丁世下业丈七()
        {
            var val_5;
            var val_6;
            string val_3 = 0;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[PushNotificationHandler] [CheckSquadPush()]");
            }
            
            val_5 = null;
            if(Rilisoft.PushNotifications.下丝丛三与专丄东丐.下丒丝丗东丄上丆丛() != false)
            {
                    bool val_4 = Rilisoft.PushNotifications.下丝丛三与专丄东丐.丐丝与丁七万丝东丑(丅一丞万丑专丅丅与: out  val_3);
                if(val_4 != false)
            {
                    val_4.下丄丑三专下丛丛丒(丅一丞万丑专丅丅与:  val_3);
                val_6 = 1;
                return (bool)val_6;
            }
            
            }
            
            val_6 = 0;
            return (bool)val_6;
        }
        private void 丐下丐世丁丞丞丞专()
        {
            ClansWindowGUI val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            if(ConnectToClanSiegeButton.专丈业丑万丆丟世丗() == false)
            {
                    return;
            }
            
            if(ConnectToClanSiegeButton.丟东七丕专丙丈丘丂() == false)
            {
                    return;
            }
            
            val_8 = null;
            val_8 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_9 = null;
                val_9 = null;
                if(activeInHierarchy != false)
            {
                    val_10 = null;
                val_10 = null;
                MainMenuController.丄丞丁丈与业上丞丟.EnterClanSiege();
                return;
            }
            
            }
            
            val_11 = null;
            val_11 = null;
            val_7 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
            if(val_7 == 0)
            {
                    return;
            }
            
            val_12 = null;
            val_12 = null;
            val_7 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
            if(val_7.InterfaceEnabled == false)
            {
                    return;
            }
            
            val_13 = null;
            val_13 = null;
            ClansWindowGUI.丆丕丝丒不丙且丐丗.EnterSiegeMode();
        }
        private void 丟丕一业丘丛三万业(string 丅一丞万丑专丅丅与)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            if(ConnectToClanWarButton.专丈业丑万丆丟世丗() == false)
            {
                    return;
            }
            
            if(ConnectToClanWarButton.丟东七丕专丙丈丘丂() == false)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_8 = null;
                val_8 = null;
                if(activeInHierarchy != false)
            {
                    val_9 = null;
                val_9 = null;
                SquadController.丄丘七三上丕世丞业.专万且业丕专丐丗一(丅一丞万丑专丅丅与:  丅一丞万丑专丅丅与);
                val_10 = null;
                val_10 = null;
                MainMenuController.丄丞丁丈与业上丞丟.EnterClanWar();
                return;
            }
            
            }
            
            val_11 = null;
            val_11 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            val_12 = null;
            val_12 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == false)
            {
                    return;
            }
            
            val_13 = null;
            val_13 = null;
            SquadController.丄丘七三上丕世丞业.专万且业丕专丐丗一(丅一丞万丑专丅丅与:  丅一丞万丑专丅丅与);
            val_14 = null;
            val_14 = null;
            ClansWindowGUI.丆丕丝丒不丙且丐丗.EnterClanWarMode();
        }
        private void 七丌与丙丕丕丆七丂(string 丅一丞万丑专丅丅与)
        {
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            if(PGCompany.ConnectToClanWarTestButton.专丈业丑万丆丟世丗() == false)
            {
                    return;
            }
            
            if(PGCompany.ConnectToClanWarTestButton.丟东七丕专丙丈丘丂() == false)
            {
                    return;
            }
            
            val_7 = null;
            val_7 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_8 = null;
                val_8 = null;
                if(activeInHierarchy != false)
            {
                    val_9 = null;
                val_9 = null;
                SquadController.丄丘七三上丕世丞业.专万且业丕专丐丗一(丅一丞万丑专丅丅与:  丅一丞万丑专丅丅与);
                val_10 = null;
                val_10 = null;
                MainMenuController.丄丞丁丈与业上丞丟.EnterClanWarTestMode();
                return;
            }
            
            }
            
            val_11 = null;
            val_11 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            val_12 = null;
            val_12 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == false)
            {
                    return;
            }
            
            val_13 = null;
            val_13 = null;
            SquadController.丄丘七三上丕世丞业.专万且业丕专丐丗一(丅一丞万丑专丅丅与:  丅一丞万丑专丅丅与);
            val_14 = null;
            val_14 = null;
            ClansWindowGUI.丆丕丝丒不丙且丐丗.EnterClanWarTestMode();
        }
        private void 下丄丑三专下丛丛丒(string 丅一丞万丑专丅丅与)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            if(ConnectToSquadButton.专丈业丑万丆丟世丗() == false)
            {
                    return;
            }
            
            if(ConnectToSquadButton.丟东七丕专丙丈丘丂() == false)
            {
                    return;
            }
            
            val_13 = null;
            val_13 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                    val_14 = null;
                val_14 = null;
                if(activeInHierarchy != false)
            {
                    val_15 = null;
                val_15 = null;
                MainMenuController.丄丞丁丈与业上丞丟.JoinToSquadPoint(丅一丞万丑专丅丅与:  丅一丞万丑专丅丅与);
                return;
            }
            
            }
            
            val_16 = static_value_081DACA8;
            val_16 = static_value_081DACA8;
            if((static_value_081DACA8 + 184 + 16) != 0)
            {
                    val_17 = static_value_081DACA8;
                val_17 = static_value_081DACA8;
                if((static_value_081DACA8 + 184 + 16 + 64.gameObject.activeInHierarchy) != false)
            {
                    val_18 = static_value_081DACA8;
                val_18 = static_value_081DACA8;
                static_value_081DACA8 + 184 + 16.丌丐丒丞且丌丒丂丛(丅一丞万丑专丅丅与:  丅一丞万丑专丅丅与);
                return;
            }
            
            }
            
            if(ChooseMiniGameController.丄丞丁丈与业上丞丟 != 0)
            {
                    if(ChooseMiniGameController.丄丞丁丈与业上丞丟.gameObject.activeInHierarchy != false)
            {
                    ChooseMiniGameController.丄丞丁丈与业上丞丟.JoinToSquadPoint(丅一丞万丑专丅丅与:  丅一丞万丑专丅丅与);
                return;
            }
            
            }
            
            val_19 = null;
            val_19 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
            {
                    return;
            }
            
            val_20 = null;
            val_20 = null;
            if(ClansWindowGUI.丆丕丝丒不丙且丐丗.InterfaceEnabled == false)
            {
                    return;
            }
            
            val_21 = null;
            val_21 = null;
            val_22 = null;
            val_22 = null;
            ClansWindowGUI.丆丕丝丒不丙且丐丗.JoinToSquadPoint(丙不丅丝丙专丕世丐:  MainMenuController.丄丞丁丈与业上丞丟.丝丆业上世丅丞且丙, 丅一丞万丑专丅丅与:  丅一丞万丑专丅丅与);
        }
        private bool 上七一业上丐三丌上()
        {
            var val_15;
            bool val_16;
            bool val_17;
            MainMenuController val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            Machinery.StateMachine<PGCompany.Ads.AdvertisingChestWindowMachinery.丄丄一丐东丐丝丗七, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丕丗与丁丁业丄上, PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆> val_6 = 0;
            val_15 = null;
            val_16 = Rilisoft.PushNotifications.下丝丛三与专丄东丐.丛丗七一丙万与丁且();
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != false)
            {
                    UnityEngine.Debug.Log(message:  "[PushNotificationHandler.CheckIsEggReadyPush] eggIsReady: "("[PushNotificationHandler.CheckIsEggReadyPush] eggIsReady: ") + val_16.ToString());
                val_17 = val_16;
            }
            
            if(val_17 != false)
            {
                    if((PGCompany.Ads.丙丘丄东专东三不丑.丑七不且上丗丁一世().丅丙一业丂丐丐丟不(丅丟丛丙下丙丄丒丁: out  val_6)) != false)
            {
                    val_18 = val_6;
                PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 val_8 = val_18.CurrentState;
            }
            
                if((PGCompany.Ads.丙丘丄东专东三不丑.丑七不且上丗丁一世().丗丄丈丙世丘下专丘(丅丟丛丙下丙丄丒丁: out  val_6)) != false)
            {
                    val_18 = val_6;
                PGCompany.Ads.AdvertisingChestWindowMachinery.丙丟与丐三丐万万丆 val_11 = val_18.CurrentState;
            }
            
                val_19 = null;
                val_19 = null;
                val_18 = MainMenuController.丄丞丁丈与业上丞丟;
                if(val_18 != 0)
            {
                    val_20 = null;
                val_20 = null;
                val_18 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
                val_18 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
                if(activeInHierarchy != false)
            {
                    val_21 = null;
                val_21 = null;
                val_18 = MainMenuController.丄丞丁丈与业上丞丟;
                val_18.与东丒业丈丒丛世万(丑丝丏丂且不下一东:  0, 一专七丟丏且丑丄下:  48, 丝丗丙丞丙丕万业下:  0, 万且丟七不上丗丑丝:  false);
            }
            
            }
            
                val_22 = 1;
                return (bool)val_22;
            }
            
            val_22 = 0;
            return (bool)val_22;
        }
        private bool 与丄专下专丈丑丆与()
        {
            MainMenuController val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[PushNotificationHandler] CheckIsEggReadyPush");
            }
            
            val_6 = null;
            if(Rilisoft.PushNotifications.下丝丛三与专丄东丐.丒丆丁三丆丘三上丐() != false)
            {
                    val_7 = null;
                val_7 = null;
                val_5 = MainMenuController.丄丞丁丈与业上丞丟;
                if(val_5 != 0)
            {
                    val_8 = null;
                val_8 = null;
                val_5 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
                val_5 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
                if(activeInHierarchy != false)
            {
                    val_9 = null;
                val_9 = null;
                val_5 = MainMenuController.丄丞丁丈与业上丞丟;
                val_5.HandleClansClickedCore(三丂东专丕专业丏万:  false);
            }
            
            }
            
                val_10 = 1;
                return (bool)val_10;
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        private bool 丒丌丅丙丄世万丈丕()
        {
            MainMenuController val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            var val_30;
            var val_31;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[PushNotificationHandler] CheckBattlePassUpdated");
            }
            
            if(FriendsController.丝丗专上三不丄丑丑() < 1)
            {
                goto label_48;
            }
            
            val_23 = null;
            if(Rilisoft.PushNotifications.下丝丛三与专丄东丐.丛不业东丝丝业丛丛() == false)
            {
                goto label_48;
            }
            
            val_24 = null;
            val_24 = null;
            val_22 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_22 == 0)
            {
                goto label_48;
            }
            
            val_25 = null;
            val_25 = null;
            val_22 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
            val_22 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
            if(activeInHierarchy == false)
            {
                goto label_48;
            }
            
            val_22 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝();
            if(val_22 == null)
            {
                    return (bool)val_26;
            }
            
            if((val_22.专丁丟丏丁丏不丗三() == false) || (val_22.丗丄上丑丑丅丐丒丌() == true))
            {
                goto label_48;
            }
            
            val_22 = BattlePassRootUI.丑七不且上丗丁一世();
            if(val_22 != 0)
            {
                goto label_48;
            }
            
            val_27 = null;
            val_27 = null;
            val_22 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
            if(val_22 == 0)
            {
                goto label_33;
            }
            
            val_28 = null;
            val_28 = null;
            val_22 = ClansWindowGUI.丆丕丝丒不丙且丐丗;
            if(val_22.InterfaceEnabled == true)
            {
                goto label_48;
            }
            
            label_33:
            UnityEngine.SceneManagement.Scene val_14 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if((System.String.op_Equality(a:  val_14.m_Handle.name, b:  "FortFieldBuild")) != true)
            {
                    if((System.String.op_Equality(a:  val_14.m_Handle.name, b:  "ClanTankBuild")) == false)
            {
                goto label_39;
            }
            
            }
            
            label_48:
            val_26 = 0;
            return (bool)val_26;
            label_39:
            val_29 = null;
            val_29 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                goto label_44;
            }
            
            val_30 = null;
            val_30 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟.与丙七丞丞不丒丙丘() == true)
            {
                goto label_48;
            }
            
            label_44:
            val_31 = null;
            val_31 = null;
            SetActive(value:  false);
            BattlePassRootUI.丆丛丏且丌丂丝丛丌(丙业与丙丗丝不丈东:  1);
            BattlePassRootUI.丂丑丌且丄丞丝七上 = 1;
            BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  31, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
            return (bool)val_26;
        }
        private bool 丐丐丛业一丟丄上七()
        {
            MainMenuController val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[PushNotificationHandler] [CheckIsLobbyCraftReadyPush()]");
            }
            
            val_6 = null;
            if(Rilisoft.PushNotifications.下丝丛三与专丄东丐.丈丘丌下且丟丌丕不() != false)
            {
                    val_7 = null;
                val_7 = null;
                val_5 = MainMenuController.丄丞丁丈与业上丞丟;
                if(val_5 != 0)
            {
                    val_8 = null;
                val_8 = null;
                val_5 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
                val_5 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
                if(activeInHierarchy != false)
            {
                    val_9 = null;
                val_9 = null;
                val_5 = MainMenuController.丄丞丁丈与业上丞丟;
                val_5.丄丒丂丈丁丂且丟丒(丁丛七丞丑一丌丞丆:  new System.Nullable<Rilisoft.LobbyItemGroupType>() {HasValue = false}, 世万丐专世丕业丟东:  0);
            }
            
            }
            
                val_10 = 1;
                return (bool)val_10;
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        private bool 丁丒七丞丗丑丂一丝()
        {
            MainMenuController val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[PushNotificationHandler] [CheckIsDailyRewardAvailablePush()]");
            }
            
            val_6 = null;
            if(Rilisoft.PushNotifications.下丝丛三与专丄东丐.丐丗丒且丂不且丄丁() != false)
            {
                    val_7 = null;
                val_7 = null;
                val_5 = MainMenuController.丄丞丁丈与业上丞丟;
                if(val_5 != 0)
            {
                    val_8 = null;
                val_8 = null;
                val_5 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
                val_5 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
                if(activeInHierarchy != false)
            {
                    val_9 = null;
                val_9 = null;
                val_5 = MainMenuController.丄丞丁丈与业上丞丟;
                val_5.OnClickMultiplyerButtonCore(三丂东专丕专业丏万:  false);
            }
            
            }
            
                val_10 = 1;
                return (bool)val_10;
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        private bool 丕丂丅专丗丟丐且丘()
        {
            MainMenuController val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            var val_11;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[PushNotificationHandler.CheckWeaponCraftAvailablePush]");
            }
            
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true)
            {
                    val_7 = null;
                if(Rilisoft.PushNotifications.下丝丛三与专丄东丐.丅专丞一丈丅丂与丛() != false)
            {
                    val_8 = null;
                val_8 = null;
                val_6 = MainMenuController.丄丞丁丈与业上丞丟;
                if(val_6 != 0)
            {
                    val_9 = null;
                val_9 = null;
                val_6 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
                val_6 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
                if(activeInHierarchy != false)
            {
                    val_10 = null;
                val_10 = null;
                val_6 = MainMenuController.丄丞丁丈与业上丞丟;
                val_6.与东丒业丈丒丛世万(丑丝丏丂且不下一东:  0, 一专七丟丏且丑丄下:  88, 丝丗丙丞丙丕万业下:  0, 万且丟七不上丗丑丝:  false);
            }
            
            }
            
                val_11 = 1;
                return (bool)val_11;
            }
            
            }
            
            val_11 = 0;
            return (bool)val_11;
        }
        private bool 三东丞业丞且专万专()
        {
            MainMenuController val_5;
            var val_6;
            var val_7;
            var val_8;
            var val_9;
            var val_10;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[PushNotificationHandler] [CheckAskedToOpenClanChestPush()]");
            }
            
            val_6 = null;
            if(Rilisoft.PushNotifications.下丝丛三与专丄东丐.丌一丑三丟丌七丙万() != false)
            {
                    val_7 = null;
                val_7 = null;
                val_5 = MainMenuController.丄丞丁丈与业上丞丟;
                if(val_5 != 0)
            {
                    val_8 = null;
                val_8 = null;
                val_5 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
                val_5 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
                if(activeInHierarchy != false)
            {
                    val_9 = null;
                val_9 = null;
                val_5 = MainMenuController.丄丞丁丈与业上丞丟;
                val_5.HandleClansClickedCore(三丂东专丕专业丏万:  false);
            }
            
            }
            
                val_10 = 1;
                return (bool)val_10;
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        private bool 丌世丐业下专丞不且()
        {
            MainMenuController val_8;
            var val_9;
            var val_10;
            var val_11;
            var val_12;
            var val_13;
            if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
            {
                    UnityEngine.Debug.Log(message:  "[PushNotificationHandler] [CheckChestWithModulesUnlocked()]");
            }
            
            val_9 = null;
            if(Rilisoft.PushNotifications.下丝丛三与专丄东丐.丝丙东丟与七丅丈专() != false)
            {
                    val_10 = null;
                val_10 = null;
                val_8 = MainMenuController.丄丞丁丈与业上丞丟;
                if(val_8 != 0)
            {
                    val_11 = null;
                val_11 = null;
                val_8 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
                val_8 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
                if(activeInHierarchy != false)
            {
                    PGCompany.三丘丌上丁万丏丛丟 val_5 = 丐东不丅丂丂丅丙不.丆万丂东东三世丄专();
                if(val_5 != null)
            {
                    val_12 = null;
                val_12 = null;
                val_8 = MainMenuController.丄丞丁丈与业上丞丟;
                val_8.与东丒业丈丒丛世万(丑丝丏丂且不下一东:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  PGCompany.万丞丘与丕丞下万丌.丂东丁上丛丗下下丆(下丅丙一丂丗丅丝七:  val_5), 七丆丒与丗丌丄且丂:  112), 一专七丟丏且丑丄下:  112, 丝丗丙丞丙丕万业下:  0, 万且丟七不上丗丑丝:  false);
            }
            
            }
            
            }
            
                val_13 = 1;
                return (bool)val_13;
            }
            
            val_13 = 0;
            return (bool)val_13;
        }
        internal static bool 丄丗丄丟丑丗与下不()
        {
            var val_5;
            string val_10;
            var val_11;
            List.Enumerator<T> val_3 = LocalNotification.丒丗丘东上丘丞丆与.丑七不且上丗丁一世().丑丘丒三丈丅专丄七().GetEnumerator();
            label_6:
            if((437379600 & 1) == 0)
            {
                goto label_3;
            }
            
            val_10 = val_5.丐丏七丌丕丗业且上();
            if((Rilisoft.PushNotifications.下丝丛三与专丄东丐.丗一丄不下丈丝丁专(下上丐丆丝丟丝丒不:  val_10)) == false)
            {
                goto label_6;
            }
            
            LocalNotification.丒丗丁且丌丏丛丞丟.丑七不且上丗丁一世().且上与世丙丗且东七(丞丅上丏丂且下丅与:  val_10);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_11 = 1;
            return (bool)val_11;
            label_3:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_10 = LocalNotification.丒丗丁且丌丏丛丞丟.丑七不且上丗丁一世();
            val_10.且上与世丙丗且东七(丞丅上丏丂且下丅与:  0);
            val_11 = 0;
            return (bool)val_11;
        }
    
    }

}
