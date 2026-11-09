using UnityEngine;
public class ImposterVoteChatController : PhotonEventBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    private System.Collections.Generic.List<丆与七世东不东丂丙> 不丑丆七丙丏丑丐世;
    private System.Action 丗万与三东下上专丕;
    
    // Methods
    internal void 丞一丙丈丘丕丐丑上(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丗万与三东下上专丕, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗万与三东下上专丕 != 1152921526260820000);
    
    }
    internal void 丌丆丄丁丑丑丗三万(System.Action 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丗万与三东下上专丕, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丗万与三东下上专丕 != 1152921526260956576);
    
    }
    private void Awake()
    {
        this.不丑丆七丙丏丑丐世 = new System.Collections.Generic.List<丆与七世东不东丂丙>();
    }
    private void 丁三专丆一丝业与丐(与丅丕丈丘东丝世丟 不丟丗丏丛丕不丁丌, string 丕丗丘丑丛与丑业丒, double 丑专丛丅丞下丄丈丞)
    {
        丆与七世东不东丂丙 val_20;
        UnityEngine.Object val_21;
        UnityEngine.Object val_22;
        var val_23;
        var val_24;
        var val_25;
        var val_26;
        var val_27;
        var val_28;
        var val_29;
        ImposterVoteChatController val_30;
        val_20 = 0;
        val_21 = 0;
        val_22 = 0;
        goto label_1;
        label_47:
        val_23 = null;
        val_23 = null;
        NetworkStartTable val_1 = Item[0];
        if(val_1.丄丈丑丐丆丞丘与丗.owner == null)
        {
            goto label_16;
        }
        
        val_24 = null;
        val_24 = null;
        NetworkStartTable val_3 = Item[0];
        if((val_3.丄丈丑丐丆丞丘与丗.owner.Equals(丘丛丏丘丝七世七丅:  不丟丗丏丛丕不丁丌)) == false)
        {
            goto label_16;
        }
        
        val_25 = null;
        val_25 = null;
        val_22 = Item[0];
        goto label_38;
        label_16:
        val_26 = null;
        val_26 = null;
        NetworkStartTable val_7 = Item[0];
        if(val_7.丄丈丑丐丆丞丘与丗.owner != null)
        {
                val_27 = null;
            val_27 = null;
            NetworkStartTable val_9 = Item[0];
            if((val_9.丄丈丑丐丆丞丘与丗.owner.Equals(丘丛丏丘丝七世七丅:  丅丒丗丑丒丙丛不丆.且上世且一丈丞专上())) != false)
        {
                val_28 = null;
            val_28 = null;
            val_21 = Item[0];
        }
        
        }
        
        label_38:
        val_20 = 1;
        label_1:
        val_29 = null;
        val_29 = null;
        if(val_20 < Count)
        {
            goto label_47;
        }
        
        val_30 = 1152921504848912384;
        if((val_21 != 0) && (val_21.丑丈上东丗丐丆世上() != false))
        {
                if(val_22 != 0)
        {
                if(val_22.丑丈上东丗丐丆世上() == false)
        {
                return;
        }
        
        }
        
        }
        
        丆与七世东不东丂丙 val_19 = null;
        val_20 = val_19;
        val_19 = new 丆与七世东不东丂丙();
        if(val_20 != null)
        {
                val_19.世与丗丟丟丘世丅且(丙业与丙丗丝不丈东:  丕丗丘丑丛与丑业丒);
            val_19.丟万丑七丑丆丆丁丅(丙业与丙丗丝不丈东:  丑专丛丅丞下丄丈丞);
            val_19.丕丈丈三丁丈丂丝丕(丙业与丙丗丝不丈东:  不丟丗丏丛丕不丁丌);
        }
        else
        {
                val_19.世与丗丟丟丘世丅且(丙业与丙丗丝不丈东:  丕丗丘丑丛与丑业丒);
            val_19.丟万丑七丑丆丆丁丅(丙业与丙丗丝不丈东:  丑专丛丅丞下丄丈丞);
            val_19.丕丈丈三丁丈丂丝丕(丙业与丙丗丝不丈东:  不丟丗丏丛丕不丁丌);
        }
        
        val_30 = this;
        val_19.丅丒丌丞丁丕丗丁丐(丙业与丙丗丝不丈东:  val_22);
        mem[1152921526261276824].Add(item:  val_19);
        if(mem[1152921526261276832] == 0)
        {
                return;
        }
        
        mem[1152921526261276832].Invoke();
    }
    internal void 丆丘丟且一丕丏世丒(与丅丕丈丘东丝世丟 不丟丗丏丛丕不丁丌, string 丕丗丘丑丛与丑业丒)
    {
        object[] val_1 = new object[3];
        val_1[0] = 不丟丗丏丛丕不丁丌;
        val_1[1] = 丕丗丘丑丛与丑业丒;
        val_1[2] = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        this.丅七下专东丗业下丐(丑丐丗三丒世丏东丅:  0, 丈丅丘丐三丂丗且丌:  0, 丕业丑万一丞丞东三:  true, 丗丟上上丒丐丗丞丙:  val_1);
        if(不丟丗丏丛丕不丁丌.不丐七丌下丗丈丒丅 == false)
        {
                return;
        }
        
        this.丁三专丆一丝业与丐(不丟丗丏丛丕不丁丌:  不丟丗丏丛丕不丁丌, 丕丗丘丑丛与丑业丒:  丕丗丘丑丛与丑业丒, 丑专丛丅丞下丄丈丞:  丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄());
    }
    internal void 丂且丕世万丅一丕七()
    {
        this.不丑丆七丙丏丑丐世.Clear();
    }
    internal System.Collections.Generic.List<丆与七世东不东丂丙> 丘丅与且丞专上万丝()
    {
        return (System.Collections.Generic.List<丆与七世东不东丂丙>)this.不丑丆七丙丏丑丐世;
    }
    public bool OnEventFired(byte 丞世不丒下上上丝丑, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_4;
        var val_5;
        int val_6;
        object val_7;
        object val_8;
        val_4 = 专丒丌丆下丐丞丟丞;
        if((丞世不丒下上上丝丑 & 255) != 0)
        {
                val_5 = 0;
            return (bool)val_5;
        }
        
        val_6 = 专丒丌丆下丐丞丟丞.Length;
        if(val_6 == 0)
        {
                val_6 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        val_7 = val_4[0];
        if(val_6 <= 1)
        {
                val_6 = 专丒丌丆下丐丞丟丞.Length;
        }
        
        val_8 = val_4[1];
        val_4 = val_4[2];
        if(val_7 != null)
        {
                val_7 = 0;
        }
        
        if((val_8 != null) && (null != null))
        {
                val_8 = 0;
        }
        
        this.丁三专丆一丝业与丐(不丟丗丏丛丕不丁丌:  val_7, 丕丗丘丑丛与丑业丒:  val_8, 丑专丛丅丞下丄丈丞:  1.28822976017949E-231);
        val_5 = 1;
        return (bool)val_5;
    }
    public ImposterVoteChatController()
    {
    
    }

}
