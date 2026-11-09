using UnityEngine;
internal sealed class GuiApplyersGroupActivator : PGBehaviour
{
    // Fields
    public GuiApplyersGroupActivator.丏三业丕丈丄丂丑东 selfSetupTrigger;
    public 东七丏不东丏丘丛下 category;
    private GuiApplyersGroup 三丙丕丆丕丈不丕万;
    
    // Properties
    public GuiApplyersGroup 丕丒丙东丌丞丐丄丈 { get; }
    
    // Methods
    public GuiApplyersGroup get_ApplyersGroup()
    {
        GuiApplyersGroup val_3;
        if(this.三丙丕丆丕丈不丕万 == 0)
        {
                this.三丙丕丆丕丈不丕万 = this.GetComponent<GuiApplyersGroup>();
            return val_3;
        }
        
        val_3 = this.三丙丕丆丕丈不丕万;
        return val_3;
    }
    public bool CanSetup()
    {
        var val_4;
        if(this.ApplyersGroup != 0)
        {
                var val_3 = (this.category != 0) ? 1 : 0;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    private void Start()
    {
        var val_11;
        if(this.selfSetupTrigger != 1)
        {
                return;
        }
        
        if(this.CanSetup() == false)
        {
                return;
        }
        
        GuiApplyersGroup val_2 = this.ApplyersGroup;
        string val_3 = this.category.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        mem2[0] = null;
        string val_4 = 下下丈一业上万丏丕.丝丞丒七丞丕丏七丐(七丆丒与丗丌丄且丂:  null);
        val_11 = ???;
        goto typeof(GuiApplyersGroup).__il2cppRuntimeField_168;
    }
    private void OnEnable()
    {
        var val_11;
        if(this.selfSetupTrigger != 2)
        {
                return;
        }
        
        if(this.CanSetup() == false)
        {
                return;
        }
        
        GuiApplyersGroup val_2 = this.ApplyersGroup;
        string val_3 = this.category.ToString();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        mem2[0] = null;
        string val_4 = 下下丈一业上万丏丕.丝丞丒七丞丕丏七丐(七丆丒与丗丌丄且丂:  null);
        val_11 = ???;
        goto typeof(GuiApplyersGroup).__il2cppRuntimeField_168;
    }
    public GuiApplyersGroupActivator()
    {
    
    }

}
