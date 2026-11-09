using UnityEngine;

namespace Org.BouncyCastle.Utilities.IO
{
    public class FilterStream : Stream
    {
        // Fields
        protected readonly System.IO.Stream s;
        
        // Properties
        public override bool CanRead { get; }
        public override bool CanSeek { get; }
        public override bool CanWrite { get; }
        public override long Length { get; }
        public override long Position { get; set; }
        
        // Methods
        public FilterStream(System.IO.Stream s)
        {
            this.s = s;
        }
        public override bool get_CanRead()
        {
            if(this.s == null)
            {
                
            }
        
        }
        public override bool get_CanSeek()
        {
            if(this.s == null)
            {
                
            }
        
        }
        public override bool get_CanWrite()
        {
            if(this.s == null)
            {
                
            }
        
        }
        public override long get_Length()
        {
            if(this.s == null)
            {
                
            }
        
        }
        public override long get_Position()
        {
            if(this.s == null)
            {
                
            }
        
        }
        public override void set_Position(long value)
        {
            if(this.s == null)
            {
                
            }
        
        }
        public override void Close()
        {
            this.Close();
        }
        public override void Flush()
        {
            if(this.s == null)
            {
                
            }
        
        }
        public override long Seek(long offset, System.IO.SeekOrigin origin)
        {
            if(this.s == null)
            {
                
            }
        
        }
        public override void SetLength(long value)
        {
            if(this.s == null)
            {
                
            }
        
        }
        public override int Read(byte[] buffer, int offset, int count)
        {
            if(this.s == null)
            {
                
            }
        
        }
        public override int ReadByte()
        {
            if(this.s == null)
            {
                
            }
        
        }
        public override void Write(byte[] buffer, int offset, int count)
        {
            if(this.s == null)
            {
                
            }
        
        }
        public override void WriteByte(byte value)
        {
            if(this.s == null)
            {
                
            }
        
        }
    
    }

}
