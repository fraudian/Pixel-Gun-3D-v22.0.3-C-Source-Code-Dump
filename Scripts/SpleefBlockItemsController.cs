using UnityEngine;
internal sealed class SpleefBlockItemsController : VTableHolder, 东丁丆一业丈万丆丐
{
    // Fields
    internal static SpleefBlockItemsController 丄丘七三上丕世丞业;
    public SpleefBlockItem[] items;
    public UnityEngine.Material[] stageMaterials;
    public UnityEngine.AudioClip hitSound;
    public UnityEngine.AudioClip deadSound;
    
    // Methods
    private void Start()
    {
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        SpleefBlockItemsController.丄丘七三上丕世丞业 = this;
    }
    private void OnDestroy()
    {
        SpleefBlockItemsController.丄丘七三上丕世丞业 = 0;
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
    }
    internal SpleefBlockItemsController()
    {
        Rilisoft.且三与世丁丏丂丌下 val_1 = this.与丑丌丌丌丁丌不丕();
        val_1.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  public System.Void SpleefBlockItemsController::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
    }
    private void Update()
    {
        SpleefBlockItem[] val_7;
        short val_8;
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        if(UnityEngine.Application.isPlaying == true)
        {
                return;
        }
        
        val_7 = this.gameObject.transform.GetComponentsInChildren<SpleefBlockItem>();
        val_8 = 0;
        this.items = val_7;
        goto label_5;
        label_10:
        SpleefBlockItem val_6 = this.items[0];
        this.items[0x0][0].index = val_8;
        val_7 = this.items;
        val_8 = W22 + 1;
        label_5:
        if(((int)val_8 & 65535) < this.items.Length)
        {
            goto label_10;
        }
    
    }
    public void GetDamage(short 丞世不丒下上上丝丑, float 丞丈专下丈专业三丞)
    {
        object[] val_2 = new object[2];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(丞世不丒下上上丝丑 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(丞世不丒下上上丝丑 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 丞世不丒下上上丝丑;
        val_2[1] = 丞丈专下丈专业三丞;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  24, 丞下万上三丘上与专:  1, 丗丟上上丒丐丗丞丙:  val_2);
    }
    public bool OnEventFired(byte 丗与一丛丐丞丘丌丞, object[] 专丒丌丆下丐丞丟丞)
    {
        System.Int16[] val_3;
        int val_4;
        int val_5;
        System.Byte[] val_6;
        var val_7;
        val_3 = 丗与一丛丐丞丘丌丞;
        byte val_1 = val_3 & 255;
        if(val_1 == 128)
        {
            goto label_1;
        }
        
        if(val_1 != 24)
        {
            goto label_2;
        }
        
        val_4 = 专丒丌丆下丐丞丟丞.Length;
        if(val_4 == 0)
        {
                val_4 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_3 = 专丒丌丆下丐丞丟丞[0];
        object val_4 = 专丒丌丆下丐丞丟丞[1];
        this.万不丄下丂三丕丒不(丞世不丒下上上丝丑:  61440, 不丄一下下丈丈丛世:  3.782474E-38f);
        goto label_6;
        label_1:
        val_5 = 专丒丌丆下丐丞丟丞.Length;
        if(val_5 == 0)
        {
                val_5 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        object val_5 = 专丒丌丆下丐丞丟丞[0];
        object val_6 = 专丒丌丆下丐丞丟丞[1];
        if(val_5 == null)
        {
            goto label_10;
        }
        
        val_3 = val_5;
        if(val_3 != null)
        {
            goto label_11;
        }
        
        label_10:
        val_3 = 0;
        label_11:
        if(val_6 == null)
        {
            goto label_12;
        }
        
        val_6 = val_6;
        if(val_6 != null)
        {
            goto label_13;
        }
        
        label_12:
        val_6 = 0;
        label_13:
        this.丑丂业且下上丝丈世(东七丛丝丑专世丏三:  val_3, 丏一与丝丅丗丈丘丕:  val_6);
        label_6:
        val_7 = 1;
        return (bool)val_7;
        label_2:
        val_7 = 0;
        return (bool)val_7;
    }
    private void 万不丄下丂三丕丒不(short 丞世不丒下上上丝丑, float 不丄一下下丈丈丛世)
    {
        this.items[(int)(short)((丞世不丒下上上丝丑) & 0xFFFF)][0].isDamageble = true;
        if((this.items[(int)(short)((丞世不丒下上上丝丑) & 0xFFFF)][0].isKilled) != false)
        {
                return;
        }
        
        float val_2 = this.items[(int)(short)((丞世不丒下上上丝丑) & 0xFFFF)][0].live;
        val_2 = val_2 - 不丄一下下丈丈丛世;
        this.items[(int)(short)((丞世不丒下上上丝丑) & 0xFFFF)][0].live = val_2;
        this.items[(int)丞世不丒下上上丝丑 & 65535].丏丝丄不丝丆三丏丟();
    }
    private void 丑丂业且下上丝丈世(short[] 东七丛丝丑专世丏三, byte[] 丏一与丝丅丗丈丘丕)
    {
        var val_3;
        var val_4;
        byte val_5;
        val_3 = 0;
        goto label_0;
        label_25:
        SpleefBlockItem val_3 = this.items[东七丛丝丑专世丏三[0]];
        val_5 = 丏一与丝丅丗丈丘丕[0];
        if(this.items[东七丛丝丑专世丏三[0x0][0]][0].live > (float)val_5)
        {
                if(W24 >= 丏一与丝丅丗丈丘丕.Length)
        {
                val_5 = mem[丏一与丝丅丗丈丘丕[0x0] + 32];
            val_5 = 丏一与丝丅丗丈丘丕[0x0] + 32;
        }
        
            if(val_5 == 0)
        {
                this.items[东七丛丝丑专世丏三[0x0] + 32].gameObject.SetActive(value:  false);
        }
        
            SpleefBlockItem val_5 = this.items[东七丛丝丑专世丏三[0x0] + 32];
            this.items[东七丛丝丑专世丏三[0x0] + 32][0].live = (float)丏一与丝丅丗丈丘丕[0x0] + 32;
            val_4 = mem[东七丛丝丑专世丏三[0x0] + 32];
            val_4 = 东七丛丝丑专世丏三[0x0] + 32;
            SpleefBlockItem val_6 = this.items[val_4];
            this.items[东七丛丝丑专世丏三[0x0] + 32][0].isDamageble = true;
        }
        
        val_3 = W24 + 1;
        label_0:
        if(((int)val_3 & 65535) < 东七丛丝丑专世丏三.Length)
        {
            goto label_25;
        }
    
    }
    public void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        object val_10;
        var val_11;
        byte val_12;
        System.Collections.Generic.List<System.Byte> val_1 = new System.Collections.Generic.List<System.Byte>();
        System.Collections.Generic.List<System.Int16> val_2 = new System.Collections.Generic.List<System.Int16>();
        val_10 = 0;
        goto label_1;
        label_25:
        SpleefBlockItem val_9 = this.items[0];
        if(this.items[0x0][0].isDamageble != false)
        {
                SpleefBlockItem val_10 = this.items[0];
            val_2.Add(item:  this.items[0x0][0].index);
            SpleefBlockItem val_11 = this.items[0];
            if(this.items[0x0][0].isKilled != false)
        {
                UnityEngine.Debug.Log(message:  "Add 0 index ="("Add 0 index =") + val_10);
            val_11 = public System.Void System.Collections.Generic.List<System.Byte>::Add(System.Byte item);
            val_12 = 0;
        }
        else
        {
                SpleefBlockItem val_12 = this.items[0];
            val_11 = public System.Void System.Collections.Generic.List<System.Byte>::Add(System.Byte item);
            val_12 = UnityEngine.Mathf.CeilToInt(f:  this.items[0x0][0].live);
        }
        
            val_1.Add(item:  val_12);
        }
        
        val_10 = W25 + 1;
        label_1:
        if(((int)val_10 & 65535) < this.items.Length)
        {
            goto label_25;
        }
        
        object[] val_6 = new object[2];
        T[] val_7 = val_2.ToArray();
        if(val_6 == null)
        {
            goto label_27;
        }
        
        if(val_7 != null)
        {
            goto label_28;
        }
        
        goto label_31;
        label_27:
        if(val_7 == null)
        {
            goto label_31;
        }
        
        label_28:
        label_31:
        val_6[0] = val_7;
        val_6[1] = val_1.ToArray();
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  128, 万丌万丅专丞业丈万:  专丞上七七且丝七丗, 丗丟上上丒丐丗丞丙:  val_6);
    }

}
