using UnityEngine;
internal sealed class CameraMoverDirectoryManager : PGBehaviour
{
    // Fields
    internal UnityEngine.Vector3 defaultRotation;
    internal float defaultRotationSpeed;
    private float 丟世丙东丂丟且丕丞;
    internal float returnSpeed;
    internal static CameraMoverDirectoryManager 丄丘七三上丕世丞业;
    private System.Collections.Generic.List<CameraMoverForDirectory> cameraMoverSettings;
    private System.Collections.Generic.Dictionary<string, CameraMoverForDirectory> 世七七不不丐丕丞丏;
    
    // Methods
    private void Awake()
    {
        CameraMoverDirectoryManager.丄丘七三上丕世丞业 = this;
    }
    private void Start()
    {
        this.丕七丌丏丐丆不上不();
        this.丟世丙东丂丟且丕丞 = GestureCamera.ZoomValue01;
    }
    private void 丕七丌丏丐丆不上不()
    {
        var val_7;
        var val_8;
        this.世七七不不丐丕丞丏.Clear();
        val_7 = 0;
        goto label_2;
        label_14:
        val_8 = 0;
        goto label_3;
        label_12:
        CameraMoverForDirectory val_1 = this.cameraMoverSettings.Item[0];
        this.世七七不不丐丕丞丏.Add(key:  val_1.subdirectoryNames.Item[0], value:  this.cameraMoverSettings.Item[0]);
        val_8 = 1;
        label_3:
        CameraMoverForDirectory val_4 = this.cameraMoverSettings.Item[0];
        if(val_8 < val_4.subdirectoryNames.Count)
        {
            goto label_12;
        }
        
        val_7 = 1;
        label_2:
        if(val_7 < this.cameraMoverSettings.Count)
        {
            goto label_14;
        }
    
    }
    internal CameraMoverForDirectory 且丒丐丗七不三丟丐(string 三业三业业丆丂世丝)
    {
        var val_3;
        if((this.世七七不不丐丕丞丏.ContainsKey(key:  三业三业业丆丂世丝)) != false)
        {
                CameraMoverForDirectory val_2 = this.世七七不不丐丕丞丏.Item[三业三业业丆丂世丝];
            return (CameraMoverForDirectory)val_3;
        }
        
        val_3 = 0;
        return (CameraMoverForDirectory)val_3;
    }
    internal void 丛丛丟丁丛一丕丞丝(string 七丆丒与丗丌丄且丂, string 丒丑丞丁世丌专不丈)
    {
        CameraMoverForDirectory val_4 = this.且丒丐丗七不三丟丐(三业三业业丆丂世丝:  丒丑丞丁世丌专不丈);
        if(val_4 == null)
        {
                val_4 = this.且丒丐丗七不三丟丐(三业三业业丆丂世丝:  七丆丒与丗丌丄且丂);
            if(val_4 == null)
        {
                return;
        }
        
        }
        
        this.丟世丙东丂丟且丕丞 = GestureCamera.ZoomValue01;
        val_4.三不丁三丕且丌万丏();
    }
    private void 丑不丐万丄丙丘三丕()
    {
        this.丟世丙东丂丟且丕丞 = GestureCamera.ZoomValue01;
    }
    internal void 一一丟丑丏丑且三丒()
    {
    
    }
    public CameraMoverDirectoryManager()
    {
        this.returnSpeed = 10f;
        this.世七七不不丐丕丞丏 = new System.Collections.Generic.Dictionary<System.String, CameraMoverForDirectory>();
    }

}
