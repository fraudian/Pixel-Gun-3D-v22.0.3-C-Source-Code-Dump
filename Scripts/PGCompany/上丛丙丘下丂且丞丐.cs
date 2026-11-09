using UnityEngine;

namespace PGCompany
{
    public class 上丛丙丘下丂且丞丐 : JsonConverter
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
            string val_3;
            var val_4;
            if(且丛三下万丂专专业 == 9)
            {
                    val_3 = 且丛三下万丂专专业;
                if((val_3 != null) && (null != null))
            {
                    val_3 = 0;
            }
            
                Rilisoft.GameEventChestPriceContainer val_2 = Rilisoft.GameEventChestPriceContainer.与丛丆专东丐一且丅(丞丕丒专一下丙业上:  val_3);
                return (object)val_4;
            }
            
            val_4 = 0;
            return (object)val_4;
        }
        public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            var val_8;
            var val_9;
            val_8 = 丙业与丙丗丝不丈东;
            val_9 = 业专丘专七丕丟丅与;
            val_8 = ???;
            val_9 = ???;
            goto typeof(Newtonsoft.Json.JsonWriter).__il2cppRuntimeField_278;
        }
        public 上丛丙丘下丂且丞丐()
        {
        
        }
    
    }

}
