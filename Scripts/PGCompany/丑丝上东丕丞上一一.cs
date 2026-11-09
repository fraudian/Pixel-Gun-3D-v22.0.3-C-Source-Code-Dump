using UnityEngine;

namespace PGCompany
{
    public class 丑丝上东丕丞上一一 : JsonConverter
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
            var val_4;
            var val_14;
            var val_15;
            val_14 = 丙业与丙丗丝不丈东;
            if(val_14 != null)
            {
                    val_14 = 0;
            }
            
            if(val_14 == 0)
            {
                    return;
            }
            
            val_15 = public System.Int32 System.Collections.Generic.List<Rilisoft.GameCurrencyData>::get_Count();
            if(val_14.Count < 1)
            {
                    return;
            }
            
            List.Enumerator<T> val_2 = val_14.GetEnumerator();
            label_11:
            if((2122504976 & 1) == 0)
            {
                goto label_6;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            string val_8 = val_5.Currency.丟丂丞不专丆万丒世().ToString();
            string val_11 = val_5.Price.丟丂丞不专丆万丒世().ToString();
            goto label_11;
            label_6:
            val_15 = public System.Void List.Enumerator<Rilisoft.GameCurrencyData>::Dispose();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        }
        public override object ReadJson(Newtonsoft.Json.JsonReader 且丛三下万丂专专业, System.Type 与丐与不丁丗丂一东, object 丄不丅丒不丁丁丌丘, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            string val_8;
            Rilisoft.GameCurrencyData val_9;
            string val_10;
            string val_12;
            var val_13;
            System.Collections.Generic.List<Rilisoft.GameCurrencyData> val_1 = new System.Collections.Generic.List<Rilisoft.GameCurrencyData>();
            if(且丛三下万丂专专业 != 1)
            {
                    return (object)val_1;
            }
            
            int val_3 = 0;
            if(且丛三下万丂专专业 == 13)
            {
                    return (object)val_1;
            }
            
            label_23:
            if(且丛三下万丂专专业 != 4)
            {
                goto label_9;
            }
            
            val_8 = 且丛三下万丂专专业;
            if(val_8 != null)
            {
                    if(null != null)
            {
                    val_8 = 0;
            }
            
            }
            
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_8, 丙业与丙丗丝不丈东: out  val_3)) == true)
            {
                goto label_14;
            }
            
            goto label_15;
            label_9:
            if(且丛三下万丂专专业 != 9)
            {
                goto label_16;
            }
            
            val_10 = 且丛三下万丂专专业;
            if(val_10 != null)
            {
                    if(null != null)
            {
                    val_10 = 0;
            }
            
            }
            
            if((丞东丑专丛丆丄丝世.丄丂丄丁丘丆不下丏(丞丕丒专一下丙业上:  val_10, 丙业与丙丗丝不丈东: out  val_3)) == false)
            {
                goto label_21;
            }
            
            Rilisoft.GameCurrencyData val_6 = null;
            val_8 = val_6;
            val_6 = new Rilisoft.GameCurrencyData(丑丏万丈丟丝丝丌丗:  0, 丏丂不专上丘丂不丅:  "BattlePassCurrency", 丒世丘丘上丆丝东丞:  0, 丕丐丗世丌三上丌世:  "Real");
            val_9 = val_8;
            val_1.Add(item:  val_6);
            label_14:
            if(且丛三下万丂专专业 != 13)
            {
                goto label_23;
            }
            
            return (object)val_1;
            label_16:
            val_12 = "Unexpected token!";
            goto label_25;
            label_15:
            val_12 = "Error int.TryParse JsonToken.PropertyName";
            goto label_25;
            label_21:
            Newtonsoft.Json.JsonSerializationException val_7 = null;
            val_12 = "Error int.TryParse JsonToken.String";
            label_25:
            val_7 = new Newtonsoft.Json.JsonSerializationException(message:  val_12);
            val_13 = val_7;
        }
        public override bool CanConvert(System.Type 与丐与不丁丗丂一东)
        {
            return false;
        }
        public 丑丝上东丕丞上一一()
        {
        
        }
    
    }

}
