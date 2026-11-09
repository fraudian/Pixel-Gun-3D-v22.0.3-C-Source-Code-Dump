using UnityEngine;
public class BuyHeavyWeaponBannerWindow : BannerWindow
{
    // Fields
    private Rilisoft.ButtonHandler cancelButton;
    private Rilisoft.ButtonHandler okButton;
    private static bool <专上下丁丈业三一下>k__BackingField;
    
    // Properties
    internal static bool 丅丄且丐东且与丏丞 { get; set; }
    
    // Methods
    internal static bool 丙丂丟丂丄丌丞丘丐()
    {
        return (bool)BuyHeavyWeaponBannerWindow.<专上下丁丈业三一下>k__BackingField;
    }
    private static void 丛一三丄丙丈世丐专(bool 丙业与丙丗丝不丈东)
    {
        BuyHeavyWeaponBannerWindow.<专上下丁丈业三一下>k__BackingField = 丙业与丙丗丝不丈东;
    }
    protected override void Awake()
    {
        this.Awake();
        this.cancelButton.noSound = false;
        this.okButton.noSound = false;
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        this.cancelButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void BuyHeavyWeaponBannerWindow::丑丂丝丙丛七丛丛三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.okButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void BuyHeavyWeaponBannerWindow::丝三丄不与丁且丏且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        BuyHeavyWeaponBannerWindow.<专上下丁丈业三一下>k__BackingField = false;
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        this.cancelButton.ClearEvents();
        this.okButton.ClearEvents();
        BuyHeavyWeaponBannerWindow.<专上下丁丈业三一下>k__BackingField = false;
    }
    private void 丑丂丝丙丛七丛丛三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.万万丄丌与丐丘东三(世丌丒丌上丗丛丈丒:  28);
    }
    private void 丝三丄不与丁且丏且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.万万丄丌与丐丘东三(世丌丒丌上丗丛丈丒:  28);
        this.丗专专丏业丈下丐下();
    }
    internal static void 七不丅丄丝不下不且()
    {
        BuyHeavyWeaponBannerWindow.<专上下丁丈业三一下>k__BackingField = true;
        BannerWindowController.与丅与丒丅专丙丐丗().ForceShowBanner(丌丅丕一丛丛丄一万:  28, 丙下丙丈上三丁丅丒:  0, 丌专丟丘一不七丅东:  new PGCompany.丆下丐丁丏世丈上丟() {丙丙专丝专上丅丛丏 = false, 丏丛万丈且丂上丞丐 = false, 丛与丏丕东世丈三业 = false, 丏东且丂丂专一丆丁 = new System.Nullable<System.Single>() {HasValue = false}});
    }
    private void 丗专专丏业丈下丐下()
    {
        var val_5;
        var val_6;
        var val_7;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        if((MainMenuController.丆万丒丆且世丙丒上(丈丈不丒丗与丝不丗:  false)) == true)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丝丞与丄丆业丛丏专(丗丛不丁丑专专丂且:  false);
        val_6 = null;
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 == null)
        {
                val_6 = null;
        }
        
        ShopNGUIController.丏丙丅丕一丑丕丑丑.CategoryToChoose = 5;
        val_7 = null;
        val_7 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丐丟丆世三七丏丐下(与丝丕与丙不与丗丆:  new 丙且上东下丏丏丟下(丞丅上丏丂且下丅与:  与世丁丙且丑下丌不.丗丐丒上专丅丐丆丈, 七丆丒与丗丌丄且丂:  5));
        ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  true, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丏丐世且丑丅丘丅丟 = new System.Action(object:  this, method:  System.Void BuyHeavyWeaponBannerWindow::丞丈丏丈世丛丒丛丞());
    }
    private void 丞丈丏丈世丛丒丛丞()
    {
        var val_3;
        var val_5;
        var val_6;
        ShopNGUIController.世丗七丙丙业下丆与(丝三丄专丗丞丄丄丌:  false, 丑丕三丅丗世且七丆:  0, 丌丂丁七丏不丂丁上:  true);
        val_3 = null;
        val_3 = null;
        if((BuyHeavyWeaponBannerWindow.<>c.<>9__13_0) == null)
        {
            goto label_5;
        }
        
        label_18:
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丏丐世且丑丅丘丅丟 = BuyHeavyWeaponBannerWindow.<>c.<>9__13_0;
        val_5 = null;
        val_5 = null;
        if(ExperienceController.sharedController == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        return;
        label_5:
        BuyHeavyWeaponBannerWindow.<>c.<>9__13_0 = new System.Action(object:  BuyHeavyWeaponBannerWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BuyHeavyWeaponBannerWindow.<>c::丆万丈丕与丏丌专丄());
        if(ShopNGUIController.丏丙丅丕一丑丕丑丑 != null)
        {
            goto label_18;
        }
        
        goto label_18;
    }
    public BuyHeavyWeaponBannerWindow()
    {
    
    }

}
