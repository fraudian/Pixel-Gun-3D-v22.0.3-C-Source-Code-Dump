using UnityEngine;
public class AnchorMover : MonoBehaviour
{
    // Fields
    private UnityEngine.Transform flagRed;
    private UIAnchor flagsAnchor;
    
    // Methods
    private void 万且丞丕丗丟丘丟丟()
    {
        this.一丁丕且丐丅一丗一();
    }
    private void 一丁丕且丐丅一丗一()
    {
        UnityEngine.Vector3 val_5 = this.flagRed.localPosition;
        UnityEngine.Vector3 val_6 = this.flagRed.localPosition;
        float val_7 = 768f;
        val_7 = (float)UnityEngine.Screen.width * val_7;
        val_7 = val_7 / (float)UnityEngine.Screen.height;
        val_7 = val_7 * 0.5f;
        val_7 = val_7 + (-30f);
        val_7 = ((丟丌丁且且世丈丈丟.丝丆丏丟丏专丒丆三() != true) ? -1f : 1f) * val_7;
        this.flagRed.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void Start()
    {
        this.flagsAnchor.uiCamera = InGameGUI.丙丞专丌丁丞与不丐.丝丙与东丈不丙三丟();
        this.一丁丕且丐丅一丗一();
        PauseNGUIController.丒一世七业丙东丒丂(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AnchorMover::万且丞丕丗丟丘丟丟()));
    }
    private void OnDestroy()
    {
        PauseNGUIController.丈一丞丘世丌丄上丟(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void AnchorMover::万且丞丕丗丟丘丟丟()));
    }
    private void OnEnable()
    {
        this.一丁丕且丐丅一丗一();
    }
    public AnchorMover()
    {
    
    }

}
