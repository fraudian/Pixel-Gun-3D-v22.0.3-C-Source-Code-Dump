using UnityEngine;
internal sealed class ArmRaceLoadoutsController : PGBehaviour
{
    // Fields
    public int weaponId;
    public int killCountOnCurrentLevel;
    public float timeBetweenLoadouts;
    public 三丈丟与丏丘丈丐万 curWeapon;
    public PGCompany.DataObjects.丞东三丒一丒下丈不.丗丄丑丄下丌三一丂 selectedLoadout;
    internal float 三世且丌一专下丂三;
    internal float 世七丈丕丑上丟丘丟;
    public System.Action movedToNextLevel;
    public System.Action addedKill;
    
    // Properties
    public int 丑下丌上丑一丁丟东 { get; }
    public bool 丝专丆丞上丒丐上且 { get; }
    public int 丈丞下丆不万三且东 { get; }
    public bool 上丌一丁丛丐丕丏丞 { get; }
    public PGCompany.DataObjects.丞东三丒一丒下丈不.七专丟丒七丆下丂丛 丟七丈且丙丒丆三上 { get; }
    
    // Methods
    public int LoadoutNumberInList(PGCompany.DataObjects.丞东三丒一丒下丈不.七专丟丒七丆下丂丛 丐三丞七丝丅不万丛)
    {
        var val_4;
        var val_5;
        val_4 = 0;
        val_5 = 0;
        goto label_1;
        label_6:
        val_4 = 1;
        label_1:
        if(val_4 < this.selectedLoadout.weapons.Count)
        {
            goto label_6;
        }
        
        return (int)(this.selectedLoadout.weapons.Item[0] == 丐三丞七丝丅不万丛) ? (val_4) : (val_5);
    }
    private void Start()
    {
    
    }
    private void Awake()
    {
        this.丂上丕丏丟下丙业七();
    }
    private void 丂上丕丏丟下丙业七()
    {
        var val_16;
        PGCompany.GameModeEvents.东万丟丝丏丟丅丟丒 val_17;
        var val_18;
        var val_20;
        丗丄丑丄下丌三一丂 val_21;
        var val_22;
        丗丄丑丄下丌三一丂 val_23;
        string val_2 = PGCompany.丒丒丛丙不万专三丆.丑七不且上丗丁一世().丘丑下丆上业丛一丄(丈丄丈世一且不不丁:  120);
        DataSystem.丈且丈上不下且丝丒 val_3 = DataSystem.丗专七丕丁丅丝万三.上丑丌专丅七七一丝();
        var val_15 = 0;
        val_15 = val_15 + 1;
        if(val_3.Count < 1)
        {
            goto label_11;
        }
        
        val_16 = null;
        val_16 = null;
        val_17 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_17 == null)
        {
            goto label_20;
        }
        
        val_17 = GameConnect.丈丝丂丐丟万丙丑丕;
        if(val_17 == null)
        {
                val_17 = 0;
        }
        
        string val_6 = val_17.丕丅丌丐丙丈丄丁丅();
        if((丞东丑专丛丆丄丝世.上丌丐丘丑丗丄丆丒(下业七不丑丂丏丟东:  val_6)) == false)
        {
            goto label_20;
        }
        
        val_18 = null;
        val_18 = null;
        if((ArmRaceLoadoutsController.<>c.<>9__10_0) == null)
        {
            goto label_23;
        }
        
        label_39:
        val_20 = val_6.FindIndex(match:  ArmRaceLoadoutsController.<>c.<>9__10_0);
        goto label_25;
        label_20:
        val_20 = 0;
        label_25:
        val_21 = val_3.Item[System.Math.Max(val1:  0, val2:  0)];
        val_22 = this;
        this.selectedLoadout = val_21;
        goto label_29;
        label_11:
        val_22 = this;
        this.selectedLoadout = new 丞东三丒一丒下丈不.丗丄丑丄下丌三一丂();
        System.Collections.Generic.List<七专丟丒七丆下丂丛> val_12 = new System.Collections.Generic.List<七专丟丒七丆下丂丛>();
        val_12.Add(item:  new 丞东三丒一丒下丈不.七专丟丒七丆下丂丛(世专丈丐东下丅丙丈:  "Weapon9", 丈下丑丆上丏丗丈专:  new System.Nullable<ItemRarity>() {HasValue = false}, 丝丄丁丅丗三上丅上:  false, 丞丗丄七专丈丕丕业:  1));
        .weapons = val_12;
        val_21 = this.selectedLoadout;
        label_29:
        val_23 = val_21;
        if(val_21 == null)
        {
                val_23 = this.selectedLoadout;
        }
        
        this.timeBetweenLoadouts = (float)mem[1152921524434042332];
        if(val_23 == null)
        {
            goto label_33;
        }
        
        this.三世且丌一专下丂三 = (float)mem[1152921524434042336];
        goto label_34;
        label_33:
        val_23 = this.selectedLoadout;
        this.三世且丌一专下丂三 = (float)mem[1152921524434042336];
        if(this.selectedLoadout == null)
        {
            goto label_35;
        }
        
        label_34:
        this.世七丈丕丑上丟丘丟 = (float)this.selectedLoadout.roundTime;
        return;
        label_23:
        ArmRaceLoadoutsController.<>c.<>9__10_0 = new System.Predicate<丗丄丑丄下丌三一丂>(object:  ArmRaceLoadoutsController.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean ArmRaceLoadoutsController.<>c::丛丟丏七丛丄丆丅丈(PGCompany.DataObjects.丞东三丒一丒下丈不.丗丄丑丄下丌三一丂 丐三丞七丝丅不万丛));
        if(val_6 != null)
        {
            goto label_39;
        }
        
        goto label_39;
        label_35:
    }
    private int 三世丒丙丌丂丂丁专(int 丞丗丄七专丈丕丕业)
    {
        var val_4;
        var val_5;
        val_4 = 0;
        val_5 = 0;
        goto label_1;
        label_8:
        七专丟丒七丆下丂丛 val_1 = this.selectedLoadout.weapons.Item[0];
        val_5 = val_1.killsToUpgrade + val_5;
        if(val_5 > 丞丗丄七专丈丕丕业)
        {
            goto label_5;
        }
        
        val_4 = 1;
        label_1:
        if(val_4 < this.selectedLoadout.weapons.Count)
        {
            goto label_8;
        }
        
        label_5:
        object val_3 = val_4 + 1;
        UnityEngine.Debug.LogError(message:  "LevelForKIlls returning " + val_3);
        return (int)val_3;
    }
    private void 丏丐丞业丘丝丌东丘()
    {
        int val_1 = this.killCountOnCurrentLevel;
        val_1 = val_1 + 1;
        this.killCountOnCurrentLevel = val_1;
        this.addedKill.Invoke();
    }
    public void GiveLoadoutWeapon(int 丞丅上丏丂且下丅与)
    {
        var val_8;
        WeaponManager val_9;
        var val_10;
        var val_11;
        this.curWeapon = new 三丈丟与丏丘丈丐万();
        七专丟丒七丆下丂丛 val_2 = this.selectedLoadout.weapons.Item[丞丅上丏丂且下丅与];
        .三丐三丞丘丕不丒专 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_2.weaponId);
        this.curWeapon.上丕丅丛不七业丙丘(丙业与丙丗丝不丈东:  this.curWeapon.三丐三丞丘丕不丒专.丟七下专丈丏丕丈上());
        this.curWeapon.业丑丝丐丟丞丟且上(丙业与丙丗丝不丈东:  this.curWeapon.三丐三丞丘丕不丒专.下世下丂丂丌丑丝世());
        val_8 = null;
        val_8 = null;
        val_9 = WeaponManager.丟丗丄业丘丗业丗七;
        if(val_9 == 0)
        {
                return;
        }
        
        val_10 = null;
        val_10 = null;
        val_9 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_9 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        if(val_9 == 0)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        专丐丏丒丘丟丁与丟(丞世不丒下上上丝丑:  0, 丟业下东与东专专业:  true);
    }
    public void CheckKillWithWeapon(string 丝三丛且丘不丌丙下)
    {
        int val_5 = this.weaponId;
        if(val_5 >= this.MaxLevel)
        {
                return;
        }
        
        val_5 = this.selectedLoadout.weapons.Item[this.weaponId];
        if((System.String.op_Inequality(a:  丝三丛且丘不丌丙下, b:  val_2.weaponId)) == true)
        {
                return;
        }
        
        this.丏丐丞业丘丝丌东丘();
        val_5 = this.weaponId;
        七专丟丒七丆下丂丛 val_4 = this.selectedLoadout.weapons.Item[val_5];
        if(this.killCountOnCurrentLevel < val_4.killsToUpgrade)
        {
                return;
        }
        
        this.七业一丞丑丌丞丞丈();
    }
    private void 七业一丞丑丌丞丞丈()
    {
        this.下专丘丗丅丞丄世丏(丐三丞七丝丅不万丛:  this.weaponId + 1);
        this.movedToNextLevel.Invoke();
    }
    private void 下专丘丗丅丞丄世丏(int 丐三丞七丝丅不万丛)
    {
        var val_6;
        var val_7;
        if(this.weaponId != 丐三丞七丝丅不万丛)
        {
                this.killCountOnCurrentLevel = 0;
        }
        
        this.weaponId = 丐三丞七丝丅不万丛;
        if(this.MaxLevel > 丐三丞七丝丅不万丛)
        {
                UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丝丂丞丗万丑且丘丛());
        }
        
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        丄丞丘丆丏丌丅丗丞(丙业与丙丗丝不丈东:  this.weaponId + 1);
    }
    public int get_CurrentLevel()
    {
        return (int)this.weaponId + 1;
    }
    public bool get_isFinalLoadout()
    {
        return (bool)(this.weaponId == (this.selectedLoadout.weapons.Count - 1)) ? 1 : 0;
    }
    public void StartActions()
    {
        this.下专丘丗丅丞丄世丏(丐三丞七丝丅不万丛:  this.weaponId);
    }
    private System.Collections.IEnumerator 丝丂丞丗万丑且丘丛()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ArmRaceLoadoutsController.下上三世丄丕丏丑丌();
    }
    public int GetLevelOfWeapon(string 丝三丛且丘不丌丙下)
    {
        var val_4;
        label_7:
        if(0 >= this.selectedLoadout.weapons.Count)
        {
            goto label_3;
        }
        
        七专丟丒七丆下丂丛 val_2 = this.selectedLoadout.weapons.Item[0];
        val_4 = 0 + 1;
        if((System.String.op_Equality(a:  val_2.weaponId, b:  丝三丛且丘不丌丙下)) == false)
        {
            goto label_7;
        }
        
        return (int)val_4;
        label_3:
        val_4 = 0;
        return (int)val_4;
    }
    public int get_MaxLevel()
    {
        if(this.selectedLoadout == null)
        {
                return 1;
        }
        
        if(this.selectedLoadout.weapons == null)
        {
                return 1;
        }
        
        return this.selectedLoadout.weapons.Count;
    }
    public bool get_HasWinnerLevel()
    {
        return (bool)(this.weaponId >= this.MaxLevel) ? 1 : 0;
    }
    public PGCompany.DataObjects.丞东三丒一丒下丈不.七专丟丒七丆下丂丛 get_CurrentWeapon()
    {
        int val_3;
        var val_4;
        val_3 = this;
        if(this.weaponId < this.selectedLoadout.weapons.Count)
        {
                val_3 = this.weaponId;
            七专丟丒七丆下丂丛 val_2 = this.selectedLoadout.weapons.Item[val_3];
            return (七专丟丒七丆下丂丛)val_4;
        }
        
        val_4 = 0;
        return (七专丟丒七丆下丂丛)val_4;
    }
    public ArmRaceLoadoutsController()
    {
        this.timeBetweenLoadouts = 1f;
        this.三世且丌一专下丂三 = 5f;
        this.世七丈丕丑上丟丘丟 = 500f;
    }

}
