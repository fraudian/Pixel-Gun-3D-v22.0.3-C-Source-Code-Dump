using UnityEngine;
internal sealed class FreemodeSecret : PGBehaviour
{
    // Fields
    public UnityEngine.GameObject meshObject;
    private UnityEngine.Transform 丂万丁三丏丕丈丂上;
    private UnityEngine.AudioClip pickUpSound;
    public UnityEngine.GameObject brMeshObject;
    internal static float 万七丙与一丏丈丅业;
    
    // Methods
    private void Awake()
    {
        this.丂万丁三丏丕丈丂上 = this.transform;
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
                return;
        }
        
        UnityEngine.Object.Destroy(obj:  this.meshObject);
        this.meshObject = this.brMeshObject;
        this.brMeshObject.SetActive(value:  true);
    }
    private void Start()
    {
    
    }
    private void 丐丌下丙丈丌丄三世()
    {
        UnityEngine.GameObject val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_12 = this;
        if(this.meshObject == 0)
        {
                return;
        }
        
        val_13 = 1152921505286238208;
        val_14 = null;
        val_14 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_378 == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.丂万丁三丏丕丈丂上.position;
        val_16 = null;
        val_16 = null;
        UnityEngine.Vector3 val_5 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z});
        val_17 = null;
        val_17 = null;
        float val_7 = FreemodeSecret.万七丙与一丏丈丅业 * FreemodeSecret.万七丙与一丏丈丅业;
        if((((val_6.x < 0) ? 1 : 0) ^ this.meshObject.activeSelf) == false)
        {
                return;
        }
        
        val_12 = this.meshObject;
        val_12.SetActive(value:  (val_6.x < 0) ? 1 : 0);
    }
    private void Update()
    {
        this.丐丌下丙丈丌丄三世();
    }
    private void 丑丈丘丌专与丆丘一()
    {
        var val_36;
        var val_37;
        bool val_38;
        bool val_39;
        var val_40;
        var val_41;
        short val_42;
        var val_43;
        var val_44;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  86);
        val_36 = null;
        val_36 = null;
        if(GameController.onlineMode != 0)
        {
                val_37 = null;
            val_37 = null;
            val_38 = mem[GameController.丆丘丂丈世丏丟丑丏 + 81];
            val_38 = GameController.丆丘丂丈世丏丟丑丏.丐一三丞丝丌不丏丑;
        }
        else
        {
                val_38 = 0;
        }
        
        if(BattleRoyaleController.丑七不且上丗丁一世() != 0)
        {
                BattleRoyaleController val_5 = BattleRoyaleController.丑七不且上丗丁一世();
            val_39 = val_5.squadMode;
        }
        else
        {
                val_39 = 0;
        }
        
        val_40 = null;
        val_40 = null;
        if(GameController.onlineMode != 0)
        {
                val_41 = null;
            val_41 = null;
            if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_30;
        }
        
        }
        
        }
        
        label_74:
        var val_7 = val_39 | val_38;
        val_7 = val_7 | 0;
        Rilisoft.丞丛七上丕专丏丌丈.丗丒丂且丒丗丏上万(丙专七丘与丒丛丅丆:  (val_7 != 0) ? 1 : 0);
        FreemodeSecretPoint val_10 = this.GetComponentInParent<FreemodeSecretPoint>();
        val_42 = val_10.丞世不丒下上上丝丑;
        UnityEngine.SceneManagement.Scene val_11 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().专丒丅丝丑丁丒丛与(丅东与业丒一业万丅:  val_42, 七丆丂丂下丈且丟世:  val_11.m_Handle.name);
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_42 = this.GetComponentInParent<UnityEngine.AudioSource>();
            val_42.PlayOneShot(clip:  this.pickUpSound);
        }
        
        this.SetInactive();
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
            goto label_43;
        }
        
        丞丐不丅专丙丛世丝();
        if(SecretsFreemodeController.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_82;
        }
        
        if(SecretsFreemodeController.丆丕丝丒不丙且丐丗.GetCurrentSecretCount() != SecretsFreemodeController.丆丕丝丒不丙且丐丗.业上一七丘丏丝下丈())
        {
            goto label_51;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_19 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  507005);
        if((PGCompany.ItemSystem.丂丟丁丗丘与丞丂丟.东一三一万且丕世不(丗丟上上丒丐丗丞丙:  val_19, 丆丗丝丄丄万丂丂且:  new PGCompany.ItemSystem.三三丌丞丘不且丗业[3])) == false)
        {
            goto label_52;
        }
        
        val_42 = public System.Void System.Nullable<PGCompany.丛丈下且丐丝不东丈>::.ctor(PGCompany.丛丈下且丐丝不东丈 value);
        PGCompany.丗丟丄丈东丝丕丄世 val_23 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_19, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        val_43 = 0;
        goto label_54;
        label_43:
        if(GameConnect.万不丒丌丙万丗东不() == false)
        {
            goto label_82;
        }
        
        丞丐不丅专丙丛世丝();
        if(SecretsFreemodeController.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_82;
        }
        
        if(SecretsFreemodeController.丆丕丝丒不丙且丐丗.GetCurrentSecretCount() != SecretsFreemodeController.丆丕丝丒不丙且丐丗.业上一七丘丏丝下丈())
        {
            goto label_65;
        }
        
        PGCompany.三东丏不丗世丅丌丄 val_28 = PGCompany.三东丏不丗世丅丌丄.东丝七业丄丑丒世七(丞世不丒下上上丝丑:  670005);
        if((PGCompany.ItemSystem.丂丟丁丗丘与丞丂丟.东一三一万且丕世不(丗丟上上丒丐丗丞丙:  val_28, 丆丗丝丄丄万丂丂且:  new PGCompany.ItemSystem.三三丌丞丘不且丗业[3])) != false)
        {
                val_42 = public System.Void System.Nullable<PGCompany.丛丈下且丐丝不东丈>::.ctor(PGCompany.丛丈下且丐丝不东丈 value);
            PGCompany.丗丟丄丈东丝丕丄世 val_32 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  val_28, 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        }
        
        ShowAllSecretsMessage();
        goto label_82;
        label_51:
        ShowCurrentSecretsMessage();
        goto label_82;
        label_30:
        bool val_34 = GameController.onlineMode.丄丗三丌世东业上丌();
        goto label_74;
        label_52:
        val_44 = null;
        val_44 = null;
        val_42 = 与丂丏丛丞丞丒丟丄.丐世丑丈丟丏专专丝;
        val_43 = 1;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().业丟不一三上七丆丕(丏丂不专上丘丂不丅:  val_42, 丗世丈丂丒丞专上丟:  200, 世丁丙世丄一万丆三:  88, 丛丞万三下丘七丌丅:  true);
        label_54:
        ShowAllSecretsMessage(与一丗丈丙东七上丒:  true);
        goto label_82;
        label_65:
        ShowCurrentSecretsMessage();
        label_82:
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
    }
    public void SetInactive()
    {
        this.gameObject.SetActive(value:  false);
    }
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        null = null;
        if(丘丛丏丘丝七世七丅 != (public System.Int32 UnityEngine.Object::GetHashCode()))
        {
                return;
        }
        
        this.丑丈丘丌专与丆丘一();
    }
    public FreemodeSecret()
    {
    
    }
    private static FreemodeSecret()
    {
        FreemodeSecret.万七丙与一丏丈丅业 = 150f;
    }

}
