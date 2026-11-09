using UnityEngine;

namespace PGCompany
{
    public class ClanStoreBuffsProxy : PGBehaviour
    {
        // Methods
        public static System.Collections.Generic.Dictionary<string, int> ConvertDataToItemIndexes(string 丕丗丘丑丛与丑业丒, Rilisoft.OfferItemType 丁丅丈丌丟世丗丗丟)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>();
            DataSystem.丈且丈上不下且丝丒 val_2 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
            val_7 = public PGCompany.ClanStoreBuffsConfig DataSystem.丌丈丕丑丛丕世丒世::丂东专丙丒丏且丛丁<PGCompany.ClanStoreBuffsConfig>(string 丞丕丒专一下丙业上);
            var val_7 = 0;
            val_7 = val_7 + 1;
            if(val_2 == null)
            {
                    return val_1;
            }
            
            if(val_2 == null)
            {
                    return val_1;
            }
            
            List.Enumerator<T> val_4 = val_2.GetEnumerator();
            val_7 = 1152921554013314672;
            label_14:
            if(((-2133120792) & 1) == 0)
            {
                goto label_10;
            }
            
            if(val_5.m_stringLength != 丁丅丈丌丟世丗丗丟)
            {
                goto label_14;
            }
            
            val_1.set_Item(key:  丕丗丘丑丛与丑业丒, value:  0.丐丏七丌丕丗业且上().Index);
            goto label_14;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public ClanStoreBuffsProxy()
        {
        
        }
    
    }

}
