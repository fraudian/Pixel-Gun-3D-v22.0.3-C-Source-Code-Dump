using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class CertificateStatusRequest
    {
        // Fields
        protected readonly byte mStatusType;
        protected readonly object mRequest;
        
        // Properties
        public virtual byte StatusType { get; }
        public virtual object Request { get; }
        
        // Methods
        public CertificateStatusRequest(byte statusType, object request)
        {
            val_1 = new System.Object();
            if((Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest.IsCorrectType(statusType:  statusType, request:  object val_1 = request)) != false)
            {
                    this.mStatusType = statusType;
                this.mRequest = val_1;
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "not an instance of the correct type", paramName:  "request");
        }
        public virtual byte get_StatusType()
        {
            return (byte)this.mStatusType;
        }
        public virtual object get_Request()
        {
            return (object)this.mRequest;
        }
        public virtual Org.BouncyCastle.Crypto.Tls.OcspStatusRequest GetOcspStatusRequest()
        {
            object val_5;
            if((Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest.IsCorrectType(statusType:  1, request:  this.mRequest)) != false)
            {
                    val_5 = this.mRequest;
                if(val_5 == null)
            {
                    return (Org.BouncyCastle.Crypto.Tls.OcspStatusRequest)val_5;
            }
            
                val_5 = 0;
                return (Org.BouncyCastle.Crypto.Tls.OcspStatusRequest)val_5;
            }
            
            System.InvalidOperationException val_4 = new System.InvalidOperationException(message:  "\'request\' is not an OCSPStatusRequest");
        }
        public virtual void Encode(System.IO.Stream output)
        {
            var val_5;
            var val_6;
            val_5 = 0;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  this.mStatusType, output:  output);
            if(this.mStatusType == 1)
            {
                    if(this.mRequest == null)
            {
                    return;
            }
            
                val_5 = 0;
                return;
            }
            
            val_6 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest Parse(System.IO.Stream input)
        {
            if(((Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input:  input)) & 255) == 1)
            {
                    return (Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest)new Org.BouncyCastle.Crypto.Tls.CertificateStatusRequest(statusType:  1, request:  Org.BouncyCastle.Crypto.Tls.OcspStatusRequest.Parse(input:  input));
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_5 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  50);
        }
        protected static bool IsCorrectType(byte statusType, object request)
        {
            var val_4;
            if((statusType & 255) == 1)
            {
                    val_4 = 0;
                return (bool);
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "unsupported value", paramName:  "statusType");
        }
    
    }

}
