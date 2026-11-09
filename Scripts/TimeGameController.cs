using UnityEngine;
internal sealed class TimeGameController : BaseConditionEndRound, 东丁丆一业丈万丆丐
{
    // Fields
    internal static TimeGameController 丄丞丁丈与业上丞丟;
    internal double 丒丂世丌东万三下丗;
    internal double 丁专不且丈丂丄且丞;
    internal double 丘丘丑丟丏与丕丝丛;
    internal PhotonView 丄丈丑丐丆丞丘与丗;
    internal double 丝七下万丛与丄丟万;
    private bool 丑丛专丘丐东丝万上;
    private bool 世丛丗丟且七与丗上;
    internal bool 不丏一一七专专丄丑;
    private bool 东一丙三下七丛丅丌;
    private int 丁不丒丗丄万丟丅丕;
    private int 业丝专丁丅且不丈丆;
    private double 丟丄一专丝不三丏丈;
    
    // Properties
    private bool 丆且三丗丝世丕丆丂 { get; }
    
    // Methods
    private void Awake()
    {
        null = null;
        if(((((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (GameConnect.不专专丂万丝上东丐() != true)) && (GameConnect.业丛丛丂一丆丕丗丟() != true)) && (GameConnect.一与东丝万上三丆丏() != true)) && (GameConnect.与丂丝丟丟三丑丝万() != true))
        {
                if(GameConnect.万不丒丌丙万丗东不() != true)
        {
                if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
            goto label_21;
        }
        
        }
        
        }
        
        this.enabled = false;
        return;
        label_21:
        if(GameConnect.丙丘不世专且万丄丐() == false)
        {
                return;
        }
        
        DungeonsController.丆万三一丞万丟不专();
    }
    private void Start()
    {
        TimeGameController.丄丞丁丈与业上丞丟 = this;
    }
    private bool 专丙丗三与专丐下丒()
    {
        var val_3;
        if(this.丑丛专丘丐东丝万上 != false)
        {
                var val_2 = (丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() != 0f) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 0;
        return (bool)val_3;
    }
    internal void 世丅世丕丆丝丄丂丙()
    {
        this.丑丛专丘丐东丝万上 = true;
    }
    internal void 丌丄丄丄丗丐丂丂三()
    {
        var val_39;
        var val_40;
        var val_41;
        var val_42;
        var val_43;
        var val_44;
        var val_45;
        var val_46;
        var val_47;
        var val_48;
        var val_49;
        double val_50;
        var val_51;
        var val_52;
        var val_53;
        double val_54;
        var val_55;
        if(this.专丙丗三与专丐下丒() == false)
        {
                return;
        }
        
        if(GameConnect.丞丂丑一丕丑丙三丐() != true)
        {
                if(GameConnect.丘丐丅丌上与丒丞万() == false)
        {
            goto label_16;
        }
        
        }
        
        val_39 = null;
        val_39 = null;
        if((System.Convert.ToDouble(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.专丝下世丄业丕丑七])) < 0)
        {
                val_40 = 1;
        }
        else
        {
                label_16:
            val_40 = 0;
        }
        
        val_41 = null;
        val_41 = null;
        this.丒丂世丌东万三下丗 = System.Convert.ToDouble(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.专丝下世丄业丕丑七]);
        var val_39 = 0;
        label_34:
        val_42 = null;
        val_42 = null;
        if(val_39 >= 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Count)
        {
            goto label_29;
        }
        
        val_43 = null;
        val_43 = null;
        val_39 = val_39 + 1;
        if(丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.Item[0].丟丌下三七丁与丟丑() == true)
        {
            goto label_34;
        }
        
        val_44 = 1;
        goto label_35;
        label_29:
        val_44 = 0;
        label_35:
        val_45 = 1152921505171275776;
        val_46 = null;
        val_46 = null;
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        double val_15 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        if(this.丒丂世丌东万三下丗 >= 0)
        {
            goto label_41;
        }
        
        if((val_44 & GameConnect.丘丐丅丌上与丒丞万()) == true)
        {
            goto label_44;
        }
        
        goto label_46;
        label_41:
        if(val_44 == 0)
        {
            goto label_46;
        }
        
        label_44:
        bool val_19 = val_40 & GameConnect.丘丐丅丌上与丒丞万();
        val_19 = val_19 + 31;
        val_19 = val_19 & 31;
        if(val_19 == true)
        {
                return;
        }
        
        label_46:
        ExitGames.Client.Photon.Hashtable val_20 = new ExitGames.Client.Photon.Hashtable();
        if(GameConnect.丟丆丏上丌一丝丟业() != false)
        {
                val_47 = 0;
            int val_23 = GameConnect.丈专且丗上丂丗丝丑();
        }
        else
        {
                if(GameConnect.丙丘不世专且万丄丐() != false)
        {
                val_48 = 4;
        }
        else
        {
                val_49 = null;
            val_49 = null;
            object val_27 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.丟下丗丙丕丁丞丞丛];
        }
        
            val_47 = 1152921504628731904 * 60;
        }
        
        val_50 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + (double)val_47;
        PGCompany.丁东丌世与丕东丆上.万丏丘三丞丝万丁丙(丂三丟丂丈丐丆丗丟: ref  double val_28 = 1.28823915254046E-231);
        if(GameConnect.与不丗丏万丙丞丌丑() == false)
        {
            goto label_72;
        }
        
        val_51 = null;
        val_51 = null;
        if(GameController.onlineMode != null)
        {
                if(null == null)
        {
            goto label_78;
        }
        
        }
        
        label_78:
        var val_31 = (null == null) ? GameController.onlineMode : 0;
        val_50 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + ((double)onlineMode == null ? GameController.onlineMode : 0 + 536 + 108);
        label_72:
        if(GameConnect.丒丈丒万七丁东丁不() == false)
        {
            goto label_82;
        }
        
        val_52 = null;
        val_52 = null;
        if(GameController.onlineMode == null)
        {
            goto label_87;
        }
        
        var val_34 = (null == null) ? GameController.onlineMode : 0;
        goto label_89;
        label_82:
        val_54 = val_50;
        goto label_90;
        label_87:
        val_53 = 0;
        label_89:
        val_54 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + (double)val_53.世七业丌业丝丟丁丆();
        label_90:
        if(val_54 > 4294967)
        {
                double val_36 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        }
        
        val_55 = null;
        val_55 = null;
        val_20.set_Item(key:  GameConnect.专丝下世丄业丕丑七, value:  4294967);
        val_20.set_Item(key:  GameConnect.东丟丁与一与一丘丆, value:  0);
        val_45 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
        val_45.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_20, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        this.丁不丒丗丄万丟丅丕 = 0;
        double val_38 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_38 = (-2f) - val_38;
        this.丁专不且丈丂丄且丞 = val_38;
    }
    internal void 丈丗丁丐丟三丄世下(float 丆丐七丅丆丗丛上与)
    {
        var val_8;
        float val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        double val_4 = System.Convert.ToDouble(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.专丝下世丄业丕丑七]);
        val_9 = val_4 + (double)丆丐七丅丆丗丛上与;
        this.丒丂世丌东万三下丗 = val_4;
        if(val_9 > 4294967)
        {
                if(丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() < 0)
        {
                val_9 = 4294967;
        }
        
        }
        
        ExitGames.Client.Photon.Hashtable val_6 = new ExitGames.Client.Photon.Hashtable();
        val_10 = null;
        val_10 = null;
        val_6.set_Item(key:  GameConnect.专丝下世丄业丕丑七, value:  4294967);
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_6, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal void 丞丞下丒丅丅丛世丕()
    {
        this.东一丙三下七丛丅丌 = false;
        if(this.专丙丗三与专丐下丒() != false)
        {
                this.丌丄丄丄丗丐丂丂三();
            return;
        }
        
        this.世丛丗丟且七与丗上 = true;
    }
    private void Update()
    {
        var val_68;
        var val_69;
        string val_70;
        object val_71;
        var val_72;
        var val_73;
        double val_74;
        var val_75;
        var val_76;
        var val_77;
        var val_79;
        int val_80;
        float val_81;
        double val_82;
        var val_83;
        double val_84;
        var val_85;
        var val_86;
        var val_87;
        var val_88;
        if(this.世丛丗丟且七与丗上 != false)
        {
                if(this.专丙丗三与专丐下丒() != false)
        {
                this.世丛丗丟且七与丗上 = false;
            this.丌丄丄丄丗丐丂丂三();
        }
        
        }
        
        val_68 = null;
        val_68 = null;
        if((与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false) || (丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null))
        {
            goto label_152;
        }
        
        val_69 = null;
        val_69 = null;
        val_70 = GameConnect.专丝下世丄业丕丑七;
        val_71 = val_70;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[val_71] == null)
        {
            goto label_152;
        }
        
        double val_6 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        this.丘丘丑丟丏与丕丝丛 = val_6;
        if(val_6 < 0)
        {
                return;
        }
        
        val_72 = null;
        val_72 = null;
        this.丒丂世丌东万三下丗 = System.Convert.ToDouble(value:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.专丝下世丄业丕丑七]);
        if(this.专丙丗三与专丐下丒() != true)
        {
                val_73 = null;
            val_73 = null;
            object val_14 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.丟下丗丙丕丁丞丞丛];
            val_74 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + (-4.61168601842739E+18);
            this.丒丂世丌东万三下丗 = val_74;
        }
        
        val_75 = null;
        val_75 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 != 0)
        {
                val_76 = null;
            val_76 = null;
            if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0)
        {
                val_74 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() + 1500;
            if(this.丒丂世丌东万三下丗 > val_74)
        {
                GameController.丑七不且上丗丁一世().丛七丟万丏丑丙丕丕(世丁丙世丄一万丆三:  System.String.Format(format:  "timeEndMatch = {0} > PhotonNetwork.time = {1} + 25 * 6", arg0:  this.丒丂世丌东万三下丗, arg1:  丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄()));
        }
        
        }
        
        }
        
        val_77 = null;
        val_77 = null;
        val_71 = GameConnect.东丟丁与一与一丘丆;
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().ContainsKey(key:  val_71)) != false)
        {
                val_79 = null;
            val_79 = null;
            object val_27 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().Item[GameConnect.东丟丁与一与一丘丆];
            val_71 = null;
            val_70 = this;
            this.丁不丒丗丄万丟丅丕 = null;
        }
        else
        {
                val_70 = this;
            val_80 = this.丁不丒丗丄万丟丅丕;
        }
        
        this.业丝专丁丅且不丈丆 = val_80;
        val_81 = this.丒丂世丌东万三下丗 - 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        if(ExperienceController.丞丞丘业东丙丏七丌() == 1)
        {
                UnityEngine.SceneManagement.Scene val_30 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            if((System.String.Equals(a:  val_30.m_Handle.name, b:  PGCompany.丁东丌世与丕东丆上.丛不丝丆与不丌与七(), comparisonType:  5)) != false)
        {
                int val_34 = PGCompany.丁东丌世与丕东丆上.丗专丝万上丑下丛一();
            val_74 = this.丟丄一专丝不三丏丈;
            if((val_74 > ((double)val_34 - 30)) && (val_81 <= ((double)val_34 - 30)))
        {
                丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  25);
            val_74 = this.丟丄一专丝不三丏丈;
        }
        
            if((val_81 <= ((double)val_34 - 60)) && (val_74 > ((double)val_34 - 60)))
        {
                丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  26);
            val_74 = this.丟丄一专丝不三丏丈;
        }
        
            if((val_81 <= ((double)val_34 - 90)) && (val_74 > ((double)val_34 - 90)))
        {
                丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  27);
        }
        
        }
        
            UnityEngine.SceneManagement.Scene val_38 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
            val_71 = PGCompany.丁东丌世与丕东丆上.丈丝丘丑丞丗丐丒丆();
            if((System.String.Equals(a:  val_38.m_Handle.name, b:  val_71, comparisonType:  5)) != false)
        {
                int val_42 = PGCompany.丁东丌世与丕东丆上.万丏丌丑下上丑一下();
            val_74 = this.丟丄一专丝不三丏丈;
            if((val_74 > ((double)val_42 - 60)) && (val_81 <= ((double)val_42 - 60)))
        {
                val_71 = 0;
            丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  31);
            val_74 = this.丟丄一专丝不三丏丈;
        }
        
            if((val_81 <= ((double)val_42 - 120)) && (val_74 > ((double)val_42 - 120)))
        {
                val_71 = 0;
            丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  32);
        }
        
        }
        
        }
        
        if(ExperienceController.丞丞丘业东丙丏七丌() != 2)
        {
            goto label_104;
        }
        
        val_71 = 0;
        val_82 = this;
        var val_67 = 60;
        val_74 = this.丟丄一专丝不三丏丈;
        int val_48 = (GameConnect.丏丝一丁丛丕且丐丈(丂丛丑东不丅丈一东:  GameConnect.丑丌丛丈丅丅与不业())) * val_67;
        val_67 = val_48 - 60;
        if((val_74 > (double)val_67) && (val_81 <= (double)val_67))
        {
                val_71 = 0;
            丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  36);
            val_74 = val_74;
        }
        
        if((val_81 <= ((double)val_48 - 120)) && (val_74 > ((double)val_48 - 120)))
        {
                val_71 = 0;
            丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  37);
            val_74 = val_74;
        }
        
        if((val_81 > ((double)val_48 - 180)) || (val_74 <= ((double)val_48 - 180)))
        {
            goto label_119;
        }
        
        val_71 = 0;
        丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  38);
        goto label_119;
        label_104:
        val_82 = this.丟丄一专丝不三丏丈;
        label_119:
        mem2[0] = val_81;
        if(val_81 <= 0f)
        {
            goto label_131;
        }
        
        if(this.丁不丒丗丄万丟丅丕 == 2)
        {
            goto label_121;
        }
        
        if(this.丁不丒丗丄万丟丅丕 != 0)
        {
            goto label_131;
        }
        
        val_81 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        float val_53 = (丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != true) ? 130 : 110;
        val_53 = val_81 + val_53;
        if(this.丒丂世丌东万三下丗 >= 0)
        {
            goto label_131;
        }
        
        this.丁不丒丗丄万丟丅丕 = 2;
        val_71 = 0;
        UnityEngine.Debug.Log(message:  "two minutes remain");
        goto label_131;
        label_121:
        val_81 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        float val_56 = (丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != true) ? 70 : 50;
        val_56 = val_81 + val_56;
        if(this.丒丂世丌东万三下丗 < 0)
        {
                val_71 = 0;
            UnityEngine.Debug.Log(message:  "one minute remain");
            this.丁不丒丗丄万丟丅丕 = 1;
        }
        
        label_131:
        if(this.业丝专丁丅且不丈丆 != this.丁不丒丗丄万丟丅丕)
        {
                UnityEngine.Debug.Log(message:  "Write ending: "("Write ending: ") + this.丁不丒丗丄万丟丅丕);
            ExitGames.Client.Photon.Hashtable val_58 = new ExitGames.Client.Photon.Hashtable();
            val_83 = null;
            val_83 = null;
            val_58.set_Item(key:  GameConnect.东丟丁与一与一丘丆, value:  this.丁不丒丗丄万丟丅丕);
            val_70 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
            val_71 = val_58;
            val_70.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_58, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        }
        
        val_84 = this.丒丂世丌东万三下丗;
        if((val_84 > 4290000) && (this.丘丘丑丟丏与丕丝丛 < 0))
        {
                ExitGames.Client.Photon.Hashtable val_60 = new ExitGames.Client.Photon.Hashtable();
            val_85 = null;
            val_81 = this.丘丘丑丟丏与丕丝丛 + 60;
            val_85 = null;
            val_60.set_Item(key:  GameConnect.专丝下世丄业丕丑七, value:  val_81);
            val_70 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且();
            val_71 = val_60;
            val_70.丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_60, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
            val_84 = this.丒丂世丌东万三下丗;
        }
        
        if(val_84 > 0f)
        {
                val_84 = val_84 - this.丘丘丑丟丏与丕丝丛;
            this.丁专不且丈丂丄且丞 = val_84;
        }
        else
        {
                this.丁专不且丈丂丄且丞 = -1;
        }
        
        label_152:
        if((this.丒丂世丌东万三下丗 > 0f) && (this.丁专不且丈丂丄且丞 < 0))
        {
                if(GameConnect.丘丐丅丌上与丒丞万() == false)
        {
            goto label_157;
        }
        
        }
        
        this.不丏一一七专专丄丑 = false;
        return;
        label_157:
        this.丛万丙丏丝丗丛丄丐();
        if(GameConnect.丑丌丛丈丅丅与不业() == 5)
        {
                return;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 1)
        {
                if(this.不丏一一七专专丄丑 == true)
        {
                return;
        }
        
            ZombiManager.丟丗丄业丘丗业丗七.EndMatch();
            return;
        }
        
        val_86 = null;
        val_86 = null;
        if(GameController.mode == null)
        {
                return;
        }
        
        if(GameConnect.丑丌丛丈丅丅与不业() == 16)
        {
                return;
        }
        
        val_87 = null;
        val_87 = null;
        if(GameController.mode != null)
        {
                val_88 = null;
            val_88 = null;
            var val_66 = (((GameModeController.__il2cppRuntimeField_typeHierarchy + (LegacyModeController.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == val_88) ? GameController.mode : 0;
        }
        
        0.丈丌一丂丟丕丄不且();
    }
    public bool OnEventFired(byte 丗与一丛丐丞丘丌丞, object[] 专丒丌丆下丐丞丟丞)
    {
        return false;
    }
    private void OnDestroy()
    {
        TimeGameController.丄丞丁丈与业上丞丟 = 0;
    }
    internal override void 下丌且丈丝丗丛上丌()
    {
    
    }
    internal override void 一丗一上丙丅下丑万()
    {
    
    }
    public TimeGameController()
    {
        this.不丏一一七专专丄丑 = true;
    }

}
