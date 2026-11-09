using UnityEngine;

namespace BestHTTP.Decompression.Zlib
{
    internal class DeflateStream : Stream
    {
        // Fields
        internal BestHTTP.Decompression.Zlib.ZlibBaseStream _baseStream;
        internal System.IO.Stream _innerStream;
        private bool _disposed;
        
        // Properties
        public virtual BestHTTP.Decompression.Zlib.FlushType FlushMode { get; set; }
        public int BufferSize { get; set; }
        public BestHTTP.Decompression.Zlib.CompressionStrategy Strategy { get; set; }
        public virtual long TotalIn { get; }
        public virtual long TotalOut { get; }
        public override bool CanRead { get; }
        public override bool CanSeek { get; }
        public override bool CanWrite { get; }
        public override long Length { get; }
        public override long Position { get; set; }
        
        // Methods
        public DeflateStream(System.IO.Stream stream, BestHTTP.Decompression.Zlib.CompressionMode mode)
        {
        
        }
        public DeflateStream(System.IO.Stream stream, BestHTTP.Decompression.Zlib.CompressionMode mode, BestHTTP.Decompression.Zlib.CompressionLevel level)
        {
        
        }
        public DeflateStream(System.IO.Stream stream, BestHTTP.Decompression.Zlib.CompressionMode mode, bool leaveOpen)
        {
            bool val_1 = leaveOpen;
        }
        public DeflateStream(System.IO.Stream stream, BestHTTP.Decompression.Zlib.CompressionMode mode, BestHTTP.Decompression.Zlib.CompressionLevel level, bool leaveOpen)
        {
            this._innerStream = stream;
            this._baseStream = new BestHTTP.Decompression.Zlib.ZlibBaseStream(stream:  stream, compressionMode:  mode, level:  level, flavor:  159, leaveOpen:  leaveOpen);
        }
        public DeflateStream(System.IO.Stream stream, BestHTTP.Decompression.Zlib.CompressionMode mode, BestHTTP.Decompression.Zlib.CompressionLevel level, bool leaveOpen, int windowBits)
        {
            this._innerStream = stream;
            this._baseStream = new BestHTTP.Decompression.Zlib.ZlibBaseStream(stream:  stream, compressionMode:  mode, level:  level, flavor:  159, leaveOpen:  leaveOpen, windowBits:  windowBits);
        }
        public virtual BestHTTP.Decompression.Zlib.FlushType get_FlushMode()
        {
            if(this._baseStream != null)
            {
                    return (BestHTTP.Decompression.Zlib.FlushType)this._baseStream._flushMode;
            }
            
            return (BestHTTP.Decompression.Zlib.FlushType)this._baseStream._flushMode;
        }
        public virtual void set_FlushMode(BestHTTP.Decompression.Zlib.FlushType value)
        {
            if(this._disposed != true)
            {
                    this._baseStream._flushMode = value;
                return;
            }
            
            System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "DeflateStream");
        }
        public int get_BufferSize()
        {
            if(this._baseStream != null)
            {
                    return (int)this._baseStream._bufferSize;
            }
            
            return (int)this._baseStream._bufferSize;
        }
        public void set_BufferSize(int value)
        {
            var val_5;
            var val_6;
            var val_7;
            if(this._disposed == true)
            {
                goto label_1;
            }
            
            if(this._baseStream._workingBuffer != null)
            {
                goto label_3;
            }
            
            if(value <= 1023)
            {
                goto label_4;
            }
            
            this._baseStream._bufferSize = value;
            return;
            label_1:
            System.ObjectDisposedException val_1 = null;
            val_5 = val_1;
            val_1 = new System.ObjectDisposedException(objectName:  "DeflateStream");
            goto label_6;
            label_3:
            BestHTTP.Decompression.Zlib.ZlibException val_2 = null;
            val_5 = val_2;
            val_2 = new BestHTTP.Decompression.Zlib.ZlibException(s:  "The working buffer is already set.");
            label_6:
            val_6 = 1152921553803197952;
            val_7 = val_5;
            goto label_7;
            label_4:
            val_6 = 1152921553803197952;
            val_7 = new BestHTTP.Decompression.Zlib.ZlibException(s:  System.String.Format(format:  "Don\'t be silly. {0} bytes?? Use a bigger buffer, at least {1}.", arg0:  value, arg1:  1024));
            label_7:
        }
        public BestHTTP.Decompression.Zlib.CompressionStrategy get_Strategy()
        {
            if(this._baseStream != null)
            {
                    return (BestHTTP.Decompression.Zlib.CompressionStrategy)this._baseStream.Strategy;
            }
            
            return (BestHTTP.Decompression.Zlib.CompressionStrategy)this._baseStream.Strategy;
        }
        public void set_Strategy(BestHTTP.Decompression.Zlib.CompressionStrategy value)
        {
            if(this._disposed != true)
            {
                    this._baseStream.Strategy = value;
                return;
            }
            
            System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "DeflateStream");
        }
        public virtual long get_TotalIn()
        {
            if(this._baseStream._z != null)
            {
                    return (long)this._baseStream._z.TotalBytesIn;
            }
            
            return (long)this._baseStream._z.TotalBytesIn;
        }
        public virtual long get_TotalOut()
        {
            if(this._baseStream._z != null)
            {
                    return (long)this._baseStream._z.TotalBytesOut;
            }
            
            return (long)this._baseStream._z.TotalBytesOut;
        }
        protected override void Dispose(bool disposing)
        {
            if(this._disposed != true)
            {
                    this._disposed = true;
            }
            
            this.Dispose(disposing:  disposing);
        }
        public override bool get_CanRead()
        {
            if(this._disposed != true)
            {
                    if(this._baseStream._stream != null)
            {
                goto typeof(System.IO.Stream).__il2cppRuntimeField_198;
            }
            
            }
            else
            {
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "DeflateStream");
            }
        
        }
        public override bool get_CanSeek()
        {
            return false;
        }
        public override bool get_CanWrite()
        {
            if(this._disposed != true)
            {
                    if(this._baseStream._stream != null)
            {
                goto typeof(System.IO.Stream).__il2cppRuntimeField_1C8;
            }
            
            }
            else
            {
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "DeflateStream");
            }
        
        }
        public override void Flush()
        {
            if(this._disposed != true)
            {
                    if(this._baseStream != null)
            {
                goto typeof(BestHTTP.Decompression.Zlib.ZlibBaseStream).__il2cppRuntimeField_268;
            }
            
            }
            else
            {
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "DeflateStream");
            }
        
        }
        public override long get_Length()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public override long get_Position()
        {
            BestHTTP.Decompression.Zlib.ZlibCodec val_1;
            BestHTTP.Decompression.Zlib.ZlibBaseStream val_2;
            long val_3;
            var val_4;
            val_1 = this;
            val_2 = this._baseStream;
            if(val_2 == null)
            {
                goto label_0;
            }
            
            if(this._baseStream._streamMode == 0)
            {
                goto label_1;
            }
            
            label_7:
            if(this._baseStream._streamMode != 1)
            {
                goto label_2;
            }
            
            val_1 = this._baseStream._z;
            val_3 = this._baseStream._z.TotalBytesIn;
            goto label_5;
            label_0:
            if(this._baseStream == null)
            {
                goto label_6;
            }
            
            val_2 = this._baseStream;
            if(this._baseStream._streamMode != 0)
            {
                goto label_7;
            }
            
            label_1:
            val_1 = this._baseStream._z;
            val_3 = this._baseStream._z.TotalBytesOut;
            label_5:
            val_4 = mem[this._baseStream._z.TotalBytesOut];
            val_4 = val_3;
            return (long)val_4;
            label_2:
            val_4 = 0;
            return (long)val_4;
            label_6:
        }
        public override void set_Position(long value)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public override int Read(byte[] buffer, int offset, int count)
        {
            if(this._disposed != true)
            {
                    if(this._baseStream != null)
            {
                goto typeof(BestHTTP.Decompression.Zlib.ZlibBaseStream).__il2cppRuntimeField_308;
            }
            
            }
            else
            {
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "DeflateStream");
            }
        
        }
        public override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public override void SetLength(long value)
        {
            if(this._baseStream == null)
            {
                
            }
        
        }
        public override void Write(byte[] buffer, int offset, int count)
        {
            if(this._disposed != true)
            {
                    if(this._baseStream != null)
            {
                goto typeof(BestHTTP.Decompression.Zlib.ZlibBaseStream).__il2cppRuntimeField_328;
            }
            
            }
            else
            {
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "DeflateStream");
            }
        
        }
        public static byte[] CompressString(string s)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            new BestHTTP.Decompression.Zlib.DeflateStream() = new BestHTTP.Decompression.Zlib.DeflateStream(stream:  val_1, mode:  0, level:  9, leaveOpen:  false);
            BestHTTP.Decompression.Zlib.ZlibBaseStream.CompressString(s:  s, compressor:  new BestHTTP.Decompression.Zlib.DeflateStream());
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_1.Dispose();
            if(0 != 1)
            {
                    return (System.Byte[])val_1;
            }
            
            if(0 == 0)
            {
                    return (System.Byte[])val_1;
            }
            
            return (System.Byte[])val_1;
        }
        public static byte[] CompressBuffer(byte[] b)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            new BestHTTP.Decompression.Zlib.DeflateStream() = new BestHTTP.Decompression.Zlib.DeflateStream(stream:  val_1, mode:  0, level:  9, leaveOpen:  false);
            BestHTTP.Decompression.Zlib.ZlibBaseStream.CompressBuffer(b:  b, compressor:  new BestHTTP.Decompression.Zlib.DeflateStream());
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_1.Dispose();
            if(0 != 1)
            {
                    return (System.Byte[])val_1;
            }
            
            if(0 == 0)
            {
                    return (System.Byte[])val_1;
            }
            
            return (System.Byte[])val_1;
        }
        public static string UncompressString(byte[] compressed)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  compressed);
            new BestHTTP.Decompression.Zlib.DeflateStream() = new BestHTTP.Decompression.Zlib.DeflateStream(stream:  val_1, mode:  1, level:  6, leaveOpen:  false);
            if(val_1 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                val_1.Dispose();
            }
            
            if(0 != 1)
            {
                    return (string)BestHTTP.Decompression.Zlib.ZlibBaseStream.UncompressString(compressed:  compressed, decompressor:  new BestHTTP.Decompression.Zlib.DeflateStream());
            }
            
            if(0 == 0)
            {
                    return (string)BestHTTP.Decompression.Zlib.ZlibBaseStream.UncompressString(compressed:  compressed, decompressor:  new BestHTTP.Decompression.Zlib.DeflateStream());
            }
            
            return (string)BestHTTP.Decompression.Zlib.ZlibBaseStream.UncompressString(compressed:  compressed, decompressor:  new BestHTTP.Decompression.Zlib.DeflateStream());
        }
        public static byte[] UncompressBuffer(byte[] compressed)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  compressed);
            new BestHTTP.Decompression.Zlib.DeflateStream() = new BestHTTP.Decompression.Zlib.DeflateStream(stream:  val_1, mode:  1, level:  6, leaveOpen:  false);
            if(val_1 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                val_1.Dispose();
            }
            
            if(0 != 1)
            {
                    return (System.Byte[])BestHTTP.Decompression.Zlib.ZlibBaseStream.UncompressBuffer(compressed:  compressed, decompressor:  new BestHTTP.Decompression.Zlib.DeflateStream());
            }
            
            if(0 == 0)
            {
                    return (System.Byte[])BestHTTP.Decompression.Zlib.ZlibBaseStream.UncompressBuffer(compressed:  compressed, decompressor:  new BestHTTP.Decompression.Zlib.DeflateStream());
            }
            
            return (System.Byte[])BestHTTP.Decompression.Zlib.ZlibBaseStream.UncompressBuffer(compressed:  compressed, decompressor:  new BestHTTP.Decompression.Zlib.DeflateStream());
        }
    
    }

}
