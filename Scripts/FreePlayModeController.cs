using UnityEngine;
internal sealed class FreePlayModeController : OnlineModeController
{
    // Fields
    internal const int 丏丗丙丄丞丄丝丌丈 = 4;
    public FreeplayModeVehicleController vehicleController;
    public FreeplayScoreController timeScoreController;
    public PGCompany.FreePlay.Squad.丘专丛不三且丅丐丑 squadUiController;
    private FreeplayVehicleSpawnSelector 丝丅丛丗与丁丅丝丗;
    private UnityEngine.AudioClip carSpawnSound;
    internal 世三丑上丂三专丐丙 丕万丝丐不三丂丘丝;
    
    // Properties
    set; }
    internal bool 丛丟丛丅一丁丄丙东 { get; }
    
    // Methods
    internal void 丕丞丛不丝一七丒下(FreeplayVehicleSpawnSelector 丙业与丙丗丝不丈东)
    {
        this.丝丅丛丗与丁丅丝丗 = 丙业与丙丗丝不丈东;
        if(this.vehicleController == 0)
        {
                return;
        }
        
        this = this.丝丅丛丗与丁丅丝丗;
        this.vehicleController.与丄丕专丞丅下不七 = this;
    }
    private void Start()
    {
        var val_8;
        System.Action<与丅丕丈丘东丝世丟> val_9;
        var val_10;
        var val_11;
        System.Action<与丅丕丈丘东丝世丟> val_12;
        val_8 = null;
        val_8 = null;
        val_10 = null;
        val_11 = null;
        if(((System.Delegate.Combine(a:  GameConnect.丆且丏丂丁且专一下, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void FreePlayModeController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 万且万且丑丗且丌丆)))) != null) && (null != val_11))
        {
                val_10 = null;
            val_11 = null;
            val_9 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_9;
        if(((System.Delegate.Combine(a:  GameConnect.丅三业三丙专丏丟丐, b:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void FreePlayModeController::OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 万且万且丑丗且丌丆)))) != null) && (null != null))
        {
                val_12 = 0;
        }
        
        GameConnect.丅三业三丙专丏丟丐 = val_12;
        FreePlayTaskController val_6 = Rilisoft.Singleton<FreePlayTaskController>.Instance;
        FreePlayTaskController.丈丘与丝丐一丁丁与(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void FreePlayModeController::七丑丒专丁丙东且丅(PGCompany.世丐下丕专东丘丏且 三东丏丐丟三丕丈上)));
    }
    internal bool 丄丗三丌世东业上丌()
    {
        if(this.丕万丝丐不三丂丘丝 == null)
        {
                return (bool)this.丕万丝丐不三丂丘丝;
        }
        
        return this.丕万丝丐不三丂丘丝.丆世一丄丞专丗不东();
    }
    internal void 丈七丈丙东上丙下业()
    {
        if(this.丕万丝丐不三丂丘丝 == null)
        {
                return;
        }
        
        if(this.丕万丝丐不三丂丘丝.丆世一丄丞专丗不东() == false)
        {
                return;
        }
        
        if(this.丕万丝丐不三丂丘丝.东与丗丂丛丌丁丁丄() == false)
        {
                return;
        }
        
        this.丕万丝丐不三丂丘丝.不三丟丟专丗万业下();
    }
    internal void 丁丑丅丁丛七丆上丘(NetworkStartTable 下业七丕丝不世上丟)
    {
        var val_4;
        var val_7;
        var val_8;
        if(this.丕万丝丐不三丂丘丝 == null)
        {
                return;
        }
        
        if(this.丕万丝丐不三丂丘丝.丆世一丄丞专丗不东() != false)
        {
                val_4 = null;
            val_4 = null;
            val_7 = 1;
        }
        else
        {
                if((this.丕万丝丐不三丂丘丝.丐丘专与上不丗丕丌(下业七丕丝不世上丟:  下业七丕丝不世上丟)) != false)
        {
                typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_28.东丞专丗不丏丏一丞(业丏丈世世世丞丒世:  new System.Action<System.Nullable<System.Boolean>>(object:  this.丕万丝丐不三丂丘丝, method:  System.Void 世三丑上丂三专丐丙::业一丘专丈丂三丑丗(System.Nullable<bool> 丙业与丙丗丝不丈东)), 丒与不丑丅丄一东丈:  下业七丕丝不世上丟.丂丈丐不丏万三七丐);
            return;
        }
        
            val_8 = null;
            val_8 = null;
            val_7 = 0;
        }
        
        下业七丕丝不世上丟.上丏七且丙丕不丞丘(且丏丝丂丑丅丄丈丏:  false, 万万丛丒丑丁丙业丑:  NetworkStartTable.__il2cppRuntimeField_cctor_thread, 与一丅三下丅丘丗三:  false, 丘丂丌丈丟东三业丟:  NetworkStartTable.__il2cppRuntimeField_method_count);
    }
    internal void 世专丐丕七丈丗世丑(string 丈丏丕丛丟丘万丛丄, NetworkStartTable 专丞上七七且丝七丗)
    {
        if(this.丕万丝丐不三丂丘丝 == null)
        {
                return;
        }
        
        if(this.丕万丝丐不三丂丘丝.丆世一丄丞专丗不东() == false)
        {
                return;
        }
        
        this = this.丕万丝丐不三丂丘丝.丅与丅丛丏万三丙七;
        if((this.Equals(value:  丈丏丕丛丟丘万丛丄)) == false)
        {
                return;
        }
        
        typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_28.七上丂丞上丝丈业万(丒丘丏上丙丟丑丕丈:  专丞上七七且丝七丗.丂丈丐不丏万三七丐);
    }
    internal bool 丆丑万丝与一与丅丌(string 一丌一丕下专丙世丘)
    {
        世三丑上丂三专丐丙 val_2 = this.丕万丝丐不三丂丘丝;
        if(val_2 == null)
        {
                return (bool)val_2;
        }
        
        if(val_2.丆世一丄丞专丗不东() != false)
        {
                val_2 = 0;
            return (bool)val_2;
        }
        
        this.丕万丝丐不三丂丘丝.丛丕丆丛丏专丙七东(丈丏丕丛丟丘万丛丄:  一丌一丕下专丙世丘, 丆丄且丐丕东三丘丏:  false);
        val_2 = 1;
        return (bool)val_2;
    }
    internal void 三丑丟丞丘丘下丟丆(Player_move_c 与丅业丕丑上丝丒丁, bool 丅丟东世专丂丁上下)
    {
        if(this.丕万丝丐不三丂丘丝 == null)
        {
                return;
        }
        
        if(this.丕万丝丐不三丂丘丝.丆世一丄丞专丗不东() == false)
        {
                return;
        }
        
        bool val_2 = this.丕万丝丐不三丂丘丝.东丟一七丁丞丝丏丕();
    }
    internal bool 丘七丈丅丐丄丐丗万(FreeplayVehicleOwner 七三丁丄三一且丘上)
    {
        if(this.丕万丝丐不三丂丘丝 == null)
        {
                return false;
        }
        
        if(this.丕万丝丐不三丂丘丝.丆世一丄丞专丗不东() == false)
        {
                return false;
        }
        
        if(this.丕万丝丐不三丂丘丝 != null)
        {
                return this.丕万丝丐不三丂丘丝.丘七丈丅丐丄丐丗万(七三丁丄三一且丘上:  七三丁丄三一且丘上);
        }
        
        return this.丕万丝丐不三丂丘丝.丘七丈丅丐丄丐丗万(七三丁丄三一且丘上:  七三丁丄三一且丘上);
    }
    internal bool 与丒与丐丂丘丂丒丕(Player_move_c 专丞上七七且丝七丗)
    {
        UnityEngine.Object val_4;
        世三丑上丂三专丐丙 val_5;
        val_4 = 专丞上七七且丝七丗;
        if(val_4 != 0)
        {
                val_5 = this.丕万丝丐不三丂丘丝;
            if(val_5 == null)
        {
                return (bool)val_5;
        }
        
            if(val_5.丆世一丄丞专丗不东() != false)
        {
                val_4 = 专丞上七七且丝七丗.丟三丏丅世一丟丟上;
            var val_3 = (专丞上七七且丝七丗.丟三丏丅世一丟丟上.丞丗丅东业丑不丙丞 == true) ? 1 : 0;
            return (bool)val_5;
        }
        
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    protected override void 丛丁丈丐丗丄丐下丌()
    {
        var val_6;
        var val_7;
        string val_8;
        this.丛丁丈丐丗丄丐下丌();
        if(this.丕万丝丐不三丂丘丝 == null)
        {
                this.丕万丝丐不三丂丘丝 = new 世三丑上丂三专丐丙(丅三七丞丝丁专不丕:  4);
        }
        
        if((世三丑上丂三专丐丙)[1152921537554986512].丕丕丛专丒世三且不 == 0)
        {
                if(this.丕万丝丐不三丂丘丝.丆世一丄丞专丗不东() == false)
        {
                return;
        }
        
        }
        
        ExitGames.Client.Photon.Hashtable val_3 = new ExitGames.Client.Photon.Hashtable();
        val_6 = null;
        val_6 = null;
        if((X22 + 80) != 0)
        {
                val_7 = null;
            val_7 = null;
            val_8 = 1152921505323888672;
        }
        else
        {
                val_8 = this.丕万丝丐不三丂丘丝.丅与丅丛丏万三丙七;
        }
        
        val_3.Add(key:  GameConnect.与丈业东丂丘丅三丙, value:  mem[this.丕万丝丐不三丂丘丝.丅与丅丛丏万三丙七]);
        丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_3, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        bool val_5 = this.丕万丝丐不三丂丘丝.丆世一丄丞专丗不东();
        if(this.丕万丝丐不三丂丘丝 == null)
        {
            goto label_19;
        }
        
        if(val_5 == false)
        {
            goto label_20;
        }
        
        label_21:
        this.丕万丝丐不三丂丘丝.丅世东丂丘世丏下东();
        return;
        label_19:
        if(val_5 == true)
        {
            goto label_21;
        }
        
        label_20:
        this.丕万丝丐不三丂丘丝.丛七不下业东世与丑();
    }
    public override void LocalEndMode(BaseConditionEndRound 丅丈丌丅专丐丈丞东)
    {
        this.LocalEndMode(丅丈丌丅专丐丈丞东:  丅丈丌丅专丐丈丞东);
    }
    internal override void 丝丐不东一一丁丌七()
    {
        this.丝丐不东一一丁丌七();
        this.丙丅与万丟世一丙丂(丙业与丙丗丝不丈东:  0);
    }
    public override void Initialize()
    {
        this.Initialize();
        this.squadUiController = new PGCompany.FreePlay.Squad.丘专丛不三且丅丐丑(且与万万丝三一丂丈:  this);
    }
    protected override void 丞丞下丒丅丅丛世丕(bool 丂丘下万丈丘丅一丄)
    {
        var val_2;
        丂丘下万丈丘丅一丄 = 丂丘下万丈丘丅一丄;
        this.丞丞下丒丅丅丛世丕(丂丘下万丈丘丅一丄:  丂丘下万丈丘丅一丄);
        if((true != 0) && (0 != 0))
        {
                丂丘下万丈丘丅一丄.丒丆且丑业世丅三上();
            this.上不丒丄世丞丈丙三();
        }
        else
        {
                丂丘下万丈丘丅一丄.ShowStartInterface();
            this.丒东丅下丒业丂丗丄(丙业与丙丗丝不丈东:  true);
        }
        
        val_2 = 0;
        goto label_9;
        label_14:
        UnityEngine.Object.Destroy(obj:  UnityEngine.Object.FindObjectsOfType<SafeZonesController>()[0]);
        val_2 = 1;
        label_9:
        if(val_2 < val_1.Length)
        {
            goto label_14;
        }
    
    }
    internal void 丌丙丞世且丗丛丟丟()
    {
        InGameGUI val_16;
        if(this.vehicleController == 0)
        {
                return;
        }
        
        if(this.vehicleController.不一一丕丘丆且丈下() != false)
        {
                return;
        }
        
        UnityEngine.Events.UnityAction val_3 = new UnityEngine.Events.UnityAction(object:  this, method:  System.Void FreePlayModeController::业七且不丆上三丕丐());
        val_16 = InGameGUI.丙丞专丌丁丞与不丐;
        if((UnityEngine.Object.op_Implicit(exists:  val_16)) == false)
        {
            goto label_30;
        }
        
        val_16 = mem[InGameGUI.丙丞专丌丁丞与不丐 + 872];
        val_16 = InGameGUI.丙丞专丌丁丞与不丐.丈三丁丆丅且丂与丂;
        if(((UnityEngine.Object.op_Implicit(exists:  val_16)) == false) || ((UnityEngine.Object.op_Implicit(exists:  typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_178)) == false))
        {
            goto label_30;
        }
        
        val_16 = this.vehicleController.丂一丞丝丄丑与丝丄();
        if((UnityEngine.Object.op_Implicit(exists:  val_16)) == false)
        {
            goto label_30;
        }
        
        val_16 = this.vehicleController.丂一丞丝丄丑与丝丄();
        if(val_16.不丐一丙丏丑丑丗一() == false)
        {
            goto label_30;
        }
        
        val_16 = this.vehicleController.丂一丞丝丄丑与丝丄();
        if((val_16 & 1) == 0)
        {
            goto label_33;
        }
        
        label_30:
        val_3.Invoke();
        return;
        label_33:
        TransportControllerBase val_13 = this.vehicleController.丂一丞丝丄丑与丝丄();
        typeof(InGameGUIPart_Freeplay).__il2cppRuntimeField_178.世一丛丞世丁专丘丐(丕丗丘丑丛与丑业丒:  System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_12767"), arg0:  丛且丗丌丏下七下丈.七业丑不七丐业丟丂(丞一丁业丄一一业且:  val_13.不丞丒下丕丙东东且)), 七丑丞丟东东一丞丁:  val_3);
    }
    internal override bool 丟丘三丟且一丗丕与(丕丁丕上与丅不丙丄 丏业丟一东丂东丘丛)
    {
        if(丏业丟一东丂东丘丛.timeEndMatch == this.timeScoreController.丕丟丛丑丕万丛丟不())
        {
                return this.丟丘三丟且一丗丕与(丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
        }
        
        丏业丟一东丂东丘丛.丟丞丗上丂世丄与丞();
        return this.丟丘三丟且一丗丕与(丏业丟一东丂东丘丛:  丏业丟一东丂东丘丛);
    }
    protected override void 丟不东丌丕不丐专业()
    {
        this.丟不东丌丕不丐专业();
        if(this.丕万丝丐不三丂丘丝 == null)
        {
                return;
        }
        
        this.丕万丝丐不三丂丘丝.丛七不下业东世与丑();
    }
    private void OnDestroy()
    {
        var val_9;
        System.Action<与丅丕丈丘东丝世丟> val_10;
        var val_11;
        var val_12;
        System.Action<与丅丕丈丘东丝世丟> val_13;
        val_9 = null;
        val_9 = null;
        val_11 = null;
        val_12 = null;
        if(((System.Delegate.Remove(source:  GameConnect.丆且丏丂丁且专一下, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void FreePlayModeController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 万且万且丑丗且丌丆)))) != null) && (null != val_12))
        {
                val_11 = null;
            val_12 = null;
            val_10 = 0;
        }
        
        GameConnect.丆且丏丂丁且专一下 = val_10;
        if(((System.Delegate.Remove(source:  GameConnect.丅三业三丙专丏丟丐, value:  new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void FreePlayModeController::OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 万且万且丑丗且丌丆)))) != null) && (null != null))
        {
                val_13 = 0;
        }
        
        GameConnect.丅三业三丙专丏丟丐 = val_13;
        UnityEngine.Object.Destroy(obj:  Rilisoft.Singleton<FreePlayTaskController>.Instance.gameObject);
        FreePlayTaskController.丏丛与丌且一世丄丛(丙业与丙丗丝不丈东:  new System.Action<PGCompany.世丐下丕专东丘丏且>(object:  this, method:  System.Void FreePlayModeController::七丑丒专丁丙东且丅(PGCompany.世丐下丕专东丘丏且 三东丏丐丟三丕丈上)));
    }
    private void OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 万且万且丑丗且丌丆)
    {
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        下丑东丏世专丗丌三();
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 万且万且丑丗且丌丆)
    {
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        下丑东丏世专丗丌三();
    }
    private void 七丑丒专丁丙东且丅(PGCompany.世丐下丕专东丘丏且 三东丏丐丟三丕丈上)
    {
        if(三东丏丐丟三丕丈上.世丈丁业丛上丘丗丐() == null)
        {
            
        }
    
    }
    public FreePlayModeController()
    {
    
    }
    private void 业七且不丆上三丕丐()
    {
        if(this.vehicleController.丕丐丙丞上三下不丏() == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        UnityEngine.AudioSource val_3 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this.carSpawnSound);
    }

}
