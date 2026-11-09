using UnityEngine;
public class UserCharactersLobbyPoints : MonoBehaviour
{
    // Fields
    internal static UserCharactersLobbyPoints 丆丕丝丒不丙且丐丗;
    private System.Collections.Generic.List<UnityEngine.Transform> _points;
    private System.Collections.Generic.List<UnityEngine.GameObject> _shadows;
    
    // Methods
    private void Awake()
    {
        UserCharactersLobbyPoints.丆丕丝丒不丙且丐丗 = this;
    }
    internal UnityEngine.Transform 七丘丅丆三不上七丆(int 丑丅世丐丒丏丐三丅)
    {
        System.Collections.Generic.List<UnityEngine.Transform> val_4 = this._points;
        if(val_4 == null)
        {
                return (UnityEngine.Transform)this._points.Item[丑丅世丐丒丏丐三丅 - 1];
        }
        
        if(val_4.Count >= 丑丅世丐丒丏丐三丅)
        {
                return (UnityEngine.Transform)this._points.Item[丑丅世丐丒丏丐三丅 - 1];
        }
        
        val_4 = 0;
        return (UnityEngine.Transform)this._points.Item[丑丅世丐丒丏丐三丅 - 1];
    }
    internal UnityEngine.GameObject 上上丝不业丕丌丏丈(int 丑丅世丐丒丏丐三丅)
    {
        System.Collections.Generic.List<UnityEngine.GameObject> val_4 = this._shadows;
        if(val_4 == null)
        {
                return (UnityEngine.GameObject)this._shadows.Item[丑丅世丐丒丏丐三丅 - 1];
        }
        
        if(val_4.Count >= 丑丅世丐丒丏丐三丅)
        {
                return (UnityEngine.GameObject)this._shadows.Item[丑丅世丐丒丏丐三丅 - 1];
        }
        
        val_4 = 0;
        return (UnityEngine.GameObject)this._shadows.Item[丑丅世丐丒丏丐三丅 - 1];
    }
    public UserCharactersLobbyPoints()
    {
    
    }

}
