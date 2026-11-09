using UnityEngine;

namespace Org.BouncyCastle.Crypto.Macs
{
    public class VmpcMac : IMac
    {
        // Fields
        private byte g;
        private byte n;
        private byte[] P;
        private byte s;
        private byte[] T;
        private byte[] workingIV;
        private byte[] workingKey;
        private byte x1;
        private byte x2;
        private byte x3;
        private byte x4;
        
        // Properties
        public virtual string AlgorithmName { get; }
        
        // Methods
        public virtual int DoFinal(byte[] output, int outOff)
        {
            int val_14;
            int val_15;
            int val_16;
            int val_17;
            int val_18;
            int val_19;
            int val_20;
            int val_21;
            int val_22;
            int val_23;
            byte val_17 = this.n;
            var val_40 = 1;
            do
            {
                byte val_19 = this.s;
                val_14 = this.P.Length;
                val_17 = val_17 & 255;
                if(val_17 >= val_14)
            {
                    val_14 = this.P.Length;
            }
            
                byte val_18 = this.P[val_17];
                val_18 = val_18 + val_19;
                val_19 = val_18 & 255;
                byte val_21 = this.x4;
                this.s = this.P[val_19];
                byte val_1 = val_21 + this.x3;
                val_1 = val_40 + val_1;
                val_21 = val_1 & 255;
                byte val_23 = this.x3;
                this.x4 = this.P[val_21];
                byte val_2 = val_23 + this.x2;
                val_2 = val_40 + val_2;
                val_23 = val_2 & 255;
                byte val_25 = this.x2;
                this.x3 = this.P[val_23];
                byte val_3 = val_25 + this.x1;
                val_3 = val_40 + val_3;
                val_25 = val_3 & 255;
                byte val_27 = this.x1;
                this.x2 = this.P[val_25];
                byte val_4 = val_27 + this.s;
                val_4 = val_40 + val_4;
                val_27 = val_4 & 255;
                byte val_29 = this.g;
                this.x1 = this.P[val_27];
                val_15 = this.T.Length;
                val_29 = val_29 & 31;
                if((val_29 & 31) >= val_15)
            {
                    val_15 = this.T.Length;
            }
            
                mem2[0] = this.x1 ^ this.T[val_29];
                byte val_31 = this.g;
                val_16 = this.T.Length;
                val_31 = (val_31 + 1) & 31;
                if(val_31 >= val_16)
            {
                    val_16 = this.T.Length;
            }
            
                val_31 = this.x2 ^ this.T[val_31];
                mem2[0] = val_31;
                byte val_33 = this.g;
                val_17 = this.T.Length;
                val_33 = (val_33 + 2) & 31;
                if(val_33 >= val_17)
            {
                    val_17 = this.T.Length;
            }
            
                val_33 = this.x3 ^ this.T[val_33];
                mem2[0] = val_33;
                byte val_35 = this.g;
                val_18 = this.T.Length;
                val_35 = (val_35 + 3) & 31;
                if(val_35 >= val_18)
            {
                    val_18 = this.T.Length;
            }
            
                val_35 = this.x4 ^ this.T[val_35];
                mem2[0] = val_35;
                byte val_37 = this.g;
                val_37 = val_37 + 4;
                val_37 = val_37 & 31;
                this.g = val_37;
                val_19 = this.P.Length;
                if(this.s >= val_19)
            {
                    val_19 = this.P.Length;
            }
            
                this.P[this.n] = this.P[this.s];
                this.P[this.s] = this.P[this.n];
                val_40 = val_40 + 1;
                this.n = this.n + 1;
            }
            while(val_40 != 25);
            
            var val_47 = 0;
            do
            {
                byte val_43 = this.s;
                var val_11 = val_47 & 255;
                byte val_42 = this.T[val_47 & 31];
                val_42 = (this.P[val_11] + val_43) + val_42;
                val_43 = val_42 & 255;
                this.s = this.P[val_43];
                val_20 = this.P.Length;
                if(this.s >= val_20)
            {
                    val_20 = this.P.Length;
            }
            
                this.P[val_11] = this.P[this.s];
                val_47 = val_47 + 1;
                this.P[this.s] = this.P[val_11];
            }
            while(val_47 != 768);
            
            byte[] val_14 = new byte[20];
            var val_56 = 32;
            do
            {
                byte val_49 = this.s;
                val_21 = this.P.Length;
                if((val_56 - 32) >= val_21)
            {
                    val_21 = this.P.Length;
            }
            
                byte val_48 = this.P[0];
                val_48 = val_48 + val_49;
                val_49 = val_48 & 255;
                byte val_50 = this.P[val_49];
                this.s = val_50;
                val_22 = this.P.Length;
                if(val_50 >= val_22)
            {
                    val_22 = this.P.Length;
            }
            
                byte val_51 = this.P[val_50];
                if(val_51 >= val_22)
            {
                    val_22 = this.P.Length;
            }
            
                byte val_52 = this.P[val_51];
                val_52 = val_52 + 1;
                byte val_16 = val_52 & 255;
                val_51 = val_52 & 255;
                val_14[0] = this.P[val_51];
                if(this.s < this.P.Length)
            {
                    val_23 = this.P.Length & 4294967295;
            }
            else
            {
                    val_23 = this.P.Length;
            }
            
                this.P[0] = this.P[this.s];
                val_56 = val_56 + 1;
                this.P[this.s] = this.P[0];
            }
            while(val_56 != 52);
            
            System.Array.Copy(sourceArray:  val_14, sourceIndex:  0, destinationArray:  output, destinationIndex:  outOff, length:  val_14.Length);
            return (int)val_14.Length;
        }
        public virtual string get_AlgorithmName()
        {
            return "VMPC-MAC";
        }
        public virtual int GetMacSize()
        {
            return 20;
        }
        public virtual void Init(Org.BouncyCastle.Crypto.ICipherParameters parameters)
        {
            var val_8;
            string val_10;
            if(parameters == null)
            {
                goto label_3;
            }
            
            val_8 = parameters.Parameters;
            if(val_8 != null)
            {
                    val_8 = 0;
            }
            
            if(parameters.Parameters == null)
            {
                goto label_9;
            }
            
            System.Byte[] val_5 = parameters.GetIV();
            this.workingIV = val_5;
            if(val_5 == null)
            {
                goto label_11;
            }
            
            int val_8 = val_5.Length;
            val_8 = val_8 - 1;
            if(val_8 >= 768)
            {
                goto label_11;
            }
            
            this.workingKey = val_8.GetKey();
            return;
            label_3:
            val_10 = "VMPC-MAC Init parameters must include an IV";
            goto label_14;
            label_9:
            val_10 = "VMPC-MAC Init parameters must include a key";
            goto label_14;
            label_11:
            val_10 = "VMPC-MAC requires 1 to 768 bytes of IV";
            label_14:
            null = new System.ArgumentException(message:  val_10, paramName:  "parameters");
        }
        private void initKey(byte[] keyBytes, byte[] ivBytes)
        {
            System.Byte[] val_6;
            byte val_7;
            int val_8;
            int val_9;
            this.s = 0;
            val_6 = new byte[256];
            val_7 = 0;
            this.P = val_6;
            goto label_1;
            label_4:
            val_6 = this.P;
            val_7 = 1;
            label_1:
            val_6[val_7] = val_7;
            if(val_7 != 255)
            {
                goto label_4;
            }
            
            var val_14 = 0;
            do
            {
                byte val_10 = this.s;
                var val_2 = val_14 & 255;
                int val_3 = val_14 / keyBytes.Length;
                val_3 = val_14 - (val_3 * keyBytes.Length);
                byte val_9 = keyBytes[(long)val_3];
                val_9 = (this.P[val_2] + val_10) + val_9;
                val_10 = val_9 & 255;
                this.s = this.P[val_10];
                val_8 = this.P.Length;
                if(this.s >= val_8)
            {
                    val_8 = this.P.Length;
            }
            
                this.P[val_2] = this.P[this.s];
                val_14 = val_14 + 1;
                this.P[this.s] = this.P[val_2];
            }
            while(val_14 != 768);
            
            var val_21 = 0;
            do
            {
                byte val_17 = this.s;
                var val_5 = val_21 & 255;
                int val_6 = val_21 / ivBytes.Length;
                val_6 = val_21 - (val_6 * ivBytes.Length);
                byte val_16 = ivBytes[(long)val_6];
                val_16 = (this.P[val_5] + val_17) + val_16;
                val_17 = val_16 & 255;
                this.s = this.P[val_17];
                val_9 = this.P.Length;
                if(this.s >= val_9)
            {
                    val_9 = this.P.Length;
            }
            
                this.P[val_5] = this.P[this.s];
                val_21 = val_21 + 1;
                this.P[this.s] = this.P[val_5];
            }
            while(val_21 != 768);
            
            this.n = 0;
        }
        public virtual void Reset()
        {
            System.Byte[] val_2;
            var val_3;
            this.initKey(keyBytes:  this.workingKey, ivBytes:  this.workingIV);
            this.g = 0;
            this.n = 0;
            this.x1 = 0;
            this.x2 = 0;
            this.x3 = 0;
            this.x4 = 0;
            val_2 = new byte[32];
            val_3 = 0;
            this.T = val_2;
            goto label_1;
            label_4:
            val_2 = this.T;
            val_3 = 1;
            label_1:
            val_2[val_3] = 0;
            if(val_3 != 31)
            {
                goto label_4;
            }
        
        }
        public virtual void Update(byte input)
        {
            int val_11;
            int val_12;
            int val_13;
            int val_14;
            int val_15;
            int val_16;
            int val_17;
            byte val_12 = this.s;
            val_11 = this.P.Length;
            if(this.n >= val_11)
            {
                    val_11 = this.P.Length;
            }
            
            byte val_11 = this.P[this.n];
            val_11 = val_11 + val_12;
            val_12 = val_11 & 255;
            byte val_13 = this.P[val_12];
            this.s = val_13;
            val_12 = this.P.Length;
            if(val_13 >= val_12)
            {
                    val_12 = this.P.Length;
            }
            
            byte val_14 = this.P[val_13];
            if(val_14 >= val_12)
            {
                    val_12 = this.P.Length;
            }
            
            byte val_15 = this.P[val_14];
            val_15 = val_15 + 1;
            byte val_1 = val_15 & 255;
            val_14 = val_15 & 255;
            byte val_17 = this.x4;
            byte val_16 = this.P[val_14];
            val_17 = (this.x3 + val_17) & 255;
            byte val_19 = this.x3;
            this.x4 = this.P[val_17];
            val_19 = (this.x2 + val_19) & 255;
            byte val_21 = this.x2;
            this.x3 = this.P[val_19];
            val_21 = (this.x1 + val_21) & 255;
            val_16 = val_16 ^ input;
            val_16 = val_16 & 255;
            this.x2 = this.P[val_21];
            byte val_5 = this.x1 + val_16;
            val_5 = val_5 + this.s;
            val_16 = val_5 & 255;
            byte val_24 = this.g;
            this.x1 = this.P[val_16];
            val_13 = this.T.Length;
            val_24 = val_24 & 31;
            if((val_24 & 31) >= val_13)
            {
                    val_13 = this.T.Length;
            }
            
            mem2[0] = this.x1 ^ this.T[val_24];
            byte val_26 = this.g;
            val_14 = this.T.Length;
            val_26 = (val_26 + 1) & 31;
            if(val_26 >= val_14)
            {
                    val_14 = this.T.Length;
            }
            
            val_26 = this.x2 ^ this.T[val_26];
            mem2[0] = val_26;
            byte val_28 = this.g;
            val_15 = this.T.Length;
            val_28 = (val_28 + 2) & 31;
            if(val_28 >= val_15)
            {
                    val_15 = this.T.Length;
            }
            
            val_28 = this.x3 ^ this.T[val_28];
            mem2[0] = val_28;
            byte val_30 = this.g;
            val_16 = this.T.Length;
            val_30 = (val_30 + 3) & 31;
            if(val_30 >= val_16)
            {
                    val_16 = this.T.Length;
            }
            
            val_30 = this.x4 ^ this.T[val_30];
            mem2[0] = val_30;
            byte val_32 = this.g;
            val_32 = val_32 + 4;
            val_32 = val_32 & 31;
            this.g = val_32;
            val_17 = this.P.Length;
            if(this.s >= val_17)
            {
                    val_17 = this.P.Length;
            }
            
            this.P[this.n] = this.P[this.s];
            this.P[this.s] = this.P[this.n];
            byte val_35 = this.n;
            val_35 = val_35 + 1;
            this.n = val_35;
        }
        public virtual void BlockUpdate(byte[] input, int inOff, int len)
        {
            var val_3;
            int val_4;
            var val_5;
            var val_6;
            var val_7;
            val_3 = inOff;
            val_4 = input.Length;
            if((len + val_3) > val_4)
            {
                goto label_2;
            }
            
            if(len < 1)
            {
                    return;
            }
            
            val_5 = len - 1;
            goto label_4;
            label_6:
            val_4 = input.Length;
            val_6 = val_3 + 1;
            val_5 = val_5 - 1;
            label_4:
            val_7 = (long)val_6;
            byte val_3 = input[val_7];
            if(val_5 != 0)
            {
                goto label_6;
            }
            
            return;
            label_2:
            Org.BouncyCastle.Crypto.DataLengthException val_2 = new Org.BouncyCastle.Crypto.DataLengthException(message:  "input buffer too short");
        }
        public VmpcMac()
        {
        
        }
    
    }

}
