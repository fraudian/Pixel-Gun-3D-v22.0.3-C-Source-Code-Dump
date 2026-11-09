using UnityEngine;
public class ClansInputEditViewController : MonoBehaviour
{
    // Fields
    private UIButton btnCancel;
    private UIButton btnOk;
    private 丞丂丘丒丟丞丑下丄 专丁丕丞丑丕丕丟下;
    private ClansInputEditViewController.丁丒万上丏丂丆丙丑 业丈丙丁丕丒丛东丕;
    private UILabel windowText;
    
    // Methods
    internal void 东丂丄万丕万丂世与(丞丂丘丒丟丞丑下丄 丞丌丐丞丞丘丏专下, ClansInputEditViewController.丁丒万上丏丂丆丙丑 丌下丏丐丕丏不丗一)
    {
        var val_5;
        UILabel val_6;
        var val_8;
        string val_9;
        val_5 = this;
        this.业丈丙丁丕丒丛东丕 = 丌下丏丐丕丏不丗一;
        this.专丁丕丞丑丕丕丟下 = 丞丌丐丞丞丘丏专下;
        if(丌下丏丐丕丏不丗一 == 1)
        {
            goto label_1;
        }
        
        if(丌下丏丐丕丏不丗一 != 0)
        {
                return;
        }
        
        val_6 = this.windowText;
        if(丞丌丐丞丞丘丏专下.东丙上东业丆不丟丘() == null)
        {
            goto label_4;
        }
        
        string val_2 = this.专丁丕丞丑丕丕丟下.东丙上东业丆不丟丘();
        goto label_6;
        label_1:
        val_6 = this.windowText;
        if(丞丌丐丞丞丘丏专下.丆不与丕世丏三丅一() == null)
        {
            goto label_8;
        }
        
        label_6:
        val_5 = this.专丁丕丞丑丕丕丟下.丆不与丕世丏三丅一();
        val_8 = val_5;
        goto label_11;
        label_4:
        val_9 = "Enter name";
        goto label_13;
        label_8:
        val_9 = "Enter slogan";
        label_13:
        label_11:
        val_6.text = val_9;
    }
    private void Awake()
    {
        Rilisoft.ButtonHandler val_1 = this.btnOk.GetComponent<Rilisoft.ButtonHandler>();
        if(val_1 != 0)
        {
                val_1.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ClansInputEditViewController::丐丄丐丛上丟丄丟丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        Rilisoft.ButtonHandler val_4 = this.btnCancel.GetComponent<Rilisoft.ButtonHandler>();
        if(val_4 == 0)
        {
                return;
        }
        
        val_4.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ClansInputEditViewController::丕不三丕丌丗丌丒丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 丐丄丐丛上丟丄丟丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
    
    }
    private void 丕不三丕丌丗丌丒丞(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.gameObject.SetActive(value:  false);
    }
    public ClansInputEditViewController()
    {
    
    }

}
