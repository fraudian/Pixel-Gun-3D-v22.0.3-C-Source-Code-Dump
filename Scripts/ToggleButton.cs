using UnityEngine;
public class ToggleButton : MonoBehaviour
{
    // Fields
    public UIButton offButton;
    public UIButton onButton;
    public bool useForMultipleToggle;
    private System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上> 丅丕丌丛万丂丈七与;
    private bool 丈丙丄丅丌丙丆丘不;
    
    // Properties
    public bool 业丟丑一丗丆业丛上 { get; set; }
    
    // Methods
    public void add_Clicked(System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丅丕丌丛万丂丈七与, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丕丌丛万丂丈七与 != 1152921540538433168);
    
    }
    public void remove_Clicked(System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丅丕丌丛万丂丈七与, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丕丌丛万丂丈七与 != 1152921540538569744);
    
    }
    public void SetCheckedImage(bool 丁丂专业丁丅丅丈丙)
    {
        this.offButton.gameObject.SetActive(value:  (~丁丂专业丁丅丅丈丙) & 1);
        this.onButton.gameObject.SetActive(value:  丁丂专业丁丅丅丈丙);
        if(this.useForMultipleToggle == false)
        {
                return;
        }
        
        this = ???;
        var val_7 = (~this.onButton.gameObject.activeSelf) & 1;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    public bool get_IsChecked()
    {
        return (bool)this.丈丙丄丅丌丙丆丘不;
    }
    public void set_IsChecked(bool 丙业与丙丗丝不丈东)
    {
        丙业与丙丗丝不丈东 = 丙业与丙丗丝不丈东;
        this.SetCheckedWithoutEvent(下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东);
        if(this.丅丕丌丛万丂丈七与 == null)
        {
                return;
        }
        
        Rilisoft.丛丘不丄丗丝丗七上 val_1 = new Rilisoft.丛丘不丄丗丝丗七上();
        val_1.专丐丆丝丑丄丑丄丈(丙业与丙丗丝不丈东:  (this.丈丙丄丅丌丙丆丘不 == true) ? 1 : 0);
        this.丅丕丌丛万丂丈七与.Invoke(sender:  this, e:  val_1);
    }
    public void SetCheckedWithoutEvent(bool 下下丏一丙不丘丌丞)
    {
        this.丈丙丄丅丌丙丆丘不 = 下下丏一丙不丘丌丞;
        this.offButton.gameObject.SetActive(value:  (this.丈丙丄丅丌丙丆丘不 == false) ? 1 : 0);
        this.onButton.gameObject.SetActive(value:  (this.丈丙丄丅丌丙丆丘不 == true) ? 1 : 0);
        if(this.useForMultipleToggle == false)
        {
                return;
        }
        
        this = ???;
        var val_8 = (~this.onButton.gameObject.activeSelf) & 1;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    private void Start()
    {
        this.onButton.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ToggleButton::丈丂丝下丄东世且丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.offButton.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ToggleButton::丄上丛丝业世丙三丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    public ToggleButton()
    {
        this.useForMultipleToggle = true;
    }
    private void 丈丂丝下丄东世且丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.IsChecked = false;
    }
    private void 丄上丛丝业世丙三丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.IsChecked = true;
    }

}
