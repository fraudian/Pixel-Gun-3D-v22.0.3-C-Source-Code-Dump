using UnityEngine;
internal sealed class AmmoUpdater : MonoBehaviour
{
    // Fields
    private UILabel 一丙且丛丟丈丙且与;
    public UnityEngine.GameObject ammoSprite;
    private System.Collections.Generic.KeyValuePair<int, string> 丂丘丘丌七丌丆与丟;
    private System.Collections.Generic.KeyValuePair<Rilisoft.专丈世丗业不世丗丙, string> 不丁丟丕丞万丑丞丝;
    
    // Methods
    private void Start()
    {
        this.一丙且丛丟丈丙且与 = this.GetComponent<UILabel>();
    }
    private void Update()
    {
        var val_20;
        var val_21;
        var val_22;
        UILabel val_23;
        val_20 = null;
        val_20 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_24;
        }
        
        val_21 = null;
        val_21 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.丞丛丏丐丘与丆七丗() == 0)
        {
            goto label_24;
        }
        
        val_22 = null;
        val_22 = null;
        三丈丟与丏丘丈丐万 val_6 = WeaponManager.丟丗丄业丘丗业丗七.下上丏丁东丝丑世与().Item[WeaponManager.丟丗丄业丘丗业丗七.丈丄丙丙丈丗业丆万()];
        if(val_6.三丐三丞丘丕不丒专.丐专丒丟丈丛丈丂业() != false)
        {
                if(val_6.三丐三丞丘丕不丒专.不丅丟丞丏丒丌三丌() == false)
        {
            goto label_24;
        }
        
        }
        
        if(this.一丙且丛丟丈丙且与 == 0)
        {
            goto label_24;
        }
        
        val_23 = this.一丙且丛丟丈丙且与;
        int val_11 = val_6.下世万丆丛专丒丑丙();
        int val_12 = val_6.东东丄丅丐一丙一业();
        if(val_6.三丐三丞丘丕不丒专.不丅丟丞丏丒丌三丌() == false)
        {
            goto label_26;
        }
        
        string val_13 = this.丂丟丈世且丁专业丑(丕丒丅丈丌丆丝丝丛:  val_11, 下丌丒丑丆丘七万丌:  val_12);
        goto label_27;
        label_24:
        val_23 = this.一丙且丛丟丈丙且与;
        val_23.text = System.String.alignConst;
        if(this.ammoSprite == 0)
        {
                return;
        }
        
        if(this.ammoSprite.activeSelf == false)
        {
                return;
        }
        
        label_43:
        this.ammoSprite.SetActive(value:  false);
        return;
        label_26:
        label_27:
        val_23.text = this.不丗丄东丈专丒一且(丕丒丅丈丌丆丝丝丛:  val_11, 下丌丒丑丆丘七万丌:  val_12, 丑世不与丈上丁丅与:  val_6.三丐三丞丘丕不丒专.下世下丂丂丌丑丝世());
        if(this.ammoSprite == 0)
        {
                return;
        }
        
        if(this.ammoSprite.activeSelf != false)
        {
                return;
        }
        
        if(this.ammoSprite != null)
        {
            goto label_43;
        }
        
        goto label_43;
    }
    private string 丂丟丈世且丁专业丑(int 丕丒丅丈丌丆丝丝丛, int 下丌丒丑丆丘七万丌)
    {
        int val_4 = 丕丒丅丈丌丆丝丝丛;
        val_4 = 下丌丒丑丆丘七万丌 + val_4;
        if(val_4 == this.丂丘丘丌七丌丆与丟.丙东专丂世丈丏丁丂())
        {
                return (string)this.丂丘丘丌七丌丆与丟;
        }
        
        string val_3 = val_4.ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
        this.丂丘丘丌七丌丆与丟 = 0;
        mem[1152921524367622432] = 0;
        return (string)this.丂丘丘丌七丌丆与丟;
    }
    private string 不丗丄东丈专丒一且(int 丕丒丅丈丌丆丝丝丛, int 下丌丒丑丆丘七万丌, int 丑世不与丈上丁丅与)
    {
        int val_10;
        int val_11;
        int val_12;
        val_10 = 下丌丒丑丆丘七万丌;
        val_11 = 丕丒丅丈丌丆丝丝丛;
        if(GameConnect.与丈丘丈上丌丝丝丛() == true)
        {
            goto label_3;
        }
        
        val_12 = val_10;
        if(GameConnect.丟丆丏上丌一丝丟业() == false)
        {
            goto label_6;
        }
        
        label_3:
        val_12 = 丑世不与丈上丁丅与;
        label_6:
        Rilisoft.专丈世丗业不世丗丙 val_3 = new Rilisoft.专丈世丗业不世丗丙(丏世一不与丗丏三不:  val_11, 世不业丌丒七不丄丗:  val_12);
        string val_4 = this.不丁丟丕丞万丑丞丝.丐丏七丌丕丗业且上();
        if(((-1713933432) & 1) != 0)
        {
                return (string)(this.不丁丟丕丞万丑丞丝 == 0) ? "0/0" : this.不丁丟丕丞万丑丞丝;
        }
        
        val_11 = val_11;
        if(GameConnect.与丈丘丈上丌丝丝丛() != true)
        {
                if(GameConnect.丟丆丏上丌一丝丟业() == false)
        {
            goto label_13;
        }
        
        }
        
        val_10 = 丑世不与丈上丁丅与;
        label_13:
        MoonSharp.Interpreter.TablePair val_8 = new MoonSharp.Interpreter.TablePair(key:  val_3.丂丅丂丂万丝丐七东, val:  val_11 + "/"("/") + val_10);
        this.不丁丟丕丞万丑丞丝 = val_8.key;
        mem[1152921524367762176] = val_8.value;
        return (string)(this.不丁丟丕丞万丑丞丝 == 0) ? "0/0" : this.不丁丟丕丞万丑丞丝;
    }
    public AmmoUpdater()
    {
        this.丂丘丘丌七丌丆与丟 = 0;
        mem[1152921524367890544] = 0;
        Rilisoft.专丈世丗业不世丗丙 val_1 = new Rilisoft.专丈世丗业不世丗丙(丏世一不与丗丏三不:  0, 世不业丌丒七不丄丗:  0);
        MoonSharp.Interpreter.TablePair val_2 = new MoonSharp.Interpreter.TablePair(key:  val_1.丂丅丂丂万丝丐七东, val:  "0/0");
        this.不丁丟丕丞万丑丞丝 = val_2.key;
        mem[1152921524367890560] = val_2.value;
    }

}
