using UnityEngine;

namespace Org.BouncyCastle.Utilities.Zlib
{
    public class ZOutputStream : Stream
    {
        // Fields
        private const int BufferSize = 512;
        protected Org.BouncyCastle.Utilities.Zlib.ZStream z;
        protected int flushLevel;
        protected byte[] buf;
        protected byte[] buf1;
        protected bool compress;
        protected System.IO.Stream output;
        protected bool closed;
        
        // Properties
        public sealed override bool CanRead { get; }
        public sealed override bool CanSeek { get; }
        public sealed override bool CanWrite { get; }
        public virtual int FlushMode { get; set; }
        public sealed override long Length { get; }
        public sealed override long Position { get; set; }
        public virtual long TotalIn { get; }
        public virtual long TotalOut { get; }
        
        // Methods
        private static Org.BouncyCastle.Utilities.Zlib.ZStream GetDefaultZStream(bool nowrap)
        {
            Org.BouncyCastle.Utilities.Zlib.ZStream val_1 = new Org.BouncyCastle.Utilities.Zlib.ZStream();
            int val_3 = val_1.inflateInit(w:  15, nowrap:  nowrap);
            return val_1;
        }
        public ZOutputStream(System.IO.Stream output)
        {
            Org.BouncyCastle.Utilities.Zlib.ZStream val_1 = Org.BouncyCastle.Utilities.Zlib.ZOutputStream.GetDefaultZStream(nowrap:  false);
        }
        public ZOutputStream(System.IO.Stream output, bool nowrap)
        {
            Org.BouncyCastle.Utilities.Zlib.ZStream val_2 = Org.BouncyCastle.Utilities.Zlib.ZOutputStream.GetDefaultZStream(nowrap:  nowrap);
        }
        public ZOutputStream(System.IO.Stream output, Org.BouncyCastle.Utilities.Zlib.ZStream z)
        {
            Org.BouncyCastle.Utilities.Zlib.ZStream val_6 = z;
            this.buf = new byte[512];
            this.buf1 = new byte[1];
            if(val_6 == null)
            {
                    Org.BouncyCastle.Utilities.Zlib.ZStream val_3 = null;
                val_6 = val_3;
                val_3 = new Org.BouncyCastle.Utilities.Zlib.ZStream();
            }
            
            if(((Org.BouncyCastle.Utilities.Zlib.ZStream)[1152921543884512960].istate == null) && ((Org.BouncyCastle.Utilities.Zlib.ZStream)[1152921543884512960].dstate == null))
            {
                    int val_4 = val_3.inflateInit(w:  15, nowrap:  false);
            }
            
            this.output = output;
            this.z = val_6;
            this.compress = ((Org.BouncyCastle.Utilities.Zlib.ZStream)[1152921543884512960].istate == 0) ? 1 : 0;
        }
        public ZOutputStream(System.IO.Stream output, int level)
        {
        
        }
        public ZOutputStream(System.IO.Stream output, int level, bool nowrap)
        {
            this.buf = new byte[512];
            this.buf1 = new byte[1];
            this.output = output;
            this.compress = true;
            Org.BouncyCastle.Utilities.Zlib.ZStream val_3 = new Org.BouncyCastle.Utilities.Zlib.ZStream();
            this.z = val_3;
            nowrap = nowrap;
            int val_4 = val_3.deflateInit(level:  level, bits:  15, nowrap:  nowrap);
        }
        public sealed override bool get_CanRead()
        {
            return false;
        }
        public sealed override bool get_CanSeek()
        {
            return false;
        }
        public sealed override bool get_CanWrite()
        {
            return (bool)(this.closed == false) ? 1 : 0;
        }
        public override void Close()
        {
            if(this.closed != false)
            {
                    return;
            }
            
            this.DoClose();
            this.Close();
        }
        private void DoClose()
        {
            var val_2;
            var val_3;
            var val_4;
            System.IO.Stream val_5;
            val_3 = this;
            val_4 = 0;
            this.closed = true;
            val_5 = this.output;
            this.output = 0;
            if(0 == 1)
            {
                goto label_4;
            }
            
            if((val_4 == 0) || (43 == 43))
            {
                goto label_6;
            }
            
            label_7:
            val_2 = ???;
            val_4 = ???;
            val_3 = ???;
            val_5 = ???;
            label_4:
            if(val_4 != 0)
            {
                goto label_7;
            }
            
            label_6:
            var val_1 = val_2 - 48;
        }
        public virtual void End()
        {
            if(this.z == null)
            {
                    return;
            }
            
            if(this.compress == false)
            {
                goto label_1;
            }
            
            if(this.z.dstate == null)
            {
                goto label_6;
            }
            
            if((this.z.dstate.status != 42) && (this.z.dstate.status != 666))
            {
                    if(this.z.dstate.status != 113)
            {
                goto label_5;
            }
            
            }
            
            this.z.dstate.pending_buf = 0;
            this.z.dstate.window = 0;
            this.z.dstate.prev = 0;
            this.z.dstate.head = 0;
            label_5:
            this.z.dstate = 0;
            goto label_6;
            label_1:
            int val_1 = this.z.inflateEnd();
            label_6:
            this.z.next_in = 0;
            this.z.next_out = 0;
            this.z.msg = 0;
            this.z._adler = 0;
            this.z = 0;
        }
        public virtual void Finish()
        {
            var val_7;
            Org.BouncyCastle.Utilities.Zlib.Deflate val_8;
            Org.BouncyCastle.Utilities.Zlib.ZStream val_9;
            val_7 = this;
            val_8 = 110639;
            label_21:
            if(this.z == null)
            {
                    val_8 = 0;
            }
            
            this.z.next_out = this.buf;
            if(this.z == null)
            {
                    val_8 = 0;
            }
            
            this.z.next_out_index = 0;
            if(this.buf == null)
            {
                goto label_3;
            }
            
            label_10:
            this.z.avail_out = this.buf.Length;
            if(this.z == null)
            {
                goto label_5;
            }
            
            if(this.compress == false)
            {
                goto label_6;
            }
            
            label_11:
            val_8 = this.z.dstate;
            if(val_8 == null)
            {
                goto label_13;
            }
            
            int val_1 = val_8.deflate(strm:  this.z, flush:  4);
            goto label_8;
            label_3:
            if(this.z != null)
            {
                goto label_10;
            }
            
            goto label_10;
            label_5:
            val_8 = 0;
            if(this.compress == true)
            {
                goto label_11;
            }
            
            label_6:
            if(this.z.istate == null)
            {
                goto label_13;
            }
            
            label_8:
            if((val_8.inflate(z:  this.z, f:  4)) >= 2)
            {
                goto label_13;
            }
            
            val_9 = this.z;
            if((this.buf.Length - this.z.avail_out) >= 1)
            {
                    val_9 = this.output;
            }
            
            if((this.z.avail_in > 0) || (this.z.avail_out == 0))
            {
                goto label_21;
            }
            
            val_7 = ???;
            goto typeof(Org.BouncyCastle.Utilities.Zlib.ZOutputStream).__il2cppRuntimeField_268;
            label_13:
            System.IO.IOException val_6 = new System.IO.IOException(message:  ((val_7 + 72) != 0) ? "de" : "in"(((val_7 + 72) != 0) ? "de" : "in") + "flating: "("flating: ") + val_7 + 40 + 64(val_7 + 40 + 64));
        }
        public override void Flush()
        {
            if(this.output == null)
            {
                
            }
        
        }
        public virtual int get_FlushMode()
        {
            return (int)this.flushLevel;
        }
        public virtual void set_FlushMode(int value)
        {
            this.flushLevel = value;
        }
        public sealed override long get_Length()
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public sealed override long get_Position()
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public sealed override void set_Position(long value)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public sealed override int Read(byte[] buffer, int offset, int count)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public sealed override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public sealed override void SetLength(long value)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public virtual long get_TotalIn()
        {
            if(this.z != null)
            {
                    return (long)this.z.total_in;
            }
            
            return (long)this.z.total_in;
        }
        public virtual long get_TotalOut()
        {
            if(this.z != null)
            {
                    return (long)this.z.total_out;
            }
            
            return (long)this.z.total_out;
        }
        public override void Write(byte[] b, int off, int len)
        {
            int val_7;
            var val_8;
            val_7 = off;
            val_8 = 110644;
            if(len == 0)
            {
                    return;
            }
            
            if(this.z == null)
            {
                    val_8 = 0;
            }
            
            this.z.next_in = b;
            if(this.z == null)
            {
                    val_8 = 0;
            }
            
            this.z.next_in_index = val_7;
            if(this.z == null)
            {
                    val_8 = 0;
            }
            
            this.z.avail_in = len;
            label_25:
            if(this.z == null)
            {
                    val_8 = 0;
            }
            
            this.z.next_out = this.buf;
            if(this.z == null)
            {
                    val_8 = 0;
            }
            
            this.z.next_out_index = 0;
            if(this.buf == null)
            {
                goto label_7;
            }
            
            label_15:
            this.z.avail_out = this.buf.Length;
            if(this.z == null)
            {
                goto label_9;
            }
            
            if(this.compress == false)
            {
                goto label_10;
            }
            
            label_16:
            if(this.z.dstate == null)
            {
                goto label_18;
            }
            
            if((this.z.dstate.deflate(strm:  this.z, flush:  this.flushLevel)) == 0)
            {
                goto label_12;
            }
            
            goto label_18;
            label_7:
            if(this.z != null)
            {
                goto label_15;
            }
            
            goto label_15;
            label_9:
            val_8 = 0;
            if(this.compress == true)
            {
                goto label_16;
            }
            
            label_10:
            if((this.z.istate == null) || ((val_8.inflate(z:  this.z, f:  this.flushLevel)) != 0))
            {
                goto label_18;
            }
            
            label_12:
            val_7 = this.output;
            int val_3 = this.buf.Length - this.z.avail_out;
            if((this.z.avail_in > 0) || (this.z.avail_out == 0))
            {
                goto label_25;
            }
            
            return;
            label_18:
            System.IO.IOException val_6 = new System.IO.IOException(message:  (this.compress == true) ? "de" : "in"((this.compress == true) ? "de" : "in") + "flating: "("flating: ") + this.z.msg);
        }
        public override void WriteByte(byte b)
        {
            this.buf1[0] = b;
            goto typeof(Org.BouncyCastle.Utilities.Zlib.ZOutputStream).__il2cppRuntimeField_328;
        }
    
    }

}
