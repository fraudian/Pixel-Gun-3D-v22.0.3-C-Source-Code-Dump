using UnityEngine;
public class BadNetworkBlinkingController : MonoBehaviour
{
    // Fields
    private UnityEngine.Material 丂且丝东丕丞且丁丗;
    private UILabel 丈丝丘丘不丁丐丗东;
    private float 丒丌丛丑丁丙丟丌上;
    private float 丒丈丌下丙丝丝丙丅;
    private float 三丙丌丕丕三丗丙上;
    private int 丄丟且七丌七丒一一;
    
    // Methods
    internal void 世丅丟专丄丘万丒丟()
    {
        this.丒丌丛丑丁丙丟丌上 = 6f;
        this.gameObject.SetActive(value:  true);
    }
    private void Awake()
    {
        UnityEngine.Material val_7;
        this.gameObject.SetActive(value:  false);
        UnityEngine.MeshRenderer val_2 = this.GetComponent<UnityEngine.MeshRenderer>();
        if(val_2 == 0)
        {
            goto label_4;
        }
        
        if(val_2 == null)
        {
            goto label_5;
        }
        
        val_7 = val_2.material;
        this.丂且丝东丕丞且丁丗 = val_7;
        goto label_6;
        label_4:
        this.丈丝丘丘不丁丐丗东 = this.GetComponent<UILabel>();
        return;
        label_5:
        val_7 = val_2.material;
        this.丂且丝东丕丞且丁丗 = val_7;
        label_6:
        val_2.sharedMaterial = val_7;
    }
    private void Update()
    {
        float val_10;
        float val_11;
        if(this.丒丌丛丑丁丙丟丌上 <= 0f)
        {
                if(this.三丙丌丕丕三丗丙上 <= 0f)
        {
            goto label_2;
        }
        
        }
        
        this.丄丟且七丌七丒一一 = (int)UnityEngine.Mathf.Sign(f:  this.丒丌丛丑丁丙丟丌上);
        float val_2 = UnityEngine.Time.deltaTime;
        val_2 = val_2 * ((float)(int)UnityEngine.Mathf.Sign(f:  this.丒丌丛丑丁丙丟丌上));
        val_2 = val_2 * this.丒丈丌下丙丝丝丙丅;
        val_10 = this.三丙丌丕丕三丗丙上 + val_2;
        this.三丙丌丕丕三丗丙上 = val_10;
        this.三丙丌丕丕三丗丙上 = UnityEngine.Mathf.Clamp(value:  val_10, min:  0f, max:  1f);
        if(this.丂且丝东丕丞且丁丗 != 0)
        {
                UnityEngine.Color val_5 = this.丂且丝东丕丞且丁丗.color;
            val_11 = this.三丙丌丕丕三丗丙上;
            val_10 = val_5.r;
            this.丂且丝东丕丞且丁丗.color = new UnityEngine.Color() {r = val_10, g = val_5.g, b = val_5.b, a = val_11};
        }
        else
        {
                if(this.丈丝丘丘不丁丐丗东 != 0)
        {
                UnityEngine.Color val_7 = this.丈丝丘丘不丁丐丗东.color;
            val_11 = this.三丙丌丕丕三丗丙上;
            val_10 = val_7.r;
            this.丈丝丘丘不丁丐丗东.color = new UnityEngine.Color() {r = val_10, g = val_7.g, b = val_7.b, a = val_11};
        }
        
        }
        
        float val_8 = UnityEngine.Time.deltaTime;
        val_8 = this.丒丌丛丑丁丙丟丌上 - val_8;
        this.丒丌丛丑丁丙丟丌上 = val_8;
        return;
        label_2:
        this.gameObject.SetActive(value:  false);
    }
    public BadNetworkBlinkingController()
    {
        this.丒丈丌下丙丝丝丙丅 = 3f;
        this.丄丟且七丌七丒一一 = 1;
    }

}
