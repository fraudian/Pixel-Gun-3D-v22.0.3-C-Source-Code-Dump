using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class MD2Digest : IDigest, IMemoable
    {
        // Fields
        private const int DigestLength = 16;
        private const int BYTE_LENGTH = 16;
        private byte[] X;
        private int xOff;
        private byte[] M;
        private int mOff;
        private byte[] C;
        private int COff;
        private static readonly byte[] S;
        
        // Properties
        public string AlgorithmName { get; }
        
        // Methods
        public MD2Digest()
        {
            this.X = new byte[48];
            this.M = new byte[16];
            this.C = new byte[16];
            this.Reset();
        }
        public MD2Digest(Org.BouncyCastle.Crypto.Digests.MD2Digest t)
        {
            this.X = new byte[48];
            this.M = new byte[16];
            this.C = new byte[16];
            this.CopyIn(t:  t);
        }
        private void CopyIn(Org.BouncyCastle.Crypto.Digests.MD2Digest t)
        {
            if(t == null)
            {
                goto label_0;
            }
            
            if(t.X != null)
            {
                goto label_7;
            }
            
            label_8:
            label_7:
            System.Array.Copy(sourceArray:  t.X, sourceIndex:  0, destinationArray:  this.X, destinationIndex:  0, length:  t.X.Length);
            if(t == null)
            {
                goto label_2;
            }
            
            this.xOff = t.xOff;
            if(t.M != null)
            {
                goto label_9;
            }
            
            label_10:
            label_9:
            System.Array.Copy(sourceArray:  t.M, sourceIndex:  0, destinationArray:  this.M, destinationIndex:  0, length:  t.M.Length);
            if(t == null)
            {
                goto label_4;
            }
            
            this.mOff = t.mOff;
            if(t.C != null)
            {
                goto label_11;
            }
            
            label_12:
            label_11:
            System.Array.Copy(sourceArray:  t.C, sourceIndex:  0, destinationArray:  this.C, destinationIndex:  0, length:  t.C.Length);
            this.COff = t.COff;
            return;
            label_0:
            if(11993091 != 0)
            {
                goto label_7;
            }
            
            goto label_8;
            label_2:
            this.xOff = 28563616;
            if(64 != 0)
            {
                goto label_9;
            }
            
            goto label_10;
            label_4:
            this.mOff = 135970152;
            if(0 != 0)
            {
                goto label_11;
            }
            
            goto label_12;
        }
        public string get_AlgorithmName()
        {
            return "MD2";
        }
        public int GetDigestSize()
        {
            return 16;
        }
        public int GetByteLength()
        {
            return 16;
        }
        public int DoFinal(byte[] output, int outOff)
        {
            int val_2;
            System.Byte[] val_3;
            val_2 = this.mOff;
            goto label_1;
            label_5:
            val_2 = val_2 + 1;
            this.M[(long)val_2] = this.M.Length - val_2;
            label_1:
            val_3 = this.M;
            if(this.M == null)
            {
                    val_3 = this.M;
            }
            
            if(val_2 < this.M.Length)
            {
                goto label_5;
            }
            
            this.ProcessChecksum(m:  val_3);
            this.ProcessBlock(m:  this.M);
            this.ProcessBlock(m:  this.C);
            System.Array.Copy(sourceArray:  this.X, sourceIndex:  this.xOff, destinationArray:  output, destinationIndex:  outOff, length:  16);
            this.Reset();
            return 16;
        }
        public void Reset()
        {
            var val_1;
            var val_2;
            var val_3;
            val_1 = 0;
            this.xOff = 0;
            goto label_0;
            label_4:
            val_1 = 1;
            this.X[0] = 0;
            label_0:
            if(val_1 != this.X.Length)
            {
                goto label_4;
            }
            
            val_2 = 0;
            this.mOff = 0;
            goto label_5;
            label_9:
            val_2 = 1;
            this.M[0] = 0;
            label_5:
            if(val_2 != this.M.Length)
            {
                goto label_9;
            }
            
            val_3 = 0;
            this.COff = 0;
            goto label_10;
            label_14:
            val_3 = 1;
            this.C[0] = 0;
            label_10:
            if(val_3 != this.C.Length)
            {
                goto label_14;
            }
        
        }
        public void Update(byte input)
        {
            this.mOff = this.mOff + 1;
            this.M[this.mOff] = input;
            if(this.mOff != 16)
            {
                    return;
            }
            
            this.ProcessChecksum(m:  this.M);
            this.ProcessBlock(m:  this.M);
            this.mOff = 0;
        }
        public void BlockUpdate(byte[] input, int inOff, int length)
        {
            int val_8;
            var val_9;
            int val_7 = length;
            val_8 = inOff;
            if((val_7 < 1) || (this.mOff == 0))
            {
                goto label_1;
            }
            
            label_5:
            this.Update(input:  input[(long)val_8]);
            val_8 = val_8 + 1;
            val_9 = val_7 - 1;
            if(val_7 < 2)
            {
                goto label_6;
            }
            
            if(this.mOff != 0)
            {
                goto label_5;
            }
            
            goto label_6;
            label_1:
            val_9 = val_7;
            label_6:
            if(val_7 >= 1)
            {
                    int val_2 = (val_9 - 17) & 4294967280;
                val_7 = val_8 + val_2;
                int val_3 = val_9 + 16;
                do
            {
                System.Array.Copy(sourceArray:  input, sourceIndex:  val_8, destinationArray:  this.M, destinationIndex:  0, length:  16);
                this.ProcessChecksum(m:  this.M);
                this.ProcessBlock(m:  this.M);
                val_3 = val_3 - 16;
                val_8 = val_8 + 16;
            }
            while(val_3 > 32);
            
                val_9 = (val_9 - 16) - val_2;
                val_8 = val_7 + 16;
            }
            
            if(val_9 < 1)
            {
                    return;
            }
            
            int val_5 = val_9 + 1;
            do
            {
                val_9 = (long)val_8;
                this.Update(input:  input[val_9]);
                val_5 = val_5 - 1;
                val_8 = val_8 + 1;
            }
            while(val_5 > 1);
        
        }
        internal void ProcessChecksum(byte[] m)
        {
            var val_2;
            byte val_3 = this.C[1];
            var val_8 = 32;
            do
            {
                var val_1 = val_8 - 32;
                val_2 = null;
                val_2 = null;
                val_3 = val_3 ^ m[0];
                System.Byte[] val_2 = Org.BouncyCastle.Crypto.Digests.MD2Digest.S + val_3;
                byte val_6 = (Org.BouncyCastle.Crypto.Digests.MD2Digest.S + (this.C[1] ^ m[0])) + 32;
                val_6 = val_6 ^ this.C[0];
                this.C[0] = val_6;
                byte val_7 = this.C[0];
                val_8 = val_8 + 1;
            }
            while(val_8 != 48);
        
        }
        internal void ProcessBlock(byte[] m)
        {
            System.Byte[] val_5;
            var val_6;
            var val_9 = 0;
            do
            {
                this.X[val_9] = null;
                var val_2 = (val_9 + 16) - 16;
                val_5 = this.X;
                if(val_2 >= m.Length)
            {
                    val_5 = this.X;
            }
            
                val_9 = (val_2 + 32) - 31;
                this.X[val_9] = val_5[val_9] ^ 1152921505721910208;
            }
            while(val_9 != 16);
            
            var val_13 = 0;
            do
            {
                var val_11 = 0;
                do
            {
                val_6 = null;
                val_6 = null;
                byte val_12 = Org.BouncyCastle.Crypto.Digests.MD2Digest.S.Length + 32;
                val_11 = val_11 + 1;
                val_12 = val_12 ^ this.X[val_11];
                byte val_5 = val_12 & 255;
                this.X[val_11] = val_12;
            }
            while(val_11 != 48);
            
                val_12 = val_13 + val_5;
                var val_7 = (val_12 < 0) ? (val_12 + 255) : (val_12);
                val_13 = val_13 + 1;
                val_7 = val_7 & 4294967040;
                val_5 = val_12 - val_7;
            }
            while(val_13 != 18);
        
        }
        public Org.BouncyCastle.Utilities.IMemoable Copy()
        {
            return (Org.BouncyCastle.Utilities.IMemoable)new Org.BouncyCastle.Crypto.Digests.MD2Digest(t:  this);
        }
        public void Reset(Org.BouncyCastle.Utilities.IMemoable other)
        {
            Org.BouncyCastle.Utilities.IMemoable val_3 = other;
            if(val_3 != null)
            {
                    val_3 = 0;
            }
            
            this.CopyIn(t:  val_3);
        }
        private static MD2Digest()
        {
            Org.BouncyCastle.Crypto.Digests.MD2Digest.S = new byte[256] {41, 46, 67, 201, 162, 216, 124, 1, 61, 54, 84, 161, 236, 240, 6, 19, 98, 167, 5, 243, 192, 199, 115, 140, 152, 147, 43, 217, 188, 76, 130, 202, 30, 155, 87, 60, 253, 212, 224, 22, 103, 66, 111, 24, 138, 23, 229, 18, 190, 78, 196, 214, 218, 158, 222, 73, 160, 251, 245, 142, 187, 47, 238, 122, 169, 104, 121, 145, 21, 178, 7, 63, 148, 194, 16, 137, 11, 34, 95, 33, 128, 127, 93, 154, 90, 144, 50, 39, 53, 62, 204, 231, 191, 247, 151, 3, 255, 25, 48, 179, 72, 165, 181, 209, 215, 94, 146, 42, 172, 86, 170, 198, 79, 184, 56, 210, 150, 164, 125, 182, 118, 252, 107, 226, 156, 116, 4, 241, 69, 157, 112, 89, 100, 113, 135, 32, 134, 91, 207, 101, 230, 45, 168, 2, 27, 96, 37, 173, 174, 176, 185, 246, 28, 70, 97, 105, 52, 64, 126, 15, 85, 71, 163, 35, 221, 81, 175, 58, 195, 92, 249, 206, 186, 197, 234, 38, 44, 83, 13, 110, 133, 40, 132, 9, 211, 223, 205, 244, 65, 129, 77, 82, 106, 220, 55, 200, 108, 193, 171, 250, 36, 225, 123, 8, 12, 189, 177, 74, 120, 136, 149, 139, 227, 99, 232, 109, 233, 203, 213, 254, 59, 0, 29, 57, 242, 239, 183, 14, 102, 88, 208, 228, 166, 119, 114, 248, 235, 117, 75, 10, 49, 68, 80, 180, 143, 237, 31, 26, 219, 153, 141, 51, 159, 17, 131, 20};
        }
    
    }

}
