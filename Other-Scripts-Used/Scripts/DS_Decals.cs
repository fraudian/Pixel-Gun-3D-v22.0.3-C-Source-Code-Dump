using UnityEngine;
public class DS_Decals : Decals
{
    // Methods
    protected override Edelweiss.DecalSystem.DecalsMeshRenderer AddDecalsMeshRendererComponentToGameObject(UnityEngine.GameObject a_GameObject)
    {
        if(a_GameObject != null)
        {
                return a_GameObject.AddComponent<DS_DecalsMeshRenderer>();
        }
        
        return a_GameObject.AddComponent<DS_DecalsMeshRenderer>();
    }
    public DS_Decals()
    {
    
    }

}
