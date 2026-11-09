using UnityEngine;

namespace Org.BouncyCastle.Utilities.IO
{
    public abstract class BaseOutputStream : Stream
    {
        // Fields
        private bool closed;
        
        // Properties
        public sealed override bool CanRead { get; }
        public sealed override bool CanSeek { get; }
        public sealed override bool CanWrite { get; }
        public sealed override long Length { get; }
        public sealed override long Position { get; set; }
        
        // Methods
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
            this.closed = true;
            this.Close();
        }
        public override void Flush()
        {
        
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
        public override void Write(byte[] buffer, int offset, int count)
        {
            int val_3 = offset;
            int val_1 = count + val_3;
            if(val_1 <= val_3)
            {
                    return;
            }
            
            var val_2 = (long)val_1 - (val_3 << );
            do
            {
                this.WriteByte(value:  0);
                val_2 = val_2 - 1;
                val_3 = val_3 + 1;
            }
            while(val_2 != 0);
        
        }
        public virtual void Write(byte[] buffer)
        {
            if(buffer == null)
            {
                
            }
        
        }
        protected BaseOutputStream()
        {
        
        }
    
    }

}
