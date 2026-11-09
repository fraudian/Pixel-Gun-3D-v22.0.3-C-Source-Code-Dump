using UnityEngine;
public class AnimationCoroutineRunner : MonoBehaviour
{
    // Methods
    public void StartPlay(UnityEngine.Animation 丆不丝丝上一丞七业, string 七不丐下丟专业万丅, bool 丄三丗丛丑下丅丏七, System.Action 丟丘丙丄丅万丏与丗)
    {
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.Play(丆不丝丝上一丞七业:  丆不丝丝上一丞七业, 七不丐下丟专业万丅:  七不丐下丟专业万丅, 丄三丗丛丑下丅丏七:  丄三丗丛丑下丅丏七, 丟丘丙丄丅万丏与丗:  丟丘丙丄丅万丏与丗));
    }
    public System.Collections.IEnumerator Play(UnityEngine.Animation 丆不丝丝上一丞七业, string 七不丐下丟专业万丅, bool 丄三丗丛丑下丅丏七, System.Action 丟丘丙丄丅万丏与丗)
    {
        AnimationCoroutineRunner.丁丕丕三丂与丝丛世 val_1 = new AnimationCoroutineRunner.丁丕丕三丂与丝丛世();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .七不丐下丟专业万丅 = 七不丐下丟专业万丅;
            .丝且与丝丒丟万丁专 = this;
            .丆不丝丝上一丞七业 = 丆不丝丝上一丞七业;
            .丄三丗丛丑下丅丏七 = 丄三丗丛丑下丅丏七;
        }
        else
        {
                mem[56] = this;
            mem[40] = 丆不丝丝上一丞七业;
            mem[48] = 七不丐下丟专业万丅;
            mem[32] = 丄三丗丛丑下丅丏七;
        }
        
        .丟丘丙丄丅万丏与丗 = 丟丘丙丄丅万丏与丗;
        return (System.Collections.IEnumerator)val_1;
    }
    public AnimationCoroutineRunner()
    {
    
    }

}
