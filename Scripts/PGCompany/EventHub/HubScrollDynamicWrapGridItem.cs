using UnityEngine;

namespace PGCompany.EventHub
{
    public class HubScrollDynamicWrapGridItem : DynamicWrapGridItem
    {
        // Fields
        private PGCompany.InventoryItemView _itemView;
        private PGCompany.丗丟丄丈东丝丕丄世 <丝业三丑三上丆专不>k__BackingField;
        
        // Properties
        internal PGCompany.丗丟丄丈东丝丕丄世 不下下丞三一丘丗丐 { get; set; }
        
        // Methods
        internal PGCompany.丗丟丄丈东丝丕丄世 丂丑丞丝且万丐万丟()
        {
            return (PGCompany.丗丟丄丈东丝丕丄世)this.<丝业三丑三上丆专不>k__BackingField;
        }
        internal void 丘丕丈下东一丑上丗(PGCompany.丗丟丄丈东丝丕丄世 丙业与丙丗丝不丈东)
        {
            this.<丝业三丑三上丆专不>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public override void UpdateContent(object 三丏丑不业丏不丂丈)
        {
            if(三丏丑不业丏不丂丈 == null)
            {
                    return;
            }
            
            三丏丑不业丏不丂丈 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (PGCompany.丗丟丄丈东丝丕丄世.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 三丏丑不业丏不丂丈 : 0;
        }
        public HubScrollDynamicWrapGridItem()
        {
        
        }
    
    }

}
