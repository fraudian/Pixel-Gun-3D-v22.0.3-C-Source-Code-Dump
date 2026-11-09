using UnityEngine;
internal sealed class ExpProgressUi : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject _defaultContainer;
    private UILabel _defaultLevelLabel;
    private SimpleProgressBarWithAnimation _defaultProgressBar;
    private UnityEngine.GameObject _maxLevelContainer;
    private UILabel _maxLeveltLevelLabel;
    private SimpleProgressBarWithAnimation _maxLevelProgressBar;
    private UIBasicSprite _maxLevelRewardTexture;
    private UnityEngine.GameObject _levelUpContainer;
    private UnityEngine.GameObject _pointNewLevelContainer;
    private ProgressRoadPointNewContentView _pointContentView;
    private ProgressRoadPointRewardsView _pointRewardsView;
    
    // Properties
    private int 丏万业丑上三丌丏丐 { get; set; }
    private int 丌业丐丗丑丛下丝业 { get; set; }
    
    // Methods
    private void Awake()
    {
        this.东一丗专上万丒东丛();
    }
    private void OnEnable()
    {
        this.丈且东丑丂且万丒丅();
        ExperienceController.丈丌专丑丂丁三丌丑(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ExpProgressUi::丈且东丑丂且万丒丅()));
        ExpController.一丈与丒丘下七丛丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ExpProgressUi::丈且东丑丂且万丒丅()));
    }
    private void OnDisable()
    {
        ExperienceController.万专丙丝东丈丗与丏(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ExpProgressUi::丈且东丑丂且万丒丅()));
        ExpController.丄丂一丛丅丄丄丘且(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ExpProgressUi::丈且东丑丂且万丒丅()));
        this.三东丆丘丐丙丐丕丑();
    }
    private void Update()
    {
        if(PGCompany.丁东丌世与丕东丆上.上丘丈专丝丞与丏丐() != false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._defaultContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._maxLevelContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._levelUpContainer, 丏业丟一东丂东丘丛:  false);
    }
    private void 丈且东丑丂且万丒丅()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._defaultContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._maxLevelContainer, 丏业丟一东丂东丘丛:  false);
        if(this._maxLevelContainer.上且丘丐丈下与丆丅() == 65)
        {
                this.业七世世丂丅丙丛世();
            return;
        }
        
        this.丛丗且上三且丟业下();
    }
    private void 东一丗专上万丒东丛()
    {
        var val_10;
        if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  147)) != true)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  147, 丙业与丙丗丝不丈东:  ExperienceController.丞丞丘业东丙丏七丌());
        }
        
        val_10 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
        if((val_10.丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  148)) == true)
        {
                return;
        }
        
        val_10 = Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙();
        val_10.丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  148, 丙业与丙丗丝不丈东:  ExperienceController.丂丂下丑且下丌丝东());
    }
    private int 上且丘丐丈下与丆丅()
    {
        Progress.丘东丅丌东丒上七丁 val_1 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
        if(val_1 != null)
        {
                return val_1.丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  147);
        }
        
        return val_1.丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  147);
    }
    private void 丌丆一一丝万丞丅丅(int 丙业与丙丗丝不丈东)
    {
        int val_6 = 丙业与丙丗丝不丈东;
        if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  147)) != false)
        {
                if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  147)) == val_6)
        {
                return;
        }
        
        }
        
        val_6 = val_6;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  147, 丙业与丙丗丝不丈东:  val_6 = 丙业与丙丗丝不丈东);
    }
    private int 丛专丟丑丂丏丛专丒()
    {
        Progress.丘东丅丌东丒上七丁 val_1 = Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂();
        if(val_1 != null)
        {
                return val_1.丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  148);
        }
        
        return val_1.丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  148);
    }
    private void 丞东不世专世丏丘丘(int 丙业与丙丗丝不丈东)
    {
        int val_6 = 丙业与丙丗丝不丈东;
        if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丟不下下且业丛丄丏(下上丐丆丝丟丝丒不:  148)) != false)
        {
                if((Progress.七七世万专丕丁上业.丏丘丏丅丅世丁丏丂().丌丌万丝丁丌世业丌(下上丐丆丝丟丝丒不:  148)) == val_6)
        {
                return;
        }
        
        }
        
        val_6 = val_6;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  148, 丙业与丙丗丝不丈东:  val_6 = 丙业与丙丗丝不丈东);
    }
    private void 丛丗且上三且丟业下()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._defaultContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._defaultLevelLabel, 丕丗丘丑丛与丑业丒:  this._defaultContainer.上且丘丐丈下与丆丅());
        this.东丌丈丂丟丂丝丙下();
        this.七丐上丁与业丝三三(丏丌专丕丐丈丏七三:  this._defaultProgressBar);
    }
    private void 东丌丈丂丟丂丝丙下()
    {
        int val_10;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._pointNewLevelContainer, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._pointContentView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._pointRewardsView, 丏业丟一东丂东丘丛:  false);
        val_10 = ExperienceController.丂丂下丑且下丌丝东();
        ProgressRoad.丅丂丅丕下丑丘万一 val_3 = ProgressRoad.丁丒丛丆与七丟丗丙.丑七不且上丗丁一世().丒丟下下不丁专且丅(上丕丈丞丌丘丅不与:  val_10);
        if(val_3 == null)
        {
                return;
        }
        
        if(val_3.且不专丝丝丐丗丑世() == 0)
        {
            goto label_7;
        }
        
        if(val_3.丕丁丅业世上丁丘丆.Count < 1)
        {
            goto label_9;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._pointContentView, 丏业丟一东丂东丘丛:  true);
        val_10 = this._pointContentView;
        if(val_10 == 0)
        {
                return;
        }
        
        this._pointContentView.丈且东丑丂且万丒丅(东东丗丅与一下丄丈:  val_3, 丕丕世且下一与丝与:  0f);
        return;
        label_7:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._pointNewLevelContainer, 丏业丟一东丂东丘丛:  true);
        return;
        label_9:
        val_10 = val_3.下丐丐丁与丂下世七;
        if(val_10.Count < 1)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._pointRewardsView, 丏业丟一东丂东丘丛:  true);
        val_10 = this._pointRewardsView;
        if(val_10 == 0)
        {
                return;
        }
        
        this._pointRewardsView.丈且东丑丂且万丒丅(东东丗丅与一下丄丈:  val_3);
    }
    private void 业七世世丂丅丙丛世()
    {
        UnityEngine.Texture val_8;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._maxLevelContainer, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._maxLeveltLevelLabel, 丕丗丘丑丛与丑业丒:  this._maxLevelContainer.上且丘丐丈下与丆丅());
        this.七丐上丁与业丝三三(丏丌专丕丐丈丏七三:  this._maxLevelProgressBar);
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_3 = ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().丐丕丅丘万丞七丐上();
        if(val_3.Count == 0)
        {
            goto label_8;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_7 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_3.Item[0]);
        if(val_7 == null)
        {
            goto label_8;
        }
        
        val_8 = val_7;
        goto label_9;
        label_8:
        val_8 = 0;
        label_9:
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this._maxLevelRewardTexture, 与万丆丛丒万丝丙丑:  val_8);
    }
    private ExpProgressUi.下丟丝世丕七丆丄丄 丌丕与丂丟丑上丐丒()
    {
        int val_18;
        int val_20;
        var val_21;
        var val_22;
        var val_23;
        if(this.上且丘丐丈下与丆丅() <= 64)
        {
            goto label_1;
        }
        
        ExpOpenSystem.丌下上业与且丁丄三 val_2 = ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世();
        if(val_2.世丂上丌丞且丁七丏 == null)
        {
            goto label_3;
        }
        
        val_18 = val_2.世丂上丌丞且丁七丏.MaxLevelRewardExp;
        goto label_4;
        label_1:
        ProgressRoad.丅丂丅丕下丑丘万一 val_5 = ProgressRoad.丁丒丛丆与七丟丗丙.丑七不且上丗丁一世().丗丐丛与丌丏与与专(上丕丈丞丌丘丅不与:  ExperienceController.丂丂下丑且下丌丝东());
        val_20 = ExperienceController.丂丂下丑且下丌丝东();
        if(val_5 == null)
        {
            goto label_8;
        }
        
        val_18 = val_5.丞东上丘丌丈七且丅();
        val_21 = val_5.丞东上丘丌丈七且丅();
        val_22 = val_5.业丑丁丆丕丆丂丅万();
        return new 下丟丝世丕七丆丄丄() {三丑丛丄万丟丄丞丁 = val_20, 丘丕丈丘三下一丗与 = val_18, 万丄丕丑丕丝七丝丛 = val_21 - val_22, 不丂且丙东业七业三 = val_5.业丑丁丆丕丆丂丅万()};
        label_3:
        val_18 = 2147483647;
        label_4:
        val_20 = System.Math.Min(val1:  ExpOpenSystem.丌下上业与且丁丄三.丑七不且上丗丁一世().丅丂七上一业一丐三(), val2:  2147483647);
        val_23 = val_18;
        return new 下丟丝世丕七丆丄丄() {三丑丛丄万丟丄丞丁 = val_20, 丘丕丈丘三下一丗与 = val_18, 万丄丕丑丕丝七丝丛 = val_21 - val_22, 不丂且丙东业七业三 = val_5.业丑丁丆丕丆丂丅万()};
        label_8:
        val_18 = 0.丞东上丘丌丈七且丅();
        val_21 = 0.丞东上丘丌丈七且丅();
        val_22 = 0.业丑丁丆丕丆丂丅万();
        return new 下丟丝世丕七丆丄丄() {三丑丛丄万丟丄丞丁 = val_20, 丘丕丈丘三下一丗与 = val_18, 万丄丕丑丕丝七丝丛 = val_21 - val_22, 不丂且丙东业七业三 = val_5.业丑丁丆丕丆丂丅万()};
    }
    private void 七丐上丁与业丝三三(SimpleProgressBarWithAnimation 丏丌专丕丐丈丏七三)
    {
        var val_11;
        var val_12;
        ExpProgressUi.下丟丝世丕七丆丄丄 val_13;
        int val_16;
        IntPtr val_18;
        .丝且与丝丒丟万丁专 = this;
        if(丏丌专丕丐丈丏七三 == 0)
        {
                return;
        }
        
        if(丏丌专丕丐丈丏七三 != null)
        {
                val_11 = 丏丌专丕丐丈丏七三;
            val_12 = 0;
            val_11.三一丞丗七专丑丐且();
        }
        else
        {
                val_12 = 0;
            0.三一丞丗七专丑丐且();
            val_11 = 0;
        }
        
        丏丌专丕丐丈丏七三.万万丗丛丏丐七丘丏 = 0;
        下丟丝世丕七丆丄丄 val_3 = this.丌丕与丂丟丑上丐丒();
        .上丕丈丞丌丘丅不与 = val_3.三丑丛丄万丟丄丞丁;
        mem[1152921537210291152] = val_3.万丄丕丑丕丝七丝丛;
        mem[1152921537210291156] = val_3.不丂且丙东业七业三;
        int val_5 = ExperienceController.丞丞丘业东丙丏七丌();
        if(val_3.三丑丛丄万丟丄丞丁.上且丘丐丈下与丆丅() < val_5)
        {
                下丟丝世丕七丆丄丄 val_6 = val_5.丌丕与丂丟丑上丐丒();
            .上丕丈丞丌丘丅不与 = val_6.三丑丛丄万丟丄丞丁;
            mem[1152921537210291152] = val_6.万丄丕丑丕丝七丝丛;
            mem[1152921537210291156] = val_6.不丂且丙东业七业三;
            val_16 = val_6.三丑丛丄万丟丄丞丁.丛专丟丑丂丏丛专丒();
            val_18 = 1152921537210224880;
        }
        else
        {
                val_13 = (ExpProgressUi.丘丞三且东万丕丙丂)[1152921537210291120].上丕丈丞丌丘丅不与;
            val_16 = val_5.丛专丟丑丂丏丛专丒().丛专丟丑丂丏丛专丒();
            System.Action val_10 = null;
            val_18 = 1152921537210230000;
        }
        
        val_10 = new System.Action(object:  new ExpProgressUi.丘丞三且东万丕丙丂(), method:  val_18);
        val_10.七丐上丁与业丝三三(丏丌专丕丐丈丏七三:  丏丌专丕丐丈丏七三, 丄且一丄丏丆丐丗与:  val_16, 丑丒丒丅七丞东丟丕:  val_13, 七丝东丛东丝且丆不:  W22, 丙丗丗丞一丟丟丄业:  W23, 丟丌丆七丘七一三丛:  val_10);
    }
    private void 七丐上丁与业丝三三(SimpleProgressBarWithAnimation 丏丌专丕丐丈丏七三, int 丄且一丄丏丆丐丗与, int 丑丒丒丅七丞东丟丕, int 七丝东丛东丝且丆不, int 丙丗丗丞一丟丟丄业, System.Action 丟丌丆七丘七一三丛)
    {
        if(丏丌专丕丐丈丏七三 != null)
        {
                丏丌专丕丐丈丏七三.initialValue = 丙丗丗丞一丟丟丄业;
            丏丌专丕丐丈丏七三.万万丗丛丏丐七丘丏 = 丟丌丆七丘七一三丛;
        }
        else
        {
                mem[80] = 丙丗丗丞一丟丟丄业;
            mem[224] = 丟丌丆七丘七一三丛;
        }
        
        丏丌专丕丐丈丏七三.丈且东丑丂且万丒丅(丄且一丄丏丆丐丗与:  丄且一丄丏丆丐丗与 - 丙丗丗丞一丟丟丄业, 丑丒丒丅七丞东丟丕:  丑丒丒丅七丞东丟丕 - 丙丗丗丞一丟丟丄业, 七丝东丛东丝且丆不:  七丝东丛东丝且丆不, 丈世万丙丟东与丕丞:  true);
    }
    private void 三东丆丘丐丙丐丕丑()
    {
        SimpleProgressBarWithAnimation val_5;
        var val_6;
        val_5 = this;
        val_6 = null;
        int val_1 = ExperienceController.丞丞丘业东丙丏七丌();
        val_1.丌丆一一丝万丞丅丅(丙业与丙丗丝不丈东:  val_1);
        下丟丝世丕七丆丄丄 val_2 = val_1.丌丕与丂丟丑上丐丒();
        val_2.三丑丛丄万丟丄丞丁.丞东不世专世丏丘丘(丙业与丙丗丝不丈东:  val_2.三丑丛丄万丟丄丞丁);
        if(this._defaultProgressBar != 0)
        {
                this._defaultProgressBar.三一丞丗七专丑丐且();
            this._defaultProgressBar.万万丗丛丏丐七丘丏 = 0;
        }
        
        if(this._maxLevelProgressBar == 0)
        {
                return;
        }
        
        this._maxLevelProgressBar.三一丞丗七专丑丐且();
        val_5 = this._maxLevelProgressBar;
        this._maxLevelProgressBar.万万丗丛丏丐七丘丏 = 0;
    }
    public void U_Click()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        UnityEngine.Object val_16;
        var val_17;
        val_12 = static_value_081DACA8;
        val_12 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16) != 0)
        {
                val_13 = static_value_081DACA8;
            val_13 = static_value_081DACA8;
            if((static_value_081DACA8 + 184 + 16 + 384) != 0)
        {
                val_14 = static_value_081DACA8;
            val_14 = static_value_081DACA8;
            if((static_value_081DACA8 + 184 + 16 + 384 + 24) != 0)
        {
                val_15 = static_value_081DACA8;
            val_15 = static_value_081DACA8;
            val_16 = static_value_081DACA8 + 184 + 16 + 384 + 24.gameObject;
            if(val_16.activeSelf == true)
        {
                return;
        }
        
        }
        
        }
        
        }
        
        val_16 = GameController.丑七不且上丗丁一世();
        if(val_16 != 0)
        {
                return;
        }
        
        if(丏丟丏丅丙业丆下专.专业丄丏丂丌丁世且() == true)
        {
                return;
        }
        
        if(ProgressRoad.丁丒丛丆与七丟丗丙.丕三丂丄三丁丛丘世() != false)
        {
                return;
        }
        
        val_17 = null;
        if(ExperienceController.丞丞丘业东丙丏七丌() >= 65)
        {
                if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() == true)
        {
                return;
        }
        
        }
        
        ProgressRoad.丁丒丛丆与七丟丗丙.丄丄业世业丈丒丁万(丂世且丙丅丘不七丑:  0, 丏丆丅且上丅上丌丘:  0, 丘丒丅三丞丞丛丛丌:  0);
    }
    public ExpProgressUi()
    {
    
    }

}
