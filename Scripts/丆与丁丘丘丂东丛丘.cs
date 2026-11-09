using UnityEngine;
private sealed class MainMenuController.丆与丁丘丘丂东丛丘 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public bool 丄七丙不丟丛与丏丐;
    public MainMenuController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MainMenuController.丆与丁丘丘丂东丛丘(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        MainMenuController val_6;
        int val_7;
        val_6 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_7;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丄七丙不丟丛与丏丐 == false)
        {
            goto label_3;
        }
        
        val_6.丗世丕丈丘七上上丕();
        丅丛丟上丁丆上丛专.上且万万丆专万一上(丙业与丙丗丝不丈东:  false);
        goto label_7;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.Coroutine val_4 = CoroutineRunner.Instance.StartCoroutine(routine:  丅与专与丘丛万丘与.丑七不且上丗丁一世().丈丁不丞丘七业一上(与丗丆丏丙丟与丒业:  "MainMenuController.OnApplicationPause"));
        MainMenuController.丒三丑丙三丞丙丗丂();
        if(val_6 == null)
        {
            goto label_16;
        }
        
        val_6.丅专不丟下丘丈专丘();
        val_6.丕丂丄丑东专下丙下();
        goto label_17;
        label_3:
        UnityEngine.WaitForSeconds val_5 = null;
        val_6 = val_5;
        val_5 = new UnityEngine.WaitForSeconds(seconds:  1f);
        val_7 = 1;
        this.丒上七丌业七丟与丐 = val_6;
        this.丗丏丅丕丆世丁专丟 = val_7;
        return (bool)val_7;
        label_16:
        0.丅专不丟下丘丈专丘();
        0.丕丂丄丑东专下丙下();
        label_17:
        val_6.丐丂丙丘丞丘专丗下();
        label_7:
        val_7 = 0;
        return (bool)val_7;
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
