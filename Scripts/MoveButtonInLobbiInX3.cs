using UnityEngine;
public class MoveButtonInLobbiInX3 : MonoBehaviour
{
    // Fields
    public float yX3;
    private UnityEngine.Transform 万东万丆专丌丕丐丗;
    private float 且丒一丕一一丌丒丛;
    private bool 与丄不不万丁不下丁;
    
    // Methods
    private void Start()
    {
        UnityEngine.Transform val_1 = this.transform;
        this.万东万丆专丌丕丐丗 = val_1;
        UnityEngine.Vector3 val_2 = val_1.localPosition;
        this.且丒一丕一一丌丒丛 = val_2.y;
        this.下丏且一三丐一丐不();
    }
    private void 下丏且一三丐一丐不()
    {
        if((((this.与丄不不万丁不下丁 == true) ? 1 : 0) ^ 丅且东丙业丏丛东丛.丑七不且上丗丁一世().丙专丘丄丝一丗丌丌()) == false)
        {
                return;
        }
        
        this.与丄不不万丁不下丁 = 丅且东丙业丏丛东丛.丑七不且上丗丁一世().丙专丘丄丝一丗丌丌();
        UnityEngine.Vector3 val_8 = this.万东万丆专丌丕丐丗.localPosition;
        this = this.万东万丆专丌丕丐丗;
        var val_9 = (this.与丄不不万丁不下丁 == true) ? this.yX3 : this.且丒一丕一一丌丒丛;
        UnityEngine.Vector3 val_10 = this.localPosition;
        this.万东万丆专丌丕丐丗.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void Update()
    {
        this.下丏且一三丐一丐不();
    }
    public MoveButtonInLobbiInX3()
    {
    
    }

}
