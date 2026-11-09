using UnityEngine;

namespace Org.BouncyCastle.Utilities
{
    public abstract class Strings
    {
        // Methods
        internal static bool IsOneOf(string s, string[] candidates)
        {
            var val_2;
            var val_3;
            val_2 = 0;
            label_3:
            if(val_2 >= candidates.Length)
            {
                goto label_1;
            }
            
            val_2 = val_2 + 1;
            if((System.String.op_Equality(a:  s, b:  candidates[0])) == false)
            {
                goto label_3;
            }
            
            val_3 = 1;
            return (bool)val_3;
            label_1:
            val_3 = 0;
            return (bool)val_3;
        }
        public static string FromByteArray(byte[] bs)
        {
            var val_3;
            char[] val_1 = new char[0];
            val_3 = 0;
            goto label_2;
            label_8:
            val_3 = 1;
            val_1[0] = System.Convert.ToChar(value:  bs[0]);
            label_2:
            if(val_3 < val_1.Length)
            {
                goto label_8;
            }
            
            return 0.CreateString(val:  val_1);
        }
        public static byte[] ToByteArray(char[] cs)
        {
            var val_3;
            byte[] val_1 = new byte[0];
            val_3 = 0;
            goto label_2;
            label_8:
            val_3 = 1;
            val_1[0] = System.Convert.ToByte(value:  cs[0]);
            label_2:
            if(val_3 < val_1.Length)
            {
                goto label_8;
            }
            
            return (System.Byte[])val_1;
        }
        public static byte[] ToByteArray(string s)
        {
            var val_5;
            int val_1 = s.Length;
            byte[] val_2 = new byte[0];
            val_5 = 0;
            goto label_2;
            label_8:
            val_5 = 1;
            val_2[0] = System.Convert.ToByte(value:  s.Chars[0]);
            label_2:
            if(val_5 < val_2.Length)
            {
                goto label_8;
            }
            
            return (System.Byte[])val_2;
        }
        public static string FromAsciiByteArray(byte[] bytes)
        {
            if(bytes == null)
            {
                goto label_0;
            }
            
            label_3:
            System.Text.Encoding.ASCII = ???;
            goto typeof(System.Text.Encoding).__il2cppRuntimeField_368;
            label_0:
            if(System.Text.Encoding.ASCII != 0)
            {
                goto label_3;
            }
            
            goto label_3;
        }
        public static byte[] ToAsciiByteArray(char[] cs)
        {
            if(System.Text.Encoding.ASCII == null)
            {
                
            }
        
        }
        public static byte[] ToAsciiByteArray(string s)
        {
            if(System.Text.Encoding.ASCII == null)
            {
                
            }
        
        }
        public static string FromUtf8ByteArray(byte[] bytes)
        {
            if(bytes == null)
            {
                goto label_0;
            }
            
            label_3:
            System.Text.Encoding.UTF8 = ???;
            goto typeof(System.Text.Encoding).__il2cppRuntimeField_368;
            label_0:
            if(System.Text.Encoding.UTF8 != 0)
            {
                goto label_3;
            }
            
            goto label_3;
        }
        public static byte[] ToUtf8ByteArray(char[] cs)
        {
            if(System.Text.Encoding.UTF8 == null)
            {
                
            }
        
        }
        public static byte[] ToUtf8ByteArray(string s)
        {
            if(System.Text.Encoding.UTF8 == null)
            {
                
            }
        
        }
        protected Strings()
        {
        
        }
    
    }

}
