using UnityEngine;

namespace PGCompany
{
    internal sealed class 七丅丑丈且下丄丄丁 : 丝丆丌丏丆丆丗丙三
    {
        // Fields
        private string 且丞丐丞丐下丟丗与;
        
        // Methods
        public 七丅丑丈且下丄丄丁(string 丝三丗万丞丁丄丌一, string 丅业世与专且业东丟)
        {
            this.且丞丐丞丐下丟丗与 = 丅业世与专且业东丟;
        }
        protected override void 下与丞三丅丛丄七丕(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            HintController val_1 = this.三丁业丁万丄七与专(丛丑业万丗丝丒三丗:  丛丑业万丗丝丒三丗);
            if(val_1 != null)
            {
                    val_1.丄一丟丕丌业丆上丌(丒丘丏上丙丟丑丕丈:  this.且丞丐丞丐下丟丗与, 丂三丟丂丈丐丆丗丟:  0f);
            }
            else
            {
                    0.丄一丟丕丌业丆上丌(丒丘丏上丙丟丑丕丈:  this.且丞丐丞丐下丟丗与, 丂三丟丂丈丐丆丗丟:  0f);
            }
            
            val_1.丙万丞丄丐丂下丅丘();
        }
        protected override void 丆世与丑丆丅丐万且(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            this.三丁业丁万丄七与专(丛丑业万丗丝丒三丗:  丛丑业万丗丝丒三丗).三东丐丕上丑下万与(丒丘丏上丙丟丑丕丈:  this.且丞丐丞丐下丟丗与);
        }
        private HintController 三丁业丁万丄七与专(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            PGCompany.HintLinkHolder val_1 = 丛丑业万丗丝丒三丗.GetComponent<PGCompany.HintLinkHolder>();
            if(val_1 == 0)
            {
                    return HintController.与一丅丝不丈业与丙();
            }
            
            if(val_1 != null)
            {
                    return val_1.东丑上业三丝丙丅丛();
            }
            
            return val_1.东丑上业三丝丙丅丛();
        }
    
    }

}
