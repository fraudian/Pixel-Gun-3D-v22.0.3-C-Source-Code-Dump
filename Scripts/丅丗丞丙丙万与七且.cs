using UnityEngine;
private sealed class NetworkStartTableNGUIController.丅丗丞丙丙万与七且 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public NetworkStartTableNGUIController 丝且与丝丒丟万丁专;
    public int 丟丒丅丂丛丄丗万丌;
    public int 丝丕三丝丗丞且丟丐;
    public int 七丛丕七不丄不丆丄;
    public bool 丆丐丐丕世丕丌世与;
    public int 业七丅丟东丑专丅万;
    public int 丈三丌丁丈丒丅丌三;
    public RatingSystem.丁上且上一丆丘与业 丕丈一丐丛世丆上万;
    public bool 丁东丄东丑与七丆世;
    public bool 丑丏七丙下丛丐丁一;
    public int 丕东丈丒与丟丅丞丁;
    public bool 专丌丁且丗与丞丕且;
    public int 业专丁丘丐丅万专与;
    public int 丆世万七丆世丟丌业;
    public int 丅下七下不东不丂丝;
    public Rilisoft.OfferItem 丄丗世丈丈丙不丐丂;
    public PGCompany.丈丅丝丙上丈丌一丈.下东丙丑丙丞丛丑上 丏丝且世丞丅与丆东;
    public string 丏三万下丘下专丛专;
    public int 丑丑上丑下丐下丌业;
    public bool 不丄丅一一一丏一丌;
    public bool 丁丑下丄东丙一丘且;
    public int 丄丅丟丟丛丟丟丟上;
    public bool 丌三丒丌丆东万丆一;
    public int 业东丆丒丏丒丒专世;
    public System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 一下下丛七丈丅丂与;
    private bool 三七丄丗丆丘且丂丑;
    private Rilisoft.OfferItem 丄丘丛丐丅三丆三丈;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public NetworkStartTableNGUIController.丅丗丞丙丙万与七且(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        NetworkStartTable val_259;
        int val_260;
        bool val_261;
        var val_262;
        float val_263;
        float val_264;
        int val_265;
        float val_266;
        float val_267;
        float val_268;
        int val_269;
        bool val_270;
        object val_271;
        var val_272;
        int val_273;
        int val_274;
        int val_275;
        int val_276;
        var val_277;
        var val_278;
        UnityEngine.Object val_279;
        bool val_280;
        var val_281;
        var val_282;
        if(this.丗丏丅丕丆世丁专丟 > 7)
        {
            goto label_547;
        }
        
        var val_259 = 106025916 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_259 = val_259 + 106025916;
        goto (106025916 + (this.丗丏丅丕丆世丁专丟) << 2 + 106025916);
        if(this.丝且与丝丒丟万丁专.interfaceAnimator != null)
        {
            goto label_272;
        }
        
        label_273:
        label_272:
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetBool(name:  "isExpOnly", value:  true);
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetBool(name:  "isHunger", value:  this.丝且与丝丒丟万丁专.interfaceAnimator.一丈丛丘与丕丛丝东());
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetBool(name:  "isDater", value:  GameConnect.东且三丆丑世世丘丟());
        if(this.丝且与丝丒丟万丁专.丆七下丒上丈丒业世 >= TournamentController.丅下丈丙丝丛业丘三())
        {
            goto label_102;
        }
        
        if(this.丝且与丝丒丟万丁专.interfaceAnimator != null)
        {
            goto label_285;
        }
        
        label_286:
        label_285:
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetBool(name:  "IsTrophyUp", value:  true);
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetBool(name:  "IsTrophyDown", value:  (this.丝且与丝丒丟万丁专.丆七下丒上丈丒业世 > TournamentController.丅下丈丙丝丛业丘三()) ? 1 : 0);
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetBool(name:  "IsTrophyAdd", value:  (this.三七丄丗丆丘且丂丑 == false) ? 1 : 0);
        if(this.三七丄丗丆丘且丂丑 == false)
        {
            goto label_108;
        }
        
        if(this.丝且与丝丒丟万丁专.interfaceAnimator != null)
        {
            goto label_599;
        }
        
        label_600:
        label_599:
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetBool(name:  "NoRaiting", value:  true);
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                if((TeamDuelController.丅丌丛丏丞上万丛丕 + 160) == 0)
        {
            goto label_126;
        }
        
        }
        
        if(((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance) == 0) || ((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丝且丗丌丟丈世上万()) == null))
        {
            goto label_126;
        }
        
        PGCompany.ClanWarController val_44 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_44.万丅一丟丑丆世丞且 == null)
        {
            goto label_126;
        }
        
        System.ValueTuple<System.Int32, System.Int32, System.Int32, System.Boolean> val_46 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.GetTaskInfo();
        if(0 != 0)
        {
            goto label_126;
        }
        
        PGCompany.ClanWarController val_47 = Rilisoft.Singleton<PGCompany.ClanWarController>.Instance;
        if(val_47.万丅一丟丑丆世丞且.七一丈丁专丞丛丟丌() == false)
        {
            goto label_126;
        }
        
        if(this.丝且与丝丒丟万丁专._clanWarChallengeHolder.childCount >= 1)
        {
                UnityEngine.Object.Destroy(obj:  this.丝且与丝丒丟万丁专._clanWarChallengeHolder.GetChild(index:  0).gameObject);
            this.丝且与丝丒丟万丁专.clanwarChallagne = 0;
        }
        
        this.丝且与丝丒丟万丁专.丐丐丑丏丁丙上上丄 = true;
        PGCompany.BattlePass.万丈上下三丅丘丛丒.一丝且不丅东丗丒丙(丁丕丗丝万万上丟丌:  this.丝且与丝丒丟万丁专._clanWarChallengeHolder, 丟丈一下东业一丝丆:  "CWConnectScene", 上一丈丕丙世东丅丅:  true);
        ClanWarConnectScene val_52 = this.丝且与丝丒丟万丁专._clanWarChallengeHolder.GetComponentInChildren<ClanWarConnectScene>();
        this.丝且与丝丒丟万丁专.clanwarChallagne = val_52;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_52, 丏业丟一东丂东丘丛:  false);
        goto label_136;
        label_126:
        this.丝且与丝丒丟万丁专.丐丐丑丏丁丙上上丄 = false;
        label_136:
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetBool(name:  "ClanWarChallangeActive", value:  (0 != 0) ? 1 : 0);
        if((this.三七丄丗丆丘且丂丑 != true) && (this.业七丅丟东丑专丅万 == 0))
        {
                if(this.丟丒丅丂丛丄丗万丌 == 0)
        {
            goto label_140;
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.interfaceAnimator != null)
        {
            goto label_601;
        }
        
        label_602:
        label_601:
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetBool(name:  "isTrophyOnly", value:  false);
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetBool(name:  "isTrophyAdded", value:  false);
        if((this.三七丄丗丆丘且丂丑 != false) && (this.业七丅丟东丑专丅万 == 0))
        {
                if(this.丟丒丅丂丛丄丗万丌 == 0)
        {
            goto label_145;
        }
        
        }
        
        label_295:
        this.丝且与丝丒丟万丁专.三丑丑丈万丛丗与下 = true;
        if((GameConnect.业丛丛丂一丆丕丗丟() != true) && (GameConnect.一与东丝万上三丆丏() != true))
        {
                if(GameConnect.与丂丝丟丟三丑丝万() != true)
        {
                this.丝且与丝丒丟万丁专.interfaceAnimator.SetBool(name:  "isRatingSystem", value:  true);
        }
        
        }
        
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetBool(name:  "interfaceAnimationDone", value:  false);
        this.丝且与丝丒丟万丁专.一七丑三丝丝丌丕丗 = false;
        this.丝且与丝丒丟万丁专.trophiAddIcon.SetActive(value:  (this.丕丈一丐丛世丆上万 > 0) ? 1 : 0);
        this.丝且与丝丒丟万丁专.trophiMinusIcon.SetActive(value:  this.丕丈一丐丛世丆上万 >> 31);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专.trophyLabel, 丏业丟一东丂东丘丛:  (this.丕丈一丐丛世丆上万 != 0) ? 1 : 0);
        this.丝且与丝丒丟万丁专.trophyLabel.text = this.丕丈一丐丛世丆上万.ToString();
        this.丝且与丝丒丟万丁专.trophyPanel.SetActive(value:  (this.丕丈一丐丛世丆上万 != 0) ? 1 : 0);
        this.丝且与丝丒丟万丁专.丗东丞一丞丑三丈专(丛丅丘一丏丙且丌上:  false);
        val_261 = 0;
        GamepadCursorController.丆丕丝丒不丙且丐丗.丗丞丈不且丛不世不(丏业丟一东丂东丘丛:  true, 丆下丘丕丐丗丅丅不:  23);
        this.丝且与丝丒丟万丁专.betsReward.SetActive(value:  false);
        if(this.丝且与丝丒丟万丁专.丟且丑丒丟丁丒丞丗 != 0)
        {
                this.丝且与丝丒丟万丁专.丟且丑丒丟丁丒丞丗.transform.parent = this.丝且与丝丒丟万丁专.cupsHolder.transform;
            this.丝且与丝丒丟万丁专.丟且丑丒丟丁丒丞丗 = 0;
        }
        
        TournamentController.丁丟丂七与丏丛丐丄(丙业与丙丗丝不丈东:  RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏());
        UnityEngine.GameObject val_261 = this.丝且与丝丒丟万丁专.cupsObjects[(long)RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏()];
        this.丝且与丝丒丟万丁专.丟且丑丒丟丁丒丞丗 = val_261;
        val_261.transform.parent = this.丝且与丝丒丟万丁专.currentCupPoint.transform;
        val_262 = 1152921504838316032;
        UnityEngine.Vector3 val_72 = UnityEngine.Vector3.zero;
        val_263 = val_72.x;
        val_264 = val_72.z;
        this.丝且与丝丒丟万丁专.丟且丑丒丟丁丒丞丗.transform.localPosition = new UnityEngine.Vector3() {x = val_263, y = val_72.y, z = val_264};
        string val_73 = ToString();
        this.丝且与丝丒丟万丁专.trophyPoints.text = val_73;
        val_266 = (float)(long)RatingSystem.与一丅丝不丈业与丙().与丌丛七七与东下丏();
        val_267 = (float)val_73;
        val_268 = (float)this.丕丈一丐丛世丆上万;
        this.丝且与丝丒丟万丁专.trophyAnimation.SetValues(丙东专丗上不丂丆业:  val_266, 丝三业丛丘且不丝丆:  val_267, 丗世丈丂丒丞专上丟:  val_268);
        this.丝且与丝丒丟万丁专.丟下下丞七丅丈东丙().value = false;
        this.丝且与丝丒丟万丁专.丟下下丞七丅丈东丙().gameObject.SetActive(value:  this.丝且与丝丒丟万丁专.丟下下丞七丅丈东丙().value);
        Rilisoft.DoubleRewardNetworkStartTable val_80 = this.丝且与丝丒丟万丁专.GetComponentInChildren<Rilisoft.DoubleRewardNetworkStartTable>(includeInactive:  true);
        if(val_80 != 0)
        {
                val_261 = 0;
            val_80.丗与丄丑一丈丙不丛(丛丛丌丗丂上七丘丆:  false, 丗七丟丈三不丕一三:  0);
        }
        
        if(val_80.一丈丛丘与丕丛丝东() == false)
        {
            goto label_196;
        }
        
        if(((GameConnect.万不丒丌丙万丗东不() != true) && (GameConnect.一业上七丟业且业丙() != true)) && (GameConnect.世丐丄三三上丅七三() != true))
        {
                if(GameConnect.七丂万专且丏丘一丙() != true)
        {
                if(GameConnect.丒丗丁丙丗丄丙不丐() == false)
        {
            goto label_211;
        }
        
        }
        
        }
        
        this.丝且与丝丒丟万丁专.业七万七专丄丑万丘();
        label_211:
        this.丝且与丝丒丟万丁专.丞三专丈业丈丙丆丘();
        label_196:
        if(this.丝且与丝丒丟万丁专.spectatorModeButtonsAnchor.side != 3)
        {
            goto label_213;
        }
        
        UnityEngine.Transform val_88 = this.丝且与丝丒丟万丁专.spectatorModeBtnPnl.transform;
        UnityEngine.Vector3 val_89 = UnityEngine.Vector3.zero;
        goto label_217;
        label_102:
        if(TournamentController.丅下丈丙丝丛业丘三() < 1)
        {
            goto label_220;
        }
        
        var val_91 = (this.丝且与丝丒丟万丁专.丆七下丒上丈丒业世 < 1) ? 1 : 0;
        if(this.丝且与丝丒丟万丁专.interfaceAnimator != null)
        {
            goto label_285;
        }
        
        goto label_286;
        label_213:
        if(this.丝且与丝丒丟万丁专.spectatorModeButtonsAnchor.side != 7)
        {
            goto label_224;
        }
        
        UnityEngine.Vector3 val_93 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_94 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_93.x, y = val_93.y, z = val_93.z}, d:  118.4f);
        label_217:
        val_263 = val_94.x;
        val_264 = val_94.z;
        val_266 = val_263;
        val_267 = val_94.y;
        val_268 = val_264;
        this.丝且与丝丒丟万丁专.spectatorModeBtnPnl.transform.localPosition = new UnityEngine.Vector3() {x = val_266, y = val_267, z = val_268};
        label_224:
        if(this.丆丐丐丕世丕丌世与 == false)
        {
            goto label_229;
        }
        
        label_245:
        if(丅丒丗丑丒丙丛不丆.专东世丞丂丐丂丈丁() == 0)
        {
            goto label_232;
        }
        
        var val_97 = (丅丒丗丑丒丙丛不丆.专东世丞丂丐丂丈丁() != 3) ? 1 : 0;
        goto label_235;
        label_108:
        if(this.丝且与丝丒丟万丁专.上业丈丐上丂上东丌 != false)
        {
                if(GameConnect.业丛丛丂一丆丕丗丟() != true)
        {
                if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_242;
        }
        
        }
        
        }
        
        if(this.丝且与丝丒丟万丁专.interfaceAnimator != null)
        {
            goto label_599;
        }
        
        goto label_600;
        label_229:
        if(this.三七丄丗丆丘且丂丑 == false)
        {
            goto label_245;
        }
        
        label_232:
        label_235:
        this.丝且与丝丒丟万丁专.上丏丙东丁不丕丁丟 = false;
        this.丝且与丝丒丟万丁专.三与万丝丒一丏丝七 = true;
        if(GameConnect.丙丌丒丈东七丒上丌() == true)
        {
            goto label_296;
        }
        
        val_259 = WeaponManager.丟丗丄业丘丗业丗七;
        if(((WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0) && (GameConnect.一与东丝万上三丆丏() != true)) && (GameConnect.丒丗丁丙丗丄丙不丐() != true))
        {
                if(GameConnect.丄丏丒丏上东业丒一() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_296;
        }
        
        }
        
        }
        
        NetworkStartTableNGUIController.丘专丗丗丕丄丗丐丆();
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetTrigger(name:  "MatchEnd");
        this.丝且与丝丒丟万丁专.三与丁丞丂丗丅丆丁(丝三丄专丗丞丄丄丌:  false, 下丈下七一万丆丁丕:  0);
        if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
            goto label_270;
        }
        
        goto label_606;
        if(this.丝且与丝丒丟万丁专.interfaceAnimator != null)
        {
            goto label_272;
        }
        
        goto label_273;
        label_270:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_276;
        }
        
        val_259 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_259 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(GameConnect.丆丁上丟丛业丄丅丝() == false)
        {
            goto label_283;
        }
        
        var val_109 = (this.丕东丈丒与丟丅丞丁 == 0) ? 1 : 0;
        goto label_284;
        label_220:
        if(this.丝且与丝丒丟万丁专.interfaceAnimator != null)
        {
            goto label_285;
        }
        
        goto label_286;
        label_276:
        if(GameConnect.丁丁丗丐东丄丞一丛() == false)
        {
            goto label_293;
        }
        
        goto label_596;
        label_145:
        var val_111 = (this.丈三丌丁丈丒丅丌三 != 0) ? 1 : 0;
        goto label_295;
        label_283:
        label_284:
        label_606:
        label_596:
        this.丝且与丝丒丟万丁专.丒丈丗三专丅丒丌三(丑一丂丙丈丝丑丅丑:  (NetworkStartTable.__il2cppRuntimeField_klass != 0) ? 1 : 0, 专东丘一三丐不丈专:  false);
        this.丝且与丝丒丟万丁专.世丒丗一丑丏丞丑一 = true;
        if(this.丝且与丝丒丟万丁专.世丒丗一丑丏丞丑一 != false)
        {
                val_269 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_269;
            return (bool)val_269;
        }
        
        label_296:
        if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                NetworkStartTableNGUIController.丘专丗丗丕丄丗丐丆();
            this.丝且与丝丒丟万丁专.三与丁丞丂丗丅丆丁(丝三丄专丗丞丄丄丌:  false, 下丈下七一万丆丁丕:  0);
            val_269 = 1;
            this.丝且与丝丒丟万丁专.丑丘业丐丟世丗下且().gameObject.SetActive(value:  true);
            UnityEngine.WaitForSeconds val_116 = null;
            val_259 = val_116;
            val_116 = new UnityEngine.WaitForSeconds(seconds:  2f);
            this.丒上七丌业七丟与丐 = val_259;
            this.丗丏丅丕丆世丁专丟 = 2;
            return (bool)val_269;
        }
        
        val_262 = 1152921505066536960;
        if(GameConnect.一与东丝万上三丆丏() != true)
        {
                if(GameConnect.丒丗丁丙丗丄丙不丐() == false)
        {
            goto label_309;
        }
        
        }
        
        this.丝且与丝丒丟万丁专.业七万七专丄丑万丘();
        label_309:
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().DisableRewards();
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.专世七丟丄专丁与且();
        if(this.三七丄丗丆丘且丂丑 == false)
        {
            goto label_313;
        }
        
        if(GameConnect.丁丁丗丐东丄丞一丛() != true)
        {
                if(GameConnect.且丘丄丛下丆丟万丕() != true)
        {
                if(GameConnect.丆丕丒与丂七与下上() == false)
        {
            goto label_323;
        }
        
        }
        
        }
        
        if(this.丆丐丐丕世丕丌世与 == true)
        {
            goto label_323;
        }
        
        label_313:
        this.丝且与丝丒丟万丁专.interfaceAnimator.SetTrigger(name:  "Reward");
        label_323:
        if(this.丆丐丐丕世丕丌世与 != false)
        {
                if(this.三七丄丗丆丘且丂丑 != false)
        {
                this.丝且与丝丒丟万丁专.interfaceAnimator.SetTrigger(name:  "Reward");
        }
        
            if((ExperienceController.丞丞丘业东丙丏七丌() == 65) && (this.业七丅丟东丑专丅万 >= 1))
        {
                this.丝且与丝丒丟万丁专.丛丏丒一丗丝丌不丅 = 0;
        }
        
            this.丝且与丝丒丟万丁专.丛丏丒一丗丝丌不丅 = this.丟丒丅丂丛丄丗万丌;
            this.丝且与丝丒丟万丁专.下丕丌丈丙与与丏丟 = this.业七丅丟东丑专丅万;
            this.丝且与丝丒丟万丁专.丈七丈丞专七丟专丛 = this.丈三丌丁丈丒丅丌三;
            this.丝且与丝丒丟万丁专.七上世丌丘丕万丅东 = this.业专丁丘丐丅万专与;
            this.丝且与丝丒丟万丁专.丕专丐上东丑丑下丘 = this.丆世万七丆世丟丌业;
            this.丝且与丝丒丟万丁专.丂三丅丘丆丂丛七丌 = this.丅下七下不东不丂丝;
            this.丝且与丝丒丟万丁专.丕一丄丏丗丄丏万下 = this.丄丗世丈丈丙不丐丂;
        }
        else
        {
                val_266 = 0;
            mem2[0] = 0;
            this.丝且与丝丒丟万丁专.丕一丄丏丗丄丏万下 = 0;
            this.丝且与丝丒丟万丁专.丈七丈丞专七丟专丛 = val_266;
            this.丝且与丝丒丟万丁专.七上世丌丘丕万丅东 = 0;
            this.丝且与丝丒丟万丁专.丕专丐上东丑丑下丘 = 0;
            this.丝且与丝丒丟万丁专.丂三丅丘丆丂丛七丌 = 0;
        }
        
        this.丝且与丝丒丟万丁专.丒丕丅下丒丂丛下七 = 0;
        this.丝且与丝丒丟万丁专.丌一丏丘丞东与上世 = this.丝且与丝丒丟万丁专.上丏丙东丁不丕丁丟;
        if(GameConnect.东且三丆丑世世丘丟() != false)
        {
                丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七东专七万世丐丂业:  this.丝且与丝丒丟万丁专.finishedInterfaceLabels, 丕丗丘丑丛与丑业丒:  this.丏三万下丘下专丛专);
        }
        
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                if(TeamDuelController.丅丌丛丏丞上万丛丕 != 0)
        {
                TeamDuelController.丅丌丛丏丞上万丛丕.__unknownFiledOffset_AD = 0;
        }
        
        }
        
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                if((TeamDuelController.丅丌丛丏丞上万丛丕 + 160) == 0)
        {
            goto label_349;
        }
        
        }
        
        ExperienceController.sharedController.下不丌丈下丄丌世七(丙业与丙丗丝不丈东:  true);
        val_259 = WeaponManager.丟丗丄业丘丗业丗七;
        丟丙不上丝丂丄丗三();
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.Clear();
        this.丄丘丛丐丅三丆三丈 = 0;
        if(this.丆丐丐丕世丕丌世与 != false)
        {
                Rilisoft.七丕丟丏三丈一丄世 val_128 = GameConnect.丑丌丛丈丅丅与不业();
            val_265 = Rilisoft.Singleton<ClansController>.Instance;
            if(val_265.丞丗丑丈一丅丗丌丟() != null)
        {
                val_265 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
            if(val_265.丟业丅世丟丗丄丞万() >= 2)
        {
                this.丑丑上丑下丐下丌业 = 0;
        }
        
        }
        
            val_261 = this.不丄丅一一一丏一丌;
            this.丝且与丝丒丟万丁专.不三丒专丗丞一丒丛(业七丅丟东丑专丅万:  this.业七丅丟东丑专丅万, 丟丒丅丂丛丄丗万丌:  this.丟丒丅丂丛丄丗万丌, 不丄丅一一一丏一丌:  val_261, 丁东丄东丑与七丆世:  false, 丕东丈丒与丟丅丞丁:  this.丕东丈丒与丟丅丞丁, 丈三丌丁丈丒丅丌三:  (val_128 == 19) ? 0 : this.丈三丌丁丈丒丅丌三, 七丒丄丙丙三东上丛:  (val_128 == 19) ? this.丈三丌丁丈丒丅丌三 : 0, 丑丑上丑下丐下丌业:  this.丑丑上丑下丐下丌业, 丁丑下丄东丙一丘且:  this.丁丑下丄东丙一丘且, 业专丁丘丐丅万专与:  this.业专丁丘丐丅万专与, 丆世万七丆世丟丌业:  this.丆世万七丆世丟丌业, 丆丈丑下丈丆业东一:  this.丅下七下不东不丂丝, 丄丅丟丟丛丟丟丟上:  this.丄丅丟丟丛丟丟丟上, 丌三丒丌丆东万丆一:  this.丌三丒丌丆东万丆一, 丛丐丌丐不丌丗三丕: out  this.丄丘丛丐丅三丆三丈, 丄丗世丈丈丙不丐丂:  this.丄丗世丈丈丙不丐丂, 丏丝且世丞丅与丆东:  this.丏丝且世丞丅与丆东, 业东丆丒丏丒丒专世:  this.业东丆丒丏丒丒专世, 一下下丛七丈丅丂与:  this.一下下丛七丈丅丂与);
        }
        else
        {
                this.丝且与丝丒丟万丁专.丂世丈丅丟且丆丑丝(丕东丈丒与丟丅丞丁:  this.丕东丈丒与丟丅丞丁);
        }
        
        if((GameConnect.一业上七丟业且业丙() != true) && (GameConnect.不专专丂万丝上东丐() != true))
        {
                if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_378;
        }
        
        }
        
        }
        
        this.丝且与丝丒丟万丁专.backButtonInHunger.SetActive(value:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.randomBtn, 丏业丟一东丂东丘丛:  false);
        val_261 = 0;
        this.丝且与丝丒丟万丁专.randomBtn.丕丞丂丆丁丕三万丟(丛丅丘一丏丙且丌上:  false, 丅丆东丏丙丝丅丆丟:  this.丝且与丝丒丟万丁专.MapSelectPanel, 下丈下七一万丆丁丕:  val_261, 丒丂丑丅丒丁业且与: ref  this.丝且与丝丒丟万丁专.下丂丐上东上丑上东);
        this.丝且与丝丒丟万丁专.spectatorModeBtnPnl.SetActive(value:  false);
        label_378:
        if(GameConnect.业丛丛丂一丆丕丗丟() != false)
        {
                val_265 = this.丄丅丟丟丛丟丟丟上;
            val_259 = this.丁东丄东丑与七丆世;
            val_270 = this.丑丏七丙下丛丐丁一;
            val_261 = val_265;
            this.丝且与丝丒丟万丁专.duelUI.丒丈丗三专丅丒丌三(丆丐丐丕世丕丌世与:  (this.丆丐丐丕世丕丌世与 == true) ? 1 : 0, 业七丅丟东丑专丅万:  this.业七丅丟东丑专丅万, 丄丅丟丟丛丟丟丟上:  val_261, 丟丒丅丂丛丄丗万丌:  this.丟丒丅丂丛丄丗万丌, 丑一丂丙丈丝丑丅丑:  (val_259 == true) ? 1 : 0, 专东丘一三丐不丈专:  (val_270 == true) ? 1 : 0);
        }
        
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                val_259 = this.丕东丈丒与丟丅丞丁;
            val_261 = 0;
            this.丝且与丝丒丟万丁专.teamDuelUI.丒丈丗三专丅丒丌三(丑一丂丙丈丝丑丅丑:  (this.专丌丁且丗与丞丕且 == true) ? 1 : 0, 专东丘一三丐不丈专:  (val_259 == 0) ? 1 : 0);
        }
        
        this.丝且与丝丒丟万丁专.丟业丁丐丟七丒丘业(丑丒业丘丑东丕世丅:  false);
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().gameObject.SetActive(value:  false);
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.专世七丟丄专丁与且();
        this.丝且与丝丒丟万丁专.与与丁下万丈丆丝上 = true;
        if(this.丝且与丝丒丟万丁专.与与丁下万丈丆丝上 == false)
        {
            goto label_395;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        val_260 = 6;
        goto label_478;
        label_395:
        if(this.丝且与丝丒丟万丁专.clanwarChallagne != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专.clanwarChallagne, 丏业丟一东丂东丘丛:  true);
        }
        
        if(((this.丝且与丝丒丟万丁专.clanwarChallagne.一丈丛丘与丕丛丝东() == false) || (this.丆丐丐丕世丕丌世与 == true)) || (GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七 == true))
        {
            goto label_432;
        }
        
        this.丝且与丝丒丟万丁专.backButtonInHunger.SetActive(value:  true);
        if(GameController.丆丘丂丈世丏丟丑丏.万丑丙丄业一丑丏丆 != true)
        {
                val_265 = 1152921505066536960;
            if(GameConnect.七丂万专且丏丘一丙() != true)
        {
                if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_418;
        }
        
        }
        
        }
        
        label_610:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.randomBtn, 丏业丟一东丂东丘丛:  (0 != 0) ? 1 : 0);
        if((GameConnect.万不丒丌丙万丗东不() != true) && (GameConnect.一业上七丟业且业丙() != true))
        {
                if(GameConnect.世丐丄三三上丅七三() != true)
        {
                if(GameConnect.七丂万专且丏丘一丙() == false)
        {
            goto label_432;
        }
        
        }
        
        }
        
        this.丝且与丝丒丟万丁专.spectatorModeBtnPnl.SetActive(value:  丞下丗丞一业丏上不());
        label_432:
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().DisableTrophies();
        if(this.丝且与丝丒丟万丁专.丐丐丑丏丁丙上上丄 == false)
        {
            goto label_440;
        }
        
        if(this.丝且与丝丒丟万丁专.clanwarChallagne != 0)
        {
            goto label_443;
        }
        
        this.丝且与丝丒丟万丁专.丐丐丑丏丁丙上上丄 = false;
        this.丝且与丝丒丟万丁专.OnCWViewShow();
        label_440:
        if((Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世() != null) && (Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业() != null))
        {
                val_271 = Rilisoft.三一丈七且丄与丝东.丑七不且上丗丁一世().丏世丞丕丂丒七上业().业上丙丞丐丄丆丅七();
        }
        else
        {
                val_271 = "";
        }
        
        val_262 = 1152921505058017280;
        val_272 = 1152921504848912384;
        val_259 = 0;
        val_273 = 0;
        if(DuelController.丄丘七三上丕世丞业 == 0)
        {
            goto label_471;
        }
        
        bool val_263 = this.丁东丄东丑与七丆世;
        val_263 = this.丑丏七丙下丛丐丁一 | val_263;
        val_263 = val_263 & 255;
        if(val_263 == false)
        {
            goto label_462;
        }
        
        if(this.丑丏七丙下丛丐丁一 == false)
        {
            goto label_465;
        }
        
        bool val_264 = this.丁东丄东丑与七丆世;
        val_264 = val_264 ^ 1;
        if(DuelController.丄丘七三上丕世丞业 != null)
        {
            goto label_586;
        }
        
        label_587:
        label_586:
        val_273 = DuelController.丄丘七三上丕世丞业.PayBetReward(专东丘一三丐不丈专:  ((val_264 & 255) == true) ? 1 : 0);
        var val_174 = (val_273 != 1) ? 1 : 0;
        if(val_273 == 1)
        {
            goto label_467;
        }
        
        Rilisoft.上专业三丟丁丞专下 val_175 = DuelController.丄丘七三上丕世丞业.GetBetConfigByIndex(丞世不丒下上上丝丑:  val_273);
        val_259 = 1;
        goto label_471;
        label_443:
        val_259 = this.丝且与丝丒丟万丁专.clanwarChallagne._challengeView;
        if(this.丝且与丝丒丟万丁专.clanwarChallagne._challengeView.专下七丌丙丂丟万丐 != false)
        {
                this.丝且与丝丒丟万丁专.interfaceAnimator.SetBool(name:  "ClanWarHide", value:  true);
            val_259 = this.丝且与丝丒丟万丁专.clanwarChallagne._challengeView;
            this.丝且与丝丒丟万丁专.clanwarChallagne._challengeView.专下七丌丙丂丟万丐 = false;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        val_260 = 7;
        goto label_478;
        label_349:
        UnityEngine.Color val_176 = UnityEngine.Color.white;
        val_263 = val_176.r;
        val_264 = val_176.b;
        AutoFade.三丒下丝东七且七丈(世三丏丑丙丅丌且下:  0.5f, 业三一丆丒与丘且业:  0.5f, 丅世丗丛万下下专丕:  0.5f, 一七专业丞丛世且丌:  new UnityEngine.Color() {r = val_263, g = val_176.g, b = val_264, a = val_176.a});
        UnityEngine.WaitForSeconds val_177 = null;
        val_259 = val_177;
        val_177 = new UnityEngine.WaitForSeconds(seconds:  0.55f);
        this.丒上七丌业七丟与丐 = val_259;
        val_260 = 4;
        label_478:
        this.丗丏丅丕丆世丁专丟 = val_260;
        val_269 = 1;
        return (bool)val_269;
        label_462:
        val_259 = 0;
        label_467:
        val_273 = 0;
        label_471:
        if(this.丆丐丐丕世丕丌世与 == false)
        {
            goto label_482;
        }
        
        UnityEngine.Color val_181 = UnityEngine.Color.white;
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().SetRewardSpriteColor(与丄丈丘丟丕丏丐丁:  this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().CoinsReward, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_181.r, g = val_181.g, b = val_181.b, a = val_181.a});
        UnityEngine.Color val_185 = UnityEngine.Color.white;
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().SetRewardSpriteColor(与丄丈丘丟丕丏丐丁:  this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().ExpReward, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_185.r, g = val_185.g, b = val_185.b, a = val_185.a});
        UnityEngine.Color val_189 = UnityEngine.Color.white;
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().SetRewardSpriteColor(与丄丈丘丟丕丏丐丁:  this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().EventReward, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_189.r, g = val_189.g, b = val_189.b, a = val_189.a});
        UnityEngine.Color val_193 = UnityEngine.Color.white;
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().SetRewardSpriteColor(与丄丈丘丟丕丏丐丁:  this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().SniperEventReward, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_193.r, g = val_193.g, b = val_193.b, a = val_193.a});
        UnityEngine.Color val_197 = UnityEngine.Color.white;
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().SetRewardSpriteColor(与丄丈丘丟丕丏丐丁:  this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().BattlePassReward, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_197.r, g = val_197.g, b = val_197.b, a = val_197.a});
        UnityEngine.Color val_201 = UnityEngine.Color.white;
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().SetRewardSpriteColor(与丄丈丘丟丕丏丐丁:  this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().PixelPassCurrencyReward, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_201.r, g = val_201.g, b = val_201.b, a = val_201.a});
        UnityEngine.Color val_205 = UnityEngine.Color.white;
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().SetRewardSpriteColor(与丄丈丘丟丕丏丐丁:  this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().PixelPassExpReward, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_205.r, g = val_205.g, b = val_205.b, a = val_205.a});
        UnityEngine.Color val_209 = UnityEngine.Color.white;
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().SetRewardSpriteColor(与丄丈丘丟丕丏丐丁:  this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().DetailsReward, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_209.r, g = val_209.g, b = val_209.b, a = val_209.a});
        UnityEngine.Color val_213 = UnityEngine.Color.white;
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().SetRewardSpriteColor(与丄丈丘丟丕丏丐丁:  this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().GemsReward, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_213.r, g = val_213.g, b = val_213.b, a = val_213.a});
        UnityEngine.Color val_217 = UnityEngine.Color.white;
        val_263 = val_217.r;
        val_264 = val_217.b;
        val_266 = val_263;
        val_267 = val_217.g;
        val_268 = val_264;
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().SetRewardSpriteColor(与丄丈丘丟丕丏丐丁:  this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().ModuleChestReward, 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_266, g = val_267, b = val_268, a = val_217.a});
        Rilisoft.七丕丟丏三丈一丄世 val_218 = GameConnect.丑丌丛丈丅丅与不业();
        if(this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.下丙丅丑专丝三丗丞() == null)
        {
            goto label_526;
        }
        
        if(this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.下丙丅丑专丝三丗丞() != null)
        {
            goto label_529;
        }
        
        goto label_529;
        label_482:
        this.丝且与丝丒丟万丁专.上丏丙东丁不丕丁丟 = false;
        goto label_530;
        label_526:
        label_529:
        RewardWindowView val_223 = this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七();
        val_274 = this.业七丅丟东丑专丅万;
        val_275 = this.丝且与丝丒丟万丁专.丛丏丒一丗丝丌不丅;
        val_276 = this.丑丑上丑下丐下丌业;
        val_265 = this.业专丁丘丐丅万专与;
        val_270 = this.丄丘丛丐丅三丆三丈;
        if(val_223 == null)
        {
                val_275 = val_275;
            val_276 = val_276;
            val_274 = val_274;
        }
        
        val_223.丘丘丙一与丛丗丅丌(丑丁丐丏业丗一丏丈:  val_274, 丕丗业下七丕丝七三:  val_275, 且丘丞丕丐丗丅丅丂:  (val_218 == 19) ? 0 : this.丈三丌丁丈丒丅丌三, 丙与丂丘丁且七丝丅:  (val_218 == 19) ? this.丈三丌丁丈丒丅丌三 : 0, 丂世业丏丌丛丛丙丘:  val_276, 不丁丛丈丙世丈万丟:  (this.丁丑下丄东丙一丘且 == true) ? 1 : 0, 万丙丒世七不丌丒丐:  val_265, 与上丌丞丙丙丂丈丌:  this.丆世万七丆世丟丌业, 且专不下丒万东丟丏:  this.丅下七下不东不丂丝, 世丕丅与丆丄丗丐万:  this.丄丅丟丟丛丟丟丟上, 下丅丙一丂丗丅丝七:  val_270, 丛丐业丞东七丒下丗:  this.丄丗世丈丈丙不丐丂, 与丑丆丑一丂丑上丙:  this.丏丝且世丞丅与丆东, 丄下丘丘丗丙丙丕丞:  0, 丐下丝丘丑丟丟丗丌:  0);
        val_272 = 1152921504848912384;
        val_273 = val_273;
        val_262 = 1152921505058017280;
        val_259 = val_259;
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().gameObject.SetActive(value:  this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().AnyRewardIsActive());
        this.丝且与丝丒丟万丁专.丑七专东丘丐三下丒.丂丅与丘丂丟丛丙七().Resize();
        label_530:
        if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
            goto label_547;
        }
        
        val_277 = null;
        if(DuelController.丄丘七三上丕世丞业 == 0)
        {
            goto label_547;
        }
        
        val_265 = 1152921505284374528;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.OpenNoAdsButton, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.丝且与丝丒丟万丁专.OpenWithAdsButton, 丏业丟一东丂东丘丛:  false);
        this.丝且与丝丒丟万丁专.betsReward.SetActive(value:  false);
        UnityEngine.Vector3 val_234 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_236 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_234.x, y = val_234.y, z = val_234.z}, d:  (val_259 != 0) ? 360f : 115f);
        this.丝且与丝丒丟万丁专.rewardLabelObject.transform.localPosition = new UnityEngine.Vector3() {x = val_236.x, y = val_236.y, z = val_236.z};
        UnityEngine.Vector3 val_238 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_240 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_238.x, y = val_238.y, z = val_238.z}, d:  (val_259 != 0) ? 1.6f : 1f);
        val_263 = val_240.x;
        val_264 = val_240.z;
        this.丝且与丝丒丟万丁专.rewardLabelObject.transform.localScale = new UnityEngine.Vector3() {x = val_263, y = val_240.y, z = val_264};
        if(val_259 != 0)
        {
                if(0 != 0)
        {
                Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丁丙丛丂丕不一与丂(下上丐丆丝丟丝丒不:  135, 丙业与丙丗丝不丈东:  0.业上丙丞丐丄丆丅七());
        }
        
            val_278 = null;
            val_278 = null;
            val_259 = 0;
            this.丝且与丝丒丟万丁专.betLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  null);
            if(this.丝且与丝丒丟万丁专.betTexture != null)
        {
                this.丝且与丝丒丟万丁专.betTexture = 丞东丑专丛丆丄丝世.丏业丒三且丝丆东与(丟丐一下丞丒业万不:  this.丝且与丝丒丟万丁专.betTexture);
        }
        
            val_273 = val_273 + 1;
            val_262 = "OfferIcons/{0}_chest_{1}";
            val_265 = 1152921524392989440;
            val_279 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/{0}_chest_{1}", arg0:  val_271, arg1:  val_273));
            if(val_279 == 0)
        {
                val_279 = UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "OfferIcons/{0}_chest_{1}", arg0:  "default", arg1:  val_273));
        }
        
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() != 8)
        {
            goto label_584;
        }
        
        label_547:
        val_269 = 0;
        return (bool)val_269;
        label_584:
        this.丝且与丝丒丟万丁专.三与万丝丒一丏丝七 = false;
        return (bool)val_269;
        label_465:
        if(DuelController.丄丘七三上丕世丞业 != null)
        {
            goto label_586;
        }
        
        goto label_587;
        label_293:
        if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
            goto label_606;
        }
        
        val_280 = this.丁东丄东丑与七丆世;
        if(val_280 != false)
        {
                val_281 = null;
            val_281 = null;
        }
        
        var val_252 = (NetworkStartTable.__il2cppRuntimeField_klass != 0) ? 1 : 0;
        goto label_596;
        label_242:
        var val_254 = (~GameConnect.与丂丝丟丟三丑丝万()) & 1;
        if(this.丝且与丝丒丟万丁专.interfaceAnimator != null)
        {
            goto label_599;
        }
        
        goto label_600;
        label_140:
        var val_255 = (this.丈三丌丁丈丒丅丌三 == 0) ? 1 : 0;
        if(this.丝且与丝丒丟万丁专.interfaceAnimator != null)
        {
            goto label_601;
        }
        
        goto label_602;
        label_418:
        val_282 = null;
        val_282 = null;
        bool val_265 = GameController.丆丘丂丈世丏丟丑丏.丐丒丕三丞世丅丐七;
        val_265 = val_265 ^ 1;
        bool val_258 = val_265 & 255;
        goto label_610;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
