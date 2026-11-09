using UnityEngine;
private sealed class ExperienceController.万丘与丂专不万丟丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public ExperienceController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ExperienceController.万丘与丂专不万丟丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_5;
        int val_6;
        var val_7;
        val_5 = this;
        if(this.丗丏丅丕丆世丁专丟 >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丙丐丄丛东七丑万丙 == true)
        {
            goto label_3;
        }
        
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_5;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        if(Rilisoft.丝丄三业丙专丛与不.丐丘丄万上丄七世丕() == null)
        {
            goto label_8;
        }
        
        val_7 = null;
        val_5 = ExperienceController.丞丞丘业东丙丏七丌();
        Rilisoft.一丟专且三万丞丁丂.下丞丏丑丞七业丌丑(丑丒与东三专七丙丙:  val_5, 丗丑丈丂丑丒世上丟:  ExpController.万上一丝丆且七丅丅() + 1);
        label_5:
        val_6 = 0;
        return (bool)val_6;
        label_8:
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
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
