using UnityEngine;
internal sealed class WavesSurvivedStat : MonoBehaviour
{
    // Fields
    private static int <丆与丘丒丏下一下世>k__BackingField;
    
    // Properties
    internal static int 世丙丆东与丝丘丈丄 { get; set; }
    
    // Methods
    internal static int 万且下不丟丌丄世丂()
    {
        return (int)WavesSurvivedStat.<丆与丘丒丏下一下世>k__BackingField;
    }
    internal static void 丑丛丗丂丞三业东业(int 丙业与丙丗丝不丈东)
    {
        WavesSurvivedStat.<丆与丘丒丏下一下世>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private WavesSurvivedStat()
    {
    
    }
    private void Start()
    {
        UILabel val_1 = this.GetComponent<UILabel>();
        if(val_1 == 0)
        {
                return;
        }
        
        val_1.text = AbstractBankViewItem.上世业丒上丁三下万(下下丏一丙不丘丌丞:  WavesSurvivedStat.<丆与丘丒丏下一下世>k__BackingField);
    }

}
