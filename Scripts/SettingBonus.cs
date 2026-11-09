using UnityEngine;
internal sealed class SettingBonus : MonoBehaviour, 东丁丆一业丈万丆丐
{
    // Fields
    public int numberSpawnZone;
    public int typeOfMass;
    
    // Methods
    public bool OnEventFired(byte 丗与一丛丐丞丘丌丞, object[] 专丒丌丆下丐丞丟丞)
    {
        object val_3;
        var val_4;
        val_3 = 丗与一丛丐丞丘丌丞;
        if((val_3 & 255) == 109)
        {
                val_3 = 专丒丌丆下丐丞丟丞[0];
            UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  val_3);
            val_4 = 1;
            this.numberSpawnZone = null;
            return (bool)val_4;
        }
        
        val_4 = 0;
        return (bool)val_4;
    }
    private void Start()
    {
        null = null;
        Add(item:  this);
    }
    private void OnDestroy()
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if(BonusController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        bool val_2 = Remove(item:  this);
    }
    public void SetNumberSpawnZone(int 三世不丒世丆七丞丒)
    {
        object[] val_2 = new object[1];
        if(val_2 == null)
        {
            goto label_1;
        }
        
        if(三世不丒世丆七丞丒 != 0)
        {
            goto label_2;
        }
        
        goto label_5;
        label_1:
        if(三世不丒世丆七丞丒 == 0)
        {
            goto label_5;
        }
        
        label_2:
        label_5:
        val_2[0] = 三世不丒世丆七丞丒;
        this.photonView.七丂东世不丐丗丕丑(丑与丆丝丕东丛丄丝:  109, 丞下万上三丘上与专:  3, 丗丟上上丒丐丗丞丙:  val_2);
    }
    private void 丂丁世丌丅丑专丑丒(int 三世不丒世丆七丞丒)
    {
        this.numberSpawnZone = 三世不丒世丆七丞丒;
    }
    public SettingBonus()
    {
        this.numberSpawnZone = 0;
    }

}
