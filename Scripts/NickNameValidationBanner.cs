using UnityEngine;
internal sealed class NickNameValidationBanner : BannerWindow
{
    // Fields
    private static NickNameValidationBanner 丝业丆丁业三丈丟东;
    public static bool needShow;
    public static bool showSecondStepOnStart;
    public UnityEngine.GameObject messagePanel;
    public UnityEngine.GameObject setNamePanel;
    public UnityEngine.GameObject proposedNamePanel;
    public UnityEngine.GameObject characterError;
    public UnityEngine.GameObject tapToEditNickLabel;
    public UIGrid grid;
    public UIInput inputField;
    public UILabel proposedNameLabel;
    
    // Properties
    internal static NickNameValidationBanner 丆丕丝丒不丙且丐丗 { get; }
    internal static bool 丅业东万丌丕上丌丄 { get; }
    internal static bool 丕丆三丆丕不三业丒 { get; }
    internal static bool 丞不丗丄丞丘丛丙东 { get; }
    
    // Methods
    internal static NickNameValidationBanner 丑七不且上丗丁一世()
    {
        null = null;
        return (NickNameValidationBanner)NickNameValidationBanner.丝业丆丁业三丈丟东;
    }
    internal static bool 丈丐丞丐上丑且丕万()
    {
        null = null;
        if(NickNameValidationBanner.丝业丆丁业三丈丟东 == 0)
        {
                return false;
        }
        
        UnityEngine.GameObject val_3 = NickNameValidationBanner.丑七不且上丗丁一世().gameObject;
        if(val_3 != null)
        {
                return val_3.activeInHierarchy;
        }
        
        return val_3.activeInHierarchy;
    }
    internal static bool 丂东下不丆专丌丈丆()
    {
        var val_7;
        MainMenuController val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        val_7 = null;
        val_7 = null;
        val_8 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_8 == 0)
        {
                return (bool)0 & 1;
        }
        
        val_9 = null;
        val_9 = null;
        val_8 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 360];
        val_8 = MainMenuController.丄丞丁丈与业上丞丟.mainPanel;
        if(activeInHierarchy == false)
        {
                return (bool)0 & 1;
        }
        
        val_10 = null;
        val_10 = null;
        val_8 = MainMenuController.丄丞丁丈与业上丞丟;
        if(val_8.丂丙丈与世专上丒上() == true)
        {
                return (bool)0 & 1;
        }
        
        val_11 = null;
        val_11 = null;
        val_8 = mem[MainMenuController.丄丞丁丈与业上丞丟 + 24];
        val_8 = MainMenuController.丄丞丁丈与业上丞丟 + 24;
        if(val_8.activeInHierarchy != false)
        {
                return (bool)0 & 1;
        }
        
        val_12 = null;
        val_12 = null;
        bool val_7 = MainMenuController.丄丞丁丈与业上丞丟.IsOpeningFriends ^ 1;
        return (bool)0 & 1;
    }
    internal static bool 丁七下丌丏丄丟上三()
    {
        null = null;
        return (bool)NickNameValidationBanner.needShow;
    }
    public override void Show()
    {
        var val_3;
        this.Show();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.setNamePanel, 丏业丟一东丂东丘丛:  false);
        val_3 = null;
        val_3 = null;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.messagePanel, 丏业丟一东丂东丘丛:  (NickNameValidationBanner.showSecondStepOnStart == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.proposedNamePanel, 丏业丟一东丂东丘丛:  NickNameValidationBanner.showSecondStepOnStart);
        if(NickNameValidationBanner.showSecondStepOnStart != false)
        {
                this.proposedNameLabel.text = ProfileController.专不业业下东丆不世();
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.characterError, 丏业丟一东丂东丘丛:  false);
        NickNameValidationBanner.丄丝丂且丅丒七业丂();
    }
    internal static void 丄丝丂且丅丒七业丂()
    {
        null = null;
        NickNameValidationBanner.needShow = false;
    }
    public static void ShowNickNameValidation(bool 万丕万丑三丕丌丏丆 = False)
    {
        null = null;
        NickNameValidationBanner.needShow = true;
        NickNameValidationBanner.showSecondStepOnStart = 万丕万丑三丕丌丏丆;
    }
    protected override void OnEnable()
    {
        null = null;
        NickNameValidationBanner.丝业丆丁业三丈丟东 = this;
        this.OnEnable();
    }
    protected override void OnDisable()
    {
        this.OnDisable();
    }
    public void NextProposed()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.messagePanel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.setNamePanel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.proposedNamePanel, 丏业丟一东丂东丘丛:  true);
        this.proposedNameLabel.text = ProfileController.专不业业下东丆不世();
    }
    public void NextSetName()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.messagePanel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.proposedNamePanel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.setNamePanel, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.characterError, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tapToEditNickLabel, 丏业丟一东丂东丘丛:  true);
        this.inputField.value = this.proposedNameLabel.text;
        if(this.grid == null)
        {
            
        }
    
    }
    public void Accept()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.characterError, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tapToEditNickLabel, 丏业丟一东丂东丘丛:  false);
        if((this.inputField.value.Length >= 3) && ((NickNameValidator.instance.ValidateNickName(丕丗丘丑丛与丑业丒:  this.inputField.value)) != false))
        {
                ProfileController.丕丑丟丂丝丕丝东丒(丏丕丁三万丛丑丝下:  this.inputField.value);
            Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  134, 丙业与丙丗丝不丈东:  1);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.characterError, 丏业丟一东丂东丘丛:  true);
        this.inputField.value = ProfileController.专不业业下东丆不世();
        if(this.grid == null)
        {
            
        }
    
    }
    public void AcceptProposed()
    {
        ProfileController.丕丑丟丂丝丕丝东丒(丏丕丁三万丛丑丝下:  this.proposedNameLabel.text);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  134, 丙业与丙丗丝不丈东:  1);
    }
    public override void Hide()
    {
        UnityEngine.Object.Destroy(obj:  this.gameObject);
        this.Hide();
    }
    public NickNameValidationBanner()
    {
    
    }
    private static NickNameValidationBanner()
    {
    
    }

}
