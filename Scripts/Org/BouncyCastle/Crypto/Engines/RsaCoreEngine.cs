using UnityEngine;

namespace Org.BouncyCastle.Crypto.Engines
{
    internal class RsaCoreEngine
    {
        // Fields
        private Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters key;
        private bool forEncryption;
        private int bitSize;
        
        // Methods
        public virtual void Init(bool forEncryption, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            Org.BouncyCastle.Crypto.ICipherParameters val_7 = parameters;
            if(val_7 != null)
            {
                    val_7 = val_7.Parameters;
                if(val_7 != null)
            {
                    this.key = val_7;
                this.forEncryption = forEncryption;
                this.bitSize = val_7.Modulus.BitLength;
                return;
            }
            
            }
            
            Org.BouncyCastle.Security.InvalidKeyException val_6 = new Org.BouncyCastle.Security.InvalidKeyException(message:  "Not an RSA key");
        }
        public virtual int GetInputBlockSize()
        {
            int val_3 = this.bitSize;
            var val_1 = (this.forEncryption == false) ? 7 : (!0);
            val_1 = val_1 + val_3;
            val_3 = val_1 + 7;
            val_1 = (val_1 < 0) ? (val_3) : (val_1);
            return (int)val_1 >> 3;
        }
        public virtual int GetOutputBlockSize()
        {
            int val_3 = this.bitSize;
            var val_1 = (this.forEncryption == true) ? 7 : (!0);
            val_1 = val_1 + val_3;
            val_3 = val_1 + 7;
            val_1 = (val_1 < 0) ? (val_3) : (val_1);
            return (int)val_1 >> 3;
        }
        public virtual Org.BouncyCastle.Math.BigInteger ConvertInput(byte[] inBuf, int inOff, int inLen)
        {
            int val_7 = this.bitSize;
            int val_1 = val_7 + 7;
            val_7 = val_7 + 14;
            var val_2 = (val_1 < 0) ? (val_7) : (val_1);
            val_2 = val_2 >> 3;
            if(val_2 >= inLen)
            {
                    Org.BouncyCastle.Math.BigInteger val_3 = new Org.BouncyCastle.Math.BigInteger(sign:  1, bytes:  inBuf, offset:  inOff, length:  inLen);
                if(((val_3.CompareTo(value:  this.key.Modulus)) & 2147483648) != 0)
            {
                    return val_3;
            }
            
            }
            
            Org.BouncyCastle.Crypto.DataLengthException val_6 = new Org.BouncyCastle.Crypto.DataLengthException(message:  "input too large for RSA cipher.");
        }
        public virtual byte[] ConvertOutput(Org.BouncyCastle.Math.BigInteger result)
        {
            System.Byte[] val_4 = result.ToByteArrayUnsigned();
            if(this.forEncryption == false)
            {
                    return (System.Byte[])val_4;
            }
            
            if(this <= val_1.Length)
            {
                    return (System.Byte[])val_4;
            }
            
            byte[] val_2 = new byte[1358168624];
            val_4.CopyTo(array:  val_2, index:  val_2.Length - val_1.Length);
            val_4 = val_2;
            return (System.Byte[])val_4;
        }
        public virtual Org.BouncyCastle.Math.BigInteger ProcessBlock(Org.BouncyCastle.Math.BigInteger input)
        {
            if(this.key != null)
            {
                    Org.BouncyCastle.Math.BigInteger val_1 = this.key.P;
                Org.BouncyCastle.Math.BigInteger val_2 = this.key.Q;
                Org.BouncyCastle.Math.BigInteger val_9 = input.Remainder(n:  val_2).ModPow(e:  this.key.DQ, m:  val_2);
                return (Org.BouncyCastle.Math.BigInteger)input.Remainder(n:  val_1).ModPow(e:  this.key.DP, m:  val_1).Subtract(n:  val_9).Multiply(val:  this.key.QInv).Mod(m:  val_1).Multiply(val:  val_2).Add(value:  val_9);
            }
            
            if(input != null)
            {
                    return input.ModPow(e:  this.key.Exponent, m:  this.key.Modulus);
            }
            
            return input.ModPow(e:  this.key.Exponent, m:  this.key.Modulus);
        }
        public RsaCoreEngine()
        {
        
        }
    
    }

}
