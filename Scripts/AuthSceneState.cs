using UnityEngine;
[Serializable]
internal enum AuthSceneState
{
    // Fields
    None = -1
    ,Initial = 0
    ,Authorizing = 1
    ,Authorized = 2
    ,FullySynchronized = 3
    ,Empty = 4
    ,CheckBindedId = 5
    ,ChooseId = 6
    ,ChooseProgress = 7
    ,SendCachedCommands = 8
    ,SynchronizeProgress = 9
    ,CheckAppVersion = 10
    ,Easy = 11
    ,CheckConnection = 12
    ,SendProgress = 13
    ,WaitAsync = 14
    ,TechnicalWorks = 15
    ,Login = 16
    

}
