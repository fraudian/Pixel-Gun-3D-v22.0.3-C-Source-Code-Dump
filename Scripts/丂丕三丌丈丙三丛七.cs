using UnityEngine;
private sealed class TaskUIImposterModeRepeatSequence.丂丕三丌丈丙三丛七 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public TaskUIImposterModeRepeatSequence 丝且与丝丒丟万丁专;
    public int 丞世不丒下上上丝丑;
    private System.Collections.Generic.List.Enumerator<int> 与业丕业业业丌丟丐;
    private int 丗丁与丂且丄丈七丂;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public TaskUIImposterModeRepeatSequence.丂丕三丌丈丙三丛七(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
        int val_1 = this.丗丏丅丕丆世丁专丟;
        val_1 = val_1 + 3;
        if(val_1 > 5)
        {
                return;
        }
        
        val_1 = 1 << val_1;
        val_1 = val_1 & 49;
        if(val_1 == 0)
        {
                return;
        }
        
        this.一世丕丕业且且丅丌();
    }
    private bool MoveNext()
    {
        var val_7;
        List.Enumerator<System.Int32> val_8;
        List.Enumerator<System.Int32> val_13;
        int val_14;
        System.Collections.Generic.List<System.Collections.Generic.List<System.Int32>> val_15;
        var val_16;
        System.Action<TaskUIImposterNumButton> val_18;
        var val_19;
        if(this.丗丏丅丕丆世丁专丟 == 0)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_2;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 2)
        {
            goto label_12;
        }
        
        val_13 = this.与业丕业业业丌丟丐;
        this.丗丏丅丕丆世丁专丟 = -3;
        goto label_4;
        label_2:
        this.丗丏丅丕丆世丁专丟 = -3;
        val_14 = this.丗丁与丂且丄丈七丂;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专.丂丅丕丂丅丄七丅丅.Item[val_14], 丏业丟一东丂东丘丛:  true);
        new UnityEngine.WaitForSecondsRealtime() = new UnityEngine.WaitForSecondsRealtime(time:  this.丝且与丝丒丟万丁专.showTime);
        this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime();
        this.丗丏丅丕丆世丁专丟 = 2;
        val_15 = 1;
        return (bool)val_15;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        val_15 = this.丝且与丝丒丟万丁专.丟东不万丌丞丘丈万;
        if(val_15 == null)
        {
                return (bool)val_15;
        }
        
        if(val_15.Count <= this.丞世不丒下上上丝丑)
        {
            goto label_12;
        }
        
        val_16 = null;
        val_16 = null;
        val_18 = TaskUIImposterModeRepeatSequence.<>c.<>9__31_0;
        if(val_18 == null)
        {
                val_18 = null;
            val_18 = new System.Action<TaskUIImposterNumButton>(object:  TaskUIImposterModeRepeatSequence.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TaskUIImposterModeRepeatSequence.<>c::丘七丝丆丏丐三丏丆(TaskUIImposterNumButton 三丟东丕丄丄下下丑));
            TaskUIImposterModeRepeatSequence.<>c.<>9__31_0 = val_18;
        }
        
        this.丝且与丝丒丟万丁专.下丌东丈丞丈丐丄七.ForEach(action:  null);
        mem2[0] = 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<TaskUIImposterNumButton>(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专.丂丅丕丂丅丄七丅丅, 丏业丟一东丂东丘丛:  false);
        val_14 = this.丞世不丒下上上丝丑;
        List.Enumerator<T> val_6 = this.丝且与丝丒丟万丁专.丟东不万丌丞丘丈万.Item[val_14].GetEnumerator();
        val_13 = this.与业丕业业业丌丟丐;
        mem[1152921537593627568] = val_7;
        this.丗丏丅丕丆世丁专丟 = -3;
        this.与业丕业业业丌丟丐 = val_8;
        label_4:
        if((val_13 & 1) != 0)
        {
                this.丗丁与丂且丄丈七丂 = val_13.丙东专丂世丈丏丁丂();
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<TaskUIImposterNumButton>(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专.丂丅丕丂丅丄七丅丅, 丏业丟一东丂东丘丛:  false);
            new UnityEngine.WaitForSecondsRealtime() = new UnityEngine.WaitForSecondsRealtime(time:  this.丝且与丝丒丟万丁专.hideTime);
            val_15 = 1;
            this.丒上七丌业七丟与丐 = new UnityEngine.WaitForSecondsRealtime();
            this.丗丏丅丕丆世丁专丟 = val_15;
            return (bool)val_15;
        }
        
        this.一世丕丕业且且丅丌();
        mem2[0] = 0;
        mem2[0] = 0;
        mem2[0] = 0;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上<TaskUIImposterNumButton>(不丗上三丛丒上东丑:  this.丝且与丝丒丟万丁专.丂丅丕丂丅丄七丅丅, 丏业丟一东丂东丘丛:  false);
        mem2[0] = 0;
        val_19 = null;
        val_19 = null;
        val_14 = TaskUIImposterModeRepeatSequence.<>c.<>9__31_1;
        if(val_14 == null)
        {
            goto label_33;
        }
        
        if(this.丝且与丝丒丟万丁专.下丌东丈丞丈丐丄七 != null)
        {
            goto label_38;
        }
        
        goto label_35;
        label_33:
        val_14 = null;
        val_14 = new System.Action<TaskUIImposterNumButton>(object:  TaskUIImposterModeRepeatSequence.<>c.__il2cppRuntimeField_static_fields, method:  System.Void TaskUIImposterModeRepeatSequence.<>c::世丅不世业且下下丄(TaskUIImposterNumButton 三丟东丕丄丄下下丑));
        TaskUIImposterModeRepeatSequence.<>c.<>9__31_1 = val_14;
        if(this.丝且与丝丒丟万丁专.下丌东丈丞丈丐丄七 != null)
        {
            goto label_38;
        }
        
        label_35:
        label_38:
        this.丝且与丝丒丟万丁专.下丌东丈丞丈丐丄七.ForEach(action:  null);
        label_12:
        val_15 = 0;
        return (bool)val_15;
    }
    private void 一世丕丕业且且丅丌()
    {
        this.丗丏丅丕丆世丁专丟 = 0;
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  this.与业丕业业业丌丟丐);
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
