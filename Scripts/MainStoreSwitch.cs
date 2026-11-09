using UnityEngine;
internal sealed class MainStoreSwitch : PGBehaviour
{
    // Fields
    internal System.Collections.Generic.List<UnityEngine.GameObject> ifEnabled;
    internal System.Collections.Generic.List<UnityEngine.GameObject> ifDisabled;
    
    // Methods
    private void OnEnable()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.ifEnabled, 丏业丟一东丂东丘丛:  PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏());
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.ifDisabled, 丏业丟一东丂东丘丛:  (~PGCompany.MainStore.万丝丞东丘丒丌七专.丑七不且上丗丁一世().丌丄一丒且下丅丁丏()) & 1);
    }
    public MainStoreSwitch()
    {
    
    }

}
