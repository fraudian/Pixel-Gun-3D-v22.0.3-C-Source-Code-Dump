using UnityEngine;
private sealed class HintController.丟七丆丘丈万丕丙丒 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    private int 丈世三丐万且丅上丈;
    private float 丕丕世且下一与丝与;
    public float 东丒丝丈丝东丈上一;
    public HintController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public HintController.丟七丆丘丈万丕丙丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        HintController val_23;
        int val_24;
        EventDelegate val_25;
        var val_26;
        var val_27;
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
        if(this.丕丕世且下一与丝与 <= 0f)
        {
            goto label_3;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_23 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        val_24 = 1;
        this.丒上七丌业七丟与丐 = val_23;
        this.丗丏丅丕丆世丁专丟 = val_24;
        return (bool)val_24;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        val_24 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟;
        if(val_24.Count == 0)
        {
                return (bool)val_24;
        }
        
        HintItem val_3 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
        if(val_3.hideReason == 1)
        {
                HintItem val_4 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
            UIButton val_5 = val_4.target.GetComponent<UIButton>();
            val_25 = this.丝且与丝丒丟万丁专.丕专且下丙丌丅丙丞;
            bool val_6 = val_5.onClick.Remove(item:  val_25);
        }
        
        HintItem val_7 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
        if(val_7.buttonsToBlock == null)
        {
            goto label_22;
        }
        
        HintItem val_8 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
        if(val_8.buttonsToBlock.Length == 0)
        {
            goto label_22;
        }
        
        val_26 = 0;
        goto label_23;
        label_36:
        HintItem val_9 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
        UIButton val_23 = val_9.buttonsToBlock[0];
        val_27 = public HintItem System.Collections.Generic.List<HintItem>::get_Item(int index);
        HintItem val_10 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
        if(val_26 >= val_10.buttonsState.Length)
        {
                val_27 = 0;
        }
        
        val_25 = val_10.buttonsState[0];
        var val_11 = (val_25 == true) ? 1 : 0;
        val_26 = 1;
        label_23:
        HintItem val_12 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
        if(val_26 < val_12.buttonsToBlock.Length)
        {
            goto label_36;
        }
        
        label_22:
        HintItem val_13 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
        if(val_13.objectsToHide == null)
        {
            goto label_43;
        }
        
        HintItem val_14 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
        if(val_14.objectsToHide.Length == 0)
        {
            goto label_43;
        }
        
        val_26 = 0;
        goto label_44;
        label_57:
        HintItem val_15 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
        HintItem val_16 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
        val_25 = val_16.objActiveState[0];
        val_15.objectsToHide[0].SetActive(value:  (val_25 == true) ? 1 : 0);
        val_26 = 1;
        label_44:
        HintItem val_18 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
        if(val_26 < val_18.objectsToHide.Length)
        {
            goto label_57;
        }
        
        label_43:
        HintItem val_19 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
        if(val_19.enableColliders != false)
        {
                HintItem val_20 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
            if(val_20.collidersObj != 0)
        {
                HintItem val_22 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
            val_22.collidersObj.SetActive(value:  false);
        }
        
        }
        
        this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.RemoveAt(index:  0);
        this.丝且与丝丒丟万丁专.hintObject.Hide();
        this.丝且与丝丒丟万丁专.下丏七丘万业三丄丌 = 0;
        val_23.专丅丁万世七丒丑丕();
        label_2:
        val_24 = 0;
        return (bool)val_24;
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
    private System.Collections.Generic.IEnumerator<object> System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator()
    {
        var val_4;
        if((this.丗丏丅丕丆世丁专丟 == 2) && (this.丈世三丐万且丅上丈 == System.Environment.CurrentManagedThreadId))
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            val_4 = this;
        }
        else
        {
                HintController.丟七丆丘丈万丕丙丒 val_2 = null;
            val_4 = val_2;
            val_2 = new HintController.丟七丆丘丈万丕丙丒();
            .丗丏丅丕丆世丁专丟 = 0;
            .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
            .丝且与丝丒丟万丁专 = this.丝且与丝丒丟万丁专;
        }
        
        .丕丕世且下一与丝与 = this.东丒丝丈丝东丈上一;
        return (System.Collections.Generic.IEnumerator<System.Object>)val_4;
    }
    private System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.System.Collections.Generic.IEnumerable<System.Object>.GetEnumerator();
    }

}
