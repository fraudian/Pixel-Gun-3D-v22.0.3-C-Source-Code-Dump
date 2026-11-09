using UnityEngine;
internal class PhotonHandler : MonoBehaviour
{
    // Fields
    public static PhotonHandler SP;
    public int updateInterval;
    public int updateIntervalOnSerialize;
    private int 丘丞丆三丞三七丏丝;
    private int 七下丄不丂下丙丌丕;
    private static bool 业丁丐上上丆丕丒丂;
    private static System.Diagnostics.Stopwatch 丅丅三丂丟丂专丞丄;
    protected internal static bool 丟丞专丄丒丐丌丗丆;
    protected internal static System.Type 丝业丛丐丛与丌丐与;
    private const string 丁丏一丟丕万丕三丄 = "PUNCloudBestRegion";
    
    // Properties
    internal static CloudRegionCode 不丌丈丒丝丂且与与 { get; set; }
    
    // Methods
    protected void Awake()
    {
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        val_11 = null;
        val_11 = null;
        if(PhotonHandler.丁丏一丟丕万丕三丄 != 0)
        {
                val_12 = null;
            val_12 = null;
            if(PhotonHandler.丁丏一丟丕万丕三丄 != this)
        {
                val_13 = null;
            val_13 = null;
            if(PhotonHandler.丁丏一丟丕万丕三丄.gameObject != 0)
        {
                val_14 = null;
            val_14 = null;
            UnityEngine.Object.DestroyImmediate(obj:  PhotonHandler.丁丏一丟丕万丕三丄.gameObject);
        }
        
        }
        
        }
        
        val_15 = null;
        val_15 = null;
        PhotonHandler.丁丏一丟丕万丕三丄 = this;
        UnityEngine.Object.DontDestroyOnLoad(target:  this.gameObject);
        this.updateInterval = 1000 / 丅丒丗丑丒丙丛不丆.丝万丟丌世三一七丕();
        this.updateIntervalOnSerialize = 1000 / 丅丒丗丑丒丙丛不丆.丑上丞丒丞丁七丌七();
        PhotonHandler.StartFallbackSendAckThread();
    }
    protected void Start()
    {
        var val_2;
        UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_4;
        val_2 = null;
        val_2 = null;
        val_4 = PhotonHandler.<>c.<>9__10_0;
        if(val_4 == null)
        {
                UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode> val_1 = null;
            val_4 = val_1;
            val_1 = new UnityEngine.Events.UnityAction<UnityEngine.SceneManagement.Scene, UnityEngine.SceneManagement.LoadSceneMode>(object:  PhotonHandler.<>c.__il2cppRuntimeField_static_fields, method:  System.Void PhotonHandler.<>c::丙专与东丞一与丒万(UnityEngine.SceneManagement.Scene 丏丈丗世丙万丆丐丅, UnityEngine.SceneManagement.LoadSceneMode 与丆七丗丛下丟东丁));
            PhotonHandler.<>c.<>9__10_0 = val_4;
        }
        
        UnityEngine.SceneManagement.SceneManager.add_sceneLoaded(value:  val_1);
    }
    protected void OnApplicationQuit()
    {
        null = null;
        PhotonHandler.丟丞专丄丒丐丌丗丆 = true;
        PhotonHandler.StopFallbackSendAckThread();
        丅丒丗丑丒丙丛不丆.下与业丒丝丕丙丘丙();
    }
    protected void OnApplicationPause(bool 丁与丟万丄丒丗专丌)
    {
        var val_2;
        var val_3;
        var val_4;
        var val_5;
        var val_6;
        val_2 = static_value_081D9CF0;
        val_2 = static_value_081D9CF0;
        val_3 = null;
        val_3 = null;
        if(PhotonHandler.丅丅三丂丟丂专丞丄 == null)
        {
                System.Diagnostics.Stopwatch val_1 = new System.Diagnostics.Stopwatch();
            val_3 = null;
            val_3 = null;
            PhotonHandler.丅丅三丂丟丂专丞丄 = val_1;
        }
        
        val_3 = null;
        val_1.Reset();
        val_4 = null;
        if(丁与丟万丄丒丗专丌 != false)
        {
                val_5 = null;
            val_1.Start();
            return;
        }
        
        val_6 = null;
        val_1.Stop();
    }
    protected void OnDestroy()
    {
        PhotonHandler.StopFallbackSendAckThread();
    }
    protected void Update()
    {
        var val_12;
        var val_13;
        var val_14;
        var val_17;
        var val_18;
        var val_19;
        val_12 = static_value_081D9CF0;
        val_12 = static_value_081D9CF0;
        if(丅丒丗丑丒丙丛不丆.丒丏丆专丝业丙一丌() == 1)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丒丏丆专丝业丙一丌() == 15)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丒丌且丞丙下三丙下() == true)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.七不丐丐丆丒丛丏万() == false)
        {
                return;
        }
        
        val_13 = null;
        val_13 = null;
        val_14 = 1;
        与丂丏丛丞丞丒丟丄.丄七东丏一丂丕丁万 = 0;
        bool val_6 =  & 丅丒丗丑丒丙丛不丆.七不丐丐丆丒丛丏万();
        val_17 = null;
        val_17 = null;
        与丂丏丛丞丞丒丟丄.丄七东丏一丂丕丁万 = 0;
        float val_7 = UnityEngine.Time.realtimeSinceStartup;
        if(丅丒丗丑丒丙丛不丆.七不丐丐丆丒丛丏万() != false)
        {
                val_7 = val_7 * 1000f;
            if(this.七下丄不丂下丙丌丕 < (int)val_7)
        {
                val_18 = static_value_081D9CF0;
            val_18 = static_value_081D9CF0;
            static_value_081D9CF0 + 184 + 16.丏万万丆世丟丕三丏();
            int val_12 = this.updateIntervalOnSerialize;
            val_12 = val_12 + (int)val_7;
            this.丘丞丆三丞三七丏丝 = 0;
            this.七下丄不丂下丙丌丕 = val_12;
        }
        
        }
        
        float val_9 = UnityEngine.Time.realtimeSinceStartup;
        val_9 = val_9 * 1000f;
        if(this.丘丞丆三丞三七丏丝 >= (int)val_9)
        {
                return;
        }
        
        val_19 = 1;
        bool val_11 =  & 丅丒丗丑丒丙丛不丆.七不丐丐丆丒丛丏万();
        int val_13 = this.updateInterval;
        val_13 = val_13 + (int)val_9;
        this.丘丞丆三丞三七丏丝 = val_13;
    }
    protected void OnJoinedRoom()
    {
        static_value_081D9CF0 = static_value_081D9CF0;
        static_value_081D9CF0 + 184 + 16.丞丄丙丒丁丁丛丟丟();
    }
    protected void OnCreatedRoom()
    {
        static_value_081D9CF0 = static_value_081D9CF0;
        static_value_081D9CF0 + 184 + 16.丒丕丑丁万且丄丞业(丒丘丑丅且丆丘东丂:  东丄且丈丈丒丙丁业.丝丝三丏丈丁丏丘丗(), 一丈丁丗丅丘丑丒丁:  false);
    }
    public static void StartFallbackSendAckThread()
    {
        var val_3 = null;
        if(PhotonHandler.业丁丐上上丆丕丒丂 != false)
        {
                return;
        }
        
        PhotonHandler.业丁丐上上丆丕丒丂 = true;
        byte val_2 = ExitGames.Client.Photon.SupportClass.StartBackgroundCalls(myThread:  new System.Func<System.Boolean>(object:  0, method:  public static System.Boolean PhotonHandler::FallbackSendAckThread()), millisecondsInterval:  100, taskName:  "");
    }
    public static void StopFallbackSendAckThread()
    {
        null = null;
        PhotonHandler.业丁丐上上丆丕丒丂 = false;
    }
    public static bool FallbackSendAckThread()
    {
        System.Diagnostics.Stopwatch val_8;
        var val_9;
        var val_10;
        var val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        val_9 = null;
        val_9 = null;
        if(PhotonHandler.业丁丐上上丆丕丒丂 == false)
        {
                return (bool)PhotonHandler.业丁丐上上丆丕丒丂;
        }
        
        if(丅丒丗丑丒丙丛不丆.丒丌且丞丙下三丙下() == true)
        {
                return (bool)PhotonHandler.业丁丐上上丆丕丒丂;
        }
        
        val_10 = static_value_081D9CF0;
        val_10 = static_value_081D9CF0;
        val_11 = null;
        val_11 = null;
        val_12 = static_value_081D9CF0;
        if(PhotonHandler.丅丅三丂丟丂专丞丄 != null)
        {
                val_12 = static_value_081D9CF0;
            val_13 = null;
            val_13 = null;
            val_14 = 0;
            long val_2 = PhotonHandler.丅丅三丂丟丂专丞丄.ElapsedMilliseconds;
            val_12 = static_value_081D9CF0;
            val_12 = static_value_081D9CF0;
            float val_8 = static_value_081D9CF0 + 184 + 176;
            val_8 = val_8 * 1000f;
            if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() != false)
        {
                丅丒丗丑丒丙丛不丆.下与业丒丝丕丙丘丙();
        }
        
            val_15 = null;
            val_15 = null;
            PhotonHandler.丅丅三丂丟丂专丞丄.Stop();
            val_8 = PhotonHandler.丅丅三丂丟丂专丞丄;
            val_8.Reset();
            return (bool)PhotonHandler.业丁丐上上丆丕丒丂;
        }
        
        if(丅丒丗丑丒丙丛不丆.七不丐丐丆丒丛丏万() != false)
        {
                val_16 = static_value_081D9CF0;
            val_16 = static_value_081D9CF0;
            val_8 = static_value_081D9CF0 + 184 + 16.ConnectionTime;
            val_14 = 0;
            if((val_8 - (static_value_081D9CF0 + 184 + 16.LastSendOutgoingTime)) < 201)
        {
                return (bool)PhotonHandler.业丁丐上上丆丕丒丂;
        }
        
        }
        
        val_17 = static_value_081D9CF0;
        val_17 = static_value_081D9CF0;
        val_8 = mem[static_value_081D9CF0 + 184 + 16];
        val_8 = static_value_081D9CF0 + 184 + 16;
        return (bool)PhotonHandler.业丁丐上上丆丕丒丂;
    }
    internal static CloudRegionCode 丌世东东且世丏丟丕()
    {
        string val_1 = UnityEngine.PlayerPrefs.GetString(key:  "PUNCloudBestRegion", defaultValue:  "");
        if((System.String.IsNullOrEmpty(value:  val_1)) == false)
        {
                return 丟丟且且丙丌下丅丗.与丛丆专东丐一且丅(世丄东且七一丗丟与:  val_1);
        }
        
        return 4;
    }
    internal static void 丂上丞丁丁丘丈三丌(CloudRegionCode 丙业与丙丗丝不丈东)
    {
        if(丙业与丙丗丝不丈东 == 4)
        {
                UnityEngine.PlayerPrefs.DeleteKey(key:  "PUNCloudBestRegion");
            return;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        UnityEngine.PlayerPrefs.SetString(key:  "PUNCloudBestRegion", value:  丙业与丙丗丝不丈东.ToString());
    }
    protected internal static void 丐丈专上东专丙丙一()
    {
        var val_4;
        System.Collections.IEnumerator val_5;
        val_4 = null;
        val_4 = null;
        if(PhotonHandler.丁丏一丟丕万丕三丄 != null)
        {
                val_5 = 丑与且丄七不丈世丒(丛一丌世专业丟丗与:  true);
        }
        else
        {
                val_5 = this.丑与且丄七不丈世丒(丛一丌世专业丟丗与:  true);
        }
        
        UnityEngine.Coroutine val_3 = PhotonHandler.丁丏一丟丕万丕三丄.StartCoroutine(routine:  val_5);
    }
    internal System.Collections.IEnumerator 丑与且丄七不丈世丒(bool 丛一丌世专业丟丗与)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丛一丌世专业丟丗与 = 丛一丌世专业丟丗与;
        return (System.Collections.IEnumerator)new PhotonHandler.且七世世三与七一丏();
    }
    public PhotonHandler()
    {
    
    }
    private static PhotonHandler()
    {
    
    }

}
