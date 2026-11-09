using UnityEngine;
public class GamePauseController : MonoBehaviour
{
    // Fields
    internal static GamePauseController 丄丘七三上丕世丞业;
    internal bool 丟下世世专业下丈丞;
    private long 丝丑丟丂丘专丞且世;
    private bool 丆丕与三丝丙丑丛三;
    private bool 丙七三丌丐业专不丟;
    private bool 丛专下丞丒丛下下与;
    private double 丘丘丑丟丏与丕丝丛;
    private float 丑且丗丈丙东专三丕;
    
    // Properties
    private bool 丆丟丌丟不丄且东丌 { get; }
    
    // Methods
    private bool 丒丞与丑丟上且丘业()
    {
        return (bool)(UnityEngine.Application.platform == 8) ? 1 : 0;
    }
    public void OnApplicationPause(bool 东丗七丕丄不丐专丒)
    {
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        if(this.enabled == false)
        {
                return;
        }
        
        val_13 = 1152921505107111936;
        if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() == false)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.丒丌且丞丙下三丙下() != false)
        {
                return;
        }
        
        if(东丗七丕丄不丐专丒 != false)
        {
                if(this.丟下世世专业下丈丞 == false)
        {
            goto label_9;
        }
        
        }
        
        if(this.丆丕与三丝丙丑丛三 != false)
        {
                bool val_4 = this.七专丑且丂丟丌东一();
        }
        
        丅丒丗丑丒丙丛不丆.丒丄丒与下丌丏丒专();
        return;
        label_9:
        if(UnityEngine.Application.platform != 8)
        {
            goto label_36;
        }
        
        val_14 = null;
        val_14 = null;
        if(SquadController.丄丘七三上丕世丞业.inSquad == true)
        {
            goto label_32;
        }
        
        if(GameConnect.业丛丛丂一丆丕丗丟() == false)
        {
            goto label_20;
        }
        
        val_15 = null;
        val_15 = null;
        if(DuelController.丄丘七三上丕世丞业.canPause == false)
        {
            goto label_36;
        }
        
        label_20:
        if(GameConnect.一与东丝万上三丆丏() != false)
        {
                if(TeamDuelController.丅丌丛丏丞上万丛丕.canPause == false)
        {
            goto label_36;
        }
        
        }
        
        if(GameConnect.与丂丝丟丟三丑丝万() == false)
        {
            goto label_32;
        }
        
        val_16 = null;
        val_16 = null;
        if(SiegeController.三三万丆下一丗万丛.canPause == false)
        {
            goto label_36;
        }
        
        label_32:
        this.丆丕与三丝丙丑丛三 = true;
        this.丙七三丌丐业专不丟 = true;
        丅丒丗丑丒丙丛不丆.一世丁七且下世一专(丙业与丙丗丝不丈东:  false);
        return;
        label_36:
        GameConnect.下与业丒丝丕丙丘丙();
    }
    private bool 七专丑且丂丟丌东一()
    {
        var val_3;
        this.丆丕与三丝丙丑丛三 = false;
        if(丅丒丗丑丒丙丛不丆.上且丕丆丘且下丛丗() == false)
        {
            goto label_3;
        }
        
        long val_2 = 专七专下且专三一且.上且一丈丐三丄一丆();
        long val_3 = this.丝丑丟丂丘专丞且世;
        if(val_3 > val_2)
        {
            goto label_7;
        }
        
        val_3 = val_3 + 60;
        if(val_3 < val_2)
        {
            goto label_7;
        }
        
        label_3:
        val_3 = 0;
        return (bool)val_3;
        label_7:
        GameConnect.下与业丒丝丕丙丘丙();
        val_3 = 1;
        return (bool)val_3;
    }
    internal void 专世丈丛丛丕丝世专(bool 丑丅丛丌丄下万世丏)
    {
        this.丛专下丞丒丛下下与 = 丑丅丛丌丄下万世丏;
    }
    private void Start()
    {
        if(this.丛专下丞丒丛下下与 == false)
        {
                return;
        }
        
        var val_5 = 0;
        val_5 = val_5 + 1;
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.丒丄丒与下丌丏丒专().GetEnumerator());
    }
    private void Update()
    {
        if(this.丛专下丞丒丛下下与 != false)
        {
                if(丅丒丗丑丒丙丛不丆.丒丌且丞丙下三丙下() != false)
        {
                this.且与丆丞业丑丄丈丆();
        }
        else
        {
                this.丂七丁丝丙丌业专且();
        }
        
        }
        
        if(this.丆丕与三丝丙丑丛三 != false)
        {
                bool val_2 = this.七专丑且丂丟丌东一();
            if(val_2 == true)
        {
                return;
        }
        
        }
        
        if(this.丙七三丌丐业专不丟 != false)
        {
                this.丙七三丌丐业专不丟 = false;
            UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  val_2.下丛三丐丈业丐丞丌());
        }
        
        this.丝丑丟丂丘专丞且世 = 专七专下且专三一且.上且一丈丐三丄一丆();
    }
    private void OnEnable()
    {
        GamePauseController.丄丘七三上丕世丞业 = this;
    }
    private void OnDisable()
    {
        GamePauseController.丄丘七三上丕世丞业 = 0;
    }
    private System.Collections.IEnumerator 下丛三丐丈业丐丞丌()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        return (System.Collections.IEnumerator)new GamePauseController.丌一一万丑丒与东丂();
    }
    private void 且与丆丞业丑丄丈丆()
    {
        float val_6;
        var val_7;
        val_6 = UnityEngine.Time.time;
        if(this.丑且丗丈丙东专三丕 > 0f)
        {
                val_7 = null;
            val_7 = null;
            val_6 = val_6 - this.丑且丗丈丙东专三丕;
            if((val_6 > 15f) && (WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0))
        {
                GameController.丑七不且上丗丁一世().丛七丟万丏丑丙丕丕(世丁丙世丄一万丆三:  "Speedhack detected! Delta: "("Speedhack detected! Delta: ") + val_6);
        }
        
        }
        
        this.丑且丗丈丙东专三丕 = UnityEngine.Time.time;
    }
    private void 丂七丁丝丙丌业专且()
    {
        var val_8;
        double val_9;
        double val_8 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
        val_8 = null;
        val_8 = null;
        val_8 = this.丘丘丑丟丏与丕丝丛 - val_8;
        val_9 = 3.5;
        if((val_8 > val_9) && (WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC != 0))
        {
                val_9 = this.丘丘丑丟丏与丕丝丛;
            if((val_9 > 600) && (val_9 < 0))
        {
                if(丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() > 600)
        {
                GameController.丑七不且上丗丁一世().丛七丟万丏丑丙丕丕(世丁丙世丄一万丆三:  System.String.Format(format:  "Speedhack detected! Delta: {0}, Photon time: {1}, Last time: {2}", arg0:  val_8, arg1:  丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄(), arg2:  this.丘丘丑丟丏与丕丝丛));
        }
        
        }
        
        }
        
        this.丘丘丑丟丏与丕丝丛 = 丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄();
    }
    private System.Collections.IEnumerable 丒丄丒与下丌丏丒专()
    {
        .丗丏丅丕丆世丁专丟 = -2;
        .丈世三丐万且丅上丈 = System.Environment.CurrentManagedThreadId;
        return (System.Collections.IEnumerable)new GamePauseController.丁丘万世丆七丕丒丒();
    }
    public GamePauseController()
    {
        this.丛专下丞丒丛下下与 = true;
    }

}
