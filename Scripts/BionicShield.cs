using UnityEngine;
internal sealed class BionicShield : PGBehaviour
{
    // Methods
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Collider val_4 = 丘丛丏丘丝七世七丅;
        丅丙上七上一丐不下 val_1 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  val_4);
        if(val_1 == null)
        {
                return;
        }
        
        val_4 = (((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_1) : 0;
    }
    private void OnTriggerExit(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        UnityEngine.Collider val_4 = 丘丛丏丘丝七世七丅;
        丅丙上七上一丐不下 val_1 = HitBox.丁且丑丏一丈丛丑一(且丙与丏下丅丐世丑:  val_4);
        if(val_1 == null)
        {
                return;
        }
        
        val_4 = (((丅丙上七上一丐不下.__il2cppRuntimeField_typeHierarchy + (PlayerDamageable.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_1) : 0;
    }
    internal void 专丘丙丁丒业丛东下()
    {
        UnityEngine.Coroutine val_5 = this.StartCoroutine(routine:  this.丝东丐世一东与万丘(丕丕世且下一与丝与:  丁下万丟且丟丛下业.一三专丞丒丅上业上().Item["gadget_bionic_shield"].丌丛丟丙丘丝丂一不()));
    }
    private System.Collections.IEnumerator 丝东丐世一东与万丘(float 丕丕世且下一与丝与)
    {
        BionicShield.丏业丞专丒一业丕丝 val_1 = new BionicShield.丏业丞专丒一业丕丝();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[40] = this;
        }
        
        .丕丕世且下一与丝与 = 丕丕世且下一与丝与;
        return (System.Collections.IEnumerator)val_1;
    }
    public BionicShield()
    {
    
    }

}
