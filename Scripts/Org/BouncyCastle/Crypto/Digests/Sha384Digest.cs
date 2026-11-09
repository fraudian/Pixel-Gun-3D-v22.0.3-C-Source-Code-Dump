using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class Sha384Digest : LongDigest
    {
        // Fields
        private const int DigestLength = 48;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public Sha384Digest()
        {
        
        }
        public Sha384Digest(Org.BouncyCastle.Crypto.Digests.Sha384Digest t)
        {
            Org.BouncyCastle.Crypto.Digests.Sha384Digest val_1 = t;
            val_1 = new Org.BouncyCastle.Crypto.Digests.LongDigest(t:  val_1);
        }
        public override string get_AlgorithmName()
        {
            return "SHA-384";
        }
        public override int GetDigestSize()
        {
            return 48;
        }
        public override int DoFinal(byte[] output, int outOff)
        {
            this.Finish();
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(n:  this, bs:  output, off:  outOff);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(n:  this, bs:  output, off:  outOff + 8);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(n:  this, bs:  output, off:  outOff + 16);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(n:  this, bs:  output, off:  outOff + 24);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(n:  this, bs:  output, off:  outOff + 32);
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_BE(n:  this, bs:  output, off:  outOff + 40);
            return 48;
        }
        public override void Reset()
        {
            this.Reset();
            mem[1152921553364907624] = ;
            mem[1152921553364907640] = ;
            mem[1152921553364907656] = ;
            mem[1152921553364907672] = ;
        }
        public override Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.Sha384Digest(t:  this);
        }
        public override void Reset(Org.BouncyCastle.Utilities.IMemoable other)
        {
            Org.BouncyCastle.Utilities.IMemoable val_3 = other;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this.CopyIn(t:  val_3);
        }
    
    }

}
