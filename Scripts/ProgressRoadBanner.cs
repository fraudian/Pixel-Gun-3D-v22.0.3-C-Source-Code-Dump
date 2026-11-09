using UnityEngine;
internal sealed class ProgressRoadBanner : BannerWindowWithBack, 丑且丆万丏丝丘丙丟
{
    // Fields
    private static System.Action 业丙丘丈七不下下丐;
    private ProgressRoadView progressRoadView;
    private UnityEngine.GameObject backButton;
    private UnityEngine.GameObject continueButtonForTutor;
    private bool 万丞一业丈丂世丙世;
    
    // Methods
    internal static void 万专丆且七丈业丅丁(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Combine(a:  ProgressRoadBanner.业丙丘丈七不下下丐, b:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    internal static void 丟丑丟丑丂丄丕丆丌(System.Action 丙业与丙丗丝不丈东)
    {
        System.Delegate val_3 = System.Delegate.Remove(source:  ProgressRoadBanner.业丙丘丈七不下下丐, value:  丙业与丙丗丝不丈东);
        if(val_3 == null)
        {
                return;
        }
        
        if(null == null)
        {
                return;
        }
        
        val_3 = 0;
    }
    protected override void OnEnable()
    {
        this.OnEnable();
        this.progressRoadView.丅下丙丐下丝丈丑不(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProgressRoadBanner::丈且下丛且上丘万丕()));
        ProgressRoadView.万专与丗丕丈一丒世(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProgressRoadBanner::丒丏丌七丗一丂丗丟()));
    }
    private void 丒丏丌七丗一丂丗丟()
    {
    
    }
    protected override void OnDisable()
    {
        ProgressRoadView.丟丈丆丁丄七且丏丆(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProgressRoadBanner::丒丏丌七丗一丂丗丟()));
        this.OnDisable();
        this.progressRoadView.丏丐上丗丏丛丝丈专(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ProgressRoadBanner::丈且下丛且上丘万丕()));
    }
    public override void Show()
    {
        int val_3;
        int val_5;
        this.Show();
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
        PGCompany.丆下丐丁丏世丈上丟 val_2 = this.丑丐丙丄丅世世丑丒();
        PGCompany.丆下丐丁丏世丈上丟 val_4 = this.丑丐丙丄丅世世丑丒();
        this.progressRoadView.丈且东丑丂且万丒丅(丂世且丙丅丘不七丑:  val_3, 丏丆丅且上丅上丌丘:  val_5);
        if(ProgressRoadBanner.业丙丘丈七不下下丐 == null)
        {
                return;
        }
        
        ProgressRoadBanner.业丙丘丈七不下下丐.Invoke();
    }
    public override void Back()
    {
        if(this.万丞一业丈丂世丙世 != false)
        {
                if(PGCompany.丁东丌世与丕东丆上.丑丞丙丕丛丏丅丁七() != false)
        {
                PGCompany.丕丝下丁七东丄三丑.丗与丆丏丝下丅丕世(丈丁下不丐丑丈丈业:  0, 专上且丗丑丌丟丈丄:  false, 丁丟丑丆三丆业一丅:  0);
        }
        else
        {
                if(PGCompany.丁东丌世与丕东丆上.丝丟三且一丝下丞丕() != false)
        {
                PGCompany.丕丝下丁七东丄三丑.世丂丈丅丘丂业与专();
        }
        
        }
        
        }
        
        this.Back();
        this.HideSelf();
        PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
    }
    private void 丈且下丛且上丘万丕()
    {
        goto typeof(ProgressRoadBanner).__il2cppRuntimeField_218;
    }
    public void U_ContinueTutor()
    {
        PGCompany.丕丝下丁七东丄三丑.丗与丆丏丝下丅丕世(丈丁下不丐丑丈丈业:  0, 专上且丗丑丌丟丈丄:  false, 丁丟丑丆三丆业一丅:  0);
        goto typeof(ProgressRoadBanner).__il2cppRuntimeField_218;
    }
    public void TurnOn()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  true);
    }
    public void TurnOff()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  false);
    }
    public bool IsVisibleLobbyMenu()
    {
        return false;
    }
    public bool IsEnabledLobbyCamera()
    {
        return false;
    }
    public float GetDelayTurnOff()
    {
        return 0f;
    }
    protected override void 丆丅下丆丂丏丙丌丛()
    {
        this.万丞一业丈丂世丙世 = false;
        this.丆丅下丆丂丏丙丌丛();
    }
    public ProgressRoadBanner()
    {
        this.万丞一业丈丂世丙世 = true;
    }

}
