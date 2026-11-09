using UnityEngine;
public class DeadEnergyController : MonoBehaviour
{
    // Fields
    public UnityEngine.SkinnedMeshRenderer mySkinRenderer;
    public UnityEngine.ParticleSystem myParticle;
    public float timeAfteAnim;
    public float startTimerAnim;
    private UnityEngine.Material 三丗专丒丌丂丈丌上;
    private UnityEngine.SkinnedMeshRenderer royaleAvatarBodyRenderer;
    private UnityEngine.SkinnedMeshRenderer royaleAvatarArmsRenderer;
    private UnityEngine.SkinnedMeshRenderer royaleAvatarHeadRenderer;
    private UnityEngine.SkinnedMeshRenderer royaleAvatarLegsRenderer;
    private UnityEngine.Transform[] royaleAvatarBodyBones;
    private UnityEngine.Transform[] royaleAvatarArmsBones;
    private UnityEngine.Transform[] royaleAvatarHeadBones;
    private UnityEngine.Transform[] royaleAvatarLegsBones;
    private UnityEngine.Material 丝丗丏丌丘丘且丂一;
    private string 万万万世业丒丕丛丞;
    private float 丑上丌业丕一业三丆;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Material val_1 = this.royaleAvatarBodyRenderer.material;
        this.丝丗丏丌丘丘且丂一 = val_1;
        this.royaleAvatarBodyRenderer.sharedMaterial = val_1;
        this.royaleAvatarArmsRenderer.sharedMaterial = this.丝丗丏丌丘丘且丂一;
        this.royaleAvatarHeadRenderer.sharedMaterial = this.丝丗丏丌丘丘且丂一;
        this.royaleAvatarLegsRenderer.sharedMaterial = this.丝丗丏丌丘丘且丂一;
    }
    public void StartAnim(UnityEngine.Color 丂丄一丗业丗丐万丏, UnityEngine.Texture 丑丄丅丟丙丛丒丑丅, RoyaleAvatar 丅世丟三下丌丝七与)
    {
        UnityEngine.Texture val_21;
        UnityEngine.Material val_22;
        UnityEngine.SkinnedMeshRenderer val_23;
        val_21 = 丑丄丅丟丙丛丒丑丅;
        float val_21 = this.timeAfteAnim;
        val_21 = this.startTimerAnim + val_21;
        this.丑上丌业丕一业三丆 = val_21;
        UnityEngine.Object val_22 = 0;
        val_22 = UnityEngine.Object.op_Equality(x:  丅世丟三下丌丝七与, y:  val_22);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.mySkinRenderer.gameObject, 丏业丟一东丂东丘丛:  val_22);
        UnityEngine.Object val_23 = 0;
        val_23 = UnityEngine.Object.op_Inequality(x:  丅世丟三下丌丝七与, y:  val_23);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.royaleAvatarBodyRenderer.gameObject, 丏业丟一东丂东丘丛:  val_23);
        UnityEngine.Object val_24 = 0;
        val_24 = UnityEngine.Object.op_Inequality(x:  丅世丟三下丌丝七与, y:  val_24);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.royaleAvatarArmsRenderer.gameObject, 丏业丟一东丂东丘丛:  val_24);
        UnityEngine.Object val_25 = 0;
        val_25 = UnityEngine.Object.op_Inequality(x:  丅世丟三下丌丝七与, y:  val_25);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.royaleAvatarHeadRenderer.gameObject, 丏业丟一东丂东丘丛:  val_25);
        UnityEngine.Object val_26 = 0;
        val_26 = UnityEngine.Object.op_Inequality(x:  丅世丟三下丌丝七与, y:  val_26);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.royaleAvatarLegsRenderer.gameObject, 丏业丟一东丂东丘丛:  val_26);
        if(丅世丟三下丌丝七与 == 0)
        {
                val_22 = this.mySkinRenderer.material;
        }
        else
        {
                val_22 = this.丝丗丏丌丘丘且丂一;
        }
        
        this.三丗专丒丌丂丈丌上 = val_22;
        val_22.SetColor(name:  "_BurnColor", value:  new UnityEngine.Color() {r = 丂丄一丗业丗丐万丏.r, g = 丂丄一丗业丗丐万丏.g, b = 丂丄一丗业丗丐万丏.b, a = 丂丄一丗业丗丐万丏.a});
        if((丅世丟三下丌丝七与 != 0) && ((System.String.op_Inequality(a:  丅世丟三下丌丝七与.name, b:  this.万万万世业丒丕丛丞)) != false))
        {
                if(丅世丟三下丌丝七与 != null)
        {
                val_23 = this.royaleAvatarBodyRenderer;
            this.万万万世业丒丕丛丞 = 丅世丟三下丌丝七与.name;
        }
        else
        {
                val_23 = this.royaleAvatarBodyRenderer;
            this.万万万世业丒丕丛丞 = 丅世丟三下丌丝七与.name;
        }
        
            RoyaleAvatar.丞不且丆丒不丄专三(丑一丑丏丐丅丞丞丂:  val_23, 丈丈三丕丘业丐丁丌:  丅世丟三下丌丝七与.bodyMeshRenderer, 丆丕东三丒丟三三三:  this.royaleAvatarBodyBones);
            RoyaleAvatar.丞不且丆丒不丄专三(丑一丑丏丐丅丞丞丂:  this.royaleAvatarArmsRenderer, 丈丈三丕丘业丐丁丌:  丅世丟三下丌丝七与.armsMeshRenderer, 丆丕东三丒丟三三三:  this.royaleAvatarArmsBones);
            RoyaleAvatar.丞不且丆丒不丄专三(丑一丑丏丐丅丞丞丂:  this.royaleAvatarHeadRenderer, 丈丈三丕丘业丐丁丌:  丅世丟三下丌丝七与.headMeshRenderer, 丆丕东三丒丟三三三:  this.royaleAvatarHeadBones);
            RoyaleAvatar.丞不且丆丒不丄专三(丑一丑丏丐丅丞丞丂:  this.royaleAvatarLegsRenderer, 丈丈三丕丘业丐丁丌:  丅世丟三下丌丝七与.legsMeshRenderer, 丆丕东三丒丟三三三:  this.royaleAvatarLegsBones);
        }
        
        if(丅世丟三下丌丝七与 != 0)
        {
                val_21 = 丅世丟三下丌丝七与.bodyMeshRenderer.sharedMaterial.mainTexture;
        }
        
        this.三丗专丒丌丂丈丌上.SetTexture(name:  "_MainTex", value:  val_21);
        this.myParticle.startColor = new UnityEngine.Color() {r = 丂丄一丗业丗丐万丏.r, g = 丂丄一丗业丗丐万丏.g, b = 丂丄一丗业丗丐万丏.b, a = 丂丄一丗业丗丐万丏.a};
    }
    private void Update()
    {
        float val_2;
        if(this.丑上丌业丕一业三丆 <= 0f)
        {
                return;
        }
        
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丑上丌业丕一业三丆 - val_1;
        this.丑上丌业丕一业三丆 = val_1;
        if(val_1 < 0)
        {
                val_1 = val_1 * 1.5f;
            val_1 = val_1 / this.startTimerAnim;
            val_2 = val_1 + (-0.25f);
        }
        else
        {
                val_2 = 1.25f;
        }
        
        this.三丗专丒丌丂丈丌上.SetFloat(name:  "_Burn", value:  val_2);
    }
    public DeadEnergyController()
    {
        this.startTimerAnim = 1f;
        this.丑上丌业丕一业三丆 = -1f;
        this.万万万世业丒丕丛丞 = System.String.alignConst;
    }

}
