using UnityEngine;
[Serializable]
public enum AuthorizationStates
{
    // Fields
    None = 0
    ,Authorized = 1
    ,Unauthorized = 2
    ,AuthorizingWithHttp = 3
    ,AuthorizingWithSessionKey = 4
    ,AuthorizationForbidden = 5
    ,WaitSocketAuthReponse = 6
    ,AuthorizationRevoked = 7
    ,Paused = 8
    ,QuietAuth = 9
    ,WaitQuietAuthResponse = 10
    

}
