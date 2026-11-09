using UnityEngine;

namespace PGCompany
{
    public class 丏丑丂不丄不丘丈丂 : JsonConverter
    {
        // Methods
        public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public override object ReadJson(Newtonsoft.Json.JsonReader 且丛三下万丂专专业, System.Type 与丐与不丁丗丂一东, object 丄不丅丒不丁丁丌丘, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            string val_5;
            var val_6;
            val_5 = 且丛三下万丂专专业;
            if(val_5 == 9)
            {
                    val_5 = val_5.ToString();
                Newtonsoft.Json.JsonConverter[] val_2 = new Newtonsoft.Json.JsonConverter[1];
                val_2[0] = new PGCompany.万丑丐丕丞专三不万<PGCompany.GameTaskActionSettings>();
                PGCompany.且丟一七万东丁三上<PGCompany.GameTaskActionSettings> val_4 = Newtonsoft.Json.JsonConvert.DeserializeObject<PGCompany.且丟一七万东丁三上<PGCompany.GameTaskActionSettings>>(value:  val_5, converters:  val_2);
                return (object)val_6;
            }
            
            val_6 = 0;
            return (object)val_6;
        }
        public override bool CanConvert(System.Type 与丐与不丁丗丂一东)
        {
            System.NotImplementedException val_1 = new System.NotImplementedException();
        }
        public 丏丑丂不丄不丘丈丂()
        {
        
        }
    
    }

}
