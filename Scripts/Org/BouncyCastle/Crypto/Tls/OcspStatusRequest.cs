using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class OcspStatusRequest
    {
        // Fields
        protected readonly System.Collections.IList mResponderIDList;
        protected readonly Org.BouncyCastle.Asn1.X509.X509Extensions mRequestExtensions;
        
        // Properties
        public virtual System.Collections.IList ResponderIDList { get; }
        public virtual Org.BouncyCastle.Asn1.X509.X509Extensions RequestExtensions { get; }
        
        // Methods
        public OcspStatusRequest(System.Collections.IList responderIDList, Org.BouncyCastle.Asn1.X509.X509Extensions requestExtensions)
        {
            val_1 = new System.Object();
            this.mResponderIDList = responderIDList;
            this.mRequestExtensions = val_1;
        }
        public virtual System.Collections.IList get_ResponderIDList()
        {
            return (System.Collections.IList)this.mResponderIDList;
        }
        public virtual Org.BouncyCastle.Asn1.X509.X509Extensions get_RequestExtensions()
        {
            return (Org.BouncyCastle.Asn1.X509.X509Extensions)this.mRequestExtensions;
        }
        public virtual void Encode(System.IO.Stream output)
        {
            System.Collections.IList val_10;
            var val_12;
            var val_14;
            val_10 = this.mResponderIDList;
            if(val_10 == null)
            {
                goto label_6;
            }
            
            var val_13 = 0;
            val_13 = val_13 + 1;
            if(val_10.Count <= 0)
            {
                goto label_6;
            }
            
            System.IO.MemoryStream val_3 = null;
            val_10 = val_3;
            val_3 = new System.IO.MemoryStream();
            val_12 = 0;
            goto label_7;
            label_26:
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_14 = this.mResponderIDList.Item[0];
            if(val_14 != null)
            {
                    val_14 = 0;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque16(buf:  val_14.GetEncoded(encoding:  "DER"), output:  val_3);
            val_12 = 1;
            label_7:
            var val_15 = 0;
            val_15 = val_15 + 1;
            if(val_12 < this.mResponderIDList.Count)
            {
                goto label_26;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i:  val_10);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  -56998800, output:  output);
            goto label_30;
            label_6:
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  0, output:  output);
            label_30:
            if(this.mRequestExtensions == null)
            {
                goto label_33;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.CheckUint16(i:  val_12.Length);
            if((this.mRequestExtensions.GetEncoded(encoding:  "DER")) == null)
            {
                goto label_37;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  val_12.Length, output:  output);
            if(output != null)
            {
                    return;
            }
            
            return;
            label_33:
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  0, output:  output);
            return;
            label_37:
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(i:  val_12.Length, output:  output);
            if(output != null)
            {
                    return;
            }
        
        }
        public static Org.BouncyCastle.Crypto.Tls.OcspStatusRequest Parse(System.IO.Stream input)
        {
            var val_14;
            Org.BouncyCastle.Asn1.X509.X509Extensions val_16;
            System.Collections.IList val_1 = Org.BouncyCastle.Utilities.Platform.CreateArrayList();
            int val_2 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input:  input);
            if(val_2 >= 1)
            {
                    System.IO.MemoryStream val_4 = null;
                val_14 = 0;
                val_4 = new System.IO.MemoryStream(buffer:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(length:  val_2, input:  input), writable:  false);
                do
            {
                var val_15 = 0;
                val_15 = val_15 + 1;
                val_14 = 2;
                int val_9 = val_1.Add(value:  Org.BouncyCastle.Asn1.Ocsp.ResponderID.GetInstance(obj:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadDerObject(encoding:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque16(input:  val_4))));
            }
            while(val_4 < val_4);
            
            }
            
            int val_10 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input:  input);
            if(val_10 >= 1)
            {
                    val_16 = Org.BouncyCastle.Asn1.X509.X509Extensions.GetInstance(obj:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadDerObject(encoding:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(length:  val_10, input:  input)));
            }
            else
            {
                    val_16 = 0;
            }
            
            .mResponderIDList = val_1;
            .mRequestExtensions = val_16;
            return (Org.BouncyCastle.Crypto.Tls.OcspStatusRequest)new Org.BouncyCastle.Crypto.Tls.OcspStatusRequest();
        }
    
    }

}
