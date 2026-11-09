using UnityEngine;
public class GuiPrefabApplyer : GuiApplyer
{
    // Fields
    internal UnityEngine.GameObject 世与丐丌丄丅上一与;
    private string 一丅丗丄丐丄世万丏;
    
    // Methods
    internal override bool 三业丒丑丂三丕上丛()
    {
        var val_2;
        if(this.七丆业丗不业丙丏三() != false)
        {
                this.且丗丘丈丝丏东丆丆();
            this.世与丐丌丄丅上一与 = X20;
            this.丞下业丛不丂下东丑();
            val_2 = 1;
            return (bool)val_2;
        }
        
        val_2 = 0;
        return (bool)val_2;
    }
    internal UnityEngine.GameObject 专丄下丆丛丂丅七丗()
    {
        if(this.transform.childCount == 0)
        {
                return 0;
        }
        
        UnityEngine.Transform val_4 = this.transform.GetChild(index:  0);
        if(val_4 != null)
        {
                return val_4.gameObject;
        }
        
        return val_4.gameObject;
    }
    internal string 不丛丗丑丐丂丙丟丅()
    {
        int val_2 = this.transform.childCount;
        return 0;
    }
    internal void 丆东七丂专业下与三(UnityEngine.GameObject 丑且不丕与专丄业丙)
    {
        string val_5;
        this.且丗丘丈丝丏东丆丆();
        if(丑且不丕与专丄业丙 != 0)
        {
                this.世与丐丌丄丅上一与 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丑且不丕与专丄业丙, parent:  this.transform);
            string val_4 = 丑且不丕与专丄业丙.name;
        }
        else
        {
                val_5 = "";
        }
        
        this.一丅丗丄丐丄世万丏 = val_5;
        this.丞下业丛不丂下东丑();
    }
    protected override void 不丏丌丟丑丄丟上丝()
    {
        if(137121792 == 0)
        {
                this.一丅丗丄丐丄世万丏 = "";
            return;
        }
        
        if((System.String.IsNullOrEmpty(value:  this.一丅丗丄丐丄世万丏)) == true)
        {
            goto label_5;
        }
        
        UnityEngine.Transform val_3 = this.transform;
        if(val_3.childCount == 0)
        {
            goto label_7;
        }
        
        label_5:
        if(this.transform.childCount < 1)
        {
                return;
        }
        
        if((System.String.op_Inequality(a:  this.一丅丗丄丐丄世万丏, b:  this.transform.GetChild(index:  0).name)) == false)
        {
                return;
        }
        
        this.一丅丗丄丐丄世万丏 = this.transform.GetChild(index:  0).name;
        UnityEngine.Transform val_15 = this.transform.GetChild(index:  0);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  val_15);
        if(val_15 != null)
        {
            goto label_19;
        }
        
        label_20:
        label_19:
        this = ???;
        goto typeof(UnityEngine.Transform).__il2cppRuntimeField_298;
        label_7:
        this.一丅丗丄丐丄世万丏 = "";
        if(val_3 != null)
        {
            goto label_19;
        }
        
        goto label_20;
    }
    private void 且丗丘丈丝丏东丆丆()
    {
        var val_7;
        if(this.世与丐丌丄丅上一与 != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.世与丐丌丄丅上一与);
        }
        
        val_7 = 丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform, 丕丛丂丞世丁丐丌专:  false, 丛丅丘一丏丙且丌上:  true);
        List.Enumerator<T> val_4 = val_7.GetEnumerator();
        label_13:
        if(((-1106828008) & 1) == 0)
        {
            goto label_9;
        }
        
        UnityEngine.Object.Destroy(obj:  0.丐丏七丌丕丗业且上().gameObject);
        goto label_13;
        label_9:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 丞下业丛不丂下东丑()
    {
        if(this.世与丐丌丄丅上一与 == 0)
        {
                return;
        }
        
        this.世与丐丌丄丅上一与.name = this.世与丐丌丄丅上一与.name.Replace(oldValue:  "(Clone)", newValue:  "");
        this.世与丐丌丄丅上一与.transform.SetParent(p:  this.transform);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  this.世与丐丌丄丅上一与.transform);
        丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  this.世与丐丌丄丅上一与, 不东丛三丂丌丑专丆:  this.transform.gameObject.layer, 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
    }
    public GuiPrefabApplyer()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
