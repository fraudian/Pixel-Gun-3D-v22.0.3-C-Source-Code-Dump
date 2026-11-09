using UnityEngine;

namespace PGCompany
{
    internal sealed class 丕三业丗一丌丗丁丆 : 下东丌丝三丑一丑万
    {
        // Fields
        private System.Action 丂七丝丝丌一丈丌丆;
        
        // Methods
        internal 丕三业丗一丌丗丁丆(System.Action 业丏丈世世世丞丒世)
        {
            this.丂七丝丝丌一丈丌丆 = 业丏丈世世世丞丒世;
        }
        internal override void 上丑丒三丐一丈三丛(System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 丞东丂丝东丒丝丅东)
        {
        
        }
        internal override void 丐丝丏三丛丕三丙丂(System.Collections.Generic.List<PGCompany.丗丟丄丈东丝丕丄世> 丛丐与丌丑专丑七丄)
        {
            if(this.丂七丝丝丌一丈丌丆 == null)
            {
                    return;
            }
            
            this.丂七丝丝丌一丈丌丆.Invoke();
        }
    
    }

}
