using UnityEngine;

namespace Org.BouncyCastle.Security
{
    public sealed class MacUtilities
    {
        // Fields
        private static readonly System.Collections.IDictionary algorithms;
        
        // Methods
        private MacUtilities()
        {
        
        }
        private static MacUtilities()
        {
            var val_48;
            var val_49;
            var val_50;
            var val_51;
            var val_52;
            var val_53;
            var val_54;
            var val_55;
            var val_56;
            var val_57;
            var val_58;
            var val_59;
            var val_60;
            var val_61;
            var val_62;
            var val_63;
            var val_64;
            var val_65;
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
            Org.BouncyCastle.Security.MacUtilities.algorithms = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            val_48 = null;
            val_48 = null;
            var val_15 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_10;
            }
            
            var val_12 = mem[val_1] + 176;
            var val_13 = 0;
            val_12 = val_12 + 8;
            label_9:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_8;
            }
            
            val_13 = val_13 + 1;
            val_12 = val_12 + 16;
            if(val_13 < (mem[val_1] + 286))
            {
                goto label_9;
            }
            
            goto label_10;
            label_8:
            var val_14 = val_12;
            val_14 = val_14 + 1;
            val_15 = val_15 + val_14;
            val_49 = val_15 + 296;
            label_10:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacMD5.Id, value:  "HMAC-MD5");
            var val_19 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_16;
            }
            
            var val_16 = mem[val_1] + 176;
            var val_17 = 0;
            val_16 = val_16 + 8;
            label_15:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_14;
            }
            
            val_17 = val_17 + 1;
            val_16 = val_16 + 16;
            if(val_17 < (mem[val_1] + 286))
            {
                goto label_15;
            }
            
            goto label_16;
            label_14:
            var val_18 = val_16;
            val_18 = val_18 + 1;
            val_19 = val_19 + val_18;
            val_50 = val_19 + 296;
            label_16:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacRipeMD160.Id, value:  "HMAC-RIPEMD160");
            var val_23 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_22;
            }
            
            var val_20 = mem[val_1] + 176;
            var val_21 = 0;
            val_20 = val_20 + 8;
            label_21:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_20;
            }
            
            val_21 = val_21 + 1;
            val_20 = val_20 + 16;
            if(val_21 < (mem[val_1] + 286))
            {
                goto label_21;
            }
            
            goto label_22;
            label_20:
            var val_22 = val_20;
            val_22 = val_22 + 1;
            val_23 = val_23 + val_22;
            val_51 = val_23 + 296;
            label_22:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacSha1.Id, value:  "HMAC-SHA1");
            var val_27 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_28;
            }
            
            var val_24 = mem[val_1] + 176;
            var val_25 = 0;
            val_24 = val_24 + 8;
            label_27:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_26;
            }
            
            val_25 = val_25 + 1;
            val_24 = val_24 + 16;
            if(val_25 < (mem[val_1] + 286))
            {
                goto label_27;
            }
            
            goto label_28;
            label_26:
            var val_26 = val_24;
            val_26 = val_26 + 1;
            val_27 = val_27 + val_26;
            val_52 = val_27 + 296;
            label_28:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Iana.IanaObjectIdentifiers.HmacTiger.Id, value:  "HMAC-TIGER");
            val_53 = null;
            val_53 = null;
            var val_31 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_36;
            }
            
            var val_28 = mem[val_1] + 176;
            var val_29 = 0;
            val_28 = val_28 + 8;
            label_35:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_34;
            }
            
            val_29 = val_29 + 1;
            val_28 = val_28 + 16;
            if(val_29 < (mem[val_1] + 286))
            {
                goto label_35;
            }
            
            goto label_36;
            label_34:
            var val_30 = val_28;
            val_30 = val_30 + 1;
            val_31 = val_31 + val_30;
            val_54 = val_31 + 296;
            label_36:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha1.Id, value:  "HMAC-SHA1");
            var val_35 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_42;
            }
            
            var val_32 = mem[val_1] + 176;
            var val_33 = 0;
            val_32 = val_32 + 8;
            label_41:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_40;
            }
            
            val_33 = val_33 + 1;
            val_32 = val_32 + 16;
            if(val_33 < (mem[val_1] + 286))
            {
                goto label_41;
            }
            
            goto label_42;
            label_40:
            var val_34 = val_32;
            val_34 = val_34 + 1;
            val_35 = val_35 + val_34;
            val_55 = val_35 + 296;
            label_42:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha224.Id, value:  "HMAC-SHA224");
            var val_39 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_48;
            }
            
            var val_36 = mem[val_1] + 176;
            var val_37 = 0;
            val_36 = val_36 + 8;
            label_47:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_46;
            }
            
            val_37 = val_37 + 1;
            val_36 = val_36 + 16;
            if(val_37 < (mem[val_1] + 286))
            {
                goto label_47;
            }
            
            goto label_48;
            label_46:
            var val_38 = val_36;
            val_38 = val_38 + 1;
            val_39 = val_39 + val_38;
            val_56 = val_39 + 296;
            label_48:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha256.Id, value:  "HMAC-SHA256");
            var val_43 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_54;
            }
            
            var val_40 = mem[val_1] + 176;
            var val_41 = 0;
            val_40 = val_40 + 8;
            label_53:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_52;
            }
            
            val_41 = val_41 + 1;
            val_40 = val_40 + 16;
            if(val_41 < (mem[val_1] + 286))
            {
                goto label_53;
            }
            
            goto label_54;
            label_52:
            var val_42 = val_40;
            val_42 = val_42 + 1;
            val_43 = val_43 + val_42;
            val_57 = val_43 + 296;
            label_54:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha384.Id, value:  "HMAC-SHA384");
            var val_47 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_60;
            }
            
            var val_44 = mem[val_1] + 176;
            var val_45 = 0;
            val_44 = val_44 + 8;
            label_59:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_58;
            }
            
            val_45 = val_45 + 1;
            val_44 = val_44 + 16;
            if(val_45 < (mem[val_1] + 286))
            {
                goto label_59;
            }
            
            goto label_60;
            label_58:
            var val_46 = val_44;
            val_46 = val_46 + 1;
            val_47 = val_47 + val_46;
            val_58 = val_47 + 296;
            label_60:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdHmacWithSha512.Id, value:  "HMAC-SHA512");
            var val_51 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_65;
            }
            
            var val_48 = mem[val_1] + 176;
            var val_49 = 0;
            val_48 = val_48 + 8;
            label_64:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_63;
            }
            
            val_49 = val_49 + 1;
            val_48 = val_48 + 16;
            if(val_49 < (mem[val_1] + 286))
            {
                goto label_64;
            }
            
            goto label_65;
            label_63:
            var val_50 = val_48;
            val_50 = val_50 + 1;
            val_51 = val_51 + val_50;
            val_59 = val_51 + 296;
            label_65:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "DES", value:  "DESMAC");
            var val_55 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_70;
            }
            
            var val_52 = mem[val_1] + 176;
            var val_53 = 0;
            val_52 = val_52 + 8;
            label_69:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_68;
            }
            
            val_53 = val_53 + 1;
            val_52 = val_52 + 16;
            if(val_53 < (mem[val_1] + 286))
            {
                goto label_69;
            }
            
            goto label_70;
            label_68:
            var val_54 = val_52;
            val_54 = val_54 + 1;
            val_55 = val_55 + val_54;
            val_60 = val_55 + 296;
            label_70:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "DES/CFB8", value:  "DESMAC/CFB8");
            var val_59 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_75;
            }
            
            var val_56 = mem[val_1] + 176;
            var val_57 = 0;
            val_56 = val_56 + 8;
            label_74:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_73;
            }
            
            val_57 = val_57 + 1;
            val_56 = val_56 + 16;
            if(val_57 < (mem[val_1] + 286))
            {
                goto label_74;
            }
            
            goto label_75;
            label_73:
            var val_58 = val_56;
            val_58 = val_58 + 1;
            val_59 = val_59 + val_58;
            val_61 = val_59 + 296;
            label_75:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "DES64", value:  "DESMAC64");
            var val_63 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_80;
            }
            
            var val_60 = mem[val_1] + 176;
            var val_61 = 0;
            val_60 = val_60 + 8;
            label_79:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_78;
            }
            
            val_61 = val_61 + 1;
            val_60 = val_60 + 16;
            if(val_61 < (mem[val_1] + 286))
            {
                goto label_79;
            }
            
            goto label_80;
            label_78:
            var val_62 = val_60;
            val_62 = val_62 + 1;
            val_63 = val_63 + val_62;
            val_62 = val_63 + 296;
            label_80:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "DESEDE", value:  "DESEDEMAC");
            var val_67 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_86;
            }
            
            var val_64 = mem[val_1] + 176;
            var val_65 = 0;
            val_64 = val_64 + 8;
            label_85:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_84;
            }
            
            val_65 = val_65 + 1;
            val_64 = val_64 + 16;
            if(val_65 < (mem[val_1] + 286))
            {
                goto label_85;
            }
            
            goto label_86;
            label_84:
            var val_66 = val_64;
            val_66 = val_66 + 1;
            val_67 = val_67 + val_66;
            val_63 = val_67 + 296;
            label_86:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.DesEde3Cbc.Id, value:  "DESEDEMAC");
            var val_71 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_91;
            }
            
            var val_68 = mem[val_1] + 176;
            var val_69 = 0;
            val_68 = val_68 + 8;
            label_90:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_89;
            }
            
            val_69 = val_69 + 1;
            val_68 = val_68 + 16;
            if(val_69 < (mem[val_1] + 286))
            {
                goto label_90;
            }
            
            goto label_91;
            label_89:
            var val_70 = val_68;
            val_70 = val_70 + 1;
            val_71 = val_71 + val_70;
            val_64 = val_71 + 296;
            label_91:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "DESEDE/CFB8", value:  "DESEDEMAC/CFB8");
            var val_75 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_96;
            }
            
            var val_72 = mem[val_1] + 176;
            var val_73 = 0;
            val_72 = val_72 + 8;
            label_95:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_94;
            }
            
            val_73 = val_73 + 1;
            val_72 = val_72 + 16;
            if(val_73 < (mem[val_1] + 286))
            {
                goto label_95;
            }
            
            goto label_96;
            label_94:
            var val_74 = val_72;
            val_74 = val_74 + 1;
            val_75 = val_75 + val_74;
            val_65 = val_75 + 296;
            label_96:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "DESISO9797MAC", value:  "DESWITHISO9797");
            var val_79 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_101;
            }
            
            var val_76 = mem[val_1] + 176;
            var val_77 = 0;
            val_76 = val_76 + 8;
            label_100:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_99;
            }
            
            val_77 = val_77 + 1;
            val_76 = val_76 + 16;
            if(val_77 < (mem[val_1] + 286))
            {
                goto label_100;
            }
            
            goto label_101;
            label_99:
            var val_78 = val_76;
            val_78 = val_78 + 1;
            val_79 = val_79 + val_78;
            val_66 = val_79 + 296;
            label_101:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "DESEDE64", value:  "DESEDEMAC64");
            var val_83 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_106;
            }
            
            var val_80 = mem[val_1] + 176;
            var val_81 = 0;
            val_80 = val_80 + 8;
            label_105:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_104;
            }
            
            val_81 = val_81 + 1;
            val_80 = val_80 + 16;
            if(val_81 < (mem[val_1] + 286))
            {
                goto label_105;
            }
            
            goto label_106;
            label_104:
            var val_82 = val_80;
            val_82 = val_82 + 1;
            val_83 = val_83 + val_82;
            val_67 = val_83 + 296;
            label_106:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "DESEDE64WITHISO7816-4PADDING", value:  "DESEDEMAC64WITHISO7816-4PADDING");
            var val_87 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_111;
            }
            
            var val_84 = mem[val_1] + 176;
            var val_85 = 0;
            val_84 = val_84 + 8;
            label_110:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_109;
            }
            
            val_85 = val_85 + 1;
            val_84 = val_84 + 16;
            if(val_85 < (mem[val_1] + 286))
            {
                goto label_110;
            }
            
            goto label_111;
            label_109:
            var val_86 = val_84;
            val_86 = val_86 + 1;
            val_87 = val_87 + val_86;
            val_68 = val_87 + 296;
            label_111:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "DESEDEISO9797ALG1MACWITHISO7816-4PADDING", value:  "DESEDEMAC64WITHISO7816-4PADDING");
            var val_91 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_116;
            }
            
            var val_88 = mem[val_1] + 176;
            var val_89 = 0;
            val_88 = val_88 + 8;
            label_115:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_114;
            }
            
            val_89 = val_89 + 1;
            val_88 = val_88 + 16;
            if(val_89 < (mem[val_1] + 286))
            {
                goto label_115;
            }
            
            goto label_116;
            label_114:
            var val_90 = val_88;
            val_90 = val_90 + 1;
            val_91 = val_91 + val_90;
            val_69 = val_91 + 296;
            label_116:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "DESEDEISO9797ALG1WITHISO7816-4PADDING", value:  "DESEDEMAC64WITHISO7816-4PADDING");
            var val_95 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_121;
            }
            
            var val_92 = mem[val_1] + 176;
            var val_93 = 0;
            val_92 = val_92 + 8;
            label_120:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_119;
            }
            
            val_93 = val_93 + 1;
            val_92 = val_92 + 16;
            if(val_93 < (mem[val_1] + 286))
            {
                goto label_120;
            }
            
            goto label_121;
            label_119:
            var val_94 = val_92;
            val_94 = val_94 + 1;
            val_95 = val_95 + val_94;
            val_70 = val_95 + 296;
            label_121:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "ISO9797ALG3", value:  "ISO9797ALG3MAC");
            var val_99 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_126;
            }
            
            var val_96 = mem[val_1] + 176;
            var val_97 = 0;
            val_96 = val_96 + 8;
            label_125:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_124;
            }
            
            val_97 = val_97 + 1;
            val_96 = val_96 + 16;
            if(val_97 < (mem[val_1] + 286))
            {
                goto label_125;
            }
            
            goto label_126;
            label_124:
            var val_98 = val_96;
            val_98 = val_98 + 1;
            val_99 = val_99 + val_98;
            val_71 = val_99 + 296;
            label_126:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "ISO9797ALG3MACWITHISO7816-4PADDING", value:  "ISO9797ALG3WITHISO7816-4PADDING");
            var val_103 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_131;
            }
            
            var val_100 = mem[val_1] + 176;
            var val_101 = 0;
            val_100 = val_100 + 8;
            label_130:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_129;
            }
            
            val_101 = val_101 + 1;
            val_100 = val_100 + 16;
            if(val_101 < (mem[val_1] + 286))
            {
                goto label_130;
            }
            
            goto label_131;
            label_129:
            var val_102 = val_100;
            val_102 = val_102 + 1;
            val_103 = val_103 + val_102;
            val_72 = val_103 + 296;
            label_131:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "SKIPJACK", value:  "SKIPJACKMAC");
            var val_107 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_136;
            }
            
            var val_104 = mem[val_1] + 176;
            var val_105 = 0;
            val_104 = val_104 + 8;
            label_135:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_134;
            }
            
            val_105 = val_105 + 1;
            val_104 = val_104 + 16;
            if(val_105 < (mem[val_1] + 286))
            {
                goto label_135;
            }
            
            goto label_136;
            label_134:
            var val_106 = val_104;
            val_106 = val_106 + 1;
            val_107 = val_107 + val_106;
            val_73 = val_107 + 296;
            label_136:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "SKIPJACK/CFB8", value:  "SKIPJACKMAC/CFB8");
            var val_111 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_141;
            }
            
            var val_108 = mem[val_1] + 176;
            var val_109 = 0;
            val_108 = val_108 + 8;
            label_140:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_139;
            }
            
            val_109 = val_109 + 1;
            val_108 = val_108 + 16;
            if(val_109 < (mem[val_1] + 286))
            {
                goto label_140;
            }
            
            goto label_141;
            label_139:
            var val_110 = val_108;
            val_110 = val_110 + 1;
            val_111 = val_111 + val_110;
            val_74 = val_111 + 296;
            label_141:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "IDEA", value:  "IDEAMAC");
            var val_115 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_146;
            }
            
            var val_112 = mem[val_1] + 176;
            var val_113 = 0;
            val_112 = val_112 + 8;
            label_145:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_144;
            }
            
            val_113 = val_113 + 1;
            val_112 = val_112 + 16;
            if(val_113 < (mem[val_1] + 286))
            {
                goto label_145;
            }
            
            goto label_146;
            label_144:
            var val_114 = val_112;
            val_114 = val_114 + 1;
            val_115 = val_115 + val_114;
            val_75 = val_115 + 296;
            label_146:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "IDEA/CFB8", value:  "IDEAMAC/CFB8");
            var val_119 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_151;
            }
            
            var val_116 = mem[val_1] + 176;
            var val_117 = 0;
            val_116 = val_116 + 8;
            label_150:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_149;
            }
            
            val_117 = val_117 + 1;
            val_116 = val_116 + 16;
            if(val_117 < (mem[val_1] + 286))
            {
                goto label_150;
            }
            
            goto label_151;
            label_149:
            var val_118 = val_116;
            val_118 = val_118 + 1;
            val_119 = val_119 + val_118;
            val_76 = val_119 + 296;
            label_151:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "RC2", value:  "RC2MAC");
            var val_123 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_156;
            }
            
            var val_120 = mem[val_1] + 176;
            var val_121 = 0;
            val_120 = val_120 + 8;
            label_155:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_154;
            }
            
            val_121 = val_121 + 1;
            val_120 = val_120 + 16;
            if(val_121 < (mem[val_1] + 286))
            {
                goto label_155;
            }
            
            goto label_156;
            label_154:
            var val_122 = val_120;
            val_122 = val_122 + 1;
            val_123 = val_123 + val_122;
            val_77 = val_123 + 296;
            label_156:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "RC2/CFB8", value:  "RC2MAC/CFB8");
            var val_127 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_161;
            }
            
            var val_124 = mem[val_1] + 176;
            var val_125 = 0;
            val_124 = val_124 + 8;
            label_160:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_159;
            }
            
            val_125 = val_125 + 1;
            val_124 = val_124 + 16;
            if(val_125 < (mem[val_1] + 286))
            {
                goto label_160;
            }
            
            goto label_161;
            label_159:
            var val_126 = val_124;
            val_126 = val_126 + 1;
            val_127 = val_127 + val_126;
            val_78 = val_127 + 296;
            label_161:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "RC5", value:  "RC5MAC");
            var val_131 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_166;
            }
            
            var val_128 = mem[val_1] + 176;
            var val_129 = 0;
            val_128 = val_128 + 8;
            label_165:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_164;
            }
            
            val_129 = val_129 + 1;
            val_128 = val_128 + 16;
            if(val_129 < (mem[val_1] + 286))
            {
                goto label_165;
            }
            
            goto label_166;
            label_164:
            var val_130 = val_128;
            val_130 = val_130 + 1;
            val_131 = val_131 + val_130;
            val_79 = val_131 + 296;
            label_166:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "RC5/CFB8", value:  "RC5MAC/CFB8");
            var val_135 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_171;
            }
            
            var val_132 = mem[val_1] + 176;
            var val_133 = 0;
            val_132 = val_132 + 8;
            label_170:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_169;
            }
            
            val_133 = val_133 + 1;
            val_132 = val_132 + 16;
            if(val_133 < (mem[val_1] + 286))
            {
                goto label_170;
            }
            
            goto label_171;
            label_169:
            var val_134 = val_132;
            val_134 = val_134 + 1;
            val_135 = val_135 + val_134;
            val_80 = val_135 + 296;
            label_171:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "GOST28147", value:  "GOST28147MAC");
            var val_139 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_176;
            }
            
            var val_136 = mem[val_1] + 176;
            var val_137 = 0;
            val_136 = val_136 + 8;
            label_175:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_174;
            }
            
            val_137 = val_137 + 1;
            val_136 = val_136 + 16;
            if(val_137 < (mem[val_1] + 286))
            {
                goto label_175;
            }
            
            goto label_176;
            label_174:
            var val_138 = val_136;
            val_138 = val_138 + 1;
            val_139 = val_139 + val_138;
            val_81 = val_139 + 296;
            label_176:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "VMPC", value:  "VMPCMAC");
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
            val_82 = val_143 + 296;
            label_181:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "VMPC-MAC", value:  "VMPCMAC");
            var val_147 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_186;
            }
            
            var val_144 = mem[val_1] + 176;
            var val_145 = 0;
            val_144 = val_144 + 8;
            label_185:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_184;
            }
            
            val_145 = val_145 + 1;
            val_144 = val_144 + 16;
            if(val_145 < (mem[val_1] + 286))
            {
                goto label_185;
            }
            
            goto label_186;
            label_184:
            var val_146 = val_144;
            val_146 = val_146 + 1;
            val_147 = val_147 + val_146;
            val_83 = val_147 + 296;
            label_186:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "SIPHASH", value:  "SIPHASH-2-4");
            var val_151 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_191;
            }
            
            var val_148 = mem[val_1] + 176;
            var val_149 = 0;
            val_148 = val_148 + 8;
            label_190:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_189;
            }
            
            val_149 = val_149 + 1;
            val_148 = val_148 + 16;
            if(val_149 < (mem[val_1] + 286))
            {
                goto label_190;
            }
            
            goto label_191;
            label_189:
            var val_150 = val_148;
            val_150 = val_150 + 1;
            val_151 = val_151 + val_150;
            val_84 = val_151 + 296;
            label_191:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "PBEWITHHMACSHA", value:  "PBEWITHHMACSHA1");
            var val_155 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_196;
            }
            
            var val_152 = mem[val_1] + 176;
            var val_153 = 0;
            val_152 = val_152 + 8;
            label_195:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_194;
            }
            
            val_153 = val_153 + 1;
            val_152 = val_152 + 16;
            if(val_153 < (mem[val_1] + 286))
            {
                goto label_195;
            }
            
            goto label_196;
            label_194:
            var val_154 = val_152;
            val_154 = val_154 + 1;
            val_155 = val_155 + val_154;
            val_85 = val_155 + 296;
            label_196:
            Org.BouncyCastle.Security.MacUtilities.algorithms.set_Item(key:  "1.3.14.3.2.26", value:  "PBEWITHHMACSHA1");
        }
        public static Org.BouncyCastle.Crypto.IMac GetMac(Org.BouncyCastle.Asn1.DerObjectIdentifier id)
        {
            return Org.BouncyCastle.Security.MacUtilities.GetMac(algorithm:  id.Id);
        }
        public static Org.BouncyCastle.Crypto.IMac GetMac(string algorithm)
        {
            var val_70;
            var val_72;
            string val_73;
            var val_74;
            var val_75;
            var val_76;
            string val_1 = Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  algorithm);
            val_70 = null;
            val_70 = null;
            var val_71 = 0;
            val_71 = val_71 + 1;
            val_72 = Org.BouncyCastle.Security.MacUtilities.algorithms;
            if((val_72.Item[val_1] != null) && (null != null))
            {
                    val_72 = 0;
            }
            
            string val_5 = (val_72 == 0) ? (val_1) : (val_72);
            if((Org.BouncyCastle.Utilities.Platform.StartsWith(source:  val_5, prefix:  "PBEWITH")) != false)
            {
                    val_74 = "PBEWITH";
                if("PBEWITH" == null)
            {
                    val_74 = "PBEWITH";
            }
            
                val_73 = val_5.Substring(startIndex:  Length);
            }
            
            if((Org.BouncyCastle.Utilities.Platform.StartsWith(source:  val_73, prefix:  "HMAC")) == false)
            {
                goto label_19;
            }
            
            if((Org.BouncyCastle.Utilities.Platform.StartsWith(source:  val_73, prefix:  "HMAC-")) != true)
            {
                    if((Org.BouncyCastle.Utilities.Platform.StartsWith(source:  val_73, prefix:  "HMAC/")) == false)
            {
                goto label_25;
            }
            
            }
            
            val_75 = 5;
            goto label_27;
            label_19:
            if((System.String.op_Equality(a:  val_73, b:  "AESCMAC")) == false)
            {
                goto label_28;
            }
            
            label_40:
            Org.BouncyCastle.Crypto.Macs.CMac val_14 = null;
            val_76 = val_14;
            val_14 = new Org.BouncyCastle.Crypto.Macs.CMac(cipher:  new Org.BouncyCastle.Crypto.Engines.AesFastEngine());
            return (Org.BouncyCastle.Crypto.IMac)val_76;
            label_28:
            if((System.String.op_Equality(a:  val_73, b:  "DESMAC")) == false)
            {
                goto label_30;
            }
            
            label_67:
            Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac val_17 = null;
            val_76 = val_17;
            val_17 = new Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac(cipher:  new Org.BouncyCastle.Crypto.Engines.DesEngine());
            return (Org.BouncyCastle.Crypto.IMac)val_76;
            label_25:
            val_75 = 4;
            label_27:
            Org.BouncyCastle.Crypto.Macs.HMac val_20 = null;
            val_76 = val_20;
            val_20 = new Org.BouncyCastle.Crypto.Macs.HMac(digest:  Org.BouncyCastle.Security.DigestUtilities.GetDigest(algorithm:  val_73.Substring(startIndex:  4)));
            return (Org.BouncyCastle.Crypto.IMac)val_76;
            label_30:
            if((System.String.op_Equality(a:  val_73, b:  "DESMAC/CFB8")) == false)
            {
                goto label_35;
            }
            
            label_69:
            Org.BouncyCastle.Crypto.Macs.CfbBlockCipherMac val_23 = new Org.BouncyCastle.Crypto.Macs.CfbBlockCipherMac(cipher:  new Org.BouncyCastle.Crypto.Engines.DesEngine());
            return (Org.BouncyCastle.Crypto.IMac)val_76;
            label_35:
            if((System.String.op_Equality(a:  val_73, b:  "DESMAC64")) == false)
            {
                goto label_37;
            }
            
            label_46:
            Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac val_26 = new Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac(cipher:  new Org.BouncyCastle.Crypto.Engines.DesEngine(), macSizeInBits:  64);
            return (Org.BouncyCastle.Crypto.IMac)val_76;
            label_37:
            if((System.String.op_Equality(a:  val_73, b:  "DESEDECMAC")) == false)
            {
                goto label_39;
            }
            
            Org.BouncyCastle.Crypto.Engines.DesEdeEngine val_28 = new Org.BouncyCastle.Crypto.Engines.DesEdeEngine();
            goto label_40;
            label_39:
            if((System.String.op_Equality(a:  val_73, b:  "DESEDEMAC")) == false)
            {
                goto label_41;
            }
            
            Org.BouncyCastle.Crypto.Engines.DesEdeEngine val_30 = new Org.BouncyCastle.Crypto.Engines.DesEdeEngine();
            goto label_67;
            label_41:
            if((System.String.op_Equality(a:  val_73, b:  "DESEDEMAC/CFB8")) == false)
            {
                goto label_43;
            }
            
            Org.BouncyCastle.Crypto.Engines.DesEdeEngine val_32 = new Org.BouncyCastle.Crypto.Engines.DesEdeEngine();
            goto label_69;
            label_43:
            if((System.String.op_Equality(a:  val_73, b:  "DESEDEMAC64")) == false)
            {
                goto label_45;
            }
            
            Org.BouncyCastle.Crypto.Engines.DesEdeEngine val_34 = new Org.BouncyCastle.Crypto.Engines.DesEdeEngine();
            goto label_46;
            label_45:
            if((System.String.op_Equality(a:  val_73, b:  "DESEDEMAC64WITHISO7816-4PADDING")) != false)
            {
                    Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac val_38 = new Org.BouncyCastle.Crypto.Macs.CbcBlockCipherMac(cipher:  new Org.BouncyCastle.Crypto.Engines.DesEdeEngine(), macSizeInBits:  64, padding:  new Org.BouncyCastle.Crypto.Paddings.ISO7816d4Padding());
                return (Org.BouncyCastle.Crypto.IMac)val_76;
            }
            
            if((System.String.op_Equality(a:  val_73, b:  "DESWITHISO9797")) != true)
            {
                    if((System.String.op_Equality(a:  val_73, b:  "ISO9797ALG3MAC")) == false)
            {
                goto label_50;
            }
            
            }
            
            Org.BouncyCastle.Crypto.Macs.ISO9797Alg3Mac val_42 = new Org.BouncyCastle.Crypto.Macs.ISO9797Alg3Mac(cipher:  new Org.BouncyCastle.Crypto.Engines.DesEngine());
            return (Org.BouncyCastle.Crypto.IMac)val_76;
            label_50:
            if((System.String.op_Equality(a:  val_73, b:  "ISO9797ALG3WITHISO7816-4PADDING")) != false)
            {
                    Org.BouncyCastle.Crypto.Macs.ISO9797Alg3Mac val_46 = new Org.BouncyCastle.Crypto.Macs.ISO9797Alg3Mac(cipher:  new Org.BouncyCastle.Crypto.Engines.DesEngine(), padding:  new Org.BouncyCastle.Crypto.Paddings.ISO7816d4Padding());
                return (Org.BouncyCastle.Crypto.IMac)val_76;
            }
            
            if((System.String.op_Equality(a:  val_73, b:  "SKIPJACKMAC")) == false)
            {
                goto label_54;
            }
            
            Org.BouncyCastle.Crypto.Engines.SkipjackEngine val_48 = new Org.BouncyCastle.Crypto.Engines.SkipjackEngine();
            goto label_67;
            label_54:
            if((System.String.op_Equality(a:  val_73, b:  "SKIPJACKMAC/CFB8")) == false)
            {
                goto label_56;
            }
            
            Org.BouncyCastle.Crypto.Engines.SkipjackEngine val_50 = new Org.BouncyCastle.Crypto.Engines.SkipjackEngine();
            goto label_69;
            label_56:
            if((System.String.op_Equality(a:  val_73, b:  "IDEAMAC")) == false)
            {
                goto label_58;
            }
            
            Org.BouncyCastle.Crypto.Engines.IdeaEngine val_52 = new Org.BouncyCastle.Crypto.Engines.IdeaEngine();
            goto label_67;
            label_58:
            if((System.String.op_Equality(a:  val_73, b:  "IDEAMAC/CFB8")) == false)
            {
                goto label_60;
            }
            
            Org.BouncyCastle.Crypto.Engines.IdeaEngine val_54 = new Org.BouncyCastle.Crypto.Engines.IdeaEngine();
            goto label_69;
            label_60:
            if((System.String.op_Equality(a:  val_73, b:  "RC2MAC")) == false)
            {
                goto label_62;
            }
            
            Org.BouncyCastle.Crypto.Engines.RC2Engine val_56 = new Org.BouncyCastle.Crypto.Engines.RC2Engine();
            goto label_67;
            label_62:
            if((System.String.op_Equality(a:  val_73, b:  "RC2MAC/CFB8")) == false)
            {
                goto label_64;
            }
            
            Org.BouncyCastle.Crypto.Engines.RC2Engine val_58 = new Org.BouncyCastle.Crypto.Engines.RC2Engine();
            goto label_69;
            label_64:
            if((System.String.op_Equality(a:  val_73, b:  "RC5MAC")) == false)
            {
                goto label_66;
            }
            
            Org.BouncyCastle.Crypto.Engines.RC532Engine val_60 = new Org.BouncyCastle.Crypto.Engines.RC532Engine();
            goto label_67;
            label_66:
            if((System.String.op_Equality(a:  val_73, b:  "RC5MAC/CFB8")) == false)
            {
                goto label_68;
            }
            
            Org.BouncyCastle.Crypto.Engines.RC532Engine val_62 = new Org.BouncyCastle.Crypto.Engines.RC532Engine();
            goto label_69;
            label_68:
            if((System.String.op_Equality(a:  val_73, b:  "GOST28147MAC")) != false)
            {
                    Org.BouncyCastle.Crypto.Macs.Gost28147Mac val_64 = new Org.BouncyCastle.Crypto.Macs.Gost28147Mac();
                return (Org.BouncyCastle.Crypto.IMac)val_76;
            }
            
            if((System.String.op_Equality(a:  val_73, b:  "VMPCMAC")) != false)
            {
                    Org.BouncyCastle.Crypto.Macs.VmpcMac val_66 = new Org.BouncyCastle.Crypto.Macs.VmpcMac();
                return (Org.BouncyCastle.Crypto.IMac)val_76;
            }
            
            if((System.String.op_Equality(a:  val_73, b:  "SIPHASH-2-4")) != false)
            {
                    Org.BouncyCastle.Crypto.Macs.SipHash val_68 = new Org.BouncyCastle.Crypto.Macs.SipHash();
                return (Org.BouncyCastle.Crypto.IMac)val_76;
            }
            
            Org.BouncyCastle.Security.SecurityUtilityException val_70 = new Org.BouncyCastle.Security.SecurityUtilityException(message:  "Mac " + val_73 + " not recognised.");
        }
        public static string GetAlgorithmName(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            var val_4;
            var val_6;
            val_4 = null;
            val_4 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = Org.BouncyCastle.Security.MacUtilities.algorithms;
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
        public static byte[] CalculateMac(string algorithm, Org.BouncyCastle.Crypto.ICipherParameters cp, byte[] input)
        {
            Org.BouncyCastle.Crypto.IMac val_1 = Org.BouncyCastle.Security.MacUtilities.GetMac(algorithm:  algorithm);
            var val_4 = 0;
            val_4 = val_4 + 1;
            val_1.Init(parameters:  cp);
            if(input == null)
            {
                goto label_8;
            }
            
            label_15:
            var val_5 = 0;
            val_5 = val_5 + 1;
            goto label_13;
            label_8:
            if(val_1 != null)
            {
                goto label_15;
            }
            
            goto label_15;
            label_13:
            val_1.BlockUpdate(input:  input, inOff:  0, len:  input.Length);
            return Org.BouncyCastle.Security.MacUtilities.DoFinal(mac:  val_1);
        }
        public static byte[] DoFinal(Org.BouncyCastle.Crypto.IMac mac)
        {
            var val_6 = 0;
            val_6 = val_6 + 1;
            int val_2 = mac.GetMacSize();
            byte[] val_3 = new byte[0];
            var val_7 = 0;
            val_7 = val_7 + 1;
            int val_5 = mac.DoFinal(output:  val_3, outOff:  0);
            return (System.Byte[])val_3;
        }
        public static byte[] DoFinal(Org.BouncyCastle.Crypto.IMac mac, byte[] input)
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
            if(mac != null)
            {
                goto label_9;
            }
            
            goto label_9;
            label_6:
            mac.BlockUpdate(input:  input, inOff:  0, len:  input.Length);
            return Org.BouncyCastle.Security.MacUtilities.DoFinal(mac:  mac);
        }
    
    }

}
