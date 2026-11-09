using UnityEngine;
[Serializable]
public class SupportAimSettingsContainer.SupportAimSharedSettingsContainer
{
    // Fields
    public float RotateSpeed;
    public float width;
    public float height;
    public float helpWidth;
    public float helpHeight;
    public float DropAutoAimTime;
    public float velocityFactorChangeSpeed;
    public float playerMult;
    internal float lerpTime;
    public bool ShowDebugRect;
    public float distanceWeight;
    
    // Methods
    public SupportAimSettingsContainer.SupportAimSharedSettingsContainer()
    {
        this.lerpTime = 1.5f;
        this.RotateSpeed = 1;
        this.helpHeight = ;
        this.DropAutoAimTime = ;
        this.velocityFactorChangeSpeed = 15f;
        this.playerMult = 0.4f;
        this.distanceWeight = 1f;
    }

}
