using UnityEngine;
internal class ChestsBattleRoyaleController : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    internal static int 与丗一丕下丞世丟上;
    public ChestBatleRoyale[] chests;
    public ChestsPointsBattleRoyale[] points;
    public ChestBatleRoyale[] airDropChests;
    public AirDropItem[] airDropItems;
    public AirDropItem[] gadgetChest;
    internal static ChestsBattleRoyaleController 丄丘七三上丕世丞业;
    internal static readonly int[] 丂丛丞丌丟一三丕丂;
    internal static readonly int[] 与丙丟丝且丅与丕丌;
    internal static readonly int[] 东三丞丛丟丙不不丝;
    internal static readonly int[] 丑丕丑丈丐丞丒丙丈;
    internal static readonly int[] 丅万丈丘丌丗丞上丆;
    internal static readonly string[][] 丐不万不丄丙丐丝业;
    internal static readonly int[][] 专万丏丝丟丈丝丄丕;
    internal static readonly int[] 东丂丆丈东万上丁东;
    internal static readonly int[] 丛丟丒且丌丏世丕世;
    internal static readonly int[] 与且丕七三丌丂丘丞;
    internal static readonly int[] 三丐世丅东丛东丘丝;
    internal static readonly int[] 世丘丌东丟丂丌且丞;
    internal static readonly int[][] 万专与丌丗一丅丝丟;
    public int countAirDronInWave;
    private static string 丁业不丄一丄丌东丛;
    private bool 一东丈七丏丛东上一;
    private AirDropPoints _airdropPoint;
    private int 三东专七丘丈丁三丟;
    private int 丈丞下丙世丐不丝丟;
    
    // Properties
    internal static string[] 三丒且丐丆七丌东丝 { get; }
    internal static int 丝上丑世上一丝且丆 { get; }
    internal static bool 丈丁丁丐丕丌丝丑世 { get; }
    
    // Methods
    internal static string[] 业业丂丕东丆丏万不()
    {
        null = null;
        int val_3 = UnityEngine.Mathf.Clamp(value:  ChestsBattleRoyaleController.丛丛与丁丄丅丕且丄(), min:  0, max:  ChestsBattleRoyaleController.丐不万不丄丙丐丝业.Length - 1);
        System.String[][] val_4 = ChestsBattleRoyaleController.丐不万不丄丙丐丝业 + (((long)(int)(val_3)) << 3);
        return (System.String[])(ChestsBattleRoyaleController.丐不万不丄丙丐丝业 + ((long)(int)(val_3)) << 3) + 32;
    }
    internal static int 丛丛与丁丄丅丕且丄()
    {
        var val_8;
        var val_9;
        var val_10;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return 0;
        }
        
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_9 = null;
        val_9 = null;
        if((val_8.ContainsKey(key:  GameConnect.丂业东业丏丝三丛万)) == false)
        {
                return 0;
        }
        
        val_10 = null;
        val_10 = null;
        return System.Convert.ToInt32(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丂业东业丏丝三丛万]);
    }
    internal static bool 丐丝丞上丐丏丈丐丗()
    {
        var val_3 = null;
        return (bool)(ChestsBattleRoyaleController.丛丛与丁丄丅丕且丄() != 1) ? 1 : 0;
    }
    private void Start()
    {
        var val_1;
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        val_1 = null;
        val_1 = null;
        ChestsBattleRoyaleController.丄丘七三上丕世丞业 = this;
    }
    private void OnDestroy()
    {
        null = null;
        ChestsBattleRoyaleController.丄丘七三上丕世丞业 = 0;
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
    }
    internal ChestsBattleRoyaleController()
    {
        this.countAirDronInWave = 2;
        this.三东专七丘丈丁三丟 = 0;
        this.丈丞下丙世丐不丝丟 = 0;
        Rilisoft.且三与世丁丏丂丌下 val_1 = this.与丑丌丌丌丁丌不丕();
        val_1.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  public System.Void ChestsBattleRoyaleController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        Rilisoft.且三与世丁丏丂丌下 val_3 = this.与丑丌丌丌丁丌不丕();
        val_3.下世丁丄且丘一丁下 = new System.Action(object:  this, method:  System.Void ChestsBattleRoyaleController::OnDisconnectedFromPhoton());
    }
    private void Update()
    {
        var val_44;
        var val_45;
        var val_46;
        bool val_47;
        var val_48;
        var val_49;
        ChestBatleRoyale[] val_50;
        short val_51;
        var val_52;
        var val_53;
        PointChestBattleRoyale[] val_54;
        var val_55;
        if(UnityEngine.Application.isEditor != false)
        {
                if(UnityEngine.Application.isPlaying == false)
        {
            goto label_2;
        }
        
        }
        
        if(this.一东丈七丏丛东上一 == false)
        {
            goto label_3;
        }
        
        label_99:
        val_44 = null;
        val_44 = null;
        val_45 = null;
        val_45 = null;
        val_46 = 0;
        val_47 = UnityEngine.Object.op_Inequality(x:  WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC, y:  0);
        goto label_11;
        label_16:
        this.chests[0].UpdateChest(世丑丙下丝丌万丄丟:  UnityEngine.Object.op_Inequality(x:  ScopeViewGameEventsController.丄丘七三上丕世丞业, y:  0), 七一下一丐丈丄七下:  val_47);
        val_46 = 1;
        label_11:
        if(val_46 < this.chests.Length)
        {
            goto label_16;
        }
        
        return;
        label_3:
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
            goto label_99;
        }
        
        val_48 = null;
        val_48 = null;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().ContainsKey(key:  ChestsBattleRoyaleController.丁业不丄一丄丌东丛)) == false)
        {
            goto label_27;
        }
        
        val_49 = null;
        val_49 = null;
        this.丛不丄与丅丘丙丁与(一不丑七万万丁不丌:  System.Convert.ToInt32(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[ChestsBattleRoyaleController.丁业不丄一丄丌东丛]));
        goto label_99;
        label_2:
        val_50 = this.gameObject.transform.GetComponentsInChildren<ChestBatleRoyale>();
        val_51 = 0;
        this.chests = val_50;
        goto label_39;
        label_44:
        val_46 = 0;
        ChestBatleRoyale val_43 = this.chests[val_46];
        this.chests[0x0][0].index = val_51;
        val_50 = this.chests;
        val_51 = W22 + 1;
        label_39:
        if(((int)val_51 & 65535) < this.chests.Length)
        {
            goto label_44;
        }
        
        val_52 = 0;
        this.airDropItems = this.transform.GetComponentsInChildren<AirDropItem>();
        goto label_46;
        label_95:
        UnityEngine.Transform val_21 = this.gameObject.transform.GetChild(index:  0);
        if((val_21.name.Contains(value:  "Points")) == false)
        {
            goto label_51;
        }
        
        int val_24 = val_21.childCount;
        val_53 = 0;
        this.points = new ChestsPointsBattleRoyale[0];
        goto label_53;
        label_92:
        UnityEngine.Transform val_26 = val_21.GetChild(index:  0);
        if(val_26 != null)
        {
                val_54 = val_26.GetComponentsInChildren<PointChestBattleRoyale>();
            val_55 = val_26;
        }
        else
        {
                val_54 = 0.GetComponentsInChildren<PointChestBattleRoyale>();
            val_55 = 0;
        }
        
        T[] val_29 = val_55.GetComponentsInChildren<ChestBatleRoyale>();
        ChestsPointsBattleRoyale val_30 = new ChestsPointsBattleRoyale();
        if(this.points == null)
        {
            goto label_57;
        }
        
        if(val_30 != null)
        {
            goto label_58;
        }
        
        goto label_61;
        label_57:
        if(val_30 == null)
        {
            goto label_61;
        }
        
        label_58:
        label_61:
        this.points[0] = val_30;
        ChestsPointsBattleRoyale val_44 = this.points[0];
        this.points[0x0][0].nameLocation = val_55.gameObject.name;
        ChestsPointsBattleRoyale val_45 = this.points[0];
        this.points[0x0][0].points = val_54;
        ChestsPointsBattleRoyale val_46 = this.points[0];
        this.points[0x0][0].chests = val_29;
        ChestsPointsBattleRoyale val_47 = this.points[0];
        ChestsPointsBattleRoyale val_48 = this.points[0];
        if(this.points[0x0][0].points.Length < this.points[0x0][0].chests.Length)
        {
                ChestsPointsBattleRoyale val_49 = this.points[0];
            UnityEngine.Debug.LogError(message:  "Андрей, сундуков не может быть больше чем точек!!!\nДобавь точек в "("Андрей, сундуков не может быть больше чем точек!!!\nДобавь точек в ") + this.points[0x0][0].nameLocation);
        }
        
        val_46 = val_55.gameObject;
        if((System.String.op_Equality(a:  val_46.name, b:  "AirDrop")) != false)
        {
                this.airDropChests = val_29;
        }
        
        val_53 = 1;
        label_53:
        if(val_53 < val_21.childCount)
        {
            goto label_92;
        }
        
        label_51:
        val_52 = val_52 + 1;
        label_46:
        val_47 = this.gameObject.transform;
        if(val_52 < val_47.childCount)
        {
            goto label_95;
        }
        
        return;
        label_27:
        bool val_41 = 丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东();
        if(val_41 == false)
        {
            goto label_99;
        }
        
        val_41.丛且与丂丟丕丕丕且();
        goto label_99;
    }
    private void 丛不丄与丅丘丙丁与(int 一不丑七万万丁不丌)
    {
        var val_24;
        ChestsPointsBattleRoyale[] val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        System.Random val_30;
        var val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        System.Random val_36;
        var val_37;
        ChestBatleRoyale val_38;
        var val_39;
        var val_40;
        var val_41;
        System.Random val_42;
        丞上七丈丗丝与丏丄 val_44;
        System.Random val_45;
        this.一东丈七丏丛东上一 = true;
        if(this.points.Length == 0)
        {
            goto label_2;
        }
        
        System.Random val_1 = new System.Random(Seed:  一不丑七万万丁不丌);
        val_24 = 0;
        goto label_3;
        label_9:
        ChestsPointsBattleRoyale val_24 = this.points[0];
        val_24 = 1;
        label_3:
        val_25 = this.points;
        if(val_24 < this.points.Length)
        {
            goto label_9;
        }
        
        val_26 = 1152921505048539136;
        val_27 = 0;
        goto label_10;
        label_185:
        val_28 = 0;
        goto label_11;
        label_183:
        val_29 = null;
        if(ChestsBattleRoyaleController.丐丝丞上丐丏丈丐丗() == true)
        {
            goto label_14;
        }
        
        ChestsPointsBattleRoyale val_25 = this.points[0];
        val_25 = 0;
        ChestBatleRoyale val_26 = this.points[0x0][0].chests[val_25];
        if(this.points[0x0][0].chests[0x0][0].typeChest == 4)
        {
            goto label_166;
        }
        
        label_14:
        ChestsPointsBattleRoyale val_27 = this.points[0];
        val_30 = val_1;
        if(val_30 == 0)
        {
                val_30 = val_1;
        }
        
        val_31 = val_30;
        goto label_27;
        label_38:
        ChestsPointsBattleRoyale val_28 = this.points[0];
        label_27:
        ChestsPointsBattleRoyale val_29 = this.points[0];
        PointChestBattleRoyale val_30 = this.points[0x0][0].points[(long)(1152921525686605729 < this.points[0x0][0].points.Length) ? 1152921525686605729 : 0];
        if((this.points[0x0][0].points[(long)(int)(1152921525686605729 < this.points[0x0][0].points.Length ? 1152921525686605729 : 0)][0].isUsed) == true)
        {
            goto label_38;
        }
        
        ChestsPointsBattleRoyale val_31 = this.points[0];
        ChestsPointsBattleRoyale val_33 = this.points[0];
        UnityEngine.Vector3 val_6 = this.points[0x0][0].points[(long)(1152921525686605729 < this.points[0x0][0].points.Length) ? 1152921525686605729 : 0].transform.position;
        this.points[0x0][0].chests[0].transform.position = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        ChestsPointsBattleRoyale val_35 = this.points[0];
        PointChestBattleRoyale val_36 = this.points[0x0][0].points[(long)(1152921525686605729 < this.points[0x0][0].points.Length) ? 1152921525686605729 : 0];
        val_32 = 0;
        val_33 = 0;
        this.points[0x0][0].points[(long)(int)(1152921525686605729 < this.points[0x0][0].points.Length ? 1152921525686605729 : 0)][0].isUsed = true;
        goto label_59;
        label_83:
        val_34 = null;
        val_34 = null;
        ChestsPointsBattleRoyale val_37 = this.points[0];
        ChestBatleRoyale val_38 = this.points[0x0][0].chests[0];
        System.Int32[][] val_7 = ChestsBattleRoyaleController.万专与丌丗一丅丝丟 + ((this.points[0x0][0].chests[0x0][0].typeChest) << 3);
        var val_8 = ((ChestsBattleRoyaleController.万专与丌丗一丅丝丟 + (this.points[0x0][0].chests[0x0][0].typeChest) << 3) + 32) + 0;
        val_32 = 1;
        val_33 = (((ChestsBattleRoyaleController.万专与丌丗一丅丝丟 + (this.points[0x0][0].chests[0x0][0].typeChest) << 3) + 32 + 0) + 32) + val_33;
        label_59:
        val_35 = null;
        val_35 = null;
        ChestsPointsBattleRoyale val_39 = this.points[0];
        ChestBatleRoyale val_40 = this.points[0x0][0].chests[0];
        System.Int32[][] val_9 = ChestsBattleRoyaleController.万专与丌丗一丅丝丟 + ((this.points[0x0][0].chests[0x0][0].typeChest) << 3);
        if(val_32 < ((ChestsBattleRoyaleController.万专与丌丗一丅丝丟 + (this.points[0x0][0].chests[0x0][0].typeChest) << 3) + 32 + 24))
        {
            goto label_83;
        }
        
        val_36 = val_1;
        if(val_36 == 0)
        {
                val_36 = val_1;
        }
        
        var val_10 = val_33 + 1;
        val_37 = 0;
        val_38 = 0;
        goto label_85;
        label_110:
        val_37 = 1;
        label_85:
        val_39 = null;
        val_39 = null;
        ChestsPointsBattleRoyale val_41 = this.points[0];
        ChestBatleRoyale val_42 = this.points[0x0][0].chests[0];
        System.Int32[][] val_11 = ChestsBattleRoyaleController.万专与丌丗一丅丝丟 + ((this.points[0x0][0].chests[0x0][0].typeChest) << 3);
        val_26 = 1152921505048539136;
        if(val_37 >= ((ChestsBattleRoyaleController.万专与丌丗一丅丝丟 + (this.points[0x0][0].chests[0x0][0].typeChest) << 3) + 32 + 24))
        {
            goto label_97;
        }
        
        val_40 = null;
        val_40 = null;
        ChestsPointsBattleRoyale val_43 = this.points[0];
        ChestBatleRoyale val_44 = this.points[0x0][0].chests[0];
        System.Int32[][] val_12 = ChestsBattleRoyaleController.万专与丌丗一丅丝丟 + ((this.points[0x0][0].chests[0x0][0].typeChest) << 3);
        var val_13 = ((ChestsBattleRoyaleController.万专与丌丗一丅丝丟 + (this.points[0x0][0].chests[0x0][0].typeChest) << 3) + 32) + 4;
        val_38 = (((ChestsBattleRoyaleController.万专与丌丗一丅丝丟 + (this.points[0x0][0].chests[0x0][0].typeChest) << 3) + 32 + 4) + 32) + val_38;
        if(val_38 < val_36)
        {
            goto label_110;
        }
        
        val_26 = 1152921505048539136;
        goto label_111;
        label_97:
        val_37 = 0;
        label_111:
        val_41 = null;
        if(ChestsBattleRoyaleController.专万丏丝丟丈丝丄丕 == null)
        {
                val_41 = null;
        }
        
        if(val_37 < ChestsBattleRoyaleController.专万丏丝丟丈丝丄丕.Length)
        {
                val_41 = null;
            val_42 = val_1;
            if(val_42 == 0)
        {
                val_42 = val_1;
        }
        
            ChestsPointsBattleRoyale val_45 = this.points[0];
            val_38 = this.points[0x0][0].chests[0];
            val_26 = 1152921505048539136;
            var val_14 = (ChestsBattleRoyaleController.专万丏丝丟丈丝丄丕.Length + 32) + (-1580310912);
            this.points[0x0][0].chests[0x0][0].weaponBonusName = System.String.Format(format:  "Weapon{0}", arg0:  (ChestsBattleRoyaleController.专万丏丝丟丈丝丄丕.Length + 32 + -1580310912) + 32);
            ChestsPointsBattleRoyale val_46 = this.points[0];
            val_25 = this.points[0x0][0].chests[0];
            val_44 = 1;
        }
        else
        {
                System.String[] val_16 = ChestsBattleRoyaleController.业业丂丕东丆丏万不();
            val_45 = val_1;
            if(val_45 == 0)
        {
                val_45 = val_1;
        }
        
            ChestsPointsBattleRoyale val_47 = this.points[0];
            ChestBatleRoyale val_48 = this.points[0x0][0].chests[0];
            this.points[0x0][0].chests[0x0][0].weaponBonusName = System.String.Format(format:  "gadget_{0}", arg0:  ChestsBattleRoyaleController.业业丂丕东丆丏万不()[-395077728]);
            ChestsPointsBattleRoyale val_50 = this.points[0];
            val_25 = this.points[0x0][0].chests[0];
            val_44 = 2;
        }
        
        val_25.丑与且且且丁丐丆丐(丙业与丙丗丝不丈东:  val_44);
        if(ChestsBattleRoyaleController.丐丝丞上丐丏丈丐丗() != false)
        {
                ChestsPointsBattleRoyale val_51 = this.points[0];
            ChestBatleRoyale val_52 = this.points[0x0][0].chests[0];
            if(this.points[0x0][0].chests[0x0][0].typeChest == 3)
        {
                System.String[] val_20 = ChestsBattleRoyaleController.业业丂丕东丆丏万不();
            val_25 = System.String.Format(format:  "gadget_{0}", arg0:  ChestsBattleRoyaleController.业业丂丕东丆丏万不()[-395077728]);
            ChestsPointsBattleRoyale val_54 = this.points[0];
            System.Collections.Generic.List<AdditionalItem> val_23 = null;
            val_38 = val_23;
            val_23 = new System.Collections.Generic.List<AdditionalItem>();
            val_23.Add(item:  new AdditionalItem() {typeItem = 2, weaponBonusName = val_25});
            this.points[0x0][0].chests[0].AddListAdditionalBonus(七丘专世丙丟世世丕:  val_23);
        }
        
        }
        
        label_166:
        val_28 = 1;
        label_11:
        ChestsPointsBattleRoyale val_56 = this.points[0];
        if(val_28 < this.points[0x0][0].chests.Length)
        {
            goto label_183;
        }
        
        val_27 = 1;
        label_10:
        if(val_27 < this.points.Length)
        {
            goto label_185;
        }
        
        return;
        label_2:
        UnityEngine.Debug.LogError(message:  "СУНДУКОВ НЕТ!!!\nСкажите Константину Приходько, что бы включил точки.");
    }
    private void 丛且与丂丟丕丕丕且()
    {
        var val_4;
        ExitGames.Client.Photon.Hashtable val_2 = new ExitGames.Client.Photon.Hashtable();
        val_4 = null;
        val_4 = null;
        val_2.set_Item(key:  ChestsBattleRoyaleController.丁业不丄一丄丌东丛, value:  UnityEngine.Random.Range(min:  1, max:  16));
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    public void KillChest(short 丞世不丒下上上丝丑)
    {
        short val_8;
        var val_9;
        System.Object[] val_10;
        var val_11;
        PhotonTargets val_12;
        val_8 = 丞世不丒下上上丝丑;
        val_9 = this;
        ChestBatleRoyale val_8 = this.chests[(int)val_8 & 65535];
        if((this.chests[(int)(short)((丞世不丒下上上丝丑) & 0xFFFF)][0].typeChest) == 3)
        {
                if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上() == null)
        {
                return;
        }
        
            val_9 = this.photonView;
            val_10 = new object[2];
            val_10[0] = val_8;
            val_8 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
            val_10[1] = val_8;
            val_11 = 34;
            val_12 = 6;
        }
        else
        {
                val_9 = this.photonView;
            object[] val_7 = new object[1];
            val_10 = val_7;
            val_8 = val_8;
            val_10[0] = val_8;
            val_11 = 34;
            val_12 = 3;
        }
        
        val_9.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  34, 丞下万上三丘上与专:  val_12, 丗丟上上丒丐丗丞丙:  val_7);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_3;
        UnityEngine.Vector3[] val_4;
        int val_5;
        var val_6;
        var val_7;
        int val_8;
        var val_9;
        var val_10;
        int val_11;
        val_3 = 丞世不丒下上上丝丑;
        byte val_1 = val_3 & 255;
        if(val_1 > 133)
        {
            goto label_1;
        }
        
        if(val_1 == 34)
        {
            goto label_2;
        }
        
        if(val_1 != 133)
        {
            goto label_10;
        }
        
        val_3 = 专丒丌丆下丐丞丟丞[0];
        if(val_3 == null)
        {
            goto label_6;
        }
        
        val_4 = val_3;
        if(val_4 != null)
        {
            goto label_7;
        }
        
        label_6:
        val_4 = 0;
        label_7:
        this.丄丘不丌丝一丈世丘(丝丂丗丝丌丈万丁丌:  val_4);
        goto label_27;
        label_1:
        if(val_1 == 140)
        {
            goto label_9;
        }
        
        if(val_1 != 170)
        {
            goto label_10;
        }
        
        val_5 = 专丒丌丆下丐丞丟丞.Length;
        if(val_5 == 0)
        {
                val_5 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_3 = 专丒丌丆下丐丞丟丞[0];
        object val_4 = 专丒丌丆下丐丞丟丞[1];
        this.且七三丏丂专丁丆丘(丞世不丒下上上丝丑:  61440, 丐丌丌丈下丁丝丅万:  21884928);
        goto label_27;
        label_10:
        val_6 = 0;
        return (bool)val_6;
        label_2:
        if(专丒丌丆下丐丞丟丞 == null)
        {
            goto label_16;
        }
        
        val_7 = 专丒丌丆下丐丞丟丞;
        val_8 = 专丒丌丆下丐丞丟丞.Length;
        if(val_8 != 1)
        {
            goto label_17;
        }
        
        label_26:
        object val_5 = 专丒丌丆下丐丞丟丞[0];
        val_10 = 0;
        goto label_19;
        label_9:
        val_11 = 专丒丌丆下丐丞丟丞.Length;
        if(val_11 == 0)
        {
                val_11 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_6 = 专丒丌丆下丐丞丟丞[0];
        if(val_11 <= 1)
        {
                val_11 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_7 = 专丒丌丆下丐丞丟丞[1];
        if(val_11 <= 2)
        {
                val_11 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_8 = 专丒丌丆下丐丞丟丞[2];
        object val_9 = 专丒丌丆下丐丞丟丞[3];
        this.丄上丏丘丌下万丘且(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = 3.782474E-38f, y = V9.16B, z = V10.16B}, 业丝不丄丒七上丅丅:  21884928, 不丘与三且丙三上丟:  21884928, 一下丗丌丒丏不丘不:  1.28822976017949E-231);
        goto label_27;
        label_16:
        val_7 = 24;
        val_3 = 28563616;
        val_8 = 28563616;
        if(val_3 == 1)
        {
            goto label_26;
        }
        
        label_17:
        if(val_8 != 2)
        {
            goto label_27;
        }
        
        object val_10 = 专丒丌丆下丐丞丟丞[0];
        object val_11 = 专丒丌丆下丐丞丟丞[1];
        val_9 = 1152921504628731904;
        label_19:
        this.丛专丐丄上下丘丂丛(丞世不丒下上上丝丑:  61440, 丐丌丌丈下丁丝丅万:  21884928);
        label_27:
        val_6 = 1;
        return (bool)val_6;
    }
    internal void 丛专丐丄上下丘丂丛(short 丞世不丒下上上丝丑)
    {
        this.丛专丐丄上下丘丂丛(丞世不丒下上上丝丑:  丞世不丒下上上丝丑, 丐丌丌丈下丁丝丅万:  0);
    }
    internal void 丛专丐丄上下丘丂丛(short 丞世不丒下上上丝丑, int 丐丌丌丈下丁丝丅万)
    {
        ChestBatleRoyale val_28;
        ChestBatleRoyale val_29;
        float val_30;
        float val_31;
        float val_32;
        var val_33;
        float val_34;
        float val_35;
        float val_36;
        var val_37;
        float val_38;
        float val_39;
        var val_40;
        val_28 = this;
        val_29 = this.chests[(int)丞世不丒下上上丝丑 & 65535];
        if((this.chests[(int)(short)((丞世不丒下上上丝丑) & 0xFFFF)][0].state) != 1)
        {
                return;
        }
        
        val_29 = this.chests[(int)丞世不丒下上上丝丑 & 65535].gameObject;
        if(val_29.activeSelf == false)
        {
                return;
        }
        
        val_29 = this.chests;
        if(((int)丞世不丒下上上丝丑 & 65535) >= this.chests.Length)
        {
                return;
        }
        
        val_29 = this.chests[(int)丞世不丒下上上丝丑 & 65535];
        if((this.chests[(int)(short)((丞世不丒下上上丝丑) & 0xFFFF)][0].typeChest) == 3)
        {
                val_29 = 1152921505107111936;
            if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上() != null)
        {
                val_29 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
            if(val_29.业丐丐三丕一丗丛丁() == 丐丌丌丈下丁丝丅万)
        {
                UnityEngine.Vector3 val_7 = this.chests[(int)丞世不丒下上上丝丑 & 65535].transform.position;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_9 = UnityEngine.Vector3.down;
            val_30 = val_8.x;
            val_31 = val_8.y;
            val_32 = val_8.z;
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_32}, direction:  new UnityEngine.Vector3() {x = val_9.x, y = val_9.y, z = val_9.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  3000f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.业万与丑丟丏丕丕业())) != false)
        {
                val_33 = null;
            val_33 = null;
            val_30 = val_30;
            val_31 = val_31;
            val_32 = val_32;
            BonusController.丄丞丁丈与业上丞丟.丘业世下丌丗丕三丕(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_30, y = val_31, z = val_32}, 丌下丏丐丕丏不丗一:  0);
        }
        
            UnityEngine.Vector3 val_13 = this.chests[(int)丞世不丒下上上丝丑 & 65535].transform.position;
            UnityEngine.Vector3 val_14 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            UnityEngine.Vector3 val_15 = UnityEngine.Vector3.down;
            val_34 = val_14.x;
            val_35 = val_14.y;
            val_36 = val_14.z;
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_34, y = val_35, z = val_36}, direction:  new UnityEngine.Vector3() {x = val_15.x, y = val_15.y, z = val_15.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  3000f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.业万与丑丟丏丕丕业())) != false)
        {
                val_37 = null;
            val_37 = null;
            val_34 = val_34;
            val_35 = val_35;
            val_36 = val_36;
            BonusController.丄丞丁丈与业上丞丟.丘业世下丌丗丕三丕(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_34, y = val_35, z = val_36}, 丌下丏丐丕丏不丗一:  (UnityEngine.Random.value > 0.3f) ? 13 : 12);
        }
        
            UnityEngine.Vector3 val_21 = this.chests[(int)丞世不丒下上上丝丑 & 65535].transform.position;
            UnityEngine.Vector3 val_22 = UnityEngine.Vector3.op_Addition(a:  new UnityEngine.Vector3() {x = val_21.x, y = val_21.y, z = val_21.z}, b:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f});
            val_38 = val_22.x;
            val_39 = val_22.z;
            UnityEngine.Vector3 val_23 = UnityEngine.Vector3.down;
            if((UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = val_38, y = val_22.y, z = val_39}, direction:  new UnityEngine.Vector3() {x = val_23.x, y = val_23.y, z = val_23.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  3000f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.业万与丑丟丏丕丕业())) != false)
        {
                val_38 = val_38;
            val_39 = val_39;
            val_40 = null;
            val_40 = null;
            BonusController.丄丞丁丈与业上丞丟.丘业世下丌丗丕三丕(下业丕七东丌丝下且:  new UnityEngine.Vector3() {x = val_38, y = val_22.y, z = val_39}, 丌下丏丐丕丏不丗一:  (UnityEngine.Random.value > 0.3f) ? 16 : 15);
        }
        
            this.chests[(int)丞世不丒下上上丝丑 & 65535].且不七丄且专丅东丌();
        }
        
        }
        
        }
        
        val_28 = this.chests[(int)丞世不丒下上上丝丑 & 65535];
        val_28.SetBonusState();
    }
    public void GetBonus(short 丞世不丒下上上丝丑)
    {
        short val_6;
        var val_7;
        var val_8;
        val_6 = 丞世不丒下上上丝丑;
        val_7 = this;
        if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上() == null)
        {
                return;
        }
        
        if( != null)
        {
                val_8 = null;
            val_8 = null;
            typeof(Player_move_c).__il2cppRuntimeField_538.Add(item:  (int)val_6 & 65535);
        }
        
        val_7 = this.photonView;
        object[] val_3 = new object[2];
        val_3[0] = val_6;
        val_6 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁();
        val_3[1] = val_6;
        val_7.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  170, 丞下万上三丘上与专:  6, 丗丟上上丒丐丗丞丙:  val_3);
    }
    internal void 且七三丏丂专丁丆丘(short 丞世不丒下上上丝丑, int 丐丌丌丈下丁丝丅万)
    {
        ChestBatleRoyale val_7;
        var val_8;
        var val_9;
        val_7 = 丐丌丌丈下丁丝丅万;
        ChestBatleRoyale val_7 = this.chests[(int)丞世不丒下上上丝丑 & 65535];
        if((this.chests[(int)(short)((丞世不丒下上上丝丑) & 0xFFFF)][0].isBonusUsed) != false)
        {
                return;
        }
        
        ChestBatleRoyale val_8 = this.chests[(int)丞世不丒下上上丝丑 & 65535];
        this.chests[(int)(short)((丞世不丒下上上丝丑) & 0xFFFF)][0].isBonusUsed = true;
        val_8 = null;
        val_8 = null;
        if(((WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0) || (丅丒丗丑丒丙丛不丆.且上世且一丈丞专上() == null)) || (丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().业丐丐三丕一丗丛丁() != val_7))
        {
            goto label_34;
        }
        
        if( != null)
        {
                val_9 = null;
            val_9 = null;
            bool val_5 = typeof(Player_move_c).__il2cppRuntimeField_538.Remove(item:  (int)丞世不丒下上上丝丑 & 65535);
        }
        
        val_7 = this.chests[(int)丞世不丒下上上丝丑 & 65535];
        丞上七丈丗丝与丏丄 val_6 = val_7.丙与世丏丂丞丂丑丛();
        if(val_6 == 2)
        {
            goto label_32;
        }
        
        if(val_6 != 1)
        {
            goto label_34;
        }
        
        this.丆丌且三丟丒丟丛丁(丞世不丒下上上丝丑:  (int)丞世不丒下上上丝丑 & 65535);
        goto label_34;
        label_32:
        this.丏下丕丏丘丅与丂丐(丞世不丒下上上丝丑:  (int)丞世不丒下上上丝丑 & 65535);
        label_34:
        this.chests[(int)丞世不丒下上上丝丑 & 65535].DelBonus();
    }
    public void AirDrop(UnityEngine.Vector3 下业丕七东丌丝下且, float 且丛上丕业丂丒与一)
    {
        var val_10;
        ChestBatleRoyale[] val_11;
        if(this.countAirDronInWave < 1)
        {
                return;
        }
        
        val_10 = 0;
        label_28:
        val_11 = this.airDropChests;
        int val_1 = this.丈丞下丙世丐不丝丟 + 1;
        this.丈丞下丙世丐不丝丟 = val_1;
        if(val_1 >= this.airDropChests.Length)
        {
                return;
        }
        
        int val_2 = this.三东专七丘丈丁三丟 + 1;
        this.三东专七丘丈丁三丟 = val_2;
        if(val_2 >= this.airDropItems.Length)
        {
                this.三东专七丘丈丁三丟 = 0;
        }
        
        UnityEngine.Vector3 val_3 = this._airdropPoint.七丘丅丆三不上七丆(丗上下丂万丑上与丌:  new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z}, 且丛上丕业丂丒与一:  且丛上丕业丂丒与一);
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.down;
        bool val_6 = UnityEngine.Physics.Raycast(origin:  new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, direction:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, hitInfo: out  new UnityEngine.RaycastHit() {m_Point = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Normal = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f}, m_Distance = 0f, m_UV = new UnityEngine.Vector2() {x = 0f, y = 0f}}, maxDistance:  3000f, layerMask:  Rilisoft.与丄丁丄丙丞下下丙.业万与丑丟丏丕丕业());
        object[] val_8 = new object[4];
        val_11 = val_8;
        if(val_11 == null)
        {
            goto label_10;
        }
        
        if(0f != 0)
        {
            goto label_11;
        }
        
        goto label_14;
        label_10:
        if(0f == 0)
        {
            goto label_14;
        }
        
        label_11:
        label_14:
        val_11[0] = 0f;
        val_11[1] = this.三东专七丘丈丁三丟;
        val_11[2] = this.丈丞下丙世丐不丝丟;
        val_11[3] = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  140, 丞下万上三丘上与专:  5, 丗丟上上丒丐丗丞丙:  val_8);
        val_10 = val_10 + 1;
        if(val_10 < this.countAirDronInWave)
        {
            goto label_28;
        }
    
    }
    internal void 丄上丏丘丌下万丘且(UnityEngine.Vector3 下业丕七东丌丝下且, int 业丝不丄丒七上丅丅, int 不丘与三且丙三上丟, double 一下丗丌丒丏不丘不)
    {
        this.三东专七丘丈丁三丟 = 业丝不丄丒七上丅丅;
        this.丈丞下丙世丐不丝丟 = 不丘与三且丙三上丟;
        this.airDropItems[(long)业丝不丄丒七上丅丅].transform.position = new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z};
        AirDropItem val_10 = this.airDropItems[(long)业丝不丄丒七上丅丅];
        this.airDropItems[(long)(int)(业丝不丄丒七上丅丅)][0].timeStart = 一下丗丌丒丏不丘不;
        AirDropItem val_11 = this.airDropItems[(long)业丝不丄丒七上丅丅];
        this.airDropItems[(long)(int)(业丝不丄丒七上丅丅)][0].chestIndex = 不丘与三且丙三上丟;
        this.airDropChests[(long)不丘与三且丙三上丟].transform.position = new UnityEngine.Vector3() {x = 下业丕七东丌丝下且.x, y = 下业丕七东丌丝下且.y, z = 下业丕七东丌丝下且.z};
        this.airDropChests[(long)不丘与三且丙三上丟].gameObject.SetActive(value:  false);
        AirDropItem val_14 = this.airDropItems[(long)业丝不丄丒七上丅丅];
        UnityEngine.GameObject val_4 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.airDropItems[(long)(int)(业丝不丄丒七上丅丅)][0].smokePrefab);
        if(val_4 != null)
        {
                val_4.SetActive(value:  true);
        }
        else
        {
                val_4.SetActive(value:  true);
        }
        
        val_4.transform.parent = this.airDropItems[(long)业丝不丄丒七上丅丅].transform;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        val_4.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        AirDropItem val_16 = this.airDropItems[(long)业丝不丄丒七上丅丅];
        this.airDropItems[(long)(int)(业丝不丄丒七上丅丅)][0].curSmoke = val_4;
    }
    public void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        object val_15;
        object val_16;
        var val_17;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_16 = 0;
        goto label_4;
        label_36:
        AirDropItem val_15 = this.airDropItems[0];
        if(this.airDropItems[0x0][0].timeStart <= 0f)
        {
            goto label_8;
        }
        
        object[] val_3 = new object[4];
        UnityEngine.Vector3 val_5 = this.airDropItems[0].transform.position;
        if(val_3 == null)
        {
            goto label_13;
        }
        
        if(val_5 != 0)
        {
            goto label_14;
        }
        
        goto label_17;
        label_13:
        if(val_5 == 0)
        {
            goto label_17;
        }
        
        label_14:
        label_17:
        val_3[0] = val_5;
        val_3[1] = val_16;
        AirDropItem val_17 = this.airDropItems[0];
        val_3[2] = this.airDropItems[0x0][0].chestIndex;
        AirDropItem val_18 = this.airDropItems[0];
        val_3[3] = this.airDropItems[0x0][0].timeStart;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  140, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_3);
        label_8:
        val_16 = 1;
        label_4:
        if(val_16 < this.airDropItems.Length)
        {
            goto label_36;
        }
        
        System.Collections.Generic.List<UnityEngine.Vector3> val_6 = null;
        val_15 = val_6;
        val_6 = new System.Collections.Generic.List<UnityEngine.Vector3>();
        val_17 = 0;
        goto label_37;
        label_49:
        val_16 = 0;
        UnityEngine.Vector3 val_8 = this.airDropChests[val_16].transform.position;
        if(val_8.y > (-5000f))
        {
                UnityEngine.Vector3 val_10 = this.airDropChests[val_16].transform.position;
            val_6.Add(item:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z});
        }
        
        val_17 = 1;
        label_37:
        if(val_17 < this.airDropChests.Length)
        {
            goto label_49;
        }
        
        if(val_6.Count < 1)
        {
                return;
        }
        
        object[] val_13 = new object[1];
        val_15 = val_6.ToArray();
        val_13[0] = val_15;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  133, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_13);
    }
    private void OnDisconnectedFromPhoton()
    {
        var val_12;
        float val_13;
        var val_14;
        val_12 = 0;
        goto label_1;
        label_32:
        ChestBatleRoyale val_12 = this.airDropChests[0];
        if(this.airDropChests[0x0][0].chestSmoke != 0)
        {
                ChestBatleRoyale val_13 = this.airDropChests[0];
            UnityEngine.Object.Destroy(obj:  this.airDropChests[0x0][0].chestSmoke);
            ChestBatleRoyale val_14 = this.airDropChests[0];
            this.airDropChests[0x0][0].chestSmoke = 0;
        }
        
        if(this.airDropChests[0].gameObject.activeSelf != true)
        {
                this.airDropChests[0].gameObject.SetActive(value:  true);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, d:  10000f);
            val_13 = val_7.y;
            this.airDropChests[0].transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_13, z = val_7.z};
        }
        
        val_12 = 1;
        label_1:
        if(val_12 < this.airDropChests.Length)
        {
            goto label_32;
        }
        
        val_14 = 0;
        goto label_33;
        label_62:
        AirDropItem val_18 = this.airDropItems[0];
        if(this.airDropItems[0x0][0].timeStart > 0f)
        {
                AirDropItem val_19 = this.airDropItems[0];
            this.airDropItems[0x0][0].timeStart = -1;
            AirDropItem val_20 = this.airDropItems[0];
            if(this.airDropItems[0x0][0].curSmoke != 0)
        {
                AirDropItem val_21 = this.airDropItems[0];
            UnityEngine.Object.Destroy(obj:  this.airDropItems[0x0][0].curSmoke);
            AirDropItem val_22 = this.airDropItems[0];
            this.airDropItems[0x0][0].curSmoke = 0;
        }
        
            UnityEngine.Vector3 val_10 = UnityEngine.Vector3.down;
            UnityEngine.Vector3 val_11 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z}, d:  20000f);
            val_13 = val_11.y;
            this.airDropItems[0].transform.position = new UnityEngine.Vector3() {x = val_11.x, y = val_13, z = val_11.z};
        }
        
        val_14 = 1;
        label_33:
        if(val_14 < this.airDropItems.Length)
        {
            goto label_62;
        }
    
    }
    private void 丄丘不丌丝一丈世丘(UnityEngine.Vector3[] 丝丂丗丝丌丈万丁丌)
    {
        ChestBatleRoyale[] val_10;
        var val_11;
        float val_12;
        val_11 = 0;
        goto label_1;
        label_45:
        val_10 = this.airDropChests;
        if(val_11 < this.airDropChests.Length)
        {
                var val_2 = 丝丂丗丝丌丈万丁丌 + (0 * 12);
            val_12 = mem[(0 * 12) + 丝丂丗丝丌丈万丁丌 + 32 + 4];
            val_12 = (0 * 12) + 丝丂丗丝丌丈万丁丌 + 32 + 4;
            this.airDropChests[0].transform.position = new UnityEngine.Vector3() {x = (0 * 12) + 丝丂丗丝丌丈万丁丌 + 32, y = val_12, z = (0 * 12) + 丝丂丗丝丌丈万丁丌 + 40};
            this.airDropChests[0].IsActiveChest = true;
            val_10 = this.airDropChests[0];
            if(this.airDropChests[0x0][0].state == 1)
        {
                ChestBatleRoyale val_13 = this.airDropChests[0];
            val_10 = this.airDropChests[0x0][0].chestSmoke;
            if(val_10 == 0)
        {
                AirDropItem val_14 = this.airDropItems[0];
            val_10 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  this.airDropItems[0].smokePrefab);
            if(val_10 != null)
        {
                val_10.SetActive(value:  true);
        }
        else
        {
                val_10.SetActive(value:  true);
        }
        
            val_10.transform.parent = this.airDropChests[0].transform;
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
            val_10.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
            UnityEngine.Quaternion val_10 = UnityEngine.Quaternion.Euler(x:  -90f, y:  0f, z:  0f);
            val_12 = val_10.y;
            val_10.transform.localRotation = new UnityEngine.Quaternion() {x = val_10.x, y = val_12, z = val_10.z, w = val_10.w};
            ChestBatleRoyale val_16 = this.airDropChests[0];
            this.airDropChests[0x0][0].chestSmoke = val_10;
        }
        
        }
        
        }
        
        val_11 = 1;
        label_1:
        if(val_11 < 丝丂丗丝丌丈万丁丌.Length)
        {
            goto label_45;
        }
    
    }
    private void 丆丌且三丟丒丟丛丁(int 丞世不丒下上上丝丑)
    {
        string val_41;
        var val_42;
        var val_43;
        var val_44;
        string val_45;
        var val_46;
        var val_47;
        var val_48;
        string val_49;
        var val_50;
        var val_51;
        var val_52;
        var val_53;
        int val_54;
        string val_55;
        var val_56;
        var val_57;
        int val_58;
        int val_59;
        丞上七丈丗丝与丏丄 val_60;
        string val_61;
        var val_62;
        var val_63;
        var val_64;
        ChestsBattleRoyaleController.三丂丝丆丆丈丅丟且 val_1 = new ChestsBattleRoyaleController.三丂丝丆丆丈丅丟且();
        ChestBatleRoyale val_41 = this.chests[(long)丞世不丒下上上丝丑];
        val_41 = this.chests[(long)(int)(丞世不丒下上上丝丑)][0].weaponBonusName;
        if(val_41 == null)
        {
                val_41 = System.String.alignConst;
        }
        
        三丅丁丗丗丝丂万且 val_2 = 丏丄丑上丛不丈且万.三丕丑丙丄上丆七下(丟丈一下东业一丝丆:  val_41);
        if(val_1 == null)
        {
            goto label_7;
        }
        
        val_42 = val_1;
        .丆丐七世世且丏丐业 = val_2;
        if(val_2 == null)
        {
            goto label_8;
        }
        
        label_61:
        val_43 = null;
        if( == null)
        {
            goto label_11;
        }
        
        val_44 = null;
        val_45 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与();
        val_46 = null;
        if(val_45.Count < WeaponManager.丂丐丛业世丝丁丛丕)
        {
            goto label_79;
        }
        
        val_47 = 0;
        goto label_17;
        label_41:
        三丈丟与丏丘丈丐万 val_6 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
        if(val_6.三丐三丞丘丕不丒专.万上丄下业丛丌不丈() != .丆丐七世世且丏丐业.万上丄下业丛丌不丈())
        {
            goto label_25;
        }
        
        val_48 = null;
        val_48 = null;
        三丈丟与丏丘丈丐万 val_10 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0];
        ChestBatleRoyale val_42 = this.chests[(long)丞世不丒下上上丝丑];
        val_49 = this.chests[(long)(int)(丞世不丒下上上丝丑)][0].weaponBonusName;
        if((val_10.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌().Equals(value:  val_49)) == true)
        {
            goto label_79;
        }
        
        label_25:
        val_46 = null;
        val_47 = 1;
        label_17:
        val_46 = null;
        val_50 = null;
        if(val_47 < WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
            goto label_41;
        }
        
        val_50 = null;
        val_51 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万()];
        if(val_17.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌() == 2)
        {
                if(val_51.七丝丈东丈丕丐与丗() != true)
        {
                val_52 = null;
            val_52 = null;
            System.Collections.Generic.KeyValuePair<System.Int32, System.Int32> val_21 = System.Linq.Enumerable.Last<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>>(source:  WeaponTogglesController.__il2cppRuntimeField_interfaceOffsets);
            val_51 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[-386263928];
        }
        
        }
        
        val_53 = null;
        val_53 = null;
        if(val_51 == null)
        {
            goto label_59;
        }
        
        val_45 = val_51.丈专世七丗三丙丝下();
        val_54 = val_51.下世万丆丛专丒丑丙();
        val_49 = val_51.东东丄丅丐一丙一业();
        goto label_60;
        label_7:
        val_42 = val_1;
        .丆丐七世世且丏丐业 = val_2;
        if(.丆丐七世世且丏丐业 != null)
        {
            goto label_61;
        }
        
        label_8:
        object[] val_26 = new object[1];
        ChestBatleRoyale val_43 = this.chests[(long)丞世不丒下上上丝丑];
        val_45 = this.chests[(long)(int)(丞世不丒下上上丝丑)][0].weaponBonusName;
        val_55 = "weapon bonus: rec == null, prefab name = {0}";
        if(val_45 == null)
        {
            goto label_65;
        }
        
        if(val_26 == null)
        {
            goto label_66;
        }
        
        label_85:
        if(val_45 != null)
        {
            goto label_67;
        }
        
        goto label_87;
        label_11:
        val_56 = null;
        System.Predicate<三丈丟与丏丘丈丐万> val_28 = null;
        val_49 = val_28;
        val_28 = new System.Predicate<三丈丟与丏丘丈丐万>(object:  val_1, method:  System.Boolean ChestsBattleRoyaleController.三丂丝丆丆丈丅丟且::丟丆丙且下不丝三专(三丈丟与丏丘丈丐万 与丘东下丈东丛丂万));
        val_45 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Find(match:  val_28);
        if(val_45 == null)
        {
            goto label_79;
        }
        
        ChestBatleRoyale val_44 = this.chests[(long)丞世不丒下上上丝丑];
        if((val_29.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌().Equals(value:  this.chests[(long)(int)(丞世不丒下上上丝丑)][0].weaponBonusName)) == true)
        {
            goto label_79;
        }
        
        val_57 = null;
        val_57 = null;
        val_58 = 0;
        val_59 = 0;
        val_60 = 1;
        val_61 = val_29.三丐三丞丘丕不丒专.三与丛丑且丐丈业丌();
        goto label_84;
        label_65:
        val_45 = System.String.alignConst;
        if(val_26 != null)
        {
            goto label_85;
        }
        
        label_66:
        if(val_45 == 0)
        {
            goto label_87;
        }
        
        label_67:
        label_87:
        val_26[0] = val_45;
        UnityEngine.Debug.LogErrorFormat(format:  val_55, args:  val_26);
        return;
        label_59:
        val_45 = 0.丈专世七丗三丙丝下();
        val_54 = 0.下世万丆丛专丒丑丙();
        val_49 = 0.东东丄丅丐一丙一业();
        label_60:
        val_61 = val_45;
        val_58 = val_54;
        val_59 = val_49;
        val_60 = (val_51.七丝丈东丈丕丐与丗() != true) ? (1 + 1) : 1;
        label_84:
        BonusController.丄丞丁丈与业上丞丟.丌丐丐丒丏且丏丁不(丆与丕丕丂下丟一丈:  val_61, 丟丒丙丁丑丐世三丈:  val_58, 上丂丝上丘专丟丁丈:  val_59, 丞丙丟丈丌七丐丝上:  -1000f, 万丁丕七丞丞丂与丟:  val_60);
        label_79:
        val_62 = null;
        val_62 = null;
        val_55 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
        val_55 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
        三下丗万丆专丄且东(三与世丈丂丕丏三上:  .丆丐七世世且丏丐业, 丙丏与丘一丁上丙一:  false, 丟丒丙丁丑丐世三丈:  0, 上丂丝上丘专丟丁丈:  0);
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        val_63 = null;
        val_63 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_298 == 0)
        {
                return;
        }
        
        val_64 = null;
        val_64 = null;
        val_55 = GetComponent<UnityEngine.AudioSource>();
        val_55.PlayOneShot(clip:  typeof(Player_move_c).__il2cppRuntimeField_298);
    }
    private void 丏下丕丏丘丅与丂丐(int 丞世不丒下上上丝丑)
    {
        string val_31;
        var val_32;
        var val_33;
        var val_34;
        var val_35;
        var val_36;
        var val_37;
        var val_38;
        var val_39;
        string val_40;
        int val_41;
        int val_42;
        var val_43;
        var val_44;
        var val_45;
        val_31 = 丞世不丒下上上丝丑;
        丕丈丏丝丗下丟丅丂 val_2 = 0;
        val_32 = 丁下万丟且丟丛下业.一三专丞丒丅上业上();
        ChestBatleRoyale val_31 = this.chests[(long)val_31];
        if(this.chests[(long)(int)(丞世不丒下上上丝丑)][0].weaponBonusName == null)
        {
            goto label_6;
        }
        
        label_53:
        bool val_3 = val_32.TryGetValue(key:  this.chests[(long)(int)(丞世不丒下上上丝丑)][0].weaponBonusName, value: out  val_2);
        if(val_2 == 0)
        {
                return;
        }
        
        if( == null)
        {
            goto label_27;
        }
        
        val_33 = null;
        val_33 = null;
        val_34 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count < WeaponManager.丂丐丛业世丝丁丛丕)
        {
            goto label_27;
        }
        
        val_35 = 0;
        goto label_17;
        label_32:
        ChestBatleRoyale val_32 = this.chests[(long)val_31];
        if((WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[0].丈专世七丗三丙丝下().Equals(value:  this.chests[(long)(int)(丞世不丒下上上丝丑)][0].weaponBonusName)) == true)
        {
            goto label_27;
        }
        
        val_34 = null;
        val_35 = 1;
        label_17:
        val_34 = null;
        val_36 = null;
        if(val_35 < WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Count)
        {
            goto label_32;
        }
        
        val_36 = null;
        val_37 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万()];
        if(val_14.三丐三丞丘丕不丒专.丒万丕七专不丏丞丌() == 2)
        {
                if(val_37.七丝丈东丈丕丐与丗() != true)
        {
                val_38 = null;
            val_38 = null;
            System.Collections.Generic.KeyValuePair<System.Int32, System.Int32> val_18 = System.Linq.Enumerable.Last<System.Collections.Generic.KeyValuePair<System.Int32, System.Int32>>(source:  WeaponTogglesController.__il2cppRuntimeField_interfaceOffsets);
            val_37 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[-385660400];
        }
        
        }
        
        val_39 = null;
        val_39 = null;
        if(val_37 == null)
        {
            goto label_50;
        }
        
        val_40 = val_37.丈专世七丗三丙丝下();
        val_41 = val_37.下世万丆丛专丒丑丙();
        val_42 = val_37.东东丄丅丐一丙一业();
        goto label_51;
        label_6:
        if(val_32 != null)
        {
            goto label_53;
        }
        
        goto label_53;
        label_50:
        val_40 = 0.丈专世七丗三丙丝下();
        val_41 = 0.下世万丆丛专丒丑丙();
        val_42 = 0.东东丄丅丐一丙一业();
        label_51:
        BonusController.丄丞丁丈与业上丞丟.丌丐丐丒丏且丏丁不(丆与丕丕丂下丟一丈:  val_40, 丟丒丙丁丑丐世三丈:  val_41, 上丂丝上丘专丟丁丈:  val_42, 丞丙丟丈丌七丐丝上:  -1000f, 万丁丕七丞丞丂与丟:  (val_37.七丝丈东丈丕丐与丗() != true) ? (1 + 1) : 1);
        label_27:
        val_43 = null;
        val_43 = null;
        ChestBatleRoyale val_33 = this.chests[(long)val_31];
        val_31 = this.chests[(long)(int)(丞世不丒下上上丝丑)][0].weaponBonusName;
        if(val_31 == null)
        {
                val_31 = System.String.alignConst;
        }
        
        val_32 = 0;
        丌丟东东丄丘上丞东(丞丅上丏丂且下丅与:  val_31, 丌丒丝东丌下丕丁丅:  0, 世丁丙世丄一万丆三:  1);
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
                return;
        }
        
        val_44 = null;
        val_44 = null;
        if(typeof(Player_move_c).__il2cppRuntimeField_298 == 0)
        {
                return;
        }
        
        val_45 = null;
        val_45 = null;
        val_31 = GetComponent<UnityEngine.AudioSource>();
        val_31.PlayOneShot(clip:  typeof(Player_move_c).__il2cppRuntimeField_298);
    }
    private static ChestsBattleRoyaleController()
    {
        int val_16;
        ChestsBattleRoyaleController.与丗一丕下丞世丟上 = 0;
        ChestsBattleRoyaleController.丂丛丞丌丟一三丕丂 = new int[14] {67, 333, 1, 66, 44, 8, 2, 4, 79, 11, 17, 748, 75, 302};
        ChestsBattleRoyaleController.与丙丟丝且丅与丕丌 = new int[6] {1149, 671, 731, 253, 51, 16};
        ChestsBattleRoyaleController.东三丞丛丟丙不不丝 = new int[6] {256, 776, 456, 659, 164, 463};
        ChestsBattleRoyaleController.丑丕丑丈丐丞丒丙丈 = new int[8] {929, 1018, 399, 1334, 924, 550, 1274, 930};
        ChestsBattleRoyaleController.丅万丈丘丌丗丞上丆 = new int[4] {1353, 1402, 1366, 1340};
        System.String[][] val_6 = new System.String[][2];
        string[] val_7 = new string[23];
        val_7[0] = "fraggrenade";
        val_7[1] = "medkit";
        val_7[2] = "jetpack";
        val_7[3] = "molotov";
        val_7[4] = "turret";
        val_7[5] = "mine";
        val_7[6] = "firemushroom";
        val_7[7] = "Blizzard_generator";
        val_7[8] = "stealth";
        val_7[9] = "fakebonus";
        val_7[10] = "dragonwhistle";
        val_7[11] = "singularity";
        val_7[12] = "reflector";
        val_7[13] = "timewatch";
        val_7[14] = "nucleargrenade";
        val_7[15] = "firework";
        val_7[16] = "leaderdrum";
        val_7[17] = "stickycandy";
        val_7[18] = "christmastreeturret";
        val_7[19] = "nutcracker";
        val_7[20] = "ninjashurickens";
        val_7[21] = "firecrackers";
        val_7[22] = "guardian";
        val_6[0] = val_7;
        string[] val_8 = new string[1];
        val_8[0] = "fraggrenade";
        val_6[1] = val_8;
        ChestsBattleRoyaleController.丐不万不丄丙丐丝业 = val_6;
        System.Int32[][] val_9 = new System.Int32[][5];
        if(val_9 == null)
        {
            goto label_80;
        }
        
        if(ChestsBattleRoyaleController.丂丛丞丌丟一三丕丂 != null)
        {
            goto label_81;
        }
        
        goto label_84;
        label_80:
        if(ChestsBattleRoyaleController.丂丛丞丌丟一三丕丂 == null)
        {
            goto label_84;
        }
        
        label_81:
        label_84:
        val_9[0] = ChestsBattleRoyaleController.丂丛丞丌丟一三丕丂;
        val_9[1] = ChestsBattleRoyaleController.与丙丟丝且丅与丕丌;
        val_9[2] = ChestsBattleRoyaleController.东三丞丛丟丙不不丝;
        val_9[3] = ChestsBattleRoyaleController.丑丕丑丈丐丞丒丙丈;
        val_9[4] = ChestsBattleRoyaleController.丅万丈丘丌丗丞上丆;
        ChestsBattleRoyaleController.专万丏丝丟丈丝丄丕 = val_9;
        ChestsBattleRoyaleController.东丂丆丈东万上丁东 = new int[6] {70, 10, 5, 0, 0, 0};
        ChestsBattleRoyaleController.丛丟丒且丌丏世丕世 = new int[6] {0, 60, 25, 15, 0, 0};
        int[] val_12 = new int[6];
        val_16 = val_12.Length;
        if(val_16 <= 3)
        {
                val_16 = val_12.Length;
        }
        
        val_12[1] = 85;
        val_12[2] = 15;
        ChestsBattleRoyaleController.与且丕七三丌丂丘丞 = val_12;
        int[] val_13 = new int[6];
        val_13[2] = 100;
        ChestsBattleRoyaleController.三丐世丅东丛东丘丝 = val_13;
        int[] val_14 = new int[6];
        val_14[2] = 10;
        ChestsBattleRoyaleController.世丘丌东丟丂丌且丞 = val_14;
        System.Int32[][] val_15 = new System.Int32[][5];
        if(val_15 == null)
        {
            goto label_105;
        }
        
        if(ChestsBattleRoyaleController.东丂丆丈东万上丁东 != null)
        {
            goto label_106;
        }
        
        goto label_109;
        label_105:
        if(ChestsBattleRoyaleController.东丂丆丈东万上丁东 == null)
        {
            goto label_109;
        }
        
        label_106:
        label_109:
        val_15[0] = ChestsBattleRoyaleController.东丂丆丈东万上丁东;
        val_15[1] = ChestsBattleRoyaleController.丛丟丒且丌丏世丕世;
        val_15[2] = ChestsBattleRoyaleController.与且丕七三丌丂丘丞;
        val_15[3] = ChestsBattleRoyaleController.三丐世丅东丛东丘丝;
        val_15[4] = ChestsBattleRoyaleController.世丘丌东丟丂丌且丞;
        ChestsBattleRoyaleController.万专与丌丗一丅丝丟 = val_15;
        ChestsBattleRoyaleController.丁业不丄一丄丌东丛 = "chestsSaltKey";
    }

}
