using UnityEngine;
public class GamepadSettingsController : MonoBehaviour
{
    // Fields
    public UIButton backBtn;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    private void OnEnable()
    {
        this.backBtn.GetComponent<Rilisoft.ButtonHandler>().add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void GamepadSettingsController::丟东丌丌丕丐丞七专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void GamepadSettingsController::下丞丆丕专一世七与()), 与且专丈不万东一万:  "GamepadSettings");
    }
    private void 丟东丌丌丕丐丞七专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    public GamepadSettingsController()
    {
    
    }
    private void 下丞丆丕专一世七与()
    {
        this.丟东丌丌丕丐丞七专(不丟丗丏丛丕不丁丌:  null, 丗丛不丁丑专专丂且:  null);
    }

}
