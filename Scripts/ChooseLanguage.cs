using UnityEngine;
public class ChooseLanguage : MonoBehaviour
{
    // Fields
    public UIButton[] languageButtons;
    public UnityEngine.GameObject[] languageSelectors;
    private UIButton 丝不七丁业丘丟丝下;
    private int 丈不丒丝丛丞东丑丆;
    
    // Methods
    private void 丛世丁上且丕丄丝世()
    {
        UIButton[] val_3;
        UnityEngine.GameObject[] val_4;
        int val_1 = 丟丏下丂七三下丗丕.丝七且丈万不世东且();
        if(val_1 == 1)
        {
                return;
        }
        
        val_3 = this.languageButtons;
        if(val_1 >= this.languageButtons.Length)
        {
                return;
        }
        
        if(this.丝不七丁业丘丟丝下 != 0)
        {
                this.丝不七丁业丘丟丝下.ResetDefaultColor();
        }
        
        val_4 = this.languageSelectors;
        if((val_4 == null) || (val_1 >= this.languageSelectors.Length))
        {
            goto label_11;
        }
        
        if((this.丈不丒丝丛丞东丑丆 & 2147483648) != 0)
        {
            goto label_12;
        }
        
        val_4[this.丈不丒丝丛丞东丑丆].SetActive(value:  false);
        val_4 = this.languageSelectors;
        this.丈不丒丝丛丞东丑丆 = val_1;
        if(val_4 != null)
        {
            goto label_16;
        }
        
        goto label_16;
        label_12:
        this.丈不丒丝丛丞东丑丆 = val_1;
        label_16:
        val_4[(long)val_1].SetActive(value:  true);
        label_11:
        val_3 = this.languageButtons;
        this.丝不七丁业丘丟丝下 = val_3[(long)val_1];
    }
    private void Start()
    {
        null = null;
        if((System.String.op_Inequality(a:  丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丑丑丛丄且丛丈下三), b:  "USA")) != false)
        {
                this.languageButtons[0].normalSprite = "flag_brit";
        }
        
        this.丛世丁上且丕丄丝世();
    }
    private void 不丟丝专业东万丕下(string 丟丟世万丟丛丌丕业)
    {
        ButtonClickSound.丁业上丏不丕三丗不();
        丟丏下丂七三下丗丕.下且丘丒丗丑不丕丌(丙业与丙丗丝不丈东:  丟丟世万丟丛丌丕业);
        this.丛世丁上且丕丄丝世();
    }
    public void SetRussianLanguage()
    {
        this.不丟丝专业东万丕下(丟丟世万丟丛丌丕业:  "Russian");
    }
    public void SetEnglishLanguage()
    {
        this.不丟丝专业东万丕下(丟丟世万丟丛丌丕业:  "English");
    }
    public void SetFrancianLanguage()
    {
        this.不丟丝专业东万丕下(丟丟世万丟丛丌丕业:  "French");
    }
    public void SetDeutschLanguage()
    {
        this.不丟丝专业东万丕下(丟丟世万丟丛丌丕业:  "German");
    }
    public void SetJapanLanguage()
    {
        this.不丟丝专业东万丕下(丟丟世万丟丛丌丕业:  "Japanese");
    }
    public void SetEspanolaLanguage()
    {
        this.不丟丝专业东万丕下(丟丟世万丟丛丌丕业:  "Spanish");
    }
    public void SetChinseLanguage()
    {
        this.不丟丝专业东万丕下(丟丟世万丟丛丌丕业:  "Chinese (Chinese)");
    }
    public void SetChineseTraditionalLanguage()
    {
        this.不丟丝专业东万丕下(丟丟世万丟丛丌丕业:  "ChineseTraditional");
    }
    public void SetKoreanLanguage()
    {
        this.不丟丝专业东万丕下(丟丟世万丟丛丌丕业:  "Korean");
    }
    public void SetBrazilLanguage()
    {
        this.不丟丝专业东万丕下(丟丟世万丟丛丌丕业:  "Portuguese (Brazil)");
    }
    public ChooseLanguage()
    {
        this.丈不丒丝丛丞东丑丆 = 0;
    }

}
