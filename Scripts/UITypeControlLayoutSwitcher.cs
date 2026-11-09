using UnityEngine;
public class UITypeControlLayoutSwitcher : MonoBehaviour
{
    // Fields
    private 下丂世丂不丛专一一.丛七万丑下东业下丟 typeControl;
    private UIToggle 三丅丌丘三上丟丕东;
    
    // Properties
    internal 下丂世丂不丛专一一.丛七万丑下东业下丟 丘丑三丁与丛下丕丙 { get; }
    
    // Methods
    internal 下丂世丂不丛专一一.丛七万丑下东业下丟 丌丈七丄世丟丛一丛()
    {
        return (丛七万丑下东业下丟)this.typeControl;
    }
    private void Awake()
    {
        this.三丅丌丘三上丟丕东 = this.GetComponent<UIToggle>();
    }
    private void Start()
    {
        this.三丅丌丘三上丟丕东.onChange.Add(item:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void UITypeControlLayoutSwitcher::丑三丘丑丘业丘丌上())));
    }
    private void 丑三丘丑丘业丘丌上()
    {
        if(((this.三丅丌丘三上丟丕东.不世丌丝且三上丏丌 == false) ? this.三丅丌丘三上丟丕东.startsActive : this.三丅丌丘三上丟丕东.丐不丝丁丙下七丗丐) == 0)
        {
                return;
        }
        
        SettingsTabControls.丆丕丝丒不丙且丐丗.与丗万三丁专三上丘(丁丅丈丌丟世丗丗丟:  this.typeControl);
    }
    internal void 一丅丈丝且丈丆丑世(下丂世丂不丛专一一.丛七万丑下东业下丟 丁丅丈丌丟世丗丗丟)
    {
        this.三丅丌丘三上丟丕东.Set(丏业丟一东丂东丘丛:  (this.typeControl == 丁丅丈丌丟世丗丗丟) ? 1 : 0);
        this.丑三丘丑丘业丘丌上();
    }
    internal void 丅丁丝丁丈丛丐且丑(bool 丆丛丆丞下丅丂且丝)
    {
        丆丛丆丞下丅丂且丝 = 丆丛丆丞下丅丂且丝;
        this.三丅丌丘三上丟丕东.enabled = 丆丛丆丞下丅丂且丝;
    }
    public UITypeControlLayoutSwitcher()
    {
    
    }

}
