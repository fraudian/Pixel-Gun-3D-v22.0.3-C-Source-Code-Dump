using UnityEngine;
internal sealed class PixelPassBanner : BannerWindowWithBack, 丑且丆万丏丝丘丙丟
{
    // Fields
    private PixelPassView pixelPassView;
    
    // Methods
    protected override void OnEnable()
    {
        this.OnEnable();
        new System.Action() = new System.Action(object:  this, method:  typeof(PixelPassBanner).__il2cppRuntimeField_220);
        this.pixelPassView.丞丌丑丐丑丆上丗丅(丙业与丙丗丝不丈东:  new System.Action());
    }
    protected override void OnDisable()
    {
        this.OnDisable();
        new System.Action() = new System.Action(object:  this, method:  typeof(PixelPassBanner).__il2cppRuntimeField_220);
        this.pixelPassView.丛不丝丗一丏三专丄(丙业与丙丗丝不丈东:  new System.Action());
    }
    public override void Show()
    {
        丆丝丈丐不专一丟且 val_5;
        PGCompany.TransitionController.丑七不且上丗丁一世().丗丝上一不三东丁专(不丌不世且丄不三丝:  this);
        this.Show();
        PGCompany.丆下丐丁丏世丈上丟 val_4 = this.丑丐丙丄丅世世丑丒();
        this.pixelPassView.丈且东丑丂且万丒丅(丈丂七世丟丞丂丗丒:  PGCompany.PixelPass.丘丏丅丆丑下业丙七.丑七不且上丗丁一世().丘丗不丂世丘三三丙(), 丗三丝丈专七万丕丆:  val_5);
        PGCompany.业专丝丆与下丙丒丑.丑七不且上丗丁一世().一东丁世丆与丆万丌(丈七丄丆丅丂东丄一:  5);
    }
    public override void Back()
    {
        this.Back();
        this.HideSelf();
        PGCompany.TransitionController.丑七不且上丗丁一世().上丒丑业不且丞丟丌(不丌不世且丄不三丝:  this);
    }
    public void TurnOn()
    {
        this.gameObject.SetActive(value:  true);
    }
    public void TurnOff()
    {
        this.gameObject.SetActive(value:  false);
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
    public PixelPassBanner()
    {
    
    }

}
