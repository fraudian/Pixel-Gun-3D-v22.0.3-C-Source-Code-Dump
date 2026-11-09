using UnityEngine;
internal class CampaignBase : MonoBehaviour
{
    // Fields
    public System.Collections.Generic.List<CampaignPartBase> listPartBase;
    public static float[] coefDamageFromTier;
    public float maxHealth;
    private float 世丙丟上丘上七万万;
    private System.Action<CampaignBase> 丈丌丙丘丅不丌万世;
    
    // Properties
    internal float 三丄丗世丌丂丗丞东 { get; }
    
    // Methods
    internal float 三丏丟不丆丅丞不丛()
    {
        return (float)this.世丙丟上丘上七万万;
    }
    internal void 且丂世丆丌不丏与丂(System.Action<CampaignBase> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.丈丌丙丘丅不丌万世, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈丌丙丘丅不丌万世 != 1152921539931079384);
    
    }
    internal void 丟下丒丐一丏丁丙丂(System.Action<CampaignBase> 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.丈丌丙丘丅不丌万世, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.丈丌丙丘丅不丌万世 != 1152921539931215960);
    
    }
    private void Awake()
    {
        CampaignBase val_4;
        var val_5;
        val_4 = this;
        int val_1 = Player_move_c.丞丐且丄丆丙丝丅丐();
        val_5 = null;
        val_5 = null;
        int val_4 = RilisoftBot.BaseBot.且业七丒丞丈丟丛不;
        val_4 = this.maxHealth * val_4;
        this.maxHealth = val_4;
        this.世丙丟上丘上七万万 = val_4;
        List.Enumerator<T> val_2 = this.listPartBase.GetEnumerator();
        goto label_6;
        label_8:
        string val_3 = 0.丐丏七丌丕丗业且上();
        mem2[0] = val_4;
        label_6:
        if((964755064 & 1) != 0)
        {
            goto label_8;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
    }
    internal bool 丐丏丗丏东世丏丞丝()
    {
        return (bool)(this.世丙丟上丘上七万万 <= 0f) ? 1 : 0;
    }
    internal void 丌丐万丛三上一与东(float 丞丈专下丈专业三丞)
    {
        float val_2;
        var val_3;
        if(this.世丙丟上丘上七万万 <= 0f)
        {
                return;
        }
        
        val_2 = this.世丙丟上丘上七万万 - 丞丈专下丈专业三丞;
        this.世丙丟上丘上七万万 = val_2;
        if(this.丈丌丙丘丅不丌万世 != null)
        {
                this.丈丌丙丘丅不丌万世.Invoke(obj:  this);
            val_2 = this.世丙丟上丘上七万万;
        }
        
        if(val_2 > 0f)
        {
                return;
        }
        
        Rilisoft.LevelCompleteScript.一世丕丝丞丌七且丌(丙业与丙丗丝不丈东:  2);
        val_3 = null;
        val_3 = null;
        LevelCompleteLoader.七丐丅专且专七三丆 = 0;
        LevelCompleteLoader.专万丟三世业丙丈且 = "LevelComplete";
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "LevelToCompleteProm");
        UnityEngine.Debug.LogError(message:  "Death when destroy generate");
    }
    public CampaignBase()
    {
        this.listPartBase = new System.Collections.Generic.List<CampaignPartBase>();
    }
    private static CampaignBase()
    {
        CampaignBase.coefDamageFromTier = new float[7] {4.600603E-41f, 5.748547E-41f, 4.186881E-08f, 8.96831E-44f, 5.829402E-42f, -6.334596E-23f, 2.304856E-41f};
    }

}
