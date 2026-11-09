using UnityEngine;

namespace Org.BouncyCastle.Utilities.Encoders
{
    public class Base64Encoder : IEncoder
    {
        // Fields
        protected readonly byte[] encodingTable;
        protected byte padding;
        protected readonly byte[] decodingTable;
        
        // Methods
        protected void InitialiseDecodingTable()
        {
            byte val_1;
            Org.BouncyCastle.Utilities.Arrays.Fill(buf:  this.decodingTable, b:  255);
            val_1 = 0;
            goto label_0;
            label_6:
            this.decodingTable[this.encodingTable[0]] = val_1;
            val_1 = 1;
            label_0:
            if(val_1 < this.encodingTable.Length)
            {
                goto label_6;
            }
        
        }
        public Base64Encoder()
        {
            this.encodingTable = new byte[64] {65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 43, 47};
            this.padding = 61;
            this.decodingTable = new byte[128];
            this.InitialiseDecodingTable();
        }
        public int Encode(byte[] data, int off, int length, System.IO.Stream outStream)
        {
            byte val_11;
            int val_12;
            byte val_13;
            System.Byte[] val_14;
            var val_15;
            int val_16;
            val_11 = off;
            int val_9 = 0;
            int val_1 = val_9 + val_11;
            val_9 = length - val_9;
            if(val_1 > val_11)
            {
                    do
            {
                val_12 = data.Length;
                if(val_11 >= val_12)
            {
                    val_12 = data.Length;
            }
            
                int val_2 = val_11 + 1;
                var val_12 = (long)val_2;
                if(val_2 >= val_12)
            {
                    val_12 = data.Length;
            }
            
                val_12 = val_12 + 1;
                byte val_13 = data[(long)val_11 + 2];
                byte val_14 = this.encodingTable[data[(long)val_11] >> 2];
                byte val_15 = this.encodingTable[data[val_12] >> 4];
                byte val_16 = this.encodingTable[val_13 >> 6];
                val_14 = this.encodingTable;
                byte val_17 = val_14[val_13 & 63];
                val_11 = val_12 + 1;
            }
            while(val_11 < val_1);
            
            }
            
            if(val_9 == 0)
            {
                goto label_15;
            }
            
            if(val_9 == 2)
            {
                goto label_16;
            }
            
            if(val_9 != 1)
            {
                goto label_17;
            }
            
            byte val_18 = data[(long)val_1];
            val_11 = val_18 >> 2;
            byte val_19 = this.encodingTable[val_11];
            byte val_20 = this.encodingTable[val_18];
            goto label_25;
            label_15:
            val_15 = 0;
            return (int)val_15;
            label_16:
            val_16 = data.Length;
            if(val_1 >= val_16)
            {
                    val_16 = data.Length;
            }
            
            val_13 = data[(long)val_1];
            var val_21 = (long)val_1 + 1;
            val_11 = data[val_21];
            val_1 = val_13 >> 2;
            val_21 = val_11 >> 4;
            byte val_23 = this.encodingTable[val_21];
            val_14 = this.encodingTable;
            byte val_24 = val_14[this.encodingTable[val_1]];
            label_25:
            label_17:
            val_15 = 4;
            return (int)val_15;
        }
        private bool ignore(char c)
        {
            char val_1 = c & 65535;
            if(val_1 == '
            ')
            {
                    return true;
            }
            
            if(val_1 == '')
            {
                    return true;
            }
            
            char val_2 = c & 65535;
            return (bool)((val_2 == ' ') ? 1 : 0) | ((val_2 == '	') ? 1 : 0);
        }
        public int Decode(byte[] data, int off, int length, System.IO.Stream outStream)
        {
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            int val_27;
            val_22 = 11495;
            val_23 = length + off;
            if(val_23 <= off)
            {
                goto label_5;
            }
            
            val_23 = (long)val_23;
            val_24 = 9728;
            label_6:
            if(data == null)
            {
                    val_22 = 0;
            }
            
            var val_1 = val_23 - 1;
            if(data[val_23] > 32)
            {
                goto label_5;
            }
            
            data[val_23] = 1 << data[val_23];
            data[val_23] = data[val_23] & 4294977025;
            if(data[val_23] == null)
            {
                goto label_5;
            }
            
            if(val_1 > (long)off)
            {
                goto label_6;
            }
            
            val_23 = val_1;
            label_5:
            int val_2 = val_23 - 4;
            int val_22 = this.nextI(data:  data, i:  off, finish:  val_2);
            if(val_22 >= val_2)
            {
                goto label_7;
            }
            
            label_26:
            if(data == null)
            {
                    val_22 = 0;
            }
            
            val_22 = val_22 + 1;
            if(mem[1152921543912103680] == 0)
            {
                    val_22 = 0;
            }
            
            byte val_5 = mem[1152921543912103680] + data[(long)val_22];
            int val_24 = this.nextI(data:  data, i:  val_22, finish:  val_2);
            val_24 = val_24 + 1;
            if(mem[1152921543912103680] == 0)
            {
                    val_22 = 0;
            }
            
            byte val_7 = mem[1152921543912103680] + data[(long)val_24];
            int val_26 = this.nextI(data:  data, i:  val_24, finish:  val_2);
            val_26 = val_26 + 1;
            if(mem[1152921543912103680] == 0)
            {
                    val_22 = 0;
            }
            
            byte val_9 = mem[1152921543912103680] + data[(long)val_26];
            int val_28 = this.nextI(data:  data, i:  val_26, finish:  val_2);
            byte val_11 = mem[1152921543912103680] + data[(long)val_28];
            val_24 = mem[(mem[1152921543912103680] + data[(long)(int)(val_10)][0]) + 32];
            val_24 = (mem[1152921543912103680] + data[(long)(int)(val_10)][0]) + 32;
            var val_12 = ((mem[1152921543912103680] + data[(long)(int)(val_6)][0]) + 32) | ((mem[1152921543912103680] + data[(long)(int)(val_3)][0]) + 32);
            val_12 = val_12 | ((mem[1152921543912103680] + data[(long)(int)(val_8)][0]) + 32);
            val_12 = val_12 | val_24;
            if((((int)val_12 & 255) & 2147483648) != 0)
            {
                goto label_21;
            }
            
            if(outStream != null)
            {
                    val_25 = 0;
            }
            else
            {
                    val_25 = 1;
            }
            
            val_28 = val_28 + 1;
            var val_14 = (((mem[1152921543912103680] + data[(long)(int)(val_6)][0]) + 32) >> 4) | (((mem[1152921543912103680] + data[(long)(int)(val_3)][0]) + 32) << 2);
            if(val_25 != 0)
            {
                    val_25 = (outStream == 0) ? 1 : 0;
            }
            
            var val_16 = (((mem[1152921543912103680] + data[(long)(int)(val_8)][0]) + 32) >> 2) | (((mem[1152921543912103680] + data[(long)(int)(val_6)][0]) + 32) << 4);
            var val_17 = val_24 | (((mem[1152921543912103680] + data[(long)(int)(val_8)][0]) + 32) << 6);
            val_26 = 0 + 3;
            if((outStream.nextI(data:  data, i:  val_28, finish:  val_2)) < val_2)
            {
                goto label_26;
            }
            
            goto label_27;
            label_7:
            val_26 = 0;
            label_27:
            val_27 = data.Length;
            if(val_2 >= val_27)
            {
                    val_27 = data.Length;
            }
            
            var val_30 = val_23;
            val_30 = val_30 - 3;
            if(val_30 >= val_27)
            {
                    val_27 = data.Length;
            }
            
            var val_32 = val_23;
            val_32 = val_32 - 2;
            if(val_32 >= val_27)
            {
                    val_27 = data.Length;
            }
            
            var val_34 = val_23;
            val_34 = val_34 - 1;
            int val_19 = this.decodeLastBlock(outStream:  outStream, c1:  data[(long)val_2], c2:  data[(long)val_30], c3:  data[(long)val_32], c4:  data[(long)val_34]);
            val_19 = val_19 + val_26;
            return (int)val_19;
            label_21:
            System.IO.IOException val_20 = new System.IO.IOException(message:  "invalid characters encountered in base64 data");
        }
        private int nextI(byte[] data, int i, int finish)
        {
            int val_1 = i;
            if(val_1 >= finish)
            {
                    return (int)val_1;
            }
            
            val_1 = (long)val_1;
            do
            {
                byte val_1 = data[val_1];
                if(val_1 > 32)
            {
                    return (int)val_1;
            }
            
                val_1 = 1 << val_1;
                val_1 = val_1 & 4294977025;
                if(val_1 == 0)
            {
                    return (int)val_1;
            }
            
                val_1 = val_1 + 1;
            }
            while(val_1 < (long)finish);
            
            return (int)val_1;
        }
        public int DecodeString(string data, System.IO.Stream outStream)
        {
            var val_43;
            int val_44;
            var val_45;
            var val_46;
            var val_47;
            var val_48;
            var val_49;
            int val_50;
            char val_51;
            char val_52;
            char val_53;
            val_43 = data;
            int val_1 = val_43.Length;
            int val_42 = val_1;
            if(val_42 < 1)
            {
                goto label_5;
            }
            
            label_6:
            val_44 = val_42 - 1;
            val_43 = data;
            char val_3 = val_43.Chars[val_44] & 65535;
            if(val_3 > ' ')
            {
                goto label_5;
            }
            
            val_3 = 1 << val_3;
            val_3 = val_3 & 4294977025;
            if(val_3 == 0)
            {
                goto label_5;
            }
            
            if((val_44 + 1) >= 2)
            {
                goto label_6;
            }
            
            goto label_7;
            label_5:
            val_44 = val_42;
            label_7:
            val_42 = val_44 - 4;
            int val_5 = val_1.nextI(data:  data, i:  0, finish:  val_42);
            val_45 = 0;
            if(val_5 >= val_42)
            {
                goto label_8;
            }
            
            label_26:
            val_46 = data;
            val_44 = val_5 + 1;
            if(mem[1152921543912459776] == 0)
            {
                    val_46 = 0;
            }
            
            char val_9 = mem[1152921543912459776] + (val_46.Chars[val_5] & 65535);
            int val_10 = this.nextI(data:  data, i:  val_44, finish:  val_42);
            val_47 = data;
            val_44 = val_10 + 1;
            if(mem[1152921543912459776] == 0)
            {
                    val_47 = 0;
            }
            
            char val_13 = mem[1152921543912459776] + (val_47.Chars[val_10] & 65535);
            int val_14 = this.nextI(data:  data, i:  val_44, finish:  val_42);
            val_48 = data;
            val_44 = val_14 + 1;
            if(mem[1152921543912459776] == 0)
            {
                    val_48 = 0;
            }
            
            char val_17 = mem[1152921543912459776] + (val_48.Chars[val_14] & 65535);
            int val_44 = this.nextI(data:  data, i:  val_44, finish:  val_42);
            var val_43 = data.Chars[val_44];
            val_43 = val_43 & 65535;
            char val_20 = mem[1152921543912459776] + val_43;
            var val_21 = ((mem[1152921543912459776] + (val_11 & 65535)) + 32) | ((mem[1152921543912459776] + (val_7 & 65535)) + 32);
            val_21 = val_21 | ((mem[1152921543912459776] + (val_15 & 65535)) + 32);
            val_21 = val_21 | ((mem[1152921543912459776] + (val_19 & 65535)) + 32);
            if((((int)val_21 & 255) & 2147483648) != 0)
            {
                goto label_21;
            }
            
            if(outStream != null)
            {
                    val_49 = 0;
            }
            else
            {
                    val_49 = 1;
            }
            
            val_44 = val_44 + 1;
            var val_23 = (((mem[1152921543912459776] + (val_11 & 65535)) + 32) >> 4) | (((mem[1152921543912459776] + (val_7 & 65535)) + 32) << 2);
            if(val_49 != 0)
            {
                    val_49 = (outStream == 0) ? 1 : 0;
            }
            
            var val_25 = (((mem[1152921543912459776] + (val_15 & 65535)) + 32) >> 2) | (((mem[1152921543912459776] + (val_11 & 65535)) + 32) << 4);
            var val_26 = ((mem[1152921543912459776] + (val_19 & 65535)) + 32) | (((mem[1152921543912459776] + (val_15 & 65535)) + 32) << 6);
            val_45 = 0 + 3;
            if((outStream.nextI(data:  data, i:  val_44, finish:  val_42)) < val_42)
            {
                goto label_26;
            }
            
            label_8:
            if(data != null)
            {
                    val_50 = val_44;
                val_51 = data.Chars[val_42];
                val_52 = data.Chars[val_50 - 3];
                val_53 = data.Chars[val_50 - 2];
            }
            else
            {
                    val_51 = 0.Chars[val_42];
                val_50 = val_44;
                val_52 = 0.Chars[val_50 - 3];
                val_53 = 0.Chars[val_50 - 2];
            }
            
            int val_40 = this.decodeLastBlock(outStream:  outStream, c1:  val_51, c2:  val_52, c3:  val_53, c4:  data.Chars[val_50 - 1]);
            val_40 = val_40 + val_45;
            return (int)val_40;
            label_21:
            System.IO.IOException val_41 = new System.IO.IOException(message:  "invalid characters encountered in base64 data");
        }
        private int decodeLastBlock(System.IO.Stream outStream, char c1, char c2, char c3, char c4)
        {
            byte val_18;
            byte val_19;
            var val_20;
            val_18 = c4;
            char val_22 = c3;
            char val_18 = c2;
            char val_19 = c1;
            if((val_22 & 65535) != this.padding)
            {
                goto label_1;
            }
            
            val_19 = val_19 & 65535;
            byte val_17 = this.decodingTable[val_19];
            val_18 = val_18 & 65535;
            val_18 = this.decodingTable[val_18];
            this.decodingTable[val_18] = val_18 | val_17;
            if((((int)this.decodingTable[val_18] & 255) & 2147483648) != 0)
            {
                goto label_22;
            }
            
            byte val_3 = (val_18 >> 4) | (val_17 << 2);
            val_20 = 1;
            return (int)val_20;
            label_1:
            val_19 = val_19 & 65535;
            byte val_20 = this.decodingTable[val_19];
            val_18 = val_18 & 65535;
            byte val_21 = this.decodingTable[val_18];
            val_22 = val_22 & 65535;
            val_19 = this.decodingTable[val_22];
            if((val_18 & 65535) != this.padding)
            {
                goto label_15;
            }
            
            byte val_5 = val_21 | val_20;
            val_5 = val_5 | val_19;
            if((((int)val_5 & 255) & 2147483648) != 0)
            {
                goto label_22;
            }
            
            byte val_7 = (val_21 >> 4) | (val_20 << 2);
            byte val_9 = (val_19 >> 2) | (val_21 << 4);
            val_20 = 2;
            return (int)val_20;
            label_15:
            val_18 = val_18 & 65535;
            byte val_23 = this.decodingTable[val_18];
            byte val_10 = val_21 | val_20;
            val_10 = val_10 | val_19;
            val_10 = val_10 | val_23;
            if((((int)val_10 & 255) & 2147483648) == 0)
            {
                    byte val_12 = (val_21 >> 4) | (val_20 << 2);
                if(outStream != null)
            {
                    val_18 = 0;
            }
            else
            {
                    val_18 = 1;
            }
            
                byte val_14 = (val_19 >> 2) | (val_21 << 4);
                byte val_15 = val_23 | (val_19 << 6);
                val_20 = 3;
                return (int)val_20;
            }
            
            label_22:
            System.IO.IOException val_16 = new System.IO.IOException(message:  "invalid characters encountered at end of base64 data");
        }
        private int nextI(string data, int i, int finish)
        {
            int val_3 = i;
            if(val_3 >= finish)
            {
                    return (int)val_3;
            }
            
            do
            {
                char val_2 = data.Chars[val_3] & 65535;
                if(val_2 > ' ')
            {
                    return (int)val_3;
            }
            
                val_2 = 1 << val_2;
                val_2 = val_2 & 4294977025;
                if(val_2 == 0)
            {
                    return (int)val_3;
            }
            
                val_3 = val_3 + 1;
            }
            while(val_3 < finish);
            
            return (int)val_3;
        }
    
    }

}
