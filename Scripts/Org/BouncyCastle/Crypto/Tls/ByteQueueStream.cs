using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class ByteQueueStream : Stream
    {
        // Fields
        private readonly Org.BouncyCastle.Crypto.Tls.ByteQueue buffer;
        
        // Properties
        public virtual int Available { get; }
        public override bool CanRead { get; }
        public override bool CanSeek { get; }
        public override bool CanWrite { get; }
        public override long Length { get; }
        public override long Position { get; set; }
        
        // Methods
        public ByteQueueStream()
        {
            this.buffer = new Org.BouncyCastle.Crypto.Tls.ByteQueue(capacity:  1024);
        }
        public virtual int get_Available()
        {
            if(this.buffer != null)
            {
                    return (int)this.buffer.available;
            }
            
            return (int)this.buffer.available;
        }
        public override bool get_CanRead()
        {
            return true;
        }
        public override bool get_CanSeek()
        {
            return false;
        }
        public override bool get_CanWrite()
        {
            return true;
        }
        public override void Flush()
        {
        
        }
        public override long get_Length()
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public virtual int Peek(byte[] buf)
        {
            int val_1 = System.Math.Min(val1:  this.buffer.available, val2:  buf.Length);
            this.buffer.Read(buf:  buf, offset:  0, len:  val_1, skip:  0);
            return val_1;
        }
        public override long get_Position()
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public override void set_Position(long value)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public virtual int Read(byte[] buf)
        {
            if(buf == null)
            {
                
            }
        
        }
        public override int Read(byte[] buf, int off, int len)
        {
            int val_1 = System.Math.Min(val1:  this.buffer.available, val2:  len);
            this.buffer.Read(buf:  buf, offset:  off, len:  val_1, skip:  0);
            this.buffer.RemoveData(i:  val_1);
            return val_1;
        }
        public override int ReadByte()
        {
            var val_2;
            byte val_3;
            val_2 = this;
            if(this.buffer.available != 0)
            {
                    val_2 = this.buffer.RemoveData(len:  1, skip:  0);
                val_3 = val_2[0];
                return (int)val_3;
            }
            
            val_3 = 0;
            return (int)val_3;
        }
        public override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public override void SetLength(long value)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public virtual int Skip(int n)
        {
            int val_1 = System.Math.Min(val1:  this.buffer.available, val2:  n);
            this.buffer.RemoveData(i:  val_1);
            return val_1;
        }
        public virtual void Write(byte[] buf)
        {
            if(buf == null)
            {
                goto label_0;
            }
            
            label_3:
            this.buffer.AddData(data:  buf, offset:  0, len:  buf.Length);
            return;
            label_0:
            if(this.buffer != null)
            {
                goto label_3;
            }
            
            goto label_3;
        }
        public override void Write(byte[] buf, int off, int len)
        {
            this.buffer.AddData(data:  buf, offset:  off, len:  len);
        }
        public override void WriteByte(byte b)
        {
            byte[] val_1 = new byte[1];
            val_1[0] = b;
            this.buffer.AddData(data:  val_1, offset:  0, len:  1);
        }
    
    }

}
