using UnityEngine;

namespace PGCompany
{
    internal sealed class ClanLootBoxInfoUI : StorePromotionInfoUIAbstract
    {
        // Fields
        private UILabel _titleLabel;
        private UILabel _progressLabel;
        private UILabel _progressIncreaseLabel;
        private UILabel _warchestTextLabel;
        private UILabel _giftchestTextLabel;
        private UISprite _progressFill;
        private UISprite _progressFillBack;
        private UISprite _progressFillBuff;
        private UISprite _superchestProgressFill;
        private UILabel _superchestProgressLabel;
        private UITextureMasked _chestIcon;
        private UnityEngine.GameObject _scrollContainer;
        private UnityEngine.GameObject _bottom;
        private UnityEngine.GameObject _progressIncreaseGlow;
        private UnityEngine.GameObject _bgSuperchest;
        private UIButton _buttonGet;
        private UnityEngine.GameObject _item;
        private WidgetLayout _layout;
        private WidgetLayout _chestDropLayout;
        private UIScrollView _view;
        private ScrollViewHelper _scrollViewHelper;
        private float _progressAnimationTime;
        private System.Collections.Generic.List<PGCompany.ClanLootBoxInfoUI.SlotLabelConfig> _slotLabelConfig;
        private PGCompany.InventoryItemView _priceView;
        private UILabel clanRankExpLabel;
        private UILabel noEnoughSilverLabel;
        private UnityEngine.GameObject _superChestBuffGo;
        private UnityEngine.GameObject MultiOpen_Button;
        private UnityEngine.GameObject MultiOpen_CloseButton;
        private UnityEngine.GameObject superChestLabel;
        private UnityEngine.GameObject SingleChest;
        private UnityEngine.GameObject MultiplyChest;
        private UISlider SliderChests;
        private UILabel SelectedBoxLabel;
        private System.Collections.Generic.List<UITextureMasked> selectedChestsIcons;
        private UIGrid gridIconsChests;
        private UnityEngine.Transform deactivateIconsRoot;
        private UnityEngine.GameObject sliderMultiplyChestBlocer;
        private string 丟且下丂丛世丁丅丟;
        private string 不东丏丘丏世丒下丘;
        internal bool 且世东专丞不丆丂丝;
        internal bool 丂丞下三七丞东丄世;
        internal static bool 七丂丑七丑世丂不丒;
        private int 丆丑丆七丏七且不丒;
        private bool 不三丛业下业丈丟一;
        private int 丌丞与丐上东一三下;
        private System.IDisposable 东三世丝丒三一丈丛;
        
        // Properties
        private bool 七世东丟与丅且丗三 { get; }
        
        // Methods
        private bool 丙丅丕丗东万丄丕丕()
        {
            if(this.MultiplyChest == 0)
            {
                    return false;
            }
            
            if(this.MultiplyChest != null)
            {
                    return this.MultiplyChest.activeSelf;
            }
            
            return this.MultiplyChest.activeSelf;
        }
        protected override void OnEnable()
        {
            var val_11;
            this.OnEnable();
            val_11 = null;
            val_11 = null;
            PGCompany.ClanLootBoxInfoUI.七丂丑七丑世丂不丒 = true;
            new System.Action() = new System.Action(object:  this, method:  typeof(PGCompany.ClanLootBoxInfoUI).__il2cppRuntimeField_1B0);
            this.东三世丝丒三一丈丛 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(), 与且专丈不万东一万:  "ClanLootBoxInfoUI_" + this.gameObject.name);
            this.不三丛业下业丈丟一 = false;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sliderMultiplyChestBlocer, 丏业丟一东丂东丘丛:  false);
            PGCompany.ItemExpiryController.丙不世丅丐丛万丅且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>>(object:  this, method:  System.Void PGCompany.ClanLootBoxInfoUI::丈丙丂丒丛丞下丆丂(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 丈与丕七丒不丘丞业)));
            PGCompany.ItemExpiryController.丐丐丞丒下丙丟丂万(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>>(object:  this, method:  System.Void PGCompany.ClanLootBoxInfoUI::丈丙丂丒丛丞下丆丂(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 丈与丕七丒不丘丞业)));
            PGCompany.ClanStoreMainUI.丟丛丂丄丞业万一丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(PGCompany.ClanLootBoxInfoUI).__il2cppRuntimeField_1C0));
            PGCompany.ClanStoreMainUI.丈丆丒三丈丗世丞丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  typeof(PGCompany.ClanLootBoxInfoUI).__il2cppRuntimeField_1C0));
        }
        internal override void 丈且东丑丂且万丒丅(PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, object 一丐丗丁丞丆丅丟丄, PGCompany.丞丙上世丑丕与丁丁 且丒丛与丞世丙丕丌 = 0)
        {
            this.丈且东丑丂且万丒丅(且丘丏丁丑与丙与丁:  且丘丏丁丑与丙与丁, 一丐丗丁丞丆丅丟丄:  0, 且丒丛与丞世丙丕丌:  0);
            this.且世东专丞不丆丂丝 = false;
            if(一丐丗丁丞丆丅丟丄 != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            label_3:
            this.丗丝丛东丘丆东七丒();
            return;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  一丐丗丁丞丆丅丟丄);
            this.且世东专丞不丆丂丝 = null;
            if(null == null)
            {
                goto label_3;
            }
            
            this.且世东专丞不丆丂丝 = false;
            this.丞七丈一上丄丞三丒();
        }
        protected override void OnDisable()
        {
            var val_4;
            this.OnDisable();
            PGCompany.ItemExpiryController.丙不世丅丐丛万丅且(丙业与丙丗丝不丈东:  new System.Action<System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业>>(object:  this, method:  System.Void PGCompany.ClanLootBoxInfoUI::丈丙丂丒丛丞下丆丂(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 丈与丕七丒不丘丞业)));
            new System.Action() = new System.Action(object:  this, method:  typeof(PGCompany.ClanLootBoxInfoUI).__il2cppRuntimeField_1C0);
            PGCompany.ClanStoreMainUI.丟丛丂丄丞业万一丘(丙业与丙丗丝不丈东:  new System.Action());
            this.不三丛业下业丈丟一 = false;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.sliderMultiplyChestBlocer, 丏业丟一东丂东丘丛:  false);
            val_4 = null;
            val_4 = null;
            PGCompany.ClanLootBoxInfoUI.七丂丑七丑世丂不丒 = false;
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.东三世丝丒三一丈丛.Dispose();
        }
        private void 丗丝丛东丘丆东七丒()
        {
            if(this.且世东专丞不丆丂丝 != false)
            {
                    return;
            }
            
            this.丆丑丆七丏七且不丒 = 1;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.noEnoughSilverLabel, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.superChestLabel, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.SingleChest, 丏业丟一东丂东丘丛:  true);
            bool val_1 = this.MultiplyChest.activeSelf;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.MultiplyChest, 丏业丟一东丂东丘丛:  false);
            if(this.与丞丆丑东东丟丆丌().三丘丆丅丝丙一丑与() == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.MultiOpen_Button, 丏业丟一东丂东丘丛:  (this.与丞丆丑东东丟丆丌().业东丅东丌上丗丑不() != 11015) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.MultiOpen_CloseButton, 丏业丟一东丂东丘丛:  false);
        }
        public override void U_Hide()
        {
            if(this.不三丛业下业丈丟一 != false)
            {
                    return;
            }
            
            this.U_Hide();
        }
        public void U_ShowMultiplyChestUI()
        {
            if(this.不三丛业下业丈丟一 != false)
            {
                    return;
            }
            
            if(this.SingleChest.activeSelf != false)
            {
                    this.丞七丈一上丄丞三丒();
                return;
            }
            
            this.丗丝丛东丘丆东七丒();
        }
        private void 丞七丈一上丄丞三丒()
        {
            var val_13;
            PGCompany.三东丏不丗世丅丌丄 val_14;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.SingleChest, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.MultiplyChest, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.MultiOpen_Button, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.MultiOpen_CloseButton, 丏业丟一东丂东丘丛:  true);
            PGCompany.东丑丆丗丏丐丟下丄 val_1 = this.与丞丆丑东东丟丆丌();
            if(val_1 != null)
            {
                    if(val_1.与下不与丐丈丁丈万() != null)
            {
                goto label_5;
            }
            
            }
            
            val_13 = 0;
            label_5:
            Rilisoft.丝丑丂丛万丐丈丘且 val_4 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  val_13.丂丁丏一丙丛业且丌());
            PGCompany.三东丏不丗世丅丌丄 val_6 = null;
            val_14 = val_6;
            val_6 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  79);
            label_8:
            if(0 > this.丌丞与丐上东一三下)
            {
                goto label_7;
            }
            
            if((1.152922E+18f) <= ((float)PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丈丄不七三万丄丁不:  val_6, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})))
            {
                goto label_8;
            }
            
            this.丛丟丒丞丝丂丌一丗();
            label_7:
            this.一丞丗丄世丐专业丑(丙业与丙丗丝不丈东:  (0 != 0) ? 0 : (0 + 1));
            PGCompany.丗丟丄丈东丝丕丄世 val_10 = this.与丞丆丑东东丟丆丌().三丘丆丅丝丙一丑与();
            if(val_10 == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            val_14 = 0;
            goto label_13;
            label_18:
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.selectedChestsIcons.Item[0], 与万丆丛丒万丝丙丑:  val_10);
            val_14 = 1;
            label_13:
            if(val_14 < this.selectedChestsIcons.Count)
            {
                goto label_18;
            }
        
        }
        private void 丛丟丒丞丝丂丌一丗()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.noEnoughSilverLabel, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.superChestLabel, 丏业丟一东丂东丘丛:  false);
        }
        private void 一丞丗丄世丐专业丑(int 丙业与丙丗丝不丈东)
        {
            this.丆丑丆七丏七且不丒 = 丙业与丙丗丝不丈东;
            this.SliderChests.value = UnityEngine.Mathf.Clamp01(value:  ((float)丙业与丙丗丝不丈东 - 1) / (float)this.丌丞与丐上东一三下);
            this.七东丒丙万丅丕七专();
        }
        public void RefreshSliderMultiBox()
        {
            double val_6 = (double)this.丌丞与丐上东一三下;
            val_6 = (System.Math.Round(value:  (double)this.SliderChests.value, digits:  1)) * val_6;
            int val_4 = UnityEngine.Mathf.Clamp(value:  System.Convert.ToInt32(value:  val_6), min:  0, max:  this.丌丞与丐上东一三下);
            this.丆丑丆七丏七且不丒 = val_4;
            float val_7 = (float)this.丌丞与丐上东一三下;
            val_7 = (float)val_4 / val_7;
            this.SliderChests.value = UnityEngine.Mathf.Clamp01(value:  val_7);
            int val_8 = this.丆丑丆七丏七且不丒;
            val_8 = val_8 + 1;
            this.丆丑丆七丏七且不丒 = val_8;
            this.七东丒丙万丅丕七专();
        }
        private void 七东丒丙万丅丕七专()
        {
            int val_13;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            PGCompany.七东万三万丒丏一丁 val_61;
            var val_62;
            var val_64;
            var val_65;
            val_57 = 1;
            goto label_1;
            label_16:
            UITextureMasked val_1 = this.selectedChestsIcons.Item[137138176];
            if(val_57 > this.丆丑丆七丏七且不丒)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1.gameObject, 丏业丟一东丂东丘丛:  false);
                val_1.transform.SetParent(p:  this.deactivateIconsRoot);
            }
            else
            {
                    val_1.transform.SetParent(p:  this.gridIconsChests.transform);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_1.gameObject, 丏业丟一东丂东丘丛:  true);
            }
            
            val_57 = 2;
            label_1:
            if((val_57 - 1) < this.selectedChestsIcons.Count)
            {
                goto label_16;
            }
            
            this.gridIconsChests.enabled = true;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.SelectedBoxLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  "Key_9156"), arg0:  this.丆丑丆七丏七且不丒));
            PGCompany.丗丟丄丈东丝丕丄世 val_12 = this.与丞丆丑东东丟丆丌().三丘丆丅丝丙一丑与();
            if(val_12 == null)
            {
                    return;
            }
            
            if(null != null)
            {
                    return;
            }
            
            val_13 = 0;
            PGCompany.东丑丆丗丏丐丟下丄 val_17 = this.与丞丆丑东东丟丆丌();
            if(val_17 != null)
            {
                    int val_18 = val_17.丂丁丏一丙丛业且丌();
                val_13 = 0;
                val_58 = val_13;
            }
            else
            {
                    val_58 = 0;
            }
            
            if(((-2057264728) & 1) != 0)
            {
                    int val_20 = val_58.丙东专丂世丈丏丁丂() * this.丆丑丆七丏七且不丒;
                val_13 = 0;
                val_59 = val_13;
            }
            else
            {
                    val_59 = 0;
            }
            
            if((val_59.丙东专丂世丈丏丁丂() > (PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丄万且丒与且丆丕丄(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  79), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true}))) && (((-2057264712) & 1) != 0))
            {
                    this.丛丟丒丞丝丂丌一丗();
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.noEnoughSilverLabel, 丏业丟一东丂东丘丛:  false);
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.superChestLabel, 丏业丟一东丂东丘丛:  true);
            }
            
            PGCompany.东丑丆丗丏丐丟下丄 val_22 = this.与丞丆丑东东丟丆丌();
            if(val_22 != null)
            {
                    var val_24 = (val_22.不业丙丒丂丞下丆丙() == 3) ? 1 : 0;
            }
            else
            {
                    val_60 = 0;
            }
            
            if(val_60 != 0)
            {
                    val_61 = 0;
                int val_25 = 丌丅且丗七丘丅丛丑.丞丛丈丐丂丞丅上东();
            }
            else
            {
                    val_61 = val_12;
            }
            
            int val_58 = this.丆丑丆七丏七且不丒;
            val_58 = val_58 * (丌丅且丗七丘丅丛丑.七丛一且丝丆上丅丑(专业丗丛不丕七丐东:  val_61));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanRankExpLabel, 丕丗丘丑丛与丑业丒:  val_58.ToString());
            int val_29 = Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丏丘丒丗丛丁且七丐();
            int val_31 = Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丗丕丂丅与七丕丅丝();
            if(this._progressLabel != 0)
            {
                    val_13 = val_31;
                this._progressLabel.text = System.String.Format(format:  this.丟且下丂丛世丁丅丟, arg0:  val_13, arg1:  val_29);
            }
            
            int val_36 = this.丆丑丆七丏七且不丒 * val_12.丂万丞与丈丙丅丝七();
            int val_37 = this.丆丑丆七丏七且不丒 * (PGCompany.丁丑上丞业丞丟丛上.丂丘丒丕丑七丙丈丑(与丁专世丈且东丌丅:  val_12));
            if(this._progressIncreaseLabel != 0)
            {
                    val_13 = val_37 + val_36;
                this._progressIncreaseLabel.text = System.String.Format(format:  this.不东丏丘丏世丒下丘, arg0:  val_13);
            }
            
            if(this._progressFill != 0)
            {
                    val_62 = null;
                val_62 = null;
                float val_43 = UnityEngine.Mathf.Max(a:  (float)val_29, b:  UnityEngine.Mathf.Epsilon);
                val_43 = (float)val_31 / val_43;
                float val_44 = UnityEngine.Mathf.Clamp01(value:  val_43);
                val_13 = 0;
                this._progressFill.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            if(this._progressFillBack != 0)
            {
                    val_64 = null;
                val_64 = null;
                float val_47 = UnityEngine.Mathf.Max(a:  (float)val_29, b:  UnityEngine.Mathf.Epsilon);
                int val_59 = val_31;
                val_59 = val_36 + val_59;
                val_47 = (float)val_59 / val_47;
                float val_48 = UnityEngine.Mathf.Clamp01(value:  val_47);
                val_13 = 0;
                this._progressFillBack.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            if(this._progressFillBuff != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._progressFillBuff, 丏业丟一东丂东丘丛:  (val_37 > 0) ? 1 : 0);
                val_65 = null;
                val_65 = null;
                float val_52 = UnityEngine.Mathf.Max(a:  (float)val_29, b:  UnityEngine.Mathf.Epsilon);
                int val_60 = val_31;
                val_60 = val_36 + val_60;
                val_60 = val_60 + val_37;
                val_52 = (float)val_60 / val_52;
                float val_53 = UnityEngine.Mathf.Clamp01(value:  val_52);
                val_13 = 0;
                this._progressFillBuff.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            PGCompany.东丑丆丗丏丐丟下丄 val_54 = this.与丞丆丑东东丟丆丌();
            if(val_54 == null)
            {
                    return;
            }
            
            PGCompany.三东丏不丗世丅丌丄 val_55 = val_54.与下不与丐丈丁丈万();
            if(val_55 == null)
            {
                    return;
            }
            
            val_55.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  this.丆丑丆七丏七且不丒 * val_55.丂丁丏一丙丛业且丌());
            this._priceView.Setup(丈丄不七三万丄丁不:  val_55);
        }
        protected override void 丝一丅丆三东丂丞七()
        {
            int val_7;
            UnityEngine.GameObject val_101;
            UnityEngine.Object val_110;
            UnityEngine.GameObject val_119;
            var val_129;
            UIScrollView val_130;
            var val_131;
            ClanLootBoxInfoUI.一三下世一丁丘丁丝 val_132;
            string val_133;
            var val_134;
            var val_135;
            PGCompany.七东万三万丒丏一丁 val_136;
            var val_137;
            UnityEngine.Object val_138;
            var val_139;
            var val_140;
            var val_141;
            var val_143;
            var val_144;
            System.Collections.Generic.IEnumerable<TSource> val_145;
            var val_146;
            var val_147;
            var val_148;
            var val_149;
            var val_150;
            System.Predicate<SlotLabelConfig> val_151;
            var val_152;
            var val_153;
            int val_154;
            val_129;
            ClanLootBoxInfoUI.一三下世一丁丘丁丝 val_1 = null;
            val_132 = val_1;
            val_1 = new ClanLootBoxInfoUI.一三下世一丁丘丁丝();
            if(this.丙丅丕丗东万丄丕丕() != true)
            {
                    this.丆丑丆七丏七且不丒 = 1;
            }
            
            if(this.与丞丆丑东东丟丆丌() == null)
            {
                goto label_2;
            }
            
            val_133 = this.与丞丆丑东东丟丆丌();
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._titleLabel, 丕丗丘丑丛与丑业丒:  val_133);
            PGCompany.丗丟丄丈东丝丕丄世 val_6 = this.与丞丆丑东东丟丆丌().三丘丆丅丝丙一丑与();
            if(val_6 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                goto label_8;
            }
            
            return;
            label_2:
            if(与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() == false)
            {
                    return;
            }
            
            UnityEngine.Debug.LogError(message:  "EROR: Promotion is null. Check me!!");
            return;
            label_8:
            if(this.与丞丆丑东东丟丆丌() != null)
            {
                    var val_12 = (this.与丞丆丑东东丟丆丌().业东丅东丌上丗丑不() == 11015) ? 1 : 0;
            }
            else
            {
                    val_134 = 1;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.MultiOpen_Button, 丏业丟一东丂东丘丛:  (val_134 == 0) ? 1 : 0);
            .专丑丕丄丗丂一丝且 = val_6.丟东丆丙东丄丅不丝();
            PGCompany.东丑丆丗丏丐丟下丄 val_15 = this.与丞丆丑东东丟丆丌();
            if(val_15 != null)
            {
                    var val_17 = (val_15.不业丙丒丂丞下丆丙() == 3) ? 1 : 0;
            }
            else
            {
                    val_135 = 0;
            }
            
            if(val_135 != 0)
            {
                    val_136 = 0;
                int val_18 = 丌丅且丗七丘丅丛丑.丞丛丈丐丂丞丅上东();
            }
            else
            {
                    val_136 = val_6;
            }
            
            int val_129 = this.丆丑丆七丏七且不丒;
            val_129 = val_129 * (丌丅且丗七丘丅丛丑.七丛一且丝丆上丅丑(专业丗丛不丕七丐东:  val_136));
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanRankExpLabel, 丕丗丘丑丛与丑业丒:  val_129.ToString());
            int val_22 = Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丏丘丒丗丛丁且七丐();
            int val_24 = Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丗丕丂丅与七丕丅丝();
            if(this._chestIcon != 0)
            {
                    丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._chestIcon, 与万丆丛丒万丝丙丑:  Rilisoft.Singleton<PGCompany.ClanLootBoxController>.Instance.丂丟丈丈下丑丆上丟());
                this._chestIcon.gameObject.SetActive(value:  true);
            }
            
            PGCompany.东丑丆丗丏丐丟下丄 val_31 = this.与丞丆丑东东丟丆丌();
            int val_32 = this.丆丑丆七丏七且不丒 * (PGCompany.丁丑上丞业丞丟丛上.丂丘丒丕丑七丙丈丑(与丁专世丈且东丌丅:  val_6));
            int val_33 = this.丆丑丆七丏七且不丒 * val_6.丂万丞与丈丙丅丝七();
            val_137 = 1152921505284374528;
            if((val_31 == null) || ((val_31.业上丙丞丐丄丆丅七().Equals(value:  "ClanLootBoxPoints")) == false))
            {
                goto label_49;
            }
            
            if(this._bottom != 0)
            {
                    this._bottom.SetActive(value:  false);
            }
            
            val_138 = 0;
            val_139 = 0;
            if(this._buttonGet == val_138)
            {
                goto label_56;
            }
            
            if(this._buttonGet == null)
            {
                goto label_174;
            }
            
            val_138 = 0;
            UnityEngine.GameObject val_38 = this._buttonGet.gameObject;
            if(val_38 != null)
            {
                    val_138 = 1;
                val_139 = 0;
                val_38.SetActive(value:  true);
            }
            
            if(this._buttonGet == null)
            {
                goto label_174;
            }
            
            var val_39 = (val_24 >= val_22) ? 1 : 0;
            label_56:
            if(this._bgSuperchest != 0)
            {
                    this._bgSuperchest.SetActive(value:  true);
            }
            
            if(this._superchestProgressFill != 0)
            {
                    val_140 = null;
                val_140 = null;
                float val_43 = UnityEngine.Mathf.Max(a:  (float)val_22, b:  UnityEngine.Mathf.Epsilon);
                int val_130 = val_33;
                val_130 = val_130 + val_24;
                val_43 = (float)val_130 / val_43;
                float val_44 = UnityEngine.Mathf.Clamp01(value:  val_43);
                val_7 = 0;
                this._superchestProgressFill.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            if(this._superchestProgressLabel == 0)
            {
                goto label_75;
            }
            
            val_7 = val_24;
            this._superchestProgressLabel.text = System.String.Format(format:  this.丟且下丂丛世丁丅丟, arg0:  val_7, arg1:  val_22);
            goto label_75;
            label_49:
            if(this._bgSuperchest != 0)
            {
                    this._bgSuperchest.SetActive(value:  false);
            }
            
            if(this._bottom != 0)
            {
                    this._bottom.SetActive(value:  true);
            }
            
            if(this._buttonGet != 0)
            {
                    UnityEngine.GameObject val_50 = this._buttonGet.gameObject;
                if(val_50 != null)
            {
                    val_50.SetActive(value:  false);
            }
            
            }
            
            if(this._progressLabel != 0)
            {
                    val_7 = val_24;
                this._progressLabel.text = System.String.Format(format:  this.丟且下丂丛世丁丅丟, arg0:  val_7, arg1:  val_22);
                val_137 = 1152921505284374528;
            }
            
            if(this._progressIncreaseLabel != 0)
            {
                    int val_131 = val_33;
                val_131 = val_32 + val_131;
                val_7 = val_131;
                this._progressIncreaseLabel.text = System.String.Format(format:  this.不东丏丘丏世丒下丘, arg0:  val_7);
            }
            
            if(this._progressFill != 0)
            {
                    val_141 = null;
                val_141 = null;
                float val_57 = UnityEngine.Mathf.Max(a:  (float)val_22, b:  UnityEngine.Mathf.Epsilon);
                val_57 = (float)val_24 / val_57;
                float val_58 = UnityEngine.Mathf.Clamp01(value:  val_57);
                val_7 = 0;
                this._progressFill.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            if(this._progressFillBack != 0)
            {
                    val_143 = null;
                val_143 = null;
                float val_61 = UnityEngine.Mathf.Max(a:  (float)val_22, b:  UnityEngine.Mathf.Epsilon);
                int val_132 = val_33;
                val_132 = val_132 + val_24;
                val_61 = (float)val_132 / val_61;
                float val_62 = UnityEngine.Mathf.Clamp01(value:  val_61);
                val_7 = 0;
                this._progressFillBack.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            if(this._progressFillBuff != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._progressFillBuff, 丏业丟一东丂东丘丛:  (val_32 > 0) ? 1 : 0);
                val_144 = null;
                val_144 = null;
                float val_66 = UnityEngine.Mathf.Max(a:  (float)val_22, b:  UnityEngine.Mathf.Epsilon);
                int val_133 = val_33;
                val_133 = val_133 + val_24;
                val_133 = val_133 + val_32;
                val_66 = (float)val_133 / val_66;
                float val_67 = UnityEngine.Mathf.Clamp01(value:  val_66);
                val_7 = 0;
                this._progressFillBuff.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            PGCompany.东丑丆丗丏丐丟下丄 val_68 = this.与丞丆丑东东丟丆丌();
            if(val_68 == null)
            {
                goto label_121;
            }
            
            if(this._priceView != null)
            {
                goto label_151;
            }
            
            label_152:
            label_151:
            this._priceView.Setup(丈丄不七三万丄丁不:  val_68.与下不与丐丈丁丈万());
            label_75:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._superChestBuffGo, 丏业丟一东丂东丘丛:  (val_32 > 0) ? 1 : 0);
            if(this._warchestTextLabel != null)
            {
                    UnityEngine.GameObject val_71 = this._warchestTextLabel.gameObject;
                if(val_71 != null)
            {
                    val_71.SetActive(value:  false);
            }
            
            }
            
            if(this._giftchestTextLabel != null)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._giftchestTextLabel.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            val_145 = this.与丞丆丑东东丟丆丌();
            if(val_145 != null)
            {
                    PGCompany.三东丏不丗世丅丌丄 val_74 = System.Linq.Enumerable.FirstOrDefault<PGCompany.三东丏不丗世丅丌丄>(source:  val_145);
            }
            
            if((System.String.op_Equality(a:  val_74.业上丙丞丐丄丆丅七(), b:  "wargift_small")) != true)
            {
                    if(this.与丞丆丑东东丟丆丌().不业丙丒丂丞下丆丙() != 3)
            {
                goto label_135;
            }
            
            }
            
            val_146 = 1;
            label_153:
            if(this._bottom != null)
            {
                    this._bottom.SetActive(value:  false);
            }
            
            if(this._buttonGet != null)
            {
                    UnityEngine.GameObject val_79 = this._buttonGet.gameObject;
                if(val_79 != null)
            {
                    val_79.SetActive(value:  false);
            }
            
            }
            
            if(this._warchestTextLabel != null)
            {
                    UnityEngine.GameObject val_80 = this._warchestTextLabel.gameObject;
                if(val_80 != null)
            {
                    val_80.SetActive(value:  true);
            }
            
            }
            
            if(this._chestIcon != null)
            {
                    UnityEngine.GameObject val_81 = this._chestIcon.gameObject;
                if(val_81 != null)
            {
                    val_81.SetActive(value:  false);
            }
            
            }
            
            if(this.与丞丆丑东东丟丆丌().不业丙丒丂丞下丆丙() != 3)
            {
                goto label_150;
            }
            
            if(this._warchestTextLabel != null)
            {
                    UnityEngine.GameObject val_84 = this._warchestTextLabel.gameObject;
                if(val_84 != null)
            {
                    val_84.SetActive(value:  false);
            }
            
            }
            
            if(this._giftchestTextLabel == null)
            {
                goto label_150;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._giftchestTextLabel.gameObject, 丏业丟一东丂东丘丛:  true);
            goto label_150;
            label_121:
            if(this._priceView != null)
            {
                goto label_151;
            }
            
            goto label_152;
            label_135:
            val_146 = 0;
            if(this.丂丞下三七丞东丄世 == false)
            {
                goto label_153;
            }
            
            label_150:
            this._scrollContainer.SetActive(value:  true);
            this._layout.RemoveAll(丏丞丙丌丆丙万丂丛:  true);
            this._item.SetActive(value:  true);
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_86 = this.丌三丝丌不丒丅与丞(丁丗丌三不丏三下丙:  false);
            List.Enumerator<T> val_88 = val_86.丟且丆丙丆丁丆一万(丑七不与丛丆一丂丞:  val_86).GetEnumerator();
            label_172:
            if(((-2056335456) & 1) == 0)
            {
                goto label_158;
            }
            
            UnityEngine.GameObject val_93 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this._item, parent:  this._item.transform.parent, worldPositionStays:  true);
            val_93.GetComponent<PGCompany.InventoryItemView>().Setup(与且专丈不万东一万:  val_7.丐丏七丌丕丗业且上());
            ClanLootBoxInfoItemUI val_95 = val_93.GetComponent<ClanLootBoxInfoItemUI>();
            val_95.丅丞丆东下丌丘丙丈 = this.丌丟丄业且三丛丕丄();
            val_93.GetComponent<ClanLootBoxInfoItemUI>().丈且东丑丂且万丒丅();
            this._layout.widgets.Add(item:  val_93.GetComponent<UIWidget>());
            goto label_172;
            label_158:
            val_147 = -2056335840;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_148 = 1152921505284374528;
            goto label_190;
            label_174:
            val_149 = 0;
            goto label_268;
            label_190:
            this._item.SetActive(value:  false);
            List.Enumerator<T> val_99 = this._slotLabelConfig.GetEnumerator();
            label_196:
            if(((-2056335520) & 1) == 0)
            {
                goto label_193;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_101, 丏业丟一东丂东丘丛:  false);
            goto label_196;
            label_193:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            PGCompany.ClanLootBoxData val_102 = val_6.丁专丗万三上丟三丆();
            Dictionary.Enumerator<TKey, TValue> val_103 = val_102.Slots.GetEnumerator();
            val_132 = 1152921554089987408;
            label_235:
            if(((-2056335552) & 1) == 0)
            {
                goto label_203;
            }
            
            new ClanLootBoxInfoUI.丂不且七一万业七与() = new System.Object();
            string val_106 = val_22.丐丏七丌丕丗业且上();
            if(new ClanLootBoxInfoUI.丂不且七一万业七与() != null)
            {
                    val_150 = new ClanLootBoxInfoUI.丂不且七一万业七与();
                .丐丏东世不丅丌且万 = val_106;
            }
            else
            {
                    mem[16] = val_106;
                val_150 = 16;
            }
            
            if(mem[16].丙东专丂世丈丏丁丂() != 4)
            {
                goto label_206;
            }
            
            val_151 = mem[1152921554090163224];
            if(val_151 == 0)
            {
                goto label_208;
            }
            
            if(this._slotLabelConfig != null)
            {
                goto label_211;
            }
            
            goto label_210;
            label_208:
            val_151 = null;
            val_151 = new System.Predicate<SlotLabelConfig>(object:  val_1, method:  System.Boolean ClanLootBoxInfoUI.一三下世一丁丘丁丝::七丅丐丏丝七丄丏丛(PGCompany.ClanLootBoxInfoUI.SlotLabelConfig 三丟东丕丄丄下下丑));
            mem[1152921554090163224] = val_151;
            if(this._slotLabelConfig != null)
            {
                goto label_211;
            }
            
            label_210:
            label_211:
            SlotLabelConfig val_109 = this._slotLabelConfig.Find(match:  null);
            if(val_110 == 0)
            {
                goto label_235;
            }
            
            int val_112 = mem[16].丙东专丂世丈丏丁丂();
            string val_113 = val_112.上且丁丂不丑丑下万(与丄不丌一世东丁丙:  val_112, 丅丅下丟丑专下与一:  .专丑丕丄丗丂一丝且);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_110, 丏业丟一东丂东丘丛:  丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_113));
            string val_116 = "x " + val_113;
            goto label_235;
            label_206:
            System.Predicate<SlotLabelConfig> val_117 = new System.Predicate<SlotLabelConfig>(object:  new ClanLootBoxInfoUI.丂不且七一万业七与(), method:  System.Boolean ClanLootBoxInfoUI.丂不且七一万业七与::丑专业与不上不七专(PGCompany.ClanLootBoxInfoUI.SlotLabelConfig 三丟东丕丄丄下下丑));
            SlotLabelConfig val_118 = this._slotLabelConfig.Find(match:  null);
            string val_123 = this.上且丁丂不丑丑下万(与丄不丌一世东丁丙:  mem[16].丙东专丂世丈丏丁丂(), 丅丅下丟丑专下与一:  .专丑丕丄丗丂一丝且);
            if((val_146 & 1) != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_119, 丏业丟一东丂东丘丛:  true);
            }
            else
            {
                    if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_123)) != false)
            {
                    val_152 = (~(丞东丑专丛丆丄丝世.丟丕东不丘丆丆丂丛<PGCompany.丗丟丄丈东丝丕丄世>(丑东与丅丐丅丂丞业:  this.业丑丌丟且丑丟丆万(与丄不丌一世东丁丙:  mem[16].丙东专丂世丈丏丁丂(), 丁丗丌三不丏三下丙:  false)))) & 1;
            }
            else
            {
                    val_152 = 0;
            }
            
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_119, 丏业丟一东丂东丘丛:  false);
            }
            
            string val_128 = "x " + val_123;
            goto label_235;
            label_203:
            val_133 = -2056335840;
            val_153 = 0;
            val_131 = 1152921505284374528;
            val_154 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_269;
            }
            
            if(( == 0) || ( == 2026))
            {
                goto label_279;
            }
            
            label_278:
            label_279:
            this._layout.Reposition();
            this._chestDropLayout.Reposition();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._progressIncreaseGlow, 丏业丟一东丂东丘丛:  false);
            val_130 = this._view;
            val_130.ResetPosition();
            if(this._scrollViewHelper == null)
            {
                    return;
            }
            
            this._scrollViewHelper.ScrollToStart(丌与丟丁万丝丞丄丏:  false);
            return;
            label_269:
            if( != 0)
            {
                goto label_278;
            }
            
            goto label_279;
            label_268:
        }
        public void U_ChestBuy()
        {
            var val_40;
            var val_41;
            System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_43;
            int val_44;
            string val_45;
            string val_46;
            val_40 = this;
            if(this.与丞丆丑东东丟丆丌() == null)
            {
                    return;
            }
            
            val_41 = null;
            val_41 = null;
            val_43 = ClanLootBoxInfoUI.<>c.<>9__61_0;
            if(val_43 == null)
            {
                    System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean> val_3 = null;
                val_43 = val_3;
                val_3 = new System.Func<PGCompany.三东丏不丗世丅丌丄, System.Boolean>(object:  ClanLootBoxInfoUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanLootBoxInfoUI.<>c::丅丕丌丕三丗丝丏丗(PGCompany.三东丏不丗世丅丌丄 三丟东丕丄丄下下丑));
                ClanLootBoxInfoUI.<>c.<>9__61_0 = val_43;
            }
            
            if(((System.Linq.Enumerable.Any<PGCompany.三东丏不丗世丅丌丄>(source:  this.与丞丆丑东东丟丆丌(), predicate:  val_3)) == false) || ((Rilisoft.Singleton<ClansController>.Instance.丈丝丒丌丛丙丐丐世(丛上丅丑东丞丄不丁:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 丅专与丒丈丗丒丘丌:  5)) == false))
            {
                goto label_10;
            }
            
            val_40 = Rilisoft.Singleton<ClansController>.Instance.丈丄一丈丆且丕丞丌(丛上丅丑东丞丄不丁:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 丅专与丒丈丗丒丘丌:  5);
            val_44 = 丑丁世丒丅丄丈丑丙.七与丑下丅万丗不丞(丅专与丒丈丗丒丘丌:  5);
            val_45 = "Key_9107";
            goto label_14;
            label_10:
            if(((System.String.op_Equality(a:  this.与丞丆丑东东丟丆丌().业上丙丞丐丄丆丅七(), b:  "Free")) == true) || ((Rilisoft.Singleton<ClansController>.Instance.丈丝丒丌丛丙丐丐世(丛上丅丑东丞丄不丁:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 丅专与丒丈丗丒丘丌:  4)) == false))
            {
                goto label_19;
            }
            
            val_40 = Rilisoft.Singleton<ClansController>.Instance.丈丄一丈丆且丕丞丌(丛上丅丑东丞丄不丁:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗(), 丅专与丒丈丗丒丘丌:  4);
            val_44 = 丑丁世丒丅丄丈丑丙.七与丑下丅万丗不丞(丅专与丒丈丗丒丘丌:  4);
            val_45 = "Key_9106";
            label_14:
            val_46 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9101");
            InfoWindowController.丆丛丈不丏丗丗与七(丏不丄丑丝丁丘万不:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_45), arg0:  val_44), 丂三丟丂丈丐丆丗丟:  (float)val_40, 丛丒丟一万上丒丁七:  val_46);
            return;
            label_19:
            bool val_26 = this.与丞丆丑东东丟丆丌().且丏三丞丝丟丘丅丕();
            PGCompany.东丑丆丗丏丐丟下丄 val_27 = this.与丞丆丑东东丟丆丌();
            if(val_27 == null)
            {
                goto label_27;
            }
            
            if(val_26 == false)
            {
                goto label_28;
            }
            
            label_29:
            val_27.丈丙且一万丟丕万下();
            return;
            label_27:
            if(val_26 == true)
            {
                goto label_29;
            }
            
            label_28:
            PGCompany.三东丏不丗世丅丌丄 val_28 = val_27.与下不与丐丈丁丈万();
            if(val_28 == null)
            {
                goto label_31;
            }
            
            val_28.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  val_28.丂丁丏一丙丛业且丌() * this.丆丑丆七丏七且不丒);
            if(val_28.业东丅东丌上丗丑不() == 10015)
            {
                goto label_34;
            }
            
            val_46 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
            if((val_46.丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_28, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) == true)
            {
                goto label_34;
            }
            
            this.万丞丌七丈丄丙东万(丏丂不专上丘丂不丅:  val_28.业上丙丞丐丄丆丅七());
            return;
            label_31:
            val_28.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  0.丂丁丏一丙丛业且丌() * this.丆丑丆七丏七且不丒);
            label_34:
            this.不三丛业下业丈丟一 = true;
            val_46 = this.sliderMultiplyChestBlocer;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_46, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Coroutine val_38 = this.StartCoroutine(routine:  this.丘下丅不丕世三丐丘(丈丒七下世业丄世专:  val_28));
        }
        private System.Collections.IEnumerator 丘下丅不丕世三丐丘(PGCompany.三东丏不丗世丅丌丄 丈丒七下世业丄世专)
        {
            ClanLootBoxInfoUI.七丑万上与世专万万 val_1 = new ClanLootBoxInfoUI.七丑万上与世专万万();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丈丒七下世业丄世专 = 丈丒七下世业丄世专;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 万丞丌七丈丄丙东万(string 丏丂不专上丘丂不丅)
        {
            var val_5;
            var val_6;
            var val_7;
            val_5 = null;
            val_5 = null;
            BankController.丑七不且上丗丁一世().丏三三不一丘上七且(丐万丂丞万丌丐丞世:  PGCompany.ClanStoreMainUI.丑丝专丐与与业丏丗);
            BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.ClanLootBoxInfoUI::七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            val_6 = null;
            val_6 = null;
            val_7 = null;
            val_7 = null;
            BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业丂丄且丌万三丘丛;
            BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  丏丂不专上丘丂不丅, 丁丕丈丏且丕丒丞丏:  true, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业丂丄且丌万三丘丛);
        }
        private void 七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
        {
            var val_5;
            var val_6;
            BankController.丑七不且上丗丁一世().万一丂不丟丟丄丕丝(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PGCompany.ClanLootBoxInfoUI::七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
            val_5 = null;
            val_5 = null;
            val_6 = null;
            val_6 = null;
            BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.业丂丄且丌万三丘丛;
            BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  false, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.业丂丄且丌万三丘丛);
            if(this.MultiplyChest.activeSelf == false)
            {
                    return;
            }
            
            this.丞七丈一上丄丞三丒();
        }
        internal bool 丞丝丅丞丒丌与丑丅(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
        {
            ScrollViewHelper val_7;
            var val_8;
            val_7 = this;
            .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
            if(this._layout.widgets.Count != 0)
            {
                    int val_4 = this._layout.widgets.FindIndex(match:  new System.Predicate<UIWidget>(object:  new ClanLootBoxInfoUI.世丈丛丒丆丕丗不丒(), method:  System.Boolean ClanLootBoxInfoUI.世丈丛丒丆丕丗不丒::不丟与丆丂丝东业丁(UIWidget 七丞丙丒三丕且丌丟)));
                if(val_4 != 1)
            {
                    val_7 = this._scrollViewHelper;
                val_8 = 1;
                val_7.ScrollTo(不七丘丘丒万七丄丒:  this._layout.widgets.Item[val_4].transform, 丌与丟丁万丝丞丄丏:  true);
                return (bool)val_8;
            }
            
            }
            
            val_8 = 0;
            return (bool)val_8;
        }
        private System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 丌三丝丌不丒丅与丞(bool 丁丗丌三不丏三下丙)
        {
            bool val_1 = 丁丗丌三不丏三下丙;
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_2 = this.业丑丌丟且丑丟丆万(与丄不丌一世东丁丙:  3, 丁丗丌三不丏三下丙:  val_1);
            val_2.AddRange(collection:  this.业丑丌丟且丑丟丆万(与丄不丌一世东丁丙:  6, 丁丗丌三不丏三下丙:  val_1));
            val_2.AddRange(collection:  this.业丑丌丟且丑丟丆万(与丄不丌一世东丁丙:  5, 丁丗丌三不丏三下丙:  val_1));
            val_2.AddRange(collection:  this.业丑丌丟且丑丟丆万(与丄不丌一世东丁丙:  7, 丁丗丌三不丏三下丙:  丁丗丌三不丏三下丙));
            return val_2;
        }
        private System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 业丑丌丟且丑丟丆万(丟三丁与丞丘一东丄 与丄不丌一世东丁丙, bool 丁丗丌三不丏三下丙)
        {
            丟三丁与丞丘一东丄 val_38;
            var val_39;
            var val_40;
            var val_41;
            val_38 = 与丄不丌一世东丁丙;
            ClanLootBoxInfoUI.专丌业丝丈丘万丈专 val_1 = new ClanLootBoxInfoUI.专丌业丝丈丘万丈专();
            if(val_1 != null)
            {
                    val_39 = val_1;
                .丁丗丌三不丏三下丙 = 丁丗丌三不丏三下丙;
            }
            else
            {
                    val_39 = 16;
                mem[16] = 丁丗丌三不丏三下丙;
            }
            
            .丝且与丝丒丟万丁专 = this;
            PGCompany.丗丟丄丈东丝丕丄世 val_5 = this.与丞丆丑东东丟丆丌().三丘丆丅丝丙一丑与();
            if(val_5 == null)
            {
                goto label_4;
            }
            
            if(null == null)
            {
                goto label_5;
            }
            
            val_40 = 0;
            goto label_7;
            label_4:
            val_40 = 0;
            goto label_7;
            label_5:
            if((val_5.丁专丗万三上丟三丆() != null) && (val_7.Slots != null))
            {
                    丟三丁与丞丘一东丄 val_38 = val_38;
                val_38 = (~(val_7.Slots.ContainsKey(key:  val_38))) & 1;
                val_40 = 0;
            }
            else
            {
                    val_40 = 0;
            }
            
            label_7:
            if((((-2054364484) & 1) == 0) || (val_40.GetValueOrDefault() == false))
            {
                goto label_12;
            }
            
            label_50:
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_10 = null;
            val_41 = val_10;
            val_10 = new System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>();
            return (System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>);
            label_12:
            if((val_38 - 1) > 6)
            {
                goto label_50;
            }
            
            var val_39 = 106043492 + ((与丄不丌一世东丁丙 - 1)) << 2;
            val_39 = val_39 + 106043492;
            goto (106043492 + ((与丄不丌一世东丁丙 - 1)) << 2 + 106043492);
        }
        private bool 丆万上丝东不丅丕万(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
        {
            PGCompany.三东丏不丗世丅丌丄 val_12;
            var val_13;
            val_12 = 下丅丙一丂丗丅丝七;
            if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().上丟丘下世七与丁世<PGCompany.世业业丝三丘业三下>(丈丄不七三万丄丁不:  val_12.丑丐丙丄丅世世丑丒(), 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != null)
            {
                    val_13 = 0;
                return (bool)(((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().七丏万丞且丛丌专丞(丒丞丁丞下丝丆不且:  val_12 = val_12.丑丐丙丄丅世世丑丒())) - (PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丂世丐丁丒上丐丏丂(世且丐丐丑丛东专丟:  val_12.业东丅东丌上丗丑不()))) > 0) ? 1 : 0;
            }
            
            return (bool)(((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().七丏万丞且丛丌专丞(丒丞丁丞下丝丆不且:  val_12)) - (PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丂世丐丁丒上丐丏丂(世且丐丐丑丛东专丟:  val_12.业东丅东丌上丗丑不()))) > 0) ? 1 : 0;
        }
        private bool 一一万丌万一丁世万(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
        {
            string val_19;
            三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.丐丗上且丒万丝丛专(丞世不丒下上上丝丑:  下丅丙一丂丗丅丝七.业东丅东丌上丗丑不());
            val_19 = Progress.七七世万专丕丁上业.一万万与七万丄丗丟();
            if((val_19.专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_2.业东丅东丌上丗丑不())) != null)
            {
                    return false;
            }
            
            System.Collections.Generic.KeyValuePair<System.String, System.Int64> val_6 = WeaponManager.万一丛七丙丑丄丆丑();
            val_19 = val_6.Value.System.IConvertible.ToInt64(provider:  public System.String System.Collections.Generic.KeyValuePair<System.String, System.Int64>::get_Key());
            if((System.String.op_Equality(a:  val_19, b:  val_2.与不丞丑七丘丁丂丛())) == true)
            {
                    return false;
            }
            
            val_19 = WeaponManager.七世丂丁丆丙丐丆丌();
            if((val_19.Contains(item:  val_2.与不丞丑七丘丁丂丛())) != false)
            {
                    return false;
            }
            
            var val_18 = ((下丅丙一丂丗丅丝七 + (Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  val_2.与不丞丑七丘丁丂丛()))) <= (BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  val_2.三与丛丑且丐丈业丌()))) ? 1 : 0;
            return false;
        }
        private System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 丟且丆丙丆丁丆一万(System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 丑七不与丛丆一丂丞)
        {
            var val_43;
            var val_45;
            var val_47;
            System.Predicate<PGCompany.丗丟丄丈东丝丕丄世> val_49;
            var val_50;
            var val_52;
            var val_54;
            System.Func<PGCompany.丗丟丄丈东丝丕丄世, 一一万丒与专丙丁丛> val_56;
            var val_57;
            System.Func<PGCompany.丗丟丄丈东丝丕丄世, 一一万丒与专丙丁丛> val_59;
            var val_60;
            ClanLootBoxInfoUI.丆丟专丕东丗业丌丕 val_1 = new ClanLootBoxInfoUI.丆丟专丕东丗业丌丕();
            val_43 = null;
            val_43 = null;
            if((ClanLootBoxInfoUI.<>c.<>9__70_0) == null)
            {
                goto label_3;
            }
            
            label_78:
            System.Collections.Generic.List<T> val_2 = 丑七不与丛丆一丂丞.FindAll(match:  ClanLootBoxInfoUI.<>c.<>9__70_0);
            val_45 = null;
            val_45 = null;
            if((ClanLootBoxInfoUI.<>c.<>9__70_1) == null)
            {
                goto label_7;
            }
            
            label_82:
            System.Collections.Generic.List<T> val_3 = 丑七不与丛丆一丂丞.FindAll(match:  ClanLootBoxInfoUI.<>c.<>9__70_1);
            val_47 = null;
            val_47 = null;
            val_49 = ClanLootBoxInfoUI.<>c.<>9__70_2;
            if(val_49 == null)
            {
                    System.Predicate<PGCompany.丗丟丄丈东丝丕丄世> val_4 = null;
                val_49 = val_4;
                val_4 = new System.Predicate<PGCompany.丗丟丄丈东丝丕丄世>(object:  ClanLootBoxInfoUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanLootBoxInfoUI.<>c::丏丝丟丈丒上丛丐丈(PGCompany.丗丟丄丈东丝丕丄世 七丞丙丒三丕且丌丟));
                ClanLootBoxInfoUI.<>c.<>9__70_2 = val_49;
            }
            
            System.Collections.Generic.List<T> val_5 = 丑七不与丛丆一丂丞.FindAll(match:  val_4);
            val_50 = null;
            val_50 = null;
            if((ClanLootBoxInfoUI.<>c.<>9__70_3) == null)
            {
                goto label_17;
            }
            
            label_86:
            System.Collections.Generic.List<T> val_6 = 丑七不与丛丆一丂丞.FindAll(match:  ClanLootBoxInfoUI.<>c.<>9__70_3);
            val_52 = null;
            val_52 = null;
            if((ClanLootBoxInfoUI.<>c.<>9__70_4) == null)
            {
                goto label_21;
            }
            
            label_90:
            System.Collections.Generic.List<T> val_7 = 丑七不与丛丆一丂丞.FindAll(match:  ClanLootBoxInfoUI.<>c.<>9__70_4);
            .丅丄三丞丘丟一丄且 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丝丌一且丝专丑丛();
            int val_12 = val_3.RemoveAll(match:  new System.Predicate<PGCompany.丗丟丄丈东丝丕丄世>(object:  val_1, method:  System.Boolean ClanLootBoxInfoUI.丆丟专丕东丗业丌丕::丟不丞专下七上丄业(PGCompany.丗丟丄丈东丝丕丄世 七丞丙丒三丕且丌丟)));
            int val_14 = val_5.RemoveAll(match:  new System.Predicate<PGCompany.丗丟丄丈东丝丕丄世>(object:  val_1, method:  System.Boolean ClanLootBoxInfoUI.丆丟专丕东丗业丌丕::丏专丝丛丆丂专丛七(PGCompany.丗丟丄丈东丝丕丄世 七丞丙丒三丕且丌丟)));
            val_54 = null;
            val_54 = null;
            val_56 = ClanLootBoxInfoUI.<>c.<>9__70_7;
            if(val_56 == null)
            {
                    System.Func<PGCompany.丗丟丄丈东丝丕丄世, 一一万丒与专丙丁丛> val_15 = null;
                val_56 = val_15;
                val_15 = new System.Func<PGCompany.丗丟丄丈东丝丕丄世, 一一万丒与专丙丁丛>(object:  ClanLootBoxInfoUI.<>c.__il2cppRuntimeField_static_fields, method:  一一万丒与专丙丁丛 ClanLootBoxInfoUI.<>c::丗丝专丌丘丝与一业(PGCompany.丗丟丄丈东丝丕丄世 七丞丙丒三丕且丌丟));
                ClanLootBoxInfoUI.<>c.<>9__70_7 = val_56;
            }
            
            System.Collections.Generic.List<TSource> val_17 = System.Linq.Enumerable.ToList<PGCompany.丗丟丄丈东丝丕丄世>(source:  System.Linq.Enumerable.OrderByDescending<PGCompany.丗丟丄丈东丝丕丄世, 一一万丒与专丙丁丛>(source:  val_3, keySelector:  val_15));
            val_57 = null;
            val_57 = null;
            val_59 = ClanLootBoxInfoUI.<>c.<>9__70_8;
            if(val_59 == null)
            {
                    System.Func<PGCompany.丗丟丄丈东丝丕丄世, 一一万丒与专丙丁丛> val_18 = null;
                val_59 = val_18;
                val_18 = new System.Func<PGCompany.丗丟丄丈东丝丕丄世, 一一万丒与专丙丁丛>(object:  ClanLootBoxInfoUI.<>c.__il2cppRuntimeField_static_fields, method:  一一万丒与专丙丁丛 ClanLootBoxInfoUI.<>c::丅丕丄丆专丙丕丘世(PGCompany.丗丟丄丈东丝丕丄世 七丞丙丒三丕且丌丟));
                ClanLootBoxInfoUI.<>c.<>9__70_8 = val_59;
            }
            
            System.Collections.Generic.List<TSource> val_20 = System.Linq.Enumerable.ToList<PGCompany.丗丟丄丈东丝丕丄世>(source:  System.Linq.Enumerable.OrderByDescending<PGCompany.丗丟丄丈东丝丕丄世, 一一万丒与专丙丁丛>(source:  val_5, keySelector:  val_18));
            val_2.Reverse();
            val_7.Reverse();
            System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> val_21 = new System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世>();
            val_60 = 0;
            goto label_40;
            label_74:
            if(val_2.Count > val_60)
            {
                    val_21.Add(item:  val_2.Item[0]);
            }
            
            if(val_17.Count > val_60)
            {
                    val_21.Add(item:  val_17.Item[0]);
            }
            
            if(val_20.Count > val_60)
            {
                    val_21.Add(item:  val_20.Item[0]);
            }
            
            if(val_6.Count > val_60)
            {
                    val_21.Add(item:  val_6.Item[0]);
            }
            
            if(val_7.Count > val_60)
            {
                    val_21.Add(item:  val_7.Item[0]);
            }
            
            val_60 = 1;
            label_40:
            int[] val_32 = new int[5];
            val_32[0] = val_2.Count;
            val_32[0] = val_17.Count;
            val_32[1] = val_20.Count;
            val_32[1] = val_6.Count;
            val_32[2] = val_7.Count;
            if(val_60 < (UnityEngine.Mathf.Max(values:  val_32)))
            {
                goto label_74;
            }
            
            return val_21;
            label_3:
            ClanLootBoxInfoUI.<>c.<>9__70_0 = new System.Predicate<PGCompany.丗丟丄丈东丝丕丄世>(object:  ClanLootBoxInfoUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanLootBoxInfoUI.<>c::万丄丝东丄且且丐一(PGCompany.丗丟丄丈东丝丕丄世 七丞丙丒三丕且丌丟));
            if(丑七不与丛丆一丂丞 != null)
            {
                goto label_78;
            }
            
            goto label_78;
            label_7:
            ClanLootBoxInfoUI.<>c.<>9__70_1 = new System.Predicate<PGCompany.丗丟丄丈东丝丕丄世>(object:  ClanLootBoxInfoUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanLootBoxInfoUI.<>c::丑七丈东丟丌丛与专(PGCompany.丗丟丄丈东丝丕丄世 七丞丙丒三丕且丌丟));
            if(丑七不与丛丆一丂丞 != null)
            {
                goto label_82;
            }
            
            goto label_82;
            label_17:
            ClanLootBoxInfoUI.<>c.<>9__70_3 = new System.Predicate<PGCompany.丗丟丄丈东丝丕丄世>(object:  ClanLootBoxInfoUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanLootBoxInfoUI.<>c::丙一丛专万丁世丞一(PGCompany.丗丟丄丈东丝丕丄世 七丞丙丒三丕且丌丟));
            if(丑七不与丛丆一丂丞 != null)
            {
                goto label_86;
            }
            
            goto label_86;
            label_21:
            ClanLootBoxInfoUI.<>c.<>9__70_4 = new System.Predicate<PGCompany.丗丟丄丈东丝丕丄世>(object:  ClanLootBoxInfoUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanLootBoxInfoUI.<>c::丛丟丕丆与世丘丗且(PGCompany.丗丟丄丈东丝丕丄世 七丞丙丒三丕且丌丟));
            if(丑七不与丛丆一丂丞 != null)
            {
                goto label_90;
            }
            
            goto label_90;
        }
        private string 上且丁丂不丑丑下万(丟三丁与丞丘一东丄 与丄不丌一世东丁丙, PGCompany.ClanLootBoxData.DivisionConfig 丅丅下丟丑专下与一)
        {
            int val_24;
            int val_26;
            val_24 = 丅丅下丟丑专下与一;
            if((与丄不丌一世东丁丙 - 1) <= 6)
            {
                    var val_22 = 106043464 + ((与丄不丌一世东丁丙 - 1)) << 2;
                val_22 = val_22 + 106043464;
            }
            else
            {
                    val_26 = System.String.alignConst;
                return (string)System.String.Format(format:  "{0} - {1}", arg0:  null, arg1:  null);
            }
        
        }
        private void 丈丙丂丒丛丞下丆丂(System.Collections.Generic.List<PGCompany.丌丐下丌丘下丝丞业> 丈与丕七丒不丘丞业)
        {
            var val_10;
            var val_11;
            System.Predicate<PGCompany.丌丐下丌丘下丝丞业> val_13;
            val_10 = this;
            val_11 = null;
            val_11 = null;
            val_13 = ClanLootBoxInfoUI.<>c.<>9__73_0;
            if(val_13 == null)
            {
                goto label_3;
            }
            
            label_9:
            if((丈与丕七丒不丘丞业.Exists(match:  val_13)) == false)
            {
                    return;
            }
            
            val_10 = ???;
            val_13 = ???;
            goto typeof(PGCompany.ClanLootBoxInfoUI).__il2cppRuntimeField_1B8;
            label_3:
            ClanLootBoxInfoUI.<>c.<>9__73_0 = new System.Predicate<PGCompany.丌丐下丌丘下丝丞业>(object:  ClanLootBoxInfoUI.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ClanLootBoxInfoUI.<>c::丘万丏业丗丅丌丗万(PGCompany.丌丐下丌丘下丝丞业 下丅丙一丂丗丅丝七));
            if(丈与丕七丒不丘丞业 != null)
            {
                goto label_9;
            }
            
            goto label_9;
        }
        public ClanLootBoxInfoUI()
        {
            this._progressAnimationTime = 0.4f;
            this._slotLabelConfig = new System.Collections.Generic.List<SlotLabelConfig>();
            this.丟且下丂丛世丁丅丟 = "{0}/{1}";
            this.丂丞下三七丞东丄世 = true;
            this.丆丑丆七丏七且不丒 = true;
            this.不东丏丘丏世丒下丘 = "+{0}";
            this.丌丞与丐上东一三下 = 9;
        }
        private static ClanLootBoxInfoUI()
        {
        
        }
    
    }

}
