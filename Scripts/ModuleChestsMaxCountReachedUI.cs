using UnityEngine;
internal class ModuleChestsMaxCountReachedUI : MonoBehaviour
{
    // Fields
    internal static bool 丟丐与丂丙丞世丏丞;
    private UnityEngine.GameObject holder;
    private System.Action 丂丈丆丅丟七丐专世;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    internal void 丈且东丑丂且万丒丅(System.Action 丂丈丆丅丟七丐专世)
    {
        var val_4;
        this.丂丈丆丅丟七丐专世 = 丂丈丆丅丟七丐专世;
        val_4 = null;
        val_4 = null;
        ModuleChestsMaxCountReachedUI.丟丐与丂丙丞世丏丞 = true;
        this.holder.SetActive(value:  true);
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void ModuleChestsMaxCountReachedUI::Hide()), 与且专丈不万东一万:  "OnOpenModuleChestUI");
    }
    public void Hide()
    {
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_2 = 0;
            val_2 = val_2 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
            this.丐丆七且丞丏下三丙 = 0;
        }
        
        this.丂丈丆丅丟七丐专世 = 0;
        this.holder.SetActive(value:  false);
    }
    public void ToChests()
    {
        var val_2;
        var val_3;
        var val_4;
        this.Hide();
        val_2 = static_value_081DACA8;
        val_2 = static_value_081DACA8;
        if((static_value_081DACA8 + 184 + 16) == 0)
        {
                return;
        }
        
        val_3 = static_value_081DACA8;
        val_3 = static_value_081DACA8;
        static_value_081DACA8 + 184 + 16.一丏丞丘专丘业丈丑(丝丗丙丞丙丕万业下:  0, 与丝丕与丙不与丗丆:  0, 一专七丟丏且丑丄下:  112, 丄丕三丞一丌与与丅:  false);
        val_4 = null;
        val_4 = null;
        ShopNGUIController.丏丙丅丕一丑丕丑丑.丆丑丆丟七丑且丈三(七丆丒与丗丌丄且丂:  112, 与丝丕与丙不与丗丆:  0, 七丑业业丒七一丂丆:  false);
    }
    public void ToBattle()
    {
        if(this.丂丈丆丅丟七丐专世 != null)
        {
                this.丂丈丆丅丟七丐专世.Invoke();
        }
        
        this.Hide();
    }
    public ModuleChestsMaxCountReachedUI()
    {
    
    }
    private static ModuleChestsMaxCountReachedUI()
    {
    
    }

}
