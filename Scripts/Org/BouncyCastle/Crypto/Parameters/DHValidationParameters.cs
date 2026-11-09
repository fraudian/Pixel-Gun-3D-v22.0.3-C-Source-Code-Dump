using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class DHValidationParameters
    {
        // Fields
        private readonly byte[] seed;
        private readonly int counter;
        
        // Properties
        public int Counter { get; }
        
        // Methods
        public DHValidationParameters(byte[] seed, int counter)
        {
            var val_4;
            System.Byte[] val_5;
            val_4 = seed;
            if(val_4 != null)
            {
                    object val_1 = val_4.Clone();
                if(val_1 != null)
            {
                    val_5 = val_1;
                val_4 = null;
                if(val_5 == null)
            {
                    val_5 = 0;
            }
            
            }
            
                this.seed = val_5;
                this.counter = counter;
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "seed");
        }
        public byte[] GetSeed()
        {
            System.Byte[] val_3;
            var val_4;
            val_3 = this.seed;
            object val_1 = val_3.Clone();
            if(val_1 == null)
            {
                    return (System.Byte[])val_4;
            }
            
            val_4 = val_1;
            val_3 = null;
            if(val_4 != null)
            {
                    return (System.Byte[])val_4;
            }
            
            val_4 = 0;
            return (System.Byte[])val_4;
        }
        public int get_Counter()
        {
            return (int)this.counter;
        }
        public override bool Equals(object obj)
        {
            var val_1;
            if(this != obj)
            {
                    val_1 = 0;
                return (bool)val_1;
            }
            
            val_1 = 1;
            return (bool)val_1;
        }
        protected bool Equals(Org.BouncyCastle.Crypto.Parameters.DHValidationParameters other)
        {
            if(this.counter != other.counter)
            {
                    return false;
            }
            
            return Org.BouncyCastle.Utilities.Arrays.AreEqual(a:  this.seed, b:  other.seed);
        }
        public override int GetHashCode()
        {
            int val_2 = Org.BouncyCastle.Utilities.Arrays.GetHashCode(data:  this.seed);
            val_2 = val_2 ^ this.counter.GetHashCode();
            return (int)val_2;
        }
    
    }

}
