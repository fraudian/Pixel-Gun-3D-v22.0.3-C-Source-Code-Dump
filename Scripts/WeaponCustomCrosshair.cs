using UnityEngine;
public class WeaponCustomCrosshair : MonoBehaviour
{
    // Fields
    internal const string 丗丝丆万七丟与丙三 = "Common/crosshairs";
    private static CrosshairsSo 丁七万丞丐且丆与上;
    private CrosshairData 丁丘丄丕下专东七不;
    private int _dataId;
    
    // Properties
    public int 七世丏与丕与丝三下 { get; set; }
    public CrosshairData 丞丑且东丌与丏丏丁 { get; }
    internal static CrosshairsSo 丙丝丟丑业丂丝丏三 { get; }
    
    // Methods
    public int get_DataId()
    {
        return (int)this._dataId;
    }
    public void set_DataId(int 丙业与丙丗丝不丈东)
    {
        this._dataId = 丙业与丙丗丝不丈东;
        this.丁丘丄丕下专东七不 = 0;
    }
    public CrosshairData get_Data()
    {
        CrosshairData val_7 = this.丁丘丄丕下专东七不;
        if(val_7 != null)
        {
                return val_7;
        }
        
        if(WeaponCustomCrosshair.丒丆一丞丆上业丒东() != 0)
        {
                CrosshairsSo val_3 = WeaponCustomCrosshair.丒丆一丞丆上业丒东();
            val_7 = System.Linq.Enumerable.FirstOrDefault<CrosshairData>(source:  val_3.Crosshairs, predicate:  new System.Func<CrosshairData, System.Boolean>(object:  this, method:  System.Boolean WeaponCustomCrosshair::丌下上丗丅与丂丙丁(CrosshairData 丁丂专业丁丅丅丈丙)));
            this.丁丘丄丕下专东七不 = val_7;
            if(val_7 != null)
        {
                return val_7;
        }
        
        }
        
        CrosshairData val_6 = null;
        val_7 = val_6;
        val_6 = new CrosshairData();
        this.丁丘丄丕下专东七不 = val_7;
        return val_7;
    }
    internal static CrosshairsSo 丒丆一丞丆上业丒东()
    {
        if(WeaponCustomCrosshair.丁七万丞丐且丆与上 != null)
        {
                return val_1;
        }
        
        CrosshairsSo val_1 = UnityEngine.Resources.Load<CrosshairsSo>(path:  "Common/crosshairs");
        WeaponCustomCrosshair.丁七万丞丐且丆与上 = val_1;
        return val_1;
    }
    public WeaponCustomCrosshair()
    {
    
    }
    private bool 丌下上丗丅与丂丙丁(CrosshairData 丁丂专业丁丅丅丈丙)
    {
        return (bool)(丁丂专业丁丅丅丈丙.ID == this._dataId) ? 1 : 0;
    }

}
