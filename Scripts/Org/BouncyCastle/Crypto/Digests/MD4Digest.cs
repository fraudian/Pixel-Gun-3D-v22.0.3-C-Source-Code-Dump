using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class MD4Digest : GeneralDigest
    {
        // Fields
        private const int DigestLength = 16;
        private int H1;
        private int H2;
        private int H3;
        private int H4;
        private int[] X;
        private int xOff;
        private const int S11 = 3;
        private const int S12 = 7;
        private const int S13 = 11;
        private const int S14 = 19;
        private const int S21 = 3;
        private const int S22 = 5;
        private const int S23 = 9;
        private const int S24 = 13;
        private const int S31 = 3;
        private const int S32 = 9;
        private const int S33 = 11;
        private const int S34 = 15;
        
        // Properties
        public override string AlgorithmName { get; }
        
        // Methods
        public MD4Digest()
        {
            this.X = new int[16];
            goto typeof(Org.BouncyCastle.Crypto.Digests.MD4Digest).__il2cppRuntimeField_1F8;
        }
        public MD4Digest(Org.BouncyCastle.Crypto.Digests.MD4Digest t)
        {
            this.X = new int[16];
            Org.BouncyCastle.Crypto.Digests.MD4Digest val_2 = t;
            val_2 = new Org.BouncyCastle.Crypto.Digests.GeneralDigest(t:  val_2);
            this.CopyIn(t:  t);
        }
        private void CopyIn(Org.BouncyCastle.Crypto.Digests.MD4Digest t)
        {
            t.CopyIn(t:  t);
            if(t == null)
            {
                goto label_0;
            }
            
            this.H1 = t.H1;
            this.H2 = t.H2;
            this.H3 = t.H3;
            this.H4 = t.H4;
            if(t.X != null)
            {
                goto label_3;
            }
            
            label_4:
            label_3:
            System.Array.Copy(sourceArray:  t.X, sourceIndex:  0, destinationArray:  this.X, destinationIndex:  0, length:  t.X.Length);
            this.xOff = t.xOff;
            return;
            label_0:
            this.H1 = 135970152;
            this.H2 = 0;
            this.H3 = 0;
            this.H4 = 3670080;
            if(4194311 != 0)
            {
                goto label_3;
            }
            
            goto label_4;
        }
        public override string get_AlgorithmName()
        {
            return "MD4";
        }
        public override int GetDigestSize()
        {
            return 16;
        }
        internal override void ProcessWord(byte[] input, int inOff)
        {
            var val_15;
            System.Int32[] val_16;
            int val_17;
            byte val_18;
            var val_19;
            val_15 = this;
            val_16 = this.X;
            this.xOff = this.xOff + 1;
            val_17 = input.Length;
            if(val_17 <= inOff)
            {
                    val_17 = input.Length;
            }
            
            int val_2 = inOff + 1;
            if(val_2 >= val_17)
            {
                    val_17 = input.Length;
            }
            
            val_18 = input[(long)val_2];
            int val_3 = inOff + 2;
            if(val_3 >= val_17)
            {
                    val_17 = input.Length;
            }
            
            byte val_16 = input[(long)val_3];
            val_19 = (long)inOff + 3;
            byte val_17 = input[val_19];
            val_16[this.xOff] = input[(long)inOff];
            if(this.xOff != 16)
            {
                    return;
            }
            
            val_15 = ???;
            val_19 = ???;
            val_16 = ???;
            val_18 = ???;
            goto typeof(Org.BouncyCastle.Crypto.Digests.MD4Digest).__il2cppRuntimeField_228;
        }
        internal override void ProcessLength(long bitLength)
        {
            long val_1 = bitLength;
            this.X[14] = val_1;
            val_1 = val_1 >> 32;
            this.X[15] = val_1;
        }
        private void UnpackWord(int word, byte[] outBytes, int outOff)
        {
            outBytes[(long)outOff] = word;
            outBytes[(long)outOff + 1] = word >> 8;
            outBytes[(long)outOff + 2] = word >> 16;
            outBytes[(long)outOff + 3] = word >> 24;
        }
        public override int DoFinal(byte[] output, int outOff)
        {
            this.Finish();
            this.UnpackWord(word:  this.H1, outBytes:  output, outOff:  outOff);
            this.UnpackWord(word:  this.H2, outBytes:  output, outOff:  outOff + 4);
            this.UnpackWord(word:  this.H3, outBytes:  output, outOff:  outOff + 8);
            this.UnpackWord(word:  this.H4, outBytes:  output, outOff:  outOff + 12);
            return 16;
        }
        public override void Reset()
        {
            var val_1;
            this.Reset();
            val_1 = 0;
            this.xOff = 0;
            this.H1 = ;
            this.H2 = ;
            this.H3 = 1167088121787636990;
            this.H4 = 271733878;
            goto label_0;
            label_4:
            val_1 = 1;
            this.X[0] = 0;
            label_0:
            if(val_1 != this.X.Length)
            {
                goto label_4;
            }
        
        }
        private int RotateLeft(int x, int n)
        {
            var val_2 = -n;
            val_2 = val_2 & 31;
            return (int)x >> val_2;
        }
        private int F(int u, int v, int w)
        {
            return (int)(w & (~u)) | (v & u);
        }
        private int G(int u, int v, int w)
        {
            int val_1 = w | v;
            val_1 = val_1 & u;
            return (int)val_1 | (w & v);
        }
        private int H(int u, int v, int w)
        {
            return (int)v ^ u ^ w;
        }
        internal override void ProcessBlock()
        {
            var val_242;
            var val_243;
            int val_249 = this.H2;
            int val_247 = this.H3;
            int val_245 = this.H4;
            int val_243 = this.H1;
            int val_1 = val_247 & val_249;
            val_1 = (val_245 & (~val_249)) | val_1;
            val_243 = (val_1 + val_243) + this.X[0];
            int val_4 = val_249 & (((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << 29));
            val_243 = val_243 >> 29;
            val_4 = (val_247 & (~(((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << 29)))) | val_4;
            val_245 = (val_4 + val_245) + this.X[1];
            int val_7 = val_243 & (((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << 29))) | (this.H) << (32-25)) | ((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << 29))) | (this.H) << 25));
            val_245 = val_245 >> 25;
            val_7 = (val_249 & (~(((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << 29))) | (this.H) << (32-25)) | ((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << 29))) | (this.H) << 25)))) | val_7;
            val_247 = (val_7 + val_247) + this.X[2];
            int val_10 = val_245 & (((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) ) << (32-21)) | ((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) ) << 21));
            val_247 = val_247 >> 21;
            val_10 = (val_243 & (~(((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) ) << (32-21)) | ((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) ) << 21)))) | val_10;
            val_249 = (val_10 + val_249) + this.X[3];
            int val_13 = val_247 & ((((((((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]) >> 29) & (~((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]))) << (32-13)) | (((((((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]) >> 29) & (~((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]))) << 13));
            val_249 = val_249 >> 13;
            val_13 = (val_245 & (~((((((((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]) >> 29) & (~((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]))) << (32-13)) | (((((((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]) >> 29) & (~((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]))) << 13)))) | val_13;
            val_243 = (val_13 + val_243) + this.X[4];
            int val_16 = val_249 & ((((((((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << 29))) | (t) << (32-29)) | (((((((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << 29))) | (t) << 29));
            val_243 = val_243 >> 29;
            val_16 = (val_247 & (~((((((((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << 29))) | (t) << (32-29)) | (((((((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << 29))) | (t) << 29)))) | val_16;
            val_245 = (val_16 + val_245) + this.X[5];
            int val_19 = val_243 & ((((((((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[) << (32-25)) | (((((((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[) << 25));
            val_245 = val_245 >> 25;
            val_19 = (val_249 & (~((((((((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[) << (32-25)) | (((((((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[) << 25)))) | val_19;
            val_247 = (val_19 + val_247) + this.X[6];
            int val_22 = val_245 & (((((((((((((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]) >> 29) & (~((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X) << (32-21)) | ((((((((((((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]) >> 29) & (~((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X) << 21));
            val_247 = val_247 >> 21;
            val_22 = (val_243 & (~(((((((((((((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]) >> 29) & (~((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X) << (32-21)) | ((((((((((((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]) >> 29) & (~((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X) << 21)))) | val_22;
            val_249 = (val_22 + val_249) + this.X[7];
            int val_25 = val_247 & (((((((((((((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << 29)))) << (32-13)) | ((((((((((((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << 29)))) << 13));
            val_249 = val_249 >> 13;
            val_25 = (val_245 & (~(((((((((((((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << 29)))) << (32-13)) | ((((((((((((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << 29)))) << 13)))) | val_25;
            val_243 = (val_25 + val_243) + this.X[8];
            int val_28 = val_249 & (((((((((((((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + th) << (32-29)) | ((((((((((((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + th) << 29));
            val_243 = val_243 >> 29;
            val_245 = ((val_247 & (~(((((((((((((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + th) << (32-29)) | ((((((((((((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + th) << 29)))) + val_245) + this.X[9];
            int val_32 = val_243 & ((((((((((((((((((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]) >> 29) & (~((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + t) << (32-25)) | (((((((((((((((((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]) >> 29) & (~((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + t) << 25));
            val_245 = val_245 >> 25;
            int val_36 = (val_249 & (~((((((((((((((((((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]) >> 29) & (~((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + t) << (32-25)) | (((((((((((((((((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]) >> 29) & (~((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + t) << 25)))) + this.X[10];
            int val_37 = val_245 & ((((((((((((((((((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << ) << (32-21)) | (((((((((((((((((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << ) << 21));
            val_36 = val_36 >> 21;
            int val_257 = this.X[11];
            int val_41 = val_243;
            int val_42 = val_36 & ((((((((((((((((((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1)) << (32-13)) | (((((((((((((((((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1)) << 13));
            int val_43 = val_245 & (~((((((((((((((((((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1)) << (32-13)) | (((((((((((((((((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0])) << (32-29)) | ((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1)) << 13)));
            val_41 = val_41 >> 13;
            int val_258 = this.X[12];
            val_43 = val_43;
            val_243 = val_41;
            val_43 = val_43 >> 29;
            int val_47 = val_36 & (~(((((((((((((((((((((((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]) >> 29) & (~((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) << (32-29)) | ((((((((((((((((((((((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) + this.X[0]) >> 29) & (~((((((this.H2 & (~((((((this.H3 & (~((((((this.H4 & (~this.H2)) | (this.H3 & this.H2)) + this.H1) << 29)));
            int val_259 = this.X[13];
            val_245 = val_43;
            val_47 = val_47 >> 25;
            int val_260 = this.X[14];
            int val_54 = val_47;
            int val_56 = val_41 >> 21;
            int val_261 = this.X[15];
            int val_62 = val_43 >> 13;
            int val_63 = val_56;
            int val_262 = this.X[0];
            int val_67 = val_43;
            val_43 = val_62;
            int val_68 = val_62;
            val_67 = val_67 >> 29;
            int val_69 = val_43;
            int val_263 = this.X[4];
            int val_73 = val_47;
            int val_75 = val_67;
            val_73 = val_73 >> 27;
            int val_76 = val_67;
            int val_264 = this.X[8];
            val_56 = val_56;
            int val_81 = val_73;
            val_56 = val_56 >> 23;
            int val_82 = val_73;
            int val_265 = this.X[12];
            val_62 = val_62;
            int val_87 = val_56;
            val_62 = val_62 >> 19;
            int val_88 = val_56;
            int val_266 = this.X[1];
            val_67 = val_67;
            int val_93 = val_62;
            val_67 = val_67 >> 29;
            int val_94 = val_62;
            int val_267 = this.X[5];
            val_73 = val_73;
            int val_99 = val_67;
            val_73 = val_73 >> 27;
            int val_100 = val_67;
            int val_268 = this.X[9];
            val_56 = val_56;
            int val_105 = val_73;
            val_56 = val_56 >> 23;
            int val_106 = val_73;
            int val_269 = this.X[13];
            val_62 = val_62;
            int val_111 = val_56;
            val_62 = val_62 >> 19;
            int val_112 = val_56;
            int val_270 = this.X[2];
            val_67 = val_67;
            int val_117 = val_62;
            val_67 = val_67 >> 29;
            int val_118 = val_62;
            int val_271 = this.X[6];
            val_73 = val_73;
            int val_123 = val_67;
            val_73 = val_73 >> 27;
            int val_124 = val_67;
            int val_272 = this.X[10];
            val_56 = val_56;
            int val_129 = val_73;
            val_56 = val_56 >> 23;
            int val_130 = val_73;
            int val_273 = this.X[14];
            val_62 = val_62;
            int val_135 = val_56;
            val_62 = val_62 >> 19;
            int val_136 = val_56;
            int val_274 = this.X[3];
            val_67 = val_67;
            int val_141 = val_62;
            val_67 = val_67 >> 29;
            int val_142 = val_62;
            int val_275 = this.X[7];
            val_73 = val_73;
            int val_147 = val_67;
            val_73 = val_73 >> 27;
            int val_148 = val_67;
            int val_276 = this.X[11];
            val_56 = val_56;
            int val_153 = val_73;
            val_56 = val_56 >> 23;
            int val_154 = val_73;
            int val_277 = this.X[15];
            val_62 = val_62 >> 19;
            int val_159 = val_56;
            int val_278 = this.X[0];
            val_67 = val_67 >> 29;
            int val_164 = val_62;
            int val_279 = this.X[8];
            val_73 = val_73 >> 23;
            int val_169 = val_67;
            int val_280 = this.X[4];
            val_56 = val_56 >> 21;
            int val_174 = val_73;
            int val_281 = this.X[12];
            val_62 = val_62 >> 17;
            int val_179 = val_56;
            int val_282 = this.X[2];
            val_67 = val_67 >> 29;
            int val_184 = val_62;
            int val_283 = this.X[10];
            val_73 = val_73 >> 23;
            int val_189 = val_67;
            int val_284 = this.X[6];
            val_56 = val_56 >> 21;
            int val_194 = val_73;
            int val_285 = this.X[14];
            val_62 = val_62 >> 17;
            int val_199 = val_56;
            int val_286 = this.X[1];
            val_67 = val_67 >> 29;
            int val_204 = val_62;
            int val_287 = this.X[9];
            val_73 = val_73 >> 23;
            int val_209 = val_67;
            int val_288 = this.X[5];
            val_56 = val_56 >> 21;
            int val_214 = val_73;
            int val_289 = this.X[13];
            val_242 = val_62 >> 17;
            int val_219 = val_56;
            int val_290 = this.X[3];
            val_67 = val_67 >> 29;
            int val_224 = val_242;
            int val_291 = this.X[11];
            val_73 = val_73;
            int val_229 = val_67;
            int val_292 = this.X[7];
            val_56 = val_56 >> 21;
            int val_234 = val_73 >> 23;
            int val_293 = this.X[15];
            int val_237 = val_242;
            val_237 = val_237 >> 17;
            val_243 = 0;
            this.H3 = this.H3;
            this.H4 = this.H4;
            this.H1 = this.H1;
            this.H2 = val_237;
            this.xOff = 0;
            goto label_96;
            label_100:
            val_242 = 0;
            val_243 = 1;
            this.X[val_242] = 0;
            label_96:
            if(val_243 != this.X.Length)
            {
                goto label_100;
            }
        
        }
        public override Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.MD4Digest(t:  this);
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
