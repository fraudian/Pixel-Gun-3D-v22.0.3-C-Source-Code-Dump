using UnityEngine;
public class DS_SkinnedDecals : SkinnedDecals
{
    // Methods
    protected override Edelweiss.DecalSystem.SkinnedDecalsMeshRenderer AddSkinnedDecalsMeshRendererComponentToGameObject(UnityEngine.GameObject a_GameObject)
    {
        if(a_GameObject != null)
        {
                return a_GameObject.AddComponent<DS_SkinnedDecalsMeshRenderer>();
        }
        
        return a_GameObject.AddComponent<DS_SkinnedDecalsMeshRenderer>();
    }
    public DS_SkinnedDecals()
    {
    
    }

}
