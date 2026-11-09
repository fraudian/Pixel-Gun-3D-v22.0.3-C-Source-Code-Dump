using UnityEngine;

namespace PGCompany
{
    public class InventoryItemViewController : MonoBehaviour
    {
        // Fields
        private PGCompany.InventoryItemView itemView;
        
        // Methods
        internal void 丆世与丑丆丅丐万且()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.itemView, 丏业丟一东丂东丘丛:  false);
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
        {
            this.丆世与丑丆丅丐万且();
            if(下丅丙一丂丗丅丝七 == null)
            {
                    return;
            }
            
            this.itemView.Setup(与且专丈不万东一万:  下丅丙一丂丗丅丝七);
        }
        public InventoryItemViewController()
        {
        
        }
    
    }

}
