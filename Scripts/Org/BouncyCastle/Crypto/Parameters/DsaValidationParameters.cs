using UnityEngine;

namespace Org.BouncyCastle.Crypto.Parameters
{
    public class DsaValidationParameters
    {
        // Fields
        private readonly byte[] seed;
        private readonly int counter;
        private readonly int usageIndex;
        
        // Properties
        public virtual int Counter { get; }
        public virtual int UsageIndex { get; }
        
        // Methods
        public DsaValidationParameters(byte[] seed, int counter)
        {
        
        }
        public DsaValidationParameters(byte[] seed, int counter, int usageIndex)
        {
            System.Byte[] val_4;
            if(seed != null)
            {
                    object val_1 = seed.Clone();
                if(val_1 != null)
            {
                    val_4 = val_1;
                if(val_4 == null)
            {
                    val_4 = 0;
            }
            
            }
            
                this.seed = val_4;
                this.counter = counter;
                this.usageIndex = usageIndex;
                return;
            }
            
            System.ArgumentNullException val_3 = new System.ArgumentNullException(paramName:  "seed");
        }
        public virtual byte[] GetSeed()
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
        public virtual int get_Counter()
        {
            return (int)this.counter;
        }
        public virtual int get_UsageIndex()
        {
            return (int)this.usageIndex;
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
        protected virtual bool Equals(Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters other)
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
