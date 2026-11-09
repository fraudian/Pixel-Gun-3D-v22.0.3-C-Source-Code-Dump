using UnityEngine;

namespace Org.BouncyCastle.Utilities.Zlib
{
    public sealed class ZStream
    {
        // Fields
        private const int MAX_WBITS = 15;
        private const int DEF_WBITS = 15;
        private const int Z_NO_FLUSH = 0;
        private const int Z_PARTIAL_FLUSH = 1;
        private const int Z_SYNC_FLUSH = 2;
        private const int Z_FULL_FLUSH = 3;
        private const int Z_FINISH = 4;
        private const int MAX_MEM_LEVEL = 9;
        private const int Z_OK = 0;
        private const int Z_STREAM_END = 1;
        private const int Z_NEED_DICT = 2;
        private const int Z_ERRNO = -1;
        private const int Z_STREAM_ERROR = -2;
        private const int Z_DATA_ERROR = -3;
        private const int Z_MEM_ERROR = -4;
        private const int Z_BUF_ERROR = -5;
        private const int Z_VERSION_ERROR = -6;
        public byte[] next_in;
        public int next_in_index;
        public int avail_in;
        public long total_in;
        public byte[] next_out;
        public int next_out_index;
        public int avail_out;
        public long total_out;
        public string msg;
        internal Org.BouncyCastle.Utilities.Zlib.Deflate dstate;
        internal Org.BouncyCastle.Utilities.Zlib.Inflate istate;
        internal int data_type;
        public long adler;
        internal Org.BouncyCastle.Utilities.Zlib.Adler32 _adler;
        
        // Methods
        public int inflateInit()
        {
            return this.inflateInit(w:  15, nowrap:  false);
        }
        public int inflateInit(bool nowrap)
        {
            return this.inflateInit(w:  15, nowrap:  nowrap);
        }
        public int inflateInit(int w)
        {
            return this.inflateInit(w:  w, nowrap:  false);
        }
        public int inflateInit(int w, bool nowrap)
        {
            Org.BouncyCastle.Utilities.Zlib.Inflate val_1 = new Org.BouncyCastle.Utilities.Zlib.Inflate();
            this.istate = val_1;
            if(val_1 != null)
            {
                    return val_1.inflateInit(z:  this, w:  (nowrap != true) ? (-w) : w);
            }
            
            return val_1.inflateInit(z:  this, w:  (nowrap != true) ? (-w) : w);
        }
        public int inflate(int f)
        {
            if(this.istate == null)
            {
                    return -2;
            }
            
            return this.inflate(z:  this, f:  f);
        }
        public int inflateEnd()
        {
            var val_1;
            if(this.istate != null)
            {
                    if(this.istate.blocks != null)
            {
                    this.istate.blocks.reset(z:  this, c:  0);
                this.istate.blocks.hufts = 0;
                this.istate.blocks.window = 0;
            }
            
                val_1 = 0;
                this.istate.blocks = 0;
                this.istate = 0;
                return (int)val_1;
            }
            
            val_1 = -2;
            return (int)val_1;
        }
        public int inflateSync()
        {
            if(this.istate == null)
            {
                    return -2;
            }
            
            return this.istate.inflateSync(z:  this);
        }
        public int inflateSetDictionary(byte[] dictionary, int dictLength)
        {
            if(this.istate == null)
            {
                    return -2;
            }
            
            return this.inflateSetDictionary(z:  this, dictionary:  dictionary, dictLength:  dictLength);
        }
        public int deflateInit(int level)
        {
            return this.deflateInit(level:  level, bits:  15, nowrap:  false);
        }
        public int deflateInit(int level, bool nowrap)
        {
            return this.deflateInit(level:  level, bits:  15, nowrap:  nowrap);
        }
        public int deflateInit(int level, int bits)
        {
            return this.deflateInit(level:  level, bits:  bits, nowrap:  false);
        }
        public int deflateInit(int level, int bits, bool nowrap)
        {
            Org.BouncyCastle.Utilities.Zlib.Deflate val_1 = new Org.BouncyCastle.Utilities.Zlib.Deflate();
            this.dstate = val_1;
            if(val_1 != null)
            {
                    return val_1.deflateInit2(strm:  this, level:  level, method:  8, windowBits:  (nowrap != true) ? (-bits) : bits, memLevel:  8, strategy:  0);
            }
            
            return val_1.deflateInit2(strm:  this, level:  level, method:  8, windowBits:  (nowrap != true) ? (-bits) : bits, memLevel:  8, strategy:  0);
        }
        public int deflate(int flush)
        {
            if(this.dstate == null)
            {
                    return -2;
            }
            
            return this.dstate.deflate(strm:  this, flush:  flush);
        }
        public int deflateEnd()
        {
            var val_2;
            if(this.dstate == null)
            {
                goto label_0;
            }
            
            if((this.dstate.status != 42) && (this.dstate.status != 666))
            {
                    if(this.dstate.status != 113)
            {
                goto label_3;
            }
            
            }
            
            var val_1 = (this.dstate.status != 113) ? 0 : -3;
            this.dstate.pending_buf = 0;
            this.dstate.window = 0;
            this.dstate.prev = 0;
            this.dstate.head = 0;
            goto label_4;
            label_0:
            val_2 = -2;
            return (int)val_2;
            label_3:
            val_2 = -2;
            label_4:
            this.dstate = 0;
            return (int)val_2;
        }
        public int deflateParams(int level, int strategy)
        {
            if(this.dstate == null)
            {
                    return -2;
            }
            
            return this.dstate.deflateParams(strm:  this, _level:  level, _strategy:  strategy);
        }
        public int deflateSetDictionary(byte[] dictionary, int dictLength)
        {
            if(this.dstate == null)
            {
                    return -2;
            }
            
            return this.dstate.deflateSetDictionary(strm:  this, dictionary:  dictionary, dictLength:  dictLength);
        }
        internal void flush_pending()
        {
            Org.BouncyCastle.Utilities.Zlib.Deflate val_4;
            Org.BouncyCastle.Utilities.Zlib.Deflate val_5;
            Org.BouncyCastle.Utilities.Zlib.Deflate val_6;
            int val_7;
            Org.BouncyCastle.Utilities.Zlib.Deflate val_8;
            int val_9;
            val_4 = this;
            int val_1 = (this.dstate.pending > this.avail_out) ? this.avail_out : this.dstate.pending;
            if(val_1 == 0)
            {
                    return;
            }
            
            if((this.dstate.pending_out < this.dstate.pending_buf.Length) && (this.next_out_index < this.next_out.Length))
            {
                    int val_4 = this.dstate.pending_out;
                val_4 = val_4 + val_1;
            }
            
            val_5 = this.dstate;
            if(this.dstate != null)
            {
                goto label_13;
            }
            
            val_5 = this.dstate;
            if(val_5 == null)
            {
                goto label_14;
            }
            
            label_13:
            System.Array.Copy(sourceArray:  this.dstate.pending_buf, sourceIndex:  this.dstate.pending_out, destinationArray:  this.next_out, destinationIndex:  this.next_out_index, length:  val_1);
            int val_5 = this.next_out_index;
            val_6 = this.dstate;
            val_5 = val_5 + val_1;
            this.next_out_index = val_5;
            if(val_6 != null)
            {
                    val_7 = this.dstate.pending_out;
            }
            else
            {
                    val_6 = 44;
                val_7 = 0;
            }
            
            mem[44] = val_7 + val_1;
            long val_6 = this.total_out;
            int val_7 = this.avail_out;
            val_8 = this.dstate;
            val_6 = val_6 + (val_1 << );
            val_7 = val_7 - val_1;
            this.total_out = val_6;
            this.avail_out = val_7;
            if(val_8 != null)
            {
                    val_9 = this.dstate.pending;
            }
            else
            {
                    val_8 = 48;
                val_9 = 0;
            }
            
            mem[48] = val_9 - val_1;
            if(this.dstate.pending != 0)
            {
                    return;
            }
            
            val_4 = this.dstate;
            this.dstate.pending_out = 0;
            return;
            label_14:
        }
        internal int read_buf(byte[] buf, int start, int size)
        {
            Org.BouncyCastle.Utilities.Zlib.Deflate val_3;
            int val_3 = this.avail_in;
            int val_1 = (val_3 > size) ? size : (val_3);
            if(val_1 == 0)
            {
                    return val_1;
            }
            
            val_3 = this.dstate;
            val_3 = val_3 - val_1;
            this.avail_in = val_3;
            if(this.dstate.noheader == 0)
            {
                    val_3 = this.adler;
                this.adler = 0.adler32(adler:  val_3, buf:  this.next_in, index:  this.next_in_index, len:  val_1);
            }
            
            System.Array.Copy(sourceArray:  this.next_in, sourceIndex:  this.next_in_index, destinationArray:  buf, destinationIndex:  start, length:  val_1);
            int val_4 = this.next_in_index;
            long val_5 = this.total_in;
            val_4 = val_4 + val_1;
            val_5 = val_5 + (val_1 << );
            this.next_in_index = val_4;
            this.total_in = val_5;
            return val_1;
        }
        public void free()
        {
            this.next_in = 0;
            this.next_out = 0;
            this.msg = 0;
            this._adler = 0;
        }
        public ZStream()
        {
            this._adler = new Org.BouncyCastle.Utilities.Zlib.Adler32();
        }
    
    }

}
