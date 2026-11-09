using UnityEngine;
internal abstract class MoveMobToTarget : MonoBehaviour
{
    // Fields
    protected UnityEngine.Transform 丛丌丕丐世丑丂七丂;
    protected RilisoftBot.BotAiController 丅万丗丕丑丑东丌丙;
    protected float 丏丕丌丒丛三专丄丄;
    
    // Methods
    public virtual void SetTarget(UnityEngine.Transform 丞下万上三丘上与专, object[] 丗专丆万丏万丂丂丆)
    {
        this.丛丌丕丐世丑丂七丂 = 丞下万上三丘上与专;
    }
    public virtual void SetBot(RilisoftBot.BotAiController 丑丁一丛万丘万丗不)
    {
        this.丅万丗丕丑丑东丌丙 = 丑丁一丛万丘万丗不;
        UnityEngine.Vector3 val_2 = 丑丁一丛万丘万丗不.transform.position;
        this.丏丕丌丒丛三专丄丄 = val_2.y;
    }
    public abstract void MoveToTarget(); // 0
    protected MoveMobToTarget()
    {
    
    }

}
