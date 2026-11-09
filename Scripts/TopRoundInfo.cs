using UnityEngine;
public sealed class TopRoundInfo : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<MiniPoolMonoBehaviour> _listMiniPool;
    private WidgetLayout _widgetLayout;
    private System.Collections.Generic.List<TopRoundItemInfo> 丗丄丑丈丏且专丆丛;
    
    // Methods
    internal void 世与东丗世三丞丞不(System.Collections.Generic.List<丏下一丌且三与丘丘> 一上丘丕万丕丟丐专)
    {
        var val_3;
        var val_9;
        List.Enumerator<T> val_1 = 一上丘丕万丕丟丐专.GetEnumerator();
        val_9 = 0;
        goto label_2;
        label_16:
        var val_10 = 0;
        val_10 = val_10 + 1;
        TopRoundItemInfo val_8 = this._listMiniPool.Item[val_3.丐丏七丌丕丗业且上().GetIndexMiniPool()].Get<TopRoundItemInfo>();
        this.丗丄丑丈丏且专丆丛.Add(item:  val_8);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_8, 丏业丟一东丂东丘丛:  true);
        val_8.丅丝三丌且三丐万世(下丅丙一丂丗丅丝七:  一上丘丕万丕丟丐专.Item[0]);
        this._widgetLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_8);
        val_9 = 1;
        label_2:
        if(((-1290607904) & 1) != 0)
        {
            goto label_16;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this._widgetLayout.Reposition();
    }
    private void Update()
    {
        List.Enumerator<T> val_1 = this.丗丄丑丈丏且专丆丛.GetEnumerator();
        label_4:
        if(((-1290446680) & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().丕下不与与不丞丟丙();
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public TopRoundInfo()
    {
        this.丗丄丑丈丏且专丆丛 = new System.Collections.Generic.List<TopRoundItemInfo>();
    }

}
