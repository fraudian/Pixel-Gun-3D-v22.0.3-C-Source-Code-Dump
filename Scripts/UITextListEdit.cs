using UnityEngine;
public class UITextListEdit : MonoBehaviour
{
    // Fields
    public int maxEntries;
    public float maxHeight;
    public float maxWidth;
    protected System.Collections.Generic.List<UITextListEdit.丐三丄丗丕丝丏丌丐> 丟丁丙丂世丏丕丘上;
    protected float 丈世丙业业七丟不丒;
    protected bool 东一且三丑丑丏丗七;
    protected char[] 丞丌下丆下丈丏丂丛;
    protected int 且丙丈东丝丝丟业丅;
    public UITextListEdit.丄丏东专与世三丂一 style;
    public bool supportScrollWheel;
    public UILabel textLabel;
    
    // Methods
    public void Clear()
    {
        this.丟丁丙丂世丏丕丘上.Clear();
        this.丘不丕不丒世东世且();
    }
    public void Add(string 丕丗丘丑丛与丑业丒)
    {
        this.业丏丗丐丂业东丂丗(丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒, 万丌与丁东且一丘上:  true);
    }
    protected void 业丏丗丐丂业东丂丗(string 丕丗丘丑丛与丑业丒, bool 万丌与丁东且一丘上)
    {
        丐三丄丗丕丝丏丌丐 val_9;
        System.Collections.Generic.List<丐三丄丗丕丝丏丌丐> val_10;
        UILabel val_11;
        if(this.丟丁丙丂世丏丕丘上.Count >= this.maxEntries)
        {
            goto label_2;
        }
        
        UITextListEdit.丐三丄丗丕丝丏丌丐 val_2 = null;
        val_9 = val_2;
        val_2 = new UITextListEdit.丐三丄丗丕丝丏丌丐();
        if(val_9 != null)
        {
            goto label_7;
        }
        
        goto label_4;
        label_2:
        val_10 = this.丟丁丙丂世丏丕丘上;
        val_9 = this.丟丁丙丂世丏丕丘上.Item[0];
        val_10.RemoveAt(index:  0);
        if(val_9 != null)
        {
            goto label_7;
        }
        
        label_4:
        label_7:
        val_3.丕丗丘丑丛与丑业丒 = 丕丗丘丑丛与丑业丒;
        this.丟丁丙丂世丏丕丘上.Add(item:  val_9);
        val_11 = this.textLabel;
        if(val_11 != 0)
        {
                val_11 = this.textLabel.font;
            if(val_11 != 0)
        {
                this.且丙丈东丝丝丟业丅 = 0;
            val_11 = this.丟丁丙丂世丏丕丘上.Count;
            if(val_11 >= 1)
        {
                int val_10 = this.且丙丈东丝丝丟业丅;
            var val_9 = 0;
            do
        {
            丐三丄丗丕丝丏丌丐 val_8 = this.丟丁丙丂世丏丕丘上.Item[0];
            val_10 = val_8.丄万丞丂不不业丅丌;
            val_9 = val_9 + 1;
            val_10 = val_10 + val_8.丄万丞丂不不业丅丌.Length;
            this.且丙丈东丝丝丟业丅 = val_10;
        }
        while(val_11 != val_9);
        
        }
        
        }
        
        }
        
        if(万丌与丁东且一丘上 == false)
        {
                return;
        }
        
        this.丘不丕不丒世东世且();
    }
    private void Awake()
    {
        float val_8;
        UILabel val_16;
        if(this.textLabel == 0)
        {
                val_16 = this.GetComponentInChildren<UILabel>();
            this.textLabel = val_16;
        }
        else
        {
                val_16 = this.textLabel;
        }
        
        if(val_16 != 0)
        {
                this.textLabel.lineWidth = 0;
        }
        
        UnityEngine.Collider val_4 = this.GetComponent<UnityEngine.Collider>();
        if(val_4 == 0)
        {
                return;
        }
        
        if(this.maxHeight <= 0f)
        {
                UnityEngine.Bounds val_6 = val_4.bounds;
            UnityEngine.Vector3 val_10 = this.transform.lossyScale;
            this.maxHeight = V1.16B / val_10.y;
        }
        
        if(this.maxWidth > 0f)
        {
                return;
        }
        
        UnityEngine.Bounds val_12 = val_4.bounds;
        UnityEngine.Vector3 val_14 = this.transform.lossyScale;
        val_14.x = val_8 / val_14.x;
        this.maxWidth = val_14.x;
    }
    public void OnSelect(bool 丛丗七丅下丞丗且丐)
    {
        this.东一且三丑丑丏丗七 = 丛丗七丅下丞丗且丐;
    }
    protected void 丘不丕不丒世东世且()
    {
        var val_24;
        var val_25;
        var val_26;
        System.Collections.Generic.List<丐三丄丗丕丝丏丌丐> val_27;
        int val_28;
        var val_29;
        System.String[] val_30;
        val_24 = this;
        if(this.textLabel == 0)
        {
                return;
        }
        
        if(this.textLabel.font == 0)
        {
                return;
        }
        
        if(this.maxHeight > 0f)
        {
                UnityEngine.Vector3 val_5 = this.textLabel.cachedTransform.localScale;
            val_25 = UnityEngine.Mathf.FloorToInt(f:  this.maxHeight / val_5.y);
        }
        else
        {
                val_25 = 65536;
            val_25 = 1;
        }
        
        val_26 = UnityEngine.Mathf.RoundToInt(f:  this.丈世丙业业七丟不丒);
        if((val_26 + 100000) > this.且丙丈东丝丝丟业丅)
        {
                int val_10 = this.且丙丈东丝丝丟业丅 - 100000;
            val_26 = UnityEngine.Mathf.Max(a:  0, b:  val_10);
            this.丈世丙业业七丟不丒 = (float)val_26;
        }
        
        if(this.style == 1)
        {
                val_10 = this.且丙丈东丝丝丟业丅 - (val_26 + 100000);
            val_26 = UnityEngine.Mathf.Max(a:  0, b:  val_10);
        }
        
        System.Text.StringBuilder val_14 = new System.Text.StringBuilder();
        val_27 = this.丟丁丙丂世丏丕丘上;
        val_28 = public System.Int32 System.Collections.Generic.List<丐三丄丗丕丝丏丌丐>::get_Count();
        int val_15 = val_27.Count;
        if(val_15 < 1)
        {
            goto label_39;
        }
        
        val_29 = 0;
        var val_24 = 0;
        label_40:
        if(this.丟丁丙丂世丏丕丘上 != null)
        {
                val_30 = this.丟丁丙丂世丏丕丘上.Count;
        }
        else
        {
                val_30 = 0.Count;
        }
        
        val_28 = val_30 + val_24;
        丐三丄丗丕丝丏丌丐 val_18 = this.丟丁丙丂世丏丕丘上.Item[val_28];
        if(val_18.丄万丞丂不不业丅丌.Length < 1)
        {
            goto label_37;
        }
        
        var val_23 = 0;
        val_27 = (long)val_18.丄万丞丂不不业丅丌.Length;
        label_38:
        val_30 = val_18.丄万丞丂不不业丅丌;
        if(val_23 >= val_18.丄万丞丂不不业丅丌.Length)
        {
                val_28 = 0;
        }
        
        if(val_23 < val_18.丄万丞丂不不业丅丌.Length)
        {
            goto label_31;
        }
        
        val_26 = val_26 - 1;
        goto label_32;
        label_31:
        val_30 = val_30[val_23];
        if(val_14.Length >= 1)
        {
                System.Text.StringBuilder val_21 = val_14.Append(value:  "\n");
        }
        
        val_28 = val_30;
        System.Text.StringBuilder val_22 = val_14.Append(value:  val_28);
        val_29 = val_29 + 1;
        if(val_29 >= 100000)
        {
            goto label_37;
        }
        
        label_32:
        val_23 = val_23 + 1;
        if(val_23 < val_27)
        {
            goto label_38;
        }
        
        label_37:
        val_24 = val_24;
        if(val_29 >= 100000)
        {
            goto label_39;
        }
        
        val_24 = val_24 + 1;
        if(val_24 < val_15)
        {
            goto label_40;
        }
        
        label_39:
        this.textLabel.text = val_14;
    }
    public void OnScroll(float 下下丏一丙不丘丌丞)
    {
        float val_3 = 下下丏一丙不丘丌丞;
        if(this.东一且三丑丑丏丗七 == false)
        {
                return;
        }
        
        if(this.supportScrollWheel == false)
        {
                return;
        }
        
        float val_4 = 10f;
        val_3 = ((this.style == 1) ? (val_4) : -10f) * val_3;
        val_4 = this.丈世丙业业七丟不丒 + val_3;
        this.丈世丙业业七丟不丒 = UnityEngine.Mathf.Max(a:  0f, b:  val_4);
        this.丘不丕不丒世东世且();
    }
    public UITextListEdit()
    {
        this.maxEntries = 50;
        this.丟丁丙丂世丏丕丘上 = new System.Collections.Generic.List<丐三丄丗丕丝丏丌丐>();
        char[] val_2 = new char[1];
        val_2[0] = '
        ';
        this.丞丌下丆下丈丏丂丛 = val_2;
        this.supportScrollWheel = true;
    }

}
