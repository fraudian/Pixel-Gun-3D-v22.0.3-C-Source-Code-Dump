using UnityEngine;
private sealed class LeaderboardEventController.不丁丈一丅丏上丘丁 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LeaderboardEventController 丝且与丝丒丟万丁专;
    public int 丟丟丄专上丟丁丐丝;
    public bool 丛专下丞丒丛下下与;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeaderboardEventController.不丁丈一丅丏上丘丁(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        LeaderboardEventController val_14;
        var val_15;
        FriendsController val_16;
        int val_17;
        string val_18;
        int val_19;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_23;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_14 = this.丝且与丝丒丟万丁专;
        if((FriendsController.丝丗专上三不丄丑丑() & 9223372036854775808) != 0)
        {
            goto label_16;
        }
        
        val_15 = null;
        val_15 = null;
        val_16 = FriendsController.丄丞丁丈与业上丞丟;
        if((((val_16 == 0) || ((System.String.IsNullOrEmpty(value:  FriendsController.不丝丕丒丂丆丘丙丙())) == true)) || (AuthSceneController.一不丆丏与丐丏丈丄() == false)) || (下丟世丏三东万丘丏.下不丙丌丙丞丞万上() == false))
        {
            goto label_16;
        }
        
        val_17 = this.丝且与丝丒丟万丁专.下丗丏丑丛上丟且丒;
        val_16 = this.丟丟丄专上丟丁丐丝;
        val_18 = "";
        if((val_16.Equals(obj:  0)) != true)
        {
                if((val_14.不专万丅世万世丙丑(丟丟丄专上丟丁丐丝:  val_16)) != null)
        {
                val_18 = val_8._id;
            val_17 = val_8._dataTimestamp;
        }
        
        }
        
        if(this.丛专下丞丒丛下下与 == false)
        {
            goto label_20;
        }
        
        long val_9 = FriendsController.丝丗专上三不丄丑丑();
        float val_14 = 1200f;
        val_14 = (float)val_17 + val_14;
        if(val_14 > (float)val_9)
        {
            goto label_23;
        }
        
        label_20:
        val_16 = CoroutineRunner.Instance;
        val_14 = val_14.丙丌不一丁丑丂下不(东丞丒丙世丏三下丟:  val_9.业丁丛丕不丗丘七不(丟丟丄专上丟丁丐丝:  val_16, 丟丏东丅且丅丌一上:  val_18, 一丏一世丘丐丁丄丟:  val_17), 且丙丂丕丆丛业丌不:  val_16);
        UnityEngine.Coroutine val_13 = val_16.StartCoroutine(routine:  val_14);
        label_23:
        val_19 = 0;
        return (bool)val_19;
        label_16:
        val_19 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_19;
        return (bool)val_19;
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
