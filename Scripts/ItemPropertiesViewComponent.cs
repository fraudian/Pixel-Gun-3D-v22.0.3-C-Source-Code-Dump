using UnityEngine;
internal sealed class ItemPropertiesViewComponent : ItemViewComponent
{
    // Fields
    private PGCompany.ItemPropertiesLayout efficencyPropertyUI;
    public System.Collections.Generic.List<PGCompany.丕万丁不丁丑东丌七> propertiesToShow;
    
    // Methods
    internal override void 丝一丅丆三东丂丞七()
    {
        UnityEngine.GameObject val_4;
        var val_5;
        UnityEngine.GameObject val_6;
        System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂> val_1 = this.世丙万丞上与一丌丅();
        if(val_1 != null)
        {
                this.efficencyPropertyUI.丈且东丑丂且万丒丅(丌不七丗丌丏丄丐丞:  this.propertiesToShow, 丙丑丆上不丒上丕丛:  val_1);
            val_4 = this.gameObject;
            val_5 = 1;
            val_6 = val_4;
        }
        else
        {
                val_4 = this.gameObject;
            val_6 = val_4;
            val_5 = 0;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  false);
    }
    private System.Collections.Generic.List<PGCompany.丗丒下万与下丂万丂> 世丙万丞上与一丌丅()
    {
        var val_3 = this;
        if(45984 == 0)
        {
                return 0;
        }
        
        if(true == 0)
        {
                return 0;
        }
        
        if(1027 == null)
        {
                return 45984.世丙万丞上与一丌丅(丆丗万丛丞丈三丗丅:  false);
        }
        
        if(1027 == null)
        {
                return 45984.世丙万丞上与一丌丅();
        }
        
        var val_2 = (((0 + (PGCompany.世丒丗丅丛丕不万丂.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 45984 : 0;
        return 0;
    }
    public ItemPropertiesViewComponent()
    {
        val_1 = new PGBehaviour();
    }

}
