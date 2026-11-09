using UnityEngine;

namespace PGCompany
{
    public class 东丄世丒丝上与七丒 : JsonConverter
    {
        // Methods
        public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            var val_8;
            var val_9;
            Newtonsoft.Json.JsonWriter val_10;
            val_8 = 与且丂丅丁专丙业丙;
            val_9 = 丙业与丙丗丝不丈东;
            val_10 = 业专丘专七丕丟丅与;
            if(val_9 != null)
            {
                    if(null == null)
            {
                goto label_2;
            }
            
            }
            
            val_8 = ???;
            val_10 = ???;
            val_9 = ???;
            goto typeof(Newtonsoft.Json.JsonWriter).__il2cppRuntimeField_278;
            label_2:
            val_8.Serialize(jsonWriter:  val_10, value:  val_9.丁丕上三丕丌丟丗丙());
        }
        public override object ReadJson(Newtonsoft.Json.JsonReader 且丛三下万丂专专业, System.Type 与丐与不丁丗丂一东, object 丄不丅丒不丁丁丌丘, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            var val_9;
            string val_10;
            var val_11;
            if(且丛三下万丂专专业 == 11)
            {
                    val_9 = 0;
                return (object)PGCompany.丒且丌丑丆上一丘丆<System.String>.东丝七业丄丑丒世七(万丝且丘不丑丝下丑:  System.Collections.Generic.Dictionary<System.String, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Int32>());
            }
            
            if((且丛三下万丂专专业 != 1) || (且丛三下万丂专专业 == 13))
            {
                    return (object)PGCompany.丒且丌丑丆上一丘丆<System.String>.东丝七业丄丑丒世七(万丝且丘不丑丝下丑:  val_1);
            }
            
            label_19:
            if((且丛三下万丂专专业 != 4) || (且丛三下万丂专专业 == null))
            {
                goto label_17;
            }
            
            if(null != null)
            {
                goto label_8;
            }
            
            if((且丛三下万丂专专业 - 7) < 2)
            {
                goto label_9;
            }
            
            if(且丛三下万丂专专业 != 9)
            {
                goto label_13;
            }
            
            val_10 = 且丛三下万丂专专业;
            if((val_10 != null) && (null != null))
            {
                    val_10 = 0;
            }
            
            if((System.Int32.TryParse(s:  val_10, result: out  0)) == false)
            {
                goto label_13;
            }
            
            goto label_14;
            label_9:
            int val_6 = System.Convert.ToInt32(value:  且丛三下万丂专专业);
            label_14:
            label_13:
            if((20504192 & 1) == 0)
            {
                goto label_17;
            }
            
            val_1.Add(key:  且丛三下万丂专专业, value:  20504192);
            if(且丛三下万丂专专业 != 13)
            {
                goto label_19;
            }
            
            return (object)PGCompany.丒且丌丑丆上一丘丆<System.String>.东丝七业丄丑丒世七(万丝且丘不丑丝下丑:  val_1);
            label_8:
            label_17:
            val_11 = new Newtonsoft.Json.JsonSerializationException(message:  "Unexpected token!");
        }
        public override bool CanConvert(System.Type 与丐与不丁丗丂一东)
        {
            return System.Type.op_Equality(left:  与丐与不丁丗丂一东, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public 东丄世丒丝上与七丒()
        {
        
        }
    
    }

}
