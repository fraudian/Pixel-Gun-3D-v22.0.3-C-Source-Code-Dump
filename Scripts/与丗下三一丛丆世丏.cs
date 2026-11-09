using UnityEngine;
internal class PlayerCoreSettingsStorager.与丗下三一丛丆世丏
{
    // Fields
    internal float 不万丟且上东丅丙且;
    internal float 丏丙世专一与丑一且;
    internal float 丗丆丞三丙专七且丆;
    
    // Methods
    public PlayerCoreSettingsStorager.与丗下三一丛丆世丏()
    {
        this.不万丟且上东丅丙且 = 10f;
        this.丏丙世专一与丑一且 = 10f;
        this.丗丆丞三丙专七且丆 = 0.5f;
    }
    public PlayerCoreSettingsStorager.与丗下三一丛丆世丏(PlayerCoreSettingsStorager.与丗下三一丛丆世丏 与丕丂且丁且丄丑一)
    {
        this.不万丟且上东丅丙且 = 10f;
        this.丏丙世专一与丑一且 = 10f;
        this.丗丆丞三丙专七且丆 = 0.5f;
        if(与丕丂且丁且丄丑一 != null)
        {
                this.不万丟且上东丅丙且 = 与丕丂且丁且丄丑一.不万丟且上东丅丙且;
            this.丏丙世专一与丑一且 = 与丕丂且丁且丄丑一.丏丙世专一与丑一且;
        }
        else
        {
                this.不万丟且上东丅丙且 = 1.68059E-38f;
            this.丏丙世专一与丑一且 = 1.401298E-45f;
        }
        
        this.丗丆丞三丙专七且丆 = 与丕丂且丁且丄丑一.丗丆丞三丙专七且丆;
    }
    public PlayerCoreSettingsStorager.与丗下三一丛丆世丏(float 不万丟且上东丅丙且, float 丏丙世专一与丑一且, float 丗丆丞三丙专七且丆)
    {
        this.不万丟且上东丅丙且 = 10f;
        this.丏丙世专一与丑一且 = 10f;
        this.丗丆丞三丙专七且丆 = 0.5f;
        this.不万丟且上东丅丙且 = 不万丟且上东丅丙且;
        this.丏丙世专一与丑一且 = 丏丙世专一与丑一且;
        this.丗丆丞三丙专七且丆 = 丗丆丞三丙专七且丆;
    }
    internal void 世丄丘丄丆且丌丙且(System.Collections.Generic.Dictionary<string, object> 丌丆丆丆丏丄万丛不)
    {
        var val_13;
        if(丌丆丆丆丏丄万丛不 == null)
        {
                return;
        }
        
        if((丌丆丆丆丏丄万丛不.ContainsKey(key:  "speedInsideZone")) != false)
        {
                bool val_4 = 丞东丑专丛丆丄丝世.丝丐丐丝丒丈且专专(丞丕丒专一下丙业上:  丌丆丆丆丏丄万丛不.Item["speedInsideZone"], 丙业与丙丗丝不丈东: out  this.不万丟且上东丅丙且);
        }
        
        if((丌丆丆丆丏丄万丛不.ContainsKey(key:  "speedOutsideZone")) != false)
        {
                bool val_8 = 丞东丑专丛丆丄丝世.丝丐丐丝丒丈且专专(丞丕丒专一下丙业上:  丌丆丆丆丏丄万丛不.Item["speedOutsideZone"], 丙业与丙丗丝不丈东: out  this.丏丙世专一与丑一且);
        }
        
        val_13 = "zoneValue";
        if((丌丆丆丆丏丄万丛不.ContainsKey(key:  "zoneValue")) == false)
        {
                return;
        }
        
        bool val_12 = 丞东丑专丛丆丄丝世.丝丐丐丝丒丈且专专(丞丕丒专一下丙业上:  丌丆丆丆丏丄万丛不.Item["zoneValue"], 丙业与丙丗丝不丈东: out  this.丗丆丞三丙专七且丆);
    }

}
