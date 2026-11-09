using UnityEngine;
internal sealed class HelicopterEngineParameters : MonoBehaviour
{
    // Fields
    public float healtInit;
    public float maxUpSpeed;
    public float maxDownSpeed;
    public float maxVerticalSpeedTime;
    public float verticalSpeedLossTime;
    public float maxRotationSpeed;
    public float maxRotationSpeedTime;
    public float rotationSpeedLossTime;
    public float maxForwardSpeed;
    public float maxBackwardSpeed;
    public float maxHorizontalSpeedTime;
    public float horizontalSpeedLossTime;
    
    // Methods
    public HelicopterEngineParameters()
    {
        this.healtInit = ;
        this.maxUpSpeed = ;
        this.maxDownSpeed = 10f;
        this.maxVerticalSpeedTime = 0.5f;
        this.verticalSpeedLossTime = ;
        this.maxRotationSpeed = ;
        this.maxRotationSpeedTime = 0.2f;
        this.rotationSpeedLossTime = 0.2f;
        this.maxForwardSpeed = ;
        this.maxBackwardSpeed = ;
        this.maxHorizontalSpeedTime = 1f;
        this.horizontalSpeedLossTime = 1f;
    }

}
