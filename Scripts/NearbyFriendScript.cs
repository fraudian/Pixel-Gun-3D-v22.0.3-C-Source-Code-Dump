using UnityEngine;
internal sealed class NearbyFriendScript : MonoBehaviour
{
    // Fields
    public UIRect nearbyFriendHeader;
    public UIRect nearbyFriendGrid;
    public UIRect otherFriendHeader;
    public UIRect otherFriendGrid;
    
    // Properties
    private bool 世且万三丄丏世下丙 { get; }
    
    // Methods
    private bool 世丈东世七丟丐丌丐()
    {
        return (bool)(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 19) ? 1 : 0;
    }
    private void Start()
    {
        var val_10;
        System.Action<UIRect> val_12;
        var val_13;
        System.Action<UIRect> val_15;
        if(Rilisoft.丄丒丘丈丐与丆下且.东不丑与丏丛丗丈丂() != 19)
        {
                return;
        }
        
        if(this.nearbyFriendGrid != 0)
        {
                if(this.otherFriendGrid != 0)
        {
                this.otherFriendGrid.topAnchor.丅专下万丕丑丆丅丝(丄丂丙丘丄丛上丐丒:  this.nearbyFriendGrid.topAnchor.relative, 业丘丕万七专丑丂一:  (float)this.nearbyFriendGrid.topAnchor.absolute);
        }
        
        }
        
        if(this.nearbyFriendHeader != 0)
        {
                if(this.otherFriendHeader != 0)
        {
                this.otherFriendHeader.topAnchor.丅专下万丕丑丆丅丝(丄丂丙丘丄丛上丐丒:  this.nearbyFriendHeader.topAnchor.relative, 业丘丕万七专丑丂一:  (float)this.nearbyFriendHeader.topAnchor.absolute);
            this.otherFriendHeader.bottomAnchor.丅专下万丕丑丆丅丝(丄丂丙丘丄丛上丐丒:  this.nearbyFriendHeader.bottomAnchor.relative, 业丘丕万七专丑丂一:  (float)this.nearbyFriendHeader.bottomAnchor.absolute);
        }
        
        }
        
        val_10 = null;
        val_10 = null;
        val_12 = NearbyFriendScript.<>c.<>9__2_0;
        if(val_12 == null)
        {
                System.Action<UIRect> val_6 = null;
            val_12 = val_6;
            val_6 = new System.Action<UIRect>(object:  NearbyFriendScript.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NearbyFriendScript.<>c::丗丟丒丈丐万丟上丂(UIRect 一丗世三专三万丞丞));
            NearbyFriendScript.<>c.<>9__2_0 = val_12;
        }
        
        UIRect val_7 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UIRect>(丄三丅七丆丛与与上:  this.nearbyFriendHeader, 七丐丅专且专七三丆:  val_6);
        val_13 = null;
        val_13 = null;
        val_15 = NearbyFriendScript.<>c.<>9__2_1;
        if(val_15 == null)
        {
                System.Action<UIRect> val_8 = null;
            val_15 = val_8;
            val_8 = new System.Action<UIRect>(object:  NearbyFriendScript.<>c.__il2cppRuntimeField_static_fields, method:  System.Void NearbyFriendScript.<>c::丙丅丞一不丟丏下东(UIRect 业七丐世专丝丂丟丈));
            NearbyFriendScript.<>c.<>9__2_1 = val_15;
        }
        
        UIRect val_9 = Rilisoft.NullExtensions.七三与丛三丈丏且专.丝丗丄丏丕丑丌且丑<UIRect>(丄三丅七丆丛与与上:  this.nearbyFriendGrid, 七丐丅专且专七三丆:  val_8);
    }
    public NearbyFriendScript()
    {
    
    }

}
