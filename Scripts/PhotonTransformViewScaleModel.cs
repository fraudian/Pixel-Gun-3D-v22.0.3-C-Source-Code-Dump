using UnityEngine;
[Serializable]
public class PhotonTransformViewScaleModel
{
    // Fields
    public bool SynchronizeEnabled;
    public PhotonTransformViewScaleModel.七丛世且丗丗丏丑不 InterpolateOption;
    public float InterpolateMoveTowardsSpeed;
    public float InterpolateLerpSpeed;
    
    // Methods
    public PhotonTransformViewScaleModel()
    {
        this.InterpolateMoveTowardsSpeed = 1f;
    }

}
