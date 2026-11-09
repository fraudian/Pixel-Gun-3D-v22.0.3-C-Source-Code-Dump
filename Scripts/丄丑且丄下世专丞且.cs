using UnityEngine;
private sealed class PetClickHandler.丄丑且丄下世专丞且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.PetClickHandler 丝且与丝丒丟万丁专;
    private float 丒丙丏七丑丑三丐丞;
    private PetTapParametersComponent 丙丝一丑业丏七丟丆;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PetClickHandler.丄丑且丄下世专丞且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.PetClickHandler val_14;
        var val_15;
        val_14 = this.丝且与丝丒丟万丁专;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_5;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丐丌丒丟丐丂万世世 == true)
        {
            goto label_5;
        }
        
        float val_1 = val_14.丒三世丙丘丟丒专一();
        this.丒丙丏七丑丑三丐丞 = val_1;
        if(val_1 <= 0f)
        {
            goto label_5;
        }
        
        this.丝且与丝丒丟万丁专.丐丌丒丟丐丂万世世 = true;
        this.丝且与丝丒丟万丁专.丙丒丐丄丒丛下丘丁.与丒万一世与万七专().CrossFade(animation:  "Tap");
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(this.丝且与丝丒丟万丁专.丙丒丐丄丒丛下丘丁.ClipTap != 0)
        {
                this.丝且与丝丒丟万丁专.丙丒丐丄丒丛下丘丁.丕专一一三七丕丏丅().spatialBlend = 0f;
            this.丝且与丝丒丟万丁专.丙丒丐丄丒丛下丘丁.丕专一一三七丕丏丅().clip = this.丝且与丝丒丟万丁专.丙丒丐丄丒丛下丘丁.ClipTap;
            this.丝且与丝丒丟万丁专.丙丒丐丄丒丛下丘丁.丕专一一三七丕丏丅().Play();
        }
        
        }
        
        PetTapParametersComponent val_8 = this.丝且与丝丒丟万丁专.丙丒丐丄丒丛下丘丁.GetComponent<PetTapParametersComponent>();
        this.丙丝一丑业丏七丟丆 = val_8;
        if(val_8 == 0)
        {
            goto label_28;
        }
        
        this.丙丝一丑业丏七丟丆.与丂丒丞七丄丘丕三(丛丅丘一丏丙且丌上:  true);
        goto label_28;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_10 = UnityEngine.Time.deltaTime;
        val_10 = this.丒丙丏七丑丑三丐丞 - val_10;
        this.丒丙丏七丑丑三丐丞 = val_10;
        label_28:
        if(this.丝且与丝丒丟万丁专.丐丌丒丟丐丂万世世 != false)
        {
                if(this.丒丙丏七丑丑三丐丞 > 0f)
        {
            goto label_30;
        }
        
        }
        
        this.丝且与丝丒丟万丁专.丐丌丒丟丐丂万世世 = false;
        if(this.丙丝一丑业丏七丟丆 != 0)
        {
                this.丙丝一丑业丏七丟丆.与丂丒丞七丄丘丕三(丛丅丘一丏丙且丌上:  false);
        }
        
        if((this.丝且与丝丒丟万丁专.丙丒丐丄丒丛下丘丁.丕东丌丄丁丛丌丑丕(丁丅丈丌丟世丗丗丟:  4)) == null)
        {
                return (bool)val_15;
        }
        
        val_14 = val_12.AnimationName;
        this.丝且与丝丒丟万丁专.丙丒丐丄丒丛下丘丁.与丒万一世与万七专().CrossFade(animation:  val_14);
        label_5:
        val_15 = 0;
        return (bool)val_15;
        label_30:
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 1;
        return (bool)val_15;
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
