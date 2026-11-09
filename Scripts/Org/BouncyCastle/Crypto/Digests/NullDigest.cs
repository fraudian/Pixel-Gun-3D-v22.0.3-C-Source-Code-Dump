using UnityEngine;

namespace Org.BouncyCastle.Crypto.Digests
{
    public class NullDigest : IDigest
    {
        // Fields
        private readonly System.IO.MemoryStream bOut;
        
        // Properties
        public string AlgorithmName { get; }
        
        // Methods
        public string get_AlgorithmName()
        {
            return "NULL";
        }
        public int GetByteLength()
        {
            return 0;
        }
        public int GetDigestSize()
        {
            if(this.bOut != null)
            {
                    return (int)this.bOut;
            }
            
            return (int)this.bOut;
        }
        public void Update(byte b)
        {
            if(this.bOut == null)
            {
                
            }
        
        }
        public void BlockUpdate(byte[] inBytes, int inOff, int len)
        {
            if(this.bOut == null)
            {
                
            }
        
        }
        public int DoFinal(byte[] outBytes, int outOff)
        {
            this.bOut.CopyTo(array:  outBytes, index:  outOff);
            if(this.bOut != null)
            {
                    return 0;
            }
            
            return 0;
        }
        public void Reset()
        {
            if(this.bOut == null)
            {
                
            }
        
        }
        public NullDigest()
        {
            this.bOut = new System.IO.MemoryStream();
        }
    
    }

}
