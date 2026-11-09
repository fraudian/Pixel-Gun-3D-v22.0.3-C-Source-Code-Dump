using UnityEngine;
internal class Graffiti : PGBehaviour
{
    // Fields
    private UnityEngine.ParticleSystemRenderer _mainParticleSystemRenderer;
    private int 丟丄丕丝丝上三一丒;
    private UnityEngine.Coroutine 丝业丗不万下世万丗;
    private float 丙一丑丏丁一且丒业;
    private bool 丌且下丕下下丌万丞;
    internal UnityEngine.Vector3 且东丑丂丝丟世七一;
    
    // Methods
    private void Awake()
    {
        if(this.photonView == 0)
        {
                return;
        }
        
        this.丌且下丕下下丌万丞 = this.GetComponent<PhotonView>().isMine;
        float val_8 = (float)丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_8 = this._mainParticleSystemRenderer.sortingFudge - val_8;
        this._mainParticleSystemRenderer.sortingFudge = val_8;
    }
    private void Start()
    {
        if(this.丝业丗不万下世万丗 != null)
        {
                this.StopCoroutine(routine:  this.丝业丗不万下世万丗);
        }
        
        this.丝业丗不万下世万丗 = this.StartCoroutine(routine:  this.丒下丁丝一丐丙专上());
    }
    private void OnDestroy()
    {
        if(this.丝业丗不万下世万丗 == null)
        {
                return;
        }
        
        this.StopCoroutine(routine:  this.丝业丗不万下世万丗);
        this.丝业丗不万下世万丗 = 0;
    }
    private void Update()
    {
        if(this.丙一丑丏丁一且丒业 < 1f)
        {
                return;
        }
        
        this.丑丄丐丆丐丘丈下丟();
    }
    internal void 丘不世丒万丑丙丁丘(int 丙业与丙丗丝不丈东)
    {
        this.丟丄丕丝丝上三一丒 = 丙业与丙丗丝不丈东;
    }
    private void 丑丄丐丆丐丘丈下丟()
    {
        var val_2;
        var val_3;
        if(this.丝业丗不万下世万丗 != null)
        {
                this.StopCoroutine(routine:  this.丝业丗不万下世万丗);
            this.丝业丗不万下世万丗 = 0;
        }
        
        val_2 = null;
        val_2 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                if(this.丌且下丕下下丌万丞 == true)
        {
            goto label_8;
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                return;
        }
        
        label_8:
        val_3 = null;
        val_3 = null;
        丛与上丆丅丑业且与().丐东丞不丝丄丆专丒();
    }
    private System.Collections.IEnumerator 丒下丁丝一丐丙专上()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new Graffiti.三丙丑丒丕丄丝业且();
    }
    public Graffiti()
    {
        this.丟丄丕丝丝上三一丒 = 3600;
        UnityEngine.Vector3 val_1 = UnityEngine.Vector3.zero;
        this.且东丑丂丝丟世七一 = val_1;
        mem[1152921540177996748] = val_1.y;
        mem[1152921540177996752] = val_1.z;
    }

}
