using UnityEngine;
internal class 丝丙丕丘丕东不丄业 : 丏七丁丌世丟丁丅丙
{
    // Fields
    private System.Collections.Generic.Dictionary<CategoryNames, bool> 东专业三丟丛丌东丒;
    
    // Methods
    internal 丝丙丕丘丕东不丄业(int 下丝丘丁专丐丅丛丝, 丘上上万专丙万丟丑 上丕丈丞丌丘丅不与, System.Collections.Generic.List<PGCompany.BattlePass.BPChallengeParameter> 丗丟上上丒丐丗丞丙)
    {
        System.Collections.Generic.Dictionary<CategoryNames, System.Boolean> val_1 = new System.Collections.Generic.Dictionary<CategoryNames, System.Boolean>();
        if(val_1 != null)
        {
                val_1.Add(key:  0, value:  false);
            val_1.Add(key:  1, value:  false);
            val_1.Add(key:  2, value:  false);
            val_1.Add(key:  3, value:  false);
            val_1.Add(key:  4, value:  false);
        }
        else
        {
                val_1.Add(key:  0, value:  false);
            val_1.Add(key:  1, value:  false);
            val_1.Add(key:  2, value:  false);
            val_1.Add(key:  3, value:  false);
            val_1.Add(key:  4, value:  false);
        }
        
        val_1.Add(key:  5, value:  false);
        this.东专业三丟丛丌东丒 = val_1;
        goto typeof(丝丙丕丘丕东不丄业).__il2cppRuntimeField_1B8;
    }
    internal override void 丈丗丝丂丝丑上三丌()
    {
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丙丘丒丛丁丂丕万万(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void 丝丙丕丘丕东不丄业::专且丘丐七丂丛丄一(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)));
        this.丈丗丝丂丝丑上三丌();
    }
    private void 专且丘丐七丂丛丄一(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)
    {
        System.Collections.Generic.Dictionary<CategoryNames, System.Boolean> val_13;
        var val_14;
        var val_15;
        var val_16;
        if(this.丈丐丞丐上丑且丕万() == false)
        {
                return;
        }
        
        val_13 = this.业丑丁丆丕丆丂丅万();
        if(val_13.世丑丐丅丆丂丘不丁() == true)
        {
                return;
        }
        
        if(this.丘丛丆丕且丂业世丌() == 1)
        {
            goto label_4;
        }
        
        if(丗丛不丁丑专专丂且 == null)
        {
                return;
        }
        
        val_13 = this.丘丛丆丕且丂业世丌();
        if(val_13 != 丗丛不丁丑专专丂且.丘丛丆丕且丂业世丌())
        {
                return;
        }
        
        val_14 = this;
        val_13 = this.东专业三丟丛丌东丒;
        goto label_7;
        label_4:
        val_14 = this;
        val_13 = this.东专业三丟丛丌东丒;
        if(丗丛不丁丑专专丂且 == null)
        {
            goto label_8;
        }
        
        label_7:
        val_15 = 0;
        goto label_9;
        label_8:
        val_15 = 1;
        label_9:
        if((val_13.ContainsKey(key:  丗丛不丁丑专专丂且.丄丄世七三业丝丛丘())) == false)
        {
                return;
        }
        
        val_13.set_Item(key:  丗丛不丁丑专专丂且.丄丄世七三业丝丛丘(), value:  true);
        val_14 = 1152921505137676288;
        val_16 = null;
        val_16 = null;
        val_13 = 丝丙丕丘丕东不丄业.<>c.<>9__3_0;
        if(val_13 == null)
        {
                System.Func<System.Boolean, System.Boolean> val_11 = null;
            val_13 = val_11;
            val_11 = new System.Func<System.Boolean, System.Boolean>(object:  丝丙丕丘丕东不丄业.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丝丙丕丘丕东不丄业.<>c::专丘世丕丁丌丂不丒(bool 与丘东下丈东丛丂万));
            丝丙丕丘丕东不丄业.<>c.<>9__3_0 = val_13;
        }
        
        if((System.Linq.Enumerable.All<System.Boolean>(source:  val_13.Values, predicate:  val_11)) == false)
        {
                return;
        }
        
        if((public static System.Boolean System.Linq.Enumerable::All<System.Boolean>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate)) != 0)
        {
                if(1152921536389494864 >= 1)
        {
            goto label_22;
        }
        
        }
        
        if(((public static System.Boolean System.Linq.Enumerable::All<System.Boolean>(System.Collections.Generic.IEnumerable<TSource> source, System.Func<TSource, bool> predicate)) != 0) && (1152921536389494864 >= 1))
        {
                label_22:
            this.丑万丞与丆丕上丂丄(丌丒丝东丌下丕丁丅:  1, 丂丟丄一丕丈丛丈东:  true);
        }
        
        this.丐三上丏丈丕且且丞();
    }
    internal override void 丟三上丂与专且丞且(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        this.丟三上丂与专且丞且(不丟丗丏丛丕不丁丌:  不丟丗丏丛丕不丁丌, 丗丛不丁丑专专丂且:  丗丛不丁丑专专丂且);
        if(W8 == 0)
        {
                return;
        }
        
        if(W8 < 1)
        {
                return;
        }
        
        this.丙丆东丁丘丞且丂丑();
    }
    internal override void 丛三丒丄且丘万丟丘(object 不丟丗丏丛丕不丁丌, Rilisoft.业丗丒丞万七三丄七 丗丛不丁丑专专丂且)
    {
        this.丛三丒丄且丘万丟丘(不丟丗丏丛丕不丁丌:  不丟丗丏丛丕不丁丌, 丗丛不丁丑专专丂且:  丗丛不丁丑专专丂且);
        if(W8 == 0)
        {
                return;
        }
        
        if(W8 < 1)
        {
                return;
        }
        
        this.丙丆东丁丘丞且丂丑();
    }
    private void 丙丆东丁丘丞且丂丑()
    {
        var val_4;
        System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.Boolean>, CategoryNames> val_6;
        System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.Boolean>, System.Boolean> val_8;
        val_4 = null;
        val_4 = null;
        val_6 = 丝丙丕丘丕东不丄业.<>c.<>9__6_0;
        if(val_6 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.Boolean>, CategoryNames> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.Boolean>, CategoryNames>(object:  丝丙丕丘丕东不丄业.<>c.__il2cppRuntimeField_static_fields, method:  CategoryNames 丝丙丕丘丕东不丄业.<>c::丑一业丝丆丛丌丒三(System.Collections.Generic.KeyValuePair<CategoryNames, bool> 丈丏万丄丒业丅丒一));
            val_4 = null;
            丝丙丕丘丕东不丄业.<>c.<>9__6_0 = val_6;
        }
        
        val_4 = null;
        val_8 = 丝丙丕丘丕东不丄业.<>c.<>9__6_1;
        if(val_8 == null)
        {
                System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.Boolean>, System.Boolean> val_2 = null;
            val_8 = val_2;
            val_2 = new System.Func<System.Collections.Generic.KeyValuePair<CategoryNames, System.Boolean>, System.Boolean>(object:  丝丙丕丘丕东不丄业.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean 丝丙丕丘丕东不丄业.<>c::业丝丛丟业丝东下专(System.Collections.Generic.KeyValuePair<CategoryNames, bool> 丈丏万丄丒业丅丒一));
            丝丙丕丘丕东不丄业.<>c.<>9__6_1 = val_8;
        }
        
        this.东专业三丟丛丌东丒 = System.Linq.Enumerable.ToDictionary<System.Collections.Generic.KeyValuePair<CategoryNames, System.Boolean>, CategoryNames, System.Boolean>(source:  this.东专业三丟丛丌东丒, keySelector:  val_1, elementSelector:  val_2);
    }
    internal override void 丞上丝丗七丁七丑丘()
    {
        Rilisoft.丞丛七上丕专丏丌丈.丙丄丏丆万丐丅丌丂().丐丂丙丟丁不丘丅专(丙业与丙丗丝不丈东:  new System.EventHandler<Rilisoft.下丝丅世上与丌丗丛>(object:  this, method:  System.Void 丝丙丕丘丕东不丄业::专且丘丐七丂丛丄一(object 不丟丗丏丛丕不丁丌, Rilisoft.下丝丅世上与丌丗丛 丗丛不丁丑专专丂且)));
        this.丞上丝丗七丁七丑丘();
    }

}
