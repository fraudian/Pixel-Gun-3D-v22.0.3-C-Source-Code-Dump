using UnityEngine;
internal sealed class FindFriendsFromLocalLAN : MonoBehaviour
{
    // Fields
    internal static bool 丝丐丘丙丒丕丘万丒;
    internal static System.Collections.Generic.List<string> 丏业万丌丏上业专丐;
    internal static System.Action 不七丑且且丟丗东业;
    private System.Net.Sockets.UdpClient 丆上丏专丈丒丌世七;
    private float 丅一万丐丗丒万世东;
    private float 丞丛与丞丙东丙丟丒;
    private bool 七丂丄与丌丄丌丞上;
    private bool 丆丈丆七丂丐丈东丈;
    private System.Collections.Generic.List<string> 丒下丞丈丒三三与丒;
    private string 丄丏上一七业上世东;
    
    // Methods
    private void Start()
    {
        this.世专下三丗且丒丂七();
    }
    private void 世专下三丗且丒丂七()
    {
        this.丄丏上一七业上世东 = 专丈专业丆且且业下.世丈丞丅丂丞丕丗丗();
        new System.Net.Sockets.UdpClient() = new System.Net.Sockets.UdpClient(port:  (与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != true) ? 22046 : 22044);
        this.丆上丏专丈丒丌世七 = new System.Net.Sockets.UdpClient();
        new System.Net.Sockets.UdpClient().EnableBroadcast = true;
        this.上丄丟与丛下不丘丙();
    }
    public void StopBroadCasting()
    {
        if(this.丆上丏专丈丒丌世七 == null)
        {
                return;
        }
        
        this.丆上丏专丈丒丌世七 = 0;
        this.丆上丏专丈丒丌世七.Close();
    }
    private void 上丄丟与丛下不丘丙()
    {
        if(this.丆上丏专丈丒丌世七 == null)
        {
                return;
        }
        
        System.IAsyncResult val_2 = this.丆上丏专丈丒丌世七.BeginReceive(requestCallback:  new System.AsyncCallback(object:  this, method:  System.Void FindFriendsFromLocalLAN::丂丁丞丅丏丏丈丑下(System.IAsyncResult 与七丅丁世七业丒东)), state:  0);
    }
    private System.Collections.IEnumerator OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        FindFriendsFromLocalLAN.丒下万且上七七丌一 val_1 = new FindFriendsFromLocalLAN.丒下万且上七七丌一();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丁与丟万丄丒丗专丌 = 丁与丟万丄丒丗专丌;
        return (System.Collections.IEnumerator)val_1;
    }
    private void 丂丁丞丅丏丏丈丑下(System.IAsyncResult 与七丅丁世七业丒东)
    {
        System.Net.Sockets.UdpClient val_15;
        var val_16;
        var val_17;
        var val_18;
        var val_19;
        if(this.丆上丏专丈丒丌世七 == null)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        val_15 = this.丆上丏专丈丒丌世七;
        System.Byte[] val_2 = val_15.EndReceive(asyncResult:  与七丅丁世七业丒东, remoteEP: ref  new System.Net.IPEndPoint(address:  System.Net.IPAddress.NumberOfLabels, port:  0));
        if(val_2.Length != 0)
        {
                val_15 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  System.Text.Encoding.Unicode);
            if(((System.String.IsNullOrEmpty(value:  System.String.alignConst)) != true) && ((System.String.Equals(a:  System.String.alignConst, b:  this.丄丏上一七业上世东)) != true))
        {
                if((System.String.IsNullOrEmpty(value:  System.String.alignConst)) != true)
        {
                val_17 = null;
            val_17 = null;
            val_15 = FindFriendsFromLocalLAN.丏业万丌丏上业专丐;
            if((val_15.Contains(item:  System.String.alignConst)) != true)
        {
                val_15 = 1152921505234001920;
            val_18 = null;
            val_18 = null;
            if(丌且下丛三丟三业丑.上丁且业世丟专丂三 != false)
        {
                val_15 = 丌且下丛三丟三业丑.丑七不且上丗丁一世().专下一丙东七丄三上();
            if((val_15.Contains(item:  System.String.alignConst)) != true)
        {
                val_19 = null;
            val_19 = null;
            val_15 = FindFriendsFromLocalLAN.丏业万丌丏上业专丐;
            val_15.Add(item:  System.String.alignConst);
            if(this.丆丈丆七丂丐丈东丈 != false)
        {
                val_15 = this.丒下丞丈丒三三与丒;
            val_15.Add(item:  System.String.alignConst);
        }
        
        }
        
        }
        
        }
        
        }
        
            this.七丂丄与丌丄丌丞上 = true;
        }
        
        }
        
        this.上丄丟与丛下不丘丙();
    }
    private void 上世丆丂三丁丂丄丗()
    {
        System.Byte[] val_12;
        var val_13;
        val_12 = this;
        if((System.String.IsNullOrEmpty(value:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true)
        {
                return;
        }
        
        this.丞丛与丞丙东丙丟丒 = UnityEngine.Time.time;
        System.Collections.Generic.List<System.String> val_4 = new System.Collections.Generic.List<System.String>();
        val_4.Add(item:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗());
        string val_6 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_4);
        val_12 = System.Text.Encoding.Unicode;
        if(this.丆上丏专丈丒丌世七 != null)
        {
                val_13 = null;
            val_13 = null;
            new System.Net.IPEndPoint() = new System.Net.IPEndPoint(address:  System.Net.IPAddress.Broadcast, port:  (与丂丏丛丞丞丒丟丄.丒丐丒丏丌丟丏丈丘() != true) ? 22046 : 22044);
            int val_11 = this.丆上丏专丈丒丌世七.Send(dgram:  val_12, bytes:  val_7.dataItem, endPoint:  new System.Net.IPEndPoint());
            return;
        }
        
        UnityEngine.Debug.Log(message:  "objUDPClient=NULL");
    }
    private void Update()
    {
        var val_7;
        var val_8;
        bool val_9;
        val_7 = null;
        val_7 = null;
        if(FriendsWindowGUI.丆丕丝丒不丙且丐丗 == 0)
        {
            goto label_5;
        }
        
        val_8 = null;
        val_8 = null;
        val_9 = FriendsWindowGUI.丆丕丝丒不丙且丐丗.上丙丆不丂丂丄一丂();
        if(this != null)
        {
            goto label_11;
        }
        
        goto label_10;
        label_5:
        val_9 = false;
        if(this != null)
        {
            goto label_11;
        }
        
        label_10:
        label_11:
        this.丆丈丆七丂丐丈东丈 = val_9;
        if(this.丒下丞丈丒三三与丒.Count >= 1)
        {
                丂与专万与丐丌丏不.丑七不且上丗丁一世().上丂不东丝且丆丝丝(世丅丈东丘丐丕丟丐:  this.丒下丞丈丒三三与丒);
            this.丒下丞丈丒三三与丒.Clear();
        }
        
        if(this.丆丈丆七丂丐丈东丈 != true)
        {
                if(this.七丂丄与丌丄丌丞上 == false)
        {
                return;
        }
        
        }
        
        float val_5 = UnityEngine.Time.time;
        val_5 = val_5 - this.丞丛与丞丙东丙丟丒;
        if(val_5 <= this.丅一万丐丗丒万世东)
        {
                return;
        }
        
        this.七丂丄与丌丄丌丞上 = false;
        this.上世丆丂三丁丂丄丗();
    }
    public FindFriendsFromLocalLAN()
    {
        this.丅一万丐丗丒万世东 = 30f;
        this.丒下丞丈丒三三与丒 = new System.Collections.Generic.List<System.String>();
    }
    private static FindFriendsFromLocalLAN()
    {
        FindFriendsFromLocalLAN.丝丐丘丙丒丕丘万丒 = false;
        FindFriendsFromLocalLAN.丏业万丌丏上业专丐 = new System.Collections.Generic.List<System.String>();
        FindFriendsFromLocalLAN.不七丑且且丟丗东业 = 0;
    }

}
