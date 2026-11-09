using UnityEngine;

namespace com.amazon.mas.cpt.ads
{
    public sealed class AdPosition : Jsonable
    {
        // Fields
        private static com.amazon.mas.cpt.ads.AmazonLogger logger;
        private com.amazon.mas.cpt.ads.Ad <Ad>k__BackingField;
        private int <XCoordinate>k__BackingField;
        private int <YCoordinate>k__BackingField;
        private int <Width>k__BackingField;
        private int <Height>k__BackingField;
        
        // Properties
        public com.amazon.mas.cpt.ads.Ad Ad { get; set; }
        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        
        // Methods
        public com.amazon.mas.cpt.ads.Ad get_Ad()
        {
            return (com.amazon.mas.cpt.ads.Ad)this.<Ad>k__BackingField;
        }
        public void set_Ad(com.amazon.mas.cpt.ads.Ad value)
        {
            this.<Ad>k__BackingField = value;
        }
        public int get_XCoordinate()
        {
            return (int)this.<XCoordinate>k__BackingField;
        }
        public void set_XCoordinate(int value)
        {
            this.<XCoordinate>k__BackingField = value;
        }
        public int get_YCoordinate()
        {
            return (int)this.<YCoordinate>k__BackingField;
        }
        public void set_YCoordinate(int value)
        {
            this.<YCoordinate>k__BackingField = value;
        }
        public int get_Width()
        {
            return (int)this.<Width>k__BackingField;
        }
        public void set_Width(int value)
        {
            this.<Width>k__BackingField = value;
        }
        public int get_Height()
        {
            return (int)this.<Height>k__BackingField;
        }
        public void set_Height(int value)
        {
            this.<Height>k__BackingField = value;
        }
        public string ToJson()
        {
            return (string)Json.Serializer.Serialize(obj:  this);
        }
        public override System.Collections.Generic.Dictionary<string, object> GetObjectDictionary()
        {
            object val_2;
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            if((this.<Ad>k__BackingField) == null)
            {
                goto label_1;
            }
            
            val_2 = this.<Ad>k__BackingField;
            if(null != null)
            {
                goto label_4;
            }
            
            goto label_3;
            label_1:
            val_2 = 0;
            if(null != null)
            {
                goto label_4;
            }
            
            label_3:
            label_4:
            null.Add(key:  "ad", value:  val_2);
            null.Add(key:  "xCoordinate", value:  this.<XCoordinate>k__BackingField);
            null.Add(key:  "yCoordinate", value:  this.<YCoordinate>k__BackingField);
            null.Add(key:  "width", value:  this.<Width>k__BackingField);
            null.Add(key:  "height", value:  this.<Height>k__BackingField);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)null;
        }
        public static com.amazon.mas.cpt.ads.AdPosition CreateFromDictionary(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            object val_18;
            var val_19;
            if(jsonMap == null)
            {
                goto label_1;
            }
            
            val_18 = new com.amazon.mas.cpt.ads.AdPosition();
            val_18 = new System.Object();
            if((jsonMap.ContainsKey(key:  "ad")) == false)
            {
                goto label_2;
            }
            
            object val_3 = jsonMap.Item["ad"];
            val_19 = 0;
            goto label_7;
            label_1:
            val_18 = 0;
            return (com.amazon.mas.cpt.ads.AdPosition)val_18;
            label_7:
            .<Ad>k__BackingField = com.amazon.mas.cpt.ads.Ad.CreateFromDictionary(jsonMap:  null);
            label_2:
            if((jsonMap.ContainsKey(key:  "xCoordinate")) != false)
            {
                    .<XCoordinate>k__BackingField = System.Convert.ToInt32(value:  jsonMap.Item["xCoordinate"]);
            }
            
            if((jsonMap.ContainsKey(key:  "yCoordinate")) != false)
            {
                    .<YCoordinate>k__BackingField = System.Convert.ToInt32(value:  jsonMap.Item["yCoordinate"]);
            }
            
            if((jsonMap.ContainsKey(key:  "width")) != false)
            {
                    .<Width>k__BackingField = System.Convert.ToInt32(value:  jsonMap.Item["width"]);
            }
            
            if((jsonMap.ContainsKey(key:  "height")) == false)
            {
                    return (com.amazon.mas.cpt.ads.AdPosition)val_18;
            }
            
            .<Height>k__BackingField = System.Convert.ToInt32(value:  jsonMap.Item["height"]);
            return (com.amazon.mas.cpt.ads.AdPosition)val_18;
        }
        public static com.amazon.mas.cpt.ads.AdPosition CreateFromJson(string jsonMessage)
        {
            string val_3 = jsonMessage;
            if(val_3 != null)
            {
                    object val_1 = Json.Parser.Parse(jsonString:  val_3 = jsonMessage);
                val_3 = 0;
            }
            
            com.amazon.mas.cpt.ads.Jsonable.CheckForErrors(jsonMap:  null);
            return (com.amazon.mas.cpt.ads.AdPosition)com.amazon.mas.cpt.ads.AdPosition.CreateFromDictionary(jsonMap:  null);
        }
        public static System.Collections.Generic.Dictionary<string, com.amazon.mas.cpt.ads.AdPosition> MapFromJson(System.Collections.Generic.Dictionary<string, object> jsonMap)
        {
            var val_7;
            System.Collections.Generic.Dictionary<System.String, com.amazon.mas.cpt.ads.AdPosition> val_1 = new System.Collections.Generic.Dictionary<System.String, com.amazon.mas.cpt.ads.AdPosition>();
            Dictionary.Enumerator<TKey, TValue> val_2 = jsonMap.GetEnumerator();
            label_9:
            if(((-1886173544) & 1) == 0)
            {
                goto label_2;
            }
            
            ConfiguredValueTaskAwaiter val_3 = 0.GetAwaiter();
            val_7 = 0;
            val_1.Add(key:  val_3._value._obj.丐丏七丌丕丗业且上(), value:  com.amazon.mas.cpt.ads.AdPosition.CreateFromDictionary(jsonMap:  null));
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public static System.Collections.Generic.List<com.amazon.mas.cpt.ads.AdPosition> ListFromJson(System.Collections.Generic.List<object> array)
        {
            var val_4;
            var val_8;
            System.Collections.Generic.List<com.amazon.mas.cpt.ads.AdPosition> val_1 = new System.Collections.Generic.List<com.amazon.mas.cpt.ads.AdPosition>();
            List.Enumerator<T> val_2 = array.GetEnumerator();
            label_9:
            if(((-1886026704) & 1) == 0)
            {
                goto label_2;
            }
            
            string val_5 = val_4.丐丏七丌丕丗业且上();
            val_8 = 0;
            val_1.Add(item:  com.amazon.mas.cpt.ads.AdPosition.CreateFromDictionary(jsonMap:  null));
            goto label_9;
            label_2:
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            return val_1;
        }
        public AdPosition()
        {
            val_1 = new System.Object();
        }
        private static AdPosition()
        {
            .tag = "Pi";
            com.amazon.mas.cpt.ads.AdPosition.logger = new com.amazon.mas.cpt.ads.AmazonLogger();
        }
    
    }

}
