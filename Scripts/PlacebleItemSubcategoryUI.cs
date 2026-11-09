using UnityEngine;
public sealed class PlacebleItemSubcategoryUI : PGBehaviour
{
    // Fields
    public SelectableButtonController selectableButtonController;
    private MiniPoolMonoBehaviour miniPool;
    private System.Collections.Generic.List<PlacebleItemSubcategoryButton> 丛不丄丁且世丁世丗;
    private System.Collections.Generic.Dictionary<string, PlacebleItemSubcategoryButton> 东丞丗三丘丟不丁丆;
    private string 七丕业丒下丛丂丛丟;
    private string 专丄丌且一丕万与丛;
    
    // Methods
    private void 丘上丐世丆丑且丞丒(string 且三丟七下丂专丈丈, string 七丆丒与丗丌丄且丂)
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
        this.专丄丌且一丕万与丛 = 七丆丒与丗丌丄且丂;
        List.Enumerator<T> val_4 = 丄丈业一下万且丂丕.丝且丕且丁世不东丒(且三丟七下丂专丈丈:  且三丟七下丂专丈丈, 七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂).GetEnumerator();
        label_22:
        if(((-2064867336) & 1) == 0)
        {
            goto label_16;
        }
        
        string val_5 = 0.丐丏七丌丕丗业且上();
        PlacebleItemSubcategoryButton val_6 = this.miniPool.Get<PlacebleItemSubcategoryButton>();
        val_6.丈且东丑丂且万丒丅(丒丑丞丁世丌专不丈:  val_5, 丂丗丝与丕丁丗丅丛:  0);
        this.丛不丄丁且世丁世丗.Add(item:  val_6);
        this.东丞丗三丘丟不丁丆.set_Item(key:  val_5, value:  val_6);
        goto label_22;
        label_16:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 下与丞三丅丛丄七丕(string 且三丟七下丂专丈丈, string 七丆丒与丗丌丄且丂, string 丒丑丞丁世丌专不丈)
    {
        string val_16;
        var val_17;
        SelectableButton val_18;
        val_16 = 且三丟七下丂专丈丈;
        val_17 = this;
        .丒丑丞丁世丌专不丈 = 丒丑丞丁世丌专不丈;
        val_18 = this.selectableButtonController.selectedButton;
        if(val_18 != 0)
        {
                val_18 = this.selectableButtonController.selectedButton;
            if((System.String.op_Equality(a:  val_18.name, b:  (PlacebleItemSubcategoryUI.丒丑万一丁丕东一丗)[1152921536902036944].丒丑丞丁世丌专不丈)) == true)
        {
                return;
        }
        
        }
        
        this.丘上丐世丆丑且丞丒(且三丟七下丂专丈丈:  val_16, 七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂);
        System.Predicate<PlacebleItemSubcategoryButton> val_5 = null;
        val_16 = val_5;
        val_5 = new System.Predicate<PlacebleItemSubcategoryButton>(object:  new PlacebleItemSubcategoryUI.丒丑万一丁丕东一丗(), method:  System.Boolean PlacebleItemSubcategoryUI.丒丑万一丁丕东一丗::丆且丒丗丈丞丈丘且(PlacebleItemSubcategoryButton 三丟东丕丄丄下下丑));
        if((this.丛不丄丁且世丁世丗.Find(match:  val_5)) == 0)
        {
                return;
        }
        
        val_17 = ???;
        val_16 = ???;
        val_18 = ???;
        goto typeof(SelectableButtonController).__il2cppRuntimeField_168;
    }
    public PlacebleItemSubcategoryUI()
    {
        this.丛不丄丁且世丁世丗 = new System.Collections.Generic.List<PlacebleItemSubcategoryButton>();
        this.东丞丗三丘丟不丁丆 = new System.Collections.Generic.Dictionary<System.String, PlacebleItemSubcategoryButton>();
    }

}
