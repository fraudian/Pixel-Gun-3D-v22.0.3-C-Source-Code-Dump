using UnityEngine;
private sealed class GiftController.丌丟丁丂东世丆且与 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    public GiftCategory 丙丑丕丂下丏一丁专;
    public bool 丕丝且丁下业丗丛丐;
    public string 丞丅上丏丂且下丅与;
    private bool 丅一三丄东上丄丙东;
    private int 一丞世丂三丛丟一丂;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public GiftController.丌丟丁丂东世丆且与(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        var val_5;
        int val_6;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_4;
        }
        
        val_5 = this;
        this.丅一三丄东上丄丙东 = true;
        this.丗丏丅丕丆世丁专丟 = 0;
        mem[1152921537814418460] = 0;
        goto label_3;
        label_1:
        val_5 = this;
        this.丗丏丅丕丆世丁专丟 = 0;
        if(this.丅一三丄东上丄丙东 == false)
        {
            goto label_4;
        }
        
        label_3:
        int val_5 = this.一丞世丂三丛丟一丂;
        val_5 = val_5 + 1;
        this.一丞世丂三丛丟一丂 = val_5;
        GiftInfo val_1 = this.丙丑丕丂下丏一丁专.丄丗三业东丕丙丈丄(专东丅一三丏三丐丟:  false);
        if(this.丕丝且丁下业丗丛丐 == false)
        {
            goto label_7;
        }
        
        if((val_1.Id.Contains(value:  this.丞丅上丏丂且下丅与)) == true)
        {
            goto label_9;
        }
        
        goto label_12;
        label_4:
        val_6 = 0;
        return (bool)val_6;
        label_7:
        if((System.String.op_Equality(a:  val_1.Id, b:  this.丞丅上丏丂且下丅与)) == false)
        {
            goto label_12;
        }
        
        label_9:
        this.丅一三丄东上丄丙东 = false;
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "[TTT] found \'{0}\' iterations count: {1}", arg0:  val_1.Id, arg1:  this.一丞世丂三丛丟一丂));
        label_12:
        if(this.一丞世丂三丛丟一丂 >= 101)
        {
                UnityEngine.Debug.Log(message:  "[TTT] stop waiting");
            this.丅一三丄东上丄丙东 = false;
        }
        
        val_6 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_6;
        return (bool)val_6;
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
