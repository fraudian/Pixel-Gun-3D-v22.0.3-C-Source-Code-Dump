using UnityEngine;
internal class ZoneWithActivePlayers : MonoBehaviour
{
    // Fields
    protected 丘丕丁丙一丐东丏专 丏丆丐一丝丟丗不丞;
    private PlayerDetector 丈丌丏丌丟丂丝丑丄;
    private bool 一丕丛丅不与丆丛且;
    
    // Properties
    internal bool 下丈专丛丂丝东丈丐 { get; }
    internal int 丒三丐丈丛丙且丟丅 { get; }
    internal bool 丑丅丏丛丑丆丏下丝 { get; }
    
    // Methods
    internal bool 世三丕丒丗丅丁一丙()
    {
        return (bool)this.一丕丛丅不与丆丛且;
    }
    internal int 丛丟丗不丝世丝万丕()
    {
        if(this.丏丆丐一丝丟丗不丞 != null)
        {
                return this.丏丆丐一丝丟丗不丞.丒一丅与与一丘不业();
        }
        
        return this.丏丆丐一丝丟丗不丞.丒一丅与与一丘不业();
    }
    private void Awake()
    {
        PlayerDetector val_1 = this.GetComponent<PlayerDetector>();
        this.丈丌丏丌丟丂丝丑丄 = val_1;
        if(val_1 == 0)
        {
                return;
        }
        
        this.丈丌丏丌丟丂丝丑丄.丐丅下丛丙不丐丂丏(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  typeof(ZoneWithActivePlayers).__il2cppRuntimeField_170));
    }
    protected virtual void 专丈下丐不业万七丗(bool 东丝丁下丁东且丑业)
    {
        this.一丕丛丅不与丆丛且 = 东丝丁下丁东且丑业;
    }
    internal bool 东丟下专七且与一三()
    {
        return (bool)(this.丏丆丐一丝丟丗不丞.丂丁丏一丙丛业且丌() > 0) ? 1 : 0;
    }
    internal virtual void Reset()
    {
        this.一丕丛丅不与丆丛且 = false;
        this.丏丆丐一丝丟丗不丞.世业丒万丘丆专丘丐();
        if(this.丈丌丏丌丟丂丝丑丄 == null)
        {
                return;
        }
        
        this.丈丌丏丌丟丂丝丑丄.Reset();
    }
    internal void 且丐丆一丞丈丈丝丌(int 业上上丏丄不上丅丈)
    {
        int val_6;
        var val_7;
        val_6 = 业上上丏丄不上丅丈;
        val_7 = null;
        val_7 = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_9:
        if(((-337152808) & 1) == 0)
        {
            goto label_4;
        }
        
        if((X22 + 32.Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = val_6})) == false)
        {
            goto label_9;
        }
        
        this.丏丆丐一丝丟丗不丞.上丙上丈三丐丞丛专(专丞上七七且丝七丗:  0.丐丏七丌丕丗业且上(), 丂三丟丂丈丐丆丗丟:  UnityEngine.Time.time);
        goto label_9;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal virtual void 与七丌专丌与丆丌丒(int 业上上丏丄不上丅丈)
    {
        int val_5;
        var val_6;
        val_5 = 业上上丏丄不上丅丈;
        val_6 = null;
        val_6 = null;
        List.Enumerator<T> val_1 = 丘丛丞且一丅丁丏丐.丁丟丌专三上丐丕丙.GetEnumerator();
        label_9:
        if(((-337024408) & 1) == 0)
        {
            goto label_4;
        }
        
        if((X22 + 32.Equals(other:  new UnityEngine.PhysicsScene2D() {m_Handle = val_5})) == false)
        {
            goto label_9;
        }
        
        this.丏丆丐一丝丟丗不丞.丒下丝下丒丟丞丆丞(专丞上七七且丝七丗:  0.丐丏七丌丕丗业且上());
        goto label_9;
        label_4:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal void 丆丞丗上丂丁且丅世(Player_move_c 专丞上七七且丝七丗)
    {
        this.丏丆丐一丝丟丗不丞.丒下丝下丒丟丞丆丞(专丞上七七且丝七丗:  专丞上七七且丝七丗);
    }
    public ZoneWithActivePlayers()
    {
        this.丏丆丐一丝丟丗不丞 = new 丘丕丁丙一丐东丏专();
    }

}
