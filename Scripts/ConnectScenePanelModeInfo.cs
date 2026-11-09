using UnityEngine;
internal sealed class ConnectScenePanelModeInfo : MonoBehaviour
{
    // Fields
    private MiniPoolGroup pool;
    private UnityEngine.Transform popupHolder;
    
    // Properties
    private string 且丆专七丝三不业丘 { get; }
    private string 世业丞丙丒世上丕不 { get; }
    private string 丁且丂丄丐丌丌丆丆 { get; }
    private string 下万丘业丝一七丗丆 { get; }
    private string 专下万丞东丒一上且 { get; }
    
    // Methods
    private string 丁丄丕丌丄上下丏丁()
    {
        return "GameModeHub/ModeHint/MiniGameInfo";
    }
    private string 世东七丆丐专丐丘丁()
    {
        return "GameModeHub/ModeHint/UniversalInfo";
    }
    private string 上丅丆三丐丒万丙世()
    {
        return "GameModeHub/ModeHint/UniversalCategoryHint";
    }
    private string 且丗丐丗丒与丙丝丄()
    {
        return "GameModeHub/ModeHint/CompetitionCategoryHint";
    }
    private string 丌东丞丒丄丙丗丑丈()
    {
        return "GameModeHub/ModeHint/MapHint";
    }
    private GMHModeInfoHint 丌丙丗丛丂丗且上丑()
    {
        object val_21;
        int val_22;
        UnityEngine.Object val_23;
        Rilisoft.七丕丟丏三丈一丄世 val_24;
        object val_25;
        var val_26;
        val_21 = this;
        val_22 = System.String.alignConst;
        val_23 = 0;
        if(PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业 == 0)
        {
                return (GMHModeInfoHint)val_23;
        }
        
        PGCompany.GameModeHub.丗丙丈下上丞不丅丑 val_2 = PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.丘专丒丈丌丁且丁丟();
        if(val_2.丐丂丄丘丈专七万下 != 30)
        {
            goto label_6;
        }
        
        if(PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业 == null)
        {
            goto label_24;
        }
        
        if(PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.丄业丌世上丛丂丑丄() == null)
        {
            goto label_8;
        }
        
        val_22 = "GameModeHub/ModeHint/MiniGameInfo";
        val_23 = this.pool.Get<GMHModeInfoHint>(丛丄业丕且丗下一万:  val_22);
        if(val_23 == 0)
        {
            goto label_44;
        }
        
        val_23.七东丘东专丗世且三(丂丛丑东不丅丈一东:  val_3.一丗丟丛丈专丙三丌);
        goto label_44;
        label_6:
        val_24 = PGCompany.GameModeHub.丙丙与东一丐丂丐上.丐丐丟三丑丁东丐丕();
        if(val_24 != 100)
        {
            goto label_16;
        }
        
        if((PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业 == null) || (PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.丘专丒丈丌丁且丁丟() == null))
        {
            goto label_37;
        }
        
        PGCompany.GameModeHub.世丘与丙丗且三且丗 val_8 = PGCompany.GameModeHub.世丘与丙丗且三且丗.丑七不且上丗丁一世();
        if(val_8 == null)
        {
            goto label_19;
        }
        
        PGCompany.GameModeHub.丗丙丈下上丞不丅丑 val_9 = PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.丘专丒丈丌丁且丁丟();
        val_25 = val_8.丆业丝不一丒丞且丝(丑丅七丅一丈丘丞七:  val_9.丅不丗丂丑丈上丘丙);
        goto label_22;
        label_8:
        if((PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业 == null) || (PGCompany.GameModeHub.GMHMainView.丄丘七三上丕世丞业.丄业丌世上丛丂丑丄() == null))
        {
            goto label_24;
        }
        
        val_26 = 0;
        goto label_25;
        label_24:
        val_26 = 0;
        label_25:
        if(((-1979453704) & 1) == 0)
        {
            goto label_37;
        }
        
        val_24 = val_26.丙东专丂世丈丏丁丂();
        if(val_24 == 100)
        {
            goto label_37;
        }
        
        label_16:
        val_22 = "GameModeHub/ModeHint/UniversalInfo";
        val_23 = this.pool.Get<GMHModeInfoHint>(丛丄业丕且丗下一万:  val_22);
        if(val_23 == 0)
        {
            goto label_44;
        }
        
        val_23.丈万丆且丏丒丁丆丙(丂丛丑东不丅丈一东:  val_24);
        goto label_44;
        label_19:
        val_25 = 0;
        label_22:
        UnityEngine.Debug.LogWarning(message:  System.String.Format(format:  "Will show info from category: {0}. ", arg0:  val_25));
        if(val_25 == 0)
        {
            goto label_37;
        }
        
        val_22 = "GameModeHub/ModeHint/UniversalInfo";
        val_23 = this.pool.Get<GMHModeInfoHint>(丛丄业丕且丗下一万:  val_22);
        if(val_23 == 0)
        {
            goto label_44;
        }
        
        val_23.丅丐丂丝丌丅世万丐(七丆丒与丗丌丄且丂:  val_25);
        goto label_44;
        label_37:
        val_23 = 0;
        label_44:
        if(val_23 == 0)
        {
                val_21 = "Hint window for " + val_22 + " not loaded";
            UnityEngine.Debug.LogError(message:  val_21);
            return (GMHModeInfoHint)val_23;
        }
        
        System.Action<System.String, UnityEngine.MonoBehaviour> val_20 = null;
        val_21 = val_20;
        val_20 = new System.Action<System.String, UnityEngine.MonoBehaviour>(object:  this.pool, method:  public System.Void MiniPoolGroup::Return(string 丛丄业丕且丗下一万, UnityEngine.MonoBehaviour 万且万且丑丗且丌丆));
        val_23.丅专不丛下丒丟东丐(丟不丒万丝与丂上丘:  val_20, 丛丄业丕且丗下一万:  val_22);
        return (GMHModeInfoHint)val_23;
    }
    private void 丝丛东丏丒世万丕丕(GMHModeInfoHint 业丈不万上下世丏一)
    {
        业丈不万上下世丏一.transform.SetParent(p:  this.popupHolder);
        丞东丑专丛丆丄丝世.且七丙丄丘一丄上不(不丂丅丁且丆东东丂:  业丈不万上下世丏一.transform);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  业丈不万上下世丏一, 丏业丟一东丂东丘丛:  true);
    }
    internal void 丟且丈丆一丅丟一丆(Rilisoft.七丕丟丏三丈一丄世 业丒与丐不丘七业丒)
    {
        GMHModeInfoHint val_1 = this.pool.Get<GMHModeInfoHint>(丛丄业丕且丗下一万:  "GameModeHub/ModeHint/UniversalCategoryHint");
        if(val_1 == 0)
        {
                return;
        }
        
        System.Action<System.String, UnityEngine.MonoBehaviour> val_3 = new System.Action<System.String, UnityEngine.MonoBehaviour>(object:  this.pool, method:  public System.Void MiniPoolGroup::Return(string 丛丄业丕且丗下一万, UnityEngine.MonoBehaviour 万且万且丑丗且丌丆));
        if(val_1 != null)
        {
                val_1.丅专不丛下丒丟东丐(丟不丒万丝与丂上丘:  val_3, 丛丄业丕且丗下一万:  "GameModeHub/ModeHint/UniversalCategoryHint");
        }
        else
        {
                val_1.丅专不丛下丒丟东丐(丟不丒万丝与丂上丘:  val_3, 丛丄业丕且丗下一万:  "GameModeHub/ModeHint/UniversalCategoryHint");
        }
        
        val_1.七东丘东专丗世且三(丂丛丑东不丅丈一东:  业丒与丐不丘七业丒);
        this.丝丛东丏丒世万丕丕(业丈不万上下世丏一:  val_1);
    }
    internal void 万丗丅上专与东三下(PGCompany.GameModeHub.丗丙丈下上丞不丅丑 丂丛丑东不丅丈一东)
    {
        UnityEngine.Object val_5;
        if((丂丛丑东不丅丈一东.丐丂丄丘丈专七万下 - 1) > 6)
        {
                return;
        }
        
        val_5 = this.pool.Get<GMHModeInfoHint>(丛丄业丕且丗下一万:  "GameModeHub/ModeHint/UniversalCategoryHint");
        if(val_5 == 0)
        {
                return;
        }
        
        System.Action<System.String, UnityEngine.MonoBehaviour> val_4 = new System.Action<System.String, UnityEngine.MonoBehaviour>(object:  this.pool, method:  public System.Void MiniPoolGroup::Return(string 丛丄业丕且丗下一万, UnityEngine.MonoBehaviour 万且万且丑丗且丌丆));
        if(val_5 != null)
        {
                val_5.丅专不丛下丒丟东丐(丟不丒万丝与丂上丘:  val_4, 丛丄业丕且丗下一万:  "GameModeHub/ModeHint/UniversalCategoryHint");
        }
        else
        {
                val_5.丅专不丛下丒丟东丐(丟不丒万丝与丂上丘:  val_4, 丛丄业丕且丗下一万:  "GameModeHub/ModeHint/UniversalCategoryHint");
        }
        
        val_5.丈万丆且丏丒丁丆丙(丂丛丑东不丅丈一东:  106032800 + ((丂丛丑东不丅丈一东.丐丂丄丘丈专七万下 - 1)) << 2);
        this.丝丛东丏丒世万丕丕(业丈不万上下世丏一:  val_5);
    }
    internal void 丞一丐七丐丘丑世且(PGCompany.GameModeHub.万业世丙丗丌与不丆 丞丁丑丏丄丏七丂不)
    {
        GMHModeInfoHint val_1 = this.pool.Get<GMHModeInfoHint>(丛丄业丕且丗下一万:  "GameModeHub/ModeHint/MapHint");
        if(val_1 == 0)
        {
                return;
        }
        
        System.Action<System.String, UnityEngine.MonoBehaviour> val_3 = new System.Action<System.String, UnityEngine.MonoBehaviour>(object:  this.pool, method:  public System.Void MiniPoolGroup::Return(string 丛丄业丕且丗下一万, UnityEngine.MonoBehaviour 万且万且丑丗且丌丆));
        if(val_1 != null)
        {
                val_1.丅专不丛下丒丟东丐(丟不丒万丝与丂上丘:  val_3, 丛丄业丕且丗下一万:  "GameModeHub/ModeHint/MapHint");
        }
        else
        {
                val_1.丅专不丛下丒丟东丐(丟不丒万丝与丂上丘:  val_3, 丛丄业丕且丗下一万:  "GameModeHub/ModeHint/MapHint");
        }
        
        val_1.丘上丄专丈丂丆丝丁(丞丁丑丏丄丏七丂不:  丞丁丑丏丄丏七丂不);
        this.丝丛东丏丒世万丕丕(业丈不万上下世丏一:  val_1);
    }
    internal void 丆丗万丒七上丆三丞(PGCompany.GameModeHub.丟与丗不不上丆丞三 七丆丒与丗丌丄且丂)
    {
        if((System.String.op_Equality(a:  0, b:  "Category08")) != false)
        {
                if((七丆丒与丗丌丄且丂.与不丞丑七丘丁丂丛().丂丆世世丕丅丕丅上(丆万一不丌且东丐丐:  "locked.exp", 丟且丒专下丈七丗丕:  4)) != true)
        {
                "GameModeHub/ModeHint/UniversalCategoryHint" = "GameModeHub/ModeHint/CompetitionCategoryHint";
        }
        
        }
        
        GMHModeInfoHint val_4 = this.pool.Get<GMHModeInfoHint>(丛丄业丕且丗下一万:  "GameModeHub/ModeHint/UniversalCategoryHint");
        if(val_4 == 0)
        {
                return;
        }
        
        System.Action<System.String, UnityEngine.MonoBehaviour> val_6 = new System.Action<System.String, UnityEngine.MonoBehaviour>(object:  this.pool, method:  public System.Void MiniPoolGroup::Return(string 丛丄业丕且丗下一万, UnityEngine.MonoBehaviour 万且万且丑丗且丌丆));
        if(val_4 != null)
        {
                val_4.丅专不丛下丒丟东丐(丟不丒万丝与丂上丘:  val_6, 丛丄业丕且丗下一万:  "GameModeHub/ModeHint/UniversalCategoryHint");
        }
        else
        {
                val_4.丅专不丛下丒丟东丐(丟不丒万丝与丂上丘:  val_6, 丛丄业丕且丗下一万:  "GameModeHub/ModeHint/UniversalCategoryHint");
        }
        
        val_4.丑丒万丝一丙丘业丆(七丆丒与丗丌丄且丂:  七丆丒与丗丌丄且丂);
        this.丝丛东丏丒世万丕丕(业丈不万上下世丏一:  val_4);
    }
    internal void 丛丗丝且世丟丌东万(System.Nullable<UnityEngine.Vector3> 上不一丗下世丂丞与)
    {
        GMHModeInfoHint val_4 = this.丌丙丗丛丂丗且上丑();
        if(val_4 == 0)
        {
                return;
        }
        
        this.丝丛东丏丒世万丕丕(业丈不万上下世丏一:  val_4 = this.丌丙丗丛丂丗且上丑());
        if(( & 1) == 0)
        {
                return;
        }
        
        val_4 = val_4.transform;
        val_4.position = new UnityEngine.Vector3() {x = V0.16B, y = V1.16B, z = V2.16B};
    }
    public ConnectScenePanelModeInfo()
    {
    
    }

}
