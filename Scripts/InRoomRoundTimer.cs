using UnityEngine;
public class InRoomRoundTimer : MonoBehaviour
{
    // Fields
    public int SecondsPerTurn;
    public double StartTime;
    public UnityEngine.Rect TextPos;
    private bool 丛丘七丆丟丕丛世丞;
    private const string 且且丌丐下丈丛丕七 = "st";
    
    // Methods
    private void 七丝丄丒东下世丆万()
    {
        if(丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() < 0)
        {
                this.丛丘七丆丟丕丛世丞 = true;
            return;
        }
        
        this.丛丘七丆丟丕丛世丞 = false;
        ExitGames.Client.Photon.Hashtable val_2 = null;
        this = val_2;
        val_2 = new ExitGames.Client.Photon.Hashtable();
        val_2.set_Item(key:  "st", value:  丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄());
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丆专东一不丙丗丘(下丌丂丗丒下与丞丈:  val_2, 丒不一专上专丌丈东:  0, 丅丞丏丈且专丆不丟:  false);
    }
    public void OnJoinedRoom()
    {
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() != false)
        {
                this.七丝丄丒东下世丆万();
            return;
        }
        
        this = "StartTime already set: "("StartTime already set: ") + 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().ContainsKey(key:  "st").ToString()(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().ContainsKey(key:  "st").ToString());
        UnityEngine.Debug.Log(message:  this);
    }
    public void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)
    {
        if((业上上东丑东丞丗不.ContainsKey(key:  "st")) == false)
        {
                return;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  业上上东丑东丞丗不.Item["st"]);
        this.StartTime = null;
    }
    public void OnMasterClientSwitched(与丅丕丈丘东丝世丟 丛丑东丝丌丒一丘丒)
    {
        if((丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌().ContainsKey(key:  "st")) != false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "The new master starts a new round, cause we didn\'t start yet.");
        this.七丝丄丒东下世丆万();
    }
    private void Update()
    {
        if(this.丛丘七丆丟丕丛世丞 == false)
        {
                return;
        }
        
        this.七丝丄丒东下世丆万();
    }
    public void OnGUI()
    {
        double val_2 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() - this.StartTime;
        double val_11 = (double)this.SecondsPerTurn;
        val_11 = val_11 - val_2;
        double val_12 = (double)this.SecondsPerTurn;
        val_12 = val_2 / val_12;
        UnityEngine.GUILayout.BeginArea(screenRect:  new UnityEngine.Rect() {m_XMin = this.TextPos, m_YMin = val_11});
        UnityEngine.GUILayout.Label(text:  System.String.Format(format:  "elapsed: {0:0.000}", arg0:  val_2), options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Label(text:  System.String.Format(format:  "remaining: {0:0.000}", arg0:  val_11), options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        UnityEngine.GUILayout.Label(text:  System.String.Format(format:  "turn: {0:0}", arg0:  (int)val_12), options:  System.Array.Empty<UnityEngine.GUILayoutOption>());
        if((UnityEngine.GUILayout.Button(text:  "new round", options:  System.Array.Empty<UnityEngine.GUILayoutOption>())) != false)
        {
                this.七丝丄丒东下世丆万();
        }
        
        UnityEngine.GUILayout.EndArea();
    }
    public InRoomRoundTimer()
    {
        this.SecondsPerTurn = 5;
        this.TextPos = 0;
        mem[1152921535614197500] = 0;
        mem[1152921535614197508] = 0;
    }

}
