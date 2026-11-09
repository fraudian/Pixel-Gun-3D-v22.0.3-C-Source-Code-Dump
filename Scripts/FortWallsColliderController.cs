using UnityEngine;
public class FortWallsColliderController : MonoBehaviour
{
    // Fields
    internal static FortWallsColliderController 丄丘七三上丕世丞业;
    public UnityEngine.Collider colliderObject;
    
    // Methods
    private void Start()
    {
        null = null;
        FortWallsColliderController.丄丘七三上丕世丞业 = this;
        this.colliderObject = this.transform.GetChild(index:  0).GetComponent<UnityEngine.Collider>();
    }
    private void Update()
    {
        null = null;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.colliderObject.gameObject, 丏业丟一东丂东丘丛:  SiegeController.三三万丆下一丗万丛.inAttackTeam);
    }
    private void OnDestroy()
    {
        null = null;
        FortWallsColliderController.丄丘七三上丕世丞业 = 0;
    }
    public FortWallsColliderController()
    {
    
    }
    private static FortWallsColliderController()
    {
    
    }

}
