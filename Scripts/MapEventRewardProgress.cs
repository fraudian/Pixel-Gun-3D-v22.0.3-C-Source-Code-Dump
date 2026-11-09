using UnityEngine;
public class MapEventRewardProgress : PGBehaviour
{
    // Fields
    public UIBasicSprite specialRewardIcon;
    public UILabel specialRewardCount;
    public UnityEngine.GameObject specialRewardCountContainer;
    public UnityEngine.GameObject specialRewardGem;
    public UITable specialRewardTable;
    public UISprite specialRewardGear;
    public UnityEngine.GameObject specialRewardCheckmark;
    public UISprite specialProgress;
    public UnityEngine.GameObject progressSeparator;
    public UnityEngine.GameObject progressSeparatorContainer;
    private System.Collections.Generic.List<UnityEngine.GameObject> 七与七丟下丕万丁下;
    public UILabel attemptsLeftLabel;
    public UILabel specalRewardDescription;
    public Rilisoft.ButtonHandler specialItemBtn;
    private Rilisoft.OfferItem 上丒丅丁丌七丄丐丆;
    private PGCompany.GameModeEvents.丝一七万丗不丄丒上 丞三丕世业三丒丅三;
    private Rilisoft.OfferItem 丘丂丅且丄丑丞万丟;
    private bool 业丆丑业丕丅业丙东;
    
    // Methods
    internal void OnEnable()
    {
        if(this.丞三丕世业三丒丅三 == null)
        {
                return;
        }
        
        if(this.丘丂丅且丄丑丞万丟 == null)
        {
                return;
        }
        
        this.东丒不七丝万丌丄三(丐且丘丑与万丞丑丅:  0, 丅丂丕下丟且丐丂丕:  false);
    }
    internal PGCompany.GameModeEvents.丝一七万丗不丄丒上 丞丂业丄丞与专丛丒()
    {
        return (PGCompany.GameModeEvents.丝一七万丗不丄丒上)this.丞三丕世业三丒丅三;
    }
    internal Rilisoft.OfferItem 一丑丄且丆与不丒丝()
    {
        return (Rilisoft.OfferItem)this.丘丂丅且丄丑丞万丟;
    }
    internal void 上东与丛丞下丈专丈(PGCompany.GameModeEvents.丝一七万丗不丄丒上 丞三丕世业三丒丅三, PGCompany.GameModeEvents.丘三丞丕丅丙三丒丗 丄丄七丞丙丞丗一丟)
    {
        this.丞三丕世业三丒丅三 = 丞三丕世业三丒丅三;
        this.丘丂丅且丄丑丞万丟 = 丄丄七丞丙丞丗一丟.丂丑丞丝且万丐万丟();
        this.东丒不七丝万丌丄三(丐且丘丑与万丞丑丅:  0, 丅丂丕下丟且丐丂丕:  false);
    }
    internal void 下与丞三丅丛丄七丕(bool 东丅丞丁丗万且丁丗 = True)
    {
        var val_3;
        if(this.丞三丕世业三丒丅三 == null)
        {
                return;
        }
        
        if(this.丘丂丅且丄丑丞万丟 == null)
        {
                return;
        }
        
        if(东丅丞丁丗万且丁丗 != false)
        {
                val_3 = null;
            val_3 = null;
            this.东丒不七丝万丌丄三(丐且丘丑与万丞丑丅:  GameConnect.丈丝丂丐丟万丙丑丕, 丅丂丕下丟且丐丂丕:  true);
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丅与丌专丟一丝业三(), 丏业丟一东丂东丘丛:  东丅丞丁丗万且丁丗);
    }
    internal void 东丒不七丝万丌丄三(PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 丐且丘丑与万丞丑丅, bool 丅丂丕下丟且丐丂丕 = False)
    {
        var val_80;
        Rilisoft.OfferItem val_81;
        float val_82;
        object val_83;
        float val_84;
        string val_85;
        var val_86;
        float val_87;
        float val_91;
        float val_92;
        float val_93;
        float val_95;
        float val_96;
        UISprite val_97;
        var val_98;
        object val_99;
        var val_101;
        string val_102;
        var val_103;
        float val_105;
        float val_106;
        float val_107;
        float val_108;
        val_81 = this.丘丂丅且丄丑丞万丟;
        if(val_81 == null)
        {
            goto label_6;
        }
        
        if(this.丞三丕世业三丒丅三 == null)
        {
            goto label_2;
        }
        
        PGCompany.GameModeEvents.GMERewardConditionProgress val_1 = this.丞三丕世业三丒丅三.丄且丙丂丆不一万七(丂丘丈丈专万丈丈丆:  true, 丑丟丙丄不丟丄丗丕:  0);
        if(val_1 == null)
        {
            goto label_4;
        }
        
        int val_2 = val_1.Points1;
        goto label_5;
        label_2:
        val_81 = 0;
        goto label_6;
        label_4:
        int val_3 = 0.Points1;
        label_5:
        float val_81 = (float)this.丞三丕世业三丒丅三;
        val_82 = (float)val_1.Points / val_81;
        this.specialProgress.fillAmount = val_82;
        var val_6 = (this.丞三丕世业三丒丅三 != 1) ? (this.丞三丕世业三丒丅三 - 1) : 0;
        int val_8 = val_6 - this.七与七丟下丕万丁下.Count;
        val_84 = (float)this.specialProgress.width;
        if(val_8 >= 1)
        {
                val_80 = 1152921519068975536;
            do
        {
            UnityEngine.GameObject val_14 = 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.progressSeparator.transform.parent.gameObject, 丑且不丕与专丄业丙:  this.progressSeparator.gameObject);
            val_14.SetActive(value:  true);
            this.七与七丟下丕万丁下.Add(item:  val_14);
            val_8 = val_8 - 1;
        }
        while(val_8 != 0);
        
        }
        
        val_85 = 1152921524288826496;
        val_86 = 0;
        val_81 = val_84 / val_81;
        goto label_30;
        label_32:
        UnityEngine.GameObject val_15 = this.七与七丟下丕万丁下.Item[0];
        if(val_86 < val_6)
        {
                val_15.SetActive(value:  true);
            UnityEngine.Vector3 val_18 = UnityEngine.Vector3.right;
            val_86 = 1;
            UnityEngine.Vector3 val_19 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, d:  1f);
            val_87 = val_81;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z}, d:  val_87);
            val_84 = val_20.x;
            val_91 = val_20.z;
            val_82 = val_84;
            val_92 = val_20.y;
            val_93 = val_91;
            this.七与七丟下丕万丁下.Item[0].transform.localPosition = new UnityEngine.Vector3() {x = val_82, y = val_92, z = val_93};
        }
        else
        {
                val_15.SetActive(value:  false);
            val_86 = 1;
        }
        
        label_30:
        if(val_86 < this.七与七丟下丕万丁下.Count)
        {
            goto label_32;
        }
        
        UnityEngine.Texture val_22 = this.丘丂丅且丄丑丞万丟.Texture;
        if(this.丘丂丅且丄丑丞万丟.Type != 1070)
        {
                if(this.丘丂丅且丄丑丞万丟.Type != 1000)
        {
            goto label_38;
        }
        
        }
        
        this.specialRewardCountContainer.SetActive(value:  true);
        this.specialRewardCount.text = this.丘丂丅且丄丑丞万丟.Count.ToString();
        this.specialRewardGear.gameObject.SetActive(value:  (this.丘丂丅且丄丑丞万丟.Type == 1070) ? 1 : 0);
        this.specialRewardGem.SetActive(value:  (this.丘丂丅且丄丑丞万丟.Type == 1000) ? 1 : 0);
        if(this.丘丂丅且丄丑丞万丟.Type != 1070)
        {
            goto label_50;
        }
        
        System.Nullable<ItemRarity> val_33 = this.丘丂丅且丄丑丞万丟.Rarity;
        if((516112480 & 1) == 0)
        {
            goto label_50;
        }
        
        System.Nullable<ItemRarity> val_34 = this.丘丂丅且丄丑丞万丟.Rarity;
        UnityEngine.Color val_35 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  val_34.HasValue);
        val_95 = val_35.r;
        val_84 = val_35.g;
        val_96 = val_35.b;
        val_91 = val_35.a;
        this.specialRewardCount.color = new UnityEngine.Color() {r = val_95, g = val_84, b = val_96, a = val_91};
        val_97 = this.specialRewardGear;
        if(val_97 != null)
        {
            goto label_57;
        }
        
        goto label_56;
        label_50:
        val_97 = this.specialRewardCount;
        UnityEngine.Color val_36 = UnityEngine.Color.white;
        val_95 = val_36.r;
        val_84 = val_36.g;
        val_96 = val_36.b;
        val_91 = val_36.a;
        if(val_97 != null)
        {
            goto label_57;
        }
        
        label_56:
        label_57:
        val_82 = val_95;
        val_92 = val_84;
        val_93 = val_96;
        val_87 = val_91;
        val_97.color = new UnityEngine.Color() {r = val_82, g = val_92, b = val_93, a = val_87};
        goto label_58;
        label_38:
        this.specialRewardCountContainer.SetActive(value:  false);
        label_58:
        this.attemptsLeftLabel.gameObject.SetActive(value:  (val_1.CompleteResult != 1) ? 1 : 0);
        if(val_1.CompleteResult != 1)
        {
            goto label_64;
        }
        
        val_98 = null;
        val_98 = null;
        if((WeaponManager.丗丈丁世且世丂丈丝.Contains(item:  this.丘丂丅且丄丑丞万丟.Id)) == false)
        {
            goto label_69;
        }
        
        label_115:
        val_99 = 丏丄丑上丛不丈且万.不丘丅丛丐丄万三丄(丆万一不丌且东丐丐:  this.丘丂丅且丄丑丞万丟.Id);
        if(val_99 == null)
        {
            goto label_73;
        }
        
        if((Progress.七七世万专丕丁上业.一万万与七万丄丗丟().专丐丂丆丘丌丗上与(丞世不丒下上上丝丑:  val_99.业东丅东丌上丗丑不())) != null)
        {
            goto label_102;
        }
        
        string val_48 = val_99.三与丛丑且丐丈业丌();
        goto label_78;
        label_64:
        this.attemptsLeftLabel.text = this.丞三丕世业三丒丅三;
        val_101 = this;
        val_102 = this.丞三丕世业三丒丅三;
        goto label_83;
        label_69:
        val_80 = 1152921505264353280;
        if((丙丞丟丑丗丅专丈一.丁丞不业丐丆专业丞().ContainsKey(key:  this.丘丂丅且丄丑丞万丟.Id)) == false)
        {
            goto label_88;
        }
        
        if((丙丞丟丑丗丅专丈一.专丙丄丏万业且丑上(上与三丛丛一万丘丟:  this.丘丂丅且丄丑丞万丟.Id)) == false)
        {
            goto label_92;
        }
        
        goto label_102;
        label_88:
        val_80 = 1152921505253916672;
        if((丛且丗丌丏下七下丈.一三专丞丒丅上业上().ContainsKey(key:  this.丘丂丅且丄丑丞万丟.Id)) == false)
        {
            goto label_98;
        }
        
        if((丛且丗丌丏下七下丈.丑丞丞东丟丒丂上不(丞一丁业丄一一业且:  this.丘丂丅且丄丑丞万丟.Id)) == true)
        {
            goto label_102;
        }
        
        label_92:
        label_78:
        val_99 = BalanceController.丗丝丄业丒丏丒丙丈(丏世丑万世一七丟丞:  this.丘丂丅且丄丑丞万丟.Id);
        val_83 = Rilisoft.丕七东丗丁丐丂三下.世丐丁丐一丕丒丏丒(丆万一不丌且东丐丐:  this.丘丂丅且丄丑丞万丟.Id);
        goto label_110;
        label_73:
        val_83 = 0;
        goto label_110;
        label_98:
        val_103 = null;
        val_103 = null;
        if((WeaponManager.丆丘下丛不丒丛丌丄.Contains(item:  this.丘丂丅且丄丑丞万丟.Id)) == true)
        {
            goto label_115;
        }
        
        label_102:
        val_83 = 0;
        val_99 = 0;
        label_110:
        val_101 = this;
        if((val_99 | val_83) != 0)
        {
                val_80 = 1152921504622075904;
            val_85 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4547");
            val_83 = val_83;
            string val_70 = System.String.Format(format:  "{0}\n{1}", arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4573"), arg1:  System.String.Format(format:  val_85, arg0:  System.String.Format(format:  "{0}/{1}", arg0:  val_83, arg1:  val_99)));
        }
        
        val_102 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_4573");
        label_83:
        this.specalRewardDescription.text = val_102;
        if(val_1.CompleteResult != 1)
        {
            goto label_124;
        }
        
        goto label_125;
        label_124:
        if(val_1.CompleteResult != 2)
        {
            goto label_127;
        }
        
        UnityEngine.Color val_74 = UnityEngine.Color.white;
        val_105 = val_74.r;
        val_106 = val_74.g;
        val_107 = val_74.b;
        val_108 = val_74.a;
        if(this.specalRewardDescription != null)
        {
            goto label_130;
        }
        
        goto label_129;
        label_127:
        label_125:
        val_105 = 0f;
        val_106 = 0f;
        val_107 = 0f;
        val_108 = 0f;
        if(this.specalRewardDescription != null)
        {
            goto label_130;
        }
        
        label_129:
        label_130:
        this.specalRewardDescription.color = new UnityEngine.Color() {r = val_105, g = val_106, b = val_107, a = val_108};
        if(val_1.CompleteResult != 1)
        {
            goto label_132;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specialRewardCheckmark, 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specialRewardTable.gameObject, 丏业丟一东丂东丘丛:  false);
        if(((丐且丘丑与万丞丑丅 == null) || (丅丂丕下丟且丐丂丕 == false)) || (PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世() == null))
        {
            goto label_140;
        }
        
        val_80 = PGCompany.GameModeEvents.丈专丂丁丁东丌丁丅.丑七不且上丗丁一世();
        bool val_79 = val_80.丅上丗丂丕丟丟与丝(丐且丘丑与万丞丑丅:  丐且丘丑与万丞丑丅);
        goto label_140;
        label_132:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specialRewardCheckmark, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.specialRewardTable.gameObject, 丏业丟一东丂东丘丛:  true);
        label_140:
        val_81 = this.丘丂丅且丄丑丞万丟;
        label_6:
        this.上丒丅丁丌七丄丐丆 = val_81;
        this.业丆丑业丕丅业丙东 = true;
    }
    private void LateUpdate()
    {
        if(this.业丆丑业丕丅业丙东 == false)
        {
                return;
        }
        
        this.业丆丑业丕丅业丙东 = false;
    }
    public MapEventRewardProgress()
    {
        this.七与七丟下丕万丁下 = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
