using UnityEngine;
public class 丆七丂丕丄丙丈万三
{
    // Fields
    private int 丄丄三丒丏专丘丂丈;
    private int 东下丑丐一丞丈丒丛;
    private int 丏丂业丂丂丘上三专;
    private float 丗丟世丟丛丝丁万下;
    private int 丞丘丆丝丕万丙上一;
    private int 丒丟丈丝丈业丂丂下;
    private System.Collections.Generic.List<object> 丛三一上丁丕七与丟;
    private bool 且丑丞不七世丑丆丒;
    
    // Methods
    public 丆七丂丕丄丙丈万三(int 丒下丙丛丂三丕丛业)
    {
        this.丏丂业丂丂丘上三专 = -36028792723996673;
        this.丗丟世丟丛丝丁万下 = -Infinityf;
        this.丞丘丆丝丕万丙上一 = 0;
        this.丒丟丈丝丈业丂丂下 = 0;
        this.丛三一上丁丕七与丟 = new System.Collections.Generic.List<System.Object>();
        this.丄丄三丒丏专丘丂丈 = 丒下丙丛丂三丕丛业;
    }
    private void 且三三丝七一丆与且()
    {
        float val_9 = (float)this.丄丄三丒丏专丘丂丈;
        val_9 = 1f / val_9;
        val_9 = this.丗丟世丟丛丝丁万下 + val_9;
        if(UnityEngine.Time.realtimeSinceStartup < 0)
        {
                this.且丑丞不七世丑丆丒 = false;
            return;
        }
        
        if(this.东下丑丐一丞丈丒丛 == 1)
        {
                this.丏丂业丂丂丘上三专 = this.丛三一上丁丕七与丟.Count;
        }
        else
        {
                if(this.东下丑丐一丞丈丒丛 >= 2)
        {
                int val_10 = this.东下丑丐一丞丈丒丛;
            val_10 = this.丛三一上丁丕七与丟.Count / val_10;
            if(val_10 != this.丏丂业丂丂丘上三专)
        {
                UnityEngine.Debug.LogWarning(message:  "The number of objects sent via a PhotonStreamQueue has to be the same each frame");
            object[] val_4 = new object[4];
            val_4[0] = this.丛三一上丁丕七与丟.Count;
            val_4[1] = this.东下丑丐一丞丈丒丛;
            int val_11 = this.东下丑丐一丞丈丒丛;
            val_11 = this.丛三一上丁丕七与丟.Count / val_11;
            val_4[2] = val_11;
            val_4[3] = this.丏丂业丂丂丘上三专;
            UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "Objects in List: {0} / Sample Count: {1} = {2} != {3}", args:  val_4));
        }
        
        }
        
        }
        
        int val_12 = this.东下丑丐一丞丈丒丛;
        this.且丑丞不七世丑丆丒 = true;
        val_12 = val_12 + 1;
        this.东下丑丐一丞丈丒丛 = val_12;
        this.丗丟世丟丛丝丁万下 = UnityEngine.Time.realtimeSinceStartup;
    }
    public void 且七丙丄丘一丄上不()
    {
        this.东下丑丐一丞丈丒丛 = -4294967296;
        this.丏丂业丂丂丘上三专 = -1;
        this.丗丟世丟丛丝丁万下 = -Infinityf;
        this.丞丘丆丝丕万丙上一 = -1;
        this.丛三一上丁丕七与丟.Clear();
    }
    public void 七丈不业丞丛东东丕(object 万且万且丑丗且丌丆)
    {
        if(UnityEngine.Time.frameCount != this.丞丘丆丝丕万丙上一)
        {
                this.且三三丝七一丆与且();
        }
        
        this.丞丘丆丝丕万丙上一 = UnityEngine.Time.frameCount;
        if(this.且丑丞不七世丑丆丒 == false)
        {
                return;
        }
        
        this.丛三一上丁丕七与丟.Add(item:  万且万且丑丗且丌丆);
    }
    public bool 丝七万东上丑业一丅()
    {
        return (bool)(this.丒丟丈丝丈业丂丂下 != 1) ? 1 : 0;
    }
    public object 与万三丘与专丛丄七()
    {
        int val_2;
        if(this.丒丟丈丝丈业丂丂下 == 1)
        {
                return 0;
        }
        
        val_2 = this.丒丟丈丝丈业丂丂下;
        if(this.丒丟丈丝丈业丂丂下 >= this.丛三一上丁丕七与丟.Count)
        {
                int val_2 = this.丏丂业丂丂丘上三专;
            val_2 = val_2 - val_2;
            this.丒丟丈丝丈业丂丂下 = val_2;
        }
        
        val_2 = val_2 + 1;
        this.丒丟丈丝丈业丂丂下 = val_2;
        if(this.丛三一上丁丕七与丟 != null)
        {
                return this.丛三一上丁丕七与丟.Item[val_2];
        }
        
        return this.丛三一上丁丕七与丟.Item[val_2];
    }
    public void 丙业不丝丗丌丗世下(下丌丙丘丈丌世万专 东业丄丅丅且世七丄)
    {
        var val_5;
        if((this.丛三一上丁丕七与丟.Count >= 1) && ((this.丏丂业丂丂丘上三专 & 2147483648) != 0))
        {
                this.丏丂业丂丂丘上三专 = this.丛三一上丁丕七与丟.Count;
        }
        
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.东下丑丐一丞丈丒丛);
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  this.丏丂业丂丂丘上三专);
        val_5 = 0;
        goto label_7;
        label_11:
        东业丄丅丅且世七丄.七丈不业丞丛东东丕(万且万且丑丗且丌丆:  Item[0]);
        val_5 = 1;
        label_7:
        if(val_5 < this.丛三一上丁丕七与丟.Count)
        {
            goto label_11;
        }
        
        this.丛三一上丁丕七与丟.Clear();
        this.东下丑丐一丞丈丒丛 = 0;
    }
    public void 丂东专丙丒丏且丛丁(下丌丙丘丈丌世万专 东业丄丅丅且世七丄)
    {
        System.Collections.Generic.List<System.Object> val_6;
        this.丛三一上丁丕七与丟.Clear();
        object val_1 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        this.东下丑丐一丞丈丒丛 = null;
        object val_2 = 东业丄丅丅且世七丄.与万三丘与专丛丄七();
        int val_6 = this.东下丑丐一丞丈丒丛;
        val_6 = this.丛三一上丁丕七与丟;
        this.丏丂业丂丂丘上三专 = null;
        val_6 = 1152921504628731904 * val_6;
        if(val_6 >= 1)
        {
                var val_7 = 0;
            do
        {
            val_6.Add(item:  东业丄丅丅且世七丄.与万三丘与专丛丄七());
            int val_8 = this.东下丑丐一丞丈丒丛;
            val_6 = this.丛三一上丁丕七与丟;
            val_7 = val_7 + 1;
            val_8 = this.丏丂业丂丂丘上三专 * val_8;
        }
        while(val_7 < val_8);
        
        }
        
        this.丒丟丈丝丈业丂丂下 = (val_6.Count < 1) ? -1 : 0;
    }

}
