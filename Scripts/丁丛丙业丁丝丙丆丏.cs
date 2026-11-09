using UnityEngine;
private sealed class SpawnDungeonMobeSetting.丁丛丙业丁丝丙丆丏 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public SpawnDungeonMobeSetting 丝且与丝丒丟万丁专;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public SpawnDungeonMobeSetting.丁丛丙业丁丝丙丆丏(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_12;
        var val_13;
        var val_14;
        int val_15;
        if((this.丗丏丅丕丆世丁专丟 - 1) >= 2)
        {
            goto label_1;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丝且与丝丒丟万丁专.三上上丌丞丂丐下业.Count < 1)
        {
            goto label_4;
        }
        
        val_12 = 0;
        goto label_5;
        label_27:
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                val_13 = null;
            val_13 = null;
            七丂丅丘丒三丅丂丈 val_4 = this.丝且与丝丒丟万丁专.三上上丌丞丂丐下业.Item[0];
            七丂丅丘丒三丅丂丈 val_6 = this.丝且与丝丒丟万丁专.三上上丌丞丂丐下业.Item[0];
            UnityEngine.Quaternion val_7 = UnityEngine.Quaternion.identity;
            七丂丅丘丒三丅丂丈 val_8 = this.丝且与丝丒丟万丁专.三上上丌丞丂丐下业.Item[0];
            UnityEngine.GameObject val_9 = 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  SpawnDungeonMobeSetting.专世丟丂业世丟丐丐 + val_4.丒丘丏上丙丟丑丕丈, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_6.丅专与丒丈丗丒丘丌.centerPoint, y = V8.16B, z = V9.16B}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_7.x, y = val_7.y, z = val_7.z, w = val_7.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  val_8.一丐丗丁丞丆丅丟丄);
            this.丝且与丝丒丟万丁专.三上上丌丞丂丐下业.RemoveAt(index:  0);
        }
        
        val_12 = 1;
        label_5:
        if(this.丝且与丝丒丟万丁专.三上上丌丞丂丐下业.Count > 4)
        {
                val_14 = 5;
        }
        else
        {
                val_14 = this.丝且与丝丒丟万丁专.三上上丌丞丂丐下业;
        }
        
        if(val_12 < val_14.Count)
        {
            goto label_27;
        }
        
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = 2;
        val_15 = 1;
        return (bool)val_15;
        label_1:
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
                val_15 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_15;
            return (bool)val_15;
        }
        
        val_15 = 0;
        return (bool)val_15;
        label_4:
        DungeonsController.丒丟丛专上东丗丕业();
        val_15 = 0;
        this.丝且与丝丒丟万丁专.专世与丗专上下七不 = 0;
        return (bool)val_15;
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
