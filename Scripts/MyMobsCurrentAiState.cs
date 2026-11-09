using UnityEngine;
internal sealed class MyMobsCurrentAiState : CurrentAiState
{
    // Fields
    internal bool 丌万丑丂丗丅丘丄丑;
    
    // Methods
    internal override RilisoftBot.BotAiController.丑丅专丈丏七丐丝业 丈丛七丐丏丘丕下丕(RilisoftBot.BotAiController.丑丅专丈丏七丐丝业 丈专世丌三丝东万东)
    {
        var val_10;
        var val_11;
        val_10 = this;
        if(IsDeath != false)
        {
                val_11 = 6;
            return (丑丅专丈丏七丐丝业)val_11;
        }
        
        if(this.丌万丑丂丗丅丘丄丑 != false)
        {
                if(currentTarget != 0)
        {
                UnityEngine.Transform val_4 = this.丌丟丄业且三丛丕丄();
            UnityEngine.Vector3 val_5 = val_4.position;
            UnityEngine.Vector3 val_7 = val_4.currentTarget.position;
            var val_9 = ((UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) <= (UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_5.x, y = val_5.y, z = val_5.z}, b:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}))) ? 2 : (0 + 1);
            return (丑丅专丈丏七丐丝业)val_11;
        }
        
        }
        
        val_11 = 0;
        return (丑丅专丈丏七丐丝业)val_11;
    }
    public MyMobsCurrentAiState()
    {
    
    }

}
