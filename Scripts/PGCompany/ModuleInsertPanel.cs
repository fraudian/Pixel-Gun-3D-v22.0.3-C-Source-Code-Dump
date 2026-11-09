using UnityEngine;

namespace PGCompany
{
    internal class ModuleInsertPanel : MonoBehaviour
    {
        // Fields
        private static System.Action 万下且丏丗下与丂丗;
        private static System.Action 丗丟丟业丑世丁下一;
        internal static bool 东丅丞丁丗万且丁丗;
        private PGCompany.ModuleStorageView _moduleStorageView;
        private PGCompany.ModuleView _selectedModuleView;
        private PGCompany.ModuleInsertPropertiesView _moduleInsertPropertiesView;
        private UIPanel _scrollPanel;
        private UIScrollView _scrollStored;
        private UIGrid _gridStored;
        private PGCompany.ModuleInStoredView _storedModuleViewExample;
        private UnityEngine.GameObject _buttonAddModule;
        private UnityEngine.GameObject _buttonRemoveModule;
        private UnityEngine.GameObject _errorContainer;
        private UILabel _errorCountLabel;
        private UILabel _errorTypeLabel;
        private UILabel _errorWeightLabel;
        private UILabel _errorHasElementalLabel;
        private UnityEngine.GameObject _itemNameContainer;
        private System.Collections.Generic.List<UILabel> _itemNameLabels;
        private PGCompany.ModuleRemoveConfirmPanel _removeConfirmPanel;
        private UnityEngine.GameObject _modulesTutorialInsertWeaponModule;
        private UnityEngine.GameObject _modulesTutorialClose;
        private UnityEngine.GameObject _modulesTutorialInsertArmorModule;
        private UnityEngine.GameObject _modulesTutorialHintAfterLastStep;
        private UnityEngine.GameObject _clanContainer;
        private UnityEngine.GameObject _infoWindow;
        private UIBasicSprite _itemTexture;
        private UnityEngine.GameObject gotGadgetAnimation;
        private float gotGadgetAnimationDutation;
        private 丙且上东下丏丏丟下 丂三下七万丛一丁丕;
        private PGCompany.丗丟丅七东丄丙丟上 丂丐丗专丞与丄丕万;
        private PGCompany.丏丂一丗丙世丏丐三 丆不三不丈与三上丘;
        private PGCompany.ModuleSlotView 丘七丗丘丌专世丛下;
        private System.Action 丂七丝丝丌一丈丌丆;
        private System.Collections.Generic.List<PGCompany.ModuleInStoredView> 丕丐七丙下丑丞东业;
        private int 七丆丛且上丙不丕万;
        private int 丆下丝丒丌丕三东丘;
        private float 丛七丑丏丑丕七丏不;
        private bool 丆世不丄业丘丆且丒;
        private System.IDisposable 丐丆七且丞丏下三丙;
        
        // Properties
        public bool 丐丆丏下世丘丁丏一 { get; }
        
        // Methods
        internal static void 丒下丟丏三丛丄不丈(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Combine(a:  PGCompany.ModuleInsertPanel.万下且丏丗下与丂丗, b:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 一下七丄专丛三丝丐(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            val_4 = System.Delegate.Remove(source:  PGCompany.ModuleInsertPanel.万下且丏丗下与丂丗, value:  丙业与丙丗丝不丈东);
            if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
            val_5 = null;
            val_5 = null;
        }
        internal static void 丗丑与与丗丞三丂一(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  PGCompany.ModuleInsertPanel.丗丟丟业丑世丁下一, b:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ModuleInsertPanel.丗丟丟业丑世丁下一 != 1152921505624952840);
        
        }
        internal static void 丘东不万与上东世上(System.Action 丙业与丙丗丝不丈东)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  PGCompany.ModuleInsertPanel.丗丟丟业丑世丁下一, value:  丙业与丙丗丝不丈东);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(PGCompany.ModuleInsertPanel.丗丟丟业丑世丁下一 != 1152921505624952840);
        
        }
        private void Awake()
        {
            丆丟七丌丞东丆丕丌.万且丆丌专丘丆丙丟(丙业与丙丗丝不丈东:  new System.Action<ModuleGadgetRecord, ModuleGadgetRecord>(object:  this, method:  System.Void PGCompany.ModuleInsertPanel::丝丘丐丟丘丄丐丝丑(ModulesSetGadgetsStorage.ModuleGadgetRecord 丒丂与丙丁丝丅丑世, ModulesSetGadgetsStorage.ModuleGadgetRecord 业丝专丙丆世丞下丛)));
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._storedModuleViewExample, 丏业丟一东丂东丘丛:  false);
        }
        private void OnDestroy()
        {
            丆丟七丌丞东丆丕丌.一丏丝一三丆丞丙丐(丙业与丙丗丝不丈东:  new System.Action<ModuleGadgetRecord, ModuleGadgetRecord>(object:  this, method:  System.Void PGCompany.ModuleInsertPanel::丝丘丐丟丘丄丐丝丑(ModulesSetGadgetsStorage.ModuleGadgetRecord 丒丂与丙丁丝丅丑世, ModulesSetGadgetsStorage.ModuleGadgetRecord 业丝专丙丆世丞下丛)));
        }
        public void HideHintAfterLastModulesTutorialStep()
        {
            this.丟丙且丝万与不丑丐(三丗丑丙丅业丙丙三:  false);
        }
        public void HandleInfoButton()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._infoWindow, 丏业丟一东丂东丘丛:  true);
        }
        public void HandleBackFromInfoButton()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._infoWindow, 丏业丟一东丂东丘丛:  false);
        }
        internal void 丈且东丑丂且万丒丅(丙且上东下丏丏丟下 丑丝丏丂且不下一东, PGCompany.丗丟丅七东丄丙丟上 丑专丆丟丟丐丆一丕)
        {
            this.丂三下七万丛一丁丕 = 丑丝丏丂且不下一东;
            this.丂丐丗专丞与丄丕万 = 丑专丆丟丟丐丆一丕;
            UnityEngine.Texture val_3 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "OfferIcons/"("OfferIcons/") + 丑丝丏丂且不下一东.业上丙丞丐丄丆丅七() + "_icon1_big");
            if(this._itemTexture == null)
            {
                
            }
        
        }
        private void OnEnable()
        {
            var val_10;
            var val_11;
            var val_12;
            bool val_13;
            val_10 = null;
            val_10 = null;
            if(SquadController.丄丘七三上丕世丞业 != 0)
            {
                    val_11 = null;
                val_11 = null;
                val_12 = SquadController.丄丘七三上丕世丞业.inSquad;
            }
            else
            {
                    val_12 = 0;
            }
            
            if((val_12 | GameConnect.上丏丈七丘丁与丅丏()) != true)
            {
                    if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == false)
            {
                goto label_15;
            }
            
            }
            
            val_13 = 0;
            goto label_16;
            label_15:
            val_13 = UnityEngine.Object.op_Equality(x:  GameController.丑七不且上丗丁一世(), y:  0);
            label_16:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._clanContainer, 丏业丟一东丂东丘丛:  val_13);
            if(this.丂丐丗专丞与丄丕万 == null)
            {
                    return;
            }
            
            this.上不专三丞业丞丅业();
            if(this.丆世不丄业丘丆且丒 != false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.丞丌丅与丒丅丅上丏());
        }
        private System.Collections.IEnumerator 丞丌丅与丒丅丅上丏()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ModuleInsertPanel.丟丙丛丞丘丄七丅且();
        }
        private void 上不专三丞业丞丅业()
        {
            丙且上东下丏丏丟下 val_19;
            PGCompany.丏丂一丗丙世丏丐三 val_20;
            PGCompany.ModuleSlotView val_21;
            val_19 = this.丂三下七万丛一丁丕;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemNameContainer, 丏业丟一东丂东丘丛:  (val_19 != 0) ? 1 : 0);
            if(this.丂三下七万丛一丁丕 != null)
            {
                    .丟下丟丈万一丙东丄 = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  this.丂三下七万丛一丁丕.业上丙丞丐丄丆丅七(), 七丆丒与丗丌丄且丂:  this.丂三下七万丛一丁丕.丒万丕七专不丏丞丌());
                val_19 = this._itemNameLabels;
                val_19.ForEach(action:  new System.Action<UILabel>(object:  new ModuleInsertPanel.丛世且不丕丕东丒三(), method:  System.Void ModuleInsertPanel.丛世且不丕丕东丒三::丟上三丑一丟业丏丛(UILabel 三丟东丕丄丄下下丑)));
            }
            
            this.丟丏七七丅三世丏七();
            System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> val_7 = this.丂丐丗专丞与丄丕万.丆丟且丗丒不丄七丌();
            this.丆不三不丈与三上丘 = 0;
            this.丘七丗丘丌专世丛下 = 0;
            if(val_7.Count >= 1)
            {
                    this.丆不三不丈与三上丘 = val_7.Item[0];
                System.Predicate<PGCompany.ModuleSlotView> val_10 = null;
                val_19 = val_10;
                val_10 = new System.Predicate<PGCompany.ModuleSlotView>(object:  this, method:  System.Boolean PGCompany.ModuleInsertPanel::丁丗丐丑丞且丁丞下(PGCompany.ModuleSlotView 三丟东丕丄丄下下丑));
                this.丘七丗丘丌专世丛下 = this._moduleStorageView.三丝一丙上丞专丏丌.Find(match:  val_10);
            }
            else
            {
                    System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_12 = this.三七丒三丐丑丁丑丂();
                if(val_12.Count >= 1)
            {
                    if((val_12.Item[0] != null) && (null != null))
            {
                    val_20 = 0;
            }
            
                this.丆不三不丈与三上丘 = val_20;
                System.Predicate<PGCompany.ModuleInStoredView> val_16 = null;
                val_19 = val_16;
                val_16 = new System.Predicate<PGCompany.ModuleInStoredView>(object:  this, method:  System.Boolean PGCompany.ModuleInsertPanel::丘丙不丟一丏丏丕丟(PGCompany.ModuleInStoredView 三丟东丕丄丄下下丑));
                val_21 = 0;
                if((this.丕丐七丙下丑丞东业.Find(match:  val_16)) != 0)
            {
                    val_21 = val_17._moduleSlotView;
            }
            
                this.丘七丗丘丌专世丛下 = val_21;
            }
            
            }
            
            this.丈丄七丙三上万丌丂();
            this._scrollStored.ResetPosition();
        }
        private void 丘上丐世丆丑且丞丒()
        {
            var val_25;
            var val_26;
            val_25 = this;
            if(this.丆世不丄业丘丆且丒 == true)
            {
                    return;
            }
            
            this.丆世不丄业丘丆且丒 = true;
            UIWidget val_1 = this._storedModuleViewExample.GetComponent<UIWidget>();
            float val_25 = this._gridStored.cellWidth;
            val_25 = this._scrollPanel.width / val_25;
            this.七丆丛且上丙不丕万 = UnityEngine.Mathf.FloorToInt(f:  val_25);
            float val_26 = this._gridStored.cellHeight;
            val_26 = this._scrollPanel.height / val_26;
            this.丆下丝丒丌丕三东丘 = UnityEngine.Mathf.CeilToInt(f:  val_26);
            float val_9 = this._scrollPanel.width;
            float val_10 = val_9 / (float)this.七丆丛且上丙不丕万;
            val_9 = val_10 - (UnityEngine.Mathf.Max(a:  0f, b:  this._gridStored.cellWidth - (float)val_1.width));
            val_9 = val_9 / (float)val_1.width;
            this.丛七丑丏丑丕七丏不 = val_9;
            this._gridStored.cellWidth = val_10;
            this._gridStored.cellHeight = val_10;
            this._gridStored.maxPerLine = this.七丆丛且上丙不丕万;
            丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<PGCompany.ModuleInStoredView>(专下丐丒丈万丗丟丝:  this.丕丐七丙下丑丞东业, 专丑业丁丗丏丌不丛:  this._storedModuleViewExample.gameObject, 丈东丘丏与丌东东下:  this._gridStored.transform, 与业丄丂丂丆下上丞:  this.丆下丝丒丌丕三东丘 * this.七丆丛且上丙不丕万, 丏东下下一丗专下丏:  0);
            val_26 = null;
            val_26 = null;
            if((ModuleInsertPanel.<>c.<>9__53_0) == null)
            {
                goto label_22;
            }
            
            label_37:
            this.丕丐七丙下丑丞东业.ForEach(action:  ModuleInsertPanel.<>c.<>9__53_0);
            UnityEngine.Vector3 val_17 = this._scrollPanel.transform.localPosition;
            UnityEngine.Vector3 val_20 = this._scrollPanel.transform.localPosition;
            val_25 = this._scrollPanel.transform;
            UnityEngine.Vector3 val_22 = val_25.localPosition;
            float val_27 = 0.5f;
            float val_23 = this._scrollPanel.width * val_27;
            val_23 = val_17.x - val_23;
            val_27 = val_10 * val_27;
            val_27 = val_27 + val_23;
            this._scrollPanel.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            return;
            label_22:
            ModuleInsertPanel.<>c.<>9__53_0 = new System.Action<PGCompany.ModuleInStoredView>(object:  ModuleInsertPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ModuleInsertPanel.<>c::丘丄且业下丞万专丕(PGCompany.ModuleInStoredView 三丟东丕丄丄下下丑));
            if(this.丕丐七丙下丑丞东业 != null)
            {
                goto label_37;
            }
            
            goto label_37;
        }
        public void U_GoToClanShopInClanLootbox()
        {
            this.丅丕下丑三下丌丝下();
        }
        private void 丅丕下丑三下丌丝下()
        {
            null = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == null)
            {
                    return;
            }
            
            ShopNGUIController.丏丙丅丕一丑丕丑丑.丂丅世东丘丛丘丕丟(且丂专丄丄丕丝丈一:  1);
        }
        public void Show(System.Action 业丏丈世世世丞丒世)
        {
            var val_5;
            this.丂七丝丝丌一丈丌丆 = 业丏丈世世世丞丒世;
            this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void PGCompany.ModuleInsertPanel::丐专丑不丝丐与丝万()), 与且专丈不万东一万:  "ModuleInsertPanel");
            this.gameObject.SetActive(value:  true);
            val_5 = null;
            val_5 = null;
            PGCompany.ModuleInsertPanel.东丅丞丁丗万且丁丗 = true;
            val_5 = null;
            if(PGCompany.ModuleInsertPanel.万下且丏丗下与丂丗 != null)
            {
                    PGCompany.ModuleInsertPanel.万下且丏丗下与丂丗.Invoke();
            }
            
            this.丟丙且丝万与不丑丐(三丗丑丙丅业丙丙三:  false);
        }
        internal void 丟丙且丝万与不丑丐(bool 三丗丑丙丅业丙丙三)
        {
            var val_16;
            var val_17;
            var val_18;
            if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丝丛三七世丙丂专丈() == 3)
            {
                    val_16 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
            }
            else
            {
                    val_16 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._modulesTutorialInsertWeaponModule, 丏业丟一东丂东丘丛:  false);
            if(((业丈不上丟万一丕丏.丑七不且上丗丁一世().丝丛三七世丙丂专丈() == 4) && (this.丂三下七万丛一丁丕 != null)) && ((上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  this.丂三下七万丛一丁丕.丒万丕七专不丏丞丌())) != false))
            {
                    val_17 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
            }
            else
            {
                    val_17 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._modulesTutorialClose, 丏业丟一东丂东丘丛:  false);
            if(((业丈不上丟万一丕丏.丑七不且上丗丁一世().丝丛三七世丙丂专丈() == 4) && (this.丂三下七万丛一丁丕 != null)) && (this.丂三下七万丛一丁丕.丒万丕七专不丏丞丌() == 7))
            {
                    val_18 = (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1;
            }
            else
            {
                    val_18 = 0;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._modulesTutorialInsertArmorModule, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._modulesTutorialHintAfterLastStep, 丏业丟一东丂东丘丛:  false);
        }
        internal void 丐专丑不丝丐与丝万()
        {
            var val_8;
            if(this._infoWindow.activeSelf != false)
            {
                    this.HandleBackFromInfoButton();
                return;
            }
            
            丏丙丌丐万七丒东丑 val_3 = 业丈不上丟万一丕丏.丑七不且上丗丁一世().丝丛三七世丙丂专丈();
            val_8 = null;
            val_8 = null;
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != true)
            {
                    if(val_3 == 3)
            {
                    return;
            }
            
                if(val_3 == 4)
            {
                    if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
            {
                    if(ShopNGUIController.丏丙丅丕一丑丕丑丑.丗丛丐丑丛丅丞七且() == 7)
            {
                    return;
            }
            
            }
            
            }
            
                if(this._modulesTutorialHintAfterLastStep.activeInHierarchy != false)
            {
                    return;
            }
            
            }
            
            this.Hide();
        }
        public void Hide()
        {
            var val_5;
            var val_6;
            if(this.丐丆七且丞丏下三丙 != null)
            {
                    var val_4 = 0;
                val_4 = val_4 + 1;
                this.丐丆七且丞丏下三丙.Dispose();
                this.丐丆七且丞丏下三丙 = 0;
            }
            
            if(this.丂七丝丝丌一丈丌丆 != null)
            {
                    this.丂七丝丝丌一丈丌丆.Invoke();
            }
            
            this.gameObject.SetActive(value:  false);
            val_5 = null;
            val_5 = null;
            PGCompany.ModuleInsertPanel.东丅丞丁丗万且丁丗 = false;
            val_5 = null;
            if(PGCompany.ModuleInsertPanel.丗丟丟业丑世丁下一 != null)
            {
                    PGCompany.ModuleInsertPanel.丗丟丟业丑世丁下一.Invoke();
            }
            
            if(ShopNGUIController.丛世丛与丌不丈丐丐() == false)
            {
                    return;
            }
            
            val_6 = null;
            val_6 = null;
            ShopNGUIController.丏丙丅丕一丑丕丑丑.业不不且丐且与不与(世万丐专世丕业丟东:  0);
        }
        public void AddModule()
        {
            if((PGCompany.七丆丆丕丂丙丕丐丂.丒丅与丛业与丒丑业(世丝七与丝丒丐业下:  this.丂丐丗专丞与丄丕万, 丕上业丕丘上丘七一:  this.丆不三不丈与三上丘)) == false)
            {
                    return;
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  63);
            丆丟七丌丞东丆丕丌.丅丌丕且丐不三丛丙(丑专丆丟丟丐丆一丕:  this.丂丐丗专丞与丄丕万, 丙上下三丈世丑丂丗:  this.丆不三不丈与三上丘, 丈万一且不与丝丅专:  this.丂三下七万丛一丁丕.业上丙丞丐丄丆丅七());
            PGCompany.丁丞丐丈丒七丟丛七.丑七不且上丗丁一世().丘丂万丅丈丄丁丒丄(丑专丆丟丟丐丆一丕:  this.丂丐丗专丞与丄丕万, 丕上业丕丘上丘七一:  this.丆不三不丈与三上丘, 丑丝丏丂且不下一东:  this.丂三下七万丛一丁丕);
            this.丟丏七七丅三世丏七();
            this.丘七丗丘丌专世丛下 = this._moduleStorageView.三丝一丙上丞专丏丌.Find(match:  new System.Predicate<PGCompany.ModuleSlotView>(object:  this, method:  System.Boolean PGCompany.ModuleInsertPanel::丁丌世与丙丙且东下(PGCompany.ModuleSlotView 三丟东丕丄丄下下丑)));
            this.丈丄七丙三上万丌丂();
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioClip val_8 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Snd\\kinetic_module_add");
                if(val_8 != 0)
            {
                    UnityEngine.AudioSource val_10 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_8);
            }
            
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        public bool get_CanRemoveSelectedModule()
        {
            return PGCompany.七丆丆丕丂丙丕丐丂.丏丘丅丂丟万丂丛专(世丝七与丝丒丐业下:  this.丂丐丗专丞与丄丕万, 丕上业丕丘上丘七一:  this.丆不三不丈与三上丘);
        }
        public void TryRemoveModule()
        {
            if((PGCompany.七丆丆丕丂丙丕丐丂.丏丘丅丂丟万丂丛专(世丝七与丝丒丐业下:  this.丂丐丗专丞与丄丕万, 丕上业丕丘上丘七一:  this.丆不三不丈与三上丘)) == false)
            {
                    return;
            }
            
            this.丆专丆世专丐丈七专();
        }
        private void 丆专丆世专丐丈七专()
        {
            PGCompany.ModuleSlotView val_13;
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  62);
            丆丟七丌丞东丆丕丌.丙丈丘且业且丘不丌(丑专丆丟丟丐丆一丕:  this.丂丐丗专丞与丄丕万, 丞丛一一丏丂下丝不:  this.丆不三不丈与三上丘, 丈万一且不与丝丅专:  this.丂三下七万丛一丁丕.业上丙丞丐丄丆丅七());
            PGCompany.丁丞丐丈丒七丟丛七.丑七不且上丗丁一世().丄丐业丒专丆丙丟丏(丑专丆丟丟丐丆一丕:  this.丂丐丗专丞与丄丕万, 丕上业丕丘上丘七一:  this.丆不三不丈与三上丘, 丑丝丏丂且不下一东:  this.丂三下七万丛一丁丕);
            Rilisoft.一丟专且三万丞丁丂.丗丗丛上专一丒丝丕(丕且丏丞业业一上丕:  this.丆不三不丈与三上丘.业上丙丞丐丄丆丅七(), 丁丟丆七丞上丅东丑:  0);
            this.丟丏七七丅三世丏七();
            val_13 = 0;
            if((this.丕丐七丙下丑丞东业.Find(match:  new System.Predicate<PGCompany.ModuleInStoredView>(object:  this, method:  System.Boolean PGCompany.ModuleInsertPanel::东丏丏丁专丝丏七三(PGCompany.ModuleInStoredView 三丟东丕丄丄下下丑)))) != 0)
            {
                    val_13 = val_6._moduleSlotView;
            }
            
            this.丘七丗丘丌专世丛下 = val_13;
            this.丈丄七丙三上万丌丂();
            if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
            {
                    UnityEngine.AudioClip val_9 = UnityEngine.Resources.Load<UnityEngine.AudioClip>(path:  "Snd\\to_deck");
                if(val_9 != 0)
            {
                    UnityEngine.AudioSource val_11 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_9);
            }
            
            }
            
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        internal void 丌丌丘丝一丂丅一丄(PGCompany.ModuleSlotView 一专上丑丐丆丄上丟)
        {
            this.丘七丗丘丌专世丛下 = 一专上丑丐丆丄上丟;
            this.丆不三不丈与三上丘 = 一专上丑丐丆丄上丟.<丆世七丘丈丞丅世上>k__BackingField;
            this.丈丄七丙三上万丌丂();
        }
        internal void 丝一丅丆三东丂丞七()
        {
            this.丟丏七七丅三世丏七();
            this.丈丄七丙三上万丌丂();
        }
        private void 丟丏七七丅三世丏七()
        {
            UIGrid val_20;
            PGCompany.丗丟丅七东丄丙丟上 val_21;
            var val_22;
            PGCompany.丏丂一丗丙世丏丐三 val_23;
            var val_24;
            System.Action<PGCompany.ModuleInStoredView> val_26;
            System.Action<T> val_27;
            val_20 = this;
            val_21 = this.丂丐丗专丞与丄丕万;
            if(val_21 != null)
            {
                    this._moduleStorageView.丂丐丗专丞与丄丕万 = val_21;
                this._moduleStorageView.丝一丅丆三东丂丞七();
            }
            
            if(this.丆世不丄业丘丆且丒 == false)
            {
                    return;
            }
            
            if(this.丂丐丗专丞与丄丕万 != null)
            {
                    val_22 = this.三七丒三丐丑丁丑丂();
            }
            else
            {
                    System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_2 = null;
                val_22 = val_2;
                val_2 = new System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>();
            }
            
            float val_20 = (float)val_2.Count;
            val_20 = val_20 / (float)this.七丆丛且上丙不丕万;
            val_21 = UnityEngine.Mathf.Max(a:  this.七丆丛且上丙不丕万 * this.丆下丝丒丌丕三东丘, b:  this.七丆丛且上丙不丕万 * (UnityEngine.Mathf.CeilToInt(f:  val_20)));
            丞东丑专丛丆丄丝世.七一三丈丕三丆丅三<PGCompany.ModuleInStoredView>(专下丐丒丈万丗丟丝:  this.丕丐七丙下丑丞东业, 专丑业丁丗丏丌不丛:  this._storedModuleViewExample.gameObject, 丈东丘丏与丌东东下:  this._gridStored.transform, 与业丄丂丂丆下上丞:  val_21, 丏东下下一丗专下丏:  0);
            val_23 = 1152921505625108480;
            val_24 = null;
            val_24 = null;
            val_26 = ModuleInsertPanel.<>c.<>9__67_0;
            if(val_26 == null)
            {
                goto label_15;
            }
            
            label_38:
            val_27 = val_26;
            this.丕丐七丙下丑丞东业.ForEach(action:  val_27);
            if(val_21 < 1)
            {
                goto label_17;
            }
            
            var val_21 = 0;
            label_33:
            if(val_21 >= val_2.Count)
            {
                goto label_20;
            }
            
            val_23 = val_2.Item[0];
            if((val_23 == null) || (null == null))
            {
                goto label_23;
            }
            
            label_20:
            val_23 = 0;
            label_23:
            this.丕丐七丙下丑丞东业.Item[0].丈且东丑丂且万丒丅(世丝七与丝丒丐业下:  this.丂丐丗专丞与丄丕万, 丕上业丕丘上丘七一:  val_23);
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_16.x, y = val_16.y, z = val_16.z}, d:  this.丛七丑丏丑丕七丏不);
            this.丕丐七丙下丑丞东业.Item[0].transform.localScale = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            val_26 = this.丕丐七丙下丑丞东业.Item[0];
            val_27 = 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_26, 丏业丟一东丂东丘丛:  true);
            val_21 = val_21 + 1;
            if(val_21 < val_21)
            {
                goto label_33;
            }
            
            label_17:
            val_20 = this._gridStored;
            return;
            label_15:
            ModuleInsertPanel.<>c.<>9__67_0 = new System.Action<PGCompany.ModuleInStoredView>(object:  ModuleInsertPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ModuleInsertPanel.<>c::上丒万一丗业业丟丕(PGCompany.ModuleInStoredView 三丟东丕丄丄下下丑));
            if(this.丕丐七丙下丑丞东业 != null)
            {
                goto label_38;
            }
            
            goto label_38;
        }
        private System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 三七丒三丐丑丁丑丂()
        {
            object val_21;
            var val_22;
            var val_23;
            var val_25;
            object val_27;
            val_21 = this;
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().三与专下上丘丏下丂(丁丅丈丌丟世丗丗丟:  126, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true});
            val_22 = 1152921505625108480;
            val_23 = null;
            val_23 = null;
            if((ModuleInsertPanel.<>c.<>9__68_0) == null)
            {
                goto label_4;
            }
            
            label_20:
            System.Collections.Generic.List<T> val_5 = val_2.FindAll(match:  ModuleInsertPanel.<>c.<>9__68_0).FindAll(match:  new System.Predicate<PGCompany.丗丟丄丈东丝丕丄世>(object:  this, method:  System.Boolean PGCompany.ModuleInsertPanel::丌丆专不丁与丄与丝(PGCompany.丗丟丄丈东丝丕丄世 三丟东丕丄丄下下丑)));
            if(业丈不上丟万一丕丏.丑七不且上丗丁一世().丌丗丑业丁上丆万七() == false)
            {
                goto label_14;
            }
            
            val_25 = null;
            val_25 = null;
            if((ModuleInsertPanel.<>c.<>9__68_3) == null)
            {
                goto label_11;
            }
            
            label_24:
            System.Collections.Generic.List<T> val_8 = val_5.FindAll(match:  ModuleInsertPanel.<>c.<>9__68_3);
            if(val_8.Count >= 1)
            {
                    ModuleInsertPanel.丑丆丟丈上与丁丕下 val_10 = null;
                val_27 = val_10;
                val_10 = new ModuleInsertPanel.丑丆丟丈上与丁丕下();
                .丂丒丁丑与三丟一丌 = System.Linq.Enumerable.First<PGCompany.丗丟丄丈东丝丕丄世>(source:  val_8);
                val_22 = 1152921504616005632;
                val_21 = System.Linq.Enumerable.OrderByDescending<PGCompany.丗丟丄丈东丝丕丄世, System.Int32>(source:  val_5, keySelector:  new System.Func<PGCompany.丗丟丄丈东丝丕丄世, System.Int32>(object:  this, method:  System.Int32 PGCompany.ModuleInsertPanel::一丛业丆万万丐丏丂(PGCompany.丗丟丄丈东丝丕丄世 三丟东丕丄丄下下丑)));
                System.Linq.IOrderedEnumerable<TSource> val_15 = System.Linq.Enumerable.ThenByDescending<PGCompany.丗丟丄丈东丝丕丄世, System.Int32>(source:  val_21, keySelector:  new System.Func<PGCompany.丗丟丄丈东丝丕丄世, System.Int32>(object:  val_10, method:  System.Int32 ModuleInsertPanel.丑丆丟丈上与丁丕下::丞上丘丏丟丅丞三丘(PGCompany.丗丟丄丈东丝丕丄世 三丟东丕丄丄下下丑)));
                return (System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>)System.Linq.Enumerable.ToList<PGCompany.丗丟丄丈东丝丕丄世>(source:  System.Linq.Enumerable.OrderByDescending<PGCompany.丗丟丄丈东丝丕丄世, System.Int32>(source:  val_5, keySelector:  System.Func<PGCompany.丗丟丄丈东丝丕丄世, System.Int32> val_16 = null));
            }
            
            label_14:
            val_27 = val_16;
            val_16 = new System.Func<PGCompany.丗丟丄丈东丝丕丄世, System.Int32>(object:  this, method:  System.Int32 PGCompany.ModuleInsertPanel::丟丝丛一丁丙丑丛丈(PGCompany.丗丟丄丈东丝丕丄世 三丟东丕丄丄下下丑));
            return (System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>)System.Linq.Enumerable.ToList<PGCompany.丗丟丄丈东丝丕丄世>(source:  System.Linq.Enumerable.OrderByDescending<PGCompany.丗丟丄丈东丝丕丄世, System.Int32>(source:  val_5, keySelector:  val_16));
            label_4:
            ModuleInsertPanel.<>c.<>9__68_0 = new System.Predicate<PGCompany.丗丟丄丈东丝丕丄世>(object:  ModuleInsertPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ModuleInsertPanel.<>c::丅七丗东丐丘丄丕上(PGCompany.丗丟丄丈东丝丕丄世 三丟东丕丄丄下下丑));
            if(val_2 != null)
            {
                goto label_20;
            }
            
            goto label_20;
            label_11:
            ModuleInsertPanel.<>c.<>9__68_3 = new System.Predicate<PGCompany.丗丟丄丈东丝丕丄世>(object:  ModuleInsertPanel.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ModuleInsertPanel.<>c::丌七东三与丅业丑丐(PGCompany.丗丟丄丈东丝丕丄世 三丟东丕丄丄下下丑));
            if(val_5 != null)
            {
                goto label_24;
            }
            
            goto label_24;
        }
        private void 丈丄七丙三上万丌丂()
        {
            bool val_18;
            var val_19;
            System.Action<T> val_20;
            var val_21;
            UILabel val_22;
            this._selectedModuleView.丙丄七万三丁丆丅丅 = this.丆不三不丈与三上丘;
            this._selectedModuleView.丝一丅丆三东丂丞七();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._selectedModuleView, 丏业丟一东丂东丘丛:  (this.丆不三不丈与三上丘 != 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._errorContainer, 丏业丟一东丂东丘丛:  (this.丆不三不丈与三上丘 != 0) ? 1 : 0);
            if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
            {
                    val_18 = 0;
            }
            else
            {
                    val_18 = PGCompany.七丆丆丕丂丙丕丐丂.丒丅与丛业与丒丑业(世丝七与丝丒丐业下:  this.丂丐丗专丞与丄丕万, 丕上业丕丘上丘七一:  this.丆不三不丈与三上丘);
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._buttonAddModule, 丏业丟一东丂东丘丛:  val_18);
            this._moduleInsertPropertiesView.丂丐丗专丞与丄丕万 = this.丂丐丗专丞与丄丕万;
            this._moduleInsertPropertiesView.丆不三不丈与三上丘 = this.丆不三不丈与三上丘;
            this._moduleInsertPropertiesView.丝一丅丆三东丂丞七();
            if((this.丂丐丗专丞与丄丕万.专丙七丞丆丝丆与丗(丕上业丕丘上丘七一:  this.丆不三不丈与三上丘)) != false)
            {
                    val_19 = this._moduleStorageView.三丝一丙上丞专丏丌.Contains(item:  this.丘七丗丘丌专世丛下);
            }
            else
            {
                    val_19 = 0;
            }
            
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this._buttonRemoveModule, 丏业丟一东丂东丘丛:  val_19 & (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()));
            this.丕丐七丙下丑丞东业.ForEach(action:  new System.Action<PGCompany.ModuleInStoredView>(object:  this, method:  System.Void PGCompany.ModuleInsertPanel::世丅丑上丑下丞丁丛(PGCompany.ModuleInStoredView 三丟东丕丄丄下下丑)));
            System.Action<PGCompany.ModuleSlotView> val_10 = null;
            val_20 = val_10;
            val_10 = new System.Action<PGCompany.ModuleSlotView>(object:  this, method:  System.Void PGCompany.ModuleInsertPanel::上不丅上丗上丑丌丟(PGCompany.ModuleSlotView 三丟东丕丄丄下下丑));
            this._moduleStorageView.三丝一丙上丞专丏丌.ForEach(action:  val_10);
            if(this.丆不三不丈与三上丘 == null)
            {
                    return;
            }
            
            System.Collections.Generic.List<System.Int32> val_11 = this.丂丐丗专丞与丄丕万.丗不万东丟七东丆东(丕上业丕丘上丘七一:  this.丆不三不丈与三上丘);
            val_20 = this._errorCountLabel;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_20, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._errorTypeLabel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._errorWeightLabel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._errorHasElementalLabel, 丏业丟一东丂东丘丛:  false);
            if(val_19 != 0)
            {
                    return;
            }
            
            if((val_11.Contains(item:  5)) != false)
            {
                    val_21 = null;
                val_22 = this._errorCountLabel;
            }
            else
            {
                    if((val_11.Contains(item:  2)) != false)
            {
                    val_21 = null;
                val_22 = this._errorTypeLabel;
            }
            else
            {
                    if((val_11.Contains(item:  4)) != false)
            {
                    val_21 = null;
                val_22 = this._errorWeightLabel;
            }
            else
            {
                    if((val_11.Contains(item:  6)) == false)
            {
                    return;
            }
            
                val_21 = null;
                val_22 = this._errorHasElementalLabel;
            }
            
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_22, 丏业丟一东丂东丘丛:  true);
        }
        private void 丝丘丐丟丘丄丐丝丑(ModulesSetGadgetsStorage.ModuleGadgetRecord 丒丂与丙丁丝丅丑世, ModulesSetGadgetsStorage.ModuleGadgetRecord 业丝专丙丆世丞下丛)
        {
            if(业丝专丙丆世丞下丛 == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gotGadgetAnimation, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Coroutine val_2 = CoroutineRunner.丝世下丆业丘上丆上(丙不三七上丑丗丑丏:  this.gotGadgetAnimationDutation, 丌专业且丛丏丞丝且:  new System.Action(object:  this, method:  System.Void PGCompany.ModuleInsertPanel::丄丛丄不下丄不丝丁()));
        }
        public ModuleInsertPanel()
        {
            this.gotGadgetAnimationDutation = 1f;
            this.丕丐七丙下丑丞东业 = new System.Collections.Generic.List<PGCompany.ModuleInStoredView>();
            this.丛七丑丏丑丕七丏不 = 1f;
        }
        private static ModuleInsertPanel()
        {
        
        }
        private bool 丁丗丐丑丞且丁丞下(PGCompany.ModuleSlotView 三丟东丕丄丄下下丑)
        {
            return System.String.op_Equality(a:  三丟东丕丄丄下下丑.<丆世七丘丈丞丅世上>k__BackingField.业上丙丞丐丄丆丅七(), b:  this.丆不三不丈与三上丘.业上丙丞丐丄丆丅七());
        }
        private bool 丘丙不丟一丏丏丕丟(PGCompany.ModuleInStoredView 三丟东丕丄丄下下丑)
        {
            return System.String.op_Equality(a:  三丟东丕丄丄下下丑._moduleSlotView.<丆世七丘丈丞丅世上>k__BackingField.业上丙丞丐丄丆丅七(), b:  this.丆不三不丈与三上丘.业上丙丞丐丄丆丅七());
        }
        private bool 丁丌世与丙丙且东下(PGCompany.ModuleSlotView 三丟东丕丄丄下下丑)
        {
            return System.String.op_Equality(a:  三丟东丕丄丄下下丑.<丆世七丘丈丞丅世上>k__BackingField.业上丙丞丐丄丆丅七(), b:  this.丆不三不丈与三上丘.业上丙丞丐丄丆丅七());
        }
        private bool 东丏丏丁专丝丏七三(PGCompany.ModuleInStoredView 三丟东丕丄丄下下丑)
        {
            return System.String.op_Equality(a:  三丟东丕丄丄下下丑._moduleSlotView.<丆世七丘丈丞丅世上>k__BackingField.业上丙丞丐丄丆丅七(), b:  this.丆不三不丈与三上丘.业上丙丞丐丄丆丅七());
        }
        private bool 丌丆专不丁与丄与丝(PGCompany.丗丟丄丈东丝丕丄世 三丟东丕丄丄下下丑)
        {
            PGCompany.丗丟丄丈东丝丕丄世 val_4 = 三丟东丕丄丄下下丑;
            if(this.丂丐丗专丞与丄丕万 == null)
            {
                goto label_1;
            }
            
            if(val_4 != null)
            {
                goto label_2;
            }
            
            return (bool)this.丂丐丗专丞与丄丕万.丛上丌七丗丙丄丞万(丕上业丕丘上丘七一:  val_4 = 0);
            label_1:
            if(val_4 == null)
            {
                    return (bool)this.丂丐丗专丞与丄丕万.丛上丌七丗丙丄丞万(丕上业丕丘上丘七一:  val_4);
            }
            
            label_2:
            if(null == null)
            {
                    return (bool)this.丂丐丗专丞与丄丕万.丛上丌七丗丙丄丞万(丕上业丕丘上丘七一:  val_4);
            }
            
            return (bool)this.丂丐丗专丞与丄丕万.丛上丌七丗丙丄丞万(丕上业丕丘上丘七一:  val_4);
        }
        private int 一丛业丆万万丐丏丂(PGCompany.丗丟丄丈东丝丕丄世 三丟东丕丄丄下下丑)
        {
            PGCompany.丗丟丄丈东丝丕丄世 val_5 = 三丟东丕丄丄下下丑;
            if(this.丂丐丗专丞与丄丕万 == null)
            {
                goto label_1;
            }
            
            if(val_5 != null)
            {
                goto label_2;
            }
            
            return (int)丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  this.丂丐丗专丞与丄丕万.下丅丕丗专丄丛丛丕(丕上业丕丘上丘七一:  val_5 = 0));
            label_1:
            if(val_5 == null)
            {
                    return (int)丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  this.丂丐丗专丞与丄丕万.下丅丕丗专丄丛丛丕(丕上业丕丘上丘七一:  val_5));
            }
            
            label_2:
            if(null == null)
            {
                    return (int)丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  this.丂丐丗专丞与丄丕万.下丅丕丗专丄丛丛丕(丕上业丕丘上丘七一:  val_5));
            }
            
            return (int)丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  this.丂丐丗专丞与丄丕万.下丅丕丗专丄丛丛丕(丕上业丕丘上丘七一:  val_5));
        }
        private int 丟丝丛一丁丙丑丛丈(PGCompany.丗丟丄丈东丝丕丄世 三丟东丕丄丄下下丑)
        {
            PGCompany.丗丟丄丈东丝丕丄世 val_5 = 三丟东丕丄丄下下丑;
            if(this.丂丐丗专丞与丄丕万 == null)
            {
                goto label_1;
            }
            
            if(val_5 != null)
            {
                goto label_2;
            }
            
            return (int)丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  this.丂丐丗专丞与丄丕万.下丅丕丗专丄丛丛丕(丕上业丕丘上丘七一:  val_5 = 0));
            label_1:
            if(val_5 == null)
            {
                    return (int)丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  this.丂丐丗专丞与丄丕万.下丅丕丗专丄丛丛丕(丕上业丕丘上丘七一:  val_5));
            }
            
            label_2:
            if(null == null)
            {
                    return (int)丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  this.丂丐丗专丞与丄丕万.下丅丕丗专丄丛丛丕(丕上业丕丘上丘七一:  val_5));
            }
            
            return (int)丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  this.丂丐丗专丞与丄丕万.下丅丕丗专丄丛丛丕(丕上业丕丘上丘七一:  val_5));
        }
        private void 世丅丑上丑下丞丁丛(PGCompany.ModuleInStoredView 三丟东丕丄丄下下丑)
        {
            PGCompany.ModuleSlotView val_2;
            var val_3;
            if(三丟东丕丄丄下下丑 != null)
            {
                    val_2 = 三丟东丕丄丄下下丑._moduleSlotView;
                val_3 = val_2;
            }
            else
            {
                    val_3 = 28563616;
                val_2 = 28563616;
            }
            
            PGCompany.ModuleSlotView val_2 = this.丘七丗丘丌专世丛下;
            val_2 = UnityEngine.Object.op_Equality(x:  val_2, y:  val_2);
            val_3.丄丑万丑不丑丟下丄(丂丛丑东不丅丈一东:  val_2);
        }
        private void 上不丅上丗上丑丌丟(PGCompany.ModuleSlotView 三丟东丕丄丄下下丑)
        {
            PGCompany.ModuleSlotView val_2 = this.丘七丗丘丌专世丛下;
            val_2 = UnityEngine.Object.op_Equality(x:  三丟东丕丄丄下下丑, y:  val_2);
            三丟东丕丄丄下下丑.丄丑万丑不丑丟下丄(丂丛丑东不丅丈一东:  val_2);
        }
        private void 丄丛丄不下丄不丝丁()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gotGadgetAnimation, 丏业丟一东丂东丘丛:  false);
        }
    
    }

}
