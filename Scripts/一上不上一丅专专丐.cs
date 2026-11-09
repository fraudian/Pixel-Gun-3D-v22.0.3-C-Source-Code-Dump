using UnityEngine;
internal abstract class 一上不上一丅专专丐
{
    // Fields
    protected AlternativeAttackSettings 业且丅不丘丑与下且;
    protected TriggerAlternativeAttackSetting 世丂世丘东丗丕丛丟;
    protected AlternativeMobAttackController 业专万丏丘丙丝一丕;
    private System.Action<一上不上一丅专专丐> 业丛丕丐丆丈下丐三;
    private System.Action<一上不上一丅专专丐> 三业丆且丛丒丏下丙;
    
    // Methods
    internal void 三七丁专丞丝丂丅丕(System.Action<一上不上一丅专专丐> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.业丛丕丐丆丈下丐三, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.业丛丕丐丆丈下丐三 != 1152921539875830424);
    
    }
    internal void 七七不丌世业东丝丈(System.Action<一上不上一丅专专丐> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.业丛丕丐丆丈下丐三, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.业丛丕丐丆丈下丐三 != 1152921539875967000);
    
    }
    internal void 丟东一下丌丏且丄上(System.Action<一上不上一丅专专丐> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.三业丆且丛丒丏下丙, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三业丆且丛丒丏下丙 != 1152921539876103584);
    
    }
    internal void 丅丌丁丑丟丙丒下丙(System.Action<一上不上一丅专专丐> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.三业丆且丛丒丏下丙, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.三业丆且丛丒丏下丙 != 1152921539876240160);
    
    }
    internal virtual void 丙丂丅丛丄丆业丛丆(AlternativeAttackSettings 与不丕丆丈不丙丟丛, AlternativeMobAttackController 丒专丈丛下丒一丒丛, TriggerAlternativeAttackSetting 七丗丘与丕且丘丑世)
    {
        this.世丂世丘东丗丕丛丟 = 七丗丘与丕且丘丑世;
        this.业专万丏丘丙丝一丕 = 丒专丈丛下丒一丒丛;
        this.业且丅不丘丑与下且 = 与不丕丆丈不丙丟丛;
    }
    internal abstract void 丆丌丙万与丛万丝世(); // 0
    protected virtual void 且下一七丒丝与世不()
    {
        bool val_2 = this.业专万丏丘丙丝一丕.丁丗丐丘丝不且与丞().Play(animation:  this.业且丅不丘丑与下且.nameAnimation);
        this.业专万丏丘丙丝一丕.animationHandler.add_OnAnimationEvent(丙业与丙丗丝不丈东:  new System.Action<System.String, 丂丌丞七丝上业丅万>(object:  this, method:  System.Void 一上不上一丅专专丐::丟丟一丙专一丛与丙(string 东丐丛丁一东丑丒专, Rilisoft.AnimationHandler.丂丌丞七丝上业丅万 世业丁丒一丒丌丞下)));
        float val_7 = 1.25f;
        val_7 = this.业专万丏丘丙丝一丕.丁丗丐丘丝不且与丞().Item[this.业且丅不丘丑与下且.nameAnimation].length * val_7;
        this.业专万丏丘丙丝一丕.丞七丗不丏丁丏丒丐(丕丕世且下一与丝与:  val_7);
        if(this.业丛丕丐丆丈下丐三 == null)
        {
                return;
        }
        
        this.业丛丕丐丆丈下丐三.Invoke(obj:  this);
    }
    protected abstract void 丙丝丞一丏专丘丐丄(); // 0
    protected virtual void 丁丟丁世丐丅上丄万()
    {
        this.业专万丏丘丙丝一丕.丗东专丈丆世下丌丞();
        if(this.三业丆且丛丒丏下丙 == null)
        {
                return;
        }
        
        this.三业丆且丛丒丏下丙.Invoke(obj:  this);
    }
    protected void 丌丐万丛三上一与东(System.Collections.Generic.List<丅丙上七上一丐不下> 丏万下业丘七业丙专)
    {
        var val_6;
        AlternativeAttackSettings val_32;
        var val_33;
        float val_34;
        var val_35;
        var val_37;
        val_33 = this;
        if(丏万下业丘七业丙专 == null)
        {
                return;
        }
        
        val_32 = this.业专万丏丘丙丝一丕.七与世丄丞丒一七三().丛丘丟业下丐专丕丑();
        if(val_32.isMine == false)
        {
                return;
        }
        
        List.Enumerator<T> val_4 = 丏万下业丘七业丙专.GetEnumerator();
        label_52:
        if((910351744 & 1) == 0)
        {
            goto label_13;
        }
        
        string val_7 = val_6.丐丏七丌丕丗业且上();
        val_32 = this.业且丅不丘丑与下且;
        if(this.业且丅不丘丑与下且.isFriendlyFire == false)
        {
            goto label_8;
        }
        
        if(val_7 == null)
        {
            goto label_13;
        }
        
        goto label_13;
        label_8:
        if(val_7 == null)
        {
            goto label_13;
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() != false)
        {
                val_34 = DungeonsController.上丂丂丂且丟丝业丘() * DungeonsController.七业与不上丏丌丈丌();
        }
        else
        {
                val_35 = null;
            val_35 = null;
            val_34 = RilisoftBot.BaseBot.东丝丌丗丘东丁丐与;
        }
        
        val_37 = null;
        UnityEngine.Vector3 val_15 = this.业专万丏丘丙丝一丕.七与世丄丞丒一七三().七与世丄丞丒一七三().万丈且与七下上不专();
        var val_30 = 0;
        val_30 = val_30 + 1;
        val_7.ApplyDamage(丞丈专下丈专业三丞:  val_34 * this.业且丅不丘丑与下且.damage, 丛世一丟丞丁业丘丒:  this.业专万丏丘丙丝一丕.七与世丄丞丒一七三().七与世丄丞丒一七三(), 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, 丐丟丘世丁三丕专专:  16, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  "", 丒丈丐丐丗丐专丈丏:  0);
        goto label_52;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    protected abstract System.Collections.Generic.List<丅丙上七上一丐不下> 丑不专丈丄专下世丒(); // 0
    private void 丟丟一丙专一丛与丙(string 东丐丛丁一东丑丒专, Rilisoft.AnimationHandler.丂丌丞七丝上业丅万 世业丁丒一丒丌丞下)
    {
        string val_9;
        object val_10;
        val_9 = 东丐丛丁一东丑丒专;
        val_10 = this;
        if(世业丁丒一丒丌丞下 != 1)
        {
                return;
        }
        
        if((System.String.op_Equality(a:  val_9, b:  this.业且丅不丘丑与下且.nameAnimation)) == false)
        {
                return;
        }
        
        this.业专万丏丘丙丝一丕.animationHandler.remove_OnAnimationEvent(丙业与丙丗丝不丈东:  new System.Action<System.String, 丂丌丞七丝上业丅万>(object:  this, method:  System.Void 一上不上一丅专专丐::丟丟一丙专一丛与丙(string 东丐丛丁一东丑丒专, Rilisoft.AnimationHandler.丂丌丞七丝上业丅万 世业丁丒一丒丌丞下)));
        val_10 = ???;
        val_9 = ???;
        goto typeof(一上不上一丅专专丐).__il2cppRuntimeField_1A8;
    }
    protected 一上不上一丅专专丐()
    {
    
    }

}
