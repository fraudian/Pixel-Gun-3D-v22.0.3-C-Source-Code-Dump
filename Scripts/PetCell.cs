using UnityEngine;
public class PetCell : BaseArmoryCellWithEquips
{
    // Fields
    private Holoville.HOTween.Tweener 三丒丏丅七丝丐丞丈;
    private bool 三丟世丘世上丁丟业;
    public UnityEngine.GameObject equipped;
    private UnityEngine.GameObject upgradeArrows;
    public UnityEngine.GameObject upgradeStar;
    private bool <丑丐与丅丅丛专丑丂>k__BackingField;
    
    // Properties
    private bool 三丂丌万专丆且丆丄 { get; set; }
    
    // Methods
    private bool 下东丑丞丑下下丑丈()
    {
        return (bool)this.<丑丐与丅丅丛专丑丂>k__BackingField;
    }
    private void 三且丁丆与专丈与丁(bool 丙业与丙丗丝不丈东)
    {
        this.<丑丐与丅丅丛专丑丂>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Start()
    {
    
    }
    private void Update()
    {
    
    }
    internal override void 丐且专丙三丕丞专丅(三丅丁丗丗丝丂万且 丆丐七世世且丏丐业)
    {
        string val_4 = this.ItemId;
        val_4 = System.String.op_Equality(a:  丆丐七世世且丏丐业.与不丞丑七丘丁丂丛(), b:  val_4);
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_4);
    }
    private void 丞丁丑且丞丈不上丑(bool 丗丛不丁丑专专丂且)
    {
        丗丛不丁丑专专丂且 = (((this.<丑丐与丅丅丛专丑丂>k__BackingField) == false) ? 1 : 0) & 丗丛不丁丑专专丂且;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.equipped, 丏业丟一东丂东丘丛:  丗丛不丁丑专专丂且);
    }
    protected override void 丂丗上专丘丌丙丛丏(string 丈丄丁丂丞丑下下丄, CategoryNames 上丌丛不业与世丑丏, string 与丑与丒丟丗万丙丁)
    {
    
    }
    protected override void 丌丌且东丒丈丐丌丌(CategoryNames 上丌丛不业与世丑丏, string 与丑与丒丟丗万丙丁)
    {
    
    }
    protected override void 且专下万东丄不万且(string 一丕且丌业下丂丏且, string 丈丈世三万世三上丑)
    {
        if(this.Category != 25000)
        {
                return;
        }
        
        string val_4 = 一丕且丌业下丂丏且;
        val_4 = System.String.op_Equality(a:  this.ItemId, b:  val_4);
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  val_4);
    }
    protected override void 世且丞丞丁丅丟世丞(string 万且万且丑丗且丌丆)
    {
        if(this.Category != 25000)
        {
                return;
        }
        
        this.丞丁丑且丞丈不上丑(丗丛不丁丑专专丂且:  false);
    }
    private void 丘丆三丂专专万丐三()
    {
        if(this.三丟世丘世上丁丟业 != false)
        {
                if(this.upgradeArrows != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradeArrows, 丏业丟一东丂东丘丛:  true);
        }
        
            if(this.三丒丏丅七丝丐丞丈 != null)
        {
                return;
        }
        
            UnityEngine.Vector3 val_3 = UnityEngine.Vector3.up;
            UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  8f);
            this.三丒丏丅七丝丐丞丈 = Holoville.HOTween.HOTween.To(p_target:  this.upgradeArrows.transform, p_duration:  1.5f, p_parms:  new Holoville.HOTween.TweenParms().Prop(p_propName:  "localPosition", p_endVal:  val_4).Ease(p_easeType:  0).UpdateType(p_updateType:  3).Loops(p_loops:  0, p_loopType:  1));
            return;
        }
        
        if(this.upgradeArrows != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.upgradeArrows, 丏业丟一东丂东丘丛:  false);
            UnityEngine.Vector3 val_13 = UnityEngine.Vector3.zero;
            this.upgradeArrows.transform.localPosition = new UnityEngine.Vector3() {x = val_13.x, y = val_13.y, z = val_13.z};
        }
        
        if(this.三丒丏丅七丝丐丞丈 == null)
        {
                return;
        }
        
        this.三丒丏丅七丝丐丞丈.Kill();
        this.三丒丏丅七丝丐丞丈 = 0;
    }
    public PetCell()
    {
    
    }

}
