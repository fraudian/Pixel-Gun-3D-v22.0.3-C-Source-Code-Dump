using UnityEngine;

namespace PGCompany
{
    internal sealed class TimerUI : PGBehaviour
    {
        // Fields
        private PGCompany.不丘丌专世丐丂丙丏 _format;
        private UILabel _timerLabel;
        internal string prefixString;
        private string localizationKey;
        private string formatString;
        private bool _showZero;
        private UnityEngine.Coroutine 三丄丝丐丙东丙丐丑;
        private Rilisoft.丝丑丂丛万丐丈丘且 世丆不下一专专丟丆;
        private System.Action 上七与丂丟丄丂丙丈;
        private System.Action 丘下丂丌丛丌丕丅丆;
        private float 丄下丛上丈丟丈专三;
        private System.Func<int, string> 丆不丝丂下与丙丆丌;
        internal System.Nullable<int> 不与丄下丗丛丗丄与;
        private UnityEngine.Color 丑丌三丏七万丞专东;
        
        // Methods
        private void Awake()
        {
            if(this._timerLabel != 0)
            {
                goto label_3;
            }
            
            UILabel val_2 = this.GetComponent<UILabel>();
            this._timerLabel = val_2;
            if(val_2 == null)
            {
                goto label_4;
            }
            
            label_6:
            UnityEngine.Color val_3 = val_2.color;
            goto label_5;
            label_3:
            if(this._timerLabel != null)
            {
                goto label_6;
            }
            
            label_4:
            UnityEngine.Color val_4 = UnityEngine.Color.white;
            label_5:
            this.丑丌三丏七万丞专东 = val_4;
            mem[1152921556101971164] = val_4.g;
            mem[1152921556101971168] = val_4.b;
            mem[1152921556101971172] = val_4.a;
            if(this.丆不丝丂下与丙丆丌 != null)
            {
                    return;
            }
            
            this.且丄下世丂丘丌丑丘();
        }
        internal void 丏丗丐丝丞丆一丙与(string 下上丐丆丝丟丝丒不)
        {
            this.localizationKey = 下上丐丆丝丟丝丒不;
        }
        internal void 丈且东丑丂且万丒丅(int 丆丐七丅丆丗丛上与, System.Action 三丘丄丕丂丏东不丛, float 丛且丛丛下丒丑丙七 = 0, System.Func<int, string> 世丐与丈三丝丌丄丑, System.Action 与丌一丑且丗三丙一)
        {
            Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丆丐七丅丆丗丛上与);
            this.世丆不下一专专丟丆 = val_1;
            mem[1152921556102231976] = val_1.上万三丆专丏丒丗业;
            this.上七与丂丟丄丂丙丈 = 三丘丄丕丂丏东不丛;
            this.丘下丂丌丛丌丕丅丆 = 与丌一丑且丗三丙一;
            this.丄下丛上丈丟丈专三 = 丛且丛丛下丒丑丙七;
            if(世丐与丈三丝丌丄丑 != null)
            {
                    this.丆不丝丂下与丙丆丌 = 世丐与丈三丝丌丄丑;
            }
            
            if(this.isActiveAndEnabled == false)
            {
                    return;
            }
            
            this.且丒不丙丌丅丑丂丄();
        }
        private void OnEnable()
        {
            this.且丒不丙丌丅丑丂丄();
        }
        private void 且丒不丙丌丅丑丂丄()
        {
            if(this.三丄丝丐丙东丙丐丑 != null)
            {
                    this.StopCoroutine(routine:  this.三丄丝丐丙东丙丐丑);
                this.三丄丝丐丙东丙丐丑 = 0;
            }
            
            this.三丄丝丐丙东丙丐丑 = this.StartCoroutine(routine:  this.与东丆丟丞丈一丕上());
        }
        internal void 一丛丄七一且东三七()
        {
            if(this.三丄丝丐丙东丙丐丑 == null)
            {
                    return;
            }
            
            this.StopCoroutine(routine:  this.三丄丝丐丙东丙丐丑);
            this.三丄丝丐丙东丙丐丑 = 0;
        }
        private void OnApplicationFocus(bool 丄丈丁下丛世丙丗上)
        {
            if(丄丈丁下丛世丙丗上 != false)
            {
                    return;
            }
            
            this.且丒不丙丌丅丑丂丄();
        }
        private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
        {
            if(东丗七丕丄不丐专丒 != false)
            {
                    return;
            }
            
            this.且丒不丙丌丅丑丂丄();
        }
        private System.Collections.IEnumerator 与东丆丟丞丈一丕上()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new TimerUI.丝丘丑一丁丂丕丐世();
        }
        internal void 丆三且丆三不世丈丌()
        {
            this.上丛业丙丙七丒丝丁(丆丐七丅丆丗丛上与:  this.世丆不下一专专丟丆);
        }
        private void 上丛业丙丙七丒丝丁(int 丆丐七丅丆丗丛上与)
        {
            object val_10;
            UILabel val_11;
            string val_12;
            var val_13;
            UnityEngine.Color val_14;
            float val_15;
            float val_16;
            float val_17;
            if(this.丆不丝丂下与丙丆丌 == null)
            {
                    return;
            }
            
            val_10 = this.丆不丝丂下与丙丆丌.Invoke(arg:  丆丐七丅丆丗丛上与);
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.localizationKey)) == false)
            {
                goto label_4;
            }
            
            val_11 = this._timerLabel;
            string val_3 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.localizationKey);
            goto label_7;
            label_4:
            val_11 = this._timerLabel;
            if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.formatString)) == false)
            {
                goto label_10;
            }
            
            val_12 = this.formatString;
            label_7:
            val_10 = System.String.Format(format:  val_12, arg0:  val_10);
            val_13 = null;
            goto label_13;
            label_10:
            val_13 = null;
            label_13:
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_11, 丕丗丘丑丛与丑业丒:  val_10);
            if((System.String.IsNullOrEmpty(value:  this.prefixString)) != true)
            {
                    val_10 = this._timerLabel;
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_10, 丕丗丘丑丛与丑业丒:  this.prefixString + val_10.text);
            }
            
            if((this.不与丄下丗丛丗丄与 & 1) == 0)
            {
                goto label_20;
            }
            
            val_10 = this._timerLabel;
            if(this.不与丄下丗丛丗丄与 >= 丆丐七丅丆丗丛上与)
            {
                goto label_21;
            }
            
            val_14 = this.丑丌三丏七万丞专东;
            if(val_10 != null)
            {
                goto label_24;
            }
            
            goto label_23;
            label_21:
            UnityEngine.Color val_9 = UnityEngine.Color.red;
            val_14 = val_9.r;
            val_15 = val_9.g;
            val_16 = val_9.b;
            val_17 = val_9.a;
            if(val_10 != null)
            {
                goto label_24;
            }
            
            label_23:
            label_24:
            val_10.color = new UnityEngine.Color() {r = val_14, g = val_15, b = val_16, a = val_17};
            label_20:
            if(this.丘下丂丌丛丌丕丅丆 == null)
            {
                    return;
            }
            
            this.丘下丂丌丛丌丕丅丆.Invoke();
        }
        private void 且丄下世丂丘丌丑丘()
        {
            if(this._format != 0)
            {
                    return;
            }
            
            this.丆不丝丂下与丙丆丌 = new System.Func<System.Int32, System.String>(object:  this, method:  System.String PGCompany.TimerUI::丟一丈丑业丑丆世七(int 丆丐七丅丆丗丛上与));
        }
        private void 丑丝丛丘丄一业一丝(System.Func<int, string> 世丐与丈三丝丌丄丑)
        {
            this.丆不丝丂下与丙丆丌 = 世丐与丈三丝丌丄丑;
        }
        internal void 丒丁丅一下丂专万不(string 丕丗丘丑丛与丑业丒)
        {
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._timerLabel, 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
        }
        public TimerUI()
        {
        
        }
        private string 丟一丈丑业丑丆世七(int 丆丐七丅丆丗丛上与)
        {
            return 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  丆丐七丅丆丗丛上与, 丒且下丘丅丘丛丆且:  (this._showZero == true) ? 1 : 0, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        }
    
    }

}
