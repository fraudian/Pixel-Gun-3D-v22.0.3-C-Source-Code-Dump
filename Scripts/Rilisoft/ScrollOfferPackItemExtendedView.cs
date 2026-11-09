using UnityEngine;

namespace Rilisoft
{
    internal class ScrollOfferPackItemExtendedView : MonoBehaviour
    {
        // Fields
        private Rilisoft.OfferItem 丈丌业丁不丘丅丞丛;
        public bool DoNotSetItemsViews;
        private PropertiesArmoryItemContainer _propertiesArmoryItemContainer;
        private ItemPreviewInArmoryInfoScreen _weaponPreview;
        private Rilisoft.TextGroup _itemName;
        private Rilisoft.TextGroup _name;
        private Rilisoft.TextGroup _description;
        private UIBasicSprite _texture;
        private UnityEngine.GameObject _itemBonusObject;
        private UILabel _itemBonusText;
        private UnityEngine.GameObject _modelHolder;
        private UnityEngine.GameObject _partsIndicator;
        private UILabel _partsCountLabel;
        
        // Properties
        private UIBasicSprite 丌丟三丅上丅上丗丞 { get; }
        
        // Methods
        private UIBasicSprite 丆下世世丟七专丞丒()
        {
            UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this._texture);
            this._texture = val_1;
            return val_1;
        }
        public void SetItem(Rilisoft.OfferItem 与业下丟丛万丗丑丆)
        {
            UILabel val_49;
            string val_50;
            string val_51;
            Rilisoft.OfferItemType val_52;
            丙且上东下丏丏丟下 val_53;
            var val_54;
            val_49 = this;
            this.丈丌业丁不丘丅丞丛 = 与业下丟丛万丗丑丆;
            this._name.Text = 与业下丟丛万丗丑丆.Name;
            val_50 = 1152921505284374528;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._propertiesArmoryItemContainer.gameObject, 丏业丟一东丂东丘丛:  false);
            if(this.丆下世世丟七专丞丒() != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丆下世世丟七专丞丒().gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            this.丐丑三丗丗丙丆不丕();
            if(与业下丟丛万丗丑丆.Type != 10)
            {
                goto label_13;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._description.gameObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemBonusObject, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._propertiesArmoryItemContainer.gameObject, 丏业丟一东丂东丘丛:  true);
            if(this._partsIndicator != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._partsIndicator, 丏业丟一东丂东丘丛:  false);
            }
            
            三丅丁丗丗丝丂万且 val_12 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  与业下丟丛万丗丑丆.Id);
            if(val_12 == null)
            {
                goto label_26;
            }
            
            val_51 = val_12.与不丞丑七丘丁丂丛();
            goto label_27;
            label_13:
            if(this._modelHolder == 0)
            {
                goto label_34;
            }
            
            if(与业下丟丛万丗丑丆.Type != 1000)
            {
                    if(与业下丟丛万丗丑丆.Type != 1010)
            {
                goto label_34;
            }
            
            }
            
            if(与业下丟丛万丗丑丆 == null)
            {
                goto label_35;
            }
            
            val_52 = 与业下丟丛万丗丑丆.Type;
            goto label_36;
            label_34:
            if(this.DoNotSetItemsViews == false)
            {
                goto label_37;
            }
            
            label_67:
            if(与业下丟丛万丗丑丆.Type != 20)
            {
                goto label_39;
            }
            
            int val_20 = 七丌丞万七万丁丐丙.丗丁七与万丘三与丅(丆三丑专丂且一三业:  与业下丟丛万丗丑丆.Id);
            int val_22 = Progress.七七世万专丕丁上业.丝丘丂与东下丗东万().丄丏且丆丈一东丟丙(丞世不丒下上上丝丑:  val_20);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemBonusObject.gameObject, 丏业丟一东丂东丘丛:  true);
            this._itemBonusText.text = BalanceController.丑丈与不丄丈丘三丟(丞世不丒下上上丝丑:  val_20, 下丑丞不一且业丆不:  val_22, 丙丂丏丛丌丏下丝不:  val_22).ToString();
            if(与业下丟丛万丗丑丆 != null)
            {
                goto label_71;
            }
            
            goto label_53;
            label_26:
            val_51 = 0.与不丞丑七丘丁丂丛();
            label_27:
            丙且上东下丏丏丟下 val_29 = null;
            val_53 = val_29;
            val_29 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_51, 七丆丒与丗丌丄且丂:  val_12.万上丄下业丛丌不丈() - 1);
            val_54 = null;
            val_54 = null;
            if(val_12 != null)
            {
                    val_50 = val_12.与不丞丑七丘丁丂丛();
            }
            else
            {
                    val_50 = 0.与不丞丑七丘丁丂丛();
            }
            
            ShopNGUIController.丏丙丅丕一丑丕丑丑.业丆上丐东丈丂丈丈(丆三丝丝一丕与丝丆:  val_50, 丂丒丒丆且丝丘丈丟:  val_12.与不丞丑七丘丁丂丛(), 丘丐丝丟业丘丏东专:  this._propertiesArmoryItemContainer, 东丈丒三丞与业世一:  false, 丐丙丒丈丄不一丈与:  val_29, 丑丂丟丆丗丒丙业丕:  false, 丙丂丒一丗下丘下丟:  0, 丄丄丒丘丏一丗丆与:  0, 世七与业一七世丂丒:  0);
            if(this.DoNotSetItemsViews == true)
            {
                    return;
            }
            
            this.丄下丛且丁丅丆丏丛(三与世丈丂丕丏三上:  val_12);
            return;
            label_37:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丆下世世丟七专丞丒().gameObject, 丏业丟一东丂东丘丛:  true);
            UIBasicSprite val_35 = this.丆下世世丟七专丞丒();
            UnityEngine.Texture val_36 = 与业下丟丛万丗丑丆.Texture;
            if(与业下丟丛万丗丑丆 != null)
            {
                goto label_67;
            }
            
            goto label_67;
            label_35:
            val_52 = 0.Type;
            label_36:
            Rilisoft.BaseOfferPackDrawer.且丑专业上三丌东东(丁丅丈丌丟世丗丗丟:  val_52, 丌丒丝东丌下丕丁丅:  与业下丟丛万丗丑丆.Count, 东丙丑万下丁丅一万:  this._modelHolder, 丆一丆七丕丑丛世东:  20f);
            label_39:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._itemBonusObject.gameObject, 丏业丟一东丂东丘丛:  false);
            if(与业下丟丛万丗丑丆 != null)
            {
                goto label_71;
            }
            
            label_53:
            label_71:
            string val_40 = 与业下丟丛万丗丑丆.Description;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._description.gameObject, 丏业丟一东丂东丘丛:  (~(丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_40))) & 1);
            this._description.Text = val_40;
            val_53 = this._partsIndicator;
            if(val_53 == 0)
            {
                    return;
            }
            
            val_53 = this._partsIndicator;
            if(与业下丟丛万丗丑丆.Type == 1070)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_53, 丏业丟一东丂东丘丛:  true);
                val_53 = this._partsCountLabel;
                if(val_53 == 0)
            {
                    return;
            }
            
                val_49 = this._partsCountLabel;
                val_49.text = 与业下丟丛万丗丑丆.Count.ToString();
                return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_53, 丏业丟一东丂东丘丛:  false);
        }
        private void 丄下丛且丁丅丆丏丛(三丅丁丗丗丝丂万且 三与世丈丂丕丏三上)
        {
            var val_23;
            var val_24;
            var val_25;
            ScrollOfferPackItemExtendedView.丞丂万丅不丒丘丟丗 val_1 = new ScrollOfferPackItemExtendedView.丞丂万丅不丒丘丟丗();
            if(val_1 == null)
            {
                goto label_1;
            }
            
            .三与世丈丂丕丏三上 = 三与世丈丂丕丏三上;
            mem[1152921543303105120] = this;
            if(三与世丈丂丕丏三上 != null)
            {
                goto label_5;
            }
            
            label_6:
            label_5:
            int val_2 = 三与世丈丂丕丏三上.万上丄下业丛丌不丈();
            if(val_1 == null)
            {
                goto label_3;
            }
            
            val_23 = val_1;
            .七丆丒与丗丌丄且丂 = val_2 - 1;
            goto label_4;
            label_1:
            mem[16] = this;
            mem[24] = 三与世丈丂丕丏三上;
            if(mem[24] != 0)
            {
                goto label_5;
            }
            
            goto label_6;
            label_3:
            val_23 = val_1;
            .七丆丒与丗丌丄且丂 = val_2 - 1;
            label_4:
            UnityEngine.GameObject val_6 = WeaponManager.丄丟上一上丐丄与丆(三不三丟专丘东东丂:  .三与世丈丂丕丏三上.与不丞丑七丘丁丂丛());
            this._weaponPreview.gameObject.SetActive(value:  true);
            val_24 = null;
            val_24 = null;
            this._weaponPreview.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            if((.三与世丈丂丕丏三上.与不丞丑七丘丁丂丛().Equals(value:  "cape_Custom")) != false)
            {
                    val_25 = null;
                val_25 = null;
                Rilisoft.与丄丁丄丙丞下下丙.且丁丞业丝万丄三丗(万且万且丑丗且丌丆:  this._weaponPreview.gameObject, 丐丅丁丂丐下丘世丄:  SkinsController.丌七丞东丟丌世且不, 丕丂丝丗丈三与东专:  new UnityEngine.GameObject[0]);
            }
            
            .丂下业与且丈丟与专 = this._weaponPreview.GetComponent<ItemPreviewInArmoryInfoScreen>();
            if(val_16.model != 0)
            {
                    (ScrollOfferPackItemExtendedView.丞丂万丅不丒丘丟丗)[1152921543303105104].丂下业与且丈丟与专.model.SetParent(p:  0);
                (ScrollOfferPackItemExtendedView.丞丂万丅不丒丘丟丗)[1152921543303105104].丂下业与且丈丟与专.model.gameObject.SetActive(value:  false);
                UnityEngine.Object.Destroy(obj:  (ScrollOfferPackItemExtendedView.丞丂万丅不丒丘丟丗)[1152921543303105104].丂下业与且丈丟与专.model.gameObject);
                (ScrollOfferPackItemExtendedView.丞丂万丅不丒丘丟丗)[1152921543303105104].丂下业与且丈丟与专.model = 0;
            }
            
            (ScrollOfferPackItemExtendedView.丞丂万丅不丒丘丟丗)[1152921543303105104].丂下业与且丈丟与专.id = .三与世丈丂丕丏三上.与不丞丑七丘丁丂丛();
            (ScrollOfferPackItemExtendedView.丞丂万丅不丒丘丟丗)[1152921543303105104].丂下业与且丈丟与专.category = (ScrollOfferPackItemExtendedView.丞丂万丅不丒丘丟丗)[1152921543303105104].七丆丒与丗丌丄且丂;
            (ScrollOfferPackItemExtendedView.丞丂万丅不丒丘丟丗)[1152921543303105104].丂下业与且丈丟与专.headName = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  .三与世丈丂丕丏三上.与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  .七丆丒与丗丌丄且丂);
            (ScrollOfferPackItemExtendedView.丞丂万丅不丒丘丟丗)[1152921543303105104].丂下业与且丈丟与专.id = .三与世丈丂丕丏三上.与不丞丑七丘丁丂丛();
            (ScrollOfferPackItemExtendedView.丞丂万丅不丒丘丟丗)[1152921543303105104].丂下业与且丈丟与专.numUpgrade = 0;
            (ScrollOfferPackItemExtendedView.丞丂万丅不丒丘丟丗)[1152921543303105104].丂下业与且丈丟与专.SetSelected(丏丈丞丙七丛东七丌:  true, 东丝三一丞下业丂丝:  false);
            丄丝不丂丕七万丘且.东丝七丛丄丙丝三七(上丞不世东丛东下丒:  val_6, 丌专业且丛丏丞丝且:  new 丄丝不丂丕七万丘且.业丛不与丕丈一与专<UnityEngine.GameObject, UnityEngine.Vector3, UnityEngine.Vector3, System.String, System.Single, System.Int32, System.Int32>(三一丄丗专丌丛丘丅:  val_1, 丛丌丙世专世东丕下:  System.Void ScrollOfferPackItemExtendedView.丞丂万丅不丒丘丟丗::丙丏丌下上丌万丘丙(UnityEngine.GameObject 丏丗上丙上世东东且, UnityEngine.Vector3 上下七丗丞丁不万丏, UnityEngine.Vector3 丁丂专丑丙丞七专与, string 一丛丞丑丛不丏一不, float 七丂且丄业丐丂丐丏, int 业万上丆丐丞且丒七, int 丙丑七万丆万丆且丌)), 七丆丒与丗丌丄且丂:  (ScrollOfferPackItemExtendedView.丞丂万丅不丒丘丟丗)[1152921543303105104].七丆丒与丗丌丄且丂, 丐丑七万丌丂专与丌:  val_6.GetComponent<WeaponSounds>());
        }
        private void 丐丑三丗丗丙丆不丕()
        {
            if(this._modelHolder == 0)
            {
                    return;
            }
            
            goto label_4;
            label_12:
            丞东丑专丛丆丄丝世.丑丞专专丁丛业丌丆(万且万且丑丗且丌丆:  this._modelHolder.transform.GetChild(index:  0).gameObject);
            label_4:
            if(this._modelHolder.transform.childCount > 0)
            {
                goto label_12;
            }
        
        }
        public ScrollOfferPackItemExtendedView()
        {
        
        }
    
    }

}
