using UnityEngine;
private sealed class NotificationController.丒一上丂业专下丝丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public bool 东丗七丕丄不丐专丒;
    public NotificationController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NotificationController.丒一上丂业专下丝丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        NotificationController val_19;
        var val_20;
        int val_21;
        System.Collections.IEnumerator val_22;
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
            goto label_35;
        }
        
        val_19 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.东丗七丕丄不丐专丒 == false)
        {
            goto label_4;
        }
        
        if(Initializer.丑七不且上丗丁一世() != 0)
        {
                val_19.SaveTimeValues();
        }
        
        val_19.丏丂且一丅世丏与不();
        if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() == false)
        {
            goto label_35;
        }
        
        val_19 = TimeGameController.丄丞丁丈与业上丞丟;
        if(val_19 != 0)
        {
            goto label_35;
        }
        
        val_19 = GamePauseController.丄丘七三上丕世丞业;
        if((val_19 != 0) || (丅丒丗丑丒丙丛不丆.丒丌且丞丙下三丙下() == true))
        {
            goto label_35;
        }
        
        if((UnityEngine.Application.platform == 11) || (丅丒丗丑丒丙丛不丆.七不丐丐丆丒丛丏万() == false))
        {
            goto label_27;
        }
        
        val_20 = static_value_081DACA8;
        val_20 = static_value_081DACA8;
        val_19 = mem[static_value_081DACA8 + 184 + 16];
        val_19 = static_value_081DACA8 + 184 + 16;
        if(val_19 == 0)
        {
            goto label_35;
        }
        
        label_27:
        GameConnect.下与业丒丝丕丙丘丙();
        goto label_35;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        Rilisoft.与丄丁丄丙丞下下丙.与丛丟且丕丒业一丘();
        Rilisoft.一丟专且三万丞丁丂.丈丅丞丁丄丅丕东丞();
        UnityEngine.Coroutine val_12 = CoroutineRunner.Instance.StartCoroutine(routine:  Rilisoft.一丟专且三万丞丁丂.丙万丆丞丌东丞丏三());
        val_19 = CoroutineRunner.Instance;
        UnityEngine.Coroutine val_15 = val_19.StartCoroutine(routine:  Rilisoft.一丟专且三万丞丁丂.丂丗丘七丆丅下一丒());
        label_35:
        val_21 = 0;
        return (bool)val_21;
        label_2:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_21 = 1;
        return (bool)val_21;
        label_4:
        if(val_19 != null)
        {
                val_22 = 92860.丏丂丈丌丘一丐丌七();
        }
        else
        {
                val_22 = 0.丏丂丈丌丘一丐丌七();
        }
        
        UnityEngine.Coroutine val_18 = val_19.StartCoroutine(routine:  val_22);
        val_21 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_21;
        return (bool)val_21;
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
