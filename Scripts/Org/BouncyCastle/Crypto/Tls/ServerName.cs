using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class ServerName
    {
        // Fields
        protected readonly byte mNameType;
        protected readonly object mName;
        
        // Properties
        public virtual byte NameType { get; }
        public virtual object Name { get; }
        
        // Methods
        public ServerName(byte nameType, object name)
        {
            val_1 = new System.Object();
            if((Org.BouncyCastle.Crypto.Tls.ServerName.IsCorrectType(nameType:  nameType, name:  object val_1 = name)) != false)
            {
                    this.mNameType = nameType;
                this.mName = val_1;
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "not an instance of the correct type", paramName:  "name");
        }
        public virtual byte get_NameType()
        {
            return (byte)this.mNameType;
        }
        public virtual object get_Name()
        {
            return (object)this.mName;
        }
        public virtual string GetHostName()
        {
            object val_3;
            if((this.mName != null) && (null == null))
            {
                    val_3 = this.mName;
                if(val_3 == null)
            {
                    return (string)val_3;
            }
            
                if(null == null)
            {
                    return (string)val_3;
            }
            
                val_3 = 0;
                return (string)val_3;
            }
            
            System.InvalidOperationException val_2 = new System.InvalidOperationException(message:  "\'name\' is not a HostName string");
        }
        public virtual void Encode(System.IO.Stream output)
        {
            object val_5;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  this.mNameType, output:  output);
            if(this.mNameType == 0)
            {
                    val_5 = this.mName;
                if((val_5 != null) && (null != null))
            {
                    val_5 = 0;
            }
            
                if(val_2.Length > 0)
            {
                    Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(buf:  (val_2.Length > 0) ? Org.BouncyCastle.Utilities.Strings.ToAsciiByteArray(s:  val_5) : 0, output:  output);
                return;
            }
            
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_4 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static Org.BouncyCastle.Crypto.Tls.ServerName Parse(System.IO.Stream input)
        {
            if(((Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input:  input)) & 255) == 0)
            {
                    if(val_3.Length > 0)
            {
                    return (Org.BouncyCastle.Crypto.Tls.ServerName)new Org.BouncyCastle.Crypto.Tls.ServerName(nameType:  0, name:  Org.BouncyCastle.Utilities.Strings.FromAsciiByteArray(bytes:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input:  input)));
            }
            
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_6 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  50);
        }
        protected static bool IsCorrectType(byte nameType, object name)
        {
            var val_4;
            if((nameType & 255) == 0)
            {
                    if(name != null)
            {
                    var val_2 = (null == null) ? 1 : 0;
                return (bool)val_4;
            }
            
                val_4 = 0;
                return (bool)val_4;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "unsupported value", paramName:  "name");
        }
    
    }

}
