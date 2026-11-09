using UnityEngine;
private sealed class GameEventSetsViewMain.丌一丂丆万上与丟丗 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.GameEventSetsViewMain 丝且与丝丒丟万丁专;
    private float 丒丙丏七丑丑三丐丞;
    private float 丒丒丅丞丗丑丏东下;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GameEventSetsViewMain.丌一丂丆万上与丟丗(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.Light val_5;
        float val_6;
        float val_7;
        int val_8;
        float val_9;
        val_5 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        val_6 = val_5;
        this.丒丙丏七丑丑三丐丞 = 0.3f;
        this.丒丒丅丞丗丑丏东下 = 0f;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.三丛上一世上丞业丗 == 0)
        {
            goto label_6;
        }
        
        val_7 = 1152921542821903980;
        goto label_7;
        label_1:
        val_7 = this.丒丒丅丞丗丑丏东下;
        val_6 = this.丒丙丏七丑丑三丐丞;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_7:
        if(val_7 <= val_6)
        {
            goto label_8;
        }
        
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_9;
        }
        
        label_6:
        val_5 = this.丝且与丝丒丟万丁专.三丛上一世上丞业丗;
        goto label_10;
        label_2:
        val_8 = 0;
        return (bool)val_8;
        label_8:
        this.丝且与丝丒丟万丁专.三丛上一世上丞业丗.intensity = UnityEngine.Mathf.Lerp(a:  0f, b:  this.丝且与丝丒丟万丁专.丒丅丑丟丙丕丛丗丌, t:  val_7 / val_6);
        val_9 = this.丒丒丅丞丗丑丏东下;
        float val_4 = UnityEngine.Time.deltaTime;
        val_4 = val_9 + val_4;
        val_8 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丒丒丅丞丗丑丏东下 = val_4;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_8;
        label_9:
        val_5 = 36;
        label_10:
        val_9 = this.丝且与丝丒丟万丁专.丒丅丑丟丙丕丛丗丌;
        val_5.intensity = val_9;
        val_8 = 0;
        this.丝且与丝丒丟万丁专.不且一三丁下丐丁世 = 0;
        return (bool)val_8;
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
