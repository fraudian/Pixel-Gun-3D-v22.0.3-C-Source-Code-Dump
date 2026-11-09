using UnityEngine;
internal sealed class ClanBuildingUpgradeBanner : SimpleBunner
{
    // Fields
    private UnityEngine.GameObject state_Normal;
    private UnityEngine.GameObject state_NeedUpgrade;
    private UnityEngine.GameObject state_MaxLevel;
    private UnityEngine.GameObject state_WaitResponse;
    private ClanBuildingProgress buildingProgress;
    private UILabel mainTextLabel;
    private UIBasicSprite bigTexture;
    private PGCompany.InventoryItemView investPriceView;
    private System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丞下丗丅且上且上丟;
    private ClanBuildingUpgradeBanner.丙丙世七丆丝七丗丐 丝丘丆世丞上丆丙丑;
    private ClanBuildingUpgradeBanner.丙丙世七丆丝七丗丐 且上丘丄丘业丐丅业;
    internal PGCompany.丏丌丝丕丐七丈且丒 丛不丈不丙丟不三上;
    private int 丒丕三丌丒丑世丙丄;
    internal static readonly System.Collections.Generic.List<BankView.BankViewTab> 丑丝专丐与与业丏丗;
    
    // Methods
    protected override void OnEnable()
    {
        this.OnEnable();
        this.丝一丅丆三东丂丞七();
        PGCompany.丁丏丝上丘丝丒丞丒.东丏丏不丗丒丞不丐(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingUpgradeBanner::东丟丁丏丅丄三下丑(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.丑丒丝丒七丐与下丝(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingUpgradeBanner::东丟丁丏丅丄三下丑(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.下丂丟丙不丗丕丒一(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingUpgradeBanner::东丟丁丏丅丄三下丑(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.丞一丘丝与丅三丙一(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingUpgradeBanner::东丟丁丏丅丄三下丑(int 丛丑丅丞丝丈丘丆三)));
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        PGCompany.丁丏丝上丘丝丒丞丒.丂丕上丒丁丘丐七不(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingUpgradeBanner::东丟丁丏丅丄三下丑(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.丛丘丁世丄丑且丐丁(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingUpgradeBanner::东丟丁丏丅丄三下丑(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.丌专专上业东丄丞丄(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingUpgradeBanner::东丟丁丏丅丄三下丑(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.万且七丅丝丅一三一(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingUpgradeBanner::东丟丁丏丅丄三下丑(int 丛丑丅丞丝丈丘丆三)));
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.丏丌丝丕丐七丈且丒 丕万丌世丆下丈丟与)
    {
        this.丛不丈不丙丟不三上 = 丕万丌世丆下丈丟与;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        if(this.丛不丈不丙丟不三上 == null)
        {
                return;
        }
        
        this.丝丘丆世丞上丆丙丑 = this.且上丘丄丘业丐丅业;
        this.且上丘丄丘业丐丅业 = this.不业丌三丅丟丌下丌();
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.bigTexture, 与万丆丛丒万丝丙丑:  this.丛不丈不丙丟不三上.丆丞不丅万世七一丝());
        this.buildingProgress.丛不丈不丙丟不三上 = this.丛不丈不丙丟不三上;
        this.buildingProgress.丝一丅丆三东丂丞七();
        this.不东丈丕不丝一东丙();
        丙丙世七丆丝七丗丐 val_3 = this.且上丘丄丘业丐丅业;
        val_3 = val_3 - 1;
        if(val_3 > 3)
        {
                return;
        }
        
        var val_4 = 106021232 + ((this.且上丘丄丘业丐丅业 - 1)) << 2;
        val_4 = val_4 + 106021232;
        goto (106021232 + ((this.且上丘丄丘业丐丅业 - 1)) << 2 + 106021232);
    }
    private ClanBuildingUpgradeBanner.丙丙世七丆丝七丗丐 不业丌三丅丟丌下丌()
    {
        PGCompany.丏丌丝丕丐七丈且丒 val_14;
        var val_15;
        var val_16;
        val_14 = this;
        if(this.丛不丈不丙丟不三上 != null)
        {
                val_15 = PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().丆世丂丅一且丑丝丅(丆专且丕专丗与一丏:  this.丛不丈不丙丟不三上.业东丅东丌上丗丑不());
            val_14 = this.丛不丈不丙丟不三上;
            var val_12 = (val_14.丙丅丗丏丆丆世世丙() != true) ? (((PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().丌上专业丆丆下专丂(丛丑丅丞丝丈丘丆三:  this.丛不丈不丙丟不三上.业东丅东丌上丗丑不())) != true) ? 4 : ((this.丛不丈不丙丟不三上.丁丟丈丌丑丅丞世丏() != true) ? (val_15) : 2)) : 3;
            return (丙丙世七丆丝七丗丐)val_16;
        }
        
        val_16 = 0;
        return (丙丙世七丆丝七丗丐)val_16;
    }
    private void 不东丈丕不丝一东丙()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Normal, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_NeedUpgrade, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_MaxLevel, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_WaitResponse, 丏业丟一东丂东丘丛:  false);
    }
    private void 万丛丟上专业三上丅()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Normal, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.mainTextLabel, 丕丗丘丑丛与丑业丒:  this.丛不丈不丙丟不三上.丆丛丐上丄丅丄丒丁());
        this.下与丈丌丗上丝且万();
    }
    private void 丝丙丌世世丝丟丄丟()
    {
        UILabel val_15;
        object val_16;
        丟上丛丏丙丙丄丟业 val_17;
        var val_18;
        var val_19;
        val_15 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_NeedUpgrade, 丏业丟一东丂东丘丛:  true);
        int val_15 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().七不世与一丛丐丕丛();
        val_16 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东万丂丙业与丆东丐();
        val_17 = this.丛不丈不丙丟不三上.丁丙丑万丒丒世不丕();
        if(val_17 != null)
        {
                val_18 = val_17.丕丆丆世万丆丁丕丘();
            val_17 = val_17.丘不丈丟不丅上丄业();
        }
        else
        {
                val_18 = 0;
        }
        
        val_15 = val_15 + 1;
        if(val_15 < val_18)
        {
                val_15 = this.mainTextLabel;
            val_19 = 1152921504622075904;
            val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8448");
        }
        else
        {
                if((val_16 + 1) >= val_17)
        {
                return;
        }
        
            val_15 = this.mainTextLabel;
            val_19 = 1152921504622075904;
            val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8449");
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_15, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9117"), arg0:  val_16, arg1:  val_17));
    }
    private void 一且三东丁丄与且世()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_MaxLevel, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.mainTextLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9120"), arg0:  this.丛不丈不丙丟不三上.七业丑不七丐业丟丂()));
    }
    private void 且丏世东丝丅一一丙()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_WaitResponse, 丏业丟一东丂东丘丛:  true);
    }
    private void 东丟丁丏丅丄三下丑(int 丛丑丅丞丝丈丘丆三)
    {
        if(this.丛不丈不丙丟不三上 == null)
        {
                return;
        }
        
        if(this.丛不丈不丙丟不三上.业东丅东丌上丗丑不() != 丛丑丅丞丝丈丘丆三)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
    }
    private void 下与丈丌丗上丝且万()
    {
        this.丒丕三丌丒丑世丙丄 = 0;
        if(this.丛不丈不丙丟不三上.丙丅丗丏丆丆世世丙() == false)
        {
                return;
        }
        
        this.丒丕三丌丒丑世丙丄 = this.丛不丈不丙丟不三上.丌与一丏丏丌不不丒();
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_5 = PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().丁丗丌且丄下丆丐丄(丘丗丈东下业丟丟丑:  this.丛不丈不丙丟不三上.业东丅东丌上丗丑不(), 丞三丑不丆丁丄丐上:  this.丒丕三丌丒丑世丙丄);
        this.丞下丗丅且上且上丟 = val_5;
        if(val_5 == null)
        {
                return;
        }
        
        if(val_5.Count < 1)
        {
                return;
        }
        
        this.investPriceView.Setup(丈丄不七三万丄丁不:  this.丞下丗丅且上且上丟.Item[1]);
    }
    public void U_GoToBank()
    {
        null = null;
        this.万丞丌七丈丄丙东万(丏丂不专上丘丂不丅:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝, 丁丕丈丏且丕丒丞丏:  false);
    }
    private void 万丞丌七丈丄丙东万(string 丏丂不专上丘丂不丅, bool 丁丕丈丏且丕丒丞丏)
    {
        var val_6 = null;
        BankController.丑七不且上丗丁一世().丏三三不一丘上七且(丐万丂丞万丌丐丞世:  ClanBuildingUpgradeBanner.丑丝专丐与与业丏丗);
        BankController.丑七不且上丗丁一世().丌丏丕下丐专丁丝丈(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ClanBuildingUpgradeBanner::七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  true, 丆丟七丝丏业丅上丄:  丏丂不专上丘丂不丅, 丁丕丈丏且丕丒丞丏:  丁丕丈丏且丕丒丞丏, 世丁丙世丄一万丆三:  "");
    }
    private void 七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        BankController.丑七不且上丗丁一世().万一丂不丟丟丄丕丝(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ClanBuildingUpgradeBanner::七且丟丝丏专三丂丁(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        BankController.丑七不且上丗丁一世().丑万七一上丕业丗丒(丝三丄专丗丞丄丄丌:  false, 丆丟七丝丏业丅上丄:  0, 丁丕丈丏且丕丒丞丏:  false, 世丁丙世丄一万丆三:  "");
    }
    public void U_UpgradeButton()
    {
        int val_15;
        PGCompany.三东丏不丗世丅丌丄 val_16;
        val_15 = this;
        if(this.丞下丗丅且上且上丟 == null)
        {
                return;
        }
        
        if(this.丞下丗丅且上且上丟.Count < 2)
        {
                return;
        }
        
        val_16 = this.丞下丗丅且上且上丟.Item[1];
        if((PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丟丛世丘丐世丟丁丌(丈丄不七三万丄丁不:  val_16, 丙与不丌丌丟丄业丛:  new System.Nullable<PGCompany.丕丅世丂丞丒万丈且>() {HasValue = true})) != false)
        {
                val_16 = this.丛不丈不丙丟不三上.业东丅东丌上丗丑不();
            PGCompany.三东丏不丗世丅丌丄 val_9 = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  this.丛不丈不丙丟不三上.丞万丒丌丈东丄业下().业东丅东丌上丗丑不());
            val_9.业与一丏丟丌万丐丛(丙业与丙丗丝不丈东:  this.丒丕三丌丒丑世丙丄);
            val_15 = this.丞下丗丅且上且上丟.Item[1].业东丅东丌上丗丑不();
            PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().丒不丅丅业世丟不不(丘丗丈东下业丟丟丑:  val_16, 不且丐一丆丛丙丙丒:  val_9, 上七丂丏丅业丞且且:  val_15);
            return;
        }
        
        this.万丞丌七丈丄丙东万(丏丂不专上丘丂不丅:  this.丞下丗丅且上且上丟.Item[1].业上丙丞丐丄丆丅七(), 丁丕丈丏且丕丒丞丏:  true);
    }
    public ClanBuildingUpgradeBanner()
    {
    
    }
    private static ClanBuildingUpgradeBanner()
    {
        System.Collections.Generic.List<BankViewTab> val_1 = new System.Collections.Generic.List<BankViewTab>();
        if(val_1 != null)
        {
                val_1.Add(item:  1);
            val_1.Add(item:  2);
        }
        else
        {
                val_1.Add(item:  1);
            val_1.Add(item:  2);
        }
        
        val_1.Add(item:  8);
        ClanBuildingUpgradeBanner.丑丝专丐与与业丏丗 = val_1;
    }

}
