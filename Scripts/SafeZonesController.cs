using UnityEngine;
public class SafeZonesController : MonoBehaviour
{
    // Fields
    internal const int 丙丑丒丅丏丐丄七业 = 3;
    public float startZoneRadius;
    public float startZoneTimeShow;
    public float startZoneTimeStay;
    public SafeZonesController.SafeZoneParameters[] zoneParameters;
    private MapSafeZone[] 一丑与丌丕与丆与丟;
    private UnityEngine.GameObject 下与丛一一丕三七专;
    private UnityEngine.Material 丒丗万丁丗丅下业丕;
    private bool <丕丒丝丕丟丙丐丁丆>k__BackingField;
    private float <三丅丄丏且丙世不七>k__BackingField;
    private float 下与世丕丗且专万丌;
    private float <丆万七丕世三丄丁丌>k__BackingField;
    private static System.Collections.Generic.Dictionary<string, object> 丄上与丏与且丄丅丁;
    private UnityEngine.Vector3 <丘丆万七丟丕一丈不>k__BackingField;
    private float <上上不一上丄丈且世>k__BackingField;
    private float <丝不丕七丕东丆丁丘>k__BackingField;
    private UnityEngine.Vector3 <丙丗丆丁丞丙丆丛丂>k__BackingField;
    private float <丞丙专丂东丗一丈丁>k__BackingField;
    
    // Properties
    public bool 东上丟丆丐七丞丄一 { get; set; }
    public float 一丈专万与丏丙丅业 { get; set; }
    public float 丐三世一丝丂丝丆丝 { get; set; }
    public UnityEngine.Vector3 丌下上七与下丝丙丝 { get; set; }
    public float 丙万丈丏丞丌业丆丘 { get; set; }
    public float 丅丕丈丁不丘与丞世 { get; set; }
    public UnityEngine.Vector3 七世下丟丂丞丞丝丒 { get; set; }
    public float 业丏丗不丌业丝万丒 { get; set; }
    
    // Methods
    public bool get_isCurrentZoneMoves()
    {
        return (bool)this.<丕丒丝丕丟丙丐丁丆>k__BackingField;
    }
    private void 丒丕一丁丐丏丈万万(bool 丙业与丙丗丝不丈东)
    {
        this.<丕丒丝丕丟丙丐丁丆>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public float get_zoneNextTimer()
    {
        return (float)this.<三丅丄丏且丙世不七>k__BackingField;
    }
    private void 丐丟七丞专丕丌丒丘(float 丙业与丙丗丝不丈东)
    {
        this.<三丅丄丏且丙世不七>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public float get_zoneMoveTimer()
    {
        return (float)this.<丆万七丕世三丄丁丌>k__BackingField;
    }
    private void 东丛丛丐丗三丞专丛(float 丙业与丙丗丝不丈东)
    {
        this.<丆万七丕世三丄丁丌>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        UnityEngine.GameObject val_7;
        UnityEngine.Material val_8;
        this.<丕丒丝丕丟丙丐丁丆>k__BackingField = false;
        UnityEngine.Object val_1 = UnityEngine.Resources.Load(path:  "KillSphere");
        if(val_1 != null)
        {
                var val_2 = (null == null) ? (val_1) : 0;
        }
        else
        {
                val_7 = 0;
        }
        
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_7);
        this.下与丛一一丕三七专 = val_3;
        UnityEngine.MeshRenderer val_4 = val_3.GetComponent<UnityEngine.MeshRenderer>();
        if(val_4 != null)
        {
                val_8 = val_4.material;
            this.丒丗万丁丗丅下业丕 = val_8;
        }
        else
        {
                val_8 = val_4.material;
            this.丒丗万丁丗丅下业丕 = val_8;
        }
        
        val_4.material = val_8;
    }
    public void SelectRandomZones(int 上七不丈下下丛丘与)
    {
        UnityEngine.Object val_10;
        var val_11;
        上七不丈下下丛丘与 = 上七不丈下下丛丘与 ^ 3;
        null = new System.Random(Seed:  上七不丈下下丛丘与);
        this.一丑与丌丕与丆与丟 = new MapSafeZone[0];
        val_10 = this.transform;
        val_11 = 0;
        goto label_2;
        label_19:
        if(this.transform.childCount == 0)
        {
                return;
        }
        
        int val_6 = val_10.childCount;
        val_10 = val_10.GetChild(index:  1494974000);
        if(val_10 == 0)
        {
                return;
        }
        
        MapSafeZone val_9 = val_10.GetComponent<MapSafeZone>();
        if(this.一丑与丌丕与丆与丟 == null)
        {
            goto label_12;
        }
        
        if(val_9 != null)
        {
            goto label_13;
        }
        
        goto label_16;
        label_12:
        if(val_9 == null)
        {
            goto label_16;
        }
        
        label_13:
        label_16:
        val_11 = 1;
        this.一丑与丌丕与丆与丟[0] = val_9;
        label_2:
        if(val_11 < this.一丑与丌丕与丆与丟.Length)
        {
            goto label_19;
        }
    
    }
    private void Update()
    {
        this.三业丘万三丘万丒下();
    }
    public UnityEngine.Vector3 get_currentZonePosition()
    {
        return new UnityEngine.Vector3() {x = this.<丘丆万七丟丕一丈不>k__BackingField};
    }
    private void 不万丂丞丏丅丛丞丘(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        this.<丘丆万七丟丕一丈不>k__BackingField = 丙业与丙丗丝不丈东;
        mem[1152921536167031308] = 丙业与丙丗丝不丈东.y;
        mem[1152921536167031312] = 丙业与丙丗丝不丈东.z;
    }
    public float get_currentZoneRadius()
    {
        return (float)this.<上上不一上丄丈且世>k__BackingField;
    }
    private void 丆丈丘世不丙丁丒上(float 丙业与丙丗丝不丈东)
    {
        this.<上上不一上丄丈且世>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public float get_currentZoneDamagePercent()
    {
        return (float)this.<丝不丕七丕东丆丁丘>k__BackingField;
    }
    private void 丅三专丁丕一丂丘丏(float 丙业与丙丗丝不丈东)
    {
        this.<丝不丕七丕东丆丁丘>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public UnityEngine.Vector3 get_safeZonePosition()
    {
        return new UnityEngine.Vector3() {x = this.<丙丗丆丁丞丙丆丛丂>k__BackingField};
    }
    private void 丄丅丐一丕万丛丐丂(UnityEngine.Vector3 丙业与丙丗丝不丈东)
    {
        this.<丙丗丆丁丞丙丆丛丂>k__BackingField = 丙业与丙丗丝不丈东;
        mem[1152921536167703328] = 丙业与丙丗丝不丈东.y;
        mem[1152921536167703332] = 丙业与丙丗丝不丈东.z;
    }
    public float get_safeZoneRadius()
    {
        return (float)this.<丞丙专丂东丗一丈丁>k__BackingField;
    }
    private void 丂丛丝丏业上丂与世(float 丙业与丙丗丝不丈东)
    {
        this.<丞丙专丂东丗一丈丁>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void 三业丘万三丘万丒下()
    {
        var val_28;
        float val_29;
        var val_33;
        float val_37;
        float val_38;
        float val_39;
        float val_40;
        SafeZoneParameters val_41;
        var val_42;
        SafeZoneParameters val_43;
        var val_44;
        var val_45;
        val_28 = 1152921505107111936;
        double val_28 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_28 = val_28 - BattleRoyaleController.丄专丕丞丟七丐丞世();
        BattleRoyaleController val_3 = BattleRoyaleController.丑七不且上丗丁一世();
        float val_29 = val_3.timeFlyShutle;
        this.<三丅丄丏且丙世不七>k__BackingField = 0f;
        this.<丆万七丕世三丄丁丌>k__BackingField = 0f;
        val_29 = (float)val_28;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.zero;
        this.<丘丆万七丟丕一丈不>k__BackingField = val_4;
        mem[1152921536168559580] = val_4.y;
        mem[1152921536168559584] = val_4.z;
        this.<上上不一上丄丈且世>k__BackingField = 0f;
        this.<丝不丕七丕东丆丁丘>k__BackingField = 0f;
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        this.<丙丗丆丁丞丙丆丛丂>k__BackingField = val_5;
        mem[1152921536168559600] = val_5.y;
        mem[1152921536168559604] = val_5.z;
        this.<丞丙专丂东丗一丈丁>k__BackingField = 0f;
        if(val_29 >= 0)
        {
            goto label_22;
        }
        
        float val_30 = this.startZoneTimeShow;
        val_29 = val_29 + val_30;
        this.<三丅丄丏且丙世不七>k__BackingField = UnityEngine.Mathf.Clamp(value:  val_29 - val_29, min:  0f, max:  val_30);
        if(val_29 >= 0)
        {
            goto label_22;
        }
        
        val_33 = 0;
        val_30 = val_29 + this.startZoneTimeStay;
        goto label_12;
        label_21:
        val_30 = val_30 + this.zoneParameters[0];
        if(val_30 > val_29)
        {
            goto label_17;
        }
        
        int val_32 = this.zoneParameters.Length;
        val_32 = val_32 - 1;
        if(val_33 == val_32)
        {
            goto label_17;
        }
        
        val_33 = 1;
        val_30 = val_30 + this.zoneParameters[0];
        label_12:
        if(val_33 < this.zoneParameters.Length)
        {
            goto label_21;
        }
        
        goto label_22;
        label_17:
        UnityEngine.Vector3 val_9 = this.一丑与丌丕与丆与丟[0].transform.position;
        this.<丙丗丆丁丞丙丆丛丂>k__BackingField = val_9;
        mem[1152921536168559600] = val_9.y;
        mem[1152921536168559604] = val_9.z;
        this.<丞丙专丂东丗一丈丁>k__BackingField = this.zoneParameters[0];
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        if(val_33 >= this.zoneParameters.Length)
        {
                UnityEngine.Vector3 val_12 = this.一丑与丌丕与丆与丟[-1].transform.position;
            val_37 = val_12.x;
            val_38 = val_12.y;
            val_39 = val_12.z;
        }
        else
        {
                UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
            val_37 = val_13.x;
            val_38 = val_13.y;
            val_39 = val_13.z;
            val_40 = this.startZoneRadius;
        }
        
        float val_14 = val_30 - val_29;
        val_29 = UnityEngine.Mathf.Clamp01(value:  val_14 / this.zoneParameters[0]);
        this.<丆万七丕世三丄丁丌>k__BackingField = UnityEngine.Mathf.Clamp(value:  val_14, min:  0f, max:  this.zoneParameters[0]);
        val_41 = this.zoneParameters[0];
        if(val_33 >= this.zoneParameters.Length)
        {
                val_42 = null;
            val_43 = this.zoneParameters[-16];
        }
        else
        {
                val_42 = null;
            val_43 = this.startZoneTimeStay;
        }
        
        this.<三丅丄丏且丙世不七>k__BackingField = UnityEngine.Mathf.Clamp(value:  val_14 - val_41, min:  0f, max:  val_43);
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                val_41 = this.下与世丕丗且专万丌;
            val_44 = null;
            val_44 = null;
            val_45 = null;
            val_45 = null;
            ChestsBattleRoyaleController.丄丘七三上丕世丞业.AirDrop(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = this.<丙丗丆丁丞丙丆丛丂>k__BackingField, y = val_39, z = val_41}, 且丛上丕业丂丒与一:  (this.<丞丙专丂东丗一丈丁>k__BackingField) * 0.8f);
            val_37 = val_37;
            val_39 = val_39;
            val_38 = val_38;
        }
        
        bool val_22 = (val_29 > 0f) ? 1 : 0;
        val_22 = val_22 & ((val_29 < 0) ? 1 : 0);
        this.下与世丕丗且专万丌 = val_14;
        this.<丕丒丝丕丟丙丐丁丆>k__BackingField = val_22;
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = this.<丙丗丆丁丞丙丆丛丂>k__BackingField, y = val_41, z = val_14}, b:  new UnityEngine.Vector3() {x = val_37, y = val_38, z = val_39}, t:  val_29);
        this.<丘丆万七丟丕一丈不>k__BackingField = val_24;
        mem[1152921536168559580] = val_24.y;
        mem[1152921536168559584] = val_24.z;
        this.<上上不一上丄丈且世>k__BackingField = UnityEngine.Mathf.Lerp(a:  this.<丞丙专丂东丗一丈丁>k__BackingField, b:  val_40, t:  val_29);
        this.<丝不丕七丕东丆丁丘>k__BackingField = this.zoneParameters[0];
        label_22:
        this.下与丛一一丕三七专.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        float val_40 = this.<上上不一上丄丈且世>k__BackingField;
        val_40 = val_40 + val_40;
        this.下与丛一一丕三七专.transform.localScale = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.丒丗万丁丗丅下业丕.SetFloat(name:  "_Scale", value:  this.<上上不一上丄丈且世>k__BackingField);
    }
    internal static void 丟丈与丕三丐丒丐丑(System.Collections.Generic.Dictionary<string, object> 丏丂万业丙专丏丒丒)
    {
        SafeZonesController.丄上与丏与且丄丅丁 = 丏丂万业丙专丏丒丒;
    }
    private void 丟丈上丛丙丕业丁丐()
    {
    
    }
    public bool IsInSafeZoneRadius(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        var val_3;
        if((this.<丞丙专丂东丗一丈丁>k__BackingField) > 0f)
        {
                UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.<丙丗丆丁丞丙丆丛丂>k__BackingField, y = V11.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
            float val_3 = this.<丞丙专丂东丗一丈丁>k__BackingField;
            val_1.x = val_1.x * val_1.x;
            val_1.z = val_1.z * val_1.z;
            val_1.x = val_1.x + val_1.z;
            val_3 = val_3 * val_3;
            var val_2 = (val_1.x <= val_3) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 1;
        return (bool)val_3;
    }
    public bool IsOutOfCurrentZoneRadius(UnityEngine.Vector3 业丒丝丗与丐丛丟丏)
    {
        var val_3;
        if((this.<上上不一上丄丈且世>k__BackingField) > 0f)
        {
                UnityEngine.Vector3 val_1 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = this.<丘丆万七丟丕一丈不>k__BackingField, y = V11.16B, z = V12.16B}, b:  new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z});
            float val_3 = this.<上上不一上丄丈且世>k__BackingField;
            val_1.x = val_1.x * val_1.x;
            val_1.z = val_1.z * val_1.z;
            val_1.x = val_1.x + val_1.z;
            val_3 = val_3 * val_3;
            var val_2 = (val_1.x > val_3) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    public SafeZonesController()
    {
        this.startZoneRadius = 300f;
        this.startZoneTimeShow = 60f;
        this.startZoneTimeStay = 60f;
    }

}
