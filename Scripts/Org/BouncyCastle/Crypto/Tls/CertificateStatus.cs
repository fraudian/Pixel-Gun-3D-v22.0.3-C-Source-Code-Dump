using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class CertificateStatus
    {
        // Fields
        protected readonly byte mStatusType;
        protected readonly object mResponse;
        
        // Properties
        public virtual byte StatusType { get; }
        public virtual object Response { get; }
        
        // Methods
        public CertificateStatus(byte statusType, object response)
        {
            val_1 = new System.Object();
            if((Org.BouncyCastle.Crypto.Tls.CertificateStatus.IsCorrectType(statusType:  statusType, response:  object val_1 = response)) != false)
            {
                    this.mStatusType = statusType;
                this.mResponse = val_1;
                return;
            }
            
            System.ArgumentException val_3 = new System.ArgumentException(message:  "not an instance of the correct type", paramName:  "response");
        }
        public virtual byte get_StatusType()
        {
            return (byte)this.mStatusType;
        }
        public virtual object get_Response()
        {
            return (object)this.mResponse;
        }
        public virtual Org.BouncyCastle.Asn1.Ocsp.OcspResponse GetOcspResponse()
        {
            object val_5;
            if((Org.BouncyCastle.Crypto.Tls.CertificateStatus.IsCorrectType(statusType:  1, response:  this.mResponse)) != false)
            {
                    val_5 = this.mResponse;
                if(val_5 == null)
            {
                    return (Org.BouncyCastle.Asn1.Ocsp.OcspResponse)val_5;
            }
            
                val_5 = 0;
                return (Org.BouncyCastle.Asn1.Ocsp.OcspResponse)val_5;
            }
            
            System.InvalidOperationException val_4 = new System.InvalidOperationException(message:  "\'response\' is not an OcspResponse");
        }
        public virtual void Encode(System.IO.Stream output)
        {
            byte val_6;
            object val_7;
            var val_8;
            val_6 = this.mStatusType;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  val_6, output:  output);
            if(this.mStatusType == 1)
            {
                    val_7 = this.mResponse;
                if(val_7 != null)
            {
                    val_6 = 1152921505551572992;
                val_7 = 0;
            }
            
                Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque24(buf:  val_7.GetEncoded(encoding:  "DER"), output:  output);
                return;
            }
            
            val_8 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public static Org.BouncyCastle.Crypto.Tls.CertificateStatus Parse(System.IO.Stream input)
        {
            if(((Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input:  input)) & 255) == 1)
            {
                    return (Org.BouncyCastle.Crypto.Tls.CertificateStatus)new Org.BouncyCastle.Crypto.Tls.CertificateStatus(statusType:  1, response:  Org.BouncyCastle.Asn1.Ocsp.OcspResponse.GetInstance(obj:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadDerObject(encoding:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque24(input:  input))));
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_7 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  50);
        }
        protected static bool IsCorrectType(byte statusType, object response)
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
