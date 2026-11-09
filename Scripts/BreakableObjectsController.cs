using UnityEngine;
internal class BreakableObjectsController : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    internal static BreakableObjectsController 丄丘七三上丕世丞业;
    private BreakableObject[] 丑七不与丛丆一丂丞;
    public PhotonView photonView;
    private double 一丞丙七一三丛丁上;
    private System.Collections.Generic.List<byte> 丆与丛与丆丙与丐专;
    private System.Collections.Generic.List<byte> 且丕七丘丝丗下丒且;
    private System.Collections.Generic.List<short> 三七万业丛七丝丅世;
    
    // Methods
    private void Awake()
    {
        BreakableObject[] val_8;
        var val_9;
        var val_10;
        this.photonView = this.GetComponent<PhotonView>();
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        BreakableObjectsController.丄丘七三上丕世丞业 = this;
        int val_3 = this.transform.childCount;
        val_8 = new BreakableObject[0];
        this.丑七不与丛丆一丂丞 = val_8;
        val_9 = 0;
        goto label_4;
        label_14:
        BreakableObject val_7 = this.transform.GetChild(index:  0).GetComponent<BreakableObject>();
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
    internal BreakableObjectsController()
    {
        this.丆与丛与丆丙与丐专 = new System.Collections.Generic.List<System.Byte>();
        this.且丕七丘丝丗下丒且 = new System.Collections.Generic.List<System.Byte>();
        this.三七万业丛七丝丅世 = new System.Collections.Generic.List<System.Int16>();
        Rilisoft.且三与世丁丏丂丌下 val_4 = this.与丑丌丌丌丁丌不丕();
        val_4.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  public System.Void BreakableObjectsController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
    }
    private void OnDestroy()
    {
        BreakableObjectsController.丄丘七三上丕世丞业 = 0;
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
        this.丑七不与丛丆一丂丞[0].ResetState();
        0 = 1;
        label_0:
        if(0 < this.丑七不与丛丆一丂丞.Length)
        {
            goto label_5;
        }
    
    }
    public void SendDamage(short 丞世不丒下上上丝丑, float 且丑丐丂与丐丟丒下)
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
        object[] val_1 = new object[2];
        val_1[0] = 丞世不丒下上上丝丑;
        val_1[1] = 且丑丐丂与丐丟丒下;
        val_2.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  24, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
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
    public void SendVisibleFireEffect(short 丞世不丒下上上丝丑, bool 业下丌下三丕丙丌下)
    {
        bool val_3;
        PhotonView val_4;
        var val_5;
        val_3 = 业下丌下三丕丙丌下;
        val_4 = this;
        val_5 = null;
        val_5 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        val_4 = this.photonView;
        object[] val_1 = new object[2];
        val_1[0] = 丞世不丒下上上丝丑;
        val_3 = val_3;
        val_1[1] = val_3;
        val_4.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  88, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_1);
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_6;
        object val_7;
        System.Int16[] val_8;
        System.Byte[] val_9;
        var val_10;
        System.Int16[] val_11;
        System.Byte[] val_12;
        val_6 = 丞世不丒下上上丝丑;
        byte val_1 = val_6 & 255;
        if(val_1 > 39)
        {
            goto label_1;
        }
        
        if(val_1 == 24)
        {
            goto label_2;
        }
        
        if(val_1 != 39)
        {
            goto label_10;
        }
        
        this.三丆丙上丝丅丑丁且(丞世不丒下上上丝丑:  System.Convert.ToInt32(value:  专丒丌丆下丐丞丟丞[0]));
        goto label_33;
        label_1:
        if(val_1 == 88)
        {
            goto label_9;
        }
        
        if(val_1 != 227)
        {
            goto label_10;
        }
        
        if(专丒丌丆下丐丞丟丞 == null)
        {
            goto label_11;
        }
        
        if(专丒丌丆下丐丞丟丞.Length != 0)
        {
            goto label_41;
        }
        
        label_42:
        label_41:
        val_7 = 专丒丌丆下丐丞丟丞[0];
        val_6 = 专丒丌丆下丐丞丟丞[1];
        if(专丒丌丆下丐丞丟丞.Length >= 3)
        {
            goto label_15;
        }
        
        if(val_7 == null)
        {
            goto label_16;
        }
        
        val_8 = val_7;
        if(val_8 != null)
        {
            goto label_17;
        }
        
        label_16:
        val_8 = 0;
        label_17:
        if(val_6 == null)
        {
            goto label_18;
        }
        
        val_9 = val_6;
        if(val_9 != null)
        {
            goto label_19;
        }
        
        label_18:
        val_9 = 0;
        label_19:
        this.丁世不一下丞丅丘丏(东七丛丝丑专世丏三:  val_8, 丝三不七丑丏一业丑:  val_9);
        goto label_33;
        label_10:
        val_10 = 0;
        return (bool)val_10;
        label_2:
        val_6 = System.Convert.ToInt32(value:  专丒丌丆下丐丞丟丞[0]);
        object val_8 = 专丒丌丆下丐丞丟丞[1];
        this.万不丄下丂三丕丒不(丞世不丒下上上丝丑:  val_6, 且丑丐丂与丐丟丒下:  3.782474E-38f);
        goto label_33;
        label_9:
        val_6 = System.Convert.ToInt32(value:  专丒丌丆下丐丞丟丞[0]);
        object val_10 = 专丒丌丆下丐丞丟丞[1];
        this.东丂丝丈丅丙世业丑(丞世不丒下上上丝丑:  val_6, 下下东且万业丞丅丒:  false);
        goto label_33;
        label_15:
        object val_11 = 专丒丌丆下丐丞丟丞[2];
        if(val_7 == null)
        {
            goto label_35;
        }
        
        val_11 = val_7;
        if(val_11 != null)
        {
            goto label_36;
        }
        
        label_35:
        val_11 = 0;
        label_36:
        if(val_6 == null)
        {
            goto label_37;
        }
        
        val_7 = val_6;
        if(val_7 != null)
        {
            goto label_38;
        }
        
        label_37:
        val_7 = 0;
        label_38:
        if(val_11 == null)
        {
            goto label_39;
        }
        
        val_6 = null;
        val_12 = val_11;
        if(val_12 != null)
        {
            goto label_40;
        }
        
        label_39:
        val_12 = 0;
        label_40:
        this.丁世不一下丞丅丘丏(东七丛丝丑专世丏三:  val_11, 丝三不七丑丏一业丑:  val_7, 丏东丒丏丘丛不丘与:  val_12);
        label_33:
        val_10 = 1;
        return (bool)val_10;
        label_11:
        if(28563616 != 0)
        {
            goto label_41;
        }
        
        goto label_42;
    }
    private void 万不丄下丂三丕丒不(int 丞世不丒下上上丝丑, float 且丑丐丂与丐丟丒下)
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
                this.丑七不与丛丆一丂丞[(long)丞世不丒下上上丝丑].GetDamageRPC(且丑丐丂与丐丟丒下:  且丑丐丂与丐丟丒下);
            return;
        }
        
        label_5:
        UnityEngine.Debug.LogError(message:  "No breakable item with index " + 丞世不丒下上上丝丑);
    }
    private void 万不丄下丂三丕丒不(short 丞世不丒下上上丝丑, float 且丑丐丂与丐丟丒下)
    {
        if(((int)丞世不丒下上上丝丑 & 65535) < this.丑七不与丛丆一丂丞.Length)
        {
                this.丑七不与丛丆一丂丞[(int)丞世不丒下上上丝丑 & 65535].GetDamageRPC(且丑丐丂与丐丟丒下:  且丑丐丂与丐丟丒下);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "No breakable item with index " + 丞世不丒下上上丝丑);
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
                this.丑七不与丛丆一丂丞[(long)丞世不丒下上上丝丑].业丐丞万与七万丗与();
            return;
        }
        
        label_5:
        UnityEngine.Debug.LogError(message:  "No destroy effect item with index " + 丞世不丒下上上丝丑);
    }
    private void 三丆丙上丝丅丑丁且(short 丞世不丒下上上丝丑)
    {
        if(((int)丞世不丒下上上丝丑 & 65535) < this.丑七不与丛丆一丂丞.Length)
        {
                this.丑七不与丛丆一丂丞[(int)丞世不丒下上上丝丑 & 65535].业丐丞万与七万丗与();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "No destroy effect item with index " + 丞世不丒下上上丝丑);
    }
    private void 东丂丝丈丅丙世业丑(int 丞世不丒下上上丝丑, bool 下下东且万业丞丅丒)
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
                this.丑七不与丛丆一丂丞[(long)丞世不丒下上上丝丑].丘丈上丅与丏丑丈业(下下东且万业丞丅丒:  下下东且万业丞丅丒);
            return;
        }
        
        label_5:
        UnityEngine.Debug.LogError(message:  "No fire effect item with index " + 丞世不丒下上上丝丑);
    }
    private void 东丂丝丈丅丙世业丑(short 丞世不丒下上上丝丑)
    {
        if(((int)丞世不丒下上上丝丑 & 65535) < this.丑七不与丛丆一丂丞.Length)
        {
                this.丑七不与丛丆一丂丞[(int)丞世不丒下上上丝丑 & 65535].业丐丞万与七万丗与();
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "No fire effect item with index " + 丞世不丒下上上丝丑);
    }
    internal void 丁世不一下丞丅丘丏(short[] 东七丛丝丑专世丏三, byte[] 丝三不七丑丏一业丑, byte[] 丏东丒丏丘丛不丘与)
    {
        var val_1;
        short val_2;
        val_1 = 0;
        goto label_0;
        label_17:
        val_2 = 东七丛丝丑专世丏三[0];
        if(val_2 < this.丑七不与丛丆一丂丞.Length)
        {
                this.丑七不与丛丆一丂丞[东七丛丝丑专世丏三[0x0] + 32].SetSyncHealth(丌丞东上丝丆一专七:  丝三不七丑丏一业丑[0]);
            val_2 = this.丑七不与丛丆一丂丞[东七丛丝丑专世丏三[0x0] + 32];
            val_2.SetSyncTimeLeftToRespawn(丁不丞丂丐丂丈丈丈:  丏东丒丏丘丛不丘与[0]);
        }
        
        val_1 = 1;
        label_0:
        if(val_1 < 东七丛丝丑专世丏三.Length)
        {
            goto label_17;
        }
    
    }
    internal void 丁世不一下丞丅丘丏(short[] 东七丛丝丑专世丏三, byte[] 丝三不七丑丏一业丑)
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
            val_2 = 丝三不七丑丏一业丑[val_2];
            this.丑七不与丛丆一丂丞[val_3].SetSyncHealth(丌丞东上丝丆一专七:  val_2);
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
        var val_10;
        if(this.photonView == 0)
        {
                return;
        }
        
        this.且丕七丘丝丗下丒且.Clear();
        this.三七万业丛七丝丅世.Clear();
        this.丆与丛与丆丙与丐专.Clear();
        val_10 = 0;
        goto label_7;
        label_25:
        if(this.丑七不与丛丆一丂丞[0].isDamaged != false)
        {
                BreakableObject val_10 = this.丑七不与丛丆一丂丞[0];
            this.三七万业丛七丝丅世.Add(item:  this.丑七不与丛丆一丂丞[0x0][0].myIndex);
            this.且丕七丘丝丗下丒且.Add(item:  this.丑七不与丛丆一丂丞[0].GetSyncHealth());
            this.丆与丛与丆丙与丐专.Add(item:  this.丑七不与丛丆一丂丞[0].GetSyncTimeLeftToRespawn());
        }
        
        val_10 = W25 + 1;
        label_7:
        if(((int)val_10 & 65535) < this.丑七不与丛丆一丂丞.Length)
        {
            goto label_25;
        }
        
        object[] val_5 = new object[3];
        val_5[0] = this.三七万业丛七丝丅世.ToArray();
        val_5[1] = this.且丕七丘丝丗下丒且.ToArray();
        val_5[2] = this.丆与丛与丆丙与丐专.ToArray();
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  227, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_5);
    }

}
