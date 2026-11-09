using UnityEngine;
public class PauseMenu : MonoBehaviour
{
    // Fields
    private UnityEngine.UI.Toggle 丑丂丁丕丐万丈丐万;
    private float 丗三一丝上东丟丁丄;
    private float 业丑丂丙丘不万丄丟;
    private bool 丝业丟丑丌丗丞丁丏;
    
    // Methods
    private void Awake()
    {
        this.丑丂丁丕丐万丈丐万 = this.GetComponent<UnityEngine.UI.Toggle>();
    }
    private void 丗业与七丁七丈丂世()
    {
        this.丗三一丝上东丟丁丄 = UnityEngine.Time.timeScale;
        UnityEngine.Time.timeScale = 0f;
        this.业丑丂丙丘不万丄丟 = UnityEngine.AudioListener.volume;
        UnityEngine.AudioListener.volume = 0f;
        this.丝业丟丑丌丗丞丁丏 = true;
    }
    public void MenuOff()
    {
        UnityEngine.Time.timeScale = this.丗三一丝上东丟丁丄;
        UnityEngine.AudioListener.volume = this.业丑丂丙丘不万丄丟;
        this.丝业丟丑丌丗丞丁丏 = false;
    }
    public void OnMenuStatusChange()
    {
        if(this.丑丂丁丕丐万丈丐万.isOn != false)
        {
                if(this.丝业丟丑丌丗丞丁丏 == false)
        {
            goto label_2;
        }
        
        }
        
        if(this.丑丂丁丕丐万丈丐万.isOn == true)
        {
                return;
        }
        
        if(this.丝业丟丑丌丗丞丁丏 == false)
        {
                return;
        }
        
        UnityEngine.Time.timeScale = this.丗三一丝上东丟丁丄;
        UnityEngine.AudioListener.volume = this.业丑丂丙丘不万丄丟;
        this.丝业丟丑丌丗丞丁丏 = false;
        return;
        label_2:
        this.丗业与七丁七丈丂世();
    }
    public PauseMenu()
    {
        this.丗三一丝上东丟丁丄 = 1f;
        this.业丑丂丙丘不万丄丟 = 1f;
    }

}
