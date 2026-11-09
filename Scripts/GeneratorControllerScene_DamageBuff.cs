using UnityEngine;
internal sealed class GeneratorControllerScene_DamageBuff : GeneratorControllerScene
{
    // Fields
    private UnityEngine.Transform 丅专与丒丈丗丒丘丌;
    private float 丑丗丘与丈不七东丛;
    
    // Methods
    private void Start()
    {
        this.丅专与丒丈丗丒丘丌 = this.丌丟丄业且三丛丕丄();
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丗丆丝丒丒丌丁丒不());
    }
    internal void 不丝丐丒丛上丒丁丕(UnityEngine.Transform 丅专与丒丈丗丒丘丌)
    {
        this.丅专与丒丈丗丒丘丌 = 丅专与丒丈丗丒丘丌;
    }
    private System.Collections.IEnumerator 丗丆丝丒丒丌丁丒不()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new GeneratorControllerScene_DamageBuff.丏业丁下上丛丁且丘();
    }
    public GeneratorControllerScene_DamageBuff()
    {
        this.丑丗丘与丈不七东丛 = 1f;
        val_1 = new FortEquipObject();
    }

}
