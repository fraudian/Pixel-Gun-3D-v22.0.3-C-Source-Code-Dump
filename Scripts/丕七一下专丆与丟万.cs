using UnityEngine;
private sealed class LeaderboardEventController.丕七一下专丆与丟万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public UnityEngine.WWW 东丞丒丙世丏三下丟;
    public int 且丙丂丕丆丛业丌不;
    public LeaderboardEventController 丝且与丝丒丟万丁专;
    private bool 丞丁丏且七丛丁下丞;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LeaderboardEventController.丕七一下专丆与丟万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_24;
        string val_25;
        object val_26;
        int val_27;
        val_24 = this;
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
            goto label_69;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丞丁丏且七丛丁下丞 = false;
        goto label_55;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_25 = this.东丞丒丙世丏三下丟.error;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_25)) == false)
        {
            goto label_55;
        }
        
        string val_3 = 丄丛丏丄不一丆丐丑.上七丐丞丆且丈丒丘(东丞丒丙世丏三下丟:  this.东丞丒丙世丏三下丟);
        val_25 = val_3;
        if((System.String.IsNullOrEmpty(value:  val_3)) == false)
        {
            goto label_11;
        }
        
        val_26 = "[LeaderboardEvent] --------- GetRequestCoroutine empty responseText";
        goto label_52;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_27;
        label_11:
        object[] val_5 = new object[1];
        val_5[0] = val_25;
        UnityEngine.Debug.LogFormat(format:  "[LeaderboardEvent] --------- GetRequestCoroutine response text: \'{0}\'", args:  val_5);
        val_25 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_25);
        val_26 = "[LeaderboardEvent] --------- GetRequestCoroutine can\'t parse responseText";
        label_52:
        UnityEngine.Debug.LogError(message:  val_26);
        label_55:
        if(this.丞丁丏且七丛丁下丞 != false)
        {
                val_27 = 1;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  5f);
            this.丗丏丅丕丆世丁专丟 = val_27;
            return (bool)val_27;
        }
        
        label_27:
        val_27 = true;
        this.丞丁丏且七丛丁下丞 = val_27;
        this.丒上七丌业七丟与丐 = this.东丞丒丙世丏三下丟;
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_27;
        label_69:
        val_27 = 0;
        return (bool)val_27;
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
