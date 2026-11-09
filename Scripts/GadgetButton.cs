using UnityEngine;
public class GadgetButton : MonoBehaviour
{
    // Fields
    internal const int 丐业丏丈丐丞三丛业 = 90;
    internal const int 丁东丂丗万丘不丆丛 = 20;
    public UnityEngine.GameObject thirdAvailableGadgetCell;
    public UnityEngine.GameObject thirdAvailableGadgetFrame;
    public UnityEngine.GameObject yazichok;
    public UISprite duration;
    public UISprite duration1;
    public UISprite duration2;
    public UISprite cooldown;
    public UISprite cooldown1;
    public UISprite cooldown2;
    public UnityEngine.GameObject cooldownEnds;
    public UnityEngine.GameObject cooldown1Ends;
    public UnityEngine.GameObject cooldown2Ends;
    public UILabel count;
    public UILabel count1;
    public UILabel count2;
    private UIBasicSprite gadgetIcon;
    private UIBasicSprite gadgetIcon1;
    private UIBasicSprite gadgetIcon2;
    public UnityEngine.GameObject counter;
    public UnityEngine.GameObject counter1;
    public UnityEngine.GameObject counter2;
    public UnityEngine.Animator gadgetAnimator;
    public bool isOpen;
    public UnityEngine.Transform ContainerForScale;
    private UISprite 丏下一上丘丘丛丆丁;
    
    // Properties
    public UIBasicSprite 丟丙丑丞一丈三丁丞 { get; }
    public UIBasicSprite 三且丕业丞丙万丐三 { get; }
    public UIBasicSprite 丛一三丌丁丒丒东丕 { get; }
    public UISprite 七丞业专丗丁丏万丛 { get; }
    
    // Methods
    public UIBasicSprite get_GadgetIcon()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.gadgetIcon);
        this.gadgetIcon = val_1;
        return val_1;
    }
    public UIBasicSprite get_GadgetIcon1()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.gadgetIcon1);
        this.gadgetIcon1 = val_1;
        return val_1;
    }
    public UIBasicSprite get_GadgetIcon2()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.gadgetIcon2);
        this.gadgetIcon2 = val_1;
        return val_1;
    }
    public void OpenGadgetPanel(bool 丁与万丂丝丒丐万丄)
    {
        var val_3;
        this.gadgetAnimator.SetBool(name:  "IsOpen", value:  丁与万丂丝丒丐万丄);
        val_3 = null;
        val_3 = null;
        JoystickController.丘万丏三丏丑世丐丏.gadgetPanelVisible = 丁与万丂丝丒丐万丄;
    }
    public void OnPanelOpen()
    {
    
    }
    public UISprite get_cachedSprite()
    {
        UISprite val_3;
        if(this.丏下一上丘丘丛丆丁 == 0)
        {
                this.丏下一上丘丘丛丆丁 = this.GetComponent<UISprite>();
            return val_3;
        }
        
        val_3 = this.丏下一上丘丘丛丆丁;
        return val_3;
    }
    private void Update()
    {
        float val_3 = 90f;
        val_3 = (float)this.cachedSprite.width / val_3;
        this.ContainerForScale.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public GadgetButton()
    {
    
    }

}
