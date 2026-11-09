using UnityEngine;
[Serializable]
public class HintController.HintItem
{
    // Fields
    public string name;
    public UnityEngine.GameObject target;
    public string hintText;
    public UnityEngine.Vector3 relativeHintPosition;
    public UnityEngine.Vector3 relativeLabelPosition;
    public HintController.丗丏丑丝丞不丟丟丅 showReason;
    public HintController.丆丗丝丘三丒不丑丌 hideReason;
    public UIButton[] buttonsToBlock;
    public UnityEngine.GameObject[] objectsToHide;
    public bool[] buttonsState;
    public bool[] objActiveState;
    public UIButton targetButton;
    public UISprite targetSprite;
    public UISprite[] targetSprites;
    public float timeout;
    public bool indicateTarget;
    public bool manualRotateArrow;
    public bool scaleTween;
    public bool showLabelByCode;
    public UnityEngine.Vector3 manualArrowRotation;
    public string indicatedSpriteName;
    public bool manualLabelPivot;
    public UIWidget.七丐与七丌不丂丞且 labelPivot;
    public string defaultSpriteName;
    public bool enableColliders;
    public UnityEngine.GameObject collidersObj;
    public TrainingController.丂丈丂丛丝丗业丒丈 trainingStage;
    
    // Methods
    public HintController.HintItem()
    {
    
    }

}
