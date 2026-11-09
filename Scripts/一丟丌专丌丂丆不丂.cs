using UnityEngine;
private sealed class PetEngine.一丟丌专丌丂丆不丂
{
    // Fields
    public Rilisoft.PetEngine 丝且与丝丒丟万丁专;
    public float 丗丞丛下丁东丐七专;
    public 丅丙上七上一丐不下 丂丈丙且丈丗三丆丕;
    public bool 丝七丏东专七与丌丒;
    
    // Methods
    public PetEngine.一丟丌专丌丂丆不丂()
    {
    
    }
    internal void 丅丐丄世七丌上一丑()
    {
        var val_11;
        if((this.丝且与丝丒丟万丁专._info.Effects.Contains(item:  81)) != false)
        {
                float val_11 = this.丗丞丛下丁东丐七专;
            val_11 = val_11 * this.丝且与丝丒丟万丁专._info.VampiricDamageMultiplier;
            bool val_2 = this.丝且与丝丒丟万丁专._owner.丂丟丙丂丕专丂七下(上上丗丁丏丙丄丏七:  val_11, 丑东与丅丐丅丂丞业:  2);
        }
        
        PetInfo val_3 = this.丝且与丝丒丟万丁专.丙丕丞且丕不丘丙丑();
        UnityEngine.Vector3 val_6 = this.丝且与丝丒丟万丁专.transform.position;
        val_11 = null;
        val_11 = null;
        var val_12 = 0;
        val_12 = val_12 + 1;
        this.丂丈丙且丈丗三丆丕.ApplyDamage(丞丈专下丈专业三丞:  this.丗丞丛下丁东丐七专, 丛世一丟丞丁业丘丒:  this.丝且与丝丒丟万丁专, 专不丑且不丏东丟丅:  0, 且一丘丛丘丞丐丐业:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z}, 丐丟丘世丁三丕专专:  (this.丝七丏东专七与丌丒 == true) ? 18 : 15, 东丏业丞丞业下丄世:  0, 丝三丛且丘不丌丙下:  val_3.Id + "_up0", 丒丈丐丐丗丐专丈丏:  GetComponent<PixelView>().viewID);
    }

}
