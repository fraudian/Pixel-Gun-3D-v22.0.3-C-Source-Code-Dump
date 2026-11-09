using UnityEngine;
internal sealed class WaveTopRoundInfo : PGBehaviour, 丏下一丌且三与丘丘
{
    // Fields
    private string 七东丏丟丗丆丐丗丑;
    private FortDefenceController 一丕丞丑与丞与丅丟;
    private string _iconName;
    private int 东七丛丝丑专世丏三;
    
    // Methods
    private void Start()
    {
        var val_2;
        GameModeController val_3;
        var val_4;
        val_2 = null;
        val_2 = null;
        val_3 = GameController.mode;
        if(val_3 == null)
        {
            goto label_5;
        }
        
        val_4 = null;
        val_3 = GameController.mode;
        if(val_3 == null)
        {
            goto label_10;
        }
        
        val_4 = null;
        this.一丕丞丑与丞与丅丟 = val_3;
        if(val_3 == null)
        {
            goto label_11;
        }
        
        GameController.mode + 512.add_OnStartWave(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  public System.Void WaveTopRoundInfo::OnChangeInfo(int 丘丂丄丗丙丅丈丏下)));
        label_5:
        this.OnChangeInfo(丘丂丄丗丙丅丈丏下:  0);
        return;
        label_10:
        this.一丕丞丑与丞与丅丟 = 0;
        label_11:
    }
    private void OnDestroy()
    {
        null = null;
        if(GameController.mode == null)
        {
                return;
        }
    
    }
    public string GetInfo()
    {
        return (string)this.七东丏丟丗丆丐丗丑;
    }
    public string GetNameSprite()
    {
        return (string)this._iconName;
    }
    public void OnChangeInfo(int 丘丂丄丗丙丅丈丏下)
    {
        FortDefenceController val_5 = this.一丕丞丑与丞与丅丟;
        if(val_5 != 0)
        {
                val_5 = this.一丕丞丑与丞与丅丟.wavesController;
            this.七东丏丟丗丆丐丗丑 = System.String.Format(format:  "{0} / {1}", arg0:  丘丂丄丗丙丅丈丏下 + 1, arg1:  val_5.且丒丆业一丑丒丕一());
            return;
        }
        
        this.七东丏丟丗丆丐丗丑 = "0/5";
    }
    public void SetIndexMiniPool(int 丞世不丒下上上丝丑)
    {
        this.东七丛丝丑专世丏三 = 丞世不丒下上上丝丑;
    }
    public int GetIndexMiniPool()
    {
        return (int)this.东七丛丝丑专世丏三;
    }
    public WaveTopRoundInfo()
    {
        this._iconName = "";
    }

}
