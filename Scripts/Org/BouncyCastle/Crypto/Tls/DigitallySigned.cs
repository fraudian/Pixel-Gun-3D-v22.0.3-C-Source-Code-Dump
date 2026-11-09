using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class DigitallySigned
    {
        // Fields
        protected readonly Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm mAlgorithm;
        protected readonly byte[] mSignature;
        
        // Properties
        public virtual Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm Algorithm { get; }
        public virtual byte[] Signature { get; }
        
        // Methods
        public DigitallySigned(Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm algorithm, byte[] signature)
        {
            if(signature != null)
            {
                    this.mAlgorithm = algorithm;
                this.mSignature = signature;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "signature");
        }
        public virtual Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm get_Algorithm()
        {
            return (Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm)this.mAlgorithm;
        }
        public virtual byte[] get_Signature()
        {
            return (System.Byte[])this.mSignature;
        }
        public virtual void Encode(System.IO.Stream output)
        {
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(buf:  this.mSignature, output:  output);
        }
        public static Org.BouncyCastle.Crypto.Tls.DigitallySigned Parse(Org.BouncyCastle.Crypto.Tls.TlsContext context, System.IO.Stream input)
        {
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context:  context)) == false)
            {
                    return (Org.BouncyCastle.Crypto.Tls.DigitallySigned)new Org.BouncyCastle.Crypto.Tls.DigitallySigned(algorithm:  0 = Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm.Parse(input:  input), signature:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input:  input));
            }
            
            return (Org.BouncyCastle.Crypto.Tls.DigitallySigned)new Org.BouncyCastle.Crypto.Tls.DigitallySigned(algorithm:  0, signature:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input:  input));
        }
    
    }

}
