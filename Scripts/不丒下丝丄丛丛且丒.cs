using UnityEngine;
private sealed class MainMenuController.不丒下丝丄丛丛且丒 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public MainMenuController 丝且与丝丒丟万丁专;
    private bool 丐一丑上丂且不丐七;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public MainMenuController.不丒下丝丄丛丛且丒(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_198;
        string val_200;
        var val_202;
        var val_203;
        int val_207;
        int val_211;
        val_198 = this;
        string val_152 = 0;
        if(this.丗丏丅丕丆世丁专丟 > 13)
        {
            goto label_169;
        }
        
        var val_197 = 106020472 + (this.丗丏丅丕丆世丁专丟) << 2;
        val_197 = val_197 + 106020472;
        goto (106020472 + (this.丗丏丅丕丆世丁专丟) << 2 + 106020472);
        label_169:
        val_211 = 0;
        return (bool)val_211;
        label_426:
        if((497838752 & 1) == 0)
        {
            goto label_417;
        }
        
        string val_129 = 0.丐丏七丌丕丗业且上();
        if(val_129 == 0)
        {
            goto label_426;
        }
        
        Rilisoft.ButtonHandler val_131 = val_129.GetComponent<Rilisoft.ButtonHandler>();
        if(val_131 == 0)
        {
            goto label_426;
        }
        
        new System.EventHandler() = new System.EventHandler(object:  1152921505080860672, method:  System.Void MainMenuController::丞丒丅东丞丄丝丄丒(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
        val_131.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler());
        goto label_426;
        label_417:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_203 = 1152921505034588160;
        if(ClansVisitController.__il2cppRuntimeField_nestedTypes != 0)
        {
                UnityEngine.Renderer val_180 = ClansVisitController.__il2cppRuntimeField_nestedTypes + 160.GetComponent<UnityEngine.Renderer>();
            if(val_180 != 0)
        {
                val_180.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  ClansVisitController val_177 = Rilisoft.Singleton<ClansVisitController>.Instance, method:  System.Void MainMenuController::万丂丗专七丅丒丕世(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        if(BankController.丑七不且上丗丁一世() != 0)
        {
                UnityEngine.Object.DontDestroyOnLoad(target:  BankController.丑七不且上丗丁一世().transform.root.gameObject);
        }
        else
        {
                UnityEngine.Debug.LogWarning(message:  "bankController == null");
        }
        
        System.Action<System.String> val_189 = null;
        val_200 = val_189;
        val_189 = new System.Action<System.String>(object:  val_177, method:  public System.Void MainMenuController::HandlePromoActionClicked(string 丒东业不丐丑丕丄丆));
        PromoActionClick.丘下一丟万专丙丑万(丙业与丙丗丝不丈东:  val_189);
        AppsMenu.且丝专丙且丒丝下丑(下业七不丑丂丏丟东:  "Start 961");
        val_202 = null;
        val_202 = null;
        val_177.丈丑丏下七世丆不万(不丟丗丏丛丕不丁丌:  0, 丗丛不丁丑专专丂且:  0);
        val_177.gameObject.SetActive(value:  false);
        this.丒上七丌业七丟与丐 = 0;
        val_207 = 4;
        this.丗丏丅丕丆世丁专丟 = ;
        val_211 = 1;
        return (bool)val_211;
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
