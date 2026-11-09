using UnityEngine;

namespace PGCompany
{
    public class 丅丕不丂丅不丂丏丁 : JsonConverter
    {
        // Methods
        public override bool CanConvert(System.Type 与丐与不丁丗丂一东)
        {
            return System.Type.op_Equality(left:  与丐与不丁丗丂一东, right:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()));
        }
        public override object ReadJson(Newtonsoft.Json.JsonReader 且丛三下万丂专专业, System.Type 与丐与不丁丗丂一东, object 丄不丅丒不丁丁丌丘, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            string val_10;
            var val_11;
            string val_12;
            if(且丛三下万丂专专业 == 10)
            {
                    return (object)null;
            }
            
            if(且丛三下万丂专专业 != 9)
            {
                goto label_4;
            }
            
            string val_3 = 且丛三下万丂专专业.ToString().ToLower().Trim();
            uint val_4 = _PrivateImplementationDetails_.ComputeStringHash(s:  val_3);
            if(val_4 > 1303515621)
            {
                goto label_8;
            }
            
            if(val_4 > 873244444)
            {
                goto label_9;
            }
            
            if(val_4 == 184981848)
            {
                goto label_10;
            }
            
            if(val_4 != 873244444)
            {
                goto label_34;
            }
            
            val_10 = "1";
            goto label_28;
            label_4:
            if(且丛三下万丂专专业 != 7)
            {
                goto label_34;
            }
            
            if(且丛三下万丂专专业 == null)
            {
                goto label_14;
            }
            
            val_11 = null;
            if(null == val_11)
            {
                goto label_15;
            }
            
            label_14:
            if((且丛三下万丂专专业 == null) || (null != null))
            {
                goto label_34;
            }
            
            var val_5 = (null > 0) ? 1 : 0;
            return (object)null;
            label_8:
            if(val_4 > 1647734778)
            {
                goto label_19;
            }
            
            if(val_4 == 1319056784)
            {
                goto label_20;
            }
            
            if(val_4 != 1647734778)
            {
                goto label_34;
            }
            
            val_12 = "no";
            goto label_33;
            label_9:
            if(val_4 == 890022063)
            {
                goto label_23;
            }
            
            if(val_4 != 1303515621)
            {
                goto label_34;
            }
            
            val_10 = "true";
            goto label_28;
            label_19:
            if(val_4 == (-351521743))
            {
                goto label_26;
            }
            
            if(val_4 != (-66302220))
            {
                goto label_34;
            }
            
            val_10 = "y";
            goto label_28;
            label_15:
            var val_6 = (null > 0) ? 1 : 0;
            return (object)null;
            label_10:
            val_12 = "false";
            goto label_33;
            label_20:
            val_10 = "yes";
            label_28:
            if((System.String.op_Equality(a:  val_3, b:  val_10)) == false)
            {
                goto label_34;
            }
            
            return (object)null;
            label_23:
            val_12 = "0";
            goto label_33;
            label_26:
            val_12 = "n";
            label_33:
            if((System.String.op_Equality(a:  val_3, b:  val_12)) != false)
            {
                    return (object)null;
            }
            
            label_34:
            Newtonsoft.Json.JsonSerializer val_9 = new Newtonsoft.Json.JsonSerializer();
            if(val_9 != null)
            {
                    return val_9.Deserialize(reader:  且丛三下万丂专专业, objectType:  与丐与不丁丗丂一东);
            }
            
            return val_9.Deserialize(reader:  且丛三下万丂专专业, objectType:  与丐与不丁丗丂一东);
        }
        public override void WriteJson(Newtonsoft.Json.JsonWriter 业专丘专七丕丟丅与, object 丙业与丙丗丝不丈东, Newtonsoft.Json.JsonSerializer 与且丂丅丁专丙业丙)
        {
            if(业专丘专七丕丟丅与 == null)
            {
                
            }
        
        }
        public 丅丕不丂丅不丂丏丁()
        {
        
        }
    
    }

}
