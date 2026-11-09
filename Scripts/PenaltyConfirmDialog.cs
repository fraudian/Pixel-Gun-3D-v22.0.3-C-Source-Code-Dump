using UnityEngine;
internal sealed class PenaltyConfirmDialog : MonoBehaviour
{
    // Fields
    private UIButton _btnDialogYes;
    private UIButton _btnDialogNo;
    private UILabel _btnDialogText;
    internal System.Action 且丕丈与丒丑丑业丝;
    internal System.Action 丆上丙丝上上业业且;
    
    // Methods
    internal void 丑专丈丙丄专东世丒()
    {
        var val_11;
        string val_12;
        var val_13;
        var val_14;
        val_11 = null;
        val_11 = null;
        if(RatingSystem.丝七丘丝丒丞丝丆世 != false)
        {
                val_12 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5205");
        }
        else
        {
                if(RatingSystem.与且丙丒丂丗世丂世() != false)
        {
                val_13 = 0;
        }
        else
        {
                val_13 = UnityEngine.PlayerPrefs.GetInt(key:  "p_Leave_count", defaultValue:  0);
        }
        
            val_14 = null;
            val_14 = null;
            if(val_13 < RatingSystem.七业丈丝万丆下丏七)
        {
                string val_4 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6585");
        }
        
            val_12 = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2950"), arg0:  UnityEngine.Mathf.Abs(value:  RatingSystem.与一丅丝不丈业与丙().一丈丒东丑专丒丅丘()).ToString());
        }
        
        this.丒丁丅一下丂专万不(丕丗丘丑丛与丑业丒:  val_12);
    }
    internal void 丐丗一万丌丗丄与不()
    {
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  "leave_from_duel_penalty");
        if(val_1 != 0)
        {
                this.丒丁丅一下丂专万不(丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_2950"), arg0:  UnityEngine.Mathf.Abs(value:  val_1)));
            return;
        }
        
        if(this.且丕丈与丒丑丑业丝 == null)
        {
                return;
        }
        
        this.且丕丈与丒丑丑业丝.Invoke();
    }
    private void 丒丁丅一下丂专万不(string 丕丗丘丑丛与丑业丒)
    {
        this._btnDialogText.text = 丕丗丘丑丛与丑业丒;
    }
    private void Awake()
    {
        this._btnDialogYes.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PenaltyConfirmDialog::丐一丈不丂与丑丒世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this._btnDialogNo.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PenaltyConfirmDialog::上七万上丏丏万上丒(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    public PenaltyConfirmDialog()
    {
    
    }
    private void 丐一丈不丂与丑丒世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.且丕丈与丒丑丑业丝.Invoke();
    }
    private void 上七万上丏丏万上丒(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丆上丙丝上上业业且.Invoke();
    }

}
