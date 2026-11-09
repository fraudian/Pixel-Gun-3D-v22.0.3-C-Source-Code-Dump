using UnityEngine;
private sealed class PortalEnemyEffectsManager.丄丐一丏上丐业丟万 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RilisoftBot.PortalEnemyEffectsManager 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PortalEnemyEffectsManager.丄丐一丏上丐业丟万(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        RilisoftBot.PortalEnemyEffectsManager val_5;
        int val_6;
        var val_7;
        System.Collections.IEnumerator val_8;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        val_5 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        val_7 = 0;
        goto label_5;
        label_10:
        T val_5 = val_5.GetComponentsInChildren<UnityEngine.Renderer>()[0];
        if(val_5 != null)
        {
                val_8 = val_5.七一世丞一丑下丟丅(三丑丛丘与丛丟世东:  val_5);
        }
        else
        {
                val_8 = 0.七一世丞一丑下丟丅(三丑丛丘与丛丟世东:  val_5);
        }
        
        UnityEngine.Coroutine val_4 = val_5.StartCoroutine(routine:  val_8);
        val_7 = 1;
        label_5:
        if(val_7 < val_1.Length)
        {
            goto label_10;
        }
        
        label_2:
        val_6 = 0;
        return (bool)val_6;
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
