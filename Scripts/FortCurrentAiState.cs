using UnityEngine;
internal sealed class FortCurrentAiState : CurrentAiState
{
    // Fields
    private bool 世丂丄世丕丅不丝丂;
    private 丅丙上七上一丐不下 与丝丁丑丁丌丞丞东;
    
    // Properties
    internal bool 丌万丑丂丗丅丘丄丑 { get; set; }
    internal 丅丙上七上一丐不下 不丘且丘专与丐丄丂 { get; set; }
    
    // Methods
    internal void 万丌万丏丌丈且三丗(bool 丙业与丙丗丝不丈东)
    {
        this.世丂丄世丕丅不丝丂 = 丙业与丙丗丝不丈东;
    }
    internal bool 丝丄万丈丒丛丗丕与()
    {
        return (bool)this.世丂丄世丕丅不丝丂;
    }
    internal void 东东专丒三东丂一丕(丅丙上七上一丐不下 丙业与丙丗丝不丈东)
    {
        this.与丝丁丑丁丌丞丞东 = 丙业与丙丗丝不丈东;
    }
    internal 丅丙上七上一丐不下 丏丒丁且丌下万丄丆()
    {
        return (丅丙上七上一丐不下)this.与丝丁丑丁丌丞丞东;
    }
    internal override RilisoftBot.BotAiController.丑丅专丈丏七丐丝业 丈丛七丐丏丘丕下丕(RilisoftBot.BotAiController.丑丅专丈丏七丐丝业 丈专世丌三丝东万东)
    {
        var val_11;
        var val_12;
        val_11 = this;
        if(IsDeath != false)
        {
                val_12 = 6;
            return (丑丅专丈丏七丐丝业)val_12;
        }
        
        if((this.世丂丄世丕丅不丝丂 != false) && (currentTarget != 0))
        {
                UnityEngine.Transform val_4 = this.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_5 = val_4.position;
            UnityEngine.Transform val_6 = val_4.currentTarget;
            UnityEngine.Vector3 val_7 = val_6.position;
            if((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) > (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})))
        {
                return (丑丅专丈丏七丐丝业)val_12;
        }
        
            if(val_6.七与世丄丞丒一七三() != null)
        {
                if(this.丐丄丞万丞东东世丟() == false)
        {
                return (丑丅专丈丏七丐丝业)val_12;
        }
        
        }
        
            val_12 = 2;
            return (丑丅专丈丏七丐丝业)val_12;
        }
        
        val_12 = 0;
        return (丑丅专丈丏七丐丝业)val_12;
    }
    public FortCurrentAiState()
    {
    
    }

}
