using UnityEngine;
internal sealed class RewardItemStackUI : PGBehaviour
{
    // Fields
    private PanelStackUI panelStackUI;
    private UnityEngine.GameObject countHolder;
    private UILabel countLabel;
    private MiniPoolMonoBehaviour miniPool;
    private System.Collections.Generic.List<ItemRewardView> 丁专丈丆丐丙世业丄;
    
    // Methods
    internal void 世业丒万丘丆专丘丐()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.miniPool.example, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_1 = this.丁专丈丆丐丙世业丄.GetEnumerator();
        label_7:
        if(((-1226860424) & 1) == 0)
        {
            goto label_5;
        }
        
        this.miniPool.Return(万且万且丑丗且丌丆:  0.丐丏七丌丕丗业且上());
        goto label_7;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.panelStackUI.世业丒万丘丆专丘丐();
        this.丁专丈丆丐丙世业丄.Clear();
        this.一丆丆丗丝丞专丑专(丌丒丝东丌下丕丁丅:  0);
    }
    internal void 丑上不不东丘丝丑丝(PGCompany.丄与丘丑业专丞七丅 万不丛丅丒丌丌丛丟)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.miniPool.example, 丏业丟一东丂东丘丛:  false);
        ItemRewardView val_1 = this.miniPool.Get<ItemRewardView>();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_1, 丏业丟一东丂东丘丛:  true);
        this.丁专丈丆丐丙世业丄.Add(item:  val_1);
        this.panelStackUI.AddTop(丅丆东丏丙丝丅丆丟:  val_1);
        this.一丆丆丗丝丞专丑专(丌丒丝东丌下丕丁丅:  this.丁专丈丆丐丙世业丄.Count);
    }
    private void 一丆丆丗丝丞专丑专(int 丌丒丝东丌下丕丁丅)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.countHolder, 丏业丟一东丂东丘丛:  (丌丒丝东丌下丕丁丅 > 0) ? 1 : 0);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.countLabel, 丕丗丘丑丛与丑业丒:  丌丒丝东丌下丕丁丅);
    }
    public RewardItemStackUI()
    {
        this.丁专丈丆丐丙世业丄 = new System.Collections.Generic.List<ItemRewardView>();
    }

}
