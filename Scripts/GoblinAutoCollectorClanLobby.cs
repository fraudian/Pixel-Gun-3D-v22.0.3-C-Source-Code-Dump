using UnityEngine;
internal sealed class GoblinAutoCollectorClanLobby : PGBehaviour
{
    // Fields
    private static System.Action 丅与丂七专下丒丌丘;
    internal static GoblinAutoCollectorClanLobby 丆丕丝丒不丙且丐丗;
    private UnityEngine.GameObject _graphic;
    private UnityEngine.GameObject _modelIdle;
    private UnityEngine.GameObject _modelFear;
    private GoblinHeader _headerIdle;
    private GoblinHeader _headerFear;
    private UnityEngine.Coroutine 丟丁东丘丝丙丑上万;
    
    // Methods
    internal static void 丌上丁业丐丟丐与丝(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  GoblinAutoCollectorClanLobby.丅与丂七专下丒丌丘, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 一三世丝丙丒上丒业(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  GoblinAutoCollectorClanLobby.丅与丂七专下丒丌丘, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    private void Awake()
    {
        GoblinAutoCollectorClanLobby.丆丕丝丒不丙且丐丗 = this;
        this.丛且丐下世与丘丆丗();
    }
    private void OnEnable()
    {
        this.丄丅不丄丐丘丙丝丑();
    }
    private void OnDestroy()
    {
        this.丞且东丒专丁万且七();
    }
    private void 丛且丐下世与丘丆丗()
    {
        一丅三东丑丗丅丗丝.世丝丄丂万丐丑丁下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GoblinAutoCollectorClanLobby::且万一下丝七与万七()));
    }
    private void 丞且东丒专丁万且七()
    {
        一丅三东丑丗丅丗丝.丄丌丗丙三世丞丕三(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void GoblinAutoCollectorClanLobby::且万一下丝七与万七()));
    }
    private void 丄丅不丄丐丘丙丝丑()
    {
        if(一丅三东丑丗丅丗丝.丗丞丌世丟丝三七丄() != null)
        {
                this.业丒丏丗丘丆丏专下();
            return;
        }
        
        this.且三丛三丟不业丛一(丙业与丙丗丝不丈东:  false);
    }
    private void OnApplicationPause(bool 东丗七丕丄不丐专丒)
    {
        if(东丗七丕丄不丐专丒 != false)
        {
                return;
        }
        
        System.Action val_1 = new System.Action(object:  this, method:  System.Void GoblinAutoCollectorClanLobby::丄丅不丄丐丘丙丝丑());
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  val_1.丗世与专丝丄下丝丟(丒丏下万世七丆上不:  val_1));
    }
    private void 且万一下丝七与万七()
    {
        System.Action val_1 = new System.Action(object:  this, method:  System.Void GoblinAutoCollectorClanLobby::业丒丏丗丘丆丏专下());
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  val_1.丗世与专丝丄下丝丟(丒丏下万世七丆上不:  val_1));
    }
    private System.Collections.IEnumerator 丗世与专丝丄下丝丟(System.Action 丒丏下万世七丆上不)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丒丏下万世七丆上不 = 丒丏下万世七丆上不;
        return (System.Collections.IEnumerator)new GoblinAutoCollectorClanLobby.万丗七不且业丂丅丘();
    }
    private void 业丒丏丗丘丆丏专下()
    {
        if(this.gameObject == 0)
        {
                return;
        }
        
        if(this.gameObject.activeSelf == false)
        {
                return;
        }
        
        if(this.gameObject.activeInHierarchy == false)
        {
                return;
        }
        
        this.且三丛三丟不业丛一(丙业与丙丗丝不丈东:  true);
        this.丞上世丈丂丟不世一();
        if(this.丟丁东丘丝丙丑上万 != null)
        {
                CoroutineRunner.Instance.StopCoroutine(routine:  this.丟丁东丘丝丙丑上万);
        }
        
        this.丟丁东丘丝丙丑上万 = this.StartCoroutine(routine:  this.丛丙不丅丂丗丛丈丄());
    }
    private void 且三丛三丟不业丛一(bool 丙业与丙丗丝不丈东)
    {
        if(this._graphic.gameObject.activeSelf ^ 丙业与丙丗丝不丈东 != false)
        {
                this._graphic.SetActive(value:  丙业与丙丗丝不丈东);
            if(GoblinAutoCollectorClanLobby.丅与丂七专下丒丌丘 != null)
        {
                GoblinAutoCollectorClanLobby.丅与丂七专下丒丌丘.Invoke();
        }
        
        }
        
        bool val_5 = 丙业与丙丗丝不丈东;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._headerIdle, 丏业丟一东丂东丘丛:  val_5);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this._headerFear, 丏业丟一东丂东丘丛:  val_5);
    }
    private void 丞上世丈丂丟不世一()
    {
        UnityEngine.GameObject val_3;
        var val_4;
        if((Rilisoft.Singleton<PGCompany.ClanWarController>.Instance.丐不业一业丁丞世丏()) == 1)
        {
                this._modelFear.SetActive(value:  true);
            val_3 = this._modelIdle;
            val_4 = 0;
        }
        else
        {
                this._modelFear.SetActive(value:  false);
            val_3 = this._modelIdle;
            val_4 = 1;
        }
        
        val_3.SetActive(value:  true);
    }
    internal void 丈专丂丑且不丟上丕()
    {
        if(一丅三东丑丗丅丗丝.丗丁丈丐丗一与丝与() > 0)
        {
                Rilisoft.ClansLobbyGui val_2 = Rilisoft.ClansLobbyGui.丑七不且上丗丁一世();
            val_2.GoblinAutoCollectorUi.丈且东丑丂且万丒丅(丙且丄丑丂万丅丘丗:  1);
            return;
        }
        
        this.且三丛三丟不业丛一(丙业与丙丗丝不丈东:  false);
    }
    private System.Collections.IEnumerator 丛丙不丅丂丗丛丈丄()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GoblinAutoCollectorClanLobby.丒丒丟丂丞丌三丐七();
    }
    public GoblinAutoCollectorClanLobby()
    {
    
    }

}
