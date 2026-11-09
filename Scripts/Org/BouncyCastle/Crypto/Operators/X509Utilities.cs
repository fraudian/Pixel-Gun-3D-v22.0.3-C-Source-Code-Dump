using UnityEngine;

namespace Org.BouncyCastle.Crypto.Operators
{
    internal class X509Utilities
    {
        // Fields
        private static readonly Org.BouncyCastle.Asn1.Asn1Null derNull;
        private static readonly System.Collections.IDictionary algorithms;
        private static readonly System.Collections.IDictionary exParams;
        private static readonly Org.BouncyCastle.Utilities.Collections.ISet noParams;
        
        // Methods
        private static X509Utilities()
        {
            var val_73;
            var val_74;
            var val_75;
            var val_76;
            var val_77;
            var val_78;
            var val_79;
            var val_80;
            var val_81;
            var val_82;
            var val_83;
            var val_84;
            var val_85;
            var val_86;
            var val_87;
            var val_88;
            var val_89;
            var val_90;
            var val_91;
            var val_92;
            var val_93;
            var val_94;
            var val_95;
            var val_96;
            var val_97;
            var val_98;
            var val_99;
            var val_100;
            var val_101;
            var val_102;
            var val_103;
            var val_104;
            var val_105;
            var val_106;
            var val_107;
            var val_108;
            var val_109;
            var val_110;
            var val_111;
            var val_112;
            var val_113;
            var val_114;
            var val_115;
            var val_116;
            var val_117;
            var val_118;
            var val_119;
            var val_120;
            object val_121;
            var val_122;
            var val_123;
            var val_124;
            var val_125;
            var val_126;
            var val_127;
            var val_128;
            var val_129;
            var val_130;
            var val_131;
            var val_132;
            var val_133;
            var val_134;
            var val_135;
            var val_136;
            var val_137;
            var val_138;
            var val_139;
            var val_140;
            var val_141;
            var val_142;
            var val_143;
            var val_144;
            var val_145;
            var val_146;
            var val_147;
            var val_148;
            var val_149;
            var val_150;
            val_73 = null;
            val_73 = null;
            Org.BouncyCastle.Crypto.Operators.X509Utilities.derNull = Org.BouncyCastle.Asn1.DerNull.Instance;
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Crypto.Operators.X509Utilities.exParams = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Utilities.Collections.HashSet val_3 = new Org.BouncyCastle.Utilities.Collections.HashSet();
            Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams = val_3;
            val_74 = null;
            val_74 = null;
            var val_17 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_11;
            }
            
            var val_14 = mem[val_1] + 176;
            var val_15 = 0;
            val_14 = val_14 + 8;
            label_10:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_9;
            }
            
            val_15 = val_15 + 1;
            val_14 = val_14 + 16;
            if(val_15 < (mem[val_1] + 286))
            {
                goto label_10;
            }
            
            goto label_11;
            label_9:
            var val_16 = val_14;
            val_16 = val_16 + 5;
            val_17 = val_17 + val_16;
            val_75 = val_17 + 296;
            label_11:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "MD2WITHRSAENCRYPTION", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption);
            var val_21 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_16;
            }
            
            var val_18 = mem[val_1] + 176;
            var val_19 = 0;
            val_18 = val_18 + 8;
            label_15:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_14;
            }
            
            val_19 = val_19 + 1;
            val_18 = val_18 + 16;
            if(val_19 < (mem[val_1] + 286))
            {
                goto label_15;
            }
            
            goto label_16;
            label_14:
            var val_20 = val_18;
            val_20 = val_20 + 5;
            val_21 = val_21 + val_20;
            val_76 = val_21 + 296;
            label_16:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "MD2WITHRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption);
            var val_25 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_21;
            }
            
            var val_22 = mem[val_1] + 176;
            var val_23 = 0;
            val_22 = val_22 + 8;
            label_20:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_19;
            }
            
            val_23 = val_23 + 1;
            val_22 = val_22 + 16;
            if(val_23 < (mem[val_1] + 286))
            {
                goto label_20;
            }
            
            goto label_21;
            label_19:
            var val_24 = val_22;
            val_24 = val_24 + 5;
            val_25 = val_25 + val_24;
            val_77 = val_25 + 296;
            label_21:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "MD5WITHRSAENCRYPTION", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption);
            var val_29 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_26;
            }
            
            var val_26 = mem[val_1] + 176;
            var val_27 = 0;
            val_26 = val_26 + 8;
            label_25:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_24;
            }
            
            val_27 = val_27 + 1;
            val_26 = val_26 + 16;
            if(val_27 < (mem[val_1] + 286))
            {
                goto label_25;
            }
            
            goto label_26;
            label_24:
            var val_28 = val_26;
            val_28 = val_28 + 5;
            val_29 = val_29 + val_28;
            val_78 = val_29 + 296;
            label_26:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "MD5WITHRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption);
            var val_33 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_31;
            }
            
            var val_30 = mem[val_1] + 176;
            var val_31 = 0;
            val_30 = val_30 + 8;
            label_30:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_29;
            }
            
            val_31 = val_31 + 1;
            val_30 = val_30 + 16;
            if(val_31 < (mem[val_1] + 286))
            {
                goto label_30;
            }
            
            goto label_31;
            label_29:
            var val_32 = val_30;
            val_32 = val_32 + 5;
            val_33 = val_33 + val_32;
            val_79 = val_33 + 296;
            label_31:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA1WITHRSAENCRYPTION", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
            var val_37 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_36;
            }
            
            var val_34 = mem[val_1] + 176;
            var val_35 = 0;
            val_34 = val_34 + 8;
            label_35:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_34;
            }
            
            val_35 = val_35 + 1;
            val_34 = val_34 + 16;
            if(val_35 < (mem[val_1] + 286))
            {
                goto label_35;
            }
            
            goto label_36;
            label_34:
            var val_36 = val_34;
            val_36 = val_36 + 5;
            val_37 = val_37 + val_36;
            val_80 = val_37 + 296;
            label_36:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA1WITHRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
            var val_41 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_41;
            }
            
            var val_38 = mem[val_1] + 176;
            var val_39 = 0;
            val_38 = val_38 + 8;
            label_40:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_39;
            }
            
            val_39 = val_39 + 1;
            val_38 = val_38 + 16;
            if(val_39 < (mem[val_1] + 286))
            {
                goto label_40;
            }
            
            goto label_41;
            label_39:
            var val_40 = val_38;
            val_40 = val_40 + 5;
            val_41 = val_41 + val_40;
            val_81 = val_41 + 296;
            label_41:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA224WITHRSAENCRYPTION", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
            var val_45 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_46;
            }
            
            var val_42 = mem[val_1] + 176;
            var val_43 = 0;
            val_42 = val_42 + 8;
            label_45:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_44;
            }
            
            val_43 = val_43 + 1;
            val_42 = val_42 + 16;
            if(val_43 < (mem[val_1] + 286))
            {
                goto label_45;
            }
            
            goto label_46;
            label_44:
            var val_44 = val_42;
            val_44 = val_44 + 5;
            val_45 = val_45 + val_44;
            val_82 = val_45 + 296;
            label_46:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA224WITHRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
            var val_49 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_51;
            }
            
            var val_46 = mem[val_1] + 176;
            var val_47 = 0;
            val_46 = val_46 + 8;
            label_50:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_49;
            }
            
            val_47 = val_47 + 1;
            val_46 = val_46 + 16;
            if(val_47 < (mem[val_1] + 286))
            {
                goto label_50;
            }
            
            goto label_51;
            label_49:
            var val_48 = val_46;
            val_48 = val_48 + 5;
            val_49 = val_49 + val_48;
            val_83 = val_49 + 296;
            label_51:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA256WITHRSAENCRYPTION", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
            var val_53 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_56;
            }
            
            var val_50 = mem[val_1] + 176;
            var val_51 = 0;
            val_50 = val_50 + 8;
            label_55:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_54;
            }
            
            val_51 = val_51 + 1;
            val_50 = val_50 + 16;
            if(val_51 < (mem[val_1] + 286))
            {
                goto label_55;
            }
            
            goto label_56;
            label_54:
            var val_52 = val_50;
            val_52 = val_52 + 5;
            val_53 = val_53 + val_52;
            val_84 = val_53 + 296;
            label_56:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA256WITHRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
            var val_57 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_61;
            }
            
            var val_54 = mem[val_1] + 176;
            var val_55 = 0;
            val_54 = val_54 + 8;
            label_60:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_59;
            }
            
            val_55 = val_55 + 1;
            val_54 = val_54 + 16;
            if(val_55 < (mem[val_1] + 286))
            {
                goto label_60;
            }
            
            goto label_61;
            label_59:
            var val_56 = val_54;
            val_56 = val_56 + 5;
            val_57 = val_57 + val_56;
            val_85 = val_57 + 296;
            label_61:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA384WITHRSAENCRYPTION", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
            var val_61 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_66;
            }
            
            var val_58 = mem[val_1] + 176;
            var val_59 = 0;
            val_58 = val_58 + 8;
            label_65:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_64;
            }
            
            val_59 = val_59 + 1;
            val_58 = val_58 + 16;
            if(val_59 < (mem[val_1] + 286))
            {
                goto label_65;
            }
            
            goto label_66;
            label_64:
            var val_60 = val_58;
            val_60 = val_60 + 5;
            val_61 = val_61 + val_60;
            val_86 = val_61 + 296;
            label_66:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA384WITHRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
            var val_65 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_71;
            }
            
            var val_62 = mem[val_1] + 176;
            var val_63 = 0;
            val_62 = val_62 + 8;
            label_70:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_69;
            }
            
            val_63 = val_63 + 1;
            val_62 = val_62 + 16;
            if(val_63 < (mem[val_1] + 286))
            {
                goto label_70;
            }
            
            goto label_71;
            label_69:
            var val_64 = val_62;
            val_64 = val_64 + 5;
            val_65 = val_65 + val_64;
            val_87 = val_65 + 296;
            label_71:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA512WITHRSAENCRYPTION", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
            var val_69 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_76;
            }
            
            var val_66 = mem[val_1] + 176;
            var val_67 = 0;
            val_66 = val_66 + 8;
            label_75:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_74;
            }
            
            val_67 = val_67 + 1;
            val_66 = val_66 + 16;
            if(val_67 < (mem[val_1] + 286))
            {
                goto label_75;
            }
            
            goto label_76;
            label_74:
            var val_68 = val_66;
            val_68 = val_68 + 5;
            val_69 = val_69 + val_68;
            val_88 = val_69 + 296;
            label_76:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA512WITHRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
            var val_73 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_81;
            }
            
            var val_70 = mem[val_1] + 176;
            var val_71 = 0;
            val_70 = val_70 + 8;
            label_80:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_79;
            }
            
            val_71 = val_71 + 1;
            val_70 = val_70 + 16;
            if(val_71 < (mem[val_1] + 286))
            {
                goto label_80;
            }
            
            goto label_81;
            label_79:
            var val_72 = val_70;
            val_72 = val_72 + 5;
            val_73 = val_73 + val_72;
            val_89 = val_73 + 296;
            label_81:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA1WITHRSAANDMGF1", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
            var val_77 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_86;
            }
            
            var val_74 = mem[val_1] + 176;
            var val_75 = 0;
            val_74 = val_74 + 8;
            label_85:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_84;
            }
            
            val_75 = val_75 + 1;
            val_74 = val_74 + 16;
            if(val_75 < (mem[val_1] + 286))
            {
                goto label_85;
            }
            
            goto label_86;
            label_84:
            var val_76 = val_74;
            val_76 = val_76 + 5;
            val_77 = val_77 + val_76;
            val_90 = val_77 + 296;
            label_86:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA224WITHRSAANDMGF1", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
            var val_81 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_91;
            }
            
            var val_78 = mem[val_1] + 176;
            var val_79 = 0;
            val_78 = val_78 + 8;
            label_90:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_89;
            }
            
            val_79 = val_79 + 1;
            val_78 = val_78 + 16;
            if(val_79 < (mem[val_1] + 286))
            {
                goto label_90;
            }
            
            goto label_91;
            label_89:
            var val_80 = val_78;
            val_80 = val_80 + 5;
            val_81 = val_81 + val_80;
            val_91 = val_81 + 296;
            label_91:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA256WITHRSAANDMGF1", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
            var val_85 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_96;
            }
            
            var val_82 = mem[val_1] + 176;
            var val_83 = 0;
            val_82 = val_82 + 8;
            label_95:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_94;
            }
            
            val_83 = val_83 + 1;
            val_82 = val_82 + 16;
            if(val_83 < (mem[val_1] + 286))
            {
                goto label_95;
            }
            
            goto label_96;
            label_94:
            var val_84 = val_82;
            val_84 = val_84 + 5;
            val_85 = val_85 + val_84;
            val_92 = val_85 + 296;
            label_96:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA384WITHRSAANDMGF1", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
            var val_89 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_101;
            }
            
            var val_86 = mem[val_1] + 176;
            var val_87 = 0;
            val_86 = val_86 + 8;
            label_100:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_99;
            }
            
            val_87 = val_87 + 1;
            val_86 = val_86 + 16;
            if(val_87 < (mem[val_1] + 286))
            {
                goto label_100;
            }
            
            goto label_101;
            label_99:
            var val_88 = val_86;
            val_88 = val_88 + 5;
            val_89 = val_89 + val_88;
            val_93 = val_89 + 296;
            label_101:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA512WITHRSAANDMGF1", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
            val_94 = null;
            val_94 = null;
            var val_93 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_108;
            }
            
            var val_90 = mem[val_1] + 176;
            var val_91 = 0;
            val_90 = val_90 + 8;
            label_107:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_106;
            }
            
            val_91 = val_91 + 1;
            val_90 = val_90 + 16;
            if(val_91 < (mem[val_1] + 286))
            {
                goto label_107;
            }
            
            goto label_108;
            label_106:
            var val_92 = val_90;
            val_92 = val_92 + 5;
            val_93 = val_93 + val_92;
            val_95 = val_93 + 296;
            label_108:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "RIPEMD160WITHRSAENCRYPTION", value:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160);
            var val_97 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_113;
            }
            
            var val_94 = mem[val_1] + 176;
            var val_95 = 0;
            val_94 = val_94 + 8;
            label_112:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_111;
            }
            
            val_95 = val_95 + 1;
            val_94 = val_94 + 16;
            if(val_95 < (mem[val_1] + 286))
            {
                goto label_112;
            }
            
            goto label_113;
            label_111:
            var val_96 = val_94;
            val_96 = val_96 + 5;
            val_97 = val_97 + val_96;
            val_96 = val_97 + 296;
            label_113:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "RIPEMD160WITHRSA", value:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160);
            var val_101 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_118;
            }
            
            var val_98 = mem[val_1] + 176;
            var val_99 = 0;
            val_98 = val_98 + 8;
            label_117:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_116;
            }
            
            val_99 = val_99 + 1;
            val_98 = val_98 + 16;
            if(val_99 < (mem[val_1] + 286))
            {
                goto label_117;
            }
            
            goto label_118;
            label_116:
            var val_100 = val_98;
            val_100 = val_100 + 5;
            val_101 = val_101 + val_100;
            val_97 = val_101 + 296;
            label_118:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "RIPEMD128WITHRSAENCRYPTION", value:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128);
            var val_105 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_123;
            }
            
            var val_102 = mem[val_1] + 176;
            var val_103 = 0;
            val_102 = val_102 + 8;
            label_122:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_121;
            }
            
            val_103 = val_103 + 1;
            val_102 = val_102 + 16;
            if(val_103 < (mem[val_1] + 286))
            {
                goto label_122;
            }
            
            goto label_123;
            label_121:
            var val_104 = val_102;
            val_104 = val_104 + 5;
            val_105 = val_105 + val_104;
            val_98 = val_105 + 296;
            label_123:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "RIPEMD128WITHRSA", value:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128);
            var val_109 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_128;
            }
            
            var val_106 = mem[val_1] + 176;
            var val_107 = 0;
            val_106 = val_106 + 8;
            label_127:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_126;
            }
            
            val_107 = val_107 + 1;
            val_106 = val_106 + 16;
            if(val_107 < (mem[val_1] + 286))
            {
                goto label_127;
            }
            
            goto label_128;
            label_126:
            var val_108 = val_106;
            val_108 = val_108 + 5;
            val_109 = val_109 + val_108;
            val_99 = val_109 + 296;
            label_128:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "RIPEMD256WITHRSAENCRYPTION", value:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256);
            var val_113 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_133;
            }
            
            var val_110 = mem[val_1] + 176;
            var val_111 = 0;
            val_110 = val_110 + 8;
            label_132:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_131;
            }
            
            val_111 = val_111 + 1;
            val_110 = val_110 + 16;
            if(val_111 < (mem[val_1] + 286))
            {
                goto label_132;
            }
            
            goto label_133;
            label_131:
            var val_112 = val_110;
            val_112 = val_112 + 5;
            val_113 = val_113 + val_112;
            val_100 = val_113 + 296;
            label_133:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "RIPEMD256WITHRSA", value:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256);
            val_101 = null;
            val_101 = null;
            var val_117 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_140;
            }
            
            var val_114 = mem[val_1] + 176;
            var val_115 = 0;
            val_114 = val_114 + 8;
            label_139:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_138;
            }
            
            val_115 = val_115 + 1;
            val_114 = val_114 + 16;
            if(val_115 < (mem[val_1] + 286))
            {
                goto label_139;
            }
            
            goto label_140;
            label_138:
            var val_116 = val_114;
            val_116 = val_116 + 5;
            val_117 = val_117 + val_116;
            val_102 = val_117 + 296;
            label_140:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA1WITHDSA", value:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
            var val_121 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_145;
            }
            
            var val_118 = mem[val_1] + 176;
            var val_119 = 0;
            val_118 = val_118 + 8;
            label_144:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_143;
            }
            
            val_119 = val_119 + 1;
            val_118 = val_118 + 16;
            if(val_119 < (mem[val_1] + 286))
            {
                goto label_144;
            }
            
            goto label_145;
            label_143:
            var val_120 = val_118;
            val_120 = val_120 + 5;
            val_121 = val_121 + val_120;
            val_103 = val_121 + 296;
            label_145:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "DSAWITHSHA1", value:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
            val_104 = null;
            val_104 = null;
            var val_125 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_152;
            }
            
            var val_122 = mem[val_1] + 176;
            var val_123 = 0;
            val_122 = val_122 + 8;
            label_151:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_150;
            }
            
            val_123 = val_123 + 1;
            val_122 = val_122 + 16;
            if(val_123 < (mem[val_1] + 286))
            {
                goto label_151;
            }
            
            goto label_152;
            label_150:
            var val_124 = val_122;
            val_124 = val_124 + 5;
            val_125 = val_125 + val_124;
            val_105 = val_125 + 296;
            label_152:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA224WITHDSA", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224);
            var val_129 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_157;
            }
            
            var val_126 = mem[val_1] + 176;
            var val_127 = 0;
            val_126 = val_126 + 8;
            label_156:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_155;
            }
            
            val_127 = val_127 + 1;
            val_126 = val_126 + 16;
            if(val_127 < (mem[val_1] + 286))
            {
                goto label_156;
            }
            
            goto label_157;
            label_155:
            var val_128 = val_126;
            val_128 = val_128 + 5;
            val_129 = val_129 + val_128;
            val_106 = val_129 + 296;
            label_157:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA256WITHDSA", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256);
            var val_133 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_162;
            }
            
            var val_130 = mem[val_1] + 176;
            var val_131 = 0;
            val_130 = val_130 + 8;
            label_161:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_160;
            }
            
            val_131 = val_131 + 1;
            val_130 = val_130 + 16;
            if(val_131 < (mem[val_1] + 286))
            {
                goto label_161;
            }
            
            goto label_162;
            label_160:
            var val_132 = val_130;
            val_132 = val_132 + 5;
            val_133 = val_133 + val_132;
            val_107 = val_133 + 296;
            label_162:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA384WITHDSA", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384);
            var val_137 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_167;
            }
            
            var val_134 = mem[val_1] + 176;
            var val_135 = 0;
            val_134 = val_134 + 8;
            label_166:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_165;
            }
            
            val_135 = val_135 + 1;
            val_134 = val_134 + 16;
            if(val_135 < (mem[val_1] + 286))
            {
                goto label_166;
            }
            
            goto label_167;
            label_165:
            var val_136 = val_134;
            val_136 = val_136 + 5;
            val_137 = val_137 + val_136;
            val_108 = val_137 + 296;
            label_167:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA512WITHDSA", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512);
            var val_141 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_172;
            }
            
            var val_138 = mem[val_1] + 176;
            var val_139 = 0;
            val_138 = val_138 + 8;
            label_171:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_170;
            }
            
            val_139 = val_139 + 1;
            val_138 = val_138 + 16;
            if(val_139 < (mem[val_1] + 286))
            {
                goto label_171;
            }
            
            goto label_172;
            label_170:
            var val_140 = val_138;
            val_140 = val_140 + 5;
            val_141 = val_141 + val_140;
            val_109 = val_141 + 296;
            label_172:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA1WITHECDSA", value:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
            var val_145 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_177;
            }
            
            var val_142 = mem[val_1] + 176;
            var val_143 = 0;
            val_142 = val_142 + 8;
            label_176:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_175;
            }
            
            val_143 = val_143 + 1;
            val_142 = val_142 + 16;
            if(val_143 < (mem[val_1] + 286))
            {
                goto label_176;
            }
            
            goto label_177;
            label_175:
            var val_144 = val_142;
            val_144 = val_144 + 5;
            val_145 = val_145 + val_144;
            val_110 = val_145 + 296;
            label_177:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "ECDSAWITHSHA1", value:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
            var val_149 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_182;
            }
            
            var val_146 = mem[val_1] + 176;
            var val_147 = 0;
            val_146 = val_146 + 8;
            label_181:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_180;
            }
            
            val_147 = val_147 + 1;
            val_146 = val_146 + 16;
            if(val_147 < (mem[val_1] + 286))
            {
                goto label_181;
            }
            
            goto label_182;
            label_180:
            var val_148 = val_146;
            val_148 = val_148 + 5;
            val_149 = val_149 + val_148;
            val_111 = val_149 + 296;
            label_182:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA224WITHECDSA", value:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224);
            var val_153 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_187;
            }
            
            var val_150 = mem[val_1] + 176;
            var val_151 = 0;
            val_150 = val_150 + 8;
            label_186:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_185;
            }
            
            val_151 = val_151 + 1;
            val_150 = val_150 + 16;
            if(val_151 < (mem[val_1] + 286))
            {
                goto label_186;
            }
            
            goto label_187;
            label_185:
            var val_152 = val_150;
            val_152 = val_152 + 5;
            val_153 = val_153 + val_152;
            val_112 = val_153 + 296;
            label_187:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA256WITHECDSA", value:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256);
            var val_157 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_192;
            }
            
            var val_154 = mem[val_1] + 176;
            var val_155 = 0;
            val_154 = val_154 + 8;
            label_191:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_190;
            }
            
            val_155 = val_155 + 1;
            val_154 = val_154 + 16;
            if(val_155 < (mem[val_1] + 286))
            {
                goto label_191;
            }
            
            goto label_192;
            label_190:
            var val_156 = val_154;
            val_156 = val_156 + 5;
            val_157 = val_157 + val_156;
            val_113 = val_157 + 296;
            label_192:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA384WITHECDSA", value:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384);
            var val_161 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_197;
            }
            
            var val_158 = mem[val_1] + 176;
            var val_159 = 0;
            val_158 = val_158 + 8;
            label_196:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_195;
            }
            
            val_159 = val_159 + 1;
            val_158 = val_158 + 16;
            if(val_159 < (mem[val_1] + 286))
            {
                goto label_196;
            }
            
            goto label_197;
            label_195:
            var val_160 = val_158;
            val_160 = val_160 + 5;
            val_161 = val_161 + val_160;
            val_114 = val_161 + 296;
            label_197:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "SHA512WITHECDSA", value:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512);
            val_115 = null;
            val_115 = null;
            var val_165 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_204;
            }
            
            var val_162 = mem[val_1] + 176;
            var val_163 = 0;
            val_162 = val_162 + 8;
            label_203:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_202;
            }
            
            val_163 = val_163 + 1;
            val_162 = val_162 + 16;
            if(val_163 < (mem[val_1] + 286))
            {
                goto label_203;
            }
            
            goto label_204;
            label_202:
            var val_164 = val_162;
            val_164 = val_164 + 5;
            val_165 = val_165 + val_164;
            val_116 = val_165 + 296;
            label_204:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "GOST3411WITHGOST3410", value:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
            var val_169 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_209;
            }
            
            var val_166 = mem[val_1] + 176;
            var val_167 = 0;
            val_166 = val_166 + 8;
            label_208:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_207;
            }
            
            val_167 = val_167 + 1;
            val_166 = val_166 + 16;
            if(val_167 < (mem[val_1] + 286))
            {
                goto label_208;
            }
            
            goto label_209;
            label_207:
            var val_168 = val_166;
            val_168 = val_168 + 5;
            val_169 = val_169 + val_168;
            val_117 = val_169 + 296;
            label_209:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "GOST3411WITHGOST3410-94", value:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
            var val_173 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_214;
            }
            
            var val_170 = mem[val_1] + 176;
            var val_171 = 0;
            val_170 = val_170 + 8;
            label_213:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_212;
            }
            
            val_171 = val_171 + 1;
            val_170 = val_170 + 16;
            if(val_171 < (mem[val_1] + 286))
            {
                goto label_213;
            }
            
            goto label_214;
            label_212:
            var val_172 = val_170;
            val_172 = val_172 + 5;
            val_173 = val_173 + val_172;
            val_118 = val_173 + 296;
            label_214:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "GOST3411WITHECGOST3410", value:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
            var val_177 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_219;
            }
            
            var val_174 = mem[val_1] + 176;
            var val_175 = 0;
            val_174 = val_174 + 8;
            label_218:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_217;
            }
            
            val_175 = val_175 + 1;
            val_174 = val_174 + 16;
            if(val_175 < (mem[val_1] + 286))
            {
                goto label_218;
            }
            
            goto label_219;
            label_217:
            var val_176 = val_174;
            val_176 = val_176 + 5;
            val_177 = val_177 + val_176;
            val_119 = val_177 + 296;
            label_219:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "GOST3411WITHECGOST3410-2001", value:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
            var val_181 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_224;
            }
            
            var val_178 = mem[val_1] + 176;
            var val_179 = 0;
            val_178 = val_178 + 8;
            label_223:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_222;
            }
            
            val_179 = val_179 + 1;
            val_178 = val_178 + 16;
            if(val_179 < (mem[val_1] + 286))
            {
                goto label_223;
            }
            
            goto label_224;
            label_222:
            var val_180 = val_178;
            val_180 = val_180 + 5;
            val_181 = val_181 + val_180;
            val_120 = val_181 + 296;
            label_224:
            val_121 = Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001;
            Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Add(key:  "GOST3411WITHGOST3410-2001", value:  val_121);
            Org.BouncyCastle.Utilities.Collections.HashSet val_183 = val_3;
            if(Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdPublicKeyType == null)
            {
                goto label_226;
            }
            
            var val_182 = 0;
            val_178 = val_178 + 8;
            if((((mem[val_1] + 176 + 8) + 8) + -8) == null)
            {
                goto label_227;
            }
            
            val_182 = val_182 + 1;
            val_178 = val_178 + 16;
            label_226:
            val_121 = 0;
            goto label_229;
            label_227:
            val_183 = val_183 + ((((mem[val_1] + 176 + 8) + 8)) << 4);
            val_122 = val_183 + 296;
            label_229:
            val_123 = public System.Void Org.BouncyCastle.Utilities.Collections.ISet::Add(object o);
            val_3.Add(o:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
            Org.BouncyCastle.Utilities.Collections.HashSet val_185 = val_3;
            if(Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdPublicKeyType == null)
            {
                goto label_231;
            }
            
            var val_184 = 0;
            val_178 = val_178 + 8;
            if(((((mem[val_1] + 176 + 8) + 8) + 8) + -8) == null)
            {
                goto label_232;
            }
            
            val_184 = val_184 + 1;
            val_178 = val_178 + 16;
            label_231:
            val_123 = 0;
            goto label_234;
            label_232:
            val_185 = val_185 + (((((mem[val_1] + 176 + 8) + 8) + 8)) << 4);
            val_124 = val_185 + 296;
            label_234:
            val_125 = public System.Void Org.BouncyCastle.Utilities.Collections.ISet::Add(object o);
            val_3.Add(o:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224);
            Org.BouncyCastle.Utilities.Collections.HashSet val_187 = val_3;
            if(Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdPublicKeyType == null)
            {
                goto label_236;
            }
            
            var val_186 = 0;
            val_178 = val_178 + 8;
            if((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + -8) == null)
            {
                goto label_237;
            }
            
            val_186 = val_186 + 1;
            val_178 = val_178 + 16;
            label_236:
            val_125 = 0;
            goto label_239;
            label_237:
            val_187 = val_187 + ((((((mem[val_1] + 176 + 8) + 8) + 8) + 8)) << 4);
            val_126 = val_187 + 296;
            label_239:
            val_127 = public System.Void Org.BouncyCastle.Utilities.Collections.ISet::Add(object o);
            val_3.Add(o:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256);
            Org.BouncyCastle.Utilities.Collections.HashSet val_189 = val_3;
            if(Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdPublicKeyType == null)
            {
                goto label_241;
            }
            
            var val_188 = 0;
            val_178 = val_178 + 8;
            if(((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + -8) == null)
            {
                goto label_242;
            }
            
            val_188 = val_188 + 1;
            val_178 = val_178 + 16;
            label_241:
            val_127 = 0;
            goto label_244;
            label_242:
            val_189 = val_189 + (((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8)) << 4);
            val_128 = val_189 + 296;
            label_244:
            val_129 = public System.Void Org.BouncyCastle.Utilities.Collections.ISet::Add(object o);
            val_3.Add(o:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384);
            Org.BouncyCastle.Utilities.Collections.HashSet val_191 = val_3;
            if(Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdPublicKeyType == null)
            {
                goto label_246;
            }
            
            var val_190 = 0;
            val_178 = val_178 + 8;
            if((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8) + -8) == null)
            {
                goto label_247;
            }
            
            val_190 = val_190 + 1;
            val_178 = val_178 + 16;
            label_246:
            val_129 = 0;
            goto label_249;
            label_247:
            val_191 = val_191 + ((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8)) << 4);
            val_130 = val_191 + 296;
            label_249:
            val_131 = public System.Void Org.BouncyCastle.Utilities.Collections.ISet::Add(object o);
            val_3.Add(o:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512);
            Org.BouncyCastle.Utilities.Collections.HashSet val_193 = val_3;
            if(Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdPublicKeyType == null)
            {
                goto label_251;
            }
            
            var val_192 = 0;
            val_178 = val_178 + 8;
            if(((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8) + 8) + -8) == null)
            {
                goto label_252;
            }
            
            val_192 = val_192 + 1;
            val_178 = val_178 + 16;
            label_251:
            val_131 = 0;
            goto label_254;
            label_252:
            val_193 = val_193 + (((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8) + 8)) << 4);
            val_132 = val_193 + 296;
            label_254:
            val_133 = public System.Void Org.BouncyCastle.Utilities.Collections.ISet::Add(object o);
            val_3.Add(o:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
            Org.BouncyCastle.Utilities.Collections.HashSet val_195 = val_3;
            if(Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.NistAlgorithm == null)
            {
                goto label_256;
            }
            
            var val_194 = 0;
            val_178 = val_178 + 8;
            if((((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + -8) == null)
            {
                goto label_257;
            }
            
            val_194 = val_194 + 1;
            val_178 = val_178 + 16;
            label_256:
            val_133 = 0;
            goto label_259;
            label_257:
            val_195 = val_195 + ((((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8)) << 4);
            val_134 = val_195 + 296;
            label_259:
            val_135 = public System.Void Org.BouncyCastle.Utilities.Collections.ISet::Add(object o);
            val_3.Add(o:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224);
            Org.BouncyCastle.Utilities.Collections.HashSet val_197 = val_3;
            if(Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.NistAlgorithm == null)
            {
                goto label_261;
            }
            
            var val_196 = 0;
            val_178 = val_178 + 8;
            if(((((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + -8) == null)
            {
                goto label_262;
            }
            
            val_196 = val_196 + 1;
            val_178 = val_178 + 16;
            label_261:
            val_135 = 0;
            goto label_264;
            label_262:
            val_197 = val_197 + (((((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8)) << 4);
            val_136 = val_197 + 296;
            label_264:
            val_137 = public System.Void Org.BouncyCastle.Utilities.Collections.ISet::Add(object o);
            val_3.Add(o:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256);
            Org.BouncyCastle.Utilities.Collections.HashSet val_199 = val_3;
            if(Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.NistAlgorithm == null)
            {
                goto label_266;
            }
            
            var val_198 = 0;
            val_178 = val_178 + 8;
            if((((((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + -8) == null)
            {
                goto label_267;
            }
            
            val_198 = val_198 + 1;
            val_178 = val_178 + 16;
            label_266:
            val_137 = 0;
            goto label_269;
            label_267:
            val_199 = val_199 + ((((((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8)) << 4);
            val_138 = val_199 + 296;
            label_269:
            val_139 = public System.Void Org.BouncyCastle.Utilities.Collections.ISet::Add(object o);
            val_3.Add(o:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384);
            Org.BouncyCastle.Utilities.Collections.HashSet val_201 = val_3;
            if(Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.NistAlgorithm == null)
            {
                goto label_271;
            }
            
            var val_200 = 0;
            val_178 = val_178 + 8;
            if(((((((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + -8) == null)
            {
                goto label_272;
            }
            
            val_200 = val_200 + 1;
            val_178 = val_178 + 16;
            label_271:
            val_139 = 0;
            goto label_274;
            label_272:
            val_201 = val_201 + (((((((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8)) << 4);
            val_140 = val_201 + 296;
            label_274:
            val_141 = public System.Void Org.BouncyCastle.Utilities.Collections.ISet::Add(object o);
            val_3.Add(o:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512);
            Org.BouncyCastle.Utilities.Collections.HashSet val_203 = val_3;
            if(Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411 == null)
            {
                goto label_276;
            }
            
            var val_202 = 0;
            val_178 = val_178 + 8;
            if((((((((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + -8) == null)
            {
                goto label_277;
            }
            
            val_202 = val_202 + 1;
            val_178 = val_178 + 16;
            label_276:
            val_141 = 0;
            goto label_279;
            label_277:
            val_203 = val_203 + ((((((((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8)) << 4);
            val_142 = val_203 + 296;
            label_279:
            val_143 = public System.Void Org.BouncyCastle.Utilities.Collections.ISet::Add(object o);
            val_3.Add(o:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
            Org.BouncyCastle.Utilities.Collections.HashSet val_205 = val_3;
            if(Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411 == null)
            {
                goto label_281;
            }
            
            var val_204 = 0;
            val_178 = val_178 + 8;
            if(((((((((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + -8) == null)
            {
                goto label_282;
            }
            
            val_204 = val_204 + 1;
            val_178 = val_178 + 16;
            label_281:
            val_143 = 0;
            goto label_284;
            label_282:
            val_205 = val_205 + (((((((((((((((mem[val_1] + 176 + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8) + 8)) << 4);
            val_144 = val_205 + 296;
            label_284:
            val_3.Add(o:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
            val_145 = null;
            val_145 = null;
            var val_209 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_291;
            }
            
            var val_206 = mem[val_2] + 176;
            var val_207 = 0;
            val_206 = val_206 + 8;
            label_290:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_289;
            }
            
            val_207 = val_207 + 1;
            val_206 = val_206 + 16;
            if(val_207 < (mem[val_2] + 286))
            {
                goto label_290;
            }
            
            goto label_291;
            label_289:
            var val_208 = val_206;
            val_208 = val_208 + 5;
            val_209 = val_209 + val_208;
            val_146 = val_209 + 296;
            label_291:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.exParams.Add(key:  "SHA1WITHRSAANDMGF1", value:  Org.BouncyCastle.Crypto.Operators.X509Utilities.CreatePssParams(hashAlgId:  new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(algorithm:  Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1, parameters:  Org.BouncyCastle.Asn1.DerNull.Instance), saltSize:  20));
            var val_213 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_296;
            }
            
            var val_210 = mem[val_2] + 176;
            var val_211 = 0;
            val_210 = val_210 + 8;
            label_295:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_294;
            }
            
            val_211 = val_211 + 1;
            val_210 = val_210 + 16;
            if(val_211 < (mem[val_2] + 286))
            {
                goto label_295;
            }
            
            goto label_296;
            label_294:
            var val_212 = val_210;
            val_212 = val_212 + 5;
            val_213 = val_213 + val_212;
            val_147 = val_213 + 296;
            label_296:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.exParams.Add(key:  "SHA224WITHRSAANDMGF1", value:  Org.BouncyCastle.Crypto.Operators.X509Utilities.CreatePssParams(hashAlgId:  new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(algorithm:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224, parameters:  Org.BouncyCastle.Asn1.DerNull.Instance), saltSize:  28));
            var val_217 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_301;
            }
            
            var val_214 = mem[val_2] + 176;
            var val_215 = 0;
            val_214 = val_214 + 8;
            label_300:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_299;
            }
            
            val_215 = val_215 + 1;
            val_214 = val_214 + 16;
            if(val_215 < (mem[val_2] + 286))
            {
                goto label_300;
            }
            
            goto label_301;
            label_299:
            var val_216 = val_214;
            val_216 = val_216 + 5;
            val_217 = val_217 + val_216;
            val_148 = val_217 + 296;
            label_301:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.exParams.Add(key:  "SHA256WITHRSAANDMGF1", value:  Org.BouncyCastle.Crypto.Operators.X509Utilities.CreatePssParams(hashAlgId:  new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(algorithm:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256, parameters:  Org.BouncyCastle.Asn1.DerNull.Instance), saltSize:  32));
            var val_221 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_306;
            }
            
            var val_218 = mem[val_2] + 176;
            var val_219 = 0;
            val_218 = val_218 + 8;
            label_305:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_304;
            }
            
            val_219 = val_219 + 1;
            val_218 = val_218 + 16;
            if(val_219 < (mem[val_2] + 286))
            {
                goto label_305;
            }
            
            goto label_306;
            label_304:
            var val_220 = val_218;
            val_220 = val_220 + 5;
            val_221 = val_221 + val_220;
            val_149 = val_221 + 296;
            label_306:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.exParams.Add(key:  "SHA384WITHRSAANDMGF1", value:  Org.BouncyCastle.Crypto.Operators.X509Utilities.CreatePssParams(hashAlgId:  new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(algorithm:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384, parameters:  Org.BouncyCastle.Asn1.DerNull.Instance), saltSize:  48));
            var val_225 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_311;
            }
            
            var val_222 = mem[val_2] + 176;
            var val_223 = 0;
            val_222 = val_222 + 8;
            label_310:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_309;
            }
            
            val_223 = val_223 + 1;
            val_222 = val_222 + 16;
            if(val_223 < (mem[val_2] + 286))
            {
                goto label_310;
            }
            
            goto label_311;
            label_309:
            var val_224 = val_222;
            val_224 = val_224 + 5;
            val_225 = val_225 + val_224;
            val_150 = val_225 + 296;
            label_311:
            Org.BouncyCastle.Crypto.Operators.X509Utilities.exParams.Add(key:  "SHA512WITHRSAANDMGF1", value:  Org.BouncyCastle.Crypto.Operators.X509Utilities.CreatePssParams(hashAlgId:  new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(algorithm:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512, parameters:  Org.BouncyCastle.Asn1.DerNull.Instance), saltSize:  64));
        }
        private static string GetDigestAlgName(Org.BouncyCastle.Asn1.DerObjectIdentifier digestAlgOID)
        {
            var val_11;
            var val_12;
            var val_13;
            var val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            val_11 = null;
            val_11 = null;
            if((Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5.Equals(obj:  digestAlgOID)) != false)
            {
                    val_12 = "MD5";
                return (string)val_12;
            }
            
            val_13 = null;
            val_13 = null;
            if((Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1.Equals(obj:  digestAlgOID)) != false)
            {
                    val_12 = "SHA1";
                return (string)val_12;
            }
            
            val_14 = null;
            val_14 = null;
            if((Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224.Equals(obj:  digestAlgOID)) != false)
            {
                    val_12 = "SHA224";
                return (string)val_12;
            }
            
            val_15 = null;
            val_15 = null;
            if((Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256.Equals(obj:  digestAlgOID)) != false)
            {
                    val_12 = "SHA256";
                return (string)val_12;
            }
            
            val_16 = null;
            val_16 = null;
            if((Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384.Equals(obj:  digestAlgOID)) != false)
            {
                    val_12 = "SHA384";
                return (string)val_12;
            }
            
            val_17 = null;
            val_17 = null;
            if((Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512.Equals(obj:  digestAlgOID)) != false)
            {
                    val_12 = "SHA512";
                return (string)val_12;
            }
            
            val_18 = null;
            val_18 = null;
            if((Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128.Equals(obj:  digestAlgOID)) != false)
            {
                    val_12 = "RIPEMD128";
                return (string)val_12;
            }
            
            val_19 = null;
            val_19 = null;
            if((Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160.Equals(obj:  digestAlgOID)) != false)
            {
                    val_12 = "RIPEMD160";
                return (string)val_12;
            }
            
            val_20 = null;
            val_20 = null;
            if((Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256.Equals(obj:  digestAlgOID)) != false)
            {
                    val_12 = "RIPEMD256";
                return (string)val_12;
            }
            
            val_21 = null;
            val_21 = null;
            if((Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411.Equals(obj:  digestAlgOID)) != false)
            {
                    val_12 = "GOST3411";
                return (string)val_12;
            }
            
            if(digestAlgOID != null)
            {
                    return digestAlgOID.Id;
            }
            
            return digestAlgOID.Id;
        }
        internal static string GetSignatureName(Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier sigAlgId)
        {
            object val_12;
            var val_13;
            var val_14;
            var val_15;
            Org.BouncyCastle.Asn1.DerObjectIdentifier val_16;
            if(sigAlgId == null)
            {
                goto label_21;
            }
            
            val_13 = null;
            val_13 = null;
            val_12 = sigAlgId;
            if((Org.BouncyCastle.Crypto.Operators.X509Utilities.derNull.Equals(obj:  val_12)) == false)
            {
                goto label_6;
            }
            
            label_21:
            if(sigAlgId != null)
            {
                    return sigAlgId.Id;
            }
            
            return sigAlgId.Id;
            label_6:
            val_14 = null;
            val_14 = null;
            if((sigAlgId.Equals(obj:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss)) != false)
            {
                    return Org.BouncyCastle.Crypto.Operators.X509Utilities.GetDigestAlgName(digestAlgOID:  Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.GetInstance(obj:  sigAlgId).HashAlgorithm)(Org.BouncyCastle.Crypto.Operators.X509Utilities.GetDigestAlgName(digestAlgOID:  Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters.GetInstance(obj:  sigAlgId).HashAlgorithm)) + "withRSAandMGF1";
            }
            
            val_15 = null;
            val_15 = null;
            if((sigAlgId.Equals(obj:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha2)) == false)
            {
                goto label_21;
            }
            
            val_16 = Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  sigAlgId);
            if(val_16 == null)
            {
                    return (string)Org.BouncyCastle.Crypto.Operators.X509Utilities.GetDigestAlgName(digestAlgOID:  val_16 = 0)(Org.BouncyCastle.Crypto.Operators.X509Utilities.GetDigestAlgName(digestAlgOID:  val_16 = 0)) + "withECDSA";
            }
            
            return (string)Org.BouncyCastle.Crypto.Operators.X509Utilities.GetDigestAlgName(digestAlgOID:  val_16)(Org.BouncyCastle.Crypto.Operators.X509Utilities.GetDigestAlgName(digestAlgOID:  val_16)) + "withECDSA";
        }
        private static Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters CreatePssParams(Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier hashAlgId, int saltSize)
        {
            null = null;
            return (Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters)new Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters(hashAlgorithm:  hashAlgId, maskGenAlgorithm:  new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(algorithm:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, parameters:  hashAlgId), saltLength:  new Org.BouncyCastle.Asn1.DerInteger(value:  saltSize), trailerField:  new Org.BouncyCastle.Asn1.DerInteger(value:  1));
        }
        internal static Org.BouncyCastle.Asn1.DerObjectIdentifier GetAlgorithmOid(string algorithmName)
        {
            var val_7;
            var val_9;
            var val_10;
            var val_12;
            string val_1 = Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  algorithmName);
            val_7 = null;
            val_7 = null;
            var val_9 = 0;
            val_9 = val_9 + 1;
            val_9 = public System.Boolean System.Collections.IDictionary::Contains(object key);
            if((Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Contains(key:  val_1)) != false)
            {
                    val_10 = null;
                val_10 = null;
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_9 = 0;
            }
            else
            {
                    Org.BouncyCastle.Asn1.DerObjectIdentifier val_4 = null;
                val_12 = val_4;
                val_4 = new Org.BouncyCastle.Asn1.DerObjectIdentifier(identifier:  val_1);
                return (Org.BouncyCastle.Asn1.DerObjectIdentifier)val_12;
            }
            
            val_12 = Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Item[val_1];
            if(val_12 == null)
            {
                    return (Org.BouncyCastle.Asn1.DerObjectIdentifier)val_12;
            }
            
            val_12 = 0;
            return (Org.BouncyCastle.Asn1.DerObjectIdentifier)val_12;
        }
        internal static Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier GetSigAlgID(Org.BouncyCastle.Asn1.DerObjectIdentifier sigOid, string algorithmName)
        {
            var val_9;
            Org.BouncyCastle.Utilities.Collections.ISet val_10;
            var val_12;
            Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier val_13;
            var val_14;
            var val_16;
            var val_17;
            var val_19;
            val_9 = null;
            val_9 = null;
            val_10 = Org.BouncyCastle.Crypto.Operators.X509Utilities.noParams;
            var val_12 = 0;
            val_12 = val_12 + 1;
            val_12 = public System.Boolean Org.BouncyCastle.Utilities.Collections.ISet::Contains(object o);
            if((val_10.Contains(o:  sigOid)) != false)
            {
                    Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier val_3 = null;
                val_13 = val_3;
                val_3 = new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(algorithm:  sigOid);
                return val_13;
            }
            
            string val_4 = Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  algorithmName);
            val_14 = null;
            val_14 = null;
            var val_13 = 0;
            val_13 = val_13 + 1;
            val_12 = 4;
            val_16 = public System.Boolean System.Collections.IDictionary::Contains(object key);
            if((Org.BouncyCastle.Crypto.Operators.X509Utilities.exParams.Contains(key:  val_4)) == false)
            {
                goto label_19;
            }
            
            val_17 = null;
            val_17 = null;
            var val_14 = 0;
            val_14 = val_14 + 1;
            val_16 = 0;
            goto label_26;
            label_19:
            val_19 = null;
            val_19 = null;
            val_10 = Org.BouncyCastle.Asn1.DerNull.Instance;
            val_13 = new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier();
            goto label_32;
            label_26:
            val_10 = Org.BouncyCastle.Crypto.Operators.X509Utilities.exParams.Item[val_4];
            val_13 = new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier();
            if(val_10 != null)
            {
                    val_10 = 0;
            }
            
            label_32:
            val_13 = new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(algorithm:  sigOid, parameters:  val_10);
            return val_13;
        }
        internal static System.Collections.IEnumerable GetAlgNames()
        {
            var val_3 = null;
            var val_4 = 0;
            val_4 = val_4 + 1;
            return (System.Collections.IEnumerable)new Org.BouncyCastle.Utilities.Collections.EnumerableProxy(inner:  Org.BouncyCastle.Crypto.Operators.X509Utilities.algorithms.Keys);
        }
        public X509Utilities()
        {
        
        }
    
    }

}
