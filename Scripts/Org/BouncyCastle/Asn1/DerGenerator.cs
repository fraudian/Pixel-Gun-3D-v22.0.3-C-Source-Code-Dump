using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    public abstract class DerGenerator : Asn1Generator
    {
        // Fields
        private bool _tagged;
        private bool _isExplicit;
        private int _tagNo;
        
        // Methods
        protected DerGenerator(System.IO.Stream outStream)
        {
            val_1 = new System.Object();
            mem[1152921553435452640] = outStream;
        }
        protected DerGenerator(System.IO.Stream outStream, int tagNo, bool isExplicit)
        {
            val_1 = new System.Object();
            mem[1152921553435572832] = outStream;
            this._tagged = true;
            this._isExplicit = isExplicit;
            this._tagNo = tagNo;
        }
        private static void WriteLength(System.IO.Stream outStr, int length)
        {
            var val_8;
            var val_9;
            var val_10;
            val_8 = length;
            val_9 = outStr;
            if(val_8 < 128)
            {
                    val_9 = ???;
                val_8 = ???;
            }
            else
            {
                    var val_11 = 0;
                var val_10 = val_8;
                do
            {
                val_10 = val_10 >> 8;
                val_10 = (-8) + 8;
                val_11 = val_11 + 1;
            }
            while(val_10 != 0);
            
                var val_1 = val_11 | 128;
                if((val_10 & 2147483648) != 0)
            {
                    return;
            }
            
                do
            {
                var val_3 = val_8 >> (val_10 & 24);
                val_10 = val_10 - 8;
            }
            while((val_10 & 2147483648) == 0);
            
            }
        
        }
        internal static void WriteDerEncoded(System.IO.Stream outStream, int tag, byte[] bytes)
        {
            Org.BouncyCastle.Asn1.DerGenerator.WriteLength(outStr:  outStream, length:  bytes.Length);
            if(bytes == null)
            {
                
            }
        
        }
        internal void WriteDerEncoded(int tag, byte[] bytes)
        {
            System.Byte[] val_4;
            System.Byte[] val_5;
            var val_6;
            int val_7;
            val_4 = bytes;
            if(this._tagged == false)
            {
                goto label_1;
            }
            
            int val_4 = this._tagNo;
            if(this._isExplicit == false)
            {
                goto label_2;
            }
            
            System.IO.MemoryStream val_2 = new System.IO.MemoryStream();
            Org.BouncyCastle.Asn1.DerGenerator.WriteDerEncoded(outStream:  val_2, tag:  tag, bytes:  val_4);
            val_5 = val_2;
            val_6 = val_4;
            val_7 = val_4 | 160;
            goto label_4;
            label_1:
            val_7 = tag;
            goto label_5;
            label_2:
            val_4 = (tag & 32) | val_4;
            val_7 = val_4 | 128;
            label_5:
            val_5 = val_4;
            label_4:
            Org.BouncyCastle.Asn1.DerGenerator.WriteDerEncoded(outStream:  23264, tag:  val_7, bytes:  val_5);
        }
        internal static void WriteDerEncoded(System.IO.Stream outStr, int tag, System.IO.Stream inStr)
        {
            Org.BouncyCastle.Asn1.DerGenerator.WriteDerEncoded(outStream:  outStr, tag:  tag, bytes:  Org.BouncyCastle.Utilities.IO.Streams.ReadAll(inStr:  inStr));
        }
    
    }

}
