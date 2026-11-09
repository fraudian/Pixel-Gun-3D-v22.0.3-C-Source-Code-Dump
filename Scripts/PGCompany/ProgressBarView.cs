using UnityEngine;

namespace PGCompany
{
    internal class ProgressBarView : MonoBehaviour
    {
        // Fields
        private System.Nullable<UnityEngine.Color> 业丒世丘丏下世七丕;
        private UILabel _progressLabel;
        private UIBasicSprite _progressFill;
        private UIBasicSprite[] _additionalProgressFill;
        
        // Methods
        internal void 丝一丅丆三东丂丞七(float 上丞丕专丈业丁世专, float 七丝东丛东丝且丆不, string 下三丝东东且且且丙)
        {
            this.丝一丅丆三东丂丞七(上丞丕专丈业丁世专:  上丞丕专丈业丁世专, 七丝东丛东丝且丆不:  七丝东丛东丝且丆不, 专下业丆丄丕世专下:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 下三丝东东且且且丙:  下三丝东东且且且丙);
        }
        internal void 丝一丅丆三东丂丞七(float 上丞丕专丈业丁世专, float 七丝东丛东丝且丆不, System.Nullable<UnityEngine.Color> 专下业丆丄丕世专下, string 下三丝东东且且且丙)
        {
            float val_14;
            float val_15;
            UIBasicSprite val_16;
            float val_17;
            float val_18;
            var val_19;
            var val_20;
            val_14 = 七丝东丛东丝且丆不;
            val_15 = 上丞丕专丈业丁世专;
            val_16 = this;
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  下三丝东东且且且丙)) != false)
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._progressLabel, 丕丗丘丑丛与丑业丒:  val_15.ToString() + "/"("/") + val_14.ToString());
                val_14 = val_14;
                val_15 = val_15;
            }
            else
            {
                    丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._progressLabel, 丕丗丘丑丛与丑业丒:  下三丝东东且且且丙);
            }
            
            val_17 = val_15 / val_14;
            if(this._progressFill != 0)
            {
                    val_18 = val_17;
                this._progressFill.fillAmount = val_18;
            }
            
            val_19 = 0;
            goto label_13;
            label_20:
            UIBasicSprite val_13 = this._additionalProgressFill[0];
            if(val_13 != 0)
            {
                    val_18 = val_17;
                val_13.fillAmount = val_18;
            }
            
            val_19 = 1;
            label_13:
            if(val_19 < this._additionalProgressFill.Length)
            {
                goto label_20;
            }
            
            if(this.业丒世丘丏下世七丕.HasValue != true)
            {
                    if(this._progressFill != 0)
            {
                    UnityEngine.Color val_9 = this._progressFill.color;
                mem2[0] = 0;
                mem2[0] = 0;
            }
            
            }
            
            if((this._progressFill != 0) && (专下业丆丄丕世专下.HasValue.HasValue != false))
            {
                    val_16 = this._progressFill;
                val_20 = 1152921525605872656;
            }
            else
            {
                    if(this.业丒世丘丏下世七丕.HasValue == false)
            {
                    return;
            }
            
                val_16 = this._progressFill;
                val_20 = 1152921525605872656;
            }
            
            val_17 = 0;
            val_16.color = new UnityEngine.Color() {r = 0f, g = val_9.g, b = val_9.b, a = val_9.a};
        }
        public ProgressBarView()
        {
        
        }
    
    }

}
