using UnityEngine;
public sealed class CameraSceneController : MonoBehaviour
{
    // Fields
    internal static CameraSceneController 丄丞丁丈与业上丞丟;
    private UnityEngine.Vector3 丐丝丕丂丏丏且丌一;
    private UnityEngine.Quaternion 丗不一业丘丕丁三不;
    private UnityEngine.Transform 万东万丆专丌丕丐丗;
    public RPG_Camera killCamController;
    public UnityEngine.Transform objListener;
    private UnityEngine.Camera 与业丞东丙丕且丏丈;
    private Player_move_c currentTarget;
    private UnityEngine.Coroutine 上丗三且丅丝专七上;
    
    // Properties
    public bool 三丕丐丆东丑东与世 { get; set; }
    
    // Methods
    private void Awake()
    {
        CameraSceneController.丄丞丁丈与业上丞丟 = this;
        this.万东万丆专丌丕丐丗 = this.transform;
        this.EnableSounds = false;
        this.与业丞东丙丕且丏丈 = this.GetComponent<UnityEngine.Camera>();
    }
    private void Start()
    {
        null = null;
        if((SceneInfoController.丄丘七三上丕世丞业.丝丅丈丁且丐不丂丝(丆丕丁专丘三丄与七:  UnityEngine.Application.loadedLevelName)) != 0)
        {
                this.丐丝丕丂丏丏且丌一 = val_2.positionCam;
            mem[1152921525574150256] = UnityEngine.Object.__il2cppRuntimeField_cctor_finished;
            UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_2.rotationCam, y = V8.16B, z = V9.16B});
            this.丗不一业丘丕丁三不 = val_4;
            mem[1152921525574150264] = val_4.y;
            mem[1152921525574150268] = val_4.z;
            mem[1152921525574150272] = val_4.w;
        }
        
        this.丆丛丒丏东丄丐丐丒();
        this.killCamController.enabled = false;
    }
    public bool get_EnableSounds()
    {
        UnityEngine.Vector3 val_1 = this.objListener.localPosition;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        return false;
    }
    public void set_EnableSounds(bool 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 != false)
        {
                UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            this.objListener.localPosition = new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z};
            return;
        }
        
        this.objListener.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    internal void 业丌丑万丄万丆丒万()
    {
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        this.丐万丑丑且不丝丑丝(世业三丘丒丙丅丈丌:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, 三上七丛丅丒七丒丒:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, 丝丘与世丛丕丒丒一:  0);
    }
    internal void 丐万丑丑且不丝丑丝(UnityEngine.Vector3 世业三丘丒丙丅丈丌, UnityEngine.Quaternion 三上七丛丅丒七丒丒, Player_move_c 丝丘与世丛丕丒丒一)
    {
        if(this.上丗三且丅丝专七上 != null)
        {
                this.StopCoroutine(routine:  this.上丗三且丅丝专七上);
        }
        
        this.gameObject.SetActive(value:  true);
        if(丝丘与世丛丕丒丒一 == 0)
        {
                this.killCamController.enabled = false;
            this.killCamController.cameraPivot = 0;
            this.丆丛丒丏东丄丐丐丒();
            this.EnableSounds = false;
            return;
        }
        
        this.与业丞东丙丕且丏丈.fieldOfView = 60f;
        this.killCamController.cameraPivot = 0;
        this.killCamController.enabled = true;
        this.killCamController.transform.position = new UnityEngine.Vector3() {x = 世业三丘丒丙丅丈丌.x, y = 世业三丘丒丙丅丈丌.y, z = 世业三丘丒丙丅丈丌.z};
        this.killCamController.transform.rotation = new UnityEngine.Quaternion() {x = 三上七丛丅丒七丒丒.x, y = 三上七丛丅丒七丒丒.y, z = 三上七丛丅丒七丒丒.z, w = 三上七丛丅丒七丒丒.w};
        this.EnableSounds = true;
        bool val_5 = UnityEngine.Object.op_Inequality(x:  this.currentTarget, y:  0);
        if(val_5 != false)
        {
                val_5.丒丕万丐世丅世丙下(万丌万丅专丞业丈万:  this.currentTarget);
        }
        
        this.currentTarget = 丝丘与世丛丕丒丒一;
        bool val_6 = UnityEngine.Object.op_Inequality(x:  丝丘与世丛丕丒丒一, y:  0);
        if(val_6 != false)
        {
                val_6.丄上万丗丏七丛与世(万丌万丅专丞业丈万:  this.currentTarget);
        }
        
        bool val_7 = UnityEngine.Object.op_Inequality(x:  this.currentTarget, y:  0);
        if(val_7 == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  val_7.东丅一上丈不丁与丛());
        this.上丗三且丅丝专七上 = this.StartCoroutine(routine:  this.不丂丝丏丌丐丐且丟());
    }
    private System.Collections.IEnumerator 东丅一上丈不丁与丛()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new CameraSceneController.丞丆世丈万丌七丑丕();
    }
    public void Disable()
    {
        this.killCamController.enabled = false;
        this.killCamController.cameraPivot = 0;
    }
    internal System.Collections.IEnumerator 不丂丝丏丌丐丐且丟()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new CameraSceneController.一专与业丈上丟一丆();
    }
    private void Update()
    {
        var val_5;
        if(GameConnect.与丂丝丟丟三丑丝万() != true)
        {
                if(GameConnect.且丞丁东丝丗上丈业() != true)
        {
                if(GameConnect.业丗与丈丁东下一丛() == false)
        {
                return;
        }
        
        }
        
        }
        
        val_5 = null;
        val_5 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer != 0)
        {
                return;
        }
        
        this.丆丛丒丏东丄丐丐丒();
    }
    private void 丆丛丒丏东丄丐丐丒()
    {
        var val_20;
        CameraScenePosition val_21;
        UnityEngine.Transform val_22;
        float val_23;
        UnityEngine.Camera val_24;
        float val_25;
        if(CameraScenePosition.丄丘七三上丕世丞业 == 0)
        {
            goto label_40;
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_6;
        }
        
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                if(gameObject.activeSelf == true)
        {
            goto label_37;
        }
        
        }
        
        val_20 = null;
        val_20 = null;
        if((SiegeController.三三万丆下一丗万丛 + 115) == 0)
        {
            goto label_37;
        }
        
        label_6:
        if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                if(gameObject.activeSelf == true)
        {
            goto label_37;
        }
        
        }
        
        }
        
        if(GameConnect.业丗与丈丁东下一丛() != false)
        {
                if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 != 0)
        {
                if(gameObject.activeSelf == true)
        {
            goto label_37;
        }
        
        }
        
        }
        
        if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
            goto label_40;
        }
        
        label_37:
        val_21 = CameraScenePosition.丄丘七三上丕世丞业;
        goto label_41;
        label_40:
        val_21 = 0;
        label_41:
        val_22 = this.万东万丆专丌丕丐丗;
        if(val_21 != 0)
        {
                UnityEngine.Vector3 val_17 = val_21.transform.position;
            val_22.position = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
            val_22 = this.万东万丆专丌丕丐丗;
            UnityEngine.Quaternion val_19 = val_21.transform.rotation;
            val_23 = val_19.z;
            val_22.rotation = new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_23, w = val_19.w};
            val_24 = this.与业丞东丙丕且丏丈;
            val_25 = 6.606506E-38f;
            if(val_24 != null)
        {
            goto label_53;
        }
        
        }
        else
        {
                val_22.position = new UnityEngine.Vector3() {x = this.丐丝丕丂丏丏且丌一, y = V9.16B, z = V10.16B};
            val_25 = this.丗不一业丘丕丁三不;
            this.万东万丆专丌丕丐丗.rotation = new UnityEngine.Quaternion() {x = val_25, y = V9.16B, z = V10.16B, w = V11.16B};
            val_24 = this.与业丞东丙丕且丏丈;
        }
        
        label_53:
        val_24.fieldOfView = 60f;
    }
    private void 丄上万丗丏七丛与世(Player_move_c 万丌万丅专丞业丈万)
    {
        if(万丌万丅专丞业丈万 == 0)
        {
                return;
        }
        
        万丌万丅专丞业丈万.东世丌丄世业丞丛丐(丛丅丘一丏丙且丌上:  true);
    }
    private void 丒丕万丐世丅世丙下(Player_move_c 万丌万丅专丞业丈万)
    {
        if(万丌万丅专丞业丈万 == 0)
        {
                return;
        }
        
        万丌万丅专丞业丈万.东世丌丄世业丞丛丐(丛丅丘一丏丙且丌上:  false);
    }
    internal void 业丟丙丌丘丞七万且()
    {
        this.丒丕万丐世丅世丙下(万丌万丅专丞业丈万:  this.currentTarget);
    }
    private void OnDestroy()
    {
        CameraSceneController.丄丞丁丈与业上丞丟 = 0;
    }
    public CameraSceneController()
    {
        this.丐丝丕丂丏丏且丌一 = 0;
        mem[1152921525576050032] = 0;
        UnityEngine.Quaternion val_1 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        this.丗不一业丘丕丁三不 = val_1;
        mem[1152921525576050040] = val_1.y;
        mem[1152921525576050044] = val_1.z;
        mem[1152921525576050048] = val_1.w;
    }

}
