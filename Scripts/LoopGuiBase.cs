using UnityEngine;
public class LoopGuiBase : MonoBehaviour
{
    // Fields
    private CategoryNames <丄上丞不三与一丅丒>k__BackingField;
    private string <七七七丒业丗丅且丛>k__BackingField;
    private string <丂业万丟丈丆丒丘万>k__BackingField;
    private bool <丛丑专一万丞丄丐不>k__BackingField;
    private bool <东丁丘丄七丅与上丅>k__BackingField;
    private System.Action <丘丟丞丄专下世丈丕>k__BackingField;
    private UnityEngine.Coroutine 丞丟三丆且丗专丘丕;
    private LoopGuiRefsKeeper 丟丟专丘丙世丅丝丟;
    private PGCompany.GameplayLoop.GameplayLoopType 丌上丕丆丕七丗三丝;
    
    // Properties
    internal PGCompany.GameplayLoop.GameplayLoopType 世丛丆丏丒一业一东 { get; set; }
    internal CategoryNames 七丌丌丏丗东丕且丅 { get; set; }
    internal string 与丙丌丈下万业丙丕 { get; set; }
    internal string 丑丛丑七丅丁东丅丌 { get; set; }
    internal bool 且丛与世丄丗丈丟丈 { get; set; }
    internal bool 丑丂丕上丏上业丐且 { get; set; }
    internal System.Action 丝丑世下业丏丙丕不 { get; set; }
    
    // Methods
    internal PGCompany.GameplayLoop.GameplayLoopType 丁丆丘七丏丄丂专丈()
    {
        return (PGCompany.GameplayLoop.GameplayLoopType)this.丌上丕丆丕七丗三丝;
    }
    private void 上世专丗七且丒丙丒(PGCompany.GameplayLoop.GameplayLoopType 丙业与丙丗丝不丈东)
    {
        this.丌上丕丆丕七丗三丝 = 丙业与丙丗丝不丈东;
    }
    internal CategoryNames 丒万丕七专不丏丞丌()
    {
        return (CategoryNames)this.<丄上丞不三与一丅丒>k__BackingField;
    }
    private void 与丘丑丒丅丕丞七丈(CategoryNames 丙业与丙丗丝不丈东)
    {
        this.<丄上丞不三与一丅丒>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal string 丐丙世七丅丅丐下丙()
    {
        return (string)this.<七七七丒业丗丅且丛>k__BackingField;
    }
    private void 丆世丄丐丐与丄下三(string 丙业与丙丗丝不丈东)
    {
        this.<七七七丒业丗丅且丛>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal string 丗万上丏丄丅丗丂专()
    {
        return (string)this.<丂业万丟丈丆丒丘万>k__BackingField;
    }
    private void 东丄丄丂丒丐东丛丛(string 丙业与丙丗丝不丈东)
    {
        this.<丂业万丟丈丆丒丘万>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 东丂丄丒丅三丈丞丄()
    {
        return (bool)this.<丛丑专一万丞丄丐不>k__BackingField;
    }
    private void 丑丁丄丙下且丗不丆(bool 丙业与丙丗丝不丈东)
    {
        this.<丛丑专一万丞丄丐不>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal bool 下丄丟丅世世丛下丆()
    {
        return (bool)this.<东丁丘丄七丅与上丅>k__BackingField;
    }
    private void 丐上丄丆丗与专下万(bool 丙业与丙丗丝不丈东)
    {
        this.<东丁丘丄七丅与上丅>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal System.Action 丞且东不丘上丟七丞()
    {
        return (System.Action)this.<丘丟丞丄专下世丈丕>k__BackingField;
    }
    private void 业且三东七专业世万(System.Action 丙业与丙丗丝不丈东)
    {
        this.<丘丟丞丄专下世丈丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal void 丈且东丑丂且万丒丅(string 丞一丁业丄一一业且, CategoryNames 七丆丒与丗丌丄且丂, PGCompany.GameplayLoop.GameplayLoopType 上丒一丂丞丅丏丅丂, string 丗丄专丐三丞与丏专, bool 丑丗丕丈丒不丙专丐, bool 一丏且丏东丌丈丄且, System.Action 专丐丛丑丞丕丌与丛)
    {
        UnityEngine.GameObject val_14;
        CategoryNames val_14 = 七丆丒与丗丌丄且丂;
        this.<丄上丞不三与一丅丒>k__BackingField = val_14;
        this.丌上丕丆丕七丗三丝 = 上丒一丂丞丅丏丅丂;
        this.<七七七丒业丗丅且丛>k__BackingField = 丞一丁业丄一一业且;
        this.<丂业万丟丈丆丒丘万>k__BackingField = 丗丄专丐三丞与丏专;
        this.<丘丟丞丄专下世丈丕>k__BackingField = 专丐丛丑丞丕丌与丛;
        this.<丛丑专一万丞丄丐不>k__BackingField = 丑丗丕丈丒不丙专丐;
        this.<东丁丘丄七丅与上丅>k__BackingField = 一丏且丏东丌丈丄且;
        LoopGuiRefsKeeper val_3 = this.GetComponent<LoopGuiRefsKeeper>();
        this.丟丟专丘丙世丅丝丟 = val_3;
        if(val_3 == 0)
        {
                object[] val_5 = new object[1];
            val_5[0] = this.name;
            UnityEngine.Debug.LogErrorFormat(format:  "LoopGuiBase Setup refs == null  {0}", args:  val_5);
            return;
        }
        
        val_14 = this.丟丟专丘丙世丅丝丟.weaponTypeContainer;
        if(val_14 != 0)
        {
                val_14 = this.丟丟专丘丙世丅丝丟.weaponTypeContainer;
            val_14 = ((val_14 != 160000) ? 1 : 0) & ((val_14 != 210000) ? 1 : 0);
            val_14.SetActive(value:  val_14);
        }
        
        if(this.丟丟专丘丙世丅丝丟.MaxDamagBG != 0)
        {
                this.丟丟专丘丙世丅丝丟.MaxDamagBG.SetActive(value:  false);
        }
        
        if(this.丟丟专丘丙世丅丝丟.barBG != 0)
        {
                this.丟丟专丘丙世丅丝丟.barBG.SetActive(value:  false);
        }
        
        if(this.丞丟三丆且丗专丘丕 != null)
        {
                this.StopCoroutine(routine:  this.丞丟三丆且丗专丘丕);
        }
        
        this.丞丟三丆且丗专丘丕 = this.StartCoroutine(routine:  this.丘丟万丌丄三丏丈业());
    }
    private void OnEnable()
    {
        if(this.丞丟三丆且丗专丘丕 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丞丟三丆且丗专丘丕);
        this.丞丟三丆且丗专丘丕 = this.StartCoroutine(routine:  this.丘丟万丌丄三丏丈业());
    }
    private System.Collections.IEnumerator 丘丟万丌丄三丏丈业()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new LoopGuiBase.丘不丒丐丑与丒下专();
    }
    public LoopGuiBase()
    {
        this.丌上丕丆丕七丗三丝 = 0;
    }

}
