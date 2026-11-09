using UnityEngine;

namespace GooglePlayGames.BasicApi.Nearby
{
    public class DummyNearbyConnectionClient : INearbyConnectionClient
    {
        // Methods
        public int MaxUnreliableMessagePayloadLength()
        {
            return 1168;
        }
        public int MaxReliableMessagePayloadLength()
        {
            return 4096;
        }
        public void SendReliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload)
        {
            UnityEngine.Debug.LogError(message:  "SendReliable called from dummy implementation");
        }
        public void SendUnreliable(System.Collections.Generic.List<string> recipientEndpointIds, byte[] payload)
        {
            UnityEngine.Debug.LogError(message:  "SendUnreliable called from dummy implementation");
        }
        public void StartAdvertising(string name, System.Collections.Generic.List<string> appIdentifiers, System.Nullable<System.TimeSpan> advertisingDuration, System.Action<GooglePlayGames.BasicApi.Nearby.AdvertisingResult> resultCallback, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionRequest> connectionRequestCallback)
        {
            connectionRequestCallback.Invoke(obj:  new GooglePlayGames.BasicApi.Nearby.AdvertisingResult());
        }
        public void StopAdvertising()
        {
            UnityEngine.Debug.LogError(message:  "StopAvertising in dummy implementation called");
        }
        public void SendConnectionRequest(string name, string remoteEndpointId, byte[] payload, System.Action<GooglePlayGames.BasicApi.Nearby.ConnectionResponse> responseCallback, GooglePlayGames.BasicApi.Nearby.IMessageListener listener)
        {
            UnityEngine.Debug.LogError(message:  "SendConnectionRequest called from dummy implementation");
            if(responseCallback == null)
            {
                    return;
            }
            
            GooglePlayGames.BasicApi.Nearby.ConnectionResponse val_1 = GooglePlayGames.BasicApi.Nearby.ConnectionResponse.Rejected(localClientId:  0, remoteEndpointId:  System.String.alignConst);
            responseCallback.Invoke(obj:  new GooglePlayGames.BasicApi.Nearby.ConnectionResponse());
        }
        public void AcceptConnectionRequest(string remoteEndpointId, byte[] payload, GooglePlayGames.BasicApi.Nearby.IMessageListener listener)
        {
            UnityEngine.Debug.LogError(message:  "AcceptConnectionRequest in dummy implementation called");
        }
        public void StartDiscovery(string serviceId, System.Nullable<System.TimeSpan> advertisingTimeout, GooglePlayGames.BasicApi.Nearby.IDiscoveryListener listener)
        {
            UnityEngine.Debug.LogError(message:  "StartDiscovery in dummy implementation called");
        }
        public void StopDiscovery(string serviceId)
        {
            UnityEngine.Debug.LogError(message:  "StopDiscovery in dummy implementation called");
        }
        public void RejectConnectionRequest(string requestingEndpointId)
        {
            UnityEngine.Debug.LogError(message:  "RejectConnectionRequest in dummy implementation called");
        }
        public void DisconnectFromEndpoint(string remoteEndpointId)
        {
            UnityEngine.Debug.LogError(message:  "DisconnectFromEndpoint in dummy implementation called");
        }
        public void StopAllConnections()
        {
            UnityEngine.Debug.LogError(message:  "StopAllConnections in dummy implementation called");
        }
        public string LocalEndpointId()
        {
            return (string)System.String.alignConst;
        }
        public string LocalDeviceId()
        {
            return "DummyDevice";
        }
        public string GetAppBundleId()
        {
            return "dummy.bundle.id";
        }
        public string GetServiceId()
        {
            return "dummy.service.id";
        }
        public DummyNearbyConnectionClient()
        {
        
        }
    
    }

}
