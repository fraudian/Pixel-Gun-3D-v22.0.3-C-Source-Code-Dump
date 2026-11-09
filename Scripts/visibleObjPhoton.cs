using UnityEngine;
internal class visibleObjPhoton : MonoBehaviour
{
    // Fields
    private bool 不与万丌一丈下丑丈;
    internal PlayerSynchStream lerpScript;
    
    // Methods
    private void Awake()
    {
        var val_1 = null;
        if((与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false) && (与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 != false))
        {
                return;
        }
        
        this.enabled = false;
    }
    private void OnBecameVisible()
    {
        PlayerSynchStream val_2;
        int val_3;
        val_2 = this;
        this.不与万丌一丈下丑丈 = true;
        if(this.lerpScript == 0)
        {
                return;
        }
        
        val_2 = this.lerpScript;
        if(val_2 != null)
        {
                val_3 = this.lerpScript.丂丈万丂上丒专不丂;
        }
        else
        {
                val_2 = 40;
            val_3 = 135970152;
        }
        
        mem[40] = 135970153;
    }
    private void OnBecameInvisible()
    {
        PlayerSynchStream val_3;
        PlayerSynchStream val_4;
        int val_5;
        val_3 = this;
        this.不与万丌一丈下丑丈 = false;
        if(this.lerpScript == 0)
        {
                return;
        }
        
        val_4 = this.lerpScript;
        if(val_4 != null)
        {
                val_5 = this.lerpScript.丂丈万丂上丒专不丂;
        }
        else
        {
                val_4 = 40;
            val_5 = 135970152;
        }
        
        mem[40] = 135970151;
        val_3 = this.lerpScript;
        float val_3 = 2f;
        val_3 = UnityEngine.Time.realtimeSinceStartup + val_3;
        this.lerpScript.世专丞丄丙丌丞丂丙 = val_3;
    }
    public visibleObjPhoton()
    {
    
    }

}
