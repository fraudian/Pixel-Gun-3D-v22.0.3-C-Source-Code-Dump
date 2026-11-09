using UnityEngine;
private sealed class GiftScroll.世东且世万业丟丂丄 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public GiftScroll 丝且与丝丒丟万丁专;
    private GiftScroll.丐丐七丈丅丐三且丆 丄丌丂东丘丗一万且;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GiftScroll.世东且世万业丟丂丄(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        int val_22;
        var val_23;
        GiftBannerWindow val_24;
        var val_25;
        var val_26;
        System.Func<SlotInfo, System.Boolean> val_28;
        var val_29;
        System.Func<SlotInfo, System.Int32> val_31;
        var val_32;
        System.Func<SlotInfo, System.Boolean> val_33;
        if(this.丗丏丅丕丆世丁专丟 != 1)
        {
                val_22 = 0;
            if(this.丗丏丅丕丆世丁专丟 != 0)
        {
                return (bool)val_22;
        }
        
            this.丗丏丅丕丆世丁专丟 = 0;
            this.丄丌丂东丘丗一万且 = new GiftScroll.丐丐七丈丅丐三且丆();
        }
        else
        {
                this.丗丏丅丕丆世丁专丟 = 0;
        }
        
        val_23 = null;
        val_23 = null;
        val_24 = GiftBannerWindow.丄丘七三上丕世丞业;
        if(val_24 == 0)
        {
                val_22 = 1;
            this.丒上七丌业七丟与丐 = 0;
            this.丗丏丅丕丆世丁专丟 = val_22;
            return (bool)val_22;
        }
        
        if(this.丝且与丝丒丟万丁专.wrapScript == 0)
        {
                this.丝且与丝丒丟万丁专.wrapScript = this.丝且与丝丒丟万丁专.parentButton.GetComponent<UIWrapContent>();
        }
        
        val_25 = null;
        val_25 = null;
        val_26 = null;
        val_26 = null;
        val_28 = GiftScroll.<>c.<>9__28_0;
        if(val_28 == null)
        {
                System.Func<SlotInfo, System.Boolean> val_6 = null;
            val_28 = val_6;
            val_6 = new System.Func<SlotInfo, System.Boolean>(object:  GiftScroll.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean GiftScroll.<>c::万丆上丕且丂丆且丞(SlotInfo 丏丛与丅丛丌万专丌));
            GiftScroll.<>c.<>9__28_0 = val_28;
        }
        
        val_29 = null;
        val_29 = null;
        val_31 = GiftScroll.<>c.<>9__28_1;
        if(val_31 == null)
        {
                System.Func<SlotInfo, System.Int32> val_8 = null;
            val_31 = val_8;
            val_8 = new System.Func<SlotInfo, System.Int32>(object:  GiftScroll.<>c.__il2cppRuntimeField_static_fields, method:  System.Int32 GiftScroll.<>c::丅丄不三与世三丅东(SlotInfo 七丏丄丅丌业与且丙));
            GiftScroll.<>c.<>9__28_1 = val_31;
        }
        
        val_24 = System.Linq.Enumerable.ToList<SlotInfo>(source:  System.Linq.Enumerable.OrderBy<SlotInfo, System.Int32>(source:  System.Linq.Enumerable.Where<SlotInfo>(source:  GiftController.丆丕丝丒不丙且丐丗.Slots, predicate:  val_6), keySelector:  val_8));
        this.丝且与丝丒丟万丁专.下下丝世与世丒丂万(三不专丕丞丄丁丛东:  val_24);
        val_32 = 0;
        goto label_28;
        label_46:
        this.丄丌丂东丘丗一万且.丅丈上一丘丅专丆丘 = this.丝且与丝丒丟万丁专.listButton.Item[0];
        val_33 = this.丄丌丂东丘丗一万且.丙丕丗万丑丗丈丟专;
        if(val_33 == null)
        {
                System.Func<SlotInfo, System.Boolean> val_12 = null;
            val_33 = val_12;
            val_12 = new System.Func<SlotInfo, System.Boolean>(object:  this.丄丌丂东丘丗一万且, method:  System.Boolean GiftScroll.丐丐七丈丅丐三且丆::一丝与一丝丗丁专丁(SlotInfo 丐三丞七丝丅不万丛));
            this.丄丌丂东丘丗一万且.丙丕丗万丑丗丈丟专 = val_33;
        }
        
        SlotInfo val_13 = System.Linq.Enumerable.FirstOrDefault<SlotInfo>(source:  val_24, predicate:  val_12);
        if(val_13 != null)
        {
                this.丄丌丂东丘丗一万且.丅丈上一丘丅专丆丘.世与东丗世三丞丞不(丘丌丛业丄丘丗世丐:  val_13);
            this.丄丌丂东丘丗一万且.丅丈上一丘丅专丆丘.gameObject.name = val_13.PositionInScroll.ToString(format:  "000")(val_13.PositionInScroll.ToString(format:  "000")) + "_" + val_13.gift.Id;
            this.丄丌丂东丘丗一万且.丅丈上一丘丅专丆丘.transform.SetSiblingIndex(index:  val_13.PositionInScroll);
            bool val_20 = val_24.Remove(item:  val_13);
        }
        
        val_32 = 1;
        label_28:
        if(val_32 < this.丝且与丝丒丟万丁专.listButton.Count)
        {
            goto label_46;
        }
        
        this.丝且与丝丒丟万丁专.Sort(三丅万丒与丑且世业:  this.丝且与丝丒丟万丁专.与丌丁上丆东三丗丞);
        val_22 = 0;
        return (bool)val_22;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
