using UnityEngine;
private sealed class OneChestGameEventView.万世丕丑与七丗下丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.OneChestGameEventView 丝且与丝丒丟万丁专;
    public int 丒丁东世世丗丅丅丄;
    private UICenterOnChild 丂丌丁丈下丁丑万丅;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public OneChestGameEventView.万世丕丑与七丗下丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.OneChestGameEventView val_31;
        var val_32;
        UnityEngine.Object val_33;
        var val_34;
        System.Object[] val_35;
        int val_37;
        val_31 = this.丝且与丝丒丟万丁专;
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
        val_32 = 0;
        goto label_5;
        label_16:
        val_33 = X21.transform.GetChild(index:  0).GetComponent<Rilisoft.GameEventScrollContainerView>();
        if(val_33.Container != null)
        {
                if(val_33.Container.Id == this.丒丁东世世丗丅丅丄)
        {
            goto label_13;
        }
        
        }
        
        val_32 = 1;
        label_5:
        if(val_32 < val_33.transform.childCount)
        {
            goto label_16;
        }
        
        val_33 = 0;
        label_13:
        val_34 = 1152921504848912384;
        if(val_33 != 0)
        {
            goto label_19;
        }
        
        object[] val_10 = new object[1];
        val_35 = val_10;
        val_35[0] = this.丒丁东世世丗丅丅丄;
        UnityEngine.Debug.LogErrorFormat(format:  "cell with container \'{0}\' not found", args:  val_10);
        goto label_28;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_28:
        label_3:
        val_37 = 0;
        return (bool)val_37;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_31 != null)
        {
            goto label_30;
        }
        
        val_34 = 1;
        goto label_31;
        label_19:
        this.丝且与丝丒丟万丁专._animator.SetTrigger(name:  "HandleOpen");
        if(this.丝且与丝丒丟万丁专._animator != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_13 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.丝且与丝丒丟万丁专._animator);
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专._animator != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_16 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.丝且与丝丒丟万丁专._animator);
        }
        
        }
        
        UICenterOnChild val_17 = this.丝且与丝丒丟万丁专._animator.GetComponent<UICenterOnChild>();
        this.丂丌丁丈下丁丑万丅 = val_17;
        if(val_17 != 0)
        {
                this.丂丌丁丈下丁丑万丅.enabled = false;
        }
        
        val_35 = val_33.gameObject;
        val_31.MoveScrollTo(丞下万上三丘上与专:  val_35.transform, 丐丐七专三且世三七:  true, 丝丒丏丒万丂万万东:  1);
        label_30:
        val_34 = 0;
        label_31:
        if(val_31.ToCenterMoving != false)
        {
                val_37 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_37;
            return (bool)val_37;
        }
        
        if(this.丂丌丁丈下丁丑万丅 != 0)
        {
                this.丂丌丁丈下丁丑万丅.enabled = true;
        }
        
        if(this.丝且与丝丒丟万丁专._baseChestAnimator.gameObject.activeInHierarchy == false)
        {
            goto label_65;
        }
        
        if(this.丝且与丝丒丟万丁专._baseChestAnimator != null)
        {
            goto label_71;
        }
        
        label_72:
        label_71:
        this.丝且与丝丒丟万丁专._baseChestAnimator.SetTrigger(name:  "HandleOpen");
        goto label_70;
        label_65:
        if(this.丝且与丝丒丟万丁专._superChestAnimator.gameObject.activeInHierarchy == false)
        {
            goto label_70;
        }
        
        if(this.丝且与丝丒丟万丁专._superChestAnimator != null)
        {
            goto label_71;
        }
        
        goto label_72;
        label_70:
        if(this.丝且与丝丒丟万丁专._baseChestAnimator != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_29 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.丝且与丝丒丟万丁专._baseChestAnimator);
        }
        
        }
        
        UnityEngine.WaitForSeconds val_30 = null;
        val_31 = val_30;
        val_30 = new UnityEngine.WaitForSeconds(seconds:  V8.16B);
        this.丒上七丌业七丟与丐 = val_31;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_37 = 1;
        return (bool)val_37;
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
