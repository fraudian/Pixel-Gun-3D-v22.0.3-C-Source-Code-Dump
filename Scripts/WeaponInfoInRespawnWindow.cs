using UnityEngine;
public class WeaponInfoInRespawnWindow : MonoBehaviour
{
    // Fields
    private UIBasicSprite itemImage;
    private UILabel itemNameLabel;
    private UnityEngine.GameObject barPanel;
    private UISprite barSprite;
    private UnityEngine.GameObject arrowDown;
    private UnityEngine.GameObject arrowUp;
    private UnityEngine.GameObject clanItem;
    private UILabel clanItemLabel;
    private UILabel currentEfficiencylabel;
    internal ItemUpgradePromoInRespawnWindow promoUpgrade;
    private UISprite upgradedBarSprite;
    private float efficiencyIncreaseDuration;
    private UnityEngine.GameObject eventItem;
    private UILabel eventItemLabel;
    private UILabel headerLabel;
    private UnityEngine.Color headerLabelDefColor;
    private UnityEngine.GameObject iconDeadByBurn;
    private UnityEngine.Color colorLabelDeadByBurn;
    private UnityEngine.GameObject iconDeadByBleeding;
    private UnityEngine.Color colorLabelDeadByBleeding;
    private UnityEngine.GameObject iconDeadByPoison;
    private UnityEngine.Color colorLabelDeadByPoison;
    private UnityEngine.GameObject dotBackground;
    
    // Properties
    private UIBasicSprite 丐丆业丒丐不丘丆丗 { get; }
    
    // Methods
    private UIBasicSprite 丑丅丞丕三丌丁世丐()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.itemImage);
        this.itemImage = val_1;
        return val_1;
    }
    internal void 丁业丑丂丘不丏世丑(专丟丗丛上丕丐丒丏 丝丞丛七且一丅丐丄, float 专丘专丟丏丏丁丝丁, float 且东业丆丁业万七与, float 丕丗丆丒丄丂丁丈丞)
    {
        float val_52;
        float val_53;
        var val_54;
        PGCompany.三东丏不丗世丅丌丄 val_55;
        var val_56;
        var val_58;
        var val_59;
        var val_60;
        bool val_61;
        string val_62;
        val_52 = 丕丗丆丒丄丂丁丈丞;
        val_53 = 且东业丆丁业万七与;
        string val_2 = ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丝丞丛七且一丅丐丄.上东且丘丌专七丂丅)) != true) ? 丝丞丛七且一丅丐丄.丌丝下丄业一丄不三 : (丝丞丛七且一丅丐丄 + 80);
        bool val_3 = System.String.IsNullOrEmpty(value:  val_2);
        UnityEngine.GameObject val_4 = this.gameObject;
        if(val_4 == null)
        {
            goto label_4;
        }
        
        if(val_3 == false)
        {
            goto label_5;
        }
        
        label_6:
        val_4.SetActive(value:  false);
        return;
        label_4:
        if(val_3 == true)
        {
            goto label_6;
        }
        
        label_5:
        val_4.SetActive(value:  true);
        int val_5 = 丏丄丑上丛不丈且万.丅丂丂丌丏丗丝丛丐(丆万一不丌且东丐丐:  val_2);
        if(丝丞丛七且一丅丐丄.丕丛业丂丕丒三丟丄 != false)
        {
                val_54 = 70;
        }
        else
        {
                if(丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 == 15)
        {
                val_54 = 80;
        }
        
        }
        
        val_55 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丁丅丈丌丟世丗丗丟:  (丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 == 23) ? 1080 : 10, 丞丅上丏丂且下丅与:  val_2);
        if(val_55 == null)
        {
            goto label_73;
        }
        
        if(val_55.丕丐一丙专丛丒丑万() == false)
        {
            goto label_18;
        }
        
        if((System.Linq.Enumerable.Any<PGCompany.丞东万丈七世丛七丂>(source:  PGCompany.丌专一业万丂下丆丝.丕上丅不丌丁专东东(丆专且丕专丗与一丏:  val_55.业东丅东丌上丗丑不()))) == false)
        {
            goto label_15;
        }
        
        val_55 = 1;
        goto label_73;
        label_15:
        if((PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().丞丒丒三丞且丏东丄(丈丄不七三万丄丁不:  val_55)) == false)
        {
            goto label_18;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_15 = PGCompany.丄丂丌丞丁丙七丆三.丑七不且上丗丁一世().下丌三上丗不丒丘丞(丒丞丁丞下丝丆不且:  val_55);
        if((val_15 == null) || (val_15.丕丐一丙专丛丒丑万() == false))
        {
            goto label_21;
        }
        
        val_56 = System.Linq.Enumerable.Any<PGCompany.丞东万丈七世丛七丂>(source:  PGCompany.丌专一业万丂下丆丝.丕上丅不丌丁专东东(丆专且丕专丗与一丏:  val_15.业东丅东丌上丗丑不()));
        goto label_22;
        label_18:
        val_55 = 0;
        label_73:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.eventItem, 丏业丟一东丂东丘丛:  false);
        this.eventItemLabel.text = this.eventItem.丂丟一丑丛丄专东三(丝丞丛七且一丅丐丄:  丝丞丛七且一丅丐丄);
        UIBasicSprite val_21 = this.丑丅丞丕三丌丁世丐();
        if(丝丞丛七且一丅丐丄.丝万丘丂与丄不丑不 != false)
        {
                UnityEngine.Texture val_22 = 丏丄丑上丛不丈且万.丏万业丕下丌丛专丌(丆万一不丌且东丐丐:  val_2);
        }
        else
        {
                UnityEngine.Texture val_23 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_2, 七丆丒与丗丌丄且丂:  val_5, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        }
        
        this.itemNameLabel.text = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_2, 七丆丒与丗丌丄且丂:  val_5);
        if(专丘专丟丏丏丁丝丁 > 0f)
        {
                this.barPanel.SetActive(value:  (丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 != 23) ? 1 : 0);
            专丘专丟丏丏丁丝丁 = 专丘专丟丏丏丁丝丁 / val_52;
            this.barSprite.fillAmount = 专丘专丟丏丏丁丝丁;
            this.arrowDown.SetActive(value:  ((val_53 > 0f) ? 1 : 0) & ((专丘专丟丏丏丁丝丁 < 0) ? 1 : 0));
            val_58 = ((val_53 > 0f) ? 1 : 0) & ((专丘专丟丏丏丁丝丁 > val_53) ? 1 : 0);
            val_59 = val_58;
        }
        else
        {
                val_59 = 0;
        }
        
        (专丘专丟丏丏丁丝丁 > 0f) ? 0 : this.barPanel.SetActive(value:  false);
        if((UnityEngine.Object.op_Implicit(exists:  this.headerLabel)) != false)
        {
                丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.headerLabel, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.headerLabelDefColor, g = 专丘专丟丏丏丁丝丁, b = val_52, a = val_53});
            UnityEngine.GameObject val_33 = this.headerLabel.gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_33, 丏业丟一东丂东丘丛:  (丝丞丛七且一丅丐丄.丝万丘丂与丄不丑不 == false) ? 1 : 0);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.headerLabel, 丕丗丘丑丛与丑业丒:  val_33.丄丌下东不一丌丒丐(丝丞丛七且一丅丐丄:  丝丞丛七且一丅丐丄));
            UnityEngine.Color val_36 = this.丌且丑丁丝业一丐丑(丝丞丛七且一丅丐丄:  丝丞丛七且一丅丐丄);
            丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(丑丑丄万丛丗三业丘:  this.headerLabel, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_36.r, g = val_36.g, b = val_36.b, a = val_36.a});
        }
        
        val_60 = null;
        val_60 = null;
        if((WeaponManager.丆丘丘丑丌丁世七不.Contains(item:  val_2)) != true)
        {
                if((丁下万丟且丟丛下业.丈丛下丗丆丐丞丟丟(丕丁下丌不万丅丞丛:  val_2)) == false)
        {
            goto label_55;
        }
        
        }
        
        val_61 = 1;
        goto label_56;
        label_55:
        val_61 = BalanceController.三不一丒丆丁丌丁三(丞世不丒下上上丝丑:  七丌丞万七万丁丐丙.丈丏丑丏丁三业丑专(丆三丑专丂且一三业:  val_2));
        label_56:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanItem, 丏业丟一东丂东丘丛:  val_61);
        if(val_61 != false)
        {
                val_62 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8619");
            if(丝丞丛七且一丅丐丄.丕丛业丂丕丒三丟丄 != false)
        {
                val_62 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12331");
        }
        
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanItemLabel, 丕丗丘丑丛与丑业丒:  val_62);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.iconDeadByBurn, 丏业丟一东丂东丘丛:  (丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 == 14) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.iconDeadByBleeding, 丏业丟一东丂东丘丛:  (丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 == 17) ? 1 : 0);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.iconDeadByPoison, 丏业丟一东丂东丘丛:  (丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 == 12) ? 1 : 0);
        世不丟丂上丟与丌下 val_50 = 丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专;
        val_50 = System.Linq.Enumerable.Contains<世不丟丂上丟与丌下>(source:  new 世不丟丂上丟与丌下[3], value:  val_50);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.dotBackground, 丏业丟一东丂东丘丛:  val_50);
        return;
        label_21:
        val_56 = 0;
        label_22:
        var val_49 = (val_56 != 0) ? 1 : 0;
        goto label_73;
    }
    private Rilisoft.OfferItemType 不丌七丅丆丝丗丌东(专丟丗丛上丕丐丒丏 丝丞丛七且一丅丐丄)
    {
        var val_2;
        if(丝丞丛七且一丅丐丄.丕丛业丂丕丒三丟丄 != false)
        {
                val_2 = 70;
            return (Rilisoft.OfferItemType)(丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 == 23) ? 1080 : 10;
        }
        
        if(丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 != 15)
        {
                return (Rilisoft.OfferItemType)(丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 == 23) ? 1080 : 10;
        }
        
        val_2 = 80;
        return (Rilisoft.OfferItemType)(丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 == 23) ? 1080 : 10;
    }
    private string 丂丟一丑丛丄专东三(专丟丗丛上丕丐丒丏 丝丞丛七且一丅丐丄)
    {
        string val_1;
        if(丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 == 23)
        {
            goto label_2;
        }
        
        if(丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 != 15)
        {
            goto label_3;
        }
        
        val_1 = "Key_12836";
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1 = "Key_12324");
        label_2:
        val_1 = "Key_12837";
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1);
        label_3:
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1);
    }
    private string 丄丌下东不一丌丒丐(专丟丗丛上丕丐丒丏 丝丞丛七且一丅丐丄)
    {
        string val_1;
        世不丟丂上丟与丌下 val_1 = 丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专;
        val_1 = val_1 - 12;
        if(val_1 <= 11)
        {
                var val_2 = 106013888 + ((丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 - 12)) << 2;
            val_2 = val_2 + 106013888;
        }
        else
        {
                if(丝丞丛七且一丅丐丄.丕丛业丂丕丒三丟丄 != false)
        {
                val_1 = "Key_12202";
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1 = "Key_7756");
        }
        
            return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1);
        }
    
    }
    private UnityEngine.Color 丌且丑丁丝业一丐丑(专丟丗丛上丕丐丒丏 丝丞丛七且一丅丐丄)
    {
        UnityEngine.Color val_1;
        var val_2;
        var val_3;
        var val_4;
        if(丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 == 17)
        {
            goto label_1;
        }
        
        if(丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 == 14)
        {
            goto label_2;
        }
        
        if(丝丞丛七且一丅丐丄.不丕丅三丕丏丕上专 != 12)
        {
            goto label_3;
        }
        
        val_1 = this.colorLabelDeadByPoison;
        val_2 = 1152921540701105084;
        val_3 = 1152921540701105088;
        val_4 = 1152921540701105092;
        return new UnityEngine.Color() {r = this.headerLabelDefColor.r, g = 1.083578E-12f, b = 1.083578E-12f, a = 1.083578E-12f};
        label_1:
        val_1 = this.colorLabelDeadByBleeding;
        val_2 = 1152921540701105060;
        val_3 = 1152921540701105064;
        val_4 = 1152921540701105068;
        return new UnityEngine.Color() {r = this.headerLabelDefColor.r, g = 1.083578E-12f, b = 1.083578E-12f, a = 1.083578E-12f};
        label_2:
        val_1 = this.colorLabelDeadByBurn;
        val_2 = 1152921540701105036;
        val_3 = 1152921540701105040;
        val_4 = 1152921540701105044;
        return new UnityEngine.Color() {r = this.headerLabelDefColor.r, g = 1.083578E-12f, b = 1.083578E-12f, a = 1.083578E-12f};
        label_3:
        val_1 = this.headerLabelDefColor;
        val_2 = 1152921540701105012;
        val_3 = 1152921540701105016;
        val_4 = 1152921540701105020;
        return new UnityEngine.Color() {r = this.headerLabelDefColor.r, g = 1.083578E-12f, b = 1.083578E-12f, a = 1.083578E-12f};
    }
    internal void 丕东丑丞与丆上与丈(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七, float 且东业丆丁业万七与, bool 上一丁丑上丈丕丏丑, bool 丟丕丙丙丕丄下丄丐, bool 万丒丐丛丝丐丞丄丐)
    {
        float val_49;
        int val_50;
        var val_51;
        bool val_52;
        丕丑丙丑丙东丌丘丕 val_53;
        string val_54;
        val_49 = 且东业丆丁业万七与;
        if(下丅丙一丂丗丅丝七 != null)
        {
                if((System.String.IsNullOrEmpty(value:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七())) == false)
        {
            goto label_2;
        }
        
        }
        
        this.gameObject.SetActive(value:  false);
        return;
        label_2:
        this.gameObject.SetActive(value:  true);
        UIBasicSprite val_5 = this.丑丅丞丕三丌丁世丐();
        this.itemNameLabel.text = 下丅丙一丂丗丅丝七;
        val_50 = System.String.alignConst;
        var val_7 = (null == null) ? 下丅丙一丂丗丅丝七 : 0;
        if(val_7 == 0)
        {
            goto label_9;
        }
        
        val_51 = null;
        val_51 = null;
        val_52 = WeaponManager.丆丘丘丑丌丁世七不.Contains(item:  下丅丙一丂丗丅丝七.业上丙丞丐丄丆丅七());
        val_53 = val_7.丐上下三丑丈丑丄丟().七丑丌专丒上丒丙七();
        if(val_53 == null)
        {
                丕丑丙丑丙东丌丘丕 val_14 = null;
            val_53 = val_14;
            val_14 = new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  val_7.丐上下三丑丈丑丄丟().七丙丛与万且专三三(), 丏丆丐丑专与丄丘丞:  下丅丙一丂丗丅丝七);
        }
        
        float val_15 = BalanceController.且下丒丞丕丙丝一上(丞丌东丟且丒丐丑丂:  val_14, 专东丑丑丁丞丛三丗:  false);
        float val_16 = BalanceController.丄业世丘一丌三丕丝(业一丝丘专丐上与七:  0, 丏丆丐丑专与丄丘丞:  5);
        this.丞丄业丈业东丐专丛(丙丆专丛业丘丄下丝:  val_15, 万下七下七丈业丈丒:  val_16, 与丑丑丑丂丛一丝一:  万丒丐丛丝丐丞丄丐);
        this.丒丏世三丛丈丁丗业(丄东丈七丐万不丕东:  BalanceController.且下丒丞丕丙丝一上(丞丌东丟且丒丐丑丂:  new 丕丑丙丑丙东丌丘丕(丘丈不不下丙万丌专:  ExperienceController.丞丞丘业东丙丏七丌(), 丏丆丐丑专与丄丘丞:  下丅丙一丂丗丅丝七), 专东丑丑丁丞丛三丗:  false), 万下七下七丈业丈丒:  val_16, 上一丁丑上丈丕丏丑:  上一丁丑上丈丕丏丑);
        this.arrowDown.SetActive(value:  (val_15 < 0) ? 1 : 0);
        this.arrowUp.SetActive(value:  (val_15 > val_49) ? 1 : 0);
        val_54 = "Key_8619";
        goto label_22;
        label_9:
        this.barPanel.SetActive(value:  false);
        val_52 = 0;
        goto label_24;
        label_22:
        label_24:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanItem, 丏业丟一东丂东丘丛:  null);
        if( != false)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanItemLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  null));
        }
        
        if(this.promoUpgrade == 0)
        {
                return;
        }
        
        this.promoUpgrade.三丒丈丁下专丙不丌(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七, 丐丏上业丈丂与万丞:  丟丕丙丙丕丄下丄丐);
        this.promoUpgrade.丙东丑不丆业丁丟丝(丑丒业丘丑东丕世丅:  上一丁丑上丈丕丏丑);
    }
    private System.Collections.IEnumerator 丛一丑丈丅丂丘丁丌(float 丝三业丛丘且不丝丆, float 与丈业丛丝丒丙一丏)
    {
        WeaponInfoInRespawnWindow.丆丞三丄丂丂世万丈 val_1 = new WeaponInfoInRespawnWindow.丆丞三丄丂丂世万丈();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丝三业丛丘且不丝丆 = 丝三业丛丘且不丝丆;
        }
        else
        {
                mem[32] = this;
            .丝三业丛丘且不丝丆 = 丝三业丛丘且不丝丆;
        }
        
        .与丈业丛丝丒丙一丏 = 与丈业丛丝丒丙一丏;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丞丄业丈业东丐专丛(float 丙丆专丛业丘丄下丝, float 万下七下七丈业丈丒, bool 与丑丑丑丂丛一丝一)
    {
        float val_5 = 万下七下七丈业丈丒;
        this.barPanel.SetActive(value:  true);
        val_5 = 丙丆专丛业丘丄下丝 / val_5;
        if(与丑丑丑丂丛一丝一 != false)
        {
                UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丛一丑丈丅丂丘丁丌(丝三业丛丘且不丝丆:  val_5, 与丈业丛丝丒丙一丏:  this.efficiencyIncreaseDuration));
        }
        else
        {
                this.barSprite.fillAmount = val_5;
        }
        
        if(this.currentEfficiencylabel == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.currentEfficiencylabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_0437"));
    }
    private void 丒丏世三丛丈丁丗业(float 丄东丈七丐万不丕东, float 万下七下七丈业丈丒, bool 上一丁丑上丈丕丏丑)
    {
        if(this.upgradedBarSprite == 0)
        {
                return;
        }
        
        if(this.upgradedBarSprite == null)
        {
            goto label_4;
        }
        
        if(上一丁丑上丈丕丏丑 == false)
        {
            goto label_5;
        }
        
        label_7:
        丄东丈七丐万不丕东 = 丄东丈七丐万不丕东 / 万下七下七丈业丈丒;
        goto label_6;
        label_4:
        if(上一丁丑上丈丕丏丑 == true)
        {
            goto label_7;
        }
        
        label_5:
        label_6:
        this.upgradedBarSprite.fillAmount = 0f;
    }
    internal void 丏丂丛丈万业丏丈与(PGCompany.丗丟丄丈东丝丕丄世 下丅丙一丂丗丅丝七, bool 上一丁丑上丈丕丏丑, bool 丐丏上业丈丂与万丞)
    {
        if(this.promoUpgrade == 0)
        {
                return;
        }
        
        this.promoUpgrade.三丒丈丁下专丙不丌(下丅丙一丂丗丅丝七:  下丅丙一丂丗丅丝七, 丐丏上业丈丂与万丞:  丐丏上业丈丂与万丞);
        this.promoUpgrade.丙东丑不丆业丁丟丝(丑丒业丘丑东丕世丅:  上一丁丑上丈丕丏丑);
    }
    internal void 丙东丑不丆业丁丟丝(bool 丑丒业丘丑东丕世丅)
    {
        if(this.promoUpgrade == 0)
        {
                return;
        }
        
        this.promoUpgrade.丙东丑不丆业丁丟丝(丑丒业丘丑东丕世丅:  丑丒业丘丑东丕世丅);
    }
    public WeaponInfoInRespawnWindow()
    {
        this.efficiencyIncreaseDuration = 1f;
        this.headerLabelDefColor = 0;
        mem[1152921540702216788] = 0;
        mem[1152921540702216796] = 0;
    }

}
