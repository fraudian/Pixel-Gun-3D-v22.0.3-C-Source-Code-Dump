using UnityEngine;

namespace Rilisoft
{
    public class DirectionPointer : MonoBehaviour
    {
        // Fields
        private Rilisoft.专丂下上东丛专丗七 _forPointerType;
        private float _hideTime;
        private UIWidget 七丞丈不万世丘上丟;
        public bool OutOfRange;
        private Rilisoft.DirectionViewerTarget <专东三丅业丄丈七丈>k__BackingField;
        
        // Properties
        public Rilisoft.专丂下上东丛专丗七 下丆丈丙下丗丅下丆 { get; }
        public Rilisoft.DirectionViewerTarget 丘与丈丘丒丂丁丛丟 { get; set; }
        public bool 丁下丏与与丘万丗丄 { get; }
        private UIWidget 与东七丏丆世丟丁丌 { get; }
        
        // Methods
        public Rilisoft.专丂下上东丛专丗七 get_ForPointerType()
        {
            return (Rilisoft.专丂下上东丛专丗七)this._forPointerType;
        }
        public Rilisoft.DirectionViewerTarget get_Target()
        {
            return (Rilisoft.DirectionViewerTarget)this.<专东三丅业丄丈七丈>k__BackingField;
        }
        private void 不丂丂丝不三丟丁丌(Rilisoft.DirectionViewerTarget 丙业与丙丗丝不丈东)
        {
            this.<专东三丅业丄丈七丈>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public bool get_IsInited()
        {
            return UnityEngine.Object.op_Inequality(x:  this.<专东三丅业丄丈七丈>k__BackingField, y:  0);
        }
        private UIWidget 与丂业丈丘丐丅丄业()
        {
            UIWidget val_3;
            if(this.七丞丈不万世丘上丟 == 0)
            {
                    this.七丞丈不万世丘上丟 = this.GetComponent<UIWidget>();
                return val_3;
            }
            
            val_3 = this.七丞丈不万世丘上丟;
            return val_3;
        }
        public void TurnOn(Rilisoft.DirectionViewerTarget 一丛丆丛不丗专丏丘)
        {
            this.<专东三丅业丄丈七丈>k__BackingField = 一丛丆丛不丗专丏丘;
            this.gameObject.SetActive(value:  true);
            UIWidget val_2 = this.与丂业丈丘丐丅丄业();
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
            this.与丂业丈丘丐丅丄业().transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        }
        public void Hide()
        {
            if(this.gameObject.activeInHierarchy != false)
            {
                    UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丏与丂业丐丏且三丏());
                return;
            }
            
            this.gameObject.SetActive(value:  false);
        }
        public void TurnOff()
        {
            this.<专东三丅业丄丈七丈>k__BackingField = 0;
            this.OutOfRange = false;
            this.Hide();
        }
        private System.Collections.IEnumerator 丏与丂业丐丏且三丏()
        {
            .丗丏丅丕丆世丁专丟 = 0;
            .丝且与丝丒丟万丁专 = this;
            return (System.Collections.IEnumerator)new DirectionPointer.丄下丗丏丆丙业七丘();
        }
        public DirectionPointer()
        {
            this._hideTime = 0.3f;
        }
    
    }

}
