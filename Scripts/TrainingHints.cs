using UnityEngine;
public class TrainingHints : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject 一丂丑丈不万丐丑丆;
    private TrainingHintBig 丌世万丂三丞上东丐;
    private TrainingHintSmall 万世丝一一丝一丌专;
    public TrainingHints.BigHintItem[] bigHints;
    public TrainingHints.SmallHintItem[] smallHints;
    private TrainingHints.BigHintItem 丅不世丄东丆三业丙;
    private TrainingHints.SmallHintItem 上丙丟专丐丕丂且丐;
    
    // Methods
    public void SetHintObject(UnityEngine.GameObject 丝三丁东丈丒世丅业)
    {
        Player_move_c.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  丝三丁东丈丒世丅业, 不东丛三丂丌丑专丆:  this.gameObject.layer);
        this.一丂丑丈不万丐丑丆 = 丝三丁东丈丒世丅业;
        丝三丁东丈丒世丅业.transform.parent = this.transform;
        UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
        丝三丁东丈丒世丅业.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
        UnityEngine.Vector3 val_8 = UnityEngine.Vector3.zero;
        丝三丁东丈丒世丅业.transform.localPosition = new UnityEngine.Vector3() {x = val_8.x, y = val_8.y, z = val_8.z};
        this.丌世万丂三丞上东丐 = 丝三丁东丈丒世丅业.transform.GetChild(index:  0).GetComponent<TrainingHintBig>();
        this.万世丝一一丝一丌专 = 丝三丁东丈丒世丅业.transform.GetChild(index:  1).GetComponent<TrainingHintSmall>();
        this.丌世万丂三丞上东丐.gameObject.SetActive(value:  false);
        this.万世丝一一丝一丌专.gameObject.SetActive(value:  false);
    }
    public void ShowBigHint(string 丒丘丏上丙丟丑丕丈, System.Action 万万丗丛丏丐七丘丏)
    {
        var val_3;
        BigHintItem[] val_4;
        val_3 = 0;
        goto label_1;
        label_7:
        val_4 = 0;
        BigHintItem val_3 = this.bigHints[val_4];
        if((System.String.op_Equality(a:  this.bigHints[0x0][0].name, b:  丒丘丏上丙丟丑丕丈)) == true)
        {
            goto label_5;
        }
        
        val_3 = 1;
        label_1:
        val_4 = this.bigHints;
        if(val_3 < this.bigHints.Length)
        {
            goto label_7;
        }
        
        goto label_11;
        label_5:
        BigHintItem val_4 = this.bigHints[val_4];
        if(val_4 != null)
        {
                this.丌世万丂三丞上东丐.Show(丙不丈东丒下三丛丁:  val_4, 万万丗丛丏丐七丘丏:  万万丗丛丏丐七丘丏);
            this.丅不世丄东丆三业丙 = val_4;
            return;
        }
        
        label_11:
        UnityEngine.Debug.LogError(message:  "Hint not found: "("Hint not found: ") + 丒丘丏上丙丟丑丕丈);
    }
    public void ShowSmallHint(string 丒丘丏上丙丟丑丕丈, UnityEngine.Transform 丘丂丘丂丁丌丂丏丘)
    {
        var val_6;
        var val_7;
        SmallHintItem[] val_8;
        UnityEngine.GameObject[] val_9;
        var val_10;
        this.HideSmallHint();
        val_6 = 0;
        goto label_1;
        label_7:
        val_7 = 0;
        SmallHintItem val_6 = this.smallHints[val_7];
        if((System.String.op_Equality(a:  this.smallHints[0x0][0].name, b:  丒丘丏上丙丟丑丕丈)) == true)
        {
            goto label_5;
        }
        
        val_6 = 1;
        label_1:
        val_8 = this.smallHints;
        if(val_6 < this.smallHints.Length)
        {
            goto label_7;
        }
        
        goto label_11;
        label_5:
        SmallHintItem val_7 = this.smallHints[val_7];
        if(val_7 == null)
        {
            goto label_11;
        }
        
        val_9 = this.smallHints[0x0][0].activateObjects;
        if(val_9 == null)
        {
            goto label_12;
        }
        
        val_10 = 0;
        goto label_13;
        label_18:
        this.smallHints[0x0][0].activateObjects[0].SetActive(value:  true);
        val_9 = this.smallHints[0x0][0].activateObjects;
        val_10 = 1;
        label_13:
        if(val_10 < this.smallHints[0x0][0].activateObjects.Length)
        {
            goto label_18;
        }
        
        label_12:
        this.万世丝一一丝一丌专.Show(丙不丈东丒下三丛丁:  val_7);
        this.上丙丟专丐丕丂且丐 = val_7;
        this.万世丝一一丝一丌专.transform.SetParent(parent:  this.一丂丑丈不万丐丑丆.transform, worldPositionStays:  false);
        return;
        label_11:
        UnityEngine.Debug.LogError(message:  "Hint not found: "("Hint not found: ") + 丒丘丏上丙丟丑丕丈);
    }
    public void HideSmallHint()
    {
        SmallHintItem val_1;
        var val_2;
        val_1 = this.上丙丟专丐丕丂且丐;
        if((val_1 == null) || (this.上丙丟专丐丕丂且丐.activateObjects == null))
        {
            goto label_1;
        }
        
        val_2 = 0;
        goto label_2;
        label_9:
        this.上丙丟专丐丕丂且丐.activateObjects[0].SetActive(value:  false);
        val_1 = this.上丙丟专丐丕丂且丐;
        val_2 = 1;
        label_2:
        if(val_2 < this.上丙丟专丐丕丂且丐.activateObjects.Length)
        {
            goto label_9;
        }
        
        label_1:
        this.万世丝一一丝一丌专.Hide();
    }
    private void Awake()
    {
    
    }
    private void Update()
    {
    
    }
    public TrainingHints()
    {
    
    }

}
