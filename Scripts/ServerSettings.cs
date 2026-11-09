using UnityEngine;
[Serializable]
public class ServerSettings : ScriptableObject
{
    // Fields
    public string AppID;
    public string VoiceAppID;
    public string ChatAppID;
    public ServerSettings.丁不东丄丞丝一与东 HostType;
    public CloudRegionCode PreferredRegion;
    public CloudRegionFlag EnabledRegions;
    public ExitGames.Client.Photon.ConnectionProtocol Protocol;
    public string ServerAddress;
    public int ServerPort;
    public int VoiceServerPort;
    public bool JoinLobby;
    public bool EnableLobbyStatistics;
    public PhotonLogLevel PunLogging;
    public ExitGames.Client.Photon.DebugLevel NetworkLogging;
    public bool RunInBackground;
    public System.Collections.Generic.List<string> RpcList;
    public bool DisableAutoOpenWizard;
    
    // Properties
    public static CloudRegionCode BestRegionCodeInPreferences { get; }
    
    // Methods
    public void 三丐不丈丆丑丘丑丈(string 丘丈七丑不七丗丈丄)
    {
        this.HostType = 4;
        this.AppID = 丘丈七丑不七丗丈丄;
    }
    public void 专丟丟丙丘一一丁丗(string 丘丈七丑不七丗丈丄)
    {
        this.HostType = 1;
        this.AppID = 丘丈七丑不七丗丈丄;
    }
    public void 专丟丟丙丘一一丁丗(string 丘丈七丑不七丗丈丄, CloudRegionCode 专丏不丏东丏丈丆上)
    {
        this.AppID = 丘丈七丑不七丗丈丄;
        this.HostType = 1;
        this.PreferredRegion = 专丏不丏东丏丈丆上;
    }
    public void 下丕丝丈丞七丙东丒(string 丑丂丏丌丐丑丆不七, int 丑与丄丑丄丂丝且丄, string 丐七丄丞世万万丄丌)
    {
        this.HostType = 2;
        this.AppID = (丐七丄丞世万万丄丌 == null) ? "master" : 丐七丄丞世万万丄丌;
        this.ServerAddress = 丑丂丏丌丐丑丆不七;
        this.ServerPort = 丑与丄丑丄丂丝且丄;
    }
    public static bool 丘丁且丞下万上丐丂(string 下下丏一丙不丘丌丞)
    {
        return true;
    }
    public static CloudRegionCode get_BestRegionCodeInPreferences()
    {
        return PhotonHandler.丌世东东且世丏丟丕();
    }
    public static void 且丙丏丄丛丏上丞丈()
    {
        PhotonHandler.丂上丞丁丁丘丈三丌(丙业与丙丗丝不丈东:  4);
    }
    public override string ToString()
    {
        return (string)System.String.Format(format:  "ServerSettings: {0} {1}", arg0:  this.HostType, arg1:  this.ServerAddress);
    }
    public ServerSettings()
    {
        this.EnabledRegions = 0;
        this.ServerPort = 5055;
        this.VoiceServerPort = 5055;
        this.NetworkLogging = 257;
        this.AppID = "";
        this.VoiceAppID = "";
        this.ChatAppID = "";
        this.ServerAddress = "";
        this.RpcList = new System.Collections.Generic.List<System.String>();
    }

}
