using UnityEngine;
public class FortFieldUICell : MonoBehaviour
{
    // Fields
    private SquareFieldCellSize _cellSize;
    private PlaceableItemSettings itemSettings;
    
    // Methods
    private void OnClick()
    {
        float val_10;
        PlaceableItemSettings val_14;
        float val_15;
        val_14 = this;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.up;
        val_15 = val_1.x;
        int val_3 = UnityEngine.Screen.width;
        int val_4 = UnityEngine.Screen.height;
        var val_5 = (val_3 < 0) ? (val_3 + 1) : (val_3);
        val_5 = val_5 >> 1;
        var val_7 = ((val_4 < 0) ? (val_4 + 1) : (val_4)) >> 1;
        UnityEngine.Ray val_8 = UnityEngine.Camera.main.ScreenPointToRay(pos:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        if((1835189120 & 1) == 0)
        {
                return;
        }
        
        UnityEngine.Vector3 val_11 = SquareField.丏东七万丞丆丅丒丕(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 0f, y = val_10, z = 0f}, 丟七丘一丈万业专下:  1f);
        val_15 = val_11.x;
        val_14 = this.itemSettings;
        ClanFieldBuildController.丑七不且上丗丁一世().丙丆丅丐丝丄与七丒().丝世丛三丌不丂与丗(丑丕专万丝七丄丞且:  new UnityEngine.Vector3() {x = val_15, y = val_11.y, z = val_11.z}, 与丆丆东丌丈丏世丄:  this._cellSize, 七丅丗丆丒丌丑丝不:  0, 业世丟丐丘丐专与不:  val_14);
    }
    public FortFieldUICell()
    {
    
    }

}
