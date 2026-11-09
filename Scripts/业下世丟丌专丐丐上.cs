using UnityEngine;
private sealed class NetworkStartTableNGUIController.业下世丟丌专丐丐上 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private float 丕丕世且下一与丝与;
    public float 东丒丝丈丝东丈上一;
    public NetworkStartTableNGUIController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkStartTableNGUIController.业下世丟丌专丐丐上(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        NetworkStartTableNGUIController val_9;
        int val_10;
        bool val_11;
        val_9 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_24;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丕丕世且下一与丝与 <= 0f)
        {
            goto label_3;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_9 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        val_10 = 1;
        this.丒上七丌业七丟与丐 = val_9;
        this.丗丏丅丕丆世丁专丟 = val_10;
        return (bool)val_10;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        if(val_9 == null)
        {
            goto label_5;
        }
        
        if(this.丝且与丝丒丟万丁专.丙不七专且与丑丝丅 == false)
        {
            goto label_8;
        }
        
        val_11 = this.丝且与丝丒丟万丁专.丙不七专且与丑丝丅;
        goto label_9;
        label_5:
        val_11 = 1552;
        goto label_9;
        label_8:
        val_9.SendAnalytics();
        label_9:
        与丂丏丛丞丞丒丟丄.丙丝丆丅七丒丙丝丝(丙业与丙丗丝不丈东:  false);
        if(this.丝且与丝丒丟万丁专.下丄三丒丟丄丂丑世 == false)
        {
            goto label_24;
        }
        
        if((val_9.丒丕丟东三世丑丛丟().activeSelf != true) && (GameConnect.业丛丛丂一丆丕丗丟() != true))
        {
                if(GameConnect.一与东丝万上三丆丏() != true)
        {
                if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_24;
        }
        
        }
        
        }
        
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetTrigger(name:  "OkPressed");
        if((((((this.丝且与丝丒丟万丁专.丛丏丒一丗丝丌不丅 <= 0) && (this.丝且与丝丒丟万丁专.下丕丌丈丙与与丏丟 <= 0)) && (this.丝且与丝丒丟万丁专.丙丏丏丛丁与丘三丝 <= 0)) && (this.丝且与丝丒丟万丁专.丈七丈丞专七丟专丛 == 0)) && (this.丝且与丝丒丟万丁专.七上世丌丘丕万丅东 <= 0)) && (this.丝且与丝丒丟万丁专.丕专丐上东丑丑下丘 <= 0))
        {
                if(this.丝且与丝丒丟万丁专.丂三丅丘丆丂丛七丌 <= 0)
        {
            goto label_32;
        }
        
        }
        
        label_37:
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetTrigger(name:  "GetReward");
        if(1 != 0)
        {
            goto label_35;
        }
        
        label_36:
        if(val_9.丘业丞丗上且一丏下() != false)
        {
                bool val_8 = val_9.上下下上三业丒丐东();
        }
        
        label_35:
        val_9.丟业丁丐丟七丒丘业(丑丒业丘丑东丕世丅:  false);
        label_24:
        val_10 = 0;
        return (bool)val_10;
        label_32:
        if(this.丝且与丝丒丟万丁专.上业丈丐上丂上东丌 == false)
        {
            goto label_36;
        }
        
        goto label_37;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        var val_4;
        if((this.丗丏丅丕丆世丁专丟 == 2) && (this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId))
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this;
        }
        else
        {
                NetworkStartTableNGUIController.业下世丟丌专丐丐上 val_2 = null;
            val_4 = val_2;
            val_2 = new NetworkStartTableNGUIController.业下世丟丌专丐丐上();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丕丕世且下一与丝与 = this.东丒丝丈丝东丈上一;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
