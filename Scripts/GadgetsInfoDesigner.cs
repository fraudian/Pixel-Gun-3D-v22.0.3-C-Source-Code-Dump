using UnityEngine;
public class GadgetsInfoDesigner : MonoBehaviour
{
    // Fields
    public 丅世一丈七丆业丝丘 killStreakType;
    public System.Collections.Generic.List<一丁丒与丁丂丈七丆> parameters;
    public System.Collections.Generic.List<WeaponSounds.丈不三丛七丑丈丑丆> effects;
    public string Lkey;
    public GadgetCategory category;
    public int tier_FROM_1;
    public GadgetsInfoDesigner previousUpgarde;
    public GadgetsInfoDesigner nextUpgrade;
    public string DescriptionLkey;
    public float Duration;
    public float Cooldown;
    public float ragdollImpulse;
    public int quantityForBR;
    public int maxQuantityBR;
    public int levelGadgetInBR;
    
    // Methods
    public GadgetsInfoDesigner()
    {
        this.killStreakType = 95;
        this.Duration = 30f;
        this.Cooldown = 5f;
        this.ragdollImpulse = 1f;
        this.quantityForBR = 5;
        this.maxQuantityBR = 5;
        this.levelGadgetInBR = 65;
    }

}
