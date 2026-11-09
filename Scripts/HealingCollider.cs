using UnityEngine;
public class HealingCollider : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<HealingCollider.丗七丈与丞丌下上丛> _listBuffType;
    public float deltaTime;
    private float regenerationPercent;
    private float 与丆一丞丏丄丙专东;
    private bool 专丒丄丌丂丙丟世丅;
    private UnityEngine.AudioClip _clip;
    private UnityEngine.BoxCollider 且丙与丏下丅丐世丑;
    private BoxIsInside 丕一三丝丆丒丙上丟;
    private UnityEngine.BoxCollider 万丄丏丟丏丞丗丟丐;
    
    // Methods
    public void RegisterPlayer()
    {
        this.专丒丄丌丂丙丟世丅 = true;
        float val_1 = UnityEngine.Time.time;
        val_1 = val_1 + this.deltaTime;
        this.与丆一丞丏丄丙专东 = val_1;
    }
    public void UnregisterPlayer()
    {
        this.专丒丄丌丂丙丟世丅 = false;
    }
    private void Awake()
    {
        this.丕一三丝丆丒丙上丟 = this.gameObject.AddComponent<BoxIsInside>();
        UnityEngine.BoxCollider val_4 = this.gameObject.GetComponent<UnityEngine.BoxCollider>();
        this.万丄丏丟丏丞丗丟丐 = val_4;
        if(val_4 == 0)
        {
                return;
        }
        
        this.万丄丏丟丏丞丗丟丐.enabled = false;
    }
    private void Update()
    {
        var val_17;
        var val_18;
        var val_19;
        float val_20;
        var val_21;
        var val_22;
        val_17 = null;
        val_17 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_22;
        }
        
        val_18 = null;
        val_18 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
            goto label_11;
        }
        
        label_22:
        this.专丒丄丌丂丙丟世丅 = false;
        return;
        label_11:
        if(this.专丒丄丌丂丙丟世丅 == false)
        {
            goto label_12;
        }
        
        if(this.万丄丏丟丏丞丗丟丐 == 0)
        {
            goto label_33;
        }
        
        val_19 = null;
        val_19 = null;
        UnityEngine.Vector3 val_5 = transform.position;
        val_20 = val_5.x;
        if((this.丕一三丝丆丒丙上丟.IsInsideBox(且丙与丏下丅丐世丑:  this.万丄丏丟丏丞丗丟丐, 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = val_20, y = val_5.y, z = val_5.z})) == false)
        {
            goto label_22;
        }
        
        goto label_33;
        label_12:
        if(this.万丄丏丟丏丞丗丟丐 != 0)
        {
                val_21 = null;
            val_21 = null;
            UnityEngine.Vector3 val_9 = transform.position;
            val_20 = val_9.x;
            if((this.丕一三丝丆丒丙上丟.IsInsideBox(且丙与丏下丅丐世丑:  this.万丄丏丟丏丞丗丟丐, 丅专与丒丈丗丒丘丌:  new UnityEngine.Vector3() {x = val_20, y = val_9.y, z = val_9.z})) != false)
        {
                this.专丒丄丌丂丙丟世丅 = true;
            val_20 = UnityEngine.Time.time + this.deltaTime;
            this.与丆一丞丏丄丙专东 = val_20;
        }
        
        }
        
        label_33:
        if(this.专丒丄丌丂丙丟世丅 == false)
        {
                return;
        }
        
        float val_12 = UnityEngine.Time.time;
        if(this.与丆一丞丏丄丙专东 >= 0)
        {
                return;
        }
        
        val_22 = null;
        val_22 = null;
        if((this._listBuffType.Contains(item:  1)) != false)
        {
                this.丁三丗丛丕万七东丗();
        }
        
        if((this._listBuffType.Contains(item:  2)) != false)
        {
                this.丝一业七丞丆丞东丈();
        }
        
        if((this._listBuffType.Contains(item:  3)) != false)
        {
                this.丂业丒丅东专丕丘丐();
        }
        
        float val_16 = UnityEngine.Time.time;
        val_16 = val_16 + this.deltaTime;
        this.与丆一丞丏丄丙专东 = val_16;
    }
    private void 丁三丗丛丕万七东丗()
    {
        var val_7;
        WeaponManager val_8;
        val_7 = null;
        val_7 = null;
        val_8 = WeaponManager.丟丗丄业丘丗业丗七;
        if(WeaponManager.丟丗丄业丘丗业丗七 != null)
        {
            goto label_3;
        }
        
        val_8 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_8 == null)
        {
            goto label_4;
        }
        
        label_3:
        float val_1 = typeof(Player_move_c).__il2cppRuntimeField_600.maxHealth;
        val_1 = this.regenerationPercent * val_1;
        if((丂丟丙丂丕专丂七下(上上丗丁丏丙丄丏七:  val_1, 丑东与丅丐丅丂丞业:  6)) != false)
        {
                if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                GadgetsSFX.__il2cppRuntimeField_generic_class.Play();
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(this._clip == 0)
        {
                return;
        }
        
        UnityEngine.AudioSource val_6 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this._clip);
        return;
        label_4:
    }
    private void 丂业丒丅东专丕丘丐()
    {
        var val_13;
        float val_14;
        var val_15;
        var val_17;
        var val_18;
        if((GameConnect.丄专业丝一丏丕丐万(丁丅丈丌丟世丗丗丟:  22)) != null)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        val_14 = typeof(Player_move_c).__il2cppRuntimeField_DE0.七丁丙丅丂上丒丞丙();
        if(val_14 < typeof(Player_move_c).__il2cppRuntimeField_DE0.丈下丏丟丑丐丆三不())
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        val_14 = this.regenerationPercent * typeof(Player_move_c).__il2cppRuntimeField_DE0.七丁丙丅丂上丒丞丙();
        if((val_14 + typeof(Player_move_c).__il2cppRuntimeField_DE0.丈下丏丟丑丐丆三不()) > typeof(Player_move_c).__il2cppRuntimeField_DE0.七丁丙丅丂上丒丞丙())
        {
                val_17 = null;
            val_17 = null;
            val_14 = typeof(Player_move_c).__il2cppRuntimeField_DE0.七丁丙丅丂上丒丞丙() - typeof(Player_move_c).__il2cppRuntimeField_DE0.丈下丏丟丑丐丆三不();
        }
        
        val_18 = null;
        val_18 = null;
        typeof(Player_move_c).__il2cppRuntimeField_DE0.下东丞丆专丟丙丝丒(下丝丘丁专丐丅丛丝:  val_14);
        丌与专丑不且专丌一(丞丂丌丆丅丘下与丕:  val_14, 丑东与丅丐丅丂丞业:  1);
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(this._clip == 0)
        {
                return;
        }
        
        UnityEngine.AudioSource val_12 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this._clip);
    }
    private void 丝一业七丞丆丞东丈()
    {
        null = null;
        bool val_1 = WeaponManager.丟丗丄业丘丗业丗七.丕丗丐丁丌丏丙丗不();
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        if(this._clip == 0)
        {
                return;
        }
        
        UnityEngine.AudioSource val_4 = 不丌丂丁丄一与丆丙.丛不上丛一丆丛丅下(丏世一不与丗丏三不:  this._clip);
    }
    public HealingCollider()
    {
        this._listBuffType = new System.Collections.Generic.List<丗七丈与丞丌下上丛>();
        this.deltaTime = 2.5f;
        this.regenerationPercent = 0.25f;
    }

}
