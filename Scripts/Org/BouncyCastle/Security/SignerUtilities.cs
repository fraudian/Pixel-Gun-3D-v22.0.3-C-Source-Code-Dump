using UnityEngine;

namespace Org.BouncyCastle.Security
{
    public sealed class SignerUtilities
    {
        // Fields
        internal static readonly System.Collections.IDictionary algorithms;
        internal static readonly System.Collections.IDictionary oids;
        
        // Properties
        public static System.Collections.ICollection Algorithms { get; }
        
        // Methods
        private SignerUtilities()
        {
        
        }
        private static SignerUtilities()
        {
            var val_213;
            var val_214;
            var val_215;
            var val_216;
            var val_217;
            var val_218;
            var val_219;
            var val_220;
            var val_221;
            var val_222;
            var val_223;
            var val_224;
            var val_225;
            var val_226;
            var val_227;
            var val_228;
            var val_229;
            var val_230;
            var val_231;
            var val_232;
            var val_233;
            var val_234;
            var val_235;
            var val_236;
            var val_237;
            var val_238;
            var val_239;
            var val_240;
            var val_241;
            var val_242;
            var val_243;
            var val_244;
            var val_245;
            var val_246;
            var val_247;
            var val_248;
            var val_249;
            var val_250;
            var val_251;
            var val_252;
            var val_253;
            var val_254;
            var val_255;
            var val_256;
            var val_257;
            var val_258;
            var val_259;
            Org.BouncyCastle.Security.SignerUtilities.algorithms = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            Org.BouncyCastle.Security.SignerUtilities.oids = Org.BouncyCastle.Utilities.Platform.CreateHashtable();
            var val_169 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_7;
            }
            
            var val_167 = mem[val_1] + 176;
            val_167 = val_167 + 8;
            label_6:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_5;
            }
            
            val_167 = val_167 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_6;
            }
            
            goto label_7;
            label_5:
            var val_168 = val_167;
            val_168 = val_168 + 1;
            val_169 = val_169 + val_168;
            var val_3 = val_169 + 296;
            label_7:
            var val_172 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_12;
            }
            
            var val_170 = mem[val_1] + 176;
            val_170 = val_170 + 8;
            label_11:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_10;
            }
            
            val_170 = val_170 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_11;
            }
            
            goto label_12;
            label_10:
            var val_171 = val_170;
            val_171 = val_171 + 1;
            val_172 = val_172 + val_171;
            var val_4 = val_172 + 296;
            label_12:
            string val_5 = Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption.Id;
            var val_175 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_20;
            }
            
            var val_173 = mem[val_1] + 176;
            val_173 = val_173 + 8;
            label_19:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_18;
            }
            
            val_173 = val_173 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_19;
            }
            
            goto label_20;
            label_18:
            var val_174 = val_173;
            val_174 = val_174 + 1;
            val_175 = val_175 + val_174;
            var val_6 = val_175 + 296;
            label_20:
            var val_178 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_25;
            }
            
            var val_176 = mem[val_1] + 176;
            val_176 = val_176 + 8;
            label_24:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_23;
            }
            
            val_176 = val_176 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_24;
            }
            
            goto label_25;
            label_23:
            var val_177 = val_176;
            val_177 = val_177 + 1;
            val_178 = val_178 + val_177;
            var val_7 = val_178 + 296;
            label_25:
            var val_181 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_30;
            }
            
            var val_179 = mem[val_1] + 176;
            val_179 = val_179 + 8;
            label_29:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_28;
            }
            
            val_179 = val_179 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_29;
            }
            
            goto label_30;
            label_28:
            var val_180 = val_179;
            val_180 = val_180 + 1;
            val_181 = val_181 + val_180;
            var val_8 = val_181 + 296;
            label_30:
            string val_9 = Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4WithRsaEncryption.Id;
            var val_184 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_36;
            }
            
            var val_182 = mem[val_1] + 176;
            val_182 = val_182 + 8;
            label_35:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_34;
            }
            
            val_182 = val_182 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_35;
            }
            
            goto label_36;
            label_34:
            var val_183 = val_182;
            val_183 = val_183 + 1;
            val_184 = val_184 + val_183;
            var val_10 = val_184 + 296;
            label_36:
            var val_187 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_41;
            }
            
            var val_185 = mem[val_1] + 176;
            val_185 = val_185 + 8;
            label_40:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_39;
            }
            
            val_185 = val_185 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_40;
            }
            
            goto label_41;
            label_39:
            var val_186 = val_185;
            val_186 = val_186 + 1;
            val_187 = val_187 + val_186;
            var val_11 = val_187 + 296;
            label_41:
            var val_190 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_46;
            }
            
            var val_188 = mem[val_1] + 176;
            val_188 = val_188 + 8;
            label_45:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_44;
            }
            
            val_188 = val_188 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_45;
            }
            
            goto label_46;
            label_44:
            var val_189 = val_188;
            val_189 = val_189 + 1;
            val_190 = val_190 + val_189;
            var val_12 = val_190 + 296;
            label_46:
            string val_13 = Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption.Id;
            var val_193 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_52;
            }
            
            var val_191 = mem[val_1] + 176;
            val_191 = val_191 + 8;
            label_51:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_50;
            }
            
            val_191 = val_191 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_51;
            }
            
            goto label_52;
            label_50:
            var val_192 = val_191;
            val_192 = val_192 + 1;
            val_193 = val_193 + val_192;
            var val_14 = val_193 + 296;
            label_52:
            var val_196 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_57;
            }
            
            var val_194 = mem[val_1] + 176;
            val_194 = val_194 + 8;
            label_56:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_55;
            }
            
            val_194 = val_194 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_56;
            }
            
            goto label_57;
            label_55:
            var val_195 = val_194;
            val_195 = val_195 + 1;
            val_196 = val_196 + val_195;
            var val_15 = val_196 + 296;
            label_57:
            var val_199 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_62;
            }
            
            var val_197 = mem[val_1] + 176;
            val_197 = val_197 + 8;
            label_61:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_60;
            }
            
            val_197 = val_197 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_61;
            }
            
            goto label_62;
            label_60:
            var val_198 = val_197;
            val_198 = val_198 + 1;
            val_199 = val_199 + val_198;
            var val_16 = val_199 + 296;
            label_62:
            string val_17 = Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption.Id;
            var val_202 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_68;
            }
            
            var val_200 = mem[val_1] + 176;
            val_200 = val_200 + 8;
            label_67:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_66;
            }
            
            val_200 = val_200 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_67;
            }
            
            goto label_68;
            label_66:
            var val_201 = val_200;
            val_201 = val_201 + 1;
            val_202 = val_202 + val_201;
            var val_18 = val_202 + 296;
            label_68:
            var val_205 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_73;
            }
            
            var val_203 = mem[val_1] + 176;
            val_203 = val_203 + 8;
            label_72:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_71;
            }
            
            val_203 = val_203 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_72;
            }
            
            goto label_73;
            label_71:
            var val_204 = val_203;
            val_204 = val_204 + 1;
            val_205 = val_205 + val_204;
            var val_19 = val_205 + 296;
            label_73:
            var val_208 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_78;
            }
            
            var val_206 = mem[val_1] + 176;
            val_206 = val_206 + 8;
            label_77:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_76;
            }
            
            val_206 = val_206 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_77;
            }
            
            goto label_78;
            label_76:
            var val_207 = val_206;
            val_207 = val_207 + 1;
            val_208 = val_208 + val_207;
            var val_20 = val_208 + 296;
            label_78:
            var val_211 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_83;
            }
            
            var val_209 = mem[val_1] + 176;
            val_209 = val_209 + 8;
            label_82:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_81;
            }
            
            val_209 = val_209 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_82;
            }
            
            goto label_83;
            label_81:
            var val_210 = val_209;
            val_210 = val_210 + 1;
            val_211 = val_211 + val_210;
            var val_21 = val_211 + 296;
            label_83:
            string val_22 = Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption.Id;
            var val_214 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_89;
            }
            
            var val_212 = mem[val_1] + 176;
            val_212 = val_212 + 8;
            label_88:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_87;
            }
            
            val_212 = val_212 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_88;
            }
            
            goto label_89;
            label_87:
            var val_213 = val_212;
            val_213 = val_213 + 1;
            val_214 = val_214 + val_213;
            var val_23 = val_214 + 296;
            label_89:
            var val_217 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_94;
            }
            
            var val_215 = mem[val_1] + 176;
            val_215 = val_215 + 8;
            label_93:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_92;
            }
            
            val_215 = val_215 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_93;
            }
            
            goto label_94;
            label_92:
            var val_216 = val_215;
            val_216 = val_216 + 1;
            val_217 = val_217 + val_216;
            var val_24 = val_217 + 296;
            label_94:
            var val_220 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_99;
            }
            
            var val_218 = mem[val_1] + 176;
            val_218 = val_218 + 8;
            label_98:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_97;
            }
            
            val_218 = val_218 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_98;
            }
            
            goto label_99;
            label_97:
            var val_219 = val_218;
            val_219 = val_219 + 1;
            val_220 = val_220 + val_219;
            var val_25 = val_220 + 296;
            label_99:
            var val_223 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_104;
            }
            
            var val_221 = mem[val_1] + 176;
            val_221 = val_221 + 8;
            label_103:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_102;
            }
            
            val_221 = val_221 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_103;
            }
            
            goto label_104;
            label_102:
            var val_222 = val_221;
            val_222 = val_222 + 1;
            val_223 = val_223 + val_222;
            var val_26 = val_223 + 296;
            label_104:
            string val_27 = Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption.Id;
            var val_226 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_110;
            }
            
            var val_224 = mem[val_1] + 176;
            val_224 = val_224 + 8;
            label_109:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_108;
            }
            
            val_224 = val_224 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_109;
            }
            
            goto label_110;
            label_108:
            var val_225 = val_224;
            val_225 = val_225 + 1;
            val_226 = val_226 + val_225;
            var val_28 = val_226 + 296;
            label_110:
            var val_229 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_115;
            }
            
            var val_227 = mem[val_1] + 176;
            val_227 = val_227 + 8;
            label_114:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_113;
            }
            
            val_227 = val_227 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_114;
            }
            
            goto label_115;
            label_113:
            var val_228 = val_227;
            val_228 = val_228 + 1;
            val_229 = val_229 + val_228;
            var val_29 = val_229 + 296;
            label_115:
            var val_232 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_120;
            }
            
            var val_230 = mem[val_1] + 176;
            val_230 = val_230 + 8;
            label_119:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_118;
            }
            
            val_230 = val_230 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_119;
            }
            
            goto label_120;
            label_118:
            var val_231 = val_230;
            val_231 = val_231 + 1;
            val_232 = val_232 + val_231;
            var val_30 = val_232 + 296;
            label_120:
            var val_235 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_125;
            }
            
            var val_233 = mem[val_1] + 176;
            val_233 = val_233 + 8;
            label_124:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_123;
            }
            
            val_233 = val_233 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_124;
            }
            
            goto label_125;
            label_123:
            var val_234 = val_233;
            val_234 = val_234 + 1;
            val_235 = val_235 + val_234;
            var val_31 = val_235 + 296;
            label_125:
            string val_32 = Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption.Id;
            var val_238 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_131;
            }
            
            var val_236 = mem[val_1] + 176;
            val_236 = val_236 + 8;
            label_130:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_129;
            }
            
            val_236 = val_236 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_130;
            }
            
            goto label_131;
            label_129:
            var val_237 = val_236;
            val_237 = val_237 + 1;
            val_238 = val_238 + val_237;
            var val_33 = val_238 + 296;
            label_131:
            var val_241 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_136;
            }
            
            var val_239 = mem[val_1] + 176;
            val_239 = val_239 + 8;
            label_135:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_134;
            }
            
            val_239 = val_239 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_135;
            }
            
            goto label_136;
            label_134:
            var val_240 = val_239;
            val_240 = val_240 + 1;
            val_241 = val_241 + val_240;
            var val_34 = val_241 + 296;
            label_136:
            var val_244 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_141;
            }
            
            var val_242 = mem[val_1] + 176;
            val_242 = val_242 + 8;
            label_140:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_139;
            }
            
            val_242 = val_242 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_140;
            }
            
            goto label_141;
            label_139:
            var val_243 = val_242;
            val_243 = val_243 + 1;
            val_244 = val_244 + val_243;
            var val_35 = val_244 + 296;
            label_141:
            var val_247 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_146;
            }
            
            var val_245 = mem[val_1] + 176;
            val_245 = val_245 + 8;
            label_145:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_144;
            }
            
            val_245 = val_245 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_145;
            }
            
            goto label_146;
            label_144:
            var val_246 = val_245;
            val_246 = val_246 + 1;
            val_247 = val_247 + val_246;
            var val_36 = val_247 + 296;
            label_146:
            string val_37 = Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption.Id;
            var val_250 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_152;
            }
            
            var val_248 = mem[val_1] + 176;
            val_248 = val_248 + 8;
            label_151:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_150;
            }
            
            val_248 = val_248 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_151;
            }
            
            goto label_152;
            label_150:
            var val_249 = val_248;
            val_249 = val_249 + 1;
            val_250 = val_250 + val_249;
            var val_38 = val_250 + 296;
            label_152:
            var val_253 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_157;
            }
            
            var val_251 = mem[val_1] + 176;
            val_251 = val_251 + 8;
            label_156:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_155;
            }
            
            val_251 = val_251 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_156;
            }
            
            goto label_157;
            label_155:
            var val_252 = val_251;
            val_252 = val_252 + 1;
            val_253 = val_253 + val_252;
            var val_39 = val_253 + 296;
            label_157:
            var val_256 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_162;
            }
            
            var val_254 = mem[val_1] + 176;
            val_254 = val_254 + 8;
            label_161:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_160;
            }
            
            val_254 = val_254 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_161;
            }
            
            goto label_162;
            label_160:
            var val_255 = val_254;
            val_255 = val_255 + 1;
            val_256 = val_256 + val_255;
            var val_40 = val_256 + 296;
            label_162:
            var val_259 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_167;
            }
            
            var val_257 = mem[val_1] + 176;
            val_257 = val_257 + 8;
            label_166:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_165;
            }
            
            val_257 = val_257 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_166;
            }
            
            goto label_167;
            label_165:
            var val_258 = val_257;
            val_258 = val_258 + 1;
            val_259 = val_259 + val_258;
            var val_41 = val_259 + 296;
            label_167:
            string val_42 = Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss.Id;
            var val_262 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_173;
            }
            
            var val_260 = mem[val_1] + 176;
            val_260 = val_260 + 8;
            label_172:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_171;
            }
            
            val_260 = val_260 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_172;
            }
            
            goto label_173;
            label_171:
            var val_261 = val_260;
            val_261 = val_261 + 1;
            val_262 = val_262 + val_261;
            var val_43 = val_262 + 296;
            label_173:
            var val_265 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_178;
            }
            
            var val_263 = mem[val_1] + 176;
            val_263 = val_263 + 8;
            label_177:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_176;
            }
            
            val_263 = val_263 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_177;
            }
            
            goto label_178;
            label_176:
            var val_264 = val_263;
            val_264 = val_264 + 1;
            val_265 = val_265 + val_264;
            var val_44 = val_265 + 296;
            label_178:
            var val_268 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_183;
            }
            
            var val_266 = mem[val_1] + 176;
            val_266 = val_266 + 8;
            label_182:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_181;
            }
            
            val_266 = val_266 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_182;
            }
            
            goto label_183;
            label_181:
            var val_267 = val_266;
            val_267 = val_267 + 1;
            val_268 = val_268 + val_267;
            var val_45 = val_268 + 296;
            label_183:
            var val_271 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_188;
            }
            
            var val_269 = mem[val_1] + 176;
            val_269 = val_269 + 8;
            label_187:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_186;
            }
            
            val_269 = val_269 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_187;
            }
            
            goto label_188;
            label_186:
            var val_270 = val_269;
            val_270 = val_270 + 1;
            val_271 = val_271 + val_270;
            var val_46 = val_271 + 296;
            label_188:
            var val_274 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_193;
            }
            
            var val_272 = mem[val_1] + 176;
            val_272 = val_272 + 8;
            label_192:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_191;
            }
            
            val_272 = val_272 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_192;
            }
            
            goto label_193;
            label_191:
            var val_273 = val_272;
            val_273 = val_273 + 1;
            val_274 = val_274 + val_273;
            var val_47 = val_274 + 296;
            label_193:
            var val_277 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_198;
            }
            
            var val_275 = mem[val_1] + 176;
            val_275 = val_275 + 8;
            label_197:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_196;
            }
            
            val_275 = val_275 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_197;
            }
            
            goto label_198;
            label_196:
            var val_276 = val_275;
            val_276 = val_276 + 1;
            val_277 = val_277 + val_276;
            var val_48 = val_277 + 296;
            label_198:
            var val_280 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_203;
            }
            
            var val_278 = mem[val_1] + 176;
            val_278 = val_278 + 8;
            label_202:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_201;
            }
            
            val_278 = val_278 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_202;
            }
            
            goto label_203;
            label_201:
            var val_279 = val_278;
            val_279 = val_279 + 1;
            val_280 = val_280 + val_279;
            var val_49 = val_280 + 296;
            label_203:
            var val_283 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_208;
            }
            
            var val_281 = mem[val_1] + 176;
            val_281 = val_281 + 8;
            label_207:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_206;
            }
            
            val_281 = val_281 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_207;
            }
            
            goto label_208;
            label_206:
            var val_282 = val_281;
            val_282 = val_282 + 1;
            val_283 = val_283 + val_282;
            var val_50 = val_283 + 296;
            label_208:
            var val_286 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_213;
            }
            
            var val_284 = mem[val_1] + 176;
            val_284 = val_284 + 8;
            label_212:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_211;
            }
            
            val_284 = val_284 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_212;
            }
            
            goto label_213;
            label_211:
            var val_285 = val_284;
            val_285 = val_285 + 1;
            val_286 = val_286 + val_285;
            var val_51 = val_286 + 296;
            label_213:
            var val_289 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_218;
            }
            
            var val_287 = mem[val_1] + 176;
            val_287 = val_287 + 8;
            label_217:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_216;
            }
            
            val_287 = val_287 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_217;
            }
            
            goto label_218;
            label_216:
            var val_288 = val_287;
            val_288 = val_288 + 1;
            val_289 = val_289 + val_288;
            var val_52 = val_289 + 296;
            label_218:
            var val_292 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_223;
            }
            
            var val_290 = mem[val_1] + 176;
            val_290 = val_290 + 8;
            label_222:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_221;
            }
            
            val_290 = val_290 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_222;
            }
            
            goto label_223;
            label_221:
            var val_291 = val_290;
            val_291 = val_291 + 1;
            val_292 = val_292 + val_291;
            var val_53 = val_292 + 296;
            label_223:
            var val_295 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_228;
            }
            
            var val_293 = mem[val_1] + 176;
            val_293 = val_293 + 8;
            label_227:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_226;
            }
            
            val_293 = val_293 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_227;
            }
            
            goto label_228;
            label_226:
            var val_294 = val_293;
            val_294 = val_294 + 1;
            val_295 = val_295 + val_294;
            var val_54 = val_295 + 296;
            label_228:
            var val_298 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_233;
            }
            
            var val_296 = mem[val_1] + 176;
            val_296 = val_296 + 8;
            label_232:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_231;
            }
            
            val_296 = val_296 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_232;
            }
            
            goto label_233;
            label_231:
            var val_297 = val_296;
            val_297 = val_297 + 1;
            val_298 = val_298 + val_297;
            var val_55 = val_298 + 296;
            label_233:
            var val_301 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_238;
            }
            
            var val_299 = mem[val_1] + 176;
            val_299 = val_299 + 8;
            label_237:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_236;
            }
            
            val_299 = val_299 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_237;
            }
            
            goto label_238;
            label_236:
            var val_300 = val_299;
            val_300 = val_300 + 1;
            val_301 = val_301 + val_300;
            var val_56 = val_301 + 296;
            label_238:
            var val_304 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_243;
            }
            
            var val_302 = mem[val_1] + 176;
            val_302 = val_302 + 8;
            label_242:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_241;
            }
            
            val_302 = val_302 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_242;
            }
            
            goto label_243;
            label_241:
            var val_303 = val_302;
            val_303 = val_303 + 1;
            val_304 = val_304 + val_303;
            var val_57 = val_304 + 296;
            label_243:
            var val_307 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_248;
            }
            
            var val_305 = mem[val_1] + 176;
            val_305 = val_305 + 8;
            label_247:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_246;
            }
            
            val_305 = val_305 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_247;
            }
            
            goto label_248;
            label_246:
            var val_306 = val_305;
            val_306 = val_306 + 1;
            val_307 = val_307 + val_306;
            var val_58 = val_307 + 296;
            label_248:
            var val_310 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_253;
            }
            
            var val_308 = mem[val_1] + 176;
            val_308 = val_308 + 8;
            label_252:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_251;
            }
            
            val_308 = val_308 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_252;
            }
            
            goto label_253;
            label_251:
            var val_309 = val_308;
            val_309 = val_309 + 1;
            val_310 = val_310 + val_309;
            var val_59 = val_310 + 296;
            label_253:
            var val_313 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_258;
            }
            
            var val_311 = mem[val_1] + 176;
            val_311 = val_311 + 8;
            label_257:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_256;
            }
            
            val_311 = val_311 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_257;
            }
            
            goto label_258;
            label_256:
            var val_312 = val_311;
            val_312 = val_312 + 1;
            val_313 = val_313 + val_312;
            var val_60 = val_313 + 296;
            label_258:
            var val_316 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_263;
            }
            
            var val_314 = mem[val_1] + 176;
            val_314 = val_314 + 8;
            label_262:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_261;
            }
            
            val_314 = val_314 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_262;
            }
            
            goto label_263;
            label_261:
            var val_315 = val_314;
            val_315 = val_315 + 1;
            val_316 = val_316 + val_315;
            var val_61 = val_316 + 296;
            label_263:
            var val_319 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_268;
            }
            
            var val_317 = mem[val_1] + 176;
            val_317 = val_317 + 8;
            label_267:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_266;
            }
            
            val_317 = val_317 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_267;
            }
            
            goto label_268;
            label_266:
            var val_318 = val_317;
            val_318 = val_318 + 1;
            val_319 = val_319 + val_318;
            var val_62 = val_319 + 296;
            label_268:
            var val_322 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_273;
            }
            
            var val_320 = mem[val_1] + 176;
            val_320 = val_320 + 8;
            label_272:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_271;
            }
            
            val_320 = val_320 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_272;
            }
            
            goto label_273;
            label_271:
            var val_321 = val_320;
            val_321 = val_321 + 1;
            val_322 = val_322 + val_321;
            var val_63 = val_322 + 296;
            label_273:
            var val_325 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_278;
            }
            
            var val_323 = mem[val_1] + 176;
            val_323 = val_323 + 8;
            label_277:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_276;
            }
            
            val_323 = val_323 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_277;
            }
            
            goto label_278;
            label_276:
            var val_324 = val_323;
            val_324 = val_324 + 1;
            val_325 = val_325 + val_324;
            var val_64 = val_325 + 296;
            label_278:
            var val_328 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_283;
            }
            
            var val_326 = mem[val_1] + 176;
            val_326 = val_326 + 8;
            label_282:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_281;
            }
            
            val_326 = val_326 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_282;
            }
            
            goto label_283;
            label_281:
            var val_327 = val_326;
            val_327 = val_327 + 1;
            val_328 = val_328 + val_327;
            var val_65 = val_328 + 296;
            label_283:
            var val_331 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_288;
            }
            
            var val_329 = mem[val_1] + 176;
            val_329 = val_329 + 8;
            label_287:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_286;
            }
            
            val_329 = val_329 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_287;
            }
            
            goto label_288;
            label_286:
            var val_330 = val_329;
            val_330 = val_330 + 1;
            val_331 = val_331 + val_330;
            var val_66 = val_331 + 296;
            label_288:
            string val_67 = Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128.Id;
            var val_334 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_296;
            }
            
            var val_332 = mem[val_1] + 176;
            val_332 = val_332 + 8;
            label_295:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_294;
            }
            
            val_332 = val_332 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_295;
            }
            
            goto label_296;
            label_294:
            var val_333 = val_332;
            val_333 = val_333 + 1;
            val_334 = val_334 + val_333;
            var val_68 = val_334 + 296;
            label_296:
            var val_337 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_301;
            }
            
            var val_335 = mem[val_1] + 176;
            val_335 = val_335 + 8;
            label_300:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_299;
            }
            
            val_335 = val_335 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_300;
            }
            
            goto label_301;
            label_299:
            var val_336 = val_335;
            val_336 = val_336 + 1;
            val_337 = val_337 + val_336;
            var val_69 = val_337 + 296;
            label_301:
            var val_340 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_306;
            }
            
            var val_338 = mem[val_1] + 176;
            val_338 = val_338 + 8;
            label_305:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_304;
            }
            
            val_338 = val_338 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_305;
            }
            
            goto label_306;
            label_304:
            var val_339 = val_338;
            val_339 = val_339 + 1;
            val_340 = val_340 + val_339;
            var val_70 = val_340 + 296;
            label_306:
            string val_71 = Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160.Id;
            var val_343 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_312;
            }
            
            var val_341 = mem[val_1] + 176;
            val_341 = val_341 + 8;
            label_311:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_310;
            }
            
            val_341 = val_341 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_311;
            }
            
            goto label_312;
            label_310:
            var val_342 = val_341;
            val_342 = val_342 + 1;
            val_343 = val_343 + val_342;
            var val_72 = val_343 + 296;
            label_312:
            var val_346 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_317;
            }
            
            var val_344 = mem[val_1] + 176;
            val_344 = val_344 + 8;
            label_316:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_315;
            }
            
            val_344 = val_344 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_316;
            }
            
            goto label_317;
            label_315:
            var val_345 = val_344;
            val_345 = val_345 + 1;
            val_346 = val_346 + val_345;
            var val_73 = val_346 + 296;
            label_317:
            var val_349 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_322;
            }
            
            var val_347 = mem[val_1] + 176;
            val_347 = val_347 + 8;
            label_321:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_320;
            }
            
            val_347 = val_347 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_321;
            }
            
            goto label_322;
            label_320:
            var val_348 = val_347;
            val_348 = val_348 + 1;
            val_349 = val_349 + val_348;
            var val_74 = val_349 + 296;
            label_322:
            string val_75 = Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256.Id;
            var val_352 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_328;
            }
            
            var val_350 = mem[val_1] + 176;
            val_350 = val_350 + 8;
            label_327:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_326;
            }
            
            val_350 = val_350 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_327;
            }
            
            goto label_328;
            label_326:
            var val_351 = val_350;
            val_351 = val_351 + 1;
            val_352 = val_352 + val_351;
            var val_76 = val_352 + 296;
            label_328:
            var val_355 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_333;
            }
            
            var val_353 = mem[val_1] + 176;
            val_353 = val_353 + 8;
            label_332:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_331;
            }
            
            val_353 = val_353 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_332;
            }
            
            goto label_333;
            label_331:
            var val_354 = val_353;
            val_354 = val_354 + 1;
            val_355 = val_355 + val_354;
            var val_77 = val_355 + 296;
            label_333:
            var val_358 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_338;
            }
            
            var val_356 = mem[val_1] + 176;
            val_356 = val_356 + 8;
            label_337:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_336;
            }
            
            val_356 = val_356 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_337;
            }
            
            goto label_338;
            label_336:
            var val_357 = val_356;
            val_357 = val_357 + 1;
            val_358 = val_358 + val_357;
            var val_78 = val_358 + 296;
            label_338:
            var val_361 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_343;
            }
            
            var val_359 = mem[val_1] + 176;
            val_359 = val_359 + 8;
            label_342:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_341;
            }
            
            val_359 = val_359 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_342;
            }
            
            goto label_343;
            label_341:
            var val_360 = val_359;
            val_360 = val_360 + 1;
            val_361 = val_361 + val_360;
            var val_79 = val_361 + 296;
            label_343:
            var val_364 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_348;
            }
            
            var val_362 = mem[val_1] + 176;
            val_362 = val_362 + 8;
            label_347:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_346;
            }
            
            val_362 = val_362 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_347;
            }
            
            goto label_348;
            label_346:
            var val_363 = val_362;
            val_363 = val_363 + 1;
            val_364 = val_364 + val_363;
            var val_80 = val_364 + 296;
            label_348:
            var val_367 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_353;
            }
            
            var val_365 = mem[val_1] + 176;
            val_365 = val_365 + 8;
            label_352:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_351;
            }
            
            val_365 = val_365 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_352;
            }
            
            goto label_353;
            label_351:
            var val_366 = val_365;
            val_366 = val_366 + 1;
            val_367 = val_367 + val_366;
            var val_81 = val_367 + 296;
            label_353:
            var val_370 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_358;
            }
            
            var val_368 = mem[val_1] + 176;
            val_368 = val_368 + 8;
            label_357:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_356;
            }
            
            val_368 = val_368 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_357;
            }
            
            goto label_358;
            label_356:
            var val_369 = val_368;
            val_369 = val_369 + 1;
            val_370 = val_370 + val_369;
            var val_82 = val_370 + 296;
            label_358:
            var val_373 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_363;
            }
            
            var val_371 = mem[val_1] + 176;
            val_371 = val_371 + 8;
            label_362:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_361;
            }
            
            val_371 = val_371 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_362;
            }
            
            goto label_363;
            label_361:
            var val_372 = val_371;
            val_372 = val_372 + 1;
            val_373 = val_373 + val_372;
            var val_83 = val_373 + 296;
            label_363:
            var val_376 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_368;
            }
            
            var val_374 = mem[val_1] + 176;
            val_374 = val_374 + 8;
            label_367:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_366;
            }
            
            val_374 = val_374 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_367;
            }
            
            goto label_368;
            label_366:
            var val_375 = val_374;
            val_375 = val_375 + 1;
            val_376 = val_376 + val_375;
            var val_84 = val_376 + 296;
            label_368:
            var val_379 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_373;
            }
            
            var val_377 = mem[val_1] + 176;
            val_377 = val_377 + 8;
            label_372:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_371;
            }
            
            val_377 = val_377 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_372;
            }
            
            goto label_373;
            label_371:
            var val_378 = val_377;
            val_378 = val_378 + 1;
            val_379 = val_379 + val_378;
            var val_85 = val_379 + 296;
            label_373:
            var val_382 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_378;
            }
            
            var val_380 = mem[val_1] + 176;
            val_380 = val_380 + 8;
            label_377:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_376;
            }
            
            val_380 = val_380 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_377;
            }
            
            goto label_378;
            label_376:
            var val_381 = val_380;
            val_381 = val_381 + 1;
            val_382 = val_382 + val_381;
            var val_86 = val_382 + 296;
            label_378:
            var val_385 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_383;
            }
            
            var val_383 = mem[val_1] + 176;
            val_383 = val_383 + 8;
            label_382:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_381;
            }
            
            val_383 = val_383 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_382;
            }
            
            goto label_383;
            label_381:
            var val_384 = val_383;
            val_384 = val_384 + 1;
            val_385 = val_385 + val_384;
            var val_87 = val_385 + 296;
            label_383:
            var val_388 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_388;
            }
            
            var val_386 = mem[val_1] + 176;
            val_386 = val_386 + 8;
            label_387:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_386;
            }
            
            val_386 = val_386 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_387;
            }
            
            goto label_388;
            label_386:
            var val_387 = val_386;
            val_387 = val_387 + 1;
            val_388 = val_388 + val_387;
            var val_88 = val_388 + 296;
            label_388:
            var val_391 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_393;
            }
            
            var val_389 = mem[val_1] + 176;
            val_389 = val_389 + 8;
            label_392:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_391;
            }
            
            val_389 = val_389 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_392;
            }
            
            goto label_393;
            label_391:
            var val_390 = val_389;
            val_390 = val_390 + 1;
            val_391 = val_391 + val_390;
            var val_89 = val_391 + 296;
            label_393:
            var val_394 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_398;
            }
            
            var val_392 = mem[val_1] + 176;
            val_392 = val_392 + 8;
            label_397:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_396;
            }
            
            val_392 = val_392 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_397;
            }
            
            goto label_398;
            label_396:
            var val_393 = val_392;
            val_393 = val_393 + 1;
            val_394 = val_394 + val_393;
            var val_90 = val_394 + 296;
            label_398:
            var val_397 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_403;
            }
            
            var val_395 = mem[val_1] + 176;
            val_395 = val_395 + 8;
            label_402:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_401;
            }
            
            val_395 = val_395 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_402;
            }
            
            goto label_403;
            label_401:
            var val_396 = val_395;
            val_396 = val_396 + 1;
            val_397 = val_397 + val_396;
            var val_91 = val_397 + 296;
            label_403:
            var val_400 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_408;
            }
            
            var val_398 = mem[val_1] + 176;
            val_398 = val_398 + 8;
            label_407:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_406;
            }
            
            val_398 = val_398 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_407;
            }
            
            goto label_408;
            label_406:
            var val_399 = val_398;
            val_399 = val_399 + 1;
            val_400 = val_400 + val_399;
            var val_92 = val_400 + 296;
            label_408:
            var val_403 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_413;
            }
            
            var val_401 = mem[val_1] + 176;
            val_401 = val_401 + 8;
            label_412:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_411;
            }
            
            val_401 = val_401 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_412;
            }
            
            goto label_413;
            label_411:
            var val_402 = val_401;
            val_402 = val_402 + 1;
            val_403 = val_403 + val_402;
            var val_93 = val_403 + 296;
            label_413:
            string val_94 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1.Id;
            var val_406 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_421;
            }
            
            var val_404 = mem[val_1] + 176;
            val_404 = val_404 + 8;
            label_420:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_419;
            }
            
            val_404 = val_404 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_420;
            }
            
            goto label_421;
            label_419:
            var val_405 = val_404;
            val_405 = val_405 + 1;
            val_406 = val_406 + val_405;
            var val_95 = val_406 + 296;
            label_421:
            var val_409 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_426;
            }
            
            var val_407 = mem[val_1] + 176;
            val_407 = val_407 + 8;
            label_425:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_424;
            }
            
            val_407 = val_407 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_425;
            }
            
            goto label_426;
            label_424:
            var val_408 = val_407;
            val_408 = val_408 + 1;
            val_409 = val_409 + val_408;
            var val_96 = val_409 + 296;
            label_426:
            var val_412 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_431;
            }
            
            var val_410 = mem[val_1] + 176;
            val_410 = val_410 + 8;
            label_430:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_429;
            }
            
            val_410 = val_410 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_430;
            }
            
            goto label_431;
            label_429:
            var val_411 = val_410;
            val_411 = val_411 + 1;
            val_412 = val_412 + val_411;
            var val_97 = val_412 + 296;
            label_431:
            var val_415 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_436;
            }
            
            var val_413 = mem[val_1] + 176;
            val_413 = val_413 + 8;
            label_435:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_434;
            }
            
            val_413 = val_413 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_435;
            }
            
            goto label_436;
            label_434:
            var val_414 = val_413;
            val_414 = val_414 + 1;
            val_415 = val_415 + val_414;
            var val_98 = val_415 + 296;
            label_436:
            var val_418 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_441;
            }
            
            var val_416 = mem[val_1] + 176;
            val_416 = val_416 + 8;
            label_440:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_439;
            }
            
            val_416 = val_416 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_440;
            }
            
            goto label_441;
            label_439:
            var val_417 = val_416;
            val_417 = val_417 + 1;
            val_418 = val_418 + val_417;
            var val_99 = val_418 + 296;
            label_441:
            var val_421 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_446;
            }
            
            var val_419 = mem[val_1] + 176;
            val_419 = val_419 + 8;
            label_445:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_444;
            }
            
            val_419 = val_419 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_445;
            }
            
            goto label_446;
            label_444:
            var val_420 = val_419;
            val_420 = val_420 + 1;
            val_421 = val_421 + val_420;
            var val_100 = val_421 + 296;
            label_446:
            var val_424 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_451;
            }
            
            var val_422 = mem[val_1] + 176;
            val_422 = val_422 + 8;
            label_450:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_449;
            }
            
            val_422 = val_422 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_450;
            }
            
            goto label_451;
            label_449:
            var val_423 = val_422;
            val_423 = val_423 + 1;
            val_424 = val_424 + val_423;
            var val_101 = val_424 + 296;
            label_451:
            string val_102 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha224.Id;
            var val_427 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_459;
            }
            
            var val_425 = mem[val_1] + 176;
            val_425 = val_425 + 8;
            label_458:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_457;
            }
            
            val_425 = val_425 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_458;
            }
            
            goto label_459;
            label_457:
            var val_426 = val_425;
            val_426 = val_426 + 1;
            val_427 = val_427 + val_426;
            var val_103 = val_427 + 296;
            label_459:
            var val_430 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_464;
            }
            
            var val_428 = mem[val_1] + 176;
            val_428 = val_428 + 8;
            label_463:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_462;
            }
            
            val_428 = val_428 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_463;
            }
            
            goto label_464;
            label_462:
            var val_429 = val_428;
            val_429 = val_429 + 1;
            val_430 = val_430 + val_429;
            var val_104 = val_430 + 296;
            label_464:
            var val_433 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_469;
            }
            
            var val_431 = mem[val_1] + 176;
            val_431 = val_431 + 8;
            label_468:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_467;
            }
            
            val_431 = val_431 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_468;
            }
            
            goto label_469;
            label_467:
            var val_432 = val_431;
            val_432 = val_432 + 1;
            val_433 = val_433 + val_432;
            var val_105 = val_433 + 296;
            label_469:
            var val_436 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_474;
            }
            
            var val_434 = mem[val_1] + 176;
            val_434 = val_434 + 8;
            label_473:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_472;
            }
            
            val_434 = val_434 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_473;
            }
            
            goto label_474;
            label_472:
            var val_435 = val_434;
            val_435 = val_435 + 1;
            val_436 = val_436 + val_435;
            var val_106 = val_436 + 296;
            label_474:
            var val_439 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_479;
            }
            
            var val_437 = mem[val_1] + 176;
            val_437 = val_437 + 8;
            label_478:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_477;
            }
            
            val_437 = val_437 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_478;
            }
            
            goto label_479;
            label_477:
            var val_438 = val_437;
            val_438 = val_438 + 1;
            val_439 = val_439 + val_438;
            var val_107 = val_439 + 296;
            label_479:
            var val_442 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_484;
            }
            
            var val_440 = mem[val_1] + 176;
            val_440 = val_440 + 8;
            label_483:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_482;
            }
            
            val_440 = val_440 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_483;
            }
            
            goto label_484;
            label_482:
            var val_441 = val_440;
            val_441 = val_441 + 1;
            val_442 = val_442 + val_441;
            var val_108 = val_442 + 296;
            label_484:
            var val_445 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_489;
            }
            
            var val_443 = mem[val_1] + 176;
            val_443 = val_443 + 8;
            label_488:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_487;
            }
            
            val_443 = val_443 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_488;
            }
            
            goto label_489;
            label_487:
            var val_444 = val_443;
            val_444 = val_444 + 1;
            val_445 = val_445 + val_444;
            var val_109 = val_445 + 296;
            label_489:
            string val_110 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha256.Id;
            var val_448 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_495;
            }
            
            var val_446 = mem[val_1] + 176;
            val_446 = val_446 + 8;
            label_494:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_493;
            }
            
            val_446 = val_446 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_494;
            }
            
            goto label_495;
            label_493:
            var val_447 = val_446;
            val_447 = val_447 + 1;
            val_448 = val_448 + val_447;
            var val_111 = val_448 + 296;
            label_495:
            var val_451 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_500;
            }
            
            var val_449 = mem[val_1] + 176;
            val_449 = val_449 + 8;
            label_499:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_498;
            }
            
            val_449 = val_449 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_499;
            }
            
            goto label_500;
            label_498:
            var val_450 = val_449;
            val_450 = val_450 + 1;
            val_451 = val_451 + val_450;
            var val_112 = val_451 + 296;
            label_500:
            var val_454 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_505;
            }
            
            var val_452 = mem[val_1] + 176;
            val_452 = val_452 + 8;
            label_504:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_503;
            }
            
            val_452 = val_452 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_504;
            }
            
            goto label_505;
            label_503:
            var val_453 = val_452;
            val_453 = val_453 + 1;
            val_454 = val_454 + val_453;
            var val_113 = val_454 + 296;
            label_505:
            var val_457 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_510;
            }
            
            var val_455 = mem[val_1] + 176;
            val_455 = val_455 + 8;
            label_509:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_508;
            }
            
            val_455 = val_455 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_509;
            }
            
            goto label_510;
            label_508:
            var val_456 = val_455;
            val_456 = val_456 + 1;
            val_457 = val_457 + val_456;
            var val_114 = val_457 + 296;
            label_510:
            var val_460 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_515;
            }
            
            var val_458 = mem[val_1] + 176;
            val_458 = val_458 + 8;
            label_514:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_513;
            }
            
            val_458 = val_458 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_514;
            }
            
            goto label_515;
            label_513:
            var val_459 = val_458;
            val_459 = val_459 + 1;
            val_460 = val_460 + val_459;
            var val_115 = val_460 + 296;
            label_515:
            var val_463 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_520;
            }
            
            var val_461 = mem[val_1] + 176;
            val_461 = val_461 + 8;
            label_519:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_518;
            }
            
            val_461 = val_461 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_519;
            }
            
            goto label_520;
            label_518:
            var val_462 = val_461;
            val_462 = val_462 + 1;
            val_463 = val_463 + val_462;
            var val_116 = val_463 + 296;
            label_520:
            var val_466 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_525;
            }
            
            var val_464 = mem[val_1] + 176;
            val_464 = val_464 + 8;
            label_524:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_523;
            }
            
            val_464 = val_464 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_524;
            }
            
            goto label_525;
            label_523:
            var val_465 = val_464;
            val_465 = val_465 + 1;
            val_466 = val_466 + val_465;
            var val_117 = val_466 + 296;
            label_525:
            string val_118 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha384.Id;
            var val_469 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_531;
            }
            
            var val_467 = mem[val_1] + 176;
            val_467 = val_467 + 8;
            label_530:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_529;
            }
            
            val_467 = val_467 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_530;
            }
            
            goto label_531;
            label_529:
            var val_468 = val_467;
            val_468 = val_468 + 1;
            val_469 = val_469 + val_468;
            var val_119 = val_469 + 296;
            label_531:
            var val_472 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_536;
            }
            
            var val_470 = mem[val_1] + 176;
            val_470 = val_470 + 8;
            label_535:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_534;
            }
            
            val_470 = val_470 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_535;
            }
            
            goto label_536;
            label_534:
            var val_471 = val_470;
            val_471 = val_471 + 1;
            val_472 = val_472 + val_471;
            var val_120 = val_472 + 296;
            label_536:
            var val_475 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_541;
            }
            
            var val_473 = mem[val_1] + 176;
            val_473 = val_473 + 8;
            label_540:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_539;
            }
            
            val_473 = val_473 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_540;
            }
            
            goto label_541;
            label_539:
            var val_474 = val_473;
            val_474 = val_474 + 1;
            val_475 = val_475 + val_474;
            var val_121 = val_475 + 296;
            label_541:
            var val_478 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_546;
            }
            
            var val_476 = mem[val_1] + 176;
            val_476 = val_476 + 8;
            label_545:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_544;
            }
            
            val_476 = val_476 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_545;
            }
            
            goto label_546;
            label_544:
            var val_477 = val_476;
            val_477 = val_477 + 1;
            val_478 = val_478 + val_477;
            var val_122 = val_478 + 296;
            label_546:
            var val_481 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_551;
            }
            
            var val_479 = mem[val_1] + 176;
            val_479 = val_479 + 8;
            label_550:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_549;
            }
            
            val_479 = val_479 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_550;
            }
            
            goto label_551;
            label_549:
            var val_480 = val_479;
            val_480 = val_480 + 1;
            val_481 = val_481 + val_480;
            var val_123 = val_481 + 296;
            label_551:
            var val_484 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_556;
            }
            
            var val_482 = mem[val_1] + 176;
            val_482 = val_482 + 8;
            label_555:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_554;
            }
            
            val_482 = val_482 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_555;
            }
            
            goto label_556;
            label_554:
            var val_483 = val_482;
            val_483 = val_483 + 1;
            val_484 = val_484 + val_483;
            var val_124 = val_484 + 296;
            label_556:
            var val_487 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_561;
            }
            
            var val_485 = mem[val_1] + 176;
            val_485 = val_485 + 8;
            label_560:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_559;
            }
            
            val_485 = val_485 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_560;
            }
            
            goto label_561;
            label_559:
            var val_486 = val_485;
            val_486 = val_486 + 1;
            val_487 = val_487 + val_486;
            var val_125 = val_487 + 296;
            label_561:
            string val_126 = Org.BouncyCastle.Asn1.Nist.NistObjectIdentifiers.DsaWithSha512.Id;
            var val_490 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_567;
            }
            
            var val_488 = mem[val_1] + 176;
            val_488 = val_488 + 8;
            label_566:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_565;
            }
            
            val_488 = val_488 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_566;
            }
            
            goto label_567;
            label_565:
            var val_489 = val_488;
            val_489 = val_489 + 1;
            val_490 = val_490 + val_489;
            var val_127 = val_490 + 296;
            label_567:
            var val_493 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_572;
            }
            
            var val_491 = mem[val_1] + 176;
            val_491 = val_491 + 8;
            label_571:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_570;
            }
            
            val_491 = val_491 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_571;
            }
            
            goto label_572;
            label_570:
            var val_492 = val_491;
            val_492 = val_492 + 1;
            val_493 = val_493 + val_492;
            var val_128 = val_493 + 296;
            label_572:
            var val_496 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_577;
            }
            
            var val_494 = mem[val_1] + 176;
            val_494 = val_494 + 8;
            label_576:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_575;
            }
            
            val_494 = val_494 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_576;
            }
            
            goto label_577;
            label_575:
            var val_495 = val_494;
            val_495 = val_495 + 1;
            val_496 = val_496 + val_495;
            var val_129 = val_496 + 296;
            label_577:
            var val_499 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_582;
            }
            
            var val_497 = mem[val_1] + 176;
            val_497 = val_497 + 8;
            label_581:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_580;
            }
            
            val_497 = val_497 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_581;
            }
            
            goto label_582;
            label_580:
            var val_498 = val_497;
            val_498 = val_498 + 1;
            val_499 = val_499 + val_498;
            var val_130 = val_499 + 296;
            label_582:
            var val_502 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_587;
            }
            
            var val_500 = mem[val_1] + 176;
            val_500 = val_500 + 8;
            label_586:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_585;
            }
            
            val_500 = val_500 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_586;
            }
            
            goto label_587;
            label_585:
            var val_501 = val_500;
            val_501 = val_501 + 1;
            val_502 = val_502 + val_501;
            var val_131 = val_502 + 296;
            label_587:
            var val_505 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_592;
            }
            
            var val_503 = mem[val_1] + 176;
            val_503 = val_503 + 8;
            label_591:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_590;
            }
            
            val_503 = val_503 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_591;
            }
            
            goto label_592;
            label_590:
            var val_504 = val_503;
            val_504 = val_504 + 1;
            val_505 = val_505 + val_504;
            var val_132 = val_505 + 296;
            label_592:
            var val_508 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_597;
            }
            
            var val_506 = mem[val_1] + 176;
            val_506 = val_506 + 8;
            label_596:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_595;
            }
            
            val_506 = val_506 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_596;
            }
            
            goto label_597;
            label_595:
            var val_507 = val_506;
            val_507 = val_507 + 1;
            val_508 = val_508 + val_507;
            var val_133 = val_508 + 296;
            label_597:
            var val_511 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_602;
            }
            
            var val_509 = mem[val_1] + 176;
            val_509 = val_509 + 8;
            label_601:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_600;
            }
            
            val_509 = val_509 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_601;
            }
            
            goto label_602;
            label_600:
            var val_510 = val_509;
            val_510 = val_510 + 1;
            val_511 = val_511 + val_510;
            var val_134 = val_511 + 296;
            label_602:
            var val_514 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_607;
            }
            
            var val_512 = mem[val_1] + 176;
            val_512 = val_512 + 8;
            label_606:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_605;
            }
            
            val_512 = val_512 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_606;
            }
            
            goto label_607;
            label_605:
            var val_513 = val_512;
            val_513 = val_513 + 1;
            val_514 = val_514 + val_513;
            var val_135 = val_514 + 296;
            label_607:
            var val_517 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_612;
            }
            
            var val_515 = mem[val_1] + 176;
            val_515 = val_515 + 8;
            label_611:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_610;
            }
            
            val_515 = val_515 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_611;
            }
            
            goto label_612;
            label_610:
            var val_516 = val_515;
            val_516 = val_516 + 1;
            val_517 = val_517 + val_516;
            var val_136 = val_517 + 296;
            label_612:
            string val_137 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1.Id;
            var val_520 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_618;
            }
            
            var val_518 = mem[val_1] + 176;
            val_518 = val_518 + 8;
            label_617:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_616;
            }
            
            val_518 = val_518 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_617;
            }
            
            goto label_618;
            label_616:
            var val_519 = val_518;
            val_519 = val_519 + 1;
            val_520 = val_520 + val_519;
            var val_138 = val_520 + 296;
            label_618:
            string val_139 = Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.ECSignWithSha1.Id;
            var val_523 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_624;
            }
            
            var val_521 = mem[val_1] + 176;
            val_521 = val_521 + 8;
            label_623:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_622;
            }
            
            val_521 = val_521 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_623;
            }
            
            goto label_624;
            label_622:
            var val_522 = val_521;
            val_522 = val_522 + 1;
            val_523 = val_523 + val_522;
            var val_140 = val_523 + 296;
            label_624:
            var val_526 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_629;
            }
            
            var val_524 = mem[val_1] + 176;
            val_524 = val_524 + 8;
            label_628:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_627;
            }
            
            val_524 = val_524 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_628;
            }
            
            goto label_629;
            label_627:
            var val_525 = val_524;
            val_525 = val_525 + 1;
            val_526 = val_526 + val_525;
            var val_141 = val_526 + 296;
            label_629:
            var val_529 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_634;
            }
            
            var val_527 = mem[val_1] + 176;
            val_527 = val_527 + 8;
            label_633:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_632;
            }
            
            val_527 = val_527 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_633;
            }
            
            goto label_634;
            label_632:
            var val_528 = val_527;
            val_528 = val_528 + 1;
            val_529 = val_529 + val_528;
            var val_142 = val_529 + 296;
            label_634:
            var val_532 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_639;
            }
            
            var val_530 = mem[val_1] + 176;
            val_530 = val_530 + 8;
            label_638:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_637;
            }
            
            val_530 = val_530 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_638;
            }
            
            goto label_639;
            label_637:
            var val_531 = val_530;
            val_531 = val_531 + 1;
            val_532 = val_532 + val_531;
            var val_143 = val_532 + 296;
            label_639:
            var val_535 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_644;
            }
            
            var val_533 = mem[val_1] + 176;
            val_533 = val_533 + 8;
            label_643:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_642;
            }
            
            val_533 = val_533 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_643;
            }
            
            goto label_644;
            label_642:
            var val_534 = val_533;
            val_534 = val_534 + 1;
            val_535 = val_535 + val_534;
            var val_144 = val_535 + 296;
            label_644:
            var val_538 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_649;
            }
            
            var val_536 = mem[val_1] + 176;
            val_536 = val_536 + 8;
            label_648:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_647;
            }
            
            val_536 = val_536 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_648;
            }
            
            goto label_649;
            label_647:
            var val_537 = val_536;
            val_537 = val_537 + 1;
            val_538 = val_538 + val_537;
            var val_145 = val_538 + 296;
            label_649:
            var val_541 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_654;
            }
            
            var val_539 = mem[val_1] + 176;
            val_539 = val_539 + 8;
            label_653:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_652;
            }
            
            val_539 = val_539 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_653;
            }
            
            goto label_654;
            label_652:
            var val_540 = val_539;
            val_540 = val_540 + 1;
            val_541 = val_541 + val_540;
            var val_146 = val_541 + 296;
            label_654:
            string val_147 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224.Id;
            var val_544 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_660;
            }
            
            var val_542 = mem[val_1] + 176;
            val_542 = val_542 + 8;
            label_659:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_658;
            }
            
            val_542 = val_542 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_659;
            }
            
            goto label_660;
            label_658:
            var val_543 = val_542;
            val_543 = val_543 + 1;
            val_544 = val_544 + val_543;
            var val_148 = val_544 + 296;
            label_660:
            var val_547 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_665;
            }
            
            var val_545 = mem[val_1] + 176;
            val_545 = val_545 + 8;
            label_664:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_663;
            }
            
            val_545 = val_545 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_664;
            }
            
            goto label_665;
            label_663:
            var val_546 = val_545;
            val_546 = val_546 + 1;
            val_547 = val_547 + val_546;
            var val_149 = val_547 + 296;
            label_665:
            var val_550 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_670;
            }
            
            var val_548 = mem[val_1] + 176;
            val_548 = val_548 + 8;
            label_669:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_668;
            }
            
            val_548 = val_548 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_669;
            }
            
            goto label_670;
            label_668:
            var val_549 = val_548;
            val_549 = val_549 + 1;
            val_550 = val_550 + val_549;
            var val_150 = val_550 + 296;
            label_670:
            var val_553 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_675;
            }
            
            var val_551 = mem[val_1] + 176;
            val_551 = val_551 + 8;
            label_674:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_673;
            }
            
            val_551 = val_551 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_674;
            }
            
            goto label_675;
            label_673:
            var val_552 = val_551;
            val_552 = val_552 + 1;
            val_553 = val_553 + val_552;
            var val_151 = val_553 + 296;
            label_675:
            var val_556 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_680;
            }
            
            var val_554 = mem[val_1] + 176;
            val_554 = val_554 + 8;
            label_679:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_678;
            }
            
            val_554 = val_554 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_679;
            }
            
            goto label_680;
            label_678:
            var val_555 = val_554;
            val_555 = val_555 + 1;
            val_556 = val_556 + val_555;
            var val_152 = val_556 + 296;
            label_680:
            var val_559 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_685;
            }
            
            var val_557 = mem[val_1] + 176;
            val_557 = val_557 + 8;
            label_684:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_683;
            }
            
            val_557 = val_557 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_684;
            }
            
            goto label_685;
            label_683:
            var val_558 = val_557;
            val_558 = val_558 + 1;
            val_559 = val_559 + val_558;
            var val_153 = val_559 + 296;
            label_685:
            var val_562 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_690;
            }
            
            var val_560 = mem[val_1] + 176;
            val_560 = val_560 + 8;
            label_689:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_688;
            }
            
            val_560 = val_560 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_689;
            }
            
            goto label_690;
            label_688:
            var val_561 = val_560;
            val_561 = val_561 + 1;
            val_562 = val_562 + val_561;
            var val_154 = val_562 + 296;
            label_690:
            string val_155 = Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256.Id;
            var val_565 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_696;
            }
            
            var val_563 = mem[val_1] + 176;
            val_563 = val_563 + 8;
            label_695:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_694;
            }
            
            val_563 = val_563 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_695;
            }
            
            goto label_696;
            label_694:
            var val_564 = val_563;
            val_564 = val_564 + 1;
            val_565 = val_565 + val_564;
            var val_156 = val_565 + 296;
            label_696:
            var val_568 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_701;
            }
            
            var val_566 = mem[val_1] + 176;
            val_566 = val_566 + 8;
            label_700:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_699;
            }
            
            val_566 = val_566 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_700;
            }
            
            goto label_701;
            label_699:
            var val_567 = val_566;
            val_567 = val_567 + 1;
            val_568 = val_568 + val_567;
            var val_157 = val_568 + 296;
            label_701:
            var val_571 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_706;
            }
            
            var val_569 = mem[val_1] + 176;
            val_569 = val_569 + 8;
            label_705:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_704;
            }
            
            val_569 = val_569 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_705;
            }
            
            goto label_706;
            label_704:
            var val_570 = val_569;
            val_570 = val_570 + 1;
            val_571 = val_571 + val_570;
            var val_158 = val_571 + 296;
            label_706:
            var val_574 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_711;
            }
            
            var val_572 = mem[val_1] + 176;
            val_572 = val_572 + 8;
            label_710:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_709;
            }
            
            val_572 = val_572 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_710;
            }
            
            goto label_711;
            label_709:
            var val_573 = val_572;
            val_573 = val_573 + 1;
            val_574 = val_574 + val_573;
            var val_159 = val_574 + 296;
            label_711:
            var val_577 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_716;
            }
            
            var val_575 = mem[val_1] + 176;
            val_575 = val_575 + 8;
            label_715:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_714;
            }
            
            val_575 = val_575 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_715;
            }
            
            goto label_716;
            label_714:
            var val_576 = val_575;
            val_576 = val_576 + 1;
            val_577 = val_577 + val_576;
            var val_160 = val_577 + 296;
            label_716:
            var val_580 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_721;
            }
            
            var val_578 = mem[val_1] + 176;
            val_578 = val_578 + 8;
            label_720:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_719;
            }
            
            val_578 = val_578 + 16;
            if(1 < (mem[val_1] + 286))
            {
                goto label_720;
            }
            
            goto label_721;
            label_719:
            var val_579 = val_578;
            val_579 = val_579 + 1;
            val_580 = val_580 + val_579;
            var val_161 = val_580 + 296;
            label_721:
            var val_584 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_726;
            }
            
            var val_581 = mem[val_1] + 176;
            var val_582 = 0;
            val_581 = val_581 + 8;
            label_725:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_724;
            }
            
            val_582 = val_582 + 1;
            val_581 = val_581 + 16;
            if(val_582 < (mem[val_1] + 286))
            {
                goto label_725;
            }
            
            goto label_726;
            label_724:
            var val_583 = val_581;
            val_583 = val_583 + 1;
            val_584 = val_584 + val_583;
            val_213 = val_584 + 296;
            label_726:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "SHA-384WITHECDSA", value:  "SHA-384withECDSA");
            var val_588 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_732;
            }
            
            var val_585 = mem[val_1] + 176;
            var val_586 = 0;
            val_585 = val_585 + 8;
            label_731:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_730;
            }
            
            val_586 = val_586 + 1;
            val_585 = val_585 + 16;
            if(val_586 < (mem[val_1] + 286))
            {
                goto label_731;
            }
            
            goto label_732;
            label_730:
            var val_587 = val_585;
            val_587 = val_587 + 1;
            val_588 = val_588 + val_587;
            val_214 = val_588 + 296;
            label_732:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384.Id, value:  "SHA-384withECDSA");
            var val_592 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_737;
            }
            
            var val_589 = mem[val_1] + 176;
            var val_590 = 0;
            val_589 = val_589 + 8;
            label_736:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_735;
            }
            
            val_590 = val_590 + 1;
            val_589 = val_589 + 16;
            if(val_590 < (mem[val_1] + 286))
            {
                goto label_736;
            }
            
            goto label_737;
            label_735:
            var val_591 = val_589;
            val_591 = val_591 + 1;
            val_592 = val_592 + val_591;
            val_215 = val_592 + 296;
            label_737:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "SHA512/ECDSA", value:  "SHA-512withECDSA");
            var val_596 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_742;
            }
            
            var val_593 = mem[val_1] + 176;
            var val_594 = 0;
            val_593 = val_593 + 8;
            label_741:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_740;
            }
            
            val_594 = val_594 + 1;
            val_593 = val_593 + 16;
            if(val_594 < (mem[val_1] + 286))
            {
                goto label_741;
            }
            
            goto label_742;
            label_740:
            var val_595 = val_593;
            val_595 = val_595 + 1;
            val_596 = val_596 + val_595;
            val_216 = val_596 + 296;
            label_742:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "SHA-512/ECDSA", value:  "SHA-512withECDSA");
            var val_600 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_747;
            }
            
            var val_597 = mem[val_1] + 176;
            var val_598 = 0;
            val_597 = val_597 + 8;
            label_746:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_745;
            }
            
            val_598 = val_598 + 1;
            val_597 = val_597 + 16;
            if(val_598 < (mem[val_1] + 286))
            {
                goto label_746;
            }
            
            goto label_747;
            label_745:
            var val_599 = val_597;
            val_599 = val_599 + 1;
            val_600 = val_600 + val_599;
            val_217 = val_600 + 296;
            label_747:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "ECDSAWITHSHA512", value:  "SHA-512withECDSA");
            var val_604 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_752;
            }
            
            var val_601 = mem[val_1] + 176;
            var val_602 = 0;
            val_601 = val_601 + 8;
            label_751:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_750;
            }
            
            val_602 = val_602 + 1;
            val_601 = val_601 + 16;
            if(val_602 < (mem[val_1] + 286))
            {
                goto label_751;
            }
            
            goto label_752;
            label_750:
            var val_603 = val_601;
            val_603 = val_603 + 1;
            val_604 = val_604 + val_603;
            val_218 = val_604 + 296;
            label_752:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "ECDSAWITHSHA-512", value:  "SHA-512withECDSA");
            var val_608 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_757;
            }
            
            var val_605 = mem[val_1] + 176;
            var val_606 = 0;
            val_605 = val_605 + 8;
            label_756:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_755;
            }
            
            val_606 = val_606 + 1;
            val_605 = val_605 + 16;
            if(val_606 < (mem[val_1] + 286))
            {
                goto label_756;
            }
            
            goto label_757;
            label_755:
            var val_607 = val_605;
            val_607 = val_607 + 1;
            val_608 = val_608 + val_607;
            val_219 = val_608 + 296;
            label_757:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "SHA512WITHECDSA", value:  "SHA-512withECDSA");
            var val_612 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_762;
            }
            
            var val_609 = mem[val_1] + 176;
            var val_610 = 0;
            val_609 = val_609 + 8;
            label_761:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_760;
            }
            
            val_610 = val_610 + 1;
            val_609 = val_609 + 16;
            if(val_610 < (mem[val_1] + 286))
            {
                goto label_761;
            }
            
            goto label_762;
            label_760:
            var val_611 = val_609;
            val_611 = val_611 + 1;
            val_612 = val_612 + val_611;
            val_220 = val_612 + 296;
            label_762:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "SHA-512WITHECDSA", value:  "SHA-512withECDSA");
            var val_616 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_768;
            }
            
            var val_613 = mem[val_1] + 176;
            var val_614 = 0;
            val_613 = val_613 + 8;
            label_767:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_766;
            }
            
            val_614 = val_614 + 1;
            val_613 = val_613 + 16;
            if(val_614 < (mem[val_1] + 286))
            {
                goto label_767;
            }
            
            goto label_768;
            label_766:
            var val_615 = val_613;
            val_615 = val_615 + 1;
            val_616 = val_616 + val_615;
            val_221 = val_616 + 296;
            label_768:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512.Id, value:  "SHA-512withECDSA");
            var val_620 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_773;
            }
            
            var val_617 = mem[val_1] + 176;
            var val_618 = 0;
            val_617 = val_617 + 8;
            label_772:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_771;
            }
            
            val_618 = val_618 + 1;
            val_617 = val_617 + 16;
            if(val_618 < (mem[val_1] + 286))
            {
                goto label_772;
            }
            
            goto label_773;
            label_771:
            var val_619 = val_617;
            val_619 = val_619 + 1;
            val_620 = val_620 + val_619;
            val_222 = val_620 + 296;
            label_773:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "RIPEMD160/ECDSA", value:  "RIPEMD160withECDSA");
            var val_624 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_778;
            }
            
            var val_621 = mem[val_1] + 176;
            var val_622 = 0;
            val_621 = val_621 + 8;
            label_777:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_776;
            }
            
            val_622 = val_622 + 1;
            val_621 = val_621 + 16;
            if(val_622 < (mem[val_1] + 286))
            {
                goto label_777;
            }
            
            goto label_778;
            label_776:
            var val_623 = val_621;
            val_623 = val_623 + 1;
            val_624 = val_624 + val_623;
            val_223 = val_624 + 296;
            label_778:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "ECDSAWITHRIPEMD160", value:  "RIPEMD160withECDSA");
            var val_628 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_783;
            }
            
            var val_625 = mem[val_1] + 176;
            var val_626 = 0;
            val_625 = val_625 + 8;
            label_782:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_781;
            }
            
            val_626 = val_626 + 1;
            val_625 = val_625 + 16;
            if(val_626 < (mem[val_1] + 286))
            {
                goto label_782;
            }
            
            goto label_783;
            label_781:
            var val_627 = val_625;
            val_627 = val_627 + 1;
            val_628 = val_628 + val_627;
            val_224 = val_628 + 296;
            label_783:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "RIPEMD160WITHECDSA", value:  "RIPEMD160withECDSA");
            var val_632 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_789;
            }
            
            var val_629 = mem[val_1] + 176;
            var val_630 = 0;
            val_629 = val_629 + 8;
            label_788:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_787;
            }
            
            val_630 = val_630 + 1;
            val_629 = val_629 + 16;
            if(val_630 < (mem[val_1] + 286))
            {
                goto label_788;
            }
            
            goto label_789;
            label_787:
            var val_631 = val_629;
            val_631 = val_631 + 1;
            val_632 = val_632 + val_631;
            val_225 = val_632 + 296;
            label_789:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.ECSignWithRipeMD160.Id, value:  "RIPEMD160withECDSA");
            var val_636 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_794;
            }
            
            var val_633 = mem[val_1] + 176;
            var val_634 = 0;
            val_633 = val_633 + 8;
            label_793:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_792;
            }
            
            val_634 = val_634 + 1;
            val_633 = val_633 + 16;
            if(val_634 < (mem[val_1] + 286))
            {
                goto label_793;
            }
            
            goto label_794;
            label_792:
            var val_635 = val_633;
            val_635 = val_635 + 1;
            val_636 = val_636 + val_635;
            val_226 = val_636 + 296;
            label_794:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "GOST-3410", value:  "GOST3410");
            var val_640 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_799;
            }
            
            var val_637 = mem[val_1] + 176;
            var val_638 = 0;
            val_637 = val_637 + 8;
            label_798:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_797;
            }
            
            val_638 = val_638 + 1;
            val_637 = val_637 + 16;
            if(val_638 < (mem[val_1] + 286))
            {
                goto label_798;
            }
            
            goto label_799;
            label_797:
            var val_639 = val_637;
            val_639 = val_639 + 1;
            val_640 = val_640 + val_639;
            val_227 = val_640 + 296;
            label_799:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "GOST-3410-94", value:  "GOST3410");
            var val_644 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_804;
            }
            
            var val_641 = mem[val_1] + 176;
            var val_642 = 0;
            val_641 = val_641 + 8;
            label_803:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_802;
            }
            
            val_642 = val_642 + 1;
            val_641 = val_641 + 16;
            if(val_642 < (mem[val_1] + 286))
            {
                goto label_803;
            }
            
            goto label_804;
            label_802:
            var val_643 = val_641;
            val_643 = val_643 + 1;
            val_644 = val_644 + val_643;
            val_228 = val_644 + 296;
            label_804:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "GOST3411WITHGOST3410", value:  "GOST3410");
            val_229 = null;
            val_229 = null;
            var val_648 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_812;
            }
            
            var val_645 = mem[val_1] + 176;
            var val_646 = 0;
            val_645 = val_645 + 8;
            label_811:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_810;
            }
            
            val_646 = val_646 + 1;
            val_645 = val_645 + 16;
            if(val_646 < (mem[val_1] + 286))
            {
                goto label_811;
            }
            
            goto label_812;
            label_810:
            var val_647 = val_645;
            val_647 = val_647 + 1;
            val_648 = val_648 + val_647;
            val_230 = val_648 + 296;
            label_812:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94.Id, value:  "GOST3410");
            var val_652 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_817;
            }
            
            var val_649 = mem[val_1] + 176;
            var val_650 = 0;
            val_649 = val_649 + 8;
            label_816:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_815;
            }
            
            val_650 = val_650 + 1;
            val_649 = val_649 + 16;
            if(val_650 < (mem[val_1] + 286))
            {
                goto label_816;
            }
            
            goto label_817;
            label_815:
            var val_651 = val_649;
            val_651 = val_651 + 1;
            val_652 = val_652 + val_651;
            val_231 = val_652 + 296;
            label_817:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "ECGOST-3410", value:  "ECGOST3410");
            var val_656 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_822;
            }
            
            var val_653 = mem[val_1] + 176;
            var val_654 = 0;
            val_653 = val_653 + 8;
            label_821:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_820;
            }
            
            val_654 = val_654 + 1;
            val_653 = val_653 + 16;
            if(val_654 < (mem[val_1] + 286))
            {
                goto label_821;
            }
            
            goto label_822;
            label_820:
            var val_655 = val_653;
            val_655 = val_655 + 1;
            val_656 = val_656 + val_655;
            val_232 = val_656 + 296;
            label_822:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "ECGOST-3410-2001", value:  "ECGOST3410");
            var val_660 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_827;
            }
            
            var val_657 = mem[val_1] + 176;
            var val_658 = 0;
            val_657 = val_657 + 8;
            label_826:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_825;
            }
            
            val_658 = val_658 + 1;
            val_657 = val_657 + 16;
            if(val_658 < (mem[val_1] + 286))
            {
                goto label_826;
            }
            
            goto label_827;
            label_825:
            var val_659 = val_657;
            val_659 = val_659 + 1;
            val_660 = val_660 + val_659;
            val_233 = val_660 + 296;
            label_827:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  "GOST3411WITHECGOST3410", value:  "ECGOST3410");
            var val_664 = mem[val_1];
            if((mem[val_1] + 286) == 0)
            {
                goto label_833;
            }
            
            var val_661 = mem[val_1] + 176;
            var val_662 = 0;
            val_661 = val_661 + 8;
            label_832:
            if(((mem[val_1] + 176 + 8) + -8) == null)
            {
                goto label_831;
            }
            
            val_662 = val_662 + 1;
            val_661 = val_661 + 16;
            if(val_662 < (mem[val_1] + 286))
            {
                goto label_832;
            }
            
            goto label_833;
            label_831:
            var val_663 = val_661;
            val_663 = val_663 + 1;
            val_664 = val_664 + val_663;
            val_234 = val_664 + 296;
            label_833:
            Org.BouncyCastle.Security.SignerUtilities.algorithms.set_Item(key:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001.Id, value:  "ECGOST3410");
            var val_668 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_838;
            }
            
            var val_665 = mem[val_2] + 176;
            var val_666 = 0;
            val_665 = val_665 + 8;
            label_837:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_836;
            }
            
            val_666 = val_666 + 1;
            val_665 = val_665 + 16;
            if(val_666 < (mem[val_2] + 286))
            {
                goto label_837;
            }
            
            goto label_838;
            label_836:
            var val_667 = val_665;
            val_667 = val_667 + 1;
            val_668 = val_668 + val_667;
            val_235 = val_668 + 296;
            label_838:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "MD2withRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD2WithRsaEncryption);
            var val_672 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_843;
            }
            
            var val_669 = mem[val_2] + 176;
            var val_670 = 0;
            val_669 = val_669 + 8;
            label_842:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_841;
            }
            
            val_670 = val_670 + 1;
            val_669 = val_669 + 16;
            if(val_670 < (mem[val_2] + 286))
            {
                goto label_842;
            }
            
            goto label_843;
            label_841:
            var val_671 = val_669;
            val_671 = val_671 + 1;
            val_672 = val_672 + val_671;
            val_236 = val_672 + 296;
            label_843:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "MD4withRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD4WithRsaEncryption);
            var val_676 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_848;
            }
            
            var val_673 = mem[val_2] + 176;
            var val_674 = 0;
            val_673 = val_673 + 8;
            label_847:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_846;
            }
            
            val_674 = val_674 + 1;
            val_673 = val_673 + 16;
            if(val_674 < (mem[val_2] + 286))
            {
                goto label_847;
            }
            
            goto label_848;
            label_846:
            var val_675 = val_673;
            val_675 = val_675 + 1;
            val_676 = val_676 + val_675;
            val_237 = val_676 + 296;
            label_848:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "MD5withRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.MD5WithRsaEncryption);
            var val_680 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_853;
            }
            
            var val_677 = mem[val_2] + 176;
            var val_678 = 0;
            val_677 = val_677 + 8;
            label_852:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_851;
            }
            
            val_678 = val_678 + 1;
            val_677 = val_677 + 16;
            if(val_678 < (mem[val_2] + 286))
            {
                goto label_852;
            }
            
            goto label_853;
            label_851:
            var val_679 = val_677;
            val_679 = val_679 + 1;
            val_680 = val_680 + val_679;
            val_238 = val_680 + 296;
            label_853:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-1withRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha1WithRsaEncryption);
            var val_684 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_858;
            }
            
            var val_681 = mem[val_2] + 176;
            var val_682 = 0;
            val_681 = val_681 + 8;
            label_857:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_856;
            }
            
            val_682 = val_682 + 1;
            val_681 = val_681 + 16;
            if(val_682 < (mem[val_2] + 286))
            {
                goto label_857;
            }
            
            goto label_858;
            label_856:
            var val_683 = val_681;
            val_683 = val_683 + 1;
            val_684 = val_684 + val_683;
            val_239 = val_684 + 296;
            label_858:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-224withRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha224WithRsaEncryption);
            var val_688 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_863;
            }
            
            var val_685 = mem[val_2] + 176;
            var val_686 = 0;
            val_685 = val_685 + 8;
            label_862:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_861;
            }
            
            val_686 = val_686 + 1;
            val_685 = val_685 + 16;
            if(val_686 < (mem[val_2] + 286))
            {
                goto label_862;
            }
            
            goto label_863;
            label_861:
            var val_687 = val_685;
            val_687 = val_687 + 1;
            val_688 = val_688 + val_687;
            val_240 = val_688 + 296;
            label_863:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-256withRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha256WithRsaEncryption);
            var val_692 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_868;
            }
            
            var val_689 = mem[val_2] + 176;
            var val_690 = 0;
            val_689 = val_689 + 8;
            label_867:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_866;
            }
            
            val_690 = val_690 + 1;
            val_689 = val_689 + 16;
            if(val_690 < (mem[val_2] + 286))
            {
                goto label_867;
            }
            
            goto label_868;
            label_866:
            var val_691 = val_689;
            val_691 = val_691 + 1;
            val_692 = val_692 + val_691;
            val_241 = val_692 + 296;
            label_868:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-384withRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha384WithRsaEncryption);
            var val_696 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_873;
            }
            
            var val_693 = mem[val_2] + 176;
            var val_694 = 0;
            val_693 = val_693 + 8;
            label_872:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_871;
            }
            
            val_694 = val_694 + 1;
            val_693 = val_693 + 16;
            if(val_694 < (mem[val_2] + 286))
            {
                goto label_872;
            }
            
            goto label_873;
            label_871:
            var val_695 = val_693;
            val_695 = val_695 + 1;
            val_696 = val_696 + val_695;
            val_242 = val_696 + 296;
            label_873:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-512withRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.Sha512WithRsaEncryption);
            var val_700 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_878;
            }
            
            var val_697 = mem[val_2] + 176;
            var val_698 = 0;
            val_697 = val_697 + 8;
            label_877:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_876;
            }
            
            val_698 = val_698 + 1;
            val_697 = val_697 + 16;
            if(val_698 < (mem[val_2] + 286))
            {
                goto label_877;
            }
            
            goto label_878;
            label_876:
            var val_699 = val_697;
            val_699 = val_699 + 1;
            val_700 = val_700 + val_699;
            val_243 = val_700 + 296;
            label_878:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "PSSwithRSA", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
            var val_704 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_883;
            }
            
            var val_701 = mem[val_2] + 176;
            var val_702 = 0;
            val_701 = val_701 + 8;
            label_882:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_881;
            }
            
            val_702 = val_702 + 1;
            val_701 = val_701 + 16;
            if(val_702 < (mem[val_2] + 286))
            {
                goto label_882;
            }
            
            goto label_883;
            label_881:
            var val_703 = val_701;
            val_703 = val_703 + 1;
            val_704 = val_704 + val_703;
            val_244 = val_704 + 296;
            label_883:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-1withRSAandMGF1", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
            var val_708 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_888;
            }
            
            var val_705 = mem[val_2] + 176;
            var val_706 = 0;
            val_705 = val_705 + 8;
            label_887:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_886;
            }
            
            val_706 = val_706 + 1;
            val_705 = val_705 + 16;
            if(val_706 < (mem[val_2] + 286))
            {
                goto label_887;
            }
            
            goto label_888;
            label_886:
            var val_707 = val_705;
            val_707 = val_707 + 1;
            val_708 = val_708 + val_707;
            val_245 = val_708 + 296;
            label_888:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-224withRSAandMGF1", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
            var val_712 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_893;
            }
            
            var val_709 = mem[val_2] + 176;
            var val_710 = 0;
            val_709 = val_709 + 8;
            label_892:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_891;
            }
            
            val_710 = val_710 + 1;
            val_709 = val_709 + 16;
            if(val_710 < (mem[val_2] + 286))
            {
                goto label_892;
            }
            
            goto label_893;
            label_891:
            var val_711 = val_709;
            val_711 = val_711 + 1;
            val_712 = val_712 + val_711;
            val_246 = val_712 + 296;
            label_893:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-256withRSAandMGF1", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
            var val_716 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_898;
            }
            
            var val_713 = mem[val_2] + 176;
            var val_714 = 0;
            val_713 = val_713 + 8;
            label_897:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_896;
            }
            
            val_714 = val_714 + 1;
            val_713 = val_713 + 16;
            if(val_714 < (mem[val_2] + 286))
            {
                goto label_897;
            }
            
            goto label_898;
            label_896:
            var val_715 = val_713;
            val_715 = val_715 + 1;
            val_716 = val_716 + val_715;
            val_247 = val_716 + 296;
            label_898:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-384withRSAandMGF1", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
            var val_720 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_903;
            }
            
            var val_717 = mem[val_2] + 176;
            var val_718 = 0;
            val_717 = val_717 + 8;
            label_902:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_901;
            }
            
            val_718 = val_718 + 1;
            val_717 = val_717 + 16;
            if(val_718 < (mem[val_2] + 286))
            {
                goto label_902;
            }
            
            goto label_903;
            label_901:
            var val_719 = val_717;
            val_719 = val_719 + 1;
            val_720 = val_720 + val_719;
            val_248 = val_720 + 296;
            label_903:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-512withRSAandMGF1", value:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdRsassaPss);
            var val_724 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_908;
            }
            
            var val_721 = mem[val_2] + 176;
            var val_722 = 0;
            val_721 = val_721 + 8;
            label_907:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_906;
            }
            
            val_722 = val_722 + 1;
            val_721 = val_721 + 16;
            if(val_722 < (mem[val_2] + 286))
            {
                goto label_907;
            }
            
            goto label_908;
            label_906:
            var val_723 = val_721;
            val_723 = val_723 + 1;
            val_724 = val_724 + val_723;
            val_249 = val_724 + 296;
            label_908:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "RIPEMD128withRSA", value:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD128);
            var val_728 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_913;
            }
            
            var val_725 = mem[val_2] + 176;
            var val_726 = 0;
            val_725 = val_725 + 8;
            label_912:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_911;
            }
            
            val_726 = val_726 + 1;
            val_725 = val_725 + 16;
            if(val_726 < (mem[val_2] + 286))
            {
                goto label_912;
            }
            
            goto label_913;
            label_911:
            var val_727 = val_725;
            val_727 = val_727 + 1;
            val_728 = val_728 + val_727;
            val_250 = val_728 + 296;
            label_913:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "RIPEMD160withRSA", value:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD160);
            var val_732 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_918;
            }
            
            var val_729 = mem[val_2] + 176;
            var val_730 = 0;
            val_729 = val_729 + 8;
            label_917:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_916;
            }
            
            val_730 = val_730 + 1;
            val_729 = val_729 + 16;
            if(val_730 < (mem[val_2] + 286))
            {
                goto label_917;
            }
            
            goto label_918;
            label_916:
            var val_731 = val_729;
            val_731 = val_731 + 1;
            val_732 = val_732 + val_731;
            val_251 = val_732 + 296;
            label_918:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "RIPEMD256withRSA", value:  Org.BouncyCastle.Asn1.TeleTrust.TeleTrusTObjectIdentifiers.RsaSignatureWithRipeMD256);
            var val_736 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_923;
            }
            
            var val_733 = mem[val_2] + 176;
            var val_734 = 0;
            val_733 = val_733 + 8;
            label_922:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_921;
            }
            
            val_734 = val_734 + 1;
            val_733 = val_733 + 16;
            if(val_734 < (mem[val_2] + 286))
            {
                goto label_922;
            }
            
            goto label_923;
            label_921:
            var val_735 = val_733;
            val_735 = val_735 + 1;
            val_736 = val_736 + val_735;
            val_252 = val_736 + 296;
            label_923:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-1withDSA", value:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.IdDsaWithSha1);
            var val_740 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_928;
            }
            
            var val_737 = mem[val_2] + 176;
            var val_738 = 0;
            val_737 = val_737 + 8;
            label_927:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_926;
            }
            
            val_738 = val_738 + 1;
            val_737 = val_737 + 16;
            if(val_738 < (mem[val_2] + 286))
            {
                goto label_927;
            }
            
            goto label_928;
            label_926:
            var val_739 = val_737;
            val_739 = val_739 + 1;
            val_740 = val_740 + val_739;
            val_253 = val_740 + 296;
            label_928:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-1withECDSA", value:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha1);
            var val_744 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_933;
            }
            
            var val_741 = mem[val_2] + 176;
            var val_742 = 0;
            val_741 = val_741 + 8;
            label_932:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_931;
            }
            
            val_742 = val_742 + 1;
            val_741 = val_741 + 16;
            if(val_742 < (mem[val_2] + 286))
            {
                goto label_932;
            }
            
            goto label_933;
            label_931:
            var val_743 = val_741;
            val_743 = val_743 + 1;
            val_744 = val_744 + val_743;
            val_254 = val_744 + 296;
            label_933:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-224withECDSA", value:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha224);
            var val_748 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_938;
            }
            
            var val_745 = mem[val_2] + 176;
            var val_746 = 0;
            val_745 = val_745 + 8;
            label_937:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_936;
            }
            
            val_746 = val_746 + 1;
            val_745 = val_745 + 16;
            if(val_746 < (mem[val_2] + 286))
            {
                goto label_937;
            }
            
            goto label_938;
            label_936:
            var val_747 = val_745;
            val_747 = val_747 + 1;
            val_748 = val_748 + val_747;
            val_255 = val_748 + 296;
            label_938:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-256withECDSA", value:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha256);
            var val_752 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_943;
            }
            
            var val_749 = mem[val_2] + 176;
            var val_750 = 0;
            val_749 = val_749 + 8;
            label_942:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_941;
            }
            
            val_750 = val_750 + 1;
            val_749 = val_749 + 16;
            if(val_750 < (mem[val_2] + 286))
            {
                goto label_942;
            }
            
            goto label_943;
            label_941:
            var val_751 = val_749;
            val_751 = val_751 + 1;
            val_752 = val_752 + val_751;
            val_256 = val_752 + 296;
            label_943:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-384withECDSA", value:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha384);
            var val_756 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_948;
            }
            
            var val_753 = mem[val_2] + 176;
            var val_754 = 0;
            val_753 = val_753 + 8;
            label_947:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_946;
            }
            
            val_754 = val_754 + 1;
            val_753 = val_753 + 16;
            if(val_754 < (mem[val_2] + 286))
            {
                goto label_947;
            }
            
            goto label_948;
            label_946:
            var val_755 = val_753;
            val_755 = val_755 + 1;
            val_756 = val_756 + val_755;
            val_257 = val_756 + 296;
            label_948:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "SHA-512withECDSA", value:  Org.BouncyCastle.Asn1.X9.X9ObjectIdentifiers.ECDsaWithSha512);
            var val_760 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_953;
            }
            
            var val_757 = mem[val_2] + 176;
            var val_758 = 0;
            val_757 = val_757 + 8;
            label_952:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_951;
            }
            
            val_758 = val_758 + 1;
            val_757 = val_757 + 16;
            if(val_758 < (mem[val_2] + 286))
            {
                goto label_952;
            }
            
            goto label_953;
            label_951:
            var val_759 = val_757;
            val_759 = val_759 + 1;
            val_760 = val_760 + val_759;
            val_258 = val_760 + 296;
            label_953:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "GOST3410", value:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x94);
            var val_764 = mem[val_2];
            if((mem[val_2] + 286) == 0)
            {
                goto label_958;
            }
            
            var val_761 = mem[val_2] + 176;
            var val_762 = 0;
            val_761 = val_761 + 8;
            label_957:
            if(((mem[val_2] + 176 + 8) + -8) == null)
            {
                goto label_956;
            }
            
            val_762 = val_762 + 1;
            val_761 = val_761 + 16;
            if(val_762 < (mem[val_2] + 286))
            {
                goto label_957;
            }
            
            goto label_958;
            label_956:
            var val_763 = val_761;
            val_763 = val_763 + 1;
            val_764 = val_764 + val_763;
            val_259 = val_764 + 296;
            label_958:
            Org.BouncyCastle.Security.SignerUtilities.oids.set_Item(key:  "ECGOST3410", value:  Org.BouncyCastle.Asn1.CryptoPro.CryptoProObjectIdentifiers.GostR3411x94WithGostR3410x2001);
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
                val_11 = Org.BouncyCastle.Security.SignerUtilities.algorithms;
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
                val_14 = Org.BouncyCastle.Security.SignerUtilities.oids;
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
            return Org.BouncyCastle.Security.SignerUtilities.oids.Keys;
        }
        public static Org.BouncyCastle.Asn1.Asn1Encodable GetDefaultX509Parameters(Org.BouncyCastle.Asn1.DerObjectIdentifier id)
        {
            return Org.BouncyCastle.Security.SignerUtilities.GetDefaultX509Parameters(algorithm:  id.Id);
        }
        public static Org.BouncyCastle.Asn1.Asn1Encodable GetDefaultX509Parameters(string algorithm)
        {
            var val_14;
            var val_15;
            var val_17;
            string val_18;
            Org.BouncyCastle.Asn1.DerNull val_19;
            var val_20;
            var val_21;
            if(algorithm != null)
            {
                    val_14 = 1152921505509666816;
                string val_1 = Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  algorithm);
                val_15 = null;
                val_15 = null;
                var val_15 = 0;
                val_15 = val_15 + 1;
                val_17 = Org.BouncyCastle.Security.SignerUtilities.algorithms;
                if((val_17.Item[val_1] != null) && (null != null))
            {
                    val_17 = 0;
            }
            
                string val_5 = (val_17 == 0) ? (val_1) : (val_17);
                if((System.String.op_Equality(a:  val_5, b:  "PSSwithRSA")) != false)
            {
                    Org.BouncyCastle.Asn1.Asn1Encodable val_7 = Org.BouncyCastle.Security.SignerUtilities.GetPssX509Parameters(digestName:  "SHA-1");
                return (Org.BouncyCastle.Asn1.Asn1Encodable)val_19;
            }
            
                val_14 = "withRSAandMGF1";
                if((Org.BouncyCastle.Utilities.Platform.EndsWith(source:  val_5, suffix:  "withRSAandMGF1")) != false)
            {
                    val_20 = "withRSAandMGF1";
                if("withRSAandMGF1" == null)
            {
                    val_20 = "withRSAandMGF1";
            }
            
                val_14 = Length;
                val_18 = val_5.Substring(startIndex:  0, length:  val_5.Length - val_14);
                Org.BouncyCastle.Asn1.Asn1Encodable val_13 = Org.BouncyCastle.Security.SignerUtilities.GetPssX509Parameters(digestName:  val_18);
                return (Org.BouncyCastle.Asn1.Asn1Encodable)val_19;
            }
            
                val_18 = 1152921505543159808;
                val_21 = null;
                val_21 = null;
                val_19 = Org.BouncyCastle.Asn1.DerNull.Instance;
                return (Org.BouncyCastle.Asn1.Asn1Encodable)val_19;
            }
            
            System.ArgumentNullException val_14 = new System.ArgumentNullException(paramName:  "algorithm");
        }
        private static Org.BouncyCastle.Asn1.Asn1Encodable GetPssX509Parameters(string digestName)
        {
            var val_9;
            var val_10;
            val_9 = null;
            val_9 = null;
            Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier val_2 = new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(algorithm:  Org.BouncyCastle.Security.DigestUtilities.GetObjectIdentifier(mechanism:  digestName), parameters:  Org.BouncyCastle.Asn1.DerNull.Instance);
            val_10 = null;
            val_10 = null;
            var val_10 = 0;
            val_10 = val_10 + 1;
            return (Org.BouncyCastle.Asn1.Asn1Encodable)new Org.BouncyCastle.Asn1.Pkcs.RsassaPssParameters(hashAlgorithm:  val_2, maskGenAlgorithm:  new Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier(algorithm:  Org.BouncyCastle.Asn1.Pkcs.PkcsObjectIdentifiers.IdMgf1, parameters:  val_2), saltLength:  new Org.BouncyCastle.Asn1.DerInteger(value:  Org.BouncyCastle.Security.DigestUtilities.GetDigest(algorithm:  digestName).GetDigestSize()), trailerField:  new Org.BouncyCastle.Asn1.DerInteger(value:  1));
        }
        public static Org.BouncyCastle.Crypto.ISigner GetSigner(Org.BouncyCastle.Asn1.DerObjectIdentifier id)
        {
            return Org.BouncyCastle.Security.SignerUtilities.GetSigner(algorithm:  id.Id);
        }
        public static Org.BouncyCastle.Crypto.ISigner GetSigner(string algorithm)
        {
            object val_132;
            var val_133;
            var val_135;
            var val_136;
            Org.BouncyCastle.Crypto.IDigest val_137;
            Org.BouncyCastle.Crypto.IDsa val_138;
            Org.BouncyCastle.Crypto.IDigest val_139;
            Org.BouncyCastle.Crypto.IDsa val_140;
            Org.BouncyCastle.Crypto.IAsymmetricBlockCipher val_141;
            Org.BouncyCastle.Crypto.IDigest val_142;
            var val_143;
            var val_144;
            var val_145;
            if(algorithm == null)
            {
                goto label_1;
            }
            
            val_132 = Org.BouncyCastle.Utilities.Platform.ToUpperInvariant(s:  algorithm);
            val_133 = null;
            val_133 = null;
            var val_132 = 0;
            val_132 = val_132 + 1;
            val_135 = Org.BouncyCastle.Security.SignerUtilities.algorithms;
            if((val_135.Item[val_132] != null) && (null != null))
            {
                    val_135 = 0;
            }
            
            var val_5 = (val_135 == 0) ? (val_132) : (val_135);
            if((val_5.Equals(value:  "RSA")) != false)
            {
                    Org.BouncyCastle.Crypto.Signers.RsaDigestSigner val_8 = null;
                val_136 = val_8;
                val_8 = new Org.BouncyCastle.Crypto.Signers.RsaDigestSigner(digest:  new Org.BouncyCastle.Crypto.Digests.NullDigest(), algId:  0);
                return (Org.BouncyCastle.Crypto.ISigner)val_136;
            }
            
            if((val_5.Equals(value:  "MD2withRSA")) == false)
            {
                goto label_17;
            }
            
            Org.BouncyCastle.Crypto.Digests.MD2Digest val_10 = null;
            val_137 = val_10;
            val_10 = new Org.BouncyCastle.Crypto.Digests.MD2Digest();
            goto label_45;
            label_17:
            if((val_5.Equals(value:  "MD4withRSA")) == false)
            {
                goto label_20;
            }
            
            Org.BouncyCastle.Crypto.Digests.MD4Digest val_12 = null;
            val_137 = val_12;
            val_12 = new Org.BouncyCastle.Crypto.Digests.MD4Digest();
            goto label_45;
            label_20:
            if((val_5.Equals(value:  "MD5withRSA")) == false)
            {
                goto label_23;
            }
            
            Org.BouncyCastle.Crypto.Digests.MD5Digest val_14 = null;
            val_137 = val_14;
            val_14 = new Org.BouncyCastle.Crypto.Digests.MD5Digest();
            goto label_45;
            label_23:
            if((val_5.Equals(value:  "SHA-1withRSA")) == false)
            {
                goto label_26;
            }
            
            Org.BouncyCastle.Crypto.Digests.Sha1Digest val_16 = null;
            val_137 = val_16;
            val_16 = new Org.BouncyCastle.Crypto.Digests.Sha1Digest();
            goto label_45;
            label_26:
            if((val_5.Equals(value:  "SHA-224withRSA")) == false)
            {
                goto label_29;
            }
            
            Org.BouncyCastle.Crypto.Digests.Sha224Digest val_18 = null;
            val_137 = val_18;
            val_18 = new Org.BouncyCastle.Crypto.Digests.Sha224Digest();
            goto label_45;
            label_29:
            if((val_5.Equals(value:  "SHA-256withRSA")) == false)
            {
                goto label_32;
            }
            
            Org.BouncyCastle.Crypto.Digests.Sha256Digest val_20 = null;
            val_137 = val_20;
            val_20 = new Org.BouncyCastle.Crypto.Digests.Sha256Digest();
            goto label_45;
            label_32:
            if((val_5.Equals(value:  "SHA-384withRSA")) == false)
            {
                goto label_35;
            }
            
            Org.BouncyCastle.Crypto.Digests.Sha384Digest val_22 = null;
            val_137 = val_22;
            val_22 = new Org.BouncyCastle.Crypto.Digests.Sha384Digest();
            goto label_45;
            label_35:
            if((val_5.Equals(value:  "SHA-512withRSA")) == false)
            {
                goto label_38;
            }
            
            Org.BouncyCastle.Crypto.Digests.Sha512Digest val_24 = null;
            val_137 = val_24;
            val_24 = new Org.BouncyCastle.Crypto.Digests.Sha512Digest();
            goto label_45;
            label_38:
            if((val_5.Equals(value:  "RIPEMD128withRSA")) == false)
            {
                goto label_41;
            }
            
            Org.BouncyCastle.Crypto.Digests.RipeMD128Digest val_26 = null;
            val_137 = val_26;
            val_26 = new Org.BouncyCastle.Crypto.Digests.RipeMD128Digest();
            goto label_45;
            label_41:
            if((val_5.Equals(value:  "RIPEMD160withRSA")) == false)
            {
                goto label_44;
            }
            
            Org.BouncyCastle.Crypto.Digests.RipeMD160Digest val_28 = null;
            val_137 = val_28;
            val_28 = new Org.BouncyCastle.Crypto.Digests.RipeMD160Digest();
            goto label_45;
            label_44:
            if((val_5.Equals(value:  "RIPEMD256withRSA")) == false)
            {
                goto label_47;
            }
            
            Org.BouncyCastle.Crypto.Digests.RipeMD256Digest val_30 = null;
            val_137 = val_30;
            val_30 = new Org.BouncyCastle.Crypto.Digests.RipeMD256Digest();
            label_45:
            Org.BouncyCastle.Crypto.Signers.RsaDigestSigner val_31 = null;
            val_136 = val_31;
            val_31 = new Org.BouncyCastle.Crypto.Signers.RsaDigestSigner(digest:  val_30);
            return (Org.BouncyCastle.Crypto.ISigner)val_136;
            label_47:
            if((val_5.Equals(value:  "RAWRSASSA-PSS")) != false)
            {
                    Org.BouncyCastle.Crypto.Signers.PssSigner val_35 = Org.BouncyCastle.Crypto.Signers.PssSigner.CreateRawSigner(cipher:  new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(), digest:  new Org.BouncyCastle.Crypto.Digests.Sha1Digest());
                return (Org.BouncyCastle.Crypto.ISigner)val_136;
            }
            
            if((val_5.Equals(value:  "PSSwithRSA")) != true)
            {
                    if((val_5.Equals(value:  "SHA-1withRSAandMGF1")) == false)
            {
                goto label_54;
            }
            
            }
            
            label_67:
            Org.BouncyCastle.Crypto.Signers.PssSigner val_40 = new Org.BouncyCastle.Crypto.Signers.PssSigner(cipher:  new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(), digest:  new Org.BouncyCastle.Crypto.Digests.Sha1Digest());
            return (Org.BouncyCastle.Crypto.ISigner)val_136;
            label_54:
            if((val_5.Equals(value:  "SHA-224withRSAandMGF1")) == false)
            {
                goto label_57;
            }
            
            Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine val_42 = new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine();
            Org.BouncyCastle.Crypto.Digests.Sha224Digest val_43 = new Org.BouncyCastle.Crypto.Digests.Sha224Digest();
            goto label_67;
            label_57:
            if((val_5.Equals(value:  "SHA-256withRSAandMGF1")) == false)
            {
                goto label_60;
            }
            
            Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine val_45 = new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine();
            Org.BouncyCastle.Crypto.Digests.Sha256Digest val_46 = new Org.BouncyCastle.Crypto.Digests.Sha256Digest();
            goto label_67;
            label_60:
            if((val_5.Equals(value:  "SHA-384withRSAandMGF1")) == false)
            {
                goto label_63;
            }
            
            Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine val_48 = new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine();
            Org.BouncyCastle.Crypto.Digests.Sha384Digest val_49 = new Org.BouncyCastle.Crypto.Digests.Sha384Digest();
            goto label_67;
            label_63:
            if((val_5.Equals(value:  "SHA-512withRSAandMGF1")) == false)
            {
                goto label_66;
            }
            
            Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine val_51 = new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine();
            Org.BouncyCastle.Crypto.Digests.Sha512Digest val_52 = new Org.BouncyCastle.Crypto.Digests.Sha512Digest();
            goto label_67;
            label_66:
            if((val_5.Equals(value:  "NONEwithDSA")) == false)
            {
                goto label_69;
            }
            
            Org.BouncyCastle.Crypto.Signers.DsaSigner val_54 = null;
            val_138 = val_54;
            val_54 = new Org.BouncyCastle.Crypto.Signers.DsaSigner();
            label_88:
            Org.BouncyCastle.Crypto.Digests.NullDigest val_55 = null;
            val_139 = val_55;
            val_55 = new Org.BouncyCastle.Crypto.Digests.NullDigest();
            goto label_106;
            label_1:
            System.ArgumentNullException val_56 = null;
            val_132 = val_56;
            val_56 = new System.ArgumentNullException(paramName:  "algorithm");
            label_155:
            label_69:
            if((Equals(value:  "SHA-1withDSA")) == false)
            {
                goto label_72;
            }
            
            Org.BouncyCastle.Crypto.Signers.DsaSigner val_58 = null;
            val_138 = val_58;
            val_58 = new Org.BouncyCastle.Crypto.Signers.DsaSigner();
            label_109:
            Org.BouncyCastle.Crypto.Digests.Sha1Digest val_59 = null;
            val_139 = val_59;
            val_59 = new Org.BouncyCastle.Crypto.Digests.Sha1Digest();
            goto label_106;
            label_72:
            if((Equals(value:  "SHA-224withDSA")) == false)
            {
                goto label_75;
            }
            
            Org.BouncyCastle.Crypto.Signers.DsaSigner val_61 = null;
            val_138 = val_61;
            val_61 = new Org.BouncyCastle.Crypto.Signers.DsaSigner();
            label_112:
            Org.BouncyCastle.Crypto.Digests.Sha224Digest val_62 = null;
            val_139 = val_62;
            val_62 = new Org.BouncyCastle.Crypto.Digests.Sha224Digest();
            goto label_106;
            label_75:
            if((Equals(value:  "SHA-256withDSA")) == false)
            {
                goto label_78;
            }
            
            Org.BouncyCastle.Crypto.Signers.DsaSigner val_64 = null;
            val_138 = val_64;
            val_64 = new Org.BouncyCastle.Crypto.Signers.DsaSigner();
            label_115:
            Org.BouncyCastle.Crypto.Digests.Sha256Digest val_65 = null;
            val_139 = val_65;
            val_65 = new Org.BouncyCastle.Crypto.Digests.Sha256Digest();
            goto label_106;
            label_78:
            if((Equals(value:  "SHA-384withDSA")) == false)
            {
                goto label_81;
            }
            
            Org.BouncyCastle.Crypto.Signers.DsaSigner val_67 = null;
            val_138 = val_67;
            val_67 = new Org.BouncyCastle.Crypto.Signers.DsaSigner();
            label_118:
            Org.BouncyCastle.Crypto.Digests.Sha384Digest val_68 = null;
            val_139 = val_68;
            val_68 = new Org.BouncyCastle.Crypto.Digests.Sha384Digest();
            goto label_106;
            label_81:
            if((Equals(value:  "SHA-512withDSA")) == false)
            {
                goto label_84;
            }
            
            Org.BouncyCastle.Crypto.Signers.DsaSigner val_70 = null;
            val_138 = val_70;
            val_70 = new Org.BouncyCastle.Crypto.Signers.DsaSigner();
            label_121:
            Org.BouncyCastle.Crypto.Digests.Sha512Digest val_71 = null;
            val_139 = val_71;
            val_71 = new Org.BouncyCastle.Crypto.Digests.Sha512Digest();
            label_106:
            Org.BouncyCastle.Crypto.Signers.DsaDigestSigner val_72 = new Org.BouncyCastle.Crypto.Signers.DsaDigestSigner(signer:  val_70, digest:  val_71);
            return (Org.BouncyCastle.Crypto.ISigner)val_136;
            label_84:
            if((Equals(value:  "NONEwithECDSA")) == false)
            {
                goto label_87;
            }
            
            Org.BouncyCastle.Crypto.Signers.ECDsaSigner val_74 = new Org.BouncyCastle.Crypto.Signers.ECDsaSigner();
            goto label_88;
            label_87:
            if((Equals(value:  "SHA-1withECDSA")) == false)
            {
                goto label_90;
            }
            
            Org.BouncyCastle.Crypto.Signers.ECDsaSigner val_76 = new Org.BouncyCastle.Crypto.Signers.ECDsaSigner();
            goto label_109;
            label_90:
            if((Equals(value:  "SHA-224withECDSA")) == false)
            {
                goto label_93;
            }
            
            Org.BouncyCastle.Crypto.Signers.ECDsaSigner val_78 = new Org.BouncyCastle.Crypto.Signers.ECDsaSigner();
            goto label_112;
            label_93:
            if((Equals(value:  "SHA-256withECDSA")) == false)
            {
                goto label_96;
            }
            
            Org.BouncyCastle.Crypto.Signers.ECDsaSigner val_80 = new Org.BouncyCastle.Crypto.Signers.ECDsaSigner();
            goto label_115;
            label_96:
            if((Equals(value:  "SHA-384withECDSA")) == false)
            {
                goto label_99;
            }
            
            Org.BouncyCastle.Crypto.Signers.ECDsaSigner val_82 = new Org.BouncyCastle.Crypto.Signers.ECDsaSigner();
            goto label_118;
            label_99:
            if((Equals(value:  "SHA-512withECDSA")) == false)
            {
                goto label_102;
            }
            
            Org.BouncyCastle.Crypto.Signers.ECDsaSigner val_84 = new Org.BouncyCastle.Crypto.Signers.ECDsaSigner();
            goto label_121;
            label_102:
            if((Equals(value:  "RIPEMD160withECDSA")) == false)
            {
                goto label_105;
            }
            
            Org.BouncyCastle.Crypto.Signers.ECDsaSigner val_86 = new Org.BouncyCastle.Crypto.Signers.ECDsaSigner();
            Org.BouncyCastle.Crypto.Digests.RipeMD160Digest val_87 = new Org.BouncyCastle.Crypto.Digests.RipeMD160Digest();
            goto label_106;
            label_105:
            if((Equals(value:  "SHA1WITHECNR")) == false)
            {
                goto label_108;
            }
            
            Org.BouncyCastle.Crypto.Signers.ECNRSigner val_89 = new Org.BouncyCastle.Crypto.Signers.ECNRSigner();
            goto label_109;
            label_108:
            if((Equals(value:  "SHA224WITHECNR")) == false)
            {
                goto label_111;
            }
            
            Org.BouncyCastle.Crypto.Signers.ECNRSigner val_91 = new Org.BouncyCastle.Crypto.Signers.ECNRSigner();
            goto label_112;
            label_111:
            if((Equals(value:  "SHA256WITHECNR")) == false)
            {
                goto label_114;
            }
            
            Org.BouncyCastle.Crypto.Signers.ECNRSigner val_93 = new Org.BouncyCastle.Crypto.Signers.ECNRSigner();
            goto label_115;
            label_114:
            if((Equals(value:  "SHA384WITHECNR")) == false)
            {
                goto label_117;
            }
            
            Org.BouncyCastle.Crypto.Signers.ECNRSigner val_95 = new Org.BouncyCastle.Crypto.Signers.ECNRSigner();
            goto label_118;
            label_117:
            if((Equals(value:  "SHA512WITHECNR")) == false)
            {
                goto label_120;
            }
            
            Org.BouncyCastle.Crypto.Signers.ECNRSigner val_97 = new Org.BouncyCastle.Crypto.Signers.ECNRSigner();
            goto label_121;
            label_120:
            if((Equals(value:  "GOST3410")) == false)
            {
                goto label_123;
            }
            
            Org.BouncyCastle.Crypto.Signers.Gost3410Signer val_99 = null;
            val_140 = val_99;
            val_99 = new Org.BouncyCastle.Crypto.Signers.Gost3410Signer();
            goto label_124;
            label_123:
            if((Equals(value:  "ECGOST3410")) == false)
            {
                goto label_126;
            }
            
            Org.BouncyCastle.Crypto.Signers.ECGost3410Signer val_101 = null;
            val_140 = val_101;
            val_101 = new Org.BouncyCastle.Crypto.Signers.ECGost3410Signer();
            label_124:
            Org.BouncyCastle.Crypto.Signers.Gost3410DigestSigner val_103 = new Org.BouncyCastle.Crypto.Signers.Gost3410DigestSigner(signer:  val_101, digest:  new Org.BouncyCastle.Crypto.Digests.Gost3411Digest());
            return (Org.BouncyCastle.Crypto.ISigner)val_136;
            label_126:
            if((Equals(value:  "SHA1WITHRSA/ISO9796-2")) == false)
            {
                goto label_129;
            }
            
            Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine val_105 = null;
            val_141 = val_105;
            val_105 = new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine();
            Org.BouncyCastle.Crypto.Digests.Sha1Digest val_106 = null;
            val_142 = val_106;
            val_106 = new Org.BouncyCastle.Crypto.Digests.Sha1Digest();
            goto label_133;
            label_129:
            if((Equals(value:  "MD5WITHRSA/ISO9796-2")) == false)
            {
                goto label_132;
            }
            
            Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine val_108 = null;
            val_141 = val_108;
            val_108 = new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine();
            Org.BouncyCastle.Crypto.Digests.MD5Digest val_109 = null;
            val_142 = val_109;
            val_109 = new Org.BouncyCastle.Crypto.Digests.MD5Digest();
            goto label_133;
            label_132:
            if((Equals(value:  "RIPEMD160WITHRSA/ISO9796-2")) == false)
            {
                goto label_135;
            }
            
            Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine val_111 = null;
            val_141 = val_111;
            val_111 = new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine();
            Org.BouncyCastle.Crypto.Digests.RipeMD160Digest val_112 = null;
            val_142 = val_112;
            val_112 = new Org.BouncyCastle.Crypto.Digests.RipeMD160Digest();
            label_133:
            Org.BouncyCastle.Crypto.Signers.Iso9796d2Signer val_113 = new Org.BouncyCastle.Crypto.Signers.Iso9796d2Signer(cipher:  val_111, digest:  val_112, isImplicit:  true);
            return (Org.BouncyCastle.Crypto.ISigner)val_136;
            label_135:
            if((Org.BouncyCastle.Utilities.Platform.EndsWith(source:  137166848, suffix:  "/X9.31")) != false)
            {
                    val_143 = "/X9.31";
                if(("/X9.31") == null)
            {
                    val_143 = "/X9.31";
            }
            
                int val_133 = Length;
                string val_118 = Substring(startIndex:  0, length:  Length - val_133);
                int val_119 = Org.BouncyCastle.Utilities.Platform.IndexOf(source:  val_118, value:  "WITH");
                if(val_119 >= 1)
            {
                    val_144 = "WITH";
                if("WITH" == null)
            {
                    val_144 = "WITH";
            }
            
                val_133 = Length + val_119;
                if(val_118 != null)
            {
                    val_145 = val_118.Length;
            }
            else
            {
                    val_145 = 0.Length;
            }
            
                if((val_118.Substring(startIndex:  val_133, length:  val_145 - val_133).Equals(value:  X22)) != false)
            {
                    Org.BouncyCastle.Crypto.Signers.X931Signer val_129 = new Org.BouncyCastle.Crypto.Signers.X931Signer(cipher:  new Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(), digest:  Org.BouncyCastle.Security.DigestUtilities.GetDigest(algorithm:  val_118.Substring(startIndex:  0, length:  val_119)));
                return (Org.BouncyCastle.Crypto.ISigner)val_136;
            }
            
            }
            
            }
            
            Org.BouncyCastle.Security.SecurityUtilityException val_131 = new Org.BouncyCastle.Security.SecurityUtilityException(message:  "Signer " + val_56 + " not recognised.");
            goto label_155;
        }
        public static string GetEncodingName(Org.BouncyCastle.Asn1.DerObjectIdentifier oid)
        {
            var val_4;
            var val_6;
            val_4 = null;
            val_4 = null;
            var val_5 = 0;
            val_5 = val_5 + 1;
            val_6 = Org.BouncyCastle.Security.SignerUtilities.algorithms;
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
    
    }

}
