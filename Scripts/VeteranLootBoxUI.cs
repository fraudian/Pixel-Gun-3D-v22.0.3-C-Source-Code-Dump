using UnityEngine;
internal class VeteranLootBoxUI : LootBoxUI
{
    // Fields
    private static VeteranLootBoxUI 丁与万丐丐东业三丄;
    private System.Collections.Generic.List<UnityEngine.Camera> _3dCameras;
    
    // Properties
    internal static bool 丕世丁丈丞丙上专丄 { get; }
    
    // Methods
    internal static bool 丕三三丐一一丟丘丂()
    {
        return UnityEngine.Object.op_Inequality(x:  VeteranLootBoxUI.丁与万丐丐东业三丄, y:  0);
    }
    protected override void OnEnable()
    {
        VeteranLootBoxUI.丁与万丐丐东业三丄 = this;
    }
    protected override void OnDisable()
    {
        VeteranLootBoxUI.丁与万丐丐东业三丄 = 0;
    }
    internal void 万丛丆与业丐丁丕丟()
    {
        List.Enumerator<T> val_1 = this._3dCameras.GetEnumerator();
        label_7:
        if(((-1219703912) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_2 = 0.丐丏七丌丕丗业且上();
        if(val_2 == 0)
        {
            goto label_7;
        }
        
        val_2.depth = 3f;
        goto label_7;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        int val_6 = UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket");
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.gameObject, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "UI"), 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
    }
    public VeteranLootBoxUI()
    {
    
    }

}
