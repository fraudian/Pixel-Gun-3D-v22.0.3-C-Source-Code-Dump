using UnityEngine;
private sealed class DoubleRewardLabelMainMenu.丒丝丌丛业丌一上专 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.DoubleRewardLabelMainMenu 丝且与丝丒丟万丁专;
    private System.Nullable<System.DateTime> 丒东丗下丘下丁与丞;
    private UnityEngine.WaitForSecondsRealtime 世且丝丟丈专丆丑上;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public DoubleRewardLabelMainMenu.丒丝丌丛业丌一上专(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_7;
        bool val_8;
        int val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Nullable<System.DateTime> val_1 = FriendsController.业丈丏丏丞丘丛丈丛();
        this.丒东丗下丘下丁与丞 = val_1;
        mem[1152921542552445056] = ???;
        this.世且丝丟丈专丆丑上 = new UnityEngine.WaitForSecondsRealtime(time:  1f);
        goto label_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        System.Nullable<System.DateTime> val_3 = FriendsController.业丈丏丏丞丘丛丈丛();
        val_7 = 1152921516340667232;
        val_8 = this.丒东丗下丘下丁与丞;
        if((val_8 ^ 1152921542552432944 & 1) != 0)
        {
                if(Rilisoft.与丄丁丄丙丞下下丙.且丈丙专丁万东上丝() != false)
        {
                object[] val_6 = new object[1];
            val_7 = false;
            val_6[0] = val_7;
            UnityEngine.Debug.LogFormat(format:  "currentServerTime.HasValue: {0}", args:  val_6);
        }
        
            val_8 = val_3.HasValue;
            this.丝且与丝丒丟万丁专.丗与丄丑一丈丙不丛(丑专丛丅丞下丄丈丞:  new System.Nullable<System.DateTime>() {HasValue = val_8});
            this.丒东丗下丘下丁与丞 = val_3;
            mem[1152921542552445056] = ???;
        }
        
        label_8:
        val_9 = 1;
        this.丗丏丅丕丆世丁专丟 = val_9;
        this.丒上七丌业七丟与丐 = this.世且丝丟丈专丆丑上;
        return (bool)val_9;
        label_2:
        val_9 = 0;
        return (bool)val_9;
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
