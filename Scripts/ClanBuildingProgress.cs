using UnityEngine;
internal sealed class ClanBuildingProgress : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject state_Normal;
    private UnityEngine.GameObject state_NeedUpgrade;
    private UnityEngine.GameObject state_MaxLevel;
    private ClanBuildingPointsView pointsView;
    private ClanBuildingUpgradeBanner upgradeBanner;
    private UILabel needLevelLabel;
    private UnityEngine.GameObject fortIcon;
    private UnityEngine.GameObject tankIcon;
    private UnityEngine.GameObject devUI;
    private ClanBuildingProgress.丙丙世七丆丝七丗丐 丝丘丆世丞上丆丙丑;
    private ClanBuildingProgress.丙丙世七丆丝七丗丐 且上丘丄丘业丐丅业;
    internal PGCompany.丏丌丝丕丐七丈且丒 丛不丈不丙丟不三上;
    
    // Methods
    private void OnEnable()
    {
        this.丝一丅丆三东丂丞七();
        PGCompany.丁丏丝上丘丝丒丞丒.东丏丏不丗丒丞不丐(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingProgress::丞丁东丐丞丑丆七上(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.丑丒丝丒七丐与下丝(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingProgress::丞丁东丐丞丑丆七上(int 丛丑丅丞丝丈丘丆三)));
    }
    private void OnDisable()
    {
        PGCompany.丁丏丝上丘丝丒丞丒.丂丕上丒丁丘丐七不(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingProgress::丞丁东丐丞丑丆七上(int 丛丑丅丞丝丈丘丆三)));
        PGCompany.丁丏丝上丘丝丒丞丒.丛丘丁世丄丑且丐丁(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanBuildingProgress::丞丁东丐丞丑丆七上(int 丛丑丅丞丝丈丘丆三)));
    }
    internal void 丈且东丑丂且万丒丅(PGCompany.丏丌丝丕丐七丈且丒 丕万丌世丆下丈丟与)
    {
        this.丛不丈不丙丟不三上 = 丕万丌世丆下丈丟与;
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.devUI, 丏业丟一东丂东丘丛:  false);
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        if(this.丛不丈不丙丟不三上 == null)
        {
                return;
        }
        
        this.丝丘丆世丞上丆丙丑 = this.且上丘丄丘业丐丅业;
        this.且上丘丄丘业丐丅业 = this.不业丌三丅丟丌下丌();
        this.pointsView.Setup(下丅丙一丂丗丅丝七:  this.丛不丈不丙丟不三上);
        this.不东丈丕不丝一东丙();
        if(this.且上丘丄丘业丐丅业 == 3)
        {
            goto label_7;
        }
        
        if(this.且上丘丄丘业丐丅业 == 2)
        {
            goto label_8;
        }
        
        if(this.且上丘丄丘业丐丅业 != 1)
        {
                return;
        }
        
        this.万丛丟上专业三上丅();
        return;
        label_7:
        this.一且三东丁丄与且世();
        return;
        label_8:
        this.丝丙丌世世丝丟丄丟();
    }
    private ClanBuildingProgress.丙丙世七丆丝七丗丐 不业丌三丅丟丌下丌()
    {
        PGCompany.丏丌丝丕丐七丈且丒 val_9;
        var val_10;
        var val_11;
        val_9 = this;
        if(this.丛不丈不丙丟不三上 != null)
        {
                val_10 = PGCompany.丒丂丘丐万三且丌丐.丑七不且上丗丁一世().丆世丂丅一且丑丝丅(丆专且丕专丗与一丏:  this.丛不丈不丙丟不三上.业东丅东丌上丗丑不());
            val_9 = this.丛不丈不丙丟不三上;
            var val_8 = (val_9.丙丅丗丏丆丆世世丙() != true) ? ((this.丛不丈不丙丟不三上.丁丟丈丌丑丅丞世丏() != true) ? (val_10) : 2) : 3;
            return (丙丙世七丆丝七丗丐)val_11;
        }
        
        val_11 = 0;
        return (丙丙世七丆丝七丗丐)val_11;
    }
    private void 不东丈丕不丝一东丙()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Normal, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_NeedUpgrade, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_MaxLevel, 丏业丟一东丂东丘丛:  false);
    }
    private void 万丛丟上专业三上丅()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Normal, 丏业丟一东丂东丘丛:  true);
    }
    private void 丝丙丌世世丝丟丄丟()
    {
        UILabel val_14;
        丟上丛丏丙丙丄丟业 val_15;
        var val_16;
        object val_17;
        string val_18;
        val_14 = this;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_NeedUpgrade, 丏业丟一东丂东丘丛:  true);
        int val_14 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().七不世与一丛丐丕丛();
        val_15 = this.丛不丈不丙丟不三上.丁丙丑万丒丒世不丕();
        if(val_15 != null)
        {
                val_16 = val_15.丕丆丆世万丆丁丕丘();
            val_15 = val_15.丘不丈丟不丅上丄业();
        }
        else
        {
                val_16 = 0;
        }
        
        val_14 = val_14 + 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.fortIcon, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tankIcon, 丏业丟一东丂东丘丛:  false);
        if(val_14 < val_16)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.fortIcon, 丏业丟一东丂东丘丛:  true);
            val_14 = this.needLevelLabel;
            val_15 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9175");
            val_17 = val_16;
            val_18 = val_15;
        }
        else
        {
                if(((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东万丂丙业与丆东丐()) + 1) >= val_15)
        {
                return;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.tankIcon, 丏业丟一东丂东丘丛:  true);
            val_14 = this.needLevelLabel;
            val_17 = val_15;
            val_18 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_9175");
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_14, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_18, arg0:  val_15));
    }
    private void 一且三东丁丄与且世()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_MaxLevel, 丏业丟一东丂东丘丛:  true);
    }
    private void 丞丁东丐丞丑丆七上(int 丛丑丅丞丝丈丘丆三)
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
    public void U_ShowInfo()
    {
        if(this.丛不丈不丙丟不三上 == null)
        {
                return;
        }
        
        this.upgradeBanner.丛不丈不丙丟不三上 = this.丛不丈不丙丟不三上;
        this.upgradeBanner.丝一丅丆三东丂丞七();
        this = ???;
        goto typeof(ClanBuildingUpgradeBanner).__il2cppRuntimeField_188;
    }
    public void U_DEV_LevelUp()
    {
    
    }
    public void U_DEV_LevelDown()
    {
    
    }
    public ClanBuildingProgress()
    {
    
    }

}
