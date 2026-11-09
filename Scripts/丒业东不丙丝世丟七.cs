using UnityEngine;
private sealed class BotAiController.丒业东不丙丝世丟七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public RilisoftBot.BotAiController 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public BotAiController.丒业东不丙丝世丟七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        UnityEngine.WaitForSeconds val_8;
        int val_9;
        if(this.丗丏丅丕丆世丁专丟 <= 1)
        {
                this.丗丏丅丕丆世丁专丟 = 0;
            if((this.丝且与丝丒丟万丁专.丛丘丌丝丟且丕丐丂 != false) && (this.丝且与丝丒丟万丁专.丅丏三七丁丑丞丄丏.isMine != false))
        {
                if(this.丝且与丝丒丟万丁专.丗下丘世三七一专丕 == 0)
        {
                UnityEngine.Vector3 val_3 = this.丝且与丝丒丟万丁专.丌丟丄业且三丛丕丄().position;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = this.丝且与丝丒丟万丁专.丐丅丑丂丞专丙东丁, y = V9.16B, z = V10.16B}, b:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z})) < 0)
        {
                this.丝且与丝丒丟万丁专.与丞丕丝上三不丞与();
        }
        
        }
        
            UnityEngine.Vector3 val_6 = this.丝且与丝丒丟万丁专.丌丟丄业且三丛丕丄().position;
            this.丝且与丝丒丟万丁专.丐丅丑丂丞专丙东丁 = val_6;
            mem2[0] = val_6.y;
            mem2[0] = val_6.z;
        }
        
            val_8 = this.丝且与丝丒丟万丁专.丏丈丏丅上丌万一世;
            if(val_8 == null)
        {
                UnityEngine.WaitForSeconds val_7 = null;
            val_8 = val_7;
            val_7 = new UnityEngine.WaitForSeconds(seconds:  0.1f);
            this.丝且与丝丒丟万丁专.丏丈丏丅上丌万一世 = val_8;
        }
        
            val_9 = 1;
            this.丒上七丌业七丟与丐 = val_8;
            this.丗丏丅丕丆世丁专丟 = val_9;
            return (bool)val_9;
        }
        
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
