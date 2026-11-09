using UnityEngine;
public class DeadRagdollController : MonoBehaviour
{
    // Fields
    private float impulseMultiplier;
    private float stoneImpulseMultiplier;
    private float WaitTimeBeforeDissolve;
    private float WaitTimeBeforeStone;
    private float DissolveTime;
    private UnityEngine.SkinnedMeshRenderer SkinnedRenderer;
    private UnityEngine.Rigidbody RootRigidbody;
    private UnityEngine.Rigidbody[] Rigidbodies;
    private UnityEngine.Rigidbody[] RigidbodiesForStone;
    private UnityEngine.Texture ExplosionDeadTexture;
    private UnityEngine.Texture StoneDeadTexture;
    private UnityEngine.Texture BlackGunkDeadTexture;
    private UnityEngine.Texture DissolveTex;
    private UnityEngine.Texture MeltTex;
    private UnityEngine.ParticleSystem Particles;
    private UnityEngine.ParticleSystem meltRedParticles;
    private UnityEngine.ParticleSystem meltSoulsParticles;
    private bool 不丏业丝丁丕下丒丕;
    private System.Collections.Generic.Dictionary<UnityEngine.Rigidbody, UnityEngine.Transform> 丏丆下丆丗万丏上东;
    private UnityEngine.Vector3[] _bonePositions;
    private UnityEngine.Quaternion[] _boneRotation;
    private UnityEngine.Material 丛一丂丞丘丂且丙丞;
    private float 上丛丛丒丂东专专丙;
    private float 七丝丕万丁丂万丝丁;
    private float 丙丙且丕东丈七丄丝;
    private int 丕世不丅东丘丁丝丄;
    private static string 丂业七丅丂丟丝丆丈;
    private static string 专业不丏丝不丏丞世;
    private static string 丞丕丄与丌丘丕不且;
    private static string 丗与上丐万丅丒丝七;
    private bool 丙七丂丈丈一丘上丟;
    private bool 丗丅丝丘丌专丟不业;
    private bool 下上丐万丅丘丏不丂;
    private UnityEngine.Transform 专丙不三丞世业丑丅;
    private float 业一丕丆丒丐专丘业;
    public bool br;
    
    // Properties
    private System.Collections.Generic.Dictionary<UnityEngine.Rigidbody, UnityEngine.Transform> 业丞七丗丆万丏世丛 { get; }
    public UnityEngine.Transform 丅丒世业丑一丘丅丞 { get; }
    
    // Methods
    private System.Collections.Generic.Dictionary<UnityEngine.Rigidbody, UnityEngine.Transform> 丟丅丌三丈丝丌丕世()
    {
        var val_2;
        if(this.不丏业丝丁丕下丒丕 == true)
        {
                return (System.Collections.Generic.Dictionary<UnityEngine.Rigidbody, UnityEngine.Transform>)this.丏丆下丆丗万丏上东;
        }
        
        val_2 = 0;
        goto label_2;
        label_10:
        this.丏丆下丆丗万丏上东.Add(key:  this.Rigidbodies[0], value:  this.Rigidbodies[0].transform);
        val_2 = 1;
        label_2:
        if(val_2 < this.Rigidbodies.Length)
        {
            goto label_10;
        }
        
        this.不丏业丝丁丕下丒丕 = true;
        return (System.Collections.Generic.Dictionary<UnityEngine.Rigidbody, UnityEngine.Transform>)this.丏丆下丆丗万丏上东;
    }
    public UnityEngine.Transform get_RootRigidBodyTransform()
    {
        return (UnityEngine.Transform)this.专丙不三丞世业丑丅;
    }
    private void 丘上丐世丆丑且丞丒()
    {
        var val_3;
        if(this.下上丐万丅丘丏不丂 == true)
        {
                return;
        }
        
        this.下上丐万丅丘丏不丂 = true;
        UnityEngine.Material val_1 = this.SkinnedRenderer.material;
        this.丛一丂丞丘丂且丙丞 = val_1;
        this.SkinnedRenderer.sharedMaterial = val_1;
        val_3 = 0;
        this.专丙不三丞世业丑丅 = this.RootRigidbody.transform;
        goto label_4;
        label_12:
        this.Rigidbodies[0].maxAngularVelocity = 4f;
        this.Rigidbodies[0].maxDepenetrationVelocity = 0.5f;
        val_3 = 1;
        label_4:
        if(val_3 < this.Rigidbodies.Length)
        {
            goto label_12;
        }
    
    }
    private void 丐丈丝丆世东丞丘丑()
    {
        int val_8 = this.Rigidbodies.Length;
        this._bonePositions = new UnityEngine.Vector3[0];
        this._boneRotation = new UnityEngine.Quaternion[0];
        if(val_8 < 1)
        {
                return;
        }
        
        var val_12 = 0;
        var val_10 = 0;
        var val_11 = 32;
        do
        {
            UnityEngine.Vector3 val_5 = this.Rigidbodies[val_10].transform.localPosition;
            this._bonePositions[val_12] = val_5;
            this._bonePositions[val_12] = val_5.y;
            this._bonePositions[val_12] = val_5.z;
            val_8 = this.Rigidbodies[val_10].transform;
            UnityEngine.Quaternion val_7 = val_8.localRotation;
            val_10 = val_10 + 1;
            val_11 = val_11 + 16;
            val_12 = val_12 + 12;
            mem2[0] = val_7.x;
            mem2[0] = val_7.y;
            mem2[0] = val_7.z;
            mem2[0] = val_7.w;
        }
        while((val_8 & 4294967295) != val_10);
    
    }
    public void LoadBoneParams()
    {
        int val_8;
        UnityEngine.Quaternion[] val_9;
        float val_10;
        float val_11;
        val_8 = this.Rigidbodies.Length;
        if(val_8 >= 1)
        {
                var val_14 = 0;
            var val_13 = 0;
            int val_1 = val_8 & 4294967295;
            var val_15 = 32;
            do
        {
            UnityEngine.Vector3 val_10 = this._bonePositions[val_14];
            UnityEngine.Vector3 val_11 = this._bonePositions[val_14];
            this.丟丅丌三丈丝丌丕世().Item[this.Rigidbodies[val_13]].localPosition = new UnityEngine.Vector3() {x = this._bonePositions[val_14], y = val_10, z = val_11};
            val_9 = this._boneRotation;
            this.丟丅丌三丈丝丌丕世().Item[this.Rigidbodies[val_13]].localRotation = new UnityEngine.Quaternion() {x = 1.451982E-37f, y = val_10, z = val_11, w = V11.16B};
            val_13 = val_13 + 1;
            val_14 = val_14 + 12;
            val_15 = val_15 + 16;
        }
        while(val_1 != val_13);
        
            if(val_8 >= 1)
        {
                val_8 = 1152921504838316032;
            do
        {
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
            this.Rigidbodies[0].velocity = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            val_10 = val_7.x;
            val_11 = val_7.z;
            this.Rigidbodies[0].angularVelocity = new UnityEngine.Vector3() {x = val_10, y = val_7.y, z = val_11};
            val_9 = 0 + 1;
        }
        while(val_1 != val_9);
        
        }
        
        }
        
        if(this.br == false)
        {
                return;
        }
        
        UnityEngine.Debug.Break();
    }
    private void 与丁丌七丏丝丞上丆(UnityEngine.Color 万丁世丁东七一丙丅, UnityEngine.Texture 业丈丛丒上上丆丕东)
    {
        null = null;
        this.丛一丂丞丘丂且丙丞.SetColor(name:  DeadRagdollController.丞丕丄与丌丘丕不且, value:  new UnityEngine.Color() {r = 万丁世丁东七一丙丅.r, g = 万丁世丁东七一丙丅.g, b = 万丁世丁东七一丙丅.b, a = 万丁世丁东七一丙丅.a});
        this.丛一丂丞丘丂且丙丞.mainTexture = 业丈丛丒上上丆丕东;
    }
    private void 丙丅丛丝世丘丙丂且(UnityEngine.Color 万丁世丁东七一丙丅)
    {
        MainModule val_1 = this.Particles.main;
        MinMaxGradient val_2 = ParticleSystem.MinMaxGradient.op_Implicit(color:  new UnityEngine.Color() {r = 万丁世丁东七一丙丅.r, g = 万丁世丁东七一丙丅.g, b = 万丁世丁东七一丙丅.b, a = 万丁世丁东七一丙丅.a});
        if(this.meltSoulsParticles == 0)
        {
                return;
        }
        
        this = this.meltSoulsParticles;
        MainModule val_8 = this.main;
        MinMaxGradient val_9 = ParticleSystem.MinMaxGradient.op_Implicit(color:  new UnityEngine.Color() {r = 万丁世丁东七一丙丅.r, g = 万丁世丁东七一丙丅.g, b = 万丁世丁东七一丙丅.b, a = 万丁世丁东七一丙丅.a});
    }
    private void 丘专且丙与三与丙专(float 专不丌不丁丛丞上与 = 1)
    {
        this.丕世不丅东丘丁丝丄 = 0;
        专不丌不丁丛丞上与 = this.DissolveTime * 专不丌不丁丛丞上与;
        this.七丝丕万丁丂万丝丁 = this.WaitTimeBeforeDissolve;
        this.丙丙且丕东丈七丄丝 = this.WaitTimeBeforeStone;
        this.上丛丛丒丂东专专丙 = 专不丌不丁丛丞上与;
    }
    private void 不下丆丐且七专专不(bool 丌丐丒丟三丗丛丁丒)
    {
        goto label_0;
        label_5:
        this.Rigidbodies[0].isKinematic = 丌丐丒丟三丗丛丁丒;
        0 = 1;
        label_0:
        if(0 < this.Rigidbodies.Length)
        {
            goto label_5;
        }
    
    }
    private void 丑业丗丞丘丙丅丄万(bool 丌丐丒丟三丗丛丁丒)
    {
        goto label_0;
        label_5:
        this.Rigidbodies[0].useGravity = 丌丐丒丟三丗丛丁丒;
        0 = 1;
        label_0:
        if(0 < this.Rigidbodies.Length)
        {
            goto label_5;
        }
    
    }
    public void StartAnim(UnityEngine.Color 万丁世丁东七一丙丅, UnityEngine.Texture 丕且下丟丙丌丅丏专, RoyaleAvatar 丘一丙丁丌丆万丂东, DeadRagdollController.丁丆一丂上东丁丝且 丙与一丂丕与丏东上, UnityEngine.Vector3 丝业丒东不一丅丐一, float 三一七丞东丛下一丂 = 400)
    {
        bool val_71;
        UnityEngine.Rigidbody[] val_72;
        UnityEngine.Texture val_73;
        float val_74;
        float val_75;
        float val_76;
        float val_77;
        float val_78;
        var val_79;
        string val_80;
        val_71 = static_value_082C63E3;
        val_72 = 丙与一丂丕与丏东上;
        val_73 = 丕且下丟丙丌丅丏专;
        val_74 = 万丁世丁东七一丙丅.a;
        val_75 = 万丁世丁东七一丙丅.b;
        val_76 = 万丁世丁东七一丙丅.g;
        val_77 = 万丁世丁东七一丙丅.r;
        val_71 = true;
        this.丘上丐世丆丑且丞丒();
        this.丙丙且丕东丈七丄丝 = this.WaitTimeBeforeStone;
        this.丕世不丅东丘丁丝丄 = 0;
        this.上丛丛丒丂东专专丙 = this.DissolveTime;
        this.七丝丕万丁丂万丝丁 = this.WaitTimeBeforeDissolve;
        if(丘一丙丁丌丆万丂东 != 0)
        {
                val_73 = 丘一丙丁丌丆万丂东.skinTexture;
        }
        
        this.业一丕丆丒丐专丘业 = 1.25f;
        val_78 = 1.25f;
        val_79 = null;
        val_79 = null;
        val_78 = this.业一丕丆丒丐专丘业;
        val_80 = DeadRagdollController.丂业七丅丂丟丝丆丈;
        this.丛一丂丞丘丂且丙丞.SetFloat(name:  val_80, value:  val_78);
        this.丗丅丝丘丌专丟不业 = false;
        if(this.meltRedParticles != 0)
        {
                this.meltRedParticles.gameObject.SetActive(value:  false);
        }
        
        if(this.meltSoulsParticles != 0)
        {
                this.meltSoulsParticles.gameObject.SetActive(value:  false);
        }
        
        if((val_72 - 1) <= 7)
        {
                var val_71 = 106031540 + ((丙与一丂丕与丏东上 - 1)) << 2;
            val_71 = val_71 + 106031540;
        }
        else
        {
                this.与丁丌七丏丝丞上丆(万丁世丁东七一丙丅:  new UnityEngine.Color() {}, 业丈丛丒上上丆丕东:  null);
        }
    
    }
    public void UpdateRagdoll()
    {
        float val_18;
        var val_20;
        if(this.丙七丂丈丈一丘上丟 != false)
        {
                if(this.七丝丕万丁丂万丝丁 > 0f)
        {
                val_18 = this.业一丕丆丒丐专丘业;
            float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.七丝丕万丁丂万丝丁 - val_1;
            this.七丝丕万丁丂万丝丁 = val_1;
        }
        else
        {
                float val_18 = this.上丛丛丒丂东专专丙;
            if(val_18 > 0f)
        {
                float val_2 = UnityEngine.Time.deltaTime;
            val_2 = val_18 - val_2;
            this.上丛丛丒丂东专专丙 = val_2;
            val_18 = val_2 / this.DissolveTime;
            val_18 = UnityEngine.Mathf.Lerp(a:  -0.25f, b:  this.业一丕丆丒丐专丘业, t:  val_18);
        }
        else
        {
                val_18 = -0.25f;
            this.丙七丂丈丈一丘上丟 = false;
        }
        
        }
        
            val_20 = null;
            val_20 = null;
            this.丛一丂丞丘丂且丙丞.SetFloat(name:  DeadRagdollController.丂业七丅丂丟丝丆丈, value:  val_18);
        }
        
        if(this.丗丅丝丘丌专丟不业 == false)
        {
                return;
        }
        
        val_18 = this.丙丙且丕东丈七丄丝;
        if(val_18 > 0f)
        {
                float val_4 = UnityEngine.Time.deltaTime;
            val_4 = val_18 - val_4;
            this.丙丙且丕东丈七丄丝 = val_4;
            return;
        }
        
        if(this.丕世不丅东丘丁丝丄 < this.RigidbodiesForStone.Length)
        {
                this.RigidbodiesForStone[this.丕世不丅东丘丁丝丄].isKinematic = false;
            UnityEngine.Vector3 val_5 = this.专丙不三丞世业丑丅.up;
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.2f);
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  this.stoneImpulseMultiplier);
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  UnityEngine.Random.Range(min:  0.03f, max:  0.05f));
            this.RigidbodiesForStone[this.丕世不丅东丘丁丝丄].AddForce(force:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, mode:  1);
            UnityEngine.Vector3 val_10 = this.专丙不三丞世业丑丅.forward;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  this.stoneImpulseMultiplier);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  (float)UnityEngine.Random.Range(min:  5, max:  -5));
            this.RigidbodiesForStone[this.丕世不丅东丘丁丝丄].AddTorque(torque:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, mode:  1);
            UnityEngine.Vector3 val_14 = this.专丙不三丞世业丑丅.right;
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z}, d:  this.stoneImpulseMultiplier);
            UnityEngine.Vector3 val_17 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, d:  (float)UnityEngine.Random.Range(min:  5, max:  -5));
            val_18 = val_17.x;
            this.RigidbodiesForStone[this.丕世不丅东丘丁丝丄].AddTorque(torque:  new UnityEngine.Vector3() {x = val_18, y = val_17.y, z = val_17.z}, mode:  1);
            int val_23 = this.丕世不丅东丘丁丝丄;
            val_23 = val_23 + 1;
            this.丙丙且丕东丈七丄丝 = this.WaitTimeBeforeStone;
            this.丕世不丅东丘丁丝丄 = val_23;
            return;
        }
        
        this.丗丅丝丘丌专丟不业 = false;
    }
    private void 丕三丆丗与专一丅专()
    {
        this.丛一丂丞丘丂且丙丞.mainTexture = this.ExplosionDeadTexture;
    }
    public DeadRagdollController()
    {
        this.DissolveTime = 1f;
        this.impulseMultiplier = ;
        this.stoneImpulseMultiplier = ;
        this.WaitTimeBeforeDissolve = 2f;
        this.WaitTimeBeforeStone = 0.2f;
        this.丏丆下丆丗万丏上东 = new System.Collections.Generic.Dictionary<UnityEngine.Rigidbody, UnityEngine.Transform>();
    }
    private static DeadRagdollController()
    {
        DeadRagdollController.丂业七丅丂丟丝丆丈 = "_Burn";
        DeadRagdollController.专业不丏丝不丏丞世 = "_BurnMap";
        DeadRagdollController.丞丕丄与丌丘丕不且 = "_BurnColor";
        DeadRagdollController.丗与上丐万丅丒丝七 = "_LineWidth";
    }

}
