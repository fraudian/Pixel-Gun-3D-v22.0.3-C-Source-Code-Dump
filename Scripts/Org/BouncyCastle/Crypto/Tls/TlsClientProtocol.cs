using UnityEngine;

namespace Org.BouncyCastle.Crypto.Tls
{
    public class TlsClientProtocol : TlsProtocol
    {
        // Fields
        protected Org.BouncyCastle.Crypto.Tls.TlsClient mTlsClient;
        internal Org.BouncyCastle.Crypto.Tls.TlsClientContextImpl mTlsClientContext;
        protected byte[] mSelectedSessionID;
        protected Org.BouncyCastle.Crypto.Tls.TlsKeyExchange mKeyExchange;
        protected Org.BouncyCastle.Crypto.Tls.TlsAuthentication mAuthentication;
        protected Org.BouncyCastle.Crypto.Tls.CertificateStatus mCertificateStatus;
        protected Org.BouncyCastle.Crypto.Tls.CertificateRequest mCertificateRequest;
        
        // Properties
        protected override Org.BouncyCastle.Crypto.Tls.TlsContext Context { get; }
        internal override Org.BouncyCastle.Crypto.Tls.AbstractTlsContext ContextAdmin { get; }
        protected override Org.BouncyCastle.Crypto.Tls.TlsPeer Peer { get; }
        
        // Methods
        public TlsClientProtocol(System.IO.Stream stream, Org.BouncyCastle.Security.SecureRandom secureRandom)
        {
        
        }
        public TlsClientProtocol(System.IO.Stream input, System.IO.Stream output, Org.BouncyCastle.Security.SecureRandom secureRandom)
        {
        
        }
        public TlsClientProtocol(Org.BouncyCastle.Security.SecureRandom secureRandom)
        {
        
        }
        public virtual void Connect(Org.BouncyCastle.Crypto.Tls.TlsClient tlsClient)
        {
            Org.BouncyCastle.Crypto.Tls.SecurityParameters val_13;
            var val_16;
            var val_20;
            if(tlsClient == null)
            {
                goto label_1;
            }
            
            if(this.mTlsClient != null)
            {
                goto label_2;
            }
            
            this.mTlsClient = tlsClient;
            Org.BouncyCastle.Crypto.Tls.SecurityParameters val_1 = null;
            .entity = 0;
            .cipherSuite = 0;
            .prfAlgorithm = 0;
            .verifyDataLength = 0;
            .maxFragmentLength = 65535;
            val_1 = new Org.BouncyCastle.Crypto.Tls.SecurityParameters();
            mem[1152921547524205216] = val_1;
            .entity = 1;
            Org.BouncyCastle.Crypto.Tls.TlsClientContextImpl val_2 = null;
            val_13 = X22;
            val_2 = new Org.BouncyCastle.Crypto.Tls.TlsClientContextImpl(secureRandom:  val_1, securityParameters:  val_13);
            this.mTlsClientContext = val_2;
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_13 = 0;
            mem[1152921547524249456] = Org.BouncyCastle.Crypto.Tls.TlsProtocol.CreateRandomBlock(useGmtUnixTime:  tlsClient.ShouldUseGmtUnixTime(), randomGenerator:  this.mTlsClientContext.NonceRandomGenerator);
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_13 = 2;
            this.mTlsClient.Init(context:  this.mTlsClientContext);
            var val_19 = 0;
            val_19 = val_19 + 1;
            Org.BouncyCastle.Crypto.Tls.TlsSession val_10 = tlsClient.GetSessionToResume();
            if(val_10 != null)
            {
                    val_16 = 1152921505529634816;
                var val_20 = 0;
                val_20 = val_20 + 1;
                if(val_10.IsResumable != false)
            {
                    var val_21 = 0;
                val_21 = val_21 + 1;
                Org.BouncyCastle.Crypto.Tls.SessionParameters val_14 = val_10.ExportSessionParameters();
                if(val_14 != null)
            {
                    mem[1152921547524205200] = val_10;
                mem[1152921547524205208] = val_14;
            }
            
            }
            
            }
            
            mem[1152921547524205264] = 1;
            goto typeof(Org.BouncyCastle.Crypto.Tls.TlsClientProtocol).__il2cppRuntimeField_1F8;
            label_1:
            System.ArgumentNullException val_15 = null;
            val_20 = val_15;
            val_15 = new System.ArgumentNullException(paramName:  "tlsClient");
            goto label_33;
            label_2:
            System.InvalidOperationException val_16 = null;
            val_20 = val_16;
            val_16 = new System.InvalidOperationException(message:  "\'Connect\' can only be called once");
            label_33:
        }
        protected override void CleanupHandshake()
        {
            this.CleanupHandshake();
            this.mCertificateRequest = 0;
            this.mAuthentication = 0;
            this.mSelectedSessionID = 0;
        }
        protected override Org.BouncyCastle.Crypto.Tls.TlsContext get_Context()
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsContext)this.mTlsClientContext;
        }
        internal override Org.BouncyCastle.Crypto.Tls.AbstractTlsContext get_ContextAdmin()
        {
            return (Org.BouncyCastle.Crypto.Tls.AbstractTlsContext)this.mTlsClientContext;
        }
        protected override Org.BouncyCastle.Crypto.Tls.TlsPeer get_Peer()
        {
            return (Org.BouncyCastle.Crypto.Tls.TlsPeer)this.mTlsClient;
        }
        protected override void HandleHandshakeMessage(byte type, byte[] data)
        {
            Org.BouncyCastle.Crypto.Tls.TlsSessionImpl val_47;
            Org.BouncyCastle.Crypto.Tls.TlsContext val_48;
            System.IO.MemoryStream val_49;
            var val_50;
            byte val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_66;
            var val_67;
            var val_68;
            var val_69;
            var val_70;
            var val_71;
            var val_72;
            var val_73;
            var val_74;
            var val_75;
            Org.BouncyCastle.Crypto.Tls.CertificateRequest val_76;
            Org.BouncyCastle.Crypto.Tls.TlsCredentials val_77;
            var val_78;
            var val_79;
            var val_81;
            var val_82;
            var val_83;
            var val_84;
            Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials val_85;
            var val_86;
            var val_87;
            var val_88;
            var val_89;
            var val_90;
            var val_91;
            val_47 = type;
            val_48 = this;
            System.IO.MemoryStream val_1 = null;
            val_49 = val_1;
            val_1 = new System.IO.MemoryStream(buffer:  data, writable:  false);
            if(null == 0)
            {
                goto label_1;
            }
            
            byte val_2 = val_47 & 255;
            if((val_2 != 20) || (val_2 != 2))
            {
                goto label_67;
            }
            
            mem[1152921547525032960] = 15;
            mem[1152921547525032960] = 16;
            label_90:
            val_50 = ???;
            val_49 = ???;
            val_48 = ???;
            val_47 = ???;
            val_51 = ???;
            val_52 = ???;
            goto typeof(Org.BouncyCastle.Crypto.Tls.TlsClientProtocol).__il2cppRuntimeField_208;
            label_1:
            if((val_47 & 255) > 23)
            {
                goto label_67;
            }
            
            var val_42 = 106068384 + ((val_47 & 255)) << 2;
            val_42 = val_42 + 106068384;
            goto (106068384 + ((val_47 & 255)) << 2 + 106068384);
            label_19:
            if(((val_48 + 192 + 176 + 8) + -8) == null)
            {
                goto label_18;
            }
            
             =  + 1;
             =  + 16;
            if( < (val_48 + 192 + 286))
            {
                goto label_19;
            }
            
            goto label_20;
            label_30:
            if(((val_48 + 192 + 176 + 8) + -8) == null)
            {
                goto label_29;
            }
            
             =  + 1;
             =  + 16;
            if( < (val_48 + 192 + 286))
            {
                goto label_30;
            }
            
            val_56 = 1;
            goto label_31;
            label_43:
            if(((val_48 + 192 + 176 + 8) + -8) == null)
            {
                goto label_42;
            }
            
             =  + 1;
             =  + 16;
            if( < (val_48 + 192 + 286))
            {
                goto label_43;
            }
            
            val_58 = 3;
            goto label_44;
            label_53:
            if(((val_48 + 176 + 8) + -8) == null)
            {
                goto label_52;
            }
            
             =  + 1;
             =  + 16;
            if( < (val_48 + 286))
            {
                goto label_53;
            }
            
            goto label_54;
            label_65:
            if(((val_48 + 192 + 176 + 8) + -8) == null)
            {
                goto label_64;
            }
            
             =  + 1;
             =  + 16;
            if( < (val_48 + 192 + 286))
            {
                goto label_65;
            }
            
            goto label_66;
            label_42:
            var val_56 = ;
            val_56 = val_56 + 3;
             =  + val_56;
            val_59 =  + 296;
            label_44:
            val_63 = public System.Void Org.BouncyCastle.Crypto.Tls.TlsKeyExchange::ProcessServerCertificate(Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate);
            val_48 + 192.ProcessServerCertificate(serverCertificate:  val_48 + 104);
            var val_61 = val_48 + 168;
            if((val_48 + 168 + 286) == 0)
            {
                goto label_74;
            }
            
            var val_58 = val_48 + 168 + 176;
            var val_59 = 0;
            val_58 = val_58 + 8;
            label_76:
            if(((val_48 + 168 + 176 + 8) + -8) == null)
            {
                goto label_75;
            }
            
            val_59 = val_59 + 1;
            val_58 = val_58 + 16;
            if(val_59 < (val_48 + 168 + 286))
            {
                goto label_76;
            }
            
            label_74:
            val_63 = 17;
            goto label_77;
            label_75:
            var val_60 = val_58;
            val_60 = val_60 + 17;
            val_61 = val_61 + val_60;
            val_64 = val_61 + 296;
            label_77:
            val_47 = val_48 + 168.GetAuthentication();
            mem2[0] = val_47;
            var val_62 = 0;
            val_62 = val_62 + 1;
            val_63 = 0;
            val_47.NotifyServerCertificate(serverCertificate:  val_48 + 104);
            val_53 = 4;
            goto label_111;
            label_52:
            var val_63 = ;
            val_63 = val_63 + 2;
             =  + val_63;
            val_60 =  + 296;
            label_54:
            Org.BouncyCastle.Crypto.Tls.TlsCompression val_26 = val_48.GetCompression();
            var val_68 = val_48;
            if((val_48 + 286) == 0)
            {
                goto label_88;
            }
            
            var val_65 = val_48 + 176;
            var val_66 = 0;
            val_65 = val_65 + 8;
            label_87:
            if(((val_48 + 176 + 8) + -8) == null)
            {
                goto label_86;
            }
            
            val_66 = val_66 + 1;
            val_65 = val_65 + 16;
            if(val_66 < (val_48 + 286))
            {
                goto label_87;
            }
            
            goto label_88;
            label_86:
            var val_67 = val_65;
            val_67 = val_67 + 3;
            val_68 = val_68 + val_67;
            val_66 = val_68 + 296;
            label_88:
            Org.BouncyCastle.Crypto.Tls.TlsCipher val_27 = val_48.GetCipher();
            if((val_48 + 40) != 0)
            {
                goto label_90;
            }
            
            goto label_90;
            label_18:
            var val_69 = ;
            val_69 = val_69 + 6;
             =  + val_69;
            val_54 =  + 296;
            label_20:
            val_48 + 192.SkipServerKeyExchange();
            if((val_48 + 200) == 0)
            {
                goto label_194;
            }
            
            val_67 = 0;
            mem2[0] = Org.BouncyCastle.Crypto.Tls.CertificateRequest.Parse(context:  val_48, input:  val_49);
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf:  val_49);
            var val_74 = val_48 + 192;
            if((val_48 + 192 + 286) == 0)
            {
                goto label_95;
            }
            
            var val_71 = val_48 + 192 + 176;
            var val_72 = 0;
            val_71 = val_71 + 8;
            label_97:
            if(((val_48 + 192 + 176 + 8) + -8) == null)
            {
                goto label_96;
            }
            
            val_72 = val_72 + 1;
            val_71 = val_71 + 16;
            if(val_72 < (val_48 + 192 + 286))
            {
                goto label_97;
            }
            
            label_95:
            val_67 = 8;
            goto label_98;
            label_96:
            var val_73 = val_71;
            val_73 = val_73 + 8;
            val_74 = val_74 + val_73;
            val_68 = val_74 + 296;
            label_98:
            val_48 + 192.ValidateCertificateRequest(certificateRequest:  val_48 + 216);
            val_47 = val_48 + 216;
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.TrackHashAlgorithms(handshakeHash:  val_48 + 40, supportedSignatureAlgorithms:  val_47);
            val_53 = 7;
            goto label_111;
            label_29:
            var val_75 = ;
            val_75 = val_75 + 1;
             =  + val_75;
            val_57 =  + 296;
            label_31:
            val_48 + 192.SkipServerCredentials();
            mem2[0] = 0;
            val_47 = mem[val_48 + 192];
            val_47 = val_48 + 192;
            var val_80 = val_47;
            if((val_48 + 192 + 286) == 0)
            {
                goto label_105;
            }
            
            var val_77 = val_48 + 192 + 176;
            var val_78 = 0;
            val_77 = val_77 + 8;
            label_107:
            if(((val_48 + 192 + 176 + 8) + -8) == null)
            {
                goto label_106;
            }
            
            val_78 = val_78 + 1;
            val_77 = val_77 + 16;
            if(val_78 < (val_48 + 192 + 286))
            {
                goto label_107;
            }
            
            label_105:
            val_56 = 7;
            goto label_108;
            label_106:
            var val_79 = val_77;
            val_79 = val_79 + 7;
            val_80 = val_80 + val_79;
            val_69 = val_80 + 296;
            label_108:
            val_47.ProcessServerKeyExchange(input:  val_49);
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf:  val_49);
            val_53 = 6;
            goto label_111;
            label_64:
            var val_81 = ;
            val_81 = val_81 + 1;
             =  + val_81;
            val_62 =  + 296;
            label_66:
            val_48 + 192.SkipServerCredentials();
            val_61 = mem[val_48 + 144];
            val_61 = val_48 + 144;
            mem2[0] = 0;
            if(((int)val_61 & 65535) > 5)
            {
                goto label_112;
            }
            
            var val_86 = val_48 + 192;
            if((val_48 + 192 + 286) == 0)
            {
                goto label_117;
            }
            
            var val_83 = val_48 + 192 + 176;
            var val_84 = 0;
            val_83 = val_83 + 8;
            label_116:
            if(((val_48 + 192 + 176 + 8) + -8) == null)
            {
                goto label_115;
            }
            
            val_84 = val_84 + 1;
            val_83 = val_83 + 16;
            if(val_84 < (val_48 + 192 + 286))
            {
                goto label_116;
            }
            
            goto label_117;
            label_115:
            var val_85 = val_83;
            val_85 = val_85 + 6;
            val_86 = val_86 + val_85;
            val_70 = val_86 + 296;
            label_117:
            val_48 + 192.SkipServerKeyExchange();
            label_112:
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf:  val_48 + 40);
            mem2[0] = 8;
            var val_90 = val_48 + 40;
            val_52 = 1152921505528942592;
            if((val_48 + 40 + 286) == 0)
            {
                goto label_125;
            }
            
            var val_87 = val_48 + 40 + 176;
            var val_88 = 0;
            val_87 = val_87 + 8;
            label_124:
            if(((val_48 + 40 + 176 + 8) + -8) == null)
            {
                goto label_123;
            }
            
            val_88 = val_88 + 1;
            val_87 = val_87 + 16;
            if(val_88 < (val_48 + 40 + 286))
            {
                goto label_124;
            }
            
            goto label_125;
            label_123:
            var val_89 = val_87;
            val_89 = val_89 + 3;
            val_90 = val_90 + val_89;
            val_71 = val_90 + 296;
            label_125:
            val_48 + 40.SealHashAlgorithms();
            var val_94 = val_48 + 168;
            if((val_48 + 168 + 286) == 0)
            {
                goto label_130;
            }
            
            var val_91 = val_48 + 168 + 176;
            var val_92 = 0;
            val_91 = val_91 + 8;
            label_129:
            if(((val_48 + 168 + 176 + 8) + -8) == null)
            {
                goto label_128;
            }
            
            val_92 = val_92 + 1;
            val_91 = val_91 + 16;
            if(val_92 < (val_48 + 168 + 286))
            {
                goto label_129;
            }
            
            goto label_130;
            label_128:
            var val_93 = val_91;
            val_93 = val_93 + 18;
            val_94 = val_94 + val_93;
            val_72 = val_94 + 296;
            label_130:
            val_73 = public System.Collections.IList Org.BouncyCastle.Crypto.Tls.TlsClient::GetClientSupplementalData();
            System.Collections.IList val_29 = val_48 + 168.GetClientSupplementalData();
            if(val_29 != null)
            {
                    val_73 = val_29;
            }
            
            mem2[0] = 9;
            if((val_48 + 216) == 0)
            {
                goto label_132;
            }
            
            var val_100 = val_48 + 200;
            if((val_48 + 200 + 286) == 0)
            {
                goto label_137;
            }
            
            var val_95 = val_48 + 200 + 176;
            var val_96 = 0;
            val_95 = val_95 + 8;
            label_136:
            if(((val_48 + 200 + 176 + 8) + -8) == null)
            {
                goto label_135;
            }
            
            val_96 = val_96 + 1;
            val_95 = val_95 + 16;
            if(val_96 < (val_48 + 200 + 286))
            {
                goto label_136;
            }
            
            goto label_137;
            label_132:
            var val_109 = val_48 + 192;
            if((val_48 + 192 + 286) == 0)
            {
                goto label_142;
            }
            
            var val_97 = val_48 + 192 + 176;
            var val_98 = 0;
            val_97 = val_97 + 8;
            label_141:
            if(((val_48 + 192 + 176 + 8) + -8) == null)
            {
                goto label_140;
            }
            
            val_98 = val_98 + 1;
            val_97 = val_97 + 16;
            if(val_98 < (val_48 + 192 + 286))
            {
                goto label_141;
            }
            
            goto label_142;
            label_135:
            var val_99 = val_95;
            val_99 = val_99 + 1;
            val_100 = val_100 + val_99;
            val_74 = val_100 + 296;
            label_137:
            val_76 = val_48 + 216;
            val_77 = val_48 + 200.GetClientCredentials(context:  val_48, certificateRequest:  val_76);
            var val_106 = val_48 + 192;
            if(val_77 == null)
            {
                goto label_144;
            }
            
            if((val_48 + 192 + 286) == 0)
            {
                goto label_145;
            }
            
            var val_101 = val_48 + 192 + 176;
            var val_102 = 0;
            val_101 = val_101 + 8;
            label_147:
            if(((val_48 + 192 + 176 + 8) + -8) == null)
            {
                goto label_146;
            }
            
            val_102 = val_102 + 1;
            val_101 = val_101 + 16;
            if(val_102 < (val_48 + 192 + 286))
            {
                goto label_147;
            }
            
            label_145:
            val_76 = 10;
            goto label_148;
            label_144:
            if((val_48 + 192 + 286) == 0)
            {
                goto label_152;
            }
            
            var val_103 = val_48 + 192 + 176;
            var val_104 = 0;
            val_103 = val_103 + 8;
            label_151:
            if(((val_48 + 192 + 176 + 8) + -8) == null)
            {
                goto label_150;
            }
            
            val_104 = val_104 + 1;
            val_103 = val_103 + 16;
            if(val_104 < (val_48 + 192 + 286))
            {
                goto label_151;
            }
            
            goto label_152;
            label_146:
            var val_105 = val_101;
            val_105 = val_105 + 10;
            val_106 = val_106 + val_105;
            val_78 = val_106 + 296;
            label_148:
            val_48 + 192.ProcessClientCredentials(clientCredentials:  val_77);
            var val_107 = 0;
            val_107 = val_107 + 1;
            Org.BouncyCastle.Crypto.Tls.Certificate val_32 = val_77.Certificate;
            goto label_157;
            label_140:
            var val_108 = val_97;
            val_108 = val_108 + 9;
            val_109 = val_109 + val_108;
            val_75 = val_109 + 296;
            label_142:
            val_48 + 192.SkipClientCredentials();
            goto label_158;
            label_150:
            var val_110 = val_103;
            val_110 = val_110 + 9;
            val_106 = val_106 + val_110;
            val_79 = val_106 + 296;
            label_152:
            val_48 + 192.SkipClientCredentials();
            val_81 = null;
            val_81 = null;
            label_158:
            val_77 = 0;
            label_157:
            mem2[0] = 10;
            mem2[0] = 11;
            val_47 = val_48 + 40;
            mem2[0] = Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetCurrentPrfHash(context:  val_48, handshakeHash:  val_47, sslSender:  0);
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.EstablishMasterSecret(context:  val_48, keyExchange:  val_48 + 192);
            var val_114 = val_48;
            if((val_48 + 286) == 0)
            {
                goto label_169;
            }
            
            var val_111 = val_48 + 176;
            var val_112 = 0;
            val_111 = val_111 + 8;
            label_168:
            if(((val_48 + 176 + 8) + -8) == null)
            {
                goto label_167;
            }
            
            val_112 = val_112 + 1;
            val_111 = val_111 + 16;
            if(val_112 < (val_48 + 286))
            {
                goto label_168;
            }
            
            goto label_169;
            label_167:
            var val_113 = val_111;
            val_113 = val_113 + 2;
            val_114 = val_114 + val_113;
            val_82 = val_114 + 296;
            label_169:
            val_51 = val_48.GetCompression();
            var val_118 = val_48;
            if((val_48 + 286) == 0)
            {
                goto label_174;
            }
            
            var val_115 = val_48 + 176;
            var val_116 = 0;
            val_115 = val_115 + 8;
            label_173:
            if(((val_48 + 176 + 8) + -8) == null)
            {
                goto label_172;
            }
            
            val_116 = val_116 + 1;
            val_115 = val_115 + 16;
            if(val_116 < (val_48 + 286))
            {
                goto label_173;
            }
            
            goto label_174;
            label_172:
            var val_117 = val_115;
            val_117 = val_117 + 3;
            val_118 = val_118 + val_117;
            val_83 = val_118 + 296;
            label_174:
            Org.BouncyCastle.Crypto.Tls.TlsCipher val_35 = val_48.GetCipher();
            if((val_77 == 0) || (val_77 == 0))
            {
                goto label_177;
            }
            
            val_51 = null;
            val_84 = val_51;
            val_85 = val_77;
            if(val_85 == 0)
            {
                    val_84 = 0;
                val_85 = 0;
            }
            
            val_86 = 0;
            Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm val_37 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetSignatureAndHashAlgorithm(context:  val_48, signerCredentials:  val_85);
            if(val_37 == null)
            {
                goto label_181;
            }
            
            val_51 = val_37;
            var val_122 = val_47;
            if((val_48 + 40 + 286) == 0)
            {
                goto label_183;
            }
            
            var val_119 = val_48 + 40 + 176;
            var val_120 = 0;
            val_119 = val_119 + 8;
            label_185:
            if(((val_48 + 40 + 176 + 8) + -8) == null)
            {
                goto label_184;
            }
            
            val_120 = val_120 + 1;
            val_119 = val_119 + 16;
            if(val_120 < (val_48 + 40 + 286))
            {
                goto label_185;
            }
            
            label_183:
            val_87 = 6;
            goto label_186;
            label_181:
            val_89 = val_48 + 96;
            goto label_188;
            label_184:
            var val_121 = val_119;
            val_121 = val_121 + 6;
            val_122 = val_122 + val_121;
            val_88 = val_122 + 296;
            label_186:
            val_90 = public System.Byte[] Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash::GetFinalHash(byte hashAlgorithm);
            val_89 = val_47;
            label_188:
            var val_125 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_190;
            }
            
            var val_123 = mem[282584257676847];
            var val_124 = 0;
            val_123 = val_123 + 8;
            label_192:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_191;
            }
            
            val_124 = val_124 + 1;
            val_123 = val_123 + 16;
            if(val_124 < mem[282584257676957])
            {
                goto label_192;
            }
            
            label_190:
            val_90 = 0;
            goto label_193;
            label_191:
            val_125 = val_125 + (((mem[282584257676847] + 8)) << 4);
            val_91 = val_125 + 296;
            label_193:
            val_47 = val_85.GenerateCertificateSignature(hash:  val_89.GetFinalHash(hashAlgorithm:  val_51));
            Org.BouncyCastle.Crypto.Tls.DigitallySigned val_40 = new Org.BouncyCastle.Crypto.Tls.DigitallySigned(algorithm:  val_37, signature:  val_47);
            mem2[0] = 12;
            label_177:
            val_53 = 13;
            label_111:
            mem2[0] = 13;
            return;
            label_67:
            label_194:
            new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert() = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  10);
            goto label_194;
        }
        protected virtual void HandleSupplementalData(System.Collections.IList serverSupplementalData)
        {
            var val_5;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_5 = public System.Void Org.BouncyCastle.Crypto.Tls.TlsClient::ProcessServerSupplementalData(System.Collections.IList serverSupplementalData);
            this.mTlsClient.ProcessServerSupplementalData(serverSupplementalData:  serverSupplementalData);
            mem[1152921547525415696] = 3;
            var val_6 = 0;
            val_6 = val_6 + 1;
            val_5 = 16;
            Org.BouncyCastle.Crypto.Tls.TlsKeyExchange val_3 = this.mTlsClient.GetKeyExchange();
            this.mKeyExchange = val_3;
            var val_7 = 0;
            val_7 = val_7 + 1;
            val_5 = 0;
            val_3.Init(context:  this);
        }
        protected virtual void ReceiveNewSessionTicketMessage(System.IO.MemoryStream buf)
        {
            Org.BouncyCastle.Crypto.Tls.TlsProtocol.AssertEmpty(buf:  buf);
            var val_3 = 0;
            val_3 = val_3 + 1;
            this.mTlsClient.NotifyNewSessionTicket(newSessionTicket:  Org.BouncyCastle.Crypto.Tls.NewSessionTicket.Parse(input:  buf));
        }
        protected virtual void ReceiveServerHelloMessage(System.IO.MemoryStream buf)
        {
            var val_51;
            var val_52;
            var val_54;
            bool val_56;
            var val_58;
            var val_60;
            var val_62;
            var val_64;
            var val_69;
            var val_70;
            var val_74;
            var val_75;
            var val_77;
            var val_78;
            var val_79;
            System.Collections.IDictionary val_80;
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion val_1 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadVersion(input:  buf);
            int val_57 = val_1.version;
            val_57 = val_57 >> 8;
            if(((val_57 == 254) || (X21 == 0)) || (val_1.version != (X21 + 16)))
            {
                goto label_140;
            }
            
            var val_58 = 0;
            val_58 = val_58 + 1;
            if((val_1.IsEqualOrEarlierVersionOf(version:  this.ClientVersion)) == false)
            {
                goto label_140;
            }
            
            val_52 = 1152921505527824384;
            var val_59 = 0;
            val_59 = val_59 + 1;
            val_51 = 10;
            this.mTlsClient.NotifyServerVersion(selectedVersion:  val_1);
            val_54 = 0;
            mem2[0] = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadFully(length:  32, input:  buf);
            this.mSelectedSessionID = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadOpaque8(input:  buf);
            if(val_7.Length >= 33)
            {
                goto label_140;
            }
            
            var val_60 = 0;
            val_60 = val_60 + 1;
            val_54 = 11;
            this.mTlsClient.NotifySessionID(sessionID:  this.mSelectedSessionID);
            if(this.mSelectedSessionID.Length == 0)
            {
                goto label_33;
            }
            
            if(this.mSelectedSessionID == null)
            {
                goto label_34;
            }
            
            var val_61 = 0;
            val_61 = val_61 + 1;
            goto label_38;
            label_33:
            val_58 = 0;
            val_56 = 0;
            goto label_41;
            label_38:
            val_56 = Org.BouncyCastle.Utilities.Arrays.AreEqual(a:  this.mSelectedSessionID, b:  this.mSelectedSessionID.SessionID);
            if(this == null)
            {
                goto label_40;
            }
            
            label_34:
            val_58 = 0;
            goto label_41;
            label_40:
            val_58 = 1;
            label_41:
            mem[1152921547526034242] = val_56;
            int val_12 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint16(input:  buf);
            if(((val_12 == 0) || ((Org.BouncyCastle.Utilities.Arrays.Contains(a:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.__il2cppRuntimeField_cctor_finished, n:  val_12)) == false)) || ((Org.BouncyCastle.Crypto.Tls.CipherSuite.IsScsv(cipherSuite:  val_12)) == true))
            {
                goto label_140;
            }
            
            var val_62 = 0;
            val_62 = val_62 + 1;
            val_60 = 0;
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsValidCipherSuiteForVersion(cipherSuite:  val_12, serverVersion:  this.ServerVersion)) == false)
            {
                goto label_140;
            }
            
            var val_63 = 0;
            val_63 = val_63 + 1;
            val_60 = 12;
            this.mTlsClient.NotifySelectedCipherSuite(selectedCipherSuite:  val_12);
            byte val_19 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.ReadUint8(input:  buf);
            val_62 = 0;
            if((Org.BouncyCastle.Utilities.Arrays.Contains(a:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.__il2cppRuntimeField_cctor_finished, n:  val_19)) == false)
            {
                goto label_140;
            }
            
            var val_64 = 0;
            val_64 = val_64 + 1;
            val_62 = 13;
            this.mTlsClient.NotifySelectedCompressionMethod(selectedCompressionMethod:  val_19);
            val_64 = 1152921505529262080;
            System.Collections.IDictionary val_22 = Org.BouncyCastle.Crypto.Tls.TlsProtocol.ReadExtensions(input:  buf);
            mem[1152921547526034232] = val_22;
            if(val_22 == null)
            {
                goto label_113;
            }
            
            var val_65 = 0;
            val_65 = val_65 + 1;
            var val_66 = 0;
            val_66 = val_66 + 1;
            System.Collections.IEnumerator val_26 = val_22.Keys.GetEnumerator();
            label_96:
            var val_67 = 0;
            val_67 = val_67 + 1;
            if(val_26.MoveNext() == false)
            {
                goto label_85;
            }
            
            var val_68 = 0;
            val_68 = val_68 + 1;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_26.Current);
            if((null == 65281) || ((Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  null, extensionType:  21884928)) != null))
            {
                goto label_96;
            }
            
            new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert() = new System.IO.IOException(message:  Org.BouncyCastle.Crypto.Tls.AlertDescription.GetText(alertDescription:  110), innerException:  0);
            .alertDescription = 110;
            label_85:
            val_58 = val_58;
            val_64 = 1152921505529262080;
            val_69 = 0;
            val_70 = 0;
            if(val_26 != null)
            {
                    var val_69 = 0;
                val_69 = val_69 + 1;
                val_26.Dispose();
            }
            
            val_52 = 1152921505527824384;
            label_113:
            val_74 = 0;
            System.Byte[] val_36 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  val_26, extensionType:  1);
            if(val_36 != null)
            {
                    mem[1152921547526034244] = 1;
                val_75 = null;
                val_75 = null;
                val_74 = 0;
                if((Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a:  val_36, b:  Org.BouncyCastle.Crypto.Tls.TlsProtocol.CreateRenegotiationInfo(renegotiated_connection:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes))) == false)
            {
                goto label_168;
            }
            
            }
            
            var val_70 = 0;
            val_70 = val_70 + 1;
            val_74 = 1;
            val_77 = public System.Void Org.BouncyCastle.Crypto.Tls.TlsPeer::NotifySecureRenegotiation(bool secureRenegotiation);
            this.mTlsClient.NotifySecureRenegotiation(secureRenegotiation:  (Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes != null) ? 1 : 0);
            if((public System.Void Org.BouncyCastle.Crypto.Tls.TlsPeer::NotifySecureRenegotiation(bool secureRenegotiation)) == 0)
            {
                goto label_127;
            }
            
            if((val_12 != (public System.Void Org.BouncyCastle.Crypto.Tls.TlsPeer::NotifySecureRenegotiation(bool secureRenegotiation))) || ((val_19 & 255) != (public System.Void Org.BouncyCastle.Crypto.Tls.TlsPeer::NotifySecureRenegotiation(bool secureRenegotiation))))
            {
                goto label_140;
            }
            
            val_78 = this.mTlsClient.ReadServerExtensions();
            val_79 = 0;
            goto label_133;
            label_127:
            label_133:
            mem[20] = val_12;
            mem[24] = val_19;
            if(this.mTlsClient == null)
            {
                goto label_136;
            }
            
            bool val_43 = Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasEncryptThenMacExtension(extensions:  this.mTlsClient);
            if(val_43 != false)
            {
                    if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsBlockCipherSuite(ciphersuite:  val_12)) == false)
            {
                goto label_140;
            }
            
            }
            
            mem2[0] = val_43;
            mem2[0] = Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasExtendedMasterSecretExtension(extensions:  this.mTlsClient);
            val_80 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
            val_77 = this.mTlsClient;
            mem2[0] = this;
            bool val_49 = Org.BouncyCastle.Crypto.Tls.TlsExtensionsUtilities.HasTruncatedHMacExtension(extensions:  this.mTlsClient);
            mem2[0] = val_49;
            if(val_49 == false)
            {
                goto label_145;
            }
            
            if( == 0)
            {
                goto label_158;
            }
            
            label_157:
            label_158:
            mem[1152921547526034245] = 0;
            if(val_49 == false)
            {
                goto label_147;
            }
            
            if( == 0)
            {
                goto label_162;
            }
            
            label_161:
            label_162:
            mem[1152921547526034246] = 0;
            label_136:
            if(Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes == null)
            {
                goto label_149;
            }
            
            var val_71 = 0;
            val_71 = val_71 + 1;
            val_77 = 14;
            goto label_154;
            label_145:
            bool val_51 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.HasExpectedEmptyExtensionData(extensions:  this.mTlsClient, extensionType:  5, alertDescription:  47);
            if( != 0)
            {
                goto label_157;
            }
            
            goto label_158;
            label_147:
            bool val_53 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.HasExpectedEmptyExtensionData(extensions:  this.mTlsClient, extensionType:  35, alertDescription:  47);
            if( != 0)
            {
                goto label_161;
            }
            
            goto label_162;
            label_154:
            val_80 = this.mTlsClient;
            this.mTlsClient.ProcessServerExtensions(serverExtensions:  val_80);
            label_149:
            mem2[0] = Org.BouncyCastle.Crypto.Tls.TlsProtocol.GetPrfAlgorithm(context:  this, ciphersuite:  val_43);
            mem[1152921547526034128] = 12;
            return;
            label_140:
            label_168:
            new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert() = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  47);
            goto label_168;
        }
        protected virtual void SendCertificateVerifyMessage(Org.BouncyCastle.Crypto.Tls.DigitallySigned certificateVerify)
        {
            new TlsProtocol.HandshakeMessage(handshakeType:  15, length:  60).WriteToRecordStream(protocol:  this);
        }
        protected virtual void SendClientHelloMessage()
        {
            var val_19;
            System.Byte[] val_21;
            var val_25;
            var val_24 = 0;
            val_24 = val_24 + 1;
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion val_2 = this.mTlsClient.ClientHelloRecordLayerVersion;
            var val_25 = 0;
            val_25 = val_25 + 1;
            Org.BouncyCastle.Crypto.Tls.ProtocolVersion val_4 = this.mTlsClient.ClientVersion;
            int val_26 = val_4.version;
            val_26 = val_26 >> 8;
            if(val_26 == 254)
            {
                goto label_13;
            }
            
            val_19 = null;
            val_19 = null;
            if(this != null)
            {
                    var val_27 = 0;
                val_27 = val_27 + 1;
                val_21 = this.SessionID;
                if(val_21 != null)
            {
                    if(val_6.Length < 33)
            {
                goto label_23;
            }
            
            }
            
                val_19 = null;
                val_19 = null;
            }
            
            val_21 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
            label_23:
            var val_28 = 0;
            val_28 = val_28 + 1;
            bool val_8 = this.mTlsClient.IsFallback;
            var val_29 = 0;
            val_29 = val_29 + 1;
            mem[1152921547526828912] = this.mTlsClient.GetCipherSuites();
            var val_30 = 0;
            val_30 = val_30 + 1;
            mem[1152921547526828920] = this.mTlsClient.GetCompressionMethods();
            if((Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes.Length != 0) && (Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes.Length != 0))
            {
                    if((Org.BouncyCastle.Utilities.Arrays.Contains(a:  0, n:  Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes.Length + 16)) != false)
            {
                    if((Org.BouncyCastle.Utilities.Arrays.Contains(a:  this.mTlsClient, n:  X26 + 20)) == true)
            {
                goto label_46;
            }
            
            }
            
                val_25 = null;
                val_25 = null;
                val_21 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
            }
            
            label_46:
            var val_31 = 0;
            val_31 = val_31 + 1;
            mem[1152921547526828928] = this.mTlsClient.GetClientExtensions();
            TlsProtocol.HandshakeMessage val_17 = new TlsProtocol.HandshakeMessage(handshakeType:  1, length:  60);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteVersion(version:  val_4, output:  val_17);
            val_17.Write(data:  val_4);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteOpaque8(buf:  val_21, output:  val_17);
            System.Byte[] val_18 = Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetExtensionData(extensions:  val_21, extensionType:  1);
            bool val_19 = Org.BouncyCastle.Utilities.Arrays.Contains(a:  1152921505526759424, n:  255);
            if((val_18 != null) || (val_19 == true))
            {
                goto label_59;
            }
            
            mem[1152921547526828912] = Org.BouncyCastle.Utilities.Arrays.Append(a:  val_19, b:  255);
            if(val_8 == true)
            {
                goto label_60;
            }
            
            goto label_63;
            label_59:
            if(val_8 == false)
            {
                goto label_63;
            }
            
            label_60:
            bool val_21 = Org.BouncyCastle.Utilities.Arrays.Contains(a:  val_19, n:  0);
            if(val_21 != true)
            {
                    mem[1152921547526828912] = Org.BouncyCastle.Utilities.Arrays.Append(a:  val_21, b:  0);
            }
            
            label_63:
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16ArrayWithUint16Length(uints:  val_18, output:  val_17);
            Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8ArrayWithUint8Length(uints:  val_18, output:  val_17);
            if(val_18 != null)
            {
                    Org.BouncyCastle.Crypto.Tls.TlsProtocol.WriteExtensions(output:  val_17, extensions:  val_18);
            }
            
            val_17.WriteToRecordStream(protocol:  this);
            return;
            label_13:
            Org.BouncyCastle.Crypto.Tls.TlsFatalAlert val_23 = new Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(alertDescription:  80);
        }
        protected virtual void SendClientKeyExchangeMessage()
        {
            var val_3;
            TlsProtocol.HandshakeMessage val_1 = null;
            val_3 = 60;
            val_1 = new TlsProtocol.HandshakeMessage(handshakeType:  16, length:  60);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_3 = 12;
            this.mKeyExchange.GenerateClientKeyExchange(output:  val_1);
            val_1.WriteToRecordStream(protocol:  this);
        }
    
    }

}
