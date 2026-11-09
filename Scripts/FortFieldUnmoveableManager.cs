using UnityEngine;
internal sealed class FortFieldUnmoveableManager : PGBehaviour
{
    // Fields
    internal static FortFieldUnmoveableManager 丄丘七三上丕世丞业;
    private System.Collections.Generic.List<FortFieldUnmoveableManager.FortCraftUnmoveablePlaces> unmoveablePlaces;
    
    // Methods
    private void Awake()
    {
        var val_5;
        var val_6;
        val_5 = 0;
        FortFieldUnmoveableManager.丄丘七三上丕世丞业 = this;
        goto label_1;
        label_11:
        val_6 = 0;
        goto label_2;
        label_9:
        FortCraftUnmoveablePlaces val_1 = this.unmoveablePlaces.Item[0];
        val_1.objectsOnPlaces.Add(item:  0);
        val_6 = 1;
        label_2:
        FortCraftUnmoveablePlaces val_2 = this.unmoveablePlaces.Item[0];
        if(val_6 < val_2.places.Count)
        {
            goto label_9;
        }
        
        val_5 = 1;
        label_1:
        if(val_5 < this.unmoveablePlaces.Count)
        {
            goto label_11;
        }
    
    }
    internal void 丑丛丞丑上丒丂三三(string 七丐丌上上万丘三丆, UnityEngine.GameObject 丂下丄丝丆丅丗丆丏)
    {
        object val_6;
        FortFieldUnmoveableManager.世丞丒丅一专丌丐丏 val_1 = null;
        val_6 = val_1;
        val_1 = new FortFieldUnmoveableManager.世丞丒丅一专丌丐丏();
        .七丐丌上上万丘三丆 = 七丐丌上上万丘三丆;
        int val_3 = this.unmoveablePlaces.FindIndex(match:  new System.Predicate<FortCraftUnmoveablePlaces>(object:  val_1, method:  System.Boolean FortFieldUnmoveableManager.世丞丒丅一专丌丐丏::丞丙丗丁一丘丏一丏(FortFieldUnmoveableManager.FortCraftUnmoveablePlaces 三丟东丕丄丄下下丑)));
        if(val_3 == 1)
        {
                val_6 = "there isnot " + (FortFieldUnmoveableManager.世丞丒丅一专丌丐丏)[1152921536731042368].七丐丌上上万丘三丆;
            UnityEngine.Debug.Log(message:  val_6);
        }
        
        this.unmoveablePlaces.Item[val_3].丟上丟丈七万丒丝丒(丂下丄丝丆丅丗丆丏:  丂下丄丝丆丅丗丆丏);
    }
    public FortFieldUnmoveableManager()
    {
    
    }

}
