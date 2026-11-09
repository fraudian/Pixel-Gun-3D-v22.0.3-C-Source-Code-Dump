using UnityEngine;
public class NickNameValidator : MonoBehaviour
{
    // Fields
    public static NickNameValidator instance;
    public UILabel label;
    private bool 业丛万丁丈丛丕业丒;
    
    // Methods
    public void Awake()
    {
        if(NickNameValidator.instance != 0)
        {
                return;
        }
        
        NickNameValidator.instance = this;
    }
    private void OnEnable()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.label, 丏业丟一东丂东丘丛:  false);
        this.业丛万丁丈丛丕业丒 = false;
    }
    public bool ValidateNickName(string 丕丗丘丑丛与丑业丒)
    {
        UILabel val_16;
        var val_17;
        val_16 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.label, 丏业丟一东丂东丘丛:  true);
        this.label.text = 丕丗丘丑丛与丑业丒;
        this.业丛万丁丈丛丕业丒 = true;
        if(this.label.text.Length < 3)
        {
            goto label_6;
        }
        
        UnityEngine.Vector2 val_3 = this.label.printedSize;
        if(val_3.x >= 30f)
        {
            goto label_8;
        }
        
        label_6:
        if(this.label.text.Length <= 2)
        {
                UnityEngine.Vector2 val_6 = this.label.printedSize;
            if(val_6.x >= 30f)
        {
                PGCompany.Analytics.一业丗丆世世上丁且.丐丆一不万丑业丝不(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丂丕与丁丒丕丟丞:  1);
        }
        
        }
        
        if(this.label.text.Length >= 3)
        {
                UnityEngine.Vector2 val_10 = this.label.printedSize;
            if(val_10.x < 0)
        {
                PGCompany.Analytics.一业丗丆世世上丁且.丐丆一不万丑业丝不(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丁丂丕与丁丒丕丟丞:  2);
        }
        
        }
        
        if(this.label.text.Length <= 2)
        {
                val_16 = this.label;
            UnityEngine.Vector2 val_14 = val_16.printedSize;
            if(val_14.x < 0)
        {
                val_16 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
            PGCompany.Analytics.一业丗丆世世上丁且.丐丆一不万丑业丝不(丆丛丑世下一丐且丕:  val_16, 丁丂丕与丁丒丕丟丞:  3);
        }
        
        }
        
        val_17 = 0;
        return (bool)val_17;
        label_8:
        val_17 = 1;
        return (bool)val_17;
    }
    public bool ValidateNickNameNoAnalytics(string 丕丗丘丑丛与丑业丒)
    {
        UILabel val_4;
        var val_5;
        val_4 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.label, 丏业丟一东丂东丘丛:  true);
        this.label.text = 丕丗丘丑丛与丑业丒;
        this.业丛万丁丈丛丕业丒 = true;
        if(this.label.text.Length < 3)
        {
            goto label_6;
        }
        
        val_4 = this.label;
        UnityEngine.Vector2 val_3 = val_4.printedSize;
        if(val_3.x >= 30f)
        {
            goto label_8;
        }
        
        label_6:
        val_5 = 0;
        return (bool)val_5;
        label_8:
        val_5 = 1;
        return (bool)val_5;
    }
    private void LateUpdate()
    {
        if(this.业丛万丁丈丛丕业丒 == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.label, 丏业丟一东丂东丘丛:  false);
        this.业丛万丁丈丛丕业丒 = false;
    }
    public NickNameValidator()
    {
    
    }

}
