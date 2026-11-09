using UnityEngine;

namespace Org.BouncyCastle.Utilities.IO.Pem
{
    public class PemHeader
    {
        // Fields
        private string name;
        private string val;
        
        // Properties
        public virtual string Name { get; }
        public virtual string Value { get; }
        
        // Methods
        public PemHeader(string name, string val)
        {
            val_1 = new System.Object();
            this.name = name;
            this.val = val_1;
        }
        public virtual string get_Name()
        {
            return (string)this.name;
        }
        public virtual string get_Value()
        {
            return (string)this.val;
        }
        public override int GetHashCode()
        {
            var val_2;
            var val_3;
            if(this.name != null)
            {
                    val_2 = this.name;
            }
            else
            {
                    val_2 = 1;
            }
            
            if(this.val != null)
            {
                    val_3 = (this.val << 5) - this.val;
                return (int)val_3 + val_2;
            }
            
            val_3 = 31;
            return (int)val_3 + val_2;
        }
        public override bool Equals(object obj)
        {
            string val_3;
            if(this == obj)
            {
                goto label_1;
            }
            
            if((obj == null) || ((System.Object.Equals(objA:  this.name, objB:  obj)) == false))
            {
                goto label_5;
            }
            
            val_3 = this.val;
            bool val_2 = System.Object.Equals(objA:  val_3, objB:  obj);
            goto label_7;
            label_5:
            val_3 = 0;
            goto label_7;
            label_1:
            val_3 = 1;
            label_7:
            val_3 = val_3 & 1;
            return (bool)val_3;
        }
        private int GetHashCode(string s)
        {
            if(s == null)
            {
                    return 1;
            }
            
            goto typeof(System.String).__il2cppRuntimeField_148;
        }
    
    }

}
