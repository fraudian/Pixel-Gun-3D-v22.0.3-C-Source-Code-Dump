using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class Certificate
    {
        // Fields
        public static readonly Org.BouncyCastle.Crypto.Tls.Certificate EmptyChain;
        protected readonly Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] mCertificateList;
        
        // Properties
        public virtual int Length { get; }
        public virtual bool IsEmpty { get; }
        
        // Methods
        public Certificate(Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] certificateList)
        {
            if(certificateList != null)
            {
                    this.mCertificateList = certificateList;
                return;
            }
            
            System.ArgumentNullException val_1 = new System.ArgumentNullException(paramName:  "certificateList");
        }
        public virtual Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] GetCertificateList()
        {
            goto typeof(Org.BouncyCastle.Crypto.Tls.Certificate).__il2cppRuntimeField_1B8;
        }
        public virtual Org.BouncyCastle.Asn1.X509.X509CertificateStructure GetCertificateAt(int index)
        {
            return (Org.BouncyCastle.Asn1.X509.X509CertificateStructure)this.mCertificateList[(long)index];
        }
        public virtual int get_Length()
        {
            if(this.mCertificateList != null)
            {
                    return (int)this.mCertificateList.Length;
            }
            
            return (int)this.mCertificateList.Length;
        }
        public virtual bool get_IsEmpty()
        {
            return (bool)(this.mCertificateList.Length == 0) ? 1 : 0;
        }
        public virtual void Encode(System.IO.Stream output)
        {
            var val_9;
            int val_10;
            var val_11;
            System.Byte[] val_16;
            var val_17;
            var val_18;
            System.Collections.IList val_1 = Org.BouncyCastle.Utilities.Platform.CreateArrayList(capacity:  this.mCertificateList.Length);
            val_9 = 0;
            val_10 = 0;
            goto label_4;
            label_14:
            val_11 = 0;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_11 = 2;
            int val_4 = val_1.Add(value:  this.mCertificateList[0].GetEncoded(encoding:  "DER"));
            int val_15 = val_2.Length;
            val_9 = 1;
            val_15 = val_10 + val_15;
            val_10 = val_15 + 3;
            label_4:
            if(val_9 < this.mCertificateList.Length)
            {
                goto label_14;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint24(i:  val_10);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint24(i:  val_10, output:  output);
            var val_16 = 0;
            val_16 = val_16 + 1;
            System.Collections.IEnumerator val_6 = val_1.GetEnumerator();
            label_37:
            var val_17 = 0;
            val_17 = val_17 + 1;
            if(val_6.MoveNext() == false)
            {
                goto label_27;
            }
            
            var val_18 = 0;
            val_18 = val_18 + 1;
            object val_10 = val_6.Current;
            if(val_10 == null)
            {
                goto label_35;
            }
            
            val_16 = val_10;
            if(val_16 != null)
            {
                goto label_36;
            }
            
            label_35:
            val_16 = 0;
            label_36:
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque24(buf:  val_16, output:  output);
            goto label_37;
            label_27:
            val_17 = 0;
            val_18 = 0;
            if(val_6 != null)
            {
                    var val_19 = 0;
                val_19 = val_19 + 1;
                val_6.Dispose();
            }
            
            if( != 1)
            {
                    return;
            }
            
            if( == false)
            {
                    return;
            }
        
        }
        public static Org.BouncyCastle.Crypto.Tls.Certificate Parse(System.IO.Stream input)
        {
            System.Byte[] val_17;
            var val_20;
            Org.BouncyCastle.Crypto.Tls.Certificate val_21;
            var val_22;
            Org.BouncyCastle.Asn1.X509.X509CertificateStructure val_24;
            var val_25;
            int val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint24(input:  input);
            if(val_1 == 0)
            {
                goto label_3;
            }
            
            System.IO.MemoryStream val_3 = null;
            val_17 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(length:  val_1, input:  input);
            val_3 = new System.IO.MemoryStream(buffer:  val_17, writable:  false);
            System.Collections.IList val_4 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            goto label_8;
            label_18:
            var val_21 = 0;
            val_21 = val_21 + 1;
            val_17 = Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(obj:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadDerObject(encoding:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque24(input:  val_3)));
            int val_9 = val_4.Add(value:  val_17);
            label_8:
            if(val_3 < val_3)
            {
                goto label_18;
            }
            
            var val_22 = 0;
            val_22 = val_22 + 1;
            goto label_23;
            label_3:
            val_20 = null;
            val_20 = null;
            val_21 = Org.BouncyCastle.Crypto.Tls.Certificate.EmptyChain;
            return (Org.BouncyCastle.Crypto.Tls.Certificate)val_21;
            label_23:
            int val_11 = val_4.Count;
            Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] val_12 = new Org.BouncyCastle.Asn1.X509.X509CertificateStructure[0];
            val_22 = 0;
            goto label_42;
            label_50:
            var val_23 = 0;
            val_23 = val_23 + 1;
            val_24 = val_4.Item[0];
            if(val_12 == null)
            {
                goto label_33;
            }
            
            if(val_24 == null)
            {
                goto label_34;
            }
            
            label_40:
            val_25 = 0;
            val_24 = 0;
            goto label_39;
            label_33:
            if(val_24 != null)
            {
                goto label_40;
            }
            
            label_34:
            val_25 = 0;
            label_39:
            val_12[val_25] = val_24;
            val_22 = 1;
            label_42:
            var val_24 = 0;
            val_24 = val_24 + 1;
            if(val_22 < val_4.Count)
            {
                goto label_50;
            }
            
            Org.BouncyCastle.Crypto.Tls.Certificate val_20 = null;
            val_21 = val_20;
            val_20 = new Org.BouncyCastle.Crypto.Tls.Certificate(certificateList:  val_12);
            return (Org.BouncyCastle.Crypto.Tls.Certificate)val_21;
        }
        protected virtual Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] CloneCertificateList()
        {
            Org.BouncyCastle.Asn1.X509.X509CertificateStructure[] val_3;
            var val_4;
            val_3 = this.mCertificateList;
            object val_1 = val_3.Clone();
            if(val_1 == null)
            {
                    return (Org.BouncyCastle.Asn1.X509.X509CertificateStructure[])val_4;
            }
            
            val_4 = val_1;
            val_3 = null;
            if(val_4 != null)
            {
                    return (Org.BouncyCastle.Asn1.X509.X509CertificateStructure[])val_4;
            }
            
            val_4 = 0;
            return (Org.BouncyCastle.Asn1.X509.X509CertificateStructure[])val_4;
        }
        private static Certificate()
        {
            Org.BouncyCastle.Crypto.Tls.Certificate.EmptyChain = new Org.BouncyCastle.Crypto.Tls.Certificate(certificateList:  new Org.BouncyCastle.Asn1.X509.X509CertificateStructure[0]);
        }
    
    }

}
