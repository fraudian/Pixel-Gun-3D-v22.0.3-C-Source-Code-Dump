using UnityEngine;
public class BattleRoyalZoneChecker : MonoBehaviour
{
    // Fields
    private bool 七丞世丞丑丘上丈丝;
    private bool 丙丗丗三东丘一丁丕;
    private float _cloudsYOffset;
    private UnityEngine.AudioSource _outOfZoneAudio;
    private UnityEngine.Quaternion 丟丐丈且丗丟丑东丑;
    private PhotonView 丄丈丑丐丆丞丘与丗;
    
    // Properties
    public bool 七丄业丙丄丂专丑且 { get; set; }
    
    // Methods
    public bool get_isShowInSpectatorMode()
    {
        return (bool)this.七丞世丞丑丘上丈丝;
    }
    public void set_isShowInSpectatorMode(bool 丙业与丙丗丝不丈东)
    {
        bool val_1 = 丙业与丙丗丝不丈东;
        this.七丞世丞丑丘上丈丝 = val_1;
        if(val_1 == true)
        {
                return;
        }
        
        if(this.丙丗丗三东丘一丁丕 != false)
        {
                this.丘丒七丐丟与丅且丟(世丁万下丗专世万丅:  false);
        }
        
        this.丙丗丗三东丘一丁丕 = false;
    }
    private void Awake()
    {
        if(GameConnect.万不丒丌丙万丗东不() != false)
        {
                return;
        }
        
        this.enabled = false;
    }
    private void Start()
    {
        PhotonView val_1 = this.GetComponent<PhotonView>();
        this.丄丈丑丐丆丞丘与丗 = val_1;
        if(val_1.isMine == false)
        {
                return;
        }
        
        this.丘丒七丐丟与丅且丟(世丁万下丗专世万丅:  false);
    }
    private void Update()
    {
        if(this.丄丈丑丐丆丞丘与丗.isMine != true)
        {
                if(this.七丞世丞丑丘上丈丝 == false)
        {
                return;
        }
        
        }
        
        BattleRoyaleController val_2 = BattleRoyaleController.丑七不且上丗丁一世();
        UnityEngine.Vector3 val_4 = this.transform.position;
        bool val_5 = val_2.safeZones.IsOutOfCurrentZoneRadius(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z});
        var val_6 = (this.丙丗丗三东丘一丁丕 == true) ? 1 : 0;
        val_6 = val_5 ^ val_6;
        if(val_6 != false)
        {
                this.丘丒七丐丟与丅且丟(世丁万下丗专世万丅:  val_5);
        }
        
        this.丙丗丗三东丘一丁丕 = val_5;
    }
    private void LateUpdate()
    {
        if(this.丄丈丑丐丆丞丘与丗.isMine != true)
        {
                if(this.七丞世丞丑丘上丈丝 == false)
        {
                return;
        }
        
        }
        
        BattleRoyaleController val_2 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_2._outOfZoneParticles == 0)
        {
                return;
        }
        
        BattleRoyaleController val_4 = BattleRoyaleController.丑七不且上丗丁一世();
        if(val_4._outOfZoneParticles.activeSelf == false)
        {
                return;
        }
        
        BattleRoyaleController val_6 = BattleRoyaleController.丑七不且上丗丁一世();
        UnityEngine.Vector3 val_9 = this.transform.position;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.up;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  this._cloudsYOffset);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z});
        val_6._outOfZoneParticles.transform.position = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
    }
    private void 丄丑七丘丁且丞丙专(bool 一三三丄下东上丅丗)
    {
        var val_1 = (this.丙丗丗三东丘一丁丕 == true) ? 1 : 0;
        val_1 = val_1 ^ 一三三丄下东上丅丗;
        if(val_1 != false)
        {
                一三三丄下东上丅丗 = 一三三丄下东上丅丗;
            this.丘丒七丐丟与丅且丟(世丁万下丗专世万丅:  一三三丄下东上丅丗);
        }
        
        this.丙丗丗三东丘一丁丕 = 一三三丄下东上丅丗;
    }
    private void 不万世丄丁丕丌万三(bool 世丁万下丗专世万丅)
    {
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        if(GadgetsSFX.__il2cppRuntimeField_implementedInterfaces == 0)
        {
                return;
        }
        
        if(世丁万下丗专世万丅 != false)
        {
                if(IsPlaying == true)
        {
                return;
        }
        
            Play(丅丁丙丁万上丂七丈:  600f);
            return;
        }
        
        if(IsPlaying == false)
        {
                return;
        }
        
        Stop();
    }
    private void 不丑丝且丏不丝丒东(bool 世丁万下丗专世万丅)
    {
        var val_4;
        var val_5;
        if(this._outOfZoneAudio == 0)
        {
                return;
        }
        
        if(世丁万下丗专世万丅 != false)
        {
                if(this._outOfZoneAudio.isPlaying == true)
        {
                return;
        }
        
            val_4 = null;
            val_4 = null;
            MenuBackgroundMusic.丌丂一丛下丒丞丛东.丛丗丐丝丁丄丙丞丘(丞下上且一上丙不丏:  this._outOfZoneAudio);
            return;
        }
        
        if(this._outOfZoneAudio.isPlaying == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        MenuBackgroundMusic.丌丂一丛下丒丞丛东.丌丗世丐业丂丐丕且(丞下上且一上丙不丏:  this._outOfZoneAudio);
    }
    private void 丘丒七丐丟与丅且丟(bool 世丁万下丗专世万丅)
    {
        UnityEngine.GameObject val_6;
        BattleRoyaleController val_1 = BattleRoyaleController.丑七不且上丗丁一世();
        val_6 = val_1._outOfZoneParticles;
        if(val_6 != 0)
        {
                BattleRoyaleController val_3 = BattleRoyaleController.丑七不且上丗丁一世();
            val_6 = val_3._outOfZoneParticles;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  世丁万下丗专世万丅);
        }
        
        bool val_5 = 世丁万下丗专世万丅;
        val_6.不万世丄丁丕丌万三(世丁万下丗专世万丅:  val_5);
        this.不丑丝且丏不丝丒东(世丁万下丗专世万丅:  val_5);
    }
    public BattleRoyalZoneChecker()
    {
    
    }

}
