using UnityEngine;
public class LeagueUp : MonoBehaviour
{
    // Fields
    public UnityEngine.Transform currentCup;
    public UnityEngine.Transform newCup;
    public UnityEngine.Transform cupsParrent;
    public UnityEngine.Transform[] cups;
    
    // Methods
    private void 万不丆丟东丐专丁丘()
    {
        goto label_1;
        label_6:
        this.cups[0].parent = this.cupsParrent;
        0 = 1;
        label_1:
        if(0 < this.cups.Length)
        {
            goto label_6;
        }
        
        int val_1 = ExpController.万上一丝丆且七丅丅();
        UnityEngine.Transform val_12 = this.cups[(long)val_1 - 1];
        val_12.parent = this.currentCup;
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_4 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z}, d:  75f);
        val_12.localScale = new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z};
        UnityEngine.Quaternion val_5 = UnityEngine.Quaternion.identity;
        val_12.localRotation = new UnityEngine.Quaternion() {x = val_5.x, y = val_5.y, z = val_5.z, w = val_5.w};
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.zero;
        val_12.localPosition = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Transform val_13 = this.cups[(long)val_1];
        val_13.parent = this.newCup;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.one;
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.op_Multiply(a:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z}, d:  75f);
        val_13.localScale = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        UnityEngine.Quaternion val_9 = UnityEngine.Quaternion.identity;
        val_13.localRotation = new UnityEngine.Quaternion() {x = val_9.x, y = val_9.y, z = val_9.z, w = val_9.w};
        UnityEngine.Vector3 val_10 = UnityEngine.Vector3.zero;
        val_13.localPosition = new UnityEngine.Vector3() {x = val_10.x, y = val_10.y, z = val_10.z};
    }
    public LeagueUp()
    {
    
    }

}
