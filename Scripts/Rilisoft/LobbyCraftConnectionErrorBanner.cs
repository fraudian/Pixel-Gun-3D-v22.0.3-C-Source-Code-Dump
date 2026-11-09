using UnityEngine;

namespace Rilisoft
{
    internal class LobbyCraftConnectionErrorBanner : MonoBehaviour
    {
        // Fields
        private float _closeDelay;
        
        // Methods
        private void OnEnable()
        {
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.万丄丂且与丝丞且丏());
        }
        private void OnDisable()
        {
            if(this.gameObject.activeSelf == false)
            {
                    return;
            }
            
            this.gameObject.SetActive(value:  false);
        }
        private System.Collections.IEnumerator 万丄丂且与丝丞且丏()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new LobbyCraftConnectionErrorBanner.丕一丕世丆丝东下丅();
        }
        private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
        {
            if(丁与丟万丄丒丗专丌 == false)
            {
                    return;
            }
            
            this.gameObject.SetActive(value:  false);
        }
        public LobbyCraftConnectionErrorBanner()
        {
            this._closeDelay = 1f;
        }
    
    }

}
