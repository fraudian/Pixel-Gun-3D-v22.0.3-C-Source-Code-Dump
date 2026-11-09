using UnityEngine;
internal class PlayerBotWear : VTableHolder
{
    // Fields
    internal SkinName 丝丘丅与丌丗丅丈下;
    internal PlayerBotController 丒专丈丛下丒一丒丛;
    private bool 丟丄丆丝丁丘丙业丟;
    public string hat;
    public string cape;
    private byte[] 丝专丌七万丈丏且丐;
    public string mask;
    public string boots;
    private bool 丐丄下丒世丏七且丘;
    private bool 丕三丑丛与专丏丒丒;
    private bool 丐丑且下丗丘丗三丙;
    private bool 世丛世且丆不丐丌丝;
    private string 与丙丕丛一丌丛丆丈;
    private bool 丈七与世丏丕业世丙;
    private string 丐丒丈丌与丈丏不上;
    private byte[] 丘专丅丞七且丗东丁;
    private string 且丘世丏丛丛万丟万;
    
    // Methods
    internal PlayerBotWear()
    {
        Rilisoft.且三与世丁丏丂丌下 val_1 = this.与丑丌丌丌丁丌不丕();
        val_1.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void PlayerBotWear::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
    }
    internal void 丌且且丒丘丑东丕丐(SkinName 丝丘丅与丌丗丅丈下)
    {
        this.丝丘丅与丌丗丅丈下 = 丝丘丅与丌丗丅丈下;
        this.上丛丌丆丑上七世三();
    }
    private void 丂丕下与丄业丘业且(Rilisoft.七丆丛上丂丏世丛丑 丑与丆丝丕东丛丄丝, PhotonTargets 丞下万上三丘上与专, object[] 丗丟上上丒丐丗丞丙)
    {
        if(this.丝丘丅与丌丗丅丈下 == 0)
        {
                return;
        }
        
        this.丝丘丅与丌丗丅丈下.丄丈丑丐丆丞丘与丗.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  丑与丆丝丕东丛丄丝, 丞下万上三丘上与专:  丞下万上三丘上与专, 丗丟上上丒丐丗丞丙:  丗丟上上丒丐丗丞丙);
    }
    private void 上丛丌丆丑上七世三()
    {
        this.丒专丈丛下丒一丒丛 = this.GetComponent<PlayerBotController>();
        this.UpdateWear();
    }
    public void ResetWearInitialize()
    {
        this.丟丄丆丝丁丘丙业丟 = false;
    }
    public void UpdateWear()
    {
        PlayerBotController val_8;
        int val_9;
        string val_10;
        System.Object[] val_11;
        var val_12;
        if(this.丒专丈丛下丒一丒丛 != 0)
        {
            goto label_3;
        }
        
        val_8 = this.GetComponent<PlayerBotController>();
        this.丒专丈丛下丒一丒丛 = val_8;
        if(val_8 != null)
        {
            goto label_6;
        }
        
        goto label_5;
        label_3:
        val_8 = this.丒专丈丛下丒一丒丛;
        if(val_8 != null)
        {
            goto label_6;
        }
        
        label_5:
        label_6:
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丌丞三丕不丒业丆业 != true)
        {
                object[] val_3 = new object[3];
            val_3[0] = System.String.alignConst;
            val_3[1] = "gadget_fraggrenade";
            val_9 = System.String.alignConst;
            val_3[2] = val_9;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  73, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  val_3);
        }
        
        if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丌丞三丕不丒业丆业 != false)
        {
                if(this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆 != null)
        {
                this.hat = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.上丈专丌万丕丙万丘;
            this.mask = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丟世丟丐且丐丟七上;
            this.boots = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.且与丛专丗丞丑丑丝;
            this.cape = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丈丐丕业下丟业丛一;
            this.丝专丌七万丈丏且丐 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丝专丌七万丈丏且丐;
            this.丐丄下丒世丏七且丘 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丐丄下丒世丏七且丘;
            this.丕三丑丛与专丏丒丒 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丕三丑丛与专丏丒丒;
            this.丐丑且下丗丘丗三丙 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丐丑且下丗丘丗三丙;
            this.世丛世且丆不丐丌丝 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.世丛世且丆不丐丌丝;
            this.与丙丕丛一丌丛丆丈 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.与丙丕丛一丌丛丆丈;
            this.丟丄丆丝丁丘丙业丟 = true;
            this.丈七与世丏丕业世丙 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丈七与世丏丕业世丙;
            this.丘专丅丞七且丗东丁 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丘专丅丞七且丗东丁;
            this.且丘世丏丛丛万丟万 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.万丐丆丗丏丝七东专;
            val_10 = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丛丗丅丆丕丅上丑三;
            this.丐丒丈丌与丈丏不上 = val_10;
            if(this.丒专丈丛下丒一丒丛 == null)
        {
                val_10 = this.丐丒丈丌与丈丏不上;
        }
        
            this.丒专丈丛下丒一丒丛.player.丐不专世丟七下丛丗(丐丒丈丌与丈丏不上:  val_10);
            val_11 = new object[3];
            val_11[0] = System.String.alignConst;
            val_11[1] = this.丒专丈丛下丒一丒丛.丗丈东丕不丘三丞业.丗万三专丌丞七丁丆.丐专下三丙三世且万;
            val_12 = null;
        }
        else
        {
                object[] val_5 = new object[3];
            val_11 = val_5;
            val_11[0] = System.String.alignConst;
            val_11[1] = "gadget_fraggrenade";
            val_12 = null;
        }
        
            val_9 = System.String.alignConst;
            val_11[2] = val_9;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  73, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  val_5);
        }
        
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        this.丛七业丁专丈丅上丈();
    }
    private void 丛七业丁专丈丅上丈()
    {
        object val_13;
        if(this.丟丄丆丝丁丘丙业丟 == false)
        {
                return;
        }
        
        object[] val_1 = new object[4];
        val_1[0] = this.丐丄下丒世丏七且丘;
        val_1[1] = this.丕三丑丛与专丏丒丒;
        val_1[2] = this.丐丑且下丗丘丗三丙;
        val_13 = this.世丛世且丆不丐丌丝;
        val_1[3] = val_13;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  91, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_1);
        if((System.String.IsNullOrEmpty(value:  this.hat)) != true)
        {
                object[] val_3 = new object[1];
            val_13 = this.hat;
            val_3[0] = val_13;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  74, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_3);
        }
        
        if((System.String.IsNullOrEmpty(value:  this.mask)) != true)
        {
                object[] val_5 = new object[1];
            val_13 = this.mask;
            val_5[0] = val_13;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  78, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_5);
        }
        
        if((System.String.IsNullOrEmpty(value:  this.boots)) != true)
        {
                object[] val_7 = new object[1];
            val_13 = this.boots;
            val_7[0] = val_13;
            this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  60, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_7);
        }
        
        if(this.丝专丌七万丈丏且丐 == null)
        {
            goto label_30;
        }
        
        object[] val_8 = new object[1];
        val_13 = this.丝专丌七万丈丏且丐;
        goto label_31;
        label_30:
        if((System.String.IsNullOrEmpty(value:  this.cape)) == true)
        {
            goto label_32;
        }
        
        object[] val_10 = new object[1];
        val_13 = this.cape;
        label_31:
        val_10[0] = val_13;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  62, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_10);
        label_32:
        if((System.String.IsNullOrEmpty(value:  this.与丙丕丛一丌丛丆丈)) == true)
        {
                return;
        }
        
        object[] val_12 = new object[3];
        val_12[0] = this.与丙丕丛一丌丛丆丈;
        val_12[1] = this.与丙丕丛一丌丛丆丈;
        bool val_13 = this.丈七与世丏丕业世丙;
        val_13 = val_13 ^ 1;
        val_13 = val_13;
        val_12[2] = val_13;
        this.丂丕下与丄业丘业且(丑与丆丝丕东丛丄丝:  59, 丞下万上三丘上与专:  0, 丗丟上上丒丐丗丞丙:  val_12);
    }
    private void Update()
    {
    
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        if(this.photonView.isMine == false)
        {
                return;
        }
        
        this.丛七业丁专丈丅上丈();
    }

}
