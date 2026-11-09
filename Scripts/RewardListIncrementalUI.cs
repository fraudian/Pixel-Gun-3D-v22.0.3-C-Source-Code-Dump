using UnityEngine;
internal sealed class RewardListIncrementalUI : PGBehaviour
{
    // Fields
    internal ItemRewardView itemViewExample;
    private MiniPoolMonoBehaviour 万上万丛丌丟丗上丂;
    private WidgetLayout 丏专丌万与上丆丈三;
    private UIGrid 丝三不丑丏丘丒丂丗;
    private System.Collections.Generic.List<ItemRewardView> 丟丟且丄丑丝丑丒丅;
    
    // Methods
    private void 丘上丐世丆丑且丞丒()
    {
        if(this.万上万丛丌丟丗上丂 == 0)
        {
                this.万上万丛丌丟丗上丂 = this.GetComponent<MiniPoolMonoBehaviour>();
            this.itemViewExample.gameObject.SetActive(value:  false);
            this.万上万丛丌丟丗上丂.SetupExample(丗丝丘丒丅丄专上丗:  this.itemViewExample);
        }
        
        if(this.丏专丌万与上丆丈三 == 0)
        {
                this.丏专丌万与上丆丈三 = this.GetComponent<WidgetLayout>();
        }
        
        if(this.丝三不丑丏丘丒丂丗 != 0)
        {
                return;
        }
        
        this.丝三不丑丏丘丒丂丗 = this.GetComponent<UIGrid>();
    }
    internal void 业丏丗丐丂业东丂丗(PGCompany.丄与丘丑业专丞七丅 丈丄不七三万丄丁不)
    {
        this.丘上丐世丆丑且丞丒();
        ItemRewardView val_1 = this.万上万丛丌丟丗上丂.Get<ItemRewardView>();
        this.丟丟且丄丑丝丑丒丅.Add(item:  val_1);
        if(val_1 != null)
        {
                val_1.gameObject.SetActive(value:  true);
            if(this.丏专丌万与上丆丈三 != null)
        {
                this.丏专丌万与上丆丈三.AddElement(丅丆东丏丙丝丅丆丟:  val_1);
            if(this.丏专丌万与上丆丈三 != null)
        {
                this.丏专丌万与上丆丈三.Reposition();
        }
        
        }
        
            if((UnityEngine.Object.op_Implicit(exists:  this.丝三不丑丏丘丒丂丗)) == false)
        {
                return;
        }
        
            this.丝三不丑丏丘丒丂丗.repositionNow = true;
            return;
        }
    
    }
    internal void 丄一且丄丑专丙丗世()
    {
        List.Enumerator<T> val_1 = this.丟丟且丄丑丝丑丒丅.GetEnumerator();
        label_4:
        if(((-1228783848) & 1) == 0)
        {
            goto label_2;
        }
        
        this.万上万丛丌丟丗上丂.Return(万且万且丑丗且丌丆:  0.丐丏七丌丕丗业且上());
        goto label_4;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(this.丏专丌万与上丆丈三 != null)
        {
                this.丏专丌万与上丆丈三.RemoveAll(丏丞丙丌丆丙万丂丛:  false);
        }
        
        this.丟丟且丄丑丝丑丒丅.Clear();
    }
    public RewardListIncrementalUI()
    {
        this.丟丟且丄丑丝丑丒丅 = new System.Collections.Generic.List<ItemRewardView>();
    }

}
