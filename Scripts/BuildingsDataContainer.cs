using UnityEngine;
[Serializable]
internal class 一七上丂丞万与一丅.BuildingsDataContainer
{
    // Fields
    internal System.Collections.Generic.List<PlaceableItemProperties> PlaceableItems;
    internal System.Collections.Generic.List<PGCompany.一七上丂丞万与一丅.RootBuildingLevelData> Fort;
    internal System.Collections.Generic.List<PGCompany.一七上丂丞万与一丅.RootBuildingLevelData> Tank;
    internal PGCompany.一七上丂丞万与一丅.CommonData CommonData;
    internal PGCompany.一七上丂丞万与一丅.丌丆三上丏丁丞丌丙 CustomProperties;
    
    // Methods
    public 一七上丂丞万与一丅.BuildingsDataContainer()
    {
        this.CommonData = new 一七上丂丞万与一丅.CommonData();
    }

}
