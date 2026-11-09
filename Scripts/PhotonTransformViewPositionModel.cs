using UnityEngine;
[Serializable]
public class PhotonTransformViewPositionModel
{
    // Fields
    public bool SynchronizeEnabled;
    public bool TeleportEnabled;
    public float TeleportIfDistanceGreaterThan;
    public PhotonTransformViewPositionModel.七丛世且丗丗丏丑不 InterpolateOption;
    public float InterpolateMoveTowardsSpeed;
    public float InterpolateLerpSpeed;
    public float InterpolateMoveTowardsAcceleration;
    public float InterpolateMoveTowardsDeceleration;
    public UnityEngine.AnimationCurve InterpolateSpeedCurve;
    public PhotonTransformViewPositionModel.丕业丘丝丗丝上丒丅 ExtrapolateOption;
    public float ExtrapolateSpeed;
    public bool ExtrapolateIncludingRoundTripTime;
    public int ExtrapolateNumberOfStoredPositions;
    public bool DrawErrorGizmo;
    
    // Methods
    public PhotonTransformViewPositionModel()
    {
        this.TeleportEnabled = true;
        this.TeleportIfDistanceGreaterThan = 3f;
        this.InterpolateOption = 2;
        this.InterpolateMoveTowardsSpeed = ;
        this.InterpolateLerpSpeed = ;
        this.InterpolateMoveTowardsAcceleration = 2f;
        this.InterpolateMoveTowardsDeceleration = 2f;
        UnityEngine.Keyframe[] val_1 = new UnityEngine.Keyframe[4];
        val_1[0] = 0;
        val_1[0] = 0;
        val_1[1] = 0;
        val_1[1] = 0;
        val_1[2] = 0;
        val_1[2] = 0;
        val_1[3] = 0;
        val_1[3] = 0;
        this.InterpolateSpeedCurve = new UnityEngine.AnimationCurve(keys:  val_1);
        this.ExtrapolateSpeed = 1f;
        this.ExtrapolateIncludingRoundTripTime = true;
        this.ExtrapolateNumberOfStoredPositions = true;
        this.DrawErrorGizmo = true;
    }

}
