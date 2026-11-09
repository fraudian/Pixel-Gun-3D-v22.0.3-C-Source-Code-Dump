using UnityEngine;
internal sealed class MainMenuCameraMoveInOut : MonoBehaviour
{
    // Fields
    private MainMenuCameraMoveInOut.丙丟与丐三丐万万丆 丗下丘世三七一专丕;
    private UnityEngine.Vector3 丕丅丕丏专七万三与;
    private UnityEngine.Quaternion 丟丐丈且丗丟丑东丑;
    
    // Properties
    internal MainMenuCameraMoveInOut.丙丟与丐三丐万万丆 上丅丑丌丑丏丏丙东 { get; }
    
    // Methods
    internal MainMenuCameraMoveInOut.丙丟与丐三丐万万丆 万丘三丘下与与且业()
    {
        return (丙丟与丐三丐万万丆)this.丗下丘世三七一专丕;
    }
    public void HandleClickTrigger()
    {
        if(this.丗下丘世三七一专丕 != null)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        UnityEngine.Debug.Log(message:  System.String.Format(format:  "Ignoring click while in {0} state.", arg0:  this.丗下丘世三七一专丕));
        return;
        label_2:
        this.丗下丘世三七一专丕 = new MainMenuCameraMoveInOut.丐东丝丁且丁丌丗丟();
        this.丗下丘世三七一专丕 = new MainMenuCameraMoveInOut.上且丁不丄专丒丟专();
    }
    public void HandleBackRequest()
    {
        if(this.丗下丘世三七一专丕 != null)
        {
                if(null == null)
        {
            goto label_2;
        }
        
        }
        
        UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "Ignoring click while in {0} state.", arg0:  this.丗下丘世三七一专丕));
        return;
        label_2:
        this.丗下丘世三七一专丕 = new MainMenuCameraMoveInOut.丐东丝丁且丁丌丗丟();
        this.丗下丘世三七一专丕 = new MainMenuCameraMoveInOut.下丝丒东丟丂一七世();
    }
    public void Reset()
    {
        this.gameObject.transform.position = new UnityEngine.Vector3() {x = this.丕丅丕丏专七万三与, y = V9.16B, z = V10.16B};
        this.gameObject.transform.rotation = new UnityEngine.Quaternion() {x = this.丟丐丈且丗丟丑东丑, y = V9.16B, z = V10.16B, w = V11.16B};
        this.丗下丘世三七一专丕 = new MainMenuCameraMoveInOut.下丝丒东丟丂一七世();
    }
    private void Awake()
    {
        UnityEngine.Vector3 val_3 = this.gameObject.transform.position;
        this.丕丅丕丏专七万三与 = val_3;
        mem[1152921538300055828] = val_3.y;
        mem[1152921538300055832] = val_3.z;
        UnityEngine.Quaternion val_6 = this.gameObject.transform.rotation;
        this.丟丐丈且丗丟丑东丑 = val_6;
        mem[1152921538300055840] = val_6.y;
        mem[1152921538300055844] = val_6.z;
        mem[1152921538300055848] = val_6.w;
    }
    public MainMenuCameraMoveInOut()
    {
        this.丗下丘世三七一专丕 = new MainMenuCameraMoveInOut.下丝丒东丟丂一七世();
    }

}
