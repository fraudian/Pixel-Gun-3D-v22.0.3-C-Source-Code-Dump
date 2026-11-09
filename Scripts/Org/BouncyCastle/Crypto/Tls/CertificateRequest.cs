using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class CertificateRequest
    {
        // Fields
        protected readonly byte[] mCertificateTypes;
        protected readonly System.Collections.IList mSupportedSignatureAlgorithms;
        protected readonly System.Collections.IList mCertificateAuthorities;
        
        // Properties
        public virtual byte[] CertificateTypes { get; }
        public virtual System.Collections.IList SupportedSignatureAlgorithms { get; }
        public virtual System.Collections.IList CertificateAuthorities { get; }
        
        // Methods
        public CertificateRequest(byte[] certificateTypes, System.Collections.IList supportedSignatureAlgorithms, System.Collections.IList certificateAuthorities)
        {
            this.mCertificateTypes = certificateTypes;
            this.mSupportedSignatureAlgorithms = supportedSignatureAlgorithms;
            this.mCertificateAuthorities = certificateAuthorities;
        }
        public virtual byte[] get_CertificateTypes()
        {
            return (System.Byte[])this.mCertificateTypes;
        }
        public virtual System.Collections.IList get_SupportedSignatureAlgorithms()
        {
            return (System.Collections.IList)this.mSupportedSignatureAlgorithms;
        }
        public virtual System.Collections.IList get_CertificateAuthorities()
        {
            return (System.Collections.IList)this.mCertificateAuthorities;
        }
        public virtual void Encode(System.IO.Stream output)
        {
            int val_22;
            var val_24;
            var val_25;
            var val_28;
            var val_29;
            var val_33;
            System.Byte[] val_37;
            if((this.mCertificateTypes != null) && (this.mCertificateTypes.Length != 0))
            {
                    Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8ArrayWithUint8Length(uints:  this.mCertificateTypes, output:  output);
            }
            else
            {
                    Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(i:  0, output:  output);
            }
            
            if(this.mSupportedSignatureAlgorithms != null)
            {
                    Org.BouncyCastle.Crypto.Tls.TlsUtilities.EncodeSupportedSignatureAlgorithms(supportedSignatureAlgorithms:  this.mSupportedSignatureAlgorithms, allowAnonymous:  false, output:  output);
            }
            
            if(this.mCertificateAuthorities == null)
            {
                goto label_16;
            }
            
            var val_28 = 0;
            val_28 = val_28 + 1;
            if(this.mCertificateAuthorities.Count <= 0)
            {
                goto label_16;
            }
            
            var val_29 = 0;
            val_29 = val_29 + 1;
            goto label_21;
            label_16:
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  0, output:  output);
            return;
            label_21:
            System.Collections.IList val_5 = Org.BouncyCastle.Utilities.Platform.CreateArrayList(capacity:  this.mCertificateAuthorities.Count);
            var val_30 = 0;
            val_30 = val_30 + 1;
            System.Collections.IEnumerator val_7 = this.mCertificateAuthorities.GetEnumerator();
            val_22 = 0;
            goto label_31;
            label_54:
            var val_31 = 0;
            val_31 = val_31 + 1;
            val_24 = val_7.Current;
            if(val_24 != null)
            {
                    val_24 = 0;
            }
            
            val_25 = 0;
            var val_32 = 0;
            val_32 = val_32 + 1;
            val_25 = 2;
            int val_16 = val_5.Add(value:  val_24.GetEncoded(encoding:  "DER"));
            int val_33 = val_14.Length;
            val_33 = val_22 + val_33;
            val_22 = val_33 + 2;
            label_31:
            var val_34 = 0;
            val_34 = val_34 + 1;
            if(val_7.MoveNext() == true)
            {
                goto label_54;
            }
            
            val_28 = 0;
            val_29 = 0;
            if(val_7 != null)
            {
                    var val_35 = 0;
                val_35 = val_35 + 1;
                val_7.Dispose();
            }
            
            if(( != 1) && (190 == 190))
            {
                    val_33 = 1152921504686292992;
                val_28 = 0;
            }
            else
            {
                    val_33 = 1152921504686292992;
                if( != false)
            {
                    val_29 = 0;
            }
            
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i:  val_22);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  val_22, output:  output);
            var val_36 = 0;
            val_36 = val_36 + 1;
            System.Collections.IEnumerator val_21 = val_5.GetEnumerator();
            label_96:
            var val_37 = 0;
            val_37 = val_37 + 1;
            if(val_21.MoveNext() == false)
            {
                goto label_97;
            }
            
            var val_38 = 0;
            val_38 = val_38 + 1;
            object val_25 = val_21.Current;
            if(val_25 == null)
            {
                goto label_94;
            }
            
            val_37 = val_25;
            if(val_37 != null)
            {
                goto label_95;
            }
            
            label_94:
            val_37 = 0;
            label_95:
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(buf:  val_37, output:  output);
            goto label_96;
            label_97:
            if(val_21 != null)
            {
                    var val_39 = 0;
                val_39 = val_39 + 1;
                val_21.Dispose();
            }
            
            if(1 != 1)
            {
                    if( == false)
            {
                    return;
            }
            
                if(259 == 259)
            {
                    return;
            }
            
                return;
            }
            
            if( == true)
            {
                    return;
            }
        
        }
        public static Org.BouncyCastle.Crypto.Tls.CertificateRequest Parse(Org.BouncyCastle.Crypto.Tls.TlsContext context, System.IO.Stream input)
        {
            var val_17;
            System.Collections.IList val_19;
            System.Byte[] val_20;
            byte val_2 = (Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input:  input)) & 255;
            byte[] val_3 = new byte[0];
            val_17 = null;
            var val_4 = ((Org.BouncyCastle.Crypto.Tls.TlsUtilities.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
            if(val_2 != 0)
            {
                    var val_18 = 0;
                do
            {
                mem2[0] = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input:  input);
                val_17 = null;
                val_18 = val_18 + 1;
                var val_6 = ((Org.BouncyCastle.Crypto.Tls.TlsUtilities.__il2cppRuntimeField_127 & 2) != 0) ? 1 : 0;
            }
            while(val_2 != val_18);
            
            }
            
            val_19 = 0;
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context:  context)) != false)
            {
                    val_19 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ParseSupportedSignatureAlgorithms(allowAnonymous:  false, input:  input);
            }
            
            System.Collections.IList val_9 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            System.IO.MemoryStream val_11 = null;
            val_20 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input:  input);
            val_11 = new System.IO.MemoryStream(buffer:  val_20, writable:  false);
            goto label_18;
            label_30:
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_20 = Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(obj:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadDerObject(encoding:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input:  val_11)));
            int val_16 = val_9.Add(value:  val_20);
            label_18:
            if(val_11 < val_11)
            {
                goto label_30;
            }
            
            .mCertificateTypes = val_3;
            .mSupportedSignatureAlgorithms = val_19;
            .mCertificateAuthorities = val_9;
            return (Org.BouncyCastle.Crypto.Tls.CertificateRequest)new Org.BouncyCastle.Crypto.Tls.CertificateRequest();
        }
    
    }

}
