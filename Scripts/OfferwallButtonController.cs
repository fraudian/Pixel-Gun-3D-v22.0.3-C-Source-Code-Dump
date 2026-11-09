using UnityEngine;
internal sealed class OfferwallButtonController : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject offerwallButton;
    
    // Properties
    private static bool 丂与丑三丐丌丐丘丁 { get; }
    private static bool 丅业东万丌丕上丌丄 { get; }
    
    // Methods
    private static bool 世丈且业丆丑丏丐一()
    {
        return 与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘();
    }
    private static bool 丈丐丞丐上丑且丕万()
    {
        return PGCompany.OfferwallController.专且丗丅丙丆业丈丁();
    }
    private void OnEnable()
    {
        System.Action val_4;
        if(((System.Delegate.Combine(a:  PGCompany.OfferwallController.丒丈东上专专丐一丄, b:  new System.Action(object:  this, method:  System.Void OfferwallButtonController::丝一丅丆三东丂丞七()))) != null) && (null != null))
        {
                val_4 = 0;
        }
        
        PGCompany.OfferwallController.丒丈东上专专丐一丄 = val_4;
        this.丝一丅丆三东丂丞七();
    }
    private void OnDisable()
    {
        System.Action val_4;
        if(((System.Delegate.Remove(source:  PGCompany.OfferwallController.丒丈东上专专丐一丄, value:  new System.Action(object:  this, method:  System.Void OfferwallButtonController::丝一丅丆三东丂丞七()))) != null) && (null != null))
        {
                val_4 = 0;
        }
        
        PGCompany.OfferwallController.丒丈东上专专丐一丄 = val_4;
    }
    private void 丝一丅丆三东丂丞七()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.offerwallButton, 丏业丟一东丂东丘丛:  PGCompany.OfferwallController.专且丗丅丙丆业丈丁());
    }
    public void U_OfferwallButtonPressed()
    {
        if(OfferwallButtonController.世丈且业丆丑丏丐一() != false)
        {
                UnityEngine.Debug.Log(message:  "[OfferwallButtonController.U_OfferwallButtonPressed]");
        }
        
        PGCompany.OfferwallController.丛不丗三丈丘与与丝();
    }
    public OfferwallButtonController()
    {
    
    }

}
