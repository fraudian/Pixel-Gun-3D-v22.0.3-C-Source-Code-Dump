using UnityEngine;

namespace GooglePlayGames.BasicApi
{
    public class CommonTypesUtil
    {
        // Methods
        public static bool StatusIsSuccess(GooglePlayGames.BasicApi.ResponseStatus status)
        {
            return (bool)(status > 0) ? 1 : 0;
        }
        public CommonTypesUtil()
        {
        
        }
    
    }

}
