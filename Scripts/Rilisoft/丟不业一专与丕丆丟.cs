using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丟不业一专与丕丆丟
    {
        // Fields
        private readonly string 与七丞东东一一丌且;
        
        // Properties
        internal static string 东丅丝丟丘上丄丒世 { get; }
        public bool 专丆上一下与丐下业 { set; }
        internal static bool 专且丏七丄丁丏丙丑 { set; }
        
        // Methods
        public 丟不业一专与丕丆丟(string 万下丈世丏业丛丕不, string 丈万三丞丝丄三丆不)
        {
            string val_4;
            val_1 = new System.Object();
            if(万下丈世丏业丛丕不 == null)
            {
                goto label_1;
            }
            
            if(val_1 == null)
            {
                goto label_2;
            }
            
            this.与七丞东东一一丌且 = 万下丈世丏业丛丕不;
            return;
            label_1:
            val_4 = "appKey";
            goto label_3;
            label_2:
            val_4 = "secretKey";
            label_3:
            null = new System.ArgumentNullException(paramName:  val_4);
        }
        internal static string 丟业丅世丟丗丄丞万()
        {
            return (string)System.String.alignConst;
        }
        public void 丝丌不东丑丁丞下七(string 丝丏业丅丈东业丝丒)
        {
            var val_5;
            if(丝丏业丅丈东业丝丒 == null)
            {
                goto label_1;
            }
            
            if((System.String.IsNullOrEmpty(value:  丝丏业丅丈东业丝丒)) == true)
            {
                goto label_2;
            }
            
            bool val_2 = System.String.IsNullOrEmpty(value:  this.与七丞东东一一丌且);
            return;
            label_1:
            System.ArgumentNullException val_3 = null;
            val_5 = val_3;
            val_3 = new System.ArgumentNullException(paramName:  "eventName");
            goto label_3;
            label_2:
            System.ArgumentException val_4 = null;
            val_5 = val_4;
            val_4 = new System.ArgumentException(message:  "Event name must not be empty.", paramName:  "eventName");
            label_3:
        }
        public void 不丘丙丑丝丅丕不世(string 万七上丁丄丘业丁丂, string 万丐丝一万专上且丝, int 上且且世业上丒丘丒, int 三丝丁丞丒丒与丑丆, string 丁业丕业丞丏与丝世)
        {
            string val_3 = 万七上丁丄丘业丁丂.Substring(startIndex:  0, length:  System.Math.Min(val1:  万七上丁丄丘业丁丂.Length, val2:  32));
            string val_6 = 万丐丝一万专上且丝.Substring(startIndex:  0, length:  System.Math.Min(val1:  万丐丝一万专上且丝.Length, val2:  96));
        }
        public void 丘丄丁丄下丕东丏丈(string 丘丛丛丘丂丙且与丛, float 丕丆且丏业一三世丅, string 丛丅丗世丗不丈下万, string 与且一丟丞专丌丗丛)
        {
        
        }
        public void 一丞丕丛三一丁丒丒(int 丛丁三世世丆七不业, string 丅不一丞丘丕丄丈丏, Rilisoft.丟业七不丝丟下丂丒.丌丑丄丆不丗世三丕 丅丅丞丙丁丕丌世东)
        {
        
        }
        public void 上丗丏丒万丏丑丄万(int 丈丘丝一丗下丈丐不, System.Collections.Generic.Dictionary<string, int> 上上三丅不丞丕一丈)
        {
        
        }
        public void 丝丌不东丑丁丞下七(string 丝丏业丅丈东业丝丒, System.Collections.Generic.IDictionary<string, object> 丛东不丒丏丈丄且丕)
        {
            string val_6;
            var val_7;
            if(丝丏业丅丈东业丝丒 == null)
            {
                goto label_1;
            }
            
            if(丛东不丒丏丈丄且丕 == null)
            {
                goto label_2;
            }
            
            if((System.String.IsNullOrEmpty(value:  丝丏业丅丈东业丝丒)) == true)
            {
                goto label_3;
            }
            
            bool val_2 = System.String.IsNullOrEmpty(value:  this.与七丞东东一一丌且);
            return;
            label_1:
            val_6 = "eventName";
            goto label_4;
            label_2:
            System.ArgumentNullException val_3 = null;
            val_6 = "eventParams";
            label_4:
            val_7 = val_3;
            val_3 = new System.ArgumentNullException(paramName:  val_6);
            goto label_5;
            label_3:
            System.ArgumentException val_4 = null;
            val_7 = val_4;
            val_4 = new System.ArgumentException(message:  "Event name must not be empty.", paramName:  "eventName");
            label_5:
        }
        public void 一丈丝丞丏丐丅丟上(bool 丙业与丙丗丝不丈东)
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  this.与七丞东东一一丌且);
        }
        internal static void 万且丏专一不上万下(bool 丙业与丙丗丝不丈东)
        {
        
        }
        public void 丌丅丗丘与丅丆丒三()
        {
            bool val_1 = System.String.IsNullOrEmpty(value:  this.与七丞东东一一丌且);
        }
    
    }

}
