using UnityEngine;
internal abstract class CurrentAiState : PGBehaviour
{
    // Fields
    protected RilisoftBot.BaseBot 东丙丄且上丈东丘不;
    protected RilisoftBot.BotAiController 丅万丗丕丑丑东丌丙;
    
    // Methods
    internal void 丐丑七丈业丝丄东丝(RilisoftBot.BaseBot 丗不丛七丏丄业三丁, RilisoftBot.BotAiController 丑丁一丛万丘万丗不)
    {
        this.东丙丄且上丈东丘不 = 丗不丛七丏丄业三丁;
        this.丅万丗丕丑丑东丌丙 = 丑丁一丛万丘万丗不;
    }
    internal abstract RilisoftBot.BotAiController.丑丅专丈丏七丐丝业 丈丛七丐丏丘丕下丕(RilisoftBot.BotAiController.丑丅专丈丏七丐丝业 丈专世丌三丝东万东); // 0
    protected CurrentAiState()
    {
    
    }

}
