using UnityEngine;
public class MigrateTrophiesSeptember2018Banner : MonoBehaviour
{
    // Fields
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    private void Awake()
    {
        this.东三世丙丁丒丝世丕();
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void MigrateTrophiesSeptember2018Banner::Hide()), 与且专丈不万东一万:  "MigrateT_rophiesSep_tember201_8Banner");
    }
    private void OnDestroy()
    {
        this.东三世丙丁丒丝世丕();
    }
    public void Hide()
    {
        ButtonClickSound.丆丕丝丒不丙且丐丗.PlayClick();
        this.transform.parent = 0;
        UnityEngine.Object.Destroy(obj:  this.gameObject);
    }
    private void 东三世丙丁丒丝世丕()
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
    public MigrateTrophiesSeptember2018Banner()
    {
    
    }

}
