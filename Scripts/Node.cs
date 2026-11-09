using UnityEngine;
[Serializable]
public class GrassSystemD.Node
{
    // Fields
    public bool active;
    public UnityEngine.Vector2 id;
    public UnityEngine.Vector2 pos;
    public System.Collections.Generic.List<int> Ids;
    public UnityEngine.Vector3[] grassPoses;
    public UnityEngine.Vector3[] grassUp;
    
    // Properties
    public int grassCount { get; }
    
    // Methods
    public int get_grassCount()
    {
        if(this.grassPoses != null)
        {
                return (int)this.grassPoses.Length;
        }
        
        return (int)this.grassPoses.Length;
    }
    public GrassSystemD.Node()
    {
        this.Ids = new System.Collections.Generic.List<System.Int32>();
    }

}
