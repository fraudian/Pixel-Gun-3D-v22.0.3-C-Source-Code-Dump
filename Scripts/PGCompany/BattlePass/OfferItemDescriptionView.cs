using UnityEngine;

namespace PGCompany.BattlePass
{
    public class OfferItemDescriptionView : MonoBehaviour, 世丙丘下丝丗上下丏<Rilisoft.OfferItem>
    {
        // Fields
        private Rilisoft.OfferItem <丅丝丌丝丁丏丙东丞>k__BackingField;
        private PropertiesArmoryItemContainer _propertiesArmoryItemContainer;
        private UnityEngine.GameObject _customProperties;
        private UIBasicSprite _texture;
        private UILabel _nameLabel;
        private UILabel _descriptionLabel;
        
        // Properties
        public Rilisoft.OfferItem 丄丄一丐东丐丝丗七 { get; set; }
        
        // Methods
        public Rilisoft.OfferItem get_Context()
        {
            return (Rilisoft.OfferItem)this.<丅丝丌丝丁丏丙东丞>k__BackingField;
        }
        private void 不丕丌与业丕下东丂(Rilisoft.OfferItem 丙业与丙丗丝不丈东)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Setup(Rilisoft.OfferItem 与且专丈不万东一万)
        {
            this.<丅丝丌丝丁丏丙东丞>k__BackingField = 与且专丈不万东一万;
            this.丝一丅丆三东丂丞七();
        }
        private void 丝一丅丆三东丂丞七()
        {
            PropertiesArmoryItemContainer val_30;
            Rilisoft.OfferItem val_31;
            var val_32;
            var val_33;
            val_30 = this;
            if((this.<丅丝丌丝丁丏丙东丞>k__BackingField) == null)
            {
                    return;
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._propertiesArmoryItemContainer.gameObject, 丏业丟一东丂东丘丛:  false);
            if(this._texture != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._texture.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            if(this._nameLabel != 0)
            {
                    string val_5 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.Name;
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._nameLabel.gameObject, 丏业丟一东丂东丘丛:  (~(丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5))) & 1);
                this._nameLabel.text = val_5;
            }
            
            三丅丁丗丗丝丂万且 val_10 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.<丅丝丌丝丁丏丙东丞>k__BackingField.Id);
            val_31 = this.<丅丝丌丝丁丏丙东丞>k__BackingField;
            if((val_10 != null) && (val_31.Type == 10))
            {
                    if(val_10.东七与与不丅丙上上() == false)
            {
                goto label_25;
            }
            
            }
            
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._customProperties, 丏业丟一东丂东丘丛:  true);
            if(this._texture != 0)
            {
                    丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._texture.gameObject, 丏业丟一东丂东丘丛:  true);
                val_31 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.Texture;
            }
            
            if(this._descriptionLabel == 0)
            {
                    return;
            }
            
            string val_17 = this.<丅丝丌丝丁丏丙东丞>k__BackingField.Description;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._descriptionLabel.gameObject, 丏业丟一东丂东丘丛:  (~(丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_17))) & 1);
            this._descriptionLabel.text = val_17;
            return;
            label_25:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._customProperties, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._propertiesArmoryItemContainer.gameObject, 丏业丟一东丂东丘丛:  true);
            丙且上东下丏丏丟下 val_25 = null;
            val_31 = val_25;
            val_25 = new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  val_10.与不丞丑七丘丁丂丛(), 七丆丒与丗丌丄且丂:  val_10.万上丄下业丛丌不丈() - 1);
            val_32 = null;
            val_32 = null;
            if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != 0)
            {
                    val_33 = null;
                val_33 = null;
                val_30 = this._propertiesArmoryItemContainer;
                ShopNGUIController.丏丙丅丕一丑丕丑丑.业丆上丐东丈丂丈丈(丆三丝丝一丕与丝丆:  val_10.与不丞丑七丘丁丂丛(), 丂丒丒丆且丝丘丈丟:  val_10.与不丞丑七丘丁丂丛(), 丘丐丝丟业丘丏东专:  val_30, 东丈丒三丞与业世一:  false, 丐丙丒丈丄不一丈与:  val_25, 丑丂丟丆丗丒丙业丕:  false, 丙丂丒一丗下丘下丟:  0, 丄丄丒丘丏一丗丆与:  0, 世七与业一七世丂丒:  0);
                return;
            }
            
            UnityEngine.Debug.LogErrorFormat(format:  "ShopNGUIController.sharedShop == null OfferItemDescriptionView", args:  System.Array.Empty<System.Object>());
        }
        public OfferItemDescriptionView()
        {
        
        }
    
    }

}
