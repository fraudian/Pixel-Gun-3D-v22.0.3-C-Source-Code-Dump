using UnityEngine;
internal sealed class GamepadDisconnectIndicator : PGBehaviour
{
    // Fields
    private UnityEngine.Transform LobbyAndOthersPosition;
    private UnityEngine.Transform FightPosition;
    private UnityEngine.Transform Indicator;
    internal UITexture IndicatorTexture;
    
    // Methods
    internal void 丏丝世丆且一专一丗(bool 丙业与丙丗丝不丈东)
    {
        var val_6;
        var val_7;
        UnityEngine.Transform val_8;
        UnityEngine.Transform val_9;
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_11;
        }
        
        val_7 = null;
        val_7 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_11;
        }
        
        val_8 = this.Indicator;
        val_9 = this.FightPosition;
        if(val_9 != null)
        {
            goto label_14;
        }
        
        goto label_13;
        label_11:
        val_8 = this.Indicator;
        val_9 = this.LobbyAndOthersPosition;
        if(val_9 != null)
        {
            goto label_14;
        }
        
        label_13:
        label_14:
        UnityEngine.Vector3 val_3 = val_9.position;
        val_8.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8.gameObject, 丏业丟一东丂东丘丛:  丙业与丙丗丝不丈东);
    }
    public GamepadDisconnectIndicator()
    {
    
    }

}
