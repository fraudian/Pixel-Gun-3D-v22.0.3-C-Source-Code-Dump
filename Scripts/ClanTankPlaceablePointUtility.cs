using UnityEngine;
internal sealed class ClanTankPlaceablePointUtility : PGBehaviour
{
    // Methods
    private void OnMouseDown()
    {
        float val_12;
        UnityEngine.Object val_13;
        UnityEngine.Vector3 val_2 = this.丌丟丄业且三丛丕丄().position;
        val_12 = val_2.x;
        val_13 = ClanTankBuildBase.instance.GetNearestPlaceableItemPoint(丝东丝万丟一丝业与:  new UnityEngine.Vector3() {x = val_12, y = val_2.y, z = val_2.z});
        if(val_13 == 0)
        {
                return;
        }
        
        val_13 = ???;
        val_12 = ???;
        goto typeof(ClanTankPlaceableItemPoint).__il2cppRuntimeField_198;
    }
    public ClanTankPlaceablePointUtility()
    {
    
    }

}
