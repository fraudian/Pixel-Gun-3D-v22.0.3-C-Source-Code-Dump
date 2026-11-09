using UnityEngine;
public class DungeonNoModulesWindowUI : MonoBehaviour
{
    // Fields
    internal System.Action 丛丝与丂世丌丌丝丂;
    internal System.Action 下丞丐万丁丟且下丗;
    public Rilisoft.ButtonHandler battleBtn;
    public Rilisoft.ButtonHandler backBtn;
    public Rilisoft.ButtonHandler craftBtn;
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
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void DungeonNoModulesWindowUI::丏丆下丘丅丙丐丌丅()), 与且专丈不万东一万:  "Dungeon No modules Window");
    }
    internal void 丆丙丗三东专丐不上()
    {
        this.gameObject.SetActive(value:  true);
    }
    private void 七专丆丝丏丅丄丅丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.下丞丐万丁丟且下丗 != null)
        {
                this.下丞丐万丁丟且下丗.Invoke();
        }
        
        this.丏丆下丘丅丙丐丌丅();
    }
    private void 业丘丂丐丏七丘三丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        var val_2;
        var val_3;
        var val_4;
        this.丏丆下丘丅丙丐丌丅();
        val_2 = static_value_081DACA8;
        val_2 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16) == 0)
        {
                return;
        }
        
        val_3 = static_value_081DACA8;
        val_3 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16.一丏丞丘专丘业丈丑(丝丗丙丞丙丕万业下:  0, 与丝丕与丙不与丗丆:  0, 一专七丟丏且丑丄下:  96, 丄丕三丞一丌与与丅:  false);
        val_4 = null;
        val_4 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丆丑丆丟七丑且丈三(七丆丒与丗丌丄且丂:  96, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
    }
    private void 丆万丘不丗丈丕且与(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(this.丛丝与丂世丌丌丝丂 != null)
        {
                this.丛丝与丂世丌丌丝丂.Invoke();
        }
        
        this.丏丆下丘丅丙丐丌丅();
    }
    private void 丏丆下丘丅丙丐丌丅()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_3 = 0;
            val_3 = val_3 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        this.gameObject.SetActive(value:  false);
    }
    private void Awake()
    {
        this.battleBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void DungeonNoModulesWindowUI::七专丆丝丏丅丄丅丗(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.craftBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void DungeonNoModulesWindowUI::业丘丂丐丏七丘三丈(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        this.backBtn.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void DungeonNoModulesWindowUI::丆万丘不丗丈丕且与(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    public DungeonNoModulesWindowUI()
    {
    
    }

}
