using UnityEngine;

namespace PGCompany.AttributeSystem
{
    public class 东丙七一丑丙丝丞业 : IEquatable<PGCompany.AttributeSystem.东丙七一丑丙丝丞业>
    {
        // Fields
        private PGCompany.AttributeSystem.世丅万丘丑万丙丂丌 <且丈丁专东丆丄丂与>k__BackingField;
        private int <丄东丗世丁丁世丆丏>k__BackingField;
        
        // Properties
        public PGCompany.AttributeSystem.世丅万丘丑万丙丂丌 丒三丝一上丙专丗丒 { get; set; }
        public int 丑丒丞丛东丕丕丈三 { get; set; }
        
        // Methods
        public PGCompany.AttributeSystem.世丅万丘丑万丙丂丌 不业丙丒丂丞下丆丙()
        {
            return (PGCompany.AttributeSystem.世丅万丘丑万丙丂丌)this.<且丈丁专东丆丄丂与>k__BackingField;
        }
        private void 东丝丕专丒丏三三与(PGCompany.AttributeSystem.世丅万丘丑万丙丂丌 丙业与丙丗丝不丈东)
        {
            this.<且丈丁专东丆丄丂与>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public int 丘上丁丈专丛丝丏丕()
        {
            return (int)this.<丄东丗世丁丁世丆丏>k__BackingField;
        }
        private void 丏丄丝丂丂丞世丌丕(int 丙业与丙丗丝不丈东)
        {
            this.<丄东丗世丁丁世丆丏>k__BackingField = 丙业与丙丗丝不丈东;
        }
        public 东丙七一丑丙丝丞业(PGCompany.AttributeSystem.世丅万丘丑万丙丂丌 丁丅丈丌丟世丗丗丟, int 业三丝丌七丑三丏丛)
        {
            this.<且丈丁专东丆丄丂与>k__BackingField = 丁丅丈丌丟世丗丗丟;
            this.<丄东丗世丁丁世丆丏>k__BackingField = 业三丝丌七丑三丏丛;
        }
        public bool Equals(PGCompany.AttributeSystem.东丙七一丑丙丝丞业 丘丛丏丘丝七世七丅)
        {
            if(丘丛丏丘丝七世七丅 == null)
            {
                    return false;
            }
            
            if(this == 丘丛丏丘丝七世七丅)
            {
                    return true;
            }
            
            if((this.<且丈丁专东丆丄丂与>k__BackingField) != (丘丛丏丘丝七世七丅.<且丈丁专东丆丄丂与>k__BackingField))
            {
                    return false;
            }
            
            return (bool)((this.<丄东丗世丁丁世丆丏>k__BackingField) == (丘丛丏丘丝七世七丅.<丄东丗世丁丁世丆丏>k__BackingField)) ? 1 : 0;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
            System.Type val_7;
            var val_8;
            if(万且万且丑丗且丌丆 == null)
            {
                goto label_10;
            }
            
            if(this == 万且万且丑丗且丌丆)
            {
                goto label_9;
            }
            
            val_7 = 万且万且丑丗且丌丆.GetType();
            bool val_3 = System.Type.op_Inequality(left:  val_7, right:  this.GetType());
            label_10:
            val_8 = 0;
            return (bool)val_8;
            label_9:
            val_8 = 1;
            return (bool)val_8;
        }
        public override int GetHashCode()
        {
            return System.HashCode.Combine<System.Int32, System.Int32>(value1:  this.<且丈丁专东丆丄丂与>k__BackingField, value2:  this.<丄东丗世丁丁世丆丏>k__BackingField);
        }
    
    }

}
