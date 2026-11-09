using UnityEngine;
internal sealed class ClanBuildingInvestorView : PGBehaviour
{
    // Fields
    private UISprite rankIcon;
    private UILabel playerName;
    private PGCompany.InventoryItemView investmentView;
    private PGCompany.丕专丝与丐上丂东世.丐丌丕丙专丑东丕丒 丘丑丁业丝丝与下不;
    
    // Methods
    public void Setup(PGCompany.丕专丝与丐上丂东世.丐丌丕丙专丑东丕丒 丘丑丁业丝丝与下不)
    {
        string val_15;
        string val_16;
        this.丘丑丁业丝丝与下不 = 丘丑丁业丝丝与下不;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.playerName, 丕丗丘丑丛与丑业丒:  丘丑丁业丝丝与下不.丂丆丏七下不丂专丁());
        this.investmentView.Setup(丈丄不七三万丄丁不:  丘丑丁业丝丝与下不.且丞世丗丝丛丏三丁());
        val_15 = "";
        val_16 = 丘丑丁业丝丝与下不.三丁专上专丁一业丐().ToString();
        七丈丗不丞丈丝丙七 val_7 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().丘下丏丞丂不三丂七(丄丒且丙三丆丟与丏:  val_16);
        if(val_7 != null)
        {
                val_15 = 丌丅且丗七丘丅丛丑.一丅丗东三一丁丈丑(专且丅丄且丘丟丅业:  val_7.丙东专丂世丈丏丁丂());
            val_16 = 1152921504622075904;
            UnityEngine.Debug.LogError(message:  "id = "("id = ") + 丘丑丁业丝丝与下不.三丁专上专丁一业丐());
            UnityEngine.Debug.LogError(message:  "rank = "("rank = ") + val_7.丙东专丂世丈丏丁丂());
            UnityEngine.Debug.LogError(message:  "spriteName = "("spriteName = ") + val_15);
        }
        
        丞东丑专丛丆丄丝世.丗与丈丒丗丌丄丗丕(丅丏上丆万丅业丝专:  this.rankIcon, 万丑丞一丝丌丐丒丘:  val_15);
    }
    public ClanBuildingInvestorView()
    {
    
    }

}
