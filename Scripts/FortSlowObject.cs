using UnityEngine;
internal sealed class FortSlowObject : FortEquipObject
{
    // Fields
    public float distance;
    public float slowdownTime;
    private bool 上丈丅下七丐丗下下;
    private float 丞丗丗世丏丟丏下丆;
    private bool 丈世丟丂丌丄业丐丅;
    
    // Methods
    internal override void 上丛丌丆丑上七世三(byte 丞丅上丏丂且下丅与, BaseEquipmentController 丒专丈丛下丒一丒丛)
    {
        this.上丛丌丆丑上七世三(丞丅上丏丂且下丅与:  丞丅上丏丂且下丅与, 丒专丈丛下丒一丒丛:  丒专丈丛下丒一丒丛);
        if(this == null)
        {
                return;
        }
        
        string val_1 = this.丆丘丒东且丂与丂丑();
        if((val_1.Equals(value:  "SlowDown")) != true)
        {
                if((val_1.丆丘丒东且丂与丂丑().Equals(value:  "SlowDown Area")) == false)
        {
                return;
        }
        
        }
        
        this.丈世丟丂丌丄业丐丅 = true;
    }
    private void Update()
    {
        var val_23;
        var val_26;
        UnityEngine.GameObject val_27;
        float val_29;
        var val_30;
        var val_31;
        WeaponManager val_32;
        if(this.丈世丟丂丌丄业丐丅 == false)
        {
                return;
        }
        
        if(GameConnect.丅丟下专不丁一丈七() == false)
        {
            goto label_50;
        }
        
        System.Collections.Generic.IEnumerator<UnityEngine.Transform> val_3 = new 丘丛丞且一丅丁丏丐.不丌且丑万七丒丒上(丂丛下世世丆丈上丆:  W21, 丅七上一丈丕上丒丞:  false).世且一丄且上丄不一();
        label_31:
        var val_22 = 0;
        val_22 = val_22 + 1;
        if(val_3.MoveNext() == false)
        {
            goto label_11;
        }
        
        var val_23 = 0;
        val_23 = val_23 + 1;
        T val_7 = val_3.Current;
        if((丘丛丞且一丅丁丏丐.万丏丘丘世丝三丛丌(丞下万上三丘上与专:  val_7)) == null)
        {
            goto label_31;
        }
        
        UnityEngine.Vector3 val_9 = val_7.position;
        UnityEngine.Vector3 val_11 = this.transform.position;
        if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, b:  new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z})) >= 0)
        {
            goto label_31;
        }
        
        float val_13 = this.下与丗丒丐三丕丘丈();
        val_13 = 1f - val_13;
        val_23 = null;
        val_23 = null;
        ApplyDebuffByMode(丁丅丈丌丟世丗丗丟:  0, 丘七丛丂专丅丛业丑:  this.slowdownTime, 业与丑丑丁丝丏丗世:  val_13);
        goto label_31;
        label_11:
        val_26 = 0;
        val_27 = 0;
        if(val_3 == null)
        {
            
        }
        else
        {
                var val_24 = 0;
            val_24 = val_24 + 1;
            val_3.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        label_50:
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
                return;
        }
        
        val_29 = this.丞丗丗世丏丟丏下丆;
        if(val_29 > 0f)
        {
                val_29 = val_29 - UnityEngine.Time.deltaTime;
            this.丞丗丗世丏丟丏下丆 = val_29;
        }
        
        if(this.上丈丅下七丐丗下下 == false)
        {
                return;
        }
        
        if(val_29 >= 0)
        {
                return;
        }
        
        val_27 = 1152921505286238208;
        val_30 = null;
        val_30 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        this.丞丗丗世丏丟丏下丆 = this.slowdownTime;
        val_31 = null;
        val_31 = null;
        val_32 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_65;
        }
        
        val_32 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_32 == null)
        {
            goto label_66;
        }
        
        label_65:
        val_29 = this.slowdownTime;
        val_27 = typeof(Player_move_c).__il2cppRuntimeField_628.gameObject;
        float val_25 = 1f;
        val_25 = val_25 - this.下与丗丒丐三丕丘丈();
        与东丁业丁与且丌丕(丞下万上三丘上与专:  val_27, 七丏上不丒万丐东丄:  val_29, 三上丅丈丄不丌万丙:  UnityEngine.Mathf.Clamp01(value:  val_25));
        return;
        label_66:
    }
    private void OnTriggerEnter(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        Player_move_c val_4;
        var val_5;
        var val_6;
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_4 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if((丆丛丂丝丄世且丛丕.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) == false)
        {
                return;
        }
        
        this.上丈丅下七丐丗下下 = true;
        this.丞丗丗世丏丟丏下丆 = -1f;
    }
    private void OnTriggerExit(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        Player_move_c val_4;
        var val_5;
        var val_6;
        if(GameConnect.七丂万专且丏丘一丙() == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_4 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_4 == 0)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        if((丆丛丂丝丄世且丛丕.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) == false)
        {
                return;
        }
        
        this.上丈丅下七丐丗下下 = false;
    }
    public FortSlowObject()
    {
        this.distance = 2f;
        this.slowdownTime = 2f;
        this.丞丗丗世丏丟丏下丆 = -1f;
    }

}
