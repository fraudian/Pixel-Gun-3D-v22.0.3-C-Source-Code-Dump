using UnityEngine;
public sealed class LANBroadcastService : MonoBehaviour
{
    // Fields
    public LANBroadcastService.丈丒世与万丘丈三专 serverMessage;
    private string 丂专丆世丟丞业业丕;
    private LANBroadcastService.丝丆三万七七上丈丙 丟丄丈上丌东丑丝三;
    public System.Collections.Generic.List<LANBroadcastService.丈丒世与万丘丈三专> lstReceivedMessages;
    private LANBroadcastService.丘丛世丘业丛专七世 下万丑丞东丒丟丑丛;
    private LANBroadcastService.专丒丘不丏下丕丑上 丏丕丝三丑七丅丌丅;
    private string 且一且丘丂七丌专丟;
    private string 丌一且业丈丕不与丙;
    private float 丛七丕一丆丒丌三专;
    private float 丏丕丙丞不丄丄丗东;
    private float 丝专丛万与丁丝专业;
    private float 丒丗东丄丗东丐丞丆;
    private float 丙丐业丛丏丁丞丅丗;
    private string 七丞万一丁丈下东业;
    
    // Properties
    public string 丌丝丆三丟专万业丝 { get; }
    
    // Methods
    public string get_Message()
    {
        return (string)this.丂专丆世丟丞业业丕;
    }
    private void Start()
    {
        this.lstReceivedMessages = new System.Collections.Generic.List<丈丒世与万丘丈三专>();
    }
    private void Update()
    {
    
    }
    private void 上丄丟与丛下不丘丙()
    {
    
    }
    private void 丏丟丌与丛下业丒不(System.IAsyncResult 与七丅丁世七业丒东)
    {
    
    }
    private void 丄丑丆与丄东丛专丘()
    {
        this.丟丄丈上丌东丑丝三 = 2;
        this.丂专丆世丟丞业业丕 = "Announcing we are a server...";
    }
    private void 丌且丆丂丕业且丟万()
    {
        this.丟丄丈上丌东丑丝三 = 0;
        this.丂专丆世丟丞业业丕 = "Announcements stopped.";
    }
    private void 下丌三丕万丛丛上与()
    {
        System.Collections.Generic.List<丈丒世与万丘丈三专> val_3 = this.lstReceivedMessages;
        if(val_3 == null)
        {
                System.Collections.Generic.List<丈丒世与万丘丈三专> val_1 = null;
            val_3 = val_1;
            val_1 = new System.Collections.Generic.List<丈丒世与万丘丈三专>();
            this.lstReceivedMessages = val_3;
        }
        
        val_1.Clear();
        this.丙丐业丛丏丁丞丅丗 = UnityEngine.Time.time;
        this.丟丄丈上丌东丑丝三 = 1;
        this.丂专丆世丟丞业业丕 = "Searching for other players...";
    }
    private void 三丁丑丙丞丟业丌丙()
    {
        this.丟丄丈上丌东丑丝三 = 0;
        this.丂专丆世丟丞业业丕 = "Search stopped.";
    }
    public void StartSearchBroadCasting(LANBroadcastService.丘丛世丘业丛专七世 丄丕丝丌上万专世不)
    {
        this.下万丑丞东丒丟丑丛 = 丄丕丝丌上万专世不;
        this.下丌三丕万丛丛上与();
    }
    public void StartAnnounceBroadCasting()
    {
        this.丟丄丈上丌东丑丝三 = 2;
        this.丂专丆世丟丞业业丕 = "Announcing we are a server...";
    }
    private void 世专下三丗且丒丂七()
    {
    
    }
    public void StopBroadCasting()
    {
    
    }
    public LANBroadcastService()
    {
        this.丂专丆世丟丞业业丕 = "";
        this.且一且丘丂七丌专丟 = "wanttobeaserver";
        this.丏丕丙丞不丄丄丗东 = 1f;
        this.丝专丛万与丁丝专业 = 0f;
        this.丌一且业丈丕不与丙 = "iamaserver";
        this.丒丗东丄丗东丐丞丆 = 5f;
    }

}
