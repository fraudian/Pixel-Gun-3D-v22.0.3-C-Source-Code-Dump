using UnityEngine;
public class InRoomTime : MonoBehaviour
{
    // Fields
    private int 下世一丗业与一丏丗;
    private const string 且且丌丐下丈丛丕七 = "#rt";
    
    // Properties
    public double 丑丞丛丑七丙丗丌丁 { get; }
    public int 丆丟丝丌丏丄丝丌丛 { get; }
    public bool 丈丂丌丄丕丆丒万丈 { get; }
    
    // Methods
    public double get_RoomTime()
    {
        double val_2 = 1000;
        val_2 = (double)this.RoomTimestamp / val_2;
        return (double)val_2;
    }
    public int get_RoomTimestamp()
    {
        var val_3;
        if(丅丒丗丑丒丙丛不丆.一上下丆世丛丌丆丞() != false)
        {
                val_3 = 丅丒丗丑丒丙丛不丆.一丛丘专七丄丗丝丕() - this.下世一丗业与一丏丗;
            return (int)val_3;
        }
        
        val_3 = 0;
        return (int)val_3;
    }
    public bool get_IsRoomTimeSet()
    {
        if(丅丒丗丑丒丙丛不丆.一上下丆世丛丌丆丞() == false)
        {
                return false;
        }
        
        ExitGames.Client.Photon.Hashtable val_3 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丂丂丁丕专丂丏与丌();
        if(val_3 != null)
        {
                return val_3.ContainsKey(key:  "#rt");
        }
        
        return val_3.ContainsKey(key:  "#rt");
    }
    internal System.Collections.IEnumerator SetRoomStartTimestamp()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new InRoomTime.东世丈三丗丆丂七丛();
    }
    public void OnJoinedRoom()
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "SetRoomStartTimestamp");
    }
    public void OnMasterClientSwitched(与丅丕丈丘东丝世丟 丛丑东丝丌丒一丘丒)
    {
        UnityEngine.Coroutine val_1 = this.StartCoroutine(methodName:  "SetRoomStartTimestamp");
    }
    public void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不)
    {
        if((业上上东丑东丞丗不.ContainsKey(key:  "#rt")) == false)
        {
                return;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  业上上东丑东丞丗不.Item["#rt"]);
        this.下世一丗业与一丏丗 = null;
    }
    public InRoomTime()
    {
    
    }

}
