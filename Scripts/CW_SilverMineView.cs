using UnityEngine;
internal sealed class CW_SilverMineView : PGBehaviour
{
    // Fields
    private UILabel _taskIdLabel;
    private UILabel _titleLabel;
    private UILabel _gameModeLabel;
    private UITextureMasked _texture;
    private UILabel _taskLabel;
    private PGCompany.GameTaskView _taskView;
    private UnityEngine.GameObject myClanTaskProgress;
    private UnityEngine.GameObject _warningContainerGo;
    private UILabel _monsterWarningLabel;
    private UILabel _rivalWarningLabel;
    private UnityEngine.GameObject containerModuleTables;
    private ModulesTableUI modulesTableUIForEnemy;
    private ModulesTableUI modulesTableUIForBosses;
    private UnityEngine.GameObject _otherClanContainerGo;
    private UILabel _otherClanNameLabel;
    private UILabel _powerFortLabel;
    private UILabel _powerTankLabel;
    private UnityEngine.GameObject _myClanContainerGo;
    private CW_TributeProgressUI _myTributeProgress;
    private PropertyUI _propertyOtherProgress;
    private string 且丟与下七丑丗专业;
    private string 三万丗三丌世丛丞世;
    private 不上丌世万丁丝丏丆 丐丌丞东上万万丈丂;
    
    // Methods
    internal void 下与丞三丅丛丄七丕(不上丌世万丁丝丏丆 丌丝万上丅丒一丈丘)
    {
        this.丐丌丞东上万万丈丂 = 丌丝万上丅丒一丈丘;
        if(丌丝万上丅丒一丈丘 != null)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._taskIdLabel, 丕丗丘丑丛与丑业丒:  丌丝万上丅丒一丈丘.下三下东业丘且丟业());
            世丂下且丟不不业专 val_2 = this.丘丅且东不丞万丅业();
            this.丅与丛且丆丙且且上(丝丄万丐下丐丟丈丆:  val_2);
            this.丌丕丗丌丘丒丁丙一(丝丄万丐下丐丟丈丆:  val_2);
            this.丟不丏世丝丕与世丘();
            this.且丌丟业下丙丗丑丗(丝丄万丐下丐丟丈丆:  val_2);
            this.丄丂一业业一与丄丝(丝丄万丐下丐丟丈丆:  val_2);
            this.丙专上下世丞丟丅东(丝丄万丐下丐丟丈丆:  val_2);
            this.丘业东且下东丏丝且(丝丄万丐下丐丟丈丆:  val_2);
            this.丒丌七且一丒万丈丞(丝丄万丐下丐丟丈丆:  val_2);
            this.丐一丁丞丄上丌东东();
            this.gameObject.SetActive(value:  true);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "_cell == null !!!");
    }
    private void 丐一丁丞丄上丌东东()
    {
        var val_6;
        var val_7;
        var val_22;
        string val_23;
        PropertyUI val_24;
        Dictionary.Enumerator<TKey, TValue> val_4 = this.丐丌丞东上万万丈丂.丑丂丅丐业丘下东丘().丏丞丌丁丄东丛下丑().专丄丘丑丏丞上丟丏().GetEnumerator();
        val_22 = 1152921525587527728;
        val_23 = 0;
        label_11:
        label_10:
        if(((-2129937216) & 1) == 0)
        {
            goto label_5;
        }
        
        ConfiguredValueTaskAwaiter val_8 = val_7.GetAwaiter();
        if((System.String.op_Equality(a:  PGCompany.丂丘丞丂丏七丁丄不.丝世丏丘丐下七业丛(), b:  val_8._value._obj.丐丏七丌丕丗业且上())) == false)
        {
            goto label_8;
        }
        
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "ignore my clan progress");
        goto label_10;
        label_8:
        if((-2129937232) <= 0)
        {
            goto label_10;
        }
        
        string val_12 = val_8._value._obj.丐丏七丌丕丗业且上();
        goto label_11;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_24 = this._propertyOtherProgress;
        if((System.String.IsNullOrEmpty(value:  null)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_24, 丏业丟一东丂东丘丛:  false);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_24, 丏业丟一东丂东丘丛:  true);
        val_24 = this._propertyOtherProgress;
        if(val_24 == 0)
        {
                return;
        }
        
        val_24 = this._propertyOtherProgress;
        val_22 = this.丐丌丞东上万万丈丂.下三下东业丘且丟业();
        UnityEngine.Color val_20 = PGCompany.丂丘丞丂丏七丁丄不.丙业不丘丝一丁丆丏(丄丒下业一不丈丝丘:  null, 丏丆丗丂丟丘丈万万:  0);
        val_6 = 0;
        val_7 = 0;
        float val_21 = 0f;
        val_21 = val_21 / (float)this.丐丌丞东上万万丈丂.下三下东业丘且丟业().丁丝丞与丟与丟丌三();
        val_24.世与东丗世三丞丞不(丟丕丞丁丝丂上丄上:  0, 丛丐丌丙丈七丛丛东:  "", 丟丒丏丛三丟丑丗丝:  null, 丌丒丝东丌下丕丁丅:  System.String.Format(format:  "{0}/{1}", arg0:  0, arg1:  val_22.丁丝丞与丟与丟丌三()), 丙丝与丆三丝不且丑:  val_21, 丑丞丈丗丄丙丟万丄:  new System.Nullable<UnityEngine.Color>() {HasValue = true}, 业丑丙一丐丞丌丘丅:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
    }
    private void 丟不丏世丝丕与世丘()
    {
        this._texture.isOfferTexture = false;
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._texture, 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  "LevelLoadings/Hi/"("LevelLoadings/Hi/") + ((System.String.IsNullOrEmpty(value:  this.丐丌丞东上万万丈丂.丙丗丏丂业且不东丞())) != true) ? this.且丟与下七丑丗专业 : this.三万丗三丌世丛丞世(((System.String.IsNullOrEmpty(value:  this.丐丌丞东上万万丈丂.丙丗丏丂业且不东丞())) != true) ? this.且丟与下七丑丗专业 : this.三万丗三丌世丛丞世)));
    }
    private void 丅与丛且丆丙且且上(CW_SilverMineView.世丂下且丟不不业专 丝丄万丐下丐丟丈丆)
    {
        var val_4;
        UILabel val_5;
        string val_6;
        val_4 = 丝丄万丐下丐丟丈丆.Equals(obj:  1);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_4 != false)
        {
                val_5 = this._titleLabel;
            val_6 = "Key_8975";
        }
        else
        {
                val_4 = null.Equals(obj:  2);
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
            val_5 = this._titleLabel;
            if(val_4 != false)
        {
                val_6 = "Key_8978";
        }
        else
        {
                val_6 = "Key_8982";
        }
        
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_5, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6));
    }
    private void 丌丕丗丌丘丒丁丙一(CW_SilverMineView.世丂下且丟不不业专 丝丄万丐下丐丟丈丆)
    {
        var val_4;
        UILabel val_5;
        string val_6;
        UILabel val_7;
        string val_8;
        val_4 = 丝丄万丐下丐丟丈丆.Equals(obj:  1);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if(val_4 == false)
        {
            goto label_3;
        }
        
        val_5 = this._gameModeLabel;
        val_6 = "Key_4359";
        goto label_6;
        label_3:
        val_4 = null.Equals(obj:  2);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        val_5 = this._gameModeLabel;
        if(val_4 == false)
        {
            goto label_9;
        }
        
        val_6 = "Key_8278";
        label_6:
        val_7 = val_5;
        val_8 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6);
        goto label_14;
        label_9:
        val_7 = val_5;
        val_8 = "";
        label_14:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_7, 丕丗丘丑丛与丑业丒:  val_8);
    }
    private void 丄丂一业业一与丄丝(CW_SilverMineView.世丂下且丟不不业专 丝丄万丐下丐丟丈丆)
    {
        UILabel val_11;
        string val_12;
        val_11 = this;
        val_12 = 丝丄万丐下丐丟丈丆.Equals(obj:  0);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_12 != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._warningContainerGo, 丏业丟一东丂东丘丛:  false);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._warningContainerGo, 丏业丟一东丂东丘丛:  true);
        val_12 = null.Equals(obj:  1);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_12 == false)
        {
            goto label_11;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._monsterWarningLabel, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._rivalWarningLabel, 丏业丟一东丂东丘丛:  false);
        val_11 = this._monsterWarningLabel;
        string val_3 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8977");
        goto label_16;
        label_11:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._monsterWarningLabel, 丏业丟一东丂东丘丛:  false);
        丞丂丘丒丟丞丑下丄 val_7 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世上东丙丂丐丕丙与().丕丐七丙丕丕丞丒丄(丞丅上丏丂且下丅与:  this.丐丌丞东上万万丈丂.丙丗丏丂业且不东丞());
        if(val_7 == null)
        {
            goto label_22;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._rivalWarningLabel, 丏业丟一东丂东丘丛:  true);
        val_11 = this._rivalWarningLabel;
        val_12 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8980");
        label_16:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_11, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  val_12, arg0:  val_7.东丙上东业丆不丟丘()));
        return;
        label_22:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._rivalWarningLabel, 丏业丟一东丂东丘丛:  false);
    }
    private void 丁一丕丅丕丒不丆丝(CW_SilverMineView.世丂下且丟不不业专 丝丄万丐下丐丟丈丆)
    {
        string val_7;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((丝丄万丐下丐丟丈丆.Equals(obj:  1)) != false)
        {
                val_7 = "Key_8976";
        }
        else
        {
                val_7 = "Key_8979";
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._taskLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_7), arg0:  this.丐丌丞东上万万丈丂.下三下东业丘且丟业().东且丟万下万世丟东().ToString()));
    }
    private CW_SilverMineView.世丂下且丟不不业专 丘丅且东不丞万丅业()
    {
        var val_7;
        var val_8;
        val_7 = this;
        if((System.String.IsNullOrEmpty(value:  this.丐丌丞东上万万丈丂.丙丗丏丂业且不东丞())) != false)
        {
                val_8 = 1;
            return (世丂下且丟不不业专)((val_7.Equals(value:  PGCompany.丂丘丞丂丏七丁丄不.丝世丏丘丐下七业丛())) != true) ? 0 : 2;
        }
        
        val_7 = this.丐丌丞东上万万丈丂.丙丗丏丂业且不东丞();
        return (世丂下且丟不不业专)((val_7.Equals(value:  PGCompany.丂丘丞丂丏七丁丄不.丝世丏丘丐下七业丛())) != true) ? 0 : 2;
    }
    private void 且丌丟业下丙丗丑丗(CW_SilverMineView.世丂下且丟不不业专 丝丄万丐下丐丟丈丆)
    {
        UnityEngine.GameObject val_8;
        PGCompany.世丐下丕专东丘丏且 val_9;
        val_8 = this;
        val_9 = 丝丄万丐下丐丟丈丆.Equals(obj:  0);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_9 != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._taskView, 丏业丟一东丂东丘丛:  false);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._taskView, 丏业丟一东丂东丘丛:  true);
        if(this._taskView != 0)
        {
                val_9 = this.丐丌丞东上万万丈丂.下三下东业丘且丟业();
            UnityEngine.Color val_4 = PGCompany.丂丘丞丂丏七丁丄不.不丝世且丆丐专三丑(丏丆丗丂丟丘丈万万:  0);
            this._taskView.业不丝丄丙丌丌丈丄(万不且且丛丆东丒业:  val_9, 丂万丆七丁且丏丗丂:  new System.Nullable<UnityEngine.Color>() {HasValue = true});
            this._taskView.丝一丅丆三东丂丞七();
        }
        
        this.丁一丕丅丕丒不丆丝(丝丄万丐下丐丟丈丆:  null);
        val_8 = this.myClanTaskProgress;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  (this.丐丌丞东上万万丈丂.业丝丙下七下七下专() != 0) ? 1 : 0);
    }
    private void 丙专上下世丞丟丅东(CW_SilverMineView.世丂下且丟不不业专 丝丄万丐下丐丟丈丆)
    {
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if((丝丄万丐下丐丟丈丆.Equals(obj:  1)) != false)
        {
                if(this.modulesTableUIForEnemy != 0)
        {
                if(this.modulesTableUIForBosses != 0)
        {
            goto label_9;
        }
        
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.containerModuleTables, 丏业丟一东丂东丘丛:  false);
        return;
        label_9:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.containerModuleTables, 丏业丟一东丂东丘丛:  true);
        this.modulesTableUIForEnemy.丙不丑丆丂三三丞下(丐丐丄丞丏丗专丏与:  false);
        this.modulesTableUIForBosses.丙不丑丆丂三三丞下(丐丐丄丞丏丗专丏与:  true);
    }
    private void 丘业东且下东丏丝且(CW_SilverMineView.世丂下且丟不不业专 丝丄万丐下丐丟丈丆)
    {
        UILabel val_17;
        UnityEngine.GameObject val_18;
        UnityEngine.GameObject val_19;
        val_17 = this;
        val_18 = 丝丄万丐下丐丟丈丆.Equals(obj:  2);
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_18 == false)
        {
            goto label_3;
        }
        
        丞丂丘丒丟丞丑下丄 val_5 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.世上东丙丂丐丕丙与().丕丐七丙丕丕丞丒丄(丞丅上丏丂且下丅与:  this.丐丌丞东上万万丈丂.丙丗丏丂业且不东丞());
        val_18 = this._otherClanContainerGo;
        if(val_5 == null)
        {
            goto label_7;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_18, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._otherClanNameLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8981"), arg0:  val_5.东丙上东业丆不丟丘()));
        UnityEngine.Debug.LogError(message:  val_5.上上三七丟丝与丆与().ToString());
        UnityEngine.Debug.LogError(message:  val_5.三丒三丕不七丁丅丈().ToString());
        val_18 = this._powerFortLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_18, 丕丗丘丑丛与丑业丒:  val_5.上上三七丟丝与丆与().ToString());
        val_17 = this._powerTankLabel;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_17, 丕丗丘丑丛与丑业丒:  val_5.三丒三丕不七丁丅丈().ToString());
        return;
        label_3:
        val_17 = this._otherClanContainerGo;
        val_19 = val_17;
        goto label_17;
        label_7:
        val_19 = val_18;
        label_17:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_19, 丏业丟一东丂东丘丛:  false);
    }
    private void 丒丌七且一丒万丈丞(CW_SilverMineView.世丂下且丟不不业专 丝丄万丐下丐丟丈丆)
    {
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if((丝丄万丐下丐丟丈丆.Equals(obj:  0)) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._myClanContainerGo, 丏业丟一东丂东丘丛:  true);
            if(this._myTributeProgress == 0)
        {
                return;
        }
        
            this = this.丐丌丞东上万万丈丂;
            this._myTributeProgress.丈且东丑丂且万丒丅(丌丝万上丅丒一丈丘:  this);
            return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._myClanContainerGo, 丏业丟一东丂东丘丛:  false);
    }
    public void DEV_TaskIncrement()
    {
    
    }
    public void DEV_TaskComplete()
    {
    
    }
    public CW_SilverMineView()
    {
        this.且丟与下七丑丗专业 = "Loading_Siege";
        this.三万丗三丌世丛丞世 = "Loading_raid";
    }

}
