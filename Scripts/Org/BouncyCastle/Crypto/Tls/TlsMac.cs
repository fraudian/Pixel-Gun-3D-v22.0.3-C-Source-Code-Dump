using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class TlsMac
    {
        // Fields
        protected readonly Org.BouncyCastle.Crypto.Tls.TlsContext context;
        protected readonly byte[] secret;
        protected readonly Org.BouncyCastle.Crypto.IMac mac;
        protected readonly int digestBlockSize;
        protected readonly int digestOverhead;
        protected readonly int macLength;
        
        // Properties
        public virtual byte[] MacSecret { get; }
        public virtual int Size { get; }
        
        // Methods
        public TlsMac(Org.BouncyCastle.Crypto.Tls.TlsContext context, Org.BouncyCastle.Crypto.IDigest digest, byte[] key, int keyOff, int keyLen)
        {
            int val_14;
            int val_15;
            int val_16;
            var val_17;
            Org.BouncyCastle.Crypto.IMac val_19;
            this.context = context;
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_1 = null;
            val_14 = keyOff;
            val_1 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  key, keyOff:  val_14, keyLen:  keyLen);
            this.secret = Org.BouncyCastle.Utilities.Arrays.Clone(data:  val_1.GetKey());
            if(digest != null)
            {
                    val_15 = 8;
                val_16 = 64;
                var val_4 = (((Org.BouncyCastle.Crypto.IDigest.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Crypto.Digests.LongDigest.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 128 : (val_16);
                var val_5 = (((Org.BouncyCastle.Crypto.IDigest.__il2cppRuntimeField_typeHierarchy + (Org.BouncyCastle.Crypto.Digests.LongDigest.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 16 : (val_15);
            }
            else
            {
                    val_15 = 8;
                val_16 = 64;
            }
            
            this.digestBlockSize = val_16;
            this.digestOverhead = val_15;
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context:  context)) == false)
            {
                goto label_7;
            }
            
            val_17 = this;
            this.mac = new Org.BouncyCastle.Crypto.Tls.Ssl3Mac(digest:  digest);
            var val_15 = 0;
            val_15 = val_15 + 1;
            val_14 = 1;
            goto label_12;
            label_7:
            Org.BouncyCastle.Crypto.Macs.HMac val_8 = null;
            val_14 = 0;
            val_19 = val_8;
            val_8 = new Org.BouncyCastle.Crypto.Macs.HMac(digest:  digest);
            val_17 = this;
            this.mac = val_19;
            if(val_19 != null)
            {
                goto label_16;
            }
            
            goto label_14;
            label_12:
            if(digest.GetDigestSize() == 20)
            {
                    this.digestOverhead = 4;
            }
            
            val_19 = this.mac;
            if(val_19 != null)
            {
                goto label_16;
            }
            
            label_14:
            label_16:
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_14 = 0;
            val_8.Init(parameters:  val_1);
            if(mem[1152921505522802704] != 0)
            {
                    var val_17 = 0;
                do
            {
                val_17 = val_17 + 1;
            }
            while(val_17 < mem[1152921505522802704]);
            
            }
            
            this.macLength = val_8.GetMacSize();
            var val_18 = 0;
            val_18 = val_18 + 1;
            Org.BouncyCastle.Crypto.Tls.SecurityParameters val_13 = context.SecurityParameters;
            if(val_13.truncatedHMac == false)
            {
                    return;
            }
            
            this.macLength = System.Math.Min(val1:  this.macLength, val2:  10);
        }
        public virtual byte[] get_MacSecret()
        {
            return (System.Byte[])this.secret;
        }
        public virtual int get_Size()
        {
            return (int)this.macLength;
        }
        public virtual byte[] CalculateMac(long seqNo, byte type, byte[] message, int offset, int length)
        {
            var val_10 = 0;
            val_10 = val_10 + 1;
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion val_2 = this.context.ServerVersion;
            bool val_3 = val_2.IsSsl;
            var val_4 = (val_3 != true) ? 11 : 13;
            byte[] val_5 = new byte[0];
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint64(i:  seqNo, buf:  val_5, offset:  0);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  type, buf:  val_5, offset:  8);
            if(val_3 != true)
            {
                    Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteVersion(version:  val_2, buf:  val_5, offset:  9);
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  length, buf:  val_5, offset:  val_5.Length - 2);
            if(val_5 == null)
            {
                goto label_15;
            }
            
            label_22:
            var val_11 = 0;
            val_11 = val_11 + 1;
            goto label_20;
            label_15:
            if(this.mac != null)
            {
                goto label_22;
            }
            
            goto label_22;
            label_20:
            this.mac.BlockUpdate(input:  val_5, inOff:  0, len:  val_5.Length);
            var val_12 = 0;
            val_12 = val_12 + 1;
            this.mac.BlockUpdate(input:  message, inOff:  offset, len:  length);
            System.Byte[] val_9 = Org.BouncyCastle.Security.MacUtilities.DoFinal(mac:  this.mac);
            goto typeof(Org.BouncyCastle.Crypto.Tls.TlsMac).__il2cppRuntimeField_1B8;
        }
        public virtual byte[] CalculateMacConstantTime(long seqNo, byte type, byte[] message, int offset, int length, int fullLength, byte[] dummyData)
        {
            var val_8;
            var val_9;
            Org.BouncyCastle.Crypto.IMac val_10;
            val_8 = type;
            var val_2 = ((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(context:  this.context)) != true) ? 11 : 13;
            int val_3 = val_2 + fullLength;
            int val_4 = val_2 + length;
            val_10 = this.mac;
            if(((-1) & 2147483648) == 0)
            {
                    val_8 = 1152921505522872320;
                do
            {
                var val_8 = 0;
                val_8 = val_8 + 1;
                val_9 = 0;
                val_10.BlockUpdate(input:  dummyData, inOff:  0, len:  this.digestBlockSize);
                val_10 = this.mac;
            }
            while(((-2) & 2147483648) == 0);
            
            }
            
            if(dummyData.Length == 0)
            {
                    val_9 = 0;
            }
            
            var val_10 = 0;
            val_10 = val_10 + 1;
            val_9 = 3;
            val_10.Update(input:  dummyData[0]);
            var val_11 = 0;
            val_11 = val_11 + 1;
            this.mac.Reset();
            return (System.Byte[])this;
        }
        protected virtual int GetDigestBlockCount(int inputLength)
        {
            int val_2 = this.digestOverhead;
            val_2 = val_2 + inputLength;
            return (int)val_2 / this.digestBlockSize;
        }
        protected virtual byte[] Truncate(byte[] bs)
        {
            if(this.macLength >= bs.Length)
            {
                    return (System.Byte[])bs;
            }
            
            return Org.BouncyCastle.Utilities.Arrays.CopyOf(data:  bs, newLength:  this.macLength);
        }
    
    }

}
