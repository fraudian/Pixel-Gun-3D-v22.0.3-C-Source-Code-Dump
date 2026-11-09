using UnityEngine;
private sealed class ThreeChestsGameEventView.万一不丛丂不丈业丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.ThreeChestsGameEventView 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ThreeChestsGameEventView.万一不丛丂不丈业丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_6;
        Rilisoft.ThreeChestsGameEventView val_32;
        var val_33;
        var val_34;
        UnityEngine.Animator val_35;
        string val_36;
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return false;
        }
        
        val_32 = this.丝且与丝丒丟万丁专;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_32.上丕丌丕丂丘丁丙万().下一三万丝丟丐丒丆() == false)
        {
                return false;
        }
        
        List.Enumerator<T> val_4 = val_32.丘丆且上七业三丆不().GetEnumerator();
        label_13:
        if(((-393713680) & 1) == 0)
        {
            goto label_8;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        if(val_7 == 0)
        {
            goto label_13;
        }
        
        val_7.ResetTrigger(name:  "Multy");
        goto label_13;
        label_8:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_32.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世() != null)
        {
                if(val_32.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世().丐丏下丕三丒丗丅丛() == false)
        {
            goto label_26;
        }
        
        }
        
        if(val_32 == null)
        {
            goto label_27;
        }
        
        val_33 = val_32.上丕丌丕丂丘丁丙万();
        goto label_28;
        label_26:
        if(val_32 == null)
        {
            goto label_29;
        }
        
        val_34 = val_32.上丕丌丕丂丘丁丙万();
        goto label_30;
        label_27:
        val_33 = val_32.上丕丌丕丂丘丁丙万();
        label_28:
        val_33.不丌东丑丏丞丛丄一(丙业与丙丗丝不丈东:  val_32.上丕丌丕丂丘丁丙万().不七丘丙不三丗业上());
        val_35 = this.丝且与丝丒丟万丁专._viewAnimator;
        val_36 = "SetSuper";
        goto label_35;
        label_29:
        val_34 = val_32.上丕丌丕丂丘丁丙万();
        label_30:
        val_34.不丌东丑丏丞丛丄一(丙业与丙丗丝不丈东:  val_32.上丕丌丕丂丘丁丙万().不七丘丙不三丗业上());
        val_35 = this.丝且与丝丒丟万丁专._viewAnimator;
        val_36 = "Golden";
        label_35:
        val_35.SetTrigger(name:  val_36);
        val_32.丐上丛丞丑且丅世丄();
        val_32.业丑丈丁丙丁世丂丁(丐下丝丘丑丟丟丗丌:  val_32.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世());
        val_32.丈不丛丆丘上丛丟丐().gameObject.SetActive(value:  false);
        UnityEngine.GameObject val_27 = val_32.丈不丛丆丘上丛丟丐().gameObject;
        val_27.SetActive(value:  true);
        val_27.UpdateView(丅东专与不三丂丁丝:  val_32.上丕丌丕丂丘丁丙万(), 七丆丟丗世丟且丒丆:  true);
        this.丝且与丝丒丟万丁专.七丅专丏丅丌不七丞 = val_32.上丕丌丕丂丘丁丙万().且丌三丙丙与与丝世();
        return false;
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
