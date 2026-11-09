using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丌世丘丝丞丞丁丑上 : 丙丐丐丙丈业丒不丁
    {
        // Methods
        protected override System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 下丟不上丏丝丞丒丟(AGSGameDataMap 丟丝上三丙丁丁世丁)
        {
            var val_11;
            var val_12;
            AGSGameDataMap val_1 = 丟丝上三丙丁丁世丁.GetMap(name:  "trophiesMap");
            val_11 = val_1.GetHighestNumber(name:  "trophiesNegative");
            val_12 = val_1.GetHighestNumber(name:  "trophiesPositive");
            AGSSyncableNumber val_4 = val_1.GetHighestNumber(name:  "season");
            if(val_11 != null)
            {
                    val_11 = val_11.AsInt();
            }
            
            if(val_12 != null)
            {
                    val_12 = val_12.AsInt();
            }
            
            if(val_4 != null)
            {
                    int val_7 = val_4.AsInt();
            }
            
            this.丄丈上一丙且万丅丞(丙业与丙丗丝不丈东:  UnityEngine.JsonUtility.ToJson(obj:  0));
            this.丞专世丗丛不丘丗丘(丙业与丙丗丝不丈东:  true);
            if(val_1 == null)
            {
                    return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  0);
            }
            
            var val_11 = 0;
            val_11 = val_11 + 1;
            val_1.Dispose();
            return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  0);
        }
        protected override void 且且且丝丆一丄丗一(AGSGameDataMap 丟丝上三丙丁丁世丁, string 一丐丗丁丞丆丅丟丄)
        {
            var val_7;
            AGSGameDataMap val_8 = 丟丝上三丙丁丁世丁;
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            Rilisoft.TrophiesMemento val_1 = UnityEngine.JsonUtility.FromJson<Rilisoft.TrophiesMemento>(json:  一丐丗丁丞丆丅丟丄);
            val_8 = val_8.GetMap(name:  "trophiesMap");
            val_8.GetHighestNumber(name:  "trophiesNegative").Set(val:  -765169296);
            val_8.GetHighestNumber(name:  "trophiesPositive").Set(val:  -765169296);
            val_8.GetHighestNumber(name:  "season").Set(val:  -765169296);
            val_7 = 0;
            if(val_8 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
                val_8.Dispose();
            }
            
            if(val_7 != 1)
            {
                    return;
            }
            
            if(0 == 0)
            {
                    return;
            }
        
        }
        public 丌世丘丝丞丞丁丑上()
        {
        
        }
    
    }

}
