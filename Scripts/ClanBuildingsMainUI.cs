using UnityEngine;
public class ClanBuildingsMainUI : BannerWindowWithBack, 丑且丆万丏丝丘丙丟
{
    // Fields
    private ClanBuildingView buildingViewEample;
    private UnityEngine.GameObject comingSoonEample;
    private UnityEngine.GameObject comingSoonNextEample;
    private WidgetLayout buildingsLayout;
    
    // Properties
    public static bool 不丁丄丌丒上丅丂丟 { get; }
    
    // Methods
    public static bool get_InterfaceEnabled()
    {
        BannerWindowController val_11 = BannerWindowController.与丅与丒丅专丙丐丗();
        if(val_11 == 0)
        {
                return false;
        }
        
        val_11 = BannerWindowController.与丅与丒丅专丙丐丗().CurrentBanner;
        if(val_11 == 0)
        {
                return false;
        }
        
        val_11 = BannerWindowController.与丅与丒丅专丙丐丗().CurrentBanner;
        if(val_11.type != 55)
        {
                return false;
        }
        
        BannerWindow val_10 = BannerWindowController.与丅与丒丅专丙丐丗().CurrentBanner;
        if(val_10 != null)
        {
                return val_10.IsShow;
        }
        
        return val_10.IsShow;
    }
    public override void Show()
    {
        this.Show();
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
        this.ShowClanBuildingsMainUI();
        丙万三丈丆丄丑东且.不下丑丆丐且丆下与();
    }
    public override void Back()
    {
        this.Back();
        this.HideSelf();
        PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
    }
    public void ShowClanBuildingsMainUI()
    {
        var val_5;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.buildingViewEample, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.comingSoonEample, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.comingSoonNextEample, 丏业丟一东丂东丘丛:  false);
        this.buildingsLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  true);
        List.Enumerator<T> val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一上丄与丌七业丈不<PGCompany.丏丌丝丕丐七丈且丒>(丁丅丈丌丟世丗丗丟:  80).GetEnumerator();
        label_13:
        if((1896393504 & 1) == 0)
        {
            goto label_6;
        }
        
        ClanBuildingView val_7 = UnityEngine.Object.Instantiate<ClanBuildingView>(original:  this.buildingViewEample);
        this.buildingsLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_7);
        val_7.丈且东丑丂且万丒丅(上丟专三丙丅丆丛且:  val_5.丐丏七丌丕丗业且上());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_7, 丏业丟一东丂东丘丛:  true);
        goto label_13;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.GameObject val_8 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.comingSoonEample);
        this.buildingsLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_8);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
        UnityEngine.GameObject val_9 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.comingSoonNextEample);
        this.buildingsLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_9);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_9, 丏业丟一东丂东丘丛:  true);
        this.buildingsLayout.Reposition();
    }
    public void TurnOn()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
            goto typeof(ClanBuildingsMainUI).__il2cppRuntimeField_218;
        }
    
    }
    public void TurnOff()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public bool IsVisibleLobbyMenu()
    {
        return false;
    }
    public bool IsEnabledLobbyCamera()
    {
        return false;
    }
    public float GetDelayTurnOff()
    {
        return 0f;
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        new System.Action() = new System.Action(object:  this, method:  typeof(ClanBuildingsMainUI).__il2cppRuntimeField_220);
        ClansController.万丟专丗丅丘丗丏丄(丙业与丙丗丝不丈东:  new System.Action());
    }
    protected override void OnDisable()
    {
        new System.Action() = new System.Action(object:  this, method:  typeof(ClanBuildingsMainUI).__il2cppRuntimeField_220);
        ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action());
        this.OnDisable();
    }
    protected override void OnDestroy()
    {
        new System.Action() = new System.Action(object:  this, method:  typeof(ClanBuildingsMainUI).__il2cppRuntimeField_220);
        ClansController.丗丅与世丏丈世上丄(丙业与丙丗丝不丈东:  new System.Action());
        this.OnDestroy();
    }
    public ClanBuildingsMainUI()
    {
    
    }

}
