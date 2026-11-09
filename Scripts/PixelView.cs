using UnityEngine;
internal sealed class PixelView : MonoBehaviour
{
    // Fields
    private static int 丛丙丞丆丁丛丈丈丝;
    private PhotonView 丄丈丑丐丆丞丘与丗;
    private int 世且一七上万丌世丞;
    
    // Properties
    public int 世上丕丐丈世上不丏 { get; }
    
    // Methods
    public int get_viewID()
    {
        var val_1;
        int val_3;
        val_1 = null;
        val_1 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
            goto label_3;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
            goto label_6;
        }
        
        if(this.丄丈丑丐丆丞丘与丗 != null)
        {
                return this.丄丈丑丐丆丞丘与丗.viewID;
        }
        
        return this.丄丈丑丐丆丞丘与丗.viewID;
        label_3:
        val_3 = 0;
        return val_3;
        label_6:
        val_3 = this.世且一七上万丌世丞;
        return val_3;
    }
    private void Awake()
    {
        var val_3 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 == false)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丝丙七丒且丂丝与丏 == false)
        {
                return;
        }
        
        PhotonView val_1 = this.GetComponent<PhotonView>();
        this.丄丈丑丐丆丞丘与丗 = val_1;
        if(val_1 != 0)
        {
                return;
        }
        
        UnityEngine.Debug.LogError(message:  "GetComponent<PhotonView>() == null");
    }
    private void 丄丛且丛万东丆丟与(int 丞丅上丏丂且下丅与)
    {
        object val_3;
        if(this.世且一七上万丌世丞 != 1)
        {
                object[] val_1 = new object[5];
            val_1[0] = "Local id is already set! ";
            val_1[1] = this.世且一七上万丌世丞;
            val_1[2] = " (new: ";
            val_1[3] = 丞丅上丏丂且下丅与;
            val_1[4] = ")";
            val_3 = +val_1;
            UnityEngine.Debug.LogError(message:  val_3);
        }
        
        this.世且一七上万丌世丞 = 丞丅上丏丂且下丅与;
    }
    public PixelView()
    {
        this.世且一七上万丌世丞 = 0;
    }
    private static PixelView()
    {
        PixelView.丛丙丞丆丁丛丈丈丝 = 1000;
    }

}
