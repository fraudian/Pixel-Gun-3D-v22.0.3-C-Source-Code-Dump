using UnityEngine;

namespace Rilisoft
{
    public class WindowAnimator : MonoBehaviour
    {
        // Fields
        private UnityEngine.Coroutine 丑世丒丑丟三丝丁丑;
        private UnityEngine.Coroutine 万专上丆丗一丅丟丆;
        private Rilisoft.一丆丌丕丆丄专丞丄[] 万不丗丆丅东丛丕丝;
        private Rilisoft.WindowAnimator.丙丟丙三万丐丛丑丒 <丐丅丙丈世东一丒东>k__BackingField;
        private float <一三七丑丆丐丙丈一>k__BackingField;
        private System.Action<bool, Rilisoft.WindowAnimator.丙丟丙三万丐丛丑丒> 丁丑丁丘丞丐丈且丘;
        private float _animationTime;
        private UnityEngine.AnimationCurve _scaleCurve;
        private UnityEngine.GameObject[] 丘丂丑丟丕丆丆丑专;
        
        // Properties
        public Rilisoft.WindowAnimator.丙丟丙三万丐丛丑丒 丟世丆丕丌且七下丂 { get; set; }
        public float 丕上丁七与丘专专丞 { get; set; }
        public bool 万丏丏丁丈丌且业东 { get; }
        
        // Methods
        public Rilisoft.WindowAnimator.丙丟丙三万丐丛丑丒 get_Direction()
        {
            return (丙丟丙三万丐丛丑丒)this.<丐丅丙丈世东一丒东>k__BackingField;
        }
        private void 一七丄丆丌一丟丅不(Rilisoft.WindowAnimator.丙丟丙三万丐丛丑丒 丙业与丙丗丝不丈东)
        {
            this.<丐丅丙丈世东一丒东>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public float get_PlayProgress()
        {
            return (float)this.<一三七丑丆丐丙丈一>k__BackingField;
        }
        private void 丕丑东丆丒东丆丄东(float 丙业与丙丗丝不丈东)
        {
            this.<一三七丑丆丐丙丈一>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_AnimationPlaying()
        {
            return (bool)(this.丑世丒丑丟三丝丁丑 != 0) ? 1 : 0;
        }
        private void OnDisable()
        {
            this.丑世丒丑丟三丝丁丑 = 0;
            this.万专上丆丗一丅丟丆 = 0;
            this.<丐丅丙丈世东一丒东>k__BackingField = 1;
            this.丏丙丒专世东丕丛丈(下丐丈丄丗丞丕业丆:  false);
        }
        public void Animate(UnityEngine.Vector3 专丂丕丗丗东世丞下, Rilisoft.WindowAnimator.丙丟丙三万丐丛丑丒 世一丑丝丈一上三丕, bool 丗三丐丞丒专丆丁丅 = False)
        {
            UnityEngine.Vector3 val_3 = this.gameObject.transform.position;
            丗三丐丞丒专丆丁丅 = 丗三丐丞丒专丆丁丅;
            this.Animate(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}, 世一丑丝丈一上三丕:  世一丑丝丈一上三丕, 丗三丐丞丒专丆丁丅:  丗三丐丞丒专丆丁丅);
        }
        public void Animate(UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下, Rilisoft.WindowAnimator.丙丟丙三万丐丛丑丒 世一丑丝丈一上三丕, bool 丗三丐丞丒专丆丁丅 = False)
        {
            bool val_17 = 丗三丐丞丒专丆丁丅;
            this.<丐丅丙丈世东一丒东>k__BackingField = 世一丑丝丈一上三丕;
            this.万不丗丆丅东丛丕丝 = this.gameObject.GetComponentsInChildren<Rilisoft.一丆丌丕丆丄专丞丄>(includeInactive:  true);
            if(this.丑世丒丑丟三丝丁丑 != null)
            {
                    this.StopCoroutine(routine:  this.丑世丒丑丟三丝丁丑);
            }
            
            if(this.万专上丆丗一丅丟丆 != null)
            {
                    this.StopCoroutine(routine:  this.万专上丆丗一丅丟丆);
            }
            
            if(val_17 != false)
            {
                    this.<一三七丑丆丐丙丈一>k__BackingField = 0f;
                this.丁丑丁丘丞丐丈且丘.Invoke(arg1:  true, arg2:  this.<丐丅丙丈世东一丒东>k__BackingField);
                this.gameObject.transform.localPosition = new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z};
                UnityEngine.Vector3 val_9 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, d:  this._scaleCurve.Evaluate(time:  ((this.<丐丅丙丈世东一丒东>k__BackingField) == 0) ? 1f : 0f));
                this.gameObject.transform.localScale = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
                this.丁丑丁丘丞丐丈且丘.Invoke(arg1:  false, arg2:  this.<丐丅丙丈世东一丒东>k__BackingField);
                return;
            }
            
            this.丑世丒丑丟三丝丁丑 = this.StartCoroutine(routine:  this.丗业万下丕丁丟丞丈(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = 丈丗与丞一上且上上.x, y = 丈丗与丞一上且上上.y, z = 丈丗与丞一上且上上.z}, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z}));
            if(this._scaleCurve == null)
            {
                    return;
            }
            
            val_17 = this._scaleCurve.keys;
            if(val_13.Length == 0)
            {
                    return;
            }
            
            this.万专上丆丗一丅丟丆 = this.StartCoroutine(routine:  this.丝丏业丟一丟业丁与(丅万且万丄丁七专丅:  (世一丑丝丈一上三丕 == 0) ? 1 : 0));
        }
        public void add_OnAnimationStateChanged(System.Action<bool, Rilisoft.WindowAnimator.丙丟丙三万丐丛丑丒> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丁丑丁丘丞丐丈且丘, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丁丑丁丘丞丐丈且丘 != 1152921543610493384);
        
        }
        public void remove_OnAnimationStateChanged(System.Action<bool, Rilisoft.WindowAnimator.丙丟丙三万丐丛丑丒> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丁丑丁丘丞丐丈且丘, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丁丑丁丘丞丐丈且丘 != 1152921543610629960);
        
        }
        private System.Collections.IEnumerator 丗业万下丕丁丟丞丈(UnityEngine.Vector3 丈丗与丞一上且上上, UnityEngine.Vector3 专丂丕丗丗东世丞下)
        {
            WindowAnimator.丗七丟丗丞丂丏上丑 val_1 = new WindowAnimator.丗七丟丗丞丂丏上丑();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丈丗与丞一上且上上 = 丈丗与丞一上且上上;
            mem[1152921543610790332] = 丈丗与丞一上且上上.y;
            mem[1152921543610790336] = 丈丗与丞一上且上上.z;
            .专丂丕丗丗东世丞下 = 专丂丕丗丗东世丞下;
            mem[1152921543610790344] = 专丂丕丗丗东世丞下.y;
            mem[1152921543610790348] = 专丂丕丗丗东世丞下.z;
            return (System.Collections.IEnumerator)val_1;
        }
        private System.Collections.IEnumerator 丝丏业丟一丟业丁与(bool 丅万且万丄丁七专丅)
        {
            WindowAnimator.丝丝万丁丂丛丆丈上 val_1 = new WindowAnimator.丝丝万丁丂丛丆丈上();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
            }
            else
            {
                    mem[32] = this;
            }
            
            .丅万且万丄丁七专丅 = 丅万且万丄丁七专丅;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 丏丙丒专世东丕丛丈(bool 下丐丈丄丗丞丕业丆)
        {
            var val_6;
            .下丐丈丄丗丞丕业丆 = 下丐丈丄丗丞丕业丆;
            if((this.万不丗丆丅东丛丕丝 == null) || (this.万不丗丆丅东丛丕丝.Length < 1))
            {
                goto label_3;
            }
            
            label_17:
            if(0 >= this.万不丗丆丅东丛丕丝.Length)
            {
                    val_6 = 0;
            }
            
            Rilisoft.一丆丌丕丆丄专丞丄 val_7 = this.万不丗丆丅东丛丕丝[0];
            if(val_7 == null)
            {
                goto label_16;
            }
            
            if((WindowAnimator.丌丐丝丐下上三丛丌)[1152921543611121840].下丐丈丄丗丞丕业丆 == false)
            {
                goto label_7;
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            val_6 = 0;
            goto label_11;
            label_7:
            var val_9 = 0;
            val_9 = val_9 + 1;
            goto label_15;
            label_11:
            val_7.AnimationStarting(丁万七业一丞丝世丛:  this);
            goto label_16;
            label_15:
            val_7.AnimationStopped();
            label_16:
            if((0 + 1) < this.万不丗丆丅东丛丕丝.Length)
            {
                goto label_17;
            }
            
            label_3:
            if(this.丘丂丑丟丕丆丆丑专 != null)
            {
                    丞东丑专丛丆丄丝世.且三丁且与丆一世下<UnityEngine.GameObject>(丌丛丏业世丄丞三丌:  this.丘丂丑丟丕丆丆丑专, 七丐丅专且专七三丆:  new System.Action<UnityEngine.GameObject>(object:  new WindowAnimator.丌丐丝丐下上三丛丌(), method:  System.Void WindowAnimator.丌丐丝丐下上三丛丌::丈丕世丞三且丄丆不(UnityEngine.GameObject 丄三丅七丆丛与与上)));
            }
            
            if(this.丁丑丁丘丞丐丈且丘 == null)
            {
                    return;
            }
            
            this.丁丑丁丘丞丐丈且丘.Invoke(arg1:  (WindowAnimator.丌丐丝丐下上三丛丌)[1152921543611121840].下丐丈丄丗丞丕业丆, arg2:  this.<丐丅丙丈世东一丒东>k__BackingField);
        }
        public WindowAnimator()
        {
            this._animationTime = 0.5f;
        }
    
    }

}
