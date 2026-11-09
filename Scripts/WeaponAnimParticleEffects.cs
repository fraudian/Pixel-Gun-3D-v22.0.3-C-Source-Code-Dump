using UnityEngine;
public class WeaponAnimParticleEffects : MonoBehaviour
{
    // Fields
    private WeaponAnimEffectData _currentEffect;
    private bool <丑世下上一丏三世丄>k__BackingField;
    private System.Collections.Generic.List<UnityEngine.GameObject> 丁丗上丟丐丁丐上业;
    private bool 专丐专丂丆丄丁丈东;
    private bool 一专世丏丞丑三丘七;
    private string _lastFinishedAnimationName;
    private string _lastStartedAnimationName;
    public WeaponAnimEffectData[] effects;
    
    // Properties
    public bool 丘东丛丙且不万世专 { get; set; }
    private System.Collections.Generic.List<UnityEngine.GameObject> 丁丂丟丐丘三专业丟 { get; }
    
    // Methods
    public bool get_DisableAllEffects()
    {
        return (bool)this.<丑世下上一丏三世丄>k__BackingField;
    }
    public void set_DisableAllEffects(bool 丙业与丙丗丝不丈东)
    {
        this.<丑世下上一丏三世丄>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private System.Collections.Generic.List<UnityEngine.GameObject> 万丝丆专业丂丂东丛()
    {
        System.Collections.Generic.List<UnityEngine.GameObject> val_4;
        var val_5;
        var val_6;
        val_4 = this.丁丗上丟丐丁丐上业;
        if(val_4 != null)
        {
                return val_4;
        }
        
        this.丁丗上丟丐丁丐上业 = new System.Collections.Generic.List<UnityEngine.GameObject>();
        val_5 = 0;
        goto label_2;
        label_15:
        WeaponAnimEffectData val_4 = this.effects[0];
        val_6 = 0;
        goto label_5;
        label_13:
        UnityEngine.ParticleSystem val_5 = this.effects[0x0][0].particleSystems[0];
        if(val_5 != 0)
        {
                this.丁丗上丟丐丁丐上业.Add(item:  val_5.gameObject);
        }
        
        val_6 = 1;
        label_5:
        if(val_6 < this.effects[0x0][0].particleSystems.Length)
        {
            goto label_13;
        }
        
        val_5 = 1;
        label_2:
        if(val_5 < this.effects.Length)
        {
            goto label_15;
        }
        
        val_4 = this.丁丗上丟丐丁丐上业;
        return val_4;
    }
    private void Start()
    {
        var val_1;
        if(this.一专世丏丞丑三丘七 == true)
        {
            goto label_0;
        }
        
        val_1 = 0;
        goto label_1;
        label_4:
        this.丆丑丗丕东丗丁丏七(丈业丙丟不丅万丘丈:  this.effects[0]);
        val_1 = 1;
        label_1:
        if(val_1 < this.effects.Length)
        {
            goto label_4;
        }
        
        this.一专世丏丞丑三丘七 = true;
        label_0:
        this.ActivateDefaultEffect();
    }
    private void OnEnable()
    {
        this.ActivateDefaultEffect();
    }
    public System.Collections.Generic.List<UnityEngine.GameObject> GetListAnimEffects()
    {
        return this.万丝丆专业丂丂东丛();
    }
    private void 丆丑丗丕东丗丁丏七(WeaponAnimEffectData 丈业丙丟不丅万丘丈)
    {
        object val_15;
        string val_16;
        WeaponAnimParticleEffects.丞丆丌万丛不且七丐 val_1 = null;
        val_15 = val_1;
        val_1 = new WeaponAnimParticleEffects.丞丆丌万丛不且七丐();
        .丈业丙丟不丅万丘丈 = 丈业丙丟不丅万丘丈;
        val_16 = (WeaponAnimParticleEffects.丞丆丌万丛不且七丐)[1152921539569615808].丈业丙丟不丅万丘丈.animationName;
        UnityEngine.AnimationClip val_3 = this.GetComponent<UnityEngine.Animation>().GetClip(name:  val_16);
        .与世丐下丌丘不丒一 = val_3;
        if(val_3 == 0)
        {
                return;
        }
        
        if((System.Linq.Enumerable.Any<UnityEngine.AnimationEvent>(source:  (WeaponAnimParticleEffects.丞丆丌万丛不且七丐)[1152921539569615808].与世丐下丌丘不丒一.events, predicate:  new System.Func<UnityEngine.AnimationEvent, System.Boolean>(object:  val_1, method:  System.Boolean WeaponAnimParticleEffects.丞丆丌万丛不且七丐::与七七丌丐丑业丝丌(UnityEngine.AnimationEvent 丗丛不丁丑专专丂且)))) != true)
        {
                UnityEngine.AnimationEvent val_8 = new UnityEngine.AnimationEvent();
            if(val_8 != null)
        {
                val_8.stringParameter = (WeaponAnimParticleEffects.丞丆丌万丛不且七丐)[1152921539569615808].丈业丙丟不丅万丘丈.animationName;
            val_8.functionName = "OnStartAnimEffects";
        }
        else
        {
                val_8.stringParameter = (WeaponAnimParticleEffects.丞丆丌万丛不且七丐)[1152921539569615808].丈业丙丟不丅万丘丈.animationName;
            val_8.functionName = "OnStartAnimEffects";
        }
        
            val_8.time = 0f;
            (WeaponAnimParticleEffects.丞丆丌万丛不且七丐)[1152921539569615808].与世丐下丌丘不丒一.AddEvent(evt:  val_8);
        }
        
        System.Func<UnityEngine.AnimationEvent, System.Boolean> val_10 = null;
        val_16 = val_10;
        val_10 = new System.Func<UnityEngine.AnimationEvent, System.Boolean>(object:  val_1, method:  System.Boolean WeaponAnimParticleEffects.丞丆丌万丛不且七丐::丘三且丗丙丐丙丕且(UnityEngine.AnimationEvent 丗丛不丁丑专专丂且));
        if((System.Linq.Enumerable.Any<UnityEngine.AnimationEvent>(source:  (WeaponAnimParticleEffects.丞丆丌万丛不且七丐)[1152921539569615808].与世丐下丌丘不丒一.events, predicate:  val_10)) != true)
        {
                UnityEngine.AnimationEvent val_12 = new UnityEngine.AnimationEvent();
            if(val_12 != null)
        {
                val_12.stringParameter = (WeaponAnimParticleEffects.丞丆丌万丛不且七丐)[1152921539569615808].丈业丙丟不丅万丘丈.animationName;
        }
        else
        {
                val_12.stringParameter = (WeaponAnimParticleEffects.丞丆丌万丛不且七丐)[1152921539569615808].丈业丙丟不丅万丘丈.animationName;
        }
        
            val_12.functionName = "OnAnimationFinished";
            val_12.time = (WeaponAnimParticleEffects.丞丆丌万丛不且七丐)[1152921539569615808].与世丐下丌丘不丒一.length;
            val_16 = (WeaponAnimParticleEffects.丞丆丌万丛不且七丐)[1152921539569615808].与世丐下丌丘不丒一;
            val_16.AddEvent(evt:  val_12);
        }
        
        if((WeaponAnimParticleEffects.丞丆丌万丛不且七丐)[1152921539569615808].丈业丙丟不丅万丘丈.isLoop != true)
        {
                val_15 = (WeaponAnimParticleEffects.丞丆丌万丛不且七丐)[1152921539569615808].与世丐下丌丘不丒一;
        }
        
        (WeaponAnimParticleEffects.丞丆丌万丛不且七丐)[1152921539569615808].丈业丙丟不丅万丘丈.<animationLength>k__BackingField = val_15.length;
    }
    public void ActivateDefaultEffect()
    {
        var val_3;
        System.Func<WeaponAnimEffectData, System.Boolean> val_5;
        val_3 = null;
        val_3 = null;
        val_5 = WeaponAnimParticleEffects.<>c.<>9__17_0;
        if(val_5 == null)
        {
                System.Func<WeaponAnimEffectData, System.Boolean> val_1 = null;
            val_5 = val_1;
            val_1 = new System.Func<WeaponAnimEffectData, System.Boolean>(object:  WeaponAnimParticleEffects.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean WeaponAnimParticleEffects.<>c::丐不一丐丗丐丕丞丕(WeaponAnimEffectData 丗丛不丁丑专专丂且));
            WeaponAnimParticleEffects.<>c.<>9__17_0 = val_5;
        }
        
        WeaponAnimEffectData val_2 = System.Linq.Enumerable.FirstOrDefault<WeaponAnimEffectData>(source:  this.effects, predicate:  val_1);
        if(val_2 != null)
        {
                this.丐万上且丟丂丑丞丛(丈业丙丟不丅万丘丈:  val_2, 丛丅丘一丏丙且丌上:  true);
        }
        
        this.丟专三丑丏丐丘丐丈();
    }
    public void DisableEffectForAnimation(string 东丐丛丁一东丑丒专)
    {
        WeaponAnimEffectData val_1 = this.三丛丞不且丄丅丂上(丌丁一下丙业丙丗不:  东丐丛丁一东丑丒专);
        if(val_1 == null)
        {
                return;
        }
        
        val_1.<isPlaying>k__BackingField = false;
        this.丐万上且丟丂丑丞丛(丈业丙丟不丅万丘丈:  val_1, 丛丅丘一丏丙且丌上:  false);
        this._currentEffect = 0;
    }
    internal void 丙业丟一丝三一丂丂(string 东丐丛丁一东丑丒专, bool 丑丒业丘丑东丕世丅)
    {
        WeaponAnimEffectData val_1 = this.三丛丞不且丄丅丂上(丌丁一下丙业丙丗不:  东丐丛丁一东丑丒专);
        if(val_1 == null)
        {
                return;
        }
        
        val_1.enabled = 丑丒业丘丑东丕世丅;
        this.丐万上且丟丂丑丞丛(丈业丙丟不丅万丘丈:  val_1, 丛丅丘一丏丙且丌上:  false);
    }
    private void 丟专三丑丏丐丘丐丈()
    {
        var val_3;
        if((this.<丑世下上一丏三世丄>k__BackingField) == false)
        {
                return;
        }
        
        System.Collections.Generic.List<UnityEngine.GameObject> val_1 = this.万丝丆专业丂丂东丛();
        val_3 = null;
        val_3 = null;
        if((WeaponAnimParticleEffects.<>c.<>9__20_0) == null)
        {
            goto label_4;
        }
        
        label_9:
        val_1.ForEach(action:  WeaponAnimParticleEffects.<>c.<>9__20_0);
        return;
        label_4:
        WeaponAnimParticleEffects.<>c.<>9__20_0 = new System.Action<UnityEngine.GameObject>(object:  WeaponAnimParticleEffects.<>c.__il2cppRuntimeField_static_fields, method:  System.Void WeaponAnimParticleEffects.<>c::且业不丆丞丗七丄丒(UnityEngine.GameObject 三丟东丕丄丄下下丑));
        if(val_1 != null)
        {
            goto label_9;
        }
        
        goto label_9;
    }
    private void 丐万上且丟丂丑丞丛(WeaponAnimEffectData 丈业丙丟不丅万丘丈, bool 丛丅丘一丏丙且丌上)
    {
        UnityEngine.Object val_6;
        if((丈业丙丟不丅万丘丈 == null) || (丈业丙丟不丅万丘丈.particleSystems == null))
        {
            goto label_6;
        }
        
        if((丛丅丘一丏丙且丌上 != false) && (丈业丙丟不丅万丘丈.blockAtPlay != false))
        {
                if((丈业丙丟不丅万丘丈.<isPlaying>k__BackingField) == true)
        {
            goto label_6;
        }
        
        }
        
        if(丈业丙丟不丅万丘丈.particleSystems.Length < 1)
        {
            goto label_6;
        }
        
        label_27:
        UnityEngine.ParticleSystem val_7 = 丈业丙丟不丅万丘丈.particleSystems[0];
        if(val_7 == 0)
        {
            goto label_25;
        }
        
        val_6 = val_7.gameObject;
        if(val_6 == 0)
        {
            goto label_25;
        }
        
        if((丛丅丘一丏丙且丌上 == false) || (丈业丙丟不丅万丘丈.enabled == false))
        {
            goto label_16;
        }
        
        val_7.gameObject.SetActive(value:  true);
        val_6 = 丈业丙丟不丅万丘丈.EmitCount;
        if((val_6 & 2147483648) != 0)
        {
            goto label_19;
        }
        
        val_7.Emit(count:  val_6);
        goto label_25;
        label_16:
        if((丈业丙丟不丅万丘丈.EmitCount & 2147483648) == 0)
        {
            goto label_25;
        }
        
        val_7.gameObject.SetActive(value:  false);
        goto label_25;
        label_19:
        val_7.Play();
        label_25:
        if((0 + 1) < 丈业丙丟不丅万丘丈.particleSystems.Length)
        {
            goto label_27;
        }
        
        label_6:
        this.丟专三丑丏丐丘丐丈();
    }
    private WeaponAnimEffectData 三丛丞不且丄丅丂上(string 丌丁一下丙业丙丗不)
    {
        WeaponAnimEffectData[] val_2;
        WeaponAnimEffectData[] val_3;
        WeaponAnimEffectData val_4;
        val_2 = this.effects;
        if(val_2 == null)
        {
                return (WeaponAnimEffectData)val_4;
        }
        
        if(this.effects.Length < 1)
        {
            goto label_1;
        }
        
        var val_2 = 0;
        goto label_2;
        label_7:
        val_3 = this.effects;
        label_2:
        val_4 = val_3[val_2];
        if(val_4 != null)
        {
                if((System.String.op_Equality(a:  this.effects[0x0][0].animationName, b:  丌丁一下丙业丙丗不)) == true)
        {
                return (WeaponAnimEffectData)val_4;
        }
        
        }
        
        val_2 = val_2 + 1;
        if(val_2 < (long)this.effects.Length)
        {
            goto label_7;
        }
        
        label_1:
        val_4 = 0;
        return (WeaponAnimEffectData)val_4;
    }
    private bool 丑东万丏丁丆丁丛丈(string 丌丁一下丙业丙丗不)
    {
        var val_3;
        if(this._currentEffect != null)
        {
                if(this._currentEffect.isLoop != false)
        {
                return System.String.op_Equality(a:  this._lastStartedAnimationName, b:  丌丁一下丙业丙丗不);
        }
        
            if((this.三丛丞不且丄丅丂上(丌丁一下丙业丙丗不:  丌丁一下丙业丙丗不)) == null)
        {
                return (bool)val_3;
        }
        
            if(val_1.isLoop != false)
        {
                var val_2 = (this.专丐专丂丆丄丁丈东 == false) ? 1 : 0;
            return (bool)val_3;
        }
        
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    private void OnStartAnimEffects(string animationName)
    {
        bool val_4;
        if((this.丑东万丏丁丆丁丛丈(丌丁一下丙业丙丗不:  animationName)) == true)
        {
                return;
        }
        
        this._lastStartedAnimationName = animationName;
        WeaponAnimEffectData val_2 = this.三丛丞不且丄丅丂上(丌丁一下丙业丙丗不:  animationName);
        if(val_2 == null)
        {
                return;
        }
        
        if(this._currentEffect == null)
        {
            goto label_3;
        }
        
        if(((System.Linq.Enumerable.SequenceEqual<UnityEngine.ParticleSystem>(first:  this._currentEffect.particleSystems, second:  val_2.particleSystems)) == false) || (this._currentEffect.isLoop == false))
        {
            goto label_7;
        }
        
        val_4 = val_2;
        if(val_2.isLoop == false)
        {
            goto label_7;
        }
        
        this._currentEffect = val_2;
        goto label_8;
        label_7:
        this.丐万上且丟丂丑丞丛(丈业丙丟不丅万丘丈:  this._currentEffect, 丛丅丘一丏丙且丌上:  false);
        label_3:
        this._currentEffect = val_2;
        this.丐万上且丟丂丑丞丛(丈业丙丟不丅万丘丈:  val_2, 丛丅丘一丏丙且丌上:  true);
        val_2.<isPlaying>k__BackingField = true;
        val_4 = val_2.isLoop;
        label_8:
        if(val_4 == true)
        {
                return;
        }
        
        this.专丐专丂丆丄丁丈东 = false;
    }
    private void OnAnimationFinished(string animationName)
    {
        this._lastFinishedAnimationName = animationName;
        if((this.三丛丞不且丄丅丂上(丌丁一下丙业丙丗不:  animationName)) == null)
        {
                return;
        }
        
        val_1.<isPlaying>k__BackingField = false;
    }
    private string 丐丕丙业丂东上万三()
    {
        var val_11;
        var val_14;
        string val_15;
        var val_16;
        var val_17;
        var val_18;
        val_11 = this;
        UnityEngine.Animation val_1 = this.GetComponent<UnityEngine.Animation>();
        if(val_1 == 0)
        {
            goto label_42;
        }
        
        System.Collections.IEnumerator val_3 = val_1.GetEnumerator();
        label_21:
        var val_13 = 0;
        val_13 = val_13 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_10;
        }
        
        var val_14 = 0;
        val_14 = val_14 + 1;
        val_14 = val_3.Current;
        if(val_14 != null)
        {
                if(null == null)
        {
            goto label_17;
        }
        
        }
        
        if(val_14 != null)
        {
                label_17:
            if(null != null)
        {
                val_14 = 0;
        }
        
        }
        
        val_15 = val_14.name;
        if((val_1.IsPlaying(name:  val_15)) == false)
        {
            goto label_21;
        }
        
        val_16 = 0;
        val_17 = 0;
        val_18 = 97;
        goto label_23;
        label_10:
        val_16 = 0;
        val_17 = 0;
        val_15 = 0;
        val_18 = 91;
        label_23:
        val_11 = val_3;
        if(val_11 != null)
        {
                var val_15 = 0;
            val_15 = val_15 + 1;
            val_11.Dispose();
        }
        
        if( == 1)
        {
            goto label_37;
        }
        
        if(91 == 97)
        {
                return (string)val_15;
        }
        
        if( == false)
        {
            goto label_42;
        }
        
        if(91 != 91)
        {
            goto label_40;
        }
        
        goto label_42;
        label_37:
        if( == false)
        {
            goto label_42;
        }
        
        label_40:
        label_42:
        val_15 = System.String.alignConst;
        return (string)val_15;
    }
    public WeaponAnimParticleEffects()
    {
    
    }

}
