using UnityEngine;
private sealed class OpenCloseDoorTriggerByPlayers.东与丄丒丒世丂丈东 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public OpenCloseDoorTriggerByPlayers 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public OpenCloseDoorTriggerByPlayers.东与丄丒丒世丂丈东(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_3;
        int val_4;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        val_3 = this.丝且与丝丒丟万丁专;
        this.丝且与丝丒丟万丁专.下丛丏七下丑丂丌丘(丆与丈丏丟七丁东丛:  this.丝且与丝丒丟万丁专.forceOpenDoorAudioClip);
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_4 = 0;
        this.丝且与丝丒丟万丁专.与丌东下丙丕业三且 = false;
        return (bool)val_4;
        label_2:
        val_4 = 0;
        return (bool)val_4;
        label_3:
        val_3 = 120;
        0.下丛丏七下丑丂丌丘(丆与丈丏丟七丁东丛:  1);
        label_4:
        val_4 = 1;
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSeconds(seconds:  val_3.length);
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_4;
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
