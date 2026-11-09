using UnityEngine;
internal sealed class MailBoxRewardWindow : BannerWindow, 丑且丆万丏丝丘丙丟
{
    // Fields
    internal Rilisoft.ButtonHandler GetRewardButton;
    private 三专业丙丏丆丟丒丑 丟且丐七丄不丂丐丏;
    private UILabel GetRewardText;
    private UnityEngine.GameObject SpriteGem;
    private UnityEngine.GameObject SpriteCoin;
    
    // Methods
    private void Awake()
    {
        this.GetRewardButton.ClearEvents();
        this.GetRewardButton.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void MailBoxRewardWindow::一丁丒东且丆丑丌业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    internal void 一丁丒东且丆丑丌业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_4;
        PGCompany.NewsLobbyController val_5;
        var val_6;
        var val_7;
        MailBoxRewardController.丄丞丁丈与业上丞丟.丛丅丏万三东七丑不(丟且丐七丄不丂丐丏:  this.丟且丐七丄不丂丐丏);
        this.HideSelf();
        val_4 = null;
        val_4 = null;
        val_5 = PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟;
        if(val_5 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_5 = PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟.gameObject;
        if(val_5.activeSelf == false)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        PGCompany.NewsLobbyController.丄丞丁丈与业上丞丟.丛丘丗丟世丂一东一(七三丞丘丟下丛丛不:  false);
    }
    protected override void OnEnable()
    {
        var val_9;
        UnityEngine.GameObject val_10;
        var val_11;
        this.OnEnable();
        val_9 = 1152921505228677120;
        if(MailBoxRewardController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        三专业丙丏丆丟丒丑 val_2 = 0.丏丈不丑上三七业丗();
        this.丟且丐七丄不丂丐丏 = val_2;
        if(val_2 == null)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.GetRewardText, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  "{0} {1}", arg0:  I2.Loc.丗丈下丕丟丟丙七丞.丛东三世丄丂不不一(与专丒七不丈上丐上:  "Key_8073"), arg1:  val_2.丗七丟丈三不丕一三.丟丂丞不专丆万丒世()));
        val_9 = val_2.丗七丟丈三不丕一三.东与三丌丅三丒丏业();
        if((val_9.Replace(oldValue:  "Currency", newValue:  System.String.alignConst).Equals(value:  "Gems")) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.SpriteGem, 丏业丟一东丂东丘丛:  true);
            val_10 = this.SpriteCoin;
            val_11 = 0;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.SpriteGem, 丏业丟一东丂东丘丛:  false);
            val_10 = this.SpriteCoin;
            val_11 = 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  true);
    }
    public void TurnOn()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  true);
    }
    public void TurnOff()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this, 丏业丟一东丂东丘丛:  false);
    }
    public bool IsVisibleLobbyMenu()
    {
        return false;
    }
    public bool IsEnabledLobbyCamera()
    {
        return true;
    }
    public float GetDelayTurnOff()
    {
        System.NotImplementedException val_1 = new System.NotImplementedException();
    }
    public MailBoxRewardWindow()
    {
    
    }

}
