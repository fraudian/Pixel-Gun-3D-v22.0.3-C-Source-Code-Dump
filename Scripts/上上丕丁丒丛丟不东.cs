using UnityEngine;
private sealed class LeaderboardEventController.上上丕丁丒丛丟不东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.WWW 东丞丒丙世丏三下丟;
    private bool 丞丁丏且七丛丁下丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeaderboardEventController.上上丕丁丒丛丟不东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        object val_13;
        int val_14;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丞丁丏且七丛丁下丞 = false;
        goto label_23;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.东丞丒丙世丏三下丟.error)) == false)
        {
            goto label_8;
        }
        
        string val_3 = 丄丛丏丄不一丆丐丑.上七丐丞丆且丈丒丘(东丞丒丙世丏三下丟:  this.东丞丒丙世丏三下丟);
        if((System.String.IsNullOrEmpty(value:  val_3)) == false)
        {
            goto label_11;
        }
        
        UnityEngine.Debug.LogError(message:  "[LeaderboardEvent] --------- SendRequestCoroutine empty responseText");
        goto label_23;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_35;
        label_8:
        object[] val_5 = new object[1];
        val_13 = this.东丞丒丙世丏三下丟.error;
        val_5[0] = val_13;
        UnityEngine.Debug.LogErrorFormat(format:  "[LeaderboardEvent] --------- SendRequestCoroutine failed with message: \'{0}\'", args:  val_5);
        goto label_23;
        label_11:
        object[] val_7 = new object[1];
        val_13 = val_7;
        val_13[0] = val_3;
        UnityEngine.Debug.LogFormat(format:  "[LeaderboardEvent] --------- SendRequestCoroutine response text: \'{0}\'", args:  val_7);
        object val_8 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_3);
        UnityEngine.Debug.LogWarning(message:  "[LeaderboardEvent] --------- SendRequestCoroutine can\'t parse answer");
        label_23:
        if(this.丞丁丏且七丛丁下丞 != false)
        {
                val_14 = 1;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  5f);
            this.丗丏丅丕丆世丁专丟 = val_14;
            return (bool)val_14;
        }
        
        label_35:
        val_14 = true;
        this.丞丁丏且七丛丁下丞 = val_14;
        this.丒上七丌业七丟与丐 = this.东丞丒丙世丏三下丟;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_14;
        label_3:
        val_14 = 0;
        return (bool)val_14;
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
