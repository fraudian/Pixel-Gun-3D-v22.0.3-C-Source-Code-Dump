using UnityEngine;

namespace PGCompany
{
    public class InventoryItemInfoController : MonoBehaviour
    {
        // Fields
        private UnityEngine.GameObject _background;
        private PGCompany.InventoryItemModuleChestInfo moduleChestInfo;
        internal PGCompany.InventoryItemModuleInfo moduleInfo;
        
        // Methods
        internal void 丆世与丑丆丅丐万且()
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._background, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.moduleChestInfo, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.moduleInfo, 丏业丟一东丂东丘丛:  false);
        }
        internal void 丈且东丑丂且万丒丅(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七)
        {
            PGCompany.InventoryItemModuleInfo val_1;
            this.丆世与丑丆丅丐万且();
            if(下丅丙一丂丗丅丝七 == null)
            {
                    return;
            }
            
            if(null == null)
            {
                goto label_2;
            }
            
            if(null != null)
            {
                goto label_3;
            }
            
            val_1 = this.moduleInfo;
            if(val_1 != null)
            {
                goto label_6;
            }
            
            goto label_5;
            label_2:
            val_1 = this.moduleChestInfo;
            if(val_1 != null)
            {
                goto label_6;
            }
            
            label_5:
            label_6:
            label_3:
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._background, 丏业丟一东丂东丘丛:  true);
        }
        public InventoryItemInfoController()
        {
        
        }
    
    }

}
