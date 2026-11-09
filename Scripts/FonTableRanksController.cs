using UnityEngine;
public class FonTableRanksController : MonoBehaviour
{
    // Fields
    public bool isTeamTable;
    public UnityEngine.GameObject scoreHead;
    public UnityEngine.GameObject countKillsHead;
    public UnityEngine.GameObject likeHead;
    public UnityEngine.GameObject rankHead;
    public int command;
    public string nameCommand;
    public UISprite fon;
    public UISprite fonHead;
    public UISprite fonUndrhead;
    public UILabel headLabel;
    public UILabel countDistance;
    public UILabel countTime;
    public UILabel countPlace;
    public UILabel[] undrheadLabels;
    
    // Methods
    private void Start()
    {
        var val_54;
        var val_55;
        string val_56;
        var val_57;
        val_54 = this;
        if(GameConnect.丑丌丛丈丅丅与不业() == 4)
        {
                UnityEngine.Vector3 val_3 = this.countKillsHead.transform.position;
            val_55 = val_3.x;
            UnityEngine.Vector3 val_6 = this.scoreHead.transform.position;
            UnityEngine.Vector3 val_8 = this.countKillsHead.transform.position;
            UnityEngine.Vector3 val_10 = this.countKillsHead.transform.position;
            this.countKillsHead.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            UnityEngine.Vector3 val_13 = this.scoreHead.transform.position;
            UnityEngine.Vector3 val_15 = this.scoreHead.transform.position;
            this.scoreHead.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
            val_56 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1006");
            this.countKillsHead.GetComponent<UILabel>().text = val_56;
            if(this.likeHead != 0)
        {
                this.likeHead.SetActive(value:  false);
        }
        
        }
        
        if((GameConnect.丑丌丛丈丅丅与不业() != 1) && (GameConnect.丑丌丛丈丅丅与不业() != 14))
        {
                if(GameConnect.丑丌丛丈丅丅与不业() != 21)
        {
                if(GameConnect.东丒七专丂世丝丏丗() == false)
        {
            goto label_51;
        }
        
        }
        
        }
        
        UnityEngine.Vector3 val_25 = this.countKillsHead.transform.position;
        val_55 = val_25.x;
        UnityEngine.Vector3 val_27 = this.scoreHead.transform.position;
        val_56 = this.scoreHead.transform;
        UnityEngine.Vector3 val_29 = val_56.position;
        this.scoreHead.transform.position = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        this.countKillsHead.SetActive(value:  false);
        if(this.likeHead != 0)
        {
                this.likeHead.SetActive(value:  false);
        }
        
        label_51:
        if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                this.scoreHead.gameObject.SetActive(value:  false);
            this.countKillsHead.gameObject.SetActive(value:  false);
            this.likeHead.SetActive(value:  false);
        }
        
        if(GameConnect.东且三丆丑世世丘丟() == false)
        {
            goto label_63;
        }
        
        this.scoreHead.gameObject.SetActive(value:  false);
        this.countKillsHead.gameObject.SetActive(value:  false);
        if(this.likeHead == 0)
        {
            goto label_75;
        }
        
        val_57 = 1;
        goto label_72;
        label_63:
        if(this.likeHead == 0)
        {
            goto label_75;
        }
        
        val_57 = 0;
        label_72:
        this.likeHead.SetActive(value:  false);
        label_75:
        if(GameConnect.丆丕丒与丂七与下上() != true)
        {
                if(GameConnect.且丘丄丛下丆丟万丕() == false)
        {
            goto label_82;
        }
        
        }
        
        this.scoreHead.gameObject.SetActive(value:  false);
        this.countKillsHead.gameObject.SetActive(value:  false);
        val_56 = GameConnect.丆丕丒与丂七与下上();
        this.countDistance.gameObject.SetActive(value:  val_56);
        this.countTime.gameObject.SetActive(value:  true);
        label_82:
        if(GameConnect.一业上七丟业且业丙() == false)
        {
                return;
        }
        
        this.scoreHead.gameObject.SetActive(value:  false);
        this.countKillsHead.gameObject.SetActive(value:  false);
        val_56 = GameConnect.一业上七丟业且业丙();
        this.countDistance.gameObject.SetActive(value:  val_56);
        val_54 = this.countTime.gameObject;
        val_54.SetActive(value:  true);
    }
    public void SetCommand(int 与丁丟东丞丙丗丌丈)
    {
        UILabel val_4;
        string val_5;
        UISprite val_6;
        float val_7;
        var val_8;
        var val_9;
        val_5 = this;
        if(this.isTeamTable == false)
        {
                return;
        }
        
        if(与丁丟东丞丙丗丌丈 == 0)
        {
            goto label_2;
        }
        
        if(与丁丟东丞丙丗丌丈 == 1)
        {
            goto label_3;
        }
        
        if(与丁丟东丞丙丗丌丈 != 2)
        {
                return;
        }
        
        val_6 = this.fon;
        goto label_5;
        label_2:
        this.fon.spriteName = "GreyTableHead";
        this.fonHead.spriteName = "GreyTableHead";
        this.fonUndrhead.spriteName = "GreyTable";
        val_7 = 0.6f;
        val_4 = 0;
        goto label_9;
        label_13:
        this.undrheadLabels[0].color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        val_4 = 1;
        label_9:
        if(val_4 < this.undrheadLabels.Length)
        {
            goto label_13;
        }
        
        val_5 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  this.nameCommand);
        this.headLabel.text = val_5;
        return;
        label_3:
        val_6 = val_5;
        this.fon.spriteName = "BlueTeamTableHead";
        this.fonHead.spriteName = "BlueTeamTableHead";
        this.fonUndrhead.spriteName = "BlueTeamTable";
        val_7 = 0.6f;
        val_8 = 0;
        goto label_21;
        label_25:
        this.undrheadLabels[0].color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        val_8 = 1;
        label_21:
        if(val_8 < this.undrheadLabels.Length)
        {
            goto label_25;
        }
        
        val_4 = this.headLabel;
        val_4.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1771");
        if(与丁丟东丞丙丗丌丈 != 2)
        {
                return;
        }
        
        label_5:
        null.spriteName = "RedTeamTableHead";
        this.fonHead.spriteName = "RedTeamTableHead";
        this.fonUndrhead.spriteName = "RedTeamTable";
        this.headLabel.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_1772");
        val_4 = this.undrheadLabels;
        val_7 = 0.7f;
        val_9 = 0;
        goto label_36;
        label_40:
        val_5 = val_4[0];
        val_5.color = new UnityEngine.Color() {r = 0f, g = 0f, b = 0f, a = 0f};
        val_9 = 1;
        label_36:
        if(val_9 < this.undrheadLabels.Length)
        {
            goto label_40;
        }
    
    }
    private void Update()
    {
        NetworkStartTable val_10;
        var val_11;
        bool val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        var val_20;
        int val_21;
        val_10 = 1152921504848912384;
        if(this.rankHead != 0)
        {
                val_11 = null;
            val_11 = null;
            if(GameController.onlineMode.丗三不丞丈业丑丘万 != false)
        {
                val_12 = 0;
        }
        else
        {
                val_13 = null;
            val_13 = null;
            val_12 = BalanceController.丄专丕世与世丙丏丛;
        }
        
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.rankHead, 丏业丟一东丂东丘丛:  (val_12 == true) ? 1 : 0);
        }
        
        val_14 = null;
        val_14 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_15 = null;
        val_15 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
            goto label_24;
        }
        
        val_16 = null;
        val_16 = null;
        if(null == 0)
        {
            goto label_28;
        }
        
        val_17 = null;
        val_17 = null;
        if(null != 0)
        {
            goto label_33;
        }
        
        goto label_33;
        label_24:
        val_18 = 0;
        goto label_39;
        label_28:
        val_18 = 0;
        label_33:
        val_19 = null;
        val_19 = null;
        val_10 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_10 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        if(丘丑丅三丆丑丌且丝() >= 1)
        {
                val_20 = null;
            val_20 = null;
            val_18 = 丘丑丅三丆丑丌且丝();
        }
        
        label_39:
        if(NetworkStartTable.与一专丒东丏丘专丕() != false)
        {
                if(GameConnect.一与东丝万上三丆丏() == false)
        {
            goto label_49;
        }
        
        }
        
        if(val_18 >= 1)
        {
            goto label_50;
        }
        
        val_21 = 0;
        goto label_53;
        label_49:
        val_21 = 0;
        if((val_18 < 1) || (NetworkStartTableNGUIController.丙丁丘专丕不上不东() == true))
        {
            goto label_53;
        }
        
        label_50:
        val_21 = this.command;
        label_53:
        this.SetCommand(与丁丟东丞丙丗丌丈:  val_21);
    }
    public FonTableRanksController()
    {
    
    }

}
