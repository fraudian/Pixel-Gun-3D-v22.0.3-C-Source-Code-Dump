using UnityEngine;
private sealed class LobbyCraftController.上世丑丐丄世丏三丗
{
    // Fields
    public Rilisoft.LobbyCraftController 丝且与丝丒丟万丁专;
    public Rilisoft.丏丘七丞丄丙丌丞丁 丑丘丕且丆东丏丘丙;
    public bool 丞丈丌且东丆丅丗万;
    
    // Methods
    public LobbyCraftController.上世丑丐丄世丏三丗()
    {
    
    }
    internal void 且丈丙专世丈业丌丅(object 万且万且丑丗且丌丆, UnityEngine.GameObject 丑且不丕与专丄业丙)
    {
        LobbyItemSlot val_22;
        Rilisoft.丏丘七丞丄丙丌丞丁 val_25;
        var val_27;
        if(万且万且丑丗且丌丆 == null)
        {
                return;
        }
        
        var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.丏丘七丞丄丙丌丞丁.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 万且万且丑丗且丌丆 : 0;
        if(丑且不丕与专丄业丙 == 0)
        {
                return;
        }
        
        val_22 = val_1.丘专上世与丟丝丟丛();
        if((this.丝且与丝丒丟万丁专.下业丝丞丈丂丁丛丑.ContainsKey(key:  val_22)) != false)
        {
                var val_22 = 0;
            val_22 = val_22 + 1;
            this.丝且与丝丒丟万丁专.下业丝丞丈丂丁丛丑.Item[val_1.丘专上世与丟丝丟丛()].Kill();
            val_22 = val_1.丘专上世与丟丝丟丛();
            bool val_9 = this.丝且与丝丒丟万丁专.下业丝丞丈丂丁丛丑.Remove(key:  val_22);
        }
        
        Rilisoft.上丆丕业丘业丈丄丆 val_11 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  丑且不丕与专丄业丙).GetComponent<Rilisoft.上丆丕业丘业丈丄丆>();
        var val_23 = 0;
        val_23 = val_23 + 1;
        val_25 = this.丑丘丕且丆东丏丘丙;
        val_11.Setup(七万上丐一丈丏丏专:  this.丝且与丝丒丟万丁专.丞丄丐世与丁丟东丘(与丄不丌一世东丁丙:  this.丑丘丕且丆东丏丘丙.丘专上世与丟丝丟丛()), 下丅丙一丂丗丅丝七:  val_25);
        var val_24 = 0;
        val_24 = val_24 + 1;
        val_25 = 2;
        val_27 = public System.Void Rilisoft.上丆丕业丘业丈丄丆::set_IsSelected(bool 丙业与丙丗丝不丈东);
        val_11.IsSelected = (this.丞丈丌且东丆丅丗万 == true) ? 1 : 0;
        if(this.丝且与丝丒丟万丁专.丈与丏业丗丗丒七万 == false)
        {
            goto label_38;
        }
        
        if(val_11 != null)
        {
            goto label_45;
        }
        
        label_46:
        label_45:
        var val_25 = 0;
        val_25 = val_25 + 1;
        val_27 = 4;
        goto label_43;
        label_38:
        bool val_18 = val_1.丑丆丑三且丛上且丟();
        if(val_11 != null)
        {
            goto label_45;
        }
        
        goto label_46;
        label_43:
        val_11.IsCrafting = false;
        var val_26 = 0;
        val_26 = val_26 + 1;
        val_11.UpdateView();
        this.丝且与丝丒丟万丁专.下业丝丞丈丂丁丛丑.Add(key:  val_1.丘专上世与丟丝丟丛(), value:  val_11);
    }
    internal bool 丌且丞丄丝下丁丄丝(object 万且万且丑丗且丌丆)
    {
        System.Collections.Generic.Dictionary<LobbyItemSlot, Rilisoft.上丆丕业丘业丈丄丆> val_7;
        System.Collections.Generic.Dictionary<LobbyItemSlot, Rilisoft.上丆丕业丘业丈丄丆> val_8;
        var val_9;
        val_8 = this;
        if(万且万且丑丗且丌丆 != null)
        {
                var val_1 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (Rilisoft.丏丘七丞丄丙丌丞丁.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? 万且万且丑丗且丌丆 : 0;
            val_7 = this.丝且与丝丒丟万丁专.下业丝丞丈丂丁丛丑;
            if((val_7.ContainsKey(key:  val_1.丘专上世与丟丝丟丛())) != false)
        {
                val_8 = this.丝且与丝丒丟万丁专.下业丝丞丈丂丁丛丑;
            var val_6 = (val_8.Item[val_1.丘专上世与丟丝丟丛()] != 0) ? 1 : 0;
            return (bool)val_9;
        }
        
        }
        
        val_9 = 0;
        return (bool)val_9;
    }

}
