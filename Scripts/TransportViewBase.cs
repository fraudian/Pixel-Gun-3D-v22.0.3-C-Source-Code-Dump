using UnityEngine;
public abstract class TransportViewBase : PGBehaviour
{
    // Fields
    public UnityEngine.Transform[] playersPlaces;
    public VehicleLandingPoint[] LandingPoints;
    public VehicleLandingPoint[] LandingPointsSecondPrioritet;
    public UnityEngine.GameObject explosion;
    public UnityEngine.AnimationCurve explosionJump;
    public UnityEngine.GameObject fire;
    public UnityEngine.GameObject[] fxObjects;
    public UnityEngine.ParticleSystem smoke;
    private readonly string <丘世丐与丁丄丌专一>k__BackingField;
    private readonly string <丗丁丑三专丗丌丑丐>k__BackingField;
    internal bool 专七丟东丒上与业下;
    private float 丗丂丘丁七丆一万上;
    
    // Properties
    protected virtual string 丝丞丅丂下丌业业丙 { get; }
    protected virtual string 丏丗不一丗丆业丌丑 { get; }
    internal abstract UnityEngine.Material 丘丐丞专业世丝丞丆 { get; }
    
    // Methods
    protected virtual string 且丙与专世一与丙万()
    {
        return (string)this.<丘世丐与丁丄丌专一>k__BackingField;
    }
    protected virtual string 万下业三业丈丝下下()
    {
        return (string)this.<丗丁丑三专丗丌丑丐>k__BackingField;
    }
    internal abstract UnityEngine.Material 上丒专丝丌万丂上丌(); // 0
    internal virtual void 七丛丐与丑丈一万丁()
    {
        if(this.专七丟东丒上与业下 == false)
        {
                return;
        }
        
        this.专七丟东丒上与业下 = false;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.explosion, 丏业丟一东丂东丘丛:  true);
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() != true)
        {
                UnityEngine.AudioSource val_2 = this.explosion.GetComponent<UnityEngine.AudioSource>();
            if(val_2 != 0)
        {
                val_2.enabled = false;
        }
        
        }
        
        if((this.fxObjects != null) && (this.fxObjects.Length >= 1))
        {
                do
        {
            丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.fxObjects[0], 丏业丟一东丂东丘丛:  false);
        }
        while((0 + 1) < this.fxObjects.Length);
        
        }
        
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.fire, 丏业丟一东丂东丘丛:  false);
        UnityEngine.Object.Destroy(obj:  this.smoke, t:  15f);
        this.SetFloat(name:  this, value:  1f);
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this);
    }
    protected virtual System.Collections.IEnumerator 丝三丐不上万丕专东()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TransportViewBase.专丗万东丅万上世下();
    }
    internal virtual void 丞业不丞专丙三不丘(float 丒丌丛丑丁丙丟丌上)
    {
        if(丒丌丛丑丁丙丟丌上 <= 1f)
        {
                return;
        }
        
        int val_2 = UnityEngine.Mathf.FloorToInt(f:  丒丌丛丑丁丙丟丌上 + 丒丌丛丑丁丙丟丌上);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this);
    }
    protected virtual System.Collections.IEnumerator 世丐丄丅东三专且丘(int 一丅上丐丂丏业上专)
    {
        TransportViewBase.七下下三丏丂丑丛丆 val_1 = new TransportViewBase.七下下三丏丂丑丛丆();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .一丅上丐丂丏业上专 = 一丅上丐丂丏业上专;
        return (System.Collections.IEnumerator)val_1;
    }
    internal virtual void 下丟丄丅丅七丐丁丙(float 上丝丄万东丘丕丐丙)
    {
        var val_19;
        string val_20;
        val_19 = 0;
        if((UnityEngine.Object.op_Implicit(exists:  this.smoke)) != false)
        {
                丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.smoke.gameObject, 丏业丟一东丂东丘丛:  (上丝丄万东丘丕丐丙 < 0) ? 1 : 0);
            if(上丝丄万东丘丕丐丙 < 0)
        {
                MainModule val_4 = this.smoke.main;
            float val_18 = 4f;
            val_18 = 上丝丄万东丘丕丐丙 * val_18;
            val_18 = val_18 + (-1f);
            MinMaxGradient val_5 = ParticleSystem.MinMaxGradient.op_Implicit(color:  new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f});
            EmissionModule val_10 = this.smoke.emission;
            float val_12 = UnityEngine.Mathf.Lerp(a:  27f, b:  5f, t:  上丝丄万东丘丕丐丙 + 上丝丄万东丘丕丐丙);
            val_12 = val_12 + 3f;
            MinMaxCurve val_13 = ParticleSystem.MinMaxCurve.op_Implicit(constant:  val_12);
            val_19;
        }
        
        }
        
        val_20 = this;
        float val_19 = 0.7f;
        val_19 = val_19 - 上丝丄万东丘丕丐丙;
        this.SetFloat(name:  this, value:  UnityEngine.Mathf.Clamp01(value:  val_19));
        if((this.丗丂丘丁七丆一万上 != (-1f)) && (this.丗丂丘丁七丆一万上 != 上丝丄万东丘丕丐丙))
        {
                UnityEngine.Coroutine val_17 = this.StartCoroutine(routine:  this);
        }
        else
        {
                val_20 = this;
            this.SetFloat(name:  this, value:  0f);
        }
        
        this.丗丂丘丁七丆一万上 = 上丝丄万东丘丕丐丙;
    }
    protected virtual System.Collections.IEnumerator 丆丒且东下丛不丘丞()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TransportViewBase.专万丞丗丆东万丝与();
    }
    protected TransportViewBase()
    {
        this.<丘世丐与丁丄丌专一>k__BackingField = "_Damage";
        this.专七丟东丒上与业下 = true;
        this.丗丂丘丁七丆一万上 = -1f;
        this.<丗丁丑三专丗丌丑丐>k__BackingField = "_Power";
    }

}
