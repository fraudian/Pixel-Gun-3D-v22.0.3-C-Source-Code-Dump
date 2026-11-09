using UnityEngine;

namespace PGCompany.GameModeHub
{
    internal sealed class GMHMainView : PGBehaviour
    {
        // Fields
        internal static PGCompany.GameModeHub.GMHMainView 丄丘七三上丕世丞业;
        private static bool <丆丝丈丒不丕七丑下>k__BackingField;
        private static System.Action<PGCompany.GameModeHub.丟与丗不不上丆丞三> 丈丗丈丌丁丒东下业;
        private static System.Action<PGCompany.GameModeHub.丗丙丈下上丞不丅丑> 七丁且丙不一丝丙丕;
        private static System.Action<PGCompany.GameModeHub.丟与丗不不上丆丞三, PGCompany.GameModeHub.丗丙丈下上丞不丅丑, PGCompany.GameModeHub.万业世丙丗丌与不丆> 丐不丈丆丗丛世且丝;
        private PGCompany.GameModeHub.GMHCategorySelector categorySelector;
        private PGCompany.GameModeHub.GMHModeMapSelector modeMapSelector;
        private UILabel backButtonLabel;
        private UnityEngine.GameObject bottomButtonsHolder;
        private UnityEngine.GameObject buttonBattle;
        private UnityEngine.GameObject buttonSolo;
        private UnityEngine.GameObject buttonTeam;
        private UnityEngine.GameObject buttonDetails;
        private UnityEngine.GameObject buttonParty;
        private UnityEngine.GameObject buttonPrivate;
        private lockedOnProgressUI lockedOnProgressUIParty;
        private lockedOnProgressUI lockedOnProgressUIPrivate;
        private ConnectScenePanelEventHint connectScenePanelEventHint;
        private ConnectScenePanelModeInfo connectScenePanelModeInfo;
        private UnityEngine.GameObject gameObjectHolder;
        private UnityEngine.BoxCollider panelBoxCollider;
        private GMHModeRewardsView gmhModeRewardsView;
        private UnityEngine.Transform startMiniGameScreenParent;
        private System.Collections.Generic.List<UIRect> rectsToUpdate;
        private StartMiniGameGuiController 丈丁下丟不不丛丗丏;
        internal bool 七丘丝丆丏丘丗丏丄;
        internal bool 专上且丗丑丌丟丈丄;
        internal ConnectionControl 丙不丅丝丙专丕世丐;
        private System.Collections.Generic.List<PGCompany.GameModeHub.丟与丗不不上丆丞三> 上专上七下丆丅下丈;
        private PGCompany.GameModeHub.丟与丗不不上丆丞三 丘丅丞下一三三丛丈;
        private PGCompany.GameModeHub.丗丙丈下上丞不丅丑 与世丈丟业丏丂丌下;
        private PGCompany.GameModeHub.万业世丙丗丌与不丆 丞丝七丑丙丞七丅东;
        private System.IDisposable 专丏业专不丂一丂丛;
        private static PGCompany.GameModeHub.GMHMainView.丝丐丝丈不且丕丈丌 不业丛丝丁丕业下下;
        public UnityEngine.Transform dungeonWindowParent;
        public UnityEngine.Transform dungeonNoModulesWindowParent;
        internal DungeonWindowUI 丛丁丅丆丅与万三丅;
        internal DungeonNoModulesWindowUI 东丏丆东丆丐丁丌丈;
        private System.IDisposable 丏七一七丕不不专丈;
        
        // Properties
        internal static bool 丐丅且丗东丘上与丏 { get; set; }
        internal StartMiniGameGuiController 丒丅丄一万丝丈丝且 { get; }
        internal MiniPoolGroup 丘丙万丝丆七丆丈丌 { get; }
        internal PGCompany.GameModeHub.丟与丗不不上丆丞三 专丛丞丛万且与丆丒 { get; }
        internal PGCompany.GameModeHub.丗丙丈下上丞不丅丑 专丘上丁丗业万万三 { get; }
        internal PGCompany.GameModeHub.万业世丙丗丌与不丆 丘丑七七丟丏丄丅上 { get; }
        
        // Methods
        internal static bool 丌丄一丒且下丅丁丏()
        {
            return (bool)PGCompany.GameModeHub.GMHMainView.<丆丝丈丒不丕七丑下>k__BackingField;
        }
        private static void 不下丞丌丑一丅丆三(bool 丙业与丙丗丝不丈东)
        {
            PGCompany.GameModeHub.GMHMainView.<丆丝丈丒不丕七丑下>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal static void 丑七丆丄丌下不三丂(System.Action<PGCompany.GameModeHub.丟与丗不不上丆丞三> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.GameModeHub.GMHMainView.丈丗丈丌丁丒东下业, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.GameModeHub.GMHMainView.丈丗丈丌丁丒东下业 != 1152921505704505360);
        
        }
        internal static void 与业万丄上丑世且丘(System.Action<PGCompany.GameModeHub.丟与丗不不上丆丞三> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.GameModeHub.GMHMainView.丈丗丈丌丁丒东下业, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.GameModeHub.GMHMainView.丈丗丈丌丁丒东下业 != 1152921505704505360);
        
        }
        internal static void 丐丛丑丗丈三丞三不(System.Action<PGCompany.GameModeHub.丗丙丈下上丞不丅丑> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.GameModeHub.GMHMainView.七丁且丙不一丝丙丕, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.GameModeHub.GMHMainView.七丁且丙不一丝丙丕 != 1152921505704505368);
        
        }
        internal static void 丑七丘一丒丁丈下丐(System.Action<PGCompany.GameModeHub.丗丙丈下上丞不丅丑> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.GameModeHub.GMHMainView.七丁且丙不一丝丙丕, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.GameModeHub.GMHMainView.七丁且丙不一丝丙丕 != 1152921505704505368);
        
        }
        internal static void 丁丏丄丑且丞丞世与(System.Action<PGCompany.GameModeHub.丟与丗不不上丆丞三, PGCompany.GameModeHub.丗丙丈下上丞不丅丑, PGCompany.GameModeHub.万业世丙丗丌与不丆> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  PGCompany.GameModeHub.GMHMainView.丐不丈丆丗丛世且丝, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.GameModeHub.GMHMainView.丐不丈丆丗丛世且丝 != 1152921505704505376);
        
        }
        internal static void 丙丏丟丑下且万丁丁(System.Action<PGCompany.GameModeHub.丟与丗不不上丆丞三, PGCompany.GameModeHub.丗丙丈下上丞不丅丑, PGCompany.GameModeHub.万业世丙丗丌与不丆> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  PGCompany.GameModeHub.GMHMainView.丐不丈丆丗丛世且丝, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(PGCompany.GameModeHub.GMHMainView.丐不丈丆丗丛世且丝 != 1152921505704505376);
        
        }
        internal StartMiniGameGuiController 丈丄不丞丝丌上丄丐()
        {
            return (StartMiniGameGuiController)this.丈丁下丟不不丛丗丏;
        }
        internal MiniPoolGroup 丘丝丅不专丙丅丕丐()
        {
            if(this.modeMapSelector != null)
            {
                    return (MiniPoolGroup)this.modeMapSelector.pool;
            }
            
            return (MiniPoolGroup)this.modeMapSelector.pool;
        }
        internal PGCompany.GameModeHub.丟与丗不不上丆丞三 上丝丞丞丌且丝丛丟()
        {
            return (PGCompany.GameModeHub.丟与丗不不上丆丞三)this.丘丅丞下一三三丛丈;
        }
        internal PGCompany.GameModeHub.丗丙丈下上丞不丅丑 丘专丒丈丌丁且丁丟()
        {
            return (PGCompany.GameModeHub.丗丙丈下上丞不丅丑)this.与世丈丟业丏丂丌下;
        }
        internal PGCompany.GameModeHub.万业世丙丗丌与不丆 丄业丌世上丛丂丑丄()
        {
            return (PGCompany.GameModeHub.万业世丙丗丌与不丆)this.丞丝七丑丙丞七丅东;
        }
        private static System.Tuple<PGCompany.GameModeHub.丟与丗不不上丆丞三, PGCompany.GameModeHub.丗丙丈下上丞不丅丑, PGCompany.GameModeHub.万业世丙丗丌与不丆> 七上业业丅丐丒专业(PGCompany.GameModeHub.GMHMainView.丝丐丝丈不且丕丈丌 丙东不丟东下上丂丑)
        {
            PGCompany.GameModeHub.丟与丗不不上丆丞三 val_11;
            PGCompany.GameModeHub.丗丙丈下上丞不丅丑 val_12;
            string val_13;
            val_11 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丙东不丟东下上丂丑.丅不丗丂丑丈上丘丙)) != true)
            {
                    val_11 = PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世().丆业丝不一丒丞且丝(丑丅七丅一丈丘丞七:  丙东不丟东下上丂丑.丅不丗丂丑丈上丘丙);
            }
            
            val_12 = 0;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丙东不丟东下上丂丑.专专丅丈丗丒万丅丌)) != true)
            {
                    val_12 = PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世().丌丘不与丗丈丟世业(七丈丆不丁丝一丄三:  丙东不丟东下上丂丑.专专丅丈丗丒万丅丌);
            }
            
            val_13 = 0;
            if((val_12 == null) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丙东不丟东下上丂丑.丟丑丟东丝东与丈丌)) == true))
            {
                    return (System.Tuple<PGCompany.GameModeHub.丟与丗不不上丆丞三, PGCompany.GameModeHub.丗丙丈下上丞不丅丑, PGCompany.GameModeHub.万业世丙丗丌与不丆>)new System.Tuple<PGCompany.GameModeHub.丟与丗不不上丆丞三, PGCompany.GameModeHub.丗丙丈下上丞不丅丑, PGCompany.GameModeHub.万业世丙丗丌与不丆>(item1:  val_11, item2:  val_12, item3:  val_13 = PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世().东与丆丟丅业丗丛一(七丈丆不丁丝一丄三:  val_13, 不万丈丟上丙丟万世:  丙东不丟东下上丂丑.丟丑丟东丝东与丈丌));
            }
            
            return (System.Tuple<PGCompany.GameModeHub.丟与丗不不上丆丞三, PGCompany.GameModeHub.丗丙丈下上丞不丅丑, PGCompany.GameModeHub.万业世丙丗丌与不丆>)new System.Tuple<PGCompany.GameModeHub.丟与丗不不上丆丞三, PGCompany.GameModeHub.丗丙丈下上丞不丅丑, PGCompany.GameModeHub.万业世丙丗丌与不丆>(item1:  val_11, item2:  val_12, item3:  val_13);
        }
        internal static void 下下且丅丆丐丞且丒(PGCompany.GameModeHub.GMHMainView.丝丐丝丈不且丕丈丌 丗丟上上丒丐丗丞丙)
        {
            PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.__il2cppRuntimeField_38 = 丗丟上上丒丐丗丞丙.丟丑丟东丝东与丈丌;
            PGCompany.GameModeHub.GMHMainView.不业丛丝丁丕业下下 = 丗丟上上丒丐丗丞丙.丅不丗丂丑丈上丘丙;
        }
        internal void 丈丌一丗丞丂丂丟丞(PGCompany.GameModeHub.万业世丙丗丌与不丆 丞丁丑丏丄丏七丂不)
        {
            if(this.丛丁丅丆丅与万三丅 == 0)
            {
                    this.丛丁丅丆丅与万三丅 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.dungeonWindowParent.gameObject, 丑且不丕与专丄业丙:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Raids/DungeonWindow")).GetComponent<DungeonWindowUI>();
                val_5.backBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::世东丄东专丙专丒丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            }
            
            this.丛丁丅丆丅与万三丅.上东与丛丞下丈专丈(下丒丏丙一不七丕丏:  丞丁丑丏丄丏七丂不);
            this.dungeonWindowParent.gameObject.SetActive(value:  true);
            if(this.丏七一七丕不不专丈 != null)
            {
                    var val_12 = 0;
                val_12 = val_12 + 1;
                this.丏七一七丕不不专丈.Dispose();
            }
            
            this.丏七一七丕不不专丈 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::丂丅丈丕三世丈丒下()), 与且专丈不万东一万:  "Dungeon Window");
        }
        internal void 世东丄东专丙专丒丐(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.丂丅丈丕三世丈丒下();
        }
        internal void 丂丅丈丕三世丈丒下()
        {
            this.dungeonWindowParent.gameObject.SetActive(value:  false);
            if(this.丏七一七丕不不专丈 == null)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.丏七一七丕不不专丈.Dispose();
            this.丏七一七丕不不专丈 = 0;
        }
        internal void 丆丒丆丂与丈上丏丕(int 丛且丞与丕业下丏丞)
        {
            if(this.modeMapSelector == 0)
            {
                    return;
            }
            
            this.modeMapSelector.丆丒丆丂与丈上丏丕(丛且丞与丕业下丏丞:  丛且丞与丕业下丏丞);
        }
        private void Awake()
        {
            var val_10;
            PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业 = this;
            this.categorySelector.丌丐与丙东万上丛东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::东上且三丛一三丂丙()));
            this.categorySelector.与丞与丗东丟丅丒万(丙业与丙丗丝不丈东:  new System.Action<PGCompany.GameModeHub.丟与丗不不上丆丞三>(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::万丄且丈丟业万丕丛(PGCompany.GameModeHub.三丙专上下万七丛东 万且万且丑丗且丌丆)));
            this.modeMapSelector.丟丙丑一丝与丒丂丝(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::丞一丙世上丅丏丏丙()));
            this.modeMapSelector.不丏上丟专世丒丆丕(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::丆丒丆丂与丈上丏丕()));
            this.modeMapSelector.丞丈不丈丒业下丁丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::丁一丈丑丙且专且丂()));
            this.modeMapSelector.丆且专七七丕业丁丗(丙业与丙丗丝不丈东:  new System.Action<PGCompany.GameModeHub.三丙专上下万七丛东>(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::万丄且丈丟业万丕丛(PGCompany.GameModeHub.三丙专上下万七丛东 万且万且丑丗且丌丆)));
            this.丙不丅丝丙专丕世丐 = this.gameObject.AddComponent<ConnectionControl>();
            val_8.dontResetGameMode = true;
            val_10 = null;
            val_10 = null;
            this.丙不丅丝丙专丕世丐.SetConnectPanel(丛丘下丗业丂一且业:  MainMenuController.丄丞丁丈与业上丞丟.丆丂三一丌一丏丁丞());
        }
        private void OnDestroy()
        {
            PGCompany.GameModeHub.GMHMainView.<丆丝丈丒不丕七丑下>k__BackingField = false;
            PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业 = 0;
            this.categorySelector.丄专丏丅丗丐丏万专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::东上且三丛一三丂丙()));
            this.categorySelector.丑丈丈不世丄丒三丑(丙业与丙丗丝不丈东:  new System.Action<PGCompany.GameModeHub.丟与丗不不上丆丞三>(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::万丄且丈丟业万丕丛(PGCompany.GameModeHub.三丙专上下万七丛东 万且万且丑丗且丌丆)));
            this.modeMapSelector.丛丟世丗丒丑丅丑丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::丞一丙世上丅丏丏丙()));
            this.modeMapSelector.上丑丟丕不丞万下丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::丆丒丆丂与丈上丏丕()));
            this.modeMapSelector.专世丐世东丛万丑东(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::丁一丈丑丙且专且丂()));
            this.modeMapSelector.丐丕专上世丘丘下下(丙业与丙丗丝不丈东:  new System.Action<PGCompany.GameModeHub.三丙专上下万七丛东>(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::万丄且丈丟业万丕丛(PGCompany.GameModeHub.三丙专上下万七丛东 万且万且丑丗且丌丆)));
        }
        private void OnEnable()
        {
            if(this.专丏业专不丂一丂丛 != null)
            {
                    var val_11 = 0;
                val_11 = val_11 + 1;
                this.专丏业专不丂一丂丛.Dispose();
            }
            
            this.专丏业专不丂一丂丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void PGCompany.GameModeHub.GMHMainView::U_BackRequest()), 与且专丈不万东一万:  "BannerWindowWithBack_" + this.gameObject.name);
            this.丛丄丁与下丙东丂三();
            if(this.connectScenePanelEventHint.gameObject.activeSelf != false)
            {
                    this.丙世丞东与丒丐丌七();
            }
            
            PGCompany.GameModeHub.世丘与丙丗且三且丗.七上丑丝七丒业丈业(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::七丏业三丙一一业丑()));
            PGCompany.GameModeHub.GMHMainView.<丆丝丈丒不丕七丑下>k__BackingField = true;
        }
        private void OnDisable()
        {
            PGCompany.GameModeHub.GMHMainView.<丆丝丈丒不丕七丑下>k__BackingField = false;
            PGCompany.GameModeHub.世丘与丙丗且三且丗.与且东与丏下三业丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::七丏业三丙一一业丑()));
            if(this.专丏业专不丂一丂丛 == null)
            {
                    return;
            }
            
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.专丏业专不丂一丂丛.Dispose();
        }
        private void 七丏业三丙一一业丑()
        {
            PGCompany.GameModeHub.丟与丗不不上丆丞三 val_1;
            PGCompany.GameModeHub.丗丙丈下上丞不丅丑 val_2;
            PGCompany.GameModeHub.万业世丙丗丌与不丆 val_3;
            val_1 = this.丘丅丞下一三三丛丈;
            val_2 = this.与世丈丟业丏丂丌下;
            val_3 = this.丞丝七丑丙丞七丅东;
            this.丈且东丑丂且万丒丅(丙东不丟东下上丂丑:  new 丝丐丝丈不且丕丈丌() {丅不丗丂丑丈上丘丙 = val_1, 专专丅丈丗丒万丅丌 = val_1, 丟丑丟东丝东与丈丌 = val_3});
        }
        private void 丛丄丁与下丙东丂三()
        {
            if(PGCompany.一丅丆丆世丛与丕世.业丛丝一丏丂上丕不 != false)
            {
                    PGCompany.GameModeHub.GMHMainView.不业丛丝丁丕业下下 = 0;
                PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.__il2cppRuntimeField_30 = 0;
                PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.__il2cppRuntimeField_38 = 0;
                null = null;
                PGCompany.一丅丆丆世丛与丕世.业丛丝一丏丂上丕不 = false;
            }
            
            this.丈且东丑丂且万丒丅(丙东不丟东下上丂丑:  new 丝丐丝丈不且丕丈丌() {丟丑丟东丝东与丈丌 = PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.__il2cppRuntimeField_38});
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.GameModeHub.GMHMainView.丝丐丝丈不且丕丈丌 丙东不丟东下上丂丑)
        {
            PGCompany.GameModeHub.世丘与丙丗且三且丗 val_1 = PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世();
            this.上专上七下丆丅下丈 = val_1.上专上七下丆丅下丈;
            PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.__il2cppRuntimeField_38 = 丙东不丟东下上丂丑.丟丑丟东丝东与丈丌;
            PGCompany.GameModeHub.GMHMainView.不业丛丝丁丕业下下 = 丙东不丟东下上丂丑.丅不丗丂丑丈上丘丙;
            this.categorySelector.丈且东丑丂且万丒丅(万丞丛东丑丑丅一业:  this.上专上七下丆丅下丈, 下丌丝丅丐且且专丝:  PGCompany.GameModeHub.GMHMainView.七上业业丅丐丒专业(丙东不丟东下上丂丑:  new 丝丐丝丈不且丕丈丌() {丅不丗丂丑丈上丘丙 = 丙东不丟东下上丂丑.丅不丗丂丑丈上丘丙, 专专丅丈丗丒万丅丌 = 丙东不丟东下上丂丑.丅不丗丂丑丈上丘丙, 丟丑丟东丝东与丈丌 = 丙东不丟东下上丂丑.丟丑丟东丝东与丈丌}).Item1);
            PGCompany.GameModeHub.GMHMainView.不业丛丝丁丕业下下 = 0;
            this.丝一丅丆三东丂丞七();
        }
        private void 东上且三丛一三丂丙()
        {
            PGCompany.GameModeHub.丗丙丈下上丞不丅丑 val_13;
            var val_14;
            var val_15;
            this.与世丈丟业丏丂丌下 = 0;
            this.丞丝七丑丙丞七丅东 = 0;
            this.丘丅丞下一三三丛丈 = this.categorySelector.丙三东丞丈东丘丞丛;
            if(PGCompany.GameModeHub.GMHMainView.不业丛丝丁丕业下下 == 0)
            {
                goto label_2;
            }
            
            label_19:
            System.Tuple<PGCompany.GameModeHub.丟与丗不不上丆丞三, PGCompany.GameModeHub.丗丙丈下上丞不丅丑, PGCompany.GameModeHub.万业世丙丗丌与不丆> val_1 = PGCompany.GameModeHub.GMHMainView.七上业业丅丐丒专业(丙东不丟东下上丂丑:  new 丝丐丝丈不且丕丈丌() {丅不丗丂丑丈上丘丙 = PGCompany.GameModeHub.GMHMainView.不业丛丝丁丕业下下, 专专丅丈丗丒万丅丌 = PGCompany.GameModeHub.GMHMainView.不业丛丝丁丕业下下, 丟丑丟东丝东与丈丌 = PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.__il2cppRuntimeField_38});
            if(val_1 == null)
            {
                goto label_3;
            }
            
            val_13 = val_1.Item2;
            goto label_4;
            label_2:
            System.Collections.Generic.KeyValuePair<System.String, System.String> val_3 = PGCompany.GameModeHub.丙且东丞三专下万世.一丈丈丒与且丟丛丆(丑丅七丅一丈丘丞七:  this.categorySelector.丙三东丞丈东丘丞丛);
            if((val_3.Value.丐丏七丌丕丗业且上() == null) || (val_3.Value == 0))
            {
                goto label_19;
            }
            
            if((PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世().丕丒丐丌丟丒丆上丄(丙下不丏丅丅专丂丗:  val_3.Value.丐丏七丌丕丗业且上())) == null)
            {
                goto label_12;
            }
            
            goto label_13;
            label_3:
            val_13 = 0.Item2;
            label_4:
            this.modeMapSelector.丑与丙丄丂丅丈丅丄();
            this.modeMapSelector.丙三东丞丈东丘丞丛 = this.丘丅丞下一三三丛丈;
            this.modeMapSelector.丛不与丈丐丘丝丗丛 = val_13;
            this.modeMapSelector.万丁下七丟三不丏丂 = val_1.Item3;
            this.modeMapSelector.丟一丌下一丞业业丈();
            PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.__il2cppRuntimeField_30 = 0;
            PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.__il2cppRuntimeField_38 = 0;
            this.丝一丅丆三东丂丞七();
            if(PGCompany.GameModeHub.GMHMainView.丈丗丈丌丁丒东下业 == null)
            {
                    return;
            }
            
            PGCompany.GameModeHub.GMHMainView.丈丗丈丌丁丒东下业.Invoke(obj:  this.丘丅丞下一三三丛丈);
            return;
            label_12:
            val_14 = 0;
            label_13:
            PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.__il2cppRuntimeField_30 = val_14;
            if((PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世().丐丟万丛丁业丐与三(丙下不丏丅丅专丂丗:  val_3.Value)) != null)
            {
                
            }
            else
            {
                    val_15 = 0;
            }
            
            PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.__il2cppRuntimeField_38 = val_15;
            goto label_19;
        }
        private void 丞一丙世上丅丏丏丙()
        {
            this.丞丝七丑丙丞七丅东 = 0;
            this.与世丈丟业丏丂丌下 = this.modeMapSelector.与世丈丟业丏丂丌下;
            this.丝一丅丆三东丂丞七();
            if(PGCompany.GameModeHub.GMHMainView.七丁且丙不一丝丙丕 == null)
            {
                    return;
            }
            
            PGCompany.GameModeHub.GMHMainView.七丁且丙不一丝丙丕.Invoke(obj:  this.与世丈丟业丏丂丌下);
        }
        private void 丆丒丆丂与丈上丏丕()
        {
            PGCompany.GameModeHub.GMHModeMapSelector val_1;
            this.丞丝七丑丙丞七丅东 = this.modeMapSelector.丞丝七丑丙丞七丅东;
            this.丝一丅丆三东丂丞七();
            if(PGCompany.GameModeHub.GMHMainView.丐不丈丆丗丛世且丝 == null)
            {
                    return;
            }
            
            val_1 = this.modeMapSelector;
            if(this.modeMapSelector != null)
            {
                goto label_4;
            }
            
            val_1 = this.modeMapSelector;
            if(val_1 == null)
            {
                goto label_5;
            }
            
            label_4:
            PGCompany.GameModeHub.GMHMainView.丐不丈丆丗丛世且丝.Invoke(arg1:  this.categorySelector.丙三东丞丈东丘丞丛, arg2:  this.modeMapSelector.与世丈丟业丏丂丌下, arg3:  this.modeMapSelector.丞丝七丑丙丞七丅东);
            return;
            label_5:
        }
        private void 丝一丅丆三东丂丞七()
        {
            this.gmhModeRewardsView.丈且东丑丂且万丒丅(丂丛丑东不丅丈一东:  this.与世丈丟业丏丂丌下);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.categorySelector, 丏业丟一东丂东丘丛:  (this.丘丅丞下一三三丛丈 == 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.modeMapSelector, 丏业丟一东丂东丘丛:  (this.丘丅丞下一三三丛丈 != 0) ? 1 : 0);
            this.与丈丑业丏丛下丟上();
            if(this.categorySelector.gameObject.activeSelf != false)
            {
                    this.categorySelector.丝一丅丆三东丂丞七();
            }
            
            专且丝丄丙丗丈不丞.丞丝一三丟东丛东且(丐丗一业丒丐七丗且:  this.rectsToUpdate);
        }
        private void 与丈丑业丏丛下丟上()
        {
            string val_19;
            if(this.丘丅丞下一三三丛丈 != null)
            {
                    val_19 = "Key_12719";
            }
            else
            {
                    val_19 = "Key_5966";
            }
            
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.backButtonLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_19));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonBattle, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonDetails, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonSolo, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonTeam, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonParty, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonPrivate, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bottomButtonsHolder, 丏业丟一东丂东丘丛:  (this.丞丝七丑丙丞七丅东 != 0) ? 1 : 0);
            System.Collections.Generic.List<PGCompany.GameModeHub.与丂丒一丈丕丏专与> val_3 = PGCompany.GameModeHub.丂丕且丟丌丐万东丗.丙丏丞丝不世七业丏(丂丛丑东不丅丈一东:  this.与世丈丟业丏丂丌下, 丞丁丑丏丄丏七丂不:  this.丞丝七丑丙丞七丅东);
            System.Collections.Generic.List<PGCompany.GameModeHub.与丂丒一丈丕丏专与> val_4 = PGCompany.GameModeHub.丂丕且丟丌丐万东丗.七专丄丘业丐丑下一(丂丛丑东不丅丈一东:  this.与世丈丟业丏丂丌下, 丞丁丑丏丄丏七丂不:  this.丞丝七丑丙丞七丅东);
            if(((val_3 == null) || (this.与世丈丟业丏丂丌下 == null)) || (this.丞丝七丑丙丞七丅东 == null))
            {
                goto label_43;
            }
            
            if((val_3.Contains(item:  1)) != false)
            {
                    if(val_4 != null)
            {
                    if((val_4.Contains(item:  1)) == true)
            {
                goto label_18;
            }
            
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonBattle, 丏业丟一东丂东丘丛:  true);
            }
            
            label_18:
            if((val_3.Contains(item:  2)) != false)
            {
                    if(val_4 != null)
            {
                    if((val_4.Contains(item:  2)) == true)
            {
                goto label_23;
            }
            
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonSolo, 丏业丟一东丂东丘丛:  true);
            }
            
            label_23:
            if((val_3.Contains(item:  3)) != false)
            {
                    if(val_4 != null)
            {
                    if((val_4.Contains(item:  3)) == true)
            {
                goto label_28;
            }
            
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonTeam, 丏业丟一东丂东丘丛:  true);
            }
            
            label_28:
            if((val_3.Contains(item:  4)) != false)
            {
                    if(val_4 != null)
            {
                    if((val_4.Contains(item:  4)) == true)
            {
                goto label_33;
            }
            
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonDetails, 丏业丟一东丂东丘丛:  true);
            }
            
            label_33:
            if((val_3.Contains(item:  5)) != false)
            {
                    if(val_4 != null)
            {
                    if((val_4.Contains(item:  5)) == true)
            {
                goto label_38;
            }
            
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonParty, 丏业丟一东丂东丘丛:  true);
            }
            
            label_38:
            if((val_3.Contains(item:  6)) != false)
            {
                    if(val_4 != null)
            {
                    if((val_4.Contains(item:  6)) == true)
            {
                goto label_43;
            }
            
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.buttonPrivate, 丏业丟一东丂东丘丛:  true);
            }
            
            label_43:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.lockedOnProgressUIParty, 丏业丟一东丂东丘丛:  false);
            if(this.lockedOnProgressUIParty.丟丁丐丂丅丁不丒东() != true)
            {
                    this.lockedOnProgressUIParty.丈且东丑丂且万丒丅(上丕丈丞丌丘丅不与:  120);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.lockedOnProgressUIParty, 丏业丟一东丂东丘丛:  true);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.lockedOnProgressUIPrivate, 丏业丟一东丂东丘丛:  false);
            if(this.lockedOnProgressUIPrivate.丝万丙丐一丕丅一丙() != false)
            {
                    return;
            }
            
            this.lockedOnProgressUIPrivate.丈且东丑丂且万丒丅(上丕丈丞丌丘丅不与:  120);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.lockedOnProgressUIPrivate, 丏业丟一东丂东丘丛:  true);
        }
        private bool 丟丁丐丂丅丁不丒东()
        {
            return (bool)(ExperienceController.丂丂下丑且下丌丝东() > 119) ? 1 : 0;
        }
        private bool 丝万丙丐一丕丅一丙()
        {
            return (bool)(ExperienceController.丂丂下丑且下丌丝东() > 119) ? 1 : 0;
        }
        private void 三且世三丂七丐一丟(PGCompany.GameModeHub.丞不七丗丒且业丁丛 丄丄丅丙专下上丄丒)
        {
            PGCompany.GameModeHub.丟与丗不不上丆丞三 val_3;
            PGCompany.GameModeHub.丗丙丈下上丞不丅丑 val_4;
            if(this.丞丝七丑丙丞七丅东 != null)
            {
                    val_3 = this.丘丅丞下一三三丛丈;
                val_4 = this.与世丈丟业丏丂丌下;
                PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.__il2cppRuntimeField_38 = this.丞丝七丑丙丞七丅东;
                PGCompany.GameModeHub.GMHMainView.不业丛丝丁丕业下下 = val_3;
                PGCompany.GameModeHub.丙丙与东一丐丂丐上.丑七不且上丗丁一世().丛丛业丈下下丐丟丒(丞丁丑丏丄丏七丂不:  this.丞丝七丑丙丞七丅东, 丄丄丅丙专下上丄丒:  丄丄丅丙专下上丄丒);
                return;
            }
            
            UnityEngine.Debug.LogError(message:  "[GMH] nullable SelectedMap");
        }
        public void U_BackRequest()
        {
            var val_1;
            PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.__il2cppRuntimeField_30 = 0;
            PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.__il2cppRuntimeField_38 = 0;
            PGCompany.GameModeHub.GMHMainView.不业丛丝丁丕业下下 = 0;
            if(this.丘丅丞下一三三丛丈 != null)
            {
                    mem2[0] = 0;
                mem2[0] = 0;
                mem2[0] = 0;
                this.丝一丅丆三东丂丞七();
                return;
            }
            
            val_1 = static_value_081DACA8;
            val_1 = static_value_081DACA8;
            static_value_081DACA8 + 184 + 16.HandleBackBtnClicked();
        }
        public void U_BattleRequest()
        {
            var val_7;
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "U_BattleRequest");
            if(this.丞丝七丑丙丞七丅东.丌丐东业专丑丘丑丗() == null)
            {
                goto label_2;
            }
            
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_2 = this.丞丝七丑丙丞七丅东.丌丐东业专丑丘丑丗();
            if(val_2 != null)
            {
                    val_7 = val_2.三丏丁万丙丄丛丒下(丁丅丈丌丟世丗丗丟:  13);
            }
            else
            {
                    val_7 = 0.三丏丁万丙丄丛丒下(丁丅丈丌丟世丗丗丟:  13);
            }
            
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_5 = val_2.丌不丅不丞东万专专();
            if(((val_7 != null) || (val_5.HasValue.丙东专丂世丈丏丁丂() != 5)) || ((50052072 & 1) == 0))
            {
                goto label_8;
            }
            
            label_2:
            this.三且世三丂七丐一丟(丄丄丅丙专下上丄丒:  1);
            return;
            label_8:
            this.U_DetailsRequest();
        }
        public void U_SoloRequest()
        {
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "U_SoloRequest");
            this.三且世三丂七丐一丟(丄丄丅丙专下上丄丒:  1);
        }
        public void U_TeamRequest()
        {
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "U_TeamRequest");
            this.三且世三丂七丐一丟(丄丄丅丙专下上丄丒:  2);
        }
        public void U_DetailsRequest()
        {
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "U_DetailsRequest");
            if(this.丞丝七丑丙丞七丅东.一丗丟丛丈专丙三丌 == 22)
            {
                    this.丈丌一丗丞丂丂丟丞(丞丁丑丏丄丏七丂不:  this.丞丝七丑丙丞七丅东);
                return;
            }
            
            if(this.与世丈丟业丏丂丌下.丐丂丄丘丈专七万下 == 30)
            {
                    this.专丆丏且丟丆世丏三(与丛丛丟丅世丏丐丌:  this.丞丝七丑丙丞七丅东.一丗丟丛丈专丙三丌);
                return;
            }
            
            if(this.丞丝七丑丙丞七丅东 == null)
            {
                    return;
            }
            
            if(this.丞丝七丑丙丞七丅东.丌丐东业专丑丘丑丗() == null)
            {
                    return;
            }
            
            this.且丐丆且丝丑丒东业(丐且丘丑与万丞丑丅:  this.丞丝七丑丙丞七丅东.丌丐东业专丑丘丑丗());
        }
        public void U_PartyRequest()
        {
            var val_1;
            var val_2;
            var val_3;
            PGCompany.GameModeHub.丕业丞七丄七丒万东 val_4;
            var val_5;
            var val_6;
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "U_PartyRequest");
            val_1 = static_value_081DACA8;
            if(this.与世丈丟业丏丂丌下.丐丂丄丘丈专七万下 == 30)
            {
                    val_2 = static_value_081DACA8;
                val_3 = mem[static_value_081DACA8 + 184 + 16];
                val_3 = static_value_081DACA8 + 184 + 16;
                val_4 = 12;
                val_5 = 1;
            }
            else
            {
                    val_6 = static_value_081DACA8;
                val_3 = mem[static_value_081DACA8 + 184 + 16];
                val_3 = static_value_081DACA8 + 184 + 16;
                val_4 = this.与世丈丟业丏丂丌下.丐丂丄丘丈专七万下;
                val_5 = 0;
            }
            
            val_3.丝万丈东万丗丕丆丆(一丐丛丏与丗七丂丐:  val_4, 丌与一丌且一不七丆:  false);
        }
        public void U_PrivateRequest()
        {
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "U_PrivateRequest");
            PGCompany.GameModeHub.丙丙与东一丐丂丐上.丑七不且上丗丁一世().丐丝丅与上丒与丐世();
        }
        public void ModeInfoRequest()
        {
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "ModeInfoButtonPressed");
            if(this.与世丈丟业丏丂丌下.丐丂丄丘丈专七万下 == 26)
            {
                    CompetitionSelectPanel.专世且东丆上丂丙与();
                return;
            }
            
            System.Nullable<UnityEngine.Vector3> val_1 = this.modeMapSelector.丑丘且业三不下与下();
            this.connectScenePanelModeInfo.丛丗丝且世丟丌东万(上不一丗下世丂丞与:  new System.Nullable<UnityEngine.Vector3>() {HasValue = val_1.HasValue});
        }
        private void 万丄且丈丟业万丕丛(PGCompany.GameModeHub.三丙专上下万七丛东 万且万且丑丗且丌丆)
        {
            TagSystem.三与下丘七丘丌丏丄 val_6;
            var val_8;
            var val_13;
            var val_16;
            if((万且万且丑丗且丌丆.<丙丝万丈丟丕丛丑丗>k__BackingField.丂丆世世丕丅丕丅上(丆万一不丌且东丐丐:  "locked.exp", 丟且丒专下丈七丗丕:  4)) != true)
            {
                    val_6 = 万且万且丑丗且丌丆.<丙丝万丈丟丕丛丑丗>k__BackingField;
                if((val_6.丂丆世世丕丅丕丅上(丆万一不丌且东丐丐:  "locked.sub-entities.not-available", 丟且丒专下丈七丗丕:  4)) == true)
            {
                    return;
            }
            
            }
            
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Locked pressed");
            if(万且万且丑丗且丌丆.丑下不丅一丘丒丄丑() != false)
            {
                    this.connectScenePanelModeInfo.丟且丈丆一丅丟一丆(业丒与丐不丘七业丒:  W22);
            }
            else
            {
                    this.connectScenePanelModeInfo.丞一丐七丐丘丑世且(丞丁丑丏丄丏七丂不:  万且万且丑丗且丌丆);
            }
            
            val_8 = null;
            if(this.connectScenePanelModeInfo == null)
            {
                    val_8 = null;
            }
            
            val_13 = 0;
            this.connectScenePanelModeInfo.万丗丅上专与东三下(丂丛丑东不丅丈一东:  null);
            val_6 = 1152921505702371328;
            val_16 = null;
        }
        public void ModeChallengesRequest()
        {
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "ModeChallengesRequest");
            if((PGCompany.PixelPass.丁且七丅丞丐丌丌世.丁丗且丗丐且专丘丂(丈丂七世丟丞丂丗丒:  PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙())) == null)
            {
                    return;
            }
            
            goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
        }
        public void GoCompetitionRequest()
        {
            Rilisoft.七丕丟丏三丈一丄世 val_5;
            CompetitionConnectWindow val_6;
            PGCompany.GameModeHub.万业世丙丗丌与不丆 val_7;
            val_5 = this;
            if(this.丞丝七丑丙丞七丅东 == null)
            {
                    return;
            }
            
            PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_1 = this.丞丝七丑丙丞七丅东.丌丐东业专丑丘丑丗();
            if(val_1 == null)
            {
                    return;
            }
            
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_2 = val_1.丌不丅不丞东万专专();
            val_6 = val_2.HasValue.丙东专丂世丈丏丁丂();
            if(val_6 != 4)
            {
                    return;
            }
            
            if((51343512 & 1) == 0)
            {
                    return;
            }
            
            InfoWindowController val_4 = InfoWindowController.丑七不且上丗丁一世();
            val_6 = val_4.competitionConnectWindow;
            val_7 = this.丞丝七丑丙丞七丅东;
            if(this.丞丝七丑丙丞七丅东 != null)
            {
                goto label_8;
            }
            
            val_7 = this.丞丝七丑丙丞七丅东;
            if(val_7 == null)
            {
                goto label_9;
            }
            
            label_8:
            val_5 = this.丞丝七丑丙丞七丅东.一丗丟丛丈专丙三丌;
            val_6.丘丌丄万丞一万丐丅(丐且丘丑与万丞丑丅:  val_1, 业丞丟万不丄丂丘丑:  val_5, 下丞七丒业丂丈丘下:  this.丞丝七丑丙丞七丅东.丐丒且丝丛丁丕丟丅);
            return;
            label_9:
        }
        private void 且丐丆且丝丑丒东业(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅)
        {
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_1 = 丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
            if((51508904 & 1) == 0)
            {
                goto label_6;
            }
            
            int val_2 = val_1.HasValue.丙东专丂世丈丏丁丂();
            if(val_2 == 5)
            {
                goto label_5;
            }
            
            if(val_2 == 4)
            {
                goto label_4;
            }
            
            if(val_2 == 1)
            {
                goto label_5;
            }
            
            goto label_6;
            label_4:
            丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Competition info window asked");
            label_5:
            this.connectScenePanelEventHint.丛丗丝且世丟丌东万(且丝丘万丅与丈丗一:  丐且丘丑与万丞丑丅, 丁丏丗且上丗下与下:  false);
            label_6:
            System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈> val_3 = 丐且丘丑与万丞丑丅.丌不丅不丞东万专专();
            this.connectScenePanelEventHint.mapEventWindow.七丝丏东东丘丆丒且(且下丕七丙丗丄不七:  new System.Nullable<PGCompany.GameModeEvents.丏丏丙丂下丈七上丈>() {HasValue = val_3.HasValue});
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectScenePanelEventHint.gameObject, 丏业丟一东丂东丘丛:  true);
            this.丙世丞东与丒丐丌七();
        }
        private void 丙世丞东与丒丐丌七()
        {
            if(this.专丏业专不丂一丂丛 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                this.专丏业专不丂一丂丛.Dispose();
            }
            
            this.专丏业专不丂一丂丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PGCompany.GameModeHub.GMHMainView::丏丐不三丘丌不丟不()), 与且专丈不万东一万:  "Map Event Hint");
        }
        internal void 三专丈丒丏不丄丗丌(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            this.丏丐不三丘丌不丟不();
        }
        internal void 一丏丞丘专丘业丈丑(FilterMaps 丝丗丙丞丙丕万业下, 丙且上东下丏丏丟下 与丝丕与丙不与丗丆, CategoryNames 一专七丟丏且丑丄下, bool 丄丕三丞一丌与与丅 = False)
        {
            var val_2 = null;
            MainMenuController.丄丞丁丈与业上丞丟.与东丒业丈丒丛世万(丑丝丏丂且不下一东:  与丝丕与丙不与丗丆, 一专七丟丏且丑丄下:  (一专七丟丏且丑丄下 == 1) ? 0 : 一专七丟丏且丑丄下, 丝丗丙丞丙丕万业下:  丝丗丙丞丙丕万业下, 万且丟七不上丗丑丝:  false);
        }
        internal void 丑丌丙丙丞丗丙七丂()
        {
        
        }
        internal void 丏丐不三丘丌不丟不()
        {
            if(丏丟丏丅丙业丆下专.专业丄丏丂丌丁世且() == true)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.connectScenePanelEventHint.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.connectScenePanelEventHint.mapEventWindow, 丏业丟一东丂东丘丛:  false);
            if(this.专丏业专不丂一丂丛 == null)
            {
                    return;
            }
            
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.专丏业专不丂一丂丛.Dispose();
            this.专丏业专不丂一丂丛 = 0;
        }
        public void U_GoToArmory()
        {
            PGCompany.丌不丞丐世丞三丘丌 val_1 = new PGCompany.丌不丞丐世丞三丘丌();
            if(val_1 != null)
            {
                    .Type = 1;
            }
            else
            {
                    mem[16] = 1;
            }
            
            .ShopCategory = 0;
            if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  val_1)) == null)
            {
                    return;
            }
            
            goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
        }
        internal void 专丆丏且丟丆世丏三(Rilisoft.七丕丟丏三丈一丄世 与丛丛丟丅世丏丐丌)
        {
            var val_9;
            if(this.startMiniGameScreenParent.childCount == 0)
            {
                goto label_4;
            }
            
            val_9 = this;
            if(this.丈丁下丟不不丛丗丏 == null)
            {
                goto label_5;
            }
            
            label_15:
            label_18:
            this.丈丁下丟不不丛丗丏.Setup(丟丘万不丏丕丌丑丟:  与丛丛丟丅世丏丐丌, 丗丅七业丝不三丄三:  BalanceController.东下三专三丏丆丄不(丞三丂七丐丝丆东丈:  与丛丛丟丅世丏丐丌));
            this.不上且丝丙七丙丕丈(丏业丟一东丂东丘丛:  false);
            this.七丘丝丆丏丘丗丏丄 = true;
            return;
            label_4:
            UnityEngine.Transform val_4 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  UnityEngine.Resources.Load<UnityEngine.Transform>(path:  "PanelMiniGame"));
            val_4.parent = this.startMiniGameScreenParent;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
            val_4.localPosition = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            if(val_4 != null)
            {
                    val_4.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            }
            else
            {
                    val_4.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            }
            
            StartMiniGameGuiController val_7 = val_4.GetComponent<StartMiniGameGuiController>();
            val_9 = this;
            this.丈丁下丟不不丛丗丏 = val_7;
            if(val_7 != null)
            {
                goto label_15;
            }
            
            label_5:
            StartMiniGameGuiController val_8 = this.startMiniGameScreenParent.GetComponentInChildren<StartMiniGameGuiController>(includeInactive:  true);
            this.丈丁下丟不不丛丗丏 = val_8;
            if(val_8 != null)
            {
                goto label_18;
            }
            
            goto label_18;
        }
        internal void 丗丗与丝丐业丘丆丈()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
            this.不上且丝丙七丙丕丈(丏业丟一东丂东丘丛:  true);
            this.七丘丝丆丏丘丗丏丄 = false;
        }
        private void 不上且丝丙七丙丕丈(bool 丏业丟一东丂东丘丛)
        {
            bool val_1 = 丏业丟一东丂东丘丛;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObjectHolder, 丏业丟一东丂东丘丛:  val_1);
            this.panelBoxCollider.enabled = val_1;
        }
        private void 丁一丈丑丙且专且丂()
        {
            this.丆丆丄丈与丐丐一丛(上且丁万丝世三丄丂:  PGCompany.GameModeHub.丂丕且丟丌丐万东丗.业丙东丆上丛丑一丁(七丆丒与丗丌丄且丂:  this.丘丅丞下一三三丛丈, 丂丛丑东不丅丈一东:  this.与世丈丟业丏丂丌下));
        }
        internal void 丆丆丄丈与丐丐一丛(PGCompany.GameModeHub.与丂丒一丈丕丏专与 上且丁万丝世三丄丂)
        {
            if((上且丁万丝世三丄丂 - 1) > 5)
            {
                    return;
            }
            
            var val_2 = 106043780 + ((上且丁万丝世三丄丂 - 1)) << 2;
            val_2 = val_2 + 106043780;
            goto (106043780 + ((上且丁万丝世三丄丂 - 1)) << 2 + 106043780);
        }
        public GMHMainView()
        {
            this.上专上七下丆丅下丈 = new System.Collections.Generic.List<PGCompany.GameModeHub.丟与丗不不上丆丞三>();
        }
    
    }

}
