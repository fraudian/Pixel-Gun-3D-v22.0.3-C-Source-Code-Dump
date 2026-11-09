using UnityEngine;
public class EggHatchingWindowController : GeneralBannerWindow
{
    // Fields
    public UnityEngine.Camera petCamera;
    public UnityEngine.Transform _3dModelsParent;
    public UnityEngine.GameObject confirmButton;
    public System.Collections.Generic.List<UILabel> currentGrade;
    public System.Collections.Generic.List<UILabel> nextGrade;
    public System.Collections.Generic.List<UILabel> points;
    public System.Collections.Generic.List<UILabel> rarity;
    public System.Collections.Generic.List<UILabel> petNameUpgrade;
    public System.Collections.Generic.List<UILabel> maximumLevel;
    public UISprite oldUpgradeIndicator;
    public UISprite newUpgradeIndicator;
    public UIInput petsNameInput;
    public UISprite darkenSprite;
    private bool 丗与与丆上丛丌不丘;
    public AnimationCoroutineRunner petProfileAnimationRunner;
    public UnityEngine.GameObject btnClose;
    
    // Methods
    public void SetRenameMode()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.confirmButton, 丏业丟一东丂东丘丛:  true);
    }
    public void SetPetsNameToInput(string 东丂下丗丕一与上丄)
    {
        this.petsNameInput.value = 东丂下丗丕一与上丄;
    }
    public virtual void HandleHatchButton()
    {
    
    }
    public void SavePetsName()
    {
    
    }
    public override void HandleClose()
    {
        if(this.丗与与丆上丛丌不丘 != false)
        {
                return;
        }
        
        this.丗与与丆上丛丌不丘 = true;
    }
    public void HandleDArkBackgroundPressed()
    {
        goto typeof(EggHatchingWindowController).__il2cppRuntimeField_198;
    }
    protected override void 下丁丕丅与丛下丙专()
    {
        goto typeof(EggHatchingWindowController).__il2cppRuntimeField_168;
    }
    private void Start()
    {
        goto typeof(EggHatchingWindowController).__il2cppRuntimeField_178;
    }
    private void OnDestroy()
    {
        goto typeof(EggHatchingWindowController).__il2cppRuntimeField_188;
    }
    private void 东与丏丗东上与七丕()
    {
        if(this.petCamera == 0)
        {
                return;
        }
        
        if(this.petCamera.enabled != false)
        {
                return;
        }
        
        this.petCamera.enabled = true;
    }
    public EggHatchingWindowController()
    {
    
    }

}
