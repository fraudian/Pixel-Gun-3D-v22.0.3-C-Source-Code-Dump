using UnityEngine;
internal class ClanWarAnalyticsHandler : MonoBehaviour
{
    // Fields
    public static ClanWarAnalyticsHandler instance;
    private PGCompany.ClanWarController 丆东丟丂丈丒丁且丁;
    private static string 与丗丒丆丙七三丌业;
    private static string 丘丟丄上丂丄丐丗丑;
    private static string 下东不世丂专丛丌丟;
    
    // Methods
    private void Awake()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(ClanWarAnalyticsHandler.instance != 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        ClanWarAnalyticsHandler.instance = this;
    }
    private void OnEnable()
    {
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) == 0)
        {
                return;
        }
        
        this.丆东丟丂丈丒丁且丁 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        PGCompany.ClanWarProgressController.三丘丗丞丈丈三丛丞(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarAnalyticsHandler::丕业上下三丞丟下东()));
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丂丝丆丄丝丌丐上丙(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void ClanWarAnalyticsHandler::丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
    }
    private void 丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
    {
        PGCompany.Analytics.上丒丞上丌丌丘丛一 val_14;
        if(丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌() != 26)
        {
                return;
        }
        
        val_14 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if((val_14.丂三丞下专一下丛万(且下丕七丙丗丄不七:  1)) == null)
        {
                return;
        }
        
        if(null != null)
        {
                return;
        }
        
        val_14 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.Analytics.一业丗丆世世上丁且.丏丟丏丂丆上不丆三(丆丛丑世下一丐且丕:  val_14, 东且丁丆丛丁丏丘且:  丗丛不丁丑专专丂且.东丐三一业与丘丂丕(), 业丞七丂一丐丝丈七:  false, 业丅丏万万丁东丅丄:  0, 丂丝丐丅业丝丞丞丛:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁(), 丅丅下丟丑专下与一:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丝丌一且丝专丑丛().ToString());
    }
    private void OnDisable()
    {
        PGCompany.ClanWarProgressController.丆且且丄与业世业丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarAnalyticsHandler::丕业上下三丞丟下东()));
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().且上丒丆丁丐丐丁万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.业丗丒丞万七三丄七>(object:  this, method:  System.Void ClanWarAnalyticsHandler::丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)));
    }
    private void 丕业上下三丞丟下东()
    {
        string val_20;
        var val_21;
        var val_22;
        if((Rilisoft.Singleton<ClansController>.Instance) == 0)
        {
                return;
        }
        
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) == null)
        {
                return;
        }
        
        if(this.丆东丟丂丈丒丁且丁.与七世丝上丗丄丌丗() == false)
        {
                return;
        }
        
        val_20 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  val_20)) != 1)
        {
                val_20 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
            if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  val_20)) != 2)
        {
                return;
        }
        
        }
        
        this.一不且丅丏与丂丙丛();
        if(((this.丆东丟丂丈丒丁且丁.且丕丅三上丏上丆丏() != 0) && (this.丆东丟丂丈丒丁且丁.东丛世丟七上丞丕丝() != false)) && (this.丆东丟丂丈丒丁且丁.丆丅丟丂且丑一与丘() != true))
        {
                val_21 = null;
            val_21 = null;
            if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.与丗丒丆丙七三丌业, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) == 1)
        {
                this.且丙丒丝上丗世丞下();
        }
        
        }
        
        if(this.丆东丟丂丈丒丁且丁.丆丅丟丂且丑一与丘() == false)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.与丗丒丆丙七三丌业, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) == 1)
        {
                return;
        }
        
        this.一丗不下不丐丕丌丁();
    }
    private void 一不且丅丏与丂丙丛()
    {
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_5 = this;
        val_6 = null;
        val_6 = null;
        bool val_1 = 丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.与丗丒丆丙七三丌业);
        if(val_1 != false)
        {
                val_7 = null;
            val_7 = null;
            if((丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.与丗丒丆丙七三丌业, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)) == 1)
        {
                return;
        }
        
            val_8 = null;
            val_5 = this.丆东丟丂丈丒丁且丁.且丕丅三上丏上丆丏();
            val_8 = null;
            if(val_5 == (丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.与丗丒丆丙七三丌业, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false)))
        {
                return;
        }
        
        }
        
        val_1.丅下丞丁万丄丟丝业();
    }
    private void 丅下丞丁万丄丟丝业()
    {
        null = null;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.与丗丒丆丙七三丌业, 下下丏一丙不丘丌丞:  0, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.丘丟丄上丂丄丐丗丑, 下下丏一丙不丘丌丞:  0.ToString());
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.下东不世丂专丛丌丟, 下下丏一丙不丘丌丞:  0.ToString());
    }
    private void 且丙丒丝上丗世丞下()
    {
        PGCompany.Analytics.上丒丞上丌丌丘丛一 val_19;
        var val_20;
        var val_21;
        string val_22;
        var val_23;
        var val_24;
        val_19 = this;
        val_20 = null;
        val_20 = null;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.丘丟丄上丂丄丐丗丑)) != true)
        {
                val_21 = null;
            val_21 = null;
            val_22 = 0.ToString();
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.丘丟丄上丂丄丐丗丑, 下下丏一丙不丘丌丞:  val_22);
        }
        
        val_23 = null;
        val_23 = null;
        if((丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.丘丟丄上丂丄丐丗丑).Equals(value:  "false", comparisonType:  5)) == false)
        {
                return;
        }
        
        val_24 = null;
        val_24 = null;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.与丗丒丆丙七三丌业, 下下丏一丙不丘丌丞:  this.丆东丟丂丈丒丁且丁.且丕丅三上丏上丆丏(), 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.丘丟丄上丂丄丐丗丑, 下下丏一丙不丘丌丞:  1.ToString());
        val_19 = PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世();
        val_22 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丝丌一且丝专丑丛().ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        PGCompany.Analytics.一业丗丆世世上丁且.丟上丐丒世东丝七东(丆丛丑世下一丐且丕:  val_19, 丞丛丆专东一丛业业:  0, 丒丙丌丑三专业专丛:  this.丆东丟丂丈丒丁且丁.且丕丅三上丏上丆丏().ToString(), 丅丅下丟丑专下与一:  val_22, 且丒丛与丞世丙丕丌:  0, 下丝丘丁专丐丅丛丝:  0, 业业丁且丒丞与上专:  0, 且丒万丏万丒丐丐丁:  0, 丝丒世丏丗专专东丝:  0, 丌且丝丏丘丑丐丈丈:  0, 丕万丐东与一丈万与:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗()).ToString());
    }
    private void 一丗不下不丐丕丌丁()
    {
        string val_30;
        var val_31;
        int val_32;
        var val_33;
        string val_34;
        var val_35;
        var val_36;
        var val_37;
        val_30 = this;
        val_31 = null;
        val_31 = null;
        val_32 = 1152921505266909184;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.下东不世丂专丛丌丟)) != true)
        {
                val_33 = null;
            val_33 = null;
            val_34 = 0.ToString();
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.下东不世丂专丛丌丟, 下下丏一丙不丘丌丞:  val_34);
        }
        
        val_35 = null;
        val_35 = null;
        if((丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.下东不世丂专丛丌丟).Equals(value:  "false", comparisonType:  5)) == false)
        {
                return;
        }
        
        val_36 = null;
        val_36 = null;
        val_34 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丝丌一且丝专丑丛().ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_32 = this.丆东丟丂丈丒丁且丁.业三丕丏不丅七丁三();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_37 = null;
        PGCompany.Analytics.一业丗丆世世上丁且.丟上丐丒世东丝七东(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世(), 丞丛丆专东一丛业业:  1, 丒丙丌丑三专业专丛:  丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  ClanWarAnalyticsHandler.与丗丒丆丙七三丌业, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false).ToString(), 丅丅下丟丑专下与一:  val_34, 且丒丛与丞世丙丕丌:  val_32, 下丝丘丁专丐丅丛丝:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业不且丟丆下丏丌丒(), 业业丁且丒丞与上专:  this.丆东丟丂丈丒丁且丁.丙丏丌不丒一一丒上(丄丒下业一不丈丝丘:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().业丐丐三丕一丗丛丁()).Count, 且丒万丏万丒丐丐丁:  this.丆东丟丂丈丒丁且丁.丙丘上丞专丏丘世世(丁丅丈丌丟世丗丗丟:  2), 丝丒世丏丗专专东丝:  this.丆东丟丂丈丒丁且丁.丙丘上丞专丏丘世世(丁丅丈丌丟世丗丗丟:  1), 丌且丝丏丘丑丐丈丈:  this.丆东丟丂丈丒丁且丁.上东万丈丂丄丁与专(), 丕万丐东与一丈万与:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().三丕三下世丈丙与丈(丄丒且丙三丆丟与丏:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗()).ToString());
        val_30 = ClanWarAnalyticsHandler.下东不世丂专丛丌丟;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_30, 下下丏一丙不丘丌丞:  1.ToString());
    }
    public ClanWarAnalyticsHandler()
    {
    
    }
    private static ClanWarAnalyticsHandler()
    {
        ClanWarAnalyticsHandler.与丗丒丆丙七三丌业 = "I_nhouseA_nalytics_CW_id";
        ClanWarAnalyticsHandler.丘丟丄上丂丄丐丗丑 = "I_nhouseA_nalytics_CW_start";
        ClanWarAnalyticsHandler.下东不世丂专丛丌丟 = "I_nhouseA_nalytics_CW_end";
    }

}
