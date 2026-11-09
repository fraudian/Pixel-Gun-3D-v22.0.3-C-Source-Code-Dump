using UnityEngine;
public class CraftLobbyPlacePoints : MonoBehaviour
{
    // Fields
    private static CraftLobbyPlacePoints <丄且丂丙丒且七丈丆>k__BackingField;
    
    // Properties
    public static CraftLobbyPlacePoints 丄丘七三上丕世丞业 { get; set; }
    
    // Methods
    public static CraftLobbyPlacePoints get_instance()
    {
        return (CraftLobbyPlacePoints)CraftLobbyPlacePoints.<丄且丂丙丒且七丈丆>k__BackingField;
    }
    private static void 丑一上丟丙不东与业(CraftLobbyPlacePoints 丙业与丙丗丝不丈东)
    {
        CraftLobbyPlacePoints.<丄且丂丙丒且七丈丆>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        CraftLobbyPlacePoints.<丄且丂丙丒且七丈丆>k__BackingField = this;
    }
    public CraftLobbyPlacePoints()
    {
    
    }

}
