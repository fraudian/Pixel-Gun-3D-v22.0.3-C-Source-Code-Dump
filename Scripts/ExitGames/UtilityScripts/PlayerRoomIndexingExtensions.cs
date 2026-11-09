using UnityEngine;

namespace ExitGames.UtilityScripts
{
    public static class PlayerRoomIndexingExtensions
    {
        // Methods
        public static int GetRoomIndex(与丅丕丈丘东丝世丟 player)
        {
            if(ExitGames.UtilityScripts.PlayerRoomIndexing.RoomPlayerIndexedProp == 0)
            {
                    UnityEngine.Debug.LogError(message:  "Missing PlayerRoomIndexing Component in Scene");
                return 0;
            }
            
            if(ExitGames.UtilityScripts.PlayerRoomIndexing.RoomPlayerIndexedProp != null)
            {
                    return ExitGames.UtilityScripts.PlayerRoomIndexing.RoomPlayerIndexedProp.GetRoomIndex(player:  player);
            }
            
            return ExitGames.UtilityScripts.PlayerRoomIndexing.RoomPlayerIndexedProp.GetRoomIndex(player:  player);
        }
    
    }

}
