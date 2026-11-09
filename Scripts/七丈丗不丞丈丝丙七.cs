using UnityEngine;
public class 七丈丗不丞丈丝丙七
{
    // Fields
    private string _id;
    private string _name;
    private 七丈丗不丞丈丝丙七.丌丌丄丂丕丑专万丆 _role;
    private int _details;
    private int _clanRank;
    private Rilisoft.丝丑丂丛万丐丈丘且 _warScores;
    private int _gemsOnClanUpgrades;
    private Rilisoft.丝丑丂丛万丐丈丘且 _joinClanTime;
    private int 丗丄丙丛丈丘丗丐业;
    private bool 丛丆丒且丛丘丙丞丞;
    private int 丆万丄三且丒丝世丟;
    
    // Properties
    public string 丁业世丅丌丛上下与 { get; set; }
    public string 专丕与丒丗丁丘专丟 { get; set; }
    public 七丈丗不丞丈丝丙七.丌丌丄丂丕丑专万丆 丈丁三丕丘丙丑丄丒 { get; set; }
    public int 三专丞丄东丂丟七与 { get; set; }
    public int 业一丁丄丌且上丈丘 { get; set; }
    public int 丙专丙丄东世万丗丌 { get; set; }
    public int 且丟不一东丐业丁三 { get; set; }
    public bool 丐丐丘丏丘丈丞丙七 { get; set; }
    public int 丗丞且一丑不丞丄丏 { get; set; }
    public int 丁丂与一且一上下丐 { get; set; }
    
    // Methods
    public string 业丐丐三丕一丗丛丁()
    {
        return (string)this._id;
    }
    public void 下东丄丄丟丞东丁丅(string 丙业与丙丗丝不丈东)
    {
        this._id = 丙业与丙丗丝不丈东;
    }
    public string 东丙上东业丆不丟丘()
    {
        return (string)this._name;
    }
    public void 丌丏上丏东且丄丑丌(string 丙业与丙丗丝不丈东)
    {
        this._name = 丙业与丙丗丝不丈东;
    }
    public 七丈丗不丞丈丝丙七.丌丌丄丂丕丑专万丆 丙丐丅丕丗丁丅丁丐()
    {
        return (丌丌丄丂丕丑专万丆)this._role;
    }
    public void 七专上丙七丆丛七丒(七丈丗不丞丈丝丙七.丌丌丄丂丕丑专万丆 丙业与丙丗丝不丈东)
    {
        this._role = 丙业与丙丗丝不丈东;
    }
    public int 丙东专丂世丈丏丁丂()
    {
        return (int)this.丆万丄三且丒丝世丟;
    }
    public void 世丈丁丂丞丙丞丑丝(int 丙业与丙丗丝不丈东)
    {
        this.丆万丄三且丒丝世丟 = 丙业与丙丗丝不丈东;
    }
    public int 不丕丒丁丈丅丏三丌()
    {
        return (int)this._details;
    }
    public void 专丙丑丁丗丘丛丗丕(int 丙业与丙丗丝不丈东)
    {
        this._details = 丙业与丙丗丝不丈东;
    }
    public int 与丘且丟不丅丏万丆()
    {
        return (int)this._clanRank;
    }
    public void 丁丄丕丁丈业丙丁一(int 丙业与丙丗丝不丈东)
    {
        this._clanRank = 丙业与丙丗丝不丈东;
    }
    public int 三七丆丑丙丆丘丛丆()
    {
    
    }
    public void 业七丕下丌七丌下且(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this._warScores = 0;
        mem[1152921536617958472] = 0;
    }
    public bool 丒与丝丂七丐与且丂()
    {
        return (bool)this.丛丆丒且丛丘丙丞丞;
    }
    public void 丝丟丝三丛专丕世丗(bool 丙业与丙丗丝不丈东)
    {
        this.丛丆丒且丛丘丙丞丞 = 丙业与丙丗丝不丈东;
    }
    public int 丏丐世上东丙七丆丗()
    {
        return (int)this._gemsOnClanUpgrades;
    }
    public void 三三丟丞丁丟丆下丗(int 丙业与丙丗丝不丈东)
    {
        this._gemsOnClanUpgrades = 丙业与丙丗丝不丈东;
    }
    public int 丛专丘业与丐东丐丂()
    {
    
    }
    public void 七丕丞丟丗丟三丆万(int 丙业与丙丗丝不丈东)
    {
        int val_1 = Rilisoft.丝丑丂丛万丐丈丘且.丕丄丞三丁万丒业丙();
        this._joinClanTime = 0;
        mem[1152921536618630496] = 0;
    }
    private string 丂丆丑世一不丘丏七()
    {
        return UnityEngine.JsonUtility.ToJson(obj:  this);
    }
    public override string ToString()
    {
        bool val_1 = UnityEngine.Application.isEditor;
        return UnityEngine.JsonUtility.ToJson(obj:  this);
    }
    internal static string 丕下与与丂七丈业上(七丈丗不丞丈丝丙七.丌丌丄丂丕丑专万丆 丕万丐东与一丈万与)
    {
        string val_1;
        if(丕万丐东与一丈万与 == 0)
        {
            goto label_1;
        }
        
        if(丕万丐东与一丈万与 == 2)
        {
            goto label_2;
        }
        
        if(丕万丐东与一丈万与 != 1)
        {
                return "";
        }
        
        val_1 = "Key_5817";
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1 = "Key_5815");
        label_1:
        val_1 = "Key_5816";
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1);
        label_2:
        return 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_1);
    }
    internal static string 不丝世与丁丘下不丐(七丈丗不丞丈丝丙七.丌丌丄丂丕丑专万丆 丕万丐东与一丈万与)
    {
        string val_5;
        if(丕万丐东与一丈万与 == 0)
        {
            goto label_1;
        }
        
        if(丕万丐东与一丈万与 == 2)
        {
            goto label_2;
        }
        
        if(丕万丐东与一丈万与 != 1)
        {
                return "";
        }
        
        string val_1 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5817");
        val_5 = "[C438FF]";
        return val_5 + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5815")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5815")) + "[-]"("[-]");
        label_1:
        string val_2 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5816");
        val_5 = "[D3D3D3]";
        return val_5 + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5815")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5815")) + "[-]"("[-]");
        label_2:
        val_5 = "[3883FF]";
        return val_5 + 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5815")(丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_5815")) + "[-]"("[-]");
    }
    public 七丈丗不丞丈丝丙七()
    {
    
    }

}
