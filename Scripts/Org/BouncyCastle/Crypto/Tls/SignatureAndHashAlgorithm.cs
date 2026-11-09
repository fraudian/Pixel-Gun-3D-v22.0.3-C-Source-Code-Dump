using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class SignatureAndHashAlgorithm
    {
        // Fields
        protected readonly byte mHash;
        protected readonly byte mSignature;
        
        // Properties
        public virtual byte Hash { get; }
        public virtual byte Signature { get; }
        
        // Methods
        public SignatureAndHashAlgorithm(byte hash, byte signature)
        {
            string val_7;
            string val_8;
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint8(i:  hash & 255)) == false)
            {
                goto label_3;
            }
            
            byte val_3 = signature & 255;
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidUint8(i:  val_3)) == false)
            {
                goto label_6;
            }
            
            if(val_3 == 0)
            {
                goto label_7;
            }
            
            this.mHash = hash;
            this.mSignature = signature;
            return;
            label_3:
            val_7 = "should be a uint8";
            val_8 = "hash";
            goto label_8;
            label_6:
            val_7 = "should be a uint8";
            goto label_9;
            label_7:
            val_7 = "MUST NOT be \"anonymous\"";
            label_9:
            val_8 = "signature";
            label_8:
            null = new System.ArgumentException(message:  val_7, paramName:  val_8);
        }
        public virtual byte get_Hash()
        {
            return (byte)this.mHash;
        }
        public virtual byte get_Signature()
        {
            return (byte)this.mSignature;
        }
        public override bool Equals(object obj)
        {
            var val_4;
            object val_4 = obj;
            if(val_4 != null)
            {
                    if((val_4 & 255) == this)
            {
                    val_4 = val_4 & 255;
                var val_3 = (val_4 == this) ? 1 : 0;
                return (bool)val_4;
            }
            
            }
            
            val_4 = 0;
            return (bool)val_4;
        }
        public override int GetHashCode()
        {
            return (int)0;
        }
        public virtual void Encode(System.IO.Stream output)
        {
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  128, output:  output);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  128, output:  output);
        }
        public static Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm Parse(System.IO.Stream input)
        {
            return (Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm)new Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm(hash:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input:  input), signature:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input:  input));
        }
    
    }

}
