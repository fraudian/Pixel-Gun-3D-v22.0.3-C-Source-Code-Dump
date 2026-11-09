using UnityEngine;
internal sealed class FortFieldTerrain : PGBehaviour
{
    // Fields
    private bool 丗下丟丄丆东三丞专;
    private UnityEngine.Renderer terrainRenderer;
    private float zoomDelta;
    private string 丑丞丅丝业丄业专丌;
    private string 丘丙与丏业丛且丄世;
    
    // Methods
    private void Awake()
    {
        UnityEngine.SceneManagement.Scene val_1 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((System.String.op_Inequality(a:  val_1.m_Handle.name, b:  "FortFieldBuild")) != false)
        {
                this.enabled = false;
        }
        
        this.丗下丟丄丆东三丞专 = false;
        this.丌丑丒丌且丑丅丕一();
    }
    private void Update()
    {
        if(GestureCamera.instance.丏业丄丏丞丕世丑业 != false)
        {
                this.丏丙丟丆世丕东丅丒();
            return;
        }
        
        this.丌丑丒丌且丑丅丕一();
    }
    private void 丌丑丒丌且丑丅丕一()
    {
        var val_4;
        if(this.丗下丟丄丆东三丞专 == true)
        {
                return;
        }
        
        this.丗下丟丄丆东三丞专 = true;
        val_4 = 0;
        goto label_1;
        label_8:
        this.terrainRenderer.materials[0].shader = UnityEngine.Shader.Find(name:  this.丑丞丅丝业丄业专丌);
        val_4 = 1;
        label_1:
        UnityEngine.Material[] val_3 = this.terrainRenderer.materials;
        if(val_4 < val_3.Length)
        {
            goto label_8;
        }
    
    }
    private void 丏丙丟丆世丕东丅丒()
    {
        var val_4;
        if(this.丗下丟丄丆东三丞专 == false)
        {
                return;
        }
        
        this.丗下丟丄丆东三丞专 = false;
        val_4 = 0;
        goto label_1;
        label_8:
        this.terrainRenderer.materials[0].shader = UnityEngine.Shader.Find(name:  this.丘丙与丏业丛且丄世);
        val_4 = 1;
        label_1:
        UnityEngine.Material[] val_3 = this.terrainRenderer.materials;
        if(val_4 < val_3.Length)
        {
            goto label_8;
        }
    
    }
    public FortFieldTerrain()
    {
        this.丑丞丅丝业丄业专丌 = "Mobile/Diffuse";
        this.丘丙与丏业丛且丄世 = "Cubic/FortTerrainAlphaByDistance";
    }

}
