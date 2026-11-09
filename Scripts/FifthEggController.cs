using UnityEngine;
public class FifthEggController : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject eggHint;
    private UILabel eggHintTimer;
    private UnityEngine.GameObject fifthEgg;
    private UIBasicSprite fifthEggIcon;
    private UnityEngine.GameObject normalState;
    private UnityEngine.GameObject pressedState;
    private UILabel timer;
    
    // Methods
    public void SetState(bool 丆丟专丑丁丒丁上丙)
    {
        UnityEngine.GameObject val_3;
        if(this.pressedState == null)
        {
            goto label_0;
        }
        
        if(丆丟专丑丁丒丁上丙 == false)
        {
            goto label_1;
        }
        
        label_7:
        this.pressedState.SetActive(value:  true);
        this.normalState.SetActive(value:  false);
        this.timer.gameObject.SetActive(value:  false);
        val_3 = this.eggHint;
        if(val_3 != null)
        {
            goto label_11;
        }
        
        goto label_6;
        label_0:
        if(丆丟专丑丁丒丁上丙 == true)
        {
            goto label_7;
        }
        
        label_1:
        this.pressedState.SetActive(value:  false);
        this.normalState.SetActive(value:  true);
        this.eggHint.SetActive(value:  false);
        val_3 = this.timer.gameObject;
        if(val_3 != null)
        {
            goto label_11;
        }
        
        label_6:
        label_11:
        val_3.SetActive(value:  true);
    }
    public void PressFifthEgg()
    {
        this.SetState(丆丟专丑丁丒丁上丙:  true);
    }
    private void OnEnable()
    {
        this.SetState(丆丟专丑丁丒丁上丙:  true);
    }
    public void UpdateEgg()
    {
    
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
        
        this.SetState(丆丟专丑丁丒丁上丙:  false);
    }
    private System.Collections.IEnumerator 丝丂丕东专世丅丝丁()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new FifthEggController.业且丄上丐丘东七丙();
    }
    public FifthEggController()
    {
    
    }

}
