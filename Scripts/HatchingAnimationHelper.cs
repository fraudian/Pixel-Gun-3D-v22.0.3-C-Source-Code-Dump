using UnityEngine;
public class HatchingAnimationHelper : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform cardOverridePoint;
    public UnityEngine.Transform[] cards;
    public float lerpTime;
    public float[] timers;
    private UnityEngine.GameObject parent;
    public UILabel tapToClose;
    
    // Methods
    public void OnGetPetCards()
    {
        UnityEngine.Object.Destroy(obj:  this.parent);
    }
    public void StartCardLerp(int 丞丅上丏丂且下丅与)
    {
        this.timers[(long)丞丅上丏丂且下丅与] = this.lerpTime;
    }
    private void OnEnable()
    {
        if(this.tapToClose == 0)
        {
                return;
        }
        
        this.tapToClose.gameObject.SetActive(value:  false);
    }
    public void OnCardShown()
    {
        null = null;
        EggHatchingWindowControllerV2.丕丑东丈丈世七丘不 = 2;
        if(this.tapToClose == 0)
        {
                return;
        }
        
        this.tapToClose.gameObject.SetActive(value:  true);
    }
    private void LateUpdate()
    {
        goto label_1;
        label_19:
        if(this.timers[0] > 0f)
        {
                UnityEngine.Vector3 val_1 = this.cards[0].position;
            UnityEngine.Vector3 val_2 = this.cardOverridePoint.position;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, t:  this.timers[0] / this.lerpTime);
            this.cards[0].position = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
            float val_5 = UnityEngine.Time.deltaTime;
            val_5 = this.timers[0] - val_5;
            this.timers[0] = val_5;
        }
        
        0 = 1;
        label_1:
        if(0 < this.timers.Length)
        {
            goto label_19;
        }
    
    }
    public HatchingAnimationHelper()
    {
        this.lerpTime = 0.3f;
    }

}
