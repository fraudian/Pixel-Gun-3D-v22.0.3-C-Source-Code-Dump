using UnityEngine;
public class RPG_Animation : MonoBehaviour
{
    // Fields
    public static RPG_Animation instance;
    public RPG_Animation.七丘三一丟不与丆丛 currentMoveDir;
    public RPG_Animation.与丞丑七丘业三万东 currentState;
    
    // Methods
    private void Awake()
    {
        RPG_Animation.instance = this;
    }
    private void Update()
    {
        this.SetCurrentState();
        this.StartAnimation();
    }
    public void SetCurrentMoveDir(UnityEngine.Vector3 丝三丈丈不丑业丁丕)
    {
        var val_5;
        var val_6;
        if(丝三丈丈不丑业丁丕.z > 0f)
        {
                var val_1 = (丝三丈丈不丑业丁丕.x > 0f) ? 6 : (0 + 1);
            val_6 = 5;
        }
        else
        {
                if(丝三丈丈不丑业丁丕.z < 0)
        {
                var val_2 = (丝三丈丈不丑业丁丕.x > 0f) ? 8 : 2;
            val_6 = 7;
        }
        else
        {
                val_5 = ((丝三丈丈不丑业丁丕.x > 0f) ? 1 : 0) << 2;
            val_6 = 3;
        }
        
        }
        
        this.currentMoveDir = (丝三丈丈不丑业丁丕.x < 0) ? (val_6) : (val_5);
    }
    public void SetCurrentState()
    {
        if(isGrounded == false)
        {
                return;
        }
        
        if(this.currentMoveDir > 8)
        {
                return;
        }
        
        var val_2 = 106037908 + (this.currentMoveDir) << 2;
        val_2 = val_2 + 106037908;
        goto (106037908 + (this.currentMoveDir) << 2 + 106037908);
    }
    public void StartAnimation()
    {
        if(this.currentState > 4)
        {
                return;
        }
        
        var val_1 = 106037944 + (this.currentState) << 2;
        val_1 = val_1 + 106037944;
        goto (106037944 + (this.currentState) << 2 + 106037944);
    }
    private void 丈丒丟上七丝且业丅()
    {
        this.GetComponent<UnityEngine.Animation>().CrossFade(animation:  "idle");
    }
    private void Walk()
    {
        this.GetComponent<UnityEngine.Animation>().CrossFade(animation:  "walk");
    }
    private void 且下与七丁丄丆丛丟()
    {
        this.GetComponent<UnityEngine.Animation>().CrossFade(animation:  "strafeforwardleft");
    }
    private void 丏丕丅丌专丕与七下()
    {
        this.GetComponent<UnityEngine.Animation>().CrossFade(animation:  "strafeforwardright");
    }
    private void 七丌丄下丟丈丏万业()
    {
        this.GetComponent<UnityEngine.Animation>().CrossFade(animation:  "walkback");
    }
    private void 丗丐丙世万与世丆业()
    {
        this.GetComponent<UnityEngine.Animation>().CrossFade(animation:  "strafebackleft");
    }
    private void 丝七七三上世丄丑丙()
    {
        this.GetComponent<UnityEngine.Animation>().CrossFade(animation:  "strafebackright");
    }
    private void 世丂丕丌东丂上丁丄()
    {
        this.GetComponent<UnityEngine.Animation>().CrossFade(animation:  "strafeleft");
    }
    private void 与专丙业业丈且业专()
    {
        this.GetComponent<UnityEngine.Animation>().CrossFade(animation:  "straferight");
    }
    public void Jump()
    {
        this.currentState = 5;
        if((this.GetComponent<UnityEngine.Animation>().IsPlaying(name:  "jump")) != false)
        {
                this.GetComponent<UnityEngine.Animation>().Stop(name:  "jump");
        }
        
        this.GetComponent<UnityEngine.Animation>().CrossFade(animation:  "jump");
    }
    public RPG_Animation()
    {
    
    }

}
