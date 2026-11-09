using UnityEngine;
internal sealed class BonusPickupsController : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    internal static BonusPickupsController 丄丘七三上丕世丞业;
    private BonusPickup[] 丑七不与丛丆一丂丞;
    public PhotonView photonView;
    private double 一丞丙七一三丛丁上;
    private System.Collections.Generic.List<byte> 丆与丛与丆丙与丐专;
    private System.Collections.Generic.List<byte> 且丕七丘丝丗下丒且;
    private System.Collections.Generic.List<short> 三七万业丛七丝丅世;
    
    // Methods
    private void Awake()
    {
        BonusPickup[] val_8;
        var val_9;
        var val_10;
        this.photonView = this.GetComponent<PhotonView>();
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        BonusPickupsController.丄丘七三上丕世丞业 = this;
        int val_3 = this.transform.childCount;
        val_8 = new BonusPickup[0];
        this.丑七不与丛丆一丂丞 = val_8;
        val_9 = 0;
        goto label_4;
        label_14:
        BonusPickup val_7 = this.transform.GetChild(index:  0).GetComponent<BonusPickup>();
        if(this.丑七不与丛丆一丂丞 == null)
        {
            goto label_7;
        }
        
        if(val_7 != null)
        {
            goto label_8;
        }
        
        goto label_11;
        label_7:
        if(val_7 == null)
        {
            goto label_11;
        }
        
        label_8:
        label_11:
        this.丑七不与丛丆一丂丞[0] = val_7;
        val_8 = this.丑七不与丛丆一丂丞;
        val_9 = 1;
        label_4:
        if(val_9 < this.丑七不与丛丆一丂丞.Length)
        {
            goto label_14;
        }
        
        val_10 = 0;
        goto label_15;
        label_20:
        this.丑七不与丛丆一丂丞[0].PrepareObject(丞世不丒下上上丝丑:  0);
        val_10 = 1;
        label_15:
        if(val_10 < this.丑七不与丛丆一丂丞.Length)
        {
            goto label_20;
        }
    
    }
    internal BonusPickupsController()
    {
        this.丆与丛与丆丙与丐专 = new System.Collections.Generic.List<System.Byte>();
        this.且丕七丘丝丗下丒且 = new System.Collections.Generic.List<System.Byte>();
        this.三七万业丛七丝丅世 = new System.Collections.Generic.List<System.Int16>();
        Rilisoft.且三与世丁丏丂丌下 val_4 = this.与丑丌丌丌丁丌不丕();
        val_4.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  public System.Void BonusPickupsController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
    }
    private void OnDestroy()
    {
        BonusPickupsController.丄丘七三上丕世丞业 = 0;
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
    }
    private void Update()
    {
        this.万万东丙丈东丝丑东();
    }
    private void 万万东丙丈东丝丑东()
    {
        if(TimeGameController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(TimeGameController.丄丞丁丈与业上丞丟.enabled == false)
        {
                return;
        }
        
        if(this.一丞丙七一三丛丁上 == TimeGameController.丄丞丁丈与业上丞丟.丒丂世丌东万三下丗)
        {
                return;
        }
        
        if(this.一丞丙七一三丛丁上 != 0f)
        {
                this.ResetState();
        }
        
        this.一丞丙七一三丛丁上 = TimeGameController.丄丞丁丈与业上丞丟.丒丂世丌东万三下丗;
    }
    public void ResetState()
    {
        goto label_0;
        label_5:
        this.丑七不与丛丆一丂丞[0x0][0].isRespawning = true;
        this.丑七不与丛丆一丂丞[0x0][0].丕丗丑七丁万不世丘 = this.丑七不与丛丆一丂丞[0x0][0].firstSpawnTime;
        this.丑七不与丛丆一丂丞[0].东丒万丘丆丐世丕丗(下下东且万业丞丅丒:  false);
        0 = 1;
        label_0:
        if(0 < this.丑七不与丛丆一丂丞.Length)
        {
            goto label_5;
        }
    
    }
    public void SendPlayDestroyEffect(short 丞世不丒下上上丝丑)
    {
        PhotonView val_2;
        var val_3;
        val_2 = this;
        val_3 = null;
        val_3 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        val_2 = this.photonView;
        object[] val_1 = new object[1];
        val_1[0] = 丞世不丒下上上丝丑;
        val_2.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  39, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        System.Int16[] val_4;
        int val_5;
        System.Byte[] val_6;
        var val_7;
        val_4 = 丞世不丒下上上丝丑;
        byte val_1 = val_4 & 255;
        if(val_1 == 39)
        {
            goto label_1;
        }
        
        if(val_1 != 128)
        {
            goto label_2;
        }
        
        val_5 = 专丒丌丆下丐丞丟丞.Length;
        if(val_5 == 0)
        {
                val_5 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_4 = 专丒丌丆下丐丞丟丞[0];
        object val_5 = 专丒丌丆下丐丞丟丞[1];
        if(val_4 == null)
        {
            goto label_6;
        }
        
        val_4 = val_4;
        if(val_4 != null)
        {
            goto label_7;
        }
        
        label_6:
        val_4 = 0;
        label_7:
        if(val_5 == null)
        {
            goto label_8;
        }
        
        val_6 = val_5;
        if(val_6 != null)
        {
            goto label_9;
        }
        
        label_8:
        val_6 = 0;
        label_9:
        this.专丑丟三与一丆不且(东七丛丝丑专世丏三:  val_4, 丏东丒丏丘丛不丘与:  val_6);
        goto label_10;
        label_1:
        this.三丆丙上丝丅丑丁且(丞世不丒下上上丝丑:  System.Convert.ToInt32(value:  专丒丌丆下丐丞丟丞[0]));
        label_10:
        val_7 = 1;
        return (bool)val_7;
        label_2:
        val_7 = 0;
        return (bool)val_7;
    }
    private void 三丆丙上丝丅丑丁且(int 丞世不丒下上上丝丑)
    {
        if(this.丑七不与丛丆一丂丞 == null)
        {
            goto label_1;
        }
        
        if((丞世不丒下上上丝丑 & 2147483648) == 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if((丞世不丒下上上丝丑 & 2147483648) != 0)
        {
            goto label_5;
        }
        
        label_2:
        if(this.丑七不与丛丆一丂丞.Length > 丞世不丒下上上丝丑)
        {
                this.丑七不与丛丆一丂丞[(long)丞世不丒下上上丝丑].七丛丐与丑丈一万丁();
            return;
        }
        
        label_5:
        UnityEngine.Debug.LogError(message:  "No destroy effect item with index " + 丞世不丒下上上丝丑);
    }
    private void 三丆丙上丝丅丑丁且(short 丞世不丒下上上丝丑)
    {
        if(((int)丞世不丒下上上丝丑 & 65535) < this.丑七不与丛丆一丂丞.Length)
        {
                this.丑七不与丛丆一丂丞[(int)丞世不丒下上上丝丑 & 65535].七丛丐与丑丈一万丁();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "No destroy effect item with index " + 丞世不丒下上上丝丑);
    }
    internal void 专丑丟三与一丆不且(short[] 东七丛丝丑专世丏三, byte[] 丏东丒丏丘丛不丘与)
    {
        var val_1;
        byte val_2;
        var val_3;
        val_1 = 0;
        goto label_0;
        label_11:
        val_2 = 0;
        if(东七丛丝丑专世丏三[val_2] < this.丑七不与丛丆一丂丞.Length)
        {
                val_3 = mem[东七丛丝丑专世丏三[0x0] + 32];
            val_3 = 东七丛丝丑专世丏三[0x0] + 32;
            BonusPickup val_2 = this.丑七不与丛丆一丂丞[val_3];
            val_2 = 丏东丒丏丘丛不丘与[val_2];
            float val_4 = this.丑七不与丛丆一丂丞[东七丛丝丑专世丏三[0x0] + 32][0].respawnTime;
            float val_3 = (float)val_2;
            val_3 = val_3 / 255f;
            val_4 = val_3 * val_4;
            this.丑七不与丛丆一丂丞[东七丛丝丑专世丏三[0x0] + 32][0].丕丗丑七丁万不世丘 = val_4;
        }
        
        val_1 = 1;
        label_0:
        if(val_1 < 东七丛丝丑专世丏三.Length)
        {
            goto label_11;
        }
    
    }
    public void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        var val_6;
        if(this.photonView == 0)
        {
                return;
        }
        
        this.且丕七丘丝丗下丒且.Clear();
        this.三七万业丛七丝丅世.Clear();
        val_6 = 0;
        goto label_6;
        label_20:
        BonusPickup val_5 = this.丑七不与丛丆一丂丞[0];
        if(this.丑七不与丛丆一丂丞[0x0][0].isRespawning != false)
        {
                BonusPickup val_6 = this.丑七不与丛丆一丂丞[0];
            this.三七万业丛七丝丅世.Add(item:  this.丑七不与丛丆一丂丞[0x0][0].myIndex);
            BonusPickup val_7 = this.丑七不与丛丆一丂丞[0];
            float val_8 = this.丑七不与丛丆一丂丞[0x0][0].respawnTime;
            val_8 = this.丑七不与丛丆一丂丞[0x0][0].丕丗丑七丁万不世丘 / val_8;
            val_8 = val_8 * 255f;
            this.丆与丛与丆丙与丐专.Add(item:  (int)val_8);
        }
        
        val_6 = W25 + 1;
        label_6:
        if(((int)val_6 & 65535) < this.丑七不与丛丆一丂丞.Length)
        {
            goto label_20;
        }
        
        object[] val_2 = new object[2];
        val_2[0] = this.三七万业丛七丝丅世.ToArray();
        val_2[1] = this.丆与丛与丆丙与丐专.ToArray();
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  128, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_2);
    }

}
