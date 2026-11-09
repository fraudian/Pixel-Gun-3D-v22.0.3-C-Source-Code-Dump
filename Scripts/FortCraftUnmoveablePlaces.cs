using UnityEngine;
[Serializable]
internal class FortFieldUnmoveableManager.FortCraftUnmoveablePlaces
{
    // Fields
    internal string subcategroyName;
    internal System.Collections.Generic.List<UnityEngine.Transform> places;
    internal System.Collections.Generic.List<UnityEngine.GameObject> objectsOnPlaces;
    
    // Methods
    private int 万丛丂东且丆丒丗丞()
    {
        var val_6;
        UnityEngine.Object val_7;
        if(this.objectsOnPlaces.Item[0] == 0)
        {
                return 0;
        }
        
        val_6 = 0;
        goto label_5;
        label_11:
        val_7 = this.objectsOnPlaces.Item[0];
        if(val_7 == 0)
        {
                return 0;
        }
        
        val_6 = 1;
        label_5:
        val_7 = this.objectsOnPlaces;
        if(val_6 < val_7.Count)
        {
            goto label_11;
        }
        
        return 0;
    }
    internal void 丟上丟丈七万丒丝丒(UnityEngine.GameObject 丂下丄丝丆丅丗丆丏)
    {
        int val_1 = this.万丛丂东且丆丒丗丞();
        if(this.objectsOnPlaces.Item[val_1] != 0)
        {
                UnityEngine.Object.DestroyImmediate(obj:  this.objectsOnPlaces.Item[val_1]);
        }
        
        this.objectsOnPlaces.set_Item(index:  val_1, value:  丂下丄丝丆丅丗丆丏);
        UnityEngine.Vector3 val_7 = this.places.Item[val_1].position;
        丂下丄丝丆丅丗丆丏.transform.position = new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z};
    }
    public FortFieldUnmoveableManager.FortCraftUnmoveablePlaces()
    {
        this.objectsOnPlaces = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
