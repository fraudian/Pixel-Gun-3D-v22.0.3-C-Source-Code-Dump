using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public class HMacDsaKCalculator : IDsaKCalculator
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Macs.HMac hMac;
        private readonly byte[] K;
        private readonly byte[] V;
        private Org.BouncyCastle.Math.BigInteger n;
        
        // Properties
        public virtual bool IsDeterministic { get; }
        
        // Methods
        public HMacDsaKCalculator(Org.BouncyCastle.Crypto.IDigest digest)
        {
            this.hMac = new Org.BouncyCastle.Crypto.Macs.HMac(digest:  digest);
            this.V = new byte[-541661008];
            this.K = new byte[0];
        }
        public virtual bool get_IsDeterministic()
        {
            return true;
        }
        public virtual void Init(Org.BouncyCastle.Math.BigInteger n, Org.BouncyCastle.Security.SecureRandom random)
        {
            System.InvalidOperationException val_1 = new System.InvalidOperationException(message:  "Operation not supported");
        }
        public void Init(Org.BouncyCastle.Math.BigInteger n, Org.BouncyCastle.Math.BigInteger d, byte[] message)
        {
            System.Array val_23;
            Org.BouncyCastle.Math.BigInteger val_24;
            this.n = n;
            Org.BouncyCastle.Utilities.Arrays.Fill(buf:  this.V, b:  1);
            Org.BouncyCastle.Utilities.Arrays.Fill(buf:  this.K, b:  0);
            int val_1 = n.BitLength;
            int val_2 = val_1 + 7;
            var val_5 = ((val_2 < 0) ? (val_1 + 14) : (val_2)) >> 3;
            byte[] val_6 = new byte[0];
            val_23 = Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(n:  d);
            if(val_6 == null)
            {
                goto label_2;
            }
            
            label_32:
            System.Array.Copy(sourceArray:  val_23, sourceIndex:  0, destinationArray:  val_6, destinationIndex:  val_6.Length - val_7.Length, length:  val_7.Length);
            int val_9 = n.BitLength;
            int val_10 = val_9 + 7;
            var val_13 = ((val_10 < 0) ? (val_9 + 14) : (val_10)) >> 3;
            byte[] val_14 = new byte[0];
            val_24 = this.BitsToInt(t:  message);
            if(((val_24.CompareTo(value:  n)) & 2147483648) == 0)
            {
                    val_24 = val_24.Subtract(n:  n);
            }
            
            System.Byte[] val_18 = Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(n:  val_24);
            if(val_14 == null)
            {
                goto label_8;
            }
            
            label_34:
            System.Array.Copy(sourceArray:  val_18, sourceIndex:  0, destinationArray:  val_14, destinationIndex:  val_14.Length - val_18.Length, length:  val_18.Length);
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_20 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  this.K);
            if(this.V == null)
            {
                goto label_11;
            }
            
            label_36:
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_21 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  this.K);
            if(this.V == null)
            {
                goto label_18;
            }
            
            label_38:
            if(this.V == null)
            {
                goto label_21;
            }
            
            label_40:
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_22 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  this.K);
            if(this.V == null)
            {
                goto label_28;
            }
            
            label_42:
            val_23 = ???;
            goto typeof(Org.BouncyCastle.Crypto.Macs.HMac).__il2cppRuntimeField_238;
            label_2:
            if(val_23 != 0)
            {
                goto label_32;
            }
            
            goto label_32;
            label_8:
            if(val_18 != null)
            {
                goto label_34;
            }
            
            goto label_34;
            label_11:
            if(this.hMac != null)
            {
                goto label_36;
            }
            
            goto label_36;
            label_18:
            if(this.hMac != null)
            {
                goto label_38;
            }
            
            goto label_38;
            label_21:
            if(this.hMac != null)
            {
                goto label_40;
            }
            
            goto label_40;
            label_28:
            if(this.hMac != null)
            {
                goto label_42;
            }
            
            goto label_42;
        }
        public virtual Org.BouncyCastle.Math.BigInteger NextK()
        {
            System.Byte[] val_13;
            var val_14;
            int val_1 = this.n.BitLength;
            int val_2 = val_1 + 7;
            var val_5 = ((val_2 < 0) ? (val_1 + 14) : (val_2)) >> 3;
            byte[] val_6 = new byte[0];
            goto label_11;
            label_31:
            if(this.V == null)
            {
                goto label_3;
            }
            
            label_13:
            val_13 = this.K;
            Org.BouncyCastle.Crypto.Parameters.KeyParameter val_7 = new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  val_13);
            if(this.V == null)
            {
                goto label_8;
            }
            
            label_15:
            if(this.hMac != null)
            {
                goto label_11;
            }
            
            goto label_11;
            label_3:
            if(this.hMac != null)
            {
                goto label_13;
            }
            
            goto label_13;
            label_8:
            if(this.hMac != null)
            {
                goto label_15;
            }
            
            goto label_15;
            label_11:
            val_14 = 0;
            goto label_23;
            label_27:
            if(this.V == null)
            {
                goto label_17;
            }
            
            label_25:
            val_13 = this.V;
            int val_9 = System.Math.Min(val1:  val_6.Length - val_14, val2:  this.V.Length);
            System.Array.Copy(sourceArray:  this.V, sourceIndex:  0, destinationArray:  val_6, destinationIndex:  0, length:  val_9);
            val_14 = val_9 + val_14;
            goto label_23;
            label_17:
            if(this.hMac != null)
            {
                goto label_25;
            }
            
            goto label_25;
            label_23:
            if(val_14 < val_6.Length)
            {
                goto label_27;
            }
            
            Org.BouncyCastle.Math.BigInteger val_10 = this.BitsToInt(t:  val_6);
            if((val_10.SignValue < 1) || (((val_10.CompareTo(value:  this.n)) & 2147483648) == 0))
            {
                goto label_31;
            }
            
            return val_10;
        }
        private Org.BouncyCastle.Math.BigInteger BitsToInt(byte[] t)
        {
            Org.BouncyCastle.Math.BigInteger val_1 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  t);
            int val_5 = t.Length;
            val_5 = val_5 << 3;
            if(val_5 <= this.n.BitLength)
            {
                    return val_1;
            }
            
            int val_6 = t.Length;
            val_6 = val_6 << 3;
            return val_1.ShiftRight(n:  val_6 - this.n.BitLength);
        }
    
    }

}
