using UnityEngine;
internal sealed class FreePlayThematicSoundsController : PGBehaviour
{
    // Fields
    private string <一不世丌且一丆丆丛>k__BackingField;
    private readonly string 丕三丝三东丈下万丅;
    private float 丗丑与万东丂三丙丙;
    private static FreePlayThematicSoundsController <不丁丄七丛不丆丁丕>k__BackingField;
    private UnityEngine.Coroutine 丄丙丏东丒丗丕丐世;
    
    // Properties
    internal string 丕丞东专东丐丘丞丏 { get; set; }
    internal static FreePlayThematicSoundsController 丆丕丝丒不丙且丐丗 { get; set; }
    
    // Methods
    internal string 与丄下丗且丙东丆丒()
    {
        return (string)this.<一不世丌且一丆丆丛>k__BackingField;
    }
    private void 不万不丝专丞七丈丅(string 丙业与丙丗丝不丈东)
    {
        this.<一不世丌且一丆丆丛>k__BackingField = 丙业与丙丗丝不丈东;
    }
    internal static FreePlayThematicSoundsController 丑七不且上丗丁一世()
    {
        return (FreePlayThematicSoundsController)FreePlayThematicSoundsController.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(FreePlayThematicSoundsController 丙业与丙丗丝不丈东)
    {
        FreePlayThematicSoundsController.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void Awake()
    {
        FreePlayThematicSoundsController.<不丁丄七丛不丆丁丕>k__BackingField = this;
        float val_1 = 与丂丏丛丞丞丒丟丄.业且丞丂一与不七丑();
        val_1 = val_1 * 0.5f;
        this.丗丑与万东丂三丙丙 = val_1;
    }
    internal void 且丕上丙东专万丝业(string 七不丐下丟专业万丅)
    {
        if(this.丄丙丏东丒丗丕丐世 != null)
        {
                this.StopCoroutine(routine:  this.丄丙丏东丒丗丕丐世);
        }
        
        if((System.String.op_Equality(a:  七不丐下丟专业万丅, b:  this.<一不世丌且一丆丆丛>k__BackingField)) == true)
        {
                return;
        }
        
        this.丄丙丏东丒丗丕丐世 = this.StartCoroutine(routine:  this.丑业丕丗丝丙丛万丈(七不丐下丟专业万丅:  七不丐下丟专业万丅));
    }
    private System.Collections.IEnumerator 丑业丕丗丝丙丛万丈(string 七不丐下丟专业万丅)
    {
        FreePlayThematicSoundsController.丌丄丌丄不丅丄丆丒 val_1 = new FreePlayThematicSoundsController.丌丄丌丄不丅丄丆丒();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .七不丐下丟专业万丅 = 七不丐下丟专业万丅;
        return (System.Collections.IEnumerator)val_1;
    }
    internal void 丞丗丕专丁丟丕东丟()
    {
        if(this.丄丙丏东丒丗丕丐世 != null)
        {
                this.StopCoroutine(routine:  this.丄丙丏东丒丗丕丐世);
        }
        
        this.丄丙丏东丒丗丕丐世 = this.StartCoroutine(routine:  this.与业三业丁丅上东业());
    }
    private System.Collections.IEnumerator 与业三业丁丅上东业()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FreePlayThematicSoundsController.丗丗丝丞丑丘三丐丕();
    }
    private void OnDestroy()
    {
        MenuBackgroundMusic val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        val_4 = 1152921505171275776;
        val_5 = null;
        val_5 = null;
        if(与丂丏丛丞丞丒丟丄.下丏丄丛丅业丄世下 == false)
        {
                return;
        }
        
        val_6 = null;
        val_6 = null;
        val_4 = MenuBackgroundMusic.丌丂一丛下丒丞丛东;
        if((UnityEngine.Object.op_Implicit(exists:  val_4)) == false)
        {
                return;
        }
        
        val_4.三且世三丂七丐一丟();
        val_7 = null;
        val_7 = null;
        if(BackgroundMusicController.丄丘七三上丕世丞业 == 0)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        val_4.丛丗丐丝丁丄丙丞丘(丞下上且一上丙不丏:  BackgroundMusicController.丄丘七三上丕世丞业.丘上丌世丑丌万丏丁());
    }
    public FreePlayThematicSoundsController()
    {
        this.丗丑与万东丂三丙丙 = 3f;
        this.丕三丝三东丈下万丅 = "FreePlayThematicSounds";
    }

}
