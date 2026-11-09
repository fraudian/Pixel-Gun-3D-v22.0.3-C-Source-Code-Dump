using UnityEngine;

namespace PGCompany
{
    public class 丙一丟与且丞丏丈一 : 专丟专世丅丂丁且专, IEquatable<PGCompany.专丟专世丅丂丁且专>, IEquatable<PGCompany.丙一丟与且丞丏丈一>
    {
        // Fields
        private string <东丒业上丌丐上东业>k__BackingField;
        
        // Properties
        internal string Key { get; set; }
        
        // Methods
        internal string 七万丅丆且丁世丏丈()
        {
            return (string)this.<东丒业上丌丐上东业>k__BackingField;
        }
        private void 丏一丅丌丙丑专专下(string 丙业与丙丗丝不丈东)
        {
            this.<东丒业上丌丐上东业>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal 丙一丟与且丞丏丈一()
        {
        
        }
        internal 丙一丟与且丞丏丈一(string 下上丐丆丝丟丝丒不)
        {
            this.<东丒业上丌丐上东业>k__BackingField = 下上丐丆丝丟丝丒不;
        }
        public bool 丑丕丈丈不不且丑且()
        {
            bool val_1 = 丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.<东丒业上丌丐上东业>k__BackingField);
            val_1 = (~val_1) & 1;
            return (bool)val_1;
        }
        public override int GetHashCode()
        {
            if((this.<东丒业上丌丐上东业>k__BackingField) == null)
            {
                
            }
        
        }
        public override bool Equals(object 丘丛丏丘丝七世七丅)
        {
            if(丘丛丏丘丝七世七丅 != null)
            {
                    var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (PGCompany.丙一丟与且丞丏丈一.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 丘丛丏丘丝七世七丅 : 0;
            }
            
            return false;
        }
        public bool Equals(PGCompany.专丟专世丅丂丁且专 丘丛丏丘丝七世七丅)
        {
            if(丘丛丏丘丝七世七丅 != null)
            {
                    var val_1 = (((PGCompany.专丟专世丅丂丁且专.__il2cppRuntimeField_typeHierarchy + (PGCompany.丙一丟与且丞丏丈一.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 丘丛丏丘丝七世七丅 : 0;
            }
            
            return false;
        }
        public bool Equals(PGCompany.丙一丟与且丞丏丈一 丘丛丏丘丝七世七丅)
        {
            if(this == 丘丛丏丘丝七世七丅)
            {
                    return true;
            }
            
            if(丘丛丏丘丝七世七丅 == null)
            {
                    return false;
            }
            
            return System.String.op_Equality(a:  this.<东丒业上丌丐上东业>k__BackingField, b:  丘丛丏丘丝七世七丅.<东丒业上丌丐上东业>k__BackingField);
        }
        public override string ToString()
        {
            return (string)this.<东丒业上丌丐上东业>k__BackingField;
        }
    
    }

}
