using UnityEngine;

namespace Rilisoft
{
    public class AnimationHandler : MonoBehaviour
    {
        // Fields
        private System.Collections.Generic.List<Rilisoft.AnimationHandler.丝丅上不丄业丁丂丟> 丈丅丈丈丂专丘丒丝;
        private System.Collections.Generic.List<Rilisoft.AnimationHandler.丝丅上不丄业丁丂丟> 世专东专下丑专丏万;
        private System.Collections.Generic.List<UnityEngine.AnimationClip> 丘丘专丘一与三丂丅;
        private System.Action<string, Rilisoft.AnimationHandler.丂丌丞七丝上业丅万> 丗丒丙丌丒三丞丑业;
        
        // Methods
        public void add_OnAnimationEvent(System.Action<string, Rilisoft.AnimationHandler.丂丌丞七丝上业丅万> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丗丒丙丌丒三丞丑业, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丗丒丙丌丒三丞丑业 != 1152921543357207168);
        
        }
        public void remove_OnAnimationEvent(System.Action<string, Rilisoft.AnimationHandler.丂丌丞七丝上业丅万> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丗丒丙丌丒三丞丑业, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丗丒丙丌丒三丞丑业 != 1152921543357343744);
        
        }
        public void SubscribeTo(string 丌丁一下丙业丙丗不, Rilisoft.AnimationHandler.丂丌丞七丝上业丅万 丒丁丐下上丒丂三丛, bool 专丞丄丄且三丏万丐, System.Action 业丏丈世世世丞丒世)
        {
            AnimationHandler.丝丅上不丄业丁丂丟 val_1 = new AnimationHandler.丝丅上不丄业丁丂丟();
            if(val_1 != null)
            {
                    .丄下世与专丅丅不丆 = 丌丁一下丙业丙丗不;
                .丞不上丛丒丆丟丘丘 = 丒丁丐下上丒丂三丛;
                .丕东丆三丝一丟丂七 = 专丞丄丄且三丏万丐;
            }
            else
            {
                    mem[16] = 丌丁一下丙业丙丗不;
                .丞不上丛丒丆丟丘丘 = 丒丁丐下上丒丂三丛;
                mem[32] = 专丞丄丄且三丏万丐;
            }
            
            .丒万业丛丏东专世丟 = 业丏丈世世世丞丒世;
            this.丈丅丈丈丂专丘丒丝.Add(item:  val_1);
        }
        public void Unsubscribe(string 丌丁一下丙业丙丗不, Rilisoft.AnimationHandler.丂丌丞七丝上业丅万 丒丁丐下上丒丂三丛, System.Action 业丏丈世世世丞丒世)
        {
            System.Func<TSource, System.Boolean> val_6;
            var val_7;
            AnimationHandler.业东下丕世丗丏万丏 val_1 = new AnimationHandler.业东下丕世丗丏万丏();
            if(val_1 != null)
            {
                    .丌丁一下丙业丙丗不 = 丌丁一下丙业丙丗不;
                .丒丁丐下上丒丂三丛 = 丒丁丐下上丒丂三丛;
            }
            else
            {
                    mem[16] = 丌丁一下丙业丙丗不;
                mem[24] = 丒丁丐下上丒丂三丛;
            }
            
            .业丏丈世世世丞丒世 = 业丏丈世世世丞丒世;
            System.Func<丝丅上不丄业丁丂丟, System.Boolean> val_2 = null;
            val_6 = val_2;
            val_2 = new System.Func<丝丅上不丄业丁丂丟, System.Boolean>(object:  val_1, method:  System.Boolean AnimationHandler.业东下丕世丗丏万丏::丑下丌丘且丝上丞专(Rilisoft.AnimationHandler.丝丅上不丄业丁丂丟 丏丛与丅丛丌万专丌));
            val_7 = 0;
            goto label_3;
            label_7:
            val_6 = System.Linq.Enumerable.ToArray<丝丅上不丄业丁丂丟>(source:  System.Linq.Enumerable.Where<丝丅上不丄业丁丂丟>(source:  this.丈丅丈丈丂专丘丒丝, predicate:  val_2))[0];
            bool val_5 = this.丈丅丈丈丂专丘丒丝.Remove(item:  val_6);
            val_7 = 1;
            label_3:
            if(val_7 < val_4.Length)
            {
                goto label_7;
            }
        
        }
        public bool AnimationIsExists(string 东丐丛丁一东丑丒专)
        {
            string val_4 = 东丐丛丁一东丑丒专;
            AnimationHandler.丌万一一业丝丁丈丝 val_1 = new AnimationHandler.丌万一一业丝丁丈丝();
            if(val_1 != null)
            {
                    .东丐丛丁一东丑丒专 = val_4;
            }
            else
            {
                    mem[16] = val_4;
                val_4 = mem[16];
            }
            
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_4)) == false)
            {
                    return System.Linq.Enumerable.Any<UnityEngine.AnimationClip>(source:  this.丘丘专丘一与三丂丅, predicate:  new System.Func<丟丄七万东与上丒丟, System.Boolean>(object:  val_1, method:  System.Boolean AnimationHandler.丌万一一业丝丁丈丝::丌丒丙下丙万丘一丘(UnityEngine.AnimationClip 丁丂专业丁丅丅丈丙)));
            }
            
            return false;
        }
        private void Awake()
        {
            var val_19;
            var val_38;
            System.Collections.Generic.List<UnityEngine.AnimationClip> val_41;
            var val_42;
            var val_43;
            System.Collections.Generic.List<UnityEngine.AnimationClip> val_47;
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            this.丘丘专丘一与三丂丅.Clear();
            UnityEngine.Animation val_1 = this.GetComponent<UnityEngine.Animation>();
            if(val_1 == 0)
            {
                goto label_4;
            }
            
            System.Collections.IEnumerator val_3 = val_1.GetEnumerator();
            val_38 = 1152921504881287168;
            label_21:
            var val_38 = 0;
            val_38 = val_38 + 1;
            if(val_3.MoveNext() == false)
            {
                goto label_11;
            }
            
            var val_39 = 0;
            val_39 = val_39 + 1;
            object val_7 = val_3.Current;
            if(val_7 != null)
            {
                    if(null == null)
            {
                goto label_18;
            }
            
            }
            
            val_41 = this.丘丘专丘一与三丂丅;
            goto label_19;
            label_18:
            val_41 = this.丘丘专丘一与三丂丅;
            label_19:
            val_41.Add(item:  val_7.clip);
            goto label_21;
            label_4:
            val_42 = 0;
            goto label_39;
            label_11:
            val_42 = 0;
            val_43 = 0;
            if(val_3 != null)
            {
                    var val_40 = 0;
                val_40 = val_40 + 1;
                val_3.Dispose();
            }
            
            if(( == 1) || (133 != 133))
            {
                goto label_37;
            }
            
            val_42 = 0;
            goto label_38;
            label_37:
            label_39:
            UnityEngine.Animator val_11 = this.GetComponent<UnityEngine.Animator>();
            if(val_11 == 0)
            {
                goto label_42;
            }
            
            val_47 = System.Linq.Enumerable.ToList<UnityEngine.AnimationClip>(source:  val_11.runtimeAnimatorController.animationClips);
            val_43 = 0;
            val_48 = 0;
            this.丘丘专丘一与三丂丅 = val_47;
            if(val_47 != null)
            {
                goto label_47;
            }
            
            goto label_46;
            label_42:
            val_43 = 0;
            label_38:
            val_47 = this.丘丘专丘一与三丂丅;
            val_48 = val_43;
            if(val_47 != null)
            {
                goto label_47;
            }
            
            label_46:
            label_47:
            if(val_47.Count <= 0)
            {
                goto label_48;
            }
            
            List.Enumerator<T> val_17 = this.丘丘专丘一与三丂丅.GetEnumerator();
            val_38 = 1152921543358088256;
            label_80:
            if((96653056 & 1) == 0)
            {
                goto label_50;
            }
            
            string val_20 = val_19.丐丏七丌丕丗业且上();
            val_49 = 0;
            val_50 = 0;
            val_51 = 0;
            goto label_52;
            label_64:
            UnityEngine.AnimationEvent val_41 = val_20.events[0];
            if(val_41.time == 0f)
            {
                    UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                val_51 = val_51 | (System.String.op_Equality(a:  val_41.functionName, b:  0.ToString()));
            }
            
            if(val_41.time == val_20.length)
            {
                    UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                val_50 = val_50 | (System.String.op_Equality(a:  val_41.functionName, b:  1.ToString()));
            }
            
            val_49 = 1;
            label_52:
            if(val_49 < val_21.Length)
            {
                goto label_64;
            }
            
            if(val_51 != true)
            {
                    new UnityEngine.AnimationEvent() = new UnityEngine.AnimationEvent();
                new UnityEngine.AnimationEvent().time = 0f;
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
                new UnityEngine.AnimationEvent().functionName = 0.ToString();
                new UnityEngine.AnimationEvent().stringParameter = val_20.name;
                val_20.AddEvent(evt:  new UnityEngine.AnimationEvent());
            }
            
            if(val_50 == true)
            {
                goto label_80;
            }
            
            new UnityEngine.AnimationEvent() = new UnityEngine.AnimationEvent();
            new UnityEngine.AnimationEvent().time = val_20.length;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            new UnityEngine.AnimationEvent().functionName = 1.ToString();
            new UnityEngine.AnimationEvent().stringParameter = val_20.name;
            val_20.AddEvent(evt:  new UnityEngine.AnimationEvent());
            goto label_80;
            label_48:
            UnityEngine.Debug.LogError(message:  "animations not found");
            return;
            label_50:
            val_52 = val_48;
            val_53 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
            if( != 1)
            {
                    if( == 0)
            {
                    return;
            }
            
                if( == 490)
            {
                    return;
            }
            
                return;
            }
            
            if( != 0)
            {
                    return;
            }
        
        }
        public void AddEventToClip(string 七不丐下丟专业万丅, float 丛下丈下丙七三丒一, string 下上丈丌万东丂丙与, string 丆且丁丒丒丆丁三丆)
        {
            var val_11;
            object val_12;
            val_11 = this;
            AnimationHandler.丗丛丘丑丐不丌丑丙 val_1 = null;
            val_12 = val_1;
            val_1 = new AnimationHandler.丗丛丘丑丐不丌丑丙();
            .七不丐下丟专业万丅 = 七不丐下丟专业万丅;
            int val_3 = this.丘丘专丘一与三丂丅.FindIndex(match:  new System.Predicate<UnityEngine.AnimationClip>(object:  val_1, method:  System.Boolean AnimationHandler.丗丛丘丑丐不丌丑丙::一丟丗且丐丞丅丟丑(UnityEngine.AnimationClip 三丟东丕丄丄下下丑)));
            if(val_3 == 1)
            {
                    return;
            }
            
            val_11 = this.丘丘专丘一与三丂丅.Item[val_3];
            var val_12 = 0;
            label_11:
            if(val_12 >= val_5.Length)
            {
                goto label_7;
            }
            
            val_12 = val_11.events[0].functionName;
            val_12 = val_12 + 1;
            if((val_12.Equals(value:  下上丈丌万东丂丙与)) == false)
            {
                goto label_11;
            }
            
            return;
            label_7:
            float val_9 = UnityEngine.Mathf.Clamp(value:  丛下丈下丙七三丒一, min:  0f, max:  val_11.length);
            UnityEngine.AnimationEvent val_10 = new UnityEngine.AnimationEvent();
            if(val_10 != null)
            {
                    val_10.time = val_9;
                val_10.functionName = 下上丈丌万东丂丙与;
            }
            else
            {
                    val_10.time = val_9;
                val_10.functionName = 下上丈丌万东丂丙与;
            }
            
            val_10.stringParameter = 丆且丁丒丒丆丁三丆;
            val_11.AddEvent(evt:  val_10);
        }
        private void Started(string animationName)
        {
            this.下与丂丝丒丘与七业(丌丁一下丙业丙丗不:  animationName, 丏业丟一东丂东丘丛:  0);
            if(this.丗丒丙丌丒三丞丑业 == null)
            {
                    return;
            }
            
            this.丗丒丙丌丒三丞丑业.Invoke(arg1:  animationName, arg2:  0);
        }
        private void Finished(string animationName)
        {
            this.下与丂丝丒丘与七业(丌丁一下丙业丙丗不:  animationName, 丏业丟一东丂东丘丛:  1);
            if(this.丗丒丙丌丒三丞丑业 == null)
            {
                    return;
            }
            
            this.丗丒丙丌丒三丞丑业.Invoke(arg1:  animationName, arg2:  1);
        }
        private void CustomCall(string animName_param)
        {
            char[] val_1 = new char[1];
            val_1[0] = '_';
            System.String[] val_2 = animName_param.Split(separator:  val_1);
            if(val_2.Length != 2)
            {
                    return;
            }
            
            System.Nullable<T> val_3 = 丞东丑专丛丆丄丝世.丅丅丝丟丒丛万丒丙<丂丌丞七丝上业丅万>(下业七不丑丂丏丟东:  val_2[1], 丏丅丗丌丌丞丌专丘:  new System.Nullable<T>() {HasValue = false}, 且丛专世丈且一丌下:  true);
            if((97551784 & 1) == 0)
            {
                    return;
            }
            
            string val_5 = val_2[0];
            this.下与丂丝丒丘与七业(丌丁一下丙业丙丗不:  val_5, 丏业丟一东丂东丘丛:  val_3.HasValue);
            this = this.丗丒丙丌丒三丞丑业;
            if(this == null)
            {
                    return;
            }
            
            this.Invoke(arg1:  val_5, arg2:  val_3.HasValue);
        }
        private void 下与丂丝丒丘与七业(string 丌丁一下丙业丙丗不, Rilisoft.AnimationHandler.丂丌丞七丝上业丅万 丏业丟一东丂东丘丛)
        {
            var val_8;
            var val_12;
            int val_13 = this.丈丅丈丈丂专丘丒丝.Count;
            val_12 = 0;
            goto label_4;
            label_25:
            if((this.丈丅丈丈丂专丘丒丝.Count - 1) < val_13)
            {
                goto label_4;
            }
            
            if(((System.String.op_Equality(a:  val_4.丄下世与专丅丅不丆, b:  丌丁一下丙业丙丗不)) == false) || (val_4.丞不上丛丒丆丟丘丘 != 丏业丟一东丂东丘丛))
            {
                goto label_12;
            }
            
            if(val_4.丒万业丛丏东专世丟 != null)
            {
                    val_4.丒万业丛丏东专世丟.Invoke();
            }
            
            if(val_4.丕东丆三丝一丟丂七 == false)
            {
                goto label_10;
            }
            
            label_13:
            this.世专东专下丑专丏万.Add(item:  this.丈丅丈丈丂专丘丒丝.Item[val_13]);
            goto label_12;
            label_10:
            if(val_4.丒万业丛丏东专世丟 == null)
            {
                goto label_13;
            }
            
            label_12:
            List.Enumerator<T> val_6 = this.世专东专下丑专丏万.GetEnumerator();
            label_17:
            if((97789664 & 1) == 0)
            {
                goto label_15;
            }
            
            bool val_10 = this.丈丅丈丈丂专丘丒丝.Remove(item:  val_8.丐丏七丌丕丗业且上());
            goto label_17;
            label_15:
            var val_12 = 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(val_12 != 1)
            {
                    var val_11 = 0;
                val_11 = val_11 ^ 0;
                val_12 = val_12 + val_11;
            }
            else
            {
                    if( != 0)
            {
                    val_12 = 0;
            }
            
            }
            
            this.世专东专下丑专丏万.Clear();
            label_4:
            val_13 = val_13 - 1;
            if((val_13 & 2147483648) == 0)
            {
                goto label_25;
            }
        
        }
        public AnimationHandler()
        {
            this.丈丅丈丈丂专丘丒丝 = new System.Collections.Generic.List<丝丅上不丄业丁丂丟>();
            this.世专东专下丑专丏万 = new System.Collections.Generic.List<丝丅上不丄业丁丂丟>();
            this.丘丘专丘一与三丂丅 = new System.Collections.Generic.List<UnityEngine.AnimationClip>();
        }
    
    }

}
