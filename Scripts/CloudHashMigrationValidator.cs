using UnityEngine;
internal class CloudHashMigrationValidator : MonoBehaviour
{
    // Fields
    private static 且万上世上丝丏丕丑 <万七丞丙丆万万一丙>k__BackingField;
    private static bool <丆与不丟三不三丒七>k__BackingField;
    private static bool <丒丒丑不丆丈丌丙丕>k__BackingField;
    private static CloudHashMigrationValidator 丝业丆丁业三丈丟东;
    
    // Properties
    internal static CloudHashMigrationValidator 丆丕丝丒不丙且丐丗 { get; }
    internal static 且万上世上丝丏丕丑 丝万丘丄东丟且世丝 { get; set; }
    internal static bool 且专丝下丒丘与丌丕 { get; set; }
    internal static bool 下上东一丁丏丂丘丆 { get; set; }
    
    // Methods
    internal static CloudHashMigrationValidator 丑七不且上丗丁一世()
    {
        CloudHashMigrationValidator val_4;
        var val_5;
        val_4 = CloudHashMigrationValidator.丝业丆丁业三丈丟东;
        if(val_4 == 0)
        {
                UnityEngine.GameObject val_2 = null;
            val_4 = val_2;
            val_2 = new UnityEngine.GameObject(name:  "CloudHashMigrationValidator");
            UnityEngine.Object.DontDestroyOnLoad(target:  val_2);
            val_5 = null;
            CloudHashMigrationValidator.丝业丆丁业三丈丟东 = val_2.AddComponent<CloudHashMigrationValidator>();
            return (CloudHashMigrationValidator)CloudHashMigrationValidator.丝业丆丁业三丈丟东;
        }
        
        val_5 = null;
        return (CloudHashMigrationValidator)CloudHashMigrationValidator.丝业丆丁业三丈丟东;
    }
    internal static bool 七一一丑七丒上丐丑(bool 丛专下丞丒丛下下与 = True)
    {
        string val_12;
        var val_14;
        var val_15;
        var val_16;
        var val_17;
        var val_18;
        val_12 = 丛专下丞丒丛下下与;
        if((CloudHashMigrationValidator.<丆与不丟三不三丒七>k__BackingField) == false)
        {
            goto label_2;
        }
        
        var val_1 = ((CloudHashMigrationValidator.<丒丒丑不丆丈丌丙丕>k__BackingField) == true) ? 1 : 0;
        if((CloudHashMigrationValidator.<丒丒丑不丆丈丌丙丕>k__BackingField) == false)
        {
                return (bool)val_14;
        }
        
        if(val_12 == false)
        {
                return (bool)val_14;
        }
        
        val_15 = null;
        val_15 = null;
        if((丌丝世丞世丛丆丅丟.丝丛丑丁丞七不丒业(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丁一与万与丈不七丌)) == false)
        {
            goto label_10;
        }
        
        val_16 = null;
        val_16 = null;
        val_12 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  与丂丏丛丞丞丒丟丄.丁一与万与丈不七丌);
        if((System.DateTime.TryParse(s:  val_12, result: out  new System.DateTime())) == true)
        {
            goto label_24;
        }
        
        System.DateTime val_5 = 专七专下且专三一且.丐世丈专与东丏丛丑();
        val_17 = null;
        val_17 = null;
        val_12 = 与丂丏丛丞丞丒丟丄.丁一与万与丈不七丌;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_12, 下下丏一丙不丘丌丞:  val_5.dateData);
        goto label_24;
        label_10:
        System.DateTime val_6 = 专七专下且专三一且.丐世丈专与东丏丛丑();
        val_18 = null;
        val_18 = null;
        val_12 = 与丂丏丛丞丞丒丟丄.丁一与万与丈不七丌;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  val_12, 下下丏一丙不丘丌丞:  val_6.dateData);
        label_24:
        System.DateTime val_7 = System.DateTime.UtcNow;
        System.TimeSpan val_8 = System.DateTime.op_Subtraction(d1:  new System.DateTime() {dateData = val_7.dateData}, d2:  new System.DateTime() {dateData = val_6.dateData});
        return (bool)val_14;
        label_2:
        val_14 = 0;
        return (bool)val_14;
    }
    internal static void 丄万丁三业万丛东丑()
    {
        CloudHashMigrationValidator.<丆与不丟三不三丒七>k__BackingField = false;
    }
    internal static 且万上世上丝丏丕丑 世丒丕一不丂三七万()
    {
        return (且万上世上丝丏丕丑)CloudHashMigrationValidator.<万七丞丙丆万万一丙>k__BackingField;
    }
    private static void 丒丈三丝专世丙丞丐(且万上世上丝丏丕丑 丙业与丙丗丝不丈东)
    {
        CloudHashMigrationValidator.<万七丞丙丆万万一丙>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static bool 丅不丝丂世七丝不丁()
    {
        return (bool)CloudHashMigrationValidator.<丆与不丟三不三丒七>k__BackingField;
    }
    private static void 丙丛与丝且世丌丙三(bool 丙业与丙丗丝不丈东)
    {
        CloudHashMigrationValidator.<丆与不丟三不三丒七>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static bool 丐世丄丝丞世业丐丒()
    {
        return (bool)CloudHashMigrationValidator.<丒丒丑不丆丈丌丙丕>k__BackingField;
    }
    private static void 丒丑丒丂丏丝专丆丝(bool 丙业与丙丗丝不丈东)
    {
        CloudHashMigrationValidator.<丒丒丑不丆丈丌丙丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Start()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  CloudHashMigrationValidator.丕与丒丞上丄丐三与());
    }
    private static System.Collections.Generic.List<且万上世上丝丏丕丑> 不七一万丑丗丅丟上()
    {
        object val_13 = 0;
        object val_15 = 0;
        object val_26 = 0;
        object val_34 = 0;
        if(Rilisoft.丐丌丝七下丈丒丅丗.丑七不且上丗丁一世() == null)
        {
                return 0;
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  专丈专业丆且且业下.世丈丞丅丂丞丕丗丗())) == true)
        {
                return 0;
        }
        
        string val_5 = Rilisoft.丐丌丝七下丈丒丅丗.丑七不且上丗丁一世().丏七丆下一业丙世丆();
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) == true)
        {
                return 0;
        }
        
        object val_7 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_5);
        return 0;
    }
    private static System.Collections.IEnumerator 一丅丛丐三下且上业()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new CloudHashMigrationValidator.丆丁下丐丝一丛丟三();
    }
    private static System.Collections.IEnumerator 丕与丒丞上丄丐三与()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new CloudHashMigrationValidator.丙丆与丙丝丛丛专世();
    }
    public CloudHashMigrationValidator()
    {
    
    }

}
