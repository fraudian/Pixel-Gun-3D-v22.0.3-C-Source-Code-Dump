using UnityEngine;
public interface 世丌丝业丈七丑丂丆
{
    // Methods
    public abstract void OnConnectedToPhoton(); // 0
    public abstract void OnLeftRoom(); // 0
    public abstract void OnMasterClientSwitched(与丅丕丈丘东丝世丟 丛丑东丝丌丒一丘丒); // 0
    public abstract void OnPhotonCreateRoomFailed(object[] 丑东万丁丛丐丗万东); // 0
    public abstract void OnPhotonJoinRoomFailed(object[] 丑东万丁丛丐丗万东); // 0
    public abstract void OnCreatedRoom(); // 0
    public abstract void OnJoinedLobby(); // 0
    public abstract void OnLeftLobby(); // 0
    public abstract void OnFailedToConnectToPhoton(DisconnectCause 世丁丙世丄一万丆三); // 0
    public abstract void OnConnectionFail(DisconnectCause 世丁丙世丄一万丆三); // 0
    public abstract void OnDisconnectedFromPhoton(); // 0
    public abstract void OnPhotonInstantiate(业丘丘丘丁丂丕万东 东一丁世丑丞业丄丐); // 0
    public abstract void OnReceivedRoomListUpdate(); // 0
    public abstract void OnJoinedRoom(); // 0
    public abstract void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 丐万丙下丙丘专丈与); // 0
    public abstract void OnPhotonPlayerDisconnected(与丅丕丈丘东丝世丟 丞七东丕丗业七丒三); // 0
    public abstract void OnPhotonRandomJoinFailed(object[] 丑东万丁丛丐丗万东); // 0
    public abstract void OnConnectedToMaster(); // 0
    public abstract void OnPhotonMaxCccuReached(); // 0
    public abstract void OnPhotonCustomRoomPropertiesChanged(ExitGames.Client.Photon.Hashtable 业上上东丑东丞丗不); // 0
    public abstract void OnPhotonPlayerPropertiesChanged(object[] 丏丗丐世丕丕丙丝丄); // 0
    public abstract void OnUpdatedFriendList(); // 0
    public abstract void OnCustomAuthenticationFailed(string 丐丞丆三丁丅丝七不); // 0
    public abstract void OnCustomAuthenticationResponse(System.Collections.Generic.Dictionary<string, object> 一丐丗丁丞丆丅丟丄); // 0
    public abstract void OnWebRpcResponse(ExitGames.Client.Photon.OperationResponse 丑与丂丌世丕丆一丗); // 0
    public abstract void OnOwnershipRequest(object[] 丗丕丁丕丐七丁丅丄); // 0
    public abstract void OnLobbyStatisticsUpdate(); // 0
    public abstract void OnPhotonPlayerActivityChanged(与丅丕丈丘东丝世丟 丞七东丕丗业七丒三); // 0
    public abstract void OnOwnershipTransfered(object[] 丈三丞丐丅三丟上丝); // 0

}
