using UnityEngine;

namespace Rilisoft
{
    internal class TEMPShowUpgradeBanner : MonoBehaviour
    {
        // Fields
        private bool 丌三万世丕丈一丏丐;
        
        // Methods
        private void OnClick()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丌且丟万丅丞丞不丝());
        }
        private System.Collections.IEnumerator 丌且丟万丅丞丞不丝()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new TEMPShowUpgradeBanner.丂丂专丗丏丙丙丌丈();
        }
        private void OnDestroy()
        {
            this.丌三万世丕丈一丏丐 = false;
        }
        public TEMPShowUpgradeBanner()
        {
        
        }
    
    }

}
