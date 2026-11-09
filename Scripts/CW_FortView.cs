using UnityEngine;
internal sealed class CW_FortView : PGBehaviour
{
    // Fields
    private 不上丌世万丁丝丏丆 丐丌丞东上万万丈丂;
    private UILabel title;
    private UITextureMasked texture;
    private UILabel clanName;
    private PGCompany.TimerUI timeLeft;
    private UnityEngine.GameObject fortInfoHolder;
    private UnityEngine.GameObject fortRaidHolder;
    private UILabel myClanScore;
    private UILabel enemyClanScore;
    private UILabel myClanName;
    private UILabel enemyClanName;
    private UITexture myClanIcon;
    private UITexture enemyClanIcon;
    private System.Collections.Generic.List<UIWidget> myClanBG;
    private System.Collections.Generic.List<UIWidget> enemyClanBG;
    private UILabel reward;
    private string textureName;
    private PropertiesLayout fortPropertiesLayout;
    private System.Collections.Generic.List<UnityEngine.Color> propertieColors;
    private UILabel rewardForEachClanMember;
    private UnityEngine.GameObject myContributionHolder;
    private UILabel myContributionPercent;
    private UILabel myContributionReward;
    private UIWidget widget;
    
    // Properties
    internal int 丐丌下丛丄丏业丘且 { get; }
    
    // Methods
    internal int 世万丞丒丈且三与丈()
    {
        if(this.widget == 0)
        {
                return 0;
        }
        
        if(this.widget != null)
        {
                return this.widget.height;
        }
        
        return this.widget.height;
    }
    internal void 下与丞三丅丛丄七丕(不上丌世万丁丝丏丆 丌丝万上丅丒一丈丘)
    {
        var val_74;
        string val_75;
        string val_76;
        var val_77;
        int val_78;
        var val_79;
        int val_80;
        UnityEngine.Texture val_81;
        UILabel val_82;
        string val_83;
        var val_84;
        string val_85;
        string val_86;
        this.fortRaidHolder.SetActive(value:  false);
        this.fortInfoHolder.SetActive(value:  false);
        this.丐丌丞东上万万丈丂 = 丌丝万上丅丒一丈丘;
        val_74 = 1152921505072021504;
        if(丌丝万上丅丒一丈丘.丂丝三不丅丙丄三丑() != false)
        {
                val_75 = "Key_8467";
        }
        else
        {
                val_75 = "Key_8468";
        }
        
        val_76 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_75);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.title, 丕丗丘丑丛与丑业丒:  val_76);
        this.texture.isOfferTexture = false;
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.texture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "LevelLoadings/"("LevelLoadings/") + this.textureName));
        if(丌丝万上丅丒一丈丘.丛七且专丗丒丟丞丈() == false)
        {
            goto label_14;
        }
        
        val_77 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世上东丙丂丐丕丙与().丕丐七丙丕丕丞丒丄(丞丅上丏丂且下丅与:  丌丝万上丅丒一丈丘.丙丗丏丂业且不东丞());
        if(val_77 == null)
        {
            goto label_18;
        }
        
        val_78 = val_77.东丙上东业丆不丟丘();
        if(val_78 != null)
        {
            goto label_19;
        }
        
        label_18:
        val_78 = System.String.alignConst;
        label_19:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanName, 丕丗丘丑丛与丑业丒:  val_78);
        PGCompany.一丏不三且丆专东东 val_12 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丂三丞下专一下丛万<PGCompany.一丏不三且丆专东东>(且下丕七丙丗丄不七:  2);
        if(val_12 == null)
        {
            goto label_27;
        }
        
        if(丌丝万上丅丒一丈丘.丂丝三不丅丙丄三丑() == true)
        {
            goto label_25;
        }
        
        val_78 = val_12.专东丏与万下丑丂丅();
        if(val_78 != 丌丝万上丅丒一丈丘.丛丆东上上丗丗业丕())
        {
            goto label_27;
        }
        
        label_25:
        this.fortRaidHolder.SetActive(value:  true);
        if(this.timeLeft != null)
        {
                this.timeLeft.丈且东丑丂且万丒丅(丆丐七丅丆丗丛上与:  val_12.丘丒不不丌丘下丒一(), 三丘丄丕丂丏东不丛:  0, 丛且丛丛下丒丑丙七:  0f, 世丐与丈三丝丌丄丑:  0, 与丌一丑且丗三丙一:  0);
        }
        
        val_79 = 1152921504622075904;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.myClanScore, 丕丗丘丑丛与丑业丒:  val_12.丑七丐万丘丁丝丆下());
        UnityEngine.Color val_20 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  System.String.Format(format:  "cw-tile-owned-{0}", arg0:  PGCompany.丂丘丞丂丏七丁丄不.丌丂丁丅丟丁丁七丂()));
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(不丏丛上丛丗丆丐丝:  this.myClanBG, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_20.r, g = val_20.g, b = val_20.b, a = val_20.a});
        val_74 = 1152921524404748272;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.myClanName, 丕丗丘丑丛与丑业丒:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东丙上东业丆不丟丘());
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.myClanIcon, 与万丆丛丒万丝丙丑:  Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().世丐专丂世丄世丂丌());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.enemyClanScore, 丕丗丘丑丛与丑业丒:  val_12.世万丙丘丂上丗与三());
        UnityEngine.Color val_30 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  System.String.Format(format:  "cw-tile-owned-{0}", arg0:  val_12.专东丏与万下丑丂丅()));
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(不丏丛上丛丗丆丐丝:  this.enemyClanBG, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_30.r, g = val_30.g, b = val_30.b, a = val_30.a});
        丞丂丘丒丟丞丑下丄 val_34 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世上东丙丂丐丕丙与().丕丐七丙丕丕丞丒丄(丞丅上丏丂且下丅与:  val_12.丂丅丏丘世且丅丗三());
        if(val_34 == null)
        {
            goto label_40;
        }
        
        val_80 = val_34.东丙上东业丆不丟丘();
        if(val_80 != null)
        {
            goto label_41;
        }
        
        label_40:
        val_80 = System.String.alignConst;
        label_41:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.enemyClanName, 丕丗丘丑丛与丑业丒:  val_80);
        丞丂丘丒丟丞丑下丄 val_39 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世上东丙丂丐丕丙与().丕丐七丙丕丕丞丒丄(丞丅上丏丂且下丅与:  val_12.丂丅丏丘世且丅丗三());
        if(val_39 == null)
        {
            goto label_46;
        }
        
        val_81 = val_39.世丐专丂世丄世丂丌();
        goto label_47;
        label_14:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.clanName, 丕丗丘丑丛与丑业丒:  "");
        val_82 = this.title;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_82, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8469"));
        return;
        label_27:
        this.fortInfoHolder.SetActive(value:  true);
        if(this.fortPropertiesLayout == 0)
        {
            goto label_75;
        }
        
        this.fortPropertiesLayout.世业丒万丘丆专丘丐();
        if(val_77 == null)
        {
            goto label_60;
        }
        
        val_83 = val_77.上上三七丟丝与丆与().ToString();
        goto label_61;
        label_46:
        val_81 = 0;
        label_47:
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.enemyClanIcon, 与万丆丛丒万丝丙丑:  val_81);
        PGCompany.三东丏不丗世丅丌丄 val_46 = val_12.三丄丝上丙丅丐丆丌();
        if(val_46 != null)
        {
                val_76 = val_46.丂丁丏一丙丛业且丌();
        }
        else
        {
                val_76 = 0;
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.reward, 丕丗丘丑丛与丑业丒:  val_76);
        if(val_12.丈且丑丛东丄三丕一() != null)
        {
                val_84 = val_12.丈且丑丛东丄三丕一();
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.rewardForEachClanMember, 丕丗丘丑丛与丑业丒:  val_84.丂丁丏一丙丛业且丌());
        val_78 = this.丐丌丞东上万万丈丂;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.myContributionHolder, 丏业丟一东丂东丘丛:  (val_78.下丕丘丟三丞丘上万() > 0f) ? 1 : 0);
        float val_74 = 100f;
        val_74 = val_12.下丕丘丟三丞丘上万() * val_74;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.myContributionPercent, 丕丗丘丑丛与丑业丒:  UnityEngine.Mathf.CeilToInt(f:  val_74)(UnityEngine.Mathf.CeilToInt(f:  val_74)) + "%"("%"));
        float val_56 = val_12.下丕丘丟三丞丘上万();
        val_56 = val_56 * 0f;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.myContributionReward, 丕丗丘丑丛与丑业丒:  UnityEngine.Mathf.CeilToInt(f:  val_56));
        goto label_75;
        label_60:
        val_83 = 0;
        label_61:
        UnityEngine.Color val_58 = this.propertieColors.Item[0];
        PropertyUI val_59 = this.fortPropertiesLayout.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  "", 丟丒丏丛三丟丑丗丝:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8241"), 丌丒丝东丌下丕丁丅:  val_83, 丙丝与丆三丝不且丑:  1f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = false});
        if(val_77 != null)
        {
                val_85 = val_77.三丒三丕不七丁丅丈().ToString();
        }
        else
        {
                val_85 = 0;
        }
        
        UnityEngine.Color val_63 = this.propertieColors.Item[1];
        PropertyUI val_64 = this.fortPropertiesLayout.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  "", 丟丒丏丛三丟丑丗丝:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8242"), 丌丒丝东丌下丕丁丅:  val_85, 丙丝与丆三丝不且丑:  1f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        val_78 = "";
        if(val_77 != null)
        {
                val_86 = val_77.业丐丐三丕一丗丛丁();
        }
        
        val_76 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丙丏丌不丒一一丒上(丄丒下业一不丈丝丘:  val_86).Count.ToString();
        UnityEngine.Color val_71 = this.propertieColors.Item[0];
        PropertyUI val_72 = this.fortPropertiesLayout.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  val_78, 丟丒丏丛三丟丑丗丝:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8253"), 丌丒丝东丌下丕丁丅:  val_76, 丙丝与丆三丝不且丑:  1f, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        label_75:
        val_82 = this.gameObject;
        val_82.SetActive(value:  true);
    }
    internal void 业不不且丐且与不与()
    {
        this.下与丞三丅丛丄七丕(丌丝万上丅丒一丈丘:  this.丐丌丞东上万万丈丂);
    }
    public CW_FortView()
    {
        this.textureName = "Loading_clan_fortress01";
    }

}
