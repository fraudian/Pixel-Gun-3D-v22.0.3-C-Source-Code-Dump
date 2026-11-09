using UnityEngine;

namespace I2.Loc
{
    public class 三丝丄世不丛丐万与
    {
        // Methods
        public static System.Collections.Generic.Dictionary<string, string> 丒东丅上与丄专丘丗(UnityEngine.TextAsset 丄专丄丟七丅万不丅)
        {
            string val_16;
            string val_8 = 0;
            string val_9 = 0;
            System.Text.Encoding val_1 = System.Text.Encoding.UTF8;
            if(丄专丄丟七丅万不丅 != null)
            {
                    val_16 = 丄专丄丟七丅万不丅.bytes;
            }
            else
            {
                    val_16 = 0.bytes;
            }
            
            if(丄专丄丟七丅万不丅.bytes == null)
            {
                goto label_3;
            }
            
            label_14:
            System.Collections.Generic.Dictionary<System.String, System.String> val_7 = new System.Collections.Generic.Dictionary<System.String, System.String>();
            goto label_9;
            label_12:
            if((I2.Loc.三丝丄世不丛丐万与.不专丐世不三万世世(不下丟丁丟丑丅且丐:  val_7 = new System.Collections.Generic.Dictionary<System.String, System.String>(), 下上丐丆丝丟丝丒不: out  val_8, 丙业与丙丗丝不丈东: out  val_9, 七丆丒与丗丌丄且丂: out  0, 丐丆丐七一上专三丑: out  0, 丛丅且丕丗一丈上东: out  0)) != false)
            {
                    val_16 = val_8;
                if((System.String.IsNullOrEmpty(value:  val_16)) != true)
            {
                    if((System.String.IsNullOrEmpty(value:  val_9)) != true)
            {
                    val_7.set_Item(key:  val_16, value:  val_9);
            }
            
            }
            
            }
            
            label_9:
            if((new System.IO.StringReader(s:  val_1.Replace(oldValue:  "\r\n", newValue:  "\n"))) != null)
            {
                goto label_12;
            }
            
            return val_7;
            label_3:
            if(val_1 != null)
            {
                goto label_14;
            }
            
            goto label_14;
        }
        public static bool 不专丐世不三万世世(string 不下丟丁丟丑丅且丐, out string 下上丐丆丝丟丝丒不, out string 丙业与丙丗丝不丈东, out string 七丆丒与丗丌丄且丂, out string 丐丆丐七一上专三丑, out string 丛丅且丕丗一丈上东)
        {
            string val_24;
            var val_25;
            int val_26;
            var val_27;
            val_24 = 1152921541583029568;
            val_25 = 不下丟丁丟丑丅且丐;
            下上丐丆丝丟丝丒不 = System.String.alignConst;
            七丆丒与丗丌丄且丂 = System.String.alignConst;
            丐丆丐七一上专三丑 = System.String.alignConst;
            丛丅且丕丗一丈上东 = System.String.alignConst;
            丙业与丙丗丝不丈东 = System.String.alignConst;
            string val_24 = "//";
            int val_1 = val_25.LastIndexOf(value:  val_24);
            if((val_1 & 2147483648) == 0)
            {
                    val_24 = val_1 + 2;
                string val_3 = val_25.Substring(startIndex:  val_24).Trim();
                丐丆丐七一上专三丑 = val_3;
                丐丆丐七一上专三丑 = I2.Loc.三丝丄世不丛丐万与.与丏下万丒丆不丞丌(下业七不丑丂丏丟东:  val_3);
                val_25 = val_25.Substring(startIndex:  0, length:  val_1);
            }
            
            val_26 = val_25.IndexOf(value:  "=");
            if((val_26 & 2147483648) == 0)
            {
                    下上丐丆丝丟丝丒不 = val_25.Substring(startIndex:  0, length:  val_26).Trim();
                string val_11 = val_25.Substring(startIndex:  val_26 + 1).Trim();
                丙业与丙丗丝不丈东 = val_11;
                val_26 = "\n";
                string val_13 = val_11.Replace(oldValue:  "\r\n", newValue:  "\n").Replace(oldValue:  "\n", newValue:  "\\n");
                丙业与丙丗丝不丈东 = val_13;
                丙业与丙丗丝不丈东 = I2.Loc.三丝丄世不丛丐万与.与丏下万丒丆不丞丌(下业七不丑丂丏丟东:  val_13);
                val_24 = 下上丐丆丝丟丝丒不;
                if(val_24.Length >= 3)
            {
                    val_24 = 下上丐丆丝丟丝丒不;
                if((val_24.Chars[0] & 65535) == '[')
            {
                    val_24 = 下上丐丆丝丟丝丒不.IndexOf(value:  ']');
                if((val_24 & 2147483648) == 0)
            {
                    丛丅且丕丗一丈上东 = 下上丐丆丝丟丝丒不.Substring(startIndex:  1, length:  val_24 - 1);
                下上丐丆丝丟丝丒不 = 下上丐丆丝丟丝丒不.Substring(startIndex:  val_24 + 1);
            }
            
            }
            
            }
            
                I2.Loc.三丝丄世不丛丐万与.专丞丌且丈丅丛三丗(丝丐丟三业丟丏万且: ref  string val_23 = 下上丐丆丝丟丝丒不);
                val_27 = 1;
                return (bool)val_27;
            }
            
            val_27 = 0;
            return (bool)val_27;
        }
        public static string 下丌丐丗丒下丂专丙(string 世丒业丂一上丆一东)
        {
            System.IO.StreamReader val_1 = System.IO.File.OpenText(path:  世丒业丂一上丆一东);
            var val_3 = 0;
            val_3 = val_3 + 1;
            val_1.Dispose();
            if(val_1 != null)
            {
                    return val_1.Replace(oldValue:  "\r\n", newValue:  "\n");
            }
            
            return val_1.Replace(oldValue:  "\r\n", newValue:  "\n");
        }
        public static System.Collections.Generic.List<string[]> 丛一世丒下业且丞丟(string 不三世丏丙丁与丑丒)
        {
            System.String[] val_5;
            int val_2 = 0;
            System.Collections.Generic.List<System.String[]> val_1 = new System.Collections.Generic.List<System.String[]>();
            val_5 = 0;
            goto label_1;
            label_5:
            val_5 = I2.Loc.三丝丄世不丛丐万与.丒丘业丝丑丝丞丗且(丟丞万且丛下专丑丌:  不三世丏丙丁与丑丒, 丘业三丌与丒丛丂丛: ref  val_2);
            if(val_5 == null)
            {
                    return val_1;
            }
            
            val_1.Add(item:  val_5);
            val_5 = val_2;
            label_1:
            if(0 < 不三世丏丙丁与丑丒.Length)
            {
                goto label_5;
            }
            
            return val_1;
        }
        private static string[] 丒丘业丝丑丝丞丗且(string 丟丞万且丛下专丑丌, ref int 丘业三丌与丒丛丂丛)
        {
            int val_15;
            int val_16;
            string val_10 = 丟丞万且丛下专丑丌;
            System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
            int val_2 = 丟丞万且丛下专丑丌.Length;
            val_15 = 丘业三丌与丒丛丂丛;
            int val_11 = val_15;
            if(val_15 >= val_2)
            {
                goto label_19;
            }
            
            label_18:
            char val_3 = 丟丞万且丛下专丑丌.Chars[val_15];
            if((0 & 1) == 0)
            {
                goto label_4;
            }
            
            if((val_3 & 65535) != '"')
            {
                goto label_14;
            }
            
            int val_13 = 丘业三丌与丒丛丂丛;
            int val_5 = val_13 + 1;
            if(val_5 >= val_2)
            {
                goto label_17;
            }
            
            val_13 = 丟丞万且丛下专丑丌.Chars[val_5] & 65535;
            if(val_13 != '"')
            {
                goto label_17;
            }
            
            val_16 = 丘业三丌与丒丛丂丛;
            int val_7 = val_16 + 2;
            if(val_7 >= val_2)
            {
                goto label_11;
            }
            
            val_16 = 丘业三丌与丒丛丂丛;
            if((丟丞万且丛下专丑丌.Chars[val_7] & 65535) != '"')
            {
                goto label_11;
            }
            
            val_16 = val_16 + 2;
            丘业三丌与丒丛丂丛 = val_16;
            goto label_17;
            label_4:
            val_15 = val_3 & 65535;
            if(val_15 == ',')
            {
                goto label_13;
            }
            
            if(val_15 == '"')
            {
                goto label_14;
            }
            
            if(val_15 != '
            ')
            {
                goto label_17;
            }
            
            label_13:
            I2.Loc.三丝丄世不丛丐万与.丞丒丏丛丟上丆上七(丝丘丑业丛万丞丌丝: ref  val_1, 丟丞万且丛下专丑丌: ref  val_10, 丒丂专丑丄丌丐且一:  丘业三丌与丒丛丂丛, 丝业下三一丏丟丅丛: ref  val_11);
            if(val_15 == '
            ')
            {
                goto label_16;
            }
            
            goto label_17;
            label_11:
            val_16 = val_16 + 1;
            丘业三丌与丒丛丂丛 = val_16;
            label_14:
            label_17:
            val_15 = 丘业三丌与丒丛丂丛 + 1;
            丘业三丌与丒丛丂丛 = val_15;
            if(val_15 < val_2)
            {
                goto label_18;
            }
            
            goto label_19;
            label_16:
            val_15 = 丘业三丌与丒丛丂丛 + 1;
            丘业三丌与丒丛丂丛 = val_15;
            label_19:
            if(val_15 <= val_11)
            {
                    return (System.String[])val_1.ToArray();
            }
            
            I2.Loc.三丝丄世不丛丐万与.丞丒丏丛丟上丆上七(丝丘丑业丛万丞丌丝: ref  val_1, 丟丞万且丛下专丑丌: ref  val_10, 丒丂专丑丄丌丐且一:  val_15, 丝业下三一丏丟丅丛: ref  val_11);
            return (System.String[])val_1.ToArray();
        }
        private static void 丞丒丏丛丟上丆上七(ref System.Collections.Generic.List<string> 丝丘丑业丛万丞丌丝, ref string 丟丞万且丛下专丑丌, int 丒丂专丑丄丌丐且一, ref int 丝业下三一丏丟丅丛)
        {
            var val_16;
            string val_17;
            val_16 = 丒丂专丑丄丌丐且一;
            丒丂专丑丄丌丐且一 = val_16 - 丝业下三一丏丟丅丛;
            丝业下三一丏丟丅丛 = val_16 + 1;
            val_17 = 丟丞万且丛下专丑丌.Substring(startIndex:  丝业下三一丏丟丅丛, length:  丒丂专丑丄丌丐且一).Replace(oldValue:  "\"\"", newValue:  "\"");
            if((val_17.Length >= 2) && ((val_17.Chars[0] & 65535) == '"'))
            {
                    if(val_17 != null)
            {
                    val_16 = val_17.Length;
            }
            else
            {
                    val_16 = 0.Length;
            }
            
                if(((val_17.Chars[val_16 - 1]) & 65535) == '"')
            {
                    if(val_17 != null)
            {
                    val_16 = val_17.Length;
            }
            else
            {
                    val_16 = 0.Length;
            }
            
                val_17 = val_17.Substring(startIndex:  1, length:  val_16 - 2);
            }
            
            }
            
            丝丘丑业丛万丞丌丝.Add(item:  val_17);
        }
        public static void 专丞丌且丈丅丛三丗(ref string 丝丐丟三业丟丏万且)
        {
            string val_5;
            string val_1 = 丝丐丟三业丟丏万且.Replace(oldChar:  '\', newChar:  '/');
            丝丐丟三业丟丏万且 = val_1;
            int val_2 = val_1.IndexOf(value:  '/');
            if((val_2 & 2147483648) != 0)
            {
                    return;
            }
            
            val_5 = 丝丐丟三业丟丏万且;
            goto label_3;
            label_6:
            val_5 = 丝丐丟三业丟丏万且.Remove(startIndex:  val_5, count:  1);
            丝丐丟三业丟丏万且 = val_5;
            label_3:
            if((val_5.LastIndexOf(value:  '/')) != val_2)
            {
                goto label_6;
            }
        
        }
        public static string 丐上丐丗丛与一丙一(string 下业七不丑丂丏丟东)
        {
            if((System.String.IsNullOrEmpty(value:  下业七不丑丂丏丟东)) != false)
            {
                    return (string)System.String.alignConst;
            }
            
            string val_3 = 下业七不丑丂丏丟东.Replace(oldValue:  "\r\n", newValue:  "<\\n>").Replace(oldValue:  "\r", newValue:  "<\\n>");
            if(val_3 != null)
            {
                    return val_3.Replace(oldValue:  "\n", newValue:  "<\\n>");
            }
            
            return val_3.Replace(oldValue:  "\n", newValue:  "<\\n>");
        }
        public static string 与丏下万丒丆不丞丌(string 下业七不丑丂丏丟东)
        {
            if((System.String.IsNullOrEmpty(value:  下业七不丑丂丏丟东)) != false)
            {
                    return (string)System.String.alignConst;
            }
            
            if(下业七不丑丂丏丟东 != null)
            {
                    return 下业七不丑丂丏丟东.Replace(oldValue:  "<\\n>", newValue:  "\r\n");
            }
            
            return 下业七不丑丂丏丟东.Replace(oldValue:  "<\\n>", newValue:  "\r\n");
        }
        public 三丝丄世不丛丐万与()
        {
        
        }
    
    }

}
