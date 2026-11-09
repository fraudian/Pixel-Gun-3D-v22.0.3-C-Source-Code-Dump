using UnityEngine;
public class LanguageSelection : MonoBehaviour
{
    // Fields
    private UIPopupList 丟丂与东业专三丕丏;
    
    // Methods
    private void Awake()
    {
        this.丟丂与东业专三丕丏 = this.GetComponent<UIPopupList>();
        this.Refresh();
    }
    private void Start()
    {
        var val_3;
        丒万业丛丏东专世丟 val_5;
        val_3 = null;
        val_3 = null;
        val_5 = LanguageSelection.<>c.<>9__2_0;
        if(val_5 == null)
        {
                EventDelegate.丒万业丛丏东专世丟 val_1 = null;
            val_5 = val_1;
            val_1 = new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  LanguageSelection.<>c.__il2cppRuntimeField_static_fields, 丛丌丙世专世东丕下:  System.Void LanguageSelection.<>c::丗丟丒丈丐万丟上丂());
            LanguageSelection.<>c.<>9__2_0 = val_5;
        }
        
        EventDelegate val_2 = EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  this.丟丂与东业专三丕丏.onChange, 业丏丈世世世丞丒世:  val_1);
    }
    public void Refresh()
    {
        var val_16;
        var val_17;
        UIPopupList val_18;
        val_16 = this;
        val_17 = 0;
        if(this.丟丂与东业专三丕丏 == 0)
        {
                return;
        }
        
        if(丛丝丝丈丝丞丒业丝.丛丛丁丗丁专丈丟丒() == null)
        {
                return;
        }
        
        System.String[] val_3 = 丛丝丝丈丝丞丒业丝.丛丛丁丗丁专丈丟丒();
        val_18 = this.丟丂与东业专三丕丏;
        if(val_3.Length >= 1)
        {
                var val_17 = 0;
            do
        {
            val_17 = public System.Void System.Collections.Generic.List<System.String>::Add(System.String item);
            this.丟丂与东业专三丕丏.items.Add(item:  丛丝丝丈丝丞丒业丝.丛丛丁丗丁专丈丟丒()[val_17]);
            val_18 = this.丟丂与东业专三丕丏;
            val_17 = val_17 + 1;
        }
        while((val_3.Length & 4294967295) != val_17);
        
        }
        
        string val_6 = 丛丝丝丈丝丞丒业丝.丂丕业丄丞三丅丐丒();
        val_16 = ???;
        goto typeof(UIPopupList).__il2cppRuntimeField_178;
    }
    public LanguageSelection()
    {
    
    }

}
