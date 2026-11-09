using UnityEngine;
public class SetRectResolution : MonoBehaviour
{
    // Fields
    private UIWidget 世丌丌丙丞丟下东丞;
    private int 业与三万七丝不万东;
    private int 丟丌丐丘丆丙丑丑一;
    public UIRect.丘一丄与上世丑七丅 update;
    
    // Methods
    private void Start()
    {
        this.世丌丌丙丞丟下东丞 = this.GetComponent<UIWidget>();
        if(this.update != 2)
        {
                return;
        }
        
        this.世丆丙丛万丂丏与丏();
    }
    private void Update()
    {
        if(this.update != 1)
        {
                return;
        }
        
        this.世丆丙丛万丂丏与丏();
    }
    private void OnEnable()
    {
        if(this.update != 0)
        {
                return;
        }
        
        this.世丆丙丛万丂丏与丏();
    }
    private void 世丆丙丛万丂丏与丏()
    {
        int val_6;
        float val_7;
        var val_8;
        val_6 = this.业与三万七丝不万东;
        if(val_6 == 0)
        {
                val_7 = 与丂丏丛丞丞丒丟丄.不上上丞丐业不三专();
            float val_6 = (float)UnityEngine.Screen.width;
            val_6 = val_6 / val_7;
            this.业与三万七丝不万东 = UnityEngine.Mathf.RoundToInt(f:  val_6);
            val_6 = this.业与三万七丝不万东;
            if(东丗上丁下业一丂丂.丐业丂丞且不东丕丗() != false)
        {
                val_8 = null;
            val_8 = null;
            val_7 = IphoneXCameraScaler.且下丒丘丙丒丈丏万;
            float val_7 = (float)val_6;
            val_7 = IphoneXCameraScaler.不丅七丘丈不丌丝丏 * val_7;
            val_7 = val_7 / val_7;
            val_6 = UnityEngine.Mathf.RoundToInt(f:  val_7);
            this.业与三万七丝不万东 = val_6;
        }
        
        }
        
        this.世丌丌丙丞丟下东丞.width = val_6;
        this.世丌丌丙丞丟下东丞.height = this.丟丌丐丘丆丙丑丑一;
    }
    public SetRectResolution()
    {
        this.丟丌丐丘丆丙丑丑一 = 770;
        this.update = 2;
    }

}
