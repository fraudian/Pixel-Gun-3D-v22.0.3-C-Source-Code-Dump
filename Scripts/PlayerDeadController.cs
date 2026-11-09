using UnityEngine;
public sealed class PlayerDeadController : MonoBehaviour
{
    // Fields
    private float 丑丅三丗丌丞三丘丂;
    private float maxliveTime;
    public bool isInUse;
    private UnityEngine.Transform 万东万丆专丌丕丐丗;
    public UnityEngine.GameObject playerDeadGameObject;
    public UnityEngine.GameObject playerDeadExplosionGameObject;
    public UnityEngine.GameObject playerDeadCartoonGameObject;
    public DeadRagdollController deadRagdoll;
    public DeadRagdollController deadExplosionRagdoll;
    public DeadRagdollController deadCartoonRagdoll;
    public UnityEngine.GameObject[] playerDeads;
    public DeadEnergyController deadEnergyController;
    public DeadExplosionController deadExplosionController;
    public bool isLow;
    public bool isImposter;
    private bool 下上丐万丅丘丏不丂;
    internal RoyaleAvatar 丞三丗丕七丄不丞业;
    public PlayerDeadController.DeathTypeSettingsParam[] deathTypeSettings;
    
    // Methods
    private void Awake()
    {
        if(this.下上丐万丅丘丏不丂 == true)
        {
                return;
        }
        
        this.万东万丆专丌丕丐丗 = this.transform;
        this.下上丐万丅丘丏不丂 = true;
    }
    private void 丘上丐世丆丑且丞丒()
    {
        if(this.下上丐万丅丘丏不丂 == true)
        {
                return;
        }
        
        this.万东万丆专丌丕丐丗 = this.transform;
        this.下上丐万丅丘丏不丂 = true;
    }
    public void StartShow(UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Vector3 丘丌三丕丙万万丅丑, UnityEngine.Quaternion 丙丆与丅丈丑一且丏, int 与丘丂下丘丁丅与东, bool 丁丈丄不且专丘与世, UnityEngine.Texture 丑丄丅丟丙丛丒丑丅, string 丝三丛且丘不丌丙下, RoyaleAvatar 丕专丆三世丏丆丌东)
    {
        var val_1;
        var val_2;
        this.丞三丗丕七丄不丞业 = 丕专丆三世丏丆丌东;
        val_1 = val_1;
        val_2 = val_2;
        this.东且丞丏世一不丂丝(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z}, 丘丌三丕丙万万丅丑:  new UnityEngine.Vector3() {x = 丘丌三丕丙万万丅丑.x, y = 丘丌三丕丙万万丅丑.y, z = 丘丌三丕丙万万丅丑.z}, 丙丆与丅丈丑一且丏:  new UnityEngine.Quaternion() {x = 丙丆与丅丈丑一且丏.x, y = 丙丆与丅丈丑一且丏.y, z = 丙丆与丅丈丑一且丏.z, w = 丙丆与丅丈丑一且丏.w}, 与丘丂下丘丁丅与东:  与丘丂下丘丁丅与东, 丁丈丄不且专丘与世:  false, 丑丄丅丟丙丛丒丑丅:  丑丄丅丟丙丛丒丑丅, 丝三丛且丘不丌丙下:  丝三丛且丘不丌丙下, 丕专丆三世丏丆丌东:  丕专丆三世丏丆丌东);
    }
    private void 东丄七世丑丆三丑下(UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Quaternion 丙丆与丅丈丑一且丏, int 与丘丂下丘丁丅与东, bool 丁丈丄不且专丘与世, UnityEngine.Texture 丑丄丅丟丙丛丒丑丅, RoyaleAvatar 丕专丆三世丏丆丌东)
    {
        this.丑丅三丗丌丞三丘丂 = this.maxliveTime;
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z};
        this.万东万丆专丌丕丐丗.rotation = new UnityEngine.Quaternion() {x = 丙丆与丅丈丑一且丏.x, y = 丙丆与丅丈丑一且丏.y, z = 丙丆与丅丈丑一且丏.z, w = 丙丆与丅丈丑一且丏.w};
        this.playerDeadGameObject.SetActive(value:  false);
        if(与丘丂下丘丁丅与东 == 1)
        {
                this.playerDeads[1].SetActive(value:  true);
            this.deadExplosionController.StartAnim();
            return;
        }
        
        if((与丘丂下丘丁丅与东 - 2) > 7)
        {
                this.playerDeads[0].SetActive(value:  true);
            return;
        }
        
        this.playerDeads[2].SetActive(value:  true);
        DeathTypeSettingsParam val_5 = this.deathTypeSettings[(long)与丘丂下丘丁丅与东];
        this.deadEnergyController.StartAnim(丂丄一丗业丗丐万丏:  new UnityEngine.Color() {r = this.deathTypeSettings[(long)(int)(与丘丂下丘丁丅与东)][0].burnColor, g = 丙丆与丅丈丑一且丏.z, b = 丙丆与丅丈丑一且丏.x, a = 丙丆与丅丈丑一且丏.y}, 丑丄丅丟丙丛丒丑丅:  丑丄丅丟丙丛丒丑丅, 丅世丟三下丌丝七与:  丕专丆三世丏丆丌东);
    }
    private void 东且丞丏世一不丂丝(UnityEngine.Vector3 下业丕七东丌丝下且, UnityEngine.Vector3 丘丌三丕丙万万丅丑, UnityEngine.Quaternion 丙丆与丅丈丑一且丏, int 与丘丂下丘丁丅与东, bool 丁丈丄不且专丘与世, UnityEngine.Texture 丑丄丅丟丙丛丒丑丅, string 丝三丛且丘不丌丙下, RoyaleAvatar 丕专丆三世丏丆丌东)
    {
        float val_1;
        float val_2;
        string val_25;
        float val_26;
        float val_27;
        float val_29;
        float val_30;
        DeadRagdollController val_31;
        丁丆一丂上东丁丝且 val_32;
        val_25 = 丝三丛且丘不丌丙下;
        int val_3 = (this.deathTypeSettings.Length > 与丘丂下丘丁丅与东) ? 与丘丂下丘丁丅与东 : 0;
        if(this.下上丐万丅丘丏不丂 == false)
        {
            goto label_2;
        }
        
        if(this.万东万丆专丌丕丐丗 != null)
        {
            goto label_14;
        }
        
        label_15:
        label_14:
        this.万东万丆专丌丕丐丗.position = new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z};
        val_26 = 丙丆与丅丈丑一且丏.x;
        this.万东万丆专丌丕丐丗.rotation = new UnityEngine.Quaternion() {x = val_26, y = val_2, z = 丙丆与丅丈丑一且丏.y, w = val_1};
        if(this.deadRagdoll != 0)
        {
                if(this.deadExplosionRagdoll != 0)
        {
                this.deadRagdoll.LoadBoneParams();
            this.deadExplosionRagdoll.LoadBoneParams();
        }
        
        }
        
        this.丞丞丕丒上世专丐丗(丙业与丙丗丝不丈东:  true, 东丏业丞丞业下丄世:  val_3);
        this.丑丅三丗丌丞三丘丂 = this.maxliveTime;
        if(this.isLow == false)
        {
            goto label_13;
        }
        
        return;
        label_2:
        UnityEngine.Transform val_6 = this.transform;
        this.万东万丆专丌丕丐丗 = val_6;
        this.下上丐万丅丘丏不丂 = true;
        if(val_6 != null)
        {
            goto label_14;
        }
        
        goto label_15;
        label_13:
        DeathTypeSettingsParam val_24 = this.deathTypeSettings[(long)val_3];
        三丅丁丗丗丝丂万且 val_7 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_25);
        if(val_7 == null)
        {
            goto label_21;
        }
        
        if(val_7 > 4)
        {
            goto label_22;
        }
        
        val_27 = mem[106025728 + (val_7) << 2];
        val_27 = 106025728 + (val_7) << 2;
        goto label_23;
        label_21:
        if((PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丈丈丒丈与丐丞三丆(丁丅丈丌丟世丗丗丟:  80, 丞一丁业丄一一业且:  val_25)) < 1)
        {
            goto label_27;
        }
        
        val_25 = Rilisoft.Singleton<Rilisoft.PetsManager>.Instance.丛丐不丐丘丘万丒丂(世丐丗专丅三丝丑丆:  val_25);
        if(val_11.Rarity > 4)
        {
            goto label_30;
        }
        
        val_27 = mem[106025728 + (val_11.Rarity) << 2];
        val_27 = 106025728 + (val_11.Rarity) << 2;
        goto label_31;
        label_22:
        val_27 = 1f;
        label_23:
        val_25 = val_7.东专与七下业不丈丅();
        float val_13 = val_7.与丄丛丂一三丆丄且();
        float val_25 = 110f;
        val_25 = val_25 - (float)val_25;
        val_29 = val_25 / 100f;
        goto label_32;
        label_27:
        val_30 = 0f;
        val_27 = 1f;
        if(((PGCompany.丂且专丕丞一上与一.丑七不且上丗丁一世().丈丈丒丈与丐丞三丆(丁丅丈丌丟世丗丗丟:  70, 丞一丁业丄一一业且:  val_25)) < 1) || ((丁下万丟且丟丛下业.一三专丞丒丅上业上().ContainsKey(key:  val_25)) == false))
        {
            goto label_45;
        }
        
        val_25 = 丁下万丟且丟丛下业.一三专丞丒丅上业上().Item[val_25];
        val_30 = val_25.与丄丛丂一三丆丄且();
        goto label_45;
        label_30:
        val_27 = 1f;
        label_31:
        val_26 = val_11.ragdollImpulse;
        val_29 = 0.2f;
        label_32:
        val_30 = val_26 * val_29;
        label_45:
        float val_26 = 2000f;
        val_26 = val_27 * val_26;
        val_30 = val_30 * val_26;
        if(val_3 == 0)
        {
            goto label_50;
        }
        
        if((val_3 - 2) <= 7)
        {
            goto label_49;
        }
        
        if((val_3 - 1) > 15)
        {
            goto label_50;
        }
        
        var val_27 = 106025628 + ((this.deathTypeSettings.Length > 与丘丂下丘丁丅与东 ? 与丘丂下丘丁丅与东 : 0 - 1)) << 2;
        val_27 = val_27 + 106025628;
        goto (106025628 + ((this.deathTypeSettings.Length > 与丘丂下丘丁丅与东 ? 与丘丂下丘丁丅与东 : 0 - 1)) << 2 + 106025628);
        label_50:
        val_31 = this.deadRagdoll;
        val_32 = 3;
        goto label_54;
        label_49:
        val_31 = this.deadRagdoll;
        val_32 = 2;
        label_54:
        val_31.StartAnim(万丁世丁东七一丙丅:  new UnityEngine.Color() {r = this.deathTypeSettings[(long)(int)(this.deathTypeSettings.Length > 与丘丂下丘丁丅与东 ? 与丘丂下丘丁丅与东 : 0)][0].burnColor, g = val_2, b = 丙丆与丅丈丑一且丏.y, a = val_1}, 丕且下丟丙丌丅丏专:  丑丄丅丟丙丛丒丑丅, 丘一丙丁丌丆万丂东:  丕专丆三世丏丆丌东, 丙与一丂丕与丏东上:  val_32, 丝业丒东不一丅丐一:  new UnityEngine.Vector3() {x = 丘丌三丕丙万万丅丑.x, y = 丘丌三丕丙万万丅丑.y, z = 丘丌三丕丙万万丅丑.z}, 三一七丞东丛下一丂:  UnityEngine.Mathf.Clamp(value:  val_30, min:  100f, max:  1000f));
    }
    private void Update()
    {
        float val_2;
        if(this.isImposter == true)
        {
                return;
        }
        
        if(this.丑丅三丗丌丞三丘丂 < 0)
        {
                return;
        }
        
        val_2 = this.丑丅三丗丌丞三丘丂 - UnityEngine.Time.deltaTime;
        this.丑丅三丗丌丞三丘丂 = val_2;
        if(this.isLow != true)
        {
                this.deadRagdoll.UpdateRagdoll();
            if(this.isLow != true)
        {
                this.deadExplosionRagdoll.UpdateRagdoll();
            if(this.isLow != true)
        {
                this.deadCartoonRagdoll.UpdateRagdoll();
        }
        
        }
        
            val_2 = this.丑丅三丗丌丞三丘丂;
        }
        
        if(val_2 >= 0)
        {
                return;
        }
        
        this.丞丞丕丒上世专丐丗(丙业与丙丗丝不丈东:  false, 东丏业丞丞业下丄世:  0);
    }
    internal void 丞丞丕丒上世专丐丗(bool 丙业与丙丗丝不丈东, int 东丏业丞丞业下丄世 = -1)
    {
        UnityEngine.GameObject val_2;
        UnityEngine.GameObject val_3;
        var val_4;
        if((东丏业丞丞业下丄世 == 1) || (丙业与丙丗丝不丈东 == false))
        {
            goto label_2;
        }
        
        if(东丏业丞丞业下丄世 > 13)
        {
            goto label_4;
        }
        
        var val_2 = 1;
        val_2 = val_2 << 东丏业丞丞业下丄世;
        val_2 = val_2 & 12290;
        if(val_2 == 0)
        {
            goto label_4;
        }
        
        val_2 = this.playerDeadGameObject;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  false);
        val_3 = this.playerDeadExplosionGameObject;
        val_4 = 1;
        goto label_7;
        label_2:
        val_2 = this.playerDeadGameObject;
        label_16:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_2, 丏业丟一东丂东丘丛:  false);
        val_3 = this.playerDeadExplosionGameObject;
        val_4 = 0;
        label_7:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  false);
        label_13:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.playerDeadCartoonGameObject, 丏业丟一东丂东丘丛:  false);
        this.isInUse = 丙业与丙丗丝不丈东;
        return;
        label_4:
        if(东丏业丞丞业下丄世 != 14)
        {
            goto label_16;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.playerDeadGameObject, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.playerDeadExplosionGameObject, 丏业丟一东丂东丘丛:  false);
        goto label_13;
    }
    internal UnityEngine.Vector3 丈丈丘丂万丄丟不丑()
    {
        if(this.deadRagdoll == 0)
        {
                if(this.transform != null)
        {
                return 0.position;
        }
        
            return 0.position;
        }
        
        this = this.deadRagdoll;
        if(this.RootRigidBodyTransform != null)
        {
                return 0.position;
        }
        
        return 0.position;
    }
    public PlayerDeadController()
    {
        this.丑丅三丗丌丞三丘丂 = -1f;
        this.maxliveTime = 5.510186E-41f;
        DeathTypeSettingsParam[] val_1 = new DeathTypeSettingsParam[16];
        UnityEngine.Color val_2 = UnityEngine.Color.gray;
        PlayerDeadController.DeathTypeSettingsParam val_3 = new PlayerDeadController.DeathTypeSettingsParam();
        .deathType = 0;
        .burnColor = val_2;
        mem[1152921535916781864] = val_2.g;
        mem[1152921535916781868] = val_2.b;
        mem[1152921535916781872] = val_2.a;
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(val_3 != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(val_3 == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = val_3;
        UnityEngine.Color val_4 = UnityEngine.Color.red;
        .burnColor = val_4;
        mem[1152921535916785960] = val_4.g;
        .deathType = 1;
        mem[1152921535916785964] = val_4.b;
        mem[1152921535916785968] = val_4.a;
        val_1[1] = new PlayerDeadController.DeathTypeSettingsParam();
        UnityEngine.Color val_6 = UnityEngine.Color.blue;
        .burnColor = val_6;
        mem[1152921535916790056] = val_6.g;
        .deathType = 2;
        mem[1152921535916790060] = val_6.b;
        mem[1152921535916790064] = val_6.a;
        val_1[2] = new PlayerDeadController.DeathTypeSettingsParam();
        UnityEngine.Color val_8 = UnityEngine.Color.red;
        .burnColor = val_8;
        mem[1152921535916794152] = val_8.g;
        .deathType = 3;
        mem[1152921535916794156] = val_8.b;
        mem[1152921535916794160] = val_8.a;
        val_1[3] = new PlayerDeadController.DeathTypeSettingsParam();
        UnityEngine.Color val_10 = UnityEngine.Color.magenta;
        .burnColor = val_10;
        mem[1152921535916798248] = val_10.g;
        .deathType = 4;
        mem[1152921535916798252] = val_10.b;
        mem[1152921535916798256] = val_10.a;
        val_1[4] = new PlayerDeadController.DeathTypeSettingsParam();
        UnityEngine.Color val_12 = UnityEngine.Color.cyan;
        .burnColor = val_12;
        mem[1152921535916802344] = val_12.g;
        .deathType = 5;
        mem[1152921535916802348] = val_12.b;
        mem[1152921535916802352] = val_12.a;
        val_1[5] = new PlayerDeadController.DeathTypeSettingsParam();
        UnityEngine.Color val_14 = UnityEngine.Color.yellow;
        .burnColor = val_14;
        mem[1152921535916806440] = val_14.g;
        .deathType = 6;
        mem[1152921535916806444] = val_14.b;
        mem[1152921535916806448] = val_14.a;
        val_1[6] = new PlayerDeadController.DeathTypeSettingsParam();
        UnityEngine.Color val_16 = UnityEngine.Color.green;
        .burnColor = val_16;
        mem[1152921535916810536] = val_16.g;
        .deathType = 7;
        mem[1152921535916810540] = val_16.b;
        mem[1152921535916810544] = val_16.a;
        val_1[7] = new PlayerDeadController.DeathTypeSettingsParam();
        UnityEngine.Color val_18 = UnityEngine.Color.red;
        .burnColor = val_18;
        mem[1152921535916814632] = val_18.g;
        .deathType = 8;
        mem[1152921535916814636] = val_18.b;
        mem[1152921535916814640] = val_18.a;
        val_1[8] = new PlayerDeadController.DeathTypeSettingsParam();
        UnityEngine.Color val_20 = UnityEngine.Color.white;
        .burnColor = val_20;
        mem[1152921535916818728] = val_20.g;
        .deathType = 9;
        mem[1152921535916818732] = val_20.b;
        mem[1152921535916818736] = val_20.a;
        val_1[9] = new PlayerDeadController.DeathTypeSettingsParam();
        UnityEngine.Color val_22 = UnityEngine.Color.blue;
        .burnColor = val_22;
        mem[1152921535916822824] = val_22.g;
        .deathType = 10;
        mem[1152921535916822828] = val_22.b;
        mem[1152921535916822832] = val_22.a;
        val_1[10] = new PlayerDeadController.DeathTypeSettingsParam();
        UnityEngine.Color val_24 = UnityEngine.Color.black;
        .burnColor = val_24;
        mem[1152921535916826920] = val_24.g;
        .deathType = 11;
        mem[1152921535916826924] = val_24.b;
        mem[1152921535916826928] = val_24.a;
        val_1[11] = new PlayerDeadController.DeathTypeSettingsParam();
        UnityEngine.Color val_26 = UnityEngine.Color.gray;
        .burnColor = val_26;
        mem[1152921535916831016] = val_26.g;
        .deathType = 12;
        mem[1152921535916831020] = val_26.b;
        mem[1152921535916831024] = val_26.a;
        val_1[12] = new PlayerDeadController.DeathTypeSettingsParam();
        UnityEngine.Color val_28 = UnityEngine.Color.black;
        .burnColor = val_28;
        mem[1152921535916835112] = val_28.g;
        .deathType = 13;
        mem[1152921535916835116] = val_28.b;
        mem[1152921535916835120] = val_28.a;
        val_1[13] = new PlayerDeadController.DeathTypeSettingsParam();
        UnityEngine.Color val_30 = UnityEngine.Color.black;
        .burnColor = val_30;
        mem[1152921535916839208] = val_30.g;
        .deathType = 14;
        mem[1152921535916839212] = val_30.b;
        mem[1152921535916839216] = val_30.a;
        val_1[14] = new PlayerDeadController.DeathTypeSettingsParam();
        UnityEngine.Color val_32 = UnityEngine.Color.black;
        .burnColor = val_32;
        mem[1152921535916843304] = val_32.g;
        .deathType = 16;
        mem[1152921535916843308] = val_32.b;
        mem[1152921535916843312] = val_32.a;
        val_1[15] = new PlayerDeadController.DeathTypeSettingsParam();
        this.deathTypeSettings = val_1;
    }

}
