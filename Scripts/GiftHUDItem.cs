using UnityEngine;
public class GiftHUDItem : MonoBehaviour, 丙专丒丄丅一丘上丌
{
    // Fields
    private System.IDisposable 丐丆七且丞丏下三丙;
    private GiftController.丆三丄且下丏丐丒丝 丟丟万一不业上丐丗;
    private SlotInfo _slotInfo;
    public UnityEngine.BoxCollider colliderForDrag;
    private UnityEngine.GameObject CommonSprite;
    private UnityEngine.GameObject EpicPartSprite;
    private UnityEngine.GameObject EpicSprite;
    public bool isInfo;
    public UILabel lbInfoGift;
    private UnityEngine.GameObject LegendaryPartSprite;
    private UnityEngine.GameObject LegendarySprite;
    private UnityEngine.GameObject MythicPartSprite;
    private UnityEngine.GameObject MythicSprite;
    private string nameAndCountGift;
    public UILabel[] nameGift;
    private UnityEngine.Vector3 不丁丞丞世与丗一丕;
    public UnityEngine.GameObject parentForSkin;
    public UnityEngine.GameObject PartIndicator;
    public UILabel PartsCountLabel;
    public UISprite PartSprite;
    public UnityEngine.GameObject UpgradeCellAnimationParticles;
    public CountingLabel IconCountLabel;
    public CountingLabel VIPCountLabel;
    public UISprite coinIcon;
    public UISprite gemIcon;
    public UnityEngine.GameObject crownIcon;
    private UnityEngine.GameObject RarePartSprite;
    private UnityEngine.GameObject RareSprite;
    private UnityEngine.Vector3 丗丗丒不丘一丒业丂;
    public UnityEngine.Shader shaderForSkin;
    public UnityEngine.Material[] UpgradeCellAnimMaterials;
    private UnityEngine.Transform 下丝上丒丁业下丈业;
    public UISprite sprIcon;
    private UIBasicSprite textureIcon;
    private UnityEngine.GameObject UncommonPartSprite;
    private UnityEngine.GameObject UncommonSprite;
    private int 业且万业丘丄丗丁与;
    private bool 丘丁丆丛丛丑丐丄丄;
    private static System.Collections.Generic.HashSet<GiftCategoryType> 丄业丗丆丏丕与上世;
    private GiftCategoryType 丛下上丑丒下丌万且;
    
    // Properties
    internal SlotInfo 丞丕丁世丆业丁专丝 { get; }
    public GiftCategoryType 且丌丐丛丂与丝万丏 { get; }
    public int 丘丗七丞不丙丕下丟 { get; }
    internal UIBasicSprite 三丒丒丝丘一世丈东 { get; }
    
    // Methods
    internal SlotInfo 丕丟丘且丕与丆东丅()
    {
        return (SlotInfo)this._slotInfo;
    }
    public GiftCategoryType get_GiftCategoryType()
    {
        return (GiftCategoryType)this.丛下上丑丒下丌万且;
    }
    public int get_PositionInScroll()
    {
        if(this._slotInfo != null)
        {
                return this._slotInfo.PositionInScroll;
        }
        
        return this._slotInfo.PositionInScroll;
    }
    internal UIBasicSprite 东丕万丕丌七东丙不()
    {
        UIBasicSprite val_1 = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.textureIcon);
        this.textureIcon = val_1;
        return val_1;
    }
    private void 丙丄不万丛上业专丘(string 丕丗丘丑丛与丑业丒)
    {
        goto label_1;
        label_11:
        if(this.nameGift[0] != 0)
        {
                this.nameGift[0].text = 丕丗丘丑丛与丑业丒;
        }
        
        0 = 1;
        label_1:
        if(0 < this.nameGift.Length)
        {
            goto label_11;
        }
    
    }
    private void Awake()
    {
        if(this.VIPCountLabel != 0)
        {
                this.VIPCountLabel.丅下丂丒东下丒丑丐();
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.VIPCountLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.IconCountLabel == 0)
        {
                return;
        }
        
        this.IconCountLabel.丅下丂丒东下丒丑丐();
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.IconCountLabel.gameObject, 丏业丟一东丂东丘丛:  true);
    }
    private void OnEnable()
    {
        if(this.UpgradeCellAnimationParticles != 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.UpgradeCellAnimationParticles, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.colliderForDrag == 0)
        {
                this.colliderForDrag = this.GetComponent<UnityEngine.Renderer>();
        }
        
        if(this.isInfo != false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.丐与且三且不丘七丑());
    }
    private void OnDisable()
    {
        if(this.UpgradeCellAnimationParticles != 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.UpgradeCellAnimationParticles, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.IconCountLabel != 0)
        {
                if(this.丘丁丆丛丛丑丐丄丄 != false)
        {
                this.IconCountLabel.上不与丞丛不丏专丙(丂丐丏下万万丒三上:  this._slotInfo.CountGift, 丕丂丐丌丆丝且万丗:  "");
        }
        else
        {
                this.IconCountLabel.丅下丂丒东下丒丑丐();
        }
        
        }
        
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    internal void 丂业丑丆丈上且丞丂(SlotInfo 丘丌丛业丄丘丗世丐)
    {
        this._slotInfo = 丘丌丛业丄丘丗世丐;
        this.丛下上丑丒下丌万且 = 丘丌丛业丄丘丗世丐.GiftCategoryType;
        this.丟丟万一不业上丐丗 = 0;
        this.丟丈丂丗丘丂丗丏一(丐业丂丕丅一丟不且:  false);
        this.gameObject.SetActive(value:  true);
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void GiftHUDItem::丝三丕丛丗万丟丆丛()), 与且专丈不万东一万:  0);
    }
    internal void 世与东丗世三丞丞不(SlotInfo 丘丌丛业丄丘丗世丐)
    {
        var val_8;
        System.Collections.Generic.HashSet<GiftCategoryType> val_9;
        val_8 = null;
        val_8 = null;
        val_9 = GiftHUDItem.丄业丗丆丏丕与上世;
        GiftCategory val_1 = 丘丌丛业丄丘丗世丐.category;
        this.丘丁丆丛丛丑丐丄丄 = val_9.Contains(item:  val_1.Type);
        if(this._slotInfo != null)
        {
                val_9 = this._slotInfo.GiftCategoryType;
            if(val_9 != 丘丌丛业丄丘丗世丐.GiftCategoryType)
        {
                val_9 = this.IconCountLabel;
            if(val_9 != 0)
        {
                val_9 = this.IconCountLabel;
            val_9.丅下丂丒东下丒丑丐();
        }
        
        }
        
        }
        
        this._slotInfo = 丘丌丛业丄丘丗世丐;
        this.丛下上丑丒下丌万且 = 丘丌丛业丄丘丗世丐.GiftCategoryType;
        this.丟丟万一不业上丐丗 = 0;
        this.丟丈丂丗丘丂丗丏一(丐业丂丕丅一丟不且:  true);
    }
    internal void 丑丕一丙丗丈一丈丆(SlotInfo 与丄不丌一世东丁丙)
    {
        this._slotInfo = 与丄不丌一世东丁丙;
        this.丛下上丑丒下丌万且 = 与丄不丌一世东丁丙.GiftCategoryType;
    }
    internal void 一丞一丝丘丕且丒丆(GiftController.丆三丄且下丏丐丒丝 东一丁世丑丞业丄丐, bool 丐业丂丕丅一丟不且)
    {
        UnityEngine.Shader val_71;
        int val_72;
        Rilisoft.丝丑丂丛万丐丈丘且 val_73;
        var val_74;
        object val_75;
        float val_80;
        var val_82;
        UnityEngine.GameObject val_91;
        val_71 = this;
        this.丟丟万一不业上丐丗 = 东一丁世丑丞业丄丐;
        this._slotInfo = 0;
        if(this.sprIcon != 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.sprIcon.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.东丕万丕丌七东丙不() != 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.东丕万丕丌七东丙不().gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.下丝上丒丁业下丈业 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.下丝上丒丁业下丈业.gameObject);
            this.下丝上丒丁业下丈业 = 0;
        }
        
        if(this.PartIndicator != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.PartIndicator, 丏业丟一东丂东丘丛:  false);
        }
        
        val_72 = System.String.alignConst;
        if(丐业丂丕丅一丟不且 == false)
        {
            goto label_28;
        }
        
        if(东一丁世丑丞业丄丐 != null)
        {
                val_73 = 东一丁世丑丞业丄丐.丙业丂丑丄业万下业;
            val_74 = val_73;
            val_75 = val_73;
        }
        else
        {
                val_73 = 24;
            val_74 = 24;
            val_75 = 24;
        }
        
        if(val_74 >= 2)
        {
            goto label_27;
        }
        
        if(val_75 != 1)
        {
            goto label_28;
        }
        
        GiftCategoryType val_71 = 东一丁世丑丞业丄丐.七丌丌丏丗东丕且丅;
        val_71 = val_71 - 1;
        if(val_71 > 3)
        {
            goto label_32;
        }
        
        val_72 = val_73 + " ";
        goto label_32;
        label_27:
        val_72 = val_75 + " ";
        label_28:
        label_32:
        GiftCategoryType val_72 = 东一丁世丑丞业丄丐.七丌丌丏丗东丕且丅;
        val_72 = val_72 - 1;
        if(val_72 <= 176)
        {
                var val_73 = 106034088 + ((东一丁世丑丞业丄丐.七丌丌丏丗东丕且丅 - 1)) << 2;
            val_73 = val_73 + 106034088;
        }
        else
        {
                val_82 = 东一丁世丑丞业丄丐.丄丅丛丆丟丁丘业丂;
            string val_33 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  null);
            this.nameAndCountGift = SkinsController.丛上不下丐丐丞丒专 + 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  null, 七丆丒与丗丌丄且丂:  null)(丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  null, 七丆丒与丗丌丄且丂:  null));
            this.丙丄不万丛上业专丘(丕丗丘丑丛与丑业丒:  this.nameAndCountGift);
            if(this.lbInfoGift != 0)
        {
                this.lbInfoGift.text = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  东一丁世丑丞业丄丐.丄丅丛丆丟丁丘业丂);
            this.lbInfoGift.gameObject.SetActive(value:  true);
        }
        
            val_91 = this.PartIndicator;
            if((val_91 != 0) && (this.isInfo != false))
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.PartIndicator, 丏业丟一东丂东丘丛:  (东一丁世丑丞业丄丐.丘上丙专丛丏三丐丒 == true) ? 1 : 0);
            val_91 = this.PartsCountLabel;
            if((val_91 != 0) && (东一丁世丑丞业丄丐.丘上丙专丛丏三丐丒 != false))
        {
                val_91 = this.PartsCountLabel;
            val_91.text = 东一丁世丑丞业丄丐.丙业丂丑丄业万下业.ToString();
        }
        
        }
        
            if(东一丁世丑丞业丄丐.七丌丌丏丗东丕且丅 == 5)
        {
                val_91 = this.parentForSkin;
            if((UnityEngine.Object.op_Implicit(exists:  val_91)) == false)
        {
                return;
        }
        
            if(this.isInfo != true)
        {
                this.parentForSkin.layer = UnityEngine.LayerMask.NameToLayer(layerName:  "Banners");
        }
        
            val_80 = this.不丁丞丞世与丗一丕;
            UnityEngine.Transform val_65 = SkinsController.上专丐丁丒世丈丝丌(且丘世丏丛丛万丟万:  东一丁世丑丞业丄丐.下丄丈不与世丐业专, 丈丙丒丛万丟丒丆与:  1, 丈东丘丏与丌东东下:  this.parentForSkin.transform, 不丁丞丞世与丗一丕:  new UnityEngine.Vector3() {x = val_80, y = V9.16B, z = V13.16B}, 丗丗丒不丘一丒业丂:  new UnityEngine.Vector3() {x = this.丗丗丒不丘一丒业丂, y = V10.16B, z = V11.16B});
            this.下丝上丒丁业下丈业 = val_65;
            val_91 = this.shaderForSkin;
            if(val_91 == 0)
        {
                return;
        }
        
            val_71 = this.shaderForSkin;
            val_65.GetComponent<CharacterInterfaceV2>().丐丌丐一上丛上丙丒().GetComponent<UnityEngine.MeshRenderer>().material.shader = val_71;
            return;
        }
        
            this.与丆丛丙丟丆丛丆丕();
        }
    
    }
    private string 东丛丕万世与丟丈丕(int 丆丐七丅丆丗丛上与)
    {
        string val_16;
        var val_17;
        var val_18;
        System.TimeSpan val_1 = System.TimeSpan.FromSeconds(value:  (double)丆丐七丅丆丗丛上与);
        if(((int)val_1._ticks.TotalMinutes - 1) <= (2.86558074587923E-322))
        {
            goto label_3;
        }
        
        System.TimeSpan val_4 = System.TimeSpan.FromSeconds(value:  (double)丆丐七丅丆丗丛上与);
        if((int)val_4._ticks.TotalHours != (4.94065645841247E-324))
        {
            goto label_6;
        }
        
        val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4074");
        val_17 = null;
        return (string)System.String.Format(format:  val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4075"), arg0:  (int)val_4._ticks.TotalHours);
        label_3:
        val_18 = 1152921504622075904;
        val_16 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_6567");
        return (string)System.String.Format(format:  val_16, arg0:  (int)val_4._ticks.TotalHours);
        label_6:
        if(((int)val_4._ticks.TotalHours - 2) <= (1.03753785626662E-322))
        {
            goto label_13;
        }
        
        var val_9 = X9 >> 63;
        var val_10 = X9 >> 34;
        var val_11 = val_10 + val_9;
        val_11 = (int)val_4._ticks.TotalHours - (val_11 * 24);
        if(val_11 == 0)
        {
            goto label_14;
        }
        
        label_13:
        label_23:
        val_18 = 1152921504622075904;
        return (string)System.String.Format(format:  val_16, arg0:  (int)val_4._ticks.TotalHours);
        label_14:
        var val_15 = val_10 + val_9;
        if(((int)val_4._ticks.TotalHours - 24) > (1.13635098543487E-322))
        {
            goto label_23;
        }
        
        goto label_23;
    }
    private string 丒丒与丙三三丘丅专(int 丆丐七丅丆丗丛上与, out int 七丐七丘上丒丏丝丏)
    {
        int val_15;
        string val_16;
        System.TimeSpan val_2 = System.TimeSpan.FromSeconds(value:  (double)this._slotInfo.gift.Count);
        val_15 = (int)val_2._ticks.TotalMinutes;
        if(val_15 != (4.94065645841247E-324))
        {
            goto label_5;
        }
        
        val_16 = "Key_6553";
        val_15 = 1;
        goto label_31;
        label_5:
        if((val_15 - 2) <= (2.81617418129511E-322))
        {
            goto label_9;
        }
        
        System.TimeSpan val_6 = System.TimeSpan.FromSeconds(value:  (double)this._slotInfo.gift.Count);
        val_15 = (int)val_6._ticks.TotalHours;
        if(val_15 != (4.94065645841247E-324))
        {
            goto label_14;
        }
        
        val_16 = "Key_6549";
        val_15 = 1;
        goto label_31;
        label_9:
        val_16 = "Key_6554";
        goto label_31;
        label_14:
        if((val_15 - 2) > (1.03753785626662E-322))
        {
                uint32_t val_9 = System.TimeSpan.__il2cppRuntimeField_cctor_finished >> 63;
            System.TimeSpan.__il2cppRuntimeField_cctor_finished = System.TimeSpan.__il2cppRuntimeField_cctor_finished >> 34;
        }
        
        val_16 = "Key_6550";
        label_31:
        七丐七丘上丒丏丝丏 = val_15;
        return (string)丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_16);
    }
    internal void 世丁丛三东七丁丁丟(float 丕丕世且下一与丝与 = 0, float 世东不与七丗丒业一 = 0)
    {
        if(this.丘丁丆丛丛丑丐丄丄 == false)
        {
                return;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丁丅丑不与丞丑一上(丕丕世且下一与丝与:  丕丕世且下一与丝与, 世东不与七丗丒业一:  世东不与七丗丒业一).GetEnumerator());
    }
    private System.Collections.IEnumerable 丁丅丑不与丞丑一上(float 丕丕世且下一与丝与, float 世东不与七丗丒业一)
    {
        GiftHUDItem.丁丛丞东丕一丆丈七 val_1 = new GiftHUDItem.丁丛丞东丕一丆丈七(丗丏丅丕丆世丁专丟:  -2);
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .东丒丝丈丝东丈上一 = 丕丕世且下一与丝与;
        }
        else
        {
                mem[40] = this;
            .东丒丝丈丝东丈上一 = 丕丕世且下一与丝与;
        }
        
        .丁丘一上丝丑丟业丒 = 世东不与七丗丒业一;
        return (System.Collections.IEnumerable)val_1;
    }
    internal void 业丞丆丏丆不三专与()
    {
        this.丟丈丂丗丘丂丗丏一(丐业丂丕丅一丟不且:  true);
    }
    private void 丟丈丂丗丘丂丗丏一(bool 丐业丂丕丅一丟不且)
    {
        UnityEngine.Shader val_112;
        UnityEngine.Shader val_113;
        UnityEngine.Color val_119;
        val_113 = this;
        int val_92 = 0;
        if(this._slotInfo == null)
        {
            goto label_1;
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.sprIcon)) != false)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.sprIcon.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if((UnityEngine.Object.op_Implicit(exists:  this.东丕万丕丌七东丙不())) != false)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.东丕万丕丌七东丙不().gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.下丝上丒丁业下丈业 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.下丝上丒丁业下丈业.gameObject);
            this.下丝上丒丁业下丈业 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.PartIndicator, 丏业丟一东丂东丘丛:  false);
        this.丄丆三七上丂万丛丟(丈下丑丆上丏丗丈专:  0, 不不丝万丅上不丈且:  false);
        if(this.gemIcon != 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.gemIcon.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.coinIcon != 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.coinIcon.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.crownIcon != 0)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.crownIcon, 丏业丟一东丂东丘丛:  false);
        }
        
        if(this.VIPCountLabel != 0)
        {
                this.VIPCountLabel.丅下丂丒东下丒丑丐();
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.VIPCountLabel.gameObject, 丏业丟一东丂东丘丛:  false);
        }
        
        if((this.丘丁丆丛丛丑丐丄丄 != false) && (this.业且万业丘丄丗丁与 > this._slotInfo.CountGift))
        {
                this.业且万业丘丄丗丁与 = this._slotInfo.CountGift;
            if(丐业丂丕丅一丟不且 != false)
        {
                if(this.IconCountLabel != 0)
        {
                this.IconCountLabel.上不与丞丛不丏专丙(丂丐丏下万万丒三上:  this.业且万业丘丄丗丁与, 丕丂丐丌丆丝且万丗:  "");
        }
        
        }
        
        }
        
        val_112 = I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._slotInfo.gift.KeyTranslateInfo);
        GiftCategory val_20 = this._slotInfo.category;
        if((val_20.Type - 1) > 176)
        {
            goto label_59;
        }
        
        var val_112 = 106036212 + ((val_20.Type - 1)) << 2;
        val_112 = val_112 + 106036212;
        goto (106036212 + ((val_20.Type - 1)) << 2 + 106036212);
        label_1:
        UnityEngine.Debug.LogError(message:  "SetInfoButton");
        return;
        label_291:
        if((this.丘丁丆丛丛丑丐丄丄 != false) && (this.业且万业丘丄丗丁与 == 1))
        {
                this.业且万业丘丄丗丁与 = this._slotInfo.CountGift;
            if((丐业丂丕丅一丟不且 != false) && (this.IconCountLabel != 0))
        {
                GiftCategory val_55 = this._slotInfo.category;
            if(val_55.Type != 8)
        {
                this.IconCountLabel.上不与丞丛不丏专丙(丂丐丏下万万丒三上:  this._slotInfo.CountGift, 丕丂丐丌丆丝且万丗:  "");
        }
        
        }
        
        }
        
        this.丙丄不万丛上业专丘(丕丗丘丑丛与丑业丒:  this.nameAndCountGift);
        if(this.lbInfoGift != 0)
        {
                this.lbInfoGift.text = 137129984;
            this.lbInfoGift.gameObject.SetActive(value:  true);
        }
        
        GiftCategory val_59 = this._slotInfo.category;
        if(val_59.Type == 5)
        {
                if((UnityEngine.Object.op_Implicit(exists:  this.parentForSkin)) == false)
        {
                return;
        }
        
            if(this.isInfo != true)
        {
                this.parentForSkin.layer = UnityEngine.LayerMask.NameToLayer(layerName:  "Banners");
        }
        
            val_119 = this.不丁丞丞世与丗一丕;
            UnityEngine.Transform val_63 = SkinsController.上专丐丁丒世丈丝丌(且丘世丏丛丛万丟万:  this._slotInfo.gift.Id, 丈丙丒丛万丟丒丆与:  1, 丈东丘丏与丌东东下:  this.parentForSkin.transform, 不丁丞丞世与丗一丕:  new UnityEngine.Vector3() {x = val_119, z = V13.16B}, 丗丗丒不丘一丒业丂:  new UnityEngine.Vector3() {x = this.丗丗丒不丘一丒业丂});
            this.下丝上丒丁业下丈业 = val_63;
            val_112 = this.shaderForSkin;
            if(val_112 == 0)
        {
                return;
        }
        
            val_113 = this.shaderForSkin;
            val_63.GetComponent<CharacterInterfaceV2>().丐丌丐一上丛上丙丒().GetComponent<UnityEngine.MeshRenderer>().material.shader = val_113;
            return;
        }
        
        this.与丆丛丙丟丆丛丆丕();
        return;
        label_59:
        if(val_20.Type != 9999)
        {
            goto label_291;
        }
        
        PGCompany.丗丟丄丈东丝丕丄世 val_70 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  this._slotInfo.gift.itemParams);
        if(val_70 == null)
        {
            goto label_178;
        }
        
        if(val_70 == null)
        {
            goto label_179;
        }
        
        this.nameAndCountGift = val_70;
        goto label_180;
        label_178:
        this.nameAndCountGift = System.String.alignConst;
        goto label_291;
        label_179:
        this.nameAndCountGift = System.String.alignConst;
        if(val_70 == null)
        {
            goto label_291;
        }
        
        label_180:
        丒与上丅丒丘与丒丘 val_108 = Rilisoft.ItemViewer.东且丏丆万与东丙万(丕丁下丌不万丅丞丛:  val_70.业上丙丞丐丄丆丅七(), 丅三丟世下丞丝丙万:  val_70);
        if(this.isInfo == true)
        {
            goto label_291;
        }
        
        this.丄丆三七上丂万丛丟(丈下丑丆上丏丗丈专:  val_70, 不不丝万丅上不丈且:  this._slotInfo.HasParts);
        goto label_291;
    }
    private void 丄丆三七上丂万丛丟(ItemRarity 丈下丑丆上丏丗丈专, bool 不不丝万丅上不丈且 = False)
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.CommonSprite, 丏业丟一东丂东丘丛:  (丈下丑丆上丏丗丈专 == 0) ? 1 : 0);
        bool val_2 = (丈下丑丆上丏丗丈专 == 1) ? 1 : 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.UncommonSprite, 丏业丟一东丂东丘丛:  val_2);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.UncommonPartSprite, 丏业丟一东丂东丘丛:  val_2 & 不不丝万丅上不丈且);
        bool val_4 = (丈下丑丆上丏丗丈专 == 2) ? 1 : 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.RareSprite, 丏业丟一东丂东丘丛:  val_4);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.RarePartSprite, 丏业丟一东丂东丘丛:  val_4 & 不不丝万丅上不丈且);
        bool val_6 = (丈下丑丆上丏丗丈专 == 3) ? 1 : 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.EpicSprite, 丏业丟一东丂东丘丛:  val_6);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.EpicPartSprite, 丏业丟一东丂东丘丛:  val_6 & 不不丝万丅上不丈且);
        bool val_8 = (丈下丑丆上丏丗丈专 == 4) ? 1 : 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.LegendarySprite, 丏业丟一东丂东丘丛:  val_8);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.LegendaryPartSprite, 丏业丟一东丂东丘丛:  val_8 & 不不丝万丅上不丈且);
        bool val_10 = (丈下丑丆上丏丗丈专 == 5) ? 1 : 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.MythicSprite, 丏业丟一东丂东丘丛:  val_10);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.MythicPartSprite, 丏业丟一东丂东丘丛:  val_10 & 不不丝万丅上不丈且);
    }
    private static string 丒丐东丕丄一上上世(string 丕丁下丌不万丅丞丛, CategoryNames 业丈世与下丘丛丐且, int 与丏丏丁丌与且三专 = 0)
    {
        string val_6 = 丕丁下丌不万丅丞丛;
        if((System.String.op_Equality(a:  val_6 = 丕丁下丌不万丅丞丛, b:  "LikeID")) != false)
        {
                return I2.Loc.丞丛丝万丅丛三上丛.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1796");
        }
        
        if((下专世丏丈丞三丗不.专丞丏东一丗丟下东(丆万一不丌且东丐丐:  val_6)) == false)
        {
                return 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_6 = 下专世丏丈丞三丗不.不丘与东丂与下丆丙(丞丅上丏丂且下丅与:  val_6, 七丞丙丒三丕且丌丟:  UnityEngine.Mathf.Min(a:  与丏丏丁丌与且三专, b:  下专世丏丈丞三丗不.丝丏与一丞万七一东())), 七丆丒与丗丌丄且丂:  业丈世与下丘丛丐且);
        }
        
        return 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_6, 七丆丒与丗丌丄且丂:  业丈世与下丘丛丐且);
    }
    private void Update()
    {
        var val_13;
        float val_14;
        var val_15;
        var val_16;
        if(this.shaderForSkin == 0)
        {
            goto label_8;
        }
        
        if(this._slotInfo == null)
        {
            goto label_4;
        }
        
        GiftCategory val_2 = this._slotInfo.category;
        if(val_2.Type == 5)
        {
            goto label_6;
        }
        
        label_4:
        if((this.丟丟万一不业上丐丗 == null) || (this.丟丟万一不业上丐丗.七丌丌丏丗东丕且丅 != 5))
        {
            goto label_8;
        }
        
        label_6:
        UnityEngine.GameObject val_4 = this.下丝上丒丁业下丈业.GetComponent<CharacterInterfaceV2>().丐丌丐一上丛上丙丒();
        val_13 = null;
        val_13 = null;
        UnityEngine.Vector3 val_5 = position;
        val_14 = val_5.x;
        UnityEngine.Vector3 val_6 = position;
        val_15 = val_4.GetComponent<UnityEngine.MeshRenderer>().material;
        val_15.SetFloat(name:  "_RightBorder", value:  val_6.x);
        val_4.GetComponent<UnityEngine.MeshRenderer>().material.SetFloat(name:  "_LeftBorder", value:  val_14);
        label_8:
        if(this.UpgradeCellAnimMaterials.Length == 0)
        {
                return;
        }
        
        if(this._slotInfo == null)
        {
                return;
        }
        
        if(this.isInfo == true)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        UnityEngine.Vector3 val_11 = position;
        val_14 = val_11.x;
        UnityEngine.Vector3 val_12 = position;
        val_15 = 0;
        goto label_33;
        label_41:
        this.UpgradeCellAnimMaterials[0].SetFloat(name:  "_RightBorder", value:  val_12.x);
        this.UpgradeCellAnimMaterials[0].SetFloat(name:  "_LeftBorder", value:  val_14);
        val_15 = 1;
        label_33:
        if(val_15 < this.UpgradeCellAnimMaterials.Length)
        {
            goto label_41;
        }
    
    }
    private void 与丆丛丙丟丆丛丆丕()
    {
        GiftCategoryType val_50;
        string val_51;
        GiftInfo val_52;
        string val_53;
        UISprite val_55;
        if(this._slotInfo != null)
        {
                GiftCategory val_1 = this._slotInfo.category;
            val_50 = val_1.Type;
        }
        else
        {
                val_50 = this.丟丟万一不业上丐丗.七丌丌丏丗东丕且丅;
        }
        
        if(this._slotInfo != null)
        {
                val_51 = this._slotInfo.gift.Id;
        }
        else
        {
                val_51 = this.丟丟万一不业上丐丗.下丄丈不与世丐业专;
        }
        
        if(this._slotInfo != null)
        {
                val_52 = this._slotInfo.gift;
            int val_2 = val_52.Count;
        }
        else
        {
                val_52 = this.丟丟万一不业上丐丗;
        }
        
        if(this._slotInfo != null)
        {
                val_52 = this._slotInfo.gift;
            System.Nullable<CategoryNames> val_3 = val_52.TypeShopCat;
            if(((-1142209432) & 1) != 0)
        {
                val_52 = this._slotInfo.gift;
            System.Nullable<CategoryNames> val_4 = val_52.TypeShopCat;
        }
        
        }
        
        if((this.丟丟万一不业上丐丗 != null) && ((this.丟丟万一不业上丐丗.不上上丕且丗丕丝三 & 1) != 0))
        {
                val_52 = this.丟丟万一不业上丐丗;
        }
        
        if((val_50 - 1) > 126)
        {
            goto label_21;
        }
        
        var val_50 = 106036920 + ((this.丟丟万一不业上丐丗.七丌丌丏丗东丕且丅 - 1)) << 2;
        val_50 = val_50 + 106036920;
        goto (106036920 + ((this.丟丟万一不业上丐丗.七丌丌丏丗东丕且丅 - 1)) << 2 + 106036920);
        label_79:
        val_53 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  mem[this.丟丟万一不业上丐丗.下丄丈不与世丐业专], 七丆丒与丗丌丄且丂:  null, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        goto label_86;
        label_21:
        if(val_50 != 9999)
        {
            goto label_37;
        }
        
        PGCompany.世东三上七丂丌下丑 val_15 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        if(this._slotInfo == null)
        {
            goto label_38;
        }
        
        if(val_15 != null)
        {
            goto label_88;
        }
        
        label_89:
        label_88:
        if((val_15.一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  this._slotInfo.gift.itemParams)) == null)
        {
            goto label_86;
        }
        
        goto label_79;
        label_37:
        三丅丁丗丗丝丂万且 val_17 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  mem[this.丟丟万一不业上丐丗.下丄丈不与世丐业专]);
        val_52 = val_17.与不丞丑七丘丁丂丛();
        val_53 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_52, 七丆丒与丗丌丄且丂:  val_17.万上丄下业丛丌不丈() - 1, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        label_86:
        if(val_53 == 0)
        {
            goto label_49;
        }
        
        val_52 = this.东丕万丕丌七东丙不();
        this.东丕万丕丌七东丙不().gameObject.SetActive(value:  true);
        val_55 = this.sprIcon;
        if(val_55 != null)
        {
            goto label_58;
        }
        
        goto label_54;
        label_49:
        this.sprIcon.spriteName = 0;
        this.sprIcon.gameObject.SetActive(value:  true);
        val_55 = this.东丕万丕丌七东丙不();
        if(val_55 != null)
        {
            goto label_58;
        }
        
        label_54:
        label_58:
        val_55.gameObject.SetActive(value:  false);
        return;
        label_38:
        if(val_15 != null)
        {
            goto label_88;
        }
        
        goto label_89;
    }
    private System.Collections.IEnumerator 丐与且三且不丘七丑()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GiftHUDItem.业不丌丐业且不七丂(丗丏丅丕丆世丁专丟:  0);
    }
    private void 丁上丑丕万丏丏且丕(UIScrollView 丄丑三东丘丆丂丟丙, UnityEngine.Vector3 业丙丝下丂丐不七丆)
    {
        float val_1 = RealTime.deltaTime;
        UnityEngine.Vector3 val_3 = 丄丑三东丘丆丂丟丙.transform.localPosition;
        丄丑三东丘丆丂丟丙.transform.localPosition = new UnityEngine.Vector3() {x = 业丙丝下丂丐不七丆.x, y = 业丙丝下丂丐不七丆.y, z = 业丙丝下丂丐不七丆.z};
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = 业丙丝下丂丐不七丆.x, y = 业丙丝下丂丐不七丆.y, z = 业丙丝下丂丐不七丆.z}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z});
        float val_9 = val_5.x;
        float val_10 = val_5.y;
        UnityEngine.Vector2 val_7 = 丄丑三东丘丆丂丟丙.panel.clipOffset;
        val_9 = val_7.x - val_9;
        val_10 = val_7.y - val_10;
        丄丑三东丘丆丂丟丙.panel.clipOffset = new UnityEngine.Vector2() {x = val_9, y = val_10};
    }
    private void OnClick()
    {
        var val_2;
        var val_3;
        if(this.isInfo == true)
        {
                return;
        }
        
        val_2 = null;
        val_2 = null;
        if(GiftBannerWindow.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        GiftBannerWindow.丄丘七三上丕世丞业.ShowInfo(与丂上上下丗上一三:  this._slotInfo);
    }
    public void U_Hide()
    {
        this.gameObject.SetActive(value:  false);
    }
    public GiftHUDItem()
    {
        this.nameAndCountGift = "";
        this.不丁丞丞世与丗一丕 = 0;
        mem[1152921537825214408] = 0;
        this.丗丗丒不丘一丒业丂 = 0;
        mem[1152921537825214520] = 0;
        this.业且万业丘丄丗丁与 = 0;
    }
    private static GiftHUDItem()
    {
        GiftHUDItem.丄业丗丆丏丕与上世 = new System.Collections.Generic.HashSet<GiftCategoryType>(collection:  new GiftCategoryType[171]);
    }
    private void 丝三丕丛丗万丟丆丛()
    {
        this.gameObject.SetActive(value:  false);
    }

}
