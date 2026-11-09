using UnityEngine;

namespace Rilisoft
{
    public class BindedBillboard : MonoBehaviour
    {
        // Fields
        private static System.Collections.Generic.List<Rilisoft.BindedBillboard> 丒丛专丙丏下丘且丝;
        private System.Func<UnityEngine.Transform> 丒丗专丁丛丄一丗业;
        private UnityEngine.Transform _pointInWorld;
        private UnityEngine.Collider _touchCollider;
        
        // Properties
        public UnityEngine.Collider 上丏丑下丒万丏丙丝 { get; }
        
        // Methods
        public UnityEngine.Collider get_Collider()
        {
            if(this._touchCollider != 0)
            {
                    return (UnityEngine.Collider)this._touchCollider;
            }
            
            UnityEngine.Collider val_3 = this.gameObject.GetComponent<UnityEngine.Collider>();
            this._touchCollider = val_3;
            if(val_3 != 0)
            {
                    return (UnityEngine.Collider)this._touchCollider;
            }
            
            this._touchCollider = this.GetComponentInChildren<UnityEngine.Collider>();
            return (UnityEngine.Collider)this._touchCollider;
        }
        internal static Rilisoft.BindedBillboard 专丟下丄丄专丆专丑(string 丒丈丄上丂业丙三丁)
        {
            var val_3;
            .丒丈丄上丂业丙三丁 = 丒丈丄上丂业丙三丁;
            val_3 = null;
            val_3 = null;
            return System.Linq.Enumerable.FirstOrDefault<Rilisoft.BindedBillboard>(source:  Rilisoft.BindedBillboard.丒丛专丙丏下丘且丝, predicate:  new System.Func<Rilisoft.BindedBillboard, System.Boolean>(object:  new BindedBillboard.丘丞上世丗丘丏丐东(), method:  System.Boolean BindedBillboard.丘丞上世丗丘丏丐东::丕东丛丏与世丐不丕(Rilisoft.BindedBillboard 丌丛万丛世丗丙丟与)));
        }
        public void BindTo(System.Func<UnityEngine.Transform> 丅专与丒丈丗丒丘丌)
        {
            this.丒丗专丁丛丄一丗业 = 丅专与丒丈丗丒丘丌;
            this._pointInWorld = 0;
        }
        private void Awake()
        {
            null = null;
            Rilisoft.BindedBillboard.丒丛专丙丏下丘且丝.Add(item:  this);
            if(this.丒丗专丁丛丄一丗业 != null)
            {
                    return;
            }
            
            if(this._pointInWorld == 0)
            {
                    return;
            }
            
            this.丒丗专丁丛丄一丗业 = new System.Func<UnityEngine.Transform>(object:  this, method:  UnityEngine.Transform Rilisoft.BindedBillboard::丐一丈不丂与丑丒世());
        }
        private void Update()
        {
            object val_20;
            System.Func<UnityEngine.Transform> val_21;
            var val_22;
            val_20 = this;
            if(this._pointInWorld == 0)
            {
                goto label_3;
            }
            
            System.Func<UnityEngine.Transform> val_2 = null;
            val_21 = val_2;
            val_2 = new System.Func<UnityEngine.Transform>(object:  this, method:  UnityEngine.Transform Rilisoft.BindedBillboard::专丄三下丑丒世丗上());
            this.丒丗专丁丛丄一丗业 = val_21;
            if(val_21 != null)
            {
                goto label_4;
            }
            
            return;
            label_3:
            val_21 = this.丒丗专丁丛丄一丗业;
            if(val_21 == null)
            {
                    return;
            }
            
            label_4:
            if(val_21.Invoke() == 0)
            {
                    return;
            }
            
            val_22 = null;
            val_22 = null;
            if(丟丌丁且且世丈丈丟.丐万与与丙丁丂丅专 == 0)
            {
                    return;
            }
            
            万丗丅且丄丑世专与.丙一且丕丟万丅一业(丄上七丟不丗丕下丟:  this.transform, 丞下万上三丘上与专:  this.丒丗专丁丛丄一丗业.Invoke());
            UnityEngine.Vector3 val_10 = this.transform.localPosition;
            UnityEngine.Vector3 val_12 = this.transform.localPosition;
            this.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            if(this.Collider == 0)
            {
                    return;
            }
            
            val_20 = this.Collider;
            val_20.enabled = this.丒丗专丁丛丄一丗业.Invoke().gameObject.activeSelf;
        }
        private void OnDestroy()
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if((Rilisoft.BindedBillboard.丒丛专丙丏下丘且丝.Contains(item:  this)) == false)
            {
                    return;
            }
            
            val_4 = null;
            val_4 = null;
            bool val_2 = Rilisoft.BindedBillboard.丒丛专丙丏下丘且丝.Remove(item:  this);
        }
        public BindedBillboard()
        {
        
        }
        private static BindedBillboard()
        {
            Rilisoft.BindedBillboard.丒丛专丙丏下丘且丝 = new System.Collections.Generic.List<Rilisoft.BindedBillboard>();
        }
        private UnityEngine.Transform 丐一丈不丂与丑丒世()
        {
            return (UnityEngine.Transform)this._pointInWorld;
        }
        private UnityEngine.Transform 专丄三下丑丒世丗上()
        {
            return (UnityEngine.Transform)this._pointInWorld;
        }
    
    }

}
