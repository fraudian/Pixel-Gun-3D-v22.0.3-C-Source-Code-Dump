using UnityEngine;
public class GadgetArmoryItem : MonoBehaviour
{
    // Fields
    public bool isReplaceOnlyHands;
    public bool isReplaceOnlyMask;
    public UnityEngine.GameObject gadgetPoint;
    public bool ignoreGadgetPointForColoring;
    public System.Collections.Generic.List<UnityEngine.GameObject> noFillPersSkinObjects;
    public UnityEngine.Transform LeftArmorHand;
    public UnityEngine.Transform RightArmorHand;
    public UnityEngine.SkinnedMeshRenderer renderArms;
    
    // Methods
    private void Awake()
    {
        this.上万世丟丙丈东下丂();
    }
    internal void 上万世丟丙丈东下丂()
    {
        if(this.renderArms != 0)
        {
                return;
        }
        
        T[] val_2 = this.GetComponentsInChildren<UnityEngine.SkinnedMeshRenderer>(includeInactive:  true);
        if(val_2 == null)
        {
                return;
        }
        
        if(val_2.Length < 1)
        {
                return;
        }
        
        do
        {
            T val_9 = val_2[0];
            if(val_9 != 0)
        {
                if((val_9.name.Equals(value:  "energy shield_mesh")) != true)
        {
                if((val_9.name.Equals(value:  "disabler_mesh")) == false)
        {
            goto label_15;
        }
        
        }
        
        }
        
        }
        while((0 + 1) < val_2.Length);
        
        return;
        label_15:
        this.renderArms = val_9;
    }
    public GadgetArmoryItem()
    {
        this.isReplaceOnlyHands = true;
    }

}
