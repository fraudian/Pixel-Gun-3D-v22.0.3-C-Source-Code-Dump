using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public abstract class AbstractTlsClient : AbstractTlsPeer, TlsClient, TlsPeer
    {
        // Fields
        protected Org.BouncyCastle.Crypto.Tls.TlsCipherFactory mCipherFactory;
        protected Org.BouncyCastle.Crypto.Tls.TlsClientContext mContext;
        protected System.Collections.IList mSupportedSignatureAlgorithms;
        protected int[] mNamedCurves;
        protected byte[] mClientECPointFormats;
        protected byte[] mServerECPointFormats;
        protected int mSelectedCipherSuite;
        protected short mSelectedCompressionMethod;
        private System.Collections.Generic.List<string> <HostNames>k__BackingField;
        
        // Properties
        public System.Collections.Generic.List<string> HostNames { get; set; }
        public virtual Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientHelloRecordLayerVersion { get; }
        public virtual Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientVersion { get; }
        public virtual bool IsFallback { get; }
        public virtual Org.BouncyCastle.Crypto.Tls.ProtocolVersion MinimumVersion { get; }
        
        // Methods
        public System.Collections.Generic.List<string> get_HostNames()
        {
            return (System.Collections.Generic.List<System.String>)this.<HostNames>k__BackingField;
        }
        public void set_HostNames(System.Collections.Generic.List<string> value)
        {
            this.<HostNames>k__BackingField = value;
        }
        public AbstractTlsClient()
        {
            this = new System.Object();
            this.mCipherFactory = new Org.BouncyCastle.Crypto.Tls.DefaultTlsCipherFactory();
        }
        public AbstractTlsClient(Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory)
        {
            val_1 = new System.Object();
            this.mCipherFactory = cipherFactory;
        }
        protected virtual bool AllowUnexpectedServerExtension(int extensionType, byte[] extensionData)
        {
            var val_2;
            if(extensionType == 10)
            {
                    System.Int32[] val_1 = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ReadSupportedEllipticCurvesExtension(extensionData:  extensionData);
                val_2 = 1;
                return (bool)val_2;
            }
            
            val_2 = 0;
            return (bool)val_2;
        }
        protected virtual void CheckForUnexpectedServerExtension(System.Collections.IDictionary serverExtensions, int extensionType)
        {
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  serverExtensions, extensionType:  extensionType)) == null)
            {
                    return;
            }
            
            if((this & 1) != 0)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
        }
        public virtual void Init(Org.BouncyCastle.Crypto.Tls.TlsClientContext context)
        {
            this.mContext = context;
        }
        public virtual Org.BouncyCastle.Crypto.Tls.TlsSession GetSessionToResume()
        {
            return 0;
        }
        public virtual Org.BouncyCastle.Crypto.Tls.ProtocolVersion get_ClientHelloRecordLayerVersion()
        {
            goto typeof(Org.BouncyCastle.Crypto.Tls.AbstractTlsClient).__il2cppRuntimeField_3D8;
        }
        public virtual Org.BouncyCastle.Crypto.Tls.ProtocolVersion get_ClientVersion()
        {
            null = null;
            return (Org.BouncyCastle.Crypto.Tls.ProtocolVersion)Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv12;
        }
        public virtual bool get_IsFallback()
        {
            return false;
        }
        public virtual System.Collections.IDictionary GetClientExtensions()
        {
            System.Int32[] val_16;
            System.Collections.IDictionary val_18;
            System.Int32[] val_19;
            int val_20;
            int val_21;
            var val_22;
            val_16 = this;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_18 = 0;
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSignatureAlgorithmsExtensionAllowed(clientVersion:  this.mContext.ClientVersion)) != false)
            {
                    this.mSupportedSignatureAlgorithms = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetDefaultSupportedSignatureAlgorithms();
                System.Collections.IDictionary val_5 = Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(extensions:  0);
                val_18 = val_5;
                Org.BouncyCastle.Crypto.Tls.TlsUtilities.AddSignatureAlgorithmsExtension(extensions:  val_5, supportedSignatureAlgorithms:  this.mSupportedSignatureAlgorithms);
            }
            
            val_19 = val_16;
            if((Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.ContainsEccCipherSuites(cipherSuites:  this)) != false)
            {
                    int[] val_7 = new int[2];
                val_20 = val_7.Length;
                if(val_20 == 0)
            {
                    val_20 = val_7.Length;
            }
            
                val_7[0] = 23;
                val_7[0] = 24;
                this.mNamedCurves = val_7;
                byte[] val_8 = new byte[3];
                val_21 = val_8.Length;
                if(val_21 <= 1)
            {
                    val_21 = val_8.Length;
            }
            
                val_8[0] = 1;
                val_8[0] = 2;
                this.mClientECPointFormats = val_8;
                val_19 = this.mNamedCurves;
                val_18 = Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.EnsureExtensionsInitialised(extensions:  val_18);
                Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.AddSupportedEllipticCurvesExtension(extensions:  val_18, namedCurves:  val_19);
                Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.AddSupportedPointFormatsExtension(extensions:  val_18, ecPointFormats:  this.mClientECPointFormats);
            }
            
            if((this.<HostNames>k__BackingField) == null)
            {
                    return val_18;
            }
            
            if((this.<HostNames>k__BackingField.Count) < 1)
            {
                    return val_18;
            }
            
            System.Collections.Generic.List<Org.BouncyCastle.Crypto.Tls.ServerName> val_12 = null;
            val_19 = val_12;
            val_12 = new System.Collections.Generic.List<Org.BouncyCastle.Crypto.Tls.ServerName>(capacity:  this.<HostNames>k__BackingField.Count);
            val_22 = 0;
            goto label_25;
            label_29:
            val_12.Add(item:  new Org.BouncyCastle.Crypto.Tls.ServerName(nameType:  0, name:  this.<HostNames>k__BackingField.Item[0]));
            val_22 = 1;
            label_25:
            if(val_22 < (this.<HostNames>k__BackingField.Count))
            {
                goto label_29;
            }
            
            Org.BouncyCastle.Crypto.Tls.ServerNameList val_16 = null;
            val_16 = val_16;
            val_16 = new Org.BouncyCastle.Crypto.Tls.ServerNameList(serverNameList:  val_12);
            Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.AddServerNameExtension(extensions:  val_18, serverNameList:  val_16);
            return val_18;
        }
        public virtual Org.BouncyCastle.Crypto.Tls.ProtocolVersion get_MinimumVersion()
        {
            null = null;
            return (Org.BouncyCastle.Crypto.Tls.ProtocolVersion)Org.BouncyCastle.Crypto.Tls.ProtocolVersion.TLSv10;
        }
        public virtual void NotifyServerVersion(Org.BouncyCastle.Crypto.Tls.ProtocolVersion serverVersion)
        {
            if((serverVersion.IsEqualOrEarlierVersionOf(version:  serverVersion)) != false)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_2 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  70);
        }
        public abstract int[] GetCipherSuites(); // 0
        public virtual byte[] GetCompressionMethods()
        {
            byte[] val_1 = new byte[1];
        }
        public virtual void NotifySessionID(byte[] sessionID)
        {
        
        }
        public virtual void NotifySelectedCipherSuite(int selectedCipherSuite)
        {
            this.mSelectedCipherSuite = selectedCipherSuite;
        }
        public virtual void NotifySelectedCompressionMethod(byte selectedCompressionMethod)
        {
            this.mSelectedCompressionMethod = selectedCompressionMethod & 255;
        }
        public virtual void ProcessServerExtensions(System.Collections.IDictionary serverExtensions)
        {
            if(serverExtensions == null)
            {
                    return;
            }
            
            if((Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.IsEccCipherSuite(cipherSuite:  this.mSelectedCipherSuite)) != false)
            {
                    this.mServerECPointFormats = Org.BouncyCastle.Crypto.Tls.TlsEccUtilities.GetSupportedPointFormatsExtension(extensions:  serverExtensions);
            }
        
        }
        public virtual void ProcessServerSupplementalData(System.Collections.IList serverSupplementalData)
        {
            if(serverSupplementalData == null)
            {
                    return;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_1 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  10);
        }
        public abstract Org.BouncyCastle.Crypto.Tls.TlsKeyExchange GetKeyExchange(); // 0
        public abstract Org.BouncyCastle.Crypto.Tls.TlsAuthentication GetAuthentication(); // 0
        public virtual System.Collections.IList GetClientSupplementalData()
        {
            return 0;
        }
        public override Org.BouncyCastle.Crypto.Tls.TlsCompression GetCompression()
        {
            var val_4;
            if(this.mSelectedCompressionMethod == 1)
            {
                goto label_1;
            }
            
            if(this.mSelectedCompressionMethod != 0)
            {
                goto label_2;
            }
            
            Org.BouncyCastle.Crypto.Tls.TlsNullCompression val_1 = null;
            val_4 = val_1;
            val_1 = new Org.BouncyCastle.Crypto.Tls.TlsNullCompression();
            return (Org.BouncyCastle.Crypto.Tls.TlsCompression)val_4;
            label_1:
            Org.BouncyCastle.Crypto.Tls.TlsDeflateCompression val_2 = null;
            val_4 = val_2;
            val_2 = new Org.BouncyCastle.Crypto.Tls.TlsDeflateCompression();
            return (Org.BouncyCastle.Crypto.Tls.TlsCompression)val_4;
            label_2:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_3 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        public override Org.BouncyCastle.Crypto.Tls.TlsCipher GetCipher()
        {
            var val_4 = 0;
            val_4 = val_4 + 1;
            return this.mCipherFactory.CreateCipher(context:  this.mContext, encryptionAlgorithm:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetEncryptionAlgorithm(ciphersuite:  this.mSelectedCipherSuite), macAlgorithm:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetMacAlgorithm(ciphersuite:  this.mSelectedCipherSuite));
        }
        public virtual void NotifyNewSessionTicket(Org.BouncyCastle.Crypto.Tls.NewSessionTicket newSessionTicket)
        {
        
        }
    
    }

}
