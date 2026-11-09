using UnityEngine;
public class CraftFortPlacePoints : MonoBehaviour
{
    // Fields
    private static CraftFortPlacePoints <丄且丂丙丒且七丈丆>k__BackingField;
    
    // Properties
    public static CraftFortPlacePoints 丄丘七三上丕世丞业 { get; set; }
    
    // Methods
    public static CraftFortPlacePoints get_instance()
    {
        return (CraftFortPlacePoints)CraftFortPlacePoints.<丄且丂丙丒且七丈丆>k__BackingField;
    }
    private static void 丑一上丟丙不东与业(CraftFortPlacePoints 丙业与丙丗丝不丈东)
    {
        CraftFortPlacePoints.<丄且丂丙丒且七丈丆>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        CraftFortPlacePoints.<丄且丂丙丒且七丈丆>k__BackingField = this;
    }
    private void OnDestroy()
    {
        CraftFortPlacePoints.<丄且丂丙丒且七丈丆>k__BackingField = 0;
    }
    public CraftFortPlacePoints()
    {
    
    }

}
