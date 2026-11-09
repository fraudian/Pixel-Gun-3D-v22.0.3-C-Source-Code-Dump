using UnityEngine;

namespace Org.BouncyCastle.Utilities.IO
{
    public class TeeOutputStream : BaseOutputStream
    {
        // Fields
        private readonly System.IO.Stream output;
        private readonly System.IO.Stream tee;
        
        // Methods
        public TeeOutputStream(System.IO.Stream output, System.IO.Stream tee)
        {
            this.output = output;
            this.tee = tee;
        }
        public override void Close()
        {
            mem[1152921543903858232] = 1;
            this.Close();
        }
        public override void Write(byte[] buffer, int offset, int count)
        {
            if(this.tee == null)
            {
                
            }
        
        }
        public override void WriteByte(byte b)
        {
            if(this.tee == null)
            {
                
            }
        
        }
    
    }

}
