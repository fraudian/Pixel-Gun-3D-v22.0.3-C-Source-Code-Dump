using UnityEngine;

namespace TagSystem
{
    public class 丞丐万丂上丏丕与上 : JsonConverter
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
        public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            TagSystem.三与下丘七丘丌丏丄 val_8;
            var val_9;
            var val_10;
            var val_12;
            val_8 = 丙业与丙丗丝不丈东;
            val_9 = 业专丘专七丕丟丅与;
            if(val_8 != null)
            {
                    val_10 = 1152921505345343488;
                val_12 = null;
            }
            
            val_8 = ???;
            val_9 = ???;
            val_10 = ???;
            goto typeof(Newtonsoft.Json.JsonWriter).__il2cppRuntimeField_278;
        }
        public override object ReadJson(Newtonsoft.Json.JsonReader 且丛三下万丂专专业, System.Type 与丐与不丁丗丂一东, object 丄不丅丒不丁丁丌丘, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            string val_3;
            var val_4;
            val_3 = 且丛三下万丂专专业;
            if(val_3 == 9)
            {
                    val_3 = val_3;
                if(val_3 != null)
            {
                    if(null != null)
            {
                    val_3 = 0;
            }
            
            }
            
                TagSystem.三与下丘七丘丌丏丄 val_2 = TagSystem.专与丈上丅上丘东万.与丛丆专东丐一且丅(丞丕丒专一下丙业上:  val_3);
                return (object)val_4;
            }
            
            val_4 = 0;
            return (object)val_4;
        }
        public override bool CanConvert(System.Type 与丐与不丁丗丂一东)
        {
            return System.Type.op_Equality(left:  与丐与不丁丗丂一东, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public 丞丐万丂上丏丕与上()
        {
        
        }
    
    }

}
