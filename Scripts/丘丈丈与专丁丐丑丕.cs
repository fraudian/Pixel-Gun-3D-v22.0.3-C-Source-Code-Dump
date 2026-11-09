using UnityEngine;
private sealed class AIBotController.丘丈丈与专丁丐丑丕 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PlayerBot.AIBotController 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 万下一丈丄丌三且丙;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AIBotController.丘丈丈与专丁丐丑丕(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WaitForSeconds val_18;
        float val_19;
        float val_20;
        var val_21;
        UnityEngine.WaitForSeconds val_22;
        int val_23;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 3)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_2;
        }
        
        val_18 = this.丝且与丝丒丟万丁专;
        val_19 = this.丝且与丝丒丟万丁专.丕丞丑丕一不下丞丙;
        if(val_19 <= 0f)
        {
            goto label_9;
        }
        
        if(this.丝且与丝丒丟万丁专.currentBehaviorType != 1)
        {
            goto label_4;
        }
        
        val_20 = UnityEngine.Time.deltaTime;
        goto label_40;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_6;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_7;
        }
        
        UnityEngine.WaitForSeconds val_3 = null;
        val_18 = val_3;
        val_3 = new UnityEngine.WaitForSeconds(seconds:  this.丝且与丝丒丟万丁专.cycleTime);
        this.万下一丈丄丌三且丙 = val_18;
        goto label_8;
        label_2:
        if(0f <= 0f)
        {
            goto label_9;
        }
        
        val_19 = 0f;
        if(0 != 1)
        {
            goto label_10;
        }
        
        val_20 = UnityEngine.Time.deltaTime;
        goto label_11;
        label_9:
        if(this.丝且与丝丒丟万丁专.业业丏与丄丛丐丗丂() != true)
        {
                float val_6 = UnityEngine.Time.time;
            if(this.丝且与丝丒丟万丁专.丞下丞不万丂丝丁丏 < 0)
        {
                float val_7 = UnityEngine.Time.time;
            val_7 = val_7 + 1f;
            this.丝且与丝丒丟万丁专.丞下丞不万丂丝丁丏 = val_7;
            this.丝且与丝丒丟万丁专.丛与万丂丅丂丏丄丄();
        }
        
        }
        
        UnityEngine.Vector3 val_8 = this.丝且与丝丒丟万丁专.丄三与丞专丄不丑丛();
        val_20 = val_8.x;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        if(((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_20, y = val_8.y, z = val_8.z}, rhs:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z})) == false) || (this.丝且与丝丒丟万丁专.useTestBehavior == true))
        {
            goto label_34;
        }
        
        val_18 = this.丝且与丝丒丟万丁专._agentController;
        UnityEngine.Vector3 val_11 = this.丝且与丝丒丟万丁专.丄三与丞专丄不丑丛();
        val_20 = val_11.z;
        if(this.丝且与丝丒丟万丁专.currentBehaviorType != 1)
        {
            goto label_23;
        }
        
        if((val_18 & 1) != 0)
        {
            goto label_34;
        }
        
        val_18 = this.丝且与丝丒丟万丁专.playerBotController;
        if(val_18 == 0)
        {
            goto label_34;
        }
        
        val_18 = this.丝且与丝丒丟万丁专.playerBotController.player;
        if((val_18 == 0) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null))
        {
            goto label_34;
        }
        
        val_18 = this.丝且与丝丒丟万丁专.playerBotController.player;
        val_18.丝丟丑丐专丁丁七丑();
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_6:
        val_21 = 0;
        return (bool)val_21;
        label_4:
        val_20 = this.丝且与丝丒丟万丁专.cycleTime;
        goto label_40;
        label_7:
        UnityEngine.WaitForSeconds val_15 = null;
        val_18 = val_15;
        val_15 = new UnityEngine.WaitForSeconds(seconds:  0f);
        this.万下一丈丄丌三且丙 = val_18;
        label_8:
        val_20 = this.丝且与丝丒丟万丁专.丛丙东丕丙丙丐丞丙;
        UnityEngine.WaitForSeconds val_16 = null;
        val_22 = val_16;
        val_16 = new UnityEngine.WaitForSeconds(seconds:  val_20);
        val_23 = 1;
        goto label_44;
        label_10:
        val_20 = 0f;
        label_11:
        val_18 = 188;
        label_40:
        mem[188] = val_19 - val_20;
        label_34:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_45;
        }
        
        label_46:
        label_45:
        if(this.丝且与丝丒丟万丁专.currentBehaviorType == 1)
        {
                val_22 = 0;
            val_23 = 2;
        }
        else
        {
                val_22 = this.万下一丈丄丌三且丙;
            val_23 = 3;
        }
        
        label_44:
        val_21 = 1;
        this.丒上七丌业七丟与丐 = val_22;
        this.丗丏丅丕丆世丁专丟 = val_23;
        return (bool)val_21;
        label_23:
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_45;
        }
        
        goto label_46;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
