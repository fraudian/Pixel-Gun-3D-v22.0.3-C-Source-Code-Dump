using UnityEngine;
public class VehicleView : TransportViewBase
{
    // Fields
    private UnityEngine.Material 丁丐丗丗丝丞丁三上;
    public UnityEngine.GameObject[] brakeHalo;
    private bool 且丌丈与丂丅丛丂丌;
    public UnityEngine.Material carMat;
    public UnityEngine.Renderer[] carRenderers;
    public UnityEngine.LayerMask ground;
    private UnityEngine.RaycastHit 丁丂丝不丟丛丟一丂;
    private bool 下上丐万丅丘丏不丂;
    private UnityEngine.Vector3[] 丌世一下丟丗丝下丛;
    private bool 丁丛东丄世丂世丑三;
    private float 丗丂丘丁七丆一万上;
    public UnityEngine.ParticleSystem[] particles;
    public UnityEngine.Color[] randomColors;
    public float ressoreLength;
    public UnityEngine.Transform[] steerWheelsVisuals;
    public UnityEngine.GameObject[] trailParticles;
    public float wheelRadius;
    public UnityEngine.Renderer[] wheelRenderers;
    public UnityEngine.Transform[] wheelVisuals;
    public bool IsAnimatedWheels;
    private System.Collections.Generic.List<UnityEngine.Animation> 七丆上东丞三丛丏丅;
    public float AnimationSpeedMultipler;
    private float[] 一丈下业丅丈上世七;
    private System.Collections.Generic.List<UnityEngine.Animation> otherAnimationToStopWhenKilled;
    private UnityEngine.GameObject[] disableForRacingObjects;
    private System.Collections.Generic.Dictionary<UnityEngine.Transform, VehicleWheelVisualParameters> 且下下丘丐丕一一七;
    internal int 不丗丘丘一丕丑专一;
    private bool 世丅且丝专东丁业七;
    private float 丐丅丘丏不东丙丄万;
    
    // Properties
    internal override UnityEngine.Material 丘丐丞专业世丝丞丆 { get; }
    public float 不与丂东世丈专丗下 { get; set; }
    
    // Methods
    internal override UnityEngine.Material 上丒专丝丌万丂上丌()
    {
        if(this.丁丛东丄世丂世丑三 == true)
        {
                return (UnityEngine.Material)this.丁丐丗丗丝丞丁三上;
        }
        
        this.丝丑丑业不丝丗丕丄();
        return (UnityEngine.Material)this.丁丐丗丗丝丞丁三上;
    }
    private void 丘上丐世丆丑且丞丒()
    {
        this.下上丐万丅丘丏不丂 = true;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.下一丙万丌丅丞丞世());
    }
    private System.Collections.IEnumerator 下一丙万丌丅丞丞世()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new VehicleView.一业世世丒丘丈丅丝(丗丏丅丕丆世丁专丟:  0);
    }
    private void Awake()
    {
        UnityEngine.GameObject[] val_18;
        System.Single[] val_19;
        var val_20;
        var val_21;
        var val_22;
        float val_23;
        UnityEngine.Vector3[] val_24;
        if(GameConnect.且丘丄丛下丆丟万丕() != false)
        {
                val_18 = this.disableForRacingObjects;
            if((val_18 != null) && (this.disableForRacingObjects.Length >= 1))
        {
                do
        {
            UnityEngine.GameObject val_20 = val_18[0];
            if(val_20 != 0)
        {
                val_20.SetActive(value:  false);
        }
        
        }
        while((0 + 1) < this.disableForRacingObjects.Length);
        
        }
        
        }
        
        if(this.IsAnimatedWheels == false)
        {
            goto label_12;
        }
        
        this.七丆上东丞三丛丏丅 = new System.Collections.Generic.List<UnityEngine.Animation>(capacity:  10);
        val_19 = 1152921536152425856;
        val_20 = 0;
        goto label_13;
        label_22:
        UnityEngine.Animation val_5 = this.wheelVisuals[0].GetComponentInChildren<UnityEngine.Animation>();
        if(val_5 != 0)
        {
                this.七丆上东丞三丛丏丅.Add(item:  val_5);
        }
        
        val_20 = 1;
        label_13:
        if(val_20 < this.wheelVisuals.Length)
        {
            goto label_22;
        }
        
        int val_7 = this.七丆上东丞三丛丏丅.Count;
        this.丌世一下丟丗丝下丛 = new UnityEngine.Vector3[0];
        int val_9 = this.七丆上东丞三丛丏丅.Count;
        this.一丈下业丅丈上世七 = new float[0];
        val_21 = 1152921536152530304;
        val_22 = 0;
        goto label_25;
        label_34:
        UnityEngine.Vector3 val_13 = this.七丆上东丞三丛丏丅.Item[0].transform.position;
        val_23 = val_13.x;
        mem[32] = val_23;
        mem[36] = val_13.y;
        mem[40] = val_13.z;
        val_19 = this.一丈下业丅丈上世七;
        val_22 = 1;
        val_19[0] = 0f;
        label_25:
        val_18 = this.七丆上东丞三丛丏丅;
        if(val_22 < val_18.Count)
        {
            goto label_34;
        }
        
        return;
        label_12:
        val_24 = new UnityEngine.Vector3[0];
        this.丌世一下丟丗丝下丛 = val_24;
        val_19 = 1152921536152662400;
        val_21 = 0;
        goto label_37;
        label_49:
        UnityEngine.Transform val_22 = this.wheelVisuals[0];
        UnityEngine.Vector3 val_16 = val_22.position;
        val_23 = val_16.x;
        var val_17 = this.丌世一下丟丗丝下丛 + (0 * 12);
        mem2[0] = val_23;
        mem2[0] = val_16.y;
        mem2[0] = val_16.z;
        val_18 = val_22.GetComponent<VehicleWheelVisualParameters>();
        if((UnityEngine.Object.op_Implicit(exists:  val_18)) != false)
        {
                this.且下下丘丐丕一一七.set_Item(key:  val_22, value:  val_18);
        }
        
        val_24 = this.丌世一下丟丗丝下丛;
        val_21 = 1;
        label_37:
        if(val_21 < this.丌世一下丟丗丝下丛.Length)
        {
            goto label_49;
        }
    
    }
    private void 丝丑丑业不丝丗丕丄()
    {
        UnityEngine.Material val_4;
        var val_5;
        this.丁丛东丄世丂世丑三 = true;
        val_4 = 1152921504848912384;
        if(this.carMat == 0)
        {
            goto label_3;
        }
        
        this.丁丐丗丗丝丞丁三上 = UnityEngine.Object.Instantiate<UnityEngine.Material>(original:  this.carMat);
        if(GameConnect.且丘丄丛下丆丟万丕() == true)
        {
            goto label_9;
        }
        
        this.丗丕万丅三丕丌丞丒();
        goto label_9;
        label_3:
        label_9:
        val_5 = 0;
        goto label_10;
        label_15:
        val_4 = mem[this.丁丐丗丗丝丞丁三上];
        this.carRenderers[0].sharedMaterial = val_4;
        val_5 = 1;
        label_10:
        if(val_5 < this.carRenderers.Length)
        {
            goto label_15;
        }
    
    }
    internal void 东丏三丆丅三且丛丁(int 丗丂丛丝丝丌且丐丅)
    {
        if((丗丂丛丝丝丌且丐丅 & 2147483648) != 0)
        {
                return;
        }
        
        if(this.randomColors == null)
        {
                return;
        }
        
        if(this.randomColors.Length <= 丗丂丛丝丝丌且丐丅)
        {
                return;
        }
        
        this.丁丐丗丗丝丞丁三上.SetColor(name:  "_CarColor", value:  new UnityEngine.Color() {r = this.randomColors[(long)丗丂丛丝丝丌且丐丅], g = this.randomColors[(long)丗丂丛丝丝丌且丐丅], b = this.randomColors[(long)丗丂丛丝丝丌且丐丅], a = this.randomColors[(long)丗丂丛丝丝丌且丐丅]});
    }
    internal void 丗丕万丅三丕丌丞丒()
    {
        if(this.randomColors == null)
        {
                return;
        }
        
        if(this.randomColors.Length == 0)
        {
                return;
        }
        
        int val_1 = UnityEngine.Random.Range(min:  0, max:  this.randomColors.Length);
        this.不丗丘丘一丕丑专一 = val_1;
        this.东丏三丆丅三且丛丁(丗丂丛丝丝丌且丐丅:  val_1);
    }
    public void Stop()
    {
        var val_3;
        this.丐丅丘丏不东丙丄万 = 0f;
        if(this.IsAnimatedWheels == false)
        {
                return;
        }
        
        if(this.世丅且丝专东丁业七 == true)
        {
                return;
        }
        
        this.世丅且丝专东丁业七 = true;
        val_3 = 0;
        goto label_3;
        label_7:
        this.七丆上东丞三丛丏丅.Item[0].Stop();
        val_3 = 1;
        label_3:
        if(val_3 < this.七丆上东丞三丛丏丅.Count)
        {
            goto label_7;
        }
    
    }
    public void UpdateVisuals(bool 丝东七一丛丅丏且三, float 与丐丌万丁丒不业丕, float 丛丄三丞世丝三丘丂, float 丕丟一东三丏丝丞丞, bool 业丂万丏丒丛丒万且, bool 丑丝七丆丙丅业丌丅 = False)
    {
        if(W8 == 0)
        {
                return;
        }
        
        if(this.下上丐万丅丘丏不丂 != true)
        {
                this.下上丐万丅丘丏不丂 = true;
            UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.下一丙万丌丅丞丞世());
        }
        
        this.世丅且丝专东丁业七 = false;
        if(this.steerWheelsVisuals != null)
        {
                if(this.IsAnimatedWheels != false)
        {
                this.丌丞与世丛不不丈丅(丝东七一丛丅丏且三:  丝东七一丛丅丏且三, 与丐丌万丁丒不业丕:  与丐丌万丁丒不业丕, 丛丄三丞世丝三丘丂:  丛丄三丞世丝三丘丂);
        }
        else
        {
                this.丈丗专不专且丌且业(丝东七一丛丅丏且三:  丝东七一丛丅丏且三, 与丐丌万丁丒不业丕:  与丐丌万丁丒不业丕, 丛丄三丞世丝三丘丂:  丛丄三丞世丝三丘丂);
        }
        
        }
        
        this.丝丙丙东丈下丒与丏();
        丑丝七丆丙丅业丌丅 = 丑丝七丆丙丅业丌丅;
        this.东丂东丈丈且不七丌(丕丟一东三丏丝丞丞:  丕丟一东三丏丝丞丞, 丝东七一丛丅丏且三:  丝东七一丛丅丏且三, 业丂万丏丒丛丒万且:  业丂万丏丒丛丒万且, 丑丝七丆丙丅业丌丅:  丑丝七丆丙丅业丌丅);
    }
    internal override void 七丛丐与丑丈一万丁()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        System.Collections.Generic.List<UnityEngine.Animation> val_13;
        this.七丛丐与丑丈一万丁();
        if(this.IsAnimatedWheels == false)
        {
            goto label_1;
        }
        
        val_8 = 0;
        goto label_2;
        label_6:
        this.七丆上东丞三丛丏丅.Item[0].Stop();
        val_8 = 1;
        label_2:
        if(val_8 < this.七丆上东丞三丛丏丅.Count)
        {
            goto label_6;
        }
        
        label_1:
        val_9 = 0;
        goto label_7;
        label_17:
        val_10 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.wheelRenderers[0])) != false)
        {
                if(val_9 >= this.wheelRenderers.Length)
        {
                val_10 = 0;
        }
        
            this.wheelRenderers[0].sharedMaterial = this;
        }
        
        val_9 = 1;
        label_7:
        if(val_9 < this.wheelRenderers.Length)
        {
            goto label_17;
        }
        
        val_11 = 0;
        goto label_18;
        label_24:
        this.particles[0].gameObject.SetActive(value:  false);
        val_11 = 1;
        label_18:
        if(val_11 < this.particles.Length)
        {
            goto label_24;
        }
        
        val_12 = 0;
        goto label_25;
        label_31:
        this.trailParticles[0].gameObject.SetActive(value:  false);
        val_12 = 1;
        label_25:
        if(val_12 < this.trailParticles.Length)
        {
            goto label_31;
        }
        
        val_13 = this.otherAnimationToStopWhenKilled;
        List.Enumerator<T> val_6 = val_13.GetEnumerator();
        label_35:
        if((1483012456 & 1) == 0)
        {
            goto label_33;
        }
        
        0.丐丏七丌丕丗业且上().Stop();
        goto label_35;
        label_33:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public void ChangeSkin()
    {
        UnityEngine.Shader val_5;
        var val_6;
        var val_7;
        this.且丌丈与丂丅丛丂丌 = true;
        val_5 = UnityEngine.Shader.Find(name:  "Optimized/VehicleShaderChange");
        this.shader = val_5;
        val_6 = 0;
        goto label_2;
        label_12:
        val_5 = 0;
        val_7 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.wheelRenderers[val_5])) != false)
        {
                if(val_6 >= this.wheelRenderers.Length)
        {
                val_7 = 0;
        }
        
            val_5 = this;
            this.wheelRenderers[val_5].sharedMaterial = this;
        }
        
        val_6 = 1;
        label_2:
        if(val_6 < this.wheelRenderers.Length)
        {
            goto label_12;
        }
        
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丌丛丏丅丙丙丅丟丝());
    }
    private System.Collections.IEnumerator 丌丛丏丅丙丙丅丟丝()
    {
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new VehicleView.丌丑丗世丈丌专丗丅(丗丏丅丕丆世丁专丟:  0);
    }
    internal override void 下丟丄丅丅七丐丁丙(float 上丝丄万东丘丕丐丙)
    {
        if(this.且丌丈与丂丅丛丂丌 != false)
        {
                return;
        }
        
        this.下丟丄丅丅七丐丁丙(上丝丄万东丘丕丐丙:  上丝丄万东丘丕丐丙);
    }
    private void 丝丙丙东丈下丒与丏()
    {
        var val_14;
        float val_15;
        float val_16;
        float val_18;
        float val_19;
        val_14 = 0;
        goto label_1;
        label_18:
        val_15 = this.wheelRadius;
        UnityEngine.Transform val_13 = this.wheelVisuals[0];
        if((this.且下下丘丐丕一一七.TryGetValue(key:  val_13, value: out  0)) == false)
        {
            goto label_5;
        }
        
        if(0 != 0)
        {
            goto label_7;
        }
        
        val_16 = 0f;
        label_5:
        UnityEngine.Vector3 val_3 = val_13.localPosition;
        UnityEngine.Vector3 val_4 = val_13.position;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        UnityEngine.Vector3 val_7 = this.transform.up;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_UnaryNegation(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, direction:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = this.丁丂丝不丟丛丟一丂, y = this.丁丂丝不丟丛丟一丂, z = this.丁丂丝不丟丛丟一丂}, m_Normal = new UnityEngine.Vector3() {x = this.丁丂丝不丟丛丟一丂, y = this.丁丂丝不丟丛丟一丂, z = this.丁丂丝不丟丛丟一丂}, m_FaceID = this.丁丂丝不丟丛丟一丂, m_Distance = this.丁丂丝不丟丛丟一丂, m_UV = new UnityEngine.Vector2() {x = this.丁丂丝不丟丛丟一丂, y = this.丁丂丝不丟丛丟一丂}, m_Collider = this.丁丂丝不丟丛丟一丂}, maxDistance:  val_16 + this.ressoreLength, layerMask:  UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = this.ground}), queryTriggerInteraction:  1)) != false)
        {
                val_18 = val_16 - this.丁丂丝不丟丛丟一丂.targetValue;
        }
        else
        {
                val_18 = -this.ressoreLength;
        }
        
        val_19 = val_3.x;
        val_13.localPosition = new UnityEngine.Vector3() {x = val_19, y = val_18, z = val_3.z};
        label_7:
        val_14 = 1;
        label_1:
        if(val_14 < this.wheelVisuals.Length)
        {
            goto label_18;
        }
    
    }
    private void 丌丞与世丛不不丈丅(bool 丝东七一丛丅丏且三, float 与丐丌万丁丒不业丕, float 丛丄三丞世丝三丘丂)
    {
        float val_27;
        float val_28;
        float val_29;
        var val_30;
        float val_31;
        var val_32;
        var val_33;
        System.Collections.Generic.List<UnityEngine.Animation> val_34;
        var val_35;
        var val_36;
        var val_37;
        float val_38;
        if(this.steerWheelsVisuals.Length == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Vector3 val_1 = this.steerWheelsVisuals[0].localEulerAngles;
        UnityEngine.Quaternion val_3 = this.steerWheelsVisuals[0].localRotation;
        val_27 = val_3.w;
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_1.x, y = 与丐丌万丁丒不业丕 * 30f, z = val_1.z});
        float val_5 = UnityEngine.Time.deltaTime;
        val_5 = val_5 * 8f;
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_27}, b:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, t:  val_5);
        val_28 = val_6.y;
        val_29 = val_6.w;
        val_30 = 0;
        goto label_11;
        label_16:
        this.steerWheelsVisuals[0].localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_28, z = val_6.z, w = val_29};
        val_30 = 1;
        label_11:
        if(val_30 < this.steerWheelsVisuals.Length)
        {
            goto label_16;
        }
        
        label_2:
        if(丝东七一丛丅丏且三 == false)
        {
            goto label_17;
        }
        
        val_31 = 0.2f;
        val_32 = 1152921536152530304;
        val_33 = 0;
        goto label_18;
        label_22:
        this.七丆上东丞三丛丏丅.Item[0].CrossFade(animation:  "Idle", fadeLength:  val_31);
        val_33 = 1;
        label_18:
        val_34 = this.七丆上东丞三丛丏丅;
        if(val_33 < val_34.Count)
        {
            goto label_22;
        }
        
        return;
        label_17:
        val_35 = 1152921536152516992;
        val_31 = 0.002f;
        val_32 = 1152921504838422528;
        val_36 = "Move";
        val_37 = 0;
        goto label_24;
        label_64:
        UnityEngine.Vector3 val_11 = this.七丆上东丞三丛丏丅.Item[0].transform.position;
        val_28 = val_11.y;
        var val_12 = this.丌世一下丟丗丝下丛 + (0 * 12);
        val_27 = mem[(0 * 12) + this.丌世一下丟丗丝下丛 + 32];
        val_27 = (0 * 12) + this.丌世一下丟丗丝下丛 + 32;
        UnityEngine.Vector3 val_13 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_27, y = (0 * 12) + this.丌世一下丟丗丝下丛 + 32 + 4, z = (0 * 12) + this.丌世一下丟丗丝下丛 + 40}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_28, z = val_11.z});
        val_29 = val_13.x * 丛丄三丞世丝三丘丂;
        UnityEngine.Animation val_14 = this.七丆上东丞三丛丏丅.Item[0];
        if(System.Math.Abs(val_29) >= 0)
        {
            goto label_35;
        }
        
        val_14.Stop();
        goto label_37;
        label_35:
        val_14.clip = this.七丆上东丞三丛丏丅.Item[0].GetClip(name:  "Move");
        UnityEngine.AnimationState val_18 = this.七丆上东丞三丛丏丅.Item[0].Item["Move"];
        float val_19 = UnityEngine.Time.deltaTime;
        val_19 = val_29 * val_19;
        val_19 = val_19 * this.AnimationSpeedMultipler;
        val_19 = this.一丈下业丅丈上世七[0] + val_19;
        this.一丈下业丅丈上世七[0] = val_19;
        float val_20 = val_18.length;
        val_38 = this.一丈下业丅丈上世七[0];
        mem2[0] = val_38;
        val_36 = val_36;
        goto label_49;
        label_55:
        val_38 = this.一丈下业丅丈上世七[0] + val_18.length;
        mem2[0] = val_38;
        label_49:
        if(this.一丈下业丅丈上世七[0] < 0)
        {
            goto label_55;
        }
        
        if(val_18 != null)
        {
                val_29 = val_18.length;
        }
        else
        {
                float val_23 = 0.length;
            val_29 = val_23;
        }
        
        val_35 = 1152921536152516992;
        val_23 = this.一丈下业丅丈上世七[0] / val_29;
        val_18.normalizedTime = val_23;
        bool val_25 = this.七丆上东丞三丛丏丅.Item[0].Play();
        var val_26 = this.丌世一下丟丗丝下丛 + (0 * 12);
        mem2[0] = val_11.x;
        mem2[0] = val_28;
        mem2[0] = val_11.z;
        label_37:
        val_37 = 1;
        label_24:
        val_34 = this.七丆上东丞三丛丏丅;
        if(val_37 < val_34.Count)
        {
            goto label_64;
        }
    
    }
    public float get_deltaWheelPos()
    {
        return (float)this.丐丅丘丏不东丙丄万;
    }
    private void 上且丝丒专丞丙万丆(float 丙业与丙丗丝不丈东)
    {
        this.丐丅丘丏不东丙丄万 = 丙业与丙丗丝不丈东;
    }
    private void 丈丗专不专且丌且业(bool 丝东七一丛丅丏且三, float 与丐丌万丁丒不业丕, float 丛丄三丞世丝三丘丂)
    {
        UnityEngine.Transform[] val_13;
        float val_14;
        float val_15;
        float val_16;
        var val_17;
        var val_18;
        val_13 = this.steerWheelsVisuals;
        if(this.steerWheelsVisuals.Length == 0)
        {
            goto label_2;
        }
        
        UnityEngine.Vector3 val_1 = this.steerWheelsVisuals[0].localEulerAngles;
        UnityEngine.Quaternion val_3 = this.steerWheelsVisuals[0].localRotation;
        val_14 = val_3.w;
        UnityEngine.Quaternion val_4 = UnityEngine.Quaternion.Euler(euler:  new UnityEngine.Vector3() {x = val_1.x, y = 与丐丌万丁丒不业丕 * 30f, z = val_1.z});
        float val_5 = UnityEngine.Time.deltaTime;
        val_5 = val_5 * 8f;
        UnityEngine.Quaternion val_6 = UnityEngine.Quaternion.Lerp(a:  new UnityEngine.Quaternion() {x = val_3.x, y = val_3.y, z = val_3.z, w = val_14}, b:  new UnityEngine.Quaternion() {x = val_4.x, y = val_4.y, z = val_4.z, w = val_4.w}, t:  val_5);
        val_15 = val_6.y;
        val_16 = val_6.w;
        val_17 = 0;
        goto label_11;
        label_16:
        val_18 = 0;
        this.steerWheelsVisuals[val_18].localRotation = new UnityEngine.Quaternion() {x = val_6.x, y = val_15, z = val_6.z, w = val_16};
        val_17 = 1;
        label_11:
        val_13 = this.steerWheelsVisuals;
        if(val_17 < this.steerWheelsVisuals.Length)
        {
            goto label_16;
        }
        
        label_2:
        if(丝东七一丛丅丏且三 != false)
        {
                this.丐丅丘丏不东丙丄万 = 0f;
            return;
        }
        
        val_18 = 1152921504838316032;
        val_13 = 0;
        goto label_19;
        label_32:
        UnityEngine.Transform val_18 = this.wheelVisuals[0];
        UnityEngine.Vector3 val_7 = val_18.position;
        var val_8 = this.丌世一下丟丗丝下丛 + (0 * 12);
        val_14 = mem[(0 * 12) + this.丌世一下丟丗丝下丛 + 40];
        val_14 = (0 * 12) + this.丌世一下丟丗丝下丛 + 40;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = (0 * 12) + this.丌世一下丟丗丝下丛 + 32, y = (0 * 12) + this.丌世一下丟丗丝下丛 + 32 + 4, z = val_14}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z});
        val_9.x = val_9.x * 丛丄三丞世丝三丘丂;
        this.丐丅丘丏不东丙丄万 = val_9.x;
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.right;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  this.丐丅丘丏不东丙丄万);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z}, d:  90f);
        val_18.Rotate(eulers:  new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z});
        UnityEngine.Vector3 val_13 = val_18.position;
        val_15 = val_13.x;
        val_16 = val_13.z;
        var val_14 = this.丌世一下丟丗丝下丛 + (0 * 12);
        val_13 = 1;
        mem2[0] = val_15;
        mem2[0] = val_13.y;
        mem2[0] = val_16;
        label_19:
        if(val_13 < this.wheelVisuals.Length)
        {
            goto label_32;
        }
    
    }
    private void 东丂东丈丈且不七丌(float 丕丟一东三丏丝丞丞, bool 丝东七一丛丅丏且三, bool 业丂万丏丒丛丒万且, bool 丑丝七丆丙丅业丌丅 = False)
    {
        bool val_6;
        var val_7;
        var val_8;
        var val_9;
        val_6 = 丑丝七丆丙丅业丌丅;
        val_7 = 0;
        goto label_1;
        label_7:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.brakeHalo[0], 丏业丟一东丂东丘丛:  丝东七一丛丅丏且三);
        val_7 = 1;
        label_1:
        if(val_7 < this.brakeHalo.Length)
        {
            goto label_7;
        }
        
        if(业丂万丏丒丛丒万且 == false)
        {
            goto label_8;
        }
        
        float val_7 = 30f;
        val_7 = 丕丟一东三丏丝丞丞 / val_7;
        val_7 = val_7 * ((丝东七一丛丅丏且三 != true) ? 1f : 0f);
        bool val_3 = (val_7 > 0.1f) ? 1 : 0;
        val_3 = val_3 | val_6;
        val_8 = 0;
        val_6 = val_3;
        goto label_9;
        label_13:
        EmissionModule val_4 = this.particles[0].emission;
        val_4.m_ParticleSystem.enabled = val_6;
        val_8 = 1;
        label_9:
        if(val_8 < this.particles.Length)
        {
            goto label_13;
        }
        
        return;
        label_8:
        val_9 = 0;
        goto label_15;
        label_19:
        val_6 = this.particles[0];
        EmissionModule val_5 = val_6.emission;
        val_5.m_ParticleSystem.enabled = false;
        val_9 = 1;
        label_15:
        if(val_9 < this.particles.Length)
        {
            goto label_19;
        }
    
    }
    public VehicleView()
    {
        this.丗丂丘丁七丆一万上 = -1f;
        this.ressoreLength = 0.5f;
        this.wheelRadius = 0.5f;
        this.AnimationSpeedMultipler = 2f;
        this.且下下丘丐丕一一七 = new System.Collections.Generic.Dictionary<UnityEngine.Transform, VehicleWheelVisualParameters>();
        this.不丗丘丘一丕丑专一 = 0;
        this.世丅且丝专东丁业七 = true;
    }

}
