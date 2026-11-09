using UnityEngine;
public class RecommendDuelsBanner : ClansSiegeConnectSceneBanner
{
    // Fields
    public UITextureMasked[] chestIcons;
    
    // Methods
    private void Awake()
    {
        var val_24;
        var val_25;
        var val_26;
        string val_26 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业().业上丙丞丐丄丆丅七();
        UnityEngine.Object val_5 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "OfferIcons/{0}_chest_2", arg0:  val_26));
        val_24 = 0;
        if( == 0)
        {
                UnityEngine.Object val_9 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "GameEvents/EventGUI_SharedResources/chest_{0}", arg0:  2));
            val_24 = 0;
        }
        
        UITextureMasked val_24 = this.chestIcons[0];
        UnityEngine.Object val_12 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "OfferIcons/{0}_chest_4", arg0:  val_26));
        val_25 = 0;
        if( == 0)
        {
                UnityEngine.Object val_16 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "GameEvents/EventGUI_SharedResources/chest_{0}", arg0:  4));
            val_25 = 0;
        }
        
        UITextureMasked val_25 = this.chestIcons[1];
        UnityEngine.Object val_19 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "OfferIcons/{0}_chest_3", arg0:  val_26));
        val_26 = 0;
        if( == 0)
        {
                UnityEngine.Object val_22 = UnityEngine.Resources.Load(path:  System.String.Format(format:  "GameEvents/EventGUI_SharedResources/chest_{0}", arg0:  3));
            val_26 = 0;
        }
        
        UITextureMasked val_27 = this.chestIcons[2];
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  "RecommendDuelsBannerShownKey", 下下丏一丙不丘丌丞:  1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    public void U_AnyZoneTouched()
    {
        this.U_CloseClick();
        new PGCompany.丌不丞丐世丞三丘丌() = new PGCompany.丌不丞丐世丞三丘丌();
        if(new PGCompany.丌不丞丐世丞三丘丌() != null)
        {
                .Type = 11;
        }
        else
        {
                mem[16] = 11;
        }
        
        .GameMode = 8;
        if((PGCompany.丒七丗丏丌丘万丘专.下丙丗丟丂下丏不丟(与不丕丆丈不丙丟丛:  new PGCompany.丌不丞丐世丞三丘丌())) == null)
        {
                return;
        }
    
    }
    public RecommendDuelsBanner()
    {
    
    }

}
