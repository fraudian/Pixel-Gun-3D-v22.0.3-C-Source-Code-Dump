using UnityEngine;
public class ClanWarCellInfoView : MonoBehaviour
{
    // Fields
    private ClanWarCellInfoListView 丟丏丄一世丛丌上七;
    internal ClanWarMap 三专丈丘一专丞不且;
    internal DiscreteVector2 专丘丏丅且丆万东丈;
    private UIWidget selectedWidget;
    private UIWidget notSelectedWidget;
    private float notSelectedAlpha;
    private UnityEngine.Vector3 selectedScale;
    private float alphaLerpParam;
    private UIWidget holder;
    private System.Collections.Generic.List<UIWidget> cellOwnerSprites;
    private System.Collections.Generic.List<UIWidget> myClanColorSprites;
    private UnityEngine.GameObject commonView;
    private CW_TaskView taskView;
    private CW_FortView fortView;
    private CW_VandalsView vandalsView;
    private CW_SilverMineView _silverMineView;
    private UnityEngine.GameObject inDevelopmentView;
    private UnityEngine.GameObject cellFlag;
    private UnityEngine.GameObject cellFlagButtons;
    private UnityEngine.GameObject AddCellFlagButton;
    private UnityEngine.GameObject RemoveCellFlagButton;
    private SimpleBunner maxFlagsCountReached;
    private UnityEngine.GameObject devContainer;
    private UILabel devCellCoord;
    private UILabel devCellId;
    private bool <丞丛丏丛丛不丟业一>k__BackingField;
    
    // Properties
    internal 不上丌世万丁丝丏丆 不上丌世万丁丝丏丆 { get; }
    internal bool 与丆与丂丄丞丒丏丑 { get; set; }
    
    // Methods
    internal 不上丌世万丁丝丏丆 丛丈业丘丏专一丕丐()
    {
        DiscreteVector2 val_4;
        var val_5;
        val_4 = this;
        val_5 = 0;
        if(this.三专丈丘一专丞不且 == 0)
        {
                return (不上丌世万丁丝丏丆)val_5;
        }
        
        if((this.三专丈丘一专丞不且.丒与丂业丆三丞上下.ContainsKey(key:  new DiscreteVector2() {_x = this.专丘丏丅且丆万东丈, _y = this.专丘丏丅且丆万东丈})) != false)
        {
                val_4 = this.专丘丏丅且丆万东丈;
            不上丌世万丁丝丏丆 val_3 = this.三专丈丘一专丞不且.丒与丂业丆三丞上下.Item[new DiscreteVector2() {_x = val_4, _y = val_4}];
            return (不上丌世万丁丝丏丆)val_5;
        }
        
        val_5 = 0;
        return (不上丌世万丁丝丏丆)val_5;
    }
    internal bool 丆世丆东三专东东三()
    {
        return (bool)this.<丞丛丏丛丛不丟业一>k__BackingField;
    }
    internal void 且七丒七与丙与丛丄(bool 丙业与丙丗丝不丈东)
    {
        this.<丞丛丏丛丛不丟业一>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal void 业不丝丄丙丌丌丈丄(ClanWarCellInfoListView 丟丏丄一世丛丌上七, 不上丌世万丁丝丏丆 且丝丑一丐丄丁一与, System.Nullable<bool> 丞丈丌且东丆丅丗万)
    {
        this.丟丏丄一世丛丌上七 = 丟丏丄一世丛丌上七;
        if(且丝丑一丐丄丁一与 != null)
        {
                this.三专丈丘一专丞不且 = 且丝丑一丐丄丁一与.业丈与下丏三丟一且();
        }
        else
        {
                this.三专丈丘一专丞不且 = 0.业丈与下丏三丟一且();
        }
        
        DiscreteVector2 val_3 = 且丝丑一丐丄丁一与.丞丑丟下丘三下专不();
        this.专丘丏丅且丆万东丈 = val_3;
        if((2139935548 & 1) != 0)
        {
                this.<丞丛丏丛丛不丟业一>k__BackingField = false;
        }
        
        this.丝一丅丆三东丂丞七();
        PGCompany.ClanWarProgressController.丈丘业丁七丒丗丌丘(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanWarCellInfoView::且丁专一不与丂业丗(int 丞丅上丏丂且下丅与)));
        PGCompany.ClanWarProgressController.丐与丞丛不丝丐丁万(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanWarCellInfoView::与丂丏丘丝丒且七丐(int 丞丅上丏丂且下丅与)));
        PGCompany.ClanWarController.世与三丅丅丞专丘丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarCellInfoView::不丙丕丕丗丘丘东丟()));
        PGCompany.ClanWarProgressController.丙万丒业丐丌丏且与(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanWarCellInfoView::且丁专一不与丂业丗(int 丞丅上丏丂且下丅与)));
        PGCompany.ClanWarProgressController.万与丁世丁专丛丐丘(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanWarCellInfoView::与丂丏丘丝丒且七丐(int 丞丅上丏丂且下丅与)));
        PGCompany.ClanWarController.丌丈三丒丐丆七丆丅(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarCellInfoView::不丙丕丕丗丘丘东丟()));
    }
    private void 且丁专一不与丂业丗(int 丞丅上丏丂且下丅与)
    {
        if(this.丛丈业丘丏专一丕丐().丗丐东丑丕丞丅丞东() != 1)
        {
                return;
        }
        
        if(this.丛丈业丘丏专一丕丐().丑丂丅丐业丘下东丘().业上丙丞丐丄丆丅七() != 丞丅上丏丂且下丅与)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
    }
    private void 与丂丏丘丝丒且七丐(int 丞丅上丏丂且下丅与)
    {
        if(this.丛丈业丘丏专一丕丐().丗丐东丑丕丞丅丞东() == 3)
        {
                if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丐东业专丑丘丑丗<PGCompany.与丐业一丂丗与七丟>(丟丟丄专上丟丁丐丝:  丞丅上丏丂且下丅与)) != null)
        {
                this.丝一丅丆三东丂丞七();
        }
        
        }
        
        if(this.丛丈业丘丏专一丕丐().丗丐东丑丕丞丅丞东() != 2)
        {
                return;
        }
        
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丌丐东业专丑丘丑丗<PGCompany.一丏不三且丆专东东>(丟丟丄专上丟丁丐丝:  丞丅上丏丂且下丅与)) == null)
        {
                return;
        }
        
        this.丝一丅丆三东丂丞七();
    }
    private void OnEnable()
    {
        this.不丙丕丕丗丘丘东丟();
    }
    private void OnDisable()
    {
        PGCompany.ClanWarProgressController.丈丘业丁七丒丗丌丘(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanWarCellInfoView::且丁专一不与丂业丗(int 丞丅上丏丂且下丅与)));
        PGCompany.ClanWarProgressController.丐与丞丛不丝丐丁万(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void ClanWarCellInfoView::与丂丏丘丝丒且七丐(int 丞丅上丏丂且下丅与)));
        PGCompany.ClanWarController.世与三丅丅丞专丘丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanWarCellInfoView::不丙丕丕丗丘丘东丟()));
    }
    private void 丂上下丟丕东丁丛不()
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 下世丆丅下丄丂七三(int 丟丌丐丘丆丙丑丑一)
    {
        if((丟丌丐丘丆丙丑丑一 & 2147483648) != 0)
        {
                return;
        }
        
        this.holder.height = 丟丌丐丘丆丙丑丑一;
    }
    internal void 丝一丅丆三东丂丞七()
    {
        string val_39;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        CW_TaskView val_48;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.devContainer, 丏业丟一东丂东丘丛:  false);
        this.下世丆丅下丄丂七三(丟丌丐丘丆丙丑丑一:  this.taskView.世万丞丒丈且三与丈());
        this.不丙丕丕丗丘丘东丟();
        if(this.丛丈业丘丏专一丕丐() == null)
        {
            goto label_4;
        }
        
        if(this.丛丈业丘丏专一丕丐().丛七且专丗丒丟丞丈() == false)
        {
            goto label_6;
        }
        
        val_39 = this.丛丈业丘丏专一丕丐().丙丗丏丂业且不东丞();
        UnityEngine.Color val_7 = PGCompany.丂丘丞丂丏七丁丄不.丙业不丘丝一丁丆丏(丄丒下业一不丈丝丘:  val_39, 丏丆丗丂丟丘丈万万:  1);
        goto label_10;
        label_4:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonView, 丏业丟一东丂东丘丛:  false);
        this.taskView.gameObject.SetActive(value:  false);
        this.fortView.gameObject.SetActive(value:  false);
        this.vandalsView.gameObject.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._silverMineView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.inDevelopmentView, 丏业丟一东丂东丘丛:  false);
        return;
        label_6:
        UnityEngine.Color val_11 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "cw-clanui-default");
        label_10:
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(不丏丛上丛丗丆丐丝:  this.cellOwnerSprites, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a});
        UnityEngine.Color val_12 = PGCompany.丂丘丞丂丏七丁丄不.不丝世且丆丐专三丑(丏丆丗丂丟丘丈万万:  1);
        丞东丑专丛丆丄丝世.丒丗丙丙丙丟专丅万(不丏丛上丛丗丆丐丝:  this.myClanColorSprites, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a});
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.taskView.mapTexture, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.taskView.taskTextureObject, 丏业丟一东丂东丘丛:  false);
        PGCompany.丝丂丒专丞与丙丏一 val_14 = this.丛丈业丘丏专一丕丐().丗丐东丑丕丞丅丞东();
        if(val_14 == 3)
        {
            goto label_29;
        }
        
        if(val_14 == 2)
        {
            goto label_30;
        }
        
        if(val_14 != 1)
        {
            goto label_31;
        }
        
        if((this.丛丈业丘丏专一丕丐().下三下东业丘且丟业() == null) || (this.丛丈业丘丏专一丕丐().下三下东业丘且丟业().七一丈丁专丞丛丟丌() == false))
        {
            goto label_36;
        }
        
        不上丌世万丁丝丏丆 val_20 = this.丛丈业丘丏专一丕丐();
        if(val_20 == null)
        {
            goto label_65;
        }
        
        PGCompany.世丐下丕专东丘丏且 val_21 = val_20.下三下东业丘且丟业();
        if(val_21 == null)
        {
            goto label_40;
        }
        
        PGCompany.丟丒丅丐万丈七且万 val_22 = val_21.世丈丁业丛上丘丗丐();
        if((val_22 == null) || (val_22.万丆丄上七丒专且世() == null))
        {
            goto label_40;
        }
        
        val_44 = 0;
        goto label_41;
        label_29:
        val_39 = this.丛丈业丘丏专一丕丐();
        this.vandalsView.下与丞三丅丛丄七丕(丌丝万上丅丒一丈丘:  val_39);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonView, 丏业丟一东丂东丘丛:  true);
        this.taskView.gameObject.SetActive(value:  false);
        this.fortView.gameObject.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._silverMineView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.inDevelopmentView, 丏业丟一东丂东丘丛:  false);
        val_45 = this.vandalsView;
        int val_27 = val_45.世万丞丒丈且三与丈();
        goto label_59;
        label_30:
        val_39 = this.丛丈业丘丏专一丕丐();
        this.fortView.下与丞三丅丛丄七丕(丌丝万上丅丒一丈丘:  val_39);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonView, 丏业丟一东丂东丘丛:  true);
        this.taskView.gameObject.SetActive(value:  false);
        this.vandalsView.gameObject.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._silverMineView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.inDevelopmentView, 丏业丟一东丂东丘丛:  false);
        val_45 = this.fortView;
        int val_31 = val_45.世万丞丒丈且三与丈();
        goto label_59;
        label_31:
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "Show Other Info");
        return;
        label_36:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._silverMineView, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.taskView, 丏业丟一东丂东丘丛:  false);
        val_46 = 0;
        goto label_63;
        label_40:
        val_44 = 0;
        label_41:
        if((val_44.丙东专丂世丈丏丁丂() != 52) || ((2141168280 & 1) == 0))
        {
            goto label_65;
        }
        
        this._silverMineView.下与丞三丅丛丄七丕(丌丝万上丅丒一丈丘:  this.丛丈业丘丏专一丕丐());
        val_47 = null;
        val_48 = this.taskView;
        goto label_71;
        label_65:
        this.taskView.下与丞三丅丛丄七丕(丌丝万上丅丒一丈丘:  this.丛丈业丘丏专一丕丐());
        val_47 = null;
        val_48 = this._silverMineView;
        label_71:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_48, 丏业丟一东丂东丘丛:  false);
        val_46 = 1;
        label_63:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.commonView, 丏业丟一东丂东丘丛:  true);
        this.fortView.gameObject.SetActive(value:  false);
        val_39 = this.vandalsView.gameObject;
        val_39.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.inDevelopmentView, 丏业丟一东丂东丘丛:  (val_46 == 0) ? 1 : 0);
        val_45 = this.taskView;
        label_59:
        this.下世丆丅下丄丂七三(丟丌丐丘丆丙丑丑一:  val_45.世万丞丒丈且三与丈());
    }
    private void 不丙丕丕丗丘丘东丟()
    {
        UnityEngine.GameObject val_17;
        var val_18;
        if(((this.丛丈业丘丏专一丕丐() != null) && (this.丛丈业丘丏专一丕丐().丑丂丅丐业丘下东丘() != null)) && (this.丛丈业丘丏专一丕丐().丂丝三不丅丙丄三丑() != true))
        {
                if(this.丛丈业丘丏专一丕丐().丗丐东丑丕丞丅丞东() != 2)
        {
                if(this.丛丈业丘丏专一丕丐().丗丐东丑丕丞丅丞东() != 3)
        {
            goto label_9;
        }
        
        }
        
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cellFlag, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.cellFlagButtons, 丏业丟一东丂东丘丛:  false);
        return;
        label_9:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.cellFlagButtons, 丏业丟一东丂东丘丛:  PGCompany.丂丘丞丂丏七丁丄不.三丙下丕专专丐三东());
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丐丘丅丑一丄专丞上(丝丌不东丕丒与丒丅:  this.丛丈业丘丏专一丕丐().丑丂丅丐业丘下东丘().业上丙丞丐丄丆丅七())) != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cellFlag, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.RemoveCellFlagButton, 丏业丟一东丂东丘丛:  true);
            val_17 = this.AddCellFlagButton;
            val_18 = 0;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.cellFlag, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.RemoveCellFlagButton, 丏业丟一东丂东丘丛:  false);
            val_17 = this.AddCellFlagButton;
            val_18 = 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_17, 丏业丟一东丂东丘丛:  true);
    }
    public void AddCellFlagButtonPressed()
    {
        if(this.丛丈业丘丏专一丕丐() == null)
        {
                return;
        }
        
        if(this.丛丈业丘丏专一丕丐().丑丂丅丐业丘下东丘() == null)
        {
                return;
        }
        
        if(PGCompany.丂丘丞丂丏七丁丄不.三丙下丕专专丐三东() == false)
        {
                return;
        }
        
        if(((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丄丆三丆与丏专上与()) != false) && (this.maxFlagsCountReached != 0))
        {
                this = ???;
        }
        else
        {
                Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丅丞丝一丑不丘世不(丝丌不东丕丒与丒丅:  this.丛丈业丘丏专一丕丐().丑丂丅丐业丘下东丘().业上丙丞丐丄丆丅七());
        }
    
    }
    public void RemoveCellFlagButtonPressed()
    {
        if(this.丛丈业丘丏专一丕丐() == null)
        {
                return;
        }
        
        if(this.丛丈业丘丏专一丕丐().丑丂丅丐业丘下东丘() == null)
        {
                return;
        }
        
        if(PGCompany.丂丘丞丂丏七丁丄不.三丙下丕专专丐三东() == false)
        {
                return;
        }
        
        Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丕丁丁丟丒业丄七一(丝丌不东丕丒与丒丅:  this.丛丈业丘丏专一丕丐().丑丂丅丐业丘下东丘().业上丙丞丐丄丆丅七());
    }
    public void OnClick()
    {
        if(this.丟丏丄一世丛丌上七 == 0)
        {
                return;
        }
        
        if(this.丛丈业丘丏专一丕丐() == null)
        {
                return;
        }
        
        this.丟丏丄一世丛丌上七.丞下丆丂丑业丆专丙(丞三七世万不不丞七:  this, 世世丗一丗东与上丏:  true);
        bool val_3 = this.丟丏丄一世丛丌上七.clanWarMap.七丞万丅一丄丛丛丝(业丄世世一世三与丝:  new System.Nullable<DiscreteVector2>() {HasValue = false});
    }
    private void Update()
    {
        var val_26;
        float val_29;
        float val_31;
        float val_32;
        float val_33;
        if(this.selectedWidget == 0)
        {
                return;
        }
        
        if(this.notSelectedWidget == 0)
        {
                return;
        }
        
        float val_3 = UnityEngine.Time.deltaTime;
        if((this.<丞丛丏丛丛不丟业一>k__BackingField) != false)
        {
                float val_8 = UnityEngine.Mathf.Lerp(a:  UnityEngine.Mathf.Lerp(a:  V0.16B, b:  1f, t:  val_3 * this.alphaLerpParam), b:  0f, t:  UnityEngine.Time.deltaTime * this.alphaLerpParam);
            val_26 = this.holder.transform;
            UnityEngine.Vector3 val_11 = this.holder.transform.localScale;
            float val_13 = UnityEngine.Time.deltaTime * this.alphaLerpParam;
            val_31 = val_11.x;
            val_32 = val_11.y;
            val_33 = val_11.z;
        }
        else
        {
                float val_18 = UnityEngine.Mathf.Lerp(a:  UnityEngine.Mathf.Lerp(a:  V0.16B, b:  0f, t:  val_3 * this.alphaLerpParam), b:  this.notSelectedAlpha, t:  UnityEngine.Time.deltaTime * this.alphaLerpParam);
            val_26 = this.holder.transform;
            UnityEngine.Vector3 val_21 = this.holder.transform.localScale;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.one;
            val_29 = val_22.y;
            val_33 = val_21.z;
            val_31 = val_21.x;
            val_32 = val_21.y;
        }
        
        UnityEngine.Vector3 val_25 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_31, y = val_32, z = val_33}, b:  new UnityEngine.Vector3() {x = val_22.x, y = val_29, z = val_22.z}, t:  UnityEngine.Time.deltaTime * this.alphaLerpParam);
        val_26.localScale = new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z};
    }
    public void DEV_TaskIncrement()
    {
    
    }
    public void DEV_TaskComplete()
    {
    
    }
    public ClanWarCellInfoView()
    {
        this.notSelectedAlpha = 0.6f;
        this.selectedScale = 0;
        mem[1152921536814394908] = 0;
        this.alphaLerpParam = 4f;
    }

}
