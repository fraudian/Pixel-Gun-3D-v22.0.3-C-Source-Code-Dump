using UnityEngine;

namespace Rilisoft.Offers
{
    internal abstract class 丏丘三丈业且上丏丑 : 丈万丈丅丌丏丞丂丐
    {
        // Fields
        private string <上七东下丏不丕丐丑>k__BackingField;
        
        // Properties
        protected string 下丄丈不与世丐业专 { get; set; }
        protected int 不丆丟与丙丏业丛丗 { get; set; }
        
        // Methods
        internal 丏丘三丈业且上丏丑(string 丞丅上丏丂且下丅与, Rilisoft.业丙丘丆东丈丕丂丄 丈丕丄上丌丐丌不丁)
        {
            this.<上七东下丏不丕丐丑>k__BackingField = 丞丅上丏丂且下丅与;
        }
        protected string 业上丙丞丐丄丆丅七()
        {
            return (string)this.<上七东下丏不丕丐丑>k__BackingField;
        }
        private void 丒丞东丈丁丄丑丅且(string 丙业与丙丗丝不丈东)
        {
            this.<上七东下丏不丕丐丑>k__BackingField = 丙业与丙丗丝不丈东;
        }
        protected int 业丑丁丆丕丆丂丅万()
        {
            Progress.OfferProgress val_2 = this.三丌丘丏丝丘丟下七().业丑丁丆丕丆丂丅万();
            if(val_2.ConditionsProgress == null)
            {
                    Progress.OfferProgress val_4 = this.三丌丘丏丝丘丟下七().业丑丁丆丕丆丂丅万();
                val_4.ConditionsProgress = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            }
            
            Progress.OfferProgress val_7 = this.三丌丘丏丝丘丟下七().业丑丁丆丕丆丂丅万();
            if((val_7.ConditionsProgress.ContainsKey(key:  this.<上七东下丏不丕丐丑>k__BackingField)) == false)
            {
                    return 0;
            }
            
            Progress.OfferProgress val_10 = this.三丌丘丏丝丘丟下七().业丑丁丆丕丆丂丅万();
            if(val_10.ConditionsProgress != null)
            {
                    return val_10.ConditionsProgress.Item[this.<上七东下丏不丕丐丑>k__BackingField];
            }
            
            return val_10.ConditionsProgress.Item[this.<上七东下丏不丕丐丑>k__BackingField];
        }
        protected void 丙丕丘丒丆丅七万丗(int 丙业与丙丗丝不丈东)
        {
            Progress.OfferProgress val_2 = this.三丌丘丏丝丘丟下七().业丑丁丆丕丆丂丅万();
            if(val_2.ConditionsProgress == null)
            {
                    Progress.OfferProgress val_4 = this.三丌丘丏丝丘丟下七().业丑丁丆丕丆丂丅万();
                val_4.ConditionsProgress = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            }
            
            Progress.OfferProgress val_7 = this.三丌丘丏丝丘丟下七().业丑丁丆丕丆丂丅万();
            bool val_8 = val_7.ConditionsProgress.ContainsKey(key:  this.<上七东下丏不丕丐丑>k__BackingField);
            Progress.OfferProgress val_10 = this.三丌丘丏丝丘丟下七().业丑丁丆丕丆丂丅万();
            if(val_10.ConditionsProgress == null)
            {
                goto label_11;
            }
            
            if(val_8 == false)
            {
                goto label_12;
            }
            
            label_13:
            val_10.ConditionsProgress.set_Item(key:  this.<上七东下丏不丕丐丑>k__BackingField, value:  丙业与丙丗丝不丈东);
            return;
            label_11:
            if(val_8 == true)
            {
                goto label_13;
            }
            
            label_12:
            val_10.ConditionsProgress.Add(key:  this.<上七东下丏不丕丐丑>k__BackingField, value:  丙业与丙丗丝不丈东);
        }
    
    }

}
