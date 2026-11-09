using UnityEngine;
[Serializable]
public class SwitchLogicBaseBot.LogicInfoBaseBot
{
    // Fields
    public float percentHealth;
    public RilisoftBot.BaseBot baseBot;
    public float mechanicalTime;
    public UnityEngine.AnimationClip clip;
    
    // Methods
    public SwitchLogicBaseBot.LogicInfoBaseBot()
    {
        this.percentHealth = 1f;
        this.mechanicalTime = 1f;
    }

}
