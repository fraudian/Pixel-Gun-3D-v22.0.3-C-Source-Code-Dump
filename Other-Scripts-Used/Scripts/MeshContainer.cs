using UnityEngine;
public class MeshContainer
{
    // Fields
    public UnityEngine.Mesh mesh;
    public UnityEngine.Vector3[] vertices;
    public UnityEngine.Vector3[] normals;
    
    // Methods
    public MeshContainer(UnityEngine.Mesh m)
    {
        this.mesh = m;
        if(m != null)
        {
                this.vertices = m.vertices;
        }
        else
        {
                this.vertices = 0.vertices;
        }
        
        this.normals = m.normals;
    }
    public void Update()
    {
        this.mesh.vertices = this.vertices;
        this.mesh.normals = this.normals;
    }

}
