using UnityEngine;
public class PhotonLagSimulationGui : MonoBehaviour
{
    // Fields
    public UnityEngine.Rect WindowRect;
    public int WindowId;
    public bool Visible;
    private ExitGames.Client.Photon.PhotonPeer <丕丘丂丟丅丐丑丙丐>k__BackingField;
    
    // Properties
    public ExitGames.Client.Photon.PhotonPeer 丗上业丐东丛万东丕 { get; set; }
    
    // Methods
    public ExitGames.Client.Photon.PhotonPeer get_Peer()
    {
        return (ExitGames.Client.Photon.PhotonPeer)this.<丕丘丂丟丅丐丑丙丐>k__BackingField;
    }
    public void set_Peer(ExitGames.Client.Photon.PhotonPeer 丙业与丙丗丝不丈东)
    {
        this.<丕丘丂丟丅丐丑丙丐>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public void Start()
    {
        static_value_081D9CF0 = static_value_081D9CF0;
        this.<丕丘丂丟丅丐丑丙丐>k__BackingField = static_value_081D9CF0 + 184 + 16;
    }
    public void OnGUI()
    {
        IntPtr val_4;
        if(this.Visible == false)
        {
                return;
        }
        
        if((this.<丕丘丂丟丅丐丑丙丐>k__BackingField) != null)
        {
                val_4 = 1152921535545685840;
        }
        else
        {
                val_4 = 1152921535545686864;
        }
        
        new GUI.WindowFunction() = new GUI.WindowFunction(object:  this, method:  val_4);
        UnityEngine.Rect val_3 = UnityEngine.GUILayout.Window(id:  this.WindowId, screenRect:  new UnityEngine.Rect() {m_XMin = this.WindowRect, m_YMin = V9.16B, m_Width = V10.16B, m_Height = V11.16B}, func:  new GUI.WindowFunction(), text:  "Netw. Sim.", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        this.WindowRect = val_3;
        mem[1152921535545748876] = val_3.m_YMin;
        mem[1152921535545748880] = val_3.m_Width;
        mem[1152921535545748884] = val_3.m_Height;
    }
    private void 丏丛丝丏世七业丈与(int 一不丟上丙丌七丆丙)
    {
        UnityEngine.GUILayout.Label(text:  "No peer to communicate with. ", options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
    }
    private void 丙丑丈丙丕丐上丕且(int 一不丟上丙丌七丆丙)
    {
        UnityEngine.GUILayout.Label(text:  System.String.Format(format:  "Rtt:{0,4} +/-{1,3}", arg0:  this.<丕丘丂丟丅丐丑丙丐>k__BackingField.RoundTripTime, arg1:  this.<丕丘丂丟丅丐丑丙丐>k__BackingField.RoundTripTimeVariance), options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        string val_34 = "Simulate";
        bool val_7 = UnityEngine.GUILayout.Toggle(value:  (this.<丕丘丂丟丅丐丑丙丐>k__BackingField) & 1, text:  val_34, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        if((((this.<丕丘丂丟丅丐丑丙丐>k__BackingField) ^ val_7) & 1) != 0)
        {
                val_34 = val_7;
        }
        
        UnityEngine.GUILayout.Label(text:  "Lag " + (float)this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.IncomingLag((float)this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.IncomingLag), options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.IncomingLag = (int)UnityEngine.GUILayout.HorizontalSlider(value:  (float)this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.IncomingLag, leftValue:  0f, rightValue:  500f, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.OutgoingLag = (int)UnityEngine.GUILayout.HorizontalSlider(value:  (float)this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.IncomingLag, leftValue:  0f, rightValue:  500f, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Label(text:  "Jit " + (float)this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.IncomingJitter((float)this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.IncomingJitter), options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.IncomingJitter = (int)UnityEngine.GUILayout.HorizontalSlider(value:  (float)this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.IncomingJitter, leftValue:  0f, rightValue:  100f, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.OutgoingJitter = (int)UnityEngine.GUILayout.HorizontalSlider(value:  (float)this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.IncomingJitter, leftValue:  0f, rightValue:  100f, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Label(text:  "Loss " + (float)this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.IncomingLossPercentage((float)this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.IncomingLossPercentage), options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.IncomingLossPercentage = (int)UnityEngine.GUILayout.HorizontalSlider(value:  (float)this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.IncomingLossPercentage, leftValue:  0f, rightValue:  10f, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.OutgoingLossPercentage = (int)UnityEngine.GUILayout.HorizontalSlider(value:  (float)this.<丕丘丂丟丅丐丑丙丐>k__BackingField.NetworkSimulationSettings.IncomingLossPercentage, leftValue:  0f, rightValue:  10f, options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        bool val_33 = UnityEngine.GUI.changed;
        UnityEngine.GUI.DragWindow();
    }
    public PhotonLagSimulationGui()
    {
        this.WindowRect = 0;
        mem[1152921535547048012] = 0;
        mem[1152921535547048020] = 0;
        this.WindowId = 101;
        this.Visible = true;
    }

}
