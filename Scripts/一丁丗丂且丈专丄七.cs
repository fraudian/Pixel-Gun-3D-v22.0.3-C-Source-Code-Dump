using UnityEngine;
public class 一丁丗丂且丈专丄七
{
    // Fields
    internal System.Collections.Generic.List<OfferItemWithProbability> offers;
    
    // Methods
    internal Rilisoft.OfferItem 七七丈且丄丞世不丁()
    {
        if((this.七七丈且丄丞世不丁(丄丐丁三东东且丄丕:  this.offers)) != null)
        {
                return (Rilisoft.OfferItem)val_1.offerItem;
        }
        
        return (Rilisoft.OfferItem)val_1.offerItem;
    }
    internal System.Collections.Generic.List<Rilisoft.OfferItem> 丙丐不与丏丁下丑七(int 丌丒丝东丌下丕丁丅)
    {
        return this.丙丐不与丏丁下丑七(丄丐丁三东东且丄丕:  this.offers, 丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅);
    }
    internal System.Collections.Generic.List<Rilisoft.OfferItem> 世与丛丏上丞三丐与(int 丌丒丝东丌下丕丁丅)
    {
        var val_5;
        System.Func<OfferItemWithProbability, Rilisoft.OfferItem> val_7;
        val_5 = null;
        val_5 = null;
        val_7 = 一丁丗丂且丈专丄七.<>c.<>9__3_0;
        if(val_7 != null)
        {
                return System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<OfferItemWithProbability, Rilisoft.OfferItem>(source:  this.丏丛不上丄丘丌丑丐(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅), selector:  System.Func<OfferItemWithProbability, Rilisoft.OfferItem> val_2 = null));
        }
        
        val_7 = val_2;
        val_2 = new System.Func<OfferItemWithProbability, Rilisoft.OfferItem>(object:  一丁丗丂且丈专丄七.<>c.__il2cppRuntimeField_static_fields, method:  Rilisoft.OfferItem 一丁丗丂且丈专丄七.<>c::专下丝丕下丁丝三丑(OfferItemWithProbability 三丟东丕丄丄下下丑));
        一丁丗丂且丈专丄七.<>c.<>9__3_0 = val_7;
        return System.Linq.Enumerable.ToList<Rilisoft.OfferItem>(source:  System.Linq.Enumerable.Select<OfferItemWithProbability, Rilisoft.OfferItem>(source:  this.丏丛不上丄丘丌丑丐(丌丒丝东丌下丕丁丅:  丌丒丝东丌下丕丁丅), selector:  val_2));
    }
    internal System.Collections.Generic.List<Rilisoft.OfferItem> 丙丐不与丏丁下丑七(int 东丂万丌丑上丝丅丝, int 专丗不丏下丑万丞一)
    {
        System.Collections.Generic.List<OfferItemWithProbability> val_1 = this.丏丛不上丄丘丌丑丐(丌丒丝东丌下丕丁丅:  专丗不丏下丑万丞一);
        System.Collections.Generic.List<Rilisoft.OfferItem> val_2 = new System.Collections.Generic.List<Rilisoft.OfferItem>();
        List.Enumerator<T> val_3 = val_1.GetEnumerator();
        label_5:
        if(((-603598600) & 1) == 0)
        {
            goto label_2;
        }
        
        val_2.Add(item:  0.丐丏七丌丕丗业且上());
        goto label_5;
        label_2:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_2.AddRange(collection:  this.丙丐不与丏丁下丑七(丄丐丁三东东且丄丕:  val_1, 丌丒丝东丌下丕丁丅:  东丂万丌丑上丝丅丝 - 专丗不丏下丑万丞一));
        return val_2;
    }
    private OfferItemWithProbability 七七丈且丄丞世不丁(System.Collections.Generic.List<OfferItemWithProbability> 丄丐丁三东东且丄丕)
    {
        var val_7;
        float val_8;
        var val_9;
        var val_10;
        List.Enumerator<T> val_1 = 丄丐丁三东东且丄丕.GetEnumerator();
        val_7 = 1152921538362963584;
        val_8 = 0f;
        goto label_2;
        label_4:
        string val_2 = 0.丐丏七丌丕丗业且上();
        val_8 = val_8 + val_2.m_stringLength;
        label_2:
        if(((-603451768) & 1) != 0)
        {
            goto label_4;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        if(val_8 > 0f)
        {
                float val_7 = 0f;
            val_8 = UnityEngine.Random.Range(min:  0f, max:  val_8);
            val_9 = 0;
            if(val_8 > 0f)
        {
                do
        {
            val_9 = 1;
            val_7 = 丄丐丁三东东且丄丕.Item[1];
            val_7 = val_7 + val_4.probability;
        }
        while(val_7 < 0);
        
        }
        
            if(val_9 < 丄丐丁三东东且丄丕.Count)
        {
                OfferItemWithProbability val_6 = 丄丐丁三东东且丄丕.Item[1];
            return (OfferItemWithProbability)val_10;
        }
        
        }
        
        val_10 = 0;
        return (OfferItemWithProbability)val_10;
    }
    private System.Collections.Generic.List<Rilisoft.OfferItem> 丙丐不与丏丁下丑七(System.Collections.Generic.List<OfferItemWithProbability> 丄丐丁三东东且丄丕, int 丌丒丝东丌下丕丁丅)
    {
        int val_4 = 丌丒丝东丌下丕丁丅;
        System.Collections.Generic.List<Rilisoft.OfferItem> val_1 = new System.Collections.Generic.List<Rilisoft.OfferItem>(capacity:  val_4 = 丌丒丝东丌下丕丁丅);
        if(val_4 < 1)
        {
                return val_1;
        }
        
        int val_2 = val_4 + 1;
        do
        {
            OfferItemWithProbability val_3 = val_1.七七丈且丄丞世不丁(丄丐丁三东东且丄丕:  丄丐丁三东东且丄丕);
            val_4 = val_3.offerItem;
            val_1.Add(item:  val_4);
            val_2 = val_2 - 1;
        }
        while(val_2 > 1);
        
        return val_1;
    }
    private System.Collections.Generic.List<OfferItemWithProbability> 丏丛不上丄丘丌丑丐(int 丌丒丝东丌下丕丁丅)
    {
        int val_6 = 丌丒丝东丌下丕丁丅;
        System.Collections.Generic.List<OfferItemWithProbability> val_1 = new System.Collections.Generic.List<OfferItemWithProbability>(capacity:  val_6 = 丌丒丝东丌下丕丁丅);
        System.Collections.Generic.List<TSource> val_2 = System.Linq.Enumerable.ToList<OfferItemWithProbability>(source:  this.offers);
        if(val_6 < 1)
        {
                return val_1;
        }
        
        int val_3 = val_6 + 1;
        do
        {
            val_6 = val_2.七七丈且丄丞世不丁(丄丐丁三东东且丄丕:  val_2);
            val_1.Add(item:  val_6);
            bool val_5 = val_2.Remove(item:  val_6);
            val_3 = val_3 - 1;
        }
        while(val_3 > 1);
        
        return val_1;
    }
    public 一丁丗丂且丈专丄七()
    {
        this.offers = new System.Collections.Generic.List<OfferItemWithProbability>();
    }

}
