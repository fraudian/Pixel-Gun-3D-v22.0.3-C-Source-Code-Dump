using UnityEngine;

namespace NJG
{
    public abstract class UIMiniMapBase : UIMapBase
    {
        // Fields
        private static NJG.UIMiniMapBase 丄丈丂丅上专万丞丏;
        public static NJG.UIMiniMapBase inst;
        public UnityEngine.Vector3 targetAngle;
        public UnityEngine.KeyCode lockKey;
        public UnityEngine.GameObject northIcon;
        public UnityEngine.KeyCode mapKey;
        public int overlayBorderOffset;
        private bool 丒丘不丈万丁业丄丟;
        private UnityEngine.GameObject 丌不丅丗丟丌丒丐东;
        protected UnityEngine.Vector2 专丙东一且丞且三七;
        protected UnityEngine.Transform 丁丘专丄且不丒世丏;
        protected System.Collections.Generic.List<NJGMapItem> 与且且丘丄万七丟丛;
        protected System.Collections.Generic.List<NJGMapItem> 丛丛丑不上下丈不丌;
        protected System.Collections.Generic.List<NJG.UIMapArrow> 且业不丁丗上丙丈业;
        protected System.Collections.Generic.List<NJG.UIMapArrow> 丏丂专丗世丌东且丂;
        private NJGMapItem 丗丕业东世丗上丆三;
        protected int 丑万丑丐丐万专与世;
        private NJG.UIMapBase.七丐与七丌不丂丞且 丂业丕丘且丕丈丗专;
        private UnityEngine.Vector2 丛丈丝丅东丕世丄丐;
        public static System.Action<UnityEngine.Vector3> onMapClick;
        protected UnityEngine.Vector3 上丆丁丐丈丞丈丈丗;
        protected UnityEngine.Vector3 三丐丗不丆上丙业下;
        protected UnityEngine.Vector3 不丙丗丅丟下且七丅;
        protected UnityEngine.Vector3 七七七丆丆丌丈丐丈;
        private float 下丁业丅且丒不丅三;
        private UnityEngine.Vector3 丞丘三丙世万三三丞;
        private float 丆东丑上丟丅丐丟丑;
        private UnityEngine.Vector2 与专七丑丁上丛东丟;
        private float 丗丞丙丞丄七丒丈丒;
        private float 丂专且丆丝万业丞东;
        private float 丞与丆丂丅丛丛丐丘;
        
        // Properties
        public static bool 丝与丆丞东丘丈东丘 { get; }
        public UnityEngine.Transform 万东丂丙丛丅丏不丕 { get; }
        protected override UnityEngine.Vector3 丛丗下丆专丛丆丏三 { get; }
        
        // Methods
        public static bool get_initialized()
        {
            return UnityEngine.Object.op_Inequality(x:  NJG.UIMiniMapBase.丄丈丂丅上专万丞丏, y:  0);
        }
        protected override void Awake()
        {
            this.Awake();
            NJG.UIMiniMapBase.inst = this;
        }
        protected override void OnDestroy()
        {
            this.OnDestroy();
            NJG.UIMiniMapBase.inst = 0;
        }
        public UnityEngine.Transform get_arrowRoot()
        {
            if(this.丁丘专丄且不丒世丏 != 0)
            {
                    return (UnityEngine.Transform)this.丁丘专丄且不丒世丏;
            }
            
            if(UnityEngine.Application.isPlaying == false)
            {
                    return (UnityEngine.Transform)this.丁丘专丄且不丒世丏;
            }
            
            UnityEngine.GameObject val_4 = 丁丒丐丂万三丌万业.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.gameObject);
            UnityEngine.Transform val_5 = val_4.transform;
            this.丁丘专丄且不丒世丏 = val_5;
            val_5.parent = val_4;
            this.丁丘专丄且不丒世丏.name = "_MapArrows";
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.丁丘专丄且不丒世丏.localEulerAngles = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            this.丁丘专丄且不丒世丏.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            this.丁丘专丄且不丒世丏.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            return (UnityEngine.Transform)this.丁丘专丄且不丒世丏;
        }
        protected override UnityEngine.Vector3 丟丏一一万丝下丟丑()
        {
            return UnityEngine.Vector3.forward;
        }
        protected override void 丁业三上丛丐且专东()
        {
            float val_13;
            float val_14;
            float val_15;
            UnityEngine.Object val_16;
            if(UnityEngine.Application.isPlaying != false)
            {
                    UnityEngine.GameObject val_4 = 丁丒丐丂万三丌万业.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.iconRoot.gameObject);
                this.丌不丅丗丟丌丒丐东 = val_4;
                val_4.name = "North";
                UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
                val_13 = val_6.x;
                val_14 = val_6.z;
                val_15 = val_13;
                this.丌不丅丗丟丌丒丐东.transform.localPosition = new UnityEngine.Vector3() {x = val_15, y = val_6.y, z = val_14};
                val_16 = 0;
                if(this.northIcon != val_16)
            {
                    UnityEngine.Transform val_8 = this.northIcon.transform;
                val_8.parent = this.丌不丅丗丟丌丒丐东.transform;
                UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.identity;
                val_13 = val_10.x;
                val_14 = val_10.z;
                val_15 = val_13;
                val_16 = 0;
                val_8.localRotation = new UnityEngine.Quaternion() {x = val_15, y = val_10.y, z = val_14, w = val_10.w};
            }
            
                UnityEngine.Vector3 val_12 = this.rendererTransform.localScale;
                val_12.x = val_12.x * 0.5f;
                val_12.x = val_12.x * 0.25f;
                mem[1152921541475882992] = val_12.x;
            }
        
        }
        public virtual void UpdateAlignment()
        {
            float val_41;
            float val_42;
            var val_43;
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_41 = val_1.x;
            val_42 = val_1.y;
            val_43 = 0;
            UnityEngine.Vector3 val_3 = this.rendererTransform.localPosition;
            if(null <= 7)
            {
                    var val_36 = mem[4611686021600273192];
                val_36 = val_36 + 106013480;
            }
            else
            {
                    this.rendererTransform.localPosition = new UnityEngine.Vector3() {z = val_3.z};
            }
        
        }
        protected override UnityEngine.Transform 丕丏一七专三丘丁丒()
        {
            UnityEngine.Transform val_3 = 丁丒丐丂万三丌万业.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.gameObject).transform;
            if(X21 != 0)
            {
                    val_3.parent = this;
                val_3.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            }
            
            val_3.name = "_MapIcons";
            return val_3;
        }
        protected override void 且丈业丕一且丝下上(NJG.UIMapIconBase 丞丐丗丄下世丆丂丗)
        {
            this.且丈业丕一且丝下上(丞丐丗丄下世丆丂丗:  丞丐丗丄下世丆丂丗);
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  null);
            丞丐丗丄下世丆丂丗.cachedTransform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        }
        protected void 一丅下丒丘丝不丑且(NJG.UIMapIconBase 丞丐丗丄下世丆丂丗, NJGMapItem 下丅丙一丂丗丅丝七, UnityEngine.Vector3 与与不丛丙一丄业专)
        {
            var val_23;
            float val_24;
            UnityEngine.Object val_25;
            var val_29;
            val_23 = 与与不丛丙一丄业专.z;
            val_24 = 与与不丛丙一丄业专.x;
            val_25 = this;
            UnityEngine.Transform val_1 = 丞丐丗丄下世丆丂丗.cachedTransform;
            if(下丅丙一丂丗丅丝七 == 0)
            {
                    return;
            }
            
            if(丞丐丗丄下世丆丂丗 == 0)
            {
                    return;
            }
            
            if(下丅丙一丂丗丅丝七.rotate == true)
            {
                goto label_10;
            }
            
            UnityEngine.Vector3 val_5 = val_1.localEulerAngles;
            if(((-1785106848) & 1) != 0)
            {
                    return;
            }
            
            if(val_1 != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_10:
            if(下丅丙一丂丗丅丝七.rotate == false)
            {
                    return;
            }
            
            val_25 = 下丅丙一丂丗丅丝七.cachedTransform;
            if((UnityEngine.Object.op_Implicit(exists:  val_25)) == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_10 = 下丅丙一丂丗丅丝七.cachedTransform.forward;
            val_25 = 1152921504838316032;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_12 = UnityEngine.Vector3.forward;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.Cross(lhs:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, rhs:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
            UnityEngine.Vector3 val_17 = 下丅丙一丂丗丅丝七.cachedTransform.forward;
            val_24 = val_17.z;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.forward;
            val_23 = (((UnityEngine.Vector3.Dot(lhs:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, rhs:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z})) > 0f) ? -1f : 1f) * (UnityEngine.Vector3.Angle(from:  new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_24}, to:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}));
            if(val_1 != null)
            {
                    UnityEngine.Vector3 val_20 = val_1.localEulerAngles;
                val_29 = val_20.x;
            }
            else
            {
                    UnityEngine.Vector3 val_21 = 0.localEulerAngles;
                val_29 = val_21.x;
            }
            
            UnityEngine.Vector3 val_22 = val_1.localEulerAngles;
            label_14:
            val_1.localEulerAngles = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        protected override void 丂丟丘丐丕丝丙一丌(UnityEngine.Vector2 丟专丅丏专丒丐丘七)
        {
            float val_27;
            float val_28;
            float val_32;
            float val_33;
            var val_34;
            var val_35;
            var val_36;
            UnityEngine.Vector2 val_1 = UnityEngine.Vector2.zero;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
            val_27 = val_2.x;
            val_28 = val_2.y;
            if(( & 1) == 0)
            {
                    float val_27 = 丟专丅丏专丒丐丘七.x;
                var val_3 = X21 + 156;
                val_27 = val_27 * val_2.x;
                var val_4 = X21 + 156;
                val_27 = S11 * val_27;
                val_28 = val_2.x * (丟专丅丏专丒丐丘七.y * val_2.z);
            }
            
            UnityEngine.Transform val_6 = this.iconRoot;
            UnityEngine.Vector3 val_7 = val_6.localEulerAngles;
            val_32 = 0f;
            int val_8 = val_6.Count;
            if(val_8 >= 1)
            {
                    int val_9 = val_8 + 1;
                do
            {
                NJG.UIMapIconBase val_11 = val_6.Item[val_9 - 2];
                if(val_11.isValid != false)
            {
                    if(( & 1) == 0)
            {
                    UnityEngine.Transform val_12 = val_11.cachedTransform;
                UnityEngine.Vector3 val_13 = val_12.localPosition;
                UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = val_27, y = val_28, z = val_2.z});
                val_33 = val_14.y;
                val_32 = val_33;
                val_12.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_32, z = val_14.z};
            }
            
                this.一丅下丒丘丝不丑且(丞丐丗丄下世丆丂丗:  val_11, 下丅丙一丂丗丅丝七:  val_11.item, 与与不丛丙一丄业专:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            }
            
                val_9 = val_9 - 1;
            }
            while(val_9 > 1);
            
            }
            
            float val_15 = val_2.z * (-0.01745329f);
            val_15 = val_15 * (-0.01745329f);
            val_34 = 0;
            goto label_22;
            label_42:
            val_35 = null;
            val_35 = null;
            NJGMapItem val_16 = NJGMapItem.list.Item[0];
            if((val_16.haveArrow != false) && ((val_16.arrow != 0) && (val_16.arrow.isValid != false)))
            {
                    if((丁丒丐丂万三丌万业.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  val_16.arrow.gameObject)) != true)
            {
                    丁丒丐丂万三丌万业.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  val_16.arrow.gameObject, 丏业丟一东丂东丘丛:  true);
            }
            
                UnityEngine.Vector3 val_23 = val_16.cachedTransform.position;
                UnityEngine.Vector2 val_24 = this.WorldToMap(丈七东丐世丒丅丗丌:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z});
                val_28 = val_24.x;
                UnityEngine.Vector2 val_25 = this.mapHalfScale;
                val_33 = val_25.x;
                val_16.arrow.UpdatePosition(丐丝丐丂且东且一丏:  new UnityEngine.Vector2() {x = val_28, y = val_24.y}, 且丅丘丑丆丞丘不丄:  new UnityEngine.Vector2() {x = val_33, y = val_25.y}, 丅下上东丅七下一丟:  val_15, 东下丗丒丟丐业业丈:  val_15);
            }
            
            val_34 = 1;
            label_22:
            val_36 = null;
            val_36 = null;
            if(val_34 < NJGMapItem.list.Count)
            {
                goto label_42;
            }
        
        }
        protected override void 上丘且丙东下不丂万()
        {
            var val_7;
            var val_8;
            var val_9;
            int val_1 = Count;
            if(val_1 >= 1)
            {
                    int val_2 = val_1 + 1;
                do
            {
                NJG.UIMapIconBase val_4 = Item[val_2 - 2];
                val_2 = val_2 - 1;
                val_4.isValid = false;
            }
            while(val_2 > 1);
            
            }
            
            this.七专上丑世丟七丑丁();
            val_7 = 0;
            goto label_6;
            label_15:
            val_8 = null;
            val_8 = null;
            NJGMapItem val_5 = NJGMapItem.list.Item[0];
            val_7 = 1;
            label_6:
            val_9 = null;
            val_9 = null;
            if(val_7 < NJGMapItem.list.Count)
            {
                goto label_15;
            }
        
        }
        private bool 丈丘丄且丏丕业丙与(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, UnityEngine.Vector3 丆丛丑世下一丐且丕, UnityEngine.Vector3 丌丗丏丏丛东专丁且, UnityEngine.Vector3 丁丂专业丁丅丅丈丙)
        {
            float val_15 = 丌丗丏丏丛东专丁且.z;
            float val_16 = 丌丗丏丏丛东专丁且.y;
            float val_14 = 丌丗丏丏丛东专丁且.x;
            val_14 = val_15 - val_14;
            业丒丝丗与丐丛丟丏.x = val_15 - 业丒丝丗与丐丛丟丏.x;
            val_15 = 丆丛丑世下一丐且丕.x - val_15;
            float val_6 = 丁丂专业丁丅丅丈丙.x - val_16;
            val_16 = val_16 - 业丒丝丗与丐丛丟丏.z;
            丆丛丑世下一丐且丕.z = 丆丛丑世下一丐且丕.z - 丁丂专业丁丅丅丈丙.x;
            业丒丝丗与丐丛丟丏.z = 丁丂专业丁丅丅丈丙.x - 业丒丝丗与丐丛丟丏.z;
            业丒丝丗与丐丛丟丏.x = 业丒丝丗与丐丛丟丏.x * 丆丛丑世下一丐且丕.z;
            val_15 = val_15 * 业丒丝丗与丐丛丟丏.z;
            val_6 = (val_14 - 业丒丝丗与丐丛丟丏.x) * val_6;
            val_16 = val_16 * val_14;
            业丒丝丗与丐丛丟丏.x = 业丒丝丗与丐丛丟丏.x - val_15;
            float val_9 = ((丆丛丑世下一丐且丕.x - 业丒丝丗与丐丛丟丏.x) * (val_16 - 丆丛丑世下一丐且丕.z)) - ((丆丛丑世下一丐且丕.z - 业丒丝丗与丐丛丟丏.z) * (val_14 - 丆丛丑世下一丐且丕.x));
            float val_10 = val_6 - val_16;
            if(((业丒丝丗与丐丛丟丏.x >= 0f) && (val_9 >= 0f)) && (val_10 >= 0f))
            {
                    return true;
            }
            
            if(val_9 <= 0f)
            {
                    return (bool)((val_10 <= 0f) ? 1 : 0) & ((业丒丝丗与丐丛丟丏.x <= 0f) ? 1 : 0);
            }
            
            return false;
        }
        protected void 七专上丑世丟七丑丁()
        {
            float val_11;
            float val_12;
            float val_13;
            float val_1 = S0 * 0.01745329f;
            val_11 = val_1;
            UnityEngine.Vector2 val_2 = this.mapHalfScale;
            val_12 = val_2.x;
            UnityEngine.Vector2 val_3 = this.mapHalfScale;
            val_13 = -val_12;
            UnityEngine.Vector3 val_4 = this.丝丁丆丞丟且丄一丛(三丟东丕丄丄下下丑:  val_13, 丒丒丄丁且丄丆丂丌:  -val_3.y, 东下丗丒丟丐业业丈:  val_11, 丑七丝丄丝七丁丅七:  val_1);
            this.不丙丗丅丟下且七丅 = val_4;
            mem[1152921541477054340] = val_4.y;
            mem[1152921541477054344] = val_4.z;
            UnityEngine.Vector3 val_5 = this.丝丁丆丞丟且丄一丛(三丟东丕丄丄下下丑:  val_12, 丒丒丄丁且丄丆丂丌:  val_3.y, 东下丗丒丟丐业业丈:  val_11, 丑七丝丄丝七丁丅七:  val_1);
            this.三丐丗不丆上丙业下 = val_5;
            mem[1152921541477054328] = val_5.y;
            mem[1152921541477054332] = val_5.z;
            UnityEngine.Vector3 val_6 = this.丝丁丆丞丟且丄一丛(三丟东丕丄丄下下丑:  val_12, 丒丒丄丁且丄丆丂丌:  -val_3.y, 东下丗丒丟丐业业丈:  val_11, 丑七丝丄丝七丁丅七:  val_1);
            this.七七七丆丆丌丈丐丈 = val_6;
            mem[1152921541477054352] = val_6.y;
            mem[1152921541477054356] = val_6.z;
            UnityEngine.Vector3 val_7 = this.丝丁丆丞丟且丄一丛(三丟东丕丄丄下下丑:  val_13, 丒丒丄丁且丄丆丂丌:  val_3.y, 东下丗丒丟丐业业丈:  val_11, 丑七丝丄丝七丁丅七:  val_1);
            this.上丆丁丐丈丞丈丈丗 = val_7;
            mem[1152921541477054316] = val_7.y;
            mem[1152921541477054320] = val_7.z;
            if(static_value_082C0000 == 0)
            {
                    return;
            }
            
            val_11 = this.上丆丁丐丈丞丈丈丗;
            UnityEngine.Vector3 val_9 = position;
            val_13 = val_9.y;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_11, y = val_1, z = val_12}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_13, z = val_9.z});
            this.下丁业丅且丒不丅三 = val_10.x;
        }
        private UnityEngine.Vector3 丝丁丆丞丟且丄一丛(float 三丟东丕丄丄下下丑, float 丒丒丄丁且丄丆丂丌, float 东下丗丒丟丐业业丈, float 丑七丝丄丝七丁丅七)
        {
            丒丒丄丁且丄丆丂丌 = 丒丒丄丁且丄丆丂丌 * 东下丗丒丟丐业业丈;
            三丟东丕丄丄下下丑 = (三丟东丕丄丄下下丑 * 东下丗丒丟丐业业丈) - (丒丒丄丁且丄丆丂丌 * 丑七丝丄丝七丁丅七);
            丒丒丄丁且丄丆丂丌 = 丒丒丄丁且丄丆丂丌 + (三丟东丕丄丄下下丑 * 丑七丝丄丝七丁丅七);
            UnityEngine.Vector2 val_4 = new UnityEngine.Vector2(x:  三丟东丕丄丄下下丑, y:  丒丒丄丁且丄丆丂丌);
            UnityEngine.Vector3 val_5 = this.MapToWorld(下业丕七东丌丝下且:  new UnityEngine.Vector2() {x = val_4.x, y = val_4.y});
            return new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        protected bool 七七业丒丟丝丘不丞(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
        {
            var val_5;
            if(static_value_082C0000 == 0)
            {
                    val_5 = 0;
                return (bool)(val_3.x < 0) ? 1 : 0;
            }
            
            UnityEngine.Vector3 val_2 = position;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
            return (bool)(val_3.x < 0) ? 1 : 0;
        }
        public bool IsExactVisible(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
        {
            float val_6;
            var val_7;
            if(static_value_082C0000 == 0)
            {
                goto label_7;
            }
            
            UnityEngine.Vector3 val_2 = position;
            val_6 = val_2.y;
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_6, z = val_2.z});
            if(val_3.x >= 0)
            {
                goto label_7;
            }
            
            bool val_4 = val_3.x.丈丘丄且丏丕业丙与(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 丆丛丑世下一丐且丕:  new UnityEngine.Vector3() {x = this.上丆丁丐丈丞丈丈丗, y = val_6, z = val_2.z}, 丌丗丏丏丛东专丁且:  new UnityEngine.Vector3() {x = this.三丐丗不丆上丙业下, y = val_2.z, z = this.不丙丗丅丟下且七丅}, 丁丂专业丁丅丅丈丙:  new UnityEngine.Vector3() {x = val_2.x, y = val_3.x, z = val_3.z});
            if(val_4 == false)
            {
                goto label_8;
            }
            
            val_7 = 1;
            goto label_10;
            label_7:
            val_7 = 0;
            label_10:
            val_7 = val_7 & 1;
            return (bool)val_7;
            label_8:
            bool val_5 = val_4.丈丘丄且丏丕业丙与(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 丆丛丑世下一丐且丕:  new UnityEngine.Vector3() {x = this.三丐丗不丆上丙业下, y = val_6, z = val_2.z}, 丌丗丏丏丛东专丁且:  new UnityEngine.Vector3() {x = this.七七七丆丆丌丈丐丈.x, y = 业丒丝丗与丐丛丟丏.x, z = this.不丙丗丅丟下且七丅}, 丁丂专业丁丅丅丈丙:  new UnityEngine.Vector3() {x = val_2.x, y = val_3.x, z = val_3.z});
            goto label_10;
        }
        protected override void 世丐丕三丞一丂三且(NJGMapItem 下丅丙一丂丗丅丝七)
        {
            var val_18;
            NJG.UIMapArrow val_19;
            NJG.UIMapArrow val_20;
            if(下丅丙一丂丗丅丝七.isUnsafeSphereIcon != true)
            {
                    if(下丅丙一丂丗丅丝七.isSafeSphereIcon == false)
            {
                goto label_3;
            }
            
            }
            
            val_18 = 1;
            label_42:
            if(下丅丙一丂丗丅丝七.isSafeSphereIcon != false)
            {
                    if(下丅丙一丂丗丅丝七.isSafeSphereIcon == true)
            {
                goto label_26;
            }
            
            }
            
            if(下丅丙一丂丗丅丝七.haveArrow == false)
            {
                goto label_26;
            }
            
            val_19 = 1152921504848912384;
            if((val_18 & 1) == 0)
            {
                goto label_7;
            }
            
            if(下丅丙一丂丗丅丝七.arrow == 0)
            {
                goto label_26;
            }
            
            if((丁丒丐丂万三丌万业.世三丅不丄丂丒丕上(丝三丁东丈丒世丅业:  下丅丙一丂丗丅丝七.arrow.gameObject)) != false)
            {
                    丁丒丐丂万三丌万业.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  下丅丙一丂丗丅丝七.arrow.gameObject, 丏业丟一东丂东丘丛:  false);
            }
            
            下丅丙一丂丗丅丝七.arrow.isValid = false;
            goto label_26;
            label_3:
            if(下丅丙一丂丗丅丝七.dontShowIcon == true)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_8 = 下丅丙一丂丗丅丝七.cachedTransform.position;
            if(下丅丙一丂丗丅丝七.haveArrow == false)
            {
                goto label_18;
            }
            
            bool val_9 = this.IsExactVisible(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            goto label_42;
            label_7:
            if(下丅丙一丂丗丅丝七.arrow == 0)
            {
                    val_20 = this;
                下丅丙一丂丗丅丝七.arrow = val_20;
            }
            else
            {
                    val_20 = 下丅丙一丂丗丅丝七.arrow;
            }
            
            if(val_20 != 0)
            {
                    下丅丙一丂丗丅丝七.arrow.isValid = true;
            }
            
            label_26:
            if(下丅丙一丂丗丅丝七.haveArrow != true)
            {
                    val_19 = 1152921504848912384;
                if(下丅丙一丂丗丅丝七.arrow != 0)
            {
                    if(NJG.UIMiniMapBase.inst != 0)
            {
                    val_19 = 下丅丙一丂丗丅丝七.arrow;
            }
            
            }
            
            }
            
            if((val_18 & 1) == 0)
            {
                    return;
            }
            
            if((this.GetEntry(业业丙且东丒业世丟:  下丅丙一丂丗丅丝七)) == 0)
            {
                    return;
            }
            
            if(val_15.isValid == true)
            {
                    return;
            }
            
            val_15.isValid = true;
            val_15.isMapIcon = false;
            return;
            label_18:
            bool val_17 = this.七七业丒丟丝丘不丞(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
            goto label_42;
        }
        protected virtual NJG.UIMapArrow 不业不不三丛不丂万(UnityEngine.Object 丄三丅七丆丛与与上)
        {
            UnityEngine.Object val_3 = 丄三丅七丆丛与与上;
            if(val_3 == null)
            {
                    return (NJG.UIMapArrow)val_3;
            }
            
            val_3 = 0;
            return (NJG.UIMapArrow)val_3;
        }
        protected override void Update()
        {
            var val_36;
            float val_37;
            int val_38;
            float val_39;
            UnityEngine.Vector2 val_40;
            var val_41;
            float val_42;
            float val_43;
            float val_44;
            float val_48;
            float val_49;
            var val_50;
            if(this.丂业丕丘且丕丈丗专 != W9)
            {
                goto label_1;
            }
            
            val_36 = this;
            val_38 = 1152921541477881076;
            val_40 = 1152921541477881952;
            val_41 = 1152921541477881956;
            val_42 = this.丛丈丝丅东丕世丄丐;
            val_43 = V10.16B;
            val_44 = V8.16B;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_42, y = val_43}, rhs:  new UnityEngine.Vector2() {x = val_44, y = V9.16B})) == true)
            {
                goto label_7;
            }
            
            UnityEngine.Vector2 val_2 = this.mapScale;
            val_39 = val_2.x;
            val_42 = V9.16B;
            val_43 = V8.16B;
            val_44 = val_39;
            if((UnityEngine.Vector2.op_Inequality(lhs:  new UnityEngine.Vector2() {x = val_42, y = val_43}, rhs:  new UnityEngine.Vector2() {x = val_44, y = val_2.y})) == true)
            {
                goto label_7;
            }
            
            goto label_8;
            label_1:
            val_36 = 1152921541477881076;
            val_38 = 1152921541477881080;
            val_40 = this.丛丈丝丅东丕世丄丐;
            val_41 = 1152921541477881956;
            label_7:
            UnityEngine.Vector2 val_4 = this.mapScale;
            mem[1152921541477881304] = val_4.x;
            mem[1152921541477881308] = val_4.y;
            this.丂业丕丘且丕丈丗专 = null;
            mem2[0] = null;
            mem[1152921541477881956] = null;
            label_8:
            if(this.arrowRoot == 0)
            {
                goto label_25;
            }
            
            if((null == 0) || (null == 0))
            {
                goto label_20;
            }
            
            UnityEngine.Vector3 val_8 = this.arrowRoot.localScale;
            val_37 = 0.001f;
            val_39 = val_8.y;
            val_42 = val_8.x;
            val_43 = val_39;
            val_44 = val_8.z;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_42, y = val_43, z = val_44}, rhs:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f})) == false)
            {
                goto label_17;
            }
            
            UnityEngine.Transform val_10 = this.arrowRoot;
            val_43 = 0f;
            val_44 = 0f;
            goto label_19;
            label_17:
            label_20:
            UnityEngine.Vector3 val_12 = this.arrowRoot.localScale;
            val_37 = val_12.x;
            val_39 = val_12.z;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
            val_43 = val_12.y;
            val_44 = val_39;
            if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_37, y = val_43, z = val_44}, rhs:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z})) == false)
            {
                goto label_25;
            }
            
            UnityEngine.Transform val_15 = this.arrowRoot;
            UnityEngine.Vector3 val_16 = UnityEngine.Vector3.one;
            val_37 = val_16.x;
            val_39 = val_16.z;
            val_43 = val_16.y;
            val_44 = val_39;
            label_19:
            val_15.localScale = new UnityEngine.Vector3() {x = val_37, y = val_43, z = val_44};
            label_25:
            if((val_15 != 0) && (val_37 > 0f))
            {
                    val_48 = this.丗丞丙丞丄七丒丈丒;
                val_49 = this.丂专且丆丝万业丞东;
                if(val_48 > val_49)
            {
                    UnityEngine.Vector3 val_18 = val_15.position;
                UnityEngine.Vector3 val_19 = val_15.position;
                float val_20 = val_18.x - this.丞丘三丙世万三三丞;
                val_19.y = val_19.z - val_19.y;
                UnityEngine.Vector2 val_21 = new UnityEngine.Vector2(x:  val_20, y:  val_19.y);
                val_20 = this.丞丘三丙世万三三丞 * val_20;
                val_20 = val_20 + 1f;
                val_49 = 1f / val_20;
                this.丞与丆丂丅丛丛丐丘 = UnityEngine.Mathf.Clamp(value:  val_49, min:  0.6f, max:  1f);
                UnityEngine.Vector3 val_23 = val_15.position;
                this.丞丘三丙世万三三丞 = val_23;
                mem[1152921541477882016] = val_23.y;
                mem[1152921541477882020] = val_23.z;
                val_48 = this.丗丞丙丞丄七丒丈丒 - this.丂专且丆丝万业丞东;
                this.丗丞丙丞丄七丒丈丒 = val_48;
            }
            
                float val_24 = UnityEngine.Time.deltaTime;
                val_24 = val_48 + val_24;
                this.丗丞丙丞丄七丒丈丒 = val_24;
                val_39 = UnityEngine.Time.deltaTime;
                val_44 = val_39;
                float val_26 = UnityEngine.Mathf.Lerp(a:  val_20, b:  this.丞与丆丂丅丛丛丐丘, t:  val_44);
                mem[1152921541477881092] = val_26;
                val_50 = val_26 * this.丞与丆丂丅丛丛丐丘;
            }
            else
            {
                    mem[1152921541477881092] = 1065353216;
            }
            
            mem[1152921541477881096] = val_37;
            this.Update();
            int val_27 = val_15.Count;
            if(val_27 < 1)
            {
                    return;
            }
            
            int val_28 = val_27 + 1;
            do
            {
                val_38 = val_28 - 2;
                if(val_29.isValid != false)
            {
                    if(val_29.item.transform == val_29.item)
            {
                    UnityEngine.Vector3 val_33 = UnityEngine.Vector3.zero;
                val_37 = val_33.x;
                val_39 = val_33.z;
                val_15.Item[val_38].cachedTransform.localPosition = new UnityEngine.Vector3() {x = val_37, y = val_33.y, z = val_39};
            }
            
            }
            
                val_28 = val_28 - 1;
            }
            while(val_28 > 1);
        
        }
        public virtual void DeleteArrow(NJG.UIMapArrow 丕丏丑丁东丄丂与东)
        {
            if(丕丏丑丁东丄丂与东 == 0)
            {
                    return;
            }
            
            bool val_2 = this.且业不丁丗上丙丈业.Remove(item:  丕丏丑丁东丄丂与东);
            this.丏丂专丗世丌东且丂.Add(item:  丕丏丑丁东丄丂与东);
            丁丒丐丂万三丌万业.不上丕不丞业一丗丂(丝三丁东丈丒世丅业:  丕丏丑丁东丄丂与东.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        public void ToggleWorldMap()
        {
            var val_4;
            if(NJG.UIWorldMapBase.inst == 0)
            {
                    return;
            }
            
            val_4 = public System.Void NJG.UIMapBase::Hide();
            NJG.UIWorldMapBase.inst.Show();
        }
        protected UIMiniMapBase()
        {
            this.lockKey = 108;
            this.mapKey = 109;
            this.与且且丘丄万七丟丛 = new System.Collections.Generic.List<NJGMapItem>();
            this.丛丛丑不上下丈不丌 = new System.Collections.Generic.List<NJGMapItem>();
            this.且业不丁丗上丙丈业 = new System.Collections.Generic.List<NJG.UIMapArrow>();
            this.丏丂专丗世丌东且丂 = new System.Collections.Generic.List<NJG.UIMapArrow>();
            this.丂专且丆丝万业丞东 = 0.2f;
        }
    
    }

}
