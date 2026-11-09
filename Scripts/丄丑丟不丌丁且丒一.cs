using UnityEngine;
private sealed class LobbyDayNightController.丄丑丟不丌丁且丒一 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public LobbyDayNightController 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LobbyDayNightController.丄丑丟不丌丁且丒一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WaitForSeconds val_3;
        int val_4;
        var val_5;
        var val_6;
        UnityEngine.Color val_7;
        var val_8;
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
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_3 = 0;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        goto label_4;
        label_1:
        val_3 = 0;
        this.丗丏丅丕丆世丁专丟 = 0;
        label_4:
        val_4 = 1;
        goto label_5;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_5 = 0;
        goto label_7;
        label_20:
        MaterialToChange val_3 = this.丝且与丝丒丟万丁专.matToChange[0];
        val_6 = 0;
        goto label_10;
        label_18:
        UnityEngine.Material val_4 = this.丝且与丝丒丟万丁专.matToChange[0x0][0].materials[0];
        if(this.丝且与丝丒丟万丁专.matToChange[0x0][0].changecolor != false)
        {
                val_7 = this.丝且与丝丒丟万丁专.matToChange[0x0][0].currentColor;
            val_4.color = new UnityEngine.Color() {r = val_7, g = V9.16B, b = V10.16B, a = V11.16B};
        }
        
        if((val_4.HasProperty(name:  "_Lerp")) != false)
        {
                val_7 = this.丝且与丝丒丟万丁专.matToChange[0x0][0].currentLerp;
            val_4.SetFloat(name:  "_Lerp", value:  val_7);
        }
        
        val_6 = 1;
        label_10:
        if(val_6 < this.丝且与丝丒丟万丁专.matToChange[0x0][0].materials.Length)
        {
            goto label_18;
        }
        
        val_5 = 1;
        label_7:
        if(val_5 < this.丝且与丝丒丟万丁专.matToChange.Length)
        {
            goto label_20;
        }
        
        val_3 = this.三丛与七下专丅丕东;
        val_4 = 2;
        label_5:
        val_8 = 1;
        this.丒上七丌业七丟与丐 = val_3;
        this.丗丏丅丕丆世丁专丟 = val_4;
        return (bool)val_8;
        label_3:
        val_8 = 0;
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
