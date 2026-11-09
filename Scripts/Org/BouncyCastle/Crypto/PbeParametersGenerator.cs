using UnityEngine;

namespace Org.BouncyCastle.Crypto
{
    public abstract class PbeParametersGenerator
    {
        // Fields
        protected byte[] mPassword;
        protected byte[] mSalt;
        protected int mIterationCount;
        
        // Properties
        public virtual byte[] Password { get; }
        public virtual byte[] Salt { get; }
        public virtual int IterationCount { get; }
        
        // Methods
        protected PbeParametersGenerator()
        {
        
        }
        public virtual void Init(byte[] password, byte[] salt, int iterationCount)
        {
            string val_5;
            if(password == null)
            {
                goto label_1;
            }
            
            if(salt == null)
            {
                goto label_2;
            }
            
            this.mPassword = Org.BouncyCastle.Utilities.Arrays.Clone(data:  password);
            this.mSalt = Org.BouncyCastle.Utilities.Arrays.Clone(data:  salt);
            this.mIterationCount = iterationCount;
            return;
            label_1:
            val_5 = "password";
            goto label_3;
            label_2:
            val_5 = "salt";
            label_3:
            null = new System.ArgumentNullException(paramName:  val_5);
        }
        public virtual byte[] get_Password()
        {
            return Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.mPassword);
        }
        public byte[] GetPassword()
        {
            goto typeof(Org.BouncyCastle.Crypto.PbeParametersGenerator).__il2cppRuntimeField_178;
        }
        public virtual byte[] get_Salt()
        {
            return Org.BouncyCastle.Utilities.Arrays.Clone(data:  this.mSalt);
        }
        public byte[] GetSalt()
        {
            goto typeof(Org.BouncyCastle.Crypto.PbeParametersGenerator).__il2cppRuntimeField_188;
        }
        public virtual int get_IterationCount()
        {
            return (int)this.mIterationCount;
        }
        public abstract Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(int keySize); // 0
        public abstract Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(string algorithm, int keySize); // 0
        public abstract Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(int keySize, int ivSize); // 0
        public abstract Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedParameters(string algorithm, int keySize, int ivSize); // 0
        public abstract Org.BouncyCastle.Crypto.ICipherParameters GenerateDerivedMacParameters(int keySize); // 0
        public static byte[] Pkcs5PasswordToBytes(char[] password)
        {
            if(password != null)
            {
                    return Org.BouncyCastle.Utilities.Strings.ToByteArray(cs:  password);
            }
            
            byte[] val_1 = new byte[0];
        }
        public static byte[] Pkcs5PasswordToBytes(string password)
        {
            if(password != null)
            {
                    return Org.BouncyCastle.Utilities.Strings.ToByteArray(s:  password);
            }
            
            byte[] val_1 = new byte[0];
        }
        public static byte[] Pkcs5PasswordToUtf8Bytes(char[] password)
        {
            System.Char[] val_7 = password;
            if(val_7 != null)
            {
                    System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
                val_7 = ???;
            }
            else
            {
                    byte[] val_6 = new byte[0];
            }
        
        }
        public static byte[] Pkcs5PasswordToUtf8Bytes(string password)
        {
            string val_7 = password;
            if(val_7 != null)
            {
                    System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
                val_7 = ???;
            }
            else
            {
                    byte[] val_6 = new byte[0];
            }
        
        }
        public static byte[] Pkcs12PasswordToBytes(char[] password)
        {
            return Org.BouncyCastle.Crypto.PbeParametersGenerator.Pkcs12PasswordToBytes(password:  password, wrongPkcs12Zero:  false);
        }
        public static byte[] Pkcs12PasswordToBytes(char[] password, bool wrongPkcs12Zero)
        {
            var val_6;
            if(password != null)
            {
                    int val_6 = password.Length;
                if(val_6 > 0)
            {
                    val_6 = val_6 << 1;
                int val_1 = val_6 + 2;
                val_6 = new byte[0];
                if(System.Text.Encoding.BigEndianUnicode != null)
            {
                    return (System.Byte[])val_6;
            }
            
                return (System.Byte[])val_6;
            }
            
            }
            
            var val_4 = (wrongPkcs12Zero != true) ? 2 : 0;
            val_6 = new byte[0];
            return (System.Byte[])val_6;
        }
    
    }

}
