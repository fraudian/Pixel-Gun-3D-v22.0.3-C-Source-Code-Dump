using UnityEngine;
internal class WeaponToggleModulesUI : MonoBehaviour
{
    // Fields
    private UISprite[] modulesIcons;
    private bool 业丂一业世下东丏丁;
    
    // Methods
    private void Awake()
    {
        var val_2;
        if(this.业丂一业世下东丏丁 == true)
        {
                return;
        }
        
        val_2 = 0;
        goto label_1;
        label_7:
        this.modulesIcons[0].gameObject.SetActive(value:  false);
        val_2 = 1;
        label_1:
        if(val_2 < this.modulesIcons.Length)
        {
            goto label_7;
        }
    
    }
    internal void 不丙丘丄与丞丄七丄(System.Collections.Generic.List<PGCompany.丏丂一丗丙世丏丐三> 丌丄丁丕丆丄下丂丛)
    {
        var val_11;
        var val_12;
        if((丌丄丁丕丆丄下丂丛 == null) || (丌丄丁丕丆丄下丂丛.Count < 1))
        {
            goto label_2;
        }
        
        val_12 = 0;
        val_11 = 0;
        label_19:
        if((val_11 >= 丌丄丁丕丆丄下丂丛.Count) || ((万世专丘且万世七丒.一丑丛丂世丈丕丛丘(丗与丟上上丑专世丗:  丌丄丁丕丆丄下丂丛.Item[0].与丝丅丘且丐上丅世())) == false))
        {
            goto label_7;
        }
        
        if(val_11 >= this.modulesIcons.Length)
        {
            goto label_21;
        }
        
        this.modulesIcons[0].gameObject.SetActive(value:  true);
        万世专丘且万世七丒.丞丗丝丛丙丏丛丛丗(与丄丈丘丟丕丏丐丁:  this.modulesIcons[0], 丗与丟上上丑专世丗:  丌丄丁丕丆丄下丂丛.Item[0].与丝丅丘且丐上丅世());
        val_12 = val_12 + 1;
        label_7:
        val_11 = val_11 + 1;
        if(val_11 < 丌丄丁丕丆丄下丂丛.Count)
        {
            goto label_19;
        }
        
        goto label_21;
        label_2:
        val_12 = 0;
        goto label_21;
        label_27:
        val_11 = 0;
        this.modulesIcons[val_11].gameObject.SetActive(value:  false);
        val_12 = 1;
        label_21:
        if(val_12 < this.modulesIcons.Length)
        {
            goto label_27;
        }
        
        this.业丂一业世下东丏丁 = true;
    }
    internal void 不丙丘丄与丞丄七丄(int[] 丌丄丁丕丆丄下丂丛)
    {
        int val_4;
        var val_5;
        if((丌丄丁丕丆丄下丂丛 == null) || (丌丄丁丕丆丄下丂丛.Length < 1))
        {
            goto label_2;
        }
        
        val_5 = 0;
        var val_5 = 0;
        label_19:
        if(val_5 >= 丌丄丁丕丆丄下丂丛.Length)
        {
            goto label_7;
        }
        
        val_4 = 丌丄丁丕丆丄下丂丛[0];
        if((万世专丘且万世七丒.一丑丛丂世丈丕丛丘(丗与丟上上丑专世丗:  val_4)) == false)
        {
            goto label_7;
        }
        
        val_4 = this.modulesIcons;
        if(val_5 >= this.modulesIcons.Length)
        {
            goto label_21;
        }
        
        this.modulesIcons[0].gameObject.SetActive(value:  true);
        val_4 = this.modulesIcons[0];
        万世专丘且万世七丒.丞丗丝丛丙丏丛丛丗(与丄丈丘丟丕丏丐丁:  val_4, 丗与丟上上丑专世丗:  丌丄丁丕丆丄下丂丛[0x0] + 32);
        val_5 = val_5 + 1;
        label_7:
        val_5 = val_5 + 1;
        if(val_5 < 丌丄丁丕丆丄下丂丛.Length)
        {
            goto label_19;
        }
        
        goto label_21;
        label_2:
        val_5 = 0;
        goto label_21;
        label_27:
        val_4 = 0;
        this.modulesIcons[val_4].gameObject.SetActive(value:  false);
        val_5 = 1;
        label_21:
        if(val_5 < this.modulesIcons.Length)
        {
            goto label_27;
        }
        
        this.业丂一业世下东丏丁 = true;
    }
    public WeaponToggleModulesUI()
    {
    
    }

}
