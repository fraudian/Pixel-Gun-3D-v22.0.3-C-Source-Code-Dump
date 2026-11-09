using UnityEngine;

namespace Rilisoft
{
    internal static class 上丗丒丙不丝丞且丂
    {
        // Methods
        internal static string 东且丏丆万与东丙万(GooglePlayGames.BasicApi.SavedGame.ISavedGameMetadata 下上不丄丕丙万丞丌)
        {
            var val_6;
            if(下上不丄丕丙万丞丌 != null)
            {
                    var val_7 = 0;
                val_7 = val_7 + 1;
            }
            else
            {
                    val_6 = "<null>";
                return (string)System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0} ({1:s})", arg0:  下上不丄丕丙万丞丌.Description, arg1:  val_5);
            }
            
            var val_8 = 0;
            val_8 = val_8 + 1;
            System.DateTime val_5 = 下上不丄丕丙万丞丌.LastModifiedTimestamp;
            return (string)System.String.Format(provider:  System.Globalization.CultureInfo.InvariantCulture, format:  "{0} ({1:s})", arg0:  下上不丄丕丙万丞丌.Description, arg1:  val_5);
        }
    
    }

}
