using UnityEngine;
[Serializable]
internal class SquareFieldCellData
{
    // Fields
    internal UnityEngine.Vector3 Position;
    internal SquareFieldCellSize CellSize;
    internal int Rotation;
    internal int ServerLevel;
    internal string itemSettingsId;
    private PlaceableItemSettings _itemSettings;
    
    // Properties
    internal PlaceableItemSettings ItemSettings { get; }
    
    // Methods
    internal PlaceableItemSettings get_ItemSettings()
    {
        if(this._itemSettings != null)
        {
                return val_1;
        }
        
        PlaceableItemSettings val_1 = 丄丈业一下万且丂丕.丕万上万丒丄丑丛万(丞丅上丏丂且下丅与:  this.itemSettingsId);
        this._itemSettings = val_1;
        return val_1;
    }
    public SquareFieldCellData()
    {
    
    }

}
