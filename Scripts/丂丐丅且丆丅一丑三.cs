using UnityEngine;
private sealed class HintController.丂丐丅且丆丅一丑三 : IEnumerable<object>, IEnumerable, IEnumerator<object>, IEnumerator, IDisposable
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
    public HintController.丂丐丅且丆丅一丑三(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
        this.丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        HintController val_25;
        int val_26;
        var val_28;
        var val_29;
        var val_30;
        val_25 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_9;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丕丕世且下一与丝与 <= 0f)
        {
            goto label_3;
        }
        
        UnityEngine.WaitForSeconds val_1 = null;
        val_25 = val_1;
        val_1 = new UnityEngine.WaitForSeconds(seconds:  this.丕丕世且下一与丝与);
        val_26 = 1;
        this.丒上七丌业七丟与丐 = val_25;
        this.丗丏丅丕丆世丁专丟 = val_26;
        return (bool)val_26;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_3:
        if(this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Count < 1)
        {
            goto label_9;
        }
        
        HintItem val_3 = this.丝且与丝丒丟万丁专.七上丁丌丈丁专丈丟.Item[0];
        if(this.丝且与丝丒丟万丁专.下丏七丘万业三丄丌 == val_3)
        {
            goto label_9;
        }
        
        if(val_3.target != 0)
        {
            goto label_13;
        }
        
        UnityEngine.Debug.LogError(message:  "Hint: target == null");
        label_9:
        val_26 = 0;
        return (bool)val_26;
        label_13:
        if(val_3.hideReason == 1)
        {
                val_3.targetButton = val_3.target.GetComponent<UIButton>();
            val_5.onClick.Add(item:  this.丝且与丝丒丟万丁专.丕专且下丙丌丅丙丞);
        }
        
        if(val_3.timeout > 0f)
        {
                var val_26 = 0;
            val_26 = val_26 + 1;
            UnityEngine.Coroutine val_9 = val_25.StartCoroutine(routine:  val_25.ShowNextD(丕丕世且下一与丝与:  val_3.timeout).GetEnumerator());
        }
        
        if((val_3.buttonsToBlock == null) || (val_3.buttonsToBlock.Length == 0))
        {
            goto label_29;
        }
        
        int val_10 = val_3.buttonsToBlock.Length & 4294967295;
        val_3.buttonsState = new bool[0];
        val_28 = 0;
        goto label_31;
        label_46:
        bool val_28 = val_3.buttonsToBlock[0];
        val_28 = val_28 & 1;
        val_3.buttonsState[0] = val_28;
        val_29 = 0;
        if(val_3.buttonsToBlock[0] != (val_3.target.GetComponent<UIButton>()))
        {
                if(val_28 >= val_3.buttonsToBlock.Length)
        {
                val_29 = 0;
        }
        
            UIButton val_30 = val_3.buttonsToBlock[0];
        }
        
        val_28 = 1;
        label_31:
        if(val_28 < val_3.buttonsToBlock.Length)
        {
            goto label_46;
        }
        
        label_29:
        if((val_3.objectsToHide == null) || (val_3.objectsToHide.Length == 0))
        {
            goto label_48;
        }
        
        int val_14 = val_3.objectsToHide.Length & 4294967295;
        val_30 = 0;
        val_3.objActiveState = new bool[0];
        goto label_49;
        label_59:
        val_3.objActiveState[0] = val_3.objectsToHide[0].activeSelf;
        val_3.objectsToHide[0].SetActive(value:  false);
        val_30 = 1;
        label_49:
        if(val_30 < val_3.objectsToHide.Length)
        {
            goto label_59;
        }
        
        label_48:
        if(val_3.enableColliders != false)
        {
                if(val_3.collidersObj != 0)
        {
                val_3.collidersObj.SetActive(value:  true);
        }
        else
        {
                UnityEngine.Debug.LogError(message:  "Hint: collidersObj == null");
        }
        
        }
        
        if(val_3.indicateTarget == false)
        {
            goto label_68;
        }
        
        if(val_3.targetButton == 0)
        {
                val_3.targetButton = val_3.target.GetComponent<UIButton>();
        }
        
        if(((System.String.IsNullOrEmpty(value:  val_3.indicatedSpriteName)) == true) || (val_3.targetButton == 0))
        {
            goto label_76;
        }
        
        UISprite val_23 = val_3.targetButton.GetComponent<UISprite>();
        val_3.targetSprite = val_23;
        val_3.defaultSpriteName = val_23.spriteName;
        if(val_25 != null)
        {
            goto label_83;
        }
        
        goto label_81;
        label_76:
        val_3.targetSprites = val_3.target.GetComponentsInChildren<UISprite>();
        label_68:
        if(val_25 != null)
        {
            goto label_83;
        }
        
        label_81:
        label_83:
        this.丝且与丝丒丟万丁专.hintObject.专丅丁万世七丒丑丕(丙不丈东丒下三丛丁:  val_3);
        this.丝且与丝丒丟万丁专.下丏七丘万业三丄丌 = val_3;
        return (bool)val_26;
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
                HintController.丂丐丅且丆丅一丑三 val_2 = null;
            val_4 = val_2;
            val_2 = new HintController.丂丐丅且丆丅一丑三();
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
