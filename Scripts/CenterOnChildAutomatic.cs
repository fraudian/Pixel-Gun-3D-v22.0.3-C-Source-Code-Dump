using UnityEngine;
internal sealed class CenterOnChildAutomatic : PGBehaviour
{
    // Fields
    internal UICenterOnChild centerOnChild;
    internal UIScrollView scrollView;
    internal float recenterTime;
    internal float 丞不万丕丅丆不七丈;
    private UnityEngine.Coroutine 一丞丐丞丘一东丄丏;
    
    // Methods
    private void OnEnable()
    {
        if(this.一丞丐丞丘一东丄丏 != null)
        {
                this.StopCoroutine(routine:  this.一丞丐丞丘一东丄丏);
        }
        
        this.一丞丐丞丘一东丄丏 = this.StartCoroutine(routine:  this.三丆东丈丟丛丗丟丅(三丟丆且丁丏丅丛万:  this.recenterTime));
    }
    private void 业丞七丂丂丒七三丛()
    {
        if(this.一丞丐丞丘一东丄丏 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.一丞丐丞丘一东丄丏);
    }
    private System.Collections.IEnumerator 三丆东丈丟丛丗丟丅(float 三丟丆且丁丏丅丛万)
    {
        CenterOnChildAutomatic.一丈丁与丘丕七丟业 val_1 = new CenterOnChildAutomatic.一丈丁与丘丕七丟业();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .三丟丆且丁丏丅丛万 = 三丟丆且丁丏丅丛万;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 专丏丞七丝丛下丌丗()
    {
        if(this.centerOnChild == 0)
        {
                return;
        }
        
        int val_9 = 0;
        do
        {
            if(val_9 >= this.centerOnChild.transform.childCount)
        {
                return;
        }
        
            val_9 = val_9 + 1;
        }
        while((this.centerOnChild.transform.GetChild(index:  0).gameObject) != this.centerOnChild.centeredObject);
        
        this.三专丛丕上丘丑丆不(丞世不丒下上上丝丑:  val_9);
    }
    private void 三专丛丕上丘丑丆不(int 丞世不丒下上上丝丑)
    {
        int val_8 = 丞世不丒下上上丝丑;
        if(this.centerOnChild.transform.childCount == 0)
        {
                return;
        }
        
        if((val_8 & 2147483648) == 0)
        {
                if(this.centerOnChild.transform.childCount > val_8)
        {
            goto label_7;
        }
        
        }
        
        val_8 = 0;
        label_7:
        UnityEngine.Transform val_6 = this.centerOnChild.transform.GetChild(index:  0);
        if(val_6 == 0)
        {
                return;
        }
        
        this.centerOnChild.CenterOn(丞下万上三丘上与专:  val_6);
    }
    public CenterOnChildAutomatic()
    {
        this.recenterTime = 5f;
    }

}
