using UnityEngine;
internal sealed class FortFieldTurretPlatformController : PGBehaviour
{
    // Fields
    private string 丝东且丟丂业与丐上;
    private string 且丆下三七上一上丞;
    internal System.Collections.Generic.List<UnityEngine.Transform> turretPlatforms;
    public static FortFieldTurretPlatformController instance;
    private float blinkSpeed;
    private float colorAlpha;
    internal System.Collections.Generic.List<FortFieldTurretPlatformController.BlinkData> blinkData;
    
    // Methods
    private void Awake()
    {
        FortFieldTurretPlatformController val_5 = this;
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Inequality(a:  val_1.m_Handle.name, b:  "FortFieldBuild")) != false)
        {
                val_5 = this.gameObject;
            val_5.SetActive(value:  false);
            return;
        }
        
        FortFieldTurretPlatformController.instance = val_5;
    }
    private void Start()
    {
        ClanFieldBuildController.丑七不且上丗丁一世().丂丑丏上丑丕丏与丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FortFieldTurretPlatformController::丛三丑且且业丛丏丅()));
    }
    internal void 丛三丑且且业丛丏丅()
    {
        var val_11;
        var val_12;
        val_11 = 0;
        goto label_1;
        label_22:
        BlinkData val_1 = this.blinkData.Item[0];
        val_12 = 0;
        val_1.nowBlink = false;
        goto label_4;
        label_20:
        if(this.blinkData.Item[0] != null)
        {
                BlinkData val_3 = this.blinkData.Item[0];
            if(val_3.blinkObjects.Item[0] != 0)
        {
                BlinkData val_6 = this.blinkData.Item[0];
            val_6.blinkObjects.Item[0].丛三丑且且业丛丏丅();
        }
        
        }
        
        val_12 = 1;
        label_4:
        BlinkData val_8 = this.blinkData.Item[0];
        if(val_12 < val_8.blinkObjects.Count)
        {
            goto label_20;
        }
        
        val_11 = 1;
        label_1:
        if(val_11 < this.blinkData.Count)
        {
            goto label_22;
        }
    
    }
    internal void 丙丘与丒七丒丞丗丈(string 丈与丏且丆丗七丑丛, string 七丐丌上上万丘三丆)
    {
        object val_9;
        FortFieldTurretPlatformController.丗丛丘丑丐不丌丑丙 val_1 = null;
        val_9 = val_1;
        val_1 = new FortFieldTurretPlatformController.丗丛丘丑丐不丌丑丙();
        if(val_9 != null)
        {
                .丈与丏且丆丗七丑丛 = 丈与丏且丆丗七丑丛;
        }
        else
        {
                mem[16] = 丈与丏且丆丗七丑丛;
        }
        
        .七丐丌上上万丘三丆 = 七丐丌上上万丘三丆;
        this.丛三丑且且业丛丏丅();
        if((this.blinkData.Find(match:  new System.Predicate<BlinkData>(object:  val_1, method:  System.Boolean FortFieldTurretPlatformController.丗丛丘丑丐不丌丑丙::丕丂丈丅与丟丘丐丄(FortFieldTurretPlatformController.BlinkData 三丟东丕丄丄下下丑)))) == null)
        {
                return;
        }
        
        val_3.nowBlink = true;
        val_9 = 0;
        goto label_5;
        label_13:
        if(val_3.blinkObjects.Item[0] != 0)
        {
                FortFieldTurretPlatform val_6 = val_3.blinkObjects.Item[0];
            val_6.丟且专丕丞丄丛丑丁 = this.blinkSpeed;
            val_6.且丁七丂丘一丄与丞 = val_6.丑丑丗丅专与世丈且;
            mem2[0] = UnityEngine.Object.__il2cppRuntimeField_cctor_finished;
            mem2[0] = this.colorAlpha * S0;
            val_6.下丄与一丁业丒业东 = true;
        }
        
        val_9 = 1;
        label_5:
        if(val_9 < val_3.blinkObjects.Count)
        {
            goto label_13;
        }
    
    }
    public UnityEngine.Vector3 GetNearestPlatfrom(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        var val_24;
        System.Func<UnityEngine.GameObject, System.Boolean> val_26;
        var val_27;
        System.Func<UnityEngine.GameObject, UnityEngine.Transform> val_29;
        System.Collections.Generic.List<UnityEngine.Transform> val_30;
        float val_31;
        float val_35;
        float val_36;
        float val_37;
        var val_38;
        ClanFieldBuildController val_2 = ClanFieldBuildController.丑七不且上丗丁一世();
        val_24 = null;
        val_24 = null;
        val_26 = FortFieldTurretPlatformController.<>c.<>9__12_0;
        if(val_26 == null)
        {
                System.Func<UnityEngine.GameObject, System.Boolean> val_4 = null;
            val_26 = val_4;
            val_4 = new System.Func<UnityEngine.GameObject, System.Boolean>(object:  FortFieldTurretPlatformController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean FortFieldTurretPlatformController.<>c::丂世专丁丌丑且丁丈(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            FortFieldTurretPlatformController.<>c.<>9__12_0 = val_26;
        }
        
        val_27 = null;
        val_27 = null;
        val_29 = FortFieldTurretPlatformController.<>c.<>9__12_1;
        if(val_29 == null)
        {
                System.Func<UnityEngine.GameObject, UnityEngine.Transform> val_6 = null;
            val_29 = val_6;
            val_6 = new System.Func<UnityEngine.GameObject, UnityEngine.Transform>(object:  FortFieldTurretPlatformController.<>c.__il2cppRuntimeField_static_fields, method:  UnityEngine.Transform FortFieldTurretPlatformController.<>c::丕丑三丈一丛丅三丂(UnityEngine.GameObject 三丟东丕丄丄下下丑));
            FortFieldTurretPlatformController.<>c.<>9__12_1 = val_29;
        }
        
        .三万丑丑丁万不丒丛 = System.Linq.Enumerable.ToList<UnityEngine.Transform>(source:  System.Linq.Enumerable.Select<UnityEngine.GameObject, UnityEngine.Transform>(source:  System.Linq.Enumerable.Where<UnityEngine.GameObject>(source:  val_2.专丁丑世业丌丏丁丛.Keys, predicate:  val_4), selector:  val_6));
        val_30 = this.turretPlatforms;
        System.Collections.Generic.List<TSource> val_11 = System.Linq.Enumerable.ToList<UnityEngine.Transform>(source:  System.Linq.Enumerable.Where<UnityEngine.Transform>(source:  val_30, predicate:  new System.Func<UnityEngine.Transform, System.Boolean>(object:  new FortFieldTurretPlatformController.丒丛丁与丅东丒不七(), method:  System.Boolean FortFieldTurretPlatformController.丒丛丁与丅东丒不七::丏丟丗下丈丄丗丁三(UnityEngine.Transform 三丟东丕丄丄下下丑))));
        if(val_11.Count == 0)
        {
            goto label_17;
        }
        
        label_35:
        UnityEngine.Vector3 val_14 = val_11.Item[0].position;
        val_31 = val_14.z;
        float val_15 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, b:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_31});
        UnityEngine.Vector3 val_17 = val_11.Item[0].position;
        val_35 = val_17.x;
        val_36 = val_17.y;
        val_37 = val_17.z;
        val_38 = 1;
        goto label_24;
        label_33:
        val_30 = val_11.Item[1];
        UnityEngine.Vector3 val_19 = val_30.position;
        val_31 = val_19.y;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, b:  new UnityEngine.Vector3() {x = val_19.x, y = val_31, z = val_19.z})) < 0)
        {
                val_30 = val_11.Item[1];
            UnityEngine.Vector3 val_22 = val_30.position;
            val_35 = val_22.x;
            val_36 = val_22.y;
            val_37 = val_22.z;
        }
        
        val_38 = 2;
        label_24:
        if(val_38 < val_11.Count)
        {
            goto label_33;
        }
        
        return new UnityEngine.Vector3() {x = val_35, y = val_36, z = val_37};
        label_17:
        if(this.turretPlatforms != null)
        {
            goto label_35;
        }
        
        goto label_35;
    }
    internal void 丅丒丘丗上不世丆丐(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        float val_14;
        var val_15;
        var val_16;
        UnityEngine.Vector3 val_2 = this.turretPlatforms.Item[0].position;
        val_14 = val_2.y;
        val_15 = 0;
        val_16 = 1;
        goto label_5;
        label_11:
        UnityEngine.Vector3 val_5 = 0.Item[1].position;
        val_14 = val_5.x;
        float val_6 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, b:  new UnityEngine.Vector3() {x = val_14, y = val_5.y, z = val_5.z});
        var val_8 = (val_6 < 0) ? (val_6) : UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_14, z = val_2.z});
        val_16 = 2;
        label_5:
        if(val_16 < this.turretPlatforms.Count)
        {
            goto label_11;
        }
        
        UnityEngine.Renderer val_11 = this.turretPlatforms.Item[(val_6 < 0) ? (val_16) : (val_15)].GetComponent<UnityEngine.Renderer>();
        UnityEngine.Material[] val_12 = new UnityEngine.Material[1];
        UnityEngine.Material val_14 = val_11.materials[0];
        if(val_12 == null)
        {
            goto label_16;
        }
        
        if(val_14 != null)
        {
            goto label_17;
        }
        
        goto label_20;
        label_16:
        if(val_14 == null)
        {
            goto label_20;
        }
        
        label_17:
        label_20:
        val_12[0] = val_14;
        val_11.materials = val_12;
    }
    internal void 与丛丕丒丛不丆丙与(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, ItemRarity 丈下丑丆上丏丗丈专)
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丘一世七丛丟上丗万(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z}, 丈下丑丆上丏丗丈专:  丈下丑丆上丏丗丈专));
    }
    private System.Collections.IEnumerator 丘一世七丛丟上丗万(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, ItemRarity 丈下丑丆上丏丗丈专)
    {
        FortFieldTurretPlatformController.丛七丑丝一东丗万下 val_1 = new FortFieldTurretPlatformController.丛七丑丝一东丗万下();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .业丒丝丗与丐丛丟丏 = 业丒丝丗与丐丛丟丏;
        mem[1152921536504378252] = 业丒丝丗与丐丛丟丏.y;
        mem[1152921536504378256] = 业丒丝丗与丐丛丟丏.z;
        .丈下丑丆上丏丗丈专 = 丈下丑丆上丏丗丈专;
        return (System.Collections.IEnumerator)val_1;
    }
    internal void 丙且丛丟丟业东上丄(UnityEngine.Vector3 业丒丝丗与丐丛丟丏, ItemRarity 丈下丑丆上丏丗丈专)
    {
        float val_18;
        float val_19;
        float val_20;
        float val_21;
        float val_22;
        var val_23;
        var val_24;
        UnityEngine.Vector3 val_2 = this.turretPlatforms.Item[0].position;
        val_18 = val_2.y;
        val_19 = 业丒丝丗与丐丛丟丏.x;
        val_20 = 业丒丝丗与丐丛丟丏.y;
        val_21 = 业丒丝丗与丐丛丟丏.z;
        val_22 = val_2.x;
        val_23 = 0;
        val_24 = 1;
        goto label_5;
        label_11:
        UnityEngine.Vector3 val_5 = 0.Item[1].position;
        val_18 = val_5.x;
        val_19 = 业丒丝丗与丐丛丟丏.x;
        val_20 = 业丒丝丗与丐丛丟丏.y;
        val_21 = 业丒丝丗与丐丛丟丏.z;
        val_22 = val_18;
        float val_6 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_21}, b:  new UnityEngine.Vector3() {x = val_22, y = val_5.y, z = val_5.z});
        var val_8 = (val_6 < 0) ? (val_6) : UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_19, y = val_20, z = val_21}, b:  new UnityEngine.Vector3() {x = val_22, y = val_18, z = val_2.z});
        val_24 = 2;
        label_5:
        if(val_24 < this.turretPlatforms.Count)
        {
            goto label_11;
        }
        
        UnityEngine.Renderer val_11 = this.turretPlatforms.Item[(val_6 < 0) ? (val_24) : (val_23)].GetComponent<UnityEngine.Renderer>();
        UnityEngine.Color val_12 = 丏丄丑上丛不丈且万.丁丄上丄丟丌与三丛(丈下丑丆上丏丗丈专:  丈下丑丆上丏丗丈专);
        UnityEngine.Material[] val_15 = new UnityEngine.Material[2];
        UnityEngine.Material val_18 = val_11.materials[0];
        if(val_15 == null)
        {
            goto label_18;
        }
        
        if(val_18 != null)
        {
            goto label_19;
        }
        
        goto label_22;
        label_18:
        if(val_18 == null)
        {
            goto label_22;
        }
        
        label_19:
        label_22:
        val_15[0] = val_18;
        val_15[1] = UnityEngine.Resources.Load<UnityEngine.Material>(path:  System.String.Format(format:  "FortField/Materials/{0}", arg0:  this.丝东且丟丂业与丐上));
        if(val_11 != null)
        {
                val_11.materials = val_15;
        }
        else
        {
                val_11.materials = val_15;
        }
        
        val_11.materials[1].SetColor(name:  this.且丆下三七上一上丞, value:  new UnityEngine.Color() {r = val_12.r, g = val_12.g, b = val_12.b, a = val_12.a});
    }
    public FortFieldTurretPlatformController()
    {
        this.丝东且丟丂业与丐上 = "fortfield_outline";
        this.blinkSpeed = 1.25f;
        this.colorAlpha = 5.510186E-41f;
        this.且丆下三七上一上丞 = "_OutlineColor";
        this.blinkData = new System.Collections.Generic.List<BlinkData>();
    }

}
