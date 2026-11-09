using UnityEngine;
internal class ChangeColorDungeonWindow : MonoBehaviour
{
    // Fields
    private System.Collections.Generic.List<ChangeColorDungeonWindow.ColorByNameMap> _colorByNameMap;
    private UIWidget _uiObject;
    
    // Methods
    private void OnEnable()
    {
        float val_7;
        string val_8;
        float val_10;
        float val_11;
        float val_12;
        UIWidget val_15;
        var val_16;
        var val_17;
        var val_18;
        val_15 = this;
        if(this._uiObject == 0)
        {
                return;
        }
        
        if(GameConnect.且丞丁东丝丗上丈业() == false)
        {
                return;
        }
        
        val_16 = null;
        val_16 = null;
        if(ConnectScene.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_17 = null;
        val_17 = null;
        if(ConnectSceneSelectMap.__il2cppRuntimeField_events == 0)
        {
                return;
        }
        
        List.Enumerator<T> val_5 = this._colorByNameMap.GetEnumerator();
        label_26:
        if(((-485514560) & 1) == 0)
        {
            goto label_20;
        }
        
        GooglePlayGames.BasicApi.Nearby.EndpointDetails val_9 = val_8.RemoteEndpoint;
        val_18 = null;
        val_18 = null;
        if((System.String.op_Equality(a:  val_8, b:  0x100000002153B000.__il2cppRuntimeField_98)) == false)
        {
            goto label_26;
        }
        
        val_15 = this._uiObject;
        val_15.color = new UnityEngine.Color() {r = val_10, g = val_11, b = val_7, a = val_12};
        label_20:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    public ChangeColorDungeonWindow()
    {
        this._colorByNameMap = new System.Collections.Generic.List<ColorByNameMap>();
    }

}
