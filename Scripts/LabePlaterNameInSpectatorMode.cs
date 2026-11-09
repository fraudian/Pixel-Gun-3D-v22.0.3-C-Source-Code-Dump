using UnityEngine;
public class LabePlaterNameInSpectatorMode : MonoBehaviour
{
    // Fields
    private UILabel 七丐丞丑丑丕世丙七;
    public UILabel clanNameLabel;
    public UITexture clanTexture;
    public UILabel countKillLabel;
    public UILabel enemyOrAllyLabel;
    public UnityEngine.GameObject container;
    
    // Methods
    private void Start()
    {
        this.七丐丞丑丑丕世丙七 = this.GetComponent<UILabel>();
        if(GameConnect.丒丗丁丙丗丄丙不丐() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
                return;
        }
        
        }
        
        this = this.container.transform;
        this.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
    }
    private void Update()
    {
        UILabel val_19;
        var val_20;
        var val_21;
        NetworkStartTable val_22;
        var val_23;
        var val_24;
        string val_26;
        var val_27;
        val_19 = this;
        if(this.七丐丞丑丑丕世丙七 == 0)
        {
                return;
        }
        
        val_20 = null;
        val_20 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable == 0)
        {
                return;
        }
        
        val_21 = null;
        val_21 = null;
        this.七丐丞丑丑丕世丙七.text = public System.Boolean UnityEngine.Object::Equals(object other);
        this.七丐丞丑丑丕世丙七.color = new UnityEngine.Color() {r = System.Void System.Object::Finalize(), g = typeof(NetworkStartTable).__il2cppRuntimeField_13C, b = System.Void System.Object::Finalize(), a = typeof(NetworkStartTable).__il2cppRuntimeField_144};
        this.clanNameLabel.text = NetworkStartTable.__il2cppRuntimeField_typeHierarchyDepth;
        val_22 = public System.Boolean UnityEngine.Object::Equals(object other);
        if(NetworkStartTable.__il2cppRuntimeField_typeDefinition != 0)
        {
                if(GameConnect.丒丗丁丙丗丄丙不丐() != true)
        {
                if(GameConnect.一业上七丟业且业丙() == false)
        {
            goto label_34;
        }
        
        }
        
        }
        
        this.countKillLabel.gameObject.SetActive(value:  false);
        label_73:
        val_23 = null;
        val_23 = null;
        if((NetworkStartTable.__il2cppRuntimeField_typeDefinition == 0) || (GameConnect.丒丗丁丙丗丄丙不丐() == false))
        {
            goto label_46;
        }
        
        this.enemyOrAllyLabel.gameObject.SetActive(value:  true);
        val_24 = null;
        val_24 = null;
        val_22 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 96];
        val_22 = WeaponManager.丟丗丄业丘丗业丗七.myNetworkStartTable;
        val_19 = this.enemyOrAllyLabel;
        if(typeof(NetworkStartTable).__il2cppRuntimeField_618.丘丑丅三丆丑丌且丝() != 丘丑丅三丆丑丌且丝())
        {
            goto label_57;
        }
        
        string val_12 = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7702");
        val_26 = "[0683FF]{0}[-]";
        goto label_60;
        label_46:
        val_19 = this.enemyOrAllyLabel.gameObject;
        val_19.SetActive(value:  false);
        return;
        label_34:
        this.countKillLabel.gameObject.SetActive(value:  true);
        val_27 = null;
        val_27 = null;
        this.countKillLabel.text = typeof(NetworkStartTable).__il2cppRuntimeField_618.丑丛丆三丆丄七丐万().ToString();
        goto label_73;
        label_57:
        val_26 = "[EB4A29]{0}[-]";
        label_60:
        val_19.text = System.String.Format(format:  val_26, arg0:  丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  "Key_7701"));
    }
    public LabePlaterNameInSpectatorMode()
    {
    
    }

}
