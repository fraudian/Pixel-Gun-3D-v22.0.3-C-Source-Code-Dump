using UnityEngine;
internal sealed class SettingsTabAccount : PGBehaviour
{
    // Fields
    public UIButton syncButton;
    public UILabel syncButtonLabel;
    
    // Methods
    private void Start()
    {
        this.东一三一万且丕世不();
        this.丘上丐世丆丑且丞丒();
        丟丏下丂七三下丗丕.丏丈丏丗万七丄与上(丕下丛丞丟丈丄丒丗:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SettingsTabAccount::不丁丅丒丗丁专丌三()));
    }
    private void 东一三一万且丕世不()
    {
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.syncButton, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabAccount.{0} is null", arg0:  "syncButton"));
        丛丅丄下丆丏上上世.东七丌且丝丘且丒丑(丝三丁东丈丒世丅业:  this.syncButtonLabel, 丄丙下丝丛丒七丂丘:  System.String.Format(format:  "SettingsTabAccount.{0} is null", arg0:  "syncButtonLabel"));
    }
    private void 丘上丐世丆丑且丞丒()
    {
        IntPtr val_17;
        if((UnityEngine.Object.op_Implicit(exists:  this.syncButton)) == false)
        {
                return;
        }
        
        this.syncButton.gameObject.SetActive(value:  (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1);
        this.不丁丅丒丗丁专丌三();
        if(UnityEngine.Application.isEditor == false)
        {
            goto label_9;
        }
        
        label_21:
        this.syncButton.gameObject.SetActive(value:  (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1);
        val_17 = 1152921538962259616;
        goto label_14;
        label_9:
        if(UnityEngine.Application.platform != 8)
        {
            goto label_15;
        }
        
        this.syncButton.gameObject.SetActive(value:  (~与丂丏丛丞丞丒丟丄.丙丞业丄丏丒一丈丆()) & 1);
        System.EventHandler val_14 = null;
        val_17 = 1152921538962277024;
        label_14:
        val_14 = new System.EventHandler(object:  this, method:  val_17);
        this.syncButton.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  val_14);
        return;
        label_15:
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 11)
        {
            goto label_21;
        }
    
    }
    public void U_ShowPrivatePolicy()
    {
        SettingsTabAccount.丄丈丄丗丈七万丙万();
    }
    internal static void 丄丈丄丗丈七万丙万()
    {
        null = null;
        UnityEngine.Application.OpenURL(url:  与丂丏丛丞丞丒丟丄.不丝东丑丐与丂丙丆);
    }
    public void U_ShowTermsOfUse()
    {
        SettingsTabAccount.一丝丈一丂七且丘世();
    }
    internal static void 一丝丈一丂七且丘世()
    {
        null = null;
        UnityEngine.Application.OpenURL(url:  与丂丏丛丞丞丒丟丄.丙且丛丄丈丗上丙丄);
    }
    private void 东且丅东丞丕丗东丕(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(UnityEngine.Application.isEditor != false)
        {
                UnityEngine.Debug.Log(message:  "[Restore] button clicked.");
        }
        
        UnityEngine.Coroutine val_4 = CoroutineRunner.Instance.StartCoroutine(routine:  SettingsTabAccount.丝下且丁丅丛丌丞七());
    }
    private static System.Collections.IEnumerator 丝下且丁丅丛丌丞七()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new SettingsTabAccount.丁丂丟丅丗丞丛世丁();
    }
    internal static void 丄丕万丁丗丆丒丅不()
    {
    
    }
    private void 东一丄丐与丅东上丝(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        PGCompany.Analytics.一业丗丆世世上丁且.三丙专业丌丏丛丌与(丆丛丑世下一丐且丕:  PGCompany.Analytics.上丒丞上丌丌丘丛一.丑七不且上丗丁一世());
        UnityEngine.Coroutine val_4 = CoroutineRunner.Instance.StartCoroutine(routine:  this.万丝下丏丗一丂七下());
    }
    private System.Collections.IEnumerator 万丝下丏丗一丂七下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new SettingsTabAccount.丆丁丕东丏丟丝三东();
    }
    private void 不丁丅丒丗丁专丌三()
    {
        UILabel val_5;
        string val_6;
        if((UnityEngine.Object.op_Implicit(exists:  this.syncButtonLabel)) == false)
        {
                return;
        }
        
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() == 8)
        {
                val_5 = this.syncButtonLabel;
            val_6 = "Key_0080";
        }
        else
        {
                if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 11)
        {
                return;
        }
        
            val_5 = this.syncButtonLabel;
            val_6 = "Key_0935";
        }
        
        val_5.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_6);
    }
    private void OnDestroy()
    {
        丟丏下丂七三下丗丕.七丛七丏业丘丝丗七(丛一丄丏且丌丂七丐:  new 丗丈下丕丟丟丙七丞.不丆丟丒丞万东不丏(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void SettingsTabAccount::不丁丅丒丗丁专丌三()));
    }
    public SettingsTabAccount()
    {
    
    }

}
