using UnityEngine;
public class BPChallengeRewardWindow : MonoBehaviour
{
    // Fields
    public UIBasicSprite[] icons;
    public UILabel[] labels;
    private bool 丛丒专丑不丗丌丙丏;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    private UIBasicSprite 三丗一丄不丆不丏三(int 丞世不丒下上上丝丑)
    {
        mem2[0] = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.icons[(long)丞世不丒下上上丝丑]);
        return (UIBasicSprite)this.icons[(long)丞世不丒下上上丝丑];
    }
    internal static void 下与丞三丅丛丄七丕(UnityEngine.Transform 丈东丘丏与丌东东下)
    {
        string val_3 = Rilisoft.Singleton<BattlePassController>.Instance.丛东丛丕东丟丂丈丝().丕世丝七世与三丞一();
        UnityEngine.GameObject val_5 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "Banners/BPChallengesDone"));
        val_5.transform.parent = 丈东丘丏与丌东东下;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_5, 不东丛三丂丌丑专丆:  丈东丘丏与丌东东下.gameObject.layer);
        val_5.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
        val_5.transform.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_11.w};
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.one;
        val_5.transform.localScale = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
    }
    private void Awake()
    {
        object val_44;
        BPChallengeRewardWindow.世丞丒丅一专丌丐丏 val_45;
        object val_46;
        var val_47;
        var val_48;
        var val_52;
        System.Func<Rilisoft.OfferItem, System.Boolean> val_54;
        var val_55;
        System.Action<Rilisoft.OfferItem> val_57;
        var val_58;
        var val_59;
        val_44 = this;
        BPChallengeRewardWindow.世丞丒丅一专丌丐丏 val_1 = null;
        val_45 = val_1;
        val_1 = new BPChallengeRewardWindow.世丞丒丅一专丌丐丏();
        this.东三世丙丁丒丝世丕();
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void BPChallengeRewardWindow::HandleBackgroundTapped()), 与且专丈不万东一万:  "BPChallengeRewardWindow");
        .丈七丁丅丐七丗七丑 = 0;
        PGCompany.BattlePass.三丛上丁丗丌丆丌东 val_6 = BPChallengesController.丑七不且上丗丁一世().七丗丒丟一一丅业丑();
        .丈七丁丅丐七丗七丑 = val_6;
        if(val_6 == null)
        {
            goto label_8;
        }
        
        .丒世丞上三丗丆专丂 = false;
        System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeRememberedReward> val_8 = BPChallengesController.丑七不且上丗丁一世().丑专丘三丟丐丅上上();
        if(val_8 == null)
        {
            goto label_12;
        }
        
        new BPChallengeRewardWindow.东专专下丏三丘丝丌() = new System.Object();
        if(new BPChallengeRewardWindow.东专专下丏三丘丝丌() == null)
        {
            goto label_13;
        }
        
        val_46 = new BPChallengeRewardWindow.东专专下丏三丘丝丌();
        .东丟且丗且三专丙丁 = val_45;
        goto label_14;
        label_8:
        UnityEngine.Debug.LogErrorFormat(format:  "BPChallengeRe_wardWindow phoenixC_hallenge == null", args:  System.Array.Empty<System.Object>());
        return;
        label_12:
        val_47 = 0;
        goto label_137;
        label_13:
        val_46 = 24;
        mem[24] = val_45;
        label_14:
        System.Func<PGCompany.BattlePass.BPChallengeRememberedReward, System.Boolean> val_11 = new System.Func<PGCompany.BattlePass.BPChallengeRememberedReward, System.Boolean>(object:  val_1, method:  System.Boolean BPChallengeRewardWindow.世丞丒丅一专丌丐丏::丘丏丘丕丙专丐业专(PGCompany.BattlePass.BPChallengeRememberedReward 三丟东丕丄丄下下丑));
        PGCompany.BattlePass.BPChallengeRememberedReward val_12 = System.Linq.Enumerable.FirstOrDefault<PGCompany.BattlePass.BPChallengeRememberedReward>(source:  val_8, predicate:  null);
        if(new BPChallengeRewardWindow.东专专下丏三丘丝丌() == null)
        {
            goto label_19;
        }
        
        .丁丕丒三万丙丈丄丗 = val_12;
        if(val_12 == null)
        {
            goto label_20;
        }
        
        label_55:
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  mem[24]);
        if(val_12.Rewards == null)
        {
            goto label_26;
        }
        
        val_48 = 0;
        goto label_27;
        label_53:
        System.Nullable<CategoryNames> val_17 = val_12.Rewards.Item[0].Category;
        UnityEngine.Texture val_18 = 丏丄丑上丛不丈且万.上与且丌上一丂丕丕(丆万一不丌且东丐丐:  val_12.Rewards.Item[0].Id, 七丆丒与丗丌丄且丂:  val_17.HasValue, 丅不丙丈丈丄丟丛七:  new System.Nullable<System.Int32>() {HasValue = false}, 丗丞丛丘丗丙三丅丙:  true, 三丑丂丅万丂丌丂万:  false);
        UIBasicSprite val_19 = this.三丗一丄不丆不丏三(丞世不丒下上上丝丑:  0);
        System.Nullable<CategoryNames> val_23 = val_12.Rewards.Item[0].Category;
        this.labels[0].text = 丏丄丑上丛不丈且万.与丆业丅上丗七丆一(丆万一不丌且东丐丐:  val_12.Rewards.Item[0].Id, 七丆丒与丗丌丄且丂:  val_23.HasValue);
        val_48 = 1;
        label_27:
        if(val_48 < val_12.Rewards.Count)
        {
            goto label_53;
        }
        
        goto label_54;
        label_19:
        mem[16] = val_12;
        if(mem[16] != 0)
        {
            goto label_55;
        }
        
        label_20:
        val_47 = 0;
        UnityEngine.Debug.LogErrorFormat(format:  "phoenixR_ewards == null", args:  System.Array.Empty<System.Object>());
        return;
        label_54:
        System.Action<Rilisoft.OfferItem> val_29 = new System.Action<Rilisoft.OfferItem>(object:  null, method:  System.Void BPChallengeRewardWindow.东专专下丏三丘丝丌::丂丐一丐下丐一万丈(Rilisoft.OfferItem 东七上世万下丗丄丛));
        val_12 + 24.ForEach(action:  null);
        label_26:
        val_52 = null;
        val_52 = null;
        val_54 = BPChallengeRewardWindow.<>c.<>9__4_2;
        if(val_54 == null)
        {
                val_54 = null;
            val_54 = new System.Func<Rilisoft.OfferItem, System.Boolean>(object:  BPChallengeRewardWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean BPChallengeRewardWindow.<>c::丄丂与丑丕专世七东(Rilisoft.OfferItem 三丟东丕丄丄下下丑));
            BPChallengeRewardWindow.<>c.<>9__4_2 = val_54;
        }
        
        val_55 = null;
        val_55 = null;
        val_57 = BPChallengeRewardWindow.<>c.<>9__4_3;
        if(val_57 == null)
        {
                val_57 = null;
            val_57 = new System.Action<Rilisoft.OfferItem>(object:  BPChallengeRewardWindow.<>c.__il2cppRuntimeField_static_fields, method:  System.Void BPChallengeRewardWindow.<>c::不不一且丛丅丛下业(Rilisoft.OfferItem 三丟东丕丄丄下下丑));
            BPChallengeRewardWindow.<>c.<>9__4_3 = val_57;
        }
        
        丞东丑专丛丆丄丝世.且三丁且与丆一世下<Rilisoft.OfferItem>(丌丛丏业世丄丞三丌:  System.Linq.Enumerable.Where<Rilisoft.OfferItem>(source:  val_12 + 24, predicate:  null), 七丐丅专且专七三丆:  null);
        val_47 = 1;
        label_137:
        val_44 = (BPChallengeRewardWindow.世丞丒丅一专丌丐丏)[1152921525530425104].丈七丁丅丐七丗七丑.业上丙丞丐丄丆丅七();
        bool val_37 = BPChallengesController.丑七不且上丗丁一世().上丒丄丌丞东丄上丛(且丂七下丙丆三丐三:  val_44, 丂丂丟丘丆东丟丄丒:  true);
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().万七丘东上世丘万丕(不丒丄下丆丗丞丂一:  54);
        if( != 0)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        }
        
        if((BPChallengeRewardWindow.世丞丒丅一专丌丐丏)[1152921525530425104].丒世丞上三丗丆专丂 == false)
        {
                return;
        }
        
        val_58 = null;
        val_58 = null;
        val_45 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_45 == 0)
        {
                return;
        }
        
        val_59 = null;
        val_59 = null;
        val_45 = WeaponManager.丟丗丄业丘丗业丗七;
        val_45.Reset(万业丒丙丂丝丗不丈:  false, 专丆丌丛东一不丑丙:  val_45.丟三上丁丗一丅丝丐());
        return;
        label_226:
        mem[8] = ;
        goto label_226;
    }
    private void OnDestroy()
    {
        this.东三世丙丁丒丝世丕();
    }
    public void HandleBackgroundTapped()
    {
        this.丆世与丑丆丅丐万且();
    }
    private void 丆世与丑丆丅丐万且()
    {
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        this.transform.parent = 0;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void 东三世丙丁丒丝世丕()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    public BPChallengeRewardWindow()
    {
    
    }

}
