using UnityEngine;
public class FortDefenceController : OnlineModeController
{
    // Fields
    internal System.Collections.Generic.List<FortAttackBotSet> botSets;
    internal FortMobWavesController wavesController;
    internal 丕下丞上上丂丕丟不 不且丝丅丂丐丒七丈;
    internal 丕下丞上上丂丕丟不 丝不丁丙丐丁丂七七;
    internal 丕下丞上上丂丕丟不 不丆丌丁丌丁丞且与;
    private UnityEngine.Coroutine 丁丟丗七丞丝且丙丑;
    private RilisoftBot.BaseBot 丅丈七丞丘丙业下七;
    private WorldPosIndicationItem_RoyaleSquad[] 万丂丂七且一丏丕且;
    private int 业丑丙丌丗万一丆丙;
    private bool 丈业丏业不业丁且上;
    
    // Methods
    internal override void 东丞丒丗专业且专丒()
    {
        this.东丞丒丗专业且专丒();
        this.不且丝丅丂丐丒七丈.且七丙丄丘一丄上不();
        this.丝不丁丙丐丁丂七七.且七丙丄丘一丄上不();
        this.不丆丌丁丌丁丞且与.且七丙丄丘一丄上不();
    }
    internal override void 丕且丅丞世三不七万()
    {
        this.丕且丅丞世三不七万();
        this.不且丝丅丂丐丒七丈.且七丙丄丘一丄上不();
        this.丝不丁丙丐丁丂七七.且七丙丄丘一丄上不();
        this.不丆丌丁丌丁丞且与.且七丙丄丘一丄上不();
    }
    public override void Initialize()
    {
        this.Initialize();
        InGameGUI.remove_OnCreateInGameGUI(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceController::丏丑下丑且三业丄丄()));
        InGameGUI.add_OnCreateInGameGUI(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceController::丏丑下丑且三业丄丄()));
        RilisoftBot.BotAiController.丞丁丆丘丌丝丏三丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void FortDefenceController::且丞丅丛业丂丐下丅(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)));
        RilisoftBot.BotAiController.丞上丗一丅与丛且丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void FortDefenceController::且丞丅丛业丂丐下丅(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)));
        RilisoftBot.BaseBot.丞七且上丌万下一丞(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BaseBot>(object:  this, method:  System.Void FortDefenceController::世下下世一丑丐丆丌(RilisoftBot.BaseBot 业丘东且七丕丞东不)));
        RilisoftBot.BaseBot.丏下丁丒丟丝丂丄丐(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BaseBot>(object:  this, method:  System.Void FortDefenceController::世下下世一丑丐丆丌(RilisoftBot.BaseBot 业丘东且七丕丞东不)));
    }
    public override void AfterInitialization()
    {
        this.AfterInitialization();
        this.wavesController.上丛丌丆丑上七世三();
    }
    public override void LocalEndMode(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        object val_5;
        BaseConditionEndRound val_6;
        var val_7;
        val_6 = 丅丈丌丅专丐丈丞东;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        this.LocalEndMode(丅丈丌丅专丐丈丞东:  val_6);
        ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
        val_7 = null;
        val_7 = null;
        val_5 = 1;
        val_2.set_Item(key:  GameConnect.丟丞丏丝与丙丁丛与, value:  1);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        val_6 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        val_6.七丟且丏不丝丒丈丙(丙业与丙丗丝不丈东:  false);
    }
    internal override void 丝丐不东一一丁丌七()
    {
        int val_3;
        var val_11;
        var val_12;
        List.Enumerator<T> val_1 = GetEnumerator();
        label_21:
        if(((-1436037104) & 1) == 0)
        {
            goto label_2;
        }
        
        if(val_3.丐丏七丌丕丗业且上() == null)
        {
            goto label_21;
        }
        
        if(null == null)
        {
            goto label_4;
        }
        
        if(null != null)
        {
            goto label_21;
        }
        
        val_11 = 0;
        if(FortDefenceLinkController.丄丘七三上丕世丞业 == 0)
        {
            goto label_21;
        }
        
        if((null != 0) && (null == 0))
        {
                val_11 = 0;
        }
        
        if(val_6.Length == 0)
        {
                val_11 = 0;
        }
        
        new object[1][0] = FortDefenceLinkController.丄丘七三上丕世丞业.damageChest;
        goto label_21;
        label_4:
        val_3 = this.wavesController.丝不丙丘专业丌丟上().GetLastWave();
        if((val_3 != 0) && (val_3 == 0))
        {
                val_12 = 0;
        }
        
        if(val_7.Length == 0)
        {
                val_12 = 0;
        }
        
        new object[1][0] = val_3;
        goto label_21;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丝丐不东一一丁丌七();
        丅专丈丑丟东丏万丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceController::丕丑丅一丈丑丘业世()));
        this.丙丅与万丟世一丙丂(丙业与丙丗丝不丈东:  0);
    }
    internal override void 三丟丏东且与丗世专(bool 丂丘下万丈丘丅一丄 = False)
    {
        var val_1;
        丂丘下万丈丘丅一丄 = 丂丘下万丈丘丅一丄;
        this.三丟丏东且与丗世专(丂丘下万丈丘丅一丄:  丂丘下万丈丘丅一丄);
        val_1 = null;
        val_1 = null;
        FortGameFieldDecorationController.丄丘七三上丕世丞业.东丘下万与万丂与丏();
        FortGameFieldController.丄丘七三上丕世丞业.万不丄丟丑丗七万丗();
    }
    protected override void 丞丞下丒丅丅丛世丕(bool 丂丘下万丈丘丅一丄)
    {
        System.Collections.Generic.List<FortAttackBotSet> val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        丂丘下万丈丘丅一丄 = 丂丘下万丈丘丅一丄;
        this.丞丞下丒丅丅丛世丕(丂丘下万丈丘丅一丄:  丂丘下万丈丘丅一丄);
        if((true != 0) && (0 != 0))
        {
                丒丆且丑业世丅三上();
            this.上不丒丄世丞丈丙三();
        }
        else
        {
                丒丆且丑业世丅三上();
            mem[1152921537530855320] = 1;
        }
        
        if((丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false) || (丂丘下万丈丘丅一丄 == true))
        {
            goto label_9;
        }
        
        val_13 = 1152921537530789072;
        val_14 = 0;
        goto label_10;
        label_13:
        UnityEngine.GameObject val_2 = 专七丗业丏业丛与丛(丞世不丒下上上丝丑:  0);
        val_14 = 1;
        label_10:
        val_12 = this.botSets;
        if(val_14 < val_12.Count)
        {
            goto label_13;
        }
        
        label_9:
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() != null)
        {
                val_13 = 1152921505066536960;
            val_15 = null;
            val_15 = null;
            val_12 = GameConnect.丕丄丛丁丛丂丝上下;
            if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_12)) != true)
        {
                ExitGames.Client.Photon.Hashtable val_8 = new ExitGames.Client.Photon.Hashtable();
            val_16 = null;
            val_16 = null;
            val_8.Add(key:  GameConnect.丕丄丛丁丛丂丝上下, value:  丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄());
            ExitGames.Client.Photon.Hashtable val_10 = null;
            val_12 = val_10;
            val_10 = new ExitGames.Client.Photon.Hashtable();
            val_10.Add(key:  GameConnect.丕丄丛丁丛丂丝上下, value:  0);
            丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_8, 丒不一专上专丌丈东:  val_10, 丅丞丏丈且专丆不丟:  false);
        }
        
        }
        
        this.wavesController.丞丞下丒丅丅丛世丕();
    }
    internal override void 丁三丅东三丅丄丘丙()
    {
        this.丁三丅东三丅丄丘丙();
        this.wavesController.三丘丒万丑三丘丌丅();
        不业丆不上丑丞三与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceController::不丁丝且丙丂世三不()));
        丆下三上丒丝世丈丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceController::不丁丝且丙丂世三不()));
        丆下三上丒丝世丈丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceController::丅世丛丘万丐七丑丐()));
        不业丆不上丑丞三与(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceController::丕丑丅一丈丑丘业世()));
    }
    private void 丏丑下丑且三业丄丄()
    {
        this.丈业丏业不业丁且上 = false;
        this.世下下世一丑丐丆丌(业丘东且七丕丞东不:  0);
        OnChangeInfo(丘丂丄丗丙丅丈丏下:  this.wavesController.丒业丈不丈丘丛丘东());
        SetIndexMiniPool(丞世不丒下上上丝丑:  0);
        SetIndexMiniPool(丞世不丒下上上丝丑:  1);
        SetIndexMiniPool(丞世不丒下上上丝丑:  0);
        System.Collections.Generic.List<丏下一丌且三与丘丘> val_2 = new System.Collections.Generic.List<丏下一丌且三与丘丘>();
        val_2.Add(item:  FortDefenceLinkController.丄丘七三上丕世丞业.waveTopRoundInfo);
        val_2.Add(item:  FortDefenceLinkController.丄丘七三上丕世丞业.placeTopRoundInfo);
        val_2.Add(item:  FortDefenceLinkController.丄丘七三上丕世丞业.scoreTopRoundInfo);
        丂东丒不与丅丏丝丒().世与东丗世三丞丞不(一上丘丕万丕丟丐专:  val_2);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丂东丒不与丅丏丝丒(), 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  下丝且丐丞丘一丁丂(), 丏业丟一东丂东丘丛:  (~IsDead()) & 1);
    }
    private void 丕丑丅一丈丑丘业世()
    {
        object val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_18 = this;
        丅专丈丑丟东丏万丁(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceController::不丁丝且丙丂世三不()));
        下一丌丕业丒万七丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceController::不丁丝且丙丂世三不()));
        下一丌丕业丒万七丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceController::丅世丛丘万丐七丑丐()));
        this.不丁丝且丙丂世三不();
        val_19 = 1152921505219145728;
        val_20 = 1152921504848912384;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  丐七丆丐丏丁东丅专(), 丏业丟一东丂东丘丛:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  下丝且丐丞丘一丁丂(), 丏业丟一东丂东丘丛:  false);
        if(this.丁丟丗七丞丝且丙丑 != null)
        {
                this.StopCoroutine(routine:  this.丁丟丗七丞丝且丙丑);
        }
        
        val_18 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_18 == 0)
        {
                return;
        }
        
        float val_18 = 三丏丟不丆丅丞不丛();
        float val_9 = maxHealth;
        val_18 = val_18 / val_9;
        val_9 = val_18 * 100f;
        if((val_18 == 0f) && (三丏丟不丆丅丞不丛() > 0f))
        {
                val_18 = "1 %";
        }
        else
        {
                val_18 = (int)val_9.ToString() + " %"(" %");
        }
        
        val_20 = 1152921505066536960;
        if(GameConnect.七丕丟上且丄丂丞丕() != false)
        {
                val_21 = "Key_8984";
        }
        else
        {
                FortDefenceLinkController.丄丘七三上丕世丞业.key_chest
        }
        
        val_19 = 丐七丆丐丏丁东丅专();
        UnityEngine.Color val_16 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "FortDefGen_Chest_green");
        if(GameConnect.七丕丟上且丄丂丞丕() != false)
        {
                val_22 = "Clan_safe_generator_icon";
        }
        else
        {
                FortDefenceLinkController.丄丘七三上丕世丞业.icon_chest
        }
        
        val_19.丙业丙与丗丅丂且丌(丗与丘不且万丟丙丑:  val_18, 上丕丈丞丌丘丅不与:  val_18, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_16.r, g = val_16.g, b = val_16.b, a = val_16.a}, 丘丏丑丁专上世丄不:  true, 丄一三上七丐专与丘:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  mem[FortDefenceLinkController.丄丘七三上丕世丞业.key_chest]), 三世丏且丑下专丟丟:  mem[FortDefenceLinkController.丄丘七三上丕世丞业.icon_chest]);
    }
    internal static UnityEngine.Texture 丘丈世丗丞丒丞丒丁(FortDefenceController.丙丑丁一丁万丑丞丑 丞丆丆专丆与丄不上)
    {
        var val_3;
        var val_4;
        val_3 = 丞丆丆专丆与丄不上;
        val_4 = 0;
        if(WorldPosIndicationsController.丄丘七三上丕世丞业 == 0)
        {
                return (UnityEngine.Texture)val_4;
        }
        
        val_3 = (long)val_3;
        UnityEngine.Texture[] val_2 = WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + (((long)(int)(丞丆丆专丆与丄不上)) << 3);
        val_4 = mem[(WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + ((long)(int)(丞丆丆专丆与丄不上)) << 3) + 32];
        return (UnityEngine.Texture)val_4;
    }
    private void 不丁丝且丙丂世三不()
    {
        float val_13;
        string val_14;
        InGameGUI val_15;
        float val_2 = maxHealth;
        val_13 = 三丏丟不丆丅丞不丛() / val_2;
        val_2 = val_13 * 100f;
        if(((int)val_2 == 0) && (三丏丟不丆丅丞不丛() > 0f))
        {
                val_14 = "1 %";
        }
        else
        {
                val_14 = (int)val_2.ToString() + " %"(" %");
        }
        
        val_15 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_15 != 0)
        {
                val_15 = 丐七丆丐丏丁东丅专();
            UnityEngine.Color val_8 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "FortDefGen_Chest_light_green");
            val_15.丝业不业丂上丒丒丄(丗与丘不且万丟丙丑:  val_13, 上丕丈丞丌丘丅不与:  val_14, 不业不丗丏丘三与万:  new UnityEngine.Color() {r = val_8.r, g = val_8.g, b = val_8.b, a = val_8.a});
            UnityEngine.Color val_10 = PGColors.丐下下丅与上东丙丑(丒丘丏上丙丟丑丕丈:  "FortDefGen_Chest_green");
            val_13 = val_10.r;
            丐七丆丐丏丁东丅专().丙上丟丏且丐丌不丒(丘上丄东丁丟丙一与:  new UnityEngine.Color() {r = val_13, g = val_10.g, b = val_10.b, a = val_10.a});
        }
        
        this.丁丟丗七丞丝且丙丑 = this.StartCoroutine(routine:  this.丅丅丌上七丗三下丆());
    }
    private void 丅世丛丘万丐七丑丐()
    {
        丆下三上丒丝世丈丐(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceController::丅世丛丘万丐七丑丐()));
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        UnityEngine.Color val_7 = UnityEngine.Color.red;
        丌丗一丁与丐丟丗三().Show(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  (GameConnect.七丕丟上且丄丂丞丕() != true) ? "Key_8939" : "Key_8010"), 丂三丟丂丈丐丆丗丟:  2f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
    }
    private System.Collections.IEnumerator 丅丅丌上七丗三下丆()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FortDefenceController.丘一丛专丝一丞上世();
    }
    private void 且丞丅丛业丂丐下丅(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)
    {
        InGameGUI val_14;
        UnityEngine.Object val_15;
        val_14 = 丑丁一丛万丘万丗不.七与世丄丞丒一七三();
        if(val_14.与丛上丙丟丘三世丁() != 3)
        {
                return;
        }
        
        val_14 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_14 == 0)
        {
                return;
        }
        
        FortDefenceController.上三且上丁业与与丑 val_4 = null;
        val_14 = val_4;
        val_4 = new FortDefenceController.上三且上丁业与与丑();
        UnityEngine.Color val_7 = UnityEngine.Color.red;
        丌丗一丁与丐丟丗三().Show(丕丗丘丑丛与丑业丒:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_8011"), 丂三丟丂丈丐丆丗丟:  5f, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_7.r, g = val_7.g, b = val_7.b, a = val_7.a});
        BossIndicationsFortDefence val_8 = 丑丁一丛万丘万丗不.GetComponent<BossIndicationsFortDefence>();
        if(val_14 != null)
        {
                val_15 = val_14;
            .丞丈且下且丙丞与丈 = val_8;
        }
        else
        {
                val_15 = 16;
            mem[16] = val_8;
        }
        
        if(val_15 == 0)
        {
                return;
        }
        
        下丝且丐丞丘一丁丂().丐丛丑丐丌丏专且丕(丗与丘不且万丟丙丑:  new System.Func<System.Single>(object:  val_4, method:  System.Single FortDefenceController.上三且上丁业与与丑::丄丈丛不东与丘万丙()));
        this.丅丈七丞丘丙业下七 = 丑丁一丛万丘万丗不.七与世丄丞丒一七三();
        RilisoftBot.BaseBot.丏下丁丒丟丝丂丄丐(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BaseBot>(object:  this, method:  System.Void FortDefenceController::丛专丕上丟一世业三(RilisoftBot.BaseBot 业丘东且七丕丞东不)));
    }
    protected override void Destroy()
    {
        this.Destroy();
        InGameGUI.remove_OnCreateInGameGUI(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortDefenceController::丏丑下丑且三业丄丄()));
        RilisoftBot.BotAiController.丞丁丆丘丌丝丏三丅(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BotAiController>(object:  this, method:  System.Void FortDefenceController::且丞丅丛业丂丐下丅(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)));
        RilisoftBot.BaseBot.丞七且上丌万下一丞(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BaseBot>(object:  this, method:  System.Void FortDefenceController::世下下世一丑丐丆丌(RilisoftBot.BaseBot 业丘东且七丕丞东不)));
    }
    private void 丛专丕上丟一世业三(RilisoftBot.BaseBot 业丘东且七丕丞东不)
    {
        if(this.丅丈七丞丘丙业下七 != 业丘东且七丕丞东不)
        {
                return;
        }
        
        RilisoftBot.BaseBot.丞七且上丌万下一丞(丙业与丙丗丝不丈东:  new System.Action<RilisoftBot.BaseBot>(object:  this, method:  System.Void FortDefenceController::丛专丕上丟一世业三(RilisoftBot.BaseBot 业丘东且七丕丞东不)));
        this = InGameGUI.丙丞专丌丁丞与不丐;
        if(this == 0)
        {
                return;
        }
        
        下丝且丐丞丘一丁丂().丑丄丐三丑丁丒丙丕();
    }
    protected override void 丅丙与东丏丂丑丄丆()
    {
        this.丅丙与东丏丂丑丄丆();
        if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                this.与丟世丂丏丈万丁上();
            return;
        }
        
        this.万丂丂七且一丏丕且 = 0;
    }
    private void 与丟世丂丏丈万丁上()
    {
        WorldPosIndicationItem_RoyaleSquad[] val_31;
        var val_32;
        WorldPosIndicationItem_RoyaleSquad[] val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        UnityEngine.GameObject val_43;
        if(WorldPosIndicationsController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        val_31 = this.万丂丂七且一丏丕且;
        if(val_31 == null)
        {
            goto label_7;
        }
        
        val_32 = 0;
        if(val_31 != null)
        {
            goto label_29;
        }
        
        goto label_9;
        label_7:
        WorldPosIndicationItem_RoyaleSquad[] val_3 = new WorldPosIndicationItem_RoyaleSquad[5];
        val_33 = val_3;
        val_34 = 0;
        this.万丂丂七且一丏丕且 = val_33;
        goto label_10;
        label_18:
        WorldPosIndicationItem_RoyaleSquad val_4 = val_3.下东丘东丟上七业丁();
        if(this.万丂丂七且一丏丕且 == null)
        {
            goto label_11;
        }
        
        if(val_4 != null)
        {
            goto label_12;
        }
        
        goto label_15;
        label_11:
        if(val_4 == null)
        {
            goto label_15;
        }
        
        label_12:
        label_15:
        this.万丂丂七且一丏丕且[0] = val_4;
        val_33 = this.万丂丂七且一丏丕且;
        val_34 = 1;
        label_10:
        if(val_34 < this.万丂丂七且一丏丕且.Length)
        {
            goto label_18;
        }
        
        val_32 = 0;
        goto label_19;
        label_30:
        bool val_5 = UnityEngine.Object.op_Equality(x:  this.万丂丂七且一丏丕且[0], y:  0);
        if(val_5 != false)
        {
                this.万丂丂七且一丏丕且[0] = val_5.下东丘东丟上七业丁();
        }
        
        val_32 = 1;
        label_19:
        val_31 = this.万丂丂七且一丏丕且;
        if(val_31 != null)
        {
            goto label_29;
        }
        
        label_9:
        label_29:
        if(val_32 < this.万丂丂七且一丏丕且.Length)
        {
            goto label_30;
        }
        
        val_35 = 0;
        goto label_31;
        label_38:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.万丂丂七且一丏丕且[0].gameObject, 丏业丟一东丂东丘丛:  false);
        val_35 = 1;
        label_31:
        if(val_35 < this.万丂丂七且一丏丕且.Length)
        {
            goto label_38;
        }
        
        val_36 = null;
        val_36 = null;
        val_37 = 0;
        goto label_41;
        label_111:
        if(Item[0] != 0)
        {
                NetworkStartTable val_10 = Item[0];
            if(val_10.丌丑丛业丈丘世丞丕 != 0)
        {
                val_38 = null;
            val_38 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_39 = null;
            val_39 = null;
            NetworkStartTable val_13 = Item[0];
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != val_13.丌丑丛业丈丘世丞丕)
        {
                NetworkStartTable val_15 = Item[0];
            if(val_15.丌丑丛业丈丘世丞丕.东丑丌丄丝世丞丘三 != false)
        {
                val_40 = null;
            WorldPosIndicationItem_RoyaleSquad val_33 = this.万丂丂七且一丏丕且[0];
            val_40 = null;
            var val_34 = 0;
            val_34 = val_34 + 1;
            if(丆丗丂三丐不东且丏() != true)
        {
                val_41 = null;
            val_41 = null;
            val_42 = null;
            val_42 = null;
            if(ShopNGUIController.丛世丛与丌不丈丐丐() != true)
        {
                BankController val_18 = BankController.丑七不且上丗丁一世();
            if(val_18.uiRoot.gameObject.activeInHierarchy != true)
        {
                NetworkStartTable val_21 = Item[0];
            if(val_21.丌丑丛业丈丘世丞丕.丐下丘丟丁丆丟丆丈() > 0f)
        {
                val_43 = val_33.gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_43, 丏业丟一东丂东丘丛:  true);
            UnityEngine.Vector3 val_24 = val_21.丌丑丛业丈丘世丞丕.myPlayerTransform.position;
            UnityEngine.Vector3 val_25 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_26 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z}, d:  1f);
            UnityEngine.Vector3 val_27 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_24.z}, b:  new UnityEngine.Vector3() {x = val_26.x, y = val_26.y, z = val_26.z});
            val_33.丝东不丄且不丏业丘(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z});
            float val_28 = val_21.丌丑丛业丈丘世丞丕.丐下丘丟丁丆丟丆丈();
            float val_29 = val_21.丌丑丛业丈丘世丞丕.丆丛不丄丂下且不丏();
            if(val_33 != null)
        {
                val_29 = val_28 / val_29;
            val_33.丝与丑与丘丝专与且(丛丁三世世丆七不业:  val_29);
        }
        else
        {
                val_29 = val_28 / val_29;
            0.丝与丑与丘丝专与且(丛丁三世世丆七不业:  val_29);
        }
        
            val_33.上丄丐丅三丄三丈丘(丛与丙丒丒下丌丟且:  false);
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        val_37 = 1;
        label_41:
        if(val_37 < Count)
        {
            goto label_111;
        }
    
    }
    private WorldPosIndicationItem_RoyaleSquad 下东丘东丟上七业丁()
    {
        WorldPosIndicationItem_RoyaleSquad val_1 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem_RoyaleSquad>();
        if(val_1 != null)
        {
                val_1.丗东丕且上丏业丝世(丛与丙丒丒下丌丟且:  true);
        }
        else
        {
                val_1.丗东丕且上丏业丝世(丛与丙丒丒下丌丟且:  true);
        }
        
        mem2[0] = 1;
        return val_1;
    }
    private void 世下下世一丑丐丆丌(RilisoftBot.BaseBot 业丘东且七丕丞东不)
    {
        var val_3;
        var val_13;
        System.Collections.Generic.HashSet<RilisoftBot.BaseBot> val_14;
        var val_15;
        val_13 = null;
        val_13 = null;
        val_14 = 丘丛丞且一丅丁丏丐.丅世丒丗业丝且丟丞;
        HashSet.Enumerator<T> val_1 = val_14.GetEnumerator();
        val_15 = 0;
        goto label_19;
        label_22:
        val_14 = val_3.丐丏七丌丕丗业且上();
        if((val_14 == 0) || (val_14 == 业丘东且七丕丞东不))
        {
            goto label_19;
        }
        
        PhotonView val_7 = val_14.photonView;
        if(val_7.丞丁丝丕世丏丌丞丁.Length == 0)
        {
            goto label_15;
        }
        
        PhotonView val_8 = val_14.photonView;
        object val_13 = val_8.丞丁丝丕世丏丌丞丁[0];
        if(null == 3)
        {
            goto label_19;
        }
        
        label_15:
        val_14 = this.wavesController;
        label_19:
        if(((-1432772736) & 1) != 0)
        {
            goto label_22;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        int val_11 = this.wavesController.万上丌丙丌七丗丞丙();
        if((val_11 + ((val_8.丞丁丝丕世丏丌丞丁[3] == val_14.丒业丈不丈丘丛丘东()) ? (val_15 + 1) : (val_15))) > this.业丑丙丌丗万一丆丙)
        {
                return;
        }
        
        this.丈业丏业不业丁且上 = true;
        val_11.丂东三专不且丕丐丕();
    }
    private void 丂东三专不且丕丐丕()
    {
        var val_5;
        float val_6;
        var val_22;
        WeaponManager val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        UnityEngine.Object val_29;
        val_22 = null;
        val_22 = null;
        val_23 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_23 == 0)
        {
                return;
        }
        
        val_24 = null;
        val_24 = null;
        val_23 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 64];
        val_23 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        if(val_23 == 0)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_168 == 0)
        {
                return;
        }
        
        val_26 = null;
        val_26 = null;
        val_27 = null;
        val_27 = null;
        HashSet.Enumerator<T> val_4 = 丘丛丞且一丅丁丏丐.丅世丒丗业丝且丟丞.GetEnumerator();
        label_39:
        label_38:
        if(((-1432528688) & 1) == 0)
        {
            goto label_26;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        if((val_5 == 0) || (val_6 <= 0f))
        {
            goto label_38;
        }
        
        val_28 = null;
        val_28 = null;
        UnityEngine.Vector3 val_9 = transform.position;
        UnityEngine.Vector3 val_11 = val_7.transform.position;
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        if(val_12.x >= 0)
        {
            goto label_38;
        }
        
        UnityEngine.Transform val_13 = val_7.transform;
        goto label_39;
        label_26:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        typeof(Player_move_c).__il2cppRuntimeField_168.一专丘东三丞东丁三();
        if(0 == 0)
        {
                return;
        }
        
        val_29 = 0.gameObject.GetComponentInChildren<UnityEngine.BoxCollider>();
        if(val_29 != 0)
        {
                UnityEngine.Vector3 val_18 = val_29.center;
        }
        else
        {
                UnityEngine.Vector3 val_19 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_20 = UnityEngine.Vector3.op_Multiply(d:  1.618f, a:  new UnityEngine.Vector3() {x = val_19.x, y = val_19.y, z = val_19.z});
        }
        
        typeof(Player_move_c).__il2cppRuntimeField_168.一专丘东三丞东丁三();
        typeof(Player_move_c).__il2cppRuntimeField_168.丒丐丙业丘丄三丕丁(丞上世与丈业丒丕不:  0, 三丙业丝丐上不丝丈:  new UnityEngine.Vector3() {x = val_20.x, y = val_20.y, z = val_20.z});
    }
    internal override bool 丄一下丒七丝与与万()
    {
        var val_5 = null;
        object val_3 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟丞丏丝与丙丁丛与];
        return (bool)(null == 1) ? 1 : 0;
    }
    protected override 丁丁丒丆不丒下丟三 上丑丙世丆丝且丝业(丌丈不下下丘丏丌一 东且丁丆丛丁丏丘且)
    {
        System.TimeSpan val_1 = X21.Elapsed;
        System.TimeSpan val_3 = X21.Elapsed;
        return (丁丁丒丆不丒下丟三)丆丒丑丑丒丘丆丅一.丈东丄丌丅丝不丂丘(丂丌丙丝且东丗丙万:  X21.丑丛丆三丆丄七丐万(), 丒丒丏丗丁丛丅七丙:  X22.丘不丄一丒丆丒丅万(), 万且丒下丕丝专丟上:  X23.丝丈丅一丆丗丝丝丘(), 丏丏业东上七丐万东:  val_1._ticks.TotalMinutes, 下丁丗丕丆丗下丟丐:  东且丁丆丛丁丏丘且, 与丛下丐丆丞万万下:  X23 + 118, 丌丑丁上丂丙与丈丞:  val_3._ticks.TotalSeconds);
    }
    internal override bool 世七丌丟丞且丛七且()
    {
        null = null;
        return (bool)(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count > 0) ? 1 : 0;
    }
    public FortDefenceController()
    {
        this.botSets = new System.Collections.Generic.List<FortAttackBotSet>();
        this.不且丝丅丂丐丒七丈 = new 丕下丞上上丂丕丟不(丑丞丘丛丂丗不万东:  new 丅世一丈七丆业丝丘[6]);
        this.丝不丁丙丐丁丂七七 = new 丕下丞上上丂丕丟不(丑丞丘丛丂丗不万东:  new 丅世一丈七丆业丝丘[4]);
        this.不丆丌丁丌丁丞且与 = new 丕下丞上上丂丕丟不(丑丞丘丛丂丗不万东:  new 丅世一丈七丆业丝丘[4]);
        this.业丑丙丌丗万一丆丙 = 3;
    }

}
