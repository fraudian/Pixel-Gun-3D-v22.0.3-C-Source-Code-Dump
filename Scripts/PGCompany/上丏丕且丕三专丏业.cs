using UnityEngine;

namespace PGCompany
{
    internal sealed class 上丏丕且丕三专丏业
    {
        // Fields
        private static readonly System.Lazy<PGCompany.上丏丕且丕三专丏业> 丝业丆丁业三丈丟东;
        
        // Properties
        internal static PGCompany.上丏丕且丕三专丏业 丆丕丝丒不丙且丐丗 { get; }
        
        // Methods
        internal static PGCompany.上丏丕且丕三专丏业 丑七不且上丗丁一世()
        {
            null = null;
            if(PGCompany.上丏丕且丕三专丏业.丝业丆丁业三丈丟东 != null)
            {
                    return PGCompany.上丏丕且丕三专丏业.丝业丆丁业三丈丟东.Value;
            }
            
            return PGCompany.上丏丕且丕三专丏业.丝业丆丁业三丈丟东.Value;
        }
        internal void 丑丒上丕世且丞丏丂(PGCompany.不万丑丗丕与丐丒丏 丙业丞丑七丗下丟丌, PGCompany.东丑丆丗丏丐丟下丄 且丘丏丁丑与丙与丁, InappRememberedBonus 丂丈丗丄不丅丅丙丒)
        {
            var val_20;
            int val_21;
            System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_22;
            var val_23;
            val_21 = 且丘丏丁丑与丙与丁;
            val_22 = 丙业丞丑七丗下丟丌;
            int val_6 = 0;
            if(val_22 == null)
            {
                    return;
            }
            
            if(丂丈丗丄不丅丅丙丒 == null)
            {
                    return;
            }
            
            if(val_21 == null)
            {
                    return;
            }
            
            if((val_22.业一与丏丄与丁丅七(东业丝丞丕东丞且丟:  丂丈丗丄不丅丅丙丒.ServerTime)) == false)
            {
                    return;
            }
            
            val_20 = val_22.专专丈丘且专丛丏与();
            if(val_20.Count < 2)
            {
                    return;
            }
            
            bool val_7 = PGCompany.丈丟业丟专七世万专.专业丈且丆专万不丁(一丗与一专丙丙丅丄:  val_21.七丈丒丒下下且万与(), 丞世不丒下上上丝丑: out  val_6);
            val_20 = val_6;
            val_21 = val_21.丂丁丏一丙丛业且丌();
            if(val_6 == 1)
            {
                    val_23 = 丞东丑专丛丆丄丝世.丈丛与上丆丏不丘不(丂下专丝丒丁万与丆:  val_22.专丙丑丈丝专一与不());
            }
            else
            {
                    val_23 = 0;
            }
            
            PGCompany.StorePromotionSettings val_16 = val_22.专专丈丘且专丛丏与().Item[0].Settings;
            PGCompany.StorePromotionSettings val_19 = val_22.专专丈丘且专丛丏与().Item[1].Settings;
            val_22 = val_19.ItemsParams;
            PGCompany.Analytics.一业丗丆世世上丁且.丅三丄丙不丒专丄丂(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丈与世丗七丐丑丆丌:  0, 万丗世专专丒一丕下:  val_21, 不丞丞丞丁丂丑三万:  0, 丌三与丅万丑业东丒:  一下丛与丛丛万万丏.三万丑不上丏上丁上(不丌一丄东丝丏且丗:  44)(一下丛与丛丛万万丏.三万丑不上丏上丁上(不丌一丄东丝丏且丗:  44)) + 丂丈丗丄不丅丅丙丒.InappId, 丈七丟三丈丈与丗丏:  val_16.ItemsParams, 丆一丂下丟丙丟且与:  val_22);
        }
        public 上丏丕且丕三专丏业()
        {
        
        }
        private static 上丏丕且丕三专丏业()
        {
            null = null;
            PGCompany.上丏丕且丕三专丏业.丝业丆丁业三丈丟东 = new System.Lazy<PGCompany.上丏丕且丕三专丏业>(valueFactory:  new System.Func<PGCompany.上丏丕且丕三专丏业>(object:  上丏丕且丕三专丏业.<>c.<>9, method:  PGCompany.上丏丕且丕三专丏业 上丏丕且丕三专丏业.<>c::丑一七丈万上丌上业()));
        }
    
    }

}
