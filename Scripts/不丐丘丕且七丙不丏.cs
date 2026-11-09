using UnityEngine;
private sealed class ThreeChestsGameEventView.不丐丘丕且七丙不丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.ThreeChestsGameEventView 丝且与丝丒丟万丁专;
    public int 丒丁东世世丗丅丅丄;
    public int 丝丒丏丒万丂万万东;
    private UICenterOnChild 丂丌丁丈下丁丑万丅;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public ThreeChestsGameEventView.不丐丘丕且七丙不丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.ThreeChestsGameEventView val_26;
        UnityEngine.Object val_27;
        UnityEngine.Object val_28;
        var val_29;
        System.Object[] val_30;
        var val_31;
        int val_32;
        val_26 = this.丝且与丝丒丟万丁专;
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
            goto label_26;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        val_27 = 0;
        goto label_5;
        label_16:
        val_28 = X21.transform.GetChild(index:  0).GetComponent<Rilisoft.GameEventScrollContainerView>();
        if(val_28.Container != null)
        {
                if(val_28.Container.Id == this.丒丁东世世丗丅丅丄)
        {
            goto label_13;
        }
        
        }
        
        val_27 = 1;
        label_5:
        if(val_27 < val_28.transform.childCount)
        {
            goto label_16;
        }
        
        val_28 = 0;
        label_13:
        val_29 = 1152921504848912384;
        if(val_28 != 0)
        {
            goto label_19;
        }
        
        object[] val_10 = new object[1];
        val_30 = val_10;
        val_30[0] = this.丒丁东世世丗丅丅丄;
        UnityEngine.Debug.LogErrorFormat(format:  "cell with container \'{0}\' not found", args:  val_10);
        goto label_26;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_26 == null)
        {
            goto label_28;
        }
        
        goto label_29;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(val_26 != null)
        {
            goto label_30;
        }
        
        val_31 = 1;
        goto label_31;
        label_19:
        if(val_27 != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_13 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_27);
        }
        
        }
        
        UICenterOnChild val_14 = val_27.GetComponent<UICenterOnChild>();
        this.丂丌丁丈下丁丑万丅 = val_14;
        if(val_14 != 0)
        {
                this.丂丌丁丈下丁丑万丅.enabled = false;
        }
        
        val_30 = val_28.gameObject;
        val_26.MoveScrollTo(丞下万上三丘上与专:  val_30.transform, 丐丐七专三且世三七:  true, 丝丒丏丒万丂万万东:  this.丝丒丏丒万丂万万东);
        label_30:
        val_31 = 0;
        label_31:
        if(val_26.ToCenterMoving != false)
        {
                val_32 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_32;
            return (bool)val_32;
        }
        
        val_29 = 1152921504848912384;
        if(this.丂丌丁丈下丁丑万丅 != 0)
        {
                this.丂丌丁丈下丁丑万丅.enabled = true;
        }
        
        UnityEngine.Animator val_20 = val_26.丁丘丈业丙丑万丏丑();
        if(val_20 != 0)
        {
                val_20.SetTrigger(name:  "HandleOpen");
        }
        
        if(val_20 != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                UnityEngine.AudioSource val_24 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  val_20);
        }
        
        }
        
        UnityEngine.WaitForSeconds val_25 = null;
        val_26 = val_25;
        val_25 = new UnityEngine.WaitForSeconds(seconds:  V8.16B);
        this.丒上七丌业七丟与丐 = val_26;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_32 = 1;
        return (bool)val_32;
        label_28:
        label_29:
        val_26.UpdateSpinButtonsAndChests();
        label_26:
        val_32 = 0;
        return (bool)val_32;
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
