using UnityEngine;

namespace BestHTTP.Decompression.Zlib
{
    internal class GZipStream : Stream
    {
        // Fields
        public System.Nullable<System.DateTime> LastModified;
        private int _headerByteCount;
        internal BestHTTP.Decompression.Zlib.ZlibBaseStream _baseStream;
        private bool _disposed;
        private bool _firstReadDone;
        private string _FileName;
        private string _Comment;
        private int _Crc32;
        internal static readonly System.DateTime _unixEpoch;
        internal static readonly System.Text.Encoding iso8859dash1;
        
        // Properties
        public string Comment { get; set; }
        public string FileName { get; set; }
        public int Crc32 { get; }
        public virtual BestHTTP.Decompression.Zlib.FlushType FlushMode { get; set; }
        public int BufferSize { get; set; }
        public virtual long TotalIn { get; }
        public virtual long TotalOut { get; }
        public override bool CanRead { get; }
        public override bool CanSeek { get; }
        public override bool CanWrite { get; }
        public override long Length { get; }
        public override long Position { get; set; }
        
        // Methods
        public string get_Comment()
        {
            return (string)this._Comment;
        }
        public void set_Comment(string value)
        {
            if(this._disposed != true)
            {
                    this._Comment = value;
                return;
            }
            
            System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "GZipStream");
        }
        public string get_FileName()
        {
            return (string)this._FileName;
        }
        public void set_FileName(string value)
        {
            string val_8;
            var val_9;
            if(this._disposed == true)
            {
                goto label_1;
            }
            
            this._FileName = value;
            if(value == null)
            {
                    return;
            }
            
            val_8 = this._FileName;
            if((value.IndexOf(value:  "/")) != 1)
            {
                    val_8 = val_8.Replace(oldValue:  "/", newValue:  "\\");
                this._FileName = val_8;
            }
            
            if((val_8.EndsWith(value:  "\\")) == true)
            {
                goto label_6;
            }
            
            if((this._FileName.IndexOf(value:  "\\")) == 1)
            {
                    return;
            }
            
            this._FileName = System.IO.Path.GetFileName(path:  this._FileName);
            return;
            label_1:
            System.ObjectDisposedException val_6 = null;
            val_9 = val_6;
            val_6 = new System.ObjectDisposedException(objectName:  "GZipStream");
            goto label_11;
            label_6:
            System.Exception val_7 = null;
            val_9 = val_7;
            val_7 = new System.Exception(message:  "Illegal filename");
            label_11:
        }
        public int get_Crc32()
        {
            return (int)this._Crc32;
        }
        public GZipStream(System.IO.Stream stream, BestHTTP.Decompression.Zlib.CompressionMode mode)
        {
        
        }
        public GZipStream(System.IO.Stream stream, BestHTTP.Decompression.Zlib.CompressionMode mode, BestHTTP.Decompression.Zlib.CompressionLevel level)
        {
        
        }
        public GZipStream(System.IO.Stream stream, BestHTTP.Decompression.Zlib.CompressionMode mode, bool leaveOpen)
        {
            bool val_1 = leaveOpen;
        }
        public GZipStream(System.IO.Stream stream, BestHTTP.Decompression.Zlib.CompressionMode mode, BestHTTP.Decompression.Zlib.CompressionLevel level, bool leaveOpen)
        {
            this._baseStream = new BestHTTP.Decompression.Zlib.ZlibBaseStream(stream:  stream, compressionMode:  mode, level:  level, flavor:  160, leaveOpen:  leaveOpen);
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
            
            System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "GZipStream");
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
            val_1 = new System.ObjectDisposedException(objectName:  "GZipStream");
            goto label_6;
            label_3:
            BestHTTP.Decompression.Zlib.ZlibException val_2 = null;
            val_5 = val_2;
            val_2 = new BestHTTP.Decompression.Zlib.ZlibException(s:  "The working buffer is already set.");
            label_6:
            val_6 = 1152921553808095648;
            val_7 = val_5;
            goto label_7;
            label_4:
            val_6 = 1152921553808095648;
            val_7 = new BestHTTP.Decompression.Zlib.ZlibException(s:  System.String.Format(format:  "Don\'t be silly. {0} bytes?? Use a bigger buffer, at least {1}.", arg0:  value, arg1:  1024));
            label_7:
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
                    if((disposing != false) && (this._baseStream != null))
            {
                    this._Crc32 = this._baseStream.Crc32;
            }
            
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
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "GZipStream");
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
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "GZipStream");
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
                    System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "GZipStream");
            }
        
        }
        public override long get_Length()
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public override long get_Position()
        {
            BestHTTP.Decompression.Zlib.ZlibBaseStream val_2;
            BestHTTP.Decompression.Zlib.ZlibBaseStream val_3;
            long val_4;
            int val_5;
            var val_6;
            val_2 = this;
            val_3 = this._baseStream;
            if(val_3 == null)
            {
                goto label_0;
            }
            
            if(this._baseStream._streamMode == 0)
            {
                goto label_1;
            }
            
            label_8:
            if(this._baseStream._streamMode != 1)
            {
                goto label_2;
            }
            
            val_2 = this._baseStream;
            val_4 = this._baseStream._z.TotalBytesIn;
            val_5 = this._baseStream._gzipHeaderByteCount;
            goto label_6;
            label_0:
            if(this._baseStream == null)
            {
                goto label_7;
            }
            
            val_3 = this._baseStream;
            if(this._baseStream._streamMode != 0)
            {
                goto label_8;
            }
            
            label_1:
            val_4 = this._baseStream._z.TotalBytesOut;
            val_5 = this._headerByteCount;
            label_6:
            val_6 = val_4 + val_5;
            return (long)val_6;
            label_2:
            val_6 = 0;
            return (long)val_6;
            label_7:
        }
        public override void set_Position(long value)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public override int Read(byte[] buffer, int offset, int count)
        {
            if(this._disposed != true)
            {
                    if(this._firstReadDone == true)
            {
                    return (int)this._baseStream;
            }
            
                this._firstReadDone = true;
                this.FileName = this._baseStream._GzipFileName;
                offset = this._baseStream;
                this.Comment = this._baseStream._GzipComment;
                return (int)this._baseStream;
            }
            
            System.ObjectDisposedException val_1 = new System.ObjectDisposedException(objectName:  "GZipStream");
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
            var val_5;
            if(this._disposed == true)
            {
                goto label_1;
            }
            
            if(this._baseStream._streamMode != 2)
            {
                goto label_3;
            }
            
            if(this._baseStream._wantCompress == false)
            {
                goto label_5;
            }
            
            this._headerByteCount = this.EmitHeader();
            label_3:
            if(this._baseStream != null)
            {
                goto typeof(BestHTTP.Decompression.Zlib.ZlibBaseStream).__il2cppRuntimeField_328;
            }
            
            goto typeof(BestHTTP.Decompression.Zlib.ZlibBaseStream).__il2cppRuntimeField_328;
            label_1:
            System.ObjectDisposedException val_3 = null;
            val_5 = val_3;
            val_3 = new System.ObjectDisposedException(objectName:  "GZipStream");
            goto label_7;
            label_5:
            System.InvalidOperationException val_4 = null;
            val_5 = val_4;
            val_4 = new System.InvalidOperationException();
            label_7:
        }
        private int EmitHeader()
        {
            string val_9;
            var val_10;
            string val_11;
            System.Array val_12;
            string val_13;
            var val_14;
            System.Array val_15;
            var val_16;
            var val_17;
            int val_18;
            ulong val_19;
            var val_20;
            int val_21;
            var val_22;
            val_9 = this._Comment;
            if(val_9 != null)
            {
                    val_10 = null;
                val_10 = null;
                val_11 = this._Comment;
                val_12 = BestHTTP.Decompression.Zlib.GZipStream.iso8859dash1;
            }
            
            val_13 = this._FileName;
            if(val_13 != null)
            {
                    val_14 = null;
                val_14 = null;
                val_13 = this._FileName;
                val_15 = BestHTTP.Decompression.Zlib.GZipStream.iso8859dash1;
            }
            else
            {
                    val_15 = 0;
            }
            
            if(this._Comment != null)
            {
                    if(val_12 != null)
            {
                goto label_12;
            }
            
            }
            else
            {
                    val_16 = 0;
            }
            
            label_12:
            if(this._FileName != null)
            {
                    val_17 = 28563616 + 1;
            }
            else
            {
                    val_17 = 0;
            }
            
            var val_2 = (val_16 + val_17) + 10;
            byte[] val_3 = new byte[0];
            val_18 = val_3.Length;
            if(val_18 == 0)
            {
                    val_18 = val_3.Length;
            }
            
            val_3[0] = 31;
            if(val_18 <= 1)
            {
                    val_18 = val_3.Length;
            }
            
            val_3[0] = 139;
            if(val_18 <= 2)
            {
                    val_18 = val_3.Length;
            }
            
            val_3[0] = 8;
            var val_4 = (this._Comment == null) ? 0 : 16;
            val_3[0] = (this._FileName == null) ? (val_4) : (val_4 | 8);
            if((this.LastModified & 1) == 0)
            {
                    System.DateTime val_7 = System.DateTime.Now;
                this.LastModified = 0;
                mem[1152921553810452064] = 0;
            }
            
            val_19 = this.LastModified;
            val_20 = null;
            val_20 = null;
            System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_19}, d2:  new System.DateTime() {dateData = BestHTTP.Decompression.Zlib.GZipStream._unixEpoch});
            System.Array.Copy(sourceArray:  System.BitConverter.GetBytes(value:  (int)val_8._ticks.TotalSeconds), sourceIndex:  0, destinationArray:  val_3, destinationIndex:  4, length:  4);
            val_21 = val_3.Length;
            if(val_21 <= 8)
            {
                    val_21 = val_3.Length;
            }
            
            val_3[1] = 0;
            val_3[1] = 255;
            if(val_17 == 0)
            {
                goto label_32;
            }
            
            System.Array.Copy(sourceArray:  val_15, sourceIndex:  0, destinationArray:  val_3, destinationIndex:  10, length:  val_17 - 1);
            val_22 = val_17 + 10;
            val_19 = (long)val_17 + 9;
            val_3[val_19] = 0;
            if(val_16 != 0)
            {
                goto label_34;
            }
            
            goto label_36;
            label_32:
            val_22 = 10;
            if(val_16 == 0)
            {
                goto label_36;
            }
            
            label_34:
            val_19 = val_16 - 1;
            System.Array.Copy(sourceArray:  val_12, sourceIndex:  0, destinationArray:  val_3, destinationIndex:  10, length:  val_19);
            val_3[(long)10 + val_19] = 0;
            label_36:
            if(this._baseStream._stream != null)
            {
                    return (int)val_3.Length;
            }
            
            return (int)val_3.Length;
        }
        public static byte[] CompressString(string s)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            new BestHTTP.Decompression.Zlib.GZipStream() = new BestHTTP.Decompression.Zlib.GZipStream(stream:  val_1, mode:  0, level:  9, leaveOpen:  false);
            BestHTTP.Decompression.Zlib.ZlibBaseStream.CompressString(s:  s, compressor:  new BestHTTP.Decompression.Zlib.GZipStream());
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
            new BestHTTP.Decompression.Zlib.GZipStream() = new BestHTTP.Decompression.Zlib.GZipStream(stream:  val_1, mode:  0, level:  9, leaveOpen:  false);
            BestHTTP.Decompression.Zlib.ZlibBaseStream.CompressBuffer(b:  b, compressor:  new BestHTTP.Decompression.Zlib.GZipStream());
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
            new BestHTTP.Decompression.Zlib.GZipStream() = new BestHTTP.Decompression.Zlib.GZipStream(stream:  val_1, mode:  1, level:  6, leaveOpen:  false);
            if(val_1 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                val_1.Dispose();
            }
            
            if(0 != 1)
            {
                    return (string)BestHTTP.Decompression.Zlib.ZlibBaseStream.UncompressString(compressed:  compressed, decompressor:  new BestHTTP.Decompression.Zlib.GZipStream());
            }
            
            if(0 == 0)
            {
                    return (string)BestHTTP.Decompression.Zlib.ZlibBaseStream.UncompressString(compressed:  compressed, decompressor:  new BestHTTP.Decompression.Zlib.GZipStream());
            }
            
            return (string)BestHTTP.Decompression.Zlib.ZlibBaseStream.UncompressString(compressed:  compressed, decompressor:  new BestHTTP.Decompression.Zlib.GZipStream());
        }
        public static byte[] UncompressBuffer(byte[] compressed)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream(buffer:  compressed);
            new BestHTTP.Decompression.Zlib.GZipStream() = new BestHTTP.Decompression.Zlib.GZipStream(stream:  val_1, mode:  1, level:  6, leaveOpen:  false);
            if(val_1 != null)
            {
                    var val_5 = 0;
                val_5 = val_5 + 1;
                val_1.Dispose();
            }
            
            if(0 != 1)
            {
                    return (System.Byte[])BestHTTP.Decompression.Zlib.ZlibBaseStream.UncompressBuffer(compressed:  compressed, decompressor:  new BestHTTP.Decompression.Zlib.GZipStream());
            }
            
            if(0 == 0)
            {
                    return (System.Byte[])BestHTTP.Decompression.Zlib.ZlibBaseStream.UncompressBuffer(compressed:  compressed, decompressor:  new BestHTTP.Decompression.Zlib.GZipStream());
            }
            
            return (System.Byte[])BestHTTP.Decompression.Zlib.ZlibBaseStream.UncompressBuffer(compressed:  compressed, decompressor:  new BestHTTP.Decompression.Zlib.GZipStream());
        }
        private static GZipStream()
        {
            BestHTTP.Decompression.Zlib.GZipStream._unixEpoch = 0;
            BestHTTP.Decompression.Zlib.GZipStream.iso8859dash1 = System.Text.Encoding.GetEncoding(name:  "iso-8859-1");
        }
    
    }

}
