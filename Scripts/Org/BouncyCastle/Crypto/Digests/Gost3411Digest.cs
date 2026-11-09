using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class Gost3411Digest : IDigest, IMemoable
    {
        // Fields
        private const int DIGEST_LENGTH = 32;
        private byte[] H;
        private byte[] L;
        private byte[] M;
        private byte[] Sum;
        private byte[][] C;
        private byte[] xBuf;
        private int xBufOff;
        private ulong byteCount;
        private readonly Org.BouncyCastle.Crypto.IBlockCipher cipher;
        private byte[] sBox;
        private byte[] K;
        private byte[] a;
        internal short[] wS;
        internal short[] w_S;
        internal byte[] S;
        internal byte[] U;
        internal byte[] V;
        internal byte[] W;
        private static readonly byte[] C2;
        
        // Properties
        public string AlgorithmName { get; }
        
        // Methods
        private static byte[][] MakeC()
        {
            System.Byte[][] val_1 = new System.Byte[][4];
            var val_3 = 0;
            label_7:
            byte[] val_2 = new byte[32];
            if(val_1 == null)
            {
                goto label_1;
            }
            
            if(val_2 != null)
            {
                goto label_2;
            }
            
            goto label_5;
            label_1:
            if(val_2 == null)
            {
                goto label_5;
            }
            
            label_2:
            label_5:
            mem2[0] = val_2;
            val_3 = val_3 + 1;
            if(val_3 != 4)
            {
                goto label_7;
            }
            
            return val_1;
        }
        public Gost3411Digest()
        {
            this.H = new byte[32];
            this.L = new byte[32];
            this.M = new byte[32];
            this.Sum = new byte[32];
            this.C = Org.BouncyCastle.Crypto.Digests.Gost3411Digest.MakeC();
            this.xBuf = new byte[32];
            this.cipher = new Org.BouncyCastle.Crypto.Engines.Gost28147Engine();
            this.K = new byte[32];
            this.a = new byte[8];
            this.wS = new short[16];
            this.w_S = new short[16];
            this.S = new byte[32];
            this.U = new byte[32];
            this.V = new byte[32];
            this.W = new byte[32];
            System.Byte[] val_16 = Org.BouncyCastle.Crypto.Engines.Gost28147Engine.GetSBox(sBoxName:  "D-A");
            this.sBox = val_16;
            var val_19 = 0;
            val_19 = val_19 + 1;
            this.cipher.Init(forEncryption:  true, parameters:  new Org.BouncyCastle.Crypto.Parameters.ParametersWithSBox(parameters:  0, sBox:  val_16));
            this.Reset();
        }
        public Gost3411Digest(byte[] sBoxParam)
        {
            this.H = new byte[32];
            this.L = new byte[32];
            this.M = new byte[32];
            this.Sum = new byte[32];
            this.C = Org.BouncyCastle.Crypto.Digests.Gost3411Digest.MakeC();
            this.xBuf = new byte[32];
            this.cipher = new Org.BouncyCastle.Crypto.Engines.Gost28147Engine();
            this.K = new byte[32];
            this.a = new byte[8];
            this.wS = new short[16];
            this.w_S = new short[16];
            this.S = new byte[32];
            this.U = new byte[32];
            this.V = new byte[32];
            this.W = new byte[32];
            System.Byte[] val_16 = Org.BouncyCastle.Utilities.Arrays.Clone(data:  sBoxParam);
            this.sBox = val_16;
            var val_19 = 0;
            val_19 = val_19 + 1;
            this.cipher.Init(forEncryption:  true, parameters:  new Org.BouncyCastle.Crypto.Parameters.ParametersWithSBox(parameters:  0, sBox:  val_16));
            this.Reset();
        }
        public Gost3411Digest(Org.BouncyCastle.Crypto.Digests.Gost3411Digest t)
        {
            this.H = new byte[32];
            this.L = new byte[32];
            this.M = new byte[32];
            this.Sum = new byte[32];
            this.C = Org.BouncyCastle.Crypto.Digests.Gost3411Digest.MakeC();
            this.xBuf = new byte[32];
            this.cipher = new Org.BouncyCastle.Crypto.Engines.Gost28147Engine();
            this.K = new byte[32];
            this.a = new byte[8];
            this.wS = new short[16];
            this.w_S = new short[16];
            this.S = new byte[32];
            this.U = new byte[32];
            this.V = new byte[32];
            this.W = new byte[32];
            this.Reset(other:  t);
        }
        public string get_AlgorithmName()
        {
            return "Gost3411";
        }
        public int GetDigestSize()
        {
            return 32;
        }
        public void Update(byte input)
        {
            this.xBufOff = this.xBufOff + 1;
            this.xBuf[this.xBufOff] = input;
            if(this.xBufOff == this.xBuf.Length)
            {
                    this.sumByteArray(input:  this.xBuf);
                this.processBlock(input:  this.xBuf, inOff:  0);
                this.xBufOff = 0;
            }
            
            ulong val_2 = this.byteCount;
            val_2 = val_2 + 1;
            this.byteCount = val_2;
        }
        public void BlockUpdate(byte[] input, int inOff, int length)
        {
            int val_4;
            var val_5;
            System.Byte[] val_6;
            System.Byte[] val_7;
            val_4 = inOff;
            if((length < 1) || (this.xBufOff == 0))
            {
                goto label_1;
            }
            
            label_5:
            this.Update(input:  input[(long)val_4]);
            val_4 = val_4 + 1;
            val_5 = length - 1;
            if(length < 2)
            {
                goto label_7;
            }
            
            if(this.xBufOff != 0)
            {
                goto label_5;
            }
            
            goto label_7;
            label_1:
            val_5 = length;
            goto label_7;
            label_15:
            System.Array.Copy(sourceArray:  input, sourceIndex:  val_4, destinationArray:  this.xBuf, destinationIndex:  0, length:  this.xBuf.Length);
            this.sumByteArray(input:  this.xBuf);
            this.processBlock(input:  this.xBuf, inOff:  0);
            val_6 = this.xBuf;
            if(val_6 == null)
            {
                goto label_9;
            }
            
            val_7 = val_6;
            val_4 = val_4 + this.xBuf.Length;
            goto label_12;
            label_9:
            val_7 = this.xBuf;
            val_4 = val_4 + this.xBuf.Length;
            if(val_7 == null)
            {
                goto label_11;
            }
            
            val_6 = val_7;
            goto label_12;
            label_11:
            val_6 = this.xBuf;
            if(val_6 == null)
            {
                goto label_13;
            }
            
            label_12:
            val_5 = val_5 - this.xBuf.Length;
            this.byteCount = this.xBuf.Length + this.byteCount;
            label_7:
            if(val_5 > this.xBuf.Length)
            {
                goto label_15;
            }
            
            if(val_5 < 1)
            {
                    return;
            }
            
            int val_2 = val_5 + 1;
            do
            {
                val_5 = (long)val_4;
                this.Update(input:  input[val_5]);
                val_2 = val_2 - 1;
                val_4 = val_4 + 1;
            }
            while(val_2 > 1);
            
            return;
            label_13:
        }
        private byte[] P(byte[] input)
        {
            var val_4 = 0;
            var val_5 = 0;
            do
            {
                this.K[val_5] = null;
                var val_1 = val_4 + 8;
                var val_2 = val_5 + 1;
                this.K[val_5] = null;
                val_1 = val_1 + 8;
                val_2 = val_2 + 1;
                this.K[val_5] = null;
                val_2 = val_2 + 1;
                this.K[val_5] = null;
                val_4 = (val_1 + 8) - 23;
                val_5 = val_2 + 1;
            }
            while(val_4 != 8);
            
            return (System.Byte[])this.K;
        }
        private byte[] A(byte[] input)
        {
            int val_1;
            var val_4 = 0;
            do
            {
                val_1 = input.Length;
                if(val_4 >= val_1)
            {
                    val_1 = input.Length;
            }
            
                byte val_2 = input[val_4];
                var val_1 = val_4 + 8;
                val_1 = val_1 - 8;
                val_2 = input[val_4] ^ val_2;
                val_4 = val_1 + 1;
                this.a[val_4] = val_2;
            }
            while(val_4 != 8);
            
            System.Array.Copy(sourceArray:  input, sourceIndex:  8, destinationArray:  input, destinationIndex:  0, length:  24);
            System.Array.Copy(sourceArray:  this.a, sourceIndex:  0, destinationArray:  input, destinationIndex:  24, length:  8);
            return (System.Byte[])input;
        }
        private void E(byte[] key, byte[] s, int sOff, byte[] input, int inOff)
        {
            var val_5 = 0;
            val_5 = val_5 + 1;
            this.cipher.Init(forEncryption:  true, parameters:  new Org.BouncyCastle.Crypto.Parameters.KeyParameter(key:  key));
            var val_6 = 0;
            val_6 = val_6 + 1;
            int val_4 = this.cipher.ProcessBlock(inBuf:  input, inOff:  inOff, outBuf:  s, outOff:  sOff);
        }
        private void fw(byte[] input)
        {
            var val_2;
            Org.BouncyCastle.Crypto.Digests.Gost3411Digest.cpyBytesToShort(S:  input, wS:  this.wS);
            if(this.wS.Length == 0)
            {
                    val_2 = 0;
            }
            
            short val_2 = this.wS[0];
            if(this.wS.Length <= 1)
            {
                    val_2 = 0;
            }
            
            if(this.wS.Length <= 2)
            {
                    val_2 = 0;
            }
            
            if(this.wS.Length <= 3)
            {
                    val_2 = 0;
            }
            
            if(this.wS.Length <= 12)
            {
                    val_2 = 0;
            }
            
            if(this.wS.Length <= 15)
            {
                    val_2 = 0;
            }
            
            short val_1 = this.wS[1] ^ val_2;
            val_1 = val_1 ^ this.wS[2];
            val_1 = val_1 ^ this.wS[3];
            val_1 = val_1 ^ this.wS[12];
            val_2 = val_1 ^ this.wS[15];
            if(this.w_S.Length <= 15)
            {
                    val_2 = 0;
            }
            
            this.w_S[15] = val_2;
            System.Array.Copy(sourceArray:  this.wS, sourceIndex:  1, destinationArray:  this.w_S, destinationIndex:  0, length:  15);
            Org.BouncyCastle.Crypto.Digests.Gost3411Digest.cpyShortToBytes(wS:  this.w_S, S:  input);
        }
        private void processBlock(byte[] input, int inOff)
        {
            System.Array.Copy(sourceArray:  input, sourceIndex:  inOff, destinationArray:  this.M, destinationIndex:  0, length:  32);
            this.H.CopyTo(array:  this.U, index:  0);
            this.M.CopyTo(array:  this.V, index:  0);
            var val_18 = 32;
            do
            {
                var val_1 = val_18 - 32;
                this.W[0] = this.V[0] ^ this.U[0];
                val_18 = val_18 + 1;
            }
            while(val_18 != 64);
            
            this.E(key:  this.P(input:  this.W), s:  this.S, sOff:  0, input:  this.H, inOff:  0);
            var val_26 = 1;
            do
            {
                System.Byte[] val_4 = this.A(input:  this.U);
                var val_22 = 32;
                do
            {
                var val_5 = val_22 - 32;
                this.U[0] = this.C[val_26][0] ^ this.U[0];
                val_22 = val_22 + 1;
            }
            while(val_22 != 64);
            
                var val_25 = 32;
                this.V = this.A(input:  this.A(input:  this.V));
                do
            {
                var val_9 = val_25 - 32;
                this.W[0] = this.V[0] ^ this.U[0];
                val_25 = val_25 + 1;
            }
            while(val_25 != 64);
            
                this.E(key:  this.P(input:  this.W), s:  this.S, sOff:  8, input:  this.H, inOff:  8);
                val_26 = val_26 + 1;
            }
            while(val_26 != 4);
            
            var val_27 = 12;
            do
            {
                this.fw(input:  this.S);
                val_27 = val_27 - 1;
            }
            while(val_27 != 0);
            
            var val_30 = 32;
            do
            {
                this.S[0] = this.M[0] ^ this.S[0];
                val_30 = val_30 + 1;
            }
            while(val_30 != 64);
            
            this.fw(input:  this.S);
            var val_33 = 32;
            do
            {
                var val_13 = val_33 - 32;
                this.S[0] = this.S[0] ^ this.H[0];
                val_33 = val_33 + 1;
            }
            while(val_33 != 64);
            
            do
            {
                this.fw(input:  this.S);
            }
            while((61 - 1) != 0);
            
            System.Array.Copy(sourceArray:  this.S, sourceIndex:  0, destinationArray:  this.H, destinationIndex:  0, length:  this.H.Length);
        }
        private void finish()
        {
            Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE(n:  this.byteCount << 3, bs:  this.L);
            goto label_0;
            label_1:
            this.Update(input:  0);
            label_0:
            if(this.xBufOff != 0)
            {
                goto label_1;
            }
            
            this.processBlock(input:  this.L, inOff:  0);
            this.processBlock(input:  this.Sum, inOff:  0);
        }
        public int DoFinal(byte[] output, int outOff)
        {
            this.finish();
            this.H.CopyTo(array:  output, index:  outOff);
            this.Reset();
            return 32;
        }
        public void Reset()
        {
            var val_1;
            this.byteCount = 0;
            this.xBufOff = 0;
            System.Array.Clear(array:  this.H, index:  0, length:  this.H.Length);
            System.Array.Clear(array:  this.L, index:  0, length:  this.L.Length);
            System.Array.Clear(array:  this.M, index:  0, length:  this.M.Length);
            System.Byte[] val_2 = this.C[1];
            System.Array.Clear(array:  this.C[1], index:  0, length:  this.C[1].Length);
            System.Byte[] val_4 = this.C[3];
            System.Array.Clear(array:  this.C[3], index:  0, length:  this.C[3].Length);
            System.Array.Clear(array:  this.Sum, index:  0, length:  this.Sum.Length);
            System.Array.Clear(array:  this.xBuf, index:  0, length:  this.xBuf.Length);
            val_1 = null;
            val_1 = null;
            Org.BouncyCastle.Crypto.Digests.Gost3411Digest.C2.CopyTo(array:  this.C[2], index:  0);
        }
        private void sumByteArray(byte[] input)
        {
            var val_4 = 0;
            goto label_0;
            label_8:
            byte val_2 = this.Sum[0];
            val_2 = (val_4 + val_2) + input[0];
            val_4 = val_2 >> 8;
            0 = 1;
            this.Sum[0] = val_2;
            label_0:
            if(0 != this.Sum.Length)
            {
                goto label_8;
            }
        
        }
        private static void cpyBytesToShort(byte[] S, short[] wS)
        {
            goto label_0;
            label_6:
            byte val_2 = S[1];
            0 = 1;
            wS[0] = S[0];
            label_0:
            if(0 < (((S.Length < 0) ? (S.Length + 1) : S.Length) >> 1))
            {
                goto label_6;
            }
        
        }
        private static void cpyShortToBytes(short[] wS, byte[] S)
        {
            goto label_0;
            label_7:
            S[1] = wS[0] >> 8;
            0 = 1;
            S[0] = wS[0x0] + 32;
            label_0:
            if(0 < (((S.Length < 0) ? (S.Length + 1) : S.Length) >> 1))
            {
                goto label_7;
            }
        
        }
        public int GetByteLength()
        {
            return 32;
        }
        public Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.Gost3411Digest(t:  this);
        }
        public void Reset(Org.BouncyCastle.Utilities.IMemoable other)
        {
            System.Array val_6;
            System.Byte[] val_7;
            System.Array val_8;
            System.Array val_9;
            System.Byte[] val_10;
            System.Array val_11;
            System.Array val_12;
            System.Byte[] val_13;
            System.Array val_14;
            System.Array val_15;
            System.Byte[] val_16;
            System.Array val_17;
            this.sBox = 0;
            var val_5 = 0;
            val_5 = val_5 + 1;
            this.cipher.Init(forEncryption:  true, parameters:  new Org.BouncyCastle.Crypto.Parameters.ParametersWithSBox(parameters:  0, sBox:  0));
            this.Reset();
            if((1 & 1) == 0)
            {
                goto label_9;
            }
            
            val_6 = 11993091;
            val_7 = this.H;
            val_8 = 11993091;
            if(val_8 != 0)
            {
                goto label_12;
            }
            
            goto label_11;
            label_9:
            val_8 = 11993091;
            val_7 = this.H;
            val_6 = val_8;
            if(val_8 != 0)
            {
                goto label_12;
            }
            
            label_11:
            label_12:
            System.Array.Copy(sourceArray:  val_6, sourceIndex:  0, destinationArray:  val_7, destinationIndex:  0, length:  mem[4306960411]);
            if((1 & 1) == 0)
            {
                goto label_13;
            }
            
            val_9 = 28563616;
            val_10 = this.L;
            val_11 = 28563616;
            if(val_11 != 0)
            {
                goto label_16;
            }
            
            goto label_15;
            label_13:
            val_11 = 28563616;
            val_10 = this.L;
            val_9 = val_11;
            if(val_11 != 0)
            {
                goto label_16;
            }
            
            label_15:
            label_16:
            System.Array.Copy(sourceArray:  val_9, sourceIndex:  0, destinationArray:  val_10, destinationIndex:  0, length:  -2012873628);
            if((1 & 1) == 0)
            {
                goto label_17;
            }
            
            val_12 = 64;
            val_13 = this.M;
            val_14 = 64;
            if(val_14 != 0)
            {
                goto label_20;
            }
            
            goto label_19;
            label_17:
            val_14 = 64;
            val_13 = this.M;
            val_12 = val_14;
            if(val_14 != 0)
            {
                goto label_20;
            }
            
            label_19:
            label_20:
            System.Array.Copy(sourceArray:  val_12, sourceIndex:  0, destinationArray:  val_13, destinationIndex:  0, length:  0);
            if((1 & 1) == 0)
            {
                goto label_21;
            }
            
            val_15 = 135970152;
            val_16 = this.Sum;
            val_17 = 135970152;
            if(val_17 != 0)
            {
                goto label_24;
            }
            
            goto label_23;
            label_21:
            val_17 = 135970152;
            val_16 = this.Sum;
            val_15 = val_17;
            if(val_17 != 0)
            {
                goto label_24;
            }
            
            label_23:
            label_24:
            System.Array.Copy(sourceArray:  val_15, sourceIndex:  0, destinationArray:  val_16, destinationIndex:  0, length:  106557232);
            System.Array.Copy(sourceArray:  mem[15762873573703720], sourceIndex:  0, destinationArray:  this.C[1], destinationIndex:  0, length:  mem[15762873573703720] + 24);
            System.Array.Copy(sourceArray:  mem[15762873573703728], sourceIndex:  0, destinationArray:  this.C[2], destinationIndex:  0, length:  mem[15762873573703728] + 24);
            System.Array.Copy(sourceArray:  mem[15762873573703736], sourceIndex:  0, destinationArray:  this.C[3], destinationIndex:  0, length:  mem[15762873573703736] + 24);
            System.Array.Copy(sourceArray:  4194311, sourceIndex:  0, destinationArray:  this.xBuf, destinationIndex:  0, length:  mem[7599944634466335]);
            this.xBufOff = 1;
            this.byteCount = 0;
        }
        private static Gost3411Digest()
        {
            Org.BouncyCastle.Crypto.Digests.Gost3411Digest.C2 = new byte[32] {0, 255, 0, 255, 0, 255, 0, 255, 255, 0, 255, 0, 255, 0, 255, 0, 0, 255, 255, 0, 255, 0, 0, 255, 255, 0, 0, 0, 255, 255, 0, 255};
        }
    
    }

}
