using UnityEngine;
public class CharacterSelectionView : MonoBehaviour
{
    // Fields
    private CharacterInterfaceV2 _character;
    private UILabel[] _levelLabel;
    private UILabel[] _nameLabel;
    private UILabel[] _clanNameLabel;
    private UITexture[] _clanTexture;
    private UILabel[] _coinsLabel;
    private UILabel[] _gemsLabel;
    private UILabel _needLevelLabel;
    private UILabel[] _createCharacterPriceLabel;
    private UILabel[] _createCharacterRealPriceLabel;
    private UILabel[] _buyStateLabel;
    private UnityEngine.GameObject _selectedState;
    private UnityEngine.GameObject _loadingState;
    private UnityEngine.GameObject _loadedState;
    private UnityEngine.GameObject _emptyState;
    private UnityEngine.GameObject _lockedState;
    private UnityEngine.GameObject _unlockedState;
    private System.Collections.Generic.List<UnityEngine.GameObject> _currencyPriceButton;
    private UnityEngine.GameObject[] _realPriceButton;
    private UnityEngine.GameObject[] _currencyPriceDisabledButton;
    private UnityEngine.GameObject[] _realPriceDisabledButton;
    private string 丏世丑万世一七丟丞;
    private string 七世丐丗丅丞丏丁丁;
    private static UnityEngine.Color 东万东一丞丌丌丐丒;
    private static UnityEngine.Color 且不业七丄丂世且一;
    private static UnityEngine.Color 丅专丕且三下丙丟丟;
    private UnityEngine.Texture2D 丑丄丅丟丙丛丒丑丅;
    private string 丌丕世丞丈丒丞丈丟;
    private string 不丙丌七丄上丛三七;
    private UnityEngine.Color 丂丄一丗业丗丐万丏;
    private bool 丂不丗丄丂丒丛丁上;
    private UnityEngine.Coroutine 丛丟专丆专丁丄丏丘;
    private SelectableButton 丂丑丏下且丕丛东上;
    private int <丁万丌丆七与丛丘丗>k__BackingField;
    private UnityEngine.Transform <丅且东不下丆丏丛丑>k__BackingField;
    private UnityEngine.GameObject <三丑丏丄丙丛万业不>k__BackingField;
    
    // Properties
    internal SelectableButton 丑丆三丐下丛丑丆丞 { get; }
    internal int 上丞且且丁丘丑丝丁 { get; set; }
    internal UnityEngine.Transform 丛丁一丑丆丞丛丂丆 { get; set; }
    internal UnityEngine.GameObject 丈下丘三业万丕丐丟 { get; set; }
    internal string 下丄丈不与世丐业专 { get; }
    internal string 三且丞七丗东不丘丝 { get; }
    
    // Methods
    internal SelectableButton 丄丐与万丄丑丏丆东()
    {
        SelectableButton val_3;
        if(this.丂丑丏下且丕丛东上 == 0)
        {
                this.丂丑丏下且丕丛东上 = this.GetComponent<SelectableButton>();
            return val_3;
        }
        
        val_3 = this.丂丑丏下且丕丛东上;
        return val_3;
    }
    internal int 丁丅世丈丈丞丛世丄()
    {
        return (int)this.<丁万丌丆七与丛丘丗>k__BackingField;
    }
    internal void 丘丒丄下丝丑丆丄一(int 丙业与丙丗丝不丈东)
    {
        this.<丁万丌丆七与丛丘丗>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal UnityEngine.Transform 不丞丒专且丘丝丗万()
    {
        return (UnityEngine.Transform)this.<丅且东不下丆丏丛丑>k__BackingField;
    }
    internal void 不丁东七丁丘丙一丗(UnityEngine.Transform 丙业与丙丗丝不丈东)
    {
        this.<丅且东不下丆丏丛丑>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal UnityEngine.GameObject 业丆丞七丈丏东下七()
    {
        return (UnityEngine.GameObject)this.<三丑丏丄丙丛万业不>k__BackingField;
    }
    internal void 丝丕丗一世丁丈丙丌(UnityEngine.GameObject 丙业与丙丗丝不丈东)
    {
        this.<三丑丏丄丙丛万业不>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal string 业上丙丞丐丄丆丅七()
    {
        return (string)this.丏世丑万世一七丟丞;
    }
    internal string 丛三七丙专丙三丌万()
    {
        return (string)this.七世丐丗丅丞丏丁丁;
    }
    private void OnEnable()
    {
        SelectableButton val_1 = this.丄丐与万丄丑丏丆东();
        val_1.selectableButtonController.add_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CharacterSelectionView::业丟专下与下一丝丄()));
        this.业丘三一丘丂不东七();
        this.东丁丛三丝一丙七丄();
    }
    private void OnDisable()
    {
        SelectableButton val_1 = this.丄丐与万丄丑丏丆东();
        val_1.selectableButtonController.remove_onSelect(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void CharacterSelectionView::业丟专下与下一丝丄()));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._character, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.<三丑丏丄丙丛万业不>k__BackingField, 丏业丟一东丂东丘丛:  false);
    }
    internal void 丟业三丟丌丘万世不()
    {
        var val_23;
        System.Action<UITexture> val_25;
        var val_26;
        var val_27;
        var val_28;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._nameLabel, 丕丗丘丑丛与丑业丒:  Progress.七七世万专丕丁上业.丒丛上上丑丁业丅下().与与丌万丟丄丌丘三());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._levelLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5726"), arg0:  ExperienceController.丞丞丘业东丙丏七丌().ToString()));
        if((Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟()) != null)
        {
                string val_11 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟().东丙上东业丆不丟丘();
        }
        
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._clanNameLabel, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6504"));
        val_23 = null;
        val_23 = null;
        val_25 = CharacterSelectionView.<>c.<>9__53_0;
        if(val_25 == null)
        {
                System.Action<UITexture> val_13 = null;
            val_25 = val_13;
            val_13 = new System.Action<UITexture>(object:  CharacterSelectionView.<>c.__il2cppRuntimeField_static_fields, method:  System.Void CharacterSelectionView.<>c::丗丂丝丗丏万丑丈丕(UITexture 三丟东丕丄丄下下丑));
            CharacterSelectionView.<>c.<>9__53_0 = val_25;
        }
        
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UITexture>(丌丛丏业世丄丞三丌:  this._clanTexture, 七丐丅专且专七三丆:  val_13);
        val_26 = null;
        val_26 = null;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._coinsLabel, 丕丗丘丑丛与丑业丒:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  与丂丏丛丞丞丒丟丄.丕丁丙与丙丝丞上丄));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._gemsLabel, 丕丗丘丑丛与丑业丒:  Progress.七七世万专丕丁上业.丈丝一丑与丝丂七丘().丏丒丆丌七丞三丈专(东丒丄与业丞丂丗且:  与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝));
        val_27 = null;
        val_27 = null;
        this.丑丄丅丟丙丛丒丑丅 = SkinsController.丌与世丂丘且下丒丑;
        val_28 = null;
        val_28 = null;
        三丈丟与丏丘丈丐万 val_19 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
        this.丌丕世丞丈丒丞丈丟 = val_19.三丐三丞丘丕不丒专.与不丞丑七丘丁丂丛();
        this.不丙丌七丄上丛三七 = 丛且丗丌丏下七下丈.业且不丂东丄一丁丈();
        this.东丁丛三丝一丙七丄();
    }
    internal void 丞丈丂丒丕丗丅丑丆(丙与不与七丌丟上东 世丟丈丏丕万丝丆万, System.Collections.Generic.Dictionary<string, object> 丛丏万丙与三丕丙东)
    {
        CharacterSelectionView.丛丄丁业且世丝丂丅 val_1 = new CharacterSelectionView.丛丄丁业且世丝丂丅();
        Progress.业丝与丁丞丑不世丙 val_2 = Progress.不丗丕万上万丟与专.丙丁丒世丆丆丄丈丞(丆丁且东业丝丌丞丞:  丛丏万丙与三丕丙东);
        if(val_1 == null)
        {
            goto label_3;
        }
        
        .一丐丗丁丞丆丅丟丄 = val_2;
        if(val_2 != null)
        {
            goto label_21;
        }
        
        label_22:
        label_21:
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._nameLabel, 丕丗丘丑丛与丑业丒:  val_2.丌专万丘丄丙丒丂丈);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._levelLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5726"), arg0:  System.Math.Max(val1:  val_2.万丄丅丛下丐丒丞上, val2:  1)));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._clanNameLabel, 丕丗丘丑丛与丑业丒:  val_2.与丑丁万丈下七下丙);
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<UITexture>(丌丛丏业世丄丞三丌:  this._clanTexture, 七丐丅专且专七三丆:  new System.Action<UITexture>(object:  val_1, method:  System.Void CharacterSelectionView.丛丄丁业且世丝丂丅::丆丆东东丕丈且丐丅(UITexture 三丟东丕丄丄下下丑)));
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._coinsLabel, 丕丗丘丑丛与丑业丒:  val_2.丕丁丙与丙丝丞上丄.ToString());
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._gemsLabel, 丕丗丘丑丛与丑业丒:  val_2.丐世丑丈丟丏专专丝.ToString());
        if(世丟丈丏丕万丝丆万 == null)
        {
            goto label_19;
        }
        
        this.丏世丑万世一七丟丞 = 世丟丈丏丕万丝丆万.丞丈业东专丅丆与七();
        goto label_20;
        label_3:
        mem[16] = val_2;
        if(mem[16] != 0)
        {
            goto label_21;
        }
        
        goto label_22;
        label_19:
        this.丏世丑万世一七丟丞 = 0.丞丈业东专丅丆与七();
        label_20:
        this.七世丐丗丅丞丏丁丁 = 世丟丈丏丕万丝丆万.丂丛专三丏专丗丅世();
        this.丑丄丅丟丙丛丒丑丅 = val_2.丗业丕丛丟一东丘丒;
        this.丌丕世丞丈丒丞丈丟 = val_2.丝丞丂丄不且三丑专;
        this.不丙丌七丄上丛三七 = val_2.七丝丒丐下业丙三丞;
        this.东丁丛三丝一丙七丄();
    }
    internal void 丏丏不丕丝丑万丆丌()
    {
        this.丆三丆丐丘丕丕丟丅();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._loadedState, 丏业丟一东丂东丘丛:  true);
    }
    internal void 丞不三世业丌万丕丁()
    {
        this.丆三丆丐丘丕丕丟丅();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._loadingState, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Color val_1 = UnityEngine.Color.white;
        this.丂丄一丗业丗丐万丏 = val_1;
        mem[1152921539494977980] = val_1.g;
        mem[1152921539494977984] = val_1.b;
        mem[1152921539494977988] = val_1.a;
    }
    internal void 丛丂丟万万业与与不(丈丞丕丘丕丗与上一 丙丙且丘丌且丏丞丏, int 丝世不丑不与丅丟七, int 丘丄丘丆丌丆丛丝丄)
    {
        UILabel[] val_5;
        var val_6;
        val_5 = 丙丙且丘丌且丏丞丏;
        this.丆三丆丐丘丕丕丟丅();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockedState, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this._needLevelLabel, 丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7536"), arg0:  丘丄丘丆丌丆丛丝丄));
        if(val_5 != null)
        {
                丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._currencyPriceButton, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._currencyPriceDisabledButton, 丏业丟一东丂东丘丛:  true);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._createCharacterPriceLabel, 丕丗丘丑丛与丑业丒:  val_5.丟丂丞不专丆万丒世());
        }
        else
        {
                if(丝世不丑不与丅丟七 >= 1)
        {
                丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._realPriceButton, 丏业丟一东丂东丘丛:  false);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._realPriceDisabledButton, 丏业丟一东丂东丘丛:  true);
            val_5 = this._createCharacterRealPriceLabel;
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_5, 丕丗丘丑丛与丑业丒:  this._realPriceDisabledButton.丑世丑丌专与丄业上(丝世不丑不与丅丟七:  丝世不丑不与丅丟七));
        }
        
        }
        
        this.丂不丗丄丂丒丛丁上 = true;
        val_6 = null;
        val_6 = null;
        this.丂丄一丗业丗丐万丏 = CharacterSelectionView.东万东一丞丌丌丐丒;
        mem[1152921539495315356] = CharacterSelectionView.东万东一丞丌丌丐丒.__il2cppRuntimeField_4;
        mem[1152921539495315364] = CharacterSelectionView.东万东一丞丌丌丐丒.__il2cppRuntimeField_C;
        this.东丁丛三丝一丙七丄();
    }
    internal void 丞下丞丝世万丕东丐(丈丞丕丘丕丗与上一 丙丙且丘丌且丏丞丏, int 丝世不丑不与丅丟七, bool 一丅丒丞丛丏东丌丘)
    {
        int val_9;
        var val_10;
        val_9 = 丝世不丑不与丅丟七;
        this.丆三丆丐丘丕丕丟丅();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unlockedState, 丏业丟一东丂东丘丛:  true);
        if(val_9 <= 0)
        {
                if(丙丙且丘丌且丏丞丏 == null)
        {
                return;
        }
        
        }
        
        if(丙丙且丘丌且丏丞丏 != null)
        {
                丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._currencyPriceButton, 丏业丟一东丂东丘丛:  一丅丒丞丛丏东丌丘);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._currencyPriceDisabledButton, 丏业丟一东丂东丘丛:  (~一丅丒丞丛丏东丌丘) & 1);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._createCharacterPriceLabel, 丕丗丘丑丛与丑业丒:  丙丙且丘丌且丏丞丏.丟丂丞不专丆万丒世());
        }
        else
        {
                if(val_9 >= 1)
        {
                丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._realPriceButton, 丏业丟一东丂东丘丛:  一丅丒丞丛丏东丌丘);
            丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._realPriceDisabledButton, 丏业丟一东丂东丘丛:  (~一丅丒丞丛丏东丌丘) & 1);
            丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this._createCharacterRealPriceLabel, 丕丗丘丑丛与丑业丒:  this._realPriceDisabledButton.丑世丑丌专与丄业上(丝世不丑不与丅丟七:  val_9));
        }
        
        }
        
        val_9 = this._buyStateLabel;
        if(一丅丒丞丛丏东丌丘 != false)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_9, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7651"));
        }
        else
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  val_9, 丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7745"));
            this.丂不丗丄丂丒丛丁上 = true;
            val_10 = null;
            val_10 = null;
            this.丂丄一丗业丗丐万丏 = CharacterSelectionView.东万东一丞丌丌丐丒;
            mem[1152921539495898588] = CharacterSelectionView.东万东一丞丌丌丐丒.__il2cppRuntimeField_4;
            mem[1152921539495898596] = CharacterSelectionView.东万东一丞丌丌丐丒.__il2cppRuntimeField_C;
        }
        
        this.东丁丛三丝一丙七丄();
    }
    private string 丑世丑丌专与丄业上(int 丝世不丑不与丅丟七)
    {
        var val_5;
        int val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        if(coinsShop.七三丗丏丑丗三丆世() == false)
        {
                return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7748");
        }
        
        val_5 = 0;
        val_6 = System.String.alignConst;
        goto label_4;
        label_13:
        val_7 = null;
        val_7 = null;
        if((丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length + 32) == 丝世不丑不与丅丟七)
        {
            goto label_9;
        }
        
        val_5 = 1;
        label_4:
        val_8 = null;
        val_8 = null;
        if(val_5 < 丏丄丑上丛不丈且万.丅丂上丞上专一丗丏.Length)
        {
            goto label_13;
        }
        
        goto label_14;
        label_9:
        val_9 = null;
        val_9 = null;
        val_6 = mem[StoreKitEventListener.业万专三一丟且丘业.Length + 32];
        val_6 = StoreKitEventListener.业万专三一丟且丘业.Length + 32;
        label_14:
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_6)) != false)
        {
                return (string)System.String.alignConst;
        }
        
        val_10 = null;
        val_10 = null;
        var val_5 = 0;
        val_5 = val_5 + 1;
        return StoreKitEventListener.丆丕丝丒不丙且丐丗.且下丕专丏丕丐丛丛(丘专丈与三专丈丈专:  val_6).丟丂丞不专丆万丒世();
    }
    internal void 丑丄与万世且丛且上()
    {
        this.丆三丆丐丘丕丕丟丅();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._emptyState, 丏业丟一东丂东丘丛:  true);
        this.东丁丛三丝一丙七丄();
    }
    internal void 丐丌与丘丂丆丆丑丕()
    {
        this.丆三丆丐丘丕丕丟丅();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._selectedState, 丏业丟一东丂东丘丛:  true);
    }
    public void U_Select()
    {
        if(this.丄丐与万丄丑丏丆东() == null)
        {
            
        }
    
    }
    public void U_CreateCharacter()
    {
        if(this.丛丟专丆专丁丄丏丘 != null)
        {
                return;
        }
        
        this.丛丟专丆专丁丄丏丘 = this.StartCoroutine(routine:  this.丕不业丛丁丄丘丁专());
    }
    public void U_RemoveCharacter()
    {
    
    }
    public void U_Unlock()
    {
        var val_9;
        UnityEngine.GameObject[] val_10;
        if((this.<丁万丌丆七与丛丘丗>k__BackingField) == 3)
        {
            goto label_1;
        }
        
        if((this.<丁万丌丆七与丛丘丗>k__BackingField) != 2)
        {
            goto label_9;
        }
        
        if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  34)) == true)
        {
                return;
        }
        
        丑丝丞丒丅丄万丒三.丕丆丁一万丗不世下(丌丒丝东丌下丕丁丅:  2);
        goto label_9;
        label_1:
        if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  35)) == true)
        {
                return;
        }
        
        丑丝丞丒丅丄万丒三.丐与一丘丟丝丄下丟();
        label_9:
        if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  34)) != true)
        {
                if((Progress.七七世万专丕丁上业.丑三丙丆丌丈与东专().丟不下下且业丛丄丏(下下丏一丙不丘丌丞:  35)) == false)
        {
                return;
        }
        
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._currencyPriceButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._realPriceButton, 丏业丟一东丂东丘丛:  false);
        if((this.<丁万丌丆七与丛丘丗>k__BackingField) != 3)
        {
                if((this.<丁万丌丆七与丛丘丗>k__BackingField) != 2)
        {
                return;
        }
        
            val_9 = null;
            val_10 = this._currencyPriceDisabledButton;
        }
        else
        {
                val_9 = null;
            val_10 = this._realPriceDisabledButton;
        }
        
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  val_10, 丏业丟一东丂东丘丛:  true);
    }
    private void 丆三丆丐丘丕丕丟丅()
    {
        var val_1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._emptyState, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._loadedState, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._loadingState, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._lockedState, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._selectedState, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this._unlockedState, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._currencyPriceButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this._realPriceButton, 丏业丟一东丂东丘丛:  false);
        this.丂不丗丄丂丒丛丁上 = false;
        val_1 = null;
        val_1 = null;
        this.丂丄一丗业丗丐万丏 = CharacterSelectionView.且不业七丄丂世且一;
        mem[1152921539497429596] = CharacterSelectionView.东万东一丞丌丌丐丒.__il2cppRuntimeField_14;
        mem[1152921539497429604] = CharacterSelectionView.东万东一丞丌丌丐丒.__il2cppRuntimeField_1C;
    }
    private void 东丁丛三丝一丙七丄()
    {
        if(this._character == 0)
        {
                return;
        }
        
        if((((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  this.不丙丌七丄上丛三七)) != false) && ((丛且丗丌丏下七下丈.丁专丏七丏东丈上世(丞一丁业丄一一业且:  this.不丙丌七丄上丛三七)) != false)) && ((System.String.op_Inequality(a:  this.不丙丌七丄上丛三七, b:  "EMPTY_ROYALE_AVATAR")) != false))
        {
                this._character.丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  this.不丙丌七丄上丛三七);
        }
        else
        {
                this._character.丈丑丅上七丑丅一丒(丕丁下丌不万丅丞丛:  System.String.alignConst);
            this._character.上丈一万东三东世东(丂丒丘丅专丗丂世丛:  this.丑丄丅丟丙丛丒丑丅);
        }
        
        this._character.世丕丈丑丌丕丁世不(丕丁下丌不万丅丞丛:  this.丌丕世丞丈丒丞丈丟);
        this._character.丒丗丙丙丙丟专丅万(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = this.丂丄一丗业丗丐万丏, g = V9.16B, b = V10.16B, a = V11.16B});
        if(this._character == null)
        {
            goto label_17;
        }
        
        if(this.丂不丗丄丂丒丛丁上 == false)
        {
            goto label_18;
        }
        
        label_19:
        this._character.不丕与丛三丛业丙不(东丐丛丁一东丑丒专:  "default");
        return;
        label_17:
        if(this.丂不丗丄丂丒丛丁上 == true)
        {
            goto label_19;
        }
        
        label_18:
        this._character.丌丐丛丛且万万丕丂(东丐丛丁一东丑丒专:  "Idle");
    }
    private void 业丘三一丘丂不东七()
    {
        UnityEngine.Transform val_12;
        UnityEngine.GameObject val_13;
        val_12 = 1152921504848912384;
        if(this._character != 0)
        {
            goto label_3;
        }
        
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "Character_model_V2");
        if(val_2 == null)
        {
            goto label_4;
        }
        
        var val_3 = (null == null) ? (val_2) : 0;
        goto label_5;
        label_3:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._character, 丏业丟一东丂东丘丛:  true);
        goto label_8;
        label_4:
        val_13 = 0;
        label_5:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  false);
        CharacterInterfaceV2 val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_13).GetComponent<CharacterInterfaceV2>();
        this._character = val_5;
        val_12 = this.<丅且东不下丆丏丛丑>k__BackingField;
        val_5.transform.SetParent(parent:  val_12, worldPositionStays:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_13, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._character, 丏业丟一东丂东丘丛:  true);
        this._character.丟且丟七丌丞专七丁();
        this._character.丌丐丛丛且万万丕丂(东丐丛丁一东丑丒专:  "Idle");
        this._character.丆七万丂丛丛一业丒(丙业与丙丗丝不丈东:  true);
        if((this.<丅且东不下丆丏丛丑>k__BackingField) != 0)
        {
                val_12 = this.<丅且东不下丆丏丛丑>k__BackingField.gameObject.layer;
            Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this._character.gameObject, 不东丛三丂丌丑专丆:  val_12);
        }
        
        Rilisoft.与丄丁丄丙丞下下丙.丌世七丑丆丈丑丕丛(与丘东下丈东丛丂万:  this._character.gameObject);
        label_8:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.<三丑丏丄丙丛万业不>k__BackingField, 丏业丟一东丂东丘丛:  true);
    }
    private System.Collections.IEnumerator 丕不业丛丁丄丘丁专()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new CharacterSelectionView.丐下丁与不与丞丘丛();
    }
    private void 业丟专下与下一丝丄()
    {
        SelectableButton val_1 = this.丄丐与万丄丑丏丆东();
        if(val_1.selected != false)
        {
                if(this._selectedState.activeInHierarchy == false)
        {
            goto label_3;
        }
        
        }
        
        SelectableButton val_3 = this.丄丐与万丄丑丏丆东();
        if(val_3.selected == true)
        {
                return;
        }
        
        if(this._selectedState.activeInHierarchy == false)
        {
                return;
        }
        
        this.丏丏不丕丝丑万丆丌();
        return;
        label_3:
        this.丐丌与丘丂丆丆丑丕();
    }
    public CharacterSelectionView()
    {
    
    }
    private static CharacterSelectionView()
    {
        CharacterSelectionView.东万东一丞丌丌丐丒 = 0;
        CharacterSelectionView.且不业七丄丂世且一 = 0;
        CharacterSelectionView.东万东一丞丌丌丐丒.__il2cppRuntimeField_14 = 0;
        CharacterSelectionView.东万东一丞丌丌丐丒.__il2cppRuntimeField_1C = 0;
        CharacterSelectionView.丅专丕且三下丙丟丟 = 0;
        CharacterSelectionView.东万东一丞丌丌丐丒.__il2cppRuntimeField_24 = 0;
        CharacterSelectionView.东万东一丞丌丌丐丒.__il2cppRuntimeField_2C = 0;
    }

}
