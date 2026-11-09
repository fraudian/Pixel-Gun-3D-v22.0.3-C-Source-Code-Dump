using UnityEngine;
internal sealed class PixelPassPageView : EndlessScrollCellDynamic
{
    // Fields
    private UnityEngine.GameObject holder;
    private WidgetLayout levelsLayout;
    private MiniPoolMonoBehaviour levelViewPool;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableIfSelected;
    private System.Collections.Generic.List<PixelPassLevelView> 丄不丝丘世丂丂业丐;
    private PGCompany.PixelPass.不万丄丛丁下业丟上 丟三一世上丂丘丐业;
    
    // Properties
    internal PGCompany.PixelPass.不万丄丛丁下业丟上 专丄丏丌丘与丘丟七 { get; }
    
    // Methods
    internal PGCompany.PixelPass.不万丄丛丁下业丟上 一丄七下业世一丁与()
    {
        return (PGCompany.PixelPass.不万丄丛丁下业丟上)this.丟三一世上丂丘丐业;
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.PixelPass.不万丄丛丁下业丟上 七与丗一丗一与丟丅)
    {
        this.丟三一世上丂丘丐业 = 七与丗一丗一与丟丅;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        if(this.丟三一世上丂丘丐业 != null)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  true);
            this.holder.enabled = true;
            this.上东与丛丞下丈专丈();
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  false);
        this.enabled = false;
    }
    private void 世业丒万丘丆专丘丐()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.levelViewPool.example, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_1 = this.丄不丝丘世丂丂业丐.GetEnumerator();
        label_7:
        if(((-400638600) & 1) == 0)
        {
            goto label_5;
        }
        
        this.levelViewPool.Return(万且万且丑丗且丌丆:  0.丐丏七丌丕丗业且上());
        goto label_7;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.levelsLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        this.丄不丝丘世丂丂业丐.Clear();
    }
    private void 上东与丛丞下丈专丈()
    {
        var val_4;
        this.世业丒万丘丆专丘丐();
        List.Enumerator<T> val_2 = this.丟三一世上丂丘丐业.丒东丒上世丘一丗丈().GetEnumerator();
        label_10:
        if(((-400459040) & 1) == 0)
        {
            goto label_3;
        }
        
        PixelPassLevelView val_6 = this.levelViewPool.Get<PixelPassLevelView>();
        val_6.丈且东丑丂且万丒丅(丅丌丆丁世一丙丑丐:  val_4.丐丏七丌丕丗业且上());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_6, 丏业丟一东丂东丘丛:  true);
        this.levelsLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_6);
        this.丄不丝丘世丂丂业丐.Add(item:  val_6);
        goto label_10;
        label_3:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.levelsLayout.Reposition();
    }
    public override void OnSelectStateUpdate()
    {
        this.OnSelectStateUpdate();
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableIfSelected, 丏业丟一东丂东丘丛:  this.Selected);
    }
    public PixelPassPageView()
    {
        this.丄不丝丘世丂丂业丐 = new System.Collections.Generic.List<PixelPassLevelView>();
    }

}
