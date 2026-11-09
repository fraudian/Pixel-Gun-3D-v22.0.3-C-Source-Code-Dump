using UnityEngine;
public class OnAwakeUsePhotonView : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Methods
    private void Awake()
    {
        bool val_2 = this.photonView.isMine;
    }
    private void Start()
    {
        bool val_2 = this.photonView.isMine;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        return false;
    }
    internal void OnAwakeRPC()
    {
        UnityEngine.Debug.Log(message:  "RPC: \'OnAwakeRPC\' PhotonView: "("RPC: \'OnAwakeRPC\' PhotonView: ") + this.photonView);
    }
    internal void OnAwakeRPC(byte 丗丐且丆丂下三丏与)
    {
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "RPC: \'OnAwakeRPC\' Parameter: {0} PhotonView: {1}", arg0:  丗丐且丆丂下三丏与, arg1:  this.photonView));
    }
    public OnAwakeUsePhotonView()
    {
    
    }

}
