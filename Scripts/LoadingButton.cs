using UnityEngine;
public class LoadingButton : MonoBehaviour
{
    // Fields
    private bool autoLock;
    private UIButton 三上丘丑东丄丕丌丈;
    private UnityEngine.GameObject hideObject;
    private UnityEngine.GameObject loadingObject;
    private bool 万东丂丒且丅丛丑丕;
    
    // Properties
    public UIButton 丟丒丞丐丐丘丒丄东 { get; }
    public bool 丆丑三丛丑丐丏且丗 { get; set; }
    
    // Methods
    public UIButton get_button()
    {
        UIButton val_3;
        if(this.三上丘丑东丄丕丌丈 == 0)
        {
                this.三上丘丑东丄丕丌丈 = this.GetComponent<UIButton>();
            return val_3;
        }
        
        val_3 = this.三上丘丑东丄丕丌丈;
        return val_3;
    }
    public bool get_Pressed()
    {
        return (bool)this.万东丂丒且丅丛丑丕;
    }
    public void set_Pressed(bool 丙业与丙丗丝不丈东)
    {
        var val_17;
        bool val_18;
        var val_19;
        val_18 = 丙业与丙丗丝不丈东;
        var val_1 = (this.万东丂丒且丅丛丑丕 == true) ? 1 : 0;
        val_1 = val_1 ^ val_18;
        if(val_1 == false)
        {
                return;
        }
        
        this.万东丂丒且丅丛丑丕 = val_18;
        if(this.loadingObject != 0)
        {
                this.loadingObject.SetActive(value:  val_18);
        }
        
        val_19 = 0;
        if(this.hideObject != 0)
        {
                val_19 = 0;
            this.hideObject.SetActive(value:  (~val_18) & 1);
        }
        
        UIButton val_7 = this.button;
        var val_8 = (~val_18) & 1;
        UIButton val_9 = this.button;
        var val_10 = (val_18 != true) ? 2 : 0;
        val_18 = ???;
        val_17 = ???;
        goto typeof(UIButton).__il2cppRuntimeField_1F8;
    }
    private void Awake()
    {
        this.万东丂丒且丅丛丑丕 = false;
        if(this.loadingObject != 0)
        {
                this.loadingObject.SetActive(value:  false);
        }
        
        if(this.hideObject != 0)
        {
                this.hideObject.SetActive(value:  true);
        }
        
        if(this.autoLock == false)
        {
                return;
        }
        
        this.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void LoadingButton::东一丕丒且丂且一下(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    public LoadingButton()
    {
        this.autoLock = true;
    }
    private void 东一丕丒且丂且一下(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.Pressed = true;
    }

}
