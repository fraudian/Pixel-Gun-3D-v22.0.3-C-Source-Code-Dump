using UnityEngine;
public static class 丛丙上丅丗上丘丐上
{
    // Methods
    public static UnityEngine.LayerMask 东丝七业丄丑丒世七(string[] 丟万丏业丌专一三丛)
    {
        UnityEngine.LayerMask val_1 = 丛丙上丅丗上丘丐上.三一丐丄上不不万七(丟万丏业丌专一三丛:  丟万丏业丌专一三丛);
        val_1.m_Mask = val_1.m_Mask & 4294967295;
        return (UnityEngine.LayerMask)val_1.m_Mask;
    }
    public static UnityEngine.LayerMask 东丝七业丄丑丒世七(int[] 且丂专业丆丂丌丆下)
    {
        UnityEngine.LayerMask val_1 = 丛丙上丅丗上丘丐上.丙一专丝下东一丈业(且丂专业丆丂丌丆下:  且丂专业丆丂丌丆下);
        val_1.m_Mask = val_1.m_Mask & 4294967295;
        return (UnityEngine.LayerMask)val_1.m_Mask;
    }
    public static UnityEngine.LayerMask 三一丐丄上不不万七(string[] 丟万丏业丌专一三丛)
    {
        var val_6;
        var val_7;
        UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
        val_6 = val_1.m_Mask;
        val_7 = 0;
        goto label_0;
        label_3:
        val_1.m_Mask = val_6 & 4294967295;
        int val_3 = UnityEngine.LayerMask.NameToLayer(layerName:  丟万丏业丌专一三丛[0]);
        丟万丏业丌专一三丛[0] = val_3 & 31;
        丟万丏业丌专一三丛[0] = 1 << 丟万丏业丌专一三丛[0];
        val_3 = 丟万丏业丌专一三丛[0] | (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = val_1.m_Mask}));
        UnityEngine.LayerMask val_4 = UnityEngine.LayerMask.op_Implicit(intVal:  val_3);
        val_6 = val_4.m_Mask;
        val_7 = 1;
        label_0:
        if(val_7 < 丟万丏业丌专一三丛.Length)
        {
            goto label_3;
        }
        
        return (UnityEngine.LayerMask)val_6 & 4294967295;
    }
    public static UnityEngine.LayerMask 丙一专丝下东一丈业(int[] 且丂专业丆丂丌丆下)
    {
        var val_5;
        var val_6;
        UnityEngine.LayerMask val_1 = UnityEngine.LayerMask.op_Implicit(intVal:  0);
        val_5 = val_1.m_Mask;
        val_6 = 0;
        goto label_0;
        label_3:
        val_1.m_Mask = val_5 & 4294967295;
        int val_2 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = val_1.m_Mask});
        且丂专业丆丂丌丆下[0] = 且丂专业丆丂丌丆下[0] & 31;
        且丂专业丆丂丌丆下[0] = 1 << 且丂专业丆丂丌丆下[0];
        val_2 = 且丂专业丆丂丌丆下[0] | val_2;
        UnityEngine.LayerMask val_3 = UnityEngine.LayerMask.op_Implicit(intVal:  val_2);
        val_5 = val_3.m_Mask;
        val_6 = 1;
        label_0:
        if(val_6 < 且丂专业丆丂丌丆下.Length)
        {
            goto label_3;
        }
        
        return (UnityEngine.LayerMask)val_5 & 4294967295;
    }
    public static UnityEngine.LayerMask 一丝不丟七丟与丄丝(UnityEngine.LayerMask 专丑业丁丗丏丌不丛)
    {
        专丑业丁丗丏丌不丛.m_Mask = 专丑业丁丗丏丌不丛.m_Mask & 4294967295;
        UnityEngine.LayerMask val_2 = UnityEngine.LayerMask.op_Implicit(intVal:  ~(UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = 专丑业丁丗丏丌不丛.m_Mask})));
        val_2.m_Mask = val_2.m_Mask & 4294967295;
        return (UnityEngine.LayerMask)val_2.m_Mask;
    }
    public static UnityEngine.LayerMask 丅上丟万与丒丕丒万(UnityEngine.LayerMask 专丑业丁丗丏丌不丛, string[] 丟万丏业丌专一三丛)
    {
        专丑业丁丗丏丌不丛.m_Mask = 专丑业丁丗丏丌不丛.m_Mask & 4294967295;
        UnityEngine.LayerMask val_2 = 丛丙上丅丗上丘丐上.三一丐丄上不不万七(丟万丏业丌专一三丛:  丟万丏业丌专一三丛);
        val_2.m_Mask = val_2.m_Mask & 4294967295;
        int val_3 = UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = val_2.m_Mask});
        val_3 = val_3 | (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = 专丑业丁丗丏丌不丛.m_Mask}));
        UnityEngine.LayerMask val_4 = UnityEngine.LayerMask.op_Implicit(intVal:  val_3);
        val_4.m_Mask = val_4.m_Mask & 4294967295;
        return (UnityEngine.LayerMask)val_4.m_Mask;
    }
    public static UnityEngine.LayerMask 丐一丑丄丞不东万世(UnityEngine.LayerMask 专丑业丁丗丏丌不丛, string[] 丟万丏业丌专一三丛)
    {
        专丑业丁丗丏丌不丛.m_Mask = 专丑业丁丗丏丌不丛.m_Mask & 4294967295;
        UnityEngine.LayerMask val_2 = UnityEngine.LayerMask.op_Implicit(intVal:  ~(UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = 专丑业丁丗丏丌不丛.m_Mask})));
        val_2.m_Mask = val_2.m_Mask & 4294967295;
        UnityEngine.LayerMask val_4 = 丛丙上丅丗上丘丐上.三一丐丄上不不万七(丟万丏业丌专一三丛:  丟万丏业丌专一三丛);
        val_4.m_Mask = val_4.m_Mask & 4294967295;
        UnityEngine.LayerMask val_7 = UnityEngine.LayerMask.op_Implicit(intVal:  ~((UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = val_4.m_Mask})) | (UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = val_2.m_Mask}))));
        val_7.m_Mask = val_7.m_Mask & 4294967295;
        return (UnityEngine.LayerMask)val_7.m_Mask;
    }
    public static string[] 丆上丅东业丐丏丄丝(UnityEngine.LayerMask 专丑业丁丗丏丌不丛)
    {
        int val_6 = 专丑业丁丗丏丌不丛.m_Mask;
        System.Collections.Generic.List<System.String> val_1 = new System.Collections.Generic.List<System.String>();
        var val_7 = 0;
        val_6 = val_6 & 4294967295;
        do
        {
            if(((UnityEngine.LayerMask.op_Implicit(mask:  new UnityEngine.LayerMask() {m_Mask = val_6})) & 0) != 0)
        {
                string val_4 = UnityEngine.LayerMask.LayerToName(layer:  0);
            if((System.String.IsNullOrEmpty(value:  val_4)) != true)
        {
                val_1.Add(item:  val_4);
        }
        
        }
        
            val_7 = val_7 + 1;
        }
        while(val_7 != 32);
        
        if(val_1 != null)
        {
                return val_1.ToArray();
        }
        
        return val_1.ToArray();
    }
    public static string 丈丛不丘丞丙丂丟丏(UnityEngine.LayerMask 专丑业丁丗丏丌不丛)
    {
        return System.String.Join(separator:  ", ", value:  丛丙上丅丗上丘丐上.丆上丅东业丐丏丄丝(专丑业丁丗丏丌不丛:  new UnityEngine.LayerMask() {m_Mask = 专丑业丁丗丏丌不丛.m_Mask & 4294967295}));
    }
    public static string 丈丛不丘丞丙丂丟丏(UnityEngine.LayerMask 专丑业丁丗丏丌不丛, string 丁与丄丕丞丈一丐业)
    {
        专丑业丁丗丏丌不丛.m_Mask = 专丑业丁丗丏丌不丛.m_Mask & 4294967295;
        return System.String.Join(separator:  丁与丄丕丞丈一丐业, value:  丛丙上丅丗上丘丐上.丆上丅东业丐丏丄丝(专丑业丁丗丏丌不丛:  new UnityEngine.LayerMask() {m_Mask = 专丑业丁丗丏丌不丛.m_Mask}));
    }

}
