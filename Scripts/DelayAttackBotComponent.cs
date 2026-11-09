using UnityEngine;
internal class DelayAttackBotComponent : PGBehaviour
{
    // Fields
    private bool <丘丒丛丁丄丗丞三上>k__BackingField;
    private bool <丆丑丞丕丑世丈丈丅>k__BackingField;
    protected UnityEngine.Transform 上丝丁东下万七且与;
    protected UnityEngine.Animation animations;
    protected RilisoftBot.BaseBot baseBot;
    protected UnityEngine.Coroutine 业丞丗丌丐丞丒业丟;
    
    // Properties
    public bool 一丘七丏丐一业丝三 { get; set; }
    public bool 不丑东七且丕丑丈丂 { get; set; }
    
    // Methods
    public bool get_CanStartAttack()
    {
        return (bool)this.<丘丒丛丁丄丗丞三上>k__BackingField;
    }
    protected void 业丑丝一丙一世丙丝(bool 丙业与丙丗丝不丈东)
    {
        this.<丘丒丛丁丄丗丞三上>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public bool get_CanPrepareForAttack()
    {
        return (bool)this.<丆丑丞丕丑世丈丈丅>k__BackingField;
    }
    protected void 丕上丒不丈丙下不与(bool 丙业与丙丗丝不丈东)
    {
        this.<丆丑丞丕丑世丈丈丅>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal virtual void 上丛丌丆丑上七世三()
    {
        this.<丘丒丛丁丄丗丞三上>k__BackingField = true;
        this.<丆丑丞丕丑世丈丈丅>k__BackingField = true;
        this.animations.cullingType = 0;
        RilisoftBot.BotAnimationEventHandler val_1 = this.GetComponentInChildren<RilisoftBot.BotAnimationEventHandler>();
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.丅丟东丗丏上下丑丄(丙业与丙丗丝不丈东:  new BotAnimationEventHandler.世专丌与丆业东一丑(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(DelayAttackBotComponent).__il2cppRuntimeField_1A0));
        val_1.一丐丘丌不上丙业一(丙业与丙丗丝不丈东:  new BotAnimationEventHandler.世专丌与丆业东一丑(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(DelayAttackBotComponent).__il2cppRuntimeField_1A0));
        val_1.丗丝丛东不下丒丙丄(丙业与丙丗丝不丈东:  new BotAnimationEventHandler.七丌丈业业丕丝丕与(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(DelayAttackBotComponent).__il2cppRuntimeField_1C0));
        val_1.下丄丝与上下丈万业(丙业与丙丗丝不丈东:  new BotAnimationEventHandler.七丌丈业业丕丝丕与(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(DelayAttackBotComponent).__il2cppRuntimeField_1C0));
        val_1.丆七丕三专丐世业七(丙业与丙丗丝不丈东:  new BotAnimationEventHandler.万且下丟丂丝上丏丑(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(DelayAttackBotComponent).__il2cppRuntimeField_1D0));
        val_1.丗万丑丕丄丌上与世(丙业与丙丗丝不丈东:  new BotAnimationEventHandler.万且下丟丂丝上丏丑(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(DelayAttackBotComponent).__il2cppRuntimeField_1D0));
        val_1.丌不丘丆专丙世上不(丙业与丙丗丝不丈东:  new BotAnimationEventHandler.一丁丙丘丁丘上专丂(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(DelayAttackBotComponent).__il2cppRuntimeField_1F0));
        val_1.业丝世且且且且丄丈(丙业与丙丗丝不丈东:  new BotAnimationEventHandler.一丁丙丘丁丘上专丂(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  typeof(DelayAttackBotComponent).__il2cppRuntimeField_1F0));
    }
    internal virtual void 且丁丄丌丐丄东丁世()
    {
        this.<丘丒丛丁丄丗丞三上>k__BackingField = true;
        this.<丆丑丞丕丑世丈丈丅>k__BackingField = false;
        if(this.业丞丗丌丐丞丒业丟 != null)
        {
                this.StopCoroutine(routine:  this.业丞丗丌丐丞丒业丟);
        }
        
        this.业丞丗丌丐丞丒业丟 = this.StartCoroutine(routine:  this);
    }
    internal virtual void SetTarget(UnityEngine.Transform 丞下万上三丘上与专)
    {
        this.上丝丁东下万七且与 = 丞下万上三丘上与专;
    }
    internal virtual void 专丅丟丏丂丅东丑万()
    {
    
    }
    internal virtual void 丆丌丙万与丛万丝世()
    {
        this.<丘丒丛丁丄丗丞三上>k__BackingField = false;
    }
    internal virtual void 与下且专丌业世丆丁()
    {
        if(this.上丝丁东下万七且与 == 0)
        {
                return;
        }
        
        this.baseBot.MakeDamage(丞下万上三丘上与专:  this.上丝丁东下万七且与);
    }
    internal virtual void 丁丟丁世丐丅上丄万()
    {
        this.<丆丑丞丕丑世丈丈丅>k__BackingField = true;
    }
    internal virtual System.Collections.IEnumerator 丈丝丅丗丄东丁一丟()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new DelayAttackBotComponent.丑七丆且丞业丅下丙();
    }
    internal virtual void 业下丄丆上七且且丑()
    {
        this.baseBot.业下丄丆上七且且丑();
    }
    public DelayAttackBotComponent()
    {
    
    }

}
