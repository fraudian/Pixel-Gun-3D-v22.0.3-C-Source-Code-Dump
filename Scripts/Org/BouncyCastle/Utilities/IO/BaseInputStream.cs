using UnityEngine;

namespace Org.BouncyCastle.Utilities.IO
{
    public abstract class BaseInputStream : Stream
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
            return (bool)(this.closed == false) ? 1 : 0;
        }
        public sealed override bool get_CanSeek()
        {
            return false;
        }
        public sealed override bool get_CanWrite()
        {
            return false;
        }
        public override void Close()
        {
            this.closed = true;
            this.Close();
        }
        public sealed override void Flush()
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
        public override int Read(byte[] buffer, int offset, int count)
        {
            var val_5;
            var val_6;
            val_5 = this;
            int val_1 = count + offset;
            val_6 = offset;
            if(val_1 <= offset)
            {
                    return (int) - offset;
            }
            
            val_6 = (long)offset;
            do
            {
                int val_2 = this.ReadByte();
                if(val_2 == 1)
            {
                    return (int) - offset;
            }
            
                var val_3 = val_6 + 1;
                buffer[val_6] = val_2;
            }
            while(val_3 < (long)val_1);
            
            val_6 = val_3;
            return (int) - offset;
        }
        public sealed override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public sealed override void SetLength(long value)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        public sealed override void Write(byte[] buffer, int offset, int count)
        {
            System.NotSupportedException val_1 = new System.NotSupportedException();
        }
        protected BaseInputStream()
        {
        
        }
    
    }

}
