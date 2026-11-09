using UnityEngine;
[Serializable]
public class 上专业三丟丁丞专下.ChestProgressDataObject : ISerializationCallbackReceiver
{
    // Fields
    private int _freeSpinTimerStart;
    public System.Collections.Generic.List<int> ContainersPositions;
    public int CurrentLap;
    public System.Collections.Generic.List<int> DropContainersHistory;
    public System.Collections.Generic.List<int> DroppedContainers;
    public System.Collections.Generic.List<int> ExcludeContainers;
    public bool LastLapRewardGetted;
    public int LastResetTime;
    public int ResetInterval;
    public int SpinsCount;
    
    // Properties
    public System.Nullable<System.DateTime> FreeSpinTimerStartAt { get; set; }
    
    // Methods
    public System.Nullable<System.DateTime> get_FreeSpinTimerStartAt()
    {
        if((this._freeSpinTimerStart & 2147483648) != 0)
        {
                return 0;
        }
        
        System.DateTime val_1 = 专七专下且专三一且.丆丁丑东专与丁七丞(丌丕三丌丈且丞且丆:  this._freeSpinTimerStart);
        return 0;
    }
    public void set_FreeSpinTimerStartAt(System.Nullable<System.DateTime> 丙业与丙丗丝不丈东)
    {
        int val_3;
        if(((-357388288) & 1) != 0)
        {
                System.TimeSpan val_1 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {}, d2:  new System.DateTime());
            val_3 = (int)val_1._ticks.TotalSeconds;
        }
        else
        {
                val_3 = 0;
        }
        
        this._freeSpinTimerStart = val_3;
    }
    public void OnAfterDeserialize()
    {
    
    }
    public void OnBeforeSerialize()
    {
    
    }
    internal System.Collections.Generic.Dictionary<string, object> 下丆丕业万丗下业七()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_1.Add(key:  "l", value:  this.CurrentLap);
        val_1.Add(key:  "p", value:  System.Linq.Enumerable.ToList<System.Int32>(source:  this.ContainersPositions));
        val_1.Add(key:  "h", value:  System.Linq.Enumerable.ToList<System.Int32>(source:  this.DropContainersHistory));
        val_1.Add(key:  "d", value:  System.Linq.Enumerable.ToList<System.Int32>(source:  this.DroppedContainers));
        val_1.Add(key:  "e", value:  System.Linq.Enumerable.ToList<System.Int32>(source:  this.ExcludeContainers));
        val_1.Add(key:  "rt", value:  this.LastResetTime);
        val_1.Add(key:  "ri", value:  this.ResetInterval);
        val_1.Add(key:  "c", value:  this.SpinsCount);
        return val_1;
    }
    internal System.Collections.Generic.Dictionary<string, object> 七丕且七丙丌丄七丘()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_1.Add(key:  "t", value:  this._freeSpinTimerStart);
        return val_1;
    }
    internal static Rilisoft.上专业三丟丁丞专下.ChestProgressDataObject 丌七丒七丕上丐三七(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒)
    {
        上专业三丟丁丞专下.ChestProgressDataObject val_1 = new 上专业三丟丁丞专下.ChestProgressDataObject();
        bool val_3 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "t", 丙业与丙丗丝不丈东: out  (上专业三丟丁丞专下.ChestProgressDataObject)[1152921542904903664]._freeSpinTimerStart);
        if(val_1 != null)
        {
                bool val_5 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "l", 丙业与丙丗丝不丈东: out  (上专业三丟丁丞专下.ChestProgressDataObject)[1152921542904903664].CurrentLap);
            bool val_7 = 丞东丑专丛丆丄丝世.丞丄东丈东丆丐丐七(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "p", 东且丁丆丛丁丏丘且: out  (上专业三丟丁丞专下.ChestProgressDataObject)[1152921542904903664].ContainersPositions);
            bool val_9 = 丞东丑专丛丆丄丝世.丞丄东丈东丆丐丐七(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "h", 东且丁丆丛丁丏丘且: out  (上专业三丟丁丞专下.ChestProgressDataObject)[1152921542904903664].DropContainersHistory);
            bool val_11 = 丞东丑专丛丆丄丝世.丞丄东丈东丆丐丐七(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "d", 东且丁丆丛丁丏丘且: out  (上专业三丟丁丞专下.ChestProgressDataObject)[1152921542904903664].DroppedContainers);
            bool val_13 = 丞东丑专丛丆丄丝世.丞丄东丈东丆丐丐七(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "e", 东且丁丆丛丁丏丘且: out  (上专业三丟丁丞专下.ChestProgressDataObject)[1152921542904903664].ExcludeContainers);
        }
        else
        {
                bool val_15 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "l", 丙业与丙丗丝不丈东: out  32);
            bool val_17 = 丞东丑专丛丆丄丝世.丞丄东丈东丆丐丐七(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "p", 东且丁丆丛丁丏丘且: out  24);
            bool val_19 = 丞东丑专丛丆丄丝世.丞丄东丈东丆丐丐七(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "h", 东且丁丆丛丁丏丘且: out  System.Collections.Generic.List<System.Int32> val_18 = 40);
            bool val_21 = 丞东丑专丛丆丄丝世.丞丄东丈东丆丐丐七(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "d", 东且丁丆丛丁丏丘且: out  48);
            bool val_23 = 丞东丑专丛丆丄丝世.丞丄东丈东丆丐丐七(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "e", 东且丁丆丛丁丏丘且: out  56);
        }
        
        bool val_25 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "rt", 丙业与丙丗丝不丈东: out  (上专业三丟丁丞专下.ChestProgressDataObject)[1152921542904903664].LastResetTime);
        if(val_1 != null)
        {
                bool val_27 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "ri", 丙业与丙丗丝不丈东: out  (上专业三丟丁丞专下.ChestProgressDataObject)[1152921542904903664].ResetInterval);
        }
        else
        {
                bool val_29 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "ri", 丙业与丙丗丝不丈东: out  int val_28 = 72);
        }
        
        bool val_31 = 丞东丑专丛丆丄丝世.且丏三丝下丒丄东下<System.Int32>(丏丂万业丙专丏丒丒:  丏丂万业丙专丏丒丒, 下上丐丆丝丟丝丒不:  "c", 丙业与丙丗丝不丈东: out  (上专业三丟丁丞专下.ChestProgressDataObject)[1152921542904903664].SpinsCount);
        return (ChestProgressDataObject)val_1;
    }
    internal Rilisoft.上专业三丟丁丞专下.ChestProgressDataObject 丒丟丗丏与丒七与丙()
    {
        return 上专业三丟丁丞专下.ChestProgressDataObject.丌七丒七丕上丐三七(丏丂万业丙专丏丒丒:  this.下丆丕业万丗下业七());
    }
    internal Rilisoft.上专业三丟丁丞专下.ChestProgressDataObject 不上丄与丁不丌丕丕()
    {
        return 上专业三丟丁丞专下.ChestProgressDataObject.丌七丒七丕上丐三七(丏丂万业丙专丏丒丒:  this.七丕且七丙丌丄七丘());
    }
    internal static System.Collections.Generic.Dictionary<string, object> 丘上上丗丝丂丄世七(Rilisoft.GameEventType 与世丗且丟丁不专丏, Rilisoft.上专业三丟丁丞专下.ChestProgressDataObject 上丕专上且上丕万丘, Rilisoft.上专业三丟丁丞专下.ChestProgressDataObject 丕与丑七与万丄丂丂)
    {
        object val_10;
        string val_11;
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(丕与丑七与万丄丂丂 == null)
        {
                return val_1;
        }
        
        if(上丕专上且上丕万丘 == null)
        {
            goto label_2;
        }
        
        if(与世丗且丟丁不专丏 != 100)
        {
            goto label_3;
        }
        
        if(上丕专上且上丕万丘._freeSpinTimerStart == 丕与丑七与万丄丂丂._freeSpinTimerStart)
        {
                return val_1;
        }
        
        val_10 = 丕与丑七与万丄丂丂._freeSpinTimerStart;
        val_11 = "t";
        goto label_6;
        label_2:
        if(与世丗且丟丁不专丏 != 100)
        {
                return 丕与丑七与万丄丂丂.下丆丕业万丗下业七();
        }
        
        return 丕与丑七与万丄丂丂.七丕且七丙丌丄七丘();
        label_3:
        if(上丕专上且上丕万丘.CurrentLap != 丕与丑七与万丄丂丂.CurrentLap)
        {
                val_1.Add(key:  "l", value:  丕与丑七与万丄丂丂.CurrentLap);
        }
        
        if((System.Linq.Enumerable.SequenceEqual<System.Int32>(first:  上丕专上且上丕万丘.ContainersPositions, second:  丕与丑七与万丄丂丂.ContainersPositions)) != true)
        {
                val_1.Add(key:  "p", value:  System.Linq.Enumerable.ToList<System.Int32>(source:  丕与丑七与万丄丂丂.ContainersPositions));
        }
        
        if((System.Linq.Enumerable.SequenceEqual<System.Int32>(first:  上丕专上且上丕万丘.DropContainersHistory, second:  丕与丑七与万丄丂丂.DropContainersHistory)) != true)
        {
                val_1.Add(key:  "h", value:  System.Linq.Enumerable.ToList<System.Int32>(source:  丕与丑七与万丄丂丂.DropContainersHistory));
        }
        
        if((System.Linq.Enumerable.SequenceEqual<System.Int32>(first:  上丕专上且上丕万丘.DroppedContainers, second:  丕与丑七与万丄丂丂.DroppedContainers)) != true)
        {
                val_1.Add(key:  "d", value:  System.Linq.Enumerable.ToList<System.Int32>(source:  丕与丑七与万丄丂丂.DroppedContainers));
        }
        
        if((System.Linq.Enumerable.SequenceEqual<System.Int32>(first:  上丕专上且上丕万丘.ExcludeContainers, second:  丕与丑七与万丄丂丂.ExcludeContainers)) != true)
        {
                val_1.Add(key:  "e", value:  System.Linq.Enumerable.ToList<System.Int32>(source:  丕与丑七与万丄丂丂.ExcludeContainers));
        }
        
        if(上丕专上且上丕万丘.LastResetTime != 丕与丑七与万丄丂丂.LastResetTime)
        {
                val_1.Add(key:  "rt", value:  丕与丑七与万丄丂丂.LastResetTime);
        }
        
        if(上丕专上且上丕万丘.ResetInterval != 丕与丑七与万丄丂丂.ResetInterval)
        {
                val_1.Add(key:  "ri", value:  丕与丑七与万丄丂丂.ResetInterval);
        }
        
        if(上丕专上且上丕万丘.SpinsCount == 丕与丑七与万丄丂丂.SpinsCount)
        {
                return val_1;
        }
        
        val_10 = 丕与丑七与万丄丂丂.SpinsCount;
        val_11 = "c";
        label_6:
        val_1.Add(key:  val_11, value:  丕与丑七与万丄丂丂.SpinsCount);
        return val_1;
    }
    public 上专业三丟丁丞专下.ChestProgressDataObject()
    {
        this._freeSpinTimerStart = 0;
        this.ContainersPositions = new System.Collections.Generic.List<System.Int32>();
        this.DropContainersHistory = new System.Collections.Generic.List<System.Int32>();
        this.DroppedContainers = new System.Collections.Generic.List<System.Int32>();
        this.ExcludeContainers = new System.Collections.Generic.List<System.Int32>();
    }

}
