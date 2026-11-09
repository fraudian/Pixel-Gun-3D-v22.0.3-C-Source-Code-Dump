using UnityEngine;

namespace PGCompany
{
    public class 丟丌下一丂丌丆丞不 : JsonConverter
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
            int val_2;
            object val_7;
            string val_8;
            var val_9;
            var val_10;
            val_7 = 且丛三下万丂专专业;
            if((val_7 - 7) < 2)
            {
                goto label_2;
            }
            
            if(val_7 != 9)
            {
                goto label_6;
            }
            
            val_8 = val_7;
            if((val_8 != null) && (null != null))
            {
                    val_8 = 0;
            }
            
            if((System.Int32.TryParse(s:  val_8, result: out  0)) == false)
            {
                goto label_6;
            }
            
            val_9 = 1152921516285748288;
            goto label_7;
            label_2:
            val_7 = val_7;
            int val_5 = System.Convert.ToInt32(value:  val_7);
            val_9 = 1152921516285748288;
            label_7:
            label_6:
            if((18637256 & 1) != 0)
            {
                    Rilisoft.丝丑丂丛万丐丈丘且 val_6 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  18637256);
                val_2 = val_6.七丄不丐丗三丝丑一;
                return (object)val_10;
            }
            
            val_10 = 0;
            return (object)val_10;
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
        public 丟丌下一丂丌丆丞不()
        {
        
        }
    
    }

}
