using UnityEngine;
public class CountKillsCommandBlue : MonoBehaviour
{
    // Fields
    internal static float 万下丝丄三七丛丑丗;
    private UILabel 一丙且丛丟丈丙且与;
    public bool isEnemyCommandLabel;
    private WeaponManager 丐下丁三且丗上丈东;
    public UnityEngine.GameObject myBackground;
    private UnityEngine.Color 万与三丟业业丙万三;
    
    // Methods
    private void Start()
    {
        null = null;
        this.丐下丁三且丗上丈东 = WeaponManager.丟丗丄业丘丗业丗七;
        this.一丙且丛丟丈丙且与 = this.GetComponent<UILabel>();
    }
    private void Update()
    {
        var val_11;
        var val_12;
        var val_13;
        float val_14;
        string val_15;
        var val_18;
        UnityEngine.Color val_19;
        if((UnityEngine.Object.op_Implicit(exists:  this.丐下丁三且丗上丈东)) == false)
        {
                return;
        }
        
        val_11 = null;
        val_11 = null;
        var val_4 = (丘丑丅三丆丑丌且丝() == 2) ? 1 : 0;
        val_12 = null;
        val_4 = ((this.isEnemyCommandLabel == true) ? 1 : 0) ^ val_4;
        if((val_4 & 1) != 0)
        {
                val_13 = null;
            val_14 = (float)typeof(TeamController).__il2cppRuntimeField_3C;
            val_15 = UnityEngine.Mathf.RoundToInt(f:  val_14).ToString();
            if(null != 0)
        {
            goto label_19;
        }
        
        }
        else
        {
                val_18 = null;
            val_14 = (float)typeof(TeamController).__il2cppRuntimeField_38;
            val_15 = UnityEngine.Mathf.RoundToInt(f:  val_14).ToString();
        }
        
        label_19:
        var val_9 = (typeof(TeamController).__il2cppRuntimeField_38 > typeof(TeamController).__il2cppRuntimeField_3C) ? 1 : 0;
        this.一丙且丛丟丈丙且与.text = val_15;
        val_19 = this.万与三丟业业丙万三;
        this.一丙且丛丟丈丙且与.color = new UnityEngine.Color() {};
    }
    public CountKillsCommandBlue()
    {
        this.万与三丟业业丙万三 = 0;
        mem[1152921525849265180] = 0;
        mem[1152921525849265188] = 0;
    }
    private static CountKillsCommandBlue()
    {
        CountKillsCommandBlue.万下丝丄三七丛丑丗 = 1.25f;
    }

}
