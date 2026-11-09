using UnityEngine;
public class PlacebleItemsListUI : PGBehaviour
{
    // Fields
    public SelectableButtonController selectableButtonController;
    private MiniPoolMonoBehaviour miniPool;
    private UIScrollView scrollView;
    private ScrollViewHelper scrollViewHelper;
    private System.Collections.Generic.List<PlaceableItemButton> 丛不丄丁且世丁世丗;
    
    // Methods
    private void 丘上丐世丆丑且丞丒(string 且三丟七下丂专丈丈, string 七丆丒与丗丌丄且丂, string 丒丑丞丁世丌专不丈)
    {
        var val_8;
        var val_9;
        val_8 = this;
        val_9 = 0;
        goto label_1;
        label_7:
        X24.Item[0].ItemSettings = 0;
        this.miniPool.Return(万且万且丑丗且丌丆:  this.丛不丄丁且世丁世丗.Item[0]);
        val_9 = 1;
        label_1:
        if(val_9 < this.丛不丄丁且世丁世丗.Count)
        {
            goto label_7;
        }
        
        this.丛不丄丁且世丁世丗.Clear();
        this.selectableButtonController.selectedButton = 0;
        this.selectableButtonController.allButtons.Clear();
        this.selectableButtonController.widgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        this.scrollView.ResetPosition();
        List.Enumerator<T> val_5 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(且三丟七下丂专丈丈:  且三丟七下丂专丈丈, 七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂, 丑三三上丞丄一丞三:  丒丑丞丁世丌专不丈).GetEnumerator();
        label_22:
        if(((-2066528392) & 1) == 0)
        {
            goto label_17;
        }
        
        string val_6 = 0.丐丏七丌丕丗业且上();
        this.丛不丄丁且世丁世丗.Add(item:  this.miniPool.Get<PlaceableItemButton>());
        goto label_22;
        label_17:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 下与丞三丅丛丄七丕(string 且三丟七下丂专丈丈, string 七丆丒与丗丌丄且丂, string 丒丑丞丁世丌专不丈, string 下丅丙一丂丗丅丝七)
    {
        .下丅丙一丂丗丅丝七 = 下丅丙一丂丗丅丝七;
        this.丘上丐世丆丑且丞丒(且三丟七下丂专丈丈:  且三丟七下丂专丈丈, 七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂, 丒丑丞丁世丌专不丈:  丒丑丞丁世丌专不丈);
        PlaceableItemButton val_3 = this.丛不丄丁且世丁世丗.Find(match:  new System.Predicate<PlaceableItemButton>(object:  new PlacebleItemsListUI.丘丞上世丗丘丏丐东(), method:  System.Boolean PlacebleItemsListUI.丘丞上世丗丘丏丐东::丆且丒丗丈丞丈丘且(PlaceableItemButton 三丟东丕丄丄下下丑)));
        if(val_3 == 0)
        {
                return;
        }
        
        this.scrollViewHelper.ScrollTo(不七丘丘丒万七丄丒:  val_3.transform, 丌与丟丁万丝丞丄丏:  false);
    }
    internal void 东丒不七丝万丌丄三()
    {
        List.Enumerator<T> val_1 = this.丛不丄丁且世丁世丗.GetEnumerator();
        label_4:
        if(((-2066100568) & 1) == 0)
        {
            goto label_2;
        }
        
        if(0.丐丏七丌丕丗业且上() != null)
        {
            goto label_4;
        }
        
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public PlacebleItemsListUI()
    {
        this.丛不丄丁且世丁世丗 = new System.Collections.Generic.List<PlaceableItemButton>();
    }

}
