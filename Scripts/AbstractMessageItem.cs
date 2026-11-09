using UnityEngine;
public abstract class AbstractMessageItem : MonoBehaviour
{
    // Fields
    public bool isRead;
    public string timeStamp;
    protected UIPanel 丝丈丏万丝业丂丏丗;
    protected UnityEngine.Transform 万东万丆专丌丕丐丗;
    public int myWrapIndex;
    
    // Methods
    public abstract void SetFon(bool 丌且下丕下下丌万丞); // 0
    public abstract void SetBackground(东业专世丟不专不丕.丏丙丘丕丙且上不东 七丐丅专且专七三丆); // 0
    public abstract void SetWidth(int 业与三万七丝不万东); // 0
    protected AbstractMessageItem()
    {
    
    }

}
