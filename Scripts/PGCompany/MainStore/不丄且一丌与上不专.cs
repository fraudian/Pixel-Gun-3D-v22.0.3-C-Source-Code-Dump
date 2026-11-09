using UnityEngine;

namespace PGCompany.MainStore
{
    internal static class 不丄且一丌与上不专
    {
        // Methods
        internal static void 丝丟七丕万丝丆业丙(System.Collections.Generic.List<int> 丟丛一东丘上丄丁业, string 丟丘不丒上丐丗与丅, ref System.Collections.Generic.List<int> 专丂丕丗丗东世丞下)
        {
            var val_10;
            var val_16;
            var val_17;
            int val_19;
            if(PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().且丆丅丆七丗丛丐丟() == false)
            {
                goto label_2;
            }
            
            val_16 = 1152921505630273536;
            val_17 = 1152921559801186096;
            PGCompany.东丑丒丗一丞下丙丙<T> val_3 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.DataObjects.丄丛一丞丏丕世万三>.万世丅七一专丕丞不();
            bool val_6 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().七丐且丞丙万丏丏万(丙丐万丗丁丏丞专丄:  丟丘不丒上丐丗与丅, 专丂丕丗丗东世丞下: ref  val_3);
            if(val_3 == null)
            {
                goto label_26;
            }
            
            List.Enumerator<T> val_8 = val_3.GetEnumerator();
            label_19:
            if(((-640202352) & 1) == 0)
            {
                goto label_10;
            }
            
            string val_11 = val_10.丐丏七丌丕丗业且上();
            if(StoreKitEventListener.丝丝一丟丈三丂丌丁() != false)
            {
                    val_19 = val_11.m_stringLength;
            }
            else
            {
                    val_19 = val_11.m_firstChar;
            }
            
            if((val_19 < '') || ((丟丛一东丘上丄丁业.Contains(item:  val_19)) == false))
            {
                goto label_19;
            }
            
            专丂丕丗丗东世丞下.Add(item:  val_19);
            goto label_19;
            label_10:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_16 = 1152921505630273536;
            val_17 = 1152921559801186096;
            label_26:
            PGCompany.东丑丒丗一丞下丙丙<T> val_13 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.DataObjects.丄丛一丞丏丕世万三>.万世丅七一专丕丞不();
            label_2:
            if(专丂丕丗丗东世丞下.Count > 0)
            {
                    return;
            }
            
            专丂丕丗丗东世丞下.AddRange(collection:  丟丛一东丘上丄丁业);
        }
        internal static string 业丙丙丐丏丟丞丞丆(PGCompany.DataObjects.丙七丘三丛丕丙丒丒 丒与世世丂且丗业丁, int 世丈三丐丞一丒丛不)
        {
            string val_7;
            bool val_1 = StoreKitEventListener.丝丝一丟丈三丂丌丁();
            if((PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().七丐且丞丙万丏丏万(丙丐万丗丁丏丞专丄:  丒与世世丂且丗业丁.Section, 世丈三丐丞一丒丛不:  世丈三丐丞一丒丛不, 丒丅世与且丈丐丑丙:  val_1)) != null)
            {
                    val_7 = mem[val_1 != true ? val_4.ViewVariantPaying : val_4.ViewVariantNonPaying];
                val_7 = (val_1 != true) ? val_4.ViewVariantPaying : val_4.ViewVariantNonPaying;
            }
            else
            {
                    val_7 = 0;
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_7)) == false)
            {
                    return "view.type." + val_7;
            }
            
            val_7 = 丒与世世丂且丗业丁.ViewVariant;
            return "view.type." + val_7;
        }
        internal static PGCompany.StorePromotionSettings 且一丕丒丌世丄丂七()
        {
            PGCompany.StorePromotionSettings val_1 = new PGCompany.StorePromotionSettings();
            if(val_1 != null)
            {
                    .ItemObtainPlace = 5;
                .ObtainCurrencyCause = 74;
            }
            else
            {
                    mem[200] = 5;
                .ObtainCurrencyCause = 74;
            }
            
            .SpendCurrencyCause = 138;
            return val_1;
        }
    
    }

}
