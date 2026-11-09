using UnityEngine;
private sealed class LobbyCraftSpeedUpButton.万与世丄丈丌丐丑丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.LobbyCraftSpeedUpButton 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public LobbyCraftSpeedUpButton.万与世丄丈丌丐丑丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_36;
        var val_37;
        UnityEngine.Object val_38;
        int val_40;
        var val_41;
        Rilisoft.PriceView val_42;
        丈丞丕丘丕丗与上一 val_43;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = new UnityEngine.WaitForSeconds(seconds:  0.5f);
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_5;
        }
        
        label_4:
        label_5:
        if(this.丝且与丝丒丟万丁专._container.activeInHierarchy == false)
        {
            goto label_9;
        }
        
        Rilisoft.LobbyItemsController val_3 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        if((val_3.<丛上丟丏与丕丒东丂>k__BackingField) == null)
        {
            goto label_9;
        }
        
        val_36 = null;
        System.Nullable<System.Int64> val_4 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
        val_37 = 1152921516339402464;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._objInternetDisabled, 丏业丟一东丂东丘丛:  false);
        Rilisoft.LobbyItemsController val_5 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        this.丝且与丝丒丟万丁专._timeLeftTextGroup.Text = 专七专下且专三一且.丒下丒丄且且丂丟丘(丆丐七丅丆丗丛上与:  val_5.<丛上丟丏与丕丒东丂>k__BackingField.下丞丘丏丂丕丄丐丘(), 丒且下丘丅丘丛丆且:  true, 七丐丞丑丑丕世丙七:  0, 专丘一丕专业七专丏:  0);
        val_38 = 0;
        if(Rilisoft.FreeLobbyCraftController.丑七不且上丗丁一世() == val_38)
        {
            goto label_23;
        }
        
        Rilisoft.LobbyItemsController val_10 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        if((val_10.<丛上丟丏与丕丒东丂>k__BackingField) == null)
        {
            goto label_23;
        }
        
        Rilisoft.LobbyItemsController val_11 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        if(((System.String.op_Inequality(a:  val_11.<丛上丟丏与丕丒东丂>k__BackingField.三与丛丑且丐丈业丌(), b:  "decor_big_military_1")) == false) || (Rilisoft.FreeLobbyCraftController.丑七不且上丗丁一世().丄丛丅丐世丌丕且丛() == false))
        {
            goto label_28;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._buttonSpeedUpVideo.gameObject, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._buttonSpeedUpGems.gameObject, 丏业丟一东丂东丘丛:  true);
        UnityEngine.GameObject val_18 = this.丝且与丝丒丟万丁专._buttonSpeedUpGemsGeneral.gameObject;
        val_38 = 0;
        goto label_34;
        label_2:
        val_40 = 0;
        return (bool)val_40;
        label_28:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._buttonSpeedUpVideo.gameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._buttonSpeedUpGems.gameObject, 丏业丟一东丂东丘丛:  false);
        val_38 = 1;
        label_34:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专._buttonSpeedUpGemsGeneral.gameObject, 丏业丟一东丂东丘丛:  true);
        label_23:
        val_41 = null;
        System.Nullable<System.Int64> val_22 = Rilisoft.LobbyItemsController.丅丘七世上丘且丗不();
        Rilisoft.LobbyItemsController val_23 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        if((val_23.<丛上丟丏与丕丒东丂>k__BackingField) == null)
        {
            goto label_44;
        }
        
        if(( & 1) == 0)
        {
            goto label_45;
        }
        
        label_51:
        this.丝且与丝丒丟万丁专._buttonSpeedUpGems.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  val_23.<丛上丟丏与丕丒东丂>k__BackingField.且丕三丙七且且东下(), 万丐丁三且下丞丈丌:  0);
        val_42 = this.丝且与丝丒丟万丁专._buttonSpeedUpGemsGeneral;
        Rilisoft.LobbyItemsController val_25 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        val_43 = val_25.<丛上丟丏与丕丒东丂>k__BackingField.且丕三丙七且且东下();
        if(val_42 != null)
        {
            goto label_59;
        }
        
        goto label_50;
        label_44:
        if(( & 1) != 0)
        {
            goto label_51;
        }
        
        label_45:
        val_37 = 1152921505317228544;
        this.丝且与丝丒丟万丁专._buttonSpeedUpGems.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  0, 丏丂不专上丘丂不丅:  val_23.<丛上丟丏与丕丒东丂>k__BackingField.丙丕丞且丕不丘丙丑().丑丘上七业丏丅丄丁().东与三丌丅三丒丏业()), 万丐丁三且下丞丈丌:  0);
        val_42 = this.丝且与丝丒丟万丁专._buttonSpeedUpGemsGeneral;
        Rilisoft.LobbyItemsController val_31 = Rilisoft.Singleton<Rilisoft.LobbyItemsController>.Instance;
        丈丞丕丘丕丗与上一 val_35 = null;
        val_43 = val_35;
        val_35 = new 丈丞丕丘丕丗与上一(丒世丘丘上丆丝东丞:  0, 丏丂不专上丘丂不丅:  val_31.<丛上丟丏与丕丒东丂>k__BackingField.丙丕丞且丕不丘丙丑().丑丘上七业丏丅丄丁().东与三丌丅三丒丏业());
        if(val_42 != null)
        {
            goto label_59;
        }
        
        label_50:
        label_59:
        val_42.丗丘丗丈丑丒丗七丘(丒世丘丘上丆丝东丞:  val_35, 万丐丁三且下丞丈丌:  0);
        label_9:
        val_40 = 1;
        this.丗丏丅丕丆世丁专丟 = val_40;
        this.丒上七丌业七丟与丐 = this.三丛与七下专丅丕东;
        return (bool)val_40;
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
