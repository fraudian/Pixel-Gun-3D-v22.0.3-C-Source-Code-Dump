using UnityEngine;
internal sealed class MainStoreButton : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject state_Enabled;
    private UnityEngine.GameObject state_Disabled;
    private UnityEngine.GameObject tag_x10;
    private UnityEngine.GameObject tag_x3;
    private UnityEngine.GameObject tag_New;
    private UnityEngine.GameObject tag_Free;
    private GuiApplyersGroup guiApplyersGroup;
    private TagSystem.三与下丘七丘丌丏丄 丛丏丂丏丏三丆丕丅;
    private static string <丌丟丂下丙世丅七丙>k__BackingField;
    
    // Properties
    internal static string 丄不丌丕丌丁丕丅丛 { get; set; }
    
    // Methods
    internal static string 丐七东丒世丞丅万丟()
    {
        return (string)MainStoreButton.<丌丟丂下丙世丅七丙>k__BackingField;
    }
    private static void 业与丛丟丛丟丄丞且(string 丙业与丙丗丝不丈东)
    {
        MainStoreButton.<丌丟丂下丙世丅七丙>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void OnDestroy()
    {
        MainStoreButton.<丌丟丂下丙世丅七丙>k__BackingField = 0;
    }
    private void OnEnable()
    {
        PGCompany.MainStore.万丝丞东丘丒丌七专.世不丅丆丁下丁丌东(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void MainStoreButton::丘丙丕丟丐丑不上丑(string 不丝丐与丑一丈丌世)));
        MainStoreView.东丑业丒且业丌丝丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainStoreButton::丝一丅丆三东丂丞七()));
        this.丝一丅丆三东丂丞七();
    }
    private void OnDisable()
    {
        PGCompany.MainStore.万丝丞东丘丒丌七专.丗与下丕三专业丟业(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void MainStoreButton::丘丙丕丟丐丑不上丑(string 不丝丐与丑一丈丌世)));
        MainStoreView.丝七一不与不丙丕丈(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void MainStoreButton::丝一丅丆三东丂丞七()));
    }
    private void 丘丙丕丟丐丑不上丑(string 不丝丐与丑一丈丌世)
    {
        this.丝一丅丆三东丂丞七();
    }
    private void 丝一丅丆三东丂丞七()
    {
        UnityEngine.GameObject val_19;
        var val_20;
        TagSystem.三与下丘七丘丌丏丄 val_21;
        var val_22;
        var val_23;
        UnityEngine.GameObject val_24;
        GuiApplyersGroup val_25;
        if(与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆() != false)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Enabled, 丏业丟一东丂东丘丛:  false);
            val_19 = this.state_Disabled;
            val_20 = 1;
        }
        else
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.state_Enabled, 丏业丟一东丂东丘丛:  true);
            val_19 = this.state_Disabled;
            val_20 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_19, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.tag_x10, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.tag_x3, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.tag_New, 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.tag_Free, 丏业丟一东丂东丘丛:  false);
        TagSystem.三与下丘七丘丌丏丄 val_3 = this.丛丏丂丏丏三丆丕丅;
        val_3.与上丒丆丟与丘与丑();
        val_21 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世();
        val_21.丂丆业丌世丒丙七丗(丏万且丈丙丁丁且世: ref  val_3, 丛丝业万丌丏世与丑:  0);
        MainStoreButton.<丌丟丂下丙世丅七丙>k__BackingField = 0;
        if(val_3 == null)
        {
            goto label_30;
        }
        
        val_21 = "X10";
        if((val_3.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "X10")) == false)
        {
            goto label_15;
        }
        
        MainStoreButton.<丌丟丂下丙世丅七丙>k__BackingField = "X10";
        val_23 = null;
        val_24 = this.tag_x10;
        goto label_33;
        label_15:
        val_21 = val_3;
        if((val_21.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "free")) == false)
        {
            goto label_20;
        }
        
        MainStoreButton.<丌丟丂下丙世丅七丙>k__BackingField = "free";
        val_23 = null;
        val_24 = this.tag_Free;
        goto label_33;
        label_20:
        val_21 = val_3;
        if((val_21.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "new")) == false)
        {
            goto label_25;
        }
        
        MainStoreButton.<丌丟丂下丙世丅七丙>k__BackingField = "new";
        val_23 = null;
        val_24 = this.tag_New;
        goto label_33;
        label_25:
        val_21 = "X3";
        if((val_3.丆丁七丄专下丗丘一(丆万一不丌且东丐丐:  "X3")) == false)
        {
            goto label_30;
        }
        
        MainStoreButton.<丌丟丂下丙世丅七丙>k__BackingField = "X3";
        val_23 = null;
        val_24 = this.tag_x3;
        label_33:
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  val_24, 丏业丟一东丂东丘丛:  true);
        label_30:
        val_25 = this.guiApplyersGroup;
        if(val_25 == null)
        {
                return;
        }
        
        string val_9 = PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().七且丈专三丟丟丘东();
        val_25 = ???;
        val_21 = ???;
        val_22 = ???;
        goto typeof(GuiApplyersGroup).__il2cppRuntimeField_168;
    }
    public void U_GoToStore()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        val_4 = null;
        val_4 = null;
        BankView.丗一专业丘丙丟丄万 = PGCompany.Analytics.丂与丏丕一丒与丁丙.丞上一丞丁丂丝丐丞;
        PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丝万万丁丌丂万丆丆(丞且丌三三万七丛万:  PGCompany.丁东丌世与丕东丆上.丁且丅丕专与丅且丄(丟丘不丒上丐丗与丅:  0), 万丆丛世丈上丕东丗:  0, 世丁丙世丄一万丆三:  PGCompany.Analytics.丂与丏丕一丒与丁丙.丞上一丞丁丂丝丐丞, 丙丙专丝专上丅丛丏:  false, 上不丗业一丛丈丞且:  0, 且下丒丒丑与不丛业:  "Default", 与东万丕丆丆且丕丕:  0);
    }
    public MainStoreButton()
    {
        this.丛丏丂丏丏三丆丕丅 = new TagSystem.三与下丘七丘丌丏丄();
    }

}
