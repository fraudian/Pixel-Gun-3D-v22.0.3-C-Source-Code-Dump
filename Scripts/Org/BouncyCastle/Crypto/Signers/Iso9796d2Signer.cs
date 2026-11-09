using UnityEngine;

namespace Org.BouncyCastle.Crypto.Signers
{
    public class Iso9796d2Signer : ISignerWithRecovery, ISigner
    {
        // Fields
        public const int TrailerImplicit = 188;
        public const int TrailerRipeMD160 = 12748;
        public const int TrailerRipeMD128 = 13004;
        public const int TrailerSha1 = 13260;
        public const int TrailerSha256 = 13516;
        public const int TrailerSha512 = 13772;
        public const int TrailerSha384 = 14028;
        public const int TrailerWhirlpool = 14284;
        private Org.BouncyCastle.Crypto.IDigest digest;
        private Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher;
        private int trailer;
        private int keyBits;
        private byte[] block;
        private byte[] mBuf;
        private int messageLength;
        private bool fullMessage;
        private byte[] recoveredMessage;
        private byte[] preSig;
        private byte[] preBlock;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public byte[] GetRecoveredMessage()
        {
            return (System.Byte[])this.recoveredMessage;
        }
        public Iso9796d2Signer(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest digest, bool isImplicit)
        {
            var val_4;
            Org.BouncyCastle.Crypto.IDigest val_5;
            val_4 = isImplicit;
            this.digest = digest;
            this.cipher = cipher;
            if(val_4 == false)
            {
                goto label_1;
            }
            
            val_5 = 188;
            goto label_2;
            label_1:
            val_4 = 1152921505530593280;
            if((Org.BouncyCastle.Crypto.Signers.IsoTrailers.NoTrailerAvailable(digest:  digest)) == true)
            {
                goto label_5;
            }
            
            val_5 = digest;
            label_2:
            this.trailer = Org.BouncyCastle.Crypto.Signers.IsoTrailers.GetTrailer(digest:  val_5);
            return;
            label_5:
            System.ArgumentException val_3 = new System.ArgumentException(message:  "no valid trailer", paramName:  "digest");
        }
        public Iso9796d2Signer(Org.BouncyCastle.Crypto.IAsymmetricBlockCipher cipher, Org.BouncyCastle.Crypto.IDigest digest)
        {
        
        }
        public virtual string get_AlgorithmName()
        {
            var val_3 = 0;
            val_3 = val_3 + 1;
            return this.digest.AlgorithmName + "withISO9796-2S1"("withISO9796-2S1");
        }
        public virtual void Init(bool forSigning, Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            Org.BouncyCastle.Crypto.ICipherParameters val_15 = parameters;
            if(val_15 != null)
            {
                    val_15 = 0;
            }
            
            var val_16 = 0;
            val_16 = val_16 + 1;
            this.cipher.Init(forEncryption:  forSigning, parameters:  val_15);
            int val_5 = 28563616.BitLength;
            this.keyBits = val_5;
            int val_6 = val_5 + 7;
            var val_9 = ((val_6 < 0) ? (val_5 + 14) : (val_6)) >> 3;
            this.block = new byte[0];
            var val_17 = 0;
            val_17 = val_17 + 1;
            var val_13 = (this.trailer == 188) ? ((-3) + 1) : -3;
            val_13 = val_13 - this.digest.GetDigestSize();
            int val_14 = val_13 + val_10.Length;
            this.mBuf = new byte[0];
        }
        private bool IsSameAs(byte[] a, byte[] b)
        {
            System.Byte[] val_2;
            int val_3;
            var val_4;
            val_2 = this.mBuf;
            if(this.messageLength <= this.mBuf.Length)
            {
                goto label_1;
            }
            
            if(this.mBuf == null)
            {
                goto label_2;
            }
            
            label_18:
            if(this.mBuf.Length > b.Length)
            {
                goto label_9;
            }
            
            val_3 = this.mBuf.Length;
            if(val_3 != 0)
            {
                goto label_6;
            }
            
            goto label_10;
            label_1:
            val_3 = b.Length;
            if(this.messageLength != val_3)
            {
                goto label_9;
            }
            
            if(val_3 == 0)
            {
                goto label_10;
            }
            
            label_6:
            do
            {
                val_2 = 0 + 1;
                val_4 = 1 & ((a[0] == b[0]) ? 1 : 0);
            }
            while(val_3 != val_2);
            
            return (bool)val_4;
            label_9:
            val_4 = 0;
            return (bool)val_4;
            label_2:
            if(b != null)
            {
                goto label_18;
            }
            
            goto label_18;
            label_10:
            val_4 = 1;
            return (bool)val_4;
        }
        private void ClearBlock(byte[] block)
        {
            System.Array.Clear(array:  block, index:  0, length:  block.Length);
        }
        public virtual void UpdateWithRecoveredMessage(byte[] signature)
        {
            var val_19;
            int val_20;
            var val_21;
            var val_24;
            string val_26;
            if(signature == null)
            {
                goto label_1;
            }
            
            label_8:
            var val_18 = 0;
            val_18 = val_18 + 1;
            goto label_6;
            label_1:
            if(this.cipher != null)
            {
                goto label_8;
            }
            
            goto label_8;
            label_6:
            System.Byte[] val_2 = this.cipher.ProcessBlock(inBuf:  signature, inOff:  0, inLen:  signature.Length);
            byte val_19 = val_2[0];
            val_19 = val_19 & 192;
            if(val_19 != 64)
            {
                goto label_13;
            }
            
            var val_20 = -4294967296;
            val_20 = val_20 + ((val_2.Length) << 32);
            byte val_21 = val_2[val_20 >> 32];
            val_21 = val_21 & 15;
            if(val_21 != 12)
            {
                goto label_13;
            }
            
            var val_22 = -4294967296;
            val_22 = val_22 + ((val_2.Length) << 32);
            if((val_2[val_22 >> 32]) != 188)
            {
                goto label_15;
            }
            
            val_19 = 1;
            goto label_16;
            label_15:
            val_20 = val_2.Length;
            var val_24 = -8589934592;
            val_24 = val_24 + ((val_2.Length) << 32);
            if(val_20 <= 1)
            {
                    val_20 = val_2.Length;
            }
            
            byte val_25 = val_2[val_24 >> 32];
            var val_26 = -4294967296;
            val_26 = val_26 + ((val_2.Length) << 32);
            byte val_27 = val_2[val_26 >> 32];
            if((Org.BouncyCastle.Crypto.Signers.IsoTrailers.NoTrailerAvailable(digest:  this.digest)) == true)
            {
                goto label_21;
            }
            
            if(val_27 != (Org.BouncyCastle.Crypto.Signers.IsoTrailers.GetTrailer(digest:  this.digest)))
            {
                goto label_24;
            }
            
            val_19 = 2;
            label_16:
            if(val_2.Length == 0)
            {
                goto label_25;
            }
            
            val_21 = 0;
            label_28:
            byte val_28 = val_2[0];
            val_28 = val_28 & 15;
            if(val_28 == 10)
            {
                goto label_29;
            }
            
            val_21 = val_21 + 1;
            if(val_21 != val_2.Length)
            {
                goto label_28;
            }
            
            goto label_29;
            label_25:
            val_21 = 0;
            label_29:
            var val_29 = 0;
            val_29 = val_29 + 1;
            var val_30 = val_21;
            val_30 = val_30 - val_19;
            val_30 = val_30 - this.digest.GetDigestSize();
            val_19 = val_30 + val_2.Length;
            if(val_19 <= 0)
            {
                goto label_35;
            }
            
            if((val_2[0] & 32) == 0)
            {
                    this.fullMessage = true;
            }
            else
            {
                    this.fullMessage = false;
            }
            
            byte[] val_12 = new byte[0];
            this.recoveredMessage = val_12;
            System.Array.Copy(sourceArray:  val_2, sourceIndex:  val_21 + 1, destinationArray:  val_12, destinationIndex:  0, length:  val_12.Length);
            this.preSig = signature;
            this.preBlock = val_2;
            if(this.recoveredMessage == null)
            {
                goto label_40;
            }
            
            label_47:
            var val_32 = 0;
            val_32 = val_32 + 1;
            goto label_45;
            label_40:
            if(this.digest != null)
            {
                goto label_47;
            }
            
            goto label_47;
            label_45:
            this.digest.BlockUpdate(input:  this.recoveredMessage, inOff:  0, length:  this.recoveredMessage.Length);
            val_24 = mem[this.recoveredMessage];
            if(mem[this.recoveredMessage] == 0)
            {
                    val_24 = mem[this.recoveredMessage];
            }
            
            this.messageLength = mem[this.recoveredMessage] + 24;
            val_24.CopyTo(array:  this.mBuf, index:  0);
            return;
            label_13:
            val_26 = "malformed signature";
            goto label_50;
            label_35:
            val_26 = "malformed block";
            label_50:
            null = new Org.BouncyCastle.Crypto.InvalidCipherTextException(message:  val_26);
            label_51:
            label_52:
            label_21:
            System.ArgumentException val_15 = new System.ArgumentException(message:  "unrecognised hash in signature");
            goto label_51;
            label_24:
            System.InvalidOperationException val_17 = new System.InvalidOperationException(message:  "signer initialised with wrong digest for trailer " + val_27);
            goto label_52;
        }
        public virtual void Update(byte input)
        {
            int val_3;
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.Update(input:  input);
            val_3 = this.messageLength;
            if(val_3 < this.mBuf.Length)
            {
                    val_3 = this.mBuf;
                val_3[this.messageLength] = input;
            }
            
            int val_3 = this.messageLength;
            val_3 = val_3 + 1;
            this.messageLength = val_3;
        }
        public virtual void BlockUpdate(byte[] input, int inOff, int length)
        {
            int val_3;
            int val_4;
            val_3 = inOff;
            if(length < 1)
            {
                goto label_3;
            }
            
            label_6:
            if(this.messageLength >= this.mBuf.Length)
            {
                goto label_3;
            }
            
            byte val_2 = input[(long)val_3];
            val_4 = length - 1;
            val_3 = val_3 + 1;
            if(length >= 2)
            {
                goto label_6;
            }
            
            goto label_7;
            label_3:
            val_4 = length;
            label_7:
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.digest.BlockUpdate(input:  input, inOff:  val_3, length:  val_4);
            int val_4 = this.messageLength;
            val_4 = val_4 + val_4;
            this.messageLength = val_4;
        }
        public virtual void Reset()
        {
            var val_2 = 0;
            val_2 = val_2 + 1;
            this.digest.Reset();
            this.messageLength = 0;
            this.digest.ClearBlock(block:  this.mBuf);
            if(this.recoveredMessage != null)
            {
                    this.digest.ClearBlock(block:  this.recoveredMessage);
            }
            
            this.recoveredMessage = 0;
            this.fullMessage = false;
            if(this.preSig == null)
            {
                    return;
            }
            
            this.preSig = 0;
            this.digest.ClearBlock(block:  this.preBlock);
            this.preBlock = 0;
        }
        public virtual byte[] GenerateSignature()
        {
            int val_15;
            var val_18;
            System.Byte[] val_19;
            var val_20;
            int val_22;
            int val_23;
            int val_24;
            int val_25;
            var val_26;
            var val_27;
            System.Byte[] val_28;
            var val_29;
            var val_15 = 0;
            val_15 = val_15 + 1;
            int val_2 = this.digest.GetDigestSize();
            int val_16 = this.block.Length;
            val_16 = val_16 - val_2;
            if(this.trailer != 188)
            {
                goto label_7;
            }
            
            val_15 = val_16 - 1;
            var val_17 = 0;
            val_17 = val_17 + 1;
            goto label_12;
            label_7:
            val_15 = val_16 - 2;
            var val_18 = 0;
            val_18 = val_18 + 1;
            goto label_17;
            label_12:
            val_18 = this.digest;
            int val_4 = val_18.DoFinal(output:  this.block, outOff:  val_15);
            if(this.block == null)
            {
                    val_18 = 0;
            }
            
            var val_19 = -4294967296;
            val_19 = val_19 + ((this.block.Length) << 32);
            val_19 = val_19 >> 32;
            val_20 = 8;
            val_22 = 188;
            goto label_20;
            label_17:
            val_18 = this.digest;
            int val_6 = val_18.DoFinal(output:  this.block, outOff:  val_15);
            if(this.block != null)
            {
                    val_23 = this.trailer;
            }
            else
            {
                    val_23 = this.trailer;
                val_18 = 0;
            }
            
            var val_20 = -8589934592;
            val_20 = val_20 + ((this.block.Length) << 32);
            this.block[val_20 >> 32] = val_23 >> 8;
            val_19 = this.block;
            if(val_19 != null)
            {
                    val_22 = this.trailer;
            }
            else
            {
                    val_22 = this.trailer;
                val_18 = 0;
            }
            
            var val_21 = -4294967296;
            val_21 = val_21 + ((this.block.Length) << 32);
            val_20 = 16;
            label_20:
            mem2[0] = val_22;
            val_24 = this.messageLength;
            int val_22 = this.keyBits;
            val_20 = val_20 + ((val_24 + val_2) << 3);
            val_20 = val_20 | 4;
            val_20 = val_20 - val_22;
            if(val_20 >= 1)
            {
                    val_22 = val_20 + 7;
                val_20 = val_20 + 14;
                val_24 = val_24 - (((val_22 < 0) ? (val_20) : (val_22)) >> 3);
                val_25 = val_15 - val_24;
                System.Array.Copy(sourceArray:  this.mBuf, sourceIndex:  0, destinationArray:  this.block, destinationIndex:  val_25, length:  val_24);
                val_26 = 96;
            }
            else
            {
                    val_25 = val_15 - val_24;
                System.Array.Copy(sourceArray:  this.mBuf, sourceIndex:  0, destinationArray:  this.block, destinationIndex:  val_25, length:  val_24);
                val_26 = 64;
            }
            
            val_25 = val_25 - 1;
            if(val_25 < 1)
            {
                goto label_29;
            }
            
            val_19 = 187;
            val_27 = val_25;
            goto label_30;
            label_33:
            int val_12 = val_22 + (long)val_27;
            val_27 = val_27 - 1;
            mem2[0] = 187;
            label_30:
            if(val_27 != 0)
            {
                goto label_33;
            }
            
            byte val_23 = this.block[(long)val_25];
            val_23 = val_23 ^ 1;
            this.block[(long)val_25] = val_23;
            val_28 = this.block;
            val_29 = 11;
            goto label_37;
            label_29:
            val_28 = this.block;
            val_29 = 10;
            label_37:
            val_28[0] = 10;
            byte val_24 = this.block[0];
            val_24 = val_24 | val_26;
            this.block[0] = val_24;
            if(this.block == null)
            {
                goto label_42;
            }
            
            if(this.cipher != null)
            {
                goto label_48;
            }
            
            label_49:
            label_48:
            var val_25 = 0;
            val_25 = val_25 + 1;
            goto label_47;
            label_42:
            if(this.cipher != null)
            {
                goto label_48;
            }
            
            goto label_49;
            label_47:
            System.Byte[] val_14 = this.cipher.ProcessBlock(inBuf:  this.block, inOff:  0, inLen:  this.block.Length);
            val_14.ClearBlock(block:  this.mBuf);
            val_14.ClearBlock(block:  this.block);
            return val_14;
        }
        public virtual bool VerifySignature(byte[] signature)
        {
            Org.BouncyCastle.Crypto.IAsymmetricBlockCipher val_31;
            var val_32;
            System.Byte[] val_33;
            var val_35;
            int val_36;
            var val_37;
            var val_38;
            int val_40;
            var val_43;
            byte val_45;
            byte val_48;
            var val_49;
            val_31 = this;
            if(this.preSig == null)
            {
                goto label_1;
            }
            
            val_32 = 0;
            if((Org.BouncyCastle.Utilities.Arrays.AreEqual(a:  this.preSig, b:  signature)) == false)
            {
                goto label_2;
            }
            
            val_33 = this.preBlock;
            this.preSig = 0;
            this.preBlock = 0;
            if(val_33 != null)
            {
                goto label_4;
            }
            
            goto label_4;
            label_1:
            val_31 = this.cipher;
            var val_30 = 0;
            val_30 = val_30 + 1;
            val_32 = 0;
            System.Byte[] val_3 = val_31.ProcessBlock(inBuf:  signature, inOff:  0, inLen:  signature.Length);
            val_33 = val_3;
            label_4:
            if(val_3.Length == 0)
            {
                    val_32 = 0;
            }
            
            byte val_31 = val_33[0];
            val_31 = val_31 & 192;
            if(val_31 != 64)
            {
                goto label_81;
            }
            
            var val_32 = -4294967296;
            val_32 = val_32 + ((val_3.Length) << 32);
            val_31 = val_32 >> 32;
            if(val_3.Length == 0)
            {
                    val_32 = 0;
            }
            
            byte val_33 = val_33[val_31];
            val_33 = val_33 & 15;
            if(val_33 != 12)
            {
                goto label_81;
            }
            
            var val_34 = -4294967296;
            val_34 = val_34 + ((val_3.Length) << 32);
            if(val_3.Length == 0)
            {
                    val_32 = 0;
            }
            
            if((val_33[val_34 >> 32]) != 188)
            {
                goto label_17;
            }
            
            val_35 = 1;
            goto label_18;
            label_17:
            val_36 = val_3.Length;
            var val_36 = -8589934592;
            val_36 = val_36 + ((val_3.Length) << 32);
            if(val_36 <= 1)
            {
                    val_32 = 0;
                val_36 = val_3.Length;
            }
            
            byte val_37 = val_33[val_36 >> 32];
            var val_38 = -4294967296;
            val_38 = val_38 + ((val_3.Length) << 32);
            if(val_36 == 0)
            {
                    val_32 = 0;
            }
            
            byte val_39 = val_33[val_38 >> 32];
            if((Org.BouncyCastle.Crypto.Signers.IsoTrailers.NoTrailerAvailable(digest:  this.digest)) == true)
            {
                goto label_23;
            }
            
            if(val_39 != (Org.BouncyCastle.Crypto.Signers.IsoTrailers.GetTrailer(digest:  this.digest)))
            {
                goto label_26;
            }
            
            val_35 = 2;
            label_18:
            if(val_3.Length == 0)
            {
                goto label_27;
            }
            
            val_37 = 0;
            label_30:
            if(val_37 >= val_3.Length)
            {
                    val_32 = 0;
            }
            
            byte val_40 = val_33[0];
            val_40 = val_40 & 15;
            if(val_40 == 10)
            {
                goto label_31;
            }
            
            val_37 = val_37 + 1;
            if(val_37 != val_3.Length)
            {
                goto label_30;
            }
            
            goto label_31;
            label_27:
            val_37 = 0;
            label_31:
            val_38 = 1152921505522765824;
            var val_41 = 0;
            val_41 = val_41 + 1;
            val_32 = 1;
            int val_10 = this.digest.GetDigestSize();
            byte[] val_11 = new byte[0];
            val_31 = val_37 + 1;
            int val_13 = (val_3.Length - val_35) - val_11.Length;
            val_40 = val_13 - val_31;
            if(val_40 <= 0)
            {
                goto label_81;
            }
            
            if(val_3.Length == 0)
            {
                    val_32 = 0;
            }
            
            if((val_33[0] & 32) != 0)
            {
                goto label_41;
            }
            
            this.fullMessage = true;
            if(this.messageLength > val_40)
            {
                goto label_81;
            }
            
            var val_43 = 0;
            val_43 = val_43 + 1;
            val_32 = 6;
            goto label_47;
            label_41:
            this.fullMessage = false;
            var val_44 = 0;
            val_44 = val_44 + 1;
            int val_15 = this.digest.DoFinal(output:  val_11, outOff:  0);
            val_38 = 0;
            val_43 = 1;
            goto label_53;
            label_59:
            val_31 = val_33[(long)val_13 + val_38];
            val_40 = 0;
            val_45 = val_11[val_40] ^ val_31;
            mem2[0] = val_45;
            if(((long)val_13 + val_38) >= val_3.Length)
            {
                    val_45 = mem[val_3[(long)(int)((((val_3.Length - val_35) - val_11.Length) + val_38))] + 32];
                val_45 = val_3[(long)(int)((((val_3.Length - val_35) - val_11.Length) + val_38))] + 32;
            }
            
            val_43 = val_43 & (((val_45 & 255) != 0) ? 1 : 0);
            val_38 = 1;
            label_53:
            if(val_38 != val_11.Length)
            {
                goto label_59;
            }
            
            goto label_60;
            label_47:
            this.digest.Reset();
            var val_46 = 0;
            val_46 = val_46 + 1;
            val_32 = 4;
            this.digest.BlockUpdate(input:  val_33, inOff:  val_31, length:  val_40);
            var val_47 = 0;
            val_47 = val_47 + 1;
            int val_21 = this.digest.DoFinal(output:  val_11, outOff:  0);
            val_38 = 0;
            val_43 = 1;
            goto label_71;
            label_77:
            val_31 = val_33[(long)val_13 + val_38];
            val_40 = 0;
            val_48 = val_11[val_40] ^ val_31;
            mem2[0] = val_48;
            if(((long)val_13 + val_38) >= val_3.Length)
            {
                    val_48 = mem[val_3[(long)(int)((((val_3.Length - val_35) - val_11.Length) + val_38))] + 32];
                val_48 = val_3[(long)(int)((((val_3.Length - val_35) - val_11.Length) + val_38))] + 32;
            }
            
            val_43 = val_43 & (((val_48 & 255) != 0) ? 1 : 0);
            val_38 = 1;
            label_71:
            if(val_38 != val_11.Length)
            {
                goto label_77;
            }
            
            label_60:
            if((val_43 & 1) == 0)
            {
                goto label_81;
            }
            
            byte[] val_24 = new byte[0];
            this.recoveredMessage = val_24;
            System.Array.Copy(sourceArray:  val_33, sourceIndex:  val_31, destinationArray:  val_24, destinationIndex:  0, length:  val_24.Length);
            if(this.messageLength == 0)
            {
                goto label_80;
            }
            
            bool val_25 = this.IsSameAs(a:  this.mBuf, b:  this.recoveredMessage);
            if(val_25 == false)
            {
                goto label_81;
            }
            
            label_80:
            val_25.ClearBlock(block:  this.mBuf);
            val_25.ClearBlock(block:  val_33);
            val_49 = 1;
            return (bool)val_49;
            label_81:
            val_3.ClearBlock(block:  this.mBuf);
            val_3.ClearBlock(block:  val_33);
            val_49 = 0;
            return (bool)val_49;
            label_2:
            System.InvalidOperationException val_26 = new System.InvalidOperationException(message:  "updateWithRecoveredMessage called on different signature");
            label_83:
            label_84:
            label_23:
            System.ArgumentException val_27 = new System.ArgumentException(message:  "unrecognised hash in signature");
            goto label_83;
            label_26:
            System.InvalidOperationException val_29 = new System.InvalidOperationException(message:  "signer initialised with wrong digest for trailer " + val_39);
            goto label_84;
        }
        private bool ReturnFalse(byte[] block)
        {
            this.ClearBlock(block:  this.mBuf);
            this.ClearBlock(block:  block);
            return false;
        }
        public virtual bool HasFullMessage()
        {
            return (bool)this.fullMessage;
        }
    
    }

}
