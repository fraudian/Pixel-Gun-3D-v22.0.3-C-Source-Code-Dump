using UnityEngine;
internal sealed class LoadingAnimation : PGBehaviour
{
    // Fields
    private UILabel _label;
    private UnityEngine.Coroutine 七丄丐丘东丏不专丁;
    
    // Properties
    internal bool 三不专丗七丄且丝业 { get; }
    
    // Methods
    internal bool 世丑三丆丒七丘丕丑()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.activeSelf;
        }
        
        return val_1.activeSelf;
    }
    internal void 下与丞三丅丛丄七丕(string 丕丗丘丑丛与丑业丒, float 丂三丟丂丈丐丆丗丟 = -1)
    {
        if(this.七丄丐丘东丏不专丁 != null)
        {
                this.StopCoroutine(routine:  this.七丄丐丘东丏不专丁);
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._label, 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒);
        this.gameObject.SetActive(value:  true);
        if(丂三丟丂丈丐丆丗丟 < 0f)
        {
                return;
        }
        
        this.七丄丐丘东丏不专丁 = this.StartCoroutine(routine:  this.丈丒不下且丌世丑丘(丂三丟丂丈丐丆丗丟:  丂三丟丂丈丐丆丗丟));
    }
    internal void 丆世与丑丆丅丐万且()
    {
        if(this.七丄丐丘东丏不专丁 != null)
        {
                this.StopCoroutine(routine:  this.七丄丐丘东丏不专丁);
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private System.Collections.IEnumerator 丈丒不下且丌世丑丘(float 丂三丟丂丈丐丆丗丟)
    {
        LoadingAnimation.丄丘丅三专丛万丂上 val_1 = new LoadingAnimation.丄丘丅三专丛万丂上();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丂三丟丂丈丐丆丗丟 = 丂三丟丂丈丐丆丗丟;
        return (System.Collections.IEnumerator)val_1;
    }
    public LoadingAnimation()
    {
    
    }

}
