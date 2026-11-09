using UnityEngine;
private class BuffSystem.丈丅万丞业不与三与
{
    // Fields
    public BuffSystem.丟不与丑与丗丙一丙 丂丐丄丁丆与丈丂上;
    private float 专丌万丑三丙丕丙丝;
    public string 丌丝下丄业一丄不三;
    
    // Properties
    public bool 三丕且七下三丙不丌 { get; }
    public bool 丐丌丙丈丗丏丅丌一 { get; }
    
    // Methods
    public BuffSystem.丈丅万丞业不与三与(BuffSystem.丟不与丑与丗丙一丙 丂丐丄丁丆与丈丂上, string 三丛丂丌丁丝丑一丂)
    {
        var val_3;
        val_1 = new System.Object();
        this.丂丐丄丁丆与丈丂上 = 丂丐丄丁丆与丈丂上;
        this.丌丝下丄业一丄不三 = val_1;
        val_3 = null;
        val_3 = null;
        float val_3 = 丂丐丄丁丆与丈丂上.丂三丟丂丈丐丆丗丟;
        val_3 = NotificationController.丄丘七三上丕世丞业.currentPlayTimeMatch + val_3;
        this.专丌万丑三丙丕丙丝 = val_3;
    }
    public BuffSystem.丈丅万丞业不与三与(BuffSystem.丟不与丑与丗丙一丙 丂丐丄丁丆与丈丂上, string 三丛丂丌丁丝丑一丂, float 下丑丗一丞丑丙不丝)
    {
        val_1 = new System.Object();
        this.丂丐丄丁丆与丈丂上 = 丂丐丄丁丆与丈丂上;
        this.丌丝下丄业一丄不三 = val_1;
        this.专丌万丑三丙丕丙丝 = 下丑丗一丞丑丙不丝;
    }
    public System.Collections.Generic.Dictionary<string, object> 丙业不丝丗丌丗世下()
    {
        System.Collections.Generic.Dictionary<System.String, System.Object> val_1 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        val_1.set_Item(key:  "type", value:  this.丂丐丄丁丆与丈丂上.丁丅丈丌丟世丗丗丟);
        val_1.set_Item(key:  "expire", value:  this.专丌万丑三丙丕丙丝);
        if((System.String.IsNullOrEmpty(value:  this.丌丝下丄业一丄不三)) == true)
        {
                return val_1;
        }
        
        val_1.set_Item(key:  "weapon", value:  this.丌丝下丄业一丄不三);
        return val_1;
    }
    public bool 丛丕丕丌丁万丂丈与()
    {
        BuffSystem.丟不与丑与丗丙一丙 val_2;
        var val_3;
        val_2 = this;
        if(this.丂丐丄丁丆与丈丂上.万上一丗上丂丞丁丟 >= 0)
        {
                val_2 = this.丂丐丄丁丆与丈丂上;
            var val_1 = (this.丂丐丄丁丆与丈丂上.七一丅下丄业世七下 < 0) ? 1 : 0;
            return (bool)val_3;
        }
        
        val_3 = 1;
        return (bool)val_3;
    }
    public bool 丞业丅一世一丝万丌()
    {
        null = null;
        float val_1 = NotificationController.丄丘七三上丕世丞业.currentPlayTimeMatch;
        return (bool)(this.专丌万丑三丙丕丙丝 < 0) ? 1 : 0;
    }

}
