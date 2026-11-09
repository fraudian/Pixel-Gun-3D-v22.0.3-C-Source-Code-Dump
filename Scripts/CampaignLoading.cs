using UnityEngine;
public sealed class CampaignLoading : MonoBehaviour
{
    // Fields
    internal static readonly string 丙丏专万丛与丝丁丛;
    public UITexture backgroundUiTexture;
    public UnityEngine.GameObject survivalNotesOverlay;
    public UnityEngine.GameObject campaignNotesOverlay;
    public UnityEngine.GameObject trainingNotesOverlay;
    public UnityEngine.GameObject ordinaryAwardLabel;
    public UnityEngine.GameObject stackOfCoinsLabel;
    public UILabel[] levelNameLabels;
    
    // Methods
    private void Start()
    {
        var val_6;
        var val_64;
        var val_65;
        var val_66;
        var val_67;
        var val_68;
        var val_69;
        var val_70;
        var val_71;
        var val_72;
        var val_73;
        LoadingTipsView val_76;
        var val_77;
        bool val_79;
        var val_80;
        var val_81;
        var val_82;
        string val_83;
        UITexture val_84;
        var val_85;
        var val_86;
        var val_87;
        var val_88;
        var val_89;
        var val_90;
        UITexture val_91;
        var val_92;
        var val_93;
        var val_94;
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_5;
        }
        
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  120)) == false)
        {
            goto label_7;
        }
        
        val_64 = null;
        val_64 = null;
        List.Enumerator<T> val_4 = 下与业丆下三丅丅丝.丏专东丕丘丈不丞三.GetEnumerator();
        val_65 = 1152921525578729232;
        val_66 = 0;
        val_67 = 0;
        val_68 = 0;
        label_38:
        if(((-502674496) & 1) == 0)
        {
            goto label_11;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        val_69 = null;
        val_69 = null;
        if((X22.Equals(value:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与)) == false)
        {
            goto label_38;
        }
        
        List.Enumerator<T> val_9 = val_7.m_stringLength.GetEnumerator();
        label_23:
        if(((-502674528) & 1) == 0)
        {
            goto label_18;
        }
        
        string val_10 = val_6.丐丏七丌丕丗业且上();
        val_70 = null;
        val_70 = null;
        if((val_10.一七与丅上丁丙丂不().Equals(value:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万)) == false)
        {
            goto label_23;
        }
        
        val_71 = 0;
        val_72 = 173;
        val_73 = val_67;
        goto label_26;
        label_18:
        val_71 = 0;
        val_72 = 173;
        val_73 = val_67;
        label_26:
        val_71 = val_71 + 1;
        mem2[0] = 173;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        var val_65 = val_71;
        if((val_65 == 1) || ((1152921525579008880 + ((val_71 + 1)) << 2) != 173))
        {
            goto label_35;
        }
        
        var val_64 = 0;
        val_64 = val_64 ^ (val_65 >> 31);
        val_65 = val_65 + val_64;
        goto label_38;
        label_35:
        if( == 0)
        {
            goto label_38;
        }
        
        goto label_38;
        label_5:
        if(GameConnect.丛专丌且丕不专丈下() == false)
        {
            goto label_94;
        }
        
        this.levelNameLabels[0].gameObject.SetActive(value:  true);
        val_65 = 1152921505072021504;
        val_76 = 0;
        goto label_46;
        label_60:
        if(val_76 >= this.levelNameLabels.Length)
        {
                val_77 = 0;
        }
        
        Rilisoft.七丕丟丏三丈一丄世 val_17 = GameConnect.丑丌丛丈丅丅与不业();
        var val_68 = 0;
        val_68 = val_68 + 1;
        val_77 = 0;
        this.levelNameLabels[0].text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  GameConnect.丛丛丏专丏下三与七().Item[null]);
        val_76 = 1;
        label_46:
        if(val_76 < this.levelNameLabels.Length)
        {
            goto label_60;
        }
        
        goto label_94;
        label_7:
        if(this.trainingNotesOverlay == 0)
        {
            goto label_94;
        }
        
        val_79 = 1;
        goto label_66;
        label_11:
        val_80 = val_65 + 1;
        mem2[0] = 198;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if( == 1)
        {
            goto label_75;
        }
        
        if(( == 0) || ((1152921525579008880 + (((val_71 + 1) + (0 ^ ((int)(val_71 + 1)) >> 31))) << 2) == 198))
        {
            goto label_164;
        }
        
        label_163:
        label_164:
        var val_69 = (((val_71 + 1) + (0 ^ ((int)(val_71 + 1)) >> 31)) + 1) + 16.Count;
        val_81 = null;
        val_81 = null;
        val_69 = val_69 - 1;
        if(((Progress.七七世万专丕丁上业.且与丆丘丅丁七丄丏().七下丗丗丏丈丘东丁(丛一丝丛丏专一业且:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, 丂一丏丙下丝丘丆丗:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万)) != null) && (val_24.丌丐丛丝丒上丟丏下 > 0))
        {
                val_76 = 0;
        }
        else
        {
                val_76 = 1;
        }
        
        bool val_25 = ((val_7.m_stringLength.IndexOf(item:  val_10)) >= val_69) ? 1 : 0;
        val_25 = val_76 & val_25;
        if(this.ordinaryAwardLabel != 0)
        {
                this.ordinaryAwardLabel.SetActive(value:  (val_25 == 0) ? 1 : 0);
        }
        
        if(this.stackOfCoinsLabel == 0)
        {
            goto label_94;
        }
        
        val_79 = val_25;
        label_66:
        this.stackOfCoinsLabel.SetActive(value:  val_79);
        label_94:
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
        {
            goto label_97;
        }
        
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
            goto label_100;
        }
        
        val_82 = null;
        val_82 = null;
        int val_32 = 与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 / 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length;
        val_32 = 与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 - (val_32 * 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length);
        System.String[] val_33 = 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与 + (((long)(int)(与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 - ((与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 / 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length) * 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length))) << 3);
        val_83 = mem[(与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与 + ((long)(int)(与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 - ((与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 / 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length) * 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length))) << 3) + 32];
        val_83 = (与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与 + ((long)(int)(与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 - ((与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 / 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length) * 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length))) << 3) + 32;
        goto label_173;
        label_97:
        label_144:
        val_83 = "New_tutor";
        label_173:
        丟丙世丙不丛丈下丑 val_36 = Rilisoft.LoadingTipsController.七与丙一丞下丏丕业(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业());
        if(val_36 == 0)
        {
            goto label_110;
        }
        
        val_84 = this;
        val_76 = UnityEngine.Object.Instantiate<LoadingTipsView>(original:  UnityEngine.Resources.Load<LoadingTipsView>(path:  "LoadingTips"), parent:  this.backgroundUiTexture.transform.parent, worldPositionStays:  false);
        val_76.gameObject.layer = this.backgroundUiTexture.transform.parent.gameObject.layer;
        val_85 = null;
        if((System.String.op_Equality(a:  val_83, b:  "Death_Escape_campaign4")) == false)
        {
            goto label_121;
        }
        
        val_86 = null;
        if(Rilisoft.LoadingTipsController.丗丐丏专丌丅丛丈七 == false)
        {
            goto label_124;
        }
        
        val_86 = null;
        var val_48 = (GameConnect.丑丌丛丈丅丅与不业() == 11) ? 1 : 0;
        goto label_127;
        label_110:
        val_84 = this.backgroundUiTexture;
        goto label_128;
        label_121:
        val_88 = null;
        if(Rilisoft.LoadingTipsController.丌万丏与丞且丝丞东 == false)
        {
            goto label_131;
        }
        
        val_88 = null;
        var val_50 = (GameConnect.丑丌丛丈丅丅与不业() == 11) ? 1 : 0;
        goto label_134;
        label_100:
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_137;
        }
        
        val_90 = null;
        val_90 = null;
        goto label_173;
        label_137:
        if(GameConnect.丛专丌且丕不专丈下() == false)
        {
            goto label_143;
        }
        
        goto label_144;
        label_124:
        val_87 = 0;
        label_127:
        val_86 = null;
        var val_53 = (val_87 != 0) ? 524288 : (0 + 1);
        Rilisoft.LoadingTipsController.丗丐丏专丌丅丛丈七 = false;
        goto label_147;
        label_131:
        val_89 = 0;
        label_134:
        val_88 = null;
        Rilisoft.LoadingTipsController.丌万丏与丞且丝丞东 = false;
        label_147:
        Rilisoft.Singleton<Rilisoft.LoadingTipsController>.Instance.ShowTip(丞万一业万丕丏且丄:  val_76, 七丆丒与丗丌丄且丂:  (((val_89 != 0) ? 1 : 0) != 0) ? ((val_89 != 0) ? 8192 : (0 + 1)) : (val_36), 丛业丑丝丘丟七与丑:  false);
        label_128:
        val_91 = this.backgroundUiTexture;
        if(val_91 != 0)
        {
                val_91 = this.backgroundUiTexture;
            val_92 = null;
            val_92 = null;
            if(东丗上丁下业一丂丂.丗丟专一丏不丛与丑() != false)
        {
                val_93 = "/Hi";
        }
        
            UnityEngine.Texture val_62 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  丂丄丙丂丆丆丗东丗.一且丌丛七丛不业专(丆丛丑世下一丐且丕:  与丂丏丛丞丞丒丟丄.专专丐业丗丆丕专丆 + System.String.__il2cppRuntimeField_static_fields, 丌丗丏丏丛东专丁且:  "Loading_" + val_83));
        }
        
        this.Invoke(methodName:  "Load", time:  2f);
        return;
        label_75:
        if( != 0)
        {
            goto label_163;
        }
        
        goto label_164;
        label_143:
        if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_167;
        }
        
        val_94 = null;
        val_94 = null;
        goto label_173;
        label_167:
        UnityEngine.Debug.LogError(message:  "No scene for this mode!");
        goto label_173;
    }
    private void Load()
    {
        var val_11;
        string val_12;
        var val_13;
        var val_14;
        if((PGCompany.丗三万丁三丗上专丟.丑七不且上丗丁一世().丟丂下七且七东丛丞(不七丆万丁一丞七下:  76)) == false)
        {
            goto label_2;
        }
        
        if(GameConnect.丌专丌万一下丕专上() == false)
        {
            goto label_5;
        }
        
        val_11 = null;
        val_11 = null;
        int val_4 = 与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 / 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length;
        val_4 = 与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 - (val_4 * 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length);
        System.String[] val_5 = 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与 + (((long)(int)(与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 - ((与丂丏丛丞丞丒丟丄.丙丐丁下丆丙业丘下 / 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length) * 与丂丏丛丞丞丒丟丄.丐丆丐与丒丅丑东与.Length))) << 3);
        goto label_28;
        label_2:
        val_12 = "New_tutor";
        label_28:
        label_25:
        if((System.String.IsNullOrEmpty(value:  val_12)) != false)
        {
                return;
        }
        
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  val_12);
        return;
        label_5:
        if(GameConnect.上丏丈七丘丁与丅丏() == false)
        {
            goto label_15;
        }
        
        val_13 = null;
        val_13 = null;
        goto label_28;
        label_15:
        if(GameConnect.丛专丌且丕不专丈下() == false)
        {
            goto label_21;
        }
        
        goto label_28;
        label_21:
        if(GameConnect.万七丄丛丈丟专一丑() == false)
        {
            goto label_25;
        }
        
        val_14 = null;
        val_14 = null;
        goto label_28;
    }
    public CampaignLoading()
    {
    
    }
    private static CampaignLoading()
    {
        CampaignLoading.丙丏专万丛与丝丁丛 = "Coliseum";
    }

}
