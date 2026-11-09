using UnityEngine;

namespace PGCompany
{
    [Serializable]
    internal class StorePromotionConfig
    {
        // Fields
        private PGCompany.丝丗丁丞丒且丙丑丙 <Type>k__BackingField;
        private PGCompany.StorePromotionSettings <Settings>k__BackingField;
        private PGCompany.丘不七不丅丄丏七丆 _identificatorContainer;
        
        // Properties
        internal PGCompany.丝丗丁丞丒且丙丑丙 Type { get; set; }
        internal PGCompany.StorePromotionSettings Settings { get; set; }
        internal PGCompany.专丟专世丅丂丁且专 Identificator { get; }
        
        // Methods
        internal PGCompany.丝丗丁丞丒且丙丑丙 get_Type()
        {
            return (PGCompany.丝丗丁丞丒且丙丑丙)this.<Type>k__BackingField;
        }
        private void set_Type(PGCompany.丝丗丁丞丒且丙丑丙 丙业与丙丗丝不丈东)
        {
            this.<Type>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal PGCompany.StorePromotionSettings get_Settings()
        {
            return (PGCompany.StorePromotionSettings)this.<Settings>k__BackingField;
        }
        private void set_Settings(PGCompany.StorePromotionSettings 丙业与丙丗丝不丈东)
        {
            this.<Settings>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal PGCompany.专丟专世丅丂丁且专 get_Identificator()
        {
            if(this._identificatorContainer != null)
            {
                    return (PGCompany.专丟专世丅丂丁且专)this._identificatorContainer.丂丐丌丄上丞上丏丁;
            }
            
            return (PGCompany.专丟专世丅丂丁且专)this._identificatorContainer.丂丐丌丄上丞上丏丁;
        }
        internal StorePromotionConfig()
        {
        
        }
        internal StorePromotionConfig(PGCompany.丝丗丁丞丒且丙丑丙 丁丅丈丌丟世丗丗丟, PGCompany.StorePromotionSettings 与不丕丆丈不丙丟丛, PGCompany.专丟专世丅丂丁且专 一丗与一专丙丙丅丄)
        {
            val_1 = new System.Object();
            this.<Type>k__BackingField = 丁丅丈丌丟世丗丗丟;
            this.<Settings>k__BackingField = val_1;
            PGCompany.丘不七不丅丄丏七丆 val_2 = new PGCompany.丘不七不丅丄丏七丆();
            System.Type val_3 = 一丗与一专丙丙丅丄.GetType();
            if(val_2 != null)
            {
                    .TypeName = val_3;
            }
            else
            {
                    mem[16] = val_3;
            }
            
            .丂丐丌丄上丞上丏丁 = 一丗与一专丙丙丅丄;
            this._identificatorContainer = val_2;
        }
        public override string ToString()
        {
            return (string)System.String.Format(format:  "{0}_{1}: ", arg0:  this.<Type>k__BackingField, arg1:  this._identificatorContainer.丂丐丌丄上丞上丏丁)(System.String.Format(format:  "{0}_{1}: ", arg0:  this.<Type>k__BackingField, arg1:  this._identificatorContainer.丂丐丌丄上丞上丏丁)) + "itemsParams="("itemsParams=") + Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.<Settings>k__BackingField.ItemsParams)(Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  this.<Settings>k__BackingField.ItemsParams));
        }
    
    }

}
