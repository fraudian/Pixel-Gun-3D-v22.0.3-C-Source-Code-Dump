using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class ServerDHParams
    {
        // Fields
        protected readonly Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters mPublicKey;
        
        // Properties
        public virtual Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters PublicKey { get; }
        
        // Methods
        public ServerDHParams(Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters publicKey)
        {
            if(publicKey != null)
            {
                    this.mPublicKey = publicKey;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "publicKey");
        }
        public virtual Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters get_PublicKey()
        {
            return (Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters)this.mPublicKey;
        }
        public virtual void Encode(System.IO.Stream output)
        {
            Org.BouncyCastle.Crypto.Parameters.DHParameters val_1 = this.mPublicKey.Parameters;
            Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.WriteDHParameter(x:  val_1.P, output:  output);
            Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.WriteDHParameter(x:  val_1.G, output:  output);
            Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.WriteDHParameter(x:  this.mPublicKey.Y, output:  output);
        }
        public static Org.BouncyCastle.Crypto.Tls.ServerDHParams Parse(System.IO.Stream input)
        {
            Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters val_5 = new Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters(y:  Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadDHParameter(input:  input), parameters:  new Org.BouncyCastle.Crypto.Parameters.DHParameters(p:  Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadDHParameter(input:  input), g:  Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ReadDHParameter(input:  input)));
            Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters val_6 = Org.BouncyCastle.Crypto.Tls.TlsDHUtilities.ValidateDHPublicKey(key:  val_5);
            return (Org.BouncyCastle.Crypto.Tls.ServerDHParams)new Org.BouncyCastle.Crypto.Tls.ServerDHParams(publicKey:  val_5);
        }
    
    }

}
