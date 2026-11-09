using UnityEngine;

namespace Progress
{
    [Serializable]
    internal class StarterPackProgress : ICloneable
    {
        // Fields
        internal int SeasonId;
        
        // Methods
        internal static System.Collections.Generic.Dictionary<string, object> 丁丕上三丕丌丟丗丙(Progress.StarterPackProgress 七丏丄丅丌业与且丙)
        {
            System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
            val_1.set_Item(key:  "s", value:  七丏丄丅丌业与且丙.SeasonId);
            return val_1;
        }
        internal static System.Collections.Generic.Dictionary<string, object> 丝丟丛丘一一且上三(Progress.StarterPackProgress 丛三七丟丗与专丙丂, Progress.StarterPackProgress 三丂丑丁丞丞丅东三)
        {
            Progress.StarterPackProgress val_4;
            if((三丂丑丁丞丞丅东三 | 丛三七丟丗与专丙丂) == null)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)new System.Collections.Generic.Dictionary<System.String, System.Object>();
            }
            
            if(丛三七丟丗与专丙丂 == null)
            {
                goto label_2;
            }
            
            if(三丂丑丁丞丞丅东三 == null)
            {
                goto label_3;
            }
            
            if(三丂丑丁丞丞丅东三.SeasonId == 丛三七丟丗与专丙丂.SeasonId)
            {
                    return (System.Collections.Generic.Dictionary<System.String, System.Object>)new System.Collections.Generic.Dictionary<System.String, System.Object>();
            }
            
            new System.Collections.Generic.Dictionary<System.String, System.Object>().Add(key:  "s", value:  三丂丑丁丞丞丅东三.SeasonId);
            return (System.Collections.Generic.Dictionary<System.String, System.Object>)new System.Collections.Generic.Dictionary<System.String, System.Object>();
            label_2:
            val_4 = 三丂丑丁丞丞丅东三;
            return Progress.StarterPackProgress.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  val_4 = 丛三七丟丗与专丙丂);
            label_3:
            return Progress.StarterPackProgress.丁丕上三丕丌丟丗丙(七丏丄丅丌业与且丙:  val_4);
        }
        public object Clone()
        {
            .SeasonId = this.SeasonId;
            return (object)new Progress.StarterPackProgress();
        }
        public StarterPackProgress()
        {
        
        }
    
    }

}
