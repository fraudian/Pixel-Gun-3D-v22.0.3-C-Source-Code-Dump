using UnityEngine;
public class ClanSetMinimumRankBannerController : BannerWindow
{
    // Fields
    private static System.Action 丂业丏七丛丗丅丆丌;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Properties
    internal static bool 业丗丝万专万丞丟上 { get; }
    
    // Methods
    internal static void 万丛丒世丈上丕丏丒(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  ClanSetMinimumRankBannerController.丂业丏七丛丗丅丆丌, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丁丏七七丌一丙一丂(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  ClanSetMinimumRankBannerController.丂业丏七丛丗丅丆丌, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static bool 丂丙上且不丟业丛丒()
    {
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        if((ClansTutorialController.Instance.丘丆丘下且丗丒丟丄(业丝丛且丛专丝业丁:  2)) != false)
        {
                val_23 = ClansTutorialController.Instance.丘丆丘下且丗丒丟丄(业丝丛且丛专丝业丁:  1);
        }
        else
        {
                val_23 = 0;
        }
        
        丞丂丘丒丟丞丑下丄 val_7 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_7 != null)
        {
                val_24 = 丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_7.且丞东丑丟业丑丌万());
        }
        else
        {
                val_24 = 0;
        }
        
        丞丂丘丒丟丞丑下丄 val_11 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_11 != null)
        {
                val_25 = (~val_11.七东丏不与与丗丂丅()) & 1;
        }
        else
        {
                val_25 = 1;
        }
        
        丞丂丘丒丟丞丑下丄 val_14 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_14 != null)
        {
                var val_17 = ((val_14.三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == 1) ? 1 : 0;
        }
        else
        {
                val_26 = 0;
        }
        
        bool val_18 = val_23 & Rilisoft.ClansLobbyGui.丛世丛与丌不丈丐丐();
        val_18 = val_18 & ((val_24 != 1) ? (val_25) : (0 + 1));
        return (bool)val_26 & val_18;
    }
    public void U_Apply()
    {
        if(ClanSetMinimumRankBannerController.丂业丏七丛丗丅丆丌 != null)
        {
                ClanSetMinimumRankBannerController.丂业丏七丛丗丅丆丌.Invoke();
        }
        
        this.HideSelf();
    }
    protected override void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_4 = 0;
            val_4 = val_4 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  0, 与且专丈不万东一万:  0);
    }
    protected override void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
    }
    public ClanSetMinimumRankBannerController()
    {
    
    }

}
