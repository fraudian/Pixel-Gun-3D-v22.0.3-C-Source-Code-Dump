using UnityEngine;
public class ShowInfoOfPlayer : MonoBehaviour
{
    // Fields
    private UnityEngine.GameObject 丞三东专世丏丗一丏;
    private UnityEngine.TextMesh 七且丆丞丌丘下世丑;
    public float CharacterSize;
    public UnityEngine.Font font;
    public bool DisableOnOwnObjects;
    
    // Methods
    private void Start()
    {
        UnityEngine.TextMesh val_15;
        UnityEngine.Object val_16;
        val_15 = this;
        if(this.font == 0)
        {
                val_16 = UnityEngine.Resources.FindObjectsOfTypeAll(type:  System.Type.GetTypeFromHandle(handle:  new System.RuntimeTypeHandle()))[0];
            if((val_16 != null) && (null != null))
        {
                val_16 = 0;
        }
        
            this.font = val_16;
            UnityEngine.Debug.LogWarning(message:  "No font defined. Found font: "("No font defined. Found font: ") + val_16);
        }
        
        if(this.七且丆丞丌丘下世丑 != 0)
        {
                return;
        }
        
        UnityEngine.GameObject val_7 = new UnityEngine.GameObject(name:  "3d text");
        this.丞三东专世丏丗一丏 = val_7;
        UnityEngine.Transform val_8 = val_7.transform;
        val_8.parent = this.gameObject.transform;
        UnityEngine.Vector3 val_11 = UnityEngine.Vector3.zero;
        val_8.localPosition = new UnityEngine.Vector3() {x = val_11.x, y = val_11.y, z = val_11.z};
        this.丞三东专世丏丗一丏.AddComponent<UnityEngine.MeshRenderer>().material = this.font.material;
        UnityEngine.TextMesh val_14 = this.丞三东专世丏丗一丏.AddComponent<UnityEngine.TextMesh>();
        this.七且丆丞丌丘下世丑 = val_14;
        val_14.font = this.font;
        this.七且丆丞丌丘下世丑.anchor = 4;
        if(this.CharacterSize <= 0f)
        {
                return;
        }
        
        val_15 = this.七且丆丞丌丘下世丑;
        val_15.characterSize = this.CharacterSize;
    }
    private void Update()
    {
        UnityEngine.TextMesh val_13;
        var val_14;
        string val_16;
        val_13 = this;
        if(this.DisableOnOwnObjects != false)
        {
                val_14 = this.photonView.isMine;
        }
        else
        {
                val_14 = 1;
        }
        
        if(this.丞三东专世丏丗一丏 != 0)
        {
                this.丞三东专世丏丗一丏.SetActive(value:  val_14 & 1);
        }
        
        if((val_14 & 1) == 0)
        {
                return;
        }
        
        与丅丕丈丘东丝世丟 val_6 = this.photonView.owner;
        if(val_6 == null)
        {
            goto label_10;
        }
        
        val_13 = this.七且丆丞丌丘下世丑;
        if((System.String.IsNullOrEmpty(value:  val_6.丁下不丛下且丌专丈())) == false)
        {
            goto label_11;
        }
        
        string val_10 = "player" + val_6.业丐丐三丕一丗丛丁();
        goto label_12;
        label_10:
        bool val_12 = this.photonView.isSceneView;
        if(this.七且丆丞丌丘下世丑 == null)
        {
            goto label_14;
        }
        
        if(val_12 == false)
        {
            goto label_15;
        }
        
        label_18:
        val_16 = "scn";
        goto label_16;
        label_11:
        label_12:
        val_13.text = val_6.丁下不丛下且丌专丈();
        return;
        label_14:
        if(val_12 == true)
        {
            goto label_18;
        }
        
        label_15:
        val_16 = "n/a";
        label_16:
        this.七且丆丞丌丘下世丑.text = val_16;
    }
    public ShowInfoOfPlayer()
    {
    
    }

}
