using UnityEngine;
public class SimpleOnAnimationParticles : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject[] reloadParticleObjs;
    
    // Methods
    private void OnEnable()
    {
        this.一丑上七丈丏下丞业(与一丐业丝上丕丘东:  this.reloadParticleObjs, 丝三丄专丗丞丄丄丌:  false);
    }
    private void 一丑上七丈丏下丞业(UnityEngine.GameObject[] 与一丐业丝上丕丘东, bool 丝三丄专丗丞丄丄丌)
    {
        UnityEngine.GameObject val_3;
        if(与一丐业丝上丕丘东 == null)
        {
                return;
        }
        
        if(与一丐业丝上丕丘东.Length < 1)
        {
                return;
        }
        
        do
        {
            val_3 = 与一丐业丝上丕丘东[0].gameObject;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_3, 丏业丟一东丂东丘丛:  丝三丄专丗丞丄丄丌);
        }
        while((0 + 1) < 与一丐业丝上丕丘东.Length);
    
    }
    public void OnReloadAnimationStart()
    {
        this.一丑上七丈丏下丞业(与一丐业丝上丕丘东:  this.reloadParticleObjs, 丝三丄专丗丞丄丄丌:  false);
        this.一丑上七丈丏下丞业(与一丐业丝上丕丘东:  this.reloadParticleObjs, 丝三丄专丗丞丄丄丌:  true);
    }
    public SimpleOnAnimationParticles()
    {
    
    }

}
