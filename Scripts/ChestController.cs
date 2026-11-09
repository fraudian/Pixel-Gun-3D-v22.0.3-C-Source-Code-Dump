using UnityEngine;
internal class ChestController : MonoBehaviour, 丅丙上七上一丐不下, 东丁丆一业丈万丆丐
{
    // Fields
    public bool isStartChest;
    public int currentSpawnZone;
    public float live;
    public bool isKilled;
    public bool isChestBonus;
    public static readonly int[] weaponForHungerGames;
    public UnityEngine.AudioClip brokenAudio;
    private bool 丒丞一下丑丆丐丕丞;
    private static System.Collections.Generic.HashSet<string> 丝丞万丟丅丛丙丙丌;
    private int <专业丞不丟专专丐与>k__BackingField;
    private float <东丟丒东丗七万世且>k__BackingField;
    
    // Properties
    internal static System.Collections.Generic.HashSet<string> 丏丕丗丛丘丈业丅丘 { get; }
    public int 丗且丗丞丝丄世上一 { get; set; }
    public UnityEngine.Transform 不丂丅丁且丆东东丂 { get; }
    public float 丟丆丆丝东世一丒丐 { get; set; }
    public bool 丁丙世丕丐丕丞丈丂 { get; }
    
    // Methods
    internal static System.Collections.Generic.HashSet<string> 丅丝丗丐三丞丕丙丈()
    {
        System.Collections.Generic.HashSet<T> val_4;
        var val_5;
        var val_7;
        System.Func<System.Int32, System.String> val_9;
        val_5 = null;
        val_5 = null;
        if(ChestController.丝丞万丟丅丛丙丙丌 == null)
        {
                val_7 = null;
            val_7 = null;
            val_9 = ChestController.<>c.<>9__9_0;
            if(val_9 == null)
        {
                System.Func<System.Int32, System.String> val_1 = null;
            val_9 = val_1;
            val_1 = new System.Func<System.Int32, System.String>(object:  ChestController.<>c.__il2cppRuntimeField_static_fields, method:  System.String ChestController.<>c::丘且一上专丛丘丂七(int 丙丐一丕丗万丁下一));
            ChestController.<>c.<>9__9_0 = val_9;
        }
        
            System.Collections.Generic.HashSet<System.String> val_3 = null;
            val_4 = val_3;
            val_3 = new System.Collections.Generic.HashSet<System.String>(collection:  System.Linq.Enumerable.Select<System.Int32, System.String>(source:  ChestController.__il2cppRuntimeField_static_fields, selector:  val_1));
            val_5 = null;
            val_5 = null;
            ChestController.丝丞万丟丅丛丙丙丌 = val_4;
        }
        
        val_5 = null;
        return (System.Collections.Generic.HashSet<System.String>)ChestController.丝丞万丟丅丛丙丙丌;
    }
    private void Start()
    {
        丘丛丞且一丅丁丏丐.东一万丕世丙丆丐丕(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
        this.<东丟丒东丗七万世且>k__BackingField = this.live;
    }
    private void OnDestroy()
    {
        丘丛丞且一丅丁丏丐.丛丂丄丕丁上七世万(丞下万上三丘上与专:  this.gameObject, 专丐丛丆与专世丆丂:  5);
    }
    private void Update()
    {
        if(this.丒丞一下丑丆丐丕丞 != true)
        {
                if((丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false) && (this.isKilled != false))
        {
                丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
        }
        
        }
        
        this.丒丞一下丑丆丐丕丞 = 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
    }
    public int get_moduleResistShownFrame()
    {
        return (int)this.<专业丞不丟专专丐与>k__BackingField;
    }
    public void set_moduleResistShownFrame(int 丙业与丙丗丝不丈东)
    {
        this.<专业丞不丟专专丐与>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public UnityEngine.Transform get_transform()
    {
        UnityEngine.GameObject val_1 = this.gameObject;
        if(val_1 != null)
        {
                return val_1.transform;
        }
        
        return val_1.transform;
    }
    public float get_maxHealth()
    {
        return (float)this.<东丟丒东丗七万世且>k__BackingField;
    }
    public void set_maxHealth(float 丙业与丙丗丝不丈东)
    {
        this.<东丟丒东丗七万世且>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void ApplyDamage(float 丞丈专下丈专业三丞, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, UnityEngine.Collider 专不丑且不丏东丟丅, UnityEngine.Vector3 且一丘丛丘丞丐丐业, Player_move_c.世不丟丂上丟与丌下 丐丟丘世丁三丕专专, WeaponSounds.丏专丐且丘丌丛不丁 东丏业丞丞业下丄世 = 0, string 丝三丛且丘不丌丙下 = "", int 丒丈丐丐丗丐专丈丏 = 0)
    {
        this.MinusLive(不丄一下下丈丈丛世:  丞丈专下丈专业三丞);
    }
    public bool IsEnemyTo(Player_move_c 专丞上七七且丝七丗)
    {
        return true;
    }
    public bool IsDead()
    {
        return (bool)this.isKilled;
    }
    public bool get_isLivingTarget()
    {
        return false;
    }
    public void AddHealthFromWeaponOnline(float 上上丗丁丏丙丄丏七, string 丝三丛且丘不丌丙下)
    {
    
    }
    public void MinusLive(float 不丄一下下丈丈丛世)
    {
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  34, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        var val_2;
        byte val_1 = 丞世不丒下上上丝丑 & 255;
        if(val_1 > 24)
        {
            goto label_1;
        }
        
        if(val_1 == 18)
        {
            goto label_2;
        }
        
        if(val_1 != 24)
        {
            goto label_8;
        }
        
        object val_2 = 专丒丌丆下丐丞丟丞[0];
        this.丟丄丌万丙丘丑丆丘(不丄一下下丈丈丛世:  3.782474E-38f);
        goto label_13;
        label_1:
        if(val_1 == 34)
        {
            goto label_7;
        }
        
        if(val_1 != 119)
        {
            goto label_8;
        }
        
        object val_3 = 专丒丌丆下丐丞丟丞[0];
        this.live = null;
        goto label_13;
        label_8:
        val_2 = 0;
        return (bool)val_2;
        label_2:
        this.DestroyChestRPC();
        goto label_13;
        label_7:
        this.丛专丐丄上下丘丂丛();
        label_13:
        val_2 = 1;
        return (bool)val_2;
    }
    internal void 丟丄丌万丙丘丑丆丘(float 不丄一下下丈丈丛世)
    {
        if(this.isKilled == true)
        {
                return;
        }
        
        float val_5 = this.live;
        val_5 = val_5 - 不丄一下下丈丈丛世;
        this.live = val_5;
        object[] val_2 = new object[1];
        val_2[0] = this.live;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  119, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  val_2);
        if(this.live > 0f)
        {
                return;
        }
        
        this = this.photonView;
        this.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  34, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
    }
    internal void 下丄丘东三下丅丞丙(float 业丛东丟丆丄丞丘上)
    {
        this.live = 业丛东丟丆丄丞丘上;
    }
    internal void 丛专丐丄上下丘丂丛()
    {
        var val_23;
        var val_24;
        var val_25;
        var val_27;
        float val_28;
        float val_29;
        var val_30;
        var val_32;
        if(this.isKilled == true)
        {
                return;
        }
        
        this.isKilled = true;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
            goto label_23;
        }
        
        val_23 = null;
        val_23 = null;
        int val_2 = UnityEngine.Random.Range(min:  0, max:  ChestController.weaponForHungerGames.Length);
        if(this.isChestBonus == false)
        {
            goto label_8;
        }
        
        if((UnityEngine.Random.Range(min:  0, max:  11)) <= 6)
        {
            goto label_9;
        }
        
        val_24 = null;
        val_24 = null;
        System.Int32[] val_4 = ChestController.weaponForHungerGames + (((long)(int)(val_2)) << 2);
        val_25 = 1152921504622075904;
        goto label_14;
        label_8:
        val_27 = null;
        val_27 = null;
        System.Int32[] val_5 = ChestController.weaponForHungerGames + (((long)(int)(val_2)) << 2);
        val_25 = 1152921504622075904;
        label_14:
        UnityEngine.Vector3 val_8 = this.transform.position;
        val_28 = val_8.x;
        val_29 = val_8.z;
        val_30 = this.transform;
        UnityEngine.Quaternion val_10 = val_30.rotation;
        UnityEngine.GameObject val_11 = 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  System.String.Format(format:  "Weapon_Bonuses/Weapon{0}_Bonus", arg0:  (ChestController.weaponForHungerGames + ((long)(int)(val_2)) << 2) + 32), 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_28, y = val_8.y, z = val_29}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_10.x, y = val_10.y, z = val_10.z, w = val_10.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  0);
        goto label_23;
        label_9:
        val_32 = null;
        val_32 = null;
        UnityEngine.Vector3 val_13 = this.transform.position;
        val_28 = val_13.x;
        val_29 = val_13.z;
        SettingBonus val_17 = this.transform.GetComponent<SettingBonus>();
        BonusController.丄丞丁丈与业上丞丟.丁上丞丆丘一丌丐丑(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_28, y = val_13.y, z = val_29}, 丌下丏丐丕丏不丗一:  ((UnityEngine.Random.Range(min:  0, max:  100)) > 69) ? 1 : 0, 丑一丟丑三丐下万丆:  val_17.numberSpawnZone);
        label_23:
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                val_30 = this.gameObject.GetComponent<UnityEngine.AudioSource>();
            val_30.PlayOneShot(clip:  this.brokenAudio);
        }
        
        UnityEngine.Animation val_21 = this.GetComponent<UnityEngine.Animation>();
        if(val_21 != null)
        {
                val_21.Stop();
        }
        else
        {
                val_21.Stop();
        }
        
        bool val_22 = val_21.Play(animation:  "Broken");
        this.Invoke(methodName:  "DestroyChestRPC", time:  0.5f);
    }
    private int 专与丏丞三与不不丆()
    {
        return (int)((UnityEngine.Random.Range(min:  0, max:  100)) > 69) ? 1 : 0;
    }
    private void 丁丟丝且丛丆丂丄丕()
    {
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  18, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  System.Array.Empty<System.Object>());
    }
    private void DestroyChestRPC()
    {
        UnityEngine.Debug.Log(message:  "DestroyChestRPC");
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                丅丒丗丑丒丙丛不丆.Destroy(专丟丆且丈丝业丂万:  this.gameObject);
            return;
        }
        
        this.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public ChestController()
    {
        this.isStartChest = true;
        this.live = 5f;
    }
    private static ChestController()
    {
        ChestController.weaponForHungerGames = new int[12] {1, 2, 3, 8, 53, 5, 52, 51, 66, 67, 162, 333};
    }

}
