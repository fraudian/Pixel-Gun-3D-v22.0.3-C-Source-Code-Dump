using UnityEngine;

namespace Rilisoft
{
    public class ReelController : MonoBehaviour
    {
        // Fields
        private UnityEngine.Vector4 丑丘三丈且丄丒一丗;
        private System.Action<UnityEngine.Transform, int> 丈丘丝丈业丂三丏丆;
        private int 丒丐丝业丗不丅万丕;
        private int 丏不三丒丙不丅丌丒;
        protected UIScrollView _scroll;
        private UnityEngine.Coroutine 万丘丂丗世三不丅丕;
        protected UnityEngine.AudioClip _spinClip;
        private UnityEngine.Coroutine 且丛丐与丞上丌不丒;
        private System.Func<UnityEngine.Transform, bool> 七丁世丕丕业丛七丆;
        private UnityEngine.AnimationCurve _stopCurve;
        private float _time;
        protected bool 专丅不丁丂丕业与三;
        protected UIWrapContent _wrap;
        private bool 丝世丘丁万业七丟丁;
        private float spinClipPlayDelay;
        private bool <丞丘丛丈丛世与业东>k__BackingField;
        private float <且丗三丆丑丝丗一万>k__BackingField;
        private System.Action<int> 丝丒丟丕上丞丈世专;
        
        // Properties
        public bool 专丗丄一上丌一丒丕 { get; set; }
        public float 七一丅丒上丐七不上 { get; set; }
        
        // Methods
        public bool get_ToCenterMoving()
        {
            return (bool)this.<丞丘丛丈丛世与业东>k__BackingField;
        }
        private void 丁业下下三丑丆万一(bool 丙业与丙丗丝不丈东)
        {
            this.<丞丘丛丈丛世与业东>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public float get_ScrollMoveTime()
        {
            return (float)this.<且丗三丆丑丝丗一万>k__BackingField;
        }
        private void 下与业丛丘丈三七丐(float 丙业与丙丗丝不丈东)
        {
            this.<且丗三丆丑丝丗一万>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public void Spin(int 丞东丆与下丁丆七与, int 丝丒丏丒万丂万万东, System.Action<UnityEngine.Transform, int> 丙东世业丟世丁丒丂, System.Func<UnityEngine.Transform, bool> 丛与丒不专且七且七)
        {
            this.丒丐丝业丗不丅万丕 = 丞东丆与下丁丆七与;
            this.丏不三丒丙不丅丌丒 = 丝丒丏丒万丂万万东;
            this.丈丘丝丈业丂三丏丆 = 丙东世业丟世丁丒丂;
            this.七丁世丕丕业丛七丆 = 丛与丒不专且七且七;
            if(this.且丛丐与丞上丌不丒 != null)
            {
                    this.StopCoroutine(routine:  this.且丛丐与丞上丌不丒);
            }
            
            this.且丛丐与丞上丌不丒 = this.StartCoroutine(routine:  this.丌丁丘丕专丞上丅且());
        }
        private System.Collections.IEnumerator 丌丁丘丕专丞上丅且()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new ReelController.上丛丗丂丄万丑丂丅();
        }
        private void 且丘丝丕专世丕丕丅(UnityEngine.Transform 丞下万上三丘上与专, bool 丐丐七专三且世三七)
        {
            UnityEngine.Object val_44;
            float val_46;
            var val_47;
            float val_48;
            float val_49;
            var val_50;
            float val_51;
            float val_52;
            float val_53;
            val_44 = 丞下万上三丘上与专;
            UIPanel val_1 = this._scroll.panel;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.5f);
            val_47 = 1152921504848912384;
            val_48 = val_3.x;
            val_49 = val_3.z;
            if(val_44 == 0)
            {
                    return;
            }
            
            if(this._scroll == 0)
            {
                    return;
            }
            
            if(this._scroll.panel == 0)
            {
                    return;
            }
            
            UnityEngine.Transform val_8 = this._scroll.transform;
            if(val_8 != null)
            {
                    UnityEngine.Vector3 val_9 = val_8.localPosition;
                val_50 = val_9.y;
            }
            else
            {
                    UnityEngine.Vector3 val_10 = 0.localPosition;
                val_50 = val_10.y;
            }
            
            UnityEngine.Vector3 val_11 = val_8.localPosition;
            val_8.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector2 val_14 = this._scroll.panel.clipOffset;
            UnityEngine.Vector2 val_15 = new UnityEngine.Vector2(x:  0f, y:  val_14.y);
            this._scroll.panel.clipOffset = new UnityEngine.Vector2() {x = val_15.x, y = val_15.y};
            val_47 = this._scroll.panel.cachedTransform;
            UnityEngine.Vector3 val_18 = val_44.position;
            UnityEngine.Vector3 val_19 = val_47.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z});
            val_46 = val_19.y;
            UnityEngine.Vector3 val_20 = val_47.InverseTransformPoint(position:  new UnityEngine.Vector3() {x = val_48, y = val_3.y, z = val_49});
            val_51 = val_19.x;
            val_52 = val_46;
            val_53 = val_19.z;
            UnityEngine.Vector3 val_21 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_51, y = val_52, z = val_53}, b:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
            val_44 = this._scroll;
            val_49 = 0f;
            float val_23 = (this._scroll.canMoveHorizontally != true) ? val_21.x : (val_49);
            float val_25 = (val_44.canMoveVertically != true) ? val_21.y : (val_49);
            if(丐丐七专三且世三七 != false)
            {
                    if(this.万丘丂丗世三不丅丕 != null)
            {
                    this.StopCoroutine(routine:  this.万丘丂丗世三不丅丕);
            }
            
                val_44 = this._wrap.transform;
                int val_29 = val_44.childCount;
                this.万丘丂丗世三不丅丕 = this._wrap.StartCoroutine(routine:  this.东丌东丑万丐不丑上(万且万且丑丗且丌丆:  this._scroll.panel.cachedGameObject, 三丙业丝丐上不丝丈:  new UnityEngine.Vector3() {x = val_23, y = val_25, z = 0f}, 业与三万七丝不万东:  val_20.x));
                return;
            }
            
            UnityEngine.Vector3 val_32 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_33 = val_8.localPosition;
            UnityEngine.Vector3 val_34 = val_47.localPosition;
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, b:  new UnityEngine.Vector3() {x = val_23, y = val_25, z = 0f});
            if(((-882977392) & 1) != 0)
            {
                    val_51 = 1f;
                val_52 = 0f;
                val_53 = 0f;
            }
            
            UnityEngine.Vector3 val_36 = val_47.localPosition;
            UnityEngine.Vector3 val_37 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_36.x, y = val_36.y, z = val_36.z}, b:  new UnityEngine.Vector3() {x = val_23, y = val_25, z = 0f});
            UnityEngine.Vector3 val_38 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_37.x, y = val_37.y, z = val_37.z}, b:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z});
            UnityEngine.Vector3 val_39 = val_47.localPosition;
            val_46 = val_39.y;
            val_47.localPosition = new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z};
            UnityEngine.Vector3 val_40 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_38.x, y = val_38.y, z = val_38.z}, b:  new UnityEngine.Vector3() {x = val_39.x, y = val_46, z = val_39.z});
            float val_44 = val_40.y;
            UnityEngine.Vector2 val_42 = this._scroll.panel.clipOffset;
            val_49 = val_42.x;
            val_48 = val_49 - val_40.x;
            val_44 = val_42.y - val_44;
            this._scroll.panel.clipOffset = new UnityEngine.Vector2() {x = val_48, y = val_44};
            this.<丞丘丛丈丛世与业东>k__BackingField = false;
        }
        public void add_OnFakeSpin(System.Action<int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Combine(a:  this.丝丒丟丕上丞丈世专, b:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丝丒丟丕上丞丈世专 != 1152921542378834712);
        
        }
        public void remove_OnFakeSpin(System.Action<int> 丙业与丙丗丝不丈东)
        {
            var val_3;
            do
            {
                val_3 = System.Delegate.Remove(source:  this.丝丒丟丕上丞丈世专, value:  丙业与丙丗丝不丈东);
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
            }
            while(this.丝丒丟丕上丞丈世专 != 1152921542378971288);
        
        }
        private System.Collections.IEnumerator 东丌东丑万丐不丑上(UnityEngine.GameObject 万且万且丑丗且丌丆, UnityEngine.Vector3 三丙业丝丐上不丝丈, float 业与三万七丝不万东)
        {
            ReelController.业不三丕丄丅丆丅上 val_1 = new ReelController.业不三丕丄丅丆丅上();
            .丗丏丅丕丆世丁专丟 = 0;
            if(val_1 != null)
            {
                    .丝且与丝丒丟万丁专 = this;
                .万且万且丑丗且丌丆 = 万且万且丑丗且丌丆;
            }
            else
            {
                    mem[32] = this;
                mem[40] = 万且万且丑丗且丌丆;
            }
            
            .三丙业丝丐上不丝丈 = 三丙业丝丐上不丝丈;
            mem[1152921542379139780] = 三丙业丝丐上不丝丈.y;
            mem[1152921542379139784] = 三丙业丝丐上不丝丈.z;
            return (System.Collections.IEnumerator)val_1;
        }
        private void 万丝丑七丟不业东东(int 丞东丆与下丁丆七与)
        {
            var val_20;
            double val_21;
            var val_22;
            float val_23;
            float val_24;
            UnityEngine.Vector4 val_25;
            UnityEngine.Vector4 val_27;
            double val_28;
            val_20 = this;
            UIPanel val_1 = this._scroll.GetComponent<UIPanel>();
            val_22 = (UnityEngine.Mathf.Clamp(value:  丞东丆与下丁丆七与 - 1, min:  1, max:  2147483647)) * this._wrap.itemSize;
            UnityEngine.Vector4 val_4 = UnityEngine.Vector4.zero;
            if((UnityEngine.Vector4.op_Equality(lhs:  new UnityEngine.Vector4() {x = this.丑丘三丈且丄丒一丗, y = V9.16B, z = V10.16B, w = V8.16B}, rhs:  new UnityEngine.Vector4() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w})) != false)
            {
                    UnityEngine.Vector4 val_6 = val_1.finalClipRegion;
                val_23 = val_6.z;
                this.丑丘三丈且丄丒一丗 = val_6;
                mem[1152921542379236140] = val_6.y;
                mem[1152921542379236144] = val_23;
                mem[1152921542379236148] = val_6.w;
            }
            
            val_24 = (float)val_22;
            if(S9 > val_24)
            {
                    UnityEngine.Vector4 val_7 = val_1.finalClipRegion;
                val_25 = this.丑丘三丈且丄丒一丗;
                if(val_1 != null)
            {
                goto label_13;
            }
            
            }
            else
            {
                    if(val_1.width >= 0)
            {
                    return;
            }
            
                UnityEngine.Vector4 val_9 = val_1.finalClipRegion;
                val_27 = this.丑丘三丈且丄丒一丗;
            }
            
            label_13:
            val_20 = ???;
            val_22 = ???;
            val_28 = ???;
            val_21 = ???;
            goto typeof(UIPanel).__il2cppRuntimeField_258;
        }
        public ReelController()
        {
            UnityEngine.Vector4 val_1 = UnityEngine.Vector4.zero;
            this._time = 2f;
            this.丝世丘丁万业七丟丁 = true;
            this.丑丘三丈且丄丒一丗 = val_1;
            mem[1152921542379360428] = val_1.y;
            mem[1152921542379360432] = val_1.z;
            mem[1152921542379360436] = val_1.w;
            this.spinClipPlayDelay = 0.15f;
        }
    
    }

}
