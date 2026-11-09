using UnityEngine;

namespace Rilisoft
{
    public class WindowAnimatorSlave : MonoBehaviour, 一丆丌丕丆丄专丞丄
    {
        // Fields
        private Rilisoft.FogSettings _fogSettings;
        private Rilisoft.WindowAnimator 丞业丆丛业丟一丛东;
        private UIViewport uiCameraScaler;
        
        // Methods
        public void AnimationStarting(Rilisoft.WindowAnimator 丁万七业一丞丝世丛)
        {
            this.uiCameraScaler.enabled = true;
            this.丞业丆丛业丟一丛东 = 丁万七业一丞丝世丛;
        }
        public void AnimationStopped()
        {
            if(this.gameObject.activeInHierarchy == false)
            {
                    return;
            }
            
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.业丅且世丝业东七丏());
        }
        private System.Collections.IEnumerator 业丅且世丝业东七丏()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new WindowAnimatorSlave.丑丗丗业丆丏丅丘专();
        }
        public WindowAnimatorSlave()
        {
        
        }
    
    }

}
