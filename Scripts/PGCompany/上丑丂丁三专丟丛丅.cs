using UnityEngine;

namespace PGCompany
{
    public class 上丑丂丁三专丟丛丅 : JsonConverter
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
            return System.Type.op_Equality(left:  与丐与不丁丗丂一东, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public override object ReadJson(Newtonsoft.Json.JsonReader 且丛三下万丂专专业, System.Type 与丐与不丁丗丂一东, object 丄不丅丒不丁丁丌丘, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            var val_2;
            string val_8;
            var val_9;
            val_8 = 且丛三下万丂专专业;
            if((val_8 - 7) < 2)
            {
                goto label_2;
            }
            
            if(val_8 != 9)
            {
                goto label_8;
            }
            
            val_8 = val_8;
            if((val_8 != null) && (null != null))
            {
                    val_8 = 0;
            }
            
            if((System.Decimal.TryParse(s:  val_8, result: out  new System.Decimal())) == false)
            {
                goto label_8;
            }
            
            goto label_9;
            label_2:
            val_8 = val_8;
            decimal val_4 = System.Convert.ToDecimal(value:  val_8);
            label_9:
            label_8:
            if(0.HasValue != false)
            {
                    val_8 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
                val_2 = 0;
                return (object)val_9;
            }
            
            val_9 = 0;
            return (object)val_9;
        }
        public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
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
        }
        public 上丑丂丁三专丟丛丅()
        {
        
        }
    
    }

}
