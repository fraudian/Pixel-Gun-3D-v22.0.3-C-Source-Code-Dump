using UnityEngine;
public class ClanStartGui : PGBehaviour
{
    // Fields
    private System.IDisposable 且丂七丑丈丞丈三丑;
    private UITable _table;
    private static ClanStartGui <不丁丄七丛不丆丁丕>k__BackingField;
    
    // Properties
    internal static ClanStartGui 丆丕丝丒不丙且丐丗 { get; set; }
    
    // Methods
    internal static ClanStartGui 丑七不且上丗丁一世()
    {
        return (ClanStartGui)ClanStartGui.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(ClanStartGui 丙业与丙丗丝不丈东)
    {
        ClanStartGui.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        ClanStartGui.<不丁丄七丛不丆丁丕>k__BackingField = this;
    }
    private void OnDestroy()
    {
        ClanStartGui.<不丁丄七丛不丆丁丕>k__BackingField = 0;
    }
    private void 丕不不丄不丄丟上丁(ClanSearchGui.一丐丛丏东上专丆丐 丐丅丒专丛丏上与业)
    {
        ClanSearchGui.丌万丗与七丄丕不丁(丐丅丒专丛丏上与业:  丐丅丒专丛丏上与业, 丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  System.Void ClanStartGui::丕丄丝东丗三下丄丄()));
        this.gameObject.SetActive(value:  false);
    }
    public void U_BackRequest()
    {
        var val_2;
        var val_3;
        val_2 = null;
        val_2 = null;
        if(ClansWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
                return;
        }
        
        val_3 = null;
        val_3 = null;
        ClansWindowGUI.丆丕丝丒不丙且丐丗.丝东丐丝东三丈世丝();
    }
    public void U_CreateClick()
    {
        var val_4;
        System.Action val_6;
        val_4 = null;
        val_4 = null;
        val_6 = ClanStartGui.<>c.<>9__10_1;
        if(val_6 == null)
        {
                System.Action val_2 = null;
            val_6 = val_2;
            val_2 = new System.Action(object:  ClanStartGui.<>c.__il2cppRuntimeField_static_fields, method:  System.Void ClanStartGui.<>c::丗丛且七丛丌丂万东());
            ClanStartGui.<>c.<>9__10_1 = val_6;
        }
        
        this.gameObject.SetActive(value:  false);
        ClanCreateGui.丌万丗与七丄丕不丁(丂丛丑东不丅丈一东:  0, 丛丝与丂世丌丌丝丂:  new System.Action(object:  this, method:  System.Void ClanStartGui::东丛丈丛一丆业专业()), 不丘丘丝丅丁且丞丝:  val_2);
    }
    public void U_SearchClik()
    {
        this.丕不不丄不丄丟上丁(丐丅丒专丛丏上与业:  0);
    }
    public void U_InvitesClick()
    {
        this.丕不不丄不丄丟上丁(丐丅丒专丛丏上与业:  1);
    }
    private void OnEnable()
    {
        丞丂丘丒丟丞丑下丄 val_2 = Rilisoft.Singleton<ClansController>.Instance.丞丗丑丈一丅丗丌丟();
        if(val_2 != null)
        {
                val_2.U_BackRequest();
        }
        
        if(this.且丂七丑丈丞丈三丑 == null)
        {
                System.Action val_4 = new System.Action(object:  this, method:  public System.Void ClanStartGui::U_BackRequest());
            0 = val_4;
            this.且丂七丑丈丞丈三丑 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  val_4, 与且专丈不万东一万:  "ClanStart");
        }
        
        if(this._table == null)
        {
            
        }
    
    }
    private void OnDisable()
    {
        if(this.且丂七丑丈丞丈三丑 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.且丂七丑丈丞丈三丑.Dispose();
        this.且丂七丑丈丞丈三丑 = 0;
    }
    public ClanStartGui()
    {
    
    }
    private void 丕丄丝东丗三下丄丄()
    {
        this.gameObject.SetActive(value:  true);
    }
    private void 东丛丈丛一丆业专业()
    {
        this.gameObject.SetActive(value:  true);
    }

}
