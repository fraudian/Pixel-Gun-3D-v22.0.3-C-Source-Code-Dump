using UnityEngine;
public class TeamNumberOfPlayer : MonoBehaviour
{
    // Fields
    public int value;
    public UnityEngine.GameObject button2x2;
    public UnityEngine.GameObject button3x3;
    public UnityEngine.GameObject button4x4;
    public UnityEngine.GameObject button5x5;
    private int 丙东专丗上不丂丆业;
    
    // Methods
    private void Start()
    {
        var val_21;
        if(this.button2x2 != 0)
        {
                Rilisoft.ButtonHandler val_2 = this.button2x2.GetComponent<Rilisoft.ButtonHandler>();
            if(val_2 != 0)
        {
                val_2.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void TeamNumberOfPlayer::丐业丌不且丒七丄业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        if(this.button3x3 != 0)
        {
                Rilisoft.ButtonHandler val_6 = this.button3x3.GetComponent<Rilisoft.ButtonHandler>();
            if(val_6 != 0)
        {
                val_6.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void TeamNumberOfPlayer::七丆业丙丆丁丅丘与(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        if(this.button4x4 != 0)
        {
                Rilisoft.ButtonHandler val_10 = this.button4x4.GetComponent<Rilisoft.ButtonHandler>();
            if(val_10 != 0)
        {
                val_10.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void TeamNumberOfPlayer::业丈丏丘与丛丐丗丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        val_21 = 0;
        if(this.button5x5 != 0)
        {
                Rilisoft.ButtonHandler val_14 = this.button5x5.GetComponent<Rilisoft.ButtonHandler>();
            val_21 = 0;
            if(val_14 != 0)
        {
                val_21 = 0;
            val_14.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void TeamNumberOfPlayer::丁三丑与上丐丒丘业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        this.value = 10;
        UIButton val_17 = this.button2x2.GetComponent<UIButton>();
        UIButton val_18 = this.button3x3.GetComponent<UIButton>();
        UIButton val_19 = this.button4x4.GetComponent<UIButton>();
        if((this.button5x5.GetComponent<UIButton>()) == null)
        {
            
        }
    
    }
    public void SetValue(int 丆不丗三丄丕丛丈丏)
    {
        this.value = 丆不丗三丄丕丛丈丏;
        UIButton val_1 = this.button2x2.GetComponent<UIButton>();
        var val_2 = (this.value != 4) ? 1 : 0;
        UIButton val_3 = this.button3x3.GetComponent<UIButton>();
        var val_4 = (this.value != 6) ? 1 : 0;
        UIButton val_5 = this.button4x4.GetComponent<UIButton>();
        var val_6 = (this.value != 8) ? 1 : 0;
        UIButton val_7 = this.button5x5.GetComponent<UIButton>();
        var val_8 = (this.value != 10) ? 1 : 0;
        goto typeof(UIButton).__il2cppRuntimeField_178;
    }
    private void 丐业丌不且丒七丄业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.SetValue(丆不丗三丄丕丛丈丏:  4);
    }
    private void 七丆业丙丆丁丅丘与(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.SetValue(丆不丗三丄丕丛丈丏:  6);
    }
    private void 业丈丏丘与丛丐丗丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.SetValue(丆不丗三丄丕丛丈丏:  8);
    }
    private void 丁三丑与上丐丒丘业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.SetValue(丆不丗三丄丕丛丈丏:  10);
    }
    public TeamNumberOfPlayer()
    {
        this.丙东专丗上不丂丆业 = 8;
    }

}
