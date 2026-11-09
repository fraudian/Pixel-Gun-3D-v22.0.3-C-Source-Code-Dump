using UnityEngine;

namespace PGCompany
{
    internal class 丏万丏丂业丞一上且 : 丝丆丌丏丆丆丗丙三
    {
        // Fields
        private bool 与且七下且丕万丙丂;
        
        // Methods
        public 丏万丏丂业丞一上且(string 丝三丗万丞丁丄丌一)
        {
        
        }
        protected override void 下与丞三丅丛丄七丕(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            if(丛丑业万丗丝丒三丗 == 0)
            {
                    return;
            }
            
            UIButton val_3 = 丛丑业万丗丝丒三丗.丅与丌专丟一丝业三().GetComponent<UIButton>();
            if(val_3 == 0)
            {
                    return;
            }
            
            this.与且七下且丕万丙丂 = val_3 & 1;
            if(val_3 == null)
            {
                
            }
        
        }
        protected override void 丆世与丑丆丅丐万且(TagSystem.CompoundTagBehaviour 丛丑业万丗丝丒三丗)
        {
            if(丛丑业万丗丝丒三丗 == 0)
            {
                    return;
            }
            
            if((丛丑业万丗丝丒三丗.丅与丌专丟一丝业三().GetComponent<UIButton>()) == 0)
            {
                    return;
            }
            
            var val_5 = (this.与且七下且丕万丙丂 == true) ? 1 : 0;
            goto typeof(UIButton).__il2cppRuntimeField_178;
        }
    
    }

}
