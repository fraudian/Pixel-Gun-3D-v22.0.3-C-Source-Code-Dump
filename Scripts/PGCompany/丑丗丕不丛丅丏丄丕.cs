using UnityEngine;

namespace PGCompany
{
    public class 丑丗丕不丛丅丏丄丕 : JsonConverter
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
            var val_11;
            string val_12;
            string val_13;
            var val_14;
            if(且丛三下万丂专专业 == 11)
            {
                    val_11 = 0;
                return (object)PGCompany.上丅丙丟不业不丆东.东丝七业丄丑丒世七(万丝且丘不丑丝下丑:  System.Collections.Generic.Dictionary<System.Int32, System.Int32> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Int32>());
            }
            
            if((且丛三下万丂专专业 != 1) || (且丛三下万丂专专业 == 13))
            {
                    return (object)PGCompany.上丅丙丟不业不丆东.东丝七业丄丑丒世七(万丝且丘不丑丝下丑:  val_1);
            }
            
            label_21:
            if(且丛三下万丂专专业 != 4)
            {
                goto label_19;
            }
            
            val_12 = 且丛三下万丂专专业;
            if((val_12 != null) && (null != null))
            {
                    val_12 = 0;
            }
            
            bool val_4 = System.Int32.TryParse(s:  val_12, result: out  0);
            if((19948672 & 1) == 0)
            {
                goto label_19;
            }
            
            if((且丛三下万丂专专业 - 7) < 2)
            {
                goto label_11;
            }
            
            if(且丛三下万丂专专业 != 9)
            {
                goto label_15;
            }
            
            val_13 = 且丛三下万丂专专业;
            if((val_13 != null) && (null != null))
            {
                    val_13 = 0;
            }
            
            if((System.Int32.TryParse(s:  val_13, result: out  0)) == false)
            {
                goto label_15;
            }
            
            goto label_16;
            label_11:
            int val_8 = System.Convert.ToInt32(value:  且丛三下万丂专专业);
            label_16:
            label_15:
            if((19948656 & 1) == 0)
            {
                goto label_19;
            }
            
            val_1.Add(key:  19948672, value:  19948656);
            if(且丛三下万丂专专业 != 13)
            {
                goto label_21;
            }
            
            return (object)PGCompany.上丅丙丟不业不丆东.东丝七业丄丑丒世七(万丝且丘不丑丝下丑:  val_1);
            label_19:
            val_14 = new Newtonsoft.Json.JsonSerializationException(message:  "Unexpected token!");
        }
        public override bool CanConvert(System.Type 与丐与不丁丗丂一东)
        {
            return System.Type.op_Equality(left:  与丐与不丁丗丂一东, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public 丑丗丕不丛丅丏丄丕()
        {
        
        }
    
    }

}
