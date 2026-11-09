using UnityEngine;
[Serializable]
public class TerrainObjectsPull.Chunk
{
    // Fields
    public System.Collections.Generic.List<string> objectsInChunk;
    public TerrainObjectsPull.MyDictionaryOfVector3 positions;
    public TerrainObjectsPull.MyDictionaryOfQuaternion rotations;
    public TerrainObjectsPull.MyDictionaryOfVector3 scales;
    public UnityEngine.Rect rect;
    public UnityEngine.Vector2 id;
    
    // Methods
    public TerrainObjectsPull.Chunk()
    {
        this.objectsInChunk = new System.Collections.Generic.List<System.String>();
        this.positions = new TerrainObjectsPull.MyDictionaryOfVector3();
        this.rotations = new TerrainObjectsPull.MyDictionaryOfQuaternion();
        this.scales = new TerrainObjectsPull.MyDictionaryOfVector3();
    }

}
