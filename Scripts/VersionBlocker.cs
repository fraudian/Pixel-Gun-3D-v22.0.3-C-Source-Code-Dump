using UnityEngine;
internal sealed class VersionBlocker : MonoBehaviour
{
    // Fields
    private static VersionBlocker 丄丘七三上丕世丞业;
    private static int 丄丁丞一丐世丙丅专;
    
    // Properties
    internal static int 丆丒业下丑丗世不丆 { get; set; }
    
    // Methods
    internal static int 丕丏丑业丙专丙七丑()
    {
        int val_2;
        var val_3 = null;
        if((VersionBlocker.丄丁丞一丐世丙丅专 & 2147483648) != 0)
        {
                val_3 = null;
            val_2 = UnityEngine.PlayerPrefs.GetInt(key:  "DalayDayShopVersion", defaultValue:  3);
            val_3 = null;
            VersionBlocker.丄丁丞一丐世丙丅专 = val_2;
        }
        
        val_3 = null;
        return (int)VersionBlocker.丄丁丞一丐世丙丅专;
    }
    internal static void 丂东万下与三丄不世(int 丙业与丙丗丝不丈东)
    {
        null = null;
        VersionBlocker.丄丁丞一丐世丙丅专 = 丙业与丙丗丝不丈东;
        int val_1 = UnityEngine.PlayerPrefs.GetInt(key:  "DalayDayShopVersion", defaultValue:  VersionBlocker.丄丁丞一丐世丙丅专);
    }
    private void Awake()
    {
        var val_9;
        var val_10;
        val_9 = null;
        val_9 = null;
        if(VersionBlocker.丄丘七三上丕世丞业 == 0)
        {
                val_10 = null;
            val_10 = null;
            VersionBlocker.丄丘七三上丕世丞业 = this;
        }
        
        string val_2 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "UpdatesChecker.BlockedNotActualVersion_newKey", 丞丌丑丛上丕丙丕下:  System.String.alignConst);
        if((val_2.丞丝上丆上丅丞丐丄(专与上世东丏丐不丐:  val_2)) != false)
        {
                丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "UpdatesChecker.BlockedNotActualVersion_newKey", 下下丏一丙不丘丌丞:  System.String.alignConst);
        }
        
        string val_4 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "UpdatesChecker.BlockedNotShopVersion_newKey", 丞丌丑丛上丕丙丕下:  System.String.alignConst);
        if((val_4.丞丝上丆上丅丞丐丄(专与上世东丏丐不丐:  val_4)) == true)
        {
            goto label_15;
        }
        
        string val_6 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "UpdatesChecker.DetectedNotShopVersion_newKey", 丞丌丑丛上丕丙丕下:  System.String.alignConst);
        if((val_6.丞丝上丆上丅丞丐丄(专与上世东丏丐不丐:  val_6)) == false)
        {
            goto label_18;
        }
        
        label_15:
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "UpdatesChecker.BlockedNotShopVersion_newKey", 下下丏一丙不丘丌丞:  System.String.alignConst);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "UpdatesChecker.DetectedNotShopVersion_newKey", 下下丏一丙不丘丌丞:  System.String.alignConst);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "UpdatesChecker.NotShopVersionDetectionTime_newKey", 下下丏一丙不丘丌丞:  System.String.alignConst);
        label_18:
        丈丁且丌丁专丅与丄();
        UpdatesChecker.与下丅三万东丏丗且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void VersionBlocker::丘丈丝七且业上万丘()));
    }
    private bool 丞丝上丆上丅丞丐丄(string 专与上世东丏丐不丐)
    {
        var val_5;
        if((System.String.op_Equality(a:  专与上世东丏丐不丐, b:  System.String.alignConst)) != true)
        {
                new System.Version() = new System.Version(version:  专与上世东丏丐不丐);
            if((System.Version.op_GreaterThan(v1:  丟丌丁且且世丈丈丟.丕不七与丘东丞丕业(), v2:  new System.Version())) != false)
        {
                val_5 = 1;
            return (bool)val_5;
        }
        
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    private void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        if(丁与丟万丄丒丗专丌 != false)
        {
                return;
        }
        
        this.丈丁且丌丁专丅与丄();
    }
    private void 丕与丐不丈丆丏丁丛()
    {
        var val_2;
        if(UpdatesChecker.丈下丐丕丟丂丒丗丞() != false)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "UpdatesChecker.BlockedNotActualVersion_newKey", 下下丏一丙不丘丌丞:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒);
    }
    private void 丈丁且丌丁专丅与丄()
    {
        string val_10;
        var val_11;
        var val_12;
        string val_13;
        string val_14;
        string val_1 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "UpdatesChecker.NotShopVersionDetectionTime_newKey", 丞丌丑丛上丕丙丕下:  System.String.alignConst);
        val_10 = val_1;
        if((System.String.op_Equality(a:  val_1, b:  System.String.alignConst)) == true)
        {
                return;
        }
        
        if((System.DateTime.TryParse(s:  val_10, result: out  new System.DateTime())) != false)
        {
                val_10 = 0;
            System.DateTime val_4 = System.DateTime.UtcNow;
            if((System.DateTime.op_GreaterThan(t1:  new System.DateTime(), t2:  new System.DateTime() {dateData = val_4.dateData})) != true)
        {
                System.DateTime val_6 = System.DateTime.UtcNow;
            System.TimeSpan val_7 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_6.dateData}, d2:  new System.DateTime());
            val_11 = null;
            if(val_7._ticks.TotalDays <= (double)VersionBlocker.丕丏丑业丙专丙七丑())
        {
                return;
        }
        
        }
        
            val_12 = null;
            val_12 = null;
            val_10 = 丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒;
            val_13 = val_10;
            val_14 = "UpdatesChecker.BlockedNotShopVersion_newKey";
        }
        else
        {
                val_14 = val_10;
            val_13 = System.String.alignConst;
        }
        
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_14, 下下丏一丙不丘丌丞:  val_13);
    }
    private void 不丐丌专丂丛东丘丙()
    {
        string val_9 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "UpdatesChecker.BlockedNotActualVersion_newKey", 丞丌丑丛上丕丙丕下:  System.String.alignConst);
        if(UpdatesChecker.丈下丐丕丟丂丒丗丞() != false)
        {
                if((System.String.op_Inequality(a:  val_9 = 丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "UpdatesChecker.BlockedNotActualVersion_newKey", 丞丌丑丛上丕丙丕下:  System.String.alignConst), b:  System.String.alignConst)) != false)
        {
                val_9 = System.String.alignConst;
            丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "UpdatesChecker.BlockedNotActualVersion_newKey", 下下丏一丙不丘丌丞:  val_9);
        }
        
        }
        
        if(UpdatesChecker.且丕丑万丂丘且丄丂() != false)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "UpdatesChecker.BlockedNotShopVersion_newKey", 丞丌丑丛上丕丙丕下:  System.String.alignConst), b:  System.String.alignConst)) != true)
        {
                if((System.String.op_Inequality(a:  丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "UpdatesChecker.DetectedNotShopVersion_newKey", 丞丌丑丛上丕丙丕下:  System.String.alignConst), b:  System.String.alignConst)) == false)
        {
                return;
        }
        
        }
        
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "UpdatesChecker.BlockedNotShopVersion_newKey", 下下丏一丙不丘丌丞:  System.String.alignConst);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "UpdatesChecker.DetectedNotShopVersion_newKey", 下下丏一丙不丘丌丞:  System.String.alignConst);
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "UpdatesChecker.NotShopVersionDetectionTime_newKey", 下下丏一丙不丘丌丞:  System.String.alignConst);
    }
    private void 丘丈丝七且业上万丘()
    {
        this.不丐丌专丂丛东丘丙();
        this.丕与丐不丈丆丏丁丛();
    }
    internal static bool 丟不丌三丙万业丘七()
    {
        if((System.String.op_Inequality(a:  丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "UpdatesChecker.BlockedNotActualVersion_newKey", 丞丌丑丛上丕丙丕下:  System.String.alignConst), b:  System.String.alignConst)) == false)
        {
                return System.String.op_Inequality(a:  丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "UpdatesChecker.BlockedNotShopVersion_newKey", 丞丌丑丛上丕丙丕下:  System.String.alignConst), b:  System.String.alignConst);
        }
        
        return true;
    }
    internal static void 丞丙丙丟不丈东丅专()
    {
        int val_4;
        var val_5;
        val_4 = System.String.alignConst;
        if((System.String.op_Equality(a:  丌丝世丞世丛丆丅丟.丁丝丘丞丑丂丙丈丄(下上丐丆丝丟丝丒不:  "UpdatesChecker.NotShopVersionDetectionTime_newKey", 丞丌丑丛上丕丙丕下:  val_4), b:  System.String.alignConst)) == false)
        {
                return;
        }
        
        System.DateTime val_3 = System.DateTime.UtcNow;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "UpdatesChecker.NotShopVersionDetectionTime_newKey", 下下丏一丙不丘丌丞:  val_3.dateData);
        val_4 = 1152921505207164928;
        val_5 = null;
        val_5 = null;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  "UpdatesChecker.DetectedNotShopVersion_newKey", 下下丏一丙不丘丌丞:  丟丌丁且且世丈丈丟.七丙丒丑与丄丛丟丒);
    }
    internal static void 东丄丒丏且丘世一丟()
    {
    
    }
    public VersionBlocker()
    {
    
    }
    private static VersionBlocker()
    {
        VersionBlocker.丄丘七三上丕世丞业 = 0;
        VersionBlocker.丄丁丞一丐世丙丅专 = 0;
    }

}
