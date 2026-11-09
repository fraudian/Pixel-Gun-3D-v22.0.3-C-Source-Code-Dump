using UnityEngine;
internal sealed class UnlockPremiumMapView : MonoBehaviour
{
    // Fields
    private int 丐丂丛与万丛丞丘万;
    public Rilisoft.ButtonHandler closeButton;
    public UILabel[] priceLabel;
    public UISprite priceSprite;
    public Rilisoft.ButtonHandler unlockButton;
    private System.EventHandler 丈丆一丏丙丄丛丌上;
    private System.EventHandler 丅丑丞下丑且丏丄丅;
    
    // Properties
    public int 丒丆丕丁丟业上七丅 { get; set; }
    
    // Methods
    public int get_Price()
    {
        return (int)this.丐丂丛与万丛丞丘万;
    }
    public void set_Price(int 丙业与丙丗丝不丈东)
    {
        int val_3 = 丙业与丙丗丝不丈东;
        this.丐丂丛与万丛丞丘万 = val_3;
        if(this.priceSprite == 0)
        {
                return;
        }
        
        val_3 = System.String.Format(format:  "premium_baner_{0}", arg0:  val_3 = 丙业与丙丗丝不丈东);
        this.priceSprite.spriteName = val_3;
    }
    public void add_ClosePressed(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丈丆一丏丙丄丛丌上, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈丆一丏丙丄丛丌上 != 1152921537312691024);
    
    }
    public void remove_ClosePressed(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丈丆一丏丙丄丛丌上, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈丆一丏丙丄丛丌上 != 1152921537312827600);
    
    }
    public void add_UnlockPressed(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丅丑丞下丑且丏丄丅, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丑丞下丑且丏丄丅 != 1152921537312964184);
    
    }
    public void remove_UnlockPressed(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丅丑丞下丑且丏丄丅, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丅丑丞下丑且丏丄丅 != 1152921537313100760);
    
    }
    private void OnDestroy()
    {
        if(this.closeButton != 0)
        {
                this.closeButton.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void UnlockPremiumMapView::丙三丛万丙业丌丏不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        if(this.unlockButton == 0)
        {
                return;
        }
        
        this.unlockButton.remove_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void UnlockPremiumMapView::七丂万丑七一东专一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void Start()
    {
        System.EventHandler val_7;
        if(this.closeButton != 0)
        {
                System.EventHandler val_2 = null;
            val_7 = val_2;
            val_2 = new System.EventHandler(object:  this, method:  System.Void UnlockPremiumMapView::丙三丛万丙业丌丏不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.closeButton.add_Clicked(丙业与丙丗丝不丈东:  val_2);
        }
        
        if(this.unlockButton != 0)
        {
                System.EventHandler val_4 = null;
            val_7 = val_4;
            val_4 = new System.EventHandler(object:  this, method:  System.Void UnlockPremiumMapView::七丂万丑七一东专一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            this.unlockButton.add_Clicked(丙业与丙丗丝不丈东:  val_4);
        }
        
        if(this.priceSprite != 0)
        {
                val_7 = System.String.Format(format:  "premium_baner_{0}", arg0:  this.丐丂丛与万丛丞丘万);
            this.priceSprite.spriteName = val_7;
        }
        
        this.丆丙丘上丂业七丒丝();
    }
    private void 丆丙丘上丂业七丒丝()
    {
        var val_3;
        if(this.priceLabel == null)
        {
                return;
        }
        
        if(this.priceLabel.Length == 0)
        {
                return;
        }
        
        val_3 = 0;
        goto label_5;
        label_10:
        this.priceLabel[0].text = System.String.Format(format:  "{0} {1}", arg0:  this.丐丂丛与万丛丞丘万, arg1:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1041"));
        val_3 = 1;
        label_5:
        if(val_3 < this.priceLabel.Length)
        {
            goto label_10;
        }
    
    }
    private void 丙三丛万丙业丌丏不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "Close event raised.");
        }
        
        if(this.丈丆一丏丙丄丛丌上 == null)
        {
                return;
        }
        
        this.丈丆一丏丙丄丛丌上.Invoke(sender:  不丟丗丏丛丕不丁丌, e:  丗丛不丁丑专专丂且);
    }
    private void 七丂万丑七一东专一(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "Unlock event raised.");
        }
        
        if(this.丅丑丞下丑且丏丄丅 == null)
        {
                return;
        }
        
        this.丅丑丞下丑且丏丄丅.Invoke(sender:  不丟丗丏丛丕不丁丌, e:  丗丛不丁丑专专丂且);
    }
    public UnlockPremiumMapView()
    {
        this.丐丂丛与万丛丞丘万 = 15;
    }

}
