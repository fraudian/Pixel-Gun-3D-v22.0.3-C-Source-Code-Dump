using UnityEngine;

namespace PGCompany
{
    public class 上丏一下万一丅世上 : JsonConverter
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
            object val_3;
            var val_5;
            val_3 = 且丛三下万丂专专业;
            if(val_3 != 7)
            {
                    if(val_3 != 8)
            {
                goto label_3;
            }
            
            }
            
            val_3 = System.Convert.ToInt32(value:  val_3);
            System.TimeSpan val_2 = System.TimeSpan.FromSeconds(value:  (double)val_3);
            return (object)val_5;
            label_3:
            val_5 = 0;
            return (object)val_5;
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
            double val_1 = null.TotalSeconds;
        }
        public 上丏一下万一丅世上()
        {
        
        }
    
    }

}
