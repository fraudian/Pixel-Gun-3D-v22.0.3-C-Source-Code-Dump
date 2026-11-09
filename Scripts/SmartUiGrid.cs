using UnityEngine;
public class SmartUiGrid : UIGrid
{
    // Fields
    internal UnityEngine.GameObject objectAfterGrid;
    internal float indentValue;
    internal bool changeXAxis;
    
    // Methods
    public void RepositionObjectAfterGrid()
    {
        var val_17;
        float val_18;
        var val_19;
        var val_20;
        float val_24;
        float val_25;
        if(this.objectAfterGrid == 0)
        {
                return;
        }
        
        int val_2 = this.丘丗丟上三丂丗丆丈();
        if(val_2 == 0)
        {
            goto label_4;
        }
        
        val_17 = 0f;
        var val_19 = 0;
        val_18 = 0f;
        label_8:
        var val_18 = 0;
        var val_3 = val_19 + val_18;
        if(val_3 >= val_2)
        {
            goto label_6;
        }
        
        val_18 = val_3 + 1;
        val_19 = val_19 + (val_18 + 1);
        val_18 = val_18 + S0;
        goto label_8;
        label_4:
        val_19 = this.objectAfterGrid.transform;
        if(this.changeXAxis == false)
        {
            goto label_10;
        }
        
        if(this.transform != null)
        {
            goto label_24;
        }
        
        label_25:
        label_24:
        UnityEngine.Vector3 val_8 = 0.localPosition;
        val_20 = val_8.x;
        UnityEngine.Vector3 val_10 = this.transform.localPosition;
        val_24 = this.indentValue;
        goto label_13;
        label_6:
        val_25 = val_18 + S0;
        val_19 = this.objectAfterGrid.transform;
        if(this.changeXAxis == false)
        {
            goto label_16;
        }
        
        if(this.transform != null)
        {
            goto label_21;
        }
        
        label_22:
        label_21:
        UnityEngine.Vector3 val_13 = 0.localPosition;
        val_20 = val_13.x;
        UnityEngine.Vector3 val_15 = this.transform.localPosition;
        val_24 = this.indentValue;
        val_15.y = val_15.y - val_25;
        label_13:
        val_15.y = val_15.y - val_24;
        val_19.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        return;
        label_16:
        if(this.objectAfterGrid.transform != null)
        {
            goto label_21;
        }
        
        goto label_22;
        label_10:
        if(this.objectAfterGrid.transform != null)
        {
            goto label_24;
        }
        
        goto label_25;
    }
    internal UnityEngine.GameObject 东丈丌万丒世且丙且(UnityEngine.GameObject 丒业丆丆丛下丈世专)
    {
        return 不丌丂丁丄一与丆丙.丗上世丑丘业丆七一(丈东丘丏与丌东东下:  this.gameObject, 丑且不丕与专丄业丙:  丒业丆丆丛下丈世专);
    }
    internal void 三丐万下上下丝世丁(UnityEngine.GameObject 业且下丒丈丅东七专)
    {
        this.objectAfterGrid = 业且下丒丈丅东七专;
    }
    internal int 三丅丝丅丅业丞万三()
    {
        System.Collections.Generic.List<UnityEngine.Transform> val_1 = this.GetChildList();
        if(val_1 != null)
        {
                return val_1.Count;
        }
        
        return val_1.Count;
    }
    internal int 丘丗丟上三丂丗丆丈()
    {
        var val_8;
        List.Enumerator<T> val_3 = 丞东丑专丛丆丄丝世.专丏三丘丟丑与业丗(丈东丘丏与丌东东下:  this.transform, 丕丛丂丞世丁丐丌专:  false, 丛丅丘一丏丙且丌上:  true).GetEnumerator();
        val_8 = 0;
        goto label_4;
        label_7:
        val_8 = val_8 + 0.丐丏七丌丕丗业且上().gameObject.activeSelf;
        label_4:
        if((689381880 & 1) != 0)
        {
            goto label_7;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (int)val_8;
    }
    public SmartUiGrid()
    {
    
    }

}
