using UnityEngine;
public class RoyaleAmbientAudioController : MonoBehaviour
{
    // Fields
    public UnityEngine.GameObject[] sourcesParrents;
    public float distance;
    private UnityEngine.Vector2[] sourcesPoints;
    private System.Collections.Generic.List<UnityEngine.AudioSource> sources;
    private bool 丄丌丄与丘丑丈丄丐;
    private bool 下世万业丗世且业丌;
    public bool isForLow;
    public TerrainController terrainController;
    
    // Methods
    private void 丝丕丟丑专丟丁三与()
    {
        UnityEngine.Vector2[] val_13;
        UnityEngine.Vector2[] val_14;
        var val_15;
        this.sourcesPoints = new UnityEngine.Vector2[0];
        this.sources = new System.Collections.Generic.List<UnityEngine.AudioSource>();
        val_13 = 0;
        goto label_1;
        label_7:
        this.sources.AddRange(collection:  this.sourcesParrents[0].GetComponentsInChildren<UnityEngine.AudioSource>());
        val_13 = 1;
        label_1:
        if(val_13 < this.sourcesParrents.Length)
        {
            goto label_7;
        }
        
        int val_4 = this.sources.Count;
        val_14 = new UnityEngine.Vector2[0];
        this.sourcesPoints = val_14;
        val_15 = 0;
        goto label_9;
        label_19:
        val_13 = this.sourcesPoints;
        UnityEngine.Vector3 val_8 = this.sources.Item[0].transform.position;
        UnityEngine.Vector3 val_11 = this.sources.Item[0].transform.position;
        UnityEngine.Vector2 val_12 = new UnityEngine.Vector2(x:  val_8.x, y:  val_11.z);
        val_13[0] = val_12.x;
        val_13[0] = val_12.y;
        val_14 = this.sourcesPoints;
        val_15 = 1;
        label_9:
        if(val_15 < this.sourcesPoints.Length)
        {
            goto label_19;
        }
    
    }
    private void 一丛万丑丏一丄丅丄()
    {
        goto label_1;
        label_10:
        AudioSourseOnOff val_2 = this.sources.Item[0].GetComponent<AudioSourseOnOff>();
        if((UnityEngine.Object.op_Implicit(exists:  val_2)) != false)
        {
                UnityEngine.Object.DestroyImmediate(obj:  val_2);
        }
        
        0 = 1;
        label_1:
        if(0 < this.sources.Count)
        {
            goto label_10;
        }
    
    }
    private void 不丘丆丝且丘丒丁丘()
    {
        goto label_1;
        label_9:
        if(this.sources.Item[0] != 0)
        {
                this.sources.Item[0].enabled = false;
        }
        
        0 = 1;
        label_1:
        if(0 < this.sources.Count)
        {
            goto label_9;
        }
    
    }
    private void 七世丐不丐丄丐丝丐()
    {
        goto label_1;
        label_10:
        if(this.sources.Item[0] != 0)
        {
                UnityEngine.Object.Destroy(obj:  this.sources.Item[0]);
        }
        
        0 = 1;
        label_1:
        if(0 < this.sources.Count)
        {
            goto label_10;
        }
    
    }
    private void Awake()
    {
        if(东丗上丁下业一丂丂.丄丒丆丑东丏业丗下() != false)
        {
                if(UnityEngine.Application.isEditor != true)
        {
                if(this.isForLow == false)
        {
            goto label_5;
        }
        
        }
        
        }
        
        if(东丗上丁下业一丂丂.丄丒丆丑东丏业丗下() == true)
        {
                return;
        }
        
        if(this.isForLow == false)
        {
                return;
        }
        
        label_5:
        if(this.下世万业丗世且业丌 != true)
        {
                this.七世丐不丐丄丐丝丐();
        }
        
        this.下世万业丗世且业丌 = true;
    }
    private void Update()
    {
        TerrainController val_13;
        var val_14;
        if(this.下世万业丗世且业丌 == true)
        {
                return;
        }
        
        if(与丂丏丛丞丞丒丟丄.丈丁丌业丘上三且丗() == false)
        {
            goto label_4;
        }
        
        this.丄丌丄与丘丑丈丄丐 = false;
        val_13 = this.terrainController;
        if(this.terrainController != null)
        {
            goto label_5;
        }
        
        val_13 = this.terrainController;
        if(val_13 == null)
        {
            goto label_6;
        }
        
        label_5:
        UnityEngine.Vector2 val_2 = new UnityEngine.Vector2(x:  this.terrainController.terrainPlayerPosition, y:  null);
        val_14 = 0;
        goto label_7;
        label_22:
        UnityEngine.Vector2 val_3 = UnityEngine.Vector2.op_Subtraction(a:  new UnityEngine.Vector2() {x = val_2.x, y = val_2.y}, b:  new UnityEngine.Vector2() {x = this.sourcesPoints[0], y = this.sourcesPoints[0]});
        float val_4 = UnityEngine.Vector2.Dot(lhs:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y}, rhs:  new UnityEngine.Vector2() {x = val_3.x, y = val_3.y});
        if(this.sources.Item[0] != 0)
        {
                if((((val_4 < 0) ? 1 : 0) ^ this.sources.Item[0].enabled) != false)
        {
                this.sources.Item[0].enabled = (val_4 < 0) ? 1 : 0;
        }
        
        }
        
        val_14 = 1;
        label_7:
        if(val_14 < this.sourcesPoints.Length)
        {
            goto label_22;
        }
        
        return;
        label_4:
        if(this.丄丌丄与丘丑丈丄丐 != true)
        {
                this.不丘丆丝且丘丒丁丘();
        }
        
        this.丄丌丄与丘丑丈丄丐 = true;
        return;
        label_6:
    }
    public RoyaleAmbientAudioController()
    {
        this.distance = 22500f;
    }

}
