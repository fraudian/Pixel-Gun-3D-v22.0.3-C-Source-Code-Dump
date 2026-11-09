using UnityEngine;

namespace BestHTTP.Decompression.Zlib
{
    internal sealed class ZlibCodec
    {
        // Fields
        public byte[] InputBuffer;
        public int NextIn;
        public int AvailableBytesIn;
        public long TotalBytesIn;
        public byte[] OutputBuffer;
        public int NextOut;
        public int AvailableBytesOut;
        public long TotalBytesOut;
        public string Message;
        internal BestHTTP.Decompression.Zlib.DeflateManager dstate;
        internal BestHTTP.Decompression.Zlib.InflateManager istate;
        internal uint _Adler32;
        public BestHTTP.Decompression.Zlib.CompressionLevel CompressLevel;
        public int WindowBits;
        public BestHTTP.Decompression.Zlib.CompressionStrategy Strategy;
        
        // Properties
        public int Adler32 { get; }
        
        // Methods
        public int get_Adler32()
        {
            return (int)this._Adler32;
        }
        public ZlibCodec()
        {
            this.CompressLevel = 15;
        }
        public ZlibCodec(BestHTTP.Decompression.Zlib.CompressionMode mode)
        {
            string val_5;
            this.CompressLevel = 15;
            if(mode == 1)
            {
                goto label_1;
            }
            
            if(mode != 0)
            {
                goto label_2;
            }
            
            if((this._InternalInitializeDeflate(wantRfc1950Header:  true)) == 0)
            {
                    return;
            }
            
            val_5 = "Cannot initialize for deflate.";
            goto label_6;
            label_1:
            if((this.InitializeInflate(windowBits:  this.WindowBits, expectRfc1950Header:  true)) != 0)
            {
                goto label_5;
            }
            
            return;
            label_2:
            val_5 = "Invalid ZlibStreamFlavor.";
            goto label_6;
            label_5:
            val_5 = "Cannot initialize for inflate.";
            label_6:
            null = new BestHTTP.Decompression.Zlib.ZlibException(s:  val_5);
        }
        public int InitializeInflate()
        {
            return this.InitializeInflate(windowBits:  this.WindowBits, expectRfc1950Header:  true);
        }
        public int InitializeInflate(bool expectRfc1950Header)
        {
            return this.InitializeInflate(windowBits:  this.WindowBits, expectRfc1950Header:  expectRfc1950Header);
        }
        public int InitializeInflate(int windowBits)
        {
            this.WindowBits = windowBits;
            return this.InitializeInflate(windowBits:  windowBits, expectRfc1950Header:  true);
        }
        public int InitializeInflate(int windowBits, bool expectRfc1950Header)
        {
            this.WindowBits = windowBits;
            if(this.dstate == null)
            {
                    BestHTTP.Decompression.Zlib.InflateManager val_2 = new BestHTTP.Decompression.Zlib.InflateManager(expectRfc1950HeaderBytes:  expectRfc1950Header);
                this.istate = val_2;
                if(val_2 != null)
            {
                    return val_2.Initialize(codec:  this, w:  windowBits);
            }
            
                return val_2.Initialize(codec:  this, w:  windowBits);
            }
            
            BestHTTP.Decompression.Zlib.ZlibException val_3 = new BestHTTP.Decompression.Zlib.ZlibException(s:  "You may not call InitializeInflate() after calling InitializeDeflate().");
        }
        public int Inflate(BestHTTP.Decompression.Zlib.FlushType flush)
        {
            if(this.istate != null)
            {
                    return this.istate.Inflate(flush:  flush);
            }
            
            BestHTTP.Decompression.Zlib.ZlibException val_1 = new BestHTTP.Decompression.Zlib.ZlibException(s:  "No Inflate State!");
        }
        public int EndInflate()
        {
            if(this.istate != null)
            {
                    this.istate = 0;
                return (int)this.istate.End();
            }
            
            BestHTTP.Decompression.Zlib.ZlibException val_2 = new BestHTTP.Decompression.Zlib.ZlibException(s:  "No Inflate State!");
        }
        public int SyncInflate()
        {
            if(this.istate != null)
            {
                    return this.istate.Sync();
            }
            
            BestHTTP.Decompression.Zlib.ZlibException val_1 = new BestHTTP.Decompression.Zlib.ZlibException(s:  "No Inflate State!");
        }
        public int InitializeDeflate()
        {
            return this._InternalInitializeDeflate(wantRfc1950Header:  true);
        }
        public int InitializeDeflate(BestHTTP.Decompression.Zlib.CompressionLevel level)
        {
            this.CompressLevel = level;
            return this._InternalInitializeDeflate(wantRfc1950Header:  true);
        }
        public int InitializeDeflate(BestHTTP.Decompression.Zlib.CompressionLevel level, bool wantRfc1950Header)
        {
            this.CompressLevel = level;
            return this._InternalInitializeDeflate(wantRfc1950Header:  wantRfc1950Header);
        }
        public int InitializeDeflate(BestHTTP.Decompression.Zlib.CompressionLevel level, int bits)
        {
            this.CompressLevel = level;
            this.WindowBits = bits;
            return this._InternalInitializeDeflate(wantRfc1950Header:  true);
        }
        public int InitializeDeflate(BestHTTP.Decompression.Zlib.CompressionLevel level, int bits, bool wantRfc1950Header)
        {
            this.CompressLevel = level;
            this.WindowBits = bits;
            return this._InternalInitializeDeflate(wantRfc1950Header:  wantRfc1950Header);
        }
        private int _InternalInitializeDeflate(bool wantRfc1950Header)
        {
            if(this.istate == null)
            {
                    BestHTTP.Decompression.Zlib.DeflateManager val_1 = new BestHTTP.Decompression.Zlib.DeflateManager();
                this.dstate = val_1;
                val_1.WantRfc1950HeaderBytes = wantRfc1950Header;
                if(this.dstate != null)
            {
                    return this.dstate.Initialize(codec:  this, level:  this.CompressLevel, bits:  this.WindowBits, compressionStrategy:  this.Strategy);
            }
            
                return this.dstate.Initialize(codec:  this, level:  this.CompressLevel, bits:  this.WindowBits, compressionStrategy:  this.Strategy);
            }
            
            BestHTTP.Decompression.Zlib.ZlibException val_3 = new BestHTTP.Decompression.Zlib.ZlibException(s:  "You may not call InitializeDeflate() after calling InitializeInflate().");
        }
        public int Deflate(BestHTTP.Decompression.Zlib.FlushType flush)
        {
            if(this.dstate != null)
            {
                    return this.dstate.Deflate(flush:  flush);
            }
            
            BestHTTP.Decompression.Zlib.ZlibException val_1 = new BestHTTP.Decompression.Zlib.ZlibException(s:  "No Deflate State!");
        }
        public int EndDeflate()
        {
            if(this.dstate != null)
            {
                    this.dstate = 0;
                return 0;
            }
            
            BestHTTP.Decompression.Zlib.ZlibException val_1 = new BestHTTP.Decompression.Zlib.ZlibException(s:  "No Deflate State!");
        }
        public void ResetDeflate()
        {
            if(this.dstate != null)
            {
                    this.dstate.Reset();
                return;
            }
            
            BestHTTP.Decompression.Zlib.ZlibException val_1 = new BestHTTP.Decompression.Zlib.ZlibException(s:  "No Deflate State!");
        }
        public int SetDeflateParams(BestHTTP.Decompression.Zlib.CompressionLevel level, BestHTTP.Decompression.Zlib.CompressionStrategy strategy)
        {
            if(this.dstate != null)
            {
                    return this.dstate.SetParams(level:  level, strategy:  strategy);
            }
            
            BestHTTP.Decompression.Zlib.ZlibException val_1 = new BestHTTP.Decompression.Zlib.ZlibException(s:  "No Deflate State!");
        }
        public int SetDictionary(byte[] dictionary)
        {
            if(this.istate != null)
            {
                    return this.istate.SetDictionary(dictionary:  dictionary);
            }
            
            if(this.dstate != null)
            {
                    return this.dstate.SetDictionary(dictionary:  dictionary);
            }
            
            BestHTTP.Decompression.Zlib.ZlibException val_1 = new BestHTTP.Decompression.Zlib.ZlibException(s:  "No Inflate or Deflate state!");
        }
        internal void flush_pending()
        {
            BestHTTP.Decompression.Zlib.DeflateManager val_6;
            BestHTTP.Decompression.Zlib.DeflateManager val_7;
            BestHTTP.Decompression.Zlib.DeflateManager val_8;
            int val_9;
            BestHTTP.Decompression.Zlib.DeflateManager val_10;
            int val_11;
            val_6 = this;
            int val_1 = (this.dstate.pendingCount > this.AvailableBytesOut) ? this.AvailableBytesOut : this.dstate.pendingCount;
            if(val_1 == 0)
            {
                    return;
            }
            
            if((this.dstate.nextPending >= this.dstate.pending.Length) || (this.NextOut >= this.OutputBuffer.Length))
            {
                goto label_14;
            }
            
            int val_6 = this.dstate.nextPending;
            val_6 = val_6 + val_1;
            if(val_6 > this.dstate.pending.Length)
            {
                goto label_14;
            }
            
            int val_7 = this.NextOut;
            val_7 = val_7 + val_1;
            if(val_7 > this.OutputBuffer.Length)
            {
                goto label_14;
            }
            
            val_7 = this.dstate;
            if(this.dstate != null)
            {
                goto label_15;
            }
            
            val_7 = this.dstate;
            if(val_7 == null)
            {
                goto label_16;
            }
            
            label_15:
            System.Array.Copy(sourceArray:  this.dstate.pending, sourceIndex:  this.dstate.nextPending, destinationArray:  this.OutputBuffer, destinationIndex:  this.NextOut, length:  val_1);
            int val_8 = this.NextOut;
            val_8 = this.dstate;
            val_8 = val_8 + val_1;
            this.NextOut = val_8;
            if(val_8 != null)
            {
                    val_9 = this.dstate.nextPending;
            }
            else
            {
                    val_8 = 48;
                val_9 = 0;
            }
            
            mem[48] = val_9 + val_1;
            long val_9 = this.TotalBytesOut;
            int val_10 = this.AvailableBytesOut;
            val_10 = this.dstate;
            val_9 = val_9 + (val_1 << );
            val_10 = val_10 - val_1;
            this.TotalBytesOut = val_9;
            this.AvailableBytesOut = val_10;
            if(val_10 != null)
            {
                    val_11 = this.dstate.pendingCount;
            }
            else
            {
                    val_10 = 52;
                val_11 = 3670080;
            }
            
            mem[52] = val_11 - val_1;
            if(this.dstate.pendingCount != 0)
            {
                    return;
            }
            
            val_6 = this.dstate;
            this.dstate.nextPending = 0;
            return;
            label_14:
            BestHTTP.Decompression.Zlib.ZlibException val_5 = new BestHTTP.Decompression.Zlib.ZlibException(s:  System.String.Format(format:  "Invalid State. (pending.Length={0}, pendingCount={1})", arg0:  this.dstate.pending.Length, arg1:  this.dstate.pendingCount));
            label_16:
        }
        internal int read_buf(byte[] buf, int start, int size)
        {
            BestHTTP.Decompression.Zlib.DeflateManager val_4;
            int val_4 = this.AvailableBytesIn;
            int val_1 = (val_4 > size) ? size : (val_4);
            if(val_1 == 0)
            {
                    return val_1;
            }
            
            val_4 = this.dstate;
            val_4 = val_4 - val_1;
            this.AvailableBytesIn = val_4;
            if(val_4.WantRfc1950HeaderBytes != false)
            {
                    val_4 = this.InputBuffer;
                this._Adler32 = BestHTTP.Decompression.Zlib.Adler.Adler32(adler:  this._Adler32, buf:  val_4, index:  this.NextIn, len:  val_1);
            }
            
            System.Array.Copy(sourceArray:  this.InputBuffer, sourceIndex:  this.NextIn, destinationArray:  buf, destinationIndex:  start, length:  val_1);
            int val_5 = this.NextIn;
            long val_6 = this.TotalBytesIn;
            val_5 = val_5 + val_1;
            val_6 = val_6 + (val_1 << );
            this.NextIn = val_5;
            this.TotalBytesIn = val_6;
            return val_1;
        }
    
    }

}
