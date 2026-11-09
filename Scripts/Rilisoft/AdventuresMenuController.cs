using UnityEngine;

namespace Rilisoft
{
    internal sealed class AdventuresMenuController : MonoBehaviour
    {
        // Fields
        private float 丁业与丄丑业丆丆丐;
        private UIButton sandboxButton;
        private float period;
        
        // Methods
        private void Awake()
        {
        
        }
        private void OnEnable()
        {
            this.业不不且丐且与不与();
        }
        private void 业不不且丐且与不与()
        {
            var val_7;
            this.sandboxButton.gameObject.SetActive(value:  true);
            UnityEngine.Transform val_3 = this.sandboxButton.transform.parent;
            if(val_3 != null)
            {
                    UnityEngine.Vector3 val_4 = val_3.localPosition;
                val_7 = val_4.y;
            }
            else
            {
                    UnityEngine.Vector3 val_5 = 0.localPosition;
                val_7 = val_5.y;
            }
            
            UnityEngine.Vector3 val_6 = val_3.localPosition;
            val_3.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        private bool 与丁丌丑丗丘丏丈丕()
        {
            return true;
        }
        public AdventuresMenuController()
        {
            this.period = 334f;
        }
    
    }

}
