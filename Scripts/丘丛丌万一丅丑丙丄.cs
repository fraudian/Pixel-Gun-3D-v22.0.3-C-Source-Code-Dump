using UnityEngine;
public class 丘丛丌万一丅丑丙丄
{
    // Fields
    private float 丆丆与丄万丐丘丁丛;
    private System.Collections.Generic.List<丘丛丌万一丅丑丙丄.丗世业丘下丐丞一世> 七丌万七丏东丂丑丕;
    private System.Collections.Generic.List<丘丛丌万一丅丑丙丄.丗世业丘下丐丞一世> 东丒丑世下丘不丕丝;
    private System.Collections.Generic.List<string> 丌丘丙丛与三与丛专;
    
    // Methods
    internal void 上三丝下丅一下三三()
    {
        float val_27;
        var val_28;
        var val_29;
        var val_30;
        string val_31;
        float val_32;
        var val_33;
        var val_34;
        if(丅丒丗丑丒丙丛不丆.丘丌丄丗专世专万东() == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丆丁丑丟且丅世丝业() == null)
        {
                return;
        }
        
        val_27 = this.丆丆与丄万丐丘丁丛;
        float val_5 = UnityEngine.Time.time;
        if(val_27 >= 0)
        {
                return;
        }
        
        this.东丒丑世下丘不丕丝.Clear();
        this.东丒丑世下丘不丕丝.AddRange(collection:  this.七丌万七丏东丂丑丕);
        this.七丌万七丏东丂丑丕.Clear();
        val_28 = 0;
        val_27 = 10f;
        goto label_15;
        label_39:
        val_29 = 0;
        goto label_16;
        label_25:
        val_29 = 1;
        label_16:
        if(val_29 >= this.东丒丑世下丘不丕丝.Count)
        {
            goto label_18;
        }
        
        丗世业丘下丐丞一世 val_7 = this.东丒丑世下丘不丕丝.Item[1];
        if((System.String.op_Equality(a:  val_7.万丛与丒丑丈七东丐, b:  丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丆丁丑丟且丅世丝业()[0])) == false)
        {
            goto label_25;
        }
        
        丗世业丘下丐丞一世 val_11 = this.东丒丑世下丘不丕丝.Item[1];
        val_30 = public System.Void System.Collections.Generic.List<丗世业丘下丐丞一世>::Add(丗世业丘下丐丞一世 item);
        val_31 = val_11.万丛与丒丑丈七东丐;
        val_32 = val_11.丅丘丟丄丞丁丐下一;
        goto label_28;
        label_18:
        val_30 = public System.Void System.Collections.Generic.List<丗世业丘下丐丞一世>::Add(丗世业丘下丐丞一世 item);
        val_32 = UnityEngine.Time.time + val_27;
        val_31 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丆丁丑丟且丅世丝业()[0];
        label_28:
        this.七丌万七丏东丂丑丕.Add(item:  new 丗世业丘下丐丞一世() {万丛与丒丑丈七东丐 = val_31, 丅丘丟丄丞丁丐下一 = val_32});
        val_28 = 1;
        label_15:
        System.String[] val_17 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丆丁丑丟且丅世丝业();
        if(val_28 < val_17.Length)
        {
            goto label_39;
        }
        
        this.丌丘丙丛与三与丛专.Clear();
        val_33 = 0;
        val_34 = 0;
        goto label_41;
        label_48:
        丗世业丘下丐丞一世 val_18 = this.东丒丑世下丘不丕丝.Item[0];
        val_27 = val_18.丅丘丟丄丞丁丐下一;
        if(UnityEngine.Time.time < 0)
        {
                丗世业丘下丐丞一世 val_20 = this.东丒丑世下丘不丕丝.Item[0];
            this.丌丘丙丛与三与丛专.Add(item:  val_20.万丛与丒丑丈七东丐);
        }
        else
        {
                val_34 = 1;
        }
        
        val_33 = 1;
        label_41:
        if(val_33 < this.东丒丑世下丘不丕丝.Count)
        {
            goto label_48;
        }
        
        if((val_34 & 1) == 0)
        {
                return;
        }
        
        float val_22 = UnityEngine.Time.time;
        val_22 = val_22 + 1f;
        this.丆丆与丄万丐丘丁丛 = val_22;
        if(this.丌丘丙丛与三与丛专.Count != 0)
        {
                丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丟丘丂丝丈丐业业丝(丙丘东丏三丆丄丁丟:  this.丌丘丙丛与三与丛专.ToArray());
            return;
        }
        
        丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丕业三一丙丘下上();
    }
    public 丘丛丌万一丅丑丙丄()
    {
        this.七丌万七丏东丂丑丕 = new System.Collections.Generic.List<丗世业丘下丐丞一世>();
        this.东丒丑世下丘不丕丝 = new System.Collections.Generic.List<丗世业丘下丐丞一世>();
        this.丌丘丙丛与三与丛专 = new System.Collections.Generic.List<System.String>();
    }

}
