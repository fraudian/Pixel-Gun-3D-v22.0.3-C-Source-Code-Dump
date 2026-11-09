using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    internal class Check
    {
        // Methods
        internal static void DataLength(bool condition, string msg)
        {
            if(condition != true)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.DataLengthException val_1 = new Org.BouncyCastle.Crypto.DataLengthException(message:  msg);
        }
        internal static void DataLength(byte[] buf, int off, int len, string msg)
        {
            if((len + off) <= buf.Length)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.DataLengthException val_2 = new Org.BouncyCastle.Crypto.DataLengthException(message:  msg);
        }
        internal static void OutputLength(byte[] buf, int off, int len, string msg)
        {
            if((len + off) <= buf.Length)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.OutputLengthException val_2 = new Org.BouncyCastle.Crypto.OutputLengthException(message:  msg);
        }
        public Check()
        {
        
        }
    
    }

}
