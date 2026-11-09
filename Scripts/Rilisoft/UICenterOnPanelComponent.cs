using UnityEngine;

namespace Rilisoft
{
    public class UICenterOnPanelComponent : MonoBehaviour
    {
        // Fields
        protected bool _centered;
        protected UIPanel _panel;
        public Rilisoft.丟世丆丕丌且七下丂 Direction;
        protected UnityEngine.Vector2 专丒丙与丙世一丑三;
        public UnityEngine.Events.UnityEvent OnCentered;
        public UnityEngine.Events.UnityEvent OnCenteredLoss;
        public float Slack;
        
        // Properties
        public bool 丙丐万下丈一丒丙丈 { get; }
        public UnityEngine.Vector3 丒丁与不一上丛专丒 { get; }
        public Rilisoft.七丂丄上与丅与业世 七丂丄上与丅与业世 { get; }
        
        // Methods
        public bool get_IsCentered()
        {
            return (bool)this._centered;
        }
        public UnityEngine.Vector3 get_Center()
        {
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = V8.16B, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = V13.16B, y = V11.16B, z = V12.16B});
            return UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  0.5f);
        }
        public Rilisoft.七丂丄上与丅与业世 get_CenterDirection()
        {
            UnityEngine.Vector3 val_1 = this.Center;
            UnityEngine.Vector3 val_3 = this.transform.position;
            val_3.x = val_1.x - val_3.x;
            return (Rilisoft.七丂丄上与丅与业世)(val_3.x <= 0f) ? 1 : 0;
        }
        private void Awake()
        {
            UnityEngine.Events.UnityEvent val_5;
            UnityEngine.Events.UnityEvent val_6;
            val_5 = this.OnCentered;
            this._panel = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIPanel>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
            if(val_5 == null)
            {
                    UnityEngine.Events.UnityEvent val_3 = null;
                val_5 = val_3;
                val_3 = new UnityEngine.Events.UnityEvent();
            }
            
            val_6 = this.OnCenteredLoss;
            this.OnCentered = val_5;
            if(val_6 == null)
            {
                    UnityEngine.Events.UnityEvent val_4 = null;
                val_6 = val_4;
                val_4 = new UnityEngine.Events.UnityEvent();
            }
            
            this.OnCenteredLoss = val_6;
        }
        private void OnEnable()
        {
            this._centered = false;
        }
        protected virtual void Update()
        {
            UIPanel val_15;
            if(this._panel == 0)
            {
                    val_15 = 不丌丂丁丄一与丆丙.东丙丗一丄上不丙与<UIPanel>(丝三丁东丈丒世丅业:  this.gameObject, 丕丗丆丕丈丑东丆丈:  0);
                this._panel = val_15;
            }
            else
            {
                    val_15 = this._panel;
            }
            
            if(val_15 == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = this.Center;
            UnityEngine.Vector3 val_7 = this.transform.position;
            val_7.x = val_5.x - val_7.x;
            UnityEngine.Vector3 val_8 = this.Center;
            UnityEngine.Vector3 val_10 = this.transform.position;
            UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  System.Math.Abs(val_7.x), y:  System.Math.Abs(val_8.y - val_10.y));
            this.专丒丙与丙世一丑三 = val_12.x;
            mem[1152921543599828544] = val_12.y;
            if(((this.Direction == 1) ? 338275900 : 338275904) <= this.Slack)
            {
                goto label_14;
            }
            
            if(this._centered == false)
            {
                    return;
            }
            
            this._centered = false;
            if(this.OnCenteredLoss != null)
            {
                goto label_16;
            }
            
            return;
            label_14:
            if(this._centered == true)
            {
                    return;
            }
            
            this._centered = true;
            if(this.OnCentered == null)
            {
                    return;
            }
            
            label_16:
            this.OnCentered.Invoke();
        }
        public UICenterOnPanelComponent()
        {
            this.Direction = 1;
            this.Slack = 0.1f;
        }
    
    }

}
