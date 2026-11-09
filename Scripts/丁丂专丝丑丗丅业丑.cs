using UnityEngine;
private sealed class ReusableRewardedVideo.丁丂专丝丑丗丅业丑 : ReusableRewardedVideo.丕丛丁丈丆丐丆丑丁
{
    // Fields
    private readonly string 丅丌丅三丟七丗且丌;
    
    // Methods
    public ReusableRewardedVideo.丁丂专丝丑丗丅业丑(Rilisoft.ReusableRewardedVideo 下丒丗丛丙丆丄丈专, string 丁丂丕与丁丒丕丟丞)
    {
        if(丁丂丕与丁丒丕丟丞 == null)
        {
            goto label_1;
        }
        
        label_4:
        this.丅丌丅三丟七丗且丌 = 丁丂丕与丁丒丕丟丞;
        return;
        label_1:
        if(this != null)
        {
            goto label_4;
        }
        
        goto label_4;
    }
    public override void 丗世业丞丝且丙七下(Rilisoft.丟世丈丕世丌丌与丐<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 且东丁丄业世丞丁不, Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
    {
        Rilisoft.ReusableRewardedVideo.丈丐丐丂丑丅丟与丁(丄丙下丝丛丒七丂丘:  "Failure.Enter: "("Failure.Enter: ") + this.丅丌丅三丟七丗且丌);
        static_value_082C90A8.SetActive(value:  true);
        this.SetActive(value:  true);
    }
    public override Rilisoft.万丐丂专丏丛丑丌丑<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 丞一丙东丐且丝丞丑(Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
    {
        Rilisoft.丝丌万丗三丈与丁丂<TInput> val_3;
        var val_4;
        if(丗丄下丈丑七丗丞专 == 5)
        {
                Rilisoft.万丝与与丈七七且丂<ReusableRewardedVideo.丈丒丟上七丝且业丅, 丒且万不丌丁丂丒丟> val_2 = null;
            val_3 = val_2;
            val_2 = new Rilisoft.万丝与与丈七七且丂<ReusableRewardedVideo.丈丒丟上七丝且业丅, 丒且万不丌丁丂丒丟>(与丆丌丂丟丛丘丑且:  new ReusableRewardedVideo.丈丒丟上七丝且业丅(下丒丗丛丙丆丄丈专:  this));
            return (Rilisoft.万丐丂专丏丛丑丌丑<丒且万不丌丁丂丒丟>)val_3;
        }
        
        val_4 = null;
        val_4 = null;
        val_3 = Rilisoft.丝丌万丗三丈与丁丂<TInput>.万丝上三丈下丌业与;
        return (Rilisoft.万丐丂专丏丛丑丌丑<丒且万不丌丁丂丒丟>)val_3;
    }
    public override void 丕丗丏东丘丑丗与丅(Rilisoft.丟世丈丕世丌丌与丐<Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟> 与丆丌丂丟丛丘丑且, Rilisoft.ReusableRewardedVideo.丒且万不丌丁丂丒丟 丗丄下丈丑七丗丞专)
    {
        Rilisoft.ReusableRewardedVideo.丈丐丐丂丑丅丟与丁(丄丙下丝丛丒七丂丘:  "Failure.Exit: "("Failure.Exit: ") + this.丅丌丅三丟七丗且丌);
        static_value_082C9088.SetActive(value:  false);
        this.SetActive(value:  false);
    }

}
