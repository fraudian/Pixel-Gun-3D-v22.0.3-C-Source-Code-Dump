using UnityEngine;
public class AlmanachCategorySelectorUI : SelectableButtonController
{
    // Fields
    private AlmanachMainUI almanachMainUI;
    
    // Properties
    private AlmanachCategoryButton 丅三丙上专万丗丒丙 { get; }
    
    // Methods
    private AlmanachCategoryButton 丝丄丌丟丂丏东丞丕()
    {
        if(137117696 == 0)
        {
                return (AlmanachCategoryButton);
        }
        
        0 = 0;
        return (AlmanachCategoryButton);
    }
    public override bool SelectButton(SelectableButton 丕丐不丑三上万丝东)
    {
        var val_4;
        if((this.SelectButton(丕丐不丑三上万丝东:  丕丐不丑三上万丝东)) != false)
        {
                AlmanachCategoryButton val_2 = this.丝丄丌丟丂丏东丞丕();
            AlmanachCategoryButton val_3 = this.丝丄丌丟丂丏东丞丕();
            this.almanachMainUI.AlmanachCategorySelected(七丆丒与丗丌丄且丂:  val_2.category, 丙万丘丗丅万丐一世:  val_3.sort);
            val_4 = 1;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    public void SelectButton(AlmanachMainUI.丈丘七丞专丐不且世 七丆丒与丗丌丄且丂, AlmanachMainUI.丘丒丕专丌丅丆丗丄 丙万丘丗丅万丐一世)
    {
        var val_4;
        var val_5;
        val_4 = 丙万丘丗丅万丐一世;
        List.Enumerator<T> val_1 = GetEnumerator();
        val_5 = 0;
        goto label_7;
        label_9:
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(0 == 七丆丒与丗丌丄且丂)
        {
                var val_3 = (0 == val_4) ? 0 : (val_5);
        }
        
        label_7:
        if(((-1757234760) & 1) != 0)
        {
            goto label_9;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public AlmanachCategorySelectorUI()
    {
    
    }

}
