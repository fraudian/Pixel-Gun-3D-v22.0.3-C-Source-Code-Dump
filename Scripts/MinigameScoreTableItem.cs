using UnityEngine;
internal class MinigameScoreTableItem : MonoBehaviour
{
    // Fields
    public UITexture playerAvatar;
    public UILabel playerScoreLabel;
    public UILabel playerName;
    public UISprite portraitBorder;
    public UISprite backGround;
    public UnityEngine.Color notMyPlayerBG;
    public UnityEngine.Color notMyPlayerAvaBorder;
    public UnityEngine.Color myPlayerBG;
    public UnityEngine.Color myPlayerAvaBorder;
    internal string 业上上丏丄不上丅丈;
    internal NetworkStartTable 业丒丅上世丂世一丁;
    private int <下业丛丑丅丛与丙丂>k__BackingField;
    private bool <丞丁丙丏七丆与世丅>k__BackingField;
    private bool 丘丄丆不丛丗上三上;
    
    // Properties
    internal int 三丂七丂丆丒丐三世 { get; set; }
    internal bool 丌丟丙丘丐丙丙且丅 { get; set; }
    internal bool 丞七丏丛丘东丏丄丏 { get; }
    
    // Methods
    internal int 万丄丕丅丈七丅世丙()
    {
        return (int)this.<下业丛丑丅丛与丙丂>k__BackingField;
    }
    private void 丆丑万丙丟丐丒丗丟(int 丙业与丙丗丝不丈东)
    {
        this.<下业丛丑丅丛与丙丂>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 丝万丈专丂且丆丝丐()
    {
        return (bool)this.<丞丁丙丏七丆与世丅>k__BackingField;
    }
    private void 丑世丏丙丟丞丒丐业(bool 丙业与丙丗丝不丈东)
    {
        this.<丞丁丙丏七丆与世丅>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 一万丙下东且丌不丂()
    {
        return (bool)this.丘丄丆不丛丗上三上;
    }
    internal void 世丏丟世丈丒丏业丑(NetworkStartTable 不且上一上丐三万丛)
    {
        UnityEngine.Texture val_10;
        var val_11;
        UnityEngine.Color val_12;
        float val_13;
        if(不且上一上丐三万丛 == 0)
        {
            goto label_3;
        }
        
        this.业丒丅上世丂世一丁 = 不且上一上丐三万丛;
        this.业上上丏丄不上丅丈 = 不且上一上丐三万丛.丈三世丞丕万丄七丂;
        this.playerAvatar.enabled = true;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  不且上一上丐三万丛.万丛丏万丟丕丒丛与, y:  0);
        if(this.业丒丅上世丂世一丁 == null)
        {
            goto label_8;
        }
        
        if(val_2 == false)
        {
            goto label_9;
        }
        
        label_13:
        val_10 = this.业丒丅上世丂世一丁.万丛丏万丟丕丒丛与;
        if(this.playerAvatar != null)
        {
            goto label_14;
        }
        
        goto label_11;
        label_3:
        this.丘丄丆不丛丗上三上 = false;
        this.业丒丅上世丂世一丁 = 0;
        this.gameObject.SetActive(value:  false);
        return;
        label_8:
        if(val_2 == true)
        {
            goto label_13;
        }
        
        label_9:
        val_10 = this.业丒丅上世丂世一丁.丌丏丞丆丗与东丗业;
        if(this.playerAvatar != null)
        {
            goto label_14;
        }
        
        label_11:
        label_14:
        this.playerName.text = this.业丒丅上世丂世一丁.丂丈丐不丏万三七丐;
        this.丂丆丄丛丂三丘业一();
        val_11 = null;
        val_11 = null;
        if(不且上一上丐三万丛 == WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable)
        {
                this.portraitBorder.color = new UnityEngine.Color() {r = this.myPlayerAvaBorder, g = V9.16B, b = V10.16B, a = V11.16B};
            this.playerName.color = new UnityEngine.Color() {r = this.myPlayerAvaBorder, g = V9.16B, b = V10.16B, a = V11.16B};
            val_12 = this.myPlayerBG;
            this.backGround.color = new UnityEngine.Color() {r = val_12, g = V9.16B, b = V10.16B, a = V11.16B};
            if(this.transform != null)
        {
            goto label_27;
        }
        
        }
        else
        {
                this.portraitBorder.color = new UnityEngine.Color() {r = this.notMyPlayerAvaBorder, g = V9.16B, b = V10.16B, a = V11.16B};
            UnityEngine.Color val_6 = UnityEngine.Color.white;
            this.playerName.color = new UnityEngine.Color() {r = val_6.r, g = val_6.g, b = val_6.b, a = val_6.a};
            this.backGround.color = new UnityEngine.Color() {r = this.notMyPlayerBG, g = val_6.g, b = val_6.b, a = val_6.a};
            UnityEngine.Vector3 val_8 = UnityEngine.Vector3.one;
            val_12 = val_8.x;
            val_13 = val_8.z;
        }
        
        label_27:
        this.transform.localScale = new UnityEngine.Vector3() {x = val_12, y = val_8.y, z = val_13};
        this.gameObject.SetActive(value:  true);
        this.丘丄丆不丛丗上三上 = true;
    }
    internal void 丁丒下且丗丈丑丛丂(NetworkStartTable 不且上一上丐三万丛)
    {
        bool val_9;
        UnityEngine.Texture val_10;
        var val_11;
        UnityEngine.Color val_12;
        float val_13;
        if(不且上一上丐三万丛 == 0)
        {
            goto label_3;
        }
        
        this.业丒丅上世丂世一丁 = 不且上一上丐三万丛;
        this.业上上丏丄不上丅丈 = 不且上一上丐三万丛.丈三世丞丕万丄七丂;
        this.playerAvatar.enabled = true;
        bool val_2 = UnityEngine.Object.op_Inequality(x:  this.业丒丅上世丂世一丁.万丛丏万丟丕丒丛与, y:  0);
        if(this.业丒丅上世丂世一丁 == null)
        {
            goto label_9;
        }
        
        if(val_2 == false)
        {
            goto label_10;
        }
        
        label_14:
        val_10 = this.业丒丅上世丂世一丁.万丛丏万丟丕丒丛与;
        if(this.playerAvatar != null)
        {
            goto label_15;
        }
        
        goto label_12;
        label_3:
        if((this.<丞丁丙丏七丆与世丅>k__BackingField) == true)
        {
                return;
        }
        
        this.与丛三丒专丄丈专下();
        return;
        label_9:
        if(val_2 == true)
        {
            goto label_14;
        }
        
        label_10:
        val_10 = this.业丒丅上世丂世一丁.丌丏丞丆丗与东丗业;
        if(this.playerAvatar != null)
        {
            goto label_15;
        }
        
        label_12:
        label_15:
        this.playerName.text = this.业丒丅上世丂世一丁.丂丈丐不丏万三七丐;
        this.万万丗下丁下丗业丟();
        val_11 = null;
        val_11 = null;
        if(不且上一上丐三万丛 == WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable)
        {
                this.portraitBorder.color = new UnityEngine.Color() {r = this.myPlayerAvaBorder, g = V9.16B, b = V10.16B, a = V11.16B};
            this.playerName.color = new UnityEngine.Color() {r = this.myPlayerAvaBorder, g = V9.16B, b = V10.16B, a = V11.16B};
            val_12 = this.myPlayerBG;
            this.backGround.color = new UnityEngine.Color() {r = val_12, g = V9.16B, b = V10.16B, a = V11.16B};
            if(this.transform != null)
        {
            goto label_28;
        }
        
        }
        else
        {
                this.portraitBorder.color = new UnityEngine.Color() {r = this.notMyPlayerAvaBorder, g = V9.16B, b = V10.16B, a = V11.16B};
            UnityEngine.Color val_5 = UnityEngine.Color.white;
            this.playerName.color = new UnityEngine.Color() {r = val_5.r, g = val_5.g, b = val_5.b, a = val_5.a};
            this.backGround.color = new UnityEngine.Color() {r = this.notMyPlayerBG, g = val_5.g, b = val_5.b, a = val_5.a};
            UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
            val_12 = val_7.x;
            val_13 = val_7.z;
        }
        
        label_28:
        this.transform.localScale = new UnityEngine.Vector3() {x = val_12, y = val_7.y, z = val_13};
        val_9 = true;
        this.gameObject.SetActive(value:  true);
        this.丘丄丆不丛丗上三上 = val_9;
    }
    internal void 丅专丅丐且丒丟丌万(MinigameScoreTableItem.丟七三丒丝与且丙世 东一丁世丑丞业丄丐)
    {
        bool val_6;
        if(东一丁世丑丞业丄丐.东东万东丂与丂丞丛 == false)
        {
                return;
        }
        
        this.<丞丁丙丏七丆与世丅>k__BackingField = 东一丁世丑丞业丄丐.东东万东丂与丂丞丛;
        this.<下业丛丑丅丛与丙丂>k__BackingField = 东一丁世丑丞业丄丐.不丙且世与丄与丁丂;
        this.业上上丏丄不上丅丈 = 东一丁世丑丞业丄丐.业上上丏丄不上丅丈;
        this.playerName.text = 东一丁世丑丞业丄丐.丞丞下东且丗丄丒丏;
        this.playerScoreLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7062");
        this.portraitBorder.color = new UnityEngine.Color() {r = this.notMyPlayerAvaBorder, g = V9.16B, b = V10.16B, a = V11.16B};
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        this.playerName.color = new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a};
        this.backGround.color = new UnityEngine.Color() {r = this.notMyPlayerBG, g = val_2.g, b = val_2.b, a = val_2.a};
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.one;
        this.transform.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        val_6 = true;
        this.gameObject.SetActive(value:  true);
        this.丘丄丆不丛丗上三上 = val_6;
    }
    internal void 与丛三丒专丄丈专下()
    {
        this.业丒丅上世丂世一丁 = 0;
        this.<丞丁丙丏七丆与世丅>k__BackingField = false;
        this.丘丄丆不丛丗上三上 = false;
        this.gameObject.SetActive(value:  false);
    }
    internal void 丂丆丄丛丂三丘业一()
    {
        var val_4;
        string val_5;
        val_4 = this;
        if(this.业丒丅上世丂世一丁 == 0)
        {
            goto label_3;
        }
        
        int val_2 = this.业丒丅上世丂世一丁.丝丈丅一丆丗丝丝丘();
        this.<下业丛丑丅丛与丙丂>k__BackingField = val_2;
        if((val_2 & 2147483648) != 0)
        {
            goto label_5;
        }
        
        val_4 = val_2.ToString();
        val_5 = val_4;
        goto label_7;
        label_3:
        this.世丏丟世丈丒丏业丑(不且上一上丐三万丛:  0);
        return;
        label_5:
        val_5 = "0";
        label_7:
        this.playerScoreLabel.text = val_5;
    }
    internal void 万万丗下丁下丗业丟()
    {
        丟七三丒丝与且丙世 val_8;
        UnityEngine.Texture val_9;
        string val_10;
        var val_11;
        var val_12;
        val_8 = this;
        if((this.<丞丁丙丏七丆与世丅>k__BackingField) == true)
        {
                return;
        }
        
        if(this.业丒丅上世丂世一丁 == 0)
        {
                return;
        }
        
        int val_2 = this.业丒丅上世丂世一丁.丝丈丅一丆丗丝丝丘();
        this.<下业丛丑丅丛与丙丂>k__BackingField = val_2;
        if((val_2 & 2147483648) == 0)
        {
                val_9 = val_2.ToString();
            val_10 = val_9;
        }
        else
        {
                val_10 = "0";
        }
        
        this.playerScoreLabel.text = val_10;
        if(this.业丒丅上世丂世一丁.丅上与上丄且不丈东 == false)
        {
                return;
        }
        
        this.<丞丁丙丏七丆与世丅>k__BackingField = true;
        this.playerScoreLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7062");
        val_9 = 1152921505122234368;
        val_11 = null;
        val_11 = null;
        if(RacingCheckpointController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_12 = null;
        val_12 = null;
        val_9 = this.playerAvatar;
        MinigameScoreTableItem.丟七三丒丝与且丙世 val_7 = null;
        val_8 = val_7;
        val_7 = new MinigameScoreTableItem.丟七三丒丝与且丙世(专且丌东丐且丕上业:  val_9, 丞丞下东且丗丄丒丏:  this.playerName.text, 东东万东丂与丂丞丛:  true, 业上上丏丄不上丅丈:  this.业上上丏丄不上丅丈, 不丙且世与丄与丁丂:  this.<下业丛丑丅丛与丙丂>k__BackingField);
        Add(item:  val_7);
    }
    public MinigameScoreTableItem()
    {
        this.业上上丏丄不上丅丈 = "";
    }

}
