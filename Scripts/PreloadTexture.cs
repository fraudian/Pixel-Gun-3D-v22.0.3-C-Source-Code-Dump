using UnityEngine;
public class PreloadTexture : MonoBehaviour
{
    // Fields
    public bool clearMemoryOnUnload;
    private UITexture 一丕丅丕丂丕丘且丘;
    public string pathTexture;
    
    // Methods
    private void OnEnable()
    {
        UITexture val_7;
        if(东丗上丁下业一丂丂.专七与丏丞丁丅丈丟() == false)
        {
            goto label_3;
        }
        
        if(this.一丕丅丕丂丕丘且丘 != 0)
        {
            goto label_6;
        }
        
        val_7 = this.GetComponent<UITexture>();
        this.一丕丅丕丂丕丘且丘 = val_7;
        goto label_7;
        label_3:
        UnityEngine.Object.Destroy(obj:  this);
        return;
        label_6:
        val_7 = this.一丕丅丕丂丕丘且丘;
        label_7:
        if(val_7 == 0)
        {
                return;
        }
        
        UnityEngine.Coroutine val_6 = this.StartCoroutine(routine:  this.丅丗丁不丗丞丙上丒());
    }
    private System.Collections.IEnumerator 丅丗丁不丗丞丙上丒()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PreloadTexture.丐上丈七一七丆丞丕();
    }
    private void OnDisable()
    {
        if(东丗上丁下业一丂丂.专七与丏丞丁丅丈丟() == false)
        {
                return;
        }
        
        if(this.一丕丅丕丂丕丘且丘 != 0)
        {
                this = this.一丕丅丕丂丕丘且丘;
        }
        
        ActivityIndicator.丁与丏东且与万丝下();
    }
    public PreloadTexture()
    {
        this.clearMemoryOnUnload = true;
    }

}
