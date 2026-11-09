using UnityEngine;
private sealed class CharactersCorouselItem.专丑丁丂丈与且丝丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public Rilisoft.CharactersCorouselItem 丝且与丝丒丟万丁专;
    public Rilisoft.PetEngine 丙丂不业且丄丏丞万;
    private float 丒丙丏七丑丑三丐丞;
    private PetTapParametersComponent 丙丝一丑业丏七丟丆;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public CharactersCorouselItem.专丑丁丂丈与且丝丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        string val_27;
        var val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        int val_35;
        val_27 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_60;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.丐丌丒丟丐丂万世世 == true)
        {
            goto label_60;
        }
        
        this.丒丙丏七丑丑三丐丞 = 0f;
        System.Collections.IEnumerator val_2 = this.丙丂不业且丄丏丞万.与丒万一世与万七专().GetEnumerator();
        label_22:
        var val_29 = 0;
        val_29 = val_29 + 1;
        if(val_2.MoveNext() == false)
        {
            goto label_12;
        }
        
        var val_30 = 0;
        val_30 = val_30 + 1;
        val_30 = val_2.Current;
        if(val_30 != null)
        {
                if(null == null)
        {
            goto label_19;
        }
        
        }
        
        val_30 = 0;
        val_31 = 1;
        goto label_20;
        label_19:
        val_31 = 0;
        label_20:
        if((System.String.op_Equality(a:  val_30.clip.name, b:  "Tap")) == false)
        {
            goto label_22;
        }
        
        float val_13 = val_30.speed;
        val_13 = val_30.clip.length * val_13;
        val_32 = 0;
        val_33 = 0;
        val_34 = 168;
        this.丒丙丏七丑丑三丐丞 = val_13;
        goto label_40;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        float val_14 = UnityEngine.Time.deltaTime;
        val_14 = this.丒丙丏七丑丑三丐丞 - val_14;
        this.丒丙丏七丑丑三丐丞 = val_14;
        label_83:
        if(this.丝且与丝丒丟万丁专.丐丌丒丟丐丂万世世 != false)
        {
                if(this.丒丙丏七丑丑三丐丞 > 0f)
        {
            goto label_29;
        }
        
        }
        
        this.丝且与丝丒丟万丁专.丐丌丒丟丐丂万世世 = false;
        if(this.丙丝一丑业丏七丟丆 != 0)
        {
                this.丙丝一丑业丏七丟丆.与丂丒丞七丄丘丕三(丛丅丘一丏丙且丌上:  false);
        }
        
        if((this.丙丂不业且丄丏丞万.丕东丌丄丁丛丌丑丕(丁丅丈丌丟世丗丗丟:  4)) == null)
        {
                return (bool)val_35;
        }
        
        val_27 = val_16.AnimationName;
        bool val_18 = this.丙丂不业且丄丏丞万.与丒万一世与万七专().Play(animation:  val_27);
        goto label_60;
        label_29:
        val_35 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_35;
        return (bool)val_35;
        label_12:
        val_32 = 0;
        val_33 = 0;
        val_34 = 168;
        label_40:
        if(val_2 != null)
        {
                var val_31 = 0;
            val_31 = val_31 + 1;
            val_2.Dispose();
        }
        
        if( == 1)
        {
            goto label_57;
        }
        
        if(( == false) || (168 == 168))
        {
            goto label_85;
        }
        
        label_84:
        label_85:
        if(this.丒丙丏七丑丑三丐丞 <= 0f)
        {
            goto label_60;
        }
        
        this.丝且与丝丒丟万丁专.丐丌丒丟丐丂万世世 = true;
        bool val_21 = this.丙丂不业且丄丏丞万.与丒万一世与万七专().Play(animation:  "Tap");
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                if(this.丙丂不业且丄丏丞万.ClipTap != 0)
        {
                this.丙丂不业且丄丏丞万.丕专一一三七丕丏丅().spatialBlend = 0f;
            this.丙丂不业且丄丏丞万.丕专一一三七丕丏丅().clip = this.丙丂不业且丄丏丞万.ClipTap;
            this.丙丂不业且丄丏丞万.丕专一一三七丕丏丅().Play();
        }
        
        }
        
        PetTapParametersComponent val_27 = this.丙丂不业且丄丏丞万.GetComponent<PetTapParametersComponent>();
        this.丙丝一丑业丏七丟丆 = val_27;
        if(val_27 == 0)
        {
            goto label_83;
        }
        
        this.丙丝一丑业丏七丟丆.与丂丒丞七丄丘丕三(丛丅丘一丏丙且丌上:  true);
        goto label_83;
        label_60:
        val_35 = 0;
        return (bool)val_35;
        label_57:
        if( == true)
        {
            goto label_84;
        }
        
        goto label_85;
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
