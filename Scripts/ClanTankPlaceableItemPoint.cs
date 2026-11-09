using UnityEngine;
public class ClanTankPlaceableItemPoint : PGBehaviour
{
    // Fields
    public ClanTankBuildBase tankBuildBase;
    public PlaceableItemSettings.丑业专丄七与与丕上 itemType;
    public PlaceableItemSettings itemSettings;
    public string category;
    public string subcategory;
    public int placeId;
    public System.Collections.Generic.List<UnityEngine.GameObject> enableOnActive;
    public System.Collections.Generic.List<UnityEngine.GameObject> enableOnInactive;
    public System.Collections.Generic.List<UnityEngine.GameObject> enableOnSelect;
    public bool Active;
    private float 丞一丗东丈丄丟万丂;
    private float 丒丏上丌丒且万丞丄;
    
    // Properties
    public bool 与丆与丂丄丞丒丏丑 { get; }
    
    // Methods
    public bool get_Selected()
    {
        return UnityEngine.Object.op_Equality(x:  this.tankBuildBase.selectedItemPoint, y:  this);
    }
    private void Start()
    {
        this.丞一丗东丈丄丟万丂 = (float)UnityEngine.Screen.height;
    }
    public virtual void Init(ClanTankBuildBase 丏丄万丆丞丂丙丑丙, int 世丟丄丅丛世丝丑丕)
    {
        this.tankBuildBase = 丏丄万丆丞丂丙丑丙;
        this.placeId = 世丟丄丅丛世丝丑丕;
    }
    public virtual bool Setup(PlaceableItemSettings 业世丟丐丘丐专与不)
    {
        if(this.itemSettings == 业世丟丐丘丐专与不)
        {
                return false;
        }
        
        this.itemSettings = 业世丟丐丘丐专与不;
        this.丞与一东三丞丕三上();
        return true;
    }
    public virtual void UpdateView()
    {
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnActive, 丏业丟一东丂东丘丛:  (this.Active == true) ? 1 : 0);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnInactive, 丏业丟一东丂东丘丛:  (this.Active == false) ? 1 : 0);
        丞东丑专丛丆丄丝世.一下下丌丌丆丘丟丏(丝三丁东丈丒世丅业:  this.enableOnSelect, 丏业丟一东丂东丘丛:  this.Selected);
    }
    public virtual void Select()
    {
        if(this.Active == false)
        {
                return;
        }
        
        if(this.itemSettings != null)
        {
                if(this.itemSettings.IsUnknown != false)
        {
                return;
        }
        
        }
        
        this.tankBuildBase.OnSelectItemPoint(丌丐下丆七丒丒丑丕:  this);
    }
    private void 丞与一东三丞丕三上()
    {
        var val_3;
        float val_4;
        float val_5;
        float val_6;
        float val_7;
        val_3 = this;
        丑业专丄七与与丕上 val_3 = this.itemType;
        val_3 = val_3 & 4294967294;
        if(val_3 != 6)
        {
                return;
        }
        
        if(this.itemSettings != null)
        {
                val_4 = 0f;
            val_5 = 0f;
            val_6 = 0f;
            val_7 = 1.25f;
        }
        else
        {
                UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
            val_4 = val_1.x;
            val_5 = val_1.y;
            val_6 = val_1.z;
            val_7 = 1f;
        }
        
        val_3 = this.GetComponent<UnityEngine.BoxCollider>();
        if(val_3 != null)
        {
                val_3.center = new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6};
        }
        else
        {
                val_3.center = new UnityEngine.Vector3() {x = val_4, y = val_5, z = val_6};
        }
        
        val_3.size = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    public void SetupPlaced()
    {
        null = null;
        PlaceableItemSettings val_1 = ClanTankBuildController.丄丘七三上丕世丞业.下世丗丂丐丐丑专丞(丅专与丒丈丗丒丘丌:  this);
        goto typeof(ClanTankPlaceableItemPoint).__il2cppRuntimeField_178;
    }
    public ClanTankPlaceableItemPoint()
    {
        this.Active = true;
        this.丒丏上丌丒且万丞丄 = 0.35f;
    }

}
