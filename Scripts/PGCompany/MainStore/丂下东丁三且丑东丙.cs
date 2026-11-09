using UnityEngine;

namespace PGCompany.MainStore
{
    internal class 丂下东丁三且丑东丙 : 丞一丌不万丐丆业丐
    {
        // Fields
        private readonly PGCompany.DataObjects.丙七丘三丛丕丙丒丒 一丄丝丆丐丘七丅丄;
        private readonly System.Collections.Generic.IReadOnlyList<PGCompany.MainStore.丙丟下万丅一与丑不> 丞丘与一丟丅与丏丈;
        
        // Methods
        internal 丂下东丁三且丑东丙(PGCompany.DataObjects.丙七丘三丛丕丙丒丒 丒与世世丂且丗业丁, System.Collections.Generic.IReadOnlyList<PGCompany.MainStore.丙丟下万丅一与丑不> 丄三丟万不丑专丅三)
        {
            this.一丄丝丆丐丘七丅丄 = 丒与世世丂且丗业丁;
            this.丞丘与一丟丅与丏丈 = 丄三丟万不丑专丅三;
        }
        internal override System.Collections.Generic.IEnumerable<PGCompany.MainStore.专丁丄东上专丞世与> 三丛丞丂丑世丆三丕()
        {
            PGCompany.MainStore.专丁丄东上专丞世与 val_1 = new PGCompany.MainStore.专丁丄东上专丞世与(丗丟上上丒丐丗丞丙:  new PGCompany.MainStore.且丆丗丐东上丌丈丟() {丒三丝一上丙专丗丒 = 1, 七下东丅东丐且丄丞 = this.一丄丝丆丐丘七丅丄, 丟丆丌丞三丆丙丐丌 = this.丞丘与一丟丅与丏丈});
            PGCompany.MainStore.专丁丄东上专丞世与[] val_2 = new PGCompany.MainStore.专丁丄东上专丞世与[1];
            if(val_2 == null)
            {
                goto label_1;
            }
            
            if(val_1 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_1 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            val_2[0] = val_1;
            return (System.Collections.Generic.IEnumerable<PGCompany.MainStore.专丁丄东上专丞世与>)val_2;
        }
    
    }

}
