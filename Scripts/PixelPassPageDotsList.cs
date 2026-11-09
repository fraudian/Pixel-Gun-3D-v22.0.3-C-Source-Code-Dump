using UnityEngine;
internal sealed class PixelPassPageDotsList : PGBehaviour
{
    // Fields
    private PixelPassRewardsLineView rewardsLineView;
    private MiniPoolMonoBehaviour pool;
    private WidgetLayout layput;
    private System.Collections.Generic.List<PixelPassPageDot> 丏下与丒丁丁丗丌丏;
    private EndlessScrollDynamic 丒不丐丏且丐上丌万;
    
    // Properties
    internal EndlessScrollDynamic 一且不且丟丘万丏丑 { get; }
    
    // Methods
    internal EndlessScrollDynamic 不业丕与专世丄丝丝()
    {
        return (EndlessScrollDynamic)this.丒不丐丏且丐上丌万;
    }
    internal void 丈且东丑丂且万丒丅(EndlessScrollDynamic 丅七丙丑丂丕丟丗不)
    {
        this.丒不丐丏且丐上丌万 = 丅七丙丑丂丕丟丗不;
        this.丝一丅丆三东丂丞七();
    }
    internal void 丝一丅丆三东丂丞七()
    {
        int val_4;
        this.世业丒万丘丆专丘丐();
        if(this.丒不丐丏且丐上丌万 == 0)
        {
                return;
        }
        
        val_4 = 0;
        goto label_4;
        label_12:
        PixelPassPageDot val_2 = this.pool.Get<PixelPassPageDot>();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_2, 丏业丟一东丂东丘丛:  true);
        val_2.丄丘三丁上丐三丟世 = this;
        val_2.上上且丈丘下不丈上 = val_4;
        val_2.丝一丅丆三东丂丞七();
        this.丏下与丒丁丁丗丌丏.Add(item:  val_2);
        this.layput.AddElement(丅丆东丏丙丝丅丆丟:  val_2);
        val_4 = 1;
        label_4:
        if(val_4 < this.丒不丐丏且丐上丌万.ItemsCount)
        {
            goto label_12;
        }
        
        this.layput.Reposition();
    }
    private void 世业丒万丘丆专丘丐()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.pool.example, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_1 = this.丏下与丒丁丁丗丌丏.GetEnumerator();
        label_7:
        if(((-401456008) & 1) == 0)
        {
            goto label_5;
        }
        
        this.pool.Return(万且万且丑丗且丌丆:  0.丐丏七丌丕丗业且上());
        goto label_7;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丏下与丒丁丁丗丌丏.Clear();
        this.layput.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
    }
    public void SelectDot(PixelPassPageDot 丂丘丟丞丅丟丛上丐)
    {
        if(this.丒不丐丏且丐上丌万 == 0)
        {
                return;
        }
        
        this.丒不丐丏且丐上丌万.业丌丘一丐丕专丆丞(丏丑丝万下与丁丞业:  丂丘丟丞丅丟丛上丐.上上且丈丘下不丈上, 万丁丕专七丌丐丄丕:  true);
        this.rewardsLineView.centerOnPage.Recenter();
    }
    public PixelPassPageDotsList()
    {
        this.丏下与丒丁丁丗丌丏 = new System.Collections.Generic.List<PixelPassPageDot>();
    }

}
