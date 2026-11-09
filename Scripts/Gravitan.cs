using UnityEngine;
public class Gravitan : MonoBehaviour
{
    // Fields
    public UnityEngine.Vector3 gravitation;
    private bool instaJump;
    private bool changeGravityModifier;
    private float gravityModifier;
    private float delayBeforeAddGravitan;
    private bool 丏万丗世丛丄丘与一;
    private bool 与丘丐丏一一三东丂;
    
    // Methods
    private void OnTriggerEnter(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        Player_move_c val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_10 = null;
            val_10 = null;
            if((丆丛丂丝丄世且丛丕.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) != false)
        {
                val_11 = null;
            val_11 = null;
            val_12 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_12 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_13 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 204];
            val_13 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 204;
            mem[204] = 1;
        }
        
        }
        
        val_14 = null;
        val_14 = null;
        val_15 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_15 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_15 != 0)
        {
                val_16 = null;
            val_16 = null;
            if((丆丛丂丝丄世且丛丕.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) != false)
        {
                this.与丘丐丏一一三东丂 = true;
        }
        
        }
        
        if((this.instaJump != false) && (this.丏万丗世丛丄丘与一 != true))
        {
                val_17 = null;
            val_17 = null;
            val_15 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_15 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_15 != 0)
        {
                val_18 = null;
            val_18 = null;
            if((丆丛丂丝丄世且丛丕.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) != false)
        {
                val_19 = null;
            val_19 = null;
            val_15 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_15 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            mem2[0] = this.gravitation;
            mem2[0] = ???;
            mem2[0] = ???;
        }
        
        }
        
        }
        
        if(this.changeGravityModifier == false)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        val_15 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_15 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_15 == 0)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        if((丆丛丂丝丄世且丛丕.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) == false)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丝丌丆丙丑丟不丞不(且下世丈丟丒万东丘:  this.gravityModifier);
    }
    private void OnTriggerExit(UnityEngine.Collider 丆丛丂丝丄世且丛丕)
    {
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        Player_move_c val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        val_12 = null;
        val_12 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_13 = null;
            val_13 = null;
            if((丆丛丂丝丄世且丛丕.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) != false)
        {
                val_14 = null;
            val_14 = null;
            val_15 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_15 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            val_16 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 204];
            val_16 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456 + 204;
            mem[204] = -1;
        }
        
        }
        
        val_17 = null;
        val_17 = null;
        val_18 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_18 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_18 != 0)
        {
                val_19 = null;
            val_19 = null;
            if((丆丛丂丝丄世且丛丕.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) != false)
        {
                this.与丘丐丏一一三东丂 = false;
        }
        
        }
        
        if(this.instaJump != false)
        {
                val_20 = null;
            val_20 = null;
            val_18 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_18 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            if(val_18 != 0)
        {
                val_21 = null;
            val_21 = null;
            if((丆丛丂丝丄世且丛丕.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) != false)
        {
                val_22 = null;
            val_22 = null;
            val_18 = mem[typeof(Player_move_c).__il2cppRuntimeField_628 + 456];
            val_18 = typeof(Player_move_c).__il2cppRuntimeField_628 + 456;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.zero;
            mem2[0] = val_7.x;
            mem2[0] = val_7.y;
            mem2[0] = val_7.z;
            UnityEngine.Coroutine val_9 = this.StartCoroutine(routine:  this.丛丝丑丅三丒丗丘与(丕丕世且下一与丝与:  this.delayBeforeAddGravitan));
        }
        
        }
        
        }
        
        if(this.changeGravityModifier == false)
        {
                return;
        }
        
        val_23 = null;
        val_23 = null;
        val_18 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_18 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_18 == 0)
        {
                return;
        }
        
        val_24 = null;
        val_24 = null;
        if((丆丛丂丝丄世且丛丕.Equals(other:  typeof(Player_move_c).__il2cppRuntimeField_198)) == false)
        {
                return;
        }
        
        val_25 = null;
        val_25 = null;
        float val_12 = 1f;
        val_12 = val_12 / this.gravityModifier;
        typeof(Player_move_c).__il2cppRuntimeField_628 + 456.丝丌丆丙丑丟不丞不(且下世丈丟丒万东丘:  val_12);
    }
    private System.Collections.IEnumerator 丛丝丑丅三丒丗丘与(float 丕丕世且下一与丝与)
    {
        Gravitan.丄丙丂丕丟丟万万三 val_1 = new Gravitan.丄丙丂丕丟丟万万三();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerator)val_1;
    }
    public Gravitan()
    {
        this.instaJump = true;
        this.gravityModifier = Infinityf;
        this.delayBeforeAddGravitan = 2f;
    }

}
