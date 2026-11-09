using UnityEngine;
public class 下丌丙丘丈丌世万专
{
    // Fields
    private bool 丁七丘丄丝丆丌世丛;
    private System.Collections.Generic.Queue<object> 上丐丌丘专丛丞专且;
    private object[] 丄下且一丐专三七丄;
    internal byte 专丗丒东丂万丂万丟;
    
    // Properties
    public bool 不丙七一不东丂万下 { get; }
    public bool 业丘丕业上业上东业 { get; }
    public int 丒专下与丑丁丆丟业 { get; }
    
    // Methods
    public 下丌丙丘丈丌世万专(bool 丁七丘丄丝丆丌世丛, object[] 上不丌丐丛三东丟丝)
    {
        this.丁七丘丄丝丆丌世丛 = 丁七丘丄丝丆丌世丛;
        if(上不丌丐丛三东丟丝 != null)
        {
                this.丄下且一丐专三七丄 = 上不丌丐丛三东丟丝;
            return;
        }
        
        this.上丐丌丘专丛丞专且 = new System.Collections.Generic.Queue<System.Object>(capacity:  10);
    }
    public void 业七丏上业丏上丐丆(object[] 上不丌丐丛三东丟丝, byte 下业丕七东丌丝下且 = 0)
    {
        this.丄下且一丐专三七丄 = 上不丌丐丛三东丟丝;
        this.专丗丒东丂万丂万丟 = 下业丕七东丌丝下且;
        this.丁七丘丄丝丆丌世丛 = false;
    }
    internal void 丆上七丟丑万不七世()
    {
        this.上丐丌丘专丛丞专且.Clear();
    }
    public bool 丕专丏万下不丞丐丛()
    {
        return (bool)this.丁七丘丄丝丆丌世丛;
    }
    public bool 丟东七不丕丞七丆丑()
    {
        return (bool)(this.丁七丘丄丝丆丌世丛 == false) ? 1 : 0;
    }
    public int 丂丁丏一丙丛业且丌()
    {
        if(this.丁七丘丄丝丆丌世丛 != false)
        {
                if(this.上丐丌丘专丛丞专且 != null)
        {
                return this.上丐丌丘专丛丞专且.Count;
        }
        
            return this.上丐丌丘专丛丞专且.Count;
        }
        
        if(this.丄下且一丐专三七丄 != null)
        {
                return (int)this.丄下且一丐专三七丄.Length;
        }
        
        return (int)this.丄下且一丐专三七丄.Length;
    }
    public object 与万三丘与专丛丄七()
    {
        object val_1;
        if(this.丁七丘丄丝丆丌世丛 != false)
        {
                UnityEngine.Debug.LogError(message:  "Error: you cannot read this stream that you are writing!");
            val_1 = 0;
            return val_1;
        }
        
        byte val_1 = this.专丗丒东丂万丂万丟;
        val_1 = this.丄下且一丐专三七丄[this.专丗丒东丂万丂万丟];
        val_1 = val_1 + 1;
        this.专丗丒东丂万丂万丟 = val_1;
        return val_1;
    }
    public object 丁专不丘丒丁丐上东()
    {
        byte val_1;
        object val_2;
        val_1 = this;
        if(this.丁七丘丄丝丆丌世丛 != false)
        {
                UnityEngine.Debug.LogError(message:  "Error: you cannot read this stream that you are writing!");
            val_2 = 0;
            return val_2;
        }
        
        val_1 = this.专丗丒东丂万丂万丟;
        val_2 = this.丄下且一丐专三七丄[val_1];
        return val_2;
    }
    public void 七丈不业丞丛东东丕(object 万且万且丑丗且丌丆)
    {
        if(this.丁七丘丄丝丆丌世丛 != false)
        {
                this.上丐丌丘专丛丞专且.Enqueue(item:  万且万且丑丗且丌丆);
            return;
        }
        
        UnityEngine.Debug.LogError(message:  "Error: you cannot write/send to this stream that you are reading!");
    }
    public object[] 东与上丗与丏下丂丘()
    {
        if(this.丁七丘丄丝丆丌世丛 == false)
        {
                return (System.Object[])this.丄下且一丐专三七丄;
        }
        
        if(this.上丐丌丘专丛丞专且 != null)
        {
                return this.上丐丌丘专丛丞专且.ToArray();
        }
        
        return this.上丐丌丘专丛丞专且.ToArray();
    }
    public void 丙业不丝丗丌丗世下(ref bool 业丑丄丙专丟上世丞)
    {
        byte val_2;
        if(this.丁七丘丄丝丆丌世丛 != false)
        {
                this = this.上丐丌丘专丛丞专且;
            this.Enqueue(item:  (业丑丄丙专丟上世丞 == true) ? 1 : 0);
            return;
        }
        
        val_2 = this.专丗丒东丂万丂万丟;
        if(this.丄下且一丐专三七丄.Length <= val_2)
        {
                return;
        }
        
        object val_2 = this.丄下且一丐专三七丄[val_2];
        业丑丄丙专丟上世丞 = null;
        byte val_3 = this.专丗丒东丂万丂万丟;
        val_3 = val_3 + 1;
        this.专丗丒东丂万丂万丟 = val_3;
    }
    public void 丙业不丝丗丌丗世下(ref int 万世世丙丕丑丗丞下)
    {
        byte val_1;
        if(this.丁七丘丄丝丆丌世丛 != false)
        {
                1152921535537899872 = 万世世丙丕丑丗丞下;
            this.上丐丌丘专丛丞专且.Enqueue(item:  万世世丙丕丑丗丞下);
            return;
        }
        
        val_1 = this.专丗丒东丂万丂万丟;
        if(this.丄下且一丐专三七丄.Length <= val_1)
        {
                return;
        }
        
        object val_1 = this.丄下且一丐专三七丄[val_1];
        万世世丙丕丑丗丞下 = null;
        byte val_2 = this.专丗丒东丂万丂万丟;
        val_2 = val_2 + 1;
        this.专丗丒东丂万丂万丟 = val_2;
    }
    public void 丙业不丝丗丌丗世下(ref string 丙业与丙丗丝不丈东)
    {
        byte val_2;
        string val_3;
        if(this.丁七丘丄丝丆丌世丛 != false)
        {
                this.上丐丌丘专丛丞专且.Enqueue(item:  丙业与丙丗丝不丈东);
            return;
        }
        
        val_2 = this.专丗丒东丂万丂万丟;
        if(this.丄下且一丐专三七丄.Length <= val_2)
        {
                return;
        }
        
        val_2 = this.丄下且一丐专三七丄[val_2];
        if(val_2 == null)
        {
            goto label_7;
        }
        
        val_3 = val_2;
        if(null != null)
        {
                val_3 = 0;
        }
        
        丙业与丙丗丝不丈东 = val_3;
        if(null == null)
        {
            goto label_10;
        }
        
        goto label_10;
        label_7:
        丙业与丙丗丝不丈东 = 0;
        label_10:
        byte val_2 = this.专丗丒东丂万丂万丟;
        val_2 = val_2 + 1;
        this.专丗丒东丂万丂万丟 = val_2;
    }
    public void 丙业不丝丗丌丗世下(ref char 丙业与丙丗丝不丈东)
    {
        byte val_1;
        if(this.丁七丘丄丝丆丌世丛 != false)
        {
                1152921535538475808 = 丙业与丙丗丝不丈东;
            this.上丐丌丘专丛丞专且.Enqueue(item:  丙业与丙丗丝不丈东);
            return;
        }
        
        val_1 = this.专丗丒东丂万丂万丟;
        if(this.丄下且一丐专三七丄.Length <= val_1)
        {
                return;
        }
        
        object val_1 = this.丄下且一丐专三七丄[val_1];
        丙业与丙丗丝不丈东 = null;
        byte val_2 = this.专丗丒东丂万丂万丟;
        val_2 = val_2 + 1;
        this.专丗丒东丂万丂万丟 = val_2;
    }
    public void 丙业不丝丗丌丗世下(ref short 丙业与丙丗丝不丈东)
    {
        byte val_1;
        if(this.丁七丘丄丝丆丌世丛 != false)
        {
                1152921535538767872 = 丙业与丙丗丝不丈东;
            this.上丐丌丘专丛丞专且.Enqueue(item:  丙业与丙丗丝不丈东);
            return;
        }
        
        val_1 = this.专丗丒东丂万丂万丟;
        if(this.丄下且一丐专三七丄.Length <= val_1)
        {
                return;
        }
        
        object val_1 = this.丄下且一丐专三七丄[val_1];
        丙业与丙丗丝不丈东 = null;
        byte val_2 = this.专丗丒东丂万丂万丟;
        val_2 = val_2 + 1;
        this.专丗丒东丂万丂万丟 = val_2;
    }
    public void 丙业不丝丗丌丗世下(ref float 万且万且丑丗且丌丆)
    {
        byte val_1;
        if(this.丁七丘丄丝丆丌世丛 != false)
        {
                1152921535539059936 = 万且万且丑丗且丌丆;
            this.上丐丌丘专丛丞专且.Enqueue(item:  万且万且丑丗且丌丆);
            return;
        }
        
        val_1 = this.专丗丒东丂万丂万丟;
        if(this.丄下且一丐专三七丄.Length <= val_1)
        {
                return;
        }
        
        object val_1 = this.丄下且一丐专三七丄[val_1];
        万且万且丑丗且丌丆 = null;
        byte val_2 = this.专丗丒东丂万丂万丟;
        val_2 = val_2 + 1;
        this.专丗丒东丂万丂万丟 = val_2;
    }
    public void 丙业不丝丗丌丗世下(ref 与丅丕丈丘东丝世丟 万且万且丑丗且丌丆)
    {
        byte val_4;
        与丅丕丈丘东丝世丟 val_5;
        if(this.丁七丘丄丝丆丌世丛 != false)
        {
                this.上丐丌丘专丛丞专且.Enqueue(item:  万且万且丑丗且丌丆);
            return;
        }
        
        val_4 = this.专丗丒东丂万丂万丟;
        if(this.丄下且一丐专三七丄.Length <= val_4)
        {
                return;
        }
        
        val_4 = this.丄下且一丐专三七丄[val_4];
        if(val_4 != null)
        {
                val_5 = val_4;
            val_5 = 0;
            万且万且丑丗且丌丆 = val_5;
        }
        else
        {
                万且万且丑丗且丌丆 = 0;
        }
        
        byte val_4 = this.专丗丒东丂万丂万丟;
        val_4 = val_4 + 1;
        this.专丗丒东丂万丂万丟 = val_4;
    }
    public void 丙业不丝丗丌丗世下(ref UnityEngine.Vector3 万且万且丑丗且丌丆)
    {
        byte val_1;
        if(this.丁七丘丄丝丆丌世丛 != false)
        {
                1152921535539635888 = 万且万且丑丗且丌丆.x;
            this.上丐丌丘专丛丞专且.Enqueue(item:  万且万且丑丗且丌丆.x);
            return;
        }
        
        val_1 = this.专丗丒东丂万丂万丟;
        if(this.丄下且一丐专三七丄.Length <= val_1)
        {
                return;
        }
        
        object val_1 = this.丄下且一丐专三七丄[val_1];
        万且万且丑丗且丌丆.z = this.丄下且一丐专三七丄[val_1];
        万且万且丑丗且丌丆.x = null;
        byte val_2 = this.专丗丒东丂万丂万丟;
        val_2 = val_2 + 1;
        this.专丗丒东丂万丂万丟 = val_2;
    }
    public void 丙业不丝丗丌丗世下(ref UnityEngine.Vector2 万且万且丑丗且丌丆)
    {
        byte val_1;
        if(this.丁七丘丄丝丆丌世丛 != false)
        {
                1152921535539927984 = 万且万且丑丗且丌丆.x;
            this.上丐丌丘专丛丞专且.Enqueue(item:  万且万且丑丗且丌丆.x);
            return;
        }
        
        val_1 = this.专丗丒东丂万丂万丟;
        if(this.丄下且一丐专三七丄.Length <= val_1)
        {
                return;
        }
        
        object val_1 = this.丄下且一丐专三七丄[val_1];
        万且万且丑丗且丌丆.x = null;
        byte val_2 = this.专丗丒东丂万丂万丟;
        val_2 = val_2 + 1;
        this.专丗丒东丂万丂万丟 = val_2;
    }
    public void 丙业不丝丗丌丗世下(ref UnityEngine.Quaternion 万且万且丑丗且丌丆)
    {
        byte val_1;
        if(this.丁七丘丄丝丆丌世丛 != false)
        {
                1152921535540220096 = 万且万且丑丗且丌丆.x;
            this.上丐丌丘专丛丞专且.Enqueue(item:  万且万且丑丗且丌丆.x);
            return;
        }
        
        val_1 = this.专丗丒东丂万丂万丟;
        if(this.丄下且一丐专三七丄.Length <= val_1)
        {
                return;
        }
        
        object val_1 = this.丄下且一丐专三七丄[val_1];
        万且万且丑丗且丌丆.x = null;
        byte val_2 = this.专丗丒东丂万丂万丟;
        val_2 = val_2 + 1;
        this.专丗丒东丂万丂万丟 = val_2;
    }

}
