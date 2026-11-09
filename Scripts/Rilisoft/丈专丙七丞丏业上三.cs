using UnityEngine;

namespace Rilisoft
{
    internal sealed class 丈专丙七丞丏业上三 : 丙丐丐丙丈业丒不丁
    {
        // Methods
        protected override System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世> 下丟不上丏丝丞丒丟(AGSGameDataMap 丟丝上三丙丁丁世丁)
        {
            object val_6;
            var val_18;
            var val_19;
            var val_20;
            var val_21;
            var val_22;
            var val_24;
            AGSGameDataMap val_1 = 丟丝上三丙丁丁世丁.GetMap(name:  "campaignProgressMap");
            AGSGameDataMap val_2 = val_1.GetMap(name:  "levels");
            HashSet.Enumerator<T> val_4 = val_2.GetMapKeys().GetEnumerator();
            label_17:
            if(((-768695728) & 1) == 0)
            {
                goto label_5;
            }
            
            string val_7 = val_6.丐丏七丌丕丗业且上();
            AGSGameDataMap val_8 = val_2.GetMap(name:  val_7);
            if(val_8 == null)
            {
                goto label_17;
            }
            
            new Rilisoft.LevelProgressMemento() = new Rilisoft.LevelProgressMemento(丒丘丑丅且丆丘东丂:  val_7);
            AGSSyncableNumber val_10 = val_8.GetHighestNumber(name:  "coinCount");
            if(val_10 == null)
            {
                goto label_8;
            }
            
            val_18 = val_10.AsInt();
            if(new Rilisoft.LevelProgressMemento() != null)
            {
                goto label_11;
            }
            
            goto label_10;
            label_8:
            val_18 = 0;
            if(new Rilisoft.LevelProgressMemento() != null)
            {
                goto label_11;
            }
            
            label_10:
            label_11:
            new Rilisoft.LevelProgressMemento().CoinCount = 0;
            AGSSyncableNumber val_12 = val_8.GetHighestNumber(name:  "gemCount");
            if(val_12 == null)
            {
                goto label_12;
            }
            
            val_19 = val_12.AsInt();
            if(new Rilisoft.LevelProgressMemento() != null)
            {
                goto label_15;
            }
            
            goto label_14;
            label_12:
            val_19 = 0;
            if(new Rilisoft.LevelProgressMemento() != null)
            {
                goto label_15;
            }
            
            label_14:
            label_15:
            new Rilisoft.LevelProgressMemento().GemCount = 0;
            0.Add(item:  new Rilisoft.LevelProgressMemento());
            goto label_17;
            label_5:
            val_20 = 0;
            val_21 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if(( != 1) && (188 == 188))
            {
                    val_20 = 0;
            }
            else
            {
                    if( != 0)
            {
                    val_21 = 0;
            }
            
            }
            
            val_6 = 0;
            this.丄丈上一丙且万丅丞(丙业与丙丗丝不丈东:  UnityEngine.JsonUtility.ToJson(obj:  val_6));
            this.丞专世丗丛不丘丗丘(丙业与丙丗丝不丈东:  true);
            val_22 = 1;
            if(val_2 != null)
            {
                goto label_36;
            }
            
            goto label_39;
            label_72:
            if((public System.Boolean HashSet.Enumerator<System.String>::MoveNext()) != 1)
            {
                goto label_55;
            }
            
            val_21 = val_6;
            if(val_2 == null)
            {
                goto label_39;
            }
            
            label_36:
            var val_18 = 0;
            val_18 = val_18 + 1;
            val_2.Dispose();
            label_39:
            if( == 1)
            {
                goto label_44;
            }
            
            if(val_21 == 0)
            {
                goto label_47;
            }
            
            if(188 != 236)
            {
                goto label_46;
            }
            
            goto label_47;
            label_44:
            if(val_21 == 0)
            {
                goto label_48;
            }
            
            label_46:
            val_21 = 0;
            val_24 = 0;
            if(val_1 != null)
            {
                goto label_51;
            }
            
            goto label_59;
            label_48:
            val_24 = 0;
            val_22 = 0;
            if(val_1 != null)
            {
                goto label_51;
            }
            
            goto label_59;
            label_55:
            if((public System.Boolean HashSet.Enumerator<System.String>::MoveNext()) != 1)
            {
                goto label_72;
            }
            
            val_21 = val_6;
            label_47:
            val_24 = val_21;
            if(val_1 == null)
            {
                goto label_59;
            }
            
            label_51:
            var val_19 = 0;
            val_19 = val_19 + 1;
            val_1.Dispose();
            label_59:
            if( != 1)
            {
                    if((val_24 == 0) || (188 == 236))
            {
                    return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  0);
            }
            
                return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  0);
            }
            
            if(val_24 != 0)
            {
                    return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  0);
            }
            
            return (System.Threading.Tasks.Task<Rilisoft.丌业丒一丛专万三世>)System.Threading.Tasks.Task.FromResult<Rilisoft.丌业丒一丛专万三世>(result:  0);
        }
        protected override void 且且且丝丆一丄丗一(AGSGameDataMap 丟丝上三丙丁丁世丁, string 一丐丗丁丞丆丅丟丄)
        {
            var val_6;
            var val_17;
            var val_18;
            var val_19;
            var val_20;
            var val_22;
            val_18 = 丟丝上三丙丁丁世丁;
            if(一丐丗丁丞丆丅丟丄 == null)
            {
                    return;
            }
            
            Rilisoft.CampaignProgressMemento val_1 = UnityEngine.JsonUtility.FromJson<Rilisoft.CampaignProgressMemento>(json:  一丐丗丁丞丆丅丟丄);
            val_18 = val_18.GetMap(name:  "campaignProgressMap");
            AGSGameDataMap val_3 = val_18.GetMap(name:  "levels");
            List.Enumerator<T> val_4 = val_1.levels.GetEnumerator();
            label_13:
            if(((-768493552) & 1) == 0)
            {
                goto label_5;
            }
            
            string val_7 = val_6.丐丏七丌丕丗业且上();
            AGSGameDataMap val_9 = val_3.GetMap(name:  val_7.LevelId);
            if(val_9 == null)
            {
                goto label_13;
            }
            
            val_9.GetHighestNumber(name:  "coinCount").Set(val:  val_7.CoinCount);
            val_9.GetHighestNumber(name:  "gemCount").Set(val:  val_7.GemCount);
            goto label_13;
            label_5:
            val_19 = 0;
            val_17 = 0;
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            if( == 1)
            {
                goto label_26;
            }
            
            val_20 = 0;
            if(val_3 != null)
            {
                goto label_30;
            }
            
            goto label_33;
            label_26:
            if( != 0)
            {
                    val_17 = 0;
            }
            
            val_20 = 0;
            if(val_3 != null)
            {
                goto label_30;
            }
            
            goto label_33;
            label_52:
            if((public System.Boolean List.Enumerator<Rilisoft.LevelProgressMemento>::MoveNext()) != 1)
            {
                goto label_43;
            }
            
            val_17 = val_6;
            if(val_3 == null)
            {
                goto label_33;
            }
            
            label_30:
            var val_16 = 0;
            val_16 = val_16 + 1;
            val_3.Dispose();
            label_33:
            if( != 1)
            {
                goto label_38;
            }
            
            if(val_17 != 0)
            {
                    val_17 = 0;
            }
            
            val_22 = 0;
            val_20 = 0;
            if(val_18 != null)
            {
                goto label_40;
            }
            
            goto label_45;
            label_43:
            if((public System.Boolean List.Enumerator<Rilisoft.LevelProgressMemento>::MoveNext()) != 1)
            {
                goto label_52;
            }
            
            val_17 = val_6;
            label_38:
            val_22 = val_17;
            if(val_18 == null)
            {
                goto label_45;
            }
            
            label_40:
            var val_17 = 0;
            val_17 = val_17 + 1;
            val_18.Dispose();
            label_45:
            if( != 1)
            {
                    return;
            }
            
            if(val_22 == 0)
            {
                    return;
            }
        
        }
        public 丈专丙七丞丏业上三()
        {
        
        }
    
    }

}
