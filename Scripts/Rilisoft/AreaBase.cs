using UnityEngine;

namespace Rilisoft
{
    public abstract class AreaBase : MonoBehaviour
    {
        // Fields
        internal const string 丝丗与丁丟一丂丄丕 = "Area";
        internal const string 丗丅丛丘丅丕丗丞丄 = "Ignore Raycast";
        private string _description;
        private bool _drawGizmo;
        private UnityEngine.Color _gizmoColor;
        private UnityEngine.Color _gizmoOutlineColor;
        private UnityEngine.Collider 丐丏三一丑丅丙丛三;
        private bool _isActive;
        
        // Methods
        protected virtual void Awake()
        {
            UnityEngine.Collider val_1 = this.GetComponent<UnityEngine.Collider>();
            this.丐丏三一丑丅丙丛三 = val_1;
            if(val_1 != 0)
            {
                    if(this.丐丏三一丑丅丙丛三.isTrigger != true)
            {
                    object[] val_4 = new object[1];
                val_4[0] = this.gameObject.name;
                UnityEngine.Debug.LogWarningFormat(format:  "[AREA SYSTEM] collider now is trigger, go:\'{0}\'", args:  val_4);
                this.丐丏三一丑丅丙丛三.isTrigger = true;
            }
            
                int val_7 = UnityEngine.LayerMask.NameToLayer(layerName:  "Ignore Raycast");
                if(this.gameObject.layer != val_7)
            {
                    this.gameObject.layer = val_7;
            }
            
                if((this.gameObject.CompareTag(tag:  "Area")) != false)
            {
                    return;
            }
            
                this.gameObject.tag = "Area";
                return;
            }
            
            System.Exception val_14 = new System.Exception(message:  "Collider not found");
        }
        private void Start()
        {
            if(Initializer.丑七不且上丗丁一世() == 0)
            {
                    return;
            }
            
            Initializer val_3 = Initializer.丑七不且上丗丁一世();
            val_3.丏丗丙丞丛世丞七七.Add(key:  this.丐丏三一丑丅丙丛三, value:  this);
        }
        public virtual void CheckIn(UnityEngine.GameObject 专丂丕丗丗东世丞下)
        {
            this._isActive = true;
        }
        public virtual void CheckOut(UnityEngine.GameObject 丈丗与丞一上且上上)
        {
            this._isActive = false;
        }
        protected AreaBase()
        {
            this._drawGizmo = true;
            this._gizmoColor = 0;
            mem[1152921542321039320] = 0;
            mem[1152921542321039328] = 0;
            this._gizmoOutlineColor = 0;
            mem[1152921542321039336] = 0;
            mem[1152921542321039344] = 0;
        }
    
    }

}
