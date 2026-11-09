using UnityEngine;
public class NewLobbyLevelAnimator : MonoBehaviour
{
    // Fields
    public float buttonAlphaTime;
    public float timeBetweenShineAndTip;
    public float timeTipShown;
    public System.Collections.Generic.List<UnityEngine.GameObject> buttons;
    public System.Collections.Generic.List<UnityEngine.GameObject> tips;
    public System.Collections.Generic.List<UnityEngine.GameObject> shines;
    public System.Collections.Generic.List<NewLobbyLevelAnimator.三丒丞丅且东丙东东> conditions;
    private const int 丈业专丝丁万丝丈丛 = 25;
    private bool 丛丕丁且丛且上下丂;
    
    // Methods
    private void Awake()
    {
        var val_3;
        var val_10;
        var val_11;
        List.Enumerator<T> val_1 = this.buttons.GetEnumerator();
        label_5:
        if((678065968 & 1) == 0)
        {
            goto label_2;
        }
        
        val_3.丐丏七丌丕丗业且上().GetComponent<UISprite>().alpha = 0f;
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_6 = this.shines.GetEnumerator();
        label_14:
        if((678065968 & 1) == 0)
        {
            goto label_12;
        }
        
        val_3.丐丏七丌丕丗业且上().SetActive(value:  false);
        goto label_14;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        List.Enumerator<T> val_8 = this.tips.GetEnumerator();
        label_22:
        if((678065968 & 1) == 0)
        {
            goto label_20;
        }
        
        val_3.丐丏七丌丕丗业且上().SetActive(value:  false);
        goto label_22;
        label_20:
        val_10 = 0;
        val_11 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( != 1)
        {
                if( == 0)
        {
                return;
        }
        
            if(165 == 165)
        {
                return;
        }
        
            return;
        }
        
        if( != 0)
        {
                return;
        }
    
    }
    public void OnMouseDown()
    {
        this.丛丕丁且丛且上下丂 = true;
    }
    private System.Collections.IEnumerator Start()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new NewLobbyLevelAnimator.不不丏丐丒丅丑丛丅();
    }
    public NewLobbyLevelAnimator()
    {
        this.buttonAlphaTime = 1f;
        this.timeBetweenShineAndTip = 5.510186E-41f;
        this.timeTipShown = 5f;
    }

}
