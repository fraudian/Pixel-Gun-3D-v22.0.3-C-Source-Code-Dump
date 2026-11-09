using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    internal class IndefiniteLengthInputStream : LimitedInputStream
    {
        // Fields
        private int _lookAhead;
        private bool _eofOn00;
        
        // Methods
        internal IndefiniteLengthInputStream(System.IO.Stream inStream, int limit)
        {
            this._eofOn00 = true;
            val_1 = new Org.BouncyCastle.Utilities.IO.BaseInputStream();
            mem[1152921553464531952] = inStream;
            mem[1152921553464531960] = limit;
            this._lookAhead = val_1.RequireByte();
            bool val_3 = val_1.CheckForEof();
        }
        internal void SetEofOn00(bool eofOn00)
        {
            this._eofOn00 = eofOn00;
            if(eofOn00 == false)
            {
                    return;
            }
            
            bool val_2 = this.CheckForEof();
        }
        private bool CheckForEof()
        {
            var val_4;
            if(this._lookAhead != 0)
            {
                    val_4 = this._lookAhead >> 31;
                return (bool)val_4;
            }
            
            if(this.RequireByte() == 0)
            {
                    this._lookAhead = 0;
                val_4 = 1;
                return (bool)val_4;
            }
            
            System.IO.IOException val_2 = new System.IO.IOException(message:  "malformed end-of-contents marker");
        }
        public override int Read(byte[] buffer, int offset, int count)
        {
            int val_3;
            var val_4;
            val_3 = offset;
            if(count < 2)
            {
                    return this.Read(buffer:  buffer, offset:  val_3, count:  count);
            }
            
            if(this._eofOn00 == true)
            {
                    return this.Read(buffer:  buffer, offset:  val_3, count:  count);
            }
            
            if((this._lookAhead & 2147483648) != 0)
            {
                goto label_3;
            }
            
            offset = val_3 + 1;
            count = count - 1;
            if(137150464 <= 0)
            {
                goto label_5;
            }
            
            val_3 = (long)val_3;
            buffer[val_3] = this._lookAhead;
            this._lookAhead = this.RequireByte();
            val_4 = 137150465;
            return (int)val_4;
            label_3:
            val_4 = 0;
            return (int)val_4;
            label_5:
            System.IO.EndOfStreamException val_2 = new System.IO.EndOfStreamException();
        }
        public override int ReadByte()
        {
            int val_3;
            if(this._eofOn00 != false)
            {
                    if(this.CheckForEof() != false)
            {
                    val_3 = 0;
                return val_3;
            }
            
            }
            
            val_3 = this._lookAhead;
            this._lookAhead = this.RequireByte();
            return val_3;
        }
        private int RequireByte()
        {
            if((this & 2147483648) == 0)
            {
                    return (int)this;
            }
            
            System.IO.EndOfStreamException val_1 = new System.IO.EndOfStreamException();
        }
    
    }

}
