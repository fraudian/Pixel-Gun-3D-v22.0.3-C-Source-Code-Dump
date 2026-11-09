using UnityEngine;
public class WeaponBonusPreview : MonoBehaviour
{
    // Fields
    public string weaponBonusName;
    public UnityEngine.Transform point;
    private bool 东丅丞丁丗万且丁丗;
    private UnityEngine.Vector3 丐丒丙丈丟专丟丒丁;
    private static int 丞世不丒下上上丝丑;
    public int thisIndex;
    private float 丙一丑丏丁一且丒业;
    public int ammoInClip;
    public int initialAmmoInBackUp;
    internal ChestBatleRoyale.丞上七丈丗丝与丏丄 世丟万一丘丐丙丝与;
    
    // Methods
    private void Start()
    {
        null = null;
        int val_1 = WeaponBonusPreview.丞世不丒下上上丝丑;
        val_1 = val_1 + 1;
        WeaponBonusPreview.丞世不丒下上上丝丑 = val_1;
        this.thisIndex = WeaponBonusPreview.丞世不丒下上上丝丑;
    }
    private void Update()
    {
        float val_12;
        float val_13;
        var val_14;
        var val_15;
        var val_16;
        if(this.东丅丞丁丗万且丁丗 == false)
        {
                return;
        }
        
        val_12 = this.丙一丑丏丁一且丒业;
        val_13 = val_12 - UnityEngine.Time.deltaTime;
        this.丙一丑丏丁一且丒业 = val_13;
        if(val_13 >= 0)
        {
            goto label_6;
        }
        
        UnityEngine.Vector3 val_3 = this.transform.position;
        val_12 = val_3.y;
        val_13 = 1E-05f;
        val_3.y = val_12 - S9;
        if(System.Math.Abs(val_3.y) >= 0)
        {
            goto label_6;
        }
        
        this.东丅丞丁丗万且丁丗 = false;
        this.GetComponent<UnityEngine.BoxCollider>().enabled = false;
        this.GetComponent<UnityEngine.Rigidbody>().isKinematic = true;
        if(this.世丟万一丘丐丙丝与 == 2)
        {
            goto label_9;
        }
        
        if(this.世丟万一丘丐丙丝与 != 1)
        {
                return;
        }
        
        val_14 = null;
        val_14 = null;
        BonusController.丄丞丁丈与业上丞丟.丝丄专丌万万丆丘七(丆与丕丕丂下丟一丈:  this.weaponBonusName, 丏丄丕丁丅丑丌万东:  this);
        return;
        label_6:
        UnityEngine.Vector3 val_7 = this.transform.position;
        this.丐丒丙丈丟专丟丒丁 = val_7;
        mem[1152921540696724288] = val_7.y;
        mem[1152921540696724292] = val_7.z;
        return;
        label_9:
        val_15 = null;
        val_15 = null;
        BonusController.丄丞丁丈与业上丞丟.丂丏下丞下丅丐七世(丑与丅东万丟世丄丌:  this);
        val_16 = null;
        val_16 = null;
        object[] val_8 = new object[4];
        val_8[0] = this.weaponBonusName;
        UnityEngine.Vector3 val_10 = this.transform.position;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_8[1] = val_11;
        val_8[2] = this.ammoInClip;
        val_8[3] = this.thisIndex;
        PickUpObjectSystem.PickUpObjectController.丄丘七三上丕世丞业.AddPickUpObject(丂一丘丞丗下丝丁丞:  1, 专丒丌丆下丐丞丟丞:  val_8);
    }
    public void SetModel(string 丝三丛且丘不丌丙下)
    {
        this.weaponBonusName = 丝三丛且丘不丌丙下;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丂丒丆丏丁业丁丁丂());
    }
    private System.Collections.IEnumerator 丂丒丆丏丁业丁丁丂()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new WeaponBonusPreview.丌与世丗丕丛丒丈业();
    }
    private void 上丂业丟七丕丂丒东(UnityEngine.ResourceRequest 与上丏下万丛世丑且)
    {
        UnityEngine.GameObject val_5 = 与上丏下万丛世丑且.asset;
        if(val_5 != null)
        {
                if(null == null)
        {
            goto label_3;
        }
        
        }
        
        val_5 = 0;
        label_3:
        丄丝不丂丕七万丘且.东丝七丛丄丙丝三七(上丞不世东丛东下丒:  val_5, 丌专业且丛丏丞丝且:  new 丄丝不丂丕七万丘且.业丛不与丕丈一与专<UnityEngine.GameObject, UnityEngine.Vector3, UnityEngine.Vector3, System.String, System.Single, System.Int32, System.Int32>(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void WeaponBonusPreview::下丞上丁丗丁丑丝丏(UnityEngine.GameObject 丏丗上丙上世东东且, UnityEngine.Vector3 上下七丗丞丁不万丏, UnityEngine.Vector3 丁丂专丑丙丞七专与, string 一丛丞丑丛不丏一不, float 七丂且丄业丐丂丐丏, int 业万上丆丐丞且丒七, int 丙丑七万丆万丆且丌)), 七丆丒与丗丌丄且丂:  val_2.categoryNabor - 1, 丐丑七万丌丂专与丌:  val_5.GetComponent<WeaponSounds>());
    }
    private void 三丗丏业丞丛丑下与(UnityEngine.ResourceRequest 与上丏下万丛世丑且)
    {
        UnityEngine.GameObject val_9;
        UnityEngine.Object val_1 = 与上丏下万丛世丑且.asset;
        if(val_1 != null)
        {
                val_1 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_9 = 0;
        }
        
        UnityEngine.GameObject val_2 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_9);
        val_2.transform.SetParent(p:  this.point);
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  val_2, 不东丛三丂丌丑专丆:  0);
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        val_2.transform.localScale = new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z};
        val_2.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_8 = UnityEngine.Quaternion.identity;
        val_2.transform.localRotation = new UnityEngine.Quaternion() {x = val_8.x, y = val_8.y, z = val_8.z, w = val_8.w};
    }
    private string 丘不丗丁丛丘东丛一()
    {
        string val_1;
        string val_2;
        if(this.世丟万一丘丐丙丝与 != 2)
        {
                if(this.世丟万一丘丐丙丝与 != 1)
        {
                return "";
        }
        
            val_1 = this.weaponBonusName;
            val_2 = "Weapons/";
            return val_2 + val_1;
        }
        
        val_1 = this.weaponBonusName;
        val_2 = "GadgetBRPrefab/";
        return val_2 + val_1;
    }
    public WeaponBonusPreview()
    {
        this.东丅丞丁丗万且丁丗 = true;
        this.weaponBonusName = System.String.alignConst;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  -1000f);
        this.丐丒丙丈丟专丟丒丁 = val_2;
        mem[1152921540697603168] = val_2.y;
        mem[1152921540697603172] = val_2.z;
        this.丙一丑丏丁一且丒业 = 1.007812f;
        this.ammoInClip = 0;
        this.initialAmmoInBackUp = 0;
    }
    private static WeaponBonusPreview()
    {
    
    }
    private void 下丞上丁丗丁丑丝丏(UnityEngine.GameObject 丏丗上丙上世东东且, UnityEngine.Vector3 上下七丗丞丁不万丏, UnityEngine.Vector3 丁丂专丑丙丞七专与, string 一丛丞丑丛不丏一不, float 七丂且丄业丐丂丐丏, int 业万上丆丐丞且丒七, int 丙丑七万丆万丆且丌)
    {
        丏丗上丙上世东东且.transform.SetParent(p:  this.point);
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  丏丗上丙上世东东且, 不东丛三丂丌丑专丆:  29);
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        丏丗上丙上世东东且.transform.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        丏丗上丙上世东东且.transform.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        float val_7 = -20f;
        val_7 = 丁丂专丑丙丞七专与.x + val_7;
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        丏丗上丙上世东东且.transform.localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_6.y, z = val_6.z, w = val_6.w};
    }

}
