using UnityEngine;
private sealed class 一专丑丂丛丄与上丁.三丈丐丈丞丙业世丙 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public bool 且丏下一下上丟与丐;
    public Rilisoft.一专丑丂丛丄与上丁 丝且与丝丒丟万丁专;
    public bool 丟东丈丗丏丛世万一;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 一专丑丂丛丄与上丁.三丈丐丈丞丙业世丙(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.AchievementProgressSyncObject val_17;
        var val_18;
        var val_19;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.且丏下一下上丟与丐 == false)
        {
                return false;
        }
        
        if(this.丝且与丝丒丟万丁专.不丏丟丐丙丏丁下丕() == null)
        {
            goto label_4;
        }
        
        Rilisoft.丆专且丆世丟丄与丂 val_2 = this.丝且与丝丒丟万丁专.不丏丟丐丙丏丁下丕();
        if(val_2 == null)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "AchievementsCloudApplyer currentPullResult == null", args:  System.Array.Empty<System.Object>());
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_2)) == false)
        {
            goto label_12;
        }
        
        val_17 = new Rilisoft.AchievementProgressSyncObject();
        val_17 = new Rilisoft.AchievementProgressSyncObject();
        goto label_13;
        label_4:
        UnityEngine.Debug.LogErrorFormat(format:  "AchievementsCloudApplyer.Apply: SlotSynchronizer == null", args:  System.Array.Empty<System.Object>());
        return false;
        label_12:
        val_17 = Rilisoft.AchievementProgressSyncObject.丘专专下东下丟与东(丌且专不丙丕专丅万:  val_2);
        label_13:
        Rilisoft.AchievementProgressSyncObject val_8 = Rilisoft.一专丑丂丛丄与上丁.专丑丘丌丆丏丁丞丅();
        Rilisoft.AchievementProgressSyncObject val_9 = Rilisoft.AchievementProgressData.丝丅丌丁丒丟三丏上(丐丕丆丟丗丑三丙业:  val_8, 丗丅丙丏丝一七东丗:  val_17);
        object val_17 = val_8;
        val_18 = null;
        val_18 = null;
        val_19 = 0;
        val_17 = (~val_17) & 1;
        if((Rilisoft.丐丌丝七下丈丒丅丗.业七丈万丏丑丅丟且 == null) && (val_17 != 0))
        {
                bool val_18 = this.丟东丈丗丏丛世万一;
            val_18 = val_18 ^ 1;
            val_19 = val_18 & 255;
        }
        
        val_19 = val_19 & this.且丏下一下上丟与丐;
        if(val_19 != false)
        {
                if(AuthSceneController.丑七不且上丗丁一世() == 0)
        {
                Rilisoft.一专丑丂丛丄与上丁.丈丁不丙丝三三专下(丝世丄下丁与万上一:  val_9);
        }
        
        }
        
        object[] val_12 = new object[5];
        val_12[0] = val_2;
        val_12[1] = UnityEngine.JsonUtility.ToJson(obj:  val_8);
        val_12[2] = UnityEngine.JsonUtility.ToJson(obj:  val_17);
        val_12[3] = UnityEngine.JsonUtility.ToJson(obj:  val_9);
        val_12[4] = val_17;
        UnityEngine.Debug.LogFormat(format:  "AchievementsCloudApplyer: Succeeded to apply achievemnts:\n\'currentPullResult\':{0},\n\'localAchievements\':{1},\n\'cloudAchievements\':{2},\n\'mergedAchievements\':{3},\n\'localDirty\':{4}", args:  val_12);
        return false;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
