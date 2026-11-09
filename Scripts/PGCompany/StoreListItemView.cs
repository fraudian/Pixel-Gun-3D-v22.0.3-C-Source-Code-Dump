using UnityEngine;

namespace PGCompany
{
    internal class StoreListItemView : PGBehaviour
    {
        // Fields
        private EndlessScroll _scroll;
        private UIWidget _scrollHolder;
        private PGCompany.InventoryItemView _itemView;
        private System.Collections.Generic.List<PGCompany.StoreListItemView.ScrollSettings> _scrollSettings;
        private System.Collections.Generic.List<UIRect> _rectsToUpdate;
        private StoreCharacterHelper _character;
        private UnityEngine.GameObject _buttonShoot;
        private UnityEngine.GameObject _lockInfoView;
        private WidgetLayout _widgetLayout;
        private PGCompany.ItemButtonEquip _buttonEquip;
        private PGCompany.ItemButtonPurchase _buttonPurchase;
        private PGCompany.ItemButtonUpgrade _buttonUpgrade;
        private PGCompany.ItemButtonCraft _buttonCraft;
        private PGCompany.ItemButtonAddDetail _buttonAddDetail;
        private UIButton _buttonShowBlockInfo;
        private UIButton _buttonGetPartsWeapons;
        private UIButton _buttonToArmory;
        private UnityEngine.GameObject _boughtArmorClosedByDivision;
        private UILabel _boughtArmorClosedByDivisionLabel;
        private UISprite _boughtArmorClosedByDivisionShield;
        private UIButton _propertiesPopupButton;
        private PropertiesPopupController _propertiesPopupController;
        public UnityEngine.GameObject GadgetBannerGo;
        private System.Collections.Generic.List<PGCompany.ItemButtonAbstract> 丕不万业七不且七万;
        private System.Collections.Generic.List<PGCompany.丟丁且丝丁三丏丙且> 专丙丌一与业三专丛;
        private int 东七丛丝丑专世丏三;
        private int 东丗丘丄东丒七下下;
        private PGCompany.丟丁且丝丁三丏丙且 七丒丙不丅且万万丂;
        internal UnityEngine.MonoBehaviour 丏世丑业丟世上丏丟;
        
        // Properties
        internal PropertiesPopupController 丒一丏东丁丑下且丈 { get; }
        internal UIButton 丘丒丕丒丂丅丌丂三 { get; }
        internal StoreCharacterHelper 丙世丐万丆丌上丕丘 { get; }
        private System.Collections.Generic.List<PGCompany.ItemButtonAbstract> 业丁上一丌三三上世 { get; }
        
        // Methods
        internal PropertiesPopupController 丛且丒万丞丝丞丝丕()
        {
            return (PropertiesPopupController)this._propertiesPopupController;
        }
        internal UIButton 业丝丆丙丂东丁东业()
        {
            return (UIButton)this._propertiesPopupButton;
        }
        public void HandlePropertiesPopupButton()
        {
            string val_4;
            if(this.七丒丙不丅且万万丂 == null)
            {
                goto label_2;
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_1 = this.七丒丙不丅且万万丂.丒丅丙丄丞丟下丏业();
            if(val_1 == null)
            {
                goto label_2;
            }
            
            val_4 = val_1.业上丙丞丐丄丆丅七();
            goto label_3;
            label_2:
            val_4 = 0;
            label_3:
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) == true)
            {
                    return;
            }
            
            if(this._propertiesPopupController == null)
            {
                    return;
            }
            
            this._propertiesPopupController.丈且东丑丂且万丒丅(丒东业不丐丑丕丄丆:  val_4);
        }
        internal StoreCharacterHelper 丟丑万与丒与不下丛()
        {
            return (StoreCharacterHelper)this._character;
        }
        private System.Collections.Generic.List<PGCompany.ItemButtonAbstract> 七丞丌丑与世丁丗业()
        {
            if(this.丕不万业七不且七万 != null)
            {
                    return (System.Collections.Generic.List<PGCompany.ItemButtonAbstract>)val_2;
            }
            
            System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<PGCompany.ItemButtonAbstract>(source:  this._scroll.GetComponentsInChildren<PGCompany.ItemButtonAbstract>(includeInactive:  true));
            this.丕不万业七不且七万 = val_2;
            return (System.Collections.Generic.List<PGCompany.ItemButtonAbstract>)val_2;
        }
        internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.丟丁且丝丁三丏丙且> 丑七不与丛丆一丂丞)
        {
            this.东丄一丅丈业丅丏一();
            if(this._character != 0)
            {
                    this._character.丛丄丘不七万丞丂丅(丙业与丙丗丝不丈东:  true);
            }
            
            this.丄丆丙东丆且丌丄专(与不丕丆丈不丙丟丛:  this.丄丆丌丟一上丁三且());
            this.不与丞下业丑丒丙万();
            this.下丌业业丐丘丐丘三();
            this.专丙丌一与业三专丛 = 丑七不与丛丆一丂丞;
            this._scroll.Init(上专丅业三丏丈丈丗:  丑七不与丛丆一丂丞.Count, 丏丑丝万下与丁丞业:  0, 世万丐专世丕业丟东:  true);
            this._scroll.三丅不丘丏丛丑专丅();
        }
        private void 下下丂丗丌上七东丕(int 丞世不丒下上上丝丑)
        {
            this.东专丑七与丟丁上丗(丞世不丒下上上丝丑:  丞世不丒下上上丝丑, 丝与丏丙丗上世丏丞:  false);
        }
        private void 东专丑七与丟丁上丗(int 丞世不丒下上上丝丑, bool 丝与丏丙丗上世丏丞 = False)
        {
            int val_8;
            int val_9;
            PGCompany.丟丁且丝丁三丏丙且 val_10;
            val_8 = 丞世不丒下上上丝丑;
            this.东七丛丝丑专世丏三 = val_8;
            if((val_8 & 2147483648) != 0)
            {
                    if(this.专丙丌一与业三专丛.Count <= val_8)
            {
                    return;
            }
            
                val_9 = this.东七丛丝丑专世丏三;
            }
            
            val_10 = this.专丙丌一与业三专丛.Item[val_9];
            if(val_10 == null)
            {
                    return;
            }
            
            PGCompany.StoreItemSettings val_3 = val_10.丏丘下丞丘不丑万丏();
            if(val_3.ItemParams == null)
            {
                    return;
            }
            
            PGCompany.StoreItemSettings val_4 = val_10.丏丘下丞丘不丑万丏();
            if((this.东丗丘丄东丒七下下 == val_4.ItemParams.业东丅东丌上丗丑不()) && (丝与丏丙丗上世丏丞 != true))
            {
                    this.东一下丝丅丟业丂东(丅丘丌且丈丘丄丗丄:  val_10);
            }
            else
            {
                    this.东丄一丅丈业丅丏一();
                this.三丈丅丂丌丟丙丁丁(丅丘丌且丈丘丄丗丄:  val_10);
            }
            
            PGCompany.StoreItemSettings val_6 = val_10.丏丘下丞丘不丑万丏();
            this.东丗丘丄东丒七下下 = val_6.ItemParams.业东丅东丌上丗丑不();
        }
        internal void 丗丆且丈七丄丟丌丝(PGCompany.丟丁且丝丁三丏丙且 丅丘丌且丈丘丄丗丄)
        {
            var val_4;
            PGCompany.StoreListItemView val_20;
            var val_21;
            var val_22;
            PGCompany.三东丏不丗世丅丌丄 val_23;
            UnityEngine.Transform val_24;
            val_20 = this;
            StoreListItemView.专丏丌丏丑东万丝专 val_1 = new StoreListItemView.专丏丌丏丑东万丝专();
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = val_20;
            }
            else
            {
                    mem[16] = val_20;
            }
            
            .丘丞上专万丑世丂三 = 0;
            List.Enumerator<T> val_2 = this._scroll.cellsList.GetEnumerator();
            val_21 = 0;
            goto label_5;
            label_25:
            string val_5 = val_4.丐丏七丌丕丗业且上();
            val_22 = 0;
            if(( == 0) || (((System.String.__il2cppRuntimeField_typeHierarchy + (PGCompany.StoreItemEndlessScrollCell.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_5 : 0 + 208.丏丘下丞丘不丑万丏()) == null))
            {
                goto label_17;
            }
            
            val_23 = (System.String.__il2cppRuntimeField_typeHierarchy + (PGCompany.StoreItemEndlessScrollCell.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_5 : 0 + 208.丏丘下丞丘不丑万丏();
            if(val_9.ItemParams == null)
            {
                goto label_17;
            }
            
            PGCompany.StoreItemSettings val_10 = (System.String.__il2cppRuntimeField_typeHierarchy + (PGCompany.StoreItemEndlessScrollCell.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? val_5 : 0 + 208.丏丘下丞丘不丑万丏();
            PGCompany.StoreItemSettings val_12 = 丅丘丌且丈丘丄丗丄.丏丘下丞丘不丑万丏();
            val_23 = val_12.ItemParams;
            if((val_10.ItemParams.业东丅东丌上丗丑不().Equals(obj:  val_23.业东丅东丌上丗丑不())) == true)
            {
                goto label_24;
            }
            
            label_17:
            val_21 = -1;
            label_5:
            if(((-166896832) & 1) != 0)
            {
                goto label_25;
            }
            
            label_29:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_1 != null)
            {
                goto label_46;
            }
            
            goto label_27;
            label_24:
            .丘丞上专万丑世丂三 = transform;
            goto label_29;
            label_27:
            label_46:
            val_24 = (StoreListItemView.专丏丌丏丑东万丝专)[1152921555979605920].丘丞上专万丑世丂三;
            if(val_24 != 0)
            {
                    System.Action val_17 = null;
                val_24 = val_17;
                val_17 = new System.Action(object:  val_1, method:  System.Void StoreListItemView.专丏丌丏丑东万丝专::万丙丒世丝七丈与与());
                UnityEngine.Coroutine val_18 = CoroutineRunner.DoWithDelay(七丐丅专且专七三丆:  val_17, 业丗七丕万万不丈丗:  1);
            }
            
            if(val_21 == 0)
            {
                    return;
            }
            
            if((StoreListItemView.专丏丌丏丑东万丝专)[1152921555979605920].丘丞上专万丑世丂三 == 0)
            {
                    return;
            }
            
            val_20 = 0;
            this._scroll.SetSelected(丞世不丒下上上丝丑:  0);
        }
        private void 丕丑丌丛丅丐东丙丒()
        {
            this._scroll.scroll.StopMomentumForce();
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            this._scroll.transform.localPosition = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
            UnityEngine.Vector2 val_3 = UnityEngine.Vector2.zero;
            this._scroll.panel.clipOffset = new UnityEngine.Vector2() {x = val_3.x, y = val_3.y};
            this.UpdateRects();
        }
        internal void 三丈丅丂丌丟丙丁丁(PGCompany.丟丁且丝丁三丏丙且 丅丘丌且丈丘丄丗丄)
        {
            PGCompany.丟丁且丝丁三丏丙且 val_46;
            var val_47;
            var val_48;
            bool val_49;
            UIButton val_50;
            WidgetLayout val_51;
            var val_52;
            var val_53;
            val_46 = 丅丘丌且丈丘丄丗丄;
            if(val_46 != null)
            {
                    val_47 = 0;
                this.七丒丙不丅且万万丂 = val_46;
            }
            else
            {
                    val_46 = this.七丒丙不丅且万万丂;
                if(val_46 != null)
            {
                    val_47 = 0;
            }
            else
            {
                    val_47 = 1;
            }
            
            }
            
            PGCompany.丗丟丄丈东丝丕丄世 val_1 = val_46.丒丅丙丄丞丟下丏业();
            this._itemView.Setup(与且专丈不万东一万:  val_1);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemView, 丏业丟一东丂东丘丛:  true);
            if(val_1 != null)
            {
                    var val_2 = (null == null) ? (val_1) : 0;
            }
            else
            {
                    val_48 = 0;
            }
            
            if(this._character != 0)
            {
                    this._character.东丌丟三丞世一一丑(下丅丙一丂丗丅丝七:  val_1);
                val_49 = 0;
                if((val_48 != 0) && (val_46.一专丁且与丅且丝且() != true))
            {
                    val_49 = (~val_46.不丌丝丗丒丛丏丙丌()) & 1;
            }
            
                this._character.丟丑万与丒与不下丛().丕不丙一丝丆下丗东(丙业与丙丗丝不丈东:  val_49);
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonShoot, 丏业丟一东丂东丘丛:  (val_48 != 0) ? 1 : 0);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonEquip, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonPurchase, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonUpgrade, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonCraft, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonAddDetail, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonShowBlockInfo, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonGetPartsWeapons, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonToArmory, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._boughtArmorClosedByDivision, 丏业丟一东丂东丘丛:  false);
            if(val_46.下丗东丛三不业丕与() != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonEquip, 丏业丟一东丂东丘丛:  true);
                this._buttonEquip.丈且东丑丂且万丒丅(丅丘丌且丈丘丄丗丄:  val_46);
            }
            
            if(val_46.与丈丟东丆丅丅丝丁() != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonPurchase, 丏业丟一东丂东丘丛:  true);
                this._buttonPurchase.丈且东丑丂且万丒丅(丅丘丌且丈丘丄丗丄:  val_46);
            }
            
            if(val_46.万万万丑丘丈丘万丒() != false)
            {
                    PGCompany.StoreItemSettings val_12 = val_46.丏丘下丞丘不丑万丏();
                if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丞丒丒三丞且丏东丄(丈丄不七三万丄丁不:  val_12.ItemParams)) != true)
            {
                    PGCompany.丗丟丄丈东丝丕丄世 val_14 = val_46.丒丅丙丄丞丟下丏业();
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonUpgrade, 丏业丟一东丂东丘丛:  true);
                this._buttonUpgrade.丈且东丑丂且万丒丅(丅丘丌且丈丘丄丗丄:  val_46);
            }
            
            }
            
            if(val_46.丁丐丅丈丑业丒三上() != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonShowBlockInfo, 丏业丟一东丂东丘丛:  true);
                PGCompany.StoreItemSettings val_17 = val_46.丏丘下丞丘不丑万丏();
                if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().三专三丘丐丙丐丈丞(丆专且丕专丗与一丏:  val_17.ItemParams.业东丅东丌上丗丑不())) != false)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonCraft, 丏业丟一东丂东丘丛:  true);
                this._buttonCraft.丈且东丑丂且万丒丅(丅丘丌且丈丘丄丗丄:  val_46);
            }
            else
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonGetPartsWeapons, 丏业丟一东丂东丘丛:  true);
            }
            
            }
            
            if((Base_BuildingUI_Controller.instance != 0) || ((PGCompany.StoreListItemView.万七丝丛业丙世上业(丅丘丌且丈丘丄丗丄:  val_46)) == false))
            {
                goto label_63;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonToArmory, 丏业丟一东丂东丘丛:  true);
            if(this._buttonEquip.gameObject.activeSelf == false)
            {
                goto label_69;
            }
            
            val_50 = this._buttonShowBlockInfo;
            if(val_50 != null)
            {
                goto label_72;
            }
            
            goto label_71;
            label_69:
            val_50 = this._buttonCraft;
            if(val_50 != null)
            {
                goto label_72;
            }
            
            label_71:
            label_72:
            UnityEngine.Vector3 val_26 = val_50.transform.localPosition;
            this._buttonToArmory.transform.localPosition = new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z};
            label_63:
            if(val_46.丒丅丙丄丞丟下丏业() != null)
            {
                    if(val_46.不丌丝丗丒丛丏丙丌() != false)
            {
                    if(val_46.一专丁且与丅且丝且() == false)
            {
                goto label_82;
            }
            
            }
            
            }
            
            if(val_47 == 0)
            {
                goto label_112;
            }
            
            label_111:
            label_112:
            if((0 | val_46.一专丁且与丅且丝且()) != true)
            {
                    if(val_46.不丌丝丗丒丛丏丙丌() != true)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._buttonShowBlockInfo, 丏业丟一东丂东丘丛:  true);
            }
            
            }
            
            val_51 = this._widgetLayout;
            if(val_51 != 0)
            {
                    val_51 = this._widgetLayout;
                val_51.Reposition();
            }
            
            if(this._propertiesPopupButton == null)
            {
                    return;
            }
            
            if(((val_47 & 1) == 0) && (val_46.丒丅丙丄丞丟下丏业() != null))
            {
                    val_52 = 0;
            }
            else
            {
                    val_52 = 0;
            }
            
            if(((-166304168) & 1) != 0)
            {
                    val_53 = val_52.丙东专丂世丈丏丁丂();
            }
            else
            {
                    val_53 = 9961472;
                val_53 = 152;
            }
            
            val_46 = 上丑三丁丄丛丁万丑.丞丆丗丟丙丂一专丐(丁丂专业丁丅丅丈丙:  112);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._propertiesPopupButton, 丏业丟一东丂东丘丛:  val_46);
            return;
            label_82:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._boughtArmorClosedByDivision, 丏业丟一东丂东丘丛:  true);
            this._boughtArmorClosedByDivisionLabel.text = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9176"), arg0:  丞丂丘丒丟丞丑下丄.丂丒丏丞丝丞且丙丁(丅丅下丟丑专下与一:  val_46.世丝丌一且丝专丑丛()));
            this._boughtArmorClosedByDivisionShield.spriteName = System.String.Format(format:  "cup{0}_small", arg0:  val_46.世丝丌一且丝专丑丛() + 1);
            if(val_47 != 0)
            {
                goto label_111;
            }
            
            goto label_112;
        }
        private static bool 万七丝丛业丙世上业(PGCompany.丟丁且丝丁三丏丙且 丅丘丌且丈丘丄丗丄)
        {
            var val_4;
            if(丅丘丌且丈丘丄丗丄.且万丟专丗丅丈世丞() != false)
            {
                    val_4 = 1;
                return (bool)val_4;
            }
            
            if(丅丘丌且丈丘丄丗丄.不丌丝丗丒丛丏丙丌() != false)
            {
                    if(丅丘丌且丈丘丄丗丄.丒丅丙丄丞丟下丏业() == null)
            {
                    return (bool)val_4;
            }
            
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        private void 东一下丝丅丟业丂东(PGCompany.丟丁且丝丁三丏丙且 丅丘丌且丈丘丄丗丄)
        {
            PGCompany.丟丁且丝丁三丏丙且 val_21;
            CategoryNames val_22;
            CategoryNames val_23;
            string val_24;
            string val_25;
            val_21 = 丅丘丌且丈丘丄丗丄;
            val_22 = val_21.丒丅丙丄丞丟下丏业();
            if(val_22 == null)
            {
                goto label_11;
            }
            
            if((null != null) && (null != null))
            {
                    val_22 = new 丙且上东下丏丏丟下();
                val_23 = 7;
                val_24 = val_22.业上丙丞丐丄丆丅七();
            }
            else
            {
                    丙且上东下丏丏丟下 val_4 = null;
                val_22 = val_4;
                val_24 = val_22.业上丙丞丐丄丆丅七();
                val_23 = val_22;
            }
            
            val_4 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_24, 七丆丒与丗丌丄且丂:  val_23);
            if(val_22 == null)
            {
                goto label_11;
            }
            
            val_22 = this.丏世丑业丟世上丏丟;
            if(val_22 == 0)
            {
                goto label_11;
            }
            
            if(val_21 == null)
            {
                goto label_12;
            }
            
            val_25 = val_21.一专丁且与丅且丝且();
            goto label_13;
            label_11:
            this.三丈丅丂丌丟丙丁丁(丅丘丌且丈丘丄丗丄:  val_21);
            return;
            label_12:
            val_25 = 0.一专丁且与丅且丝且();
            label_13:
            Rilisoft.OfferItemType val_10 = val_21.丒丅丙丄丞丟下丏业().丑丐丙丄丅世世丑丒().不业丙丒丂丞下丆丙();
            bool val_12 = val_21.不丌丝丗丒丛丏丙丌();
            bool val_13 = ((val_10 != 20) ? 1 : 0) & val_12;
            val_13 = val_25 | val_13;
            if(val_13 != false)
            {
                    PGCompany.StoreItemSettings val_15 = val_21.丏丘下丞丘不丑万丏();
                val_25 = val_15.ItemParams.业上丙丞丐丄丆丅七();
                PGCompany.StoreItemSettings val_17 = val_21.丏丘下丞丘不丑万丏();
                val_21 = val_17.ItemParams.丂丁丏一丙丛业且丌();
                Rilisoft.ItemViewer val_19 = Rilisoft.ItemViewer.下与丞三丅丛丄七丕(丌丅丕一丛丛丄一万:  "NguiWindows/InfoViewClanStore", 丆丏七丟不丒与七专:  this.丏世丑业丟世上丏丟.transform, 丕丁下丌不万丅丞丛:  val_25, 丅三丟世下丞丝丙万:  val_21, 丗丟上上丒丐丗丞丙:  0, 丘丙丞丟丂丅丄丟丐:  true, 业万丒丌丗丄东丁丕:  false, 与丙丆世丘丑丒丌丄:  0, 丒不业且丄丅世世下:  false);
                return;
            }
            
            if(val_10 == 20)
            {
                    if(val_12 ^ 1 != true)
            {
                    return;
            }
            
            }
            
            this.ShowLockInfo();
        }
        public void ShowLockInfo()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockInfoView, 丏业丟一东丂东丘丛:  true);
        }
        public void GetPartsButtonHandler()
        {
            PGCompany.ClanStoreMainUI.丑七不且上丗丁一世().丆丂东丄万三不丏丅(丐丅丒专丛丏上与业:  1, 且丘丏丁丑与丙与丁:  0, 丅丘丌且丈丘丄丗丄:  0, 丞丘丞丏业且丛丏丘:  0, 丑丒万丐丞丒丈专丞:  false);
        }
        private void 东丄一丅丈业丅丏一()
        {
            var val_3;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._itemView, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._buttonShoot, 丏业丟一东丂东丘丛:  false);
            System.Collections.Generic.List<PGCompany.ItemButtonAbstract> val_1 = this.七丞丌丑与世丁丗业();
            val_3 = null;
            val_3 = null;
            if((StoreListItemView.<>c.<>9__49_0) == null)
            {
                goto label_5;
            }
            
            label_10:
            val_1.ForEach(action:  StoreListItemView.<>c.<>9__49_0);
            return;
            label_5:
            StoreListItemView.<>c.<>9__49_0 = new System.Action<PGCompany.ItemButtonAbstract>(object:  StoreListItemView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void StoreListItemView.<>c::丌且丘丝世丞丁丕丂(PGCompany.ItemButtonAbstract 三丟东丕丄丄下下丑));
            if(val_1 != null)
            {
                goto label_10;
            }
            
            goto label_10;
        }
        internal void 丏丛不丄丑上专丐丝()
        {
            this._scroll.cellsList.ForEach(action:  new System.Action<EndlessScrollCell>(object:  this, method:  System.Void PGCompany.StoreListItemView::丂上下丟丕东丁丛不(EndlessScrollCell 丌丝万上丅丒一丈丘)));
            this.东专丑七与丟丁上丗(丞世不丒下上上丝丑:  this._scroll.GetSelectedIndex(), 丝与丏丙丗上世丏丞:  true);
        }
        private void 丂上下丟丕东丁丛不(EndlessScrollCell 丌丝万上丅丒一丈丘)
        {
            int val_9;
            UnityEngine.Object val_10;
            PGCompany.丟丁且丝丁三丏丙且 val_11;
            val_10 = 丌丝万上丅丒一丈丘;
            if((val_10.Index & 2147483648) != 0)
            {
                goto label_5;
            }
            
            val_9 = val_10.Index;
            if(val_9 >= this.专丙丌一与业三专丛.Count)
            {
                goto label_5;
            }
            
            val_9 = val_10.Index;
            val_11 = this.专丙丌一与业三专丛.Item[val_9];
            goto label_11;
            label_5:
            val_11 = 0;
            if(val_10 == 0)
            {
                goto label_11;
            }
            
            if(val_10 == null)
            {
                goto label_12;
            }
            
            val_10.丈且东丑丂且万丒丅(丅丘丌且丈丘丄丗丄:  0);
            val_11 = 0;
            goto label_15;
            label_11:
            if(val_10 == null)
            {
                goto label_19;
            }
            
            label_15:
            val_10 = 0;
            goto label_19;
            label_12:
            val_11 = 0;
            label_19:
            if(val_10 == 0)
            {
                    return;
            }
            
            if(val_10 != null)
            {
                    val_10.丆丅业丆专七丏业专(丙业与丙丗丝不丈东:  true);
            }
            else
            {
                    val_10.丆丅业丆专七丏业专(丙业与丙丗丝不丈东:  true);
            }
            
            val_10.丈且东丑丂且万丒丅(丅丘丌且丈丘丄丗丄:  val_11);
        }
        private PGCompany.StoreListItemView.ScrollSettings 丄丆丌丟一上丁三且()
        {
            System.Collections.Generic.List<ScrollSettings> val_8;
            StoreListItemView.丛世且不丕丕东丒三 val_1 = new StoreListItemView.丛世且不丕丕东丒三();
            .东丞丅丕丌丑丗丞下 = 丒丁三上丂丅丌丈丁.丌且专业丈丒丄东万();
            val_8 = this._scrollSettings;
            if((val_8.Exists(match:  new System.Predicate<ScrollSettings>(object:  val_1, method:  System.Boolean StoreListItemView.丛世且不丕丕东丒三::下丗丒丑丂专东丏丛(PGCompany.StoreListItemView.ScrollSettings 三丟东丕丄丄下下丑)))) == false)
            {
                    return (ScrollSettings)System.Linq.Enumerable.First<ScrollSettings>(source:  this._scrollSettings);
            }
            
            System.Predicate<ScrollSettings> val_5 = null;
            val_8 = val_5;
            val_5 = new System.Predicate<ScrollSettings>(object:  val_1, method:  System.Boolean StoreListItemView.丛世且不丕丕东丒三::丄且丝丐丈丑下业丏(PGCompany.StoreListItemView.ScrollSettings 三丟东丕丄丄下下丑));
            ScrollSettings val_6 = this._scrollSettings.Find(match:  val_5);
            return (ScrollSettings)System.Linq.Enumerable.First<ScrollSettings>(source:  this._scrollSettings);
        }
        private void 丄丆丙东丆且丌丄专(PGCompany.StoreListItemView.ScrollSettings 与不丕丆丈不丙丟丛)
        {
            this.UpdateRects();
            float val_3 = (float)与不丕丆丈不丙丟丛.cellsInRow;
            val_3 = this._scroll.panel.width / val_3;
            this._scroll.cellCountInRow = 与不丕丆丈不丙丟丛.cellsInRow;
            this._scroll.cellSize = UnityEngine.Mathf.FloorToInt(f:  val_3);
        }
        public void UpdateRects()
        {
            List.Enumerator<T> val_1 = this._rectsToUpdate.GetEnumerator();
            label_7:
            if(((-164533768) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_2 = 0.丐丏七丌丕丗业且上();
            if(val_2 == 0)
            {
                goto label_7;
            }
            
            val_2.ResetAndUpdateAnchors();
            goto label_7;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public void U_GoToArmory()
        {
            PGCompany.丗丟丄丈东丝丕丄世 val_8;
            var val_9;
            val_8 = this;
            ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
            val_9 = null;
            val_9 = null;
            if(MainMenuController.丄丞丁丈与业上丞丟 == 0)
            {
                    return;
            }
            
            val_8 = this.七丒丙不丅且万万丂.丒丅丙丄丞丟下丏业();
            if(val_8 == null)
            {
                    return;
            }
            
            if((PGCompany.丕丝下丁七东丄三丑.不丝丏万丘丒不丄丟(下丅丙一丂丗丅丝七:  val_8)) == null)
            {
                    return;
            }
            
            val_8 = ???;
            goto typeof(PGCompany.丕万丅丗丏三丙丈丁).__il2cppRuntimeField_168;
        }
        private void OnDisable()
        {
            null = null;
            this.东丗丘丄东丒七下下 = 丐丏七丈且丌丄三丏.丛七丞丂下丘丘丘东;
        }
        private void 下丌业业丐丘丐丘三()
        {
            this._scroll.canSelectDelegate = new EndlessScroll.丞丆丐丒且丘三丂丁(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Boolean PGCompany.StoreListItemView::丈七专与丈丝一专丁(EndlessScrollCell 丌丝万上丅丒一丈丘));
            this._scroll.add_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCell>(object:  this, method:  System.Void PGCompany.StoreListItemView::丂上下丟丕东丁丛不(EndlessScrollCell 丌丝万上丅丒一丈丘)));
            this._scroll.add_onSelectCell(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.StoreListItemView::下下丂丗丌上七东丕(int 丞世不丒下上上丝丑)));
            this.七丞丌丑与世丁丗业().ForEach(action:  new System.Action<PGCompany.ItemButtonAbstract>(object:  this, method:  System.Void PGCompany.StoreListItemView::丝丅丈丂丒专三东不(PGCompany.ItemButtonAbstract 三丟东丕丄丄下下丑)));
        }
        private void 不与丞下业丑丒丙万()
        {
            this._scroll.remove_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCell>(object:  this, method:  System.Void PGCompany.StoreListItemView::丂上下丟丕东丁丛不(EndlessScrollCell 丌丝万上丅丒一丈丘)));
            this._scroll.remove_onSelectCell(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void PGCompany.StoreListItemView::下下丂丗丌上七东丕(int 丞世不丒下上上丝丑)));
            this.七丞丌丑与世丁丗业().ForEach(action:  new System.Action<PGCompany.ItemButtonAbstract>(object:  this, method:  System.Void PGCompany.StoreListItemView::上丄丗丟丑一丄丂三(PGCompany.ItemButtonAbstract 三丟东丕丄丄下下丑)));
        }
        private bool 丈七专与丈丝一专丁(EndlessScrollCell 丌丝万上丅丒一丈丘)
        {
            var val_8;
            var val_9;
            var val_10;
            val_9 = 丌丝万上丅丒一丈丘;
            if((val_9.Index & 2147483648) == 0)
            {
                    val_8 = val_9.Index;
                if(val_8 < this.专丙丌一与业三专丛.Count)
            {
                    val_9 = this.专丙丌一与业三专丛.Item[val_9.Index];
                if(val_9 == null)
            {
                    return (bool)val_10;
            }
            
                if(val_9.丑丕丈丈不不且丑且() != false)
            {
                    if(val_9.一专丁且与丅且丝且() == false)
            {
                    return val_9.不丌丝丗丒丛丏丙丌();
            }
            
                val_10 = 1;
                return (bool)val_10;
            }
            
            }
            
            }
            
            val_10 = 0;
            return (bool)val_10;
        }
        public StoreListItemView()
        {
            var val_3;
            this._scrollSettings = new System.Collections.Generic.List<ScrollSettings>();
            this.专丙丌一与业三专丛 = new System.Collections.Generic.List<PGCompany.丟丁且丝丁三丏丙且>();
            val_3 = null;
            val_3 = null;
            this.东丗丘丄东丒七下下 = 丐丏七丈且丌丄三丏.丛七丞丂下丘丘丘东;
        }
        private void 丝丅丈丂丒专三东不(PGCompany.ItemButtonAbstract 三丟东丕丄丄下下丑)
        {
            三丟东丕丄丄下下丑.不丌丕丝丐丆上丕丌(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.StoreListItemView::丏丛不丄丑上专丐丝()));
        }
        private void 上丄丗丟丑一丄丂三(PGCompany.ItemButtonAbstract 三丟东丕丄丄下下丑)
        {
            三丟东丕丄丄下下丑.丐专世丛丘丝丈丘丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void PGCompany.StoreListItemView::丏丛不丄丑上专丐丝()));
        }
    
    }

}
