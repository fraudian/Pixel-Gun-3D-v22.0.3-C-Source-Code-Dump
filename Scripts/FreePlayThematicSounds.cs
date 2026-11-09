using UnityEngine;
internal sealed class FreePlayThematicSounds : AreaBase
{
    // Fields
    public FreePlayThematicSoundsController controller;
    public string clipName;
    private bool <丂丈丗丁且业世丘上>k__BackingField;
    
    // Properties
    private bool 专丒丄丌丂丙丟世丅 { get; set; }
    
    // Methods
    private bool 丈丏专与丛业丂丏与()
    {
        return (bool)this.<丂丈丗丁且业世丘上>k__BackingField;
    }
    private void 丕丘丛一丟丂七丅丆(bool 丙业与丙丗丝不丈东)
    {
        this.<丂丈丗丁且业世丘上>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void 丙丆丐一三丌丝丕丌()
    {
        this.<丂丈丗丁且业世丘上>k__BackingField = true;
        this.controller.且丕上丙东专万丝业(七不丐下丟专业万丅:  this.clipName);
    }
    private void 丛三丐丘丂丈专丏专()
    {
        this.<丂丈丗丁且业世丘上>k__BackingField = false;
        this.controller.丞丗丕专丁丟丕东丟();
    }
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        if((this.丂丈与万一丆丄丅丂(丘丛丏丘丝七世七丅:  丘丛丏丘丝七世七丅)) == false)
        {
                return;
        }
        
        this.丙丆丐一三丌丝丕丌();
    }
    private void OnTriggerExit(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        if((this.丂丈与万一丆丄丅丂(丘丛丏丘丝七世七丅:  丘丛丏丘丝七世七丅)) == false)
        {
                return;
        }
        
        this.丛三丐丘丂丈专丏专();
    }
    private bool 丂丈与万一丆丄丅丂(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Object val_8;
        var val_9;
        var val_10;
        val_8 = 丘丛丏丘丝七世七丅;
        if((val_8.CompareTag(tag:  "BodyCollider")) == false)
        {
                return false;
        }
        
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer == 0)
        {
                return false;
        }
        
        val_8 = val_8.transform.parent;
        if(val_8 == 0)
        {
                return false;
        }
        
        if((val_8.CompareTag(tag:  "Player")) == false)
        {
                return false;
        }
        
        val_10 = null;
        val_10 = null;
        return UnityEngine.Object.op_Equality(x:  val_8, y:  transform);
    }
    public FreePlayThematicSounds()
    {
    
    }

}
