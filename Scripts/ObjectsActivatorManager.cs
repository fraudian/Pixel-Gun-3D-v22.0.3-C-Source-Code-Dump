using UnityEngine;
internal sealed class ObjectsActivatorManager : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<ObjectWithDelay> effects;
    
    // Methods
    internal void 丏丁一下丅世七丄丅()
    {
        goto label_1;
        label_4:
        ObjectWithDelay val_1 = this.effects.Item[0];
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  val_1.丂专世丒不丅业且丌(丏不丂丆且三丞丆丏:  val_1));
        0 = 1;
        label_1:
        if(0 < this.effects.Count)
        {
            goto label_4;
        }
    
    }
    private System.Collections.IEnumerator 丂专世丒不丅业且丌(ObjectWithDelay 丏不丂丆且三丞丆丏)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丏不丂丆且三丞丆丏 = 丏不丂丆且三丞丆丏;
        return (System.Collections.IEnumerator)new ObjectsActivatorManager.丙不与专丐丈丁万丐();
    }
    public ObjectsActivatorManager()
    {
    
    }

}
