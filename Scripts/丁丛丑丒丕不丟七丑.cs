using UnityEngine;
private sealed class AIBotTargetDetector.丁丛丑丒丕不丟七丑 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public PlayerBot.AIBotTargetDetector 丝且与丝丒丟万丁专;
    private UnityEngine.WaitForSeconds 三丛与七下专丅丕东;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public AIBotTargetDetector.丁丛丑丒丕不丟七丑(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_6;
        UnityEngine.WaitForSeconds val_7;
        int val_8;
        var val_9;
        if(this.丗丏丅丕丆世丁专丟 == 2)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_3;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.三丛与七下专丅丕东 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        UnityEngine.Vector3 val_1 = this.丝且与丝丒丟万丁专.业东丆丝上世丅下丗();
        val_6 = val_1.x;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.zero;
        if((UnityEngine.Vector3.op_Inequality(lhs:  new UnityEngine.Vector3() {x = val_6, y = val_1.y, z = val_1.z}, rhs:  new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z})) == false)
        {
            goto label_9;
        }
        
        val_7 = this.三丛与七下专丅丕东;
        if(val_7 == null)
        {
                val_6 = this.丝且与丝丒丟万丁专.丕丘业七丌与丅丞三;
            UnityEngine.WaitForSeconds val_4 = null;
            val_7 = val_4;
            val_4 = new UnityEngine.WaitForSeconds(seconds:  val_6);
            this.三丛与七下专丅丕东 = val_7;
        }
        
        val_8 = 1;
        goto label_12;
        label_2:
        this.丗丏丅丕丆世丁专丟 = 0;
        label_9:
        UnityEngine.Vector3 val_5 = UnityEngine.Vector3.zero;
        val_6 = val_5.x;
        val_7 = 0;
        val_8 = 2;
        this.丝且与丝丒丟万丁专.丂七上七万丈丁丅丅 = val_5;
        mem2[0] = val_5.y;
        mem2[0] = val_5.z;
        label_12:
        val_9 = 1;
        this.丒上七丌业七丟与丐 = val_7;
        this.丗丏丅丕丆世丁专丟 = val_8;
        return (bool)val_9;
        label_3:
        val_9 = 0;
        return (bool)val_9;
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
