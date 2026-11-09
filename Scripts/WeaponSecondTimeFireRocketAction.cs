using UnityEngine;
public class WeaponSecondTimeFireRocketAction : WeaponSecondTimeFireAction
{
    // Properties
    internal override bool 丅业东万丌丕上丌丄 { get; }
    
    // Methods
    internal override bool 丈丐丞丐上丑且丕万()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return false;
        }
        
        val_4 = null;
        val_4 = null;
        return typeof(Player_move_c).__il2cppRuntimeField_F30.ContainsKey(key:  WeaponManager.丟丗丄业丘丗业丗七.三与丛丑且丐丈业丌());
    }
    internal override void 且丝丑丄丝不东丅丗()
    {
        var val_7;
        var val_8;
        val_7 = null;
        val_7 = null;
        string val_1 = X21.三与丛丑且丐丈业丌();
        if((typeof(Player_move_c).__il2cppRuntimeField_F30.ContainsKey(key:  val_1)) == false)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        typeof(Player_move_c).__il2cppRuntimeField_F30.Item[val_1.三与丛丑且丐丈业丌()].丄丕万丄丐万七丅丈();
        bool val_6 = typeof(Player_move_c).__il2cppRuntimeField_F30.Remove(key:  WeaponManager.丟丗丄业丘丗业丗七.三与丛丑且丐丈业丌());
    }
    public WeaponSecondTimeFireRocketAction()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
