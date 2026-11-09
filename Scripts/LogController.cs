using UnityEngine;
public class LogController : MonoBehaviour
{
    // Fields
    private static LogController <不丁丄七丛不丆丁丕>k__BackingField;
    public static System.Collections.Generic.Dictionary<string, string> colors;
    private static PGCompany.DebugLogWindow 万三且丄丏东丕丟且;
    public static bool Enabled;
    public static bool DuplicateToConsole;
    public static bool WriteToLogFile;
    
    // Properties
    public static LogController 丆丕丝丒不丙且丐丗 { get; set; }
    internal static PGCompany.DebugLogWindow 丆与下丛丅丄三丟万 { get; set; }
    public static bool 丛上丂丛丏下丛且丌 { get; }
    
    // Methods
    public static LogController get_Instance()
    {
        null = null;
        return (LogController)LogController.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(LogController 丙业与丙丗丝不丈东)
    {
        null = null;
        LogController.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static PGCompany.DebugLogWindow 丐三丅丂与且丈丈与()
    {
        var val_8;
        PGCompany.DebugLogWindow val_9;
        var val_10;
        val_8 = null;
        val_8 = null;
        val_9 = LogController.万三且丄丏东丕丟且;
        if(val_9 == 0)
        {
                InfoWindowController val_3 = InfoWindowController.丑七不且上丗丁一世();
            val_10 = null;
            val_9 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  UnityEngine.Resources.Load<UnityEngine.GameObject>(path:  "NguiWindows/DebugWindow/DebugLogWindow"), parent:  val_3.camera.transform.parent).GetComponent<PGCompany.DebugLogWindow>();
            val_10 = null;
            LogController.万三且丄丏东丕丟且 = val_9;
        }
        else
        {
                val_10 = null;
        }
        
        val_10 = null;
        return (PGCompany.DebugLogWindow)LogController.万三且丄丏东丕丟且;
    }
    private static void 丒三业万丂丈丅万世(PGCompany.DebugLogWindow 丙业与丙丗丝不丈东)
    {
        null = null;
        LogController.万三且丄丏东丕丟且 = 丙业与丙丗丝不丈东;
    }
    public static bool get_AnyLogEnabled()
    {
        if(LogController.Enabled == true)
        {
                return true;
        }
        
        null = null;
        if(LogController.DuplicateToConsole != false)
        {
                return true;
        }
        
        var val_1 = (LogController.WriteToLogFile == true) ? 1 : 0;
        return true;
    }
    private void Awake()
    {
        LogController.丒且丒丗丗丟下丗丝(丙业与丙丗丝不丈东:  this);
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
    }
    public void AddMessage(BestHTTP.SocketIO.SocketManager 丝东丗丕丛丞丝且丕, string[] 丛专丛丕一与丅丝丁)
    {
        var val_7;
        System.String[] val_8;
        var val_9;
        string val_10;
        val_7 = null;
        val_7 = null;
        if(LogController.DuplicateToConsole == false)
        {
                return;
        }
        
        string[] val_2 = new string[5];
        val_8 = val_2;
        var val_3 = (丝东丗丕丛丞丝且丕 != 0) ? 1 : 0;
        val_8[0] = "[WebSocket] [";
        if(丝东丗丕丛丞丝且丕 == null)
        {
            goto label_9;
        }
        
        BestHTTP.SocketIO.SocketOptions val_4 = 丝东丗丕丛丞丝且丕.Options;
        if(val_4 == null)
        {
            goto label_9;
        }
        
        val_10 = val_4.DebugName;
        if(丝东丗丕丛丞丝且丕 != null)
        {
                if(val_8 != null)
        {
            goto label_11;
        }
        
        }
        
        val_8 = 0;
        label_11:
        if((val_10 == null) || (val_10 != null))
        {
            goto label_14;
        }
        
        goto label_14;
        label_9:
        val_10 = 0;
        val_9 = 1;
        label_14:
        val_8[val_9] = val_10;
        val_8[2] = "] ";
        val_8[3] = System.String.Join(separator:  "", value:  丛专丛丕一与丅丝丁);
        val_8[4] = "]";
        UnityEngine.Debug.Log(message:  +val_2);
    }
    public static string ColorEvent(string 丝丏业丅丈东业丝丒)
    {
        string val_1 = 丝丏业丅丈东业丝丒;
        if(val_1 != null)
        {
                return (string)val_1;
        }
        
        val_1 = System.String.alignConst;
        return (string)val_1;
    }
    public LogController()
    {
    
    }
    private static LogController()
    {
        System.Collections.Generic.Dictionary<System.String, System.String> val_1 = new System.Collections.Generic.Dictionary<System.String, System.String>();
        if(val_1 != null)
        {
                val_1.Add(key:  "red", value:  "FF0000");
        }
        else
        {
                val_1.Add(key:  "red", value:  "FF0000");
        }
        
        val_1.Add(key:  "yellow", value:  "FFFF00");
        val_1.Add(key:  "cyan", value:  "00FFFF");
        LogController.colors = val_1;
        LogController.Enabled = false;
        LogController.DuplicateToConsole = false;
        LogController.WriteToLogFile = false;
    }

}
