using UnityEngine;

namespace PGCompany
{
    public class 一七丞丐一上下不与 : JsonConverter
    {
        // Fields
        private const string 且与丝丙丕且丏丂一 = ":";
        
        // Properties
        public override bool 与丐下丂丂上业丕业 { get; }
        public override bool 下一且丄丗三丌丄丘 { get; }
        
        // Methods
        public override bool get_CanRead()
        {
            return true;
        }
        public override bool get_CanWrite()
        {
            return true;
        }
        public override bool CanConvert(System.Type 与丐与不丁丗丂一东)
        {
            return System.Type.op_Equality(left:  与丐与不丁丗丂一东, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public override object ReadJson(Newtonsoft.Json.JsonReader 且丛三下万丂专专业, System.Type 与丐与不丁丗丂一东, object 丄不丅丒不丁丁丌丘, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            string val_14;
            var val_15;
            var val_16;
            var val_17;
            var val_18;
            var val_19;
            int val_20;
            var val_21;
            var val_22;
            var val_23;
            var val_24;
            var val_25;
            var val_26;
            var val_27;
            var val_28;
            var val_29;
            val_14 = 且丛三下万丂专专业;
            if(val_14 != 9)
            {
                goto label_2;
            }
            
            val_14 = val_14.ToString();
            if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_14)) == false)
            {
                goto label_6;
            }
            
            val_16 = null;
            return (object)val_13._ticks;
            label_2:
            val_17 = 0;
            return (object)val_13._ticks;
            label_6:
            char[] val_3 = new char[1];
            val_18 = ":";
            if((":") == null)
            {
                    val_18 = ":";
            }
            
            val_3[0] = Chars[0];
            System.String[] val_5 = val_14.Split(separator:  val_3);
            if(val_5 == null)
            {
                goto label_13;
            }
            
            val_19 = val_5;
            val_20 = val_5.Length;
            if(val_20 == 2)
            {
                goto label_14;
            }
            
            if(val_20 == 3)
            {
                goto label_15;
            }
            
            if(val_20 == 4)
            {
                goto label_16;
            }
            
            goto label_33;
            label_13:
            val_21 = 24;
            val_22 = 28563616;
            if(28563616 != 4)
            {
                goto label_18;
            }
            
            label_16:
            val_23 = System.Convert.ToInt32(value:  val_5[0]);
            val_24 = System.Convert.ToInt32(value:  val_5[1]);
            val_25 = System.Convert.ToInt32(value:  val_5[2]);
            val_14 = val_5[3];
            goto label_25;
            label_18:
            val_26 = 24;
            val_27 = 28563616;
            if(val_22 != 3)
            {
                goto label_26;
            }
            
            label_15:
            val_24 = System.Convert.ToInt32(value:  val_5[0]);
            val_25 = System.Convert.ToInt32(value:  val_5[1]);
            val_14 = val_5[2];
            goto label_32;
            label_26:
            val_28 = 24;
            val_29 = 28563616;
            if(val_27 != 2)
            {
                goto label_33;
            }
            
            label_14:
            val_25 = System.Convert.ToInt32(value:  val_5[0]);
            val_14 = val_5[1];
            goto label_38;
            label_33:
            if(val_20 != 1)
            {
                goto label_44;
            }
            
            if(val_5 == null)
            {
                    val_29 = mem[val_5 + 24];
                val_29 = val_5 + 24;
            }
            
            val_14 = val_5[0];
            val_25 = 0;
            label_38:
            val_24 = 0;
            label_32:
            val_23 = 0;
            label_25:
            label_44:
            System.TimeSpan val_13 = new System.TimeSpan(days:  0, hours:  0, minutes:  0, seconds:  System.Convert.ToInt32(value:  val_14));
            val_15;
            val_16 = null;
            return (object)val_13._ticks;
        }
        public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            var val_12;
            if(丙业与丙丗丝不丈东 != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            if(业专丘专七丕丟丅与 != null)
            {
                    return;
            }
            
            return;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
            PGCompany.东丑丒丗一丞下丙丙<T> val_1 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
            if(null.Days >= 1)
            {
                    val_1.Add(item:  null.Days);
            }
            
            if(null.Hours >= 1)
            {
                    val_1.Add(item:  null.Hours);
            }
            
            if(null.Minutes >= 1)
            {
                    val_1.Add(item:  null.Minutes);
            }
            
            if(null.Seconds >= 1)
            {
                    val_1.Add(item:  null.Seconds);
            }
            
            val_12 = System.String.Join<System.Int32>(separator:  ":", values:  val_1);
            PGCompany.东丑丒丗一丞下丙丙<T> val_11 = PGCompany.东丑丒丗一丞下丙丙<System.Int32>.万世丅七一专丕丞不();
        }
        public 一七丞丐一上下不与()
        {
        
        }
    
    }

}
