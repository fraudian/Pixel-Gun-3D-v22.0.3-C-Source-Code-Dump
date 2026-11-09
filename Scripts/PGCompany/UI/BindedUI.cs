using UnityEngine;

namespace PGCompany.UI
{
    internal class BindedUI : PGBehaviour, IDisposable
    {
        // Fields
        public UnityEngine.GameObject Target;
        private UnityEngine.Camera _guiCamera;
        private UnityEngine.Camera _worldCamera;
        private UnityEngine.Vector3 _addPosition;
        
        // Methods
        protected virtual void OnEnable()
        {
            this._guiCamera = 0;
            this._worldCamera = 0;
            this._guiCamera = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  this.丌丟丄业且三丛丕丄().gameObject.layer);
            if(this.Target == 0)
            {
                    return;
            }
            
            this._worldCamera = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  this.Target.layer);
        }
        protected virtual void LateUpdate()
        {
            if(this._worldCamera == 0)
            {
                    if(this.Target != 0)
            {
                    this._worldCamera = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  this.Target.layer);
            }
            
            }
            
            if(this._guiCamera == 0)
            {
                    this._guiCamera = 不丌丂丁丄一与丆丙.丄且丂丏一七业业丒(且丅丟丛丛万丝下上:  this.丌丟丄业且三丛丕丄().gameObject.layer);
            }
            
            if(this.Target == 0)
            {
                    return;
            }
            
            if(this._guiCamera == 0)
            {
                    return;
            }
            
            if(this._worldCamera == 0)
            {
                    return;
            }
            
            万丗丅且丄丑世专与.丙一且丕丟万丅一业(丄上七丟不丗丕下丟:  this.丌丟丄业且三丛丕丄(), 丈七东丐世丒丅丗丌:  new UnityEngine.Vector3(), 丑丑丘丄丅万丁丏不:  this._worldCamera, 七上与丌不丏三丌丙:  this._guiCamera);
            UnityEngine.Vector3 val_16 = this.丌丟丄业且三丛丕丄().localPosition;
            UnityEngine.Vector3 val_18 = this.丌丟丄业且三丛丕丄().localPosition;
            float val_19 = val_16.x + this._addPosition;
            val_18.y = val_18.y + S3;
            this.丌丟丄业且三丛丕丄().localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        }
        protected virtual UnityEngine.Vector3 与万丞万丁丞丗丗上()
        {
            UnityEngine.Transform val_1 = this.Target.transform;
            if(val_1 != null)
            {
                    return val_1.position;
            }
            
            return val_1.position;
        }
        protected virtual void OnDisable()
        {
        
        }
        protected virtual void OnDestroy()
        {
        
        }
        public virtual void Dispose()
        {
            this._guiCamera = 0;
            this._worldCamera = 0;
            this.Target = 0;
        }
        public BindedUI()
        {
        
        }
    
    }

}
