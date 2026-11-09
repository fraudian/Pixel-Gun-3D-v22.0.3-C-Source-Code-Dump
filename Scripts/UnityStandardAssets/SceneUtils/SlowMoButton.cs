using UnityEngine;

namespace UnityStandardAssets.SceneUtils
{
    public class SlowMoButton : MonoBehaviour
    {
        // Fields
        public UnityEngine.UI.Button button;
        public float fullSpeed;
        public UnityEngine.Sprite FullSpeedTex;
        private bool 丁丁丙丈丑丑丁不下;
        public float slowSpeed;
        public UnityEngine.Sprite SlowSpeedTex;
        
        // Methods
        private void Start()
        {
            this.丁丁丙丈丑丑丁不下 = false;
        }
        private void OnDestroy()
        {
            UnityEngine.Time.timeScale = 1f;
        }
        public void ChangeSpeed()
        {
            var val_5;
            bool val_5 = this.丁丁丙丈丑丑丁不下;
            val_5 = val_5 ^ 1;
            this.丁丁丙丈丑丑丁不下 = val_5;
            UnityEngine.UI.Graphic val_1 = this.button.targetGraphic;
            val_5 = 0;
            if( != 0)
            {
                    sprite = (this.丁丁丙丈丑丑丁不下 == true) ? this.SlowSpeedTex : this.FullSpeedTex;
            }
            
            this.button.targetGraphic = ;
            UnityEngine.Time.timeScale = (this.丁丁丙丈丑丑丁不下 == false) ? this.fullSpeed : this.slowSpeed;
        }
        public SlowMoButton()
        {
            this.fullSpeed = 1f;
            this.slowSpeed = 0.3f;
        }
    
    }

}
