using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    internal class DefiniteLengthInputStream : LimitedInputStream
    {
        // Fields
        private static readonly byte[] EmptyBytes;
        private readonly int _originalLength;
        private int _remaining;
        
        // Properties
        internal int Remaining { get; }
        
        // Methods
        internal DefiniteLengthInputStream(System.IO.Stream inStream, int length)
        {
            if((length & 2147483648) == 0)
            {
                    this._originalLength = length;
                this._remaining = length;
                if(length == 0)
            {
                goto typeof(Org.BouncyCastle.Asn1.DefiniteLengthInputStream).__il2cppRuntimeField_358;
            }
            
                return;
            }
            
            System.ArgumentException val_1 = new System.ArgumentException(message:  "negative lengths not allowed", paramName:  "length");
        }
        internal int get_Remaining()
        {
            return (int)this._remaining;
        }
        public override int ReadByte()
        {
            var val_4;
            if(this._remaining == 0)
            {
                goto label_1;
            }
            
            val_4 = 137134080;
            if((val_4 & 2147483648) != 0)
            {
                goto label_3;
            }
            
            int val_4 = this._remaining;
            val_4 = val_4 - 1;
            this._remaining = val_4;
            if(val_4 != 0)
            {
                    return (int)val_4;
            }
            
            return (int)val_4;
            label_1:
            val_4 = 0;
            return (int)val_4;
            label_3:
            System.IO.EndOfStreamException val_3 = new System.IO.EndOfStreamException(message:  +new object[4]);
        }
        public override int Read(byte[] buf, int off, int len)
        {
            var val_5;
            if(this._remaining == 0)
            {
                goto label_1;
            }
            
            int val_1 = System.Math.Min(val1:  len, val2:  this._remaining);
            val_5 = this._remaining;
            if(val_5 <= 0)
            {
                goto label_5;
            }
            
            int val_5 = this._remaining;
            val_5 = val_5 - val_5;
            this._remaining = val_5;
            if(val_5 != 0)
            {
                    return (int)val_5;
            }
            
            return (int)val_5;
            label_1:
            val_5 = 0;
            return (int)val_5;
            label_5:
            System.IO.EndOfStreamException val_4 = new System.IO.EndOfStreamException(message:  +new object[4]);
        }
        internal void ReadAllIntoByteArray(byte[] buf)
        {
            var val_7;
            var val_8;
            if(this._remaining != buf.Length)
            {
                goto label_2;
            }
            
            int val_2 = this._remaining - (Org.BouncyCastle.Utilities.IO.Streams.ReadFully(inStr:  0, buf:  buf));
            this._remaining = val_2;
            if(val_2 != 0)
            {
                goto label_3;
            }
            
            goto typeof(Org.BouncyCastle.Asn1.DefiniteLengthInputStream).__il2cppRuntimeField_358;
            label_2:
            val_7 = 1152921553417366816;
            val_8 = new System.ArgumentException(message:  "buffer length not right for data");
            goto label_4;
            label_3:
            val_7 = 1152921553417366816;
            val_8 = new System.IO.EndOfStreamException(message:  +new object[4]);
            label_4:
        }
        internal byte[] ToArray()
        {
            var val_6;
            System.Byte[] val_7;
            var val_8;
            val_6 = this;
            if(this._remaining == 0)
            {
                goto label_1;
            }
            
            System.IO.Stream val_6 = 1152921505721910208;
            byte[] val_1 = new byte[0];
            val_7 = val_1;
            val_6 = this._remaining - (Org.BouncyCastle.Utilities.IO.Streams.ReadFully(inStr:  val_6, buf:  val_1));
            this._remaining = val_6;
            if(val_6 != 0)
            {
                goto label_2;
            }
            
            return val_7;
            label_1:
            val_6 = 1152921505542414336;
            val_8 = null;
            val_8 = null;
            val_7 = Org.BouncyCastle.Asn1.DefiniteLengthInputStream.EmptyBytes;
            return val_7;
            label_2:
            System.IO.EndOfStreamException val_5 = new System.IO.EndOfStreamException(message:  +new object[4]);
        }
        private static DefiniteLengthInputStream()
        {
            Org.BouncyCastle.Asn1.DefiniteLengthInputStream.EmptyBytes = new byte[0];
        }
    
    }

}
