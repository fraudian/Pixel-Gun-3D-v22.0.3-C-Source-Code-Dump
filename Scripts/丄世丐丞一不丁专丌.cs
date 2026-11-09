using UnityEngine;
private sealed class BaseBot.丄世丐丞一不丁专丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public float 丕丕世且下一与丝与;
    public RilisoftBot.BaseBot 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BaseBot.丄世丐丞一不丁专丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        RilisoftBot.BaseBot val_9;
        int val_10;
        var val_11;
        var val_12;
        var val_13;
        val_9 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
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
        val_11 = null;
        val_11 = null;
        if(ZombieCreator.丞丈丟丒丂丞丏不丑 == 0)
        {
            goto label_9;
        }
        
        if((this.丝且与丝丒丟万丁专.丑一业丟上丐丕丗下 == true) || (val_9.丄丘丞丟七丂丆万且() == true))
        {
            goto label_18;
        }
        
        val_12 = null;
        val_12 = null;
        if(ZombieCreator.丞丈丟丒丂丞丏不丑 == null)
        {
            goto label_15;
        }
        
        val_13 = ZombieCreator.丞丈丟丒丂丞丏不丑.丌丟且丛丄丒万丈丑();
        goto label_16;
        label_9:
        if(val_9 != null)
        {
            goto label_18;
        }
        
        goto label_18;
        label_15:
        val_13 = 0.丌丟且丛丄丒万丈丑();
        label_16:
        ZombieCreator.丞丈丟丒丂丞丏不丑.丂丟丑丂丁丝下与丒(丙业与丙丗丝不丈东:  val_13 + 1);
        label_18:
        if(this.丝且与丝丒丟万丁专.丑一业丟上丐丕丗下 != false)
        {
                if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                this.丝且与丝丒丟万丁专.丅丏三七丁丑丞丄丏.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  205, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
        }
        
        }
        
        val_9.DestroyByNetworkType();
        label_2:
        val_10 = 0;
        return (bool)val_10;
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
