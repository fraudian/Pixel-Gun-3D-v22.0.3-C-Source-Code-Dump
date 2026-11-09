using UnityEngine;
public class SupportAimSettingsContainer : ScriptableObject, 丘丐丗丐七丑丏丒丗
{
    // Fields
    private bool useSettingsContainer;
    private SupportAimSettingsContainer.SupportAimSharedSettingsContainer supportAimSharedSettingsContainer;
    
    // Properties
    public SupportAimSettingsContainer.SupportAimSharedSettingsContainer CurrentSharedContainer { get; }
    public SupportAimSettingsContainer.SupportAimSharedSettingsContainer DefaultSharedContainer { get; }
    
    // Methods
    public SupportAimSettingsContainer.SupportAimSharedSettingsContainer get_CurrentSharedContainer()
    {
        return (SupportAimSharedSettingsContainer)this.supportAimSharedSettingsContainer;
    }
    public SupportAimSettingsContainer.SupportAimSharedSettingsContainer get_DefaultSharedContainer()
    {
        return (SupportAimSharedSettingsContainer)this.supportAimSharedSettingsContainer;
    }
    public SupportAimSettingsContainer()
    {
        SupportAimSettingsContainer.SupportAimSharedSettingsContainer val_1 = null;
        .lerpTime = 1.5f;
        .RotateSpeed = 1;
        .helpHeight = ;
        .DropAutoAimTime = ;
        .velocityFactorChangeSpeed = 15f;
        .playerMult = 0.4f;
        .distanceWeight = 1f;
        val_1 = new SupportAimSettingsContainer.SupportAimSharedSettingsContainer();
        this.supportAimSharedSettingsContainer = val_1;
    }

}
