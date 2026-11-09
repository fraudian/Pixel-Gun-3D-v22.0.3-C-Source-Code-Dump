using UnityEngine;

namespace NJG
{
    public class UIMapIconBase : MonoBehaviour
    {
        // Fields
        private static System.Collections.Generic.List<NJG.UIMapIconBase> 丛丗七丅下丞丗且丐;
        public NJGMapItem item;
        public bool isValid;
        public bool isMapIcon;
        public bool isVisible;
        public UnityEngine.Object collider;
        private UnityEngine.Transform 丐一丗丛丕世丘东丁;
        protected bool 东东且丕丙万丕下丄;
        protected bool 世一东世丈丑丆丐专;
        protected UnityEngine.Vector3 世三世丁业丑不上丈;
        private float 一丌丌丙世万丄专丅;
        protected bool 业丌丂丙丕下丏丈下;
        protected bool 东一且三丑丑丏丗七;
        
        // Properties
        public UnityEngine.Transform 丛丄与丌丛万业丝丞 { get; }
        public float 与专丌丅丙上丌一丄 { get; set; }
        
        // Methods
        public UnityEngine.Transform get_cachedTransform()
        {
            UnityEngine.Transform val_3;
            if(this.丐一丗丛丕世丘东丁 == 0)
            {
                    this.丐一丗丛丕世丘东丁 = this.transform;
                return val_3;
            }
            
            val_3 = this.丐一丗丛丕世丘东丁;
            return val_3;
        }
        public float get_alpha()
        {
            return (float)this.一丌丌丙世万丄专丅;
        }
        public void set_alpha(float 丙业与丙丗丝不丈东)
        {
            this.一丌丌丙世万丄专丅 = 丙业与丙丗丝不丈东;
        }
        protected virtual void Start()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            this.业丒丒七且丅丝下丈();
        }
        protected virtual void Update()
        {
            if(((this.东一且三丑丑丏丗七 == true) ? 1 : 0) != ((this.item.东一且三丑丑丏丗七 == true) ? 1 : 0))
            {
                    this.东一且三丑丑丏丗七 = this.item.东一且三丑丑丏丗七;
                if(this.item.东一且三丑丑丏丗七 != false)
            {
                
            }
            
            }
            
            if(this.item.showIcon == false)
            {
                    return;
            }
            
            if(this.item.showOnAction == false)
            {
                    return;
            }
            
            this = this.item;
            this.item.showIcon = false;
        }
        public virtual void Select()
        {
            var val_3;
            var val_4;
            if(((UnityEngine.Input.GetKey(key:  48)) != true) && (this.item.丅世丘丌丄丕东丐丕 != true))
            {
                    this.业丆不东业丌丛丏世();
            }
            
            this.item.isSelected = true;
            val_3 = null;
            val_3 = null;
            if((NJG.UIMapIconBase.丛丗七丅下丞丗且丐.Contains(item:  this)) != false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            NJG.UIMapIconBase.丛丗七丅下丞丗且丐.Add(item:  this);
        }
        public virtual void UnSelect()
        {
        
        }
        protected void 业丆不东业丌丛丏世()
        {
            var val_3;
            var val_4;
            var val_5;
            var val_6;
            var val_7;
            val_3 = null;
            val_3 = null;
            int val_1 = NJG.UIMapIconBase.丛丗七丅下丞丗且丐.Count;
            val_4 = null;
            val_5 = (uint)(((uint)((NJG.UIMapIconBase.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
            if(val_1 >= 1)
            {
                    var val_3 = 0;
                do
            {
                val_6 = null;
                NJG.UIMapIconBase val_2 = NJG.UIMapIconBase.丛丗七丅下丞丗且丐.Item[0];
                val_7 = null;
                val_3 = val_3 + 1;
                val_5 = (uint)(((uint)((NJG.UIMapIconBase.__il2cppRuntimeField_127>>1) & 0x1)) >> 1) & 1;
            }
            while(val_1 != val_3);
            
            }
            
            val_7 = null;
            NJG.UIMapIconBase.丛丗七丅下丞丗且丐.Clear();
        }
        protected void 业丒丒七且丅丝下丈()
        {
            var val_18;
            UnityEngine.Object val_19;
            val_18 = this;
            this.一丌丌丙世万丄专丅 = 1f;
            val_19 = 0;
            if(this.item == val_19)
            {
                    return;
            }
            
            if(this.item.showOnAction != false)
            {
                    UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
                this.cachedTransform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
                return;
            }
            
            if(this.item.fadeOutAfterDelay > 0f)
            {
                    if(this.业丌丂丙丕下丏丈下 == true)
            {
                    return;
            }
            
                this.业丌丂丙丕下丏丈下 = true;
                UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.丂丑不丅丛丘上丕丂());
                return;
            }
            
            if(this.item.loopAnimation == false)
            {
                goto label_13;
            }
            
            label_19:
            val_18 = ???;
            goto typeof(NJG.UIMapIconBase).__il2cppRuntimeField_1C8;
            label_13:
            if((val_18 + 24.animateOnVisible) == false)
            {
                    return;
            }
            
            if((val_18 + 33) != 0)
            {
                    return;
            }
            
            if((val_18 + 24.fadeOutAfterDelay) != 0f)
            {
                    return;
            }
            
            goto label_19;
        }
        public virtual void OnEnable()
        {
            if(UnityEngine.Application.isPlaying == false)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
            this.cachedTransform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
            this.业丒丒七且丅丝下丈();
        }
        private void OnDisable()
        {
            if(this.业丌丂丙丕下丏丈下 != false)
            {
                    this.业丌丂丙丕下丏丈下 = false;
                this.StopAllCoroutines();
            }
            
            if(this.isVisible == false)
            {
                    return;
            }
            
            this.isVisible = false;
        }
        protected virtual void 丗丘专丁下丗一一丕()
        {
            if(this.isVisible == true)
            {
                    return;
            }
            
            if((this.item.fadeOutAfterDelay > 0f) && (this.业丌丂丙丕下丏丈下 != true))
            {
                    this.业丌丂丙丕下丏丈下 = true;
                UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丂丑不丅丛丘上丕丂());
            }
            
            if(this.item.loopAnimation != true)
            {
                    UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
                UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  0.01f);
                this.cachedTransform.localScale = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
                UnityEngine.Vector3 val_10 = UnityEngine.Vector3.one;
                丛丙丆丌七丘丘且世 val_12 = LeanTween.scale(下丐三丆丝与不丗丕:  this.cachedTransform.gameObject, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, 丂三丟丂丈丐丆丗丟:  1f).丞不丁丝丙上丗丈万(丙与丕丒丕丈上丗丂:  18);
            }
            
            this.isVisible = true;
        }
        protected virtual void 且丁丛丏业业万丄丁()
        {
            if(this.item.loopAnimation == false)
            {
                    return;
            }
            
            this.东东且丕丙万丕下丄 = true;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  1.5f);
            丛丙丆丌七丘丘且世 val_9 = LeanTween.scale(下丐三丆丝与不丗丕:  this.cachedTransform.gameObject, 专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, 丂三丟丂丈丐丆丗丟:  0.5f).丂丆丈一丒丌业丙专(上丒一丂丞丅丏丅丂:  37).下下丝丞丛万七丞丆(丈丗与丞一上且上上:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z});
        }
        protected System.Collections.IEnumerator 丂丑不丅丛丘上丕丂()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new UIMapIconBase.与丒丆丆丞丟专上丅();
        }
        protected virtual void 丒丈丅专七丞丑丏丌()
        {
            丛丙丆丌七丘丘且世 val_2 = LeanTween.alpha(下丐三丆丝与不丗丕:  this.gameObject, 专丂丕丗丗东世丞下:  0f, 丂三丟丂丈丐丆丗丟:  0.9f);
            this.业丌丂丙丕下丏丈下 = false;
        }
        public UIMapIconBase()
        {
            this.isMapIcon = true;
            this.世三世丁业丑不上丈 = 0;
            mem[1152921541474249684] = 0;
            this.一丌丌丙世万丄专丅 = 1f;
        }
        private static UIMapIconBase()
        {
            NJG.UIMapIconBase.丛丗七丅下丞丗且丐 = new System.Collections.Generic.List<NJG.UIMapIconBase>();
        }
    
    }

}
