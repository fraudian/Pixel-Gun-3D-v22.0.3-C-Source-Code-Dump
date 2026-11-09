using UnityEngine;
private abstract class InfoWindowController.不丌丅丗丁丟丅丐一
{
    // Fields
    private bool <下丏专丌世丅东上丁>k__BackingField;
    private AchieveBox <丄业与丅丌丙丆丈上>k__BackingField;
    
    // Properties
    public bool 万下且丏丗下与丂丗 { get; set; }
    public AchieveBox 世业不不丒一丘下东 { get; set; }
    
    // Methods
    public InfoWindowController.不丌丅丗丁丟丅丐一(AchieveBox 不丌丗丂丆业丂丏世)
    {
        this.<丄业与丅丌丙丆丈上>k__BackingField = 不丌丗丂丆业丂丏世;
    }
    public bool 丗丙丐下丏丝丁丘三()
    {
        return (bool)this.<下丏专丌世丅东上丁>k__BackingField;
    }
    public void 且万丆七世三不丆丑(bool 丙业与丙丗丝不丈东)
    {
        this.<下丏专丌世丅东上丁>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public AchieveBox 下七上丐丘丟丒三丞()
    {
        return (AchieveBox)this.<丄业与丅丌丙丆丈上>k__BackingField;
    }
    protected void 丟丗与丁专三与世且(AchieveBox 丙业与丙丗丝不丈东)
    {
        this.<丄业与丅丌丙丆丈上>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public virtual void 一丌一丞世不下丄专()
    {
        this.<下丏专丌世丅东上丁>k__BackingField = true;
        this.<丄业与丅丌丙丆丈上>k__BackingField.ShowBox();
    }

}
