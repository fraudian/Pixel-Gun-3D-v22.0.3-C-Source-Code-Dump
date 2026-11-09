using UnityEngine;
public class BlickButton : MonoBehaviour
{
    // Fields
    public float firstSdvig;
    public float blickPeriod;
    public float blickSpeed;
    public UISprite blickSprite;
    public UIButton baseButton;
    public string baseNameSprite;
    public int countFrame;
    
    // Methods
    private void Start()
    {
        this.blickSprite.gameObject.SetActive(value:  false);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.世丅丟专丄丘万丒丟());
    }
    private System.Collections.IEnumerator 世丅丟专丄丘万丒丟()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new BlickButton.丛丅丛丒丙丞不丆丘();
    }
    public System.Collections.IEnumerator MyWaitForSeconds(float 七且丆丞丌丘下世丑)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .七且丆丞丌丘下世丑 = 七且丆丞丌丘下世丑;
        return (System.Collections.IEnumerator)new BlickButton.与东丘丒丟万不丂丌();
    }
    private void Update()
    {
    
    }
    public BlickButton()
    {
        this.blickPeriod = 3f;
        this.blickSpeed = 5.510186E-41f;
    }

}
