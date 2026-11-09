using UnityEngine;

namespace PGCompany
{
    public class 世丏丘丛丗丑专丈下 : 专丟专世丅丂丁且专, IEquatable<PGCompany.专丟专世丅丂丁且专>, IEquatable<PGCompany.世丏丘丛丗丑专丈下>
    {
        // Fields
        private int <东丒业上丌丐上东业>k__BackingField;
        
        // Properties
        internal int Key { get; set; }
        
        // Methods
        internal int 七万丅丆且丁世丏丈()
        {
            return (int)this.<东丒业上丌丐上东业>k__BackingField;
        }
        private void 丏一丅丌丙丑专专下(int 丙业与丙丗丝不丈东)
        {
            this.<东丒业上丌丐上东业>k__BackingField = 丙业与丙丗丝不丈东;
        }
        internal 世丏丘丛丗丑专丈下()
        {
        
        }
        internal 世丏丘丛丗丑专丈下(int 下上丐丆丝丟丝丒不)
        {
            this.<东丒业上丌丐上东业>k__BackingField = 下上丐丆丝丟丝丒不;
        }
        public bool 丑丕丈丈不不且丑且()
        {
            int val_2 = this.<东丒业上丌丐上东业>k__BackingField;
            val_2 = val_2 >> 31;
            return (bool)val_2 ^ 1;
        }
        public override bool Equals(object 丘丛丏丘丝七世七丅)
        {
            if(丘丛丏丘丝七世七丅 != null)
            {
                    var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (PGCompany.世丏丘丛丗丑专丈下.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 丘丛丏丘丝七世七丅 : 0;
            }
            
            return false;
        }
        public override int GetHashCode()
        {
            return (int)this.<东丒业上丌丐上东业>k__BackingField.GetHashCode();
        }
        public bool Equals(PGCompany.专丟专世丅丂丁且专 丘丛丏丘丝七世七丅)
        {
            if(丘丛丏丘丝七世七丅 != null)
            {
                    var val_1 = (((PGCompany.专丟专世丅丂丁且专.__il2cppRuntimeField_typeHierarchy + (PGCompany.世丏丘丛丗丑专丈下.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 丘丛丏丘丝七世七丅 : 0;
            }
            
            return false;
        }
        public bool Equals(PGCompany.世丏丘丛丗丑专丈下 丘丛丏丘丝七世七丅)
        {
            if(this == 丘丛丏丘丝七世七丅)
            {
                    return true;
            }
            
            if(丘丛丏丘丝七世七丅 == null)
            {
                    return false;
            }
            
            return (bool)((this.<东丒业上丌丐上东业>k__BackingField) == (丘丛丏丘丝七世七丅.<东丒业上丌丐上东业>k__BackingField)) ? 1 : 0;
        }
        public override string ToString()
        {
            return (string)this.<东丒业上丌丐上东业>k__BackingField.ToString();
        }
    
    }

}
