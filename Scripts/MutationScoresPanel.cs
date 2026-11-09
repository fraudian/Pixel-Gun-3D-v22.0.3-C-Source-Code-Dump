using UnityEngine;
internal sealed class MutationScoresPanel : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject friendsHumanIcon;
    private UnityEngine.GameObject enemiesHumanIcon;
    private UnityEngine.GameObject friendsZombieIcon;
    private UnityEngine.GameObject enemiesZombieIcon;
    private UILabel friendsActiveLabel;
    private UILabel enemiesActiveLabel;
    
    // Methods
    private void Update()
    {
        object val_8;
        UILabel val_15;
        object val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        var val_21;
        var val_22;
        val_15 = this;
        val_16 = 1152921505286238208;
        val_17 = null;
        val_17 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_18 = null;
        val_18 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        bool val_3 = (typeof(Player_move_c).__il2cppRuntimeField_AA8 == 0) ? 1 : 0;
        this.friendsHumanIcon.SetActive(value:  val_3);
        this.enemiesZombieIcon.SetActive(value:  val_3);
        this.friendsZombieIcon.SetActive(value:  (typeof(Player_move_c).__il2cppRuntimeField_AA8 != 0) ? 1 : 0);
        this.enemiesHumanIcon.SetActive(value:  (typeof(Player_move_c).__il2cppRuntimeField_AA8 != 0) ? 1 : 0);
        val_20 = null;
        val_20 = null;
        List.Enumerator<T> val_6 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        val_21 = 0;
        val_22 = 0;
        goto label_30;
        label_31:
        if(this.enemiesZombieIcon != 0)
        {
                if(val_8.丐丏七丌丕丗业且上().且世专不丄丏七下万() != false)
        {
                val_22 = 1;
        }
        else
        {
                val_21 = 1;
        }
        
        }
        
        label_30:
        if(((-564756912) & 1) != 0)
        {
            goto label_31;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_8 = (typeof(Player_move_c).__il2cppRuntimeField_AA8 != 0) ? (val_22) : (val_21);
        val_16 = val_8;
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  this.friendsActiveLabel, 丕丗丘丑丛与丑业丒:  val_8);
        val_15 = this.enemiesActiveLabel;
        val_8 = (typeof(Player_move_c).__il2cppRuntimeField_AA8 != 0) ? (val_21) : (val_22);
        丞东丑专丛丆丄丝世.丒丁丅一下丂专万不(七丐丞丑丑丕世丙七:  val_15, 丕丗丘丑丛与丑业丒:  val_8);
    }
    public MutationScoresPanel()
    {
    
    }

}
