using UnityEngine;
public class EditorShopItem : MonoBehaviour
{
    // Fields
    public UILabel itemName;
    public UIToggle topCheckbox;
    public UIToggle newCheckbox;
    public UIInput discountInput;
    private string <丕专丗七丒东业世丛>k__BackingField;
    private 丅丒丌且三丅丄丆丟 不丗且下丌东东丙丄;
    
    // Properties
    public string 丟丈一下东业一丝丆 { get; set; }
    
    // Methods
    private void 丝丌丝丟业丛专世丑(string 丙业与丙丗丝不丈东)
    {
        this.<丕专丗七丒东业世丛>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public string get_prefabName()
    {
        return (string)this.<丕专丗七丒东业世丛>k__BackingField;
    }
    public void SetData(丅丒丌且三丅丄丆丟 一丐丗丁丞丆丅丟丄)
    {
        string val_14;
        UILabel val_15;
        this.不丗且下丌东东丙丄 = 一丐丗丁丞丆丅丟丄;
        System.Text.StringBuilder val_1 = new System.Text.StringBuilder();
        System.Text.StringBuilder val_4 = val_1.AppendLine(value:  System.String.Format(format:  "Name: {0}", arg0:  丟丏下丂七三下丗丕.上丞丞丑丙丒一丗丅(丝丐丟三业丟丏万且:  一丐丗丁丞丆丅丟丄.丘业丗丆下不一与东)));
        if((System.String.IsNullOrEmpty(value:  一丐丗丁丞丆丅丟丄.丟丈一下东业一丝丆)) != true)
        {
                this.<丕专丗七丒东业世丛>k__BackingField = 一丐丗丁丞丆丅丟丄.丟丈一下东业一丝丆;
            System.Text.StringBuilder val_7 = val_1.AppendLine(value:  System.String.Format(format:  "Prefab: {0}", arg0:  一丐丗丁丞丆丅丟丄.丟丈一下东业一丝丆));
        }
        
        string val_8 = System.String.Format(format:  "Tag: {0}", arg0:  一丐丗丁丞丆丅丟丄.丆万一不丌且东丐丐);
        if(val_1 != null)
        {
                val_14 = val_8;
            System.Text.StringBuilder val_9 = val_1.Append(value:  val_14);
            val_15 = this.itemName;
        }
        else
        {
                val_14 = val_8;
            System.Text.StringBuilder val_10 = val_1.Append(value:  val_14);
            val_15 = this.itemName;
        }
        
        val_15.text = val_1;
        this.topCheckbox.value = (一丐丗丁丞丆丅丟丄.万世丆丏丟丑不丄丝 == true) ? 1 : 0;
        this.newCheckbox.value = (一丐丗丁丞丆丅丟丄.且丑丛丏丌世丆七丌 == true) ? 1 : 0;
        this.discountInput.label.text = 一丐丗丁丞丆丅丟丄.三丒万万丗世三丆丄.ToString();
    }
    public void SetTopState()
    {
        this.不丗且下丌东东丙丄.万世丆丏丟丑不丄丝 = this.topCheckbox.value;
    }
    public void SetNewState()
    {
        this.不丗且下丌东东丙丄.且丑丛丏丌世丆七丌 = this.newCheckbox.value;
    }
    public void SetDiscount()
    {
        bool val_3 = System.Int32.TryParse(s:  this.discountInput.label.text, result: out  this.不丗且下丌东东丙丄.三丒万万丗世三丆丄);
    }
    public EditorShopItem()
    {
    
    }

}
