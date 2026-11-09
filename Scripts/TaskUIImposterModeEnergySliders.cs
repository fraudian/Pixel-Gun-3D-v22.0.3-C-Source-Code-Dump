using UnityEngine;
internal sealed class TaskUIImposterModeEnergySliders : TaskUIImposterModeAbstract
{
    // Fields
    private WidgetLayout slidersLayout;
    private WidgetLayoutConstrained widgetLayoutConstrained;
    private MiniPoolMonoBehaviour pool;
    private System.Collections.Generic.List<ImposterModeEnergySlider> 丕丐丗七一丈丝丆东;
    public System.Collections.Generic.List<string> roomLocals;
    
    // Methods
    protected override void 丗下丗丕丂丈万七丛()
    {
        this.丘丌万丏丅丌丐丏丑();
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
        List.Enumerator<T> val_1 = this.丕丐丗七一丈丝丆东.GetEnumerator();
        label_4:
        if(((-1384774856) & 1) == 0)
        {
            goto label_2;
        }
        
        0.丐丏七丌丕丗业且上().丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  0.5f);
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丐丅丂丆专三丅丙丑(ImposterModeEnergySlider 丆且丞丟丛丗万一世)
    {
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "OnSliderValueChaged");
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "slider: "("slider: ") + 丆且丞丟丛丗万一世._roomLocalization);
        丆丟丟三丗东一丆三.上世且且丆下一丌不(丕丗丘丑丛与丑业丒:  "task: "("task: ") + val_2.roomLocalization);
        if(丆且丞丟丛丗万一世.世三丞丅丑丌丈丈一() < 1f)
        {
                return;
        }
        
        ImposterRoomLocalization val_5 = RoomLocalization.RoomLocalization;
        if((System.String.op_Equality(a:  丆且丞丟丛丗万一世._roomLocalization, b:  val_5.roomLocalization)) == false)
        {
                return;
        }
        
        this.万丏丛东下丝下丟丕();
    }
    private void 丘丌万丏丅丌丐丏丑()
    {
        var val_3;
        var val_16;
        System.Action<ImposterModeEnergySlider> val_19;
        var val_20;
        System.Action<ImposterModeEnergySlider> val_21;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.pool.example, 丏业丟一东丂东丘丛:  false);
        List.Enumerator<T> val_1 = this.丕丐丗七一丈丝丆东.GetEnumerator();
        label_10:
        if(((-1384373488) & 1) == 0)
        {
            goto label_5;
        }
        
        System.Action<ImposterModeEnergySlider> val_5 = new System.Action<ImposterModeEnergySlider>(object:  this, method:  System.Void TaskUIImposterModeEnergySliders::丐丅丂丆专三丅丙丑(ImposterModeEnergySlider 丆且丞丟丛丗万一世));
        if(((System.Delegate.Remove(source:  X21, value:  null)) != null) && (null != null))
        {
                val_16 = 0;
        }
        
        mem2[0] = val_16;
        this.pool.Return(万且万且丑丗且丌丆:  val_3.丐丏七丌丕丗业且上());
        goto label_10;
        label_5:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.丕丐丗七一丈丝丆东.Clear();
        this.slidersLayout.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        List.Enumerator<T> val_8 = this.roomLocals.GetEnumerator();
        label_37:
        if(((-1384373520) & 1) == 0)
        {
            goto label_24;
        }
        
        ImposterModeEnergySlider val_10 = this.pool.Get<ImposterModeEnergySlider>();
        val_10.丈且东丑丂且万丒丅(万不且且丛丆东丒业:  X22, 世丈丘丌丕三丐三丅:  val_3.丐丏七丌丕丗业且上());
        val_10.丙丏不三丗三丙丈与(丙业与丙丗丝不丈东:  0.5f);
        System.Action<ImposterModeEnergySlider> val_11 = new System.Action<ImposterModeEnergySlider>(object:  this, method:  System.Void TaskUIImposterModeEnergySliders::丐丅丂丆专三丅丙丑(ImposterModeEnergySlider 丆且丞丟丛丗万一世));
        val_19 = System.Delegate.Remove(source:  val_10.七丂丌丐丛丏丌丑丞, value:  null);
        val_20 = null;
        if((val_19 != null) && (null != val_20))
        {
                val_20 = null;
            val_19 = 0;
        }
        
        val_10.七丂丌丐丛丏丌丑丞 = val_19;
        System.Action<ImposterModeEnergySlider> val_13 = new System.Action<ImposterModeEnergySlider>(object:  this, method:  System.Void TaskUIImposterModeEnergySliders::丐丅丂丆专三丅丙丑(ImposterModeEnergySlider 丆且丞丟丛丗万一世));
        if(((System.Delegate.Combine(a:  val_19, b:  null)) != null) && (null != null))
        {
                val_21 = 0;
        }
        
        val_10.七丂丌丐丛丏丌丑丞 = val_21;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_10, 丏业丟一东丂东丘丛:  true);
        this.丕丐丗七一丈丝丆东.Add(item:  val_10);
        this.slidersLayout.AddElement(丅丆东丏丙丝丅丆丟:  val_10);
        goto label_37;
        label_24:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.slidersLayout.Reposition();
        this.widgetLayoutConstrained.Reposition();
    }
    public TaskUIImposterModeEnergySliders()
    {
        this.丕丐丗七一丈丝丆东 = new System.Collections.Generic.List<ImposterModeEnergySlider>();
        this.roomLocals = new System.Collections.Generic.List<System.String>();
        this = new PGBehaviour();
    }

}
