using UnityEngine;

namespace PGCompany
{
    public class 万丑丐丕丞专三不万<T> : JsonConverter
    {
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
            return System.Type.op_Equality(left:  与丐与不丁丗丂一东, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle() {value = __RuntimeMethodHiddenParam + 24 + 192}));
        }
        public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            object val_2;
            if(丙业与丙丗丝不丈东 == null)
            {
                goto label_1;
            }
            
            if(丙业与丙丗丝不丈东 == null)
            {
                goto label_3;
            }
            
            val_2 = 丙业与丙丗丝不丈东;
            if(val_2 != null)
            {
                goto label_4;
            }
            
            label_3:
            val_2 = 0;
            label_4:
            与且丂丅丁专丙业丙.Serialize(jsonWriter:  业专丘专七丕丟丅与, value:  val_2);
            return;
            label_1:
            if(业专丘专七丕丟丅与 == null)
            {
                
            }
        
        }
        public override object ReadJson(Newtonsoft.Json.JsonReader 且丛三下万丂专专业, System.Type 与丐与不丁丗丂一东, object 丄不丅丒不丁丁丌丘, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            var val_5;
            var val_6;
            var val_7;
            string val_8;
            var val_9;
            var val_11;
            if(且丛三下万丂专专业 == 11)
            {
                    val_5 = 0;
                return (object)val_5;
            }
            
            if((且丛三下万丂专专业 != 1) || (且丛三下万丂专专业 == 13))
            {
                goto label_6;
            }
            
            val_6 = 1152921504624312320;
            val_7 = 1152921516284043440;
            label_21:
            if(且丛三下万丂专专业 != 4)
            {
                goto label_11;
            }
            
            val_8 = 且丛三下万丂专专业;
            if(val_8 != null)
            {
                    val_9 = null;
                val_8 = val_8;
                if(val_8 == null)
            {
                    val_8 = 0;
            }
            
            }
            
            bool val_3 = System.Int32.TryParse(s:  val_8, result: out  0);
            if((19529728 & 1) == 0)
            {
                goto label_11;
            }
            
            if(且丛三下万丂专专业 == 1)
            {
                goto label_12;
            }
            
            if(且丛三下万丂专专业 != 9)
            {
                goto label_18;
            }
            
            val_9;
            if(且丛三下万丂专专业 != null)
            {
                    if(且丛三下万丂专专业 != null)
            {
                goto label_17;
            }
            
            }
            
            label_17:
            val_6 = val_6;
            val_7 = val_7;
            goto label_18;
            label_12:
            val_9 = 与且丂丅丁专丙业丙;
            label_18:
            if(且丛三下万丂专专业 != 13)
            {
                goto label_21;
            }
            
            label_6:
            val_5 = __RuntimeMethodHiddenParam + 24 + 192 + 24;
            return (object)val_5;
            label_11:
            val_11 = new Newtonsoft.Json.JsonSerializationException(message:  "Unexpected token!");
        }
        public 万丑丐丕丞专三不万<T>()
        {
            if(this != null)
            {
                    return;
            }
        
        }
    
    }

}
