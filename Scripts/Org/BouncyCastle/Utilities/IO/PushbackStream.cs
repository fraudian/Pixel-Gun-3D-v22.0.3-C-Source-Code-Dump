using UnityEngine;

namespace Org.BouncyCastle.Utilities.IO
{
    public class PushbackStream : FilterStream
    {
        // Fields
        private int buf;
        
        // Methods
        public PushbackStream(System.IO.Stream s)
        {
            this.buf = 0;
        }
        public override int ReadByte()
        {
            if(this.buf != 1)
            {
                    this.buf = 0;
                return (int)this.buf;
            }
            
            if(X19 == 0)
            {
                
            }
        
        }
        public override int Read(byte[] buffer, int offset, int count)
        {
            if((count >= 1) && (this.buf != 1))
            {
                    buffer[(long)offset] = this.buf;
                this.buf = 0;
                return 1;
            }
            
            if(this == null)
            {
                
            }
        
        }
        public virtual void Unread(int b)
        {
            if(this.buf == 1)
            {
                    this.buf = b & 255;
                return;
            }
            
            System.InvalidOperationException val_2 = new System.InvalidOperationException(message:  "Can only push back one byte");
        }
    
    }

}
