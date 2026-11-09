using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    internal class CombinedHash : TlsHandshakeHash, IDigest
    {
        // Fields
        protected Org.BouncyCastle.Crypto.Tls.TlsContext mContext;
        protected Org.BouncyCastle.Crypto.IDigest mMd5;
        protected Org.BouncyCastle.Crypto.IDigest mSha1;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        internal CombinedHash()
        {
            this.mMd5 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  1);
            this.mSha1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  2);
        }
        internal CombinedHash(Org.BouncyCastle.Crypto.Tls.CombinedHash t)
        {
            if(t != null)
            {
                    this.mContext = t.mContext;
            }
            else
            {
                    this.mContext = 11993091;
            }
            
            this.mMd5 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CloneHash(hashAlgorithm:  1, hash:  t.mMd5);
            this.mSha1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CloneHash(hashAlgorithm:  2, hash:  t.mSha1);
        }
        public virtual void Init(Org.BouncyCastle.Crypto.Tls.TlsContext context)
        {
            this.mContext = context;
        }
        public virtual Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash NotifyPrfDetermined()
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash)this;
        }
        public virtual void TrackHashAlgorithm(byte hashAlgorithm)
        {
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "CombinedHash only supports calculating the legacy PRF for handshake hash");
        }
        public virtual void SealHashAlgorithms()
        {
        
        }
        public virtual Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash StopTracking()
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash)new Org.BouncyCastle.Crypto.Tls.CombinedHash(t:  this);
        }
        public virtual Org.BouncyCastle.Crypto.IDigest ForkPrfHash()
        {
            return (Org.BouncyCastle.Crypto.IDigest)new Org.BouncyCastle.Crypto.Tls.CombinedHash(t:  this);
        }
        public virtual byte[] GetFinalHash(byte hashAlgorithm)
        {
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "CombinedHash doesn\'t support multiple hashes");
        }
        public virtual string get_AlgorithmName()
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            var val_6 = 0;
            val_6 = val_6 + 1;
            return this.mMd5.AlgorithmName + " and " + this.mSha1.AlgorithmName;
        }
        public virtual int GetByteLength()
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            var val_6 = 0;
            val_6 = val_6 + 1;
            return System.Math.Max(val1:  this.mMd5.GetByteLength(), val2:  this.mSha1.GetByteLength());
        }
        public virtual int GetDigestSize()
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            var val_6 = 0;
            val_6 = val_6 + 1;
            int val_4 = this.mSha1.GetDigestSize();
            val_4 = val_4 + this.mMd5.GetDigestSize();
            return (int)val_4;
        }
        public virtual void Update(byte input)
        {
            var val_4;
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_4 = public System.Void Org.BouncyCastle.Crypto.IDigest::Update(byte input);
            this.mMd5.Update(input:  input);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_4 = 3;
            this.mSha1.Update(input:  input);
        }
        public virtual void BlockUpdate(byte[] input, int inOff, int len)
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.mMd5.BlockUpdate(input:  input, inOff:  inOff, length:  len);
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.mSha1.BlockUpdate(input:  input, inOff:  inOff, length:  len);
        }
        public virtual int DoFinal(byte[] output, int outOff)
        {
            var val_4;
            int val_7 = outOff;
            if(this.mContext != null)
            {
                    if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context:  this.mContext)) != false)
            {
                    val_4 = null;
                val_4 = null;
            }
            
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            int val_3 = this.mMd5.DoFinal(output:  output, outOff:  val_7);
            val_7 = val_3 + val_7;
            var val_8 = 0;
            val_8 = val_8 + 1;
            int val_5 = this.mSha1.DoFinal(output:  output, outOff:  val_7);
            val_5 = val_5 + val_3;
            return (int)val_5;
        }
        public virtual void Reset()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.mMd5.Reset();
            var val_4 = 0;
            val_4 = val_4 + 1;
            this.mSha1.Reset();
        }
        protected virtual void Ssl3Complete(Org.BouncyCastle.Crypto.IDigest d, byte[] ipad, byte[] opad, int padLength)
        {
            var val_9 = 0;
            val_9 = val_9 + 1;
            Org.BouncyCastle.Crypto.Tls.SecurityParameters val_2 = this.mContext.SecurityParameters;
            if(val_2.masterSecret == null)
            {
                goto label_7;
            }
            
            label_14:
            var val_10 = 0;
            val_10 = val_10 + 1;
            goto label_12;
            label_7:
            if(d != null)
            {
                goto label_14;
            }
            
            goto label_14;
            label_12:
            d.BlockUpdate(input:  val_2.masterSecret, inOff:  0, length:  val_2.masterSecret.Length);
            var val_11 = 0;
            val_11 = val_11 + 1;
            d.BlockUpdate(input:  ipad, inOff:  0, length:  padLength);
            System.Byte[] val_5 = Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest:  d);
            if(val_2.masterSecret == null)
            {
                goto label_22;
            }
            
            label_29:
            var val_12 = 0;
            val_12 = val_12 + 1;
            goto label_27;
            label_22:
            if(d != null)
            {
                goto label_29;
            }
            
            goto label_29;
            label_27:
            d.BlockUpdate(input:  val_2.masterSecret, inOff:  0, length:  val_2.masterSecret.Length);
            var val_13 = 0;
            val_13 = val_13 + 1;
            d.BlockUpdate(input:  opad, inOff:  0, length:  padLength);
            if(val_5 == null)
            {
                goto label_35;
            }
            
            label_42:
            var val_14 = 0;
            val_14 = val_14 + 1;
            goto label_40;
            label_35:
            if(d != null)
            {
                goto label_42;
            }
            
            goto label_42;
            label_40:
            d.BlockUpdate(input:  val_5, inOff:  0, length:  val_5.Length);
        }
    
    }

}
