using UnityEngine;
public class PlayerBotController : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    internal PhotonView 丄丈丑丐丆丞丘与丗;
    internal PlayerBotInstance 丗丈东丕不丘三丞业;
    public UnityEngine.GameObject playerGameObject;
    internal PlayerBotEntity player;
    internal PlayerBotWear wear;
    internal PlayerBotMovement movement;
    internal PlayerBot.AIBotController 丌丕下东七丗丛丞下;
    private ObjectOnDamagePoisonParams 丐七不丗不丟丂丁丗;
    
    // Properties
    internal bool 丌且下丕下下丌万丞 { get; }
    internal ObjectOnDamagePoisonParams 七丁丑丘丂丆丌丁三 { get; }
    
    // Methods
    internal bool 丟丌下三七丁与丟丑()
    {
        if(this.丄丈丑丐丆丞丘与丗 != null)
        {
                return this.丄丈丑丐丆丞丘与丗.isMine;
        }
        
        return this.丄丈丑丐丆丞丘与丗.isMine;
    }
    internal ObjectOnDamagePoisonParams 下丏万七东丐世业丆()
    {
        ObjectOnDamagePoisonParams val_4;
        if(this.丐七不丗不丟丂丁丗 == 0)
        {
                this.丐七不丗不丟丂丁丗 = this.gameObject.AddComponent<ObjectOnDamagePoisonParams>();
            return val_4;
        }
        
        val_4 = this.丐七不丗不丟丂丁丗;
        return val_4;
    }
    private void Awake()
    {
        this.丌丕下东七丗丛丞下 = this.GetComponent<PlayerBot.AIBotController>();
        this.丄丈丑丐丆丞丘与丗 = this.GetComponent<PhotonView>();
        this.上丛丌丆丑上七世三();
        PlayerBotsManager val_3 = PlayerBotsManager.与一丅丝不丈业与丙();
        val_3.业丌上丁下七不丐丝.Add(item:  this);
    }
    internal void 下丂专且万七丐丁三(Player_move_c 专丞上七七且丝七丗)
    {
        SkinName val_1;
        this.丙下且一丒丛丞丏丆(丕丁丘丆万丄世专丛:  专丞上七七且丝七丗);
        if(专丞上七七且丝七丗 != null)
        {
                val_1 = 专丞上七七且丝七丗.mySkinName;
            this.丌且且丒丘丑东丕丐(丝丘丅与丌丗丅丈下:  专丞上七七且丝七丗.mySkinName);
        }
        else
        {
                val_1 = 1576;
            this.丌且且丒丘丑东丕丐(丝丘丅与丌丗丅丈下:  0);
        }
        
        this.且丑丏丙丘丐丐不丂(丐丆丁东丄丁丅丁丅:  mem[1460288881096]);
        this.万丁上专与且丈一不(丁业世丈丟丈丘下丘:  专丞上七七且丝七丗.myPersonNetwork);
        this.丌丕下东七丗丛丞下.丏丂且一不世丙丑下();
    }
    private void 丙下且一丒丛丞丏丆(Player_move_c 丕丁丘丆万丄世专丛)
    {
        this.player.丙下且一丒丛丞丏丆(丕丁丘丆万丄世专丛:  丕丁丘丆万丄世专丛);
    }
    private void 丌且且丒丘丑东丕丐(SkinName 丝丘丅与丌丗丅丈下)
    {
        this.wear.丌且且丒丘丑东丕丐(丝丘丅与丌丗丅丈下:  丝丘丅与丌丗丅丈下);
        this.playerGameObject = 丝丘丅与丌丗丅丈下.gameObject;
    }
    private void 且丑丏丙丘丐丐不丂(FirstPersonControlSharp 丐丆丁东丄丁丅丁丅)
    {
        this.movement.且丑丏丙丘丐丐不丂(丐丆丁东丄丁丅丁丅:  丐丆丁东丄丁丅丁丅);
    }
    private void 万丁上专与且丈一不(PlayerSynchStream 丁业世丈丟丈丘下丘)
    {
        this.movement.万丁上专与且丈一不(丁业世丈丟丈丘下丘:  丁业世丈丟丈丘下丘);
    }
    internal void 上丛丌丆丑上七世三()
    {
        PhotonView val_1 = this.GetComponent<PhotonView>();
        this.丄丈丑丐丆丞丘与丗 = val_1;
        if(val_1.instantiationData != null)
        {
                System.Object[] val_3 = this.丄丈丑丐丆丞丘与丗.instantiationData;
            if(val_3.Length != 0)
        {
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  this.丄丈丑丐丆丞丘与丗.instantiationData[0]);
            if(null != 1)
        {
                PhotonView val_5 = PhotonView.Find(世上丕丐丈世上不丏:  21884928);
            if(val_5 == 0)
        {
                UnityEngine.Debug.LogError(message:  "botInstancePhotonView == null");
            return;
        }
        
            this.丗丈东丕不丘三丞业 = val_5.GetComponent<PlayerBotInstance>();
        }
        
        }
        
        }
        
        this.丗丈东丕不丘三丞业.七七且与丈不三丒丙(丛世丕丘七东下丌丄:  this);
        if(this.丄丈丑丐丆丞丘与丗.isMine != false)
        {
                UnityEngine.Vector3 val_10 = this.transform.position;
            UnityEngine.Quaternion val_12 = this.transform.rotation;
            object[] val_13 = new object[1];
            val_13[0] = this.丗丈东丕不丘三丞业.世丌丐丁丂一丘丂一.丄丈丑丐丆丞丘与丗.viewID;
            UnityEngine.GameObject val_15 = 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  "Player", 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_12.x, y = val_12.y, z = val_12.z, w = val_12.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  val_13);
        }
        
        this.player.Initialize();
    }
    internal static PlayerBotController 不世丂丏丒万世东丂(PhotonView 丁世丛业丟下丕三丟)
    {
        UnityEngine.Object val_8;
        PlayerBotController val_9;
        val_8 = 丁世丛业丟下丕三丟;
        val_9 = 0;
        if(val_8 == 0)
        {
                return (PlayerBotController)val_9;
        }
        
        if(val_8.instantiationData == null)
        {
                return (PlayerBotController)val_9;
        }
        
        System.Object[] val_3 = val_8.instantiationData;
        if(val_3.Length != 0)
        {
                UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_8.instantiationData[0]);
            val_8 = NetworkStartTable.三与三丛丟丁丆丕世(世上丕丐丈世上不丏:  21884928);
            val_9 = 0;
            if(val_8 == 0)
        {
                return (PlayerBotController)val_9;
        }
        
            if(val_5.一七不三丌专三丆一 != false)
        {
                val_8 = val_5.丗丈东丕不丘三丞业;
            val_9 = val_5.丗丈东丕不丘三丞业.不丕丅丝七丂丐丗丄;
            return (PlayerBotController)val_9;
        }
        
        }
        
        val_9 = 0;
        return (PlayerBotController)val_9;
    }
    private void Start()
    {
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
    }
    private void OnDestroy()
    {
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
        PlayerBotsManager val_1 = PlayerBotsManager.与一丅丝不丈业与丙();
        bool val_2 = val_1.业丌上丁下七不丐丝.Remove(item:  this);
        if(this.丄丈丑丐丆丞丘与丗.isMine == false)
        {
                return;
        }
        
        丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.playerGameObject);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        byte val_5;
        var val_6;
        val_5 = 丞世不丒下上上丝丑;
        byte val_1 = val_5 & 255;
        if(val_1 == 175)
        {
            goto label_1;
        }
        
        if(val_1 != 196)
        {
            goto label_2;
        }
        
        this.丗下下丁七上丅丞业(与丆丌丂丟丛丘丑且:  System.Convert.ToInt32(value:  专丒丌丆下丐丞丟丞[0]));
        goto label_7;
        label_1:
        val_5 = System.Convert.ToByte(value:  专丒丌丆下丐丞丟丞[0]);
        this.七专下丌世丄三万丅(丛业丌丕与丛下丞丞:  val_5, 丛丄业丕且丗下一万:  System.Convert.ToByte(value:  专丒丌丆下丐丞丟丞[1]));
        label_7:
        val_6 = 1;
        return (bool)val_6;
        label_2:
        val_6 = 0;
        return (bool)val_6;
    }
    internal void 丒丛丒丅丈丛东丝一()
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_2;
        }
        
        if(this.丌丕下东七丗丛丞下.currentBehaviorType != 0)
        {
            goto label_3;
        }
        
        goto label_6;
        label_2:
        if(this.丌丕下东七丗丛丞下.currentBehaviorType == 0)
        {
            goto label_6;
        }
        
        label_3:
        label_6:
        val_1[0] = this.丌丕下东七丗丛丞下.currentBehaviorType;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  196, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    internal void 丏上丟丕丒丟丄且丄(int 丛业丌丕与丛下丞丞, int 丛丄业丕且丗下一万)
    {
        object[] val_1 = new object[2];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(丛业丌丕与丛下丞丞 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丛业丌丕与丛下丞丞 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = 丛业丌丕与丛下丞丞;
        val_1[1] = 丛丄业丕且丗下一万;
        this.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  175, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    private void 丗下下丁七上丅丞业(int 与丆丌丂丟丛丘丑且)
    {
        if(this.丌丕下东七丗丛丞下.丟丌下三七丁与丟丑() != false)
        {
                return;
        }
        
        this.丌丕下东七丗丛丞下.丘业三丌丐丂丈丗丒(丌专丝丘丒丒丟丄上:  与丆丌丂丟丛丘丑且);
    }
    private void 七专下丌世丄三万丅(byte 丛业丌丕与丛下丞丞, byte 丛丄业丕且丗下一万)
    {
        var val_3;
        if(this.丌丕下东七丗丛丞下.丟丌下三七丁与丟丑() == true)
        {
                return;
        }
        
        if(this.丌丕下东七丗丛丞下.丒七丕丛万东丘丞丛 == null)
        {
                return;
        }
        
        val_3 = null;
    }
    public PlayerBotController()
    {
    
    }

}
