using UnityEngine;
public class WeaponMySkinApplyer : MonoBehaviour
{
    // Fields
    private string 丅丐丞丞丐丘东丘丘;
    private WeaponSkinChanger 丛丒下丆丂丌丑丘丏;
    
    // Methods
    public static WeaponMySkinApplyer Create(string 丅丐丞丞丐丘东丘丘, WeaponSkinChanger 丛丒下丆丂丌丑丘丏)
    {
        if(丛丒下丆丂丌丑丘丏 == 0)
        {
                return (WeaponMySkinApplyer)0;
        }
        
        0 = 丞东丑专丛丆丄丝世.七丞丕丞不丟东下且<WeaponMySkinApplyer>(不下丙丟专丙丆万丆:  丛丒下丆丂丌丑丘丏);
        if(0 != null)
        {
                val_2.丅丐丞丞丐丘东丘丘 = 丅丐丞丞丐丘东丘丘;
            val_2.丛丒下丆丂丌丑丘丏 = 丛丒下丆丂丌丑丘丏;
        }
        else
        {
                mem[24] = 丅丐丞丞丐丘东丘丘;
            mem[32] = 丛丒下丆丂丌丑丘丏;
        }
        
        0.UpdateCurrentSkin();
        return (WeaponMySkinApplyer)0;
    }
    private void OnEnable()
    {
        Progress.丟丕丒丑东丗丑丏丑.与丐丕上丌丑丁丌上(丙业与丙丗丝不丈东:  new System.Action<System.String, PGCompany.丟丝世万东万丆丟上>(object:  this, method:  System.Void WeaponMySkinApplyer::万不不丏丘丗丑专与(string 丅丐丞丞丐丘东丘丘, PGCompany.丟丝世万东万丆丟上 丂丒丘丅专丗丂世丛)));
        Progress.丟丕丒丑东丗丑丏丑.丒专七与丏丌丌业七(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void WeaponMySkinApplyer::丌丒丘专业丂丁丙丗(string 丅丐丞丞丐丘东丘丘)));
        this.UpdateCurrentSkin();
    }
    private void OnDisable()
    {
        Progress.丟丕丒丑东丗丑丏丑.丂专丑东丂丏与与丒(丙业与丙丗丝不丈东:  new System.Action<System.String, PGCompany.丟丝世万东万丆丟上>(object:  this, method:  System.Void WeaponMySkinApplyer::万不不丏丘丗丑专与(string 丅丐丞丞丐丘东丘丘, PGCompany.丟丝世万东万丆丟上 丂丒丘丅专丗丂世丛)));
        Progress.丟丕丒丑东丗丑丏丑.丘丑且下丁丈专丝三(丙业与丙丗丝不丈东:  new System.Action<System.String>(object:  this, method:  System.Void WeaponMySkinApplyer::丌丒丘专业丂丁丙丗(string 丅丐丞丞丐丘东丘丘)));
    }
    public void UpdateCurrentSkin()
    {
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  this.丅丐丞丞丐丘东丘丘)) == true)
        {
                return;
        }
        
        if(this.丛丒下丆丂丌丑丘丏 == 0)
        {
                return;
        }
        
        this.丛丒下丆丂丌丑丘丏.上丈一万东三东世东(三丕上下丗丘丌专丒:  丏丞丛上七丁丞丛万.丏丌丗丛丅丗丕丘专(丅丐丞丞丐丘东丘丘:  this.丅丐丞丞丐丘东丘丘), 丄丕且丆与业下业下:  0);
    }
    private void 万不不丏丘丗丑专与(string 丅丐丞丞丐丘东丘丘, PGCompany.丟丝世万东万丆丟上 丂丒丘丅专丗丂世丛)
    {
        if((System.String.op_Inequality(a:  this.丅丐丞丞丐丘东丘丘, b:  丅丐丞丞丐丘东丘丘)) != false)
        {
                return;
        }
        
        this.UpdateCurrentSkin();
    }
    private void 丌丒丘专业丂丁丙丗(string 丅丐丞丞丐丘东丘丘)
    {
        if((System.String.op_Inequality(a:  this.丅丐丞丞丐丘东丘丘, b:  丅丐丞丞丐丘东丘丘)) != false)
        {
                return;
        }
        
        this.UpdateCurrentSkin();
    }
    public WeaponMySkinApplyer()
    {
    
    }

}
