using UnityEngine;
private sealed class 七丐丛专丞东一不世.七三与不上丛丅丒东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.七丐丛专丞东一不世 丝且与丝丒丟万丁专;
    private UnityEngine.WWW 丕东丒专丈东一丒不;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public 七丐丛专丞东一不世.七三与不上丛丅丒东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_8;
        var val_9;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_15;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_8 = 1;
        UnityEngine.WWW val_2 = Rilisoft.与丄丁丄丙丞下下丙.与丛七丞且专丄丛世(七丙不丅丛丘丗万与:  丄丛丏丄不一丆丐丑.东丝丁上丌丂七丞上(), 丝丌丝不丟丞丑丑丗:  true);
        this.丕东丒专丈东一丒不 = val_2;
        this.丒上七丌业七丟与丐 = val_2;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if((System.String.IsNullOrEmpty(value:  this.丕东丒专丈东一丒不.error)) == false)
        {
            goto label_7;
        }
        
        val_9 = null;
        val_9 = null;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  Rilisoft.七丐丛专丞东一不世.丛丄下丅丙且世七不, 下下丏一丙不丘丌丞:  丄丛丏丄不一丆丐丑.上七丐丞丆且丈丒丘(东丞丒丙世丏三下丟:  this.丕东丒专丈东一丒不));
        this.丝且与丝丒丟万丁专.丟丈上丛丙丕业丁丐();
        goto label_15;
        label_7:
        object[] val_6 = new object[1];
        if(this.丕东丒专丈东一丒不 == null)
        {
            goto label_16;
        }
        
        if(val_6 != null)
        {
            goto label_23;
        }
        
        label_24:
        label_23:
        val_6[0] = this.丕东丒专丈东一丒不.error;
        UnityEngine.Debug.LogWarningFormat(format:  "Minigame rating response error: {0}", args:  val_6);
        label_15:
        val_8 = 0;
        return (bool)val_8;
        label_16:
        if(val_6 != null)
        {
            goto label_23;
        }
        
        goto label_24;
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
