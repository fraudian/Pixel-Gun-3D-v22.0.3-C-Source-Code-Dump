using UnityEngine;
public class ImposterVoteController : PhotonEventBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    public ImposterModeController imposterMode;
    internal static int 专丟七上丁世丕且丟;
    private bool <丆与丆丝丛与丐丈且>k__BackingField;
    
    // Properties
    internal static float 七世丝丞专上丑丝世 { get; }
    internal static float 丛下丄丄丅丌丟丁丂 { get; }
    internal static float 丂东丂丅丙七万丄世 { get; }
    internal static float 丛万一丏丝丑丗丕丈 { get; }
    internal static float 丆丒业丂丗下不丆三 { get; }
    internal bool 丑专丒不丈上丂世丆 { get; set; }
    internal int 一丞丕丕丒丙世丕丙 { get; set; }
    internal bool 东下下丅三丛上丄丏 { get; }
    internal bool 丆下丝且丙丐业三丞 { get; }
    internal bool 丑与丟下一七丙丂专 { get; }
    internal bool 万丌丙东丙三万业上 { get; }
    internal bool 不丅丒东丈丙上丌丗 { get; }
    private double 丑丑世丙丄丝丛三下 { get; }
    private float 丄专万丏丘上丑与一 { get; }
    internal float 丘丗业丅丁与丌专丒 { get; }
    
    // Methods
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_5;
        var val_6;
        int val_7;
        object val_8;
        val_5 = 专丒丌丆下丐丞丟丞;
        if((丞世不丒下上上丝丑 & 255) != 0)
        {
                val_6 = 0;
            return (bool)val_6;
        }
        
        val_7 = 专丒丌丆下丐丞丟丞.Length;
        if(val_7 == 0)
        {
                val_7 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        val_8 = val_5[0];
        if(val_7 <= 1)
        {
                val_7 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_5 = val_5[1];
        val_5 = val_5[2];
        if(val_8 != null)
        {
                val_8 = 0;
        }
        
        if((val_5 != null) && (null != null))
        {
                val_5 = 0;
        }
        
        this.丕业丗丛丛丌丗丘业(丛丌专丒一丞丐丞丐:  val_8, 丄丐丆丞与丟上上下:  (null != 0) ? 1 : 0, 与丟丅七丞且且丛丕:  val_5);
        val_6 = 1;
        return (bool)val_6;
    }
    internal static float 丘丅业丗丌丒万丒丙()
    {
        PGCompany.丄三上丏丄丛丗丙丕 val_1 = PGCompany.且三下不丁丐丕丛丞.世世业丙且丂丁丅丘();
        if(val_1 != null)
        {
                return val_1.丑丞丁丄专丄丄七丏();
        }
        
        return val_1.丑丞丁丄专丄丄七丏();
    }
    internal static float 丗丏丁丟丝丟不东丄()
    {
        PGCompany.丄三上丏丄丛丗丙丕 val_1 = PGCompany.且三下不丁丐丕丛丞.世世业丙且丂丁丅丘();
        if(val_1 != null)
        {
                return val_1.万专丗丈丒丄不一三();
        }
        
        return val_1.万专丗丈丒丄不一三();
    }
    internal static float 业丛丒丞一丂丌丅与()
    {
        PGCompany.丄三上丏丄丛丗丙丕 val_1 = PGCompany.且三下不丁丐丕丛丞.世世业丙且丂丁丅丘();
        if(val_1 != null)
        {
                return val_1.且三丙下丙丛且丄世();
        }
        
        return val_1.且三丙下丙丛且丄世();
    }
    internal static float 丒七不丕丞专七丕丘()
    {
        PGCompany.丄三上丏丄丛丗丙丕 val_1 = PGCompany.且三下不丁丐丕丛丞.世世业丙且丂丁丅丘();
        if(val_1 != null)
        {
                return val_1.丌丗丛丗不丒万丈业();
        }
        
        return val_1.丌丗丛丗不丒万丈业();
    }
    internal static float 丏三丑世丆丄丞丛与()
    {
        PGCompany.丄三上丏丄丛丗丙丕 val_1 = PGCompany.且三下不丁丐丕丛丞.世世业丙且丂丁丅丘();
        if(val_1 != null)
        {
                return val_1.一丑丏七七丙丕三东();
        }
        
        return val_1.一丑丏七七丙丕三东();
    }
    internal bool 丛且丛且丑世上丐丘()
    {
        return (bool)this.<丆与丆丝丛与丐丈且>k__BackingField;
    }
    private void 丏丈七丅丏丁三丆丛(bool 丙业与丙丗丝不丈东)
    {
        this.<丆与丆丝丛与丐丈且>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal int 丞不丌丗丈丅丌下丄()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        if(丅丒丗丑丒丙丛不丆.且上世且一丈丞专上() != null)
        {
                val_8 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆();
            val_9 = null;
            val_9 = null;
            if((val_8.ContainsKey(key:  GameConnect.丑上丐且丟丂东丐丅)) != false)
        {
                val_10 = null;
            val_8 = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丗三丛丛丆丟丌丆();
            val_10 = null;
            object val_7 = val_8.Item[GameConnect.丑上丐且丟丂东丐丅];
            return (int)val_11;
        }
        
        }
        
        val_11 = 0;
        return (int)val_11;
    }
    internal void 丂丅丑丐万七三丟丐(int 丙业与丙丗丝不丈东)
    {
        var val_3;
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_3 = null;
        val_3 = null;
        val_1.Add(key:  GameConnect.丑上丐且丟丂东丐丅, value:  丙业与丙丗丝不丈东);
        丅丒丗丑丒丙丛不丆.且上世且一丈丞专上().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    internal bool 丒世丁丅丟丄与且且()
    {
        return (bool)(this.丞不丌丗丈丅丌下丄() != 1) ? 1 : 0;
    }
    internal bool 万丝一业丝丄不丗业()
    {
        var val_5;
        if(0.三丘三丈上丕丆丂一() == 3)
        {
                var val_4 = (this.丗丟三与与世世一丗() > ImposterVoteController.丒七不丕丞专七丕丘()) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    internal bool 丕一丁七丈丟丆丂上()
    {
        var val_6;
        if(0.三丘三丈上丕丆丂一() == 3)
        {
                float val_4 = ImposterVoteController.业丛丒丞一丂丌丅与();
            val_4 = ImposterVoteController.丒七不丕丞专七丕丘() + val_4;
            var val_5 = (this.丗丟三与与世世一丗() > val_4) ? 1 : 0;
            return (bool)val_6;
        }
        
        val_6 = 0;
        return (bool)val_6;
    }
    internal bool 丝上业丘万丁业东丅()
    {
        var val_5;
        if(0.三丘三丈上丕丆丂一() == 3)
        {
                var val_4 = (this.丗丟三与与世世一丗() <= ImposterVoteController.丒七不丕丞专七丕丘()) ? 1 : 0;
            return (bool)val_5;
        }
        
        val_5 = 0;
        return (bool)val_5;
    }
    internal bool 万东七下不丆丈东丑()
    {
        return (bool)(0.三丘三丈上丕丆丂一() == 4) ? 1 : 0;
    }
    private double 丘丄丒东丒丌丁丂业()
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        val_9 = 0;
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return 1.28822976017949E-231;
        }
        
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_10 = null;
        val_10 = null;
        if((val_8.ContainsKey(key:  GameConnect.丞专上丗丄一东丐丛)) == false)
        {
                return 1.28822976017949E-231;
        }
        
        val_11 = null;
        val_8 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆();
        val_11 = null;
        object val_7 = val_8.Item[GameConnect.丞专上丗丄一东丐丛];
        return 1.28822976017949E-231;
    }
    private float 丗丟三与与世世一丗()
    {
        double val_2 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_2 = this.丘丄丒东丒丌丁丂业() - val_2;
        return UnityEngine.Mathf.Max(a:  0f, b:  (float)val_2);
    }
    internal float 专丏丞丂东丒丏丐下()
    {
        var val_6;
        bool val_1 = this.万丝一业丝丄不丗业();
        double val_2 = val_1.丘丄丒东丒丌丁丂业();
        if(val_1 != false)
        {
                double val_6 = (double)ImposterVoteController.丒七不丕丞专七丕丘();
            val_6 = val_2 - val_6;
            val_6 = val_6 - 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
            return UnityEngine.Mathf.Max(a:  0f, b:  (float)val_6 = val_2 - 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄());
        }
        
        return UnityEngine.Mathf.Max(a:  0f, b:  (float)val_6);
    }
    private void 丕业丗丛丛丌丗丘业(与丅丕丈丘东丝世丟 丛丌专丒一丞丐丞丐, bool 丄丐丆丞与丟上上下, string 与丟丅七丞且且丛丕)
    {
        this.业丗业丒上一丟丘丐();
        丄丐丆丞与丟上上下 = 丄丐丆丞与丟上上下;
        0.世丘且与一丄丟丗丐(丛丌专丒一丞丐丞丐:  丛丌专丒一丞丐丞丐, 丄丐丆丞与丟上上下:  丄丐丆丞与丟上上下, 与丟丅七丞且且丛丕:  与丟丅七丞且且丛丕);
    }
    internal void 不丄丅专一丘丏专丟(bool 丄丐丆丞与丟上上下, string 与丟丅七丞且且丛丕)
    {
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                this.丕业丗丛丛丌丗丘业(丛丌专丒一丞丐丞丐:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上(), 丄丐丆丞与丟上上下:  丄丐丆丞与丟上上下, 与丟丅七丞且且丛丕:  与丟丅七丞且且丛丕);
            return;
        }
        
        object[] val_4 = new object[3];
        val_4[0] = 丅丒丗丑丒丙丛不丆.且上世且一丈丞专上();
        val_4[1] = 丄丐丆丞与丟上上下;
        val_4[2] = 与丟丅七丞且且丛丕;
        this.丅七下专东丗业下丐(丑丐丗三丒世丏东丅:  0, 丈丅丘丐三丂丗且丌:  2, 丕业丑万一丞丞东三:  false, 丗丟上上丒丐丗丞丙:  val_4);
    }
    internal void 丏丒丏世丒丌三丂业()
    {
        NetworkStartTable val_4;
        var val_5;
        var val_6;
        val_4 = this;
        if(this.丞不丌丗丈丅丌下丄() != 1)
        {
                return;
        }
        
        if(this.丝上业丘万丁业东丅() == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        val_4 = mem[GameController.onlineMode + 352];
        val_4 = GameController.onlineMode.丟三丏丅世一丟丟上;
        if(丑丈上东丗丐丆世上() == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        丂丅丑丐万七三丟丐(丙业与丙丗丝不丈东:  ImposterVoteController.专丟七上丁世丕且丟);
    }
    internal void 且丙与东丞与丐丞专(NetworkStartTable 不且上一上丐三万丛)
    {
        var val_9;
        if(this.丞不丌丗丈丅丌下丄() != 1)
        {
                return;
        }
        
        if(this.丝上业丘万丁业东丅() == false)
        {
                return;
        }
        
        if(不且上一上丐三万丛 == 0)
        {
                return;
        }
        
        if(不且上一上丐三万丛.丑丈上东丗丐丆世上() == false)
        {
                return;
        }
        
        if(不且上一上丐三万丛.丄丈丑丐丆丞丘与丗.owner == null)
        {
                return;
        }
        
        val_9 = null;
        val_9 = null;
        if(丑丈上东丗丐丆世上() == false)
        {
                return;
        }
        
        int val_8 = 不且上一上丐三万丛.丄丈丑丐丆丞丘与丗.owner.业丐丐三丕一丗丛丁();
        val_8.丂丅丑丐万七三丟丐(丙业与丙丗丝不丈东:  val_8);
    }
    internal void 丆专丅上丙丞丁丅东()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丗一三丒丄丄一丙丅(), 丏业丟一东丂东丘丛:  false);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.一丝丄专丛丙业丝业(), 丏业丟一东丂东丘丛:  false);
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.一丝丄专丛丙业丝业().且七丁丈不七下与七();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丘专东三丗业下东丅(), 丏业丟一东丂东丘丛:  true);
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丘专东三丗业下东丅().丂丁丈丟丟丘与丑万(东丌与与且丝三丟业:  this);
    }
    internal void 东且世丌丏丁三丛丅()
    {
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丗一三丒丄丄一丙丅().gameObject.SetActive(value:  true);
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丗一三丒丄丄一丙丅().丂丏丏东丟下丌三七();
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丁下东丙丞丝且丒丐().丌万丗与七丄丕不丁(丟丞丄万丂丗丟丆七:  new 丙下丝丅丝丑丏丁且());
    }
    internal void 丒世东专丝业丒丙专()
    {
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丗一三丒丄丄一丙丅().gameObject.SetActive(value:  false);
        ImposterVoteChatUi val_3 = NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丁下东丙丞丝且丒丐();
        if(val_3.丛丄上世丒丝丂丗丑 == null)
        {
                return;
        }
        
        val_3.丛丄上世丒丝丂丗丑.不七丅丙丏上丛丒丗();
    }
    internal void 丗丈万丈东且三丅丄()
    {
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丗一三丒丄丄一丙丅().丗丈万丈东且三丅丄(且丒丕东丁丗丏业万:  this.丒丆丒不丒丝世丐丒());
    }
    internal void 丆丅与东丏丈丟丅东()
    {
        this.<丆与丆丝丛与丐丈且>k__BackingField = false;
        SabotageImposterModeController.丆丕丝丒不丙且丐丗.上丘丗丕专下丂丟万();
    }
    private void 七丝专世不丌万东丐()
    {
        this.<丆与丆丝丛与丐丈且>k__BackingField = true;
        this.丒世东专丝业丒丙专();
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.一丝丄专丛丙业丝业(), 丏业丟一东丂东丘丛:  true);
        NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.一丝丄专丛丙业丝业().丗不专世丈下东丂丝(东丌与与且丝三丟业:  this);
    }
    internal void 丒丄上丁且丑丈丄世()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.一丝丄专丛丙业丝业(), 丏业丟一东丂东丘丛:  false);
    }
    internal void 下丆丐三专丂丕丝三()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丘专东三丗业下东丅(), 丏业丟一东丂东丘丛:  false);
    }
    internal void 且丞丙丟下丘业丘丒()
    {
        var val_13;
        if(this.万东七下不丆丈东丑() != false)
        {
                if((this.<丆与丆丝丛与丐丈且>k__BackingField) == true)
        {
                return;
        }
        
            if(this.丗丟三与与世世一丗() <= 0f)
        {
                if(NetworkStartTableNGUIController.丄丞丁丈与业上丞丟.丗一三丒丄丄一丙丅().gameObject.activeInHierarchy != false)
        {
                this.七丝专世不丌万东丐();
            return;
        }
        
        }
        
        }
        
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        val_13 = this;
        bool val_7 = this.丝上业丘万丁业东丅();
        if(val_7 == false)
        {
            goto label_13;
        }
        
        if(val_7.丒丐丗丐丑世丑丕七() == true)
        {
            goto label_12;
        }
        
        val_13 = this;
        if(this.丗丟三与与世世一丗() > 0f)
        {
            goto label_13;
        }
        
        label_12:
        0.不丙丈丁三下七丄万(东且丁丆丛丁丏丘且:  this.不丅丞丄丑世一丆不());
        label_13:
        if(this.万东七下不丆丈东丑() == false)
        {
                return;
        }
        
        if(this.丗丟三与与世世一丗() > 0f)
        {
                return;
        }
        
        0.丟丑丑丁七丝上丏丕();
    }
    internal void 业丗业丒上一丟丘丐()
    {
        var val_4;
        var val_5;
        val_4 = 0;
        goto label_1;
        label_13:
        ExitGames.Client.Photon.Hashtable val_1 = new ExitGames.Client.Photon.Hashtable();
        val_5 = null;
        val_5 = null;
        val_1.Add(key:  GameConnect.丑上丐且丟丂东丐丅, value:  0);
        丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0].丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_1, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
        val_4 = 1;
        label_1:
        与丅丕丈丘东丝世丟[] val_3 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_4 < val_3.Length)
        {
            goto label_13;
        }
    
    }
    internal bool 丒丐丗丐丑世丑丕七()
    {
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        val_14 = 0;
        goto label_1;
        label_41:
        val_15 = null;
        val_15 = null;
        if((丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0].丑丗三丛丛丆丟丌丆().ContainsKey(key:  GameConnect.丂丏丈上东丕丒三丈)) == false)
        {
            goto label_19;
        }
        
        val_16 = null;
        val_16 = null;
        object val_6 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0].丑丗三丛丛丆丟丌丆().Item[GameConnect.丂丏丈上东丕丒三丈];
        if(null != 1)
        {
            goto label_19;
        }
        
        val_17 = null;
        val_18 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0].丑丗三丛丛丆丟丌丆();
        val_17 = null;
        if((val_18.ContainsKey(key:  GameConnect.丑上丐且丟丂东丐丅)) == false)
        {
            goto label_37;
        }
        
        val_19 = null;
        val_18 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0].丑丗三丛丛丆丟丌丆();
        val_19 = null;
        object val_12 = val_18.Item[GameConnect.丑上丐且丟丂东丐丅];
        if(null == 1)
        {
            goto label_37;
        }
        
        label_19:
        val_14 = 1;
        label_1:
        val_18 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_14 < val_13.Length)
        {
            goto label_41;
        }
        
        val_20 = 1;
        return (bool)val_20;
        label_37:
        val_20 = 0;
        return (bool)val_20;
    }
    internal int 不丅丞丄丑世一丆不()
    {
        var val_5;
        var val_13;
        var val_14;
        Dictionary.Enumerator<TKey, TValue> val_2 = this.丒丆丒不丒丝世丐丒().GetEnumerator();
        label_11:
        val_13 = 0;
        label_9:
        val_14 = val_13;
        label_6:
        if((191974144 & 1) == 0)
        {
            goto label_2;
        }
        
        ConfiguredValueTaskAwaiter val_6 = val_5.GetAwaiter();
        if(0 < val_6._value._obj.Count)
        {
            goto label_4;
        }
        
        if(0 != val_6._value._obj.Count)
        {
            goto label_6;
        }
        
        goto label_7;
        label_4:
        int val_9 = val_6._value._obj.丙东专丂世丈丏丁丂();
        int val_10 = val_6._value._obj.Count;
        goto label_9;
        label_7:
        int val_11 = val_6._value._obj.Count;
        goto label_11;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        return (int)(0 != 0) ? (val_14) : (!0);
    }
    internal System.Collections.Generic.Dictionary<int, System.Collections.Generic.List<与丅丕丈丘东丝世丟>> 丒丆丒不丒丝世丐丒()
    {
        var val_20;
        var val_21;
        var val_22;
        string val_23;
        var val_24;
        var val_25;
        var val_26;
        System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<与丅丕丈丘东丝世丟>> val_1 = new System.Collections.Generic.Dictionary<System.Int32, System.Collections.Generic.List<与丅丕丈丘东丝世丟>>();
        val_20 = 1152921504622075904;
        val_21 = 0;
        goto label_1;
        label_56:
        val_22 = null;
        val_22 = null;
        val_23 = GameConnect.丂丏丈上东丕丒三丈;
        if((丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0].丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_23)) != false)
        {
                val_24 = null;
            val_24 = null;
            val_23 = GameConnect.丂丏丈上东丕丒三丈;
            object val_7 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0].丑丗三丛丛丆丟丌丆().Item[val_23];
            if(null == 1)
        {
                val_25 = null;
            val_25 = null;
            val_23 = GameConnect.丑上丐且丟丂东丐丅;
            if((丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0].丑丗三丛丛丆丟丌丆().ContainsKey(key:  val_23)) != false)
        {
                val_26 = null;
            val_26 = null;
            val_23 = GameConnect.丑上丐且丟丂东丐丅;
            object val_13 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0].丑丗三丛丛丆丟丌丆().Item[val_23];
            if(null != 1)
        {
                if((val_1.ContainsKey(key:  21884928)) != false)
        {
                val_23 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0];
            val_1.Item[21884928].Add(item:  val_23);
        }
        else
        {
                System.Collections.Generic.List<与丅丕丈丘东丝世丟> val_17 = null;
            val_23 = val_17;
            val_17 = new System.Collections.Generic.List<与丅丕丈丘东丝世丟>();
            val_17.Add(item:  丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁()[0]);
            val_1.Add(key:  21884928, value:  val_17);
            val_20 = 1152921504622075904;
        }
        
        }
        
        }
        
        }
        
        }
        
        val_21 = 1;
        label_1:
        与丅丕丈丘东丝世丟[] val_19 = 丅丒丗丑丒丙丛不丆.丒丙不世万下丟丅丁();
        if(val_21 < val_19.Length)
        {
            goto label_56;
        }
        
        return val_1;
    }
    public ImposterVoteController()
    {
    
    }
    private static ImposterVoteController()
    {
        ImposterVoteController.专丟七上丁世丕且丟 = 10000;
    }

}
