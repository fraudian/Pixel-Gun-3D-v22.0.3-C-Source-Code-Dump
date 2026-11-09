using UnityEngine;
internal sealed class TestMiniMapCube : PGBehaviour
{
    // Methods
    private void Update()
    {
        if((UnityEngine.Input.GetKeyDown(key:  107)) != false)
        {
                NJGMapItem val_3 = AddMiniMapIcon(业丟丏上丛与不一丝:  this.gameObject, 下丗丁丒丘东丂不丑:  11);
        }
        
        if((UnityEngine.Input.GetKeyDown(key:  108)) == false)
        {
                return;
        }
        
        RemoveMiniMapIcon(业丟丏上丛与不一丝:  this.gameObject);
    }
    public TestMiniMapCube()
    {
    
    }

}
