using UnityEngine;

namespace Org.BouncyCastle.Asn1.Utilities
{
    public sealed class Asn1Dump
    {
        // Fields
        private static readonly string NewLine;
        private const string Tab = "    ";
        private const int SampleSize = 32;
        
        // Methods
        private Asn1Dump()
        {
        
        }
        private static void AsString(string indent, bool verbose, Org.BouncyCastle.Asn1.Asn1Object obj, System.Text.StringBuilder buf)
        {
            int val_16;
            System.Byte[] val_176;
            bool val_177;
            string val_178;
            var val_181;
            var val_182;
            string val_185;
            var val_190;
            var val_191;
            var val_192;
            var val_193;
            var val_195;
            var val_196;
            var val_197;
            int val_199;
            var val_200;
            var val_201;
            var val_205;
            var val_206;
            var val_207;
            var val_208;
            var val_209;
            var val_210;
            var val_211;
            var val_212;
            var val_214;
            var val_216;
            var val_217;
            var val_218;
            var val_219;
            var val_251;
            val_176 = obj;
            val_177 = verbose;
            val_178 = indent;
            if(val_176 == null)
            {
                goto label_1;
            }
            
            val_181 = 0;
            label_633:
            if(buf == null)
            {
                goto label_8;
            }
            
            System.Text.StringBuilder val_5 = buf.Append(value:  val_178);
            goto label_9;
            label_1:
            val_182 = null;
            val_182 = null;
            string val_7 = val_178 + val_176.ToString() + Org.BouncyCastle.Asn1.Utilities.Asn1Dump.SampleSize;
            goto label_554;
            label_8:
            System.Text.StringBuilder val_30 = 0.Append(value:  val_178);
            label_9:
            System.Text.StringBuilder val_31 = buf.Append(value:  "BER Set");
            val_190 = null;
            val_190 = null;
            System.Text.StringBuilder val_32 = buf.Append(value:  Org.BouncyCastle.Asn1.Utilities.Asn1Dump.SampleSize);
            label_79:
            var val_175 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_60;
            }
            
            var val_173 = mem[282584257676847];
            var val_174 = 0;
            val_173 = val_173 + 8;
            label_59:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_58;
            }
            
            val_174 = val_174 + 1;
            val_173 = val_173 + 16;
            if(val_174 < mem[282584257676957])
            {
                goto label_59;
            }
            
            goto label_60;
            label_58:
            val_175 = val_175 + (((mem[282584257676847] + 8)) << 4);
            val_191 = val_175 + 296;
            label_60:
            if(0.MoveNext() == false)
            {
                goto label_61;
            }
            
            var val_179 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_66;
            }
            
            var val_176 = mem[282584257676847];
            var val_177 = 0;
            val_176 = val_176 + 8;
            label_65:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_64;
            }
            
            val_177 = val_177 + 1;
            val_176 = val_176 + 16;
            if(val_177 < mem[282584257676957])
            {
                goto label_65;
            }
            
            goto label_66;
            label_64:
            var val_178 = val_176;
            val_178 = val_178 + 1;
            val_179 = val_179 + val_178;
            val_192 = val_179 + 296;
            label_66:
            object val_36 = 0.Current;
            System.Text.StringBuilder val_39 = buf.Append(value:  val_178 + "    ");
            System.Text.StringBuilder val_40 = buf.Append(value:  "NULL");
            val_193 = null;
            val_193 = null;
            System.Text.StringBuilder val_41 = buf.Append(value:  Org.BouncyCastle.Asn1.Utilities.Asn1Dump.SampleSize);
            goto label_79;
            label_113:
            var val_182 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_92;
            }
            
            var val_180 = mem[282584257676847];
            var val_181 = 0;
            val_180 = val_180 + 8;
            label_91:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_90;
            }
            
            val_181 = val_181 + 1;
            val_180 = val_180 + 16;
            if(val_181 < mem[282584257676957])
            {
                goto label_91;
            }
            
            goto label_92;
            label_90:
            val_182 = val_182 + (((mem[282584257676847] + 8)) << 4);
            val_195 = val_182 + 296;
            label_92:
            if(0.MoveNext() == false)
            {
                goto label_93;
            }
            
            var val_186 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_98;
            }
            
            var val_183 = mem[282584257676847];
            var val_184 = 0;
            val_183 = val_183 + 8;
            label_97:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_96;
            }
            
            val_184 = val_184 + 1;
            val_183 = val_183 + 16;
            if(val_184 < mem[282584257676957])
            {
                goto label_97;
            }
            
            goto label_98;
            label_96:
            var val_185 = val_183;
            val_185 = val_185 + 1;
            val_186 = val_186 + val_185;
            val_196 = val_186 + 296;
            label_98:
            object val_48 = 0.Current;
            System.Text.StringBuilder val_51 = buf.Append(value:  null);
            System.Text.StringBuilder val_52 = buf.Append(value:  "NULL");
            val_197 = null;
            val_197 = null;
            System.Text.StringBuilder val_53 = buf.Append(value:  Org.BouncyCastle.Asn1.Utilities.Asn1Dump.SampleSize);
            goto label_113;
            label_93:
            val_200 = 0;
            val_201 = 0;
            goto label_121;
            label_61:
            val_177 = val_177;
            val_185 = 0;
            val_181 = 1;
            val_205 = null;
            if(0 == 0)
            {
                goto label_153;
            }
            
            var val_189 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_157;
            }
            
            var val_187 = mem[282584257676847];
            var val_188 = 0;
            val_187 = val_187 + 8;
            label_156:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_155;
            }
            
            val_188 = val_188 + 1;
            val_187 = val_187 + 16;
            if(val_188 < mem[282584257676957])
            {
                goto label_156;
            }
            
            goto label_157;
            label_155:
            val_189 = val_189 + (((mem[282584257676847] + 8)) << 4);
            val_206 = val_189 + 296;
            label_157:
            val_205 = public System.Void System.IDisposable::Dispose();
            0.Dispose();
            label_153:
            if(val_181 != 1)
            {
                    if(2372 == 2372)
            {
                    return;
            }
            
            }
            
            if( != false)
            {
                    val_205 = 0;
            }
            
            if(buf != null)
            {
                    System.Text.StringBuilder val_60 = buf.Append(value:  val_178);
            }
            else
            {
                    System.Text.StringBuilder val_61 = 0.Append(value:  val_178);
            }
            
            System.Text.StringBuilder val_62 = buf.Append(value:  "DER Set");
            val_207 = null;
            val_207 = null;
            System.Text.StringBuilder val_63 = buf.Append(value:  Org.BouncyCastle.Asn1.Utilities.Asn1Dump.SampleSize);
            label_195:
            var val_192 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_176;
            }
            
            var val_190 = mem[282584257676847];
            var val_191 = 0;
            val_190 = val_190 + 8;
            label_175:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_174;
            }
            
            val_191 = val_191 + 1;
            val_190 = val_190 + 16;
            if(val_191 < mem[282584257676957])
            {
                goto label_175;
            }
            
            goto label_176;
            label_174:
            val_192 = val_192 + (((mem[282584257676847] + 8)) << 4);
            val_208 = val_192 + 296;
            label_176:
            if(0.MoveNext() == false)
            {
                goto label_177;
            }
            
            var val_196 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_182;
            }
            
            var val_193 = mem[282584257676847];
            var val_194 = 0;
            val_193 = val_193 + 8;
            label_181:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_180;
            }
            
            val_194 = val_194 + 1;
            val_193 = val_193 + 16;
            if(val_194 < mem[282584257676957])
            {
                goto label_181;
            }
            
            goto label_182;
            label_180:
            var val_195 = val_193;
            val_195 = val_195 + 1;
            val_196 = val_196 + val_195;
            val_209 = val_196 + 296;
            label_182:
            object val_67 = 0.Current;
            System.Text.StringBuilder val_70 = buf.Append(value:  val_178 + "    ");
            System.Text.StringBuilder val_71 = buf.Append(value:  "NULL");
            val_210 = null;
            val_210 = null;
            System.Text.StringBuilder val_72 = buf.Append(value:  Org.BouncyCastle.Asn1.Utilities.Asn1Dump.SampleSize);
            goto label_195;
            label_177:
            val_177 = ;
            val_185 = 0;
            val_181 = 2;
            val_205 = null;
            if(0 == 0)
            {
                goto label_213;
            }
            
            var val_199 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_217;
            }
            
            var val_197 = mem[282584257676847];
            var val_198 = 0;
            val_197 = val_197 + 8;
            label_216:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_215;
            }
            
            val_198 = val_198 + 1;
            val_197 = val_197 + 16;
            if(val_198 < mem[282584257676957])
            {
                goto label_216;
            }
            
            goto label_217;
            label_215:
            val_199 = val_199 + (((mem[282584257676847] + 8)) << 4);
            val_211 = val_199 + 296;
            label_217:
            val_205 = public System.Void System.IDisposable::Dispose();
            0.Dispose();
            label_213:
            if(val_181 != 1)
            {
                    if(2372 == 2372)
            {
                    return;
            }
            
            }
            
            if( != false)
            {
                    val_205 = 0;
            }
            
            val_185 = 1152921505542627328;
            val_185 = 1152921505543106560;
            val_185 = 1152921505543053312;
            val_185 = 1152921505544065024;
            val_185 = 1152921505543479296;
            val_185 = 1152921505544171520;
            val_185 = 1152921505542574080;
            val_185 = 1152921505543852032;
            val_185 = 1152921505543000064;
            val_185 = 1152921505544118272;
            val_212 = null;
            val_214 = null;
            val_216 = null;
            val_216 = null;
            System.Text.StringBuilder val_92 = buf.Append(value:  val_178 + "External " + Org.BouncyCastle.Asn1.Utilities.Asn1Dump.SampleSize);
            string val_93 = val_178 + "    ";
            if(val_176.DirectReference != null)
            {
                    val_217 = null;
                val_217 = null;
                System.Text.StringBuilder val_98 = buf.Append(value:  val_93 + "Direct Reference: "("Direct Reference: ") + val_176.DirectReference.Id + Org.BouncyCastle.Asn1.Utilities.Asn1Dump.SampleSize);
            }
            
            if(val_176.IndirectReference != null)
            {
                    val_218 = null;
                val_218 = null;
                System.Text.StringBuilder val_102 = buf.Append(value:  val_93 + "Indirect Reference: "("Indirect Reference: ") + val_176.IndirectReference + Org.BouncyCastle.Asn1.Utilities.Asn1Dump.SampleSize);
            }
            
            if(val_176.DataValueDescriptor != null)
            {
                    Org.BouncyCastle.Asn1.Asn1Object val_104 = val_176.DataValueDescriptor;
                bool val_105 = ;
            }
            
            object[] val_106 = new object[4];
            val_106[0] = val_93;
            val_106[1] = "Encoding: ";
            val_16 = val_176.Encoding;
            val_106[2] = val_16;
            val_219 = null;
            val_219 = null;
            val_106[3] = Org.BouncyCastle.Asn1.Utilities.Asn1Dump.SampleSize;
            System.Text.StringBuilder val_109 = buf.Append(value:  +val_106);
            Org.BouncyCastle.Asn1.Asn1Object val_110 = val_176.ExternalContent;
            bool val_111 = ;
            return;
            label_554:
            val_199 = +;
            System.Text.StringBuilder val_160 = buf.Append(value:  val_199);
            return;
            label_121:
            if(0 == 0)
            {
                goto label_625;
            }
            
            var val_202 = 1179403647;
            if(mem[282584257676957] == 0)
            {
                goto label_629;
            }
            
            var val_200 = mem[282584257676847];
            var val_201 = 0;
            val_200 = val_200 + 8;
            label_628:
            if(((mem[282584257676847] + 8) + -8) == null)
            {
                goto label_627;
            }
            
            val_201 = val_201 + 1;
            val_200 = val_200 + 16;
            if(val_201 < mem[282584257676957])
            {
                goto label_628;
            }
            
            goto label_629;
            label_627:
            val_202 = val_202 + (((mem[282584257676847] + 8)) << 4);
            val_251 = val_202 + 296;
            label_629:
            0.Dispose();
            label_625:
            if( != 1)
            {
                    if(2372 == 2372)
            {
                    return;
            }
            
            }
            
            if( == false)
            {
                goto label_633;
            }
            
            goto label_633;
        }
        private static string outputApplicationSpecific(string type, string indent, bool verbose, Org.BouncyCastle.Asn1.DerApplicationSpecific app)
        {
            object val_21;
            object val_22;
            var val_23;
            System.Text.StringBuilder val_24;
            var val_25;
            Org.BouncyCastle.Asn1.Asn1Object val_28;
            var val_29;
            var val_30;
            var val_31;
            var val_32;
            object val_33;
            object val_34;
            val_21 = verbose;
            val_22 = type;
            System.Text.StringBuilder val_1 = null;
            val_24 = val_1;
            val_1 = new System.Text.StringBuilder();
            if(app.IsConstructed() == false)
            {
                goto label_2;
            }
            
            Org.BouncyCastle.Asn1.Asn1Sequence val_4 = Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj:  app.GetObject(derTagNo:  16));
            object[] val_5 = new object[6];
            val_5[0] = indent;
            val_5[1] = val_22;
            val_5[2] = " ApplicationSpecific[";
            val_5[3] = app.ApplicationTag;
            val_5[4] = "]";
            val_22 = 1152921505548378112;
            val_25 = null;
            val_25 = null;
            val_5[5] = Org.BouncyCastle.Asn1.Utilities.Asn1Dump.SampleSize;
            System.Text.StringBuilder val_8 = val_1.Append(value:  +val_5);
            label_45:
            var val_23 = 0;
            val_23 = val_23 + 1;
            bool val_11 = val_4.MoveNext();
            if(val_11 == false)
            {
                goto label_33;
            }
            
            var val_24 = 0;
            val_24 = val_24 + 1;
            val_28 = val_4.Current;
            if(val_28 != null)
            {
                    val_28 = 0;
            }
            
            Org.BouncyCastle.Asn1.Utilities.Asn1Dump.AsString(indent:  indent + "    ", verbose:  val_21, obj:  val_28, buf:  val_1);
            goto label_45;
            label_2:
            object[] val_16 = new object[8];
            val_24 = val_16;
            val_24[0] = indent;
            val_24[1] = val_22;
            val_24[2] = " ApplicationSpecific[";
            val_24[3] = app.ApplicationTag;
            val_24[4] = "] (";
            val_24[5] = Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(data:  app.GetContents());
            val_24[6] = ")";
            val_29 = null;
            val_29 = null;
            val_24[7] = Org.BouncyCastle.Asn1.Utilities.Asn1Dump.SampleSize;
            string val_20 = +val_16;
            return (string)val_30;
            label_33:
            val_23 = 0;
            val_31 = 0;
            goto label_78;
            label_120:
            val_32 = public System.Boolean System.Collections.IEnumerator::MoveNext();
            val_33 = val_11;
            goto label_100;
            label_78:
            val_34 = null;
            val_21 = val_4;
            if(val_21 == null)
            {
                goto label_101;
            }
            
            var val_25 = 0;
            val_25 = val_25 + 1;
            goto label_105;
            label_100:
            if(val_32 != 1)
            {
                goto label_120;
            }
            
            val_21 = val_33;
            if((null & 1) == 0)
            {
                goto label_107;
            }
            
            val_34 = val_21;
            System.Text.StringBuilder val_21 = val_1.Append(value:  val_34);
            if(val_24 != null)
            {
                goto label_116;
            }
            
            goto label_110;
            label_105:
            val_34 = public System.Void System.IDisposable::Dispose();
            val_21.Dispose();
            label_101:
            if( == 1)
            {
                goto label_111;
            }
            
            if( == false)
            {
                goto label_115;
            }
            
            if(170 != 170)
            {
                goto label_113;
            }
            
            goto label_115;
            label_111:
            if( == false)
            {
                goto label_115;
            }
            
            label_113:
            val_34 = 0;
            label_115:
            if(val_24 != null)
            {
                goto label_116;
            }
            
            label_110:
            label_116:
            val_30 = val_24;
            return (string)val_30;
            label_107:
            mem[8] = val_21;
            goto label_120;
        }
        public static string DumpAsString(object obj)
        {
            Org.BouncyCastle.Asn1.Asn1Object val_5;
            var val_6;
            val_5 = obj;
            if(val_5 == null)
            {
                    return "unknown object type " + val_5;
            }
            
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            val_6 = null;
            val_6 = 0;
            val_5 = 0;
            Org.BouncyCastle.Asn1.Utilities.Asn1Dump.AsString(indent:  "", verbose:  false, obj:  val_5, buf:  val_1);
            if(val_1 != null)
            {
                    return (string)val_1;
            }
            
            return (string)val_1;
        }
        public static string DumpAsString(Org.BouncyCastle.Asn1.Asn1Encodable obj)
        {
            return Org.BouncyCastle.Asn1.Utilities.Asn1Dump.DumpAsString(obj:  obj, verbose:  false);
        }
        public static string DumpAsString(Org.BouncyCastle.Asn1.Asn1Encodable obj, bool verbose)
        {
            System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
            Org.BouncyCastle.Asn1.Utilities.Asn1Dump.AsString(indent:  "", verbose:  verbose, obj:  obj, buf:  val_1);
            if(val_1 == null)
            {
                
            }
        
        }
        private static string dumpBinaryDataAsString(string indent, byte[] bytes)
        {
            var val_18;
            string val_19;
            var val_20;
            var val_21;
            var val_22;
            val_18 = null;
            val_18 = null;
            System.Text.StringBuilder val_2 = null;
            val_19 = Org.BouncyCastle.Asn1.Utilities.Asn1Dump.SampleSize;
            val_2 = new System.Text.StringBuilder(value:  val_19);
            val_20 = 0;
            goto label_3;
            label_25:
            System.Text.StringBuilder val_3 = val_2.Append(value:  indent + "    ");
            if(1152921505548382208 >= 33)
            {
                goto label_5;
            }
            
            System.Text.StringBuilder val_6 = val_2.Append(value:  Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(data:  bytes, off:  0, length:  bytes.Length - val_20));
            val_21 = 32 - bytes.Length;
            goto label_9;
            label_11:
            System.Text.StringBuilder val_7 = val_2.Append(value:  "  ");
            val_21 = val_21 - 1;
            label_9:
            if(val_21 != 0)
            {
                goto label_11;
            }
            
            System.Text.StringBuilder val_8 = val_2.Append(value:  "    ");
            val_22 = bytes.Length - val_20;
            goto label_15;
            label_5:
            string val_9 = Org.BouncyCastle.Utilities.Encoders.Hex.ToHexString(data:  bytes, off:  0, length:  32);
            if(val_2 != null)
            {
                    System.Text.StringBuilder val_10 = val_2.Append(value:  val_9);
            }
            else
            {
                    System.Text.StringBuilder val_11 = val_2.Append(value:  val_9);
            }
            
            System.Text.StringBuilder val_12 = val_2.Append(value:  "    ");
            val_22 = 32;
            label_15:
            System.Text.StringBuilder val_14 = val_2.Append(value:  Org.BouncyCastle.Asn1.Utilities.Asn1Dump.calculateAscString(bytes:  bytes, off:  0, len:  32));
            val_19 = Org.BouncyCastle.Asn1.Utilities.Asn1Dump.SampleSize;
            System.Text.StringBuilder val_15 = val_2.Append(value:  val_19);
            val_20 = 32;
            label_3:
            if(val_20 < bytes.Length)
            {
                goto label_25;
            }
            
            if(val_2 == null)
            {
                
            }
        
        }
        private static string calculateAscString(byte[] bytes, int off, int len)
        {
            var val_3;
            char val_4;
            val_3 = len;
            int val_4 = off;
            System.Text.StringBuilder val_1 = null;
            val_4 = 0;
            val_1 = new System.Text.StringBuilder();
            if(val_3 != 0)
            {
                    do
            {
                if(val_4 >= bytes.Length)
            {
                    val_4 = 0;
            }
            
                byte val_3 = bytes[(long)val_4];
                bytes[(long)val_4] = val_3 - 32;
                if(bytes[(long)val_4] <= 94)
            {
                    val_4 = val_3;
                System.Text.StringBuilder val_2 = val_1.Append(value:  val_4);
            }
            
                val_3 = val_3 - 1;
                val_4 = val_4 + 1;
            }
            while(val_3 != 0);
            
            }
            
            if(val_1 == null)
            {
                
            }
        
        }
        private static Asn1Dump()
        {
            null = null;
            Org.BouncyCastle.Asn1.Utilities.Asn1Dump.SampleSize = Org.BouncyCastle.Utilities.Platform.NewLine;
        }
    
    }

}
