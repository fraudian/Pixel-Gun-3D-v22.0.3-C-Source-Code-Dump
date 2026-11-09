using UnityEngine;
public class ClanTestMatchBanner : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject tankObject;
    public UnityEngine.GameObject fortObject;
    public Rilisoft.ButtonHandler cancelBtn;
    public Rilisoft.ButtonHandler squadBtn;
    public Rilisoft.ButtonHandler backgroundBtn;
    private System.Action 与业丛丄丐专丘与下;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    private void Awake()
    {
        this.cancelBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ClanTestMatchBanner::东不专三丟丙下东丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.backgroundBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ClanTestMatchBanner::东不专三丟丙下东丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.squadBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void ClanTestMatchBanner::三丁丐与丟万不丏业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    internal void 专万万一丁业丘下丕(bool 丞东丗万丌丏丛丒丄, System.Action 三丑丁一丐丘丟丄丈)
    {
        this.gameObject.SetActive(value:  true);
        this.tankObject.SetActive(value:  丞东丗万丌丏丛丒丄);
        this.fortObject.SetActive(value:  (~丞东丗万丌丏丛丒丄) & 1);
        this.与业丛丄丐专丘与下 = 三丑丁一丐丘丟丄丈;
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_8 = 0;
            val_8 = val_8 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void ClanTestMatchBanner::丈丗丈丟丁且一丅丞()), 与且专丈不万东一万:  "Squad dialog");
    }
    private void 东不专三丟丙下东丘(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丅丙丞下一不丌丟不();
    }
    private void 三丁丐与丟万不丏业(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.三丏三丟且七七下世();
    }
    private void 三丏三丟且七七下世()
    {
        this.丅丙丞下一不丌丟不();
        if(this.与业丛丄丐专丘与下 == null)
        {
                return;
        }
        
        this.与业丛丄丐专丘与下.Invoke();
    }
    internal void 丅丙丞下一不丌丟不()
    {
        this.gameObject.SetActive(value:  false);
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_3 = 0;
        val_3 = val_3 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    public ClanTestMatchBanner()
    {
    
    }
    private void 丈丗丈丟丁且一丅丞()
    {
        this.丅丙丞下一不丌丟不();
    }

}
