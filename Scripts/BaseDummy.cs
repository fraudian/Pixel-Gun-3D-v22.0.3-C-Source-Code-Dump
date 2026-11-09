using UnityEngine;
public class BaseDummy : MonoBehaviour
{
    // Fields
    public float health;
    private float 七丕七与丂专丘丟不;
    public float awakeTime;
    public float hideTime;
    private bool 丆且上丘世下丅且丞;
    private bool 丒丒与丆专丂丕丆丑;
    public bool flyTarget;
    public bool hidingTarget;
    private UnityEngine.Animation 业与丘丞丂专丘丗世;
    private UnityEngine.AudioSource 丞下上且一上丙不丏;
    private float 不丂丂一丝丐丙一丁;
    private float 一丌专万丛下丁丟三;
    public UnityEngine.Collider[] colliders;
    public UnityEngine.Transform armorArmLeft;
    public UnityEngine.Transform armorArmRight;
    public UnityEngine.Transform armorPoint;
    public BaseDummy.丌丐丁丙丈下且万丂 healthType;
    public BaseDummy.丅不丐丟丏不丟丗丞 armorType;
    public UnityEngine.SkinnedMeshRenderer skinnedMesh;
    public UnityEngine.Texture hitTexture;
    private UnityEngine.Texture 丁东专丙丕丟丏业业;
    private UnityEngine.Material 万丄丗不丞丕丘且不;
    public UnityEngine.AudioClip hitSound;
    public UnityEngine.AudioClip upSound;
    public UnityEngine.AudioClip downSound;
    public UnityEngine.Transform jetpackPoint;
    public UnityEngine.GameObject jetpackSounds;
    public UnityEngine.Transform explosionEffect;
    
    // Properties
    public bool 丒东三丌专丗三丂丟 { get; }
    
    // Methods
    public bool get_isDead()
    {
        return (bool)this.丆且上丘世下丅且丞;
    }
    private void 世丘丛三七丛东丝丕()
    {
        if(this.jetpackSounds != 0)
        {
                this.jetpackSounds.SetActive(value:  与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗());
        }
        
        if(this.jetpackPoint == 0)
        {
                return;
        }
        
        this.jetpackPoint.gameObject.SetActive(value:  true);
    }
    private void 万丐一世丌三专下丐()
    {
        if(this.jetpackSounds != 0)
        {
                this.jetpackSounds.SetActive(value:  false);
        }
        
        if(this.jetpackPoint == 0)
        {
                return;
        }
        
        this.jetpackPoint.gameObject.SetActive(value:  false);
    }
    internal void 业丂丛丟上且丂东丂(float 丛业专丘丂丅丗丝丛, Player_move_c.世不丟丂上丟与丌下 东丂丄丞三丛丆丌下)
    {
        if(this.丆且上丘世下丅且丞 == true)
        {
                return;
        }
        
        float val_2 = this.health;
        val_2 = val_2 - 丛业专丘丂丅丗丝丛;
        this.health = val_2;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.丞下上且一上丙不丏.PlayOneShot(clip:  this.hitSound);
        }
        
        if(this.health > 0f)
        {
                return;
        }
        
        this.丅丄丛丈丆不丛丟丕();
    }
    private void 丅丄丛丈丆不丛丟丕()
    {
        if(this.flyTarget == false)
        {
            goto label_1;
        }
        
        UnityEngine.Vector3 val_2 = this.explosionEffect.position;
        UnityEngine.Quaternion val_3 = UnityEngine.Quaternion.identity;
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.explosionEffect.gameObject, position:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, rotation:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_3.w});
        if(val_4 == null)
        {
            goto label_8;
        }
        
        val_4.SetActive(value:  true);
        goto label_9;
        label_1:
        this.丁丆三丈与万丗业不();
        return;
        label_8:
        val_4.SetActive(value:  true);
        label_9:
        val_4.GetComponent<UnityEngine.AudioSource>().enabled = 与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗();
        UnityEngine.Object.Destroy(obj:  val_4, t:  2f);
        this.GetComponent<MovingDummy>().ResetPath();
        this.health = this.七丕七与丂专丘丟不;
    }
    private void 丌丐丌丟不万业业业(int 丗东丏与上丆丌不且)
    {
    
    }
    private System.Collections.IEnumerator 丛丑丅丝丞专丐丙丌(bool 万东丏丌不七东丘万)
    {
        BaseDummy.上丛丑不丏不业专丘 val_1 = new BaseDummy.上丛丑不丏不业专丘();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .万东丏丌不七东丘万 = 万东丏丌不七东丘万;
        return (System.Collections.IEnumerator)val_1;
    }
    public void SetTextureForBody(UnityEngine.Texture 与万丆丛丒万丝丙丑)
    {
        if(this.万丄丗不丞丕丘且不 == 0)
        {
                return;
        }
        
        this.万丄丗不丞丕丘且不.mainTexture = 与万丆丛丒万丝丙丑;
    }
    private void Awake()
    {
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        if(this.丆且上丘世下丅且丞 == true)
        {
                return;
        }
        
        this.丞下上且一上丙不丏 = this.GetComponent<UnityEngine.AudioSource>();
        UnityEngine.Animation val_2 = this.GetComponent<UnityEngine.Animation>();
        this.业与丘丞丂专丘丗世 = val_2;
        bool val_3 = val_2.Play(animation:  "Dummy_Idle", mode:  4);
        if(this.healthType == 0)
        {
            goto label_3;
        }
        
        if(this.healthType == 2)
        {
            goto label_4;
        }
        
        if(this.healthType != 1)
        {
            goto label_30;
        }
        
        val_20 = null;
        val_20 = null;
        if(ExpController.万上一丝丆且七丅丅() >= ExpController.LevelsForTiers.Length)
        {
            goto label_30;
        }
        
        goto label_30;
        label_3:
        val_21 = null;
        val_21 = null;
        int val_5 = ExpController.万上一丝丆且七丅丅();
        System.Int32[] val_6 = ExpController.LevelsForTiers + (((long)(int)(val_5)) << 2);
        if((ExpController.万上一丝丆且七丅丅() + 1) >= ExpController.LevelsForTiers.Length)
        {
            goto label_16;
        }
        
        val_22 = null;
        val_22 = null;
        int val_10 = ExpController.万上一丝丆且七丅丅() + 1;
        System.Int32[] val_11 = ExpController.LevelsForTiers + (((long)(int)((val_9 + 1))) << 2);
        val_23 = mem[(ExpController.LevelsForTiers + ((long)(int)((val_9 + 1))) << 2) + 32];
        val_23 = (ExpController.LevelsForTiers + ((long)(int)((val_9 + 1))) << 2) + 32;
        goto label_21;
        label_4:
        val_24 = null;
        val_24 = null;
        if((ExpController.万上一丝丆且七丅丅() + 1) >= ExpController.LevelsForTiers.Length)
        {
            goto label_30;
        }
        
        val_25 = null;
        val_25 = null;
        if((ExpController.万上一丝丆且七丅丅() + 1) < ExpController.LevelsForTiers.Length)
        {
            goto label_30;
        }
        
        goto label_30;
        label_16:
        val_23 = 65;
        label_21:
        float val_20 = (float)65 + ((ExpController.LevelsForTiers + ((long)(int)(val_5)) << 2) + 32);
        val_20 = val_20 * 0.5f;
        int val_17 = UnityEngine.Mathf.RoundToInt(f:  val_20);
        label_30:
        val_26 = null;
        val_26 = null;
        this.health = 1.152922E+18f;
        this.七丕七与丂专丘丟不 = 1.152922E+18f;
        UnityEngine.Material val_18 = this.skinnedMesh.material;
        this.万丄丗不丞丕丘且不 = val_18;
        this.skinnedMesh.sharedMaterial = val_18;
        this.丁东专丙丕丟丏业业 = this.万丄丗不丞丕丘且不.mainTexture;
    }
    private void Start()
    {
        if(this.flyTarget != false)
        {
                return;
        }
        
        this.flyTarget = true;
    }
    private void 丁丆三丈与万丗业不()
    {
        var val_10;
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != false)
        {
                this.丞下上且一上丙不丏.clip = this.downSound;
            this.丞下上且一上丙不丏.Play();
        }
        
        val_10 = 0;
        this.丆且上丘世下丅且丞 = true;
        goto label_6;
        label_10:
        this.colliders[0].enabled = false;
        val_10 = 1;
        label_6:
        if(val_10 < this.colliders.Length)
        {
            goto label_10;
        }
        
        bool val_2 = this.业与丘丞丂专丘丗世.Play(animation:  "Dead", mode:  4);
        float val_3 = UnityEngine.Time.time;
        val_3 = val_3 + this.awakeTime;
        this.一丌专万丛下丁丟三 = val_3;
        if(this.hidingTarget == false)
        {
                return;
        }
        
        float val_8 = this.业与丘丞丂专丘丗世.GetClip(name:  "Dead").length;
        float val_9 = UnityEngine.Time.time + this.hideTime;
        val_9 = val_9 + (this.业与丘丞丂专丘丗世.GetClip(name:  "Dummy_Up").length);
        val_8 = val_9 + val_8;
        this.不丂丂一丝丐丙一丁 = val_8;
    }
    private System.Collections.IEnumerator 丏丌专万丙丝丝丈一()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BaseDummy.丏上不世业丞下丏丐();
    }
    private void OnDestroy()
    {
    
    }
    private void Update()
    {
        if(this.丆且上丘世下丅且丞 != false)
        {
                return;
        }
        
        if(this.hidingTarget != false)
        {
                float val_1 = UnityEngine.Time.time;
            if(this.不丂丂一丝丐丙一丁 < 0)
        {
                this.丒丒与丆专丂丕丆丑 = true;
            this.丁丆三丈与万丗业不();
        }
        
        }
        
        if(this.丆且上丘世下丅且丞 == false)
        {
                return;
        }
        
        float val_2 = UnityEngine.Time.time;
        if(this.一丌专万丛下丁丟三 >= 0)
        {
                return;
        }
        
        if(this.丒丒与丆专丂丕丆丑 != true)
        {
                this.health = this.七丕七与丂专丘丟不;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丏丌专万丙丝丝丈一());
    }
    public void SetArmor(string 与丙丕丛一丌丛丆丈)
    {
        int val_23;
        UnityEngine.Object val_24;
        var val_25;
        UnityEngine.Transform val_26;
        float val_27;
        float val_28;
        float val_29;
        float val_30;
        string val_23 = 与丙丕丛一丌丛丆丈;
        val_23 = this;
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "Armor/"("Armor/") + val_23);
        if(val_2 != null)
        {
                val_23 = (null == null) ? (val_2) : 0;
        }
        else
        {
                val_24 = 0;
        }
        
        if(val_24 == 0)
        {
                UnityEngine.Debug.LogWarning(message:  "armorPrefab == null");
            return;
        }
        
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_24);
        ArmorRefs val_7 = val_4.transform.GetChild(index:  0).GetComponent<ArmorRefs>();
        val_25 = val_7;
        if(val_7 == 0)
        {
                return;
        }
        
        if(val_7.leftBone != 0)
        {
                val_26 = this.armorArmLeft;
            val_7.leftBone.parent = val_26;
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
            val_7.leftBone.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
            UnityEngine.Quaternion val_11 = UnityEngine.Quaternion.identity;
            val_27 = val_11.w;
            val_7.leftBone.localRotation = new UnityEngine.Quaternion() {x = val_11.x, y = val_11.y, z = val_11.z, w = val_27};
            val_28 = 0f;
            val_29 = 0f;
            val_30 = 0f;
            val_7.leftBone.localScale = new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30};
        }
        
        if(val_7.rightBone != 0)
        {
                val_26 = this.armorArmRight;
            val_7.rightBone.parent = val_26;
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
            val_7.rightBone.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
            UnityEngine.Quaternion val_14 = UnityEngine.Quaternion.identity;
            val_27 = val_14.w;
            val_7.rightBone.localRotation = new UnityEngine.Quaternion() {x = val_14.x, y = val_14.y, z = val_14.z, w = val_27};
            val_28 = 0f;
            val_29 = 0f;
            val_30 = 0f;
            val_7.rightBone.localScale = new UnityEngine.Vector3() {x = val_28, y = val_29, z = val_30};
        }
        
        val_4.transform.parent = this.armorPoint;
        UnityEngine.Vector3 val_17 = UnityEngine.Vector3.zero;
        val_4.transform.localPosition = new UnityEngine.Vector3() {x = val_17.x, y = val_17.y, z = val_17.z};
        UnityEngine.Quaternion val_19 = UnityEngine.Quaternion.identity;
        val_4.transform.localRotation = new UnityEngine.Quaternion() {x = val_19.x, y = val_19.y, z = val_19.z, w = val_19.w};
        val_25 = val_4.transform;
        val_25.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        val_23 = this.gameObject.layer;
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_4, 不东丛三丂丌丑专丆:  val_23);
    }
    public BaseDummy()
    {
        this.awakeTime = 2f;
        this.hideTime = 2f;
        this.丆且上丘世下丅且丞 = true;
        this.healthType = true;
    }

}
