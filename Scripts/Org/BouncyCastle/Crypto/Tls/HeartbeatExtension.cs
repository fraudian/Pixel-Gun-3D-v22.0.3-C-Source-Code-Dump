using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class HeartbeatExtension
    {
        // Fields
        protected readonly byte mMode;
        
        // Properties
        public virtual byte Mode { get; }
        
        // Methods
        public HeartbeatExtension(byte mode)
        {
            byte val_1 = mode - 1;
            val_1 = val_1 & 255;
            if(val_1 < 2)
            {
                    this.mMode = mode;
                return;
            }
            
            System.ArgumentException val_2 = new System.ArgumentException(message:  "not a valid HeartbeatMode value", paramName:  "mode");
        }
        public virtual byte get_Mode()
        {
            return (byte)this.mMode;
        }
        public virtual void Encode(System.IO.Stream output)
        {
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  this.mMode, output:  output);
        }
        public static Org.BouncyCastle.Crypto.Tls.HeartbeatExtension Parse(System.IO.Stream input)
        {
            byte val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input:  input);
            byte val_2 = val_1 - 1;
            val_2 = val_2 & 255;
            if(val_2 < 2)
            {
                    return (Org.BouncyCastle.Crypto.Tls.HeartbeatExtension)new Org.BouncyCastle.Crypto.Tls.HeartbeatExtension(mode:  val_1);
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_4 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
        }
    
    }

}
