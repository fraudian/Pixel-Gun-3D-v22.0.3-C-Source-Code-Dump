using UnityEngine;
private sealed class NetworkStartTableNGUIController.丐丗一丞业不丟三丝 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public NetworkStartTableNGUIController 丝且与丝丒丟万丁专;
    public float 丕丕世且下一与丝与;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkStartTableNGUIController.丐丗一丞业不丟三丝(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        NetworkStartTableNGUIController val_19;
        int val_20;
        var val_21;
        var val_22;
        val_19 = this.丝且与丝丒丟万丁专;
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
            goto label_10;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.WaitUntil val_2 = null;
        val_19 = val_2;
        val_2 = new UnityEngine.WaitUntil(predicate:  new System.Func<System.Boolean>(object:  val_19, method:  System.Boolean NetworkStartTableNGUIController::世丘上丁业丒上丙丛()));
        val_20 = 1;
        this.丒上七丌业七丟与丐 = val_19;
        this.丗丏丅丕丆世丁专丟 = val_20;
        return (bool)val_20;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_19 == null)
        {
            goto label_5;
        }
        
        this.丝且与丝丒丟万丁专.丌一丏丘丞东与上世 = false;
        this.丝且与丝丒丟万丁专.七三丝丛丈三万丁一 = 0;
        goto label_6;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.endInterfacePanel == 0)
        {
            goto label_10;
        }
        
        val_19.丟业丁丐丟七丒丘业(丑丒业丘丑东丕世丅:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.rewardFullScreenButton, 丏业丟一东丂东丘丛:  true);
        if(GameConnect.不专专丂万丝上东丐() != false)
        {
                if(GameConnect.与丈丘丈上丌丝丝丛() == false)
        {
            goto label_18;
        }
        
        }
        
        val_21 = 0;
        goto label_19;
        label_5:
        label_6:
        if((val_19.一丈丛丘与丕丛丝东() != true) && (GameConnect.业丛丛丂一丆丕丗丟() != true))
        {
                if(GameConnect.一与东丝万上三丆丏() != true)
        {
                if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_34;
        }
        
        }
        
        }
        
        if((((this.丝且与丝丒丟万丁专.丛丏丒一丗丝丌不丅 <= 0) && (this.丝且与丝丒丟万丁专.下丕丌丈丙与与丏丟 <= 0)) && (this.丝且与丝丒丟万丁专.丈七丈丞专七丟专丛 <= 0)) && (this.丝且与丝丒丟万丁专.七上世丌丘丕万丅东 <= 0))
        {
                if(this.丝且与丝丒丟万丁专.丕专丐上东丑丑下丘 <= 0)
        {
            goto label_35;
        }
        
        }
        
        label_34:
        val_22 = 1;
        if(val_19 == null)
        {
            goto label_36;
        }
        
        label_50:
        val_19.丟业丁丐丟七丒丘业(丑丒业丘丑东丕世丅:  true);
        goto label_37;
        label_18:
        val_21 = GameConnect.世丐丄三三上丅七三() ^ 1;
        label_19:
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丏丒丁丙世东丏丝();
        if((Rilisoft.VIPController.丌丏丄专丘丕丑上且() != false) && ((Rilisoft.Singleton<Rilisoft.VIPController>.Instance.下一与丄丄丆三丝丐()) != true))
        {
                var val_15 = (this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.万万下东上丏且丅七() < 1) ? 1 : 0;
            val_15 = val_21 | val_15;
            if(val_15 != true)
        {
                this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丌且且丒丝一丝丅一();
        }
        
        }
        
        val_20 = true;
        this.丝且与丝丒丟万丁专.丌一丏丘丞东与上世 = val_20;
        this.丒上七丌业七丟与丐 = val_19.丛三下丛丛丈万世丟(丕丕世且下一与丝与:  this.丕丕世且下一与丝与, 丈丅三丈丗丐下一丄:  false);
        this.丗丏丅丕丆世丁专丟 = 2;
        return (bool)val_20;
        label_35:
        if(val_19 != null)
        {
            goto label_50;
        }
        
        label_36:
        val_19.丟业丁丐丟七丒丘业(丑丒业丘丑东丕世丅:  (this.丝且与丝丒丟万丁专.丂三丅丘丆丂丛七丌 > 0) ? 1 : 0);
        label_37:
        val_19 = this.丝且与丝丒丟万丁专.rewardFullScreenButton;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_19, 丏业丟一东丂东丘丛:  false);
        label_10:
        val_20 = 0;
        return (bool)val_20;
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
