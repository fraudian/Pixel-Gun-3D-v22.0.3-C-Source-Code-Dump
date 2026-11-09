using UnityEngine;
internal sealed class ScoreTopRoundInfo : PGBehaviour, 丏下一丌且三与丘丘
{
    // Fields
    private string 丟丟万一不业上丐丗;
    private string _iconName;
    private int 东七丛丝丑专世丏三;
    
    // Methods
    public string GetInfo()
    {
        return (string)this.丟丟万一不业上丐丗;
    }
    public string GetNameSprite()
    {
        return (string)this._iconName;
    }
    private void Update()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        if(GameController.mode == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        this.丟丟万一不业上丐丗 = GameController.mode.丞丏丕丑丞丑丏丏丄().ToString();
    }
    public void SetIndexMiniPool(int 丞世不丒下上上丝丑)
    {
        this.东七丛丝丑专世丏三 = 丞世不丒下上上丝丑;
    }
    public int GetIndexMiniPool()
    {
        return (int)this.东七丛丝丑专世丏三;
    }
    public ScoreTopRoundInfo()
    {
        this.丟丟万一不业上丐丗 = "";
        this._iconName = "";
    }

}
