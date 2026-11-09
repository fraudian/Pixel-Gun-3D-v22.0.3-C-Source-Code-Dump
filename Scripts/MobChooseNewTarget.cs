using UnityEngine;
internal class MobChooseNewTarget : PGBehaviour
{
    // Fields
    protected RilisoftBot.BaseBot 东丙丄且上丈东丘不;
    protected RilisoftBot.BotAiController 丅万丗丕丑丑东丌丙;
    protected 丅丙上七上一丐不下 丛丌丕丐世丑丂七丂;
    
    // Methods
    internal 丅丙上七上一丐不下 丗丕一丁下丅世一三()
    {
        return (丅丙上七上一丐不下)this.丛丌丕丐世丑丂七丂;
    }
    internal virtual void 丐丑七丈业丝丄东丝(RilisoftBot.BaseBot 丗不丛七丏丄业三丁, RilisoftBot.BotAiController 丑丁一丛万丘万丗不)
    {
        this.东丙丄且上丈东丘不 = 丗不丛七丏丄业三丁;
        this.丅万丗丕丑丑东丌丙 = 丑丁一丛万丘万丗不;
    }
    private void Start()
    {
        System.Action<RilisoftBot.BaseBot, 丅丙上七上一丐不下, System.Single> val_1 = new System.Action<RilisoftBot.BaseBot, 丅丙上七上一丐不下, System.Single>(object:  this, method:  typeof(MobChooseNewTarget).__il2cppRuntimeField_180);
        this.东丙丄且上丈东丘不.丈万丕丟丞丂丑不丈(丙业与丙丗丝不丈东:  null);
    }
    private void OnDestroy()
    {
        System.Action<RilisoftBot.BaseBot, 丅丙上七上一丐不下, System.Single> val_1 = new System.Action<RilisoftBot.BaseBot, 丅丙上七上一丐不下, System.Single>(object:  this, method:  typeof(MobChooseNewTarget).__il2cppRuntimeField_180);
        this.东丙丄且上丈东丘不.东丂不专三丙丐一丁(丙业与丙丗丝不丈东:  null);
    }
    protected virtual void 业丂丛丟上且丂东丂(RilisoftBot.BaseBot 丗不丛七丏丄业三丁, 丅丙上七上一丐不下 丛世一丟丞丁业丘丒, float 丞丈专下丈专业三丞)
    {
    
    }
    public MobChooseNewTarget()
    {
    
    }

}
