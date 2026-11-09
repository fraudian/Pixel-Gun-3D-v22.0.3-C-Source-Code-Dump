using UnityEngine;
internal class WeaponAOEDamager : MonoBehaviour
{
    // Fields
    internal string onGroundEffectName;
    private float damageRadius;
    private float damageMultiplier;
    private WeaponSounds.丏专丐且丘丌丛不丁 typeDead;
    private bool isPoison;
    private DamageInRadiusEffect.WeaponInfoForPoison poisonSettings;
    
    // Methods
    private void 丄世丝丐丙三业世丏(WeaponSounds 丌丝下丄业一丄不三, float 与丗与丕丈丌与丄丝)
    {
        UnityEngine.Object val_33;
        ZombiManager val_34;
        float val_37;
        float val_38;
        float val_39;
        var val_40;
        var val_41;
        val_33 = 丌丝下丄业一丄不三;
        if(this.onGroundEffectName != null)
        {
                if((System.String.op_Inequality(a:  this.onGroundEffectName, b:  System.String.alignConst)) != false)
        {
                val_33.下丏丆下丙与丘上丁().丏丗丐七丑丏丛七上(丒丘丏上丙丟丑丕丈:  this.onGroundEffectName);
        }
        
        }
        
        Player_move_c val_3 = val_33.下丏丆下丙与丘上丁();
        if(val_3.丁丑丅丏丒不七上丁 != false)
        {
                val_34 = val_33.下丏丆下丙与丘上丁();
            if(val_34.丟丌下三七丁与丟丑() == false)
        {
                return;
        }
        
        }
        
        if((GameConnect.丙丘不世专且万丄丐() != false) && (TimeGameController.丄丞丁丈与业上丞丟 != 0))
        {
                if(((val_33 != 0) && (ZombiManager.丟丗丄业丘丗业丗七.currentWeaponCategory != 1)) && (丌丝下丄业一丄不三.categoryNabor != 1))
        {
                val_34 = ZombiManager.丟丗丄业丘丗业丗七;
            if((丌丝下丄业一丄不三.categoryNabor - 1) != ZombiManager.丟丗丄业丘丗业丗七.currentWeaponCategory)
        {
                return;
        }
        
        }
        
        }
        
        float val_35 = this.damageRadius;
        val_35 = val_35 * val_35;
        val_34 = new 丘丛丞且一丅丁丏丐.丈丐丆丅下丏业业丑().世且一丄且上丄不一();
        label_61:
        var val_36 = 0;
        val_36 = val_36 + 1;
        if(val_34.MoveNext() == false)
        {
            goto label_32;
        }
        
        var val_37 = 0;
        val_37 = val_37 + 1;
        T val_17 = val_34.Current;
        UnityEngine.Vector3 val_18 = val_17.position;
        UnityEngine.Vector3 val_21 = val_33.下丏丆下丙与丘上丁().transform.position;
        UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_18.x, y = val_18.y, z = val_18.z}, b:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z});
        float val_38 = val_22.x;
        if(val_38 >= 0)
        {
            goto label_61;
        }
        
        float val_23 = 万世专丘且万世七丒.丝丛丈丟丅一上世丞(丌丝下丄业一丄不三:  val_33, 丞下万上三丘上与专:  val_17);
        val_23 = val_23 * this.damageMultiplier;
        val_37 = val_23 * 0.7f;
        val_23 = val_23 - val_37;
        val_38 = 1f - (val_38 / ((val_35 * 与丗与丕丈丌与丄丝) * 与丗与丕丈丌与丄丝));
        val_39 = val_38 * val_23;
        val_38 = val_37 + val_39;
        if(this.isPoison != false)
        {
                this.poisonSettings.weaponName = val_33.三与丛丑且丐丈业丌();
            val_40 = null;
            val_40 = null;
            UnityEngine.Vector3 val_28 = this.transform.position;
            val_39 = val_28.x;
            val_37 = val_28.y;
            val_38 = val_28.z;
            丈丞与与丕丕一丝世(丞下万上三丘上与专:  val_17.gameObject, 专不丑且不丏东丟丅:  0, 丂且丑三且丌丘下丌:  new UnityEngine.Vector3() {x = val_39, y = val_37, z = val_38}, 丒下世丝丂万丑丏下:  val_38, 丌丒万丂丈不且丈丄:  this.poisonSettings);
        }
        
        UnityEngine.Vector3 val_32 = this.transform.position;
        val_33.下丏丆下丙与丘上丁().丆七丆与丅丕丝丂丐(丞下万上三丘上与专:  val_17.gameObject, 丞丈专下丈专业三丞:  val_38, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_32.x, y = val_32.y, z = val_32.z}, 丝三丛且丘不丌丙下:  val_33.三与丛丑且丐丈业丌(), 东丏业丞丞业下丄世:  this.typeDead, 丐丟丘世丁三丕专专:  24);
        goto label_61;
        label_32:
        val_41 = 0;
        val_33 = 0;
        if(val_34 == null)
        {
            
        }
        else
        {
                var val_39 = 0;
            val_39 = val_39 + 1;
            val_34.Dispose();
        }
        
        if( != 1)
        {
                return;
        }
        
        if( == false)
        {
                return;
        }
    
    }
    public WeaponAOEDamager()
    {
        this.onGroundEffectName = System.String.alignConst;
        this.damageRadius = Infinityf;
        this.damageMultiplier = 1f;
    }

}
