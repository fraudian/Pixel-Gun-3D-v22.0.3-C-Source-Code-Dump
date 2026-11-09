using UnityEngine;
public class ButtonBannerBase : MonoBehaviour
{
    // Fields
    public int indexBut;
    public int priorityShow;
    
    // Methods
    public virtual void OnShow()
    {
    
    }
    public virtual void OnHide()
    {
    
    }
    public virtual bool BannerIsActive()
    {
        return false;
    }
    public virtual void OnClickButton()
    {
    
    }
    public virtual void OnChangeLocalize()
    {
    
    }
    public virtual void OnUpdateParameter()
    {
    
    }
    private void OnClick()
    {
        goto typeof(ButtonBannerBase).__il2cppRuntimeField_198;
    }
    private void OnPress(bool 丙丌丂与丒七丘丌丙)
    {
        var val_1;
        var val_2;
        var val_3;
        val_1 = null;
        if(丙丌丂与丒七丘丌丙 != false)
        {
                val_2 = null;
            ButtonBannerHUD.丄丘七三上丕世丞业.StopTimerNextBanner();
            return;
        }
        
        val_3 = null;
        ButtonBannerHUD.丄丘七三上丕世丞业.ResetTimerNextBanner();
    }
    public ButtonBannerBase()
    {
    
    }

}
