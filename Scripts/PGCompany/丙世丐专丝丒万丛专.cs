using UnityEngine;

namespace PGCompany
{
    public class 丙世丐专丝丒万丛专 : JsonConverter
    {
        // Methods
        public override bool CanConvert(System.Type 与丐与不丁丗丂一东)
        {
            return System.Type.op_Equality(left:  与丐与不丁丗丂一东, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            PGCompany.七丑一上且三世丝三<K, V> val_1 = PGCompany.七丑一上且三世丝三<System.String, System.Single>.万世丅七一专丕丞不();
            val_1.Add(key:  "x", value:  3.782474E-38f);
            if(val_1 != null)
            {
                    val_1.Add(key:  "y", value:  V9.16B);
            }
            else
            {
                    val_1.Add(key:  "y", value:  V9.16B);
            }
            
            val_1.Add(key:  "z", value:  V8.16B);
            与且丂丅丁专丙业丙.Serialize(jsonWriter:  业专丘专七丕丟丅与, value:  val_1);
            if((PGCompany.七丑一上且三世丝三<System.String, System.Single>.万世丅七一专丕丞不()) == null)
            {
                
            }
        
        }
        public override object ReadJson(Newtonsoft.Json.JsonReader 且丛三下万丂专专业, System.Type 与丐与不丁丗丂一东, object 丄不丅丒不丁丁丌丘, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            System.Collections.Generic.Dictionary<System.String, System.Single> val_1 = 与且丂丅丁专丙业丙.Deserialize<System.Collections.Generic.Dictionary<System.String, System.Single>>(reader:  且丛三下万丂专专业);
            bool val_3 = val_1.TryGetValue(key:  "x", value: out  float val_2 = 4.22519E-38f);
            if(val_1 != null)
            {
                    bool val_5 = val_1.TryGetValue(key:  "y", value: out  float val_4 = 4.225188E-38f);
            }
            else
            {
                    bool val_7 = val_1.TryGetValue(key:  "y", value: out  float val_6 = 4.225188E-38f);
            }
            
            bool val_9 = val_1.TryGetValue(key:  "z", value: out  float val_8 = 4.225185E-38f);
            return 0;
        }
        public 丙世丐专丝丒万丛专()
        {
        
        }
    
    }

}
