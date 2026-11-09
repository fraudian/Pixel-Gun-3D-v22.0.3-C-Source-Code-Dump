using UnityEngine;
internal class FpcShoppingAreaStateController : AreaBase
{
    // Fields
    public 丟丞世万丈丒丒上丟 defaultState;
    public UnityEngine.GameObject availableBorder;
    public UnityEngine.GameObject boughteBorder;
    public UnityEngine.GameObject notavailableBorder;
    private 丟丞世万丈丒丒上丟 <丒一七丙万业上且三>k__BackingField;
    
    // Properties
    internal 丟丞世万丈丒丒上丟 丙丟与丐三丐万万丆 { get; set; }
    
    // Methods
    internal 丟丞世万丈丒丒上丟 丄丙丂丝丄丌丗丂丅()
    {
        return (丟丞世万丈丒丒上丟)this.<丒一七丙万业上且三>k__BackingField;
    }
    private void 丌七丗东三丏东丅丕(丟丞世万丈丒丒上丟 丙业与丙丗丝不丈东)
    {
        this.<丒一七丙万业上且三>k__BackingField = 丙业与丙丗丝不丈东;
    }
    protected override void Awake()
    {
        this.Awake();
        this.丄丑七丘丁且丞丙专(与丆丌丂丟丛丘丑且:  this.defaultState);
    }
    internal void 丄丑七丘丁且丞丙专(丟丞世万丈丒丒上丟 与丆丌丂丟丛丘丑且)
    {
        this.<丒一七丙万业上且三>k__BackingField = 与丆丌丂丟丛丘丑且;
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.availableBorder, 丏业丟一东丂东丘丛:  (与丆丌丂丟丛丘丑且 == 1) ? 1 : 0);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.boughteBorder, 丏业丟一东丂东丘丛:  ((this.<丒一七丙万业上且三>k__BackingField) == 2) ? 1 : 0);
        丞东丑专丛丆丄丝世.丗丄且丑世七且专一(丝三丁东丈丒世丅业:  this.notavailableBorder, 丏业丟一东丂东丘丛:  ((this.<丒一七丙万业上且三>k__BackingField) == 3) ? 1 : 0);
    }
    public FpcShoppingAreaStateController()
    {
    
    }

}
