using UnityEngine;
public sealed class 世丘业丐东与万不与
{
    // Fields
    private static 世丘业丐东与万不与 丝业丆丁业三丈丟东;
    private string 丏世丑万世一七丟丞;
    private string 东世且下丟七丄三丝;
    private bool 丄世丗丗丌业丙丏丅;
    
    // Properties
    public static 世丘业丐东与万不与 丆丕丝丒不丙且丐丗 { get; }
    public string 下丄丈不与世丐业专 { get; }
    public bool 东专丅丑不丄下丛丅 { get; }
    public string 丕丆一下一上丅与丘 { get; }
    
    // Methods
    public static 世丘业丐东与万不与 丑七不且上丗丁一世()
    {
        世丘业丐东与万不与 val_2 = 世丘业丐东与万不与.丝业丆丁业三丈丟东;
        if(val_2 != null)
        {
                return val_2;
        }
        
        世丘业丐东与万不与 val_1 = null;
        val_2 = val_1;
        val_1 = new 世丘业丐东与万不与();
        世丘业丐东与万不与.丝业丆丁业三丈丟东 = val_2;
        return val_2;
    }
    public 世丘业丐东与万不与()
    {
        this.丏世丑万世一七丟丞 = System.String.alignConst;
        this.丄世丗丗丌业丙丏丅 = false;
        this.东世且下丟七丄三丝 = System.String.alignConst;
    }
    public string 业上丙丞丐丄丆丅七()
    {
        return (string)this.丏世丑万世一七丟丞;
    }
    public bool 世丘丙东不上不丘下()
    {
        return (bool)this.丄世丗丗丌业丙丏丅;
    }
    public string 丂丑丂丝专上丘东丑()
    {
        return (string)this.东世且下丟七丄三丝;
    }
    public void 丛丗上丝业下不丈丟(System.Action<bool> 业丏丈世世世丞丒世)
    {
        UnityEngine.Coroutine val_2 = CoroutineRunner.Start(丂丒丐下丑丏丐专上:  this.丂且且丁七上且丈万(业丏丈世世世丞丒世:  业丏丈世世世丞丒世));
    }
    public void 丛丗下世丆丕丟丟丒()
    {
        this.丏世丑万世一七丟丞 = System.String.alignConst;
        this.丄世丗丗丌业丙丏丅 = false;
        this.东世且下丟七丄三丝 = System.String.alignConst;
    }
    private bool 丞丆丗丒不丈专丛下(string 业丄万一丑丏业上丐)
    {
        string val_8;
        var val_9;
        string val_8 = 业丄万一丑丏业上丐;
        object val_3 = 0;
        object val_6 = 0;
        this.丏世丑万世一七丟丞 = System.String.alignConst;
        this.丄世丗丗丌业丙丏丅 = false;
        this.东世且下丟七丄三丝 = System.String.alignConst;
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_8)) != true)
        {
                object val_2 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_8);
            if(val_2 == null)
        {
                return (bool)val_9;
        }
        
            val_8 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_2) : 0;
            if((val_8.TryGetValue(key:  "id", value: out  val_3)) != false)
        {
                val_8 = val_3;
            if((val_8 != 0) && (1179403647 == null))
        {
                if((System.String.op_Equality(a:  val_8, b:  System.String.alignConst)) == false)
        {
            goto label_11;
        }
        
        }
        
        }
        
        }
        
        val_9 = 0;
        return (bool)val_9;
        label_11:
        this.丏世丑万世一七丟丞 = val_8;
        this.丄世丗丗丌业丙丏丅 = true;
        if((val_8.TryGetValue(key:  "name", value: out  val_6)) == false)
        {
                return (bool)val_9;
        }
        
        if(val_6 == 0)
        {
                return (bool)val_9;
        }
        
        if(1179403647 != null)
        {
                return (bool)val_9;
        }
        
        this.东世且下丟七丄三丝 = val_6;
        return (bool)val_9;
    }
    private System.Collections.IEnumerator 丂且且丁七上且丈万(System.Action<bool> 业丏丈世世世丞丒世)
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .业丏丈世世世丞丒世 = 业丏丈世世世丞丒世;
        return (System.Collections.IEnumerator)new 世丘业丐东与万不与.七一业业丛丅且万丐();
    }

}
