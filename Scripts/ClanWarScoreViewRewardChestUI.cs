using UnityEngine;
internal sealed class ClanWarScoreViewRewardChestUI : PGBehaviour
{
    // Fields
    private string _chestId;
    private UITextureMasked _chestIcon;
    private System.Action<PGCompany.东丑丆丗丏丐丟下丄> 丞丙世丗丈专一丆世;
    internal PGCompany.东丑丆丗丏丐丟下丄 丒丁丝与且丂且丐丝;
    
    // Methods
    internal void 万东世丆丄丂丁丟丗(System.Action<PGCompany.东丑丆丗丏丐丟下丄> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丞丙世丗丈专一丆世, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丞丙世丗丈专一丆世 != 1152921536726328760);
    
    }
    internal void 丗且丏丞不丟丛不丝(System.Action<PGCompany.东丑丆丗丏丐丟下丄> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丞丙世丗丈专一丆世, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丞丙世丗丈专一丆世 != 1152921536726465336);
    
    }
    public void U_OnButtonClicked()
    {
        if(this.丞丙世丗丈专一丆世 == null)
        {
                return;
        }
        
        this.丞丙世丗丈专一丆世.Invoke(obj:  this.丒丁丝与且丂且丐丝);
    }
    internal PGCompany.丗丟丄丈东丝丕丄世 上丛丌丆丑上七世三()
    {
        PGCompany.丗丟丄丈东丝丕丄世 val_2 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丁丅丈丌丟世丗丗丟:  206, 丞丅上丏丂且下丅与:  this._chestId);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._chestIcon, 与万丆丛丒万丝丙丑:  val_2);
        return val_2;
    }
    public ClanWarScoreViewRewardChestUI()
    {
    
    }

}
