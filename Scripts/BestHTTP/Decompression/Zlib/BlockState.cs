using UnityEngine;

namespace BestHTTP.Decompression.Zlib
{
    [Serializable]
    internal enum BlockState
    {
        // Fields
        NeedMore = 0
        ,BlockDone = 1
        ,FinishStarted = 2
        ,FinishDone = 3
        
    
    }

}
