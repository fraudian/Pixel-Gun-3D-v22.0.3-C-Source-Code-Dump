using UnityEngine;
public class FortSlowdownZone : MonoBehaviour
{
    // Fields
    public float slowdownCoeff;
    private bool 上丈丅下七丐丗下下;
    private float 丝丒一与丘丞一丌丐;
    private float 丞丗丗世丏丟丏下丆;
    
    // Methods
    private void Update()
    {
        float val_7;
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        WeaponManager val_13;
        val_7 = this.丞丗丗世丏丟丏下丆;
        if(val_7 > 0f)
        {
                val_7 = val_7 - UnityEngine.Time.deltaTime;
            this.丞丗丗世丏丟丏下丆 = val_7;
        }
        
        if(this.上丈丅下七丐丗下下 == false)
        {
                return;
        }
        
        if(val_7 >= 0)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        if(SiegeController.三三万丆下一丗万丛 != 0)
        {
                val_10 = null;
            val_10 = null;
            val_11 = null;
            val_11 = null;
            if(SiegeController.三三万丆下一丗万丛.attackTeam != 丘丑丅三丆丑丌且丝())
        {
                return;
        }
        
        }
        
        this.丞丗丗世丏丟丏下丆 = this.丝丒一与丘丞一丌丐;
        val_12 = null;
        val_12 = null;
        val_13 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_25;
        }
        
        val_13 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_13 == null)
        {
            goto label_26;
        }
        
        label_25:
        float val_7 = 1.5f;
        val_7 = this.丝丒一与丘丞一丌丐 * val_7;
        与东丁业丁与且丌丕(丞下万上三丘上与专:  typeof(Player_move_c).__il2cppRuntimeField_628.gameObject, 七丏上不丒万丐东丄:  val_7, 三上丅丈丄不丌万丙:  this.slowdownCoeff);
        return;
        label_26:
    }
    private void OnTriggerEnter(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        var val_3;
        Player_move_c val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_4 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if((丆丛丂丝丄世且丛丕.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) == false)
        {
                return;
        }
        
        this.上丈丅下七丐丗下下 = true;
        this.丞丗丗世丏丟丏下丆 = -1f;
    }
    private void OnTriggerExit(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        var val_3;
        Player_move_c val_4;
        var val_5;
        val_3 = null;
        val_3 = null;
        val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_4 == 0)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if((丆丛丂丝丄世且丛丕.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) == false)
        {
                return;
        }
        
        this.上丈丅下七丐丗下下 = false;
    }
    public FortSlowdownZone()
    {
        this.slowdownCoeff = 0.5f;
        this.丝丒一与丘丞一丌丐 = 1f;
        this.丞丗丗世丏丟丏下丆 = -1f;
    }

}
