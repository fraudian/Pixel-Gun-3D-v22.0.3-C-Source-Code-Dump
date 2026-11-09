using UnityEngine;
public class MultipleToggleButton : MonoBehaviour
{
    // Fields
    public ToggleButton[] buttons;
    private System.EventHandler<Rilisoft.不东丞丂丕丑三业业> 丅丕丌丛万丂丈七与;
    private int 丆专一业丗丙万东且;
    
    // Properties
    public int 丐不丂世丟丛丒丆丆 { get; set; }
    
    // Methods
    public void add_Clicked(System.EventHandler<Rilisoft.不东丞丂丕丑三业业> 丙业与丙丗丝不丈东)
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
        while(this.丅丕丌丛万丂丈七与 != 1152921530951648160);
    
    }
    public void remove_Clicked(System.EventHandler<Rilisoft.不东丞丂丕丑三业业> 丙业与丙丗丝不丈东)
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
        while(this.丅丕丌丛万丂丈七与 != 1152921530951784736);
    
    }
    public int get_SelectedIndex()
    {
        return (int)this.丆专一业丗丙万东且;
    }
    public void set_SelectedIndex(int 丙业与丙丗丝不丈东)
    {
        var val_2;
        ToggleButton[] val_3;
        if(丙业与丙丗丝不丈东 == 1)
        {
                return;
        }
        
        val_3 = this.buttons;
        if(val_3 == null)
        {
                return;
        }
        
        val_2 = 0;
        this.丆专一业丗丙万东且 = 丙业与丙丗丝不丈东;
        goto label_3;
        label_9:
        if(val_2 != this.丆专一业丗丙万东且)
        {
                this.buttons[0].IsChecked = false;
        }
        
        val_3 = this.buttons;
        val_2 = 1;
        label_3:
        if(val_2 < this.buttons.Length)
        {
            goto label_9;
        }
        
        if(this.丅丕丌丛万丂丈七与 == null)
        {
                return;
        }
        
        Rilisoft.不东丞丂丕丑三业业 val_1 = new Rilisoft.不东丞丂丕丑三业业();
        val_1.丅不丄与丝万三七且(丙业与丙丗丝不丈东:  this.丆专一业丗丙万东且);
        this.丅丕丌丛万丂丈七与.Invoke(sender:  this, e:  val_1);
    }
    private void Awake()
    {
        var val_5;
        ToggleButton[] val_6;
        var val_7;
        ToggleButton[] val_8;
        ToggleButton[] val_9;
        int val_10;
        var val_11;
        System.EventHandler<Rilisoft.不东丞丂丕丑三业业> val_13;
        val_5 = null;
        与丂丏丛丞丞丒丟丄.一丗丈丛丌专专世世 = UnityEngine.PlayerPrefs.GetInt(key:  与丂丏丛丞丞丒丟丄.丟丐一丐七不业丂丆(), defaultValue:  2);
        val_6 = this.buttons;
        if(val_6 == null)
        {
            goto label_3;
        }
        
        val_7 = 0;
        goto label_4;
        label_9:
        val_6[0].add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.丛丘不丄丗丝丗七上>(object:  this, method:  System.Void MultipleToggleButton::丁丟丞丁丒丒东丟丂(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)));
        val_8 = this.buttons;
        val_7 = 1;
        label_4:
        val_9 = this.buttons;
        if(val_7 < this.buttons.Length)
        {
            goto label_9;
        }
        
        val_5 = null;
        label_3:
        val_5 = null;
        val_10 = 与丂丏丛丞丞丒丟丄.一丗丈丛丌专专世世;
        val_9[val_10].IsChecked = true;
        val_11 = null;
        val_11 = null;
        val_13 = MultipleToggleButton.<>c.<>9__7_0;
        if(val_13 == null)
        {
                System.EventHandler<Rilisoft.不东丞丂丕丑三业业> val_4 = null;
            val_13 = val_4;
            val_4 = new System.EventHandler<Rilisoft.不东丞丂丕丑三业业>(object:  MultipleToggleButton.<>c.__il2cppRuntimeField_static_fields, method:  System.Void MultipleToggleButton.<>c::且且专丒丞七丗丙丗(object 不丟丗丏丛丕不丁丌, Rilisoft.不东丞丂丕丑三业业 丗丛不丁丑专专丂且));
            MultipleToggleButton.<>c.<>9__7_0 = val_13;
        }
        
        this.add_Clicked(丙业与丙丗丝不丈东:  val_4);
    }
    public MultipleToggleButton()
    {
    
    }
    private void 丁丟丞丁丒丒东丟丂(object 不丟丗丏丛丕不丁丌, Rilisoft.丛丘不丄丗丝丗七上 丗丛不丁丑专专丂且)
    {
        var val_4;
        if(丗丛不丁丑专专丂且.且丂丅丁与丟丒丛丟() == false)
        {
                return;
        }
        
        val_4 = 0;
        this.SelectedIndex = System.Array.IndexOf<ToggleButton>(array:  this.buttons, value:  null);
    }

}
