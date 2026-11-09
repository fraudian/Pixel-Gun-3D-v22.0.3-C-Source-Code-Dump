using UnityEngine;

namespace Org.BouncyCastle.Security
{
    public sealed class DigestUtilities
    {
        // Fields
        private static readonly System.Collections.IDictionary algorithms;
        private static readonly System.Collections.IDictionary oids;
        
        // Properties
        public static System.Collections.ICollection Algorithms { get; }
        
        // Methods
        private DigestUtilities()
        {
        
        }
        private static DigestUtilities()
        {
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
            var val_121;
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
            Org.BouncyCastle.Security.DigestUtilities.algorithms = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Security.DigestUtilities.oids = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  Org.BouncyCastle.Utilities.Enums.GetArbitraryValue(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())));
            if(mem[val_4] != 0)
            {
                    string val_5 = mem[val_4].ToString();
            }
            else
            {
                    string val_6 = mem[val_4].ToString();
            }
            
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_79 = null;
            val_79 = null;
            var val_31 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_16;
            }
            
            var val_28 = mem[val_1] + 176;
            var val_29 = 0;
            val_28 = val_28 + 8;
            label_15:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_14;
            }
            
            val_29 = val_29 + 1;
            val_28 = val_28 + 16;
            if(val_29 < (mem[val_1] + 286))
            {
                goto label_15;
            }
            
            goto label_16;
            label_14:
            var val_30 = val_28;
            val_30 = val_30 + 1;
            val_31 = val_31 + val_30;
            val_80 = val_31 + 296;
            label_16:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2.Id, value:  "MD2");
            var val_35 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_22;
            }
            
            var val_32 = mem[val_1] + 176;
            var val_33 = 0;
            val_32 = val_32 + 8;
            label_21:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_20;
            }
            
            val_33 = val_33 + 1;
            val_32 = val_32 + 16;
            if(val_33 < (mem[val_1] + 286))
            {
                goto label_21;
            }
            
            goto label_22;
            label_20:
            var val_34 = val_32;
            val_34 = val_34 + 1;
            val_35 = val_35 + val_34;
            val_81 = val_35 + 296;
            label_22:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4.Id, value:  "MD4");
            var val_39 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_28;
            }
            
            var val_36 = mem[val_1] + 176;
            var val_37 = 0;
            val_36 = val_36 + 8;
            label_27:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_26;
            }
            
            val_37 = val_37 + 1;
            val_36 = val_36 + 16;
            if(val_37 < (mem[val_1] + 286))
            {
                goto label_27;
            }
            
            goto label_28;
            label_26:
            var val_38 = val_36;
            val_38 = val_38 + 1;
            val_39 = val_39 + val_38;
            val_82 = val_39 + 296;
            label_28:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5.Id, value:  "MD5");
            var val_43 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_33;
            }
            
            var val_40 = mem[val_1] + 176;
            var val_41 = 0;
            val_40 = val_40 + 8;
            label_32:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_31;
            }
            
            val_41 = val_41 + 1;
            val_40 = val_40 + 16;
            if(val_41 < (mem[val_1] + 286))
            {
                goto label_32;
            }
            
            goto label_33;
            label_31:
            var val_42 = val_40;
            val_42 = val_42 + 1;
            val_43 = val_43 + val_42;
            val_83 = val_43 + 296;
            label_33:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  "SHA1", value:  "SHA-1");
            val_84 = null;
            val_84 = null;
            var val_47 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_41;
            }
            
            var val_44 = mem[val_1] + 176;
            var val_45 = 0;
            val_44 = val_44 + 8;
            label_40:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_39;
            }
            
            val_45 = val_45 + 1;
            val_44 = val_44 + 16;
            if(val_45 < (mem[val_1] + 286))
            {
                goto label_40;
            }
            
            goto label_41;
            label_39:
            var val_46 = val_44;
            val_46 = val_46 + 1;
            val_47 = val_47 + val_46;
            val_85 = val_47 + 296;
            label_41:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1.Id, value:  "SHA-1");
            var val_51 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_46;
            }
            
            var val_48 = mem[val_1] + 176;
            var val_49 = 0;
            val_48 = val_48 + 8;
            label_45:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_44;
            }
            
            val_49 = val_49 + 1;
            val_48 = val_48 + 16;
            if(val_49 < (mem[val_1] + 286))
            {
                goto label_45;
            }
            
            goto label_46;
            label_44:
            var val_50 = val_48;
            val_50 = val_50 + 1;
            val_51 = val_51 + val_50;
            val_86 = val_51 + 296;
            label_46:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  "SHA224", value:  "SHA-224");
            val_87 = null;
            val_87 = null;
            var val_55 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_54;
            }
            
            var val_52 = mem[val_1] + 176;
            var val_53 = 0;
            val_52 = val_52 + 8;
            label_53:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_52;
            }
            
            val_53 = val_53 + 1;
            val_52 = val_52 + 16;
            if(val_53 < (mem[val_1] + 286))
            {
                goto label_53;
            }
            
            goto label_54;
            label_52:
            var val_54 = val_52;
            val_54 = val_54 + 1;
            val_55 = val_55 + val_54;
            val_88 = val_55 + 296;
            label_54:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224.Id, value:  "SHA-224");
            var val_59 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_59;
            }
            
            var val_56 = mem[val_1] + 176;
            var val_57 = 0;
            val_56 = val_56 + 8;
            label_58:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_57;
            }
            
            val_57 = val_57 + 1;
            val_56 = val_56 + 16;
            if(val_57 < (mem[val_1] + 286))
            {
                goto label_58;
            }
            
            goto label_59;
            label_57:
            var val_58 = val_56;
            val_58 = val_58 + 1;
            val_59 = val_59 + val_58;
            val_89 = val_59 + 296;
            label_59:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  "SHA256", value:  "SHA-256");
            var val_63 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_65;
            }
            
            var val_60 = mem[val_1] + 176;
            var val_61 = 0;
            val_60 = val_60 + 8;
            label_64:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_63;
            }
            
            val_61 = val_61 + 1;
            val_60 = val_60 + 16;
            if(val_61 < (mem[val_1] + 286))
            {
                goto label_64;
            }
            
            goto label_65;
            label_63:
            var val_62 = val_60;
            val_62 = val_62 + 1;
            val_63 = val_63 + val_62;
            val_90 = val_63 + 296;
            label_65:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256.Id, value:  "SHA-256");
            var val_67 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_70;
            }
            
            var val_64 = mem[val_1] + 176;
            var val_65 = 0;
            val_64 = val_64 + 8;
            label_69:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_68;
            }
            
            val_65 = val_65 + 1;
            val_64 = val_64 + 16;
            if(val_65 < (mem[val_1] + 286))
            {
                goto label_69;
            }
            
            goto label_70;
            label_68:
            var val_66 = val_64;
            val_66 = val_66 + 1;
            val_67 = val_67 + val_66;
            val_91 = val_67 + 296;
            label_70:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  "SHA384", value:  "SHA-384");
            var val_71 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_76;
            }
            
            var val_68 = mem[val_1] + 176;
            var val_69 = 0;
            val_68 = val_68 + 8;
            label_75:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_74;
            }
            
            val_69 = val_69 + 1;
            val_68 = val_68 + 16;
            if(val_69 < (mem[val_1] + 286))
            {
                goto label_75;
            }
            
            goto label_76;
            label_74:
            var val_70 = val_68;
            val_70 = val_70 + 1;
            val_71 = val_71 + val_70;
            val_92 = val_71 + 296;
            label_76:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384.Id, value:  "SHA-384");
            var val_75 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_81;
            }
            
            var val_72 = mem[val_1] + 176;
            var val_73 = 0;
            val_72 = val_72 + 8;
            label_80:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_79;
            }
            
            val_73 = val_73 + 1;
            val_72 = val_72 + 16;
            if(val_73 < (mem[val_1] + 286))
            {
                goto label_80;
            }
            
            goto label_81;
            label_79:
            var val_74 = val_72;
            val_74 = val_74 + 1;
            val_75 = val_75 + val_74;
            val_93 = val_75 + 296;
            label_81:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  "SHA512", value:  "SHA-512");
            var val_79 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_87;
            }
            
            var val_76 = mem[val_1] + 176;
            var val_77 = 0;
            val_76 = val_76 + 8;
            label_86:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_85;
            }
            
            val_77 = val_77 + 1;
            val_76 = val_76 + 16;
            if(val_77 < (mem[val_1] + 286))
            {
                goto label_86;
            }
            
            goto label_87;
            label_85:
            var val_78 = val_76;
            val_78 = val_78 + 1;
            val_79 = val_79 + val_78;
            val_94 = val_79 + 296;
            label_87:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512.Id, value:  "SHA-512");
            var val_83 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_92;
            }
            
            var val_80 = mem[val_1] + 176;
            var val_81 = 0;
            val_80 = val_80 + 8;
            label_91:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_90;
            }
            
            val_81 = val_81 + 1;
            val_80 = val_80 + 16;
            if(val_81 < (mem[val_1] + 286))
            {
                goto label_91;
            }
            
            goto label_92;
            label_90:
            var val_82 = val_80;
            val_82 = val_82 + 1;
            val_83 = val_83 + val_82;
            val_95 = val_83 + 296;
            label_92:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  "SHA512/224", value:  "SHA-512/224");
            var val_87 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_98;
            }
            
            var val_84 = mem[val_1] + 176;
            var val_85 = 0;
            val_84 = val_84 + 8;
            label_97:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_96;
            }
            
            val_85 = val_85 + 1;
            val_84 = val_84 + 16;
            if(val_85 < (mem[val_1] + 286))
            {
                goto label_97;
            }
            
            goto label_98;
            label_96:
            var val_86 = val_84;
            val_86 = val_86 + 1;
            val_87 = val_87 + val_86;
            val_96 = val_87 + 296;
            label_98:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_224.Id, value:  "SHA-512/224");
            var val_91 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_103;
            }
            
            var val_88 = mem[val_1] + 176;
            var val_89 = 0;
            val_88 = val_88 + 8;
            label_102:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_101;
            }
            
            val_89 = val_89 + 1;
            val_88 = val_88 + 16;
            if(val_89 < (mem[val_1] + 286))
            {
                goto label_102;
            }
            
            goto label_103;
            label_101:
            var val_90 = val_88;
            val_90 = val_90 + 1;
            val_91 = val_91 + val_90;
            val_97 = val_91 + 296;
            label_103:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  "SHA512/256", value:  "SHA-512/256");
            var val_95 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_109;
            }
            
            var val_92 = mem[val_1] + 176;
            var val_93 = 0;
            val_92 = val_92 + 8;
            label_108:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_107;
            }
            
            val_93 = val_93 + 1;
            val_92 = val_92 + 16;
            if(val_93 < (mem[val_1] + 286))
            {
                goto label_108;
            }
            
            goto label_109;
            label_107:
            var val_94 = val_92;
            val_94 = val_94 + 1;
            val_95 = val_95 + val_94;
            val_98 = val_95 + 296;
            label_109:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_256.Id, value:  "SHA-512/256");
            var val_99 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_114;
            }
            
            var val_96 = mem[val_1] + 176;
            var val_97 = 0;
            val_96 = val_96 + 8;
            label_113:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_112;
            }
            
            val_97 = val_97 + 1;
            val_96 = val_96 + 16;
            if(val_97 < (mem[val_1] + 286))
            {
                goto label_113;
            }
            
            goto label_114;
            label_112:
            var val_98 = val_96;
            val_98 = val_98 + 1;
            val_99 = val_99 + val_98;
            val_99 = val_99 + 296;
            label_114:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  "RIPEMD-128", value:  "RIPEMD128");
            val_100 = null;
            val_100 = null;
            var val_103 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_122;
            }
            
            var val_100 = mem[val_1] + 176;
            var val_101 = 0;
            val_100 = val_100 + 8;
            label_121:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_120;
            }
            
            val_101 = val_101 + 1;
            val_100 = val_100 + 16;
            if(val_101 < (mem[val_1] + 286))
            {
                goto label_121;
            }
            
            goto label_122;
            label_120:
            var val_102 = val_100;
            val_102 = val_102 + 1;
            val_103 = val_103 + val_102;
            val_101 = val_103 + 296;
            label_122:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128.Id, value:  "RIPEMD128");
            var val_107 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_127;
            }
            
            var val_104 = mem[val_1] + 176;
            var val_105 = 0;
            val_104 = val_104 + 8;
            label_126:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_125;
            }
            
            val_105 = val_105 + 1;
            val_104 = val_104 + 16;
            if(val_105 < (mem[val_1] + 286))
            {
                goto label_126;
            }
            
            goto label_127;
            label_125:
            var val_106 = val_104;
            val_106 = val_106 + 1;
            val_107 = val_107 + val_106;
            val_102 = val_107 + 296;
            label_127:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  "RIPEMD-160", value:  "RIPEMD160");
            var val_111 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_133;
            }
            
            var val_108 = mem[val_1] + 176;
            var val_109 = 0;
            val_108 = val_108 + 8;
            label_132:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_131;
            }
            
            val_109 = val_109 + 1;
            val_108 = val_108 + 16;
            if(val_109 < (mem[val_1] + 286))
            {
                goto label_132;
            }
            
            goto label_133;
            label_131:
            var val_110 = val_108;
            val_110 = val_110 + 1;
            val_111 = val_111 + val_110;
            val_103 = val_111 + 296;
            label_133:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160.Id, value:  "RIPEMD160");
            var val_115 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_138;
            }
            
            var val_112 = mem[val_1] + 176;
            var val_113 = 0;
            val_112 = val_112 + 8;
            label_137:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_136;
            }
            
            val_113 = val_113 + 1;
            val_112 = val_112 + 16;
            if(val_113 < (mem[val_1] + 286))
            {
                goto label_137;
            }
            
            goto label_138;
            label_136:
            var val_114 = val_112;
            val_114 = val_114 + 1;
            val_115 = val_115 + val_114;
            val_104 = val_115 + 296;
            label_138:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  "RIPEMD-256", value:  "RIPEMD256");
            var val_119 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_144;
            }
            
            var val_116 = mem[val_1] + 176;
            var val_117 = 0;
            val_116 = val_116 + 8;
            label_143:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_142;
            }
            
            val_117 = val_117 + 1;
            val_116 = val_116 + 16;
            if(val_117 < (mem[val_1] + 286))
            {
                goto label_143;
            }
            
            goto label_144;
            label_142:
            var val_118 = val_116;
            val_118 = val_118 + 1;
            val_119 = val_119 + val_118;
            val_105 = val_119 + 296;
            label_144:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256.Id, value:  "RIPEMD256");
            var val_123 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_149;
            }
            
            var val_120 = mem[val_1] + 176;
            var val_121 = 0;
            val_120 = val_120 + 8;
            label_148:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_147;
            }
            
            val_121 = val_121 + 1;
            val_120 = val_120 + 16;
            if(val_121 < (mem[val_1] + 286))
            {
                goto label_148;
            }
            
            goto label_149;
            label_147:
            var val_122 = val_120;
            val_122 = val_122 + 1;
            val_123 = val_123 + val_122;
            val_106 = val_123 + 296;
            label_149:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  "RIPEMD-320", value:  "RIPEMD320");
            val_107 = null;
            val_107 = null;
            var val_127 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_157;
            }
            
            var val_124 = mem[val_1] + 176;
            var val_125 = 0;
            val_124 = val_124 + 8;
            label_156:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_155;
            }
            
            val_125 = val_125 + 1;
            val_124 = val_124 + 16;
            if(val_125 < (mem[val_1] + 286))
            {
                goto label_156;
            }
            
            goto label_157;
            label_155:
            var val_126 = val_124;
            val_126 = val_126 + 1;
            val_127 = val_127 + val_126;
            val_108 = val_127 + 296;
            label_157:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411.Id, value:  "GOST3411");
            var val_131 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_163;
            }
            
            var val_128 = mem[val_1] + 176;
            var val_129 = 0;
            val_128 = val_128 + 8;
            label_162:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_161;
            }
            
            val_129 = val_129 + 1;
            val_128 = val_128 + 16;
            if(val_129 < (mem[val_1] + 286))
            {
                goto label_162;
            }
            
            goto label_163;
            label_161:
            var val_130 = val_128;
            val_130 = val_130 + 1;
            val_131 = val_131 + val_130;
            val_109 = val_131 + 296;
            label_163:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_224.Id, value:  "SHA3-224");
            var val_135 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_169;
            }
            
            var val_132 = mem[val_1] + 176;
            var val_133 = 0;
            val_132 = val_132 + 8;
            label_168:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_167;
            }
            
            val_133 = val_133 + 1;
            val_132 = val_132 + 16;
            if(val_133 < (mem[val_1] + 286))
            {
                goto label_168;
            }
            
            goto label_169;
            label_167:
            var val_134 = val_132;
            val_134 = val_134 + 1;
            val_135 = val_135 + val_134;
            val_110 = val_135 + 296;
            label_169:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_256.Id, value:  "SHA3-256");
            var val_139 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_175;
            }
            
            var val_136 = mem[val_1] + 176;
            var val_137 = 0;
            val_136 = val_136 + 8;
            label_174:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_173;
            }
            
            val_137 = val_137 + 1;
            val_136 = val_136 + 16;
            if(val_137 < (mem[val_1] + 286))
            {
                goto label_174;
            }
            
            goto label_175;
            label_173:
            var val_138 = val_136;
            val_138 = val_138 + 1;
            val_139 = val_139 + val_138;
            val_111 = val_139 + 296;
            label_175:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_384.Id, value:  "SHA3-384");
            var val_143 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_181;
            }
            
            var val_140 = mem[val_1] + 176;
            var val_141 = 0;
            val_140 = val_140 + 8;
            label_180:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_179;
            }
            
            val_141 = val_141 + 1;
            val_140 = val_140 + 16;
            if(val_141 < (mem[val_1] + 286))
            {
                goto label_180;
            }
            
            goto label_181;
            label_179:
            var val_142 = val_140;
            val_142 = val_142 + 1;
            val_143 = val_143 + val_142;
            val_112 = val_143 + 296;
            label_181:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_512.Id, value:  "SHA3-512");
            var val_147 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_187;
            }
            
            var val_144 = mem[val_1] + 176;
            var val_145 = 0;
            val_144 = val_144 + 8;
            label_186:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_185;
            }
            
            val_145 = val_145 + 1;
            val_144 = val_144 + 16;
            if(val_145 < (mem[val_1] + 286))
            {
                goto label_186;
            }
            
            goto label_187;
            label_185:
            var val_146 = val_144;
            val_146 = val_146 + 1;
            val_147 = val_147 + val_146;
            val_113 = val_147 + 296;
            label_187:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdShake128.Id, value:  "SHAKE128");
            var val_151 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_193;
            }
            
            var val_148 = mem[val_1] + 176;
            var val_149 = 0;
            val_148 = val_148 + 8;
            label_192:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_191;
            }
            
            val_149 = val_149 + 1;
            val_148 = val_148 + 16;
            if(val_149 < (mem[val_1] + 286))
            {
                goto label_192;
            }
            
            goto label_193;
            label_191:
            var val_150 = val_148;
            val_150 = val_150 + 1;
            val_151 = val_151 + val_150;
            val_114 = val_151 + 296;
            label_193:
            Org.BouncyCastle.Security.DigestUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdShake256.Id, value:  "SHAKE256");
            var val_155 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_198;
            }
            
            var val_152 = mem[val_2] + 176;
            var val_153 = 0;
            val_152 = val_152 + 8;
            label_197:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_196;
            }
            
            val_153 = val_153 + 1;
            val_152 = val_152 + 16;
            if(val_153 < (mem[val_2] + 286))
            {
                goto label_197;
            }
            
            goto label_198;
            label_196:
            var val_154 = val_152;
            val_154 = val_154 + 1;
            val_155 = val_155 + val_154;
            val_115 = val_155 + 296;
            label_198:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "MD2", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2);
            var val_159 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_203;
            }
            
            var val_156 = mem[val_2] + 176;
            var val_157 = 0;
            val_156 = val_156 + 8;
            label_202:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_201;
            }
            
            val_157 = val_157 + 1;
            val_156 = val_156 + 16;
            if(val_157 < (mem[val_2] + 286))
            {
                goto label_202;
            }
            
            goto label_203;
            label_201:
            var val_158 = val_156;
            val_158 = val_158 + 1;
            val_159 = val_159 + val_158;
            val_116 = val_159 + 296;
            label_203:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "MD4", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4);
            var val_163 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_208;
            }
            
            var val_160 = mem[val_2] + 176;
            var val_161 = 0;
            val_160 = val_160 + 8;
            label_207:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_206;
            }
            
            val_161 = val_161 + 1;
            val_160 = val_160 + 16;
            if(val_161 < (mem[val_2] + 286))
            {
                goto label_207;
            }
            
            goto label_208;
            label_206:
            var val_162 = val_160;
            val_162 = val_162 + 1;
            val_163 = val_163 + val_162;
            val_117 = val_163 + 296;
            label_208:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "MD5", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5);
            var val_167 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_213;
            }
            
            var val_164 = mem[val_2] + 176;
            var val_165 = 0;
            val_164 = val_164 + 8;
            label_212:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_211;
            }
            
            val_165 = val_165 + 1;
            val_164 = val_164 + 16;
            if(val_165 < (mem[val_2] + 286))
            {
                goto label_212;
            }
            
            goto label_213;
            label_211:
            var val_166 = val_164;
            val_166 = val_166 + 1;
            val_167 = val_167 + val_166;
            val_118 = val_167 + 296;
            label_213:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "SHA-1", value:  Org.BouncyCastle.Asn1.Oiw.OiwObjectIdentifiers.IdSha1);
            var val_171 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_218;
            }
            
            var val_168 = mem[val_2] + 176;
            var val_169 = 0;
            val_168 = val_168 + 8;
            label_217:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_216;
            }
            
            val_169 = val_169 + 1;
            val_168 = val_168 + 16;
            if(val_169 < (mem[val_2] + 286))
            {
                goto label_217;
            }
            
            goto label_218;
            label_216:
            var val_170 = val_168;
            val_170 = val_170 + 1;
            val_171 = val_171 + val_170;
            val_119 = val_171 + 296;
            label_218:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "SHA-224", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha224);
            var val_175 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_223;
            }
            
            var val_172 = mem[val_2] + 176;
            var val_173 = 0;
            val_172 = val_172 + 8;
            label_222:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_221;
            }
            
            val_173 = val_173 + 1;
            val_172 = val_172 + 16;
            if(val_173 < (mem[val_2] + 286))
            {
                goto label_222;
            }
            
            goto label_223;
            label_221:
            var val_174 = val_172;
            val_174 = val_174 + 1;
            val_175 = val_175 + val_174;
            val_120 = val_175 + 296;
            label_223:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "SHA-256", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha256);
            var val_179 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_228;
            }
            
            var val_176 = mem[val_2] + 176;
            var val_177 = 0;
            val_176 = val_176 + 8;
            label_227:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_226;
            }
            
            val_177 = val_177 + 1;
            val_176 = val_176 + 16;
            if(val_177 < (mem[val_2] + 286))
            {
                goto label_227;
            }
            
            goto label_228;
            label_226:
            var val_178 = val_176;
            val_178 = val_178 + 1;
            val_179 = val_179 + val_178;
            val_121 = val_179 + 296;
            label_228:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "SHA-384", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha384);
            var val_183 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_233;
            }
            
            var val_180 = mem[val_2] + 176;
            var val_181 = 0;
            val_180 = val_180 + 8;
            label_232:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_231;
            }
            
            val_181 = val_181 + 1;
            val_180 = val_180 + 16;
            if(val_181 < (mem[val_2] + 286))
            {
                goto label_232;
            }
            
            goto label_233;
            label_231:
            var val_182 = val_180;
            val_182 = val_182 + 1;
            val_183 = val_183 + val_182;
            val_122 = val_183 + 296;
            label_233:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "SHA-512", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512);
            var val_187 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_238;
            }
            
            var val_184 = mem[val_2] + 176;
            var val_185 = 0;
            val_184 = val_184 + 8;
            label_237:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_236;
            }
            
            val_185 = val_185 + 1;
            val_184 = val_184 + 16;
            if(val_185 < (mem[val_2] + 286))
            {
                goto label_237;
            }
            
            goto label_238;
            label_236:
            var val_186 = val_184;
            val_186 = val_186 + 1;
            val_187 = val_187 + val_186;
            val_123 = val_187 + 296;
            label_238:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "SHA-512/224", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_224);
            var val_191 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_243;
            }
            
            var val_188 = mem[val_2] + 176;
            var val_189 = 0;
            val_188 = val_188 + 8;
            label_242:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_241;
            }
            
            val_189 = val_189 + 1;
            val_188 = val_188 + 16;
            if(val_189 < (mem[val_2] + 286))
            {
                goto label_242;
            }
            
            goto label_243;
            label_241:
            var val_190 = val_188;
            val_190 = val_190 + 1;
            val_191 = val_191 + val_190;
            val_124 = val_191 + 296;
            label_243:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "SHA-512/256", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha512_256);
            var val_195 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_248;
            }
            
            var val_192 = mem[val_2] + 176;
            var val_193 = 0;
            val_192 = val_192 + 8;
            label_247:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_246;
            }
            
            val_193 = val_193 + 1;
            val_192 = val_192 + 16;
            if(val_193 < (mem[val_2] + 286))
            {
                goto label_247;
            }
            
            goto label_248;
            label_246:
            var val_194 = val_192;
            val_194 = val_194 + 1;
            val_195 = val_195 + val_194;
            val_125 = val_195 + 296;
            label_248:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "SHA3-224", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_224);
            var val_199 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_253;
            }
            
            var val_196 = mem[val_2] + 176;
            var val_197 = 0;
            val_196 = val_196 + 8;
            label_252:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_251;
            }
            
            val_197 = val_197 + 1;
            val_196 = val_196 + 16;
            if(val_197 < (mem[val_2] + 286))
            {
                goto label_252;
            }
            
            goto label_253;
            label_251:
            var val_198 = val_196;
            val_198 = val_198 + 1;
            val_199 = val_199 + val_198;
            val_126 = val_199 + 296;
            label_253:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "SHA3-256", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_256);
            var val_203 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_258;
            }
            
            var val_200 = mem[val_2] + 176;
            var val_201 = 0;
            val_200 = val_200 + 8;
            label_257:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_256;
            }
            
            val_201 = val_201 + 1;
            val_200 = val_200 + 16;
            if(val_201 < (mem[val_2] + 286))
            {
                goto label_257;
            }
            
            goto label_258;
            label_256:
            var val_202 = val_200;
            val_202 = val_202 + 1;
            val_203 = val_203 + val_202;
            val_127 = val_203 + 296;
            label_258:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "SHA3-384", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_384);
            var val_207 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_263;
            }
            
            var val_204 = mem[val_2] + 176;
            var val_205 = 0;
            val_204 = val_204 + 8;
            label_262:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_261;
            }
            
            val_205 = val_205 + 1;
            val_204 = val_204 + 16;
            if(val_205 < (mem[val_2] + 286))
            {
                goto label_262;
            }
            
            goto label_263;
            label_261:
            var val_206 = val_204;
            val_206 = val_206 + 1;
            val_207 = val_207 + val_206;
            val_128 = val_207 + 296;
            label_263:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "SHA3-512", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdSha3_512);
            var val_211 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_268;
            }
            
            var val_208 = mem[val_2] + 176;
            var val_209 = 0;
            val_208 = val_208 + 8;
            label_267:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_266;
            }
            
            val_209 = val_209 + 1;
            val_208 = val_208 + 16;
            if(val_209 < (mem[val_2] + 286))
            {
                goto label_267;
            }
            
            goto label_268;
            label_266:
            var val_210 = val_208;
            val_210 = val_210 + 1;
            val_211 = val_211 + val_210;
            val_129 = val_211 + 296;
            label_268:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "SHAKE128", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdShake128);
            var val_215 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_273;
            }
            
            var val_212 = mem[val_2] + 176;
            var val_213 = 0;
            val_212 = val_212 + 8;
            label_272:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_271;
            }
            
            val_213 = val_213 + 1;
            val_212 = val_212 + 16;
            if(val_213 < (mem[val_2] + 286))
            {
                goto label_272;
            }
            
            goto label_273;
            label_271:
            var val_214 = val_212;
            val_214 = val_214 + 1;
            val_215 = val_215 + val_214;
            val_130 = val_215 + 296;
            label_273:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "SHAKE256", value:  Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.IdShake256);
            var val_219 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_278;
            }
            
            var val_216 = mem[val_2] + 176;
            var val_217 = 0;
            val_216 = val_216 + 8;
            label_277:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_276;
            }
            
            val_217 = val_217 + 1;
            val_216 = val_216 + 16;
            if(val_217 < (mem[val_2] + 286))
            {
                goto label_277;
            }
            
            goto label_278;
            label_276:
            var val_218 = val_216;
            val_218 = val_218 + 1;
            val_219 = val_219 + val_218;
            val_131 = val_219 + 296;
            label_278:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "RIPEMD128", value:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD128);
            var val_223 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_283;
            }
            
            var val_220 = mem[val_2] + 176;
            var val_221 = 0;
            val_220 = val_220 + 8;
            label_282:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_281;
            }
            
            val_221 = val_221 + 1;
            val_220 = val_220 + 16;
            if(val_221 < (mem[val_2] + 286))
            {
                goto label_282;
            }
            
            goto label_283;
            label_281:
            var val_222 = val_220;
            val_222 = val_222 + 1;
            val_223 = val_223 + val_222;
            val_132 = val_223 + 296;
            label_283:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "RIPEMD160", value:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD160);
            var val_227 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_288;
            }
            
            var val_224 = mem[val_2] + 176;
            var val_225 = 0;
            val_224 = val_224 + 8;
            label_287:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_286;
            }
            
            val_225 = val_225 + 1;
            val_224 = val_224 + 16;
            if(val_225 < (mem[val_2] + 286))
            {
                goto label_287;
            }
            
            goto label_288;
            label_286:
            var val_226 = val_224;
            val_226 = val_226 + 1;
            val_227 = val_227 + val_226;
            val_133 = val_227 + 296;
            label_288:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "RIPEMD256", value:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RipeMD256);
            var val_231 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_293;
            }
            
            var val_228 = mem[val_2] + 176;
            var val_229 = 0;
            val_228 = val_228 + 8;
            label_292:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_291;
            }
            
            val_229 = val_229 + 1;
            val_228 = val_228 + 16;
            if(val_229 < (mem[val_2] + 286))
            {
                goto label_292;
            }
            
            goto label_293;
            label_291:
            var val_230 = val_228;
            val_230 = val_230 + 1;
            val_231 = val_231 + val_230;
            val_134 = val_231 + 296;
            label_293:
            Org.BouncyCastle.Security.DigestUtilities.oids.set_Item(key:  "GOST3411", value:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411);
        }
        public static Org.BouncyCastle.Asn1.DerObjectIdentifier GetObjectIdentifier(string mechanism)
        {
            var val_8;
            var val_10;
            var val_11;
            var val_12;
            var val_14;
            var val_15;
            if(mechanism != null)
            {
                    string val_1 = Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  mechanism);
                val_8 = null;
                val_8 = null;
                var val_10 = 0;
                val_10 = val_10 + 1;
                val_10 = public System.Object System.Collections.IDictionary::get_Item(object key);
                val_11 = Org.BouncyCastle.Security.DigestUtilities.algorithms;
                if((val_11.Item[val_1] != null) && (null != null))
            {
                    val_10 = 0;
                val_11 = 0;
            }
            
                val_12 = null;
                val_12 = null;
                var val_11 = 0;
                val_11 = val_11 + 1;
                val_10 = 0;
                val_14 = Org.BouncyCastle.Security.DigestUtilities.oids;
                if((val_14.Item[(val_11 == 0) ? (val_1) : (val_11)]) == null)
            {
                    return (Org.BouncyCastle.Asn1.DerObjectIdentifier)val_14;
            }
            
                val_14 = 0;
                return (Org.BouncyCastle.Asn1.DerObjectIdentifier)val_14;
            }
            
            val_15 = new System.ArgumentNullException(paramName:  "mechanism");
        }
        public static System.Collections.ICollection get_Algorithms()
        {
            var val_2 = null;
            var val_2 = 0;
            val_2 = val_2 + 1;
            return Org.BouncyCastle.Security.DigestUtilities.oids.Keys;
        }
        public static Org.BouncyCastle.Crypto.IDigest GetDigest(Org.BouncyCastle.Asn1.DerObjectIdentifier id)
        {
            return Org.BouncyCastle.Security.DigestUtilities.GetDigest(algorithm:  id.Id);
        }
        public static Org.BouncyCastle.Crypto.IDigest GetDigest(string algorithm)
        {
            var val_37;
            var val_39;
            var val_42;
            var val_43;
            string val_1 = Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  algorithm);
            val_37 = null;
            val_37 = null;
            var val_38 = 0;
            val_38 = val_38 + 1;
            val_39 = Org.BouncyCastle.Security.DigestUtilities.algorithms;
            if((val_39.Item[val_1] != null) && (null != null))
            {
                    val_39 = 0;
            }
            
            string val_5 = (val_39 == 0) ? (val_1) : (val_39);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  Org.BouncyCastle.Utilities.Enums.GetEnumValue(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()), s:  val_5));
            if(mem[val_7] <= 27)
            {
                    var val_39 = 106066748 + (mem[val_7]) << 2;
                val_39 = val_39 + 106066748;
            }
            else
            {
                    Org.BouncyCastle.Security.SecurityUtilityException val_37 = null;
                val_43 = val_37;
                val_37 = new Org.BouncyCastle.Security.SecurityUtilityException(message:  "Digest " + val_5 + " not recognised.");
                mem[8] = null;
                val_42 = 8;
            }
        
        }
        public static string GetAlgorithmName(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            var val_4;
            var val_6;
            val_4 = null;
            val_4 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = Org.BouncyCastle.Security.DigestUtilities.algorithms;
            if(val_6.Item[oid.Id] == null)
            {
                    return (string)val_6;
            }
            
            if(null == null)
            {
                    return (string)val_6;
            }
            
            val_6 = 0;
            return (string)val_6;
        }
        public static byte[] CalculateDigest(string algorithm, byte[] input)
        {
            Org.BouncyCastle.Crypto.IDigest val_1 = Org.BouncyCastle.Security.DigestUtilities.GetDigest(algorithm:  algorithm);
            if(input == null)
            {
                goto label_3;
            }
            
            label_10:
            var val_3 = 0;
            val_3 = val_3 + 1;
            goto label_8;
            label_3:
            if(val_1 != null)
            {
                goto label_10;
            }
            
            goto label_10;
            label_8:
            val_1.BlockUpdate(input:  input, inOff:  0, length:  input.Length);
            return Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest:  val_1);
        }
        public static byte[] DoFinal(Org.BouncyCastle.Crypto.IDigest digest)
        {
            var val_6 = 0;
            val_6 = val_6 + 1;
            int val_2 = digest.GetDigestSize();
            byte[] val_3 = new byte[0];
            var val_7 = 0;
            val_7 = val_7 + 1;
            int val_5 = digest.DoFinal(output:  val_3, outOff:  0);
            return (System.Byte[])val_3;
        }
        public static byte[] DoFinal(Org.BouncyCastle.Crypto.IDigest digest, byte[] input)
        {
            if(input == null)
            {
                goto label_1;
            }
            
            label_9:
            var val_2 = 0;
            val_2 = val_2 + 1;
            goto label_6;
            label_1:
            if(digest != null)
            {
                goto label_9;
            }
            
            goto label_9;
            label_6:
            digest.BlockUpdate(input:  input, inOff:  0, length:  input.Length);
            return Org.BouncyCastle.Security.DigestUtilities.DoFinal(digest:  digest);
        }
    
    }

}
