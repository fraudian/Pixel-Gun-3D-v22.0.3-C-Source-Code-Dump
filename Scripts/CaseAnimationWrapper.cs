using UnityEngine;
public class CaseAnimationWrapper : MonoBehaviour
{
    // Fields
    public UnityEngine.Animator animPrev;
    public UnityEngine.Animator animNext;
    public UnityEngine.Transform casePrev;
    public UnityEngine.Transform caseNext;
    public UnityEngine.GameObject ParticleAccept;
    public UnityEngine.GameObject ParticleRise;
    private UnityEngine.GameObject[] 且与丕丑且世一三不;
    private UnityEngine.GameObject 万与丟丐与丒丐丗一;
    private UnityEngine.GameObject 丑丛丛业丄丌三丁业;
    private float 世东不与七丗丒业一;
    private System.Collections.Generic.List<CaseAnimationWrapper.七丏丕上万丝丘丅丛> 丑上且丛且丝专世与;
    private string 丝丏业丅丈东业丝丒;
    
    // Methods
    public void ClearAnimations()
    {
        this.丑上且丛且丝专世与.Clear();
        this.世东不与七丗丒业一 = 0f;
    }
    public void AddCaseAnimation(Rilisoft.丝三丕七业丗丂丆三 丞丂世丏万上上丘丗, Rilisoft.丝三丕七业丗丂丆三 世丒丌丆丁丝丒三丕, CaseAnimationWrapper.专丘万丙丝丌丗丞丛 丐丐七专三且世三七, bool 丝上丑业丙下丂万与)
    {
        bool val_1 = 丝上丑业丙下丂万与;
        this.丑上且丛且丝专世与.Add(item:  new 七丏丕上万丝丘丅丛() {丞丂世丏万上上丘丗 = 丞丂世丏万上上丘丗, 世丒丌丆丁丝丒三丕 = 丞丂世丏万上上丘丗, 丐丐七专三且世三七 = 丞丂世丏万上上丘丗, 丝上丑业丙下丂万与 = 丞丂世丏万上上丘丗});
    }
    private void 下世东世丛一丁七丆(CaseAnimationWrapper.七丏丕上万丝丘丅丛 丐丐七专三且世三七)
    {
        if(this.万与丟丐与丒丐丗一 != 0)
        {
                this.万与丟丐与丒丐丗一.gameObject.SetActive(value:  false);
        }
        
        if(this.丑丛丛业丄丌三丁业 != 0)
        {
                this.丑丛丛业丄丌三丁业.gameObject.SetActive(value:  false);
        }
        
        this.世东不与七丗丒业一 = 0.5f;
        if((X2 & 1095216660480) == 0)
        {
                UnityEngine.GameObject val_6 = this.且丏业与东业丐三丌(世万丟丂丅丈丁丅丂:  丐丐七专三且世三七.丞丂世丏万上上丘丗);
            this.万与丟丐与丒丐丗一 = val_6;
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_6, 丏业丟一东丂东丘丛:  true);
            this.万与丟丐与丒丐丗一.transform.SetParent(parent:  this.casePrev, worldPositionStays:  false);
        }
        
        UnityEngine.GameObject val_8 = this.且丏业与东业丐三丌(世万丟丂丅丈丁丅丂:  0);
        this.丑丛丛业丄丌三丁业 = val_8;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_8, 丏业丟一东丂东丘丛:  true);
        this.丑丛丛业丄丌三丁业.transform.SetParent(parent:  this.caseNext, worldPositionStays:  false);
        if(X2 > 3)
        {
                return;
        }
        
        var val_10 = X2 & 4294967295;
        var val_27 = 106014208 + ((X2 & 4294967295)) << 2;
        val_27 = val_27 + 106014208;
        goto (106014208 + ((X2 & 4294967295)) << 2 + 106014208);
    }
    private void Update()
    {
        if(this.世东不与七丗丒业一 > 0f)
        {
                float val_1 = UnityEngine.Time.deltaTime;
            val_1 = this.世东不与七丗丒业一 - val_1;
            this.世东不与七丗丒业一 = val_1;
            if(val_1 > 0f)
        {
                return;
        }
        
            if(this.万与丟丐与丒丐丗一 == 0)
        {
                return;
        }
        
            if(this.万与丟丐与丒丐丗一 == this.丑丛丛业丄丌三丁业)
        {
                return;
        }
        
            this.万与丟丐与丒丐丗一.gameObject.SetActive(value:  false);
            return;
        }
        
        if(this.丑上且丛且丝专世与.Count < 1)
        {
                return;
        }
        
        七丏丕上万丝丘丅丛 val_6 = this.丑上且丛且丝专世与.Item[0];
        this.下世东世丛一丁七丆(丐丐七专三且世三七:  new 七丏丕上万丝丘丅丛() {丞丂世丏万上上丘丗 = this.丑上且丛且丝专世与, 世丒丌丆丁丝丒三丕 = this.丑上且丛且丝专世与, 丐丐七专三且世三七 = this.丑上且丛且丝专世与, 丝上丑业丙下丂万与 = this.丑上且丛且丝专世与});
        this.丑上且丛且丝专世与.RemoveAt(index:  0);
    }
    public void Initialize(string 丝丏业丅丈东业丝丒)
    {
        this.丝丏业丅丈东业丝丒 = 丝丏业丅丈东业丝丒;
    }
    public void ResetState()
    {
        if(this.万与丟丐与丒丐丗一 != 0)
        {
                this.万与丟丐与丒丐丗一.gameObject.SetActive(value:  false);
        }
        
        if(this.丑丛丛业丄丌三丁业 != 0)
        {
                this.丑丛丛业丄丌三丁业.gameObject.SetActive(value:  false);
        }
        
        this.世东不与七丗丒业一 = 0f;
    }
    private UnityEngine.GameObject 且丏业与东业丐三丌(Rilisoft.丝三丕七业丗丂丆三 世万丟丂丅丈丁丅丂)
    {
        UnityEngine.GameObject val_8;
        val_8 = this.且与丕丑且世一三不[(long)世万丟丂丅丈丁丅丂];
        if(val_8 == 0)
        {
                val_8 = GameEventsHalper.丙丌丘丅丑与与丂万<UnityEngine.GameObject>(丞丕丟丁且丛三丕不:  this.丝丏业丅丈东业丝丒, 丒丘丏上丙丟丑丕丈:  System.String.Format(format:  "duel_chest_{0}", arg0:  世万丟丂丅丈丁丅丂 + 1), 下上丕丌业丁丙上丐:  true);
            UnityEngine.Vector3 val_6 = UnityEngine.Vector3.one;
            val_8.transform.localScale = new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z};
            丞东丑专丛丆丄丝世.世丙丆业世丝与丝七(丝三丁东丈丒世丅业:  val_8, 不东丛三丂丌丑专丆:  UnityEngine.LayerMask.NameToLayer(layerName:  "Rocket"), 东丛下丘三下丝丌丑:  new System.Nullable<System.Int32>() {HasValue = false});
            this.且与丕丑且世一三不[(long)世万丟丂丅丈丁丅丂] = val_8;
        }
        
        return (UnityEngine.GameObject)this.且与丕丑且世一三不[(long)世万丟丂丅丈丁丅丂];
    }
    private void 丈世丝世七丙丘上丈(string 一丑丑丝丏且丂丏丘)
    {
        if(this.animPrev != 0)
        {
                this.animPrev.SetTrigger(name:  一丑丑丝丏且丂丏丘);
        }
        
        if(this.animNext == 0)
        {
                return;
        }
        
        this.animNext.SetTrigger(name:  一丑丑丝丏且丂丏丘);
    }
    private System.Collections.IEnumerator 一丈丅丆丁世且丁丏(CaseAnimationWrapper.专丘万丙丝丌丗丞丛 丁丅丈丌丟世丗丗丟)
    {
        CaseAnimationWrapper.业且与丒三与万东丙 val_1 = new CaseAnimationWrapper.业且与丒三与万东丙();
        .丗丏丅丕丆世丁专丟 = 0;
        if(val_1 != null)
        {
                .丝且与丝丒丟万丁专 = this;
        }
        else
        {
                mem[32] = this;
        }
        
        .丁丅丈丌丟世丗丗丟 = 丁丅丈丌丟世丗丗丟;
        return (System.Collections.IEnumerator)val_1;
    }
    public CaseAnimationWrapper()
    {
        this.且与丕丑且世一三不 = new UnityEngine.GameObject[4];
        this.丑上且丛且丝专世与 = new System.Collections.Generic.List<七丏丕上万丝丘丅丛>();
    }

}
