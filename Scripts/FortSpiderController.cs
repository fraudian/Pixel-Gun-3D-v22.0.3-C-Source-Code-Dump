using UnityEngine;
public class FortSpiderController : MonoBehaviour
{
    // Fields
    public float slowdownCoeff;
    private bool 上丈丅下七丐丗下下;
    private float 丝丒一与丘丞一丌丐;
    private float 丞丗丗世丏丟丏下丆;
    
    // Methods
    private void Update()
    {
        float val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        WeaponManager val_11;
        val_6 = this.丞丗丗世丏丟丏下丆;
        if(val_6 > 0f)
        {
                val_6 = val_6 - UnityEngine.Time.deltaTime;
            this.丞丗丗世丏丟丏下丆 = val_6;
        }
        
        if(this.上丈丅下七丐丗下下 == false)
        {
                return;
        }
        
        if(val_6 >= 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = null;
        val_9 = null;
        if(SiegeController.三三万丆下一丗万丛.attackTeam != 丘丑丅三丆丑丌且丝())
        {
                return;
        }
        
        this.丞丗丗世丏丟丏下丆 = this.丝丒一与丘丞一丌丐;
        val_10 = null;
        val_10 = null;
        val_11 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_20;
        }
        
        val_11 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_11 == null)
        {
            goto label_21;
        }
        
        label_20:
        float val_6 = 1.5f;
        val_6 = this.丝丒一与丘丞一丌丐 * val_6;
        与东丁业丁与且丌丕(丞下万上三丘上与专:  typeof(Player_move_c).__il2cppRuntimeField_628.gameObject, 七丏上不丒万丐东丄:  val_6, 三上丅丈丄不丌万丙:  this.slowdownCoeff);
        return;
        label_21:
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
    public FortSpiderController()
    {
        this.slowdownCoeff = 0.5f;
        this.丝丒一与丘丞一丌丐 = 1f;
        this.丞丗丗世丏丟丏下丆 = -1f;
    }

}
