using UnityEngine;
public sealed class BackRanksTapReceiver : MonoBehaviour
{
    // Fields
    internal NetworkStartTableNGUIController networkStartTableNGUIController;
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
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void BackRanksTapReceiver::OnClick()), 与且专丈不万东一万:  "Back Ranks");
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
        ButtonClickSound.丁业上丏不丕三丗不();
        this.networkStartTableNGUIController.丏专七丁七丙下丆丁(丟丆丞丏业七世东丒:  true);
    }
    public BackRanksTapReceiver()
    {
    
    }

}
