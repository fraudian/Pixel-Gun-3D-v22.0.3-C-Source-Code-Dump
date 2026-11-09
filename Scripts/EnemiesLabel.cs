using UnityEngine;
internal sealed class EnemiesLabel : MonoBehaviour
{
    // Fields
    private UILabel 一丙且丛丟丈丙且与;
    private ZombieCreator 丏丗与丝丗丈丌丛丝;
    private System.Collections.Generic.KeyValuePair<int, string> 丘三丂丞世不丞三丂;
    private string 上丈下不丏丙万丂丂;
    
    // Methods
    private void Start()
    {
        var val_6;
        var val_7;
        int val_8;
        val_6 = null;
        val_6 = null;
        this.gameObject.SetActive(value:  (与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false) ? 1 : 0);
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == true)
        {
                return;
        }
        
        this.一丙且丛丟丈丙且与 = this.GetComponent<UILabel>();
        val_7 = null;
        val_7 = null;
        this.丏丗与丝丗丈丌丛丝 = ZombieCreator.丞丈丟丒丂丞丏不丑;
        UnityEngine.SceneManagement.Scene val_4 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if(val_4.m_Handle.name == null)
        {
                val_8 = System.String.alignConst;
        }
        
        this.上丈下不丏丙万丂丂 = val_8;
    }
    private void Update()
    {
        this.一丙且丛丟丈丙且与.text = this.且专丟丘东七丁一丝();
    }
    private void OnDestroy()
    {
        this.丘三丂丞世不丞三丂 = 0;
        mem[1152921525990727984] = 0;
    }
    private string 且专丟丘东七丁一丝()
    {
        ZombieCreator val_6 = this.丏丗与丝丗丈丌丛丝;
        val_6 = (ZombieCreator.东丐丄七丆三且丕万(专万丟三世业丙丈且:  this.上丈下不丏丙万丂丂)) - val_6.丌丟且丛丄丒万丈丑();
        if(val_6 == this.丘三丂丞世不丞三丂.丙东专丂世丈丏丁丂())
        {
                return (string)this.丘三丂丞世不丞三丂;
        }
        
        string val_5 = val_6.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
        this.丘三丂丞世不丞三丂 = 0;
        mem[1152921525990856368] = 0;
        return (string)this.丘三丂丞世不丞三丂;
    }
    public EnemiesLabel()
    {
        this.丘三丂丞世不丞三丂 = 0;
        mem[1152921525990984752] = 0;
        this.上丈下不丏丙万丂丂 = System.String.alignConst;
    }

}
