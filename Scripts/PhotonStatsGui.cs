using UnityEngine;
public class PhotonStatsGui : MonoBehaviour
{
    // Fields
    public bool statsWindowOn;
    public bool statsOn;
    public bool healthStatsVisible;
    public bool trafficStatsOn;
    public bool buttonsOn;
    public UnityEngine.Rect statsRect;
    public int WindowId;
    
    // Methods
    public void Start()
    {
        float val_1 = this.statsRect.x;
        if(val_1 > 0f)
        {
                return;
        }
        
        val_1 = (float)UnityEngine.Screen.width - val_1;
        this.statsRect.x = val_1;
    }
    public void Update()
    {
        if((UnityEngine.Input.GetKeyDown(key:  9)) == false)
        {
                return;
        }
        
        if((UnityEngine.Input.GetKey(key:  48)) == false)
        {
                return;
        }
        
        bool val_3 = this.statsWindowOn;
        this.statsOn = true;
        val_3 = val_3 ^ 1;
        this.statsWindowOn = val_3;
    }
    public void OnGUI()
    {
        WindowFunction val_7;
        var val_8;
        bool val_9;
        var val_10;
        val_7 = 1152921505107111936;
        val_8 = static_value_081D9CF0;
        val_8 = static_value_081D9CF0;
        val_9 = this.statsOn;
        var val_2 = (val_9 == true) ? 1 : 0;
        val_2 = (static_value_081D9CF0 + 184 + 16.TrafficStatsEnabled) ^ val_2;
        if(val_2 != false)
        {
                val_10 = static_value_081D9CF0;
            val_10 = static_value_081D9CF0;
            val_9 = this.statsOn;
            static_value_081D9CF0 + 184 + 16.TrafficStatsEnabled = (val_9 == true) ? 1 : 0;
        }
        
        if(this.statsWindowOn == false)
        {
                return;
        }
        
        GUI.WindowFunction val_4 = null;
        val_7 = val_4;
        val_4 = new GUI.WindowFunction(object:  this, method:  public System.Void PhotonStatsGui::TrafficStatsWindow(int 丙上丏丞丅丅丝丆业));
        UnityEngine.Rect val_6 = UnityEngine.GUILayout.Window(id:  this.WindowId, screenRect:  new UnityEngine.Rect() {m_XMin = this.statsRect, m_YMin = V9.16B, m_Width = V10.16B, m_Height = V11.16B}, func:  val_4, text:  "Messages (shift+tab)", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        this.statsRect = val_6;
        mem[1152921535573836068] = val_6.m_YMin;
        mem[1152921535573836072] = val_6.m_Width;
        mem[1152921535573836076] = val_6.m_Height;
    }
    public void TrafficStatsWindow(int 丙上丏丞丅丅丝丆业)
    {
        var val_58;
        object val_59;
        string val_60;
        var val_61;
        var val_62;
        var val_63;
        string val_64;
        string val_65;
        int val_66;
        var val_67;
        val_58 = static_value_081D9CF0;
        val_58 = static_value_081D9CF0;
        val_59 = static_value_081D9CF0 + 184 + 16.TrafficStatsGameLevel;
        object val_4 = (((static_value_081D9CF0 + 184 + 16.TrafficStatsElapsedMs) + 999) > 1998) ? 18446744073709551 : (0 + 1);
        UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        this.buttonsOn = UnityEngine.GUILayout.Toggle(value:  this.buttonsOn, text:  "buttons", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        this.healthStatsVisible = UnityEngine.GUILayout.Toggle(value:  this.healthStatsVisible, text:  "health", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        this.trafficStatsOn = UnityEngine.GUILayout.Toggle(value:  this.trafficStatsOn, text:  "traffic", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.EndHorizontal();
        string val_18 = System.String.Format(format:  "Out {0,4} | In {1,4} | Sum {2,4}", arg0:  val_59.TotalOutgoingMessageCount, arg1:  val_59.TotalIncomingMessageCount, arg2:  val_59.TotalMessageCount);
        string val_19 = System.String.Format(format:  "{0}sec average:", arg0:  val_4);
        object val_58 = (long)val_59.TotalOutgoingMessageCount;
        val_58 = val_58 / val_4;
        object val_59 = (long)val_59.TotalIncomingMessageCount;
        val_59 = val_59 / val_4;
        object val_60 = (long)val_59.TotalMessageCount;
        val_60 = val_60 / val_4;
        string val_23 = System.String.Format(format:  "Out {0,4} | In {1,4} | Sum {2,4}", arg0:  val_58, arg1:  val_59, arg2:  val_60);
        UnityEngine.GUILayout.Label(text:  val_18, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        val_60 = val_19;
        UnityEngine.GUILayout.Label(text:  val_60, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Label(text:  val_23, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        if(this.buttonsOn != false)
        {
                UnityEngine.GUILayout.BeginHorizontal(options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            this.statsOn = UnityEngine.GUILayout.Toggle(value:  this.statsOn, text:  "stats on", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            if((UnityEngine.GUILayout.Button(text:  "Reset", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
        {
                val_61 = static_value_081D9CF0;
            val_61 = static_value_081D9CF0;
            static_value_081D9CF0 + 184 + 16.TrafficStatsReset();
            static_value_081D9CF0 + 184 + 16.TrafficStatsEnabled = true;
        }
        
            val_62 = UnityEngine.GUILayout.Button(text:  "To Log", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.EndHorizontal();
        }
        else
        {
                val_62 = 0;
        }
        
        if(this.trafficStatsOn != false)
        {
                UnityEngine.GUILayout.Box(text:  "Traffic Stats", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            val_63 = static_value_081D9CF0;
            val_63 = static_value_081D9CF0;
            val_64 = "Incoming: \n"("Incoming: \n") + static_value_081D9CF0 + 184 + 16.TrafficStatsIncoming(static_value_081D9CF0 + 184 + 16.TrafficStatsIncoming);
            val_65 = "Outgoing: \n"("Outgoing: \n") + static_value_081D9CF0 + 184 + 16.TrafficStatsOutgoing(static_value_081D9CF0 + 184 + 16.TrafficStatsOutgoing);
            UnityEngine.GUILayout.Label(text:  val_64, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            UnityEngine.GUILayout.Label(text:  val_65, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            val_66 = System.String.alignConst;
        }
        else
        {
                val_66 = System.String.alignConst;
            val_65 = val_66;
            val_64 = val_66;
        }
        
        if(this.healthStatsVisible != false)
        {
                UnityEngine.GUILayout.Box(text:  "Health Stats", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
            object[] val_43 = new object[9];
            val_43[0] = val_59.LongestDeltaBetweenSending;
            val_43[1] = val_59.LongestDeltaBetweenDispatching;
            val_43[2] = val_59.LongestEventCallback;
            val_43[3] = val_59.LongestEventCallbackCode;
            val_43[4] = val_59.LongestOpResponseCallback;
            val_43[5] = val_59.LongestOpResponseCallbackOpCode;
            val_67 = static_value_081D9CF0;
            val_67 = static_value_081D9CF0;
            val_43[6] = static_value_081D9CF0 + 184 + 16.RoundTripTime;
            val_43[7] = static_value_081D9CF0 + 184 + 16.RoundTripTimeVariance;
            val_60 = val_19;
            val_59 = static_value_081D9CF0 + 184 + 16.ResentReliableCommands;
            val_43[8] = val_59;
            val_66 = System.String.Format(format:  "ping: {6}[+/-{7}]ms resent:{8} \n\nmax ms between\nsend: {0,4} \ndispatch: {1,4} \n\nlongest dispatch for: \nev({3}):{2,3}ms \nop({5}):{4,3}ms", args:  val_43);
            UnityEngine.GUILayout.Label(text:  val_66, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        }
        
        if((val_62 & 1) != 0)
        {
                object[] val_55 = new object[6];
            val_59 = val_55;
            val_59[0] = val_18;
            val_59[1] = val_60;
            val_59[2] = val_23;
            val_59[3] = val_64;
            val_59[4] = val_65;
            val_59[5] = val_66;
            UnityEngine.Debug.Log(message:  System.String.Format(format:  "{0}\n{1}\n{2}\n{3}\n{4}\n{5}", args:  val_55));
        }
        
        bool val_57 = UnityEngine.GUI.changed;
        UnityEngine.GUI.DragWindow();
    }
    public PhotonStatsGui()
    {
        this.statsWindowOn = true;
        this.statsOn = true;
        this.statsRect = 0;
        mem[1152921535575511796] = 0;
        mem[1152921535575511804] = 0;
        this.WindowId = 100;
    }

}
