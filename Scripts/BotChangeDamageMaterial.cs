using UnityEngine;
public sealed class BotChangeDamageMaterial : MonoBehaviour
{
    // Fields
    private UnityEngine.Texture 丅万丗世下不丌丆丑;
    public UnityEngine.Material mobMaterial;
    private UnityEngine.Renderer 丆丏丆一丄丝业七一;
    private UnityEngine.Shader 丁世与一上丞三丌丏;
    private UnityEngine.Shader 丗与丆上专丆丏且丄;
    
    // Methods
    private void Start()
    {
        var val_17;
        var val_18;
        var val_19;
        UnityEngine.Renderer val_1 = this.GetComponent<UnityEngine.Renderer>();
        this.丆丏丆一丄丝业七一 = val_1;
        UnityEngine.Material val_2 = val_1.material;
        this.mobMaterial = val_2;
        this.丁世与一上丞三丌丏 = val_2.shader;
        this.丗与丆上专丆丏且丄 = UnityEngine.Shader.Find(name:  "Rilisoft/WallHackShader");
        this.丆丏丆一丄丝业七一.sharedMaterial = this.mobMaterial;
        string val_8 = this.transform.root.GetChild(index:  0).name;
        val_17 = 0;
        if((val_8.Contains(value:  "Enemy")) != false)
        {
                string val_11 = val_8 + "_Level" + 丅丌丝丘丐不丒丄专.丙东东丅丁业丝万一();
            val_17 = 0;
            bool val_13 = UnityEngine.Object.op_Implicit(exists:  null);
        }
        
        if( != 0)
        {
                this.丅万丗世下不丌丆丑 = ;
            this.ResetMainMaterial();
        }
        else
        {
                this.丅万丗世下不丌丆丑 = this.mobMaterial.mainTexture;
        }
        
        val_18 = null;
        val_18 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_19 = null;
        val_19 = null;
        this.SetXRayShader(丛丅丘一丏丙且丌上:  true);
    }
    public void ShowDamageEffect(bool 万东丏丌不七东丘万 = False, RilisoftBot.七一丙世丏下丐丕世 丗与丟上上丑专世丗 = 0)
    {
        UnityEngine.Material val_7;
        if(this.mobMaterial == 0)
        {
                return;
        }
        
        if(丗与丟上上丑专世丗 == 3)
        {
            goto label_4;
        }
        
        if(丗与丟上上丑专世丗 == 2)
        {
            goto label_5;
        }
        
        if(丗与丟上上丑专世丗 != 1)
        {
            goto label_6;
        }
        
        val_7 = this.mobMaterial;
        UnityEngine.Texture2D val_2 = SkinsController.丘下丑丟下丌丙丒三();
        goto label_19;
        label_4:
        val_7 = this.mobMaterial;
        UnityEngine.Texture2D val_3 = SkinsController.三丙一丛下上丄丏不();
        goto label_19;
        label_5:
        val_7 = this.mobMaterial;
        UnityEngine.Texture2D val_4 = SkinsController.丝丗丟不丙丘丛丞丝();
        goto label_19;
        label_6:
        val_7 = this.mobMaterial;
        if(万东丏丌不七东丘万 != false)
        {
                UnityEngine.Texture2D val_5 = SkinsController.丈三且与上丄丗丙专();
        }
        
        label_19:
        val_7.mainTexture = SkinsController.丝丕且丐上丁丛三丝();
    }
    public void ResetMainMaterial()
    {
        if(this.mobMaterial == 0)
        {
                return;
        }
        
        this.mobMaterial.mainTexture = this.丅万丗世下不丌丆丑;
    }
    public void SetXRayShader(bool 丛丅丘一丏丙且丌上)
    {
        UnityEngine.Material val_7;
        var val_8;
        val_7 = this.mobMaterial;
        if(val_7 == 0)
        {
                return;
        }
        
        this.mobMaterial.shader = (丛丅丘一丏丙且丌上 != true) ? this.丗与丆上专丆丏且丄 : this.丁世与一上丞三丌丏;
        val_7 = this.丆丏丆一丄丝业七一;
        if(val_7 == 0)
        {
                return;
        }
        
        val_8 = 0;
        if( == 0)
        {
                return;
        }
        
        allowOcclusionWhenDynamic = (~丛丅丘一丏丙且丌上) & 1;
    }
    public BotChangeDamageMaterial()
    {
    
    }

}
