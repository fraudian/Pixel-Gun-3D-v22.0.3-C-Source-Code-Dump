using UnityEngine;
private sealed class LobbyGameModeButton.丕丗东下万丘丘且丌 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.LobbyGameModeButton 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LobbyGameModeButton.丕丗东下万丘丘且丌(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        var val_15;
        var val_16;
        int val_17;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  1f);
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        if((Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世().业且万丝丛东丂丄丑(上且丗一丏丏万丅丌:  this.丝且与丝丒丟万丁专.Mode)) == true)
        {
            goto label_18;
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._buttonLockedObjects, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_4 = this.丝且与丝丒丟万丁专._buttons.GetEnumerator();
        val_15 = 1152921535463079680;
        val_16 = 1152921535463080704;
        label_14:
        if(((-203332864) & 1) == 0)
        {
            goto label_28;
        }
        
        if(val_6.丐丏七丌丕丗业且上() != null)
        {
            goto label_14;
        }
        
        goto label_14;
        label_2:
        val_17 = 0;
        return (bool)val_17;
        label_18:
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._buttonLockedObjects, 丏业丟一东丂东丘丛:  true);
        val_16 = Rilisoft.一世东上七三丌丅不.丑七不且上丗丁一世();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.丝且与丝丒丟万丁专._levelRequiredLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_11148"), arg0:  val_16.丒与丆三丟三丈丄丄(上且丗一丏丏万丅丌:  this.丝且与丝丒丟万丁专.Mode)));
        List.Enumerator<T> val_12 = this.丝且与丝丒丟万丁专._buttons.GetEnumerator();
        val_15 = 1152921535463079680;
        label_30:
        if(((-203332864) & 1) == 0)
        {
            goto label_28;
        }
        
        if(val_6.丐丏七丌丕丗业且上() != null)
        {
            goto label_30;
        }
        
        goto label_30;
        label_28:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        val_17 = 1;
        this.丗丏丅丕丆世丁专丟 = val_17;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_17;
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
