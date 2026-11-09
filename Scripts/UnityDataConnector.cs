using UnityEngine;
public class UnityDataConnector : MonoBehaviour
{
    // Fields
    public string webServiceUrl;
    public string spreadsheetId;
    public string worksheetName;
    public string password;
    public float maxWaitTime;
    public UnityEngine.GameObject dataDestinationObject;
    public string statisticsWorksheetName;
    public bool debugMode;
    private bool 丂丟世丛七丗丆不世;
    private string 世专世且丟专丁丑丄;
    private LitJson.丑丘丆不丄丐丟丄七[] 丗一且丙丛丈丛下上;
    private bool 丗丆丅丄不丝一上丐;
    private UnityEngine.Rect 丄东丑万丑一丙业业;
    private UnityEngine.Rect 丛丌丈且上丟丄丕三;
    private UnityEngine.Rect 丌三上业丅丞丗丄丁;
    private UnityEngine.Rect 丝业万东万丁专专七;
    
    // Methods
    private void Start()
    {
        this.丂丟世丛七丗丆不世 = false;
        this.世专世且丟专丁丑丄 = "Offline";
        this.丗丆丅丄不丝一上丐 = false;
        mem[1152921526187294352] = 0;
        this.丄东丑万丑一丙业业 = 0;
        mem[1152921526187294360] = 0;
        this.丛丌丈且上丟丄丕三 = 0;
        mem[1152921526187294368] = 0;
        mem[1152921526187294376] = 0;
        this.丌三上业丅丞丗丄丁 = 0;
        mem[1152921526187294384] = 0;
        mem[1152921526187294392] = 0;
        this.丝业万东万丁专专七 = 0;
        mem[1152921526187294400] = 0;
        mem[1152921526187294408] = 0;
    }
    private void OnGUI()
    {
        UnityEngine.GUI.Box(position:  new UnityEngine.Rect() {m_XMin = this.丄东丑万丑一丙业业, m_YMin = V10.16B, m_Width = V9.16B, m_Height = V8.16B}, text:  this.世专世且丟专丁丑丄);
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = this.丛丌丈且上丟丄丕三, m_YMin = V10.16B, m_Width = V9.16B, m_Height = V8.16B}, text:  "Update From Google Spreadsheet")) != false)
        {
                this.丗丑不丙专丂一下丈();
        }
        
        this.丗丆丅丄不丝一上丐 = UnityEngine.GUI.Toggle(position:  new UnityEngine.Rect() {m_XMin = this.丌三上业丅丞丗丄丁, m_YMin = V10.16B, m_Width = V9.16B, m_Height = V8.16B}, value:  (this.丗丆丅丄不丝一上丐 == true) ? 1 : 0, text:  "Save Stats To Google Spreadsheet");
        if((UnityEngine.GUI.Button(position:  new UnityEngine.Rect() {m_XMin = this.丝业万东万丁专专七, m_YMin = V10.16B, m_Width = V9.16B, m_Height = V8.16B}, text:  "Reset Balls values")) == false)
        {
                return;
        }
        
        this.dataDestinationObject.SendMessage(methodName:  "ResetBalls");
    }
    private void 丗丑不丙专丂一下丈()
    {
        if(this.丂丟世丛七丗丆不世 != false)
        {
                return;
        }
        
        this.丂丟世丛七丗丆不世 = true;
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丙丘丝七业丟丁与丛());
    }
    private System.Collections.IEnumerator 丙丘丝七业丟丁与丛()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new UnityDataConnector.且丝专丒专丄丘三上();
    }
    public void SaveDataOnTheCloud(string 丌七与万丆丘丞丁一, float 且丐丑丐与丂上万世)
    {
        if(this.丗丆丅丄不丝一上丐 == false)
        {
                return;
        }
        
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.业丙丅丆七万东下丆(丌七与万丆丘丞丁一:  丌七与万丆丘丞丁一, 且丐丑丐与丂上万世:  且丐丑丐与丂上万世));
    }
    private System.Collections.IEnumerator 业丙丅丆七万东下丆(string 丌七与万丆丘丞丁一, float 且丐丑丐与丂上万世)
    {
        UnityDataConnector.丄下世一一丏上下上 val_1 = new UnityDataConnector.丄下世一一丏上下上();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
            .丌七与万丆丘丞丁一 = 丌七与万丆丘丞丁一;
        }
        else
        {
                mem[32] = this;
            mem[40] = 丌七与万丆丘丞丁一;
        }
        
        .且丐丑丐与丂上万世 = 且丐丑丐与丂上万世;
        return (System.Collections.IEnumerator)val_1;
    }
    public UnityDataConnector()
    {
        this.maxWaitTime = 10f;
        this.webServiceUrl = "";
        this.spreadsheetId = "";
        this.worksheetName = "";
        this.password = "";
        this.statisticsWorksheetName = "Statistics";
    }

}
