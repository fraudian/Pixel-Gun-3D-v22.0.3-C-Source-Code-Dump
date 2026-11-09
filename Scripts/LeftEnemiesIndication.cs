using UnityEngine;
internal sealed class LeftEnemiesIndication : PGBehaviour
{
    // Fields
    private UnityEngine.Coroutine 丘丅专丛丟三丑上一;
    private UnityEngine.Coroutine 丅丂丂丆丛丒且丐万;
    private UnityEngine.Coroutine 下万丝丌万万丈丈丙;
    private System.Collections.Generic.List<WorldPosIndicationItem> 丈且丞三丝一与丛丟;
    private System.Collections.Generic.List<bool> 万丗丑丘与丞且丙不;
    private UnityEngine.AudioSource 丞下上且一上丙不丏;
    private bool 丕上与万且丏丝丗丈;
    private float 上丏丞万丏丗丝丈一;
    private float 三丑且丗丐专丁丅丟;
    
    // Methods
    private void Start()
    {
        var val_3;
        this.丞下上且一上丙不丏 = this.GetComponent<UnityEngine.AudioSource>();
        val_3 = null;
        val_3 = null;
        GameController.mode.丛世丝一万丒世丁七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void LeftEnemiesIndication::丗丄丞三丗丟七丗丏()));
    }
    private void 丗丄丞三丗丟七丗丏()
    {
        var val_8;
        var val_9;
        this.丌丑丈东不丛下一丒();
        if(GameConnect.一与东丝万上三丆丏() != true)
        {
                if(GameConnect.世丐丄三三上丅七三() != true)
        {
                if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
                return;
        }
        
        }
        
        }
        
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                val_8 = null;
            val_8 = null;
            if(与丂丏丛丞丞丒丟丄.丑丕一且丛丞丌丌丐 == false)
        {
                return;
        }
        
        }
        
        if(GameConnect.世丐丄三三上丅七三() != false)
        {
                val_9 = null;
            val_9 = null;
            if(与丂丏丛丞丞丒丟丄.丐丒丐万不丌丛丁丂 == false)
        {
                return;
        }
        
        }
        
        this.丘丅专丛丟三丑上一 = this.StartCoroutine(routine:  this.丞专丞丌丗丟丐丟丕());
    }
    private void 丌丑丈东不丛下一丒()
    {
        if(this.丘丅专丛丟三丑上一 != null)
        {
                this.StopCoroutine(routine:  this.丘丅专丛丟三丑上一);
        }
        
        if(this.丅丂丂丆丛丒且丐万 != null)
        {
                this.StopCoroutine(routine:  this.丅丂丂丆丛丒且丐万);
        }
        
        if(this.下万丝丌万万丈丈丙 != null)
        {
                this.StopCoroutine(routine:  this.下万丝丌万万丈丈丙);
        }
        
        this.丕上与万且丏丝丗丈 = false;
        this.业不丁丏七丝丙丌丗();
    }
    private void 业不丁丏七丝丙丌丗()
    {
        goto label_1;
        label_10:
        if(this.丈且丞三丝一与丛丟.Item[0] != 0)
        {
                this.丈且丞三丝一与丛丟.Item[0].gameObject.SetActive(value:  false);
        }
        
        0 = 1;
        label_1:
        if(0 < this.丈且丞三丝一与丛丟.Count)
        {
            goto label_10;
        }
    
    }
    private System.Collections.IEnumerator 丞专丞丌丗丟丐丟丕()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LeftEnemiesIndication.丕丐丐丆万不且丙专();
    }
    private double 丑一丅丂丑丑丈下丂()
    {
        System.Collections.Generic.List<NetworkStartTable> val_18;
        double val_19;
        var val_20;
        var val_21;
        var val_22;
        var val_23;
        var val_24;
        var val_25;
        val_18 = 1152921505066536960;
        val_19 = 0;
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                if(TeamDuelController.丅丌丛丏丞上万丛丕 != 0)
        {
                val_19 = (double)TeamDuelController.丅丌丛丏丞上万丛丕.timeLeft;
        }
        
        }
        
        if(GameConnect.丄丏丒丏上东业丒一() != false)
        {
                val_20 = null;
            val_20 = null;
            if(MutationController.丆丕丝丒不丙且丐丗 != 0)
        {
                val_21 = null;
            val_21 = null;
            val_19 = (double)MutationController.丆丕丝丒不丙且丐丗.丙世丑丅丒丑业与不();
        }
        
        }
        
        if(GameConnect.世丐丄三三上丅七三() == false)
        {
                return val_19;
        }
        
        val_18 = 1152921505084108800;
        if(MiniGamesController.丑七不且上丗丁一世() == 0)
        {
                return val_19;
        }
        
        MiniGamesController val_10 = MiniGamesController.丑七不且上丗丁一世();
        val_22 = 0;
        val_23 = 0;
        goto label_30;
        label_47:
        val_24 = null;
        val_24 = null;
        if(Item[0] != 0)
        {
                if(val_11.丌丑丛业丈丘世丞丕 != 0)
        {
                bool val_18 = val_11.丌丑丛业丈丘世丞丕.万丝一万丐且丌业丛;
            val_18 = val_18 ^ 1;
            val_23 = val_23 + val_18;
        }
        
        }
        
        val_22 = 1;
        label_30:
        val_25 = null;
        val_25 = null;
        val_18 = mem[GameController.onlineMode + 392];
        val_18 = GameController.onlineMode.丌丏丒上丆丏下与世;
        if(val_22 < Count)
        {
            goto label_47;
        }
        
        val_19 = (double)val_10.gameTimer;
        if(val_23 != true)
        {
                return val_19;
        }
        
        if(this.丕上与万且丏丝丗丈 != false)
        {
                float val_15 = UnityEngine.Time.time;
            val_15 = val_15 - this.上丏丞万丏丗丝丈一;
            var val_16 = (val_15 > this.三丑且丗丐专丁丅丟) ? 1 : (val_19);
            return val_19;
        }
        
        this.丕上与万且丏丝丗丈 = true;
        this.上丏丞万丏丗丝丈一 = UnityEngine.Time.time;
        return val_19;
    }
    private double 丁与丝丁不业一丁丄()
    {
        double val_5;
        var val_6;
        var val_7;
        val_5 = 0;
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                val_6 = null;
            val_6 = null;
            val_5 = (double)与丂丏丛丞丞丒丟丄.丌与丅丑与丈且丂丝;
        }
        
        val_7 = 0;
        if(GameConnect.世丐丄三三上丅七三() == false)
        {
                return (double)(GameConnect.丄丏丒丏上东业丒一() != true) ? 40 : (val_5);
        }
        
        if((((val_2 + 295) & 2) != 0) && ((val_2 + 216) == 0))
        {
                val_7 = null;
        }
        
        val_5 = (double)与丂丏丛丞丞丒丟丄.丙丘丗丐丞万丑丐下;
        return (double)(GameConnect.丄丏丒丏上东业丒一() != true) ? 40 : (val_5);
    }
    private void 丙丏丘不且丕丟丗丂()
    {
        this.丅丂丂丆丛丒且丐万 = this.StartCoroutine(routine:  this.一业上丗专丄丒丙丒());
        this.下万丝丌万万丈丈丙 = this.StartCoroutine(routine:  this.东丆丄一丌万业丏业());
        this.丛万业一三丝丌专丘();
    }
    private void 丛万业一三丝丌专丘()
    {
        InGameGUI val_8;
        var val_9;
        var val_10;
        val_8 = this;
        if(GameConnect.丄丏丒丏上东业丒一() != false)
        {
                val_9 = null;
            val_9 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable != 0)
        {
                val_10 = null;
            val_10 = null;
            if(且世专不丄丏七下万() == false)
        {
                return;
        }
        
        }
        
        }
        
        if(this.丞下上且一上丙不丏 != 0)
        {
                if(this.丞下上且一上丙不丏.clip != 0)
        {
                this.丞下上且一上丙不丏.Play();
        }
        
        }
        
        val_8 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_8 == 0)
        {
                return;
        }
        
        GadgetsSFX.__il2cppRuntimeField_method_count.Play();
    }
    private System.Collections.IEnumerator 东丆丄一丌万业丏业()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LeftEnemiesIndication.丌丗丌丆东丆丈丁丞();
    }
    private System.Collections.IEnumerator 一业上丗专丄丒丙丒()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LeftEnemiesIndication.丅七下丝不丐上丘万();
    }
    private void 丅专丏世丅世丞丅上()
    {
        var val_43;
        System.Collections.Generic.List<NetworkStartTable> val_44;
        var val_45;
        var val_46;
        System.Collections.Generic.List<System.Boolean> val_47;
        var val_48;
        var val_49;
        float val_50;
        float val_51;
        val_43 = null;
        val_43 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        if(typeof(Player_move_c).__il2cppRuntimeField_378 == 0)
        {
                return;
        }
        
        val_45 = null;
        val_45 = null;
        val_44 = mem[GameController.onlineMode + 392];
        val_44 = GameController.onlineMode.丌丏丒上丆丏下与世;
        val_46 = 0;
        goto label_14;
        label_17:
        this.万丗丑丘与丞且丙不.set_Item(index:  0, value:  false);
        val_46 = 1;
        label_14:
        if(val_46 < this.万丗丑丘与丞且丙不.Count)
        {
            goto label_17;
        }
        
        val_47 = this.万丗丑丘与丞且丙不;
        if(Count <= val_47.Count)
        {
            goto label_20;
        }
        
        val_48 = this.万丗丑丘与丞且丙不.Count;
        goto label_22;
        label_25:
        val_47 = this.万丗丑丘与丞且丙不;
        val_47.Add(item:  false);
        val_48 = val_48 + 1;
        label_22:
        if(val_48 < Count)
        {
            goto label_25;
        }
        
        label_20:
        val_49 = 0;
        goto label_26;
        label_84:
        val_47 = Item[0];
        if(val_47 == 0)
        {
            goto label_81;
        }
        
        NetworkStartTable val_10 = Item[0];
        val_47 = val_10.丌丑丛业丈丘世丞丕;
        if(val_47 == 0)
        {
            goto label_81;
        }
        
        NetworkStartTable val_12 = Item[0];
        val_47 = val_12.丌丑丛业丈丘世丞丕.myPlayerTransform;
        if(val_47 == 0)
        {
            goto label_81;
        }
        
        val_47 = val_12.丌丑丛业丈丘世丞丕.一丈丞丐与下且三专;
        if(Item[0].丘丑丅三丆丑丌且丝() == 0)
        {
            goto label_46;
        }
        
        val_47 = Item[0].丘丑丅三丆丑丌且丝();
        if(val_47 == typeof(Player_move_c).__il2cppRuntimeField_618.丘丑丅三丆丑丌且丝())
        {
            goto label_81;
        }
        
        label_46:
        if(GameConnect.丄丏丒丏上东业丒一() == false)
        {
            goto label_53;
        }
        
        if(typeof(Player_move_c).__il2cppRuntimeField_618.且世专不丄丏七下万() == false)
        {
            goto label_81;
        }
        
        val_47 = Item[0];
        if(val_47.且世专不丄丏七下万() == true)
        {
            goto label_81;
        }
        
        label_53:
        UnityEngine.Vector3 val_23 = val_12.丌丑丛业丈丘世丞丕.myPlayerTransform.position;
        UnityEngine.Vector3 val_24 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
        val_50 = val_24.z;
        UnityEngine.Vector3 val_25 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        val_47 = this.万丗丑丘与丞且丙不;
        val_51 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_24.x, y = val_24.y, z = val_50}, b:  new UnityEngine.Vector3() {x = val_25.x, y = val_25.y, z = val_25.z});
        val_47.set_Item(index:  0, value:  true);
        if(val_51 > 15f)
        {
            goto label_81;
        }
        
        UnityEngine.Vector3 val_27 = val_12.丌丑丛业丈丘世丞丕.myPlayerTransform.position;
        UnityEngine.Vector3 val_28 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        UnityEngine.Vector3 val_29 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_27.x, y = val_27.y, z = val_27.z}, b:  new UnityEngine.Vector3() {x = val_28.x, y = val_28.y, z = val_28.z});
        val_51 = val_29.x;
        val_50 = val_29.z;
        UnityEngine.Vector3 val_30 = typeof(Player_move_c).__il2cppRuntimeField_378.position;
        if((UnityEngine.Physics.Raycast(ray:  new UnityEngine.Ray() {m_Origin = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Direction = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  15f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.丞上万世业丙丗且丆())) == false)
        {
            goto label_70;
        }
        
        val_47;
        if((System.String.op_Equality(a:  0.name, b:  "BodyCollider")) == false)
        {
            goto label_81;
        }
        
        val_47 = 0.transform.parent;
        if(val_47 == 0)
        {
            goto label_81;
        }
        
        val_47 = val_12.丌丑丛业丈丘世丞丕.myPlayerTransform;
        if((0.transform.parent.Equals(other:  val_47)) == false)
        {
            goto label_81;
        }
        
        label_70:
        val_47 = this.万丗丑丘与丞且丙不;
        val_47.set_Item(index:  0, value:  false);
        label_81:
        val_49 = 1;
        label_26:
        if(val_49 < Count)
        {
            goto label_84;
        }
    
    }
    private void 丘丌丝丞三丝丆丘下()
    {
        var val_38;
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        System.Collections.Generic.List<WorldPosIndicationItem> val_43;
        var val_44;
        float val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        var val_50;
        if(WorldPosIndicationsController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_38 = 1152921505286238208;
        val_39 = null;
        val_39 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        val_40 = null;
        val_40 = null;
        if(丆丗丂三丐不东且丏() == true)
        {
                return;
        }
        
        val_41 = null;
        val_41 = null;
        val_42 = null;
        val_42 = null;
        if(ShopNGUIController.丛世丛与丌不丈丐丐() == true)
        {
                return;
        }
        
        BankController val_6 = BankController.丑七不且上丗丁一世();
        if(val_6.uiRoot.gameObject.activeInHierarchy == true)
        {
                return;
        }
        
        val_43 = 1152921539693056544;
        val_44 = 0;
        goto label_37;
        label_48:
        if(this.丈且丞三丝一与丛丟.Item[0] == 0)
        {
                WorldPosIndicationItem val_11 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem>();
            UnityEngine.Color val_13 = UnityEngine.Color.red;
            val_11.丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  val_11.丘丈世丗丞丒丞丒丁(丞丆丆专丆与丄不上:  0), 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a});
            UnityEngine.Color val_14 = UnityEngine.Color.red;
            val_45 = val_14.b;
            val_11.clampOnScreen = false;
            this.丈且丞三丝一与丛丟.set_Item(index:  0, value:  val_11);
        }
        
        val_44 = 1;
        label_37:
        if(val_44 < this.丈且丞三丝一与丛丟.Count)
        {
            goto label_48;
        }
        
        val_46 = null;
        val_46 = null;
        if(this.丈且丞三丝一与丛丟.Count >= Count)
        {
            goto label_54;
        }
        
        val_47 = this.丈且丞三丝一与丛丟.Count;
        goto label_56;
        label_63:
        WorldPosIndicationItem_Distanced val_19 = WorldPosIndicationsController.丄丘七三上丕世丞业.CreateItem<WorldPosIndicationItem_Distanced>();
        UnityEngine.Color val_21 = UnityEngine.Color.red;
        val_19.丙丈东丑丒丙上与丞(与万丆丛丒万丝丙丑:  val_19.丘丈世丗丞丒丞丒丁(丞丆丆专丆与丄不上:  0), 丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_21.r, g = val_21.g, b = val_21.b, a = val_21.a});
        UnityEngine.Color val_22 = UnityEngine.Color.red;
        val_45 = val_22.b;
        mem2[0] = 0;
        val_43 = this.丈且丞三丝一与丛丟;
        val_43.Add(item:  val_19);
        val_47 = val_47 + 1;
        label_56:
        if(val_47 < Count)
        {
            goto label_63;
        }
        
        label_54:
        this.业不丁丏七丝丙丌丗();
        val_38 = 0;
        goto label_64;
        label_100:
        WorldPosIndicationItem val_24 = this.丈且丞三丝一与丛丟.Item[0];
        val_43 = this.万丗丑丘与丞且丙不;
        if(val_43.Count > val_38)
        {
                val_43 = this.万丗丑丘与丞且丙不;
            if(val_43.Item[0] != false)
        {
                val_48 = null;
            val_48 = null;
            NetworkStartTable val_27 = Item[0];
            val_43 = val_27.丌丑丛业丈丘世丞丕;
            if(val_43 != 0)
        {
                val_49 = null;
            val_49 = null;
            NetworkStartTable val_29 = Item[0];
            val_43 = val_29.丌丑丛业丈丘世丞丕.myPlayerTransform;
            if(val_43 != 0)
        {
                val_24.gameObject.SetActive(value:  true);
            val_50 = null;
            val_50 = null;
            NetworkStartTable val_32 = Item[0];
            val_43 = val_32.丌丑丛业丈丘世丞丕.myPlayerTransform;
            UnityEngine.Vector3 val_33 = val_43.position;
            UnityEngine.Vector3 val_34 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_35 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_34.x, y = val_34.y, z = val_34.z}, d:  1.5f);
            UnityEngine.Vector3 val_36 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_33.x, y = val_33.y, z = val_33.z}, b:  new UnityEngine.Vector3() {x = val_35.x, y = val_35.y, z = val_35.z});
            val_45 = val_36.y;
            val_24.丝东不丄且不丏业丘(业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_36.x, y = val_45, z = val_36.z});
        }
        
        }
        
        }
        
        }
        
        val_38 = 1;
        label_64:
        if(val_38 < Count)
        {
            goto label_100;
        }
    
    }
    internal UnityEngine.Texture 丘丈世丗丞丒丞丒丁(int 丞丆丆专丆与丄不上)
    {
        var val_3;
        var val_4;
        val_3 = 丞丆丆专丆与丄不上;
        val_4 = 0;
        if(WorldPosIndicationsController.丄丘七三上丕世丞业 == 0)
        {
                return (UnityEngine.Texture)val_4;
        }
        
        val_3 = (long)val_3;
        UnityEngine.Texture[] val_2 = WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + (((long)(int)(丞丆丆专丆与丄不上)) << 3);
        val_4 = mem[(WorldPosIndicationsController.丄丘七三上丕世丞业.下丘丌万丈丌专三与 + ((long)(int)(丞丆丆专丆与丄不上)) << 3) + 32];
        return (UnityEngine.Texture)val_4;
    }
    public LeftEnemiesIndication()
    {
        this.丈且丞三丝一与丛丟 = new System.Collections.Generic.List<WorldPosIndicationItem>();
        this.万丗丑丘与丞且丙不 = new System.Collections.Generic.List<System.Boolean>();
        this.三丑且丗丐专丁丅丟 = 15f;
    }

}
