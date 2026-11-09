using UnityEngine;

namespace Org.BouncyCastle.Utilities.Encoders
{
    public class HexEncoder : IEncoder
    {
        // Fields
        protected readonly byte[] encodingTable;
        protected readonly byte[] decodingTable;
        
        // Methods
        protected void InitialiseDecodingTable()
        {
            var val_2;
            int val_3;
            int val_4;
            int val_5;
            int val_6;
            int val_7;
            int val_8;
            Org.BouncyCastle.Utilities.Arrays.Fill(buf:  this.decodingTable, b:  255);
            val_2 = 0;
            goto label_0;
            label_6:
            byte val_1 = X20 + this.encodingTable[0];
            mem2[0] = val_2;
            val_2 = 1;
            label_0:
            if(val_2 < this.encodingTable.Length)
            {
                goto label_6;
            }
            
            val_3 = this.decodingTable.Length;
            if(val_3 <= 97)
            {
                    val_3 = this.decodingTable.Length;
            }
            
            this.decodingTable[65] = this.decodingTable[97];
            val_4 = this.decodingTable.Length;
            if(val_4 <= 98)
            {
                    val_4 = this.decodingTable.Length;
            }
            
            this.decodingTable[66] = this.decodingTable[98];
            val_5 = this.decodingTable.Length;
            if(val_5 <= 99)
            {
                    val_5 = this.decodingTable.Length;
            }
            
            this.decodingTable[67] = this.decodingTable[99];
            val_6 = this.decodingTable.Length;
            if(val_6 <= 100)
            {
                    val_6 = this.decodingTable.Length;
            }
            
            this.decodingTable[68] = this.decodingTable[100];
            val_7 = this.decodingTable.Length;
            if(val_7 <= 101)
            {
                    val_7 = this.decodingTable.Length;
            }
            
            this.decodingTable[69] = this.decodingTable[101];
            val_8 = this.decodingTable.Length;
            if(val_8 <= 102)
            {
                    val_8 = this.decodingTable.Length;
            }
            
            this.decodingTable[70] = this.decodingTable[102];
        }
        public HexEncoder()
        {
            this.encodingTable = new byte[16] {48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 97, 98, 99, 100, 101, 102};
            this.decodingTable = new byte[128];
            this.InitialiseDecodingTable();
        }
        public int Encode(byte[] data, int off, int length, System.IO.Stream outStream)
        {
            int val_4 = off;
            int val_1 = length + val_4;
            if(val_1 <= val_4)
            {
                    return (int)length << 1;
            }
            
            var val_2 = (long)val_1 - (val_4 << );
            do
            {
                byte val_5 = this.encodingTable[0];
                byte val_6 = this.encodingTable[1152921505721910208 & 15];
                val_2 = val_2 - 1;
                val_4 = val_4 + 1;
            }
            while(val_2 != 0);
            
            return (int)length << 1;
        }
        private static bool Ignore(char c)
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
            c = ((val_2 == ' ') ? 1 : 0) | ((val_2 == '	') ? 1 : 0);
            return (bool)c;
        }
        public int Decode(byte[] data, int off, int length, System.IO.Stream outStream)
        {
            var val_15;
            System.IO.Stream val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_16 = outStream;
            val_17 = off;
            val_18 = length + val_17;
            if(val_18 <= val_17)
            {
                goto label_5;
            }
            
            val_18 = (long)val_18;
            val_19 = 1;
            label_6:
            val_16 = val_18 - 1;
            if(data[val_18] > 32)
            {
                goto label_5;
            }
            
            data[val_18] = val_19 << data[val_18];
            data[val_18] = data[val_18] & 4294977025;
            if(data[val_18] == null)
            {
                goto label_5;
            }
            
            if(val_16 > (long)val_17)
            {
                goto label_6;
            }
            
            val_18 = val_16;
            label_5:
            if(val_18 <= val_17)
            {
                goto label_7;
            }
            
            val_19 = (long)val_18;
            label_29:
            if(val_17 >= val_18)
            {
                goto label_12;
            }
            
            val_17 = (long)val_17;
            label_13:
            byte val_11 = data[val_17];
            if(val_11 > 32)
            {
                goto label_12;
            }
            
            val_11 = 1 << val_11;
            val_11 = val_11 & 4294977025;
            if(val_11 == 0)
            {
                goto label_12;
            }
            
            val_17 = val_17 + 1;
            if(val_17 < val_19)
            {
                goto label_13;
            }
            
            label_12:
            byte val_1 = mem[1152921543916581912] + data[(long)val_17];
            val_20 = val_17 + 1;
            if(val_20 >= val_18)
            {
                goto label_23;
            }
            
            System.Byte[] val_2 = data[32] + (val_20 << );
            label_22:
            var val_3 = val_17 + 1;
            var val_13 = val_2;
            if(val_13 > 32)
            {
                goto label_21;
            }
            
            val_13 = 1 << val_13;
            val_13 = val_13 & 4294977025;
            if(val_13 == 0)
            {
                goto label_21;
            }
            
            var val_4 = val_17 + 1;
            val_2 = val_2 + 1;
            if((val_17 + 2) < val_18)
            {
                goto label_22;
            }
            
            val_20 = val_4 + 1;
            val_17 = val_4;
            goto label_23;
            label_21:
            val_20 = val_17 + 1;
            label_23:
            byte val_6 = mem[1152921543916581912] + data[(long)val_20];
            val_15 = mem[(mem[1152921543916581912] + data[(long)(int)((((long)(int)(off) + 1) + 1))][0]) + 32];
            val_15 = (mem[1152921543916581912] + data[(long)(int)((((long)(int)(off) + 1) + 1))][0]) + 32;
            if((((int)(val_15 | ((mem[1152921543916581912] + data[(long)(int)(((long)(int)(off) + 1))][0]) + 32)) & 255) & 2147483648) != 0)
            {
                goto label_27;
            }
            
            val_16 = val_16;
            val_17 = val_17 + 2;
            var val_8 = val_15 | (((mem[1152921543916581912] + data[(long)(int)(((long)(int)(off) + 1))][0]) + 32) << 4);
            val_21 = 0 + 1;
            if(val_17 < val_18)
            {
                goto label_29;
            }
            
            return (int)val_21;
            label_7:
            val_21 = 0;
            return (int)val_21;
            label_27:
            System.IO.IOException val_9 = new System.IO.IOException(message:  "invalid characters encountered in Hex data");
        }
        public int DecodeString(string data, System.IO.Stream outStream)
        {
            var val_18;
            int val_19;
            var val_20;
            int val_21;
            var val_22;
            int val_1 = data.Length;
            if(val_1 < 1)
            {
                goto label_8;
            }
            
            val_18 = 1;
            label_6:
            val_19 = val_1 - 1;
            char val_3 = data.Chars[val_19] & 65535;
            if(val_3 > ' ')
            {
                goto label_5;
            }
            
            val_3 = val_18 << val_3;
            val_3 = val_3 & 4294977025;
            if(val_3 == 0)
            {
                goto label_5;
            }
            
            if((val_19 + 1) > 1)
            {
                goto label_6;
            }
            
            goto label_7;
            label_5:
            val_19 = val_1;
            label_7:
            if(val_19 < 1)
            {
                goto label_8;
            }
            
            val_20 = 0;
            label_28:
            if(val_20 >= val_19)
            {
                goto label_12;
            }
            
            char val_6 = data.Chars[0] & 65535;
            if(val_6 > ' ')
            {
                goto label_12;
            }
            
            val_6 = 1 << val_6;
            val_6 = val_6 & 4294977025;
            if(val_6 == 0)
            {
                goto label_12;
            }
            
            val_20 = val_20 + 1;
            goto label_28;
            label_12:
            char val_9 = mem[1152921543916752280] + (data.Chars[0] & 65535);
            val_21 = val_20 + 1;
            if(val_21 >= val_19)
            {
                goto label_22;
            }
            
            label_21:
            char val_12 = (data.Chars[val_20 + 1]) & 65535;
            if(val_12 > ' ')
            {
                goto label_20;
            }
            
            val_12 = 1 << val_12;
            val_12 = val_12 & 4294977025;
            if(val_12 == 0)
            {
                goto label_20;
            }
            
            var val_13 = val_20 + 1;
            if((val_20 + 2) < val_19)
            {
                goto label_21;
            }
            
            val_21 = val_13 + 1;
            val_20 = val_13;
            goto label_22;
            label_20:
            val_21 = val_20 + 1;
            label_22:
            var val_20 = data.Chars[val_21];
            val_20 = val_20 & 65535;
            char val_16 = mem[1152921543916752280] + val_20;
            val_18 = mem[(mem[1152921543916752280] + (val_15 & 65535)) + 32];
            val_18 = (mem[1152921543916752280] + (val_15 & 65535)) + 32;
            if((((int)(val_18 | ((mem[1152921543916752280] + (val_7 & 65535)) + 32)) & 255) & 2147483648) != 0)
            {
                goto label_26;
            }
            
            val_20 = val_20 + 2;
            var val_18 = val_18 | (((mem[1152921543916752280] + (val_7 & 65535)) + 32) << 4);
            val_22 = 0 + 1;
            if(val_20 < val_19)
            {
                goto label_28;
            }
            
            return (int)val_22;
            label_8:
            val_22 = 0;
            return (int)val_22;
            label_26:
            System.IO.IOException val_19 = new System.IO.IOException(message:  "invalid characters encountered in Hex data");
        }
    
    }

}
