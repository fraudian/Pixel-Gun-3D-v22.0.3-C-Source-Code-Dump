using UnityEngine;
public class ImpactReceiver : MonoBehaviour
{
    // Fields
    private bool useNewSchemeConsole;
    private bool useNewSchemePrefab;
    internal float maxImpactMagnitude;
    private bool 且三丆丒丐不丙丒丕;
    internal float impulsePerFrameMultiplier;
    private UnityEngine.CharacterController 世丟丈丏丕万丝丆万;
    private UnityEngine.Vector3 万丄上且东丟丏丒且;
    private float 东丅丁丕东丐丂与万;
    private float 一下一丙丞专七丗丂;
    private float 丙下不与丅专七丕万;
    private UnityEngine.Vector3 三丌上七丙丌丅一丘;
    private 丑丝丛丞与丗三且万 <上与业丐丄上万上丝>k__BackingField;
    private UnityEngine.Transform 丛丄与丌丛万业丝丞;
    private FirstPersonControlSharp 丞丄与业丙丄丏七丘;
    private UnityEngine.Vector3 专与不丑丟丈与丌丝;
    private System.Func<WeaponSounds, UnityEngine.Collider, UnityEngine.Vector3, bool> 丈七丟丒丞业世丐丑;
    private WeaponSounds 丅丄丏丐一七业三万;
    private UnityEngine.Vector3 丒丈丘业丛丁丏丙丘;
    private System.Collections.Generic.HashSet<UnityEngine.Collider> 一丐丘丞丄七丙一丙;
    
    // Properties
    internal bool 业下七丌丁东丟丟丛 { get; }
    private bool 与丌三丑丈且丛七丛 { get; }
    internal 丑丝丛丞与丗三且万 上丟丛丈丞丙丂丈与 { get; set; }
    
    // Methods
    internal bool 丈业丆丌万丛丌丌丄()
    {
        bool val_9;
        if(this.useNewSchemeConsole == true)
        {
            goto label_1;
        }
        
        val_9 = this.useNewSchemePrefab;
        if(val_9 == false)
        {
            goto label_6;
        }
        
        label_1:
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                label_18:
            val_9 = 0;
        }
        else
        {
                if(((GameConnect.丞丗东丆下丈丒东业(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) != false) && (GameConnect.东丒七专丂世丝丏丗() != true))
        {
                if(GameConnect.丙丌丒丈东七丒上丌() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_18;
        }
        
        }
        
        }
        
            bool val_7 = this.丝世丙丄丄丏丒丕丞();
            val_9 = val_7 ^ 1;
        }
        
        label_6:
        val_7 = val_9;
        return (bool)val_7;
    }
    private bool 丝世丙丄丄丏丒丕丞()
    {
        if(this.丞丄与业丙丄丏七丘 == 0)
        {
                return false;
        }
        
        if(this.丞丄与业丙丄丏七丘 != null)
        {
                return this.丞丄与业丙丄丏七丘.丛业七丆万丕一丟丏();
        }
        
        return this.丞丄与业丙丄丏七丘.丛业七丆万丕一丟丏();
    }
    internal 丑丝丛丞与丗三且万 世丘丝丕丌与丟丟业()
    {
        return (丑丝丛丞与丗三且万)this.<上与业丐丄上万上丝>k__BackingField;
    }
    private void 丆下丅业丗三世丆丁(丑丝丛丞与丗三且万 丙业与丙丗丝不丈东)
    {
        this.<上与业丐丄上万上丝>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        this.世丟丈丏丕万丝丆万 = this.GetComponent<UnityEngine.CharacterController>();
        this.丞丄与业丙丄丏七丘 = this.GetComponent<FirstPersonControlSharp>();
        this.丛丄与丌丛万业丝丞 = this.transform;
    }
    private void Update()
    {
        if(GameConnect.丟丆丏上丌一丝丟业() != false)
        {
                return;
        }
        
        if(this.丈业丆丌万丛丌丌丄() != false)
        {
                this.七世丙丌丛丝丒丙丘();
            return;
        }
        
        this.丄丞丟丄丛东七丘不();
    }
    private void 丄丞丟丄丛东七丘不()
    {
        UnityEngine.Vector3 val_8;
        float val_9;
        var val_10;
        var val_11;
        val_8 = this.万丄上且东丟丏丒且;
        val_9 = this.丙下不与丅专七丕万;
        if(S0 > val_9)
        {
                if((this.<上与业丐丄上万上丝>k__BackingField) == 3)
        {
                this.丙世丕世且上与丘上();
        }
        
            val_8 = this;
            val_10 = 1152921537910538320;
            val_11 = 1152921537910538320;
            UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = this.万丄上且东丟丏丒且, y = V10.16B, z = V9.16B}, d:  UnityEngine.Time.deltaTime);
            val_9 = val_2.y;
            UnityEngine.CollisionFlags val_3 = this.世丟丈丏丕万丝丆万.Move(motion:  new UnityEngine.Vector3() {x = val_2.x, y = val_9, z = val_2.z});
        }
        else
        {
                val_10 = 1152921537910538324;
            val_11 = 1152921537910538328;
            this.<上与业丐丄上万上丝>k__BackingField = 0;
        }
        
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.万丄上且东丟丏丒且.x, y = 2.57498E-17f, z = 2.57498E-17f}, b:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, t:  this.一下一丙丞专七丗丂 * UnityEngine.Time.deltaTime);
        this.万丄上且东丟丏丒且 = val_7;
        mem[1152921537910538324] = val_7.y;
        mem[1152921537910538328] = val_7.z;
    }
    private void 七世丙丌丛丝丒丙丘()
    {
        if(S0 > this.丙下不与丅专七丕万)
        {
                if((this.<上与业丐丄上万上丝>k__BackingField) == 3)
        {
                this.丙世丕世且上与丘上();
        }
        
            UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            UnityEngine.Vector3 val_5 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.万丄上且东丟丏丒且, y = V8.16B, z = V9.16B}, b:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, t:  (this.impulsePerFrameMultiplier * this.一下一丙丞专七丗丂) * UnityEngine.Time.deltaTime);
            this.万丄上且东丟丏丒且 = val_5;
            mem[1152921537910670804] = val_5.y;
            mem[1152921537910670808] = val_5.z;
            float val_6 = UnityEngine.Time.deltaTime;
            val_6 = this.impulsePerFrameMultiplier * val_6;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(d:  val_6, a:  new UnityEngine.Vector3() {x = this.万丄上且东丟丏丒且, y = val_5.z, z = val_1.x});
            this.丞丄与业丙丄丏七丘.且丏丄丄上万与丑与(下丒万丌丆丞一丄丅:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
            return;
        }
        
        if(this.且三丆丒丐不丙丒丕 == false)
        {
                return;
        }
        
        this.<上与业丐丄上万上丝>k__BackingField = 0;
        this.丈丗丈丕与丒一丅三();
    }
    public void AddImpact(丑丝丛丞与丗三且万 且丒丗万七丑丁丏丏, UnityEngine.Vector3 丅与丐与丝丆专一专, float 七丆丟丗世丟且丒丆, float 专世万丙丐丐七丐丁 = 5, float 三丏下七丄东丆丂丗 = 0.2, WeaponSounds 丌丝下丄业一丄不三, System.Func<WeaponSounds, UnityEngine.Collider, UnityEngine.Vector3, bool> 业七与丙丄丘与丒且)
    {
        WeaponSounds val_11;
        float val_12;
        float val_13;
        float val_14;
        float val_15;
        float val_16;
        float val_17;
        val_11 = 丌丝下丄业一丄不三;
        val_12 = 七丆丟丗世丟且丒丆;
        this.<上与业丐丄上万上丝>k__BackingField = 且丒丗万七丑丁丏丏;
        val_13 = 丅与丐与丝丆专一专.y;
        if(val_13 < 0)
        {
                val_13 = -val_13;
        }
        
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_13, y = 丅与丐与丝丆专一专.y, z = 丅与丐与丝丆专一专.z}, d:  val_12);
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Division(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  this.东丅丁丕东丐丂与万);
        val_15 = this.万丄上且东丟丏丒且;
        val_16 = V13.16B;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_15, y = V12.16B, z = val_16}, b:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z});
        this.万丄上且东丟丏丒且 = val_3;
        mem[1152921537910820692] = val_3.y;
        mem[1152921537910820696] = val_3.z;
        if(this.丈业丆丌万丛丌丌丄() == false)
        {
            goto label_4;
        }
        
        float val_11 = this.maxImpactMagnitude;
        val_11 = val_11 * val_11;
        if(val_3.x <= val_11)
        {
            goto label_8;
        }
        
        val_14 = this.maxImpactMagnitude;
        val_12 = val_3.x;
        val_15 = val_12;
        val_16 = val_3.z;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_15, y = val_11, z = val_16}, d:  val_14);
        this.万丄上且东丟丏丒且 = val_5;
        mem[1152921537910820692] = val_5.y;
        mem[1152921537910820696] = val_5.z;
        goto label_8;
        label_4:
        this.丞丄与业丙丄丏七丘.丐世丙丁下上上丆丙(丙业与丙丗丝不丈东:  true);
        label_8:
        this.一下一丙丞专七丗丂 = 专世万丙丐丐七丐丁;
        if(this.丈业丆丌万丛丌丌丄() != false)
        {
                label_17:
            val_17 = 三丏下七丄东丆丂丗;
        }
        else
        {
                if(GameConnect.上丏丈七丘丁与丅丏() != true)
        {
                if(GameConnect.不专专丂万丝上东丐() == false)
        {
            goto label_17;
        }
        
        }
        
            val_15 = 11f;
        }
        
        this.丙下不与丅专七丕万 = (专世万丙丐丐七丐丁 < 0) ? (val_15) : 三丏下七丄东丆丂丗;
        this.且三丆丒丐不丙丒丕 = true;
        if((this.<上与业丐丄上万上丝>k__BackingField) != 3)
        {
                return;
        }
        
        this.丅丄丏丐一七业三万 = val_11;
        this.丒丈丘业丛丁丏丙丘 = 丅与丐与丝丆专一专;
        mem[1152921537910820784] = 丅与丐与丝丆专一专.z;
        UnityEngine.Vector3 val_10 = this.丛丄与丌丛万业丝丞.position;
        val_11 = this.一丐丘丞丄七丙一丙;
        this.专与不丑丟丈与丌丝 = val_10;
        mem[1152921537910820748] = val_10.y;
        mem[1152921537910820752] = val_10.z;
        val_11.Clear();
        this.丈七丟丒丞业世丐丑 = 业七与丙丄丘与丒且;
    }
    private void 丙世丕世且上与丘上()
    {
        float val_14;
        UnityEngine.Vector3 val_15;
        float val_16;
        float val_17;
        float val_18;
        var val_19;
        UnityEngine.Collider val_20;
        UnityEngine.Collider val_21;
        UnityEngine.Vector3 val_1 = this.丛丄与丌丛万业丝丞.position;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, b:  new UnityEngine.Vector3() {x = this.专与不丑丟丈与丌丝, y = V11.16B, z = V10.16B});
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z}, d:  0.5f);
        UnityEngine.Vector3 val_4 = this.丛丄与丌丛万业丝丞.position;
        val_14 = val_4.z;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, d:  0.5f);
        val_17 = val_4.y;
        val_16 = val_4.x;
        val_18 = val_14;
        UnityEngine.RaycastHit[] val_8 = UnityEngine.Physics.BoxCastAll(center:  new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18}, halfExtents:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, direction:  new UnityEngine.Vector3() {x = this.丒丈丘业丛丁丏丙丘, y = val_1.y, z = 0f}, orientation:  new UnityEngine.Quaternion() {x = 0f, y = val_6.x, z = val_4.y, w = val_3.x}, maxDistance:  val_3.z, layerMask:  Player_move_c.丗丒丒丑万一丗丂丗());
        val_19 = 0;
        goto label_7;
        label_19:
        val_20 = 0 + 32;
        val_21 = val_20;
        if((this.一丐丘丞丄七丙一丙.Contains(item:  val_21)) != true)
        {
                bool val_10 = this.一丐丘丞丄七丙一丙.Add(item:  val_20);
            val_21 = this.丈七丟丒丞业世丐丑;
            val_15 = this.专与不丑丟丈与丌丝;
            val_20 = val_20;
            val_16 = val_15;
            val_17 = val_1.y;
            val_18 = val_14;
            if((val_21.Invoke(arg1:  this.丅丄丏丐一七业三万, arg2:  val_20, arg3:  new UnityEngine.Vector3() {x = val_16, y = val_17, z = val_18})) != false)
        {
                UnityEngine.Vector3 val_12 = UnityEngine.Vector3.zero;
            this.万丄上且东丟丏丒且 = val_12;
            mem[1152921537911029972] = val_12.y;
            mem[1152921537911029976] = val_12.z;
        }
        
        }
        
        val_19 = 1;
        label_7:
        if(val_19 < val_8.Length)
        {
            goto label_19;
        }
        
        UnityEngine.Vector3 val_13 = this.丛丄与丌丛万业丝丞.position;
        this.专与不丑丟丈与丌丝 = val_13;
        mem[1152921537911030028] = val_13.y;
        mem[1152921537911030032] = val_13.z;
    }
    internal void 丈丗丈丕与丒一丅三()
    {
        this.且三丆丒丐不丙丒丕 = false;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.万丄上且东丟丏丒且 = val_1;
        mem[1152921537911207508] = val_1.y;
        mem[1152921537911207512] = val_1.z;
    }
    internal void 丛与丏与专东一丂不(UnityEngine.Vector3 丌丆丈丅丑世丗丞与)
    {
        this.丒丈丘业丛丁丏丙丘 = 丌丆丈丅丑世丗丞与;
        mem[1152921537911319596] = 丌丆丈丅丑世丗丞与.y;
        mem[1152921537911319600] = 丌丆丈丅丑世丗丞与.z;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Multiply(d:  丌丆丈丅丑世丗丞与.x, a:  new UnityEngine.Vector3() {x = this.丒丈丘业丛丁丏丙丘, y = V9.16B, z = V8.16B});
        this.万丄上且东丟丏丒且 = val_1;
        mem[1152921537911319508] = val_1.y;
        mem[1152921537911319512] = val_1.z;
    }
    internal void 丆丆丝世三丁三东业()
    {
        this.万丄上且东丟丏丒且 = 0;
        mem[1152921537911431512] = 0;
    }
    internal void 丙业丁三丈与丈丅丛()
    {
        mem[1152921537911543508] = 0;
    }
    public ImpactReceiver()
    {
        this.maxImpactMagnitude = 50f;
        this.impulsePerFrameMultiplier = 1f;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.万丄上且东丟丏丒且 = val_1;
        mem[1152921537911660628] = val_1.y;
        mem[1152921537911660632] = val_1.z;
        this.东丅丁丕东丐丂与万 = 1f;
        this.一下一丙丞专七丗丂 = 0f;
        this.丙下不与丅专七丕万 = 0.2f;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        this.三丌上七丙丌丅一丘 = val_2;
        mem[1152921537911660652] = val_2.y;
        mem[1152921537911660656] = val_2.z;
        this.一丐丘丞丄七丙一丙 = new System.Collections.Generic.HashSet<UnityEngine.Collider>();
    }

}
