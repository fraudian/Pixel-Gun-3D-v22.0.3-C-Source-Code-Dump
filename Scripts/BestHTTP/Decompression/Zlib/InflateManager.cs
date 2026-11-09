using UnityEngine;

namespace BestHTTP.Decompression.Zlib
{
    internal sealed class InflateManager
    {
        // Fields
        private const int PRESET_DICT = 32;
        private const int Z_DEFLATED = 8;
        private BestHTTP.Decompression.Zlib.InflateManager.InflateManagerMode mode;
        internal BestHTTP.Decompression.Zlib.ZlibCodec _codec;
        internal int method;
        internal uint computedCheck;
        internal uint expectedCheck;
        internal int marker;
        private bool _handleRfc1950HeaderBytes;
        internal int wbits;
        internal BestHTTP.Decompression.Zlib.InflateBlocks blocks;
        private static readonly byte[] mark;
        
        // Properties
        internal bool HandleRfc1950HeaderBytes { get; set; }
        
        // Methods
        internal bool get_HandleRfc1950HeaderBytes()
        {
            return (bool)this._handleRfc1950HeaderBytes;
        }
        internal void set_HandleRfc1950HeaderBytes(bool value)
        {
            this._handleRfc1950HeaderBytes = value;
        }
        public InflateManager()
        {
            this._handleRfc1950HeaderBytes = true;
        }
        public InflateManager(bool expectRfc1950HeaderBytes)
        {
            this._handleRfc1950HeaderBytes = true;
            this._handleRfc1950HeaderBytes = expectRfc1950HeaderBytes;
        }
        internal int Reset()
        {
            if(this._codec != null)
            {
                    this._codec.TotalBytesOut = 0;
            }
            else
            {
                    mem[56] = 0;
            }
            
            this._codec.TotalBytesIn = 0;
            this._codec.Message = 0;
            this.mode = (this._handleRfc1950HeaderBytes == true) ? 0 : 7;
            uint val_2 = this.blocks.Reset();
            return 0;
        }
        internal int End()
        {
            if(this.blocks != null)
            {
                    uint val_1 = this.blocks.Reset();
                this.blocks.hufts = 0;
                this.blocks.window = 0;
            }
            
            this.blocks = 0;
            return 0;
        }
        internal int Initialize(BestHTTP.Decompression.Zlib.ZlibCodec codec, int w)
        {
            this._codec = codec;
            codec.Message = 0;
            this.blocks = 0;
            if((w & 4294967288) == 8)
            {
                    this.wbits = w;
                BestHTTP.Decompression.Zlib.InflateBlocks val_5 = new BestHTTP.Decompression.Zlib.InflateBlocks(codec:  codec, checkfn:  (this._handleRfc1950HeaderBytes == true) ? (this) : 0, w:  1 << (w & 31));
                this.blocks = val_5;
                int val_6 = this.Reset();
                return 0;
            }
            
            int val_7 = this.End();
            BestHTTP.Decompression.Zlib.ZlibException val_8 = new BestHTTP.Decompression.Zlib.ZlibException(s:  "Bad window size.");
        }
        internal int Inflate(BestHTTP.Decompression.Zlib.FlushType flush)
        {
            var val_27;
            int val_28;
            InflateManagerMode val_35;
            string val_84;
            var val_85;
            var val_86;
            if(this._codec.InputBuffer == null)
            {
                goto label_2;
            }
            
            val_27 = -5;
            val_28 = 28;
            val_35 = this.mode;
            if(val_35 > 13)
            {
                goto label_59;
            }
            
            var val_29 = 106049324 + (this.mode) << 2;
            val_29 = val_29 + 106049324;
            goto (106049324 + (this.mode) << 2 + 106049324);
            label_59:
            val_84 = "Stream error.";
            goto label_156;
            label_2:
            BestHTTP.Decompression.Zlib.ZlibException val_26 = null;
            val_84 = "InputBuffer is null. ";
            label_156:
            val_26 = new BestHTTP.Decompression.Zlib.ZlibException(s:  val_84);
            val_85 = 1152921553817700320;
            val_86 = val_26;
        }
        internal int SetDictionary(byte[] dictionary)
        {
            BestHTTP.Decompression.Zlib.InflateBlocks val_5;
            int val_6;
            int val_7;
            int val_8;
            var val_9;
            if(this.mode != 6)
            {
                goto label_2;
            }
            
            val_5 = 1152921505560571904;
            val_6 = dictionary.Length;
            val_7 = val_6;
            if((BestHTTP.Decompression.Zlib.Adler.Adler32(adler:  1, buf:  dictionary, index:  0, len:  null)) != this._codec._Adler32)
            {
                goto label_7;
            }
            
            uint val_4 = 1;
            this._codec._Adler32 = val_4;
            int val_3 = this.wbits;
            val_3 = val_3 & 31;
            val_4 = val_4 << val_3;
            if(val_4 <= val_6)
            {
                goto label_12;
            }
            
            val_8 = 0;
            goto label_13;
            label_7:
            val_9 = -3;
            return (int)val_9;
            label_12:
            val_6 = val_4 - 1;
            val_8 = dictionary.Length - val_6;
            label_13:
            val_5 = this.blocks;
            System.Array.Copy(sourceArray:  dictionary, sourceIndex:  val_8, destinationArray:  this.blocks.window, destinationIndex:  0, length:  val_6);
            val_9 = 0;
            this.blocks.readAt = val_6;
            this.blocks.writeAt = val_6;
            this.mode = 7;
            return (int)val_9;
            label_2:
            BestHTTP.Decompression.Zlib.ZlibException val_2 = new BestHTTP.Decompression.Zlib.ZlibException(s:  "Stream error.");
        }
        internal int Sync()
        {
            BestHTTP.Decompression.Zlib.ZlibCodec val_7;
            int val_8;
            int val_9;
            int val_11;
            var val_12;
            var val_13;
            BestHTTP.Decompression.Zlib.ZlibCodec val_14;
            BestHTTP.Decompression.Zlib.ZlibCodec val_15;
            BestHTTP.Decompression.Zlib.ZlibCodec val_16;
            if(this.mode != 13)
            {
                    this.mode = 13;
                this.marker = 0;
            }
            
            if(this._codec.AvailableBytesIn == 0)
            {
                goto label_3;
            }
            
            val_7 = this._codec;
            if(this._codec == null)
            {
                    val_7 = this._codec;
            }
            
            val_8 = this.marker;
            val_9 = this._codec.NextIn;
            var val_1 = (val_7 == 0) ? 1 : 0;
            if(val_8 <= 3)
            {
                goto label_5;
            }
            
            val_11 = this._codec.AvailableBytesIn;
            goto label_20;
            label_3:
            val_12 = -5;
            return (int)val_12;
            label_5:
            label_21:
            val_13 = null;
            val_13 = null;
            System.Byte[] val_2 = BestHTTP.Decompression.Zlib.InflateManager.mark + (long)val_8;
            if(this._codec.InputBuffer[(long)val_9] == ((BestHTTP.Decompression.Zlib.InflateManager.mark + (long)(int)(this.marker)) + 32))
            {
                    val_8 = val_8 + 1;
            }
            else
            {
                    val_8 = (this._codec.InputBuffer[(long)val_9] == 0) ? (4 - val_8) : 0;
            }
            
            val_7 = this._codec;
            val_9 = val_9 + 1;
            val_11 = this._codec.AvailableBytesIn - 1;
            if(val_8 <= 3)
            {
                    if(this._codec.AvailableBytesIn != 1)
            {
                goto label_21;
            }
            
            }
            
            label_20:
            val_14 = val_7;
            if(((val_7 == 0) ? 1 : 0) != 0)
            {
                    val_14 = this._codec;
            }
            
            int val_8 = this._codec.NextIn;
            val_8 = val_9 - val_8;
            val_8 = this._codec.TotalBytesIn + (val_8 << );
            this._codec.TotalBytesIn = val_8;
            this._codec.NextIn = val_9;
            val_15 = this._codec;
            this._codec.AvailableBytesIn = val_11;
            this.marker = val_8;
            if(val_8 != 4)
            {
                goto label_26;
            }
            
            val_16 = this._codec;
            if(this._codec != null)
            {
                goto label_27;
            }
            
            val_16 = this._codec;
            if(val_16 == null)
            {
                goto label_28;
            }
            
            label_27:
            int val_5 = this.Reset();
            this._codec.TotalBytesIn = this._codec.TotalBytesIn;
            val_15 = this._codec;
            val_12 = 0;
            this._codec.TotalBytesOut = this._codec.TotalBytesOut;
            this.mode = 7;
            return (int)val_12;
            label_26:
            val_12 = -3;
            return (int)val_12;
            label_28:
        }
        internal int SyncPoint(BestHTTP.Decompression.Zlib.ZlibCodec z)
        {
            return (int)(this.blocks.mode == 1) ? 1 : 0;
        }
        private static InflateManager()
        {
            int val_2;
            byte[] val_1 = new byte[4];
            val_2 = val_1.Length;
            if(val_2 <= 2)
            {
                    val_2 = val_1.Length;
            }
            
            val_1[0] = 255;
            val_1[0] = 255;
            BestHTTP.Decompression.Zlib.InflateManager.mark = val_1;
        }
    
    }

}
