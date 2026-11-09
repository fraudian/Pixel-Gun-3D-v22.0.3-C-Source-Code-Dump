using UnityEngine;
internal sealed class AvardPanelOkBtn : MonoBehaviour
{
    // Fields
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    private void OnEnable()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_5 = 0;
            val_5 = val_5 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void AvardPanelOkBtn::OnClick()), 与且专丈不万东一万:  "Award Panel");
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    private void OnClick()
    {
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丑与丑丕七丞一一丏();
    }
    public AvardPanelOkBtn()
    {
    
    }

}
