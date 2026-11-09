using UnityEngine;
internal class 丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏
{
    // Fields
    private Rilisoft.丆专且丆世丟丄与丂 <七东丅丗丙下丐丘丈>k__BackingField;
    private Rilisoft.丈上丛丕业丂丕丝世 <丝专丞丑丞丏业丆丈>k__BackingField;
    
    // Properties
    public Rilisoft.丆专且丆世丟丄与丂 与丙不丆上三七丕丄 { get; set; }
    public Rilisoft.丈上丛丕业丂丕丝世 丈丆丟丐丆且东丈丘 { get; set; }
    
    // Methods
    public 丐丌丝七下丈丒丅丗.丞丁丙与丝丁不三丏(Rilisoft.丆专且丆世丟丄与丂 万世丞一丐丞丝丏东, Rilisoft.丈上丛丕业丂丕丝世 丕且丄东丑丟丑不丒)
    {
        val_1 = new System.Object();
        this.<七东丅丗丙下丐丘丈>k__BackingField = 万世丞一丐丞丝丏东;
        this.<丝专丞丑丞丏业丆丈>k__BackingField = val_1;
    }
    public Rilisoft.丆专且丆世丟丄与丂 不丏丟丐丙丏丁下丕()
    {
        return (Rilisoft.丆专且丆世丟丄与丂)this.<七东丅丗丙下丐丘丈>k__BackingField;
    }
    private void 丙不丂七丏下丙七与(Rilisoft.丆专且丆世丟丄与丂 丙业与丙丗丝不丈东)
    {
        this.<七东丅丗丙下丐丘丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public Rilisoft.丈上丛丕业丂丕丝世 丄世丙世丌丐丐东丅()
    {
        return (Rilisoft.丈上丛丕业丂丕丝世)this.<丝专丞丑丞丏业丆丈>k__BackingField;
    }
    private void 不七七万三万丄不东(Rilisoft.丈上丛丕业丂丕丝世 丙业与丙丗丝不丈东)
    {
        this.<丝专丞丑丞丏业丆丈>k__BackingField = 丙业与丙丗丝不丈东;
    }
    public override string ToString()
    {
        object val_5;
        object val_6;
        if((this.<七东丅丗丙下丐丘丈>k__BackingField) == null)
        {
            goto label_1;
        }
        
        if((this.<七东丅丗丙下丐丘丈>k__BackingField.GetType()) != null)
        {
            goto label_7;
        }
        
        label_8:
        val_5 = 0;
        label_7:
        if((this.<丝专丞丑丞丏业丆丈>k__BackingField) == null)
        {
            goto label_3;
        }
        
        if((this.<丝专丞丑丞丏业丆丈>k__BackingField.GetType()) != null)
        {
                return System.String.Format(format:  "({0},{1})", arg0:  val_5, arg1:  val_6 = 0);
        }
        
        label_12:
        return System.String.Format(format:  "({0},{1})", arg0:  val_5, arg1:  val_6);
        label_1:
        if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) != null)
        {
            goto label_7;
        }
        
        goto label_8;
        label_3:
        if((System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle())) != null)
        {
                return System.String.Format(format:  "({0},{1})", arg0:  val_5, arg1:  val_6);
        }
        
        goto label_12;
    }

}
