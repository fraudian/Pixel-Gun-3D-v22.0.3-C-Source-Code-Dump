using UnityEngine;

namespace PGCompany.EventHub
{
    internal sealed class EventHubBanner : BannerWindow, 丑且丆万丏丝丘丙丟
    {
        // Fields
        private static PGCompany.EventHub.EventHubBanner <不丁丄七丛不丆丁丕>k__BackingField;
        private static PGCompany.EventHub.丄丟丐丂丌丆万丁丅 丙与丟丌丄专丕丗专;
        private static bool 丕丅世丐丝不丝丟丕;
        private static bool 丏万丝专丅丟七丛业;
        private System.IDisposable 丐丆七且丞丏下三丙;
        private PGCompany.丝丆业不一丌东万世 上丁丈丞丌且丞丈丄;
        private PGCompany.丝丆业不一丌东万世 世七上三丌与丝丌丘;
        private PGCompany.EventHub.丄世丌东丏三东丒丂 丁丐丆东上不世万专;
        private System.Collections.Generic.Dictionary<string, PGCompany.EventHubPresentation> 上七与丁丟丅一下丐;
        private PGCompany.EventHub.EventHubView _view;
        private UnityEngine.GameObject _eventHubContainer;
        private UnityEngine.GameObject _eventPresentationContainer;
        internal static bool 上丟丐上丏丒丞一丒;
        
        // Properties
        internal static PGCompany.EventHub.EventHubBanner 丆丕丝丒不丙且丐丗 { get; set; }
        internal bool 丘三丄丂丝丅且丁世 { get; }
        internal static bool 丕丆三丆丕不三业丒 { get; }
        internal static bool 丞不丗丄丞丘丛丙东 { get; }
        
        // Methods
        internal static PGCompany.EventHub.EventHubBanner 丑七不且上丗丁一世()
        {
            null = null;
            return (PGCompany.EventHub.EventHubBanner)PGCompany.EventHub.EventHubBanner.<不丁丄七丛不丆丁丕>k__BackingField;
        }
        private static void 丒且丒丗丗丟下丗丝(PGCompany.EventHub.EventHubBanner 丙业与丙丗丝不丈东)
        {
            null = null;
            PGCompany.EventHub.EventHubBanner.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal bool 上丒丆丗东与丄世下()
        {
            if(this._eventHubContainer != null)
            {
                    return this._eventHubContainer.activeInHierarchy;
            }
            
            return this._eventHubContainer.activeInHierarchy;
        }
        internal static bool 丂东下不丆专丌丈丆()
        {
            var val_11;
            MainMenuController val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            val_11 = null;
            val_11 = null;
            val_12 = MainMenuController.丄丞丁丈与业上丞丟;
            if(val_12 != 0)
            {
                    val_13 = null;
                val_13 = null;
                val_12 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
                val_12 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
                if(activeInHierarchy != false)
            {
                    val_14 = null;
                val_14 = null;
                val_12 = MainMenuController.丄丞丁丈与业上丞丟;
                if(val_12.丂丙丈与世专上丒上() != true)
            {
                    val_15 = null;
                val_15 = null;
                val_12 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 24];
                val_12 = MainMenuController.丄丞丁丈与业上丞丟 + 24;
                if(val_12.activeInHierarchy != true)
            {
                    val_16 = null;
                val_16 = null;
                val_12 = MainMenuController.丄丞丁丈与业上丞丟;
                if((val_12.IsOpeningFriends != true) && (MainStoreView.丈丐丞丐上丑且丕万() != true))
            {
                    val_12 = Rilisoft.Singleton<ClansVisitController>.Instance;
                if(val_7.丕丁不丅丒丑丁丁世 != true)
            {
                    val_17 = null;
                val_17 = null;
                if(MainMenuController.与丝与丄三丅下丒七 == 9990000)
            {
                    InfoWindowController val_8 = InfoWindowController.丑七不且上丗丁一世();
                val_12 = val_8.competitionConnectWindow;
                val_18 = val_12.丙东丞丛丝丅世七三() ^ 1;
                return (bool)val_18 & 1;
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            }
            
            val_18 = 0;
            return (bool)val_18 & 1;
        }
        internal static bool 丁七下丌丏丄丟上三()
        {
            return PGCompany.EventHub.EventHubBanner.丟三七丗世丕丞丛丁(丙丆丞且丒丐丕丛东:  true);
        }
        internal static bool 丟三七丗世丕丞丛丁(bool 丙丆丞且丒丐丕丛东)
        {
            var val_11;
            System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘> val_13;
            PGCompany.EventHub.丄丟丐丂丌丆万丁丅 val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            if((PGCompany.Banners.丗丘丆一世丁丙丝且.世丌丕丏丒丌一丒丄(世丁丌万丏丟丗世三:  11)) == false)
            {
                goto label_32;
            }
            
            val_11 = null;
            val_11 = null;
            if(PGCompany.EventHub.EventHubBanner.丏万丝专丅丟七丛业 != true)
            {
                    PGCompany.EventHub.EventHubBanner.丏万丝专丅丟七丛业 = true;
                System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘> val_3 = null;
                val_13 = val_3;
                val_3 = new System.EventHandler<PGCompany.丏专丆丒丏丗丞丐丘>(object:  0, method:  static System.Void PGCompany.EventHub.EventHubBanner::丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且));
                PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丗丈下上丙下七丙下(丙业与丙丗丝不丈东:  val_3);
                val_11 = null;
            }
            
            PGCompany.EventHub.EventHubBanner.专与丏丒专丙丙三丅();
            val_14 = PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专;
            if(val_14 == null)
            {
                goto label_32;
            }
            
            val_14 = PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专;
            if(val_14 == null)
            {
                goto label_15;
            }
            
            if((PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专.<丗丏万与丘丁丛与丐>k__BackingField) > ExperienceController.丞丞丘业东丙丏七丌())
            {
                goto label_32;
            }
            
            val_15 = null;
            val_15 = null;
            if(PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专.丕丝丒不东丅与丟丐() == true)
            {
                goto label_32;
            }
            
            val_16 = null;
            val_16 = null;
            if((PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专.业世东丟七丈东且丂() == true) || (与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true))
            {
                goto label_32;
            }
            
            val_17 = null;
            val_17 = null;
            if(丅与专与丘丛万丘与.万七一丝不世丒丈丙 == true)
            {
                goto label_32;
            }
            
            val_13 = 1152921505080860672;
            val_18 = null;
            val_18 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 != 0)
            {
                goto label_37;
            }
            
            label_32:
            var val_11 = 0;
            label_42:
            val_11 = val_11 & 1;
            return (bool)val_11;
            label_37:
            val_19 = null;
            val_19 = null;
            if((MainMenuController.丄丞丁丈与业上丞丟.丌世世万不上丝丆三() == false) || (丙丆丞且丒丐丕丛东 == false))
            {
                goto label_42;
            }
            
            PGCompany.业专丝丆与下丙丒丑 val_10 = PGCompany.业专丝丆与下丙丒丑.丑七不且上丗丁一世();
            if(val_10 != null)
            {
                    return val_10.丂丐丆丈一专丗丄三();
            }
            
            return val_10.丂丐丆丈一专丗丄三();
            label_15:
        }
        protected override void OnEnable()
        {
            this.OnEnable();
            PGCompany.EventHub.EventHubBanner.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
        }
        protected override void OnDisable()
        {
            PGCompany.EventHub.EventHubBanner.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  0);
            this.OnDisable();
        }
        private static void 专与丏丒专丙丙三丅()
        {
            System.Collections.Generic.IEnumerable<TSource> val_8;
            var val_9;
            var val_10;
            var val_12;
            System.Func<PGCompany.EventHub.丄丟丐丂丌丆万丁丅, System.Boolean> val_14;
            var val_15;
            var val_16;
            val_9 = null;
            val_9 = null;
            if(PGCompany.EventHub.EventHubBanner.丕丅世丐丝不丝丟丕 == true)
            {
                    return;
            }
            
            string val_2 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  105);
            val_10 = public System.Collections.Generic.List<PGCompany.EventHub.丄丟丐丂丌丆万丁丅> DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<System.Collections.Generic.List<PGCompany.EventHub.丄丟丐丂丌丆万丁丅>>(string 丞丕丒专一下丙业上);
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_8 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            if(val_8 != null)
            {
                    val_12 = null;
                val_12 = null;
                val_14 = EventHubBanner.<>c.<>9__25_0;
                if(val_14 == null)
            {
                    System.Func<PGCompany.EventHub.丄丟丐丂丌丆万丁丅, System.Boolean> val_5 = null;
                val_14 = val_5;
                val_5 = new System.Func<PGCompany.EventHub.丄丟丐丂丌丆万丁丅, System.Boolean>(object:  EventHubBanner.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean EventHubBanner.<>c::世丘丄下上丒丝上丛(PGCompany.EventHub.丄丟丐丂丌丆万丁丅 三丟东丕丄丄下下丑));
                EventHubBanner.<>c.<>9__25_0 = val_14;
            }
            
                val_8 = System.Linq.Enumerable.FirstOrDefault<PGCompany.EventHub.丄丟丐丂丌丆万丁丅>(source:  val_8, predicate:  val_5);
            }
            
            val_15 = null;
            val_15 = null;
            PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专 = val_8;
            if(PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专 == null)
            {
                    val_16 = null;
                val_16 = null;
                val_8 = "Can\'t find version " + 丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒 + " in hub config";
                UnityEngine.Debug.LogError(message:  val_8);
                val_15 = null;
            }
            
            val_15 = null;
            PGCompany.EventHub.EventHubBanner.丕丅世丐丝不丝丟丕 = true;
        }
        internal static PGCompany.EventHub.丄丟丐丂丌丆万丁丅 丝丏上且丄丗丛丕世()
        {
            PGCompany.EventHub.EventHubBanner.专与丏丒专丙丙三丅();
            return (PGCompany.EventHub.丄丟丐丂丌丆万丁丅)PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专;
        }
        private static void 丛丅与三丒且丐丗丗(object 不丟丗丏丛丕不丁丌, PGCompany.丏专丆丒丏丗丞丐丘 丗丛不丁丑专专丂且)
        {
            var val_2;
            var val_3;
            val_2 = 丗丛不丁丑专专丂且;
            if(val_2.丐丂丏丑丄丑丛丂丝() != 105)
            {
                    return;
            }
            
            val_2 = 1152921505662062592;
            val_3 = null;
            val_3 = null;
            PGCompany.EventHub.EventHubBanner.丕丅世丐丝不丝丟丕 = false;
        }
        public override void Show()
        {
            var val_13;
            var val_18;
            var val_20;
            var val_22;
            PGCompany.EventHub.丄世丌东丏三东丒丂 val_23;
            val_20 = null;
            val_20 = null;
            if(PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专 == null)
            {
                goto label_3;
            }
            
            this.上丁丈丞丌且丞丈丄 = PGCompany.丟丝世世且丗丈丈丞.丟丟万丌丒丛丐丞丝();
            PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
            this.Show();
            if(this.丐丆七且丞丏下三丙 == null)
            {
                goto label_5;
            }
            
            var val_20 = 0;
            val_20 = val_20 + 1;
            goto label_9;
            label_3:
            UnityEngine.Debug.LogError(message:  "[" + this.GetType() + "] Cannot parse config: "("] Cannot parse config: ") + PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  105)(PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  105)));
            return;
            label_9:
            this.丐丆七且丞丏下三丙.Dispose();
            label_5:
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PGCompany.EventHub.EventHubBanner::丝东丐丝东三丈世丝()), 与且专丈不万东一万:  "hub banner");
            val_22 = null;
            val_22 = null;
            PGCompany.EventHub.丅丝丙与丑七不丛世 val_11 = new PGCompany.EventHub.丅丝丙与丑七不丛世(不丐专不丒丒上丒业:  PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专, 丁世丛业丟下丕三丟:  this._view);
            this._view.丈且东丑丂且万丒丅(丈丁丅丈丌三丕七丗:  this, 丒专丈丛下丒一丒丛:  val_11);
            PGCompany.丆下丐丁丏世丈上丟 val_12 = this.丑丐丙丄丅世世丑丒();
            if(val_13 != 0)
            {
                    PGCompany.丆下丐丁丏世丈上丟 val_14 = this.丑丐丙丄丅世世丑丒();
                val_23 = val_13;
            }
            else
            {
                    val_23 = PGCompany.业专丝丆与下丙丒丑.丑七不且上丗丁一世().丟丑三万丛丂丏万不();
            }
            
            this._view.万专丟丈丞丙丘丆世(且下丕七丙丗丄不七:  val_23);
            PGCompany.丆下丐丁丏世丈上丟 val_17 = this.丑丐丙丄丅世世丑丒();
            if(val_18 != false)
            {
                    this.七东丝丄专丘一丆丄(且下丕七丙丗丄不七:  val_23, 丘世丌七丝七丑一丁:  val_11.且丌与东七丛专丘东(丁丅丈丌丟世丗丗丟:  val_23));
                return;
            }
            
            this.丗七丟下丒丘丑丞不();
        }
        public void U_CloseBanner()
        {
            this.丝东丐丝东三丈世丝();
        }
        internal void 丝东丐丝东三丈世丝()
        {
            this.丗丟万丂丘丈专丄丂();
            this.世七上三丌与丝丌丘 = 0;
            PGCompany.丟丝世世且丗丈丈丞.丏东业丛下业一丛万(丙业与丙丗丝不丈东:  this.上丁丈丞丌且丞丈丄);
            PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
        }
        internal void 丗丟万丂丘丈专丄丂()
        {
            var val_5;
            System.Version val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            if(PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专 != null)
            {
                    val_6 = mem[PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专 + 16];
                val_6 = PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专.Version;
            }
            else
            {
                    val_6 = 0;
            }
            
            if((System.Version.op_Inequality(v1:  val_6, v2:  0)) != false)
            {
                    val_7 = null;
                val_7 = null;
                丅丛丟上丁丆上丛专.不七不丙丏上与三一().一丄丄丙丌丑丛丟丒(丌丈不丄丝七丕万专:  ToString(fieldCount:  2));
            }
            
            this._view.丄丑上丕丂丈丘丙七();
            this.HideSelf();
            if(this.丐丆七且丞丏下三丙 == null)
            {
                    return;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        public void TurnOn()
        {
            this._view.万专丟丈丞丙丘丆世(且下丕七丙丗丄不七:  this.丁丐丆东上不世万专);
            this.丁丐丆东上不世万专 = 0;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  true);
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_6 = 0;
                val_6 = val_6 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
            }
            
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PGCompany.EventHub.EventHubBanner::丝东丐丝东三丈世丝()), 与且专丈不万东一万:  "hub banner");
            PGCompany.丟丝世世且丗丈丈丞.丏东业丛下业一丛万(丙业与丙丗丝不丈东:  this.世七上三丌与丝丌丘);
        }
        public void TurnOff()
        {
            this.丁丐丆东上不世万专 = this._view.<丈丟且丘丟专丑丑丙>k__BackingField;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  false);
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
            return 0f;
        }
        private void 丗七丟下丒丘丑丞不()
        {
            UnityEngine.Transform val_13;
            var val_14;
            var val_15;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._eventHubContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._eventPresentationContainer, 丏业丟一东丂东丘丛:  false);
            PGCompany.丟丝世世且丗丈丈丞.丏东业丛下业一丛万(丙业与丙丗丝不丈东:  new PGCompany.丝丆业不一丌东万世().丕一一丄丐丞丗业丅(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f}).丞丒且东三丁七丆丂(丙业与丙丗丝不丈东:  false));
            this.世七上三丌与丝丌丘 = PGCompany.丟丝世世且丗丈丈丞.丟丟万丌丒丛丐丞丝();
            System.Collections.IEnumerator val_6 = this._eventPresentationContainer.transform.GetEnumerator();
            label_23:
            var val_13 = 0;
            val_13 = val_13 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_12;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_13 = val_6.Current;
            if(val_13 != null)
            {
                    val_13 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  val_13, 丏业丟一东丂东丘丛:  false);
            goto label_23;
            label_12:
            val_14 = 0;
            val_15 = 0;
            if(val_6 != null)
            {
                    var val_15 = 0;
                val_15 = val_15 + 1;
                val_6.Dispose();
            }
            
            NotificationWindowController.世丛上丕专上且且三(丁丅丈丌丟世丗丗丟:  0);
        }
        internal static PGCompany.EventHub.丄世丌东丏三东丒丂 丕丌一丕丌一丛丛七()
        {
            var val_5;
            PGCompany.EventHub.丄丟丐丂丌丆万丁丅 val_6;
            PGCompany.EventHub.丄世丌东丏三东丒丂 val_7;
            val_5 = null;
            val_5 = null;
            val_6 = PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专;
            if((val_6 != null) && (null != 0))
            {
                    val_6 = PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专;
                .丂丒丁丑东丑丁丕丑 = new PGCompany.EventHub.丅丝丙与丑七不丛世(不丐专不丒丒上丒业:  val_6, 丁世丛业丟下丕三丟:  0);
                if((System.Linq.Enumerable.FirstOrDefault<PGCompany.EventHub.业丝下专丗且上丆万>(source:  PGCompany.EventHub.EventHubBanner.丙与丟丌丄专丕丗专.<业一专且丗丈丒与丂>k__BackingField, predicate:  new System.Func<PGCompany.EventHub.业丝下专丗且上丆万, System.Boolean>(object:  new EventHubBanner.与丙丌丟一七下丏与(), method:  System.Boolean EventHubBanner.与丙丌丟一七下丏与::丈丞与且丞不丈东丒(PGCompany.EventHub.业丝下专丗且上丆万 三丟东丕丄丄下下丑)))) == null)
            {
                    return (PGCompany.EventHub.丄世丌东丏三东丒丂)val_7;
            }
            
                val_7 = val_4.<且丈丁专东丆丄丂与>k__BackingField;
                return (PGCompany.EventHub.丄世丌东丏三东丒丂)val_7;
            }
            
            val_7 = 0;
            return (PGCompany.EventHub.丄世丌东丏三东丒丂)val_7;
        }
        internal void 七东丝丄专丘一丆丄(PGCompany.EventHub.丄世丌东丏三东丒丂 且下丕七丙丗丄不七, PGCompany.EventHub.丁七丑丝丂丄丅丏丑 丘世丌七丝七丑一丁)
        {
            PGCompany.EventHub.EventHubBanner val_23;
            string val_24;
            UnityEngine.MonoBehaviour val_25;
            var val_26;
            string val_27;
            val_23 = this;
            PGCompany.EventHubPresentation val_1 = 0;
            val_24 = 丘世丌七丝七丑一丁;
            if((this.上七与丁丟丅一下丐.TryGetValue(key:  val_24, value: out  val_1)) == false)
            {
                goto label_6;
            }
            
            val_24 = 0;
            if(val_1 == val_24)
            {
                goto label_6;
            }
            
            val_25 = val_1;
            goto label_7;
            label_6:
            PGCompany.EventHubPresentation val_4 = UnityEngine.Resources.Load<PGCompany.EventHubPresentation>(path:  丘世丌七丝七丑一丁);
            if(val_4 != 0)
            {
                goto label_10;
            }
            
            val_26 = 5;
            string[] val_6 = new string[5];
            val_25 = val_6;
            if("Presentation for event " == null)
            {
                    val_26 = 0;
            }
            
            if(val_6.Length == 0)
            {
                    val_26 = 0;
            }
            
            val_25[0] = "Presentation for event ";
            if(丘世丌七丝七丑一丁.丑与七丝东下丌业丏 == null)
            {
                goto label_15;
            }
            
            val_27 = 丘世丌七丝七丑一丁.丑与七丝东下丌业丏.<上丒世丘丗下丌七不>k__BackingField;
            if((val_27 == null) || (val_27 != null))
            {
                goto label_18;
            }
            
            val_26 = 0;
            goto label_18;
            label_10:
            val_25 = 丞东丑专丛丆丄丝世.万丁三丙东且与丕与<PGCompany.EventHubPresentation>(丑且不丕与专丄业丙:  val_4, 丈东丘丏与丌东东下:  this._eventPresentationContainer.transform, 丙专下东丝一丐丌丟:  false, 丙丄丌与世丝丏丈丗:  new System.Nullable<System.Int32>() {HasValue = false});
            DisableHardwareBack val_10 = val_25.丅与丌专丟一丝业三().AddComponent<DisableHardwareBack>();
            mem[1152921559743997856] = val_23;
            mem[1152921559743997864] = System.Void PGCompany.EventHub.EventHubBanner::丗七丟下丒丘丑丞不();
            mem[1152921559743997840] = System.Void PGCompany.EventHub.EventHubBanner::丗七丟下丒丘丑丞不();
            val_8.animationWrapper.丟下丞三丘丑丝业丟 = new EventHubPresentationAnimationWrapper.丝丂丕下丄丞东三上();
            val_8.OnSkipButtonClick = new System.Action(object:  this, method:  System.Void PGCompany.EventHub.EventHubBanner::丗七丟下丒丘丑丞不());
            label_7:
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "last_shown_presentation_time", 下下丏一丙不丘丌丞:  PixelTime.丙丅丅业丟丁世丁丗(), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "last_shown_presentation_time_" + 且下丕七丙丗丄不七.ToString(), 下下丏一丙不丘丌丞:  PixelTime.丙丅丅业丟丁世丁丗(), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._eventHubContainer, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._eventPresentationContainer, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_25, 丏业丟一东丂东丘丛:  true);
            PGCompany.丟丝世世且丗丈丈丞.丏东业丛下业一丛万(丙业与丙丗丝不丈东:  new PGCompany.丝丆业不一丌东万世().丞丒且东三丁七丆丂(丙业与丙丗丝不丈东:  (val_8.fog == true) ? 1 : 0).丂丁丅丏与丕不专且(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_8.fogColor, g = V9.16B, b = V10.16B, a = V11.16B}).丕一一丄丐丞丗业丅(丙业与丙丗丝不丈东:  new UnityEngine.Color() {r = val_8.ambientLignt, g = V9.16B, b = V10.16B, a = V11.16B}));
            this.世七上三丌与丝丌丘 = PGCompany.丟丝世世且丗丈丈丞.丟丟万丌丒丛丐丞丝();
            val_23 = this.上七与丁丟丅一下丐;
            val_23.set_Item(key:  丘世丌七丝七丑一丁, value:  val_25);
            return;
            label_15:
            val_27 = 0;
            label_18:
            if(val_6.Length <= 1)
            {
                    val_26 = 0;
            }
            
            val_25[1] = val_27;
            if(" not found on path " == null)
            {
                    val_26 = 0;
            }
            
            if(val_6.Length <= 2)
            {
                    val_26 = 0;
            }
            
            val_25[2] = " not found on path ";
            val_25[3] = 丘世丌七丝七丑一丁;
            val_25[4] = ". Skip presentation.";
            UnityEngine.Debug.Log(message:  +val_6);
            this.丗七丟下丒丘丑丞不();
        }
        public EventHubBanner()
        {
            this.上七与丁丟丅一下丐 = new System.Collections.Generic.Dictionary<System.String, PGCompany.EventHubPresentation>();
        }
        private static EventHubBanner()
        {
            PGCompany.EventHub.EventHubBanner.上丟丐上丏丒丞一丒 = true;
        }
    
    }

}
