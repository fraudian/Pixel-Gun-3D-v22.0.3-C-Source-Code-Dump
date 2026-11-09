using UnityEngine;

namespace Rilisoft
{
    internal sealed class TrainingBlinking : MonoBehaviour
    {
        // Fields
        private TouchButton 东丝丙丑世丅丅丈丁;
        
        // Methods
        public void SetButton(TouchButton 丟丒丞丐丐丘丒丄东)
        {
            this.东丝丙丑世丅丅丈丁 = 丟丒丞丐丐丘丒丄东;
        }
        private void OnDisable()
        {
            UnityEngine.Object.Destroy(obj:  this);
        }
        private void OnDestroy()
        {
        
        }
        private void OnEnable()
        {
            if(this.东丝丙丑世丅丅丈丁 == null)
            {
                
            }
        
        }
        public TrainingBlinking()
        {
        
        }
    
    }

}
