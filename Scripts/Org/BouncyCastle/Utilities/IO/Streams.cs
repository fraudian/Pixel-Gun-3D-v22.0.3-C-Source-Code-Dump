using UnityEngine;

namespace Org.BouncyCastle.Utilities.IO
{
    public sealed class Streams
    {
        // Fields
        private const int BufferSize = 512;
        
        // Methods
        private Streams()
        {
        
        }
        public static void Drain(System.IO.Stream inStr)
        {
            goto label_6;
            label_4:
            if(inStr != null)
            {
                goto label_3;
            }
            
            goto label_3;
            label_6:
            if(new byte[512] == null)
            {
                goto label_4;
            }
            
            label_3:
            if(inStr > 0)
            {
                goto label_6;
            }
        
        }
        public static byte[] ReadAll(System.IO.Stream inStr)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            Org.BouncyCastle.Utilities.IO.Streams.PipeAll(inStr:  inStr, outStr:  val_1);
            if(val_1 == null)
            {
                
            }
        
        }
        public static byte[] ReadAllLimited(System.IO.Stream inStr, int limit)
        {
            System.IO.MemoryStream val_1 = new System.IO.MemoryStream();
            long val_2 = Org.BouncyCastle.Utilities.IO.Streams.PipeAllLimited(inStr:  inStr, limit:  (long)limit, outStr:  val_1);
            if(val_1 == null)
            {
                
            }
        
        }
        public static int ReadFully(System.IO.Stream inStr, byte[] buf)
        {
            if(buf != null)
            {
                    return Org.BouncyCastle.Utilities.IO.Streams.ReadFully(inStr:  inStr, buf:  buf, off:  0, len:  buf.Length);
            }
            
            return Org.BouncyCastle.Utilities.IO.Streams.ReadFully(inStr:  inStr, buf:  buf, off:  0, len:  buf.Length);
        }
        public static int ReadFully(System.IO.Stream inStr, byte[] buf, int off, int len)
        {
            if(len < 1)
            {
                    return 1152921504642469888;
            }
            
            do
            {
                off = 0 + off;
                len = len - 0;
                if(inStr < 1)
            {
                    return 1152921504642469888;
            }
            
            }
            while(null < len);
            
            return 1152921504642469888;
        }
        public static void PipeAll(System.IO.Stream inStr, System.IO.Stream outStr)
        {
            goto label_3;
            label_8:
            if(outStr != null)
            {
                goto label_3;
            }
            
            goto label_3;
            label_6:
            if(inStr != null)
            {
                goto label_5;
            }
            
            goto label_5;
            label_3:
            if(new byte[512] == null)
            {
                goto label_6;
            }
            
            label_5:
            if(inStr > 0)
            {
                goto label_8;
            }
        
        }
        public static long PipeAllLimited(System.IO.Stream inStr, long limit, System.IO.Stream outStr)
        {
            var val_4 = 0;
            goto label_4;
            label_9:
            if((limit - val_4) < ((W24) << ))
            {
                goto label_2;
            }
            
            val_4 = val_4 + (long)(long)(int)(W24);
            if(outStr != null)
            {
                goto label_4;
            }
            
            goto label_4;
            label_7:
            if(inStr != null)
            {
                goto label_6;
            }
            
            goto label_6;
            label_4:
            if(new byte[512] == null)
            {
                goto label_7;
            }
            
            label_6:
            if(inStr > 0)
            {
                goto label_9;
            }
            
            return (long)val_4;
            label_2:
            Org.BouncyCastle.Utilities.IO.StreamOverflowException val_3 = new Org.BouncyCastle.Utilities.IO.StreamOverflowException(message:  "Data Overflow");
        }
    
    }

}
