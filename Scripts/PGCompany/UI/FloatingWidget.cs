using UnityEngine;

namespace PGCompany.UI
{
    internal class FloatingWidget : MonoBehaviour
    {
        // Fields
        internal UIPanel ClampPanel;
        internal UnityEngine.Transform Anchor;
        internal bool ClampHorizontal;
        internal bool ClampVertical;
        private UIWidget _sizeWidget;
        private UIWidget _body;
        private PGCompany.UI.FloatingWidget.三丒丐丛不丗丌不丌 lerpType;
        private float lerpParam;
        
        // Methods
        internal void 丈且东丑丂且万丒丅(UnityEngine.Transform 丐丐丒万不丛丐专专, UIPanel 丁丑下且丛丙丏丂下)
        {
            this.ClampPanel = 丁丑下且丛丙丏丂下;
            this.Anchor = 丐丐丒万不丛丐专专;
        }
        private void OnEnable()
        {
            this._body = this.GetComponent<UIWidget>();
        }
        private void LateUpdate()
        {
            var val_26;
            float val_30;
            float val_31;
            float val_32;
            float val_33;
            UIWidget val_34;
            var val_35;
            float val_36;
            var val_37;
            float val_39;
            float val_40;
            var val_41;
            float val_42;
            float val_43;
            float val_44;
            float val_45;
            float val_46;
            val_26 = this;
            if(this.Anchor == 0)
            {
                    return;
            }
            
            if(this.ClampPanel == 0)
            {
                    return;
            }
            
            if(this._body == 0)
            {
                    return;
            }
            
            UnityEngine.Vector3 val_5 = this._body.transform.position;
            val_30 = val_5.y;
            val_31 = val_5.z;
            if(this.ClampHorizontal == false)
            {
                goto label_36;
            }
            
            UnityEngine.Vector3 val_6 = this.Anchor.position;
            val_32 = val_30;
            val_33 = val_31;
            UnityEngine.Vector3 val_9 = this.ClampPanel.root.transform.localScale;
            float val_25 = val_9.x;
            if(this._sizeWidget == 0)
            {
                goto label_19;
            }
            
            val_34 = this._sizeWidget;
            if(val_34 != null)
            {
                goto label_29;
            }
            
            label_30:
            val_34 = 0;
            label_29:
            val_31 = val_5.x;
            val_25 = val_25 * (float)val_34.width;
            if(null == null)
            {
                    val_35 = 0;
            }
            
            val_36 = val_25 * 0.5f;
            val_30 = val_31 - val_36;
            if(val_30 >= 0)
            {
                goto label_26;
            }
            
            if(null != null)
            {
                goto label_28;
            }
            
            goto label_28;
            label_19:
            if(this._body != null)
            {
                goto label_29;
            }
            
            goto label_30;
            label_26:
            val_30 = val_31 + val_36;
            if(null <= 3)
            {
                    val_37 = 0;
            }
            
            if(val_30 <= val_9.x)
            {
                goto label_32;
            }
            
            label_28:
            val_39 = val_9.x - val_30;
            label_32:
            if(((-250842984) & 1) != 0)
            {
                    val_30 = val_5.x;
                val_32 = val_30;
                val_33 = val_31;
                val_39 = val_30 + val_39;
            }
            
            label_36:
            if(this.lerpType == 2)
            {
                goto label_37;
            }
            
            if(this.lerpType == 1)
            {
                goto label_38;
            }
            
            if(this.lerpType != 0)
            {
                    return;
            }
            
            val_30 = val_5.x;
            val_40 = val_30;
            val_36 = val_31;
            val_26 = this._body.transform;
            if(val_26 != null)
            {
                goto label_42;
            }
            
            goto label_42;
            label_37:
            val_41 = this._body.transform;
            UnityEngine.Vector3 val_15 = this._body.transform.position;
            val_42 = val_31;
            val_43 = UnityEngine.Time.deltaTime;
            val_44 = val_15.x;
            val_45 = val_15.y;
            val_46 = val_15.z;
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.MoveTowards(current:  new UnityEngine.Vector3() {x = val_44, y = val_45, z = val_46}, target:  new UnityEngine.Vector3() {x = val_5.x, y = val_30, z = val_42}, maxDistanceDelta:  val_43 * this.lerpParam);
            goto label_48;
            label_38:
            val_41 = this._body.transform;
            UnityEngine.Vector3 val_21 = this._body.transform.position;
            val_42 = val_31;
            val_43 = UnityEngine.Time.deltaTime;
            val_44 = val_21.x;
            val_45 = val_21.y;
            val_46 = val_21.z;
            UnityEngine.Vector3 val_24 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_44, y = val_45, z = val_46}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_30, z = val_42}, t:  val_43 * this.lerpParam);
            label_48:
            val_30 = val_24.x;
            val_40 = val_24.y;
            val_36 = val_24.z;
            label_42:
            val_41.position = new UnityEngine.Vector3() {x = val_30, y = val_40, z = val_36};
        }
        public FloatingWidget()
        {
            this.ClampHorizontal = true;
            this.lerpParam = 5f;
        }
    
    }

}
