using UnityEngine;
public class ZombiKillController : MonoBehaviour
{
    // Fields
    private static ZombiKillController 丏丐丛丏丘东丛且丕;
    internal static string 丑丌丛东丛丈不丁万;
    internal static string 世丈丕三业丏东丞丁;
    internal static string 一七万丒丁丑一不不;
    internal static string 不丘上上不东丐一丕;
    internal static string 丛丒丐丐不不一丈丏;
    private int 丞丅丞丞丐东丏丛丆;
    private int 丁丐丄上丏不丙业七;
    private static readonly int <丑丐三丒丛专下与专>k__BackingField;
    
    // Properties
    internal static ZombiKillController 丆丕丝丒不丙且丐丗 { get; }
    internal static int 丁丐丞丝丏丗丟业丆 { get; }
    
    // Methods
    internal static ZombiKillController 丑七不且上丗丁一世()
    {
        null = null;
        return (ZombiKillController)ZombiKillController.丏丐丛丏丘东丛且丕;
    }
    internal static int 专东丛丄七万上丞三()
    {
        null = null;
        return (int)ZombiKillController.<丑丐三丒丛专下与专>k__BackingField;
    }
    private void Awake()
    {
        null = null;
        ZombiKillController.丏丐丛丏丘东丛且丕 = this;
    }
    public bool ZombieEventEnable()
    {
        return false;
    }
    public void ResetEvent()
    {
        this.SetCurrentZombieHP(丙业与丙丗丝不丈东:  0);
    }
    public int GetOldZombieHP()
    {
        null = null;
        return 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  ZombiKillController.世丈丕三业丏东丞丁, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
    }
    public int GetTotalZombieHP()
    {
        return 0;
    }
    public int GetZombieLastShownCount()
    {
        null = null;
        return 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  ZombiKillController.不丘上上不东丐一丕, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
    }
    public int GetZombieLastShownDaysCount()
    {
        null = null;
        return 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  ZombiKillController.丛丒丐丐不不一丈丏, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
    }
    public int GetCurrentZombieHP()
    {
        int val_3;
        var val_4;
        var val_5;
        val_3 = this.丞丅丞丞丐东丏丛丆;
        if(val_3 != 1)
        {
                return val_3;
        }
        
        val_4 = null;
        val_4 = null;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  ZombiKillController.丑丌丛东丛丈不丁万)) != false)
        {
                val_5 = null;
            val_5 = null;
            val_3 = ZombiKillController.丑丌丛东丛丈不丁万;
            int val_2 = 丌丝世丞世丛丆丅丟.丑下丏丑丛丝下丟丈(下上丐丆丝丟丝丒不:  val_3, 且丌丌丟丙丐丛丅下:  false, 专不万丝丂三万丝丕:  false, 丅丝丆且丘丟丗丅丄:  false);
        }
        else
        {
                val_3 = 0;
        }
        
        this.丞丅丞丞丐东丏丛丆 = val_3;
        return val_3;
    }
    public void SetZombieLastShownCount(int 丙业与丙丗丝不丈东)
    {
        null = null;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  ZombiKillController.不丘上上不东丐一丕, 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    public void SetZombieShownDaysCount(int 丙业与丙丗丝不丈东)
    {
        null = null;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  ZombiKillController.丛丒丐丐不不一丈丏, 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    public void SetCurrentZombieHP(int 丙业与丙丗丝不丈东)
    {
        int val_1;
        var val_2;
        val_1 = 丙业与丙丗丝不丈东 & (~(丙业与丙丗丝不丈东 >> 31));
        this.丞丅丞丞丐东丏丛丆 = val_1;
        val_2 = null;
        val_2 = null;
        val_1 = this.丞丅丞丞丐东丏丛丆;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  ZombiKillController.丑丌丛东丛丈不丁万, 下下丏一丙不丘丌丞:  val_1, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    public void SetOldZombieHP(int 丙业与丙丗丝不丈东)
    {
        null = null;
        丌丝世丞世丛丆丅丟.且专丒一丅万与丁丞(下上丐丆丝丟丝丒不:  ZombiKillController.世丈丕三业丏东丞丁, 下下丏一丙不丘丌丞:  丙业与丙丗丝不丈东, 丕丒万丄世丆丑丟丙:  false, 丌丂丑业下丞丝丈世:  false);
    }
    public void HitZombie(System.DateTime 丂三丟丂丈丐丆丗丟)
    {
    
    }
    public int GetCurrentDamage(System.Nullable<System.DateTime> 丂三丟丂丈丐丆丗丟)
    {
        return ZombiKillController.专东丛丄七万上丞三();
    }
    public int GetCurrentDamage(int 东专专丗丄与丏丗专, int 丕上上丗业与七三丟)
    {
        return ZombiKillController.专东丛丄七万上丞三();
    }
    internal static System.Nullable<System.DateTime> 丝丆丙丝且上丆一丐()
    {
        var val_4;
        var val_5;
        val_4 = null;
        val_4 = null;
        string val_1 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  ZombiKillController.一七万丒丁丑一不不);
        val_5 = 0;
        if((System.String.IsNullOrEmpty(value:  val_1)) == true)
        {
                return 0;
        }
        
        if((System.DateTime.TryParse(s:  val_1, result: out  new System.DateTime())) == false)
        {
                return 0;
        }
        
        val_5 = 0;
        return 0;
    }
    private static void 丒丝丘业一七且丘且(System.DateTime 丅丏丅丂丝一丆丙丅)
    {
        null = null;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  ZombiKillController.一七万丒丁丑一不不, 下下丏一丙不丘丌丞:  丅丏丅丂丝一丆丙丅.dateData);
    }
    public ZombiKillController()
    {
        this.丞丅丞丞丐东丏丛丆 = 0;
        this.丁丐丄上丏不丙业七 = 65515;
    }
    private static ZombiKillController()
    {
        ZombiKillController.丑丌丛东丛丈不丁万 = "Ads.ZombieCurrentHP";
        ZombiKillController.世丈丕三业丏东丞丁 = "Ads.ZombieOldHP";
        ZombiKillController.一七万丒丁丑一不不 = "Ads.ZombieLastShownTime";
        ZombiKillController.不丘上上不东丐一丕 = "Ads.ZombieLastShownCount";
        ZombiKillController.丛丒丐丐不不一丈丏 = "Ads.ZombieShownDaysCount";
        ZombiKillController.<丑丐三丒丛专下与专>k__BackingField = 17;
    }

}
