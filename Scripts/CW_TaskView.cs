using UnityEngine;
internal sealed class CW_TaskView : PGBehaviour
{
    // Fields
    private 不上丌世万丁丝丏丆 丐丌丞东上万万丈丂;
    internal bool showOtherClansProgress;
    private PGCompany.GameTaskView taskView;
    private UILabel taskIdLabel;
    internal UITextureMasked mapTexture;
    internal UnityEngine.GameObject taskTextureObject;
    private UITextureMasked taskTexture;
    private UITexture taskColorTexture;
    private UITexture taskPatternTexture;
    private UILabel sceneNameLabel;
    private UILabel gameModNameLabel;
    private UnityEngine.GameObject clanmemberIconIndicator;
    private UnityEngine.GameObject clanmemberTextIndicator;
    private UnityEngine.GameObject taskDescription;
    private UnityEngine.GameObject myContributionHolder;
    private UISprite myContributionBar;
    private UILabel myContributionLabel;
    private UILabel myContributionRewardLabel;
    private UnityEngine.GameObject myClanTaskProgress;
    private PropertiesLayout otherClansProgressLayout;
    private CW_TributeProgressUI tributeProgress;
    private CW_TributeProgressUI myTributeProgress;
    private UnityEngine.GameObject[] enableIfMine;
    private UnityEngine.GameObject[] enableIfUnreached;
    private ModulesTableUI modulesTableUI;
    private WidgetLayout widgetLayout;
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
        CW_TaskView val_138;
        float val_139;
        var val_140;
        float val_141;
        float val_142;
        UILabel val_143;
        string val_144;
        CW_TributeProgressUI val_145;
        var val_146;
        string val_147;
        var val_148;
        UnityEngine.Object val_149;
        UILabel val_150;
        var val_151;
        var val_152;
        string val_153;
        var val_154;
        UILabel val_155;
        var val_156;
        var val_157;
        string val_158;
        UnityEngine.MonoBehaviour val_159;
        var val_160;
        UnityEngine.Texture val_162;
        UITexture val_163;
        val_138 = this;
        val_139 = 0;
        int val_78 = 0;
        this.丐丌丞东上万万丈丂 = 丌丝万上丅丒一丈丘;
        if(丌丝万上丅丒一丈丘.下三下东业丘且丟业() == null)
        {
                return;
        }
        
        PGCompany.世丐下丕专东丘丏且 val_2 = this.丐丌丞东上万万丈丂.业丝丙下七下七下专();
        bool val_4 = this.丐丌丞东上万万丈丂.丂丝三不丅丙丄三丑();
        bool val_139 = val_4;
        val_4.丁丐丞丟下丄丒万业(业丐世丛丐一丌业不:  this.enableIfMine, 东丅丞丁丗万且丁丗:  val_139);
        bool val_6 = val_139 ^ 1;
        val_4.丁丐丞丟下丄丒万业(业丐世丛丐一丌业不:  this.enableIfUnreached, 东丅丞丁丗万且丁丗:  ((val_2 == 0) ? 1 : 0) & val_6);
        this.myClanTaskProgress.SetActive(value:  (val_2 != 0) ? 1 : 0);
        this.taskDescription.SetActive(value:  val_6);
        this.tributeProgress.gameObject.SetActive(value:  val_6);
        this.myTributeProgress.gameObject.SetActive(value:  val_139);
        val_140 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanmemberIconIndicator, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanmemberTextIndicator, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.myContributionHolder, 丏业丟一东丂东丘丛:  (this.丐丌丞东上万万丈丂.下丕丘丟三丞丘上万() > 0f) ? 1 : 0);
        this.gameObject.SetActive(value:  true);
        if(val_2 != null)
        {
                this.myContributionBar.fillAmount = this.丐丌丞东上万万丈丂.下丕丘丟三丞丘上万();
            UnityEngine.Color val_18 = PGCompany.丂丘丞丂丏七丁丄不.不丝世且丆丐专三丑(丏丆丗丂丟丘丈万万:  2);
            val_141 = val_18.b;
            this.myContributionBar.color = new UnityEngine.Color() {r = val_18.r, g = val_18.g, b = val_141, a = val_18.a};
            val_142 = this.丐丌丞东上万万丈丂.下丕丘丟三丞丘上万();
            val_139 = val_142 * 100f;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.myContributionLabel, 丕丗丘丑丛与丑业丒:  UnityEngine.Mathf.CeilToInt(f:  val_139)(UnityEngine.Mathf.CeilToInt(f:  val_139)) + "%"("%"));
            if((this.丐丌丞东上万万丈丂.下三下东业丘且丟业().丈丏丁东上与东丙丕() != null) && (this.丐丌丞东上万万丈丂.下三下东业丘且丟业().丈丏丁东上与东丙丕().Count >= 1))
        {
                val_142 = this.丐丌丞东上万万丈丂.下丕丘丟三丞丘上万();
            val_139 = val_142 * (float)this.丐丌丞东上万万丈丂.下三下东业丘且丟业().丈丏丁东上与东丙丕().Item[0].丂丁丏一丙丛业且丌();
            val_143 = this.myContributionRewardLabel;
            val_144 = UnityEngine.Mathf.CeilToInt(f:  val_139).ToString();
        }
        else
        {
                val_143 = this.myContributionRewardLabel;
            val_144 = "0";
        }
        
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_143, 丕丗丘丑丛与丑业丒:  val_144);
        }
        
        if(val_139 != false)
        {
                val_145 = this.myTributeProgress;
        }
        else
        {
                val_145 = this.tributeProgress;
        }
        
        val_145.丈且东丑丂且万丒丅(丌丝万上丅丒一丈丘:  this.丐丌丞东上万万丈丂);
        UnityEngine.Color val_35 = PGCompany.丂丘丞丂丏七丁丄不.不丝世且丆丐专三丑(丏丆丗丂丟丘丈万万:  0);
        this.taskView.业不丝丄丙丌丌丈丄(万不且且丛丆东丒业:  this.丐丌丞东上万万丈丂.下三下东业丘且丟业(), 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
        this.taskView.丝一丅丆三东丂丞七();
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.taskIdLabel, 丕丗丘丑丛与丑业丒:  this.丐丌丞东上万万丈丂.下三下东业丘且丟业());
        val_146 = null;
        val_147 = "";
        val_146 = null;
        PGCompany.GameTaskActionSettings val_39 = this.丐丌丞东上万万丈丂.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        val_148 = 1152921504848912384;
        val_149 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  val_39.Map);
        if(val_149 != 0)
        {
                val_147 = val_149.七丛一丛专七丈丅专();
        }
        else
        {
                PGCompany.GameTaskActionSettings val_45 = 丌丝万上丅丒一丈丘.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
            UnityEngine.Debug.LogError(message:  "No SceneInfo for " + val_45.Map);
        }
        
        PGCompany.GameTaskActionSettings val_49 = this.丐丌丞东上万万丈丂.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        PGCompany.GameTaskActionSettings val_52 = this.丐丌丞东上万万丈丂.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        val_150 = this.sceneNameLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_150, 丕丗丘丑丛与丑业丒:  val_147);
        if(this.clanmemberIconIndicator == 0)
        {
                if(this.clanmemberTextIndicator == 0)
        {
            goto label_159;
        }
        
        }
        
        if((((val_149 == 0) || (this.丐丌丞东上万万丈丂.丂丝三不丅丙丄三丑() == true)) || (this.丐丌丞东上万万丈丂.下三下东业丘且丟业().丈丐丞丐上丑且丕万() == false)) || (this.丐丌丞东上万万丈丂.下三下东业丘且丟业().七一丈丁专丞丛丟丌() == false))
        {
            goto label_159;
        }
        
        丞丂丘丒丟丞丑下丄 val_62 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_62 == null)
        {
            goto label_159;
        }
        
        System.Collections.Generic.List<System.String> val_63 = val_62.业丌丂丑上七丄一且();
        if((val_63 == null) || (val_63.Count < 1))
        {
            goto label_159;
        }
        
        List.Enumerator<T> val_65 = val_63.GetEnumerator();
        label_133:
        if(((-2126567248) & 1) == 0)
        {
            goto label_106;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.String> val_70 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        if((丐丌不丏东丟丕七丟.丑七不且上丗丁一世().万丄丘与丒丅丒下世().TryGetValue(key:  0.丐丏七丌丕丗业且上(), value: out  val_70)) == false)
        {
            goto label_133;
        }
        
        丁一丑丐丗下丄丟丐 val_72 = FriendsController.丈丘万七丝东丏三丙(丄且丆丘丆丏丄且东:  val_70);
        if(((val_72 == null) || ((System.String.IsNullOrEmpty(value:  val_72.丛且丞与丕业下丏丞)) == true)) || ((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_72.丞与丈七丁丗丅丁与())) == true))
        {
            goto label_133;
        }
        
        char[] val_76 = new char[1];
        val_76[0] = '_';
        if((System.Int32.TryParse(s:  val_72.丛且丞与丕业下丏丞.Split(separator:  val_76)[0], result: out  val_78)) == false)
        {
            goto label_133;
        }
        
        val_151 = null;
        val_151 = null;
        val_152 = val_78;
        if(SceneInfoController.丄丘七三上丕世丞业 == null)
        {
                val_152 = val_152;
        }
        
        SceneInfo val_80 = SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丈东丅万丟丞丒不丒:  0);
        if(val_80 == 0)
        {
            goto label_133;
        }
        
        string val_82 = val_80.丙且上丒不下丑下丞();
        val_153 = val_82;
        if(val_153 == 0)
        {
                val_153 = val_82;
        }
        
        if(((val_153.Equals(value:  val_149.丙且上丒不下丑下丞(), comparisonType:  5)) == false) || (val_72.丑丌丛丈丅丅与不业() != val_52.GameMode))
        {
            goto label_133;
        }
        
        val_150 = val_138;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanmemberIconIndicator, 丏业丟一东丂东丘丛:  true);
        val_138 = val_150;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.clanmemberTextIndicator, 丏业丟一东丂东丘丛:  true);
        label_106:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_159:
        if(this.modulesTableUI == 0)
        {
            goto label_166;
        }
        
        val_139 = val_139 | (((val_2 == 0) ? 1 : 0) | ((val_52.GameMode != 22) ? 1 : 0));
        UnityEngine.GameObject val_90 = this.modulesTableUI.gameObject;
        if(val_90 == null)
        {
            goto label_164;
        }
        
        if(val_139 == false)
        {
            goto label_165;
        }
        
        label_167:
        val_90.SetActive(value:  false);
        goto label_166;
        label_164:
        if(val_139 == true)
        {
            goto label_167;
        }
        
        label_165:
        val_90.SetActive(value:  true);
        val_149 = val_40.indexMap;
        this.modulesTableUI.UpdateModules(丞丒丌丄丄丏下下专:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丙丆不上丂万丝丕(), 下丞七丒业丂丈丘下:  val_149);
        label_166:
        val_154 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.gameModNameLabel, 丏业丟一东丂东丘丛:  false);
        if(val_52.GameMode == 100)
        {
            goto label_173;
        }
        
        if(val_52.GameMode != 22)
        {
            goto label_174;
        }
        
        val_155 = this.gameModNameLabel;
        val_156 = null;
        val_156 = null;
        val_149 = GameConnect.丗丗丈一不丂丛丞丒;
        int val_96 = UnityEngine.Mathf.Clamp(value:  Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丙丆不上丂万丝丕(), min:  0, max:  GameConnect.丗丗丈一不丂丛丞丒.Length - 1);
        val_157 = null;
        System.String[] val_97 = val_149 + (((long)(int)(val_96)) << 3);
        val_158 = mem[(GameConnect.丗丗丈一不丂丛丞丒 + ((long)(int)(val_96)) << 3) + 32];
        val_158 = (GameConnect.丗丗丈一不丂丛丞丒 + ((long)(int)(val_96)) << 3) + 32;
        goto label_185;
        label_173:
        val_159 = this.gameModNameLabel;
        val_160 = 0;
        goto label_188;
        label_174:
        val_155 = this.gameModNameLabel;
        PGCompany.GameTaskActionSettings val_101 = this.丐丌丞东上万万丈丂.下三下东业丘且丟业().世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        val_149 = val_101.GameMode;
        var val_140 = 0;
        val_140 = val_140 + 1;
        val_154 = 0;
        val_158 = GameConnect.丛丛丏专丏下三与七().Item[null];
        val_157 = null;
        label_185:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_155, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_158));
        val_160 = 1;
        val_159 = this.gameModNameLabel;
        label_188:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_159, 丏业丟一东丂东丘丛:  true);
        val_162 = System.String.IsNullOrEmpty(value:  val_49.Map);
        UnityEngine.GameObject val_106 = this.mapTexture.gameObject;
        if(val_162 == false)
        {
            goto label_207;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_106, 丏业丟一东丂东丘丛:  false);
        if(this.taskTextureObject != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.taskTextureObject, 丏业丟一东丂东丘丛:  true);
        }
        
        if(this.taskTexture != 0)
        {
                val_162 = CW_TaskView.丗丕专丈丄丏丏丒丄(与世七丑丂专专丌丙:  this.丐丌丞东上万万丈丂.下三下东业丘且丟业());
            丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.taskTexture, 与万丆丛丒万丝丙丑:  val_162);
        }
        
        if(this.taskColorTexture != 0)
        {
                val_162 = this.丐丌丞东上万万丈丂;
            UnityEngine.Color val_113 = CW_TaskView.丑丟丙丄丏世与丙丟(与世七丑丂专专丌丙:  val_162.下三下东业丘且丟业());
            val_142 = val_113.r;
            val_141 = val_113.b;
            this.taskColorTexture.color = new UnityEngine.Color() {r = val_142, g = val_113.g, b = val_141, a = val_113.a};
        }
        
        if(this.taskPatternTexture == 0)
        {
            goto label_228;
        }
        
        val_163 = this.taskPatternTexture;
        UnityEngine.Texture val_116 = CW_TaskView.丁丂丈世丐丐丙丌丘(与世七丑丂专专丌丙:  this.丐丌丞东上万万丈丂.下三下东业丘且丟业());
        goto label_230;
        label_207:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_106, 丏业丟一东丂东丘丛:  true);
        if(this.taskTextureObject != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.taskTextureObject, 丏业丟一东丂东丘丛:  false);
        }
        
        this.mapTexture.isOfferTexture = false;
        val_163 = this.mapTexture;
        label_230:
        val_162 = CW_TaskView.丂丐业丘丑丒三万丒(七丆丂丂下丈且丟世:  val_49.Map);
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  val_163, 与万丆丛丒万丝丙丑:  val_162);
        label_228:
        if(this.showOtherClansProgress == false)
        {
            goto label_279;
        }
        
        this.otherClansProgressLayout.世业丒万丘丆专丘丐();
        Dictionary.Enumerator<TKey, TValue> val_122 = this.丐丌丞东上万万丈丂.丑丂丅丐业丘下东丘().丏丞丌丁丄东丛下丑().专丄丘丑丏丞上丟丏().GetEnumerator();
        val_140 = 1152921525587526704;
        val_150 = "ignore my clan progress";
        val_162 = 1152921524529904288;
        goto label_251;
        label_259:
        ConfiguredValueTaskAwaiter val_124 = 0.GetAwaiter();
        if((System.String.op_Equality(a:  PGCompany.丂丘丞丂丏七丁丄不.丝世丏丘丐下七业丛(), b:  val_124._value._obj.丐丏七丌丕丗业且上())) != false)
        {
                丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "ignore my clan progress");
        }
        else
        {
                val_149;
            UnityEngine.Color val_135 = PGCompany.丂丘丞丂丏七丁丄不.丙业不丘丝一丁丆丏(丄丒下业一不丈丝丘:  val_124._value._obj.丐丏七丌丕丗业且上(), 丏丆丗丂丟丘丈万万:  0);
            float val_141 = 1.152922E+18f;
            val_141 = val_141 / (float)this.丐丌丞东上万万丈丂.下三下东业丘且丟业().丁丝丞与丟与丟丌三();
            PropertyUI val_136 = this.otherClansProgressLayout.丟丛丁丒丟丞丐丙丙(丛丐丌丙丈七丛丛东:  "", 丟丒丏丛三丟丑丗丝:  val_124._value._obj.丐丏七丌丕丗业且上(), 丌丒丝东丌下丕丁丅:  System.String.Format(format:  "{0}/{1}", arg0:  val_124._value._obj, arg1:  this.丐丌丞东上万万丈丂.下三下东业丘且丟业().丁丝丞与丟与丟丌三()), 丙丝与丆三丝不且丑:  val_141, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            val_138 = val_138;
            val_150 = val_150;
            val_140 = val_140;
            val_162 = val_162;
        }
        
        label_251:
        if(((-2126567312) & 1) != 0)
        {
            goto label_259;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_148 = 1152921504848912384;
        label_279:
        if((UnityEngine.Object.op_Implicit(exists:  mem[1152921536840030528])) == false)
        {
                return;
        }
        
        val_138 = mem[1152921536840030528];
        val_138.Reposition();
    }
    internal static UnityEngine.Texture 丂丐业丘丑丒三万丒(string 七丆丂丂下丈且丟世)
    {
        var val_5;
        var val_6;
        if(东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != false)
        {
                val_5 = "/Hi";
        }
        
        if((UnityEngine.Resources.Load(path:  System.String.Format(format:  "LevelLoadingsPreview{0}/Loading_{1}", arg0:  System.String.__il2cppRuntimeField_static_fields, arg1:  七丆丂丂下丈且丟世))) == null)
        {
                return (UnityEngine.Texture);
        }
        
        val_6 = 0;
        return (UnityEngine.Texture);
    }
    internal static UnityEngine.Texture 丗丕专丈丄丏丏丒丄(PGCompany.世丐下丕专东丘丏且 与世七丑丂专专丌丙)
    {
        object val_14;
        int val_15;
        string val_16;
        var val_17;
        val_14 = 与世七丑丂专专丌丙;
        val_15 = System.String.alignConst;
        PGCompany.GameTaskActionSettings val_2 = val_14.世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if(val_2.Type <= 19)
        {
            goto label_4;
        }
        
        if((val_2.Type - 72) > 7)
        {
            goto label_5;
        }
        
        var val_14 = 106014108;
        val_14 = (106014108 + ((val_2.Type - 72)) << 2) + val_14;
        goto (106014108 + ((val_2.Type - 72)) << 2 + 106014108);
        label_4:
        if(val_2.Type == 13)
        {
            goto label_7;
        }
        
        if(val_2.Type != 19)
        {
            goto label_15;
        }
        
        val_16 = "Textures/Clan/CWTasks/cw_icon_pet";
        goto label_20;
        label_7:
        PGCompany.GameTaskActionSettings val_5 = val_14.世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        val_15 = "OfferIcons/ClanLootBox/ClanLootBox_"("OfferIcons/ClanLootBox/ClanLootBox_") + val_5.ClanChestType + "_icon";
        goto label_15;
        label_5:
        if(val_2.Type == 29)
        {
            goto label_14;
        }
        
        if(val_2.Type != 51)
        {
            goto label_15;
        }
        
        val_16 = "Textures/Clan/CWTasks/cw_icon_armory";
        goto label_20;
        label_14:
        val_16 = "Textures/Clan/CWTasks/cw_icon_eventkeys";
        label_20:
        label_15:
        if((System.String.IsNullOrEmpty(value:  val_16)) != false)
        {
                PGCompany.GameTaskActionSettings val_9 = val_14.世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            mem2[0] = null;
            val_14 = "Non Texture for " + val_9.Type.ToString() + " Clan War Task";
            UnityEngine.Debug.LogError(message:  val_14);
        }
        else
        {
                if((UnityEngine.Resources.Load(path:  val_16)) == null)
        {
                return (UnityEngine.Texture)val_17;
        }
        
        }
        
        val_17 = 0;
        return (UnityEngine.Texture)val_17;
    }
    internal static UnityEngine.Color 丑丟丙丄丏世与丙丟(PGCompany.世丐下丕专东丘丏且 与世七丑丂专专丌丙)
    {
        object val_9;
        int val_10;
        string val_11;
        val_9 = 与世七丑丂专专丌丙;
        val_10 = System.String.alignConst;
        PGCompany.GameTaskActionSettings val_2 = val_9.世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        PGCompany.丒丘且上丟专东不丐 val_9 = val_2.Type;
        if(val_9 <= 19)
        {
            goto label_4;
        }
        
        val_9 = val_9 - 29;
        if(val_9 > 50)
        {
            goto label_11;
        }
        
        var val_10 = 1;
        val_10 = val_10 << val_9;
        val_10 = val_10 & 439804655304704;
        if(val_10 != 0)
        {
            goto label_6;
        }
        
        var val_11 = 1;
        val_11 = val_11 << val_9;
        val_11 = val_11 & 1688849860263937;
        if(val_11 != 0)
        {
            goto label_7;
        }
        
        val_9 = 1 << val_9;
        val_9 = val_9 & 114349209288704;
        if(val_9 != 0)
        {
            goto label_10;
        }
        
        goto label_11;
        label_4:
        if(val_9 == 13)
        {
            goto label_10;
        }
        
        if(val_9 != 19)
        {
            goto label_11;
        }
        
        label_6:
        val_11 = "orange";
        goto label_13;
        label_10:
        val_11 = "blue";
        goto label_13;
        label_7:
        val_11 = "purple";
        label_13:
        label_11:
        if((System.String.IsNullOrEmpty(value:  val_11)) == false)
        {
                return ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CW_TaskColors/cw_task_"("CW_TaskColors/cw_task_") + val_10);
        }
        
        PGCompany.GameTaskActionSettings val_5 = val_9.世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        mem2[0] = null;
        val_9 = "Non Color for " + val_5.Type.ToString() + " Clan War Task";
        UnityEngine.Debug.LogError(message:  val_9);
        val_10 = "orange";
        return ColorStorage.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "CW_TaskColors/cw_task_"("CW_TaskColors/cw_task_") + val_10);
    }
    internal static UnityEngine.Texture 丁丂丈世丐丐丙丌丘(PGCompany.世丐下丕专东丘丏且 与世七丑丂专专丌丙)
    {
        int val_7;
        string val_8;
        var val_9;
        val_7 = System.String.alignConst;
        PGCompany.GameTaskActionSettings val_2 = 与世七丑丂专专丌丙.世丈丁业丛上丘丗丐().万丆丄上七丒专且世();
        if(val_2.Type <= 19)
        {
            goto label_4;
        }
        
        if((val_2.Type - 72) > 7)
        {
            goto label_5;
        }
        
        var val_7 = 106014140;
        val_7 = (106014140 + ((val_2.Type - 72)) << 2) + val_7;
        goto (106014140 + ((val_2.Type - 72)) << 2 + 106014140);
        label_4:
        if(val_2.Type == 13)
        {
            goto label_10;
        }
        
        if(val_2.Type == 19)
        {
            goto label_8;
        }
        
        goto label_11;
        label_5:
        if(val_2.Type == 29)
        {
            goto label_10;
        }
        
        if(val_2.Type != 51)
        {
            goto label_11;
        }
        
        label_8:
        val_8 = "cw_pattern_arrows_up";
        goto label_17;
        label_10:
        val_8 = "cw_pattern_keys";
        label_17:
        label_11:
        if((UnityEngine.Resources.Load(path:  "Textures/Clan/CWTasks/"("Textures/Clan/CWTasks/") + val_8)) == null)
        {
                return (UnityEngine.Texture);
        }
        
        val_9 = 0;
        return (UnityEngine.Texture);
    }
    public void DEV_TaskIncrement()
    {
    
    }
    public void DEV_TaskComplete()
    {
    
    }
    private void 丁丐丞丟下丄丒万业(UnityEngine.GameObject[] 业丐世丛丐一丌业不, bool 东丅丞丁丗万且丁丗)
    {
        UnityEngine.GameObject val_3;
        goto label_1;
        label_8:
        val_3 = 业丐世丛丐一丌业不[0];
        if((UnityEngine.Object.op_Implicit(exists:  val_3)) != false)
        {
                val_3.SetActive(value:  东丅丞丁丗万且丁丗);
        }
        
        0 = 1;
        label_1:
        if(0 < 业丐世丛丐一丌业不.Length)
        {
            goto label_8;
        }
    
    }
    public CW_TaskView()
    {
        this.enableIfMine = new UnityEngine.GameObject[0];
        this.enableIfUnreached = new UnityEngine.GameObject[0];
    }

}
