using UnityEngine;
internal class TaskUIImposterRopes : TaskUIImposterModeAbstract
{
    // Fields
    private System.Collections.Generic.List<TaskUIImposter.Ropes.RopeTale> _tales;
    private System.Collections.Generic.List<TaskUIImposter.Ropes.RopeSocket> _sockets;
    private System.Collections.Generic.List<UnityEngine.Color> _possibleColors;
    private float _minDistanceToSocket;
    private TaskUIImposter.Ropes.RopeTale 丑与丄上丆丗丙丛专;
    public UnityEngine.AudioClip ropeConnectedClip;
    public UnityEngine.AudioSource audioSource;
    
    // Methods
    protected override void OnEnable()
    {
        this.OnEnable();
        TaskUIImposter.Ropes.RopeTale.丆且丛下与丏万丐丅(丙业与丙丗丝不丈东:  new System.Action<TaskUIImposter.Ropes.RopeTale>(object:  this, method:  System.Void TaskUIImposterRopes::三丈丕丄上七丁与三(TaskUIImposter.Ropes.RopeTale 丈丄丌丙丕丈丆丝丟)));
        TaskUIImposter.Ropes.RopeTale.丏上丁东丅丁丐丈丒(丙业与丙丗丝不丈东:  new System.Action<TaskUIImposter.Ropes.RopeTale>(object:  this, method:  System.Void TaskUIImposterRopes::丅丙业专丑专丒丆丙(TaskUIImposter.Ropes.RopeTale 丈丄丌丙丕丈丆丝丟)));
    }
    protected override void OnDisable()
    {
        TaskUIImposter.Ropes.RopeTale.丏丛丙业丙专丏丂丅(丙业与丙丗丝不丈东:  new System.Action<TaskUIImposter.Ropes.RopeTale>(object:  this, method:  System.Void TaskUIImposterRopes::三丈丕丄上七丁与三(TaskUIImposter.Ropes.RopeTale 丈丄丌丙丕丈丆丝丟)));
        TaskUIImposter.Ropes.RopeTale.一一丏上丙丆丐不丙(丙业与丙丗丝不丈东:  new System.Action<TaskUIImposter.Ropes.RopeTale>(object:  this, method:  System.Void TaskUIImposterRopes::丅丙业专丑专丒丆丙(TaskUIImposter.Ropes.RopeTale 丈丄丌丙丕丈丆丝丟)));
    }
    private void 三丈丕丄上七丁与三(TaskUIImposter.Ropes.RopeTale 丈丄丌丙丕丈丆丝丟)
    {
        TaskUIImposter.Ropes.RopeTale val_4 = this.丑与丄上丆丗丙丛专;
        if(丈丄丌丙丕丈丆丝丟 == val_4)
        {
                return;
        }
        
        val_4 = this.丑与丄上丆丗丙丛专;
        if(val_4 != 0)
        {
                val_4 = this.丑与丄上丆丗丙丛专.与丅世丈丝丈丑丈与;
            if(val_4 == 0)
        {
                val_4 = this.丑与丄上丆丗丙丛专;
            val_4.丝丈万一业丁三丙丛();
            this.丑与丄上丆丗丙丛专 = 0;
        }
        
        }
        
        this.丑与丄上丆丗丙丛专 = 丈丄丌丙丕丈丆丝丟;
    }
    private void 丅丙业专丑专丒丆丙(TaskUIImposter.Ropes.RopeTale 丈丄丌丙丕丈丆丝丟)
    {
        TaskUIImposter.Ropes.RopeTale val_14;
        UnityEngine.Object val_15;
        TaskUIImposter.Ropes.RopeSocket val_4 = 0;
        val_14 = this.丑与丄上丆丗丙丛专;
        if(丈丄丌丙丕丈丆丝丟 != val_14)
        {
                return;
        }
        
        UnityEngine.Vector3 val_3 = 丈丄丌丙丕丈丆丝丟.transform.position;
        val_14 = 0;
        if((this.丄与世万丆丌世丂丅(专丂丕丗丗东世丞下:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, 丘一丄丕丏专上三专: out  val_4, 丌七丒世丄上丞丞丁: out  float val_5 = -7.558685E-10f)) != false)
        {
                if(this._minDistanceToSocket > 0f)
        {
                val_14 = val_4;
        }
        else
        {
                val_14 = 0;
        }
        
        }
        
        if(val_14 == 0)
        {
            goto label_23;
        }
        
        List.Enumerator<T> val_8 = this._tales.GetEnumerator();
        label_19:
        if(((-1336949400) & 1) == 0)
        {
            goto label_13;
        }
        
        string val_9 = 0.丐丏七丌丕丗业且上();
        var val_10 = (val_9 == null) ? 0 : (val_9);
        if(val_9 != null)
        {
                val_15 = mem[val_9 == null ? 0 : val_9 + 160];
            val_15 = val_9 == null ? 0 : val_9 + 160;
        }
        else
        {
                val_15 = 0;
        }
        
        if(val_15 != val_14)
        {
            goto label_19;
        }
        
        val_14 = 0;
        label_13:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        label_23:
        if(val_14 != 0)
        {
                this.丅丕世三世专丆丑丘(丈丄丌丙丕丈丆丝丟:  丈丄丌丙丕丈丆丝丟, 丝东丗丕丛丞丝且丕:  val_14);
            if(this.丕一三丁业与万丂下() == false)
        {
                return;
        }
        
            this.万丏丛东下丝下丟丕();
            return;
        }
        
        丈丄丌丙丕丈丆丝丟.丝丈万一业丁三丙丛();
    }
    private bool 丄与世万丆丌世丂丅(UnityEngine.Vector3 专丂丕丗丗东世丞下, out TaskUIImposter.Ropes.RopeSocket 丘一丄丕丏专上三专, out float 丌七丒世丄上丞丞丁)
    {
        var val_3;
        System.Collections.Generic.List<TaskUIImposter.Ropes.RopeSocket> val_11;
        丘一丄丕丏专上三专 = 0;
        丌七丒世丄上丞丞丁 = -1.175494E-38f;
        val_11 = this._sockets;
        List.Enumerator<T> val_1 = val_11.GetEnumerator();
        goto label_10;
        label_11:
        val_11 = val_3.丐丏七丌丕丗业且上();
        if(val_11 != 0)
        {
                UnityEngine.Vector3 val_7 = val_11.transform.position;
            float val_8 = UnityEngine.Vector3.Distance(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, b:  new UnityEngine.Vector3() {x = 专丂丕丗丗东世丞下.x, y = 专丂丕丗丗东世丞下.y, z = 专丂丕丗丗东世丞下.z});
            if(val_8 < 0)
        {
                丘一丄丕丏专上三专 = val_11;
            丌七丒世丄上丞丞丁 = val_8;
        }
        
        }
        
        label_10:
        if(((-1336792480) & 1) != 0)
        {
            goto label_11;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool)UnityEngine.Object.op_Inequality(x:  丘一丄丕丏专上三专, y:  0);
    }
    private void 丅丕世三世专丆丑丘(TaskUIImposter.Ropes.RopeTale 丈丄丌丙丕丈丆丝丟, TaskUIImposter.Ropes.RopeSocket 丝东丗丕丛丞丝且丕)
    {
        if(丈丄丌丙丕丈丆丝丟 != null)
        {
                丈丄丌丙丕丈丆丝丟.与丅世丈丝丈丑丈与 = 丝东丗丕丛丞丝且丕;
        }
        else
        {
                mem[160] = 丝东丗丕丛丞丝且丕;
        }
        
        UnityEngine.Vector3 val_3 = 丝东丗丕丛丞丝且丕.transform.position;
        丈丄丌丙丕丈丆丝丟.transform.position = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        if(this.ropeConnectedClip == 0)
        {
                return;
        }
        
        this.audioSource.PlayOneShot(clip:  this.ropeConnectedClip);
    }
    private bool 丕一三丁业与万丂下()
    {
        var val_3;
        var val_8;
        List.Enumerator<T> val_1 = this._tales.GetEnumerator();
        label_11:
        if(((-1336482496) & 1) == 0)
        {
            goto label_2;
        }
        
        string val_4 = val_3.丐丏七丌丕丗业且上();
        if(val_4 == 0)
        {
            goto label_11;
        }
        
        if(137129984 != 0)
        {
                if((System.String.op_Inequality(a:  val_4, b:  static_value_082C7020)) == false)
        {
            goto label_11;
        }
        
        }
        
        val_8 = 0;
        goto label_12;
        label_2:
        val_8 = 1;
        label_12:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        return (bool)val_8;
    }
    protected override void 丗下丗丕丂丈万七丛()
    {
        goto typeof(TaskUIImposterRopes).__il2cppRuntimeField_178;
    }
    protected override void 丛丕丌丐上东丂丟丑()
    {
        var val_17;
        var val_18;
        var val_19;
        this.丑与丄上丆丗丙丛专 = 0;
        if(73222 != 0)
        {
                val_17 = 73222.丐丕不丅三专万丕丗();
        }
        else
        {
                val_17 = 999;
        }
        
        System.Collections.Generic.List<T> val_6 = System.Linq.Enumerable.ToList<UnityEngine.Color>(source:  丞东丑专丛丆丄丝世.丆丝丙丁不丅丄七丂<UnityEngine.Color>(丅东丗丒丄东丛业丄:  this._possibleColors, 丂丆且一丛丙丑七丒:  new System.Random(Seed:  231))).GetRange(index:  0, count:  this._sockets.Count);
        if((public System.Collections.Generic.List<T> System.Collections.Generic.List<UnityEngine.Color>::GetRange(int index, int count)) != 0)
        {
                val_18 = 丐丕不丅三专万丕丗() + 1000;
        }
        else
        {
                val_18 = 1999;
        }
        
        val_19 = 0;
        goto label_11;
        label_20:
        UnityEngine.Color val_11 = val_6.Item[0];
        TaskUIImposter.Ropes.RopeTale val_12 = this._tales.Item[0];
        if(val_12 != null)
        {
                val_12.丝丈万一业丁三丙丛();
        }
        else
        {
                val_12.丝丈万一业丁三丙丛();
        }
        
        val_12.丒丗丙丙丙丟专丅万(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_11.r, g = val_11.g, b = val_11.b, a = val_11.a});
        UnityEngine.Color val_13 = System.Linq.Enumerable.ToList<UnityEngine.Color>(source:  丞东丑专丛丆丄丝世.丆丝丙丁不丅丄七丂<UnityEngine.Color>(丅东丗丒丄东丛业丄:  val_6, 丂丆且一丛丙丑七丒:  new System.Random(Seed:  207))).Item[0];
        this._sockets.Item[0].丒丗丙丙丙丟专丅万(丑丞丈丗丄丙丟万丄:  new UnityEngine.Color() {r = val_13.r, g = val_13.g, b = val_13.b, a = val_13.a});
        val_19 = 1;
        label_11:
        if(val_19 < this._tales.Count)
        {
            goto label_20;
        }
    
    }
    public TaskUIImposterRopes()
    {
        this._minDistanceToSocket = 0.15f;
        val_1 = new PGBehaviour();
    }

}
