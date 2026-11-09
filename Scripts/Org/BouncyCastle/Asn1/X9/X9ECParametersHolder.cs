using UnityEngine;

namespace Org.BouncyCastle.Asn1.X9
{
    public abstract class X9ECParametersHolder
    {
        // Fields
        private Org.BouncyCastle.Asn1.X9.X9ECParameters parameters;
        
        // Properties
        public Org.BouncyCastle.Asn1.X9.X9ECParameters Parameters { get; }
        
        // Methods
        public Org.BouncyCastle.Asn1.X9.X9ECParameters get_Parameters()
        {
            Org.BouncyCastle.Asn1.X9.X9ECParameters val_2;
            var val_3;
            var val_4;
            bool val_1 = false;
            System.Threading.Monitor.Enter(obj:  this, lockTaken: ref  val_1);
            val_2 = this.parameters;
            if(val_2 != null)
            {
                    val_3 = 0;
                val_4 = 0;
            }
            else
            {
                    val_2 = this;
                val_3 = 0;
                val_4 = 0;
                this.parameters = val_2;
            }
            
            if(val_1 != 0)
            {
                    System.Threading.Monitor.Exit(obj:  this);
            }
            
            if(val_3 != 1)
            {
                    return val_2;
            }
            
            if(val_4 == 0)
            {
                    return val_2;
            }
            
            return val_2;
        }
        protected abstract Org.BouncyCastle.Asn1.X9.X9ECParameters CreateParameters(); // 0
        protected X9ECParametersHolder()
        {
        
        }
    
    }

}
