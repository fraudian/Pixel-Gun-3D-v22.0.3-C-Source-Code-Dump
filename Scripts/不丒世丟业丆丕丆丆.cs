using UnityEngine;
private sealed class WeaponTargetDetectorBase.不丒世丟业丆丕丆丆 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public WeaponTargetDetectorBase 丝且与丝丒丟万丁专;
    private WeaponTargetDetectorBase.丞丂万丅不丒丘丟丗 丄丌丂东丘丗一万且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public WeaponTargetDetectorBase.不丒世丟业丆丕丆丆(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        float val_21;
        float val_22;
        WeaponTargetDetectorBase.丞丂万丅不丒丘丟丗 val_23;
        int val_24;
        float val_25;
        var val_26;
        var val_27;
        Player_move_c val_28;
        var val_29;
        var val_30;
        var val_33;
        var val_34;
        var val_36;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        this.丄丌丂东丘丗一万且 = new WeaponTargetDetectorBase.丞丂万丅不丒丘丟丗();
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_3;
        }
        
        val_21 = this.丝且与丝丒丟万丁专.detectionRadius;
        val_22 = val_21;
        goto label_4;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_23 = this.丄丌丂东丘丗一万且;
        goto label_5;
        label_2:
        val_24 = 0;
        return (bool)val_24;
        label_3:
        val_22 = 0f;
        val_21 = 0f;
        label_4:
        val_23 = this.丄丌丂东丘丗一万且;
        .丙丕丙丒业丂与丄丈 = val_22 * val_21;
        label_5:
        if(this.丝且与丝丒丟万丁专 == null)
        {
            goto label_8;
        }
        
        val_25 = this.丝且与丝丒丟万丁专.detectionRadius;
        if(mem[this.丄丌丂东丘丗一万且] != 0)
        {
            goto label_34;
        }
        
        label_35:
        label_34:
        mem2[0] = val_25 * this.丝且与丝丒丟万丁专.detectionRadius;
        System.Collections.Generic.List<UnityEngine.Transform> val_4 = null;
        val_26 = val_4;
        val_4 = new System.Collections.Generic.List<UnityEngine.Transform>();
        val_27 = null;
        val_27 = null;
        val_28 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_28 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        val_29 = 0;
        if(val_28 == 0)
        {
            goto label_15;
        }
        
        WeaponTargetDetectorBase.丆丂丁丐丁丑不丐丆 val_6 = null;
        val_28 = val_6;
        val_6 = new WeaponTargetDetectorBase.丆丂丁丐丁丑不丐丆();
        .东丟且丗且三专丙丁 = mem[this.丄丌丂东丘丗一万且];
        val_30 = null;
        val_30 = null;
        System.Collections.Generic.List<UnityEngine.Transform> val_8 = new System.Collections.Generic.List<UnityEngine.Transform>();
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_9 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑(上丁丆不东丕万丂丏:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, 不丙丗丞丌丈且丄丟:  false, 丆世上且丗与丕丂丘:  false, 且三丁业丏丞丗世上:  false, 丁且世下丙三丏丕东:  false, 与丌上专不丌丘东丑:  false, 丌万丅丏丈丝丄一丌:  false, 丏丈丒一专业丏东丛:  true).世且一丄且上丄不一();
        label_33:
        var val_23 = 0;
        val_23 = val_23 + 1;
        if(val_9.MoveNext() == false)
        {
            goto label_26;
        }
        
        var val_24 = 0;
        val_24 = val_24 + 1;
        val_8.Add(item:  val_9.Current);
        goto label_33;
        label_8:
        if(mem[this.丄丌丂东丘丗一万且] != 0)
        {
            goto label_34;
        }
        
        goto label_35;
        label_26:
        val_33 = 0;
        val_34 = 0;
        if(val_9 == null)
        {
            
        }
        else
        {
                var val_25 = 0;
            val_25 = val_25 + 1;
            val_9.Dispose();
        }
        
        val_36 = null;
        val_36 = null;
        UnityEngine.Vector3 val_16 = typeof(Player_move_c).__il2cppRuntimeField_628.transform.position;
        val_25 = val_16.x;
        .丞丙丐丒一丛丟丕业 = val_16;
        mem[1152921540326191012] = val_16.y;
        mem[1152921540326191016] = val_16.z;
        val_26 = System.Linq.Enumerable.ToList<UnityEngine.Transform>(source:  System.Linq.Enumerable.Where<UnityEngine.Transform>(source:  val_8, predicate:  new System.Func<UnityEngine.Transform, System.Boolean>(object:  val_6, method:  System.Boolean WeaponTargetDetectorBase.丆丂丁丐丁丑不丐丆::丂丗专上丗万丐且丒(UnityEngine.Transform 三丟东丕丄丄下下丑))));
        System.Comparison<UnityEngine.Transform> val_20 = null;
        val_23 = val_20;
        val_20 = new System.Comparison<UnityEngine.Transform>(object:  val_6, method:  System.Int32 WeaponTargetDetectorBase.丆丂丁丐丁丑不丐丆::丆丌丑丕一丘丞且丒(UnityEngine.Transform 丁下丗七丟丗丞丁丐, UnityEngine.Transform 专丟丗丗丈丅丙七三));
        val_29 = public System.Void System.Collections.Generic.List<UnityEngine.Transform>::Sort(System.Comparison<T> comparison);
        val_26.Sort(comparison:  val_20);
        label_15:
        if(this.丝且与丝丒丟万丁专.targetsCount == 1)
        {
                if(val_26.Count >= 1)
        {
                val_29 = public UnityEngine.Transform System.Collections.Generic.List<UnityEngine.Transform>::get_Item(int index);
            UnityEngine.Transform val_22 = val_26.Item[0];
        }
        
        }
        
        val_24 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_24;
        return (bool)val_24;
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
