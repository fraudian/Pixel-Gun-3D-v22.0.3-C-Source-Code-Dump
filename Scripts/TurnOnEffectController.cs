using UnityEngine;
public class TurnOnEffectController : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<UnityEngine.GameObject> effect;
    private float timeRemainingInSeconds;
    private bool turnOffByClick;
    private bool turnOffByTime;
    
    // Methods
    private void OnEnable()
    {
        if(this.effect == null)
        {
            goto label_8;
        }
        
        List.Enumerator<T> val_1 = this.effect.GetEnumerator();
        label_4:
        if(((-487667704) & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().SetActive(value:  true);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_8:
        if(this.turnOffByTime == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.专丑一丒一丞丐东且());
    }
    private System.Collections.IEnumerator 专丑一丒一丞丐东且()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TurnOnEffectController.丟下丞丗丑丏东与丑();
    }
    private void OnDisable()
    {
        this.StopCoroutine(routine:  this.专丑一丒一丞丐东且());
    }
    private void Update()
    {
        var val_5;
        var val_6;
        UnityEngine.Touch[] val_1 = UnityEngine.Input.touches;
        val_5 = 0;
        val_6 = 0;
        goto label_0;
        label_4:
        var val_2 = 0 + 32;
        val_5 = 1;
        label_0:
        if(val_5 < val_1.Length)
        {
            goto label_4;
        }
        
        if(((专三三与三且一且一() != 4) ? (val_6 + 1) : (val_6)) < 1)
        {
                return;
        }
        
        if(this.turnOffByClick == false)
        {
                return;
        }
        
        this.一丌丌丏丝丘丈丆业();
    }
    private void 一丌丌丏丝丘丈丆业()
    {
        if(this.effect == null)
        {
            goto label_8;
        }
        
        List.Enumerator<T> val_1 = this.effect.GetEnumerator();
        label_4:
        if(((-487100920) & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().SetActive(value:  false);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_8:
        this.gameObject.SetActive(value:  false);
    }
    public TurnOnEffectController()
    {
        this.timeRemainingInSeconds = 3f;
    }

}
