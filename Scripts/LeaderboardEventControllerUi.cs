using UnityEngine;
internal sealed class LeaderboardEventControllerUi : PGBehaviour
{
    // Fields
    internal static LeaderboardEventControllerUi 丆丕丝丒不丙且丐丗;
    private EndlessScrollDynamic _eventTournamentScroll;
    private UIPanel _scrollPanel;
    private UnityEngine.Transform _topBound;
    private UnityEngine.Transform _bottomBound;
    private PlayerScoreUi _dublicateMyPlayerScoreUi;
    private UnityEngine.GameObject _generalHolderGo;
    private UnityEngine.GameObject _updatingPanelGo;
    private float _cooldownUpdatingPanel;
    private int 丑下丈丝丅丒丄东丐;
    private System.Collections.Generic.List<丂丟丙丌丞七东丑丁> 丅丄世丄丝上与丌东;
    private PlayerScoreUi 一丛且丛与下且且丐;
    private TournamentPlayer 丛丛丐丑丈丙东万丈;
    private int 丌丂丂丛上三丐丙不;
    private int 丑丒专丗丐丌丄不且;
    
    // Methods
    private void Awake()
    {
        if(LeaderboardEventControllerUi.丆丕丝丒不丙且丐丗 != 0)
        {
                UnityEngine.Object.DestroyImmediate(obj:  this);
            return;
        }
        
        LeaderboardEventControllerUi.丆丕丝丒不丙且丐丗 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this);
        this.丒丕丙丐与丕七丘与();
        this._generalHolderGo.SetActive(value:  false);
        this._updatingPanelGo.SetActive(value:  false);
        this._eventTournamentScroll.remove_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCellDynamic>(object:  this, method:  System.Void LeaderboardEventControllerUi::丗丞丒丙与丄丕丒丄(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)));
        this._eventTournamentScroll.add_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCellDynamic>(object:  this, method:  System.Void LeaderboardEventControllerUi::丗丞丒丙与丄丕丒丄(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)));
        LeaderboardEventController.不丛丞丌三丗丁丄东(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void LeaderboardEventControllerUi::东上万七丙丈丛丏丆(int 丟丟丄专上丟丁丐丝)));
        LeaderboardEventController.万丅丞丐丒世专丆丅(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void LeaderboardEventControllerUi::东上万七丙丈丛丏丆(int 丟丟丄专上丟丁丐丝)));
    }
    private void OnDestroy()
    {
        LeaderboardEventController.不丛丞丌三丗丁丄东(丙业与丙丗丝不丈东:  new System.Action<System.Int32>(object:  this, method:  System.Void LeaderboardEventControllerUi::东上万七丙丈丛丏丆(int 丟丟丄专上丟丁丐丝)));
        this._eventTournamentScroll.remove_onUpdateCell(丙业与丙丗丝不丈东:  new System.Action<EndlessScrollCellDynamic>(object:  this, method:  System.Void LeaderboardEventControllerUi::丗丞丒丙与丄丕丒丄(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)));
    }
    private void OnEnable()
    {
        this.丐丟不七专丂丁世丟();
    }
    private void 丐丟不七专丂丁世丟()
    {
        if(this.丑下丈丝丅丒丄东丐 == 1)
        {
                return;
        }
        
        if(this._dublicateMyPlayerScoreUi != 0)
        {
                this._dublicateMyPlayerScoreUi.丂下不丘丑与业东与(不丆业丏上丐与丌业:  ProfileController.丆三丂丂丆上丆丕专());
        }
        
        if(this.一丛且丛与下且且丐 == 0)
        {
                return;
        }
        
        this.一丛且丛与下且且丐.丂下不丘丑与业东与(不丆业丏上丐与丌业:  ProfileController.丆三丂丂丆上丆丕专());
    }
    private void 丒丕丙丐与丕七丘与()
    {
        int val_1 = this._dublicateMyPlayerScoreUi.丝丌且丄不世三业上();
        var val_2 = (val_1 < 0) ? (val_1 + 1) : (val_1);
        val_2 = val_2 >> 1;
        float val_3 = S8 - (float)val_2;
        this._topBound.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        int val_4 = this._dublicateMyPlayerScoreUi.丝丌且丄不世三业上();
        var val_5 = (val_4 < 0) ? (val_4 + 1) : (val_4);
        val_5 = val_5 >> 1;
        float val_6 = S8 + (float)val_5;
        this._bottomBound.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void 万丙丒万丑丕丛丑一()
    {
        if(this.丛丛丐丑丈丙东万丈 != null)
        {
                this._dublicateMyPlayerScoreUi.丈且东丑丂且万丒丅(且丒丛与丞世丙丕丌:  this.丑丒专丗丐丌丄不且, 丞丅上丏丂且下丅与:  this.丛丛丐丑丈丙东万丈.id, 不丆业丏上丐与丌业:  this.丛丛丐丑丈丙东万丈.nickname, 万且丒下丕丝专丟上:  this.丛丛丐丑丈丙东万丈.score);
        }
        
        this._dublicateMyPlayerScoreUi.gameObject.SetActive(value:  false);
    }
    internal void 下与丞三丅丛丄七丕()
    {
        static_value_081DACA8 = static_value_081DACA8;
        int val_1 = static_value_081DACA8 + 184 + 16 + 48 + 136 + 408.业上丙丞丐丄丆丅七();
        if((this.丐丙丞一丕丏万丐丒(丟丟丄专上丟丁丐丝:  val_1, 丝丞东丙丂丏丙丞丕:  false)) == false)
        {
                return;
        }
        
        LeaderboardEventController.丑丐丄丆丛丁丟丗丅.丏丑万丌丘万三丙与(丟丟丄专上丟丁丐丝:  val_1);
        this.丑下丈丝丅丒丄东丐 = val_1;
    }
    private bool 丐丙丞一丕丏万丐丒(int 丟丟丄专上丟丁丐丝, bool 丝丞东丙丂丏丙丞丕 = False)
    {
        System.Collections.Generic.List<丂丟丙丌丞七东丑丁> val_9;
        bool val_3 = ((this.丑下丈丝丅丒丄东丐.Equals(obj:  丟丟丄专上丟丁丐丝)) ^ 1) | 丝丞东丙丂丏丙丞丕;
        if(val_3 != false)
        {
                val_9 = LeaderboardEventController.丑丐丄丆丛丁丟丗丅.与丝丁丘世丏丆丏丙(丟丟丄专上丟丁丐丝:  丟丟丄专上丟丁丐丝, 丒丒且丟东七世丐丆: ref  this.丛丛丐丑丈丙东万丈, 七丂一与丏丂七万丛: ref  this.丌丂丂丛上三丐丙不, 丅丕世与丁丘丆专三: ref  this.丑丒专丗丐丌丄不且);
            this.丅丄世丄丝上与丌东 = val_9;
        }
        else
        {
                val_9 = this.丅丄世丄丝上与丌东;
        }
        
        if(this._generalHolderGo == null)
        {
            goto label_4;
        }
        
        if(val_9 == null)
        {
            goto label_5;
        }
        
        label_10:
        val_9 = 1;
        this._generalHolderGo.SetActive(value:  true);
        if(val_3 == false)
        {
                return (bool)val_9;
        }
        
        this._eventTournamentScroll.Init(上专丅业三丏丈丈丗:  this.丅丄世丄丝上与丌东.Count, 丏丑丝万下与丁丞业:  0);
        this.万丙丒万丑丕丛丑一();
        val_9 = 1;
        return (bool)val_9;
        label_4:
        if(val_9 != null)
        {
            goto label_10;
        }
        
        label_5:
        this._generalHolderGo.SetActive(value:  false);
        return (bool)val_9;
    }
    internal void 丗丟万丂丘丈专丄丂()
    {
        this._generalHolderGo.SetActive(value:  false);
    }
    private void 丗丞丒丙与丄丕丒丄(EndlessScrollCellDynamic 丌丝万上丅丒一丈丘)
    {
        EndlessScrollCellDynamic val_5 = 丌丝万上丅丒一丈丘;
        if(val_5 != null)
        {
                val_5 = 0;
        }
        
        if( == 0)
        {
                return;
        }
        
        丈且东丑丂且万丒丅(丘丟丒丘下专丂丒业:  this.丈丈丘丑下丌丑丐丝(丞世不丒下上上丝丑:  val_5.Index));
    }
    private void Update()
    {
        this.丝三丐丙东丆丆丌不();
    }
    private void 丝三丐丙东丆丆丌不()
    {
        var val_20;
        float val_24;
        float val_25;
        float val_26;
        UnityEngine.Transform val_28;
        val_20 = this;
        if(this.丛丛丐丑丈丙东万丈 == null)
        {
            goto label_1;
        }
        
        if(this.一丛且丛与下且且丐 != 0)
        {
            goto label_4;
        }
        
        this._dublicateMyPlayerScoreUi.gameObject.SetActive(value:  true);
        if(this.丁上丈丅七丑下丗丛() == false)
        {
            goto label_8;
        }
        
        if(this._topBound != null)
        {
            goto label_23;
        }
        
        label_24:
        label_23:
        UnityEngine.Vector3 val_5 = 0.localPosition;
        val_24 = val_5.x;
        val_25 = val_5.y;
        val_26 = val_5.z;
        if(this._dublicateMyPlayerScoreUi.transform != null)
        {
            goto label_11;
        }
        
        goto label_11;
        label_1:
        label_35:
        this._dublicateMyPlayerScoreUi.gameObject.SetActive(value:  false);
        return;
        label_4:
        UnityEngine.Vector3 val_8 = this.一丛且丛与下且且丐.transform.position;
        UnityEngine.Vector3 val_10 = this._topBound.transform.position;
        if(val_8.y <= val_10.y)
        {
            goto label_18;
        }
        
        this._dublicateMyPlayerScoreUi.gameObject.SetActive(value:  true);
        UnityEngine.Transform val_12 = this._dublicateMyPlayerScoreUi.transform;
        val_28 = this._topBound;
        goto label_22;
        label_8:
        if(this._bottomBound != null)
        {
            goto label_23;
        }
        
        goto label_24;
        label_18:
        UnityEngine.Vector3 val_14 = this.一丛且丛与下且且丐.transform.position;
        UnityEngine.Vector3 val_16 = this._bottomBound.transform.position;
        if(val_14.y >= 0)
        {
            goto label_35;
        }
        
        this._dublicateMyPlayerScoreUi.gameObject.SetActive(value:  true);
        val_28 = this._bottomBound;
        label_22:
        val_20 = this._dublicateMyPlayerScoreUi.transform;
        UnityEngine.Vector3 val_19 = val_28.localPosition;
        val_24 = val_19.x;
        val_25 = val_19.y;
        val_26 = val_19.z;
        label_11:
        val_20.localPosition = new UnityEngine.Vector3() {x = val_24, y = val_25, z = val_26};
    }
    internal void 三丛七下业东丏丘丈(PlayerScoreUi 七上世丗丄一业丅且)
    {
        this.一丛且丛与下且且丐 = 七上世丗丄一业丅且;
    }
    private 丂丟丙丌丞七东丑丁 丈丈丘丑下丌丑丐丝(int 丞世不丒下上上丝丑)
    {
        System.Collections.Generic.List<丂丟丙丌丞七东丑丁> val_4;
        var val_5;
        val_4 = this.丅丄世丄丝上与丌东;
        val_5 = 0;
        if((丞世不丒下上上丝丑 & 2147483648) != 0)
        {
                return (丂丟丙丌丞七东丑丁)val_5;
        }
        
        if(val_4.Count == 0)
        {
                return (丂丟丙丌丞七东丑丁)val_5;
        }
        
        val_4 = this.丅丄世丄丝上与丌东;
        if(val_4.Count > 丞世不丒下上上丝丑)
        {
                丂丟丙丌丞七东丑丁 val_3 = this.丅丄世丄丝上与丌东.Item[丞世不丒下上上丝丑];
            return (丂丟丙丌丞七东丑丁)val_5;
        }
        
        val_5 = 0;
        return (丂丟丙丌丞七东丑丁)val_5;
    }
    private void 东上万七丙丈丛丏丆(int 丟丟丄专上丟丁丐丝)
    {
        int val_6 = 丟丟丄专上丟丁丐丝;
        LeaderboardEventControllerUi.世丘丛上丞丆丟丟丐 val_1 = new LeaderboardEventControllerUi.世丘丛上丞丆丟丟丐();
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丟丟丄专上丟丁丐丝 = val_6;
        }
        else
        {
                mem[16] = this;
            mem[24] = val_6;
            val_6 = mem[24];
        }
        
        if((this.丑下丈丝丅丒丄东丐.Equals(obj:  val_6)) == false)
        {
                return;
        }
        
        val_6 = this._generalHolderGo;
        if(val_6.activeSelf == false)
        {
                return;
        }
        
        this._updatingPanelGo.SetActive(value:  true);
        UnityEngine.Coroutine val_5 = CoroutineRunner.不七丏丝丒一下丄万(丂三丟丂丈丐丆丗丟:  this._cooldownUpdatingPanel, 七丐丅专且专七三丆:  new System.Action(object:  val_1, method:  System.Void LeaderboardEventControllerUi.世丘丛上丞丆丟丟丐::上丕丘丆一丌丐丙一()));
    }
    private bool 丁上丈丅七丑下丗丛()
    {
        var val_4;
        List.Enumerator<T> val_1 = this._eventTournamentScroll.cellsList.GetEnumerator();
        label_5:
        if(((-1787314696) & 1) == 0)
        {
            goto label_3;
        }
        
        if(this.丌丂丂丛上三丐丙不 <= 0.丐丏七丌丕丗业且上().Index)
        {
            goto label_5;
        }
        
        val_4 = 0;
        goto label_6;
        label_3:
        val_4 = 1;
        label_6:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool);
    }
    public LeaderboardEventControllerUi()
    {
        this._cooldownUpdatingPanel = 1.007812f;
        this.丑下丈丝丅丒丄东丐 = 0;
        this.丅丄世丄丝上与丌东 = new System.Collections.Generic.List<丂丟丙丌丞七东丑丁>();
    }

}
