using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    internal class DeferredHash : TlsHandshakeHash, IDigest
    {
        // Fields
        protected const int BUFFERING_HASH_LIMIT = 4;
        protected Org.BouncyCastle.Crypto.Tls.TlsContext mContext;
        private Org.BouncyCastle.Crypto.Tls.DigestInputBuffer mBuf;
        private System.Collections.IDictionary mHashes;
        private int mPrfHashAlgorithm;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        internal DeferredHash()
        {
            this.mBuf = new Org.BouncyCastle.Crypto.Tls.DigestInputBuffer();
            this.mHashes = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            this.mPrfHashAlgorithm = 0;
        }
        private DeferredHash(byte prfHashAlgorithm, Org.BouncyCastle.Crypto.IDigest prfHash)
        {
            this.mBuf = 0;
            System.Collections.IDictionary val_1 = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            this.mHashes = val_1;
            this.mPrfHashAlgorithm = prfHashAlgorithm & 255;
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_1.set_Item(key:  prfHashAlgorithm, value:  prfHash);
        }
        public virtual void Init(Org.BouncyCastle.Crypto.Tls.TlsContext context)
        {
            this.mContext = context;
        }
        public virtual Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash NotifyPrfDetermined()
        {
            var val_6 = 0;
            val_6 = val_6 + 1;
            Org.BouncyCastle.Crypto.Tls.SecurityParameters val_2 = this.mContext.SecurityParameters;
            if(val_2 != null)
            {
                    this.mPrfHashAlgorithm = (Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetHashAlgorithmForPrfAlgorithm(prfAlgorithm:  val_2)) & 255;
                return (Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash)this;
            }
            
            this.mBuf.UpdateDigest(d:  new Org.BouncyCastle.Crypto.Tls.CombinedHash());
            goto typeof(Org.BouncyCastle.Crypto.Tls.CombinedHash).__il2cppRuntimeField_258;
        }
        public virtual void TrackHashAlgorithm(byte hashAlgorithm)
        {
            if(this.mBuf != null)
            {
                
            }
            else
            {
                    System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Too late to track more hash algorithms");
            }
        
        }
        public virtual void SealHashAlgorithms()
        {
            goto typeof(Org.BouncyCastle.Crypto.Tls.DeferredHash).__il2cppRuntimeField_328;
        }
        public virtual Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash StopTracking()
        {
            Org.BouncyCastle.Crypto.IDigest val_6;
            var val_6 = 0;
            val_6 = val_6 + 1;
            object val_2 = this.mHashes.Item[this.mPrfHashAlgorithm];
            if(val_2 == null)
            {
                goto label_10;
            }
            
            val_6 = val_2;
            if(val_6 != null)
            {
                goto label_9;
            }
            
            label_10:
            val_6 = 0;
            label_9:
            Org.BouncyCastle.Crypto.IDigest val_4 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CloneHash(hashAlgorithm:  this.mPrfHashAlgorithm, hash:  val_6);
            if(this.mBuf != null)
            {
                    this.mBuf.UpdateDigest(d:  val_4);
            }
            
            Org.BouncyCastle.Crypto.Tls.DeferredHash val_5 = new Org.BouncyCastle.Crypto.Tls.DeferredHash(prfHashAlgorithm:  this.mPrfHashAlgorithm, prfHash:  val_4);
            if(val_5 != null)
            {
                    return (Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash)val_5;
            }
            
            return (Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash)val_5;
        }
        public virtual Org.BouncyCastle.Crypto.IDigest ForkPrfHash()
        {
            Org.BouncyCastle.Crypto.IDigest val_5;
            Org.BouncyCastle.Crypto.IDigest val_7;
            if(this.mBuf != null)
            {
                    val_5 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  this.mPrfHashAlgorithm);
                this.mBuf.UpdateDigest(d:  val_5);
                return (Org.BouncyCastle.Crypto.IDigest)val_5;
            }
            
            var val_6 = 0;
            val_6 = val_6 + 1;
            object val_3 = this.mHashes.Item[this.mPrfHashAlgorithm];
            if(val_3 == null)
            {
                goto label_15;
            }
            
            val_7 = val_3;
            if(val_7 != null)
            {
                goto label_14;
            }
            
            label_15:
            val_7 = 0;
            label_14:
            val_5 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CloneHash(hashAlgorithm:  this.mPrfHashAlgorithm, hash:  val_7);
            return (Org.BouncyCastle.Crypto.IDigest)val_5;
        }
        public virtual byte[] GetFinalHash(byte hashAlgorithm)
        {
            var val_9 = 0;
            val_9 = val_9 + 1;
            object val_2 = this.mHashes.Item[hashAlgorithm];
            if(val_2 != null)
            {
                    if(val_2 != null)
            {
                    Org.BouncyCastle.Crypto.IDigest val_3 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CloneHash(hashAlgorithm:  hashAlgorithm, hash:  val_2);
                if(this.mBuf == null)
            {
                    return (System.Byte[])Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest:  val_3);
            }
            
                this.mBuf.UpdateDigest(d:  val_3);
                return (System.Byte[])Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest:  val_3);
            }
            
            }
            
            System.InvalidOperationException val_8 = new System.InvalidOperationException(message:  "HashAlgorithm." + Org.BouncyCastle.Crypto.Tls.HashAlgorithm.GetText(hashAlgorithm:  hashAlgorithm)(Org.BouncyCastle.Crypto.Tls.HashAlgorithm.GetText(hashAlgorithm:  hashAlgorithm)) + " is not being tracked");
        }
        public virtual string get_AlgorithmName()
        {
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Use Fork() to get a definite IDigest");
        }
        public virtual int GetByteLength()
        {
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Use Fork() to get a definite IDigest");
        }
        public virtual int GetDigestSize()
        {
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Use Fork() to get a definite IDigest");
        }
        public virtual void Update(byte input)
        {
            var val_9;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            if(this.mBuf != null)
            {
                    this.mBuf.WriteByte(value:  input);
                return;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_9 = 3;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_9 = 0;
            System.Collections.IEnumerator val_4 = this.mHashes.Values.GetEnumerator();
            label_32:
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_9 = 0;
            if(val_4.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_9 = 1;
            object val_8 = val_4.Current;
            if(val_8 == null)
            {
                goto label_23;
            }
            
            if(val_8 == null)
            {
                goto label_24;
            }
            
            val_14 = null;
            goto label_25;
            label_24:
            val_9 = 0;
            label_23:
            val_14 = null;
            if(val_8 == null)
            {
                goto label_26;
            }
            
            label_25:
            val_15 = val_8;
            if(val_15 != null)
            {
                goto label_27;
            }
            
            val_9 = 0;
            label_26:
            val_15 = 0;
            label_27:
            if(mem[282584257676957] == 0)
            {
                goto label_28;
            }
            
            var val_16 = mem[282584257676847];
            var val_17 = 0;
            val_16 = val_16 + 8;
            label_30:
            if(((mem[282584257676847] + 8) + -8) == val_14)
            {
                goto label_29;
            }
            
            val_17 = val_17 + 1;
            val_16 = val_16 + 16;
            if(val_17 < mem[282584257676957])
            {
                goto label_30;
            }
            
            label_28:
            val_9 = 3;
            goto label_31;
            label_29:
            var val_18 = val_16;
            val_18 = val_18 + 3;
            val_15 = val_15 + val_18;
            val_16 = val_15 + 296;
            label_31:
            val_15.Update(input:  input);
            goto label_32;
            label_17:
            val_17 = 0;
            val_18 = 0;
            if(val_4 != null)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_4.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        public virtual void BlockUpdate(byte[] input, int inOff, int len)
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            if(this.mBuf != null)
            {
                    this.mBuf.Write(buffer:  input, offset:  inOff, count:  len);
                return;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            var val_13 = 0;
            val_13 = val_13 + 1;
            System.Collections.IEnumerator val_4 = this.mHashes.Values.GetEnumerator();
            label_32:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            object val_8 = val_4.Current;
            if(val_8 == null)
            {
                goto label_23;
            }
            
            if(val_8 == null)
            {
                goto label_24;
            }
            
            val_13 = null;
            goto label_25;
            label_24:
            label_23:
            val_13 = null;
            if(val_8 == null)
            {
                goto label_26;
            }
            
            label_25:
            val_14 = val_8;
            if(val_14 != null)
            {
                goto label_27;
            }
            
            label_26:
            val_14 = 0;
            label_27:
            if(mem[282584257676957] == 0)
            {
                goto label_31;
            }
            
            var val_16 = mem[282584257676847];
            var val_17 = 0;
            val_16 = val_16 + 8;
            label_30:
            if(((mem[282584257676847] + 8) + -8) == val_13)
            {
                goto label_29;
            }
            
            val_17 = val_17 + 1;
            val_16 = val_16 + 16;
            if(val_17 < mem[282584257676957])
            {
                goto label_30;
            }
            
            goto label_31;
            label_29:
            var val_18 = val_16;
            val_18 = val_18 + 4;
            val_14 = val_14 + val_18;
            val_15 = val_14 + 296;
            label_31:
            val_14.BlockUpdate(input:  input, inOff:  inOff, length:  len);
            goto label_32;
            label_17:
            val_16 = 0;
            val_17 = 0;
            if(val_4 != null)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_4.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        public virtual int DoFinal(byte[] output, int outOff)
        {
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Use Fork() to get a definite IDigest");
        }
        public virtual void Reset()
        {
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            if(this.mBuf != null)
            {
                    this.mBuf.SetLength(value:  0);
                return;
            }
            
            var val_12 = 0;
            val_12 = val_12 + 1;
            var val_13 = 0;
            val_13 = val_13 + 1;
            System.Collections.IEnumerator val_4 = this.mHashes.Values.GetEnumerator();
            label_32:
            var val_14 = 0;
            val_14 = val_14 + 1;
            if(val_4.MoveNext() == false)
            {
                goto label_17;
            }
            
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_13 = public System.Object System.Collections.IEnumerator::get_Current();
            object val_8 = val_4.Current;
            if(val_8 == null)
            {
                goto label_23;
            }
            
            if(val_8 == null)
            {
                goto label_24;
            }
            
            val_14 = null;
            goto label_25;
            label_24:
            val_13 = 0;
            label_23:
            val_14 = null;
            if(val_8 == null)
            {
                goto label_26;
            }
            
            label_25:
            val_13 = val_14;
            val_15 = val_8;
            if(val_15 != null)
            {
                goto label_27;
            }
            
            val_13 = 0;
            label_26:
            val_15 = 0;
            label_27:
            if(mem[282584257676957] == 0)
            {
                goto label_28;
            }
            
            var val_16 = mem[282584257676847];
            var val_17 = 0;
            val_16 = val_16 + 8;
            label_30:
            if(((mem[282584257676847] + 8) + -8) == val_14)
            {
                goto label_29;
            }
            
            val_17 = val_17 + 1;
            val_16 = val_16 + 16;
            if(val_17 < mem[282584257676957])
            {
                goto label_30;
            }
            
            label_28:
            val_13 = val_14;
            goto label_31;
            label_29:
            var val_18 = val_16;
            val_18 = val_18 + 6;
            val_15 = val_15 + val_18;
            val_16 = val_15 + 296;
            label_31:
            val_15.Reset();
            goto label_32;
            label_17:
            val_17 = 0;
            val_18 = 0;
            if(val_4 != null)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_4.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        protected virtual void CheckStopBuffering()
        {
            Org.BouncyCastle.Crypto.IDigest val_13;
            var val_14;
            var val_15;
            if(this.mBuf == null)
            {
                    return;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            if(this.mHashes.Count > 4)
            {
                    return;
            }
            
            var val_14 = 0;
            val_14 = val_14 + 1;
            var val_15 = 0;
            val_15 = val_15 + 1;
            System.Collections.IEnumerator val_6 = this.mHashes.Values.GetEnumerator();
            label_32:
            var val_16 = 0;
            val_16 = val_16 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_23;
            }
            
            var val_17 = 0;
            val_17 = val_17 + 1;
            object val_10 = val_6.Current;
            if(val_10 == null)
            {
                goto label_29;
            }
            
            val_13 = val_10;
            if(val_13 != null)
            {
                goto label_30;
            }
            
            label_29:
            val_13 = 0;
            label_30:
            this.mBuf.UpdateDigest(d:  val_13);
            goto label_32;
            label_23:
            val_14 = 0;
            val_15 = 0;
            if(val_6 != null)
            {
                    var val_18 = 0;
                val_18 = val_18 + 1;
                val_6.Dispose();
            }
            
            this.mBuf = 0;
        }
        protected virtual void CheckTrackingHash(byte hashAlgorithm)
        {
            byte val_4;
            System.Collections.IDictionary val_5;
            val_4 = hashAlgorithm;
            val_5 = this.mHashes;
            var val_5 = 0;
            val_5 = val_5 + 1;
            if((val_5.Contains(key:  val_4)) == true)
            {
                    return;
            }
            
            val_5 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(hashAlgorithm:  val_4);
            val_4 = val_4;
            var val_6 = 0;
            val_6 = val_6 + 1;
            this.mHashes.set_Item(key:  val_4, value:  val_5);
        }
    
    }

}
