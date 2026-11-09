using UnityEngine;
internal class BearMechBody : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioClip mechBearActivSound;
    public UnityEngine.GameObject mechBearBody;
    public UnityEngine.Animation mechBearBodyAnimation;
    public UnityEngine.SkinnedMeshRenderer mechBearBodyRenderer;
    public UnityEngine.SkinnedMeshRenderer mechBearHandRenderer;
    public UnityEngine.GameObject mechBearHands;
    public SynhRotationWithGameObject mechBearSyncRot;
    public UnityEngine.Transform mechHeadTransform;
    public UnityEngine.Transform bearHeadColliderPivot;
    public UnityEngine.Animation wingsBearAnimation;
    public UnityEngine.GameObject wingsPointBear;
    
    // Methods
    public BearMechBody()
    {
    
    }

}
