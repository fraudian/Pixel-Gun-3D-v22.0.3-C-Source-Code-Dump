using UnityEngine;
public class AlmanachMigrationUI : MonoBehaviour
{
    // Fields
    private static System.Action 且东丏丞不丕七丌丒;
    public static bool isActive;
    private UnityEngine.GameObject holder;
    private OfferItemView rewardUi;
    private System.IDisposable 七丝丕丅与且丘业万;
    
    // Methods
    public static void add_onGetRewardButtonPressed(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Combine(a:  AlmanachMigrationUI.且东丏丞不丕七丌丒, b:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    public static void remove_onGetRewardButtonPressed(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        var val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = System.Delegate.Remove(source:  AlmanachMigrationUI.且东丏丞不丕七丌丒, value:  丙业与丙丗丝不丈东);
        if((val_4 != null) && (null != null))
        {
                val_4 = 0;
        }
        
        val_5 = null;
        val_5 = null;
    }
    public void Setup()
    {
        var val_6 = null;
        AlmanachMigrationUI.isActive = true;
        this.rewardUi.Setup(与且专丈不万东一万:  上且丁万与丌下丐上.丘东丐七丒专七下三());
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  true);
        if(this.七丝丕丅与且丘业万 != null)
        {
                var val_6 = 0;
            val_6 = val_6 + 1;
            this.七丝丕丅与且丘业万.Dispose();
        }
        
        this.七丝丕丅与且丘业万 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  public System.Void AlmanachMigrationUI::GetRewardButtonPressed()), 与且专丈不万东一万:  "AlmanachMainUI");
    }
    public void Hide()
    {
        var val_3;
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.七丝丕丅与且丘业万.Dispose();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.holder, 丏业丟一东丂东丘丛:  false);
        val_3 = null;
        val_3 = null;
        AlmanachMigrationUI.isActive = false;
    }
    public void GetRewardButtonPressed()
    {
        var val_1;
        System.Action val_2;
        this.Hide();
        val_1 = null;
        val_1 = null;
        val_2 = AlmanachMigrationUI.且东丏丞不丕七丌丒;
        if(val_2 == null)
        {
                return;
        }
        
        val_2 = AlmanachMigrationUI.且东丏丞不丕七丌丒;
        if(val_2 == null)
        {
                val_2 = 0;
        }
        
        val_2.Invoke();
    }
    public AlmanachMigrationUI()
    {
    
    }
    private static AlmanachMigrationUI()
    {
    
    }

}
