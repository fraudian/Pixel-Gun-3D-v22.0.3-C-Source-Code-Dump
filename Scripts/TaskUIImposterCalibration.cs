using UnityEngine;
internal class TaskUIImposterCalibration : TaskUIImposterModeAbstract
{
    // Fields
    private System.Collections.Generic.List<TaskUIImposter.Calibrate.ControlGroup> _controls;
    private int 七丝万丝丐丅下且丗;
    private System.Random 丂丆且一丛丙丑七丒;
    
    // Methods
    protected override void OnEnable()
    {
        this.OnEnable();
        TaskUIImposter.Calibrate.ControlGroup.一东丞丗业丁丟不业(丙业与丙丗丝不丈东:  new System.Action<TaskUIImposter.Calibrate.ControlGroup>(object:  this, method:  System.Void TaskUIImposterCalibration::丑世一不丝与丈丑一(TaskUIImposter.Calibrate.ControlGroup 丞丏丐丑丆上丐丒丆)));
    }
    protected override void OnDisable()
    {
        TaskUIImposter.Calibrate.ControlGroup.上业丙世不丁丏下丒(丙业与丙丗丝不丈东:  new System.Action<TaskUIImposter.Calibrate.ControlGroup>(object:  this, method:  System.Void TaskUIImposterCalibration::丑世一不丝与丈丑一(TaskUIImposter.Calibrate.ControlGroup 丞丏丐丑丆上丐丒丆)));
    }
    private void 丑世一不丝与丈丑一(TaskUIImposter.Calibrate.ControlGroup 丞丏丐丑丆上丐丒丆)
    {
        var val_12;
        var val_13;
        val_12 = this;
        if(丞丏丐丑丆上丐丒丆 == 0)
        {
                return;
        }
        
        val_13 = this._controls.IndexOf(item:  丞丏丐丑丆上丐丒丆);
        if(val_13 != this.七丝万丝丐丅下且丗)
        {
                return;
        }
        
        if(丞丏丐丑丆上丐丒丆.且丈丕丆丁丞一丙万 <= 0.4f)
        {
            goto label_7;
        }
        
        丞丏丐丑丆上丐丒丆.<丑万丕丆世丄丒丂丑>k__BackingField = true;
        if(val_13 != (this._controls.Count - 1))
        {
            goto label_9;
        }
        
        this.万丏丛东下丝下丟丕();
        return;
        label_7:
        val_12 = ???;
        val_13 = ???;
        goto typeof(TaskUIImposterCalibration).__il2cppRuntimeField_178;
        label_9:
        TaskUIImposter.Calibrate.ControlGroup val_6 = val_12 + 96.Item[val_13 + 1];
        val_6.丘丄丆不丛丗上三上 = true;
        var val_12 = val_12 + 104;
        val_12 = val_12 + 1;
        mem2[0] = val_12;
    }
    protected override void 丗下丗丕丂丈万七丛()
    {
        goto typeof(TaskUIImposterCalibration).__il2cppRuntimeField_178;
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
        var val_5;
        if(this.丂丆且一丛丙丑七丒 == null)
        {
                this.丂丆且一丛丙丑七丒 = new System.Random(Seed:  丐丕不丅三专万丕丗());
        }
        
        List.Enumerator<T> val_3 = this._controls.GetEnumerator();
        label_12:
        if(((-1339606496) & 1) == 0)
        {
            goto label_4;
        }
        
        string val_6 = val_5.丐丏七丌丕丗业且上();
        if(val_6 == 0)
        {
            goto label_12;
        }
        
        val_6.丗下丗丕丂丈万七丛(丌下七丒丐不东丆不:  (float)this.丂丆且一丛丙丑七丒);
        if(val_6 != null)
        {
                mem2[0] = 0;
        }
        else
        {
                mem2[0] = 0;
        }
        
        val_6.Reset();
        goto label_12;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        TaskUIImposter.Calibrate.ControlGroup val_8 = this._controls.Item[0];
        val_8.丘丄丆不丛丗上三上 = true;
        this.七丝万丝丐丅下且丗 = 0;
    }
    public TaskUIImposterCalibration()
    {
        this.七丝万丝丐丅下且丗 = 0;
        val_1 = new PGBehaviour();
    }

}
