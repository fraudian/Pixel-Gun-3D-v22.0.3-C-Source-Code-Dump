using UnityEngine;

namespace Org.BouncyCastle.Asn1
{
    internal class ConstructedOctetStream : BaseInputStream
    {
        // Fields
        private readonly Org.BouncyCastle.Asn1.Asn1StreamParser _parser;
        private bool _first;
        private System.IO.Stream _currentStream;
        
        // Methods
        internal ConstructedOctetStream(Org.BouncyCastle.Asn1.Asn1StreamParser parser)
        {
            this._first = true;
            this._parser = parser;
        }
        public override int Read(byte[] buffer, int offset, int count)
        {
            Org.BouncyCastle.Asn1.Asn1StreamParser val_4;
            int val_5;
            int val_6;
            System.IO.Stream val_7;
            var val_8;
            var val_10;
            var val_11;
            val_5 = count;
            val_6 = offset;
            val_7 = this._currentStream;
            if(val_7 == null)
            {
                goto label_1;
            }
            
            val_4 = this._parser;
            goto label_2;
            label_1:
            if(this._first == false)
            {
                goto label_5;
            }
            
            val_4 = this;
            val_5 = this._parser;
            if(val_5 == null)
            {
                goto label_5;
            }
            
            val_8 = val_6;
            var val_10 = val_5;
            if(val_10 == null)
            {
                goto label_6;
            }
            
            this._first = false;
            var val_6 = val_5;
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_10;
            label_21:
            val_7 = this._currentStream;
            val_6 = val_6;
            label_2:
            val_6 = val_10 + val_6;
            val_6 = val_6 - val_10;
            goto label_11;
            label_20:
            if(null == null)
            {
                goto label_13;
            }
            
            val_8 = null;
            if(null == null)
            {
                goto label_14;
            }
            
            var val_9 = mem[this._parser];
            if((mem[this._parser] + 286) == 0)
            {
                goto label_18;
            }
            
            var val_7 = mem[this._parser] + 176;
            var val_8 = 0;
            val_7 = val_7 + 8;
            label_17:
            if(((mem[this._parser] + 176 + 8) + -8) == null)
            {
                goto label_16;
            }
            
            val_8 = val_8 + 1;
            val_7 = val_7 + 16;
            if(val_8 < (mem[this._parser] + 286))
            {
                goto label_17;
            }
            
            goto label_18;
            label_16:
            val_9 = val_9 + (((mem[this._parser] + 176 + 8)) << 4);
            val_10 = val_9 + 296;
            label_18:
            val_7 = null.GetOctetStream();
            this._currentStream = val_7;
            label_11:
            if(val_7 < 1)
            {
                goto label_20;
            }
            
            val_5 = val_5;
            val_10 = val_7 + val_10;
            if(val_10 != val_5)
            {
                goto label_21;
            }
            
            val_11 = val_5;
            return (int)val_11;
            label_14:
            label_13:
            this._currentStream = 0;
            return (int)val_11;
            label_6:
            label_5:
            val_11 = 0;
            return (int)val_11;
            label_10:
            this._currentStream = val_10.GetOctetStream();
            goto label_2;
        }
        public override int ReadByte()
        {
            var val_5;
            System.IO.Stream val_6;
            var val_7;
            val_5 = this;
            val_6 = this._currentStream;
            if(val_6 != null)
            {
                goto label_1;
            }
            
            if(this._first == false)
            {
                goto label_2;
            }
            
            val_6 = this._parser;
            if(val_6 == null)
            {
                    return (int)val_3;
            }
            
            if(val_6 == null)
            {
                goto label_5;
            }
            
            this._first = false;
            var val_4 = 0;
            val_4 = val_4 + 1;
            goto label_22;
            label_5:
            label_2:
            val_6 = 0;
            return (int)val_3;
            label_25:
            val_7 = (1152921553416585688 + ((X11) << 4)) + 296;
            goto label_13;
            label_22:
            label_13:
            System.IO.Stream val_3 = val_6.GetOctetStream();
            this._currentStream = val_3;
            if(val_3 == null)
            {
                goto label_25;
            }
            
            label_1:
            if((val_3 & 2147483648) == 0)
            {
                    return (int)val_3;
            }
            
            if(this._parser == null)
            {
                goto label_17;
            }
            
            if(this._parser == null)
            {
                goto label_18;
            }
            
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_22;
            label_18:
            label_17:
            this._currentStream = 0;
            return (int)val_3;
        }
    
    }

}
