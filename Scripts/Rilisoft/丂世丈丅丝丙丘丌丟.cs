using UnityEngine;

namespace Rilisoft
{
    public sealed class 丂世丈丅丝丙丘丌丟
    {
        // Fields
        private readonly System.Security.Cryptography.SymmetricAlgorithm 丏丌丞丙上世丕丈丏;
        
        // Methods
        public 丂世丈丅丝丙丘丌丟(byte[] 丅丄三丅丑丑丞且万)
        {
            System.Array val_7;
            if(丅丄三丅丑丑丞且万 == null)
            {
                goto label_1;
            }
            
            System.Security.Cryptography.Rfc2898DeriveBytes val_2 = new System.Security.Cryptography.Rfc2898DeriveBytes(password:  丅丄三丅丑丑丞且万, salt:  new byte[8], iterations:  1);
            byte[] val_3 = new byte[32];
            System.Array.Copy(sourceArray:  val_2, sourceIndex:  0, destinationArray:  val_3, destinationIndex:  0, length:  val_3.Length);
            byte[] val_4 = new byte[16];
            val_7 = val_4;
            if(val_3 == null)
            {
                goto label_4;
            }
            
            label_15:
            System.Array.Copy(sourceArray:  val_2, sourceIndex:  val_3.Length, destinationArray:  val_4, destinationIndex:  0, length:  val_4.Length);
            this.丏丌丞丙上世丕丈丏 = System.Security.Cryptography.Rijndael.Create();
            val_7 = ???;
            goto typeof(System.Security.Cryptography.SymmetricAlgorithm).__il2cppRuntimeField_278;
            label_4:
            if(val_7 != 0)
            {
                goto label_15;
            }
            
            goto label_15;
            label_1:
            System.ArgumentNullException val_6 = new System.ArgumentNullException(paramName:  "masterKey");
        }
        public byte[] 丘丞丕丏一丌三丟丅(byte[] 丕丑丏世上丄丐且丑)
        {
            var val_7;
            var val_8;
            var val_12;
            var val_13;
            if(丕丑丏世上丄丐且丑 == null)
            {
                goto label_1;
            }
            
            new System.IO.MemoryStream() = new System.IO.MemoryStream();
            new System.Security.Cryptography.CryptoStream() = new System.Security.Cryptography.CryptoStream(stream:  new System.IO.MemoryStream(), transform:  this.丏丌丞丙上世丕丈丏, mode:  1);
            new System.Security.Cryptography.CryptoStream().Close();
            val_7 = 0;
            val_8 = 0;
            var val_7 = 0;
            val_7 = val_7 + 1;
            new System.Security.Cryptography.CryptoStream().Dispose();
            if(val_8 == 1)
            {
                    if(val_7 != 0)
            {
                    val_7 = 0;
            }
            
                val_8 = 0;
            }
            
            if(new System.IO.MemoryStream() != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                new System.IO.MemoryStream().Dispose();
            }
            
            if(val_8 == 1)
            {
                    if(val_7 != 0)
            {
                    val_7 = 0;
            }
            
                val_8 = 0;
            }
            
            if(this.丏丌丞丙上世丕丈丏 == null)
            {
                goto label_42;
            }
            
            label_41:
            var val_9 = 0;
            val_9 = val_9 + 1;
            this.丏丌丞丙上世丕丈丏.Dispose();
            label_42:
            if(val_8 != 1)
            {
                    return (System.Byte[])new System.IO.MemoryStream();
            }
            
            if(val_7 == 0)
            {
                    return (System.Byte[])new System.IO.MemoryStream();
            }
            
            return (System.Byte[])new System.IO.MemoryStream();
            label_1:
            System.ArgumentNullException val_6 = new System.ArgumentNullException(paramName:  "ciphertext");
            val_12 = 0;
            val_13 = val_6;
            if( != 1)
            {
                goto label_40;
            }
            
            if(val_6 != null)
            {
                goto label_41;
            }
            
            goto label_42;
            label_40:
        }
        public byte[] 三丙业业世丙丏丝丝(byte[] 下丟丗丛丅丗丒与丙)
        {
            var val_7;
            var val_8;
            var val_12;
            var val_13;
            if(下丟丗丛丅丗丒与丙 == null)
            {
                goto label_1;
            }
            
            new System.IO.MemoryStream() = new System.IO.MemoryStream();
            new System.Security.Cryptography.CryptoStream() = new System.Security.Cryptography.CryptoStream(stream:  new System.IO.MemoryStream(), transform:  this.丏丌丞丙上世丕丈丏, mode:  1);
            new System.Security.Cryptography.CryptoStream().Close();
            val_7 = 0;
            val_8 = 0;
            var val_7 = 0;
            val_7 = val_7 + 1;
            new System.Security.Cryptography.CryptoStream().Dispose();
            if(val_8 == 1)
            {
                    if(val_7 != 0)
            {
                    val_7 = 0;
            }
            
                val_8 = 0;
            }
            
            if(new System.IO.MemoryStream() != null)
            {
                    var val_8 = 0;
                val_8 = val_8 + 1;
                new System.IO.MemoryStream().Dispose();
            }
            
            if(val_8 == 1)
            {
                    if(val_7 != 0)
            {
                    val_7 = 0;
            }
            
                val_8 = 0;
            }
            
            if(this.丏丌丞丙上世丕丈丏 == null)
            {
                goto label_42;
            }
            
            label_41:
            var val_9 = 0;
            val_9 = val_9 + 1;
            this.丏丌丞丙上世丕丈丏.Dispose();
            label_42:
            if(val_8 != 1)
            {
                    return (System.Byte[])new System.IO.MemoryStream();
            }
            
            if(val_7 == 0)
            {
                    return (System.Byte[])new System.IO.MemoryStream();
            }
            
            return (System.Byte[])new System.IO.MemoryStream();
            label_1:
            System.ArgumentNullException val_6 = new System.ArgumentNullException(paramName:  "plaintext");
            val_12 = 0;
            val_13 = val_6;
            if( != 1)
            {
                goto label_40;
            }
            
            if(val_6 != null)
            {
                goto label_41;
            }
            
            goto label_42;
            label_40:
        }
    
    }

}
