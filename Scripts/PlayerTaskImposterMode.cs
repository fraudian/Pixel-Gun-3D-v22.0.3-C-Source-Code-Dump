using UnityEngine;
internal sealed class PlayerTaskImposterMode : PGBehaviour
{
    // Fields
    internal bool 丕丞丌万丞丄丘且丘;
    private ImposterRoomLocalization _roomLocalization;
    internal UnityEngine.GameObject hightlightObject;
    internal PlayerTaskImposterMode.丌不丕丁丁东且丈丑 taskType;
    private string taskLocalization;
    internal string taskDescription;
    internal bool dontFollow;
    internal System.Action<int> 丙丟七上丏丟丗丒丅;
    private int 三专丙七业丗一丏丑;
    private Rilisoft.丝丑丂丛万丐丈丘且 丌丏丒丕不七上专世;
    private UnityEngine.ParticleSystem particlesEffect;
    
    // Properties
    public ImposterRoomLocalization 万丄专丌丝丛丘丘丄 { get; }
    internal UnityEngine.Vector3 万七丁七丕丘专丆不 { get; }
    internal UnityEngine.Transform 业与七专丁丅丑业丌 { get; }
    internal int 上三丞丄丏业下三专 { get; set; }
    
    // Methods
    public ImposterRoomLocalization get_RoomLocalization()
    {
        return (ImposterRoomLocalization)this._roomLocalization;
    }
    internal UnityEngine.Vector3 世丈一丝丒且不丈丙()
    {
        UnityEngine.Transform val_1 = this.transform;
        if(val_1 != null)
        {
                return val_1.position;
        }
        
        return val_1.position;
    }
    internal UnityEngine.Transform 丂世丟丈丆丗一丗丌()
    {
        return this.transform;
    }
    internal int 丐丕不丅三专万丕丗()
    {
    
    }
    internal void 丈丞七世丝丘丞丙上(int 丙业与丙丗丝不丈东)
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = Rilisoft.丝丑丂丛万丐丈丘且.东丝七业丄丑丒世七(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        this.丌丏丒丕不七上专世 = val_1;
        mem[1152921537604170120] = val_1.上万三丆专丏丒丗业;
    }
    private void Awake()
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.taskLocalization)) != true)
        {
                if(this._roomLocalization != 0)
        {
                this.taskDescription = System.String.Format(format:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.taskLocalization), arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this._roomLocalization.roomLocalization));
        }
        
        }
        
        if(this.taskType != 3)
        {
                return;
        }
        
        UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.丘丁丐不不丕丆丝丙());
    }
    internal void 丝丏东丛丂三不东丆(System.Action<int> 丈丈专丁专丟万丟丏, int 三专三丐丁世丑丁丅 = -1)
    {
        System.Action<System.Int32> val_4;
        this.丕丞丌万丞丄丘且丘 = false;
        if(((System.Delegate.Combine(a:  this.丙丟七上丏丟丗丒丅, b:  丈丈专丁专丟万丟丏)) != null) && (null != null))
        {
                val_4 = 0;
        }
        
        this.丙丟七上丏丟丗丒丅 = val_4;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
        this.三专丙七业丗一丏丑 = 三专三丐丁世丑丁丅;
    }
    internal void 丄三丙丄丞东丕丒丝()
    {
        if(this.taskType != 3)
        {
                this.丕丞丌万丞丄丘且丘 = true;
        }
        
        if(this.丙丟七上丏丟丗丒丅 != null)
        {
                this.丙丟七上丏丟丗丒丅.Invoke(obj:  this.三专丙七业丗一丏丑);
        }
        
        this.丏丛专丘丄且丑下丑();
    }
    private System.Collections.IEnumerator 丘丁丐不不丕丆丝丙()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new PlayerTaskImposterMode.丞丄下一丘丁且丌万();
    }
    internal void 丏丛专丘丄且丑下丑()
    {
        var val_3;
        this.丙丟七上丏丟丗丒丅 = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
        val_3 = null;
        val_3 = null;
        PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.不丆世丅丘东丙丐丂 = false;
        PlayerTaskImposterModeController.丆丕丝丒不丙且丐丗.丒且下上丑丆七丟丕 = (float)UnityEngine.Time.frameCount;
    }
    internal void 丄丟东丑下丄万上丄()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hightlightObject, 丏业丟一东丂东丘丛:  true);
    }
    internal void 业七丈丁丂丌业丝下()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.hightlightObject, 丏业丟一东丂东丘丛:  false);
    }
    public PlayerTaskImposterMode()
    {
    
    }

}
