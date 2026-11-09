using UnityEngine;

namespace PGCompany.MainStore
{
    internal class 不与丅三丛三且丁丅 : 丞一丌不万丐丆业丐
    {
        // Fields
        private readonly string 丗丄不不丒丕丕丛丑;
        
        // Methods
        internal 不与丅三丛三且丁丅(string 丛丐且下丂丏丁专丌)
        {
            this.丗丄不不丒丕丕丛丑 = 丛丐且下丂丏丁专丌;
        }
        internal override System.Collections.Generic.IEnumerable<PGCompany.MainStore.专丁丄东上专丞世与> 三丛丞丂丑世丆三丕()
        {
            var val_8;
            string val_16;
            System.Collections.Generic.List<PGCompany.MainStore.专丁丄东上专丞世与> val_1 = new System.Collections.Generic.List<PGCompany.MainStore.专丁丄东上专丞世与>();
            PGCompany.东丑丒丗一丞下丙丙<T> val_4 = PGCompany.东丑丒丗一丞下丙丙<PGCompany.ShopSystem.丈丈世丏丂丄丂万丒>.万世丅七一专丕丞不();
            val_16 = 0;
            bool val_5 = PGCompany.ShopSystem.丝丏丏丕丏丘丑丐丞.丑七不且上丗丁一世().丁一丝丘七丐丕丗与(丑上丅丏七万东丗丕:  this.丗丄不不丒丕丕丛丑, 丞丑丞丒丙丄丄且丐:  val_16, 专丂丕丗丗东世丞下: ref  val_4);
            List.Enumerator<T> val_6 = val_4.GetEnumerator();
            label_12:
            if(((-602931328) & 1) == 0)
            {
                goto label_6;
            }
            
            if(val_8.丐丏七丌丕丗业且上() == null)
            {
                goto label_12;
            }
            
            new PGCompany.DataObjects.丙七丘三丛丕丙丒丒() = new PGCompany.DataObjects.丙七丘三丛丕丙丒丒();
            System.Collections.Generic.List<System.String> val_11 = new System.Collections.Generic.List<System.String>();
            null.Add(item:  this.丗丄不不丒丕丕丛丑);
            .Shops = null;
            .Section = val_9.m_stringLength;
            .TitleLocKey = val_9.m_stringLength;
            .Season = val_9.m_stringLength;
            System.Collections.Generic.List<PGCompany.MainStore.丙丟下万丅一与丑不> val_12 = new System.Collections.Generic.List<PGCompany.MainStore.丙丟下万丅一与丑不>();
            new PGCompany.MainStore.丄丙丗丂下七与丒一() = new PGCompany.MainStore.丄丙丗丂下七与丒一(业丅丒丆丄丟三丟丞:  val_9.m_stringLength);
            null.Add(item:  new PGCompany.MainStore.丄丙丗丂下七与丒一());
            new PGCompany.MainStore.专丁丄东上专丞世与() = new PGCompany.MainStore.专丁丄东上专丞世与(丗丟上上丒丐丗丞丙:  new PGCompany.MainStore.且丆丗丐东上丌丈丟() {丒三丝一上丙专丗丒 = 2, 七下东丅东丐且丄丞 = new PGCompany.DataObjects.丙七丘三丛丕丙丒丒()});
            val_1.Add(item:  new PGCompany.MainStore.专丁丄东上专丞世与());
            goto label_12;
            label_6:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if((PGCompany.东丑丒丗一丞下丙丙<PGCompany.ShopSystem.丈丈世丏丂丄丂万丒>.万世丅七一专丕丞不()) != null)
            {
                    return (System.Collections.Generic.IEnumerable<PGCompany.MainStore.专丁丄东上专丞世与>)val_1;
            }
            
            return (System.Collections.Generic.IEnumerable<PGCompany.MainStore.专丁丄东上专丞世与>)val_1;
        }
    
    }

}
