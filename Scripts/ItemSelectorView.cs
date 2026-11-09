using UnityEngine;
internal sealed class ItemSelectorView : SelectableButtonController
{
    // Fields
    private MiniPoolMonoBehaviour buttonsPool;
    private System.Collections.Generic.List<ItemSelectableButton> 下丏专丒丑一丘东丁;
    private System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 专丙丌一与业三专丛;
    
    // Properties
    internal System.Collections.Generic.List<ItemSelectableButton> 七上世丘七东丆下下 { get; }
    internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丝丈不丗丐不丙丟丁 { get; }
    internal ItemSelectableButton 丅丘丗不丞且三丘丆 { get; }
    internal PGCompany.三东丏不丗世丅丌丄 丗丅丅丁与丗丂丗业 { get; }
    internal PGCompany.丗丟丄丈东丝丕丄世 专一丟丆专丟一世一 { get; }
    
    // Methods
    internal System.Collections.Generic.List<ItemSelectableButton> 丘丑丘丕丁丌丏万不()
    {
        return (System.Collections.Generic.List<ItemSelectableButton>)this.下丏专丒丑一丘东丁;
    }
    internal System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丑丒丏三丆丗专丞丗()
    {
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_2 = this.专丙丌一与业三专丛;
        if(val_2 != null)
        {
                return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)val_2;
        }
        
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_1 = null;
        val_2 = val_1;
        val_1 = new System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>();
        return (System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄>)val_2;
    }
    internal ItemSelectableButton 丝丒三世丘丗丐丆专()
    {
        var val_3;
        bool val_1 = UnityEngine.Object.op_Inequality(x:  137121792, y:  0);
        val_3 = 0;
        if(val_1 == false)
        {
                return (ItemSelectableButton)val_3;
        }
        
        if(val_1 != false)
        {
                var val_2 = (val_1 == null) ? (val_1) : 0;
            return (ItemSelectableButton)val_3;
        }
        
        val_3 = 0;
        return (ItemSelectableButton)val_3;
    }
    internal PGCompany.三东丏不丗世丅丌丄 东丞丕且丁丏东与下()
    {
        if(this.丝丒三世丘丗丐丆专() != null)
        {
                return (PGCompany.三东丏不丗世丅丌丄)val_1.丕丟丈丙丟丅丟丑七;
        }
        
        return (PGCompany.三东丏不丗世丅丌丄)val_1.丕丟丈丙丟丅丟丑七;
    }
    internal PGCompany.丗丟丄丈东丝丕丄世 丕丟丐丈丐丄丌三丐()
    {
        if(this.丝丒三世丘丗丐丆专() == 0)
        {
                return 0;
        }
        
        PGCompany.世东三上七丂丌下丑 val_3 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世();
        ItemSelectableButton val_4 = this.丝丒三世丘丗丐丆专();
        if(val_3 != null)
        {
                return val_3.一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_4.丕丟丈丙丟丅丟丑七);
        }
        
        return val_3.一丌世丑丄东丞丘三(丈丄不七三万丄丁不:  val_4.丕丟丈丙丟丅丟丑七);
    }
    internal void 丈且东丑丂且万丒丅(System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> 丑七不与丛丆一丂丞, PGCompany.三东丏不丗世丅丌丄 丛丗七丅下丞丗且丐)
    {
        PGCompany.三东丏不丗世丅丌丄 val_4;
        System.Collections.Generic.List<PGCompany.三东丏不丗世丅丌丄> val_5;
        val_4 = 丛丗七丅下丞丗且丐;
        val_5 = 丑七不与丛丆一丂丞;
        this.专丙丌一与业三专丛 = val_5;
        this.业丞丗丈东专丂不丛();
        List.Enumerator<T> val_1 = this.GetEnumerator();
        label_6:
        if((325328552 & 1) != 0)
        {
                if(((0.丐丏七丌丕丗业且上() == null) || (null != null)) || ((val_5.Equals(丘丛丏丘丝七世七丅:  val_4)) == false))
        {
            goto label_6;
        }
        
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    private void 业丞丗丈东专丂不丛()
    {
        var val_3;
        var val_8;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.buttonsPool.example, 丏业丟一东丂东丘丛:  false);
        this.丞七丐三丑东且丈下();
        if(this.专丙丌一与业三专丛 == null)
        {
                return;
        }
        
        List.Enumerator<T> val_1 = this.专丙丌一与业三专丛.GetEnumerator();
        label_13:
        if((325487616 & 1) == 0)
        {
            goto label_5;
        }
        
        ItemSelectableButton val_5 = this.buttonsPool.Get<ItemSelectableButton>();
        val_5.transform.SetAsLastSibling();
        val_5.Reset();
        val_5.丈且东丑丂且万丒丅(丈丄不七三万丄丁不:  val_3.丐丏七丌丕丗业且上());
        this.AddNewButton(丟丂丄丕下业丗丛丂:  val_5);
        this.下丏专丒丑一丘东丁.Add(item:  val_5);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  val_5, 丏业丟一东丂东丘丛:  true);
        goto label_13;
        label_5:
        val_8 = public System.Void List.Enumerator<PGCompany.三东丏不丗世丅丌丄>::Dispose();
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  false);
        if(val_3 != 0)
        {
                val_8 = 0;
            val_3.Reposition();
        }
        
        if(val_3 == 0)
        {
                return;
        }
    
    }
    internal void 丞七丐三丑东且丈下()
    {
        List.Enumerator<T> val_1 = this.下丏专丒丑一丘东丁.GetEnumerator();
        label_4:
        if((325653928 & 1) == 0)
        {
            goto label_2;
        }
        
        this.buttonsPool.Return(万且万且丑丗且丌丆:  0.丐丏七丌丕丗业且上());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.下丏专丒丑一丘东丁.Clear();
        if(this.下丏专丒丑一丘东丁 != null)
        {
                this.下丏专丒丑一丘东丁.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        }
        
        this.下丏专丒丑一丘东丁.Clear();
        mem[1152921539292251432] = 0;
    }
    public ItemSelectorView()
    {
        this.下丏专丒丑一丘东丁 = new System.Collections.Generic.List<ItemSelectableButton>();
    }

}
