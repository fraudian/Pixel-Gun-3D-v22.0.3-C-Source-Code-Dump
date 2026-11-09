using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class Gost3410ValidationParameters
    {
        // Fields
        private int x0;
        private int c;
        private long x0L;
        private long cL;
        
        // Properties
        public int C { get; }
        public int X0 { get; }
        public long CL { get; }
        public long X0L { get; }
        
        // Methods
        public Gost3410ValidationParameters(int x0, int c)
        {
            this.x0 = x0;
            this.c = c;
        }
        public Gost3410ValidationParameters(long x0L, long cL)
        {
            this.x0L = x0L;
            this.cL = cL;
        }
        public int get_C()
        {
            return (int)this.c;
        }
        public int get_X0()
        {
            return (int)this.x0;
        }
        public long get_CL()
        {
            return (long)this.cL;
        }
        public long get_X0L()
        {
            return (long)this.x0L;
        }
        public override bool Equals(object obj)
        {
            var val_3;
            if(obj != null)
            {
                    var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? obj : 0;
                var val_2 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8 == null ? obj : 0 + 24) == this.x0L) ? 1 : 0;
                return (bool)val_3;
            }
            
            val_3 = 0;
            return (bool)val_3;
        }
        public override int GetHashCode()
        {
            int val_4 = this.x0L.GetHashCode();
            int val_5 = this.x0.GetHashCode() ^ this.c.GetHashCode();
            val_5 = val_5 ^ this.cL.GetHashCode();
            val_4 = val_5 ^ val_4;
            return (int)val_4;
        }
    
    }

}
