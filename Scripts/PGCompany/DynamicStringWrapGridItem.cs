using UnityEngine;

namespace PGCompany
{
    public class DynamicStringWrapGridItem : MonoBehaviour
    {
        // Fields
        public int wrapIndex;
        private UIWidget <与专丐丝七且丈七丙>k__BackingField;
        
        // Properties
        public UIWidget 丕丟丟丝丝丞七且下 { get; set; }
        
        // Methods
        public UIWidget get_Widget()
        {
            return (UIWidget)this.<与专丐丝七且丈七丙>k__BackingField;
        }
        private void 丈世万丐丈世上七丒(UIWidget 丙业与丙丗丝不丈东)
        {
            this.<与专丐丝七且丈七丙>k__BackingField = 丙业与丙丗丝不丈东;
        }
        protected virtual void Awake()
        {
            this.<与专丐丝七且丈七丙>k__BackingField = this.GetComponent<UIWidget>();
        }
        public virtual void UpdateContent(string 三丏丑不业丏不丂丈)
        {
        
        }
        public DynamicStringWrapGridItem()
        {
        
        }
    
    }

}
