using UnityEngine;
internal sealed class BonusItem : MonoBehaviour
{
    // Fields
    public bool isActive;
    public bool isPickedUp;
    public 与丅丕丈丘东丝世丟 playerPicked;
    public UnityEngine.AudioClip[] itemSounds;
    public UnityEngine.GameObject[] itemMdls;
    private bool 丁丑丅丏丒不七上丁;
    private bool 丝丙七丒且丂丝与丏;
    private bool 丛丛世丑万东丗万专;
    public Rilisoft.专与丏丞三与不不丆 type;
    public double expireTime;
    public bool isTimeBonus;
    public int mySpawnNumber;
    public int myIndex;
    private UnityEngine.Transform 万一丂丐丄丁上与丟;
    private float _timeForHideBonuse;
    private float 丗丐七下三丑东万丌;
    private UnityEngine.GameObject _particleHideEffect;
    
    // Methods
    private void Awake()
    {
        null = null;
        this.丁丑丅丏丒不七上丁 = 与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁;
        this.丝丙七丒且丂丝与丏 = 与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏;
        this.丛丛世丑万东丗万专 = GameConnect.丙丘不世专且万丄丐();
        this.万一丂丐丄丁上与丟 = this.transform;
    }
    public void ActivateBonus(Rilisoft.专与丏丞三与不不丆 丁丅丈丌丟世丗丗丟, UnityEngine.Vector3 业丒丝丗与丐丛丟丏, double 专丌万丑三丙丕丙丝, int 丁丅丆丟上丄丅丟与, int 丞世不丒下上上丝丑)
    {
        if(this.isActive == true)
        {
                return;
        }
        
        this.type = 丁丅丈丌丟世丗丗丟;
        this.万一丂丐丄丁上与丟.position = new UnityEngine.Vector3() {x = 业丒丝丗与丐丛丟丏.x, y = 业丒丝丗与丐丛丟丏.y, z = 业丒丝丗与丐丛丟丏.z};
        this.万三丐丗丙丂丛丐东(丛与丙丒丒下丌丟且:  true);
        this.mySpawnNumber = 丁丅丆丟上丄丅丟与;
        this.myIndex = 丞世不丒下上上丝丑;
        this.expireTime = 专丌万丑三丙丕丙丝;
        this.isTimeBonus = (专丌万丑三丙丕丙丝 != (-1)) ? 1 : 0;
        this.isActive = true;
    }
    private void 万三丐丗丙丂丛丐东(bool 丛与丙丒丒下丌丟且 = True)
    {
        this.itemMdls[this.type].SetActive(value:  丛与丙丒丒下丌丟且);
    }
    public void DeactivateBonus()
    {
        this.playerPicked = 0;
        this.isActive = false;
        this.isPickedUp = false;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  100f);
        this.万一丂丐丄丁上与丟.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.万三丐丗丙丂丛丐东(丛与丙丒丒下丌丟且:  false);
    }
    public void PickupBonus(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        this.playerPicked = 专丞上七七且丝七丗;
        this.isPickedUp = true;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.down;
        UnityEngine.Vector3 val_2 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, d:  100f);
        this.万一丂丐丄丁上与丟.position = new UnityEngine.Vector3() {x = val_2.x, y = val_2.y, z = val_2.z};
        this.万三丐丗丙丂丛丐东(丛与丙丒丒下丌丟且:  false);
    }
    public void UpdateBonus()
    {
        System.Collections.Generic.List<PlayerBotController> val_123;
        var val_124;
        double val_125;
        float val_126;
        float val_127;
        var val_128;
        var val_129;
        var val_130;
        var val_131;
        var val_132;
        var val_133;
        var val_134;
        Rilisoft.专与丏丞三与不不丆 val_135;
        var val_136;
        int val_137;
        var val_138;
        if(this.isActive == false)
        {
                return;
        }
        
        if((GameConnect.与不丗丏万丙丞丌丑() != false) && (this.isActive != false))
        {
                if(this.type == 0)
        {
            goto label_6;
        }
        
        }
        
        if((this.isTimeBonus == false) || (丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false))
        {
            goto label_16;
        }
        
        val_123 = 1152921505171275776;
        val_124 = null;
        val_124 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_16;
        }
        
        val_125 = this.expireTime;
        if(丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() <= val_125)
        {
            goto label_16;
        }
        
        if((GameConnect.且丞丁东丝丗上丈业() == false) || (this.丗丐七下三丑东万丌 >= 0))
        {
            goto label_20;
        }
        
        if(this._particleHideEffect != 0)
        {
                this._particleHideEffect.SetActive(value:  true);
        }
        
        float val_6 = UnityEngine.Time.deltaTime;
        val_6 = this.丗丐七下三丑东万丌 + val_6;
        this.丗丐七下三丑东万丌 = val_6;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_9 = UnityEngine.Vector3.zero;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.Lerp(a:  new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z}, b:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, t:  this.丗丐七下三丑东万丌 / this._timeForHideBonuse);
        val_126 = val_11.x;
        val_127 = val_11.z;
        val_125 = val_11.y;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_126, y = val_125, z = val_127};
        label_16:
        val_128 = 1152921505286238208;
        val_129 = null;
        val_129 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_130 = null;
            val_130 = null;
            val_131 = null;
            val_131 = null;
            val_132 = null;
            val_132 = null;
            if(丄丝丝下丟丘丄丒丈() != true)
        {
                val_123 = 1152921505219145728;
            if(InGameGUI.丙丞专丌丁丞与不丐 != 0)
        {
                if(InGameGUI.丙丞专丌丁丞与不丐.isTurretInterfaceActive == true)
        {
            goto label_426;
        }
        
        }
        
            val_133 = null;
            val_133 = null;
        }
        
        }
        
        label_426:
        if(PlayerBotsManager.与一丅丝不丈业与丙() == 0)
        {
                return;
        }
        
        val_128 = 1152921525522827936;
        val_134 = 0;
        goto label_66;
        label_187:
        PlayerBotsManager val_17 = PlayerBotsManager.与一丅丝不丈业与丙();
        if(val_17.业丌上丁下七不丐丝.Item[0].丟丌下三七丁与丟丑() == false)
        {
            goto label_173;
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_75;
        }
        
        PlayerBotsManager val_21 = PlayerBotsManager.与一丅丝不丈业与丙();
        PlayerBotController val_22 = val_21.业丌上丁下七不丐丝.Item[0];
        if(val_22.丗丈东丕不丘三丞业.世丌丐丁丂一丘丂一.且世专不丄丏七下万() == true)
        {
            goto label_173;
        }
        
        label_75:
        PlayerBotsManager val_24 = PlayerBotsManager.与一丅丝不丈业与丙();
        PlayerBotController val_25 = val_24.业丌上丁下七不丐丝.Item[0];
        if(val_25.丗丈东丕不丘三丞业.isScenarioBot == true)
        {
            goto label_173;
        }
        
        PlayerBotsManager val_26 = PlayerBotsManager.与一丅丝不丈业与丙();
        PlayerBotController val_27 = val_26.业丌上丁下七不丐丝.Item[0];
        if(val_27.player == 0)
        {
            goto label_173;
        }
        
        PlayerBotsManager val_29 = PlayerBotsManager.与一丅丝不丈业与丙();
        PlayerBotController val_30 = val_29.业丌上丁下七不丐丝.Item[0];
        if(val_30.player.丕丁丘丆万丄世专丛 != 0)
        {
                PlayerBotsManager val_32 = PlayerBotsManager.与一丅丝不丈业与丙();
            PlayerBotController val_33 = val_32.业丌上丁下七不丐丝.Item[0];
            if(val_33.player.丕丁丘丆万丄世专丛.万丝一万丐且丌业丛 != true)
        {
                PlayerBotsManager val_34 = PlayerBotsManager.与一丅丝不丈业与丙();
            PlayerBotController val_35 = val_34.业丌上丁下七不丐丝.Item[0];
            if(val_35.player.丕丁丘丆万丄世专丛.东丑丌丄丝世丞丘三 != true)
        {
                PlayerBotsManager val_36 = PlayerBotsManager.与一丅丝不丈业与丙();
            PlayerBotController val_37 = val_36.业丌上丁下七不丐丝.Item[0];
            if(val_37.丗丈东丕不丘三丞业.isScenarioBot != true)
        {
                PlayerBotsManager val_38 = PlayerBotsManager.与一丅丝不丈业与丙();
            PlayerBotController val_39 = val_38.业丌上丁下七不丐丝.Item[0];
            if(val_39.player != 0)
        {
                PlayerBotsManager val_41 = PlayerBotsManager.与一丅丝不丈业与丙();
            PlayerBotController val_42 = val_41.业丌上丁下七不丐丝.Item[0];
            if(val_42.player.丕丁丘丆万丄世专丛 != 0)
        {
                PlayerBotsManager val_44 = PlayerBotsManager.与一丅丝不丈业与丙();
            PlayerBotController val_45 = val_44.业丌上丁下七不丐丝.Item[0];
            if(val_45.player.丕丁丘丆万丄世专丛.万丝一万丐且丌业丛 != true)
        {
                PlayerBotsManager val_46 = PlayerBotsManager.与一丅丝不丈业与丙();
            PlayerBotController val_47 = val_46.业丌上丁下七不丐丝.Item[0];
            if(val_47.player.丕丁丘丆万丄世专丛.东丑丌丄丝世丞丘三 != true)
        {
                UnityEngine.Vector3 val_48 = this.万一丂丐丄丁上与丟.position;
            val_126 = val_48.x;
            val_127 = val_48.z;
            PlayerBotsManager val_49 = PlayerBotsManager.与一丅丝不丈业与丙();
            UnityEngine.Vector3 val_52 = val_49.业丌上丁下七不丐丝.Item[0].transform.position;
            val_126 = val_126;
            UnityEngine.Vector3 val_53 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_126, y = val_48.y, z = val_127}, b:  new UnityEngine.Vector3() {x = val_52.x, y = val_52.y, z = val_52.z});
            if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_53.x, y = val_53.y, z = val_53.z})) < 0)
        {
                PlayerBotsManager val_55 = PlayerBotsManager.与一丅丝不丈业与丙();
            PlayerBotController val_56 = val_55.业丌上丁下七不丐丝.Item[0];
            val_135 = this.type;
            if(val_56.player == null)
        {
                val_135 = val_135;
        }
        
            val_56.player.丒丕丒东七丛丑丄一(丁丅丈丌丟世丗丗丟:  val_135);
            val_136 = null;
            val_136 = null;
            val_137 = this.myIndex;
            if(BonusController.丄丞丁丈与业上丞丟 == null)
        {
                val_137 = val_137;
        }
        
            BonusController.丄丞丁丈与业上丞丟.丂下上不不上专东丞(丞世不丒下上上丝丑:  val_137);
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        }
        
        label_173:
        val_134 = 1;
        label_66:
        PlayerBotsManager val_57 = PlayerBotsManager.与一丅丝不丈业与丙();
        val_123 = val_57.业丌上丁下七不丐丝;
        if(val_134 < val_123.Count)
        {
            goto label_187;
        }
        
        return;
        label_6:
        this.DeactivateBonus();
        return;
        label_20:
        if(this._particleHideEffect != 0)
        {
                this._particleHideEffect.SetActive(value:  false);
        }
        
        this.丗丐七下三丑东万丌 = 0f;
        val_138 = null;
        val_138 = null;
        BonusController.丄丞丁丈与业上丞丟.丂下上不不上专东丞(丞世不丒下上上丝丑:  this.myIndex);
    }
    public BonusItem()
    {
        this.isActive = true;
        int val_3 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).Length;
        this.itemSounds = new UnityEngine.AudioClip[0];
        int val_7 = System.Enum.GetValues(enumType:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())).Length;
        this.itemMdls = new UnityEngine.GameObject[0];
        this.expireTime = -1;
        this.mySpawnNumber = 0;
        this._timeForHideBonuse = 2f;
    }

}
