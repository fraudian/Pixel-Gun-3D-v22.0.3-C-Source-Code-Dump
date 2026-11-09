using UnityEngine;
public class AGSSyncableAccumulatingNumber : AGSSyncable
{
    // Methods
    public AGSSyncableAccumulatingNumber(AmazonJavaWrapper javaObject)
    {
        val_1 = new System.Object();
        mem[1152921524079860320] = javaObject;
    }
    public AGSSyncableAccumulatingNumber(UnityEngine.AndroidJavaObject javaObject)
    {
    
    }
    public void Increment(long delta)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(delta != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(delta == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = delta;
        this.Call(method:  "increment", args:  val_1);
    }
    public void Increment(double delta)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(delta != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(delta == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = delta;
        this.Call(method:  "increment", args:  val_1);
    }
    public void Increment(int delta)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(delta != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(delta == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = delta;
        this.Call(method:  "increment", args:  val_1);
    }
    public void Increment(string delta)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(delta != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(delta == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = delta;
        this.Call(method:  "increment", args:  val_1);
    }
    public void Decrement(long delta)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(delta != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(delta == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = delta;
        this.Call(method:  "decrement", args:  val_1);
    }
    public void Decrement(double delta)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(delta != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(delta == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = delta;
        this.Call(method:  "decrement", args:  val_1);
    }
    public void Decrement(int delta)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(delta != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(delta == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = delta;
        this.Call(method:  "decrement", args:  val_1);
    }
    public void Decrement(string delta)
    {
        object[] val_1 = new object[1];
        if(val_1 == null)
        {
            goto label_1;
        }
        
        if(delta != null)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(delta == null)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_1[0] = delta;
        this.Call(method:  "decrement", args:  val_1);
    }
    public long AsLong()
    {
        if(this != null)
        {
                return this.Call<System.Int64>(method:  "asLong", args:  System.Array.Empty<System.String>());
        }
        
        return this.Call<System.Int64>(method:  "asLong", args:  System.Array.Empty<System.String>());
    }
    public double AsDouble()
    {
        if(this != null)
        {
                return this.Call<System.Double>(method:  "asDouble", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.Double>(method:  "asDouble", args:  System.Array.Empty<System.Object>());
    }
    public int AsInt()
    {
        if(this != null)
        {
                return this.Call<System.Int32>(method:  "asInt", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.Int32>(method:  "asInt", args:  System.Array.Empty<System.Object>());
    }
    public string AsString()
    {
        if(this != null)
        {
                return this.Call<System.String>(method:  "asString", args:  System.Array.Empty<System.Object>());
        }
        
        return this.Call<System.String>(method:  "asString", args:  System.Array.Empty<System.Object>());
    }

}
