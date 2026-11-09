using UnityEngine;
private sealed class ThreeChestsGameEventView.丅丁丙丅三丕七上一 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.ThreeChestsGameEventView 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ThreeChestsGameEventView.丅丁丙丅三丕七上一(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.ThreeChestsGameEventView val_23;
        System.Collections.Generic.List<UnityEngine.GameObject> val_24;
        int val_25;
        var val_26;
        var val_27;
        string val_28;
        var val_29;
        val_23 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_24 = val_23.上丕丌丕丂丘丁丙万();
        if(val_24.且丌三丙丙与与丝世() == null)
        {
                return (bool)val_25;
        }
        
        int val_7 = val_23.上丕丌丕丂丘丁丙万().丄三丐丟丗丄丟上丞().IndexOf(item:  val_23.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世());
        if(val_7 == 2)
        {
            goto label_13;
        }
        
        if(val_7 == 1)
        {
            goto label_14;
        }
        
        if(val_7 != 0)
        {
            goto label_15;
        }
        
        val_27 = "First";
        goto label_28;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        PGCompany.Analytics.一业丗丆世世上丁且.丘丘世丕专专丞丁丆(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 与丂丒丄丟丌丆丁丕:  3);
        Rilisoft.AbstractGameEventGui val_9 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
        val_23 = val_23.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世().业上丙丞丐丄丆丅七();
        if(val_9 != null)
        {
                val_24 = 1152921505450934272;
            var val_13 = (null == null) ? (val_9) : 0;
        }
        
        0.丈丄丗丐丒与东丏三(丐东业丕丕丂丗丅丙:  val_23);
        label_2:
        val_25 = 0;
        return (bool)val_25;
        label_14:
        val_27 = "Second";
        goto label_28;
        label_13:
        val_27 = "Third";
        label_28:
        if(val_23 == null)
        {
            goto label_29;
        }
        
        label_36:
        this.丝且与丝丒丟万丁专.下专丞丅丟丏丐丆丙 = true;
        if((Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世() == null) || (null != null))
        {
            goto label_31;
        }
        
        val_26 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
        if(val_26 == null)
        {
            goto label_32;
        }
        
        if(null == null)
        {
            goto label_35;
        }
        
        val_26 = 0;
        goto label_35;
        label_15:
        val_28 = 0;
        if(val_23 != null)
        {
            goto label_36;
        }
        
        label_29:
        label_32:
        label_35:
        一丈丌且下丌七丟丂(丛丅丘一丏丙且丌上:  false);
        val_29 = Rilisoft.AbstractGameEventGui.丑七不且上丗丁一世();
        if(val_29 == null)
        {
            goto label_37;
        }
        
        if(null == X23)
        {
            goto label_40;
        }
        
        val_29 = 0;
        goto label_40;
        label_37:
        label_40:
        val_29.丞丙三丛专丌丞不丐(丛丅丘一丏丙且丌上:  false);
        label_31:
        this.丝且与丝丒丟万丁专._viewAnimator.SetTrigger(name:  "Select" + val_28);
        val_24 = this.丝且与丝丒丟万丁专._disableIfSpinActive;
        List.Enumerator<T> val_19 = val_24.GetEnumerator();
        label_49:
        if(( & 1) == 0)
        {
            goto label_43;
        }
        
        string val_20 = 0.丐丏七丌丕丗业且上();
        if(val_20 == 0)
        {
            goto label_49;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_20, 丏业丟一东丂东丘丛:  false);
        goto label_49;
        label_43:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.WaitForSeconds val_22 = null;
        val_23 = val_22;
        val_22 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专._selectChestTime);
        val_25 = 1;
        this.丒上七丌业七丟与丐 = val_23;
        this.丗丏丅丕丆世丁专丟 = val_25;
        return (bool)val_25;
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
