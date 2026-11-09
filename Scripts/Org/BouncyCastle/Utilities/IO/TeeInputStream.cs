using UnityEngine;

namespace Org.BouncyCastle.Utilities.IO
{
    public class TeeInputStream : BaseInputStream
    {
        // Fields
        private readonly System.IO.Stream input;
        private readonly System.IO.Stream tee;
        
        // Methods
        public TeeInputStream(System.IO.Stream input, System.IO.Stream tee)
        {
            this.input = input;
            this.tee = tee;
        }
        public override void Close()
        {
            mem[1152921543903270968] = 1;
            this.Close();
        }
        public override int Read(byte[] buf, int off, int len)
        {
            if(this.input < 1)
            {
                    return (int)this.input;
            }
            
            return (int)this.input;
        }
        public override int ReadByte()
        {
            if((this.input & 2147483648) != 0)
            {
                    return (int)this.input;
            }
            
            return (int)this.input;
        }
    
    }

}
