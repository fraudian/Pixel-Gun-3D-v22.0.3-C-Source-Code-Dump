using UnityEngine;
[Serializable]
public class PhotonTransformViewRotationModel
{
    // Fields
    public bool SynchronizeEnabled;
    public PhotonTransformViewRotationModel.七丛世且丗丗丏丑不 InterpolateOption;
    public float InterpolateRotateTowardsSpeed;
    public float InterpolateLerpSpeed;
    
    // Methods
    public PhotonTransformViewRotationModel()
    {
        this.InterpolateOption = 1;
        this.InterpolateRotateTowardsSpeed = 180f;
        this.InterpolateLerpSpeed = 5f;
    }

}
