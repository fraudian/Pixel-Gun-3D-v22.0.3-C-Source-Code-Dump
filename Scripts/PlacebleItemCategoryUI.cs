using UnityEngine;
public sealed class PlacebleItemCategoryUI : PGBehaviour
{
    // Fields
    public SelectableButtonController selectableButtonController;
    private MiniPoolMonoBehaviour miniPool;
    private System.Collections.Generic.List<PlacebleItemCategoryButton> 丛不丄丁且世丁世丗;
    private System.Collections.Generic.Dictionary<string, PlacebleItemCategoryButton> 东丞丗三丘丟不丁丆;
    private string 七丕业丒下丛丂丛丟;
    
    // Methods
    private void 丘上丐世丆丑且丞丒(string 且三丟七下丂专丈丈)
    {
        var val_7;
        var val_8;
        val_7 = this;
        val_8 = 0;
        goto label_1;
        label_5:
        this.miniPool.Return(万且万且丑丗且丌丆:  this.丛不丄丁且世丁世丗.Item[0]);
        val_8 = 1;
        label_1:
        if(val_8 < this.丛不丄丁且世丁世丗.Count)
        {
            goto label_5;
        }
        
        this.丛不丄丁且世丁世丗.Clear();
        this.东丞丗三丘丟不丁丆.Clear();
        this.selectableButtonController.selectedButton = 0;
        this.selectableButtonController.allButtons.Clear();
        this.selectableButtonController.widgetLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        this.七丕业丒下丛丂丛丟 = 且三丟七下丂专丈丈;
        List.Enumerator<T> val_4 = 丄丈业一下万且丂丕.丈世世三万丝一丕一(且三丟七下丂专丈丈:  且三丟七下丂专丈丈).GetEnumerator();
        label_22:
        if(((-2067426312) & 1) == 0)
        {
            goto label_16;
        }
        
        string val_5 = 0.丐丏七丌丕丗业且上();
        PlacebleItemCategoryButton val_6 = this.miniPool.Get<PlacebleItemCategoryButton>();
        val_6.丈且东丑丂且万丒丅(七丆丒与丗丌丄且丂:  val_5, 丂丗丝与丕丁丗丅丛:  0);
        this.丛不丄丁且世丁世丗.Add(item:  val_6);
        this.东丞丗三丘丟不丁丆.set_Item(key:  val_5, value:  val_6);
        goto label_22;
        label_16:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 下与丞三丅丛丄七丕(string 且三丟七下丂专丈丈, string 七丆丒与丗丌丄且丂)
    {
        var val_15;
        object val_16;
        val_15 = this;
        PlacebleItemCategoryUI.丘丞上世丗丘丏丐东 val_1 = null;
        val_16 = val_1;
        val_1 = new PlacebleItemCategoryUI.丘丞上世丗丘丏丐东();
        .七丆丒与丗丌丄且丂 = 七丆丒与丗丌丄且丂;
        if(this.selectableButtonController.selectedButton != 0)
        {
                if((System.String.op_Equality(a:  this.selectableButtonController.selectedButton.name, b:  (PlacebleItemCategoryUI.丘丞上世丗丘丏丐东)[1152921536899465680].七丆丒与丗丌丄且丂)) == true)
        {
                return;
        }
        
        }
        
        this.丘上丐世丆丑且丞丒(且三丟七下丂专丈丈:  且三丟七下丂专丈丈);
        if((this.丛不丄丁且世丁世丗.Find(match:  new System.Predicate<PlacebleItemCategoryButton>(object:  val_1, method:  System.Boolean PlacebleItemCategoryUI.丘丞上世丗丘丏丐东::丆且丒丗丈丞丈丘且(PlacebleItemCategoryButton 三丟东丕丄丄下下丑)))) == 0)
        {
                return;
        }
        
        val_15 = ???;
        val_16 = ???;
        goto typeof(SelectableButtonController).__il2cppRuntimeField_168;
    }
    public PlacebleItemCategoryUI()
    {
        this.丛不丄丁且世丁世丗 = new System.Collections.Generic.List<PlacebleItemCategoryButton>();
        this.东丞丗三丘丟不丁丆 = new System.Collections.Generic.Dictionary<System.String, PlacebleItemCategoryButton>();
    }

}
