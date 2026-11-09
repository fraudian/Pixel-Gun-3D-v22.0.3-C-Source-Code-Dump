using UnityEngine;
internal sealed class TurretController_HologramProjector : TurretController_Tower
{
    // Fields
    private CharacterInterfaceV2 characterInterface;
    private SelfExplosionComponent selfExplosion;
    private UnityEngine.Texture glossTexture;
    private DamageableObjectWithoutDeath damageableObjectWithoutDeath;
    private float scrollValue;
    private float scrollSpeedValue;
    private float scrollAplhaValue;
    private float glossTime;
    private float nonGlossTime;
    private bool 且丐丁丂且上一丝丗;
    private bool 下丄三丑三丁丁丞丌;
    
    // Methods
    protected override void 丒与上专丕丐一丝丕()
    {
        this.丒与上专丕丐一丝丕();
        this.且丐丁丂且上一丝丗 = false;
        this.characterInterface.世丅三丈丐丒万丈万(丙业与丙丗丝不丈东:  true);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.characterInterface.transform, 丏业丟一东丂东丘丛:  true);
        this.下丄三丑三丁丁丞丌 = false;
        this.characterInterface.业不丛不丞七丕东世(七不丐下丟专业万丅:  "Shoot");
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丒且三丗丐丘丙东一());
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.丝丞丅且丄业丟丂七());
        UnityEngine.Coroutine val_7 = this.StartCoroutine(routine:  this.丝上丈专丆丑丆丆丗());
    }
    private System.Collections.IEnumerator 丒且三丗丐丘丙东一()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TurretController_HologramProjector.专丒不一上业东东丆();
    }
    private System.Collections.IEnumerator 丒下丂不丐丕丄丏丙()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TurretController_HologramProjector.丌专丄丟一且丛丘丙();
    }
    private void 丆丕丐丁丝丝不丒万(UnityEngine.Renderer 丐丑丅丘丄丑丄丂与)
    {
        bool val_4 = System.String.op_Inequality(a:  丐丑丅丘丄丑丄丂与.material.shader.name, b:  "Custom/SpeedRunSky");
        丐丑丅丘丄丑丄丂与.material.shader = UnityEngine.Shader.Find(name:  "Custom/SpeedRunSky");
        丐丑丅丘丄丑丄丂与.material.SetTexture(name:  "_MainTex3", value:  this.glossTexture);
        this.上上一丙上下不上丌(丐丑丅丘丄丑丄丂与:  丐丑丅丘丄丑丄丂与);
    }
    private void 上上一丙上下不上丌(UnityEngine.Renderer 丐丑丅丘丄丑丄丂与)
    {
        if(this.下丄三丑三丁丁丞丌 == false)
        {
            goto label_1;
        }
        
        if(丐丑丅丘丄丑丄丂与 != null)
        {
            goto label_8;
        }
        
        label_9:
        label_8:
        丐丑丅丘丄丑丄丂与.material.SetFloat(name:  "_Scroll", value:  this.scrollValue);
        丐丑丅丘丄丑丄丂与.material.SetFloat(name:  "_ScrollSpeed", value:  this.scrollSpeedValue);
        丐丑丅丘丄丑丄丂与.material.SetFloat(name:  "_ScrollAlpha", value:  this.scrollAplhaValue);
        return;
        label_1:
        if(丐丑丅丘丄丑丄丂与 != null)
        {
            goto label_8;
        }
        
        goto label_9;
    }
    private System.Collections.IEnumerator 丑丐业丟丘丐丌丆丞()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TurretController_HologramProjector.丌丄东下一丗一丄丟();
    }
    protected override void 丐丐丗丒丂上下万且()
    {
        this.丐丐丗丒丂上下万且();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.characterInterface.transform, 丏业丟一东丂东丘丛:  false);
    }
    protected override System.Collections.IEnumerator 丗丅世且丛丑业世丑()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new TurretController_HologramProjector.一丄丐丐丒业丅丗丑();
    }
    protected override void 丈丞一丈丑丝丈丂丂()
    {
    
    }
    protected override void 丕丕丞不丆业东下丒()
    {
        if(this.且丐丁丂且上一丝丗 != false)
        {
                return;
        }
        
        this.且丐丁丂且上一丝丗 = true;
        this.selfExplosion.丐丟丐专丙一丄业丟(丌且下丕下下丌万丞:  X21.isMine, 丌丑丛业丈丘世丞丕:  X21, 业丞业一丒丛丝且专:  V8.16B);
    }
    private System.Collections.IEnumerator 丝丞丅且丄业丟丂七()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TurretController_HologramProjector.丏业丑一七三丑丝丑();
    }
    private void 世不丆不丅专丁丅万(bool 丝世丏丑专丄丒业丏)
    {
        var val_1 = (this.下丄三丑三丁丁丞丌 == true) ? 1 : 0;
        val_1 = val_1 ^ 丝世丏丑专丄丒业丏;
        if(val_1 == false)
        {
                return;
        }
        
        this.下丄三丑三丁丁丞丌 = 丝世丏丑专丄丒业丏;
        this.上上一丙上下不上丌(丐丑丅丘丄丑丄丂与:  this.characterInterface.playerBodyRenderer);
        this.上上一丙上下不上丌(丐丑丅丘丄丑丄丂与:  this.characterInterface.playerHeadRenderer);
        this.上上一丙上下不上丌(丐丑丅丘丄丑丄丂与:  this.characterInterface.playerRightLegRenderer);
        this.上上一丙上下不上丌(丐丑丅丘丄丑丄丂与:  this.characterInterface.playerLeftLegRenderer);
        this.上上一丙上下不上丌(丐丑丅丘丄丑丄丂与:  this.characterInterface.playerSelfLeftArmRenderer);
        this.上上一丙上下不上丌(丐丑丅丘丄丑丄丂与:  this.characterInterface.playerSelfRightArmRenderer);
        this.上上一丙上下不上丌(丐丑丅丘丄丑丄丂与:  this.characterInterface.royaleAvatarBodyRenderer);
        this.上上一丙上下不上丌(丐丑丅丘丄丑丄丂与:  this.characterInterface.royaleAvatarHeadRenderer);
        this.上上一丙上下不上丌(丐丑丅丘丄丑丄丂与:  this.characterInterface.royaleAvatarArmsRenderer);
        this.上上一丙上下不上丌(丐丑丅丘丄丑丄丂与:  this.characterInterface.royaleAvatarLegsRenderer);
    }
    private System.Collections.IEnumerator 丝上丈专丆丑丆丆丗()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new TurretController_HologramProjector.丘丌丅丁业万七不七();
    }
    public TurretController_HologramProjector()
    {
        mem2[0] = ;
        this.nonGlossTime = 0.8f;
        mem[1152921540157183852] = ;
        mem[1152921540157183868] = 1130102784;
        val_1 = new TurretController();
    }

}
