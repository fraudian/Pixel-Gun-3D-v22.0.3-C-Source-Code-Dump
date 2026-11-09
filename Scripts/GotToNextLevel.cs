using UnityEngine;
internal sealed class GotToNextLevel : MonoBehaviour
{
    // Fields
    internal static GotToNextLevel 丄丘七三上丕世丞业;
    private System.Action 丒一丈丛丁与丌丝丁;
    private UnityEngine.GameObject 丒一丄丗丞丗丄丐丂;
    private Player_move_c 丕七三上上一丆丈世;
    private bool 丆丑上不丂丞业万丟;
    private System.EventHandler 专丘丒丂三丂不丁丅;
    private System.IDisposable 丐丆七且丞丏下三丙;
    
    // Methods
    public void add_Invoked(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Combine(a:  this.专丘丒丂三丂不丁丅, b:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专丘丒丂三丂不丁丅 != 1152921526179726984);
    
    }
    public void remove_Invoked(System.EventHandler 丙业与丙丗丝不丈东)
    {
        var val_3;
        do
        {
            val_3 = System.Delegate.Remove(source:  this.专丘丒丂三丂不丁丅, value:  丙业与丙丗丝不丈东);
            if((val_3 != null) && (null != null))
        {
                val_3 = 0;
        }
        
        }
        while(this.专丘丒丂三丂不丁丅 != 1152921526179863560);
    
    }
    private void Awake()
    {
        null = null;
        GotToNextLevel.丄丘七三上丕世丞业 = this;
        System.Action val_1 = new System.Action(object:  this, method:  System.Void GotToNextLevel::丐一丈不丂与丑丒世());
        this.丒一丈丛丁与丌丝丁 = val_1;
        GameModeController.丂丂且丂丂与丟丁丛(丙业与丙丗丝不丈东:  val_1);
    }
    private void OnDestroy()
    {
        var val_2;
        GameModeController.上丝世一丆丙丙丙三(丙业与丙丗丝不丈东:  this.丒一丈丛丁与丌丝丁);
        val_2 = null;
        val_2 = null;
        GotToNextLevel.丄丘七三上丕世丞业 = 0;
        if(InGameGUI.丙丞专丌丁丞与不丐 == 0)
        {
                return;
        }
        
        InGameGUI.丙丞专丌丁丞与不丐.SetEnablePerfectLabel(丝三丄专丗丞丄丄丌:  false);
    }
    private void Update()
    {
        if(this.丒一丄丗丞丗丄丐丂 == 0)
        {
                return;
        }
        
        if(this.丕七三上上一丆丈世 == 0)
        {
                return;
        }
        
        if(this.丆丑上不丂丞业万丟 == true)
        {
                return;
        }
        
        UnityEngine.Vector3 val_4 = this.transform.position;
        UnityEngine.Vector3 val_6 = this.丒一丄丗丞丗丄丐丂.transform.position;
        UnityEngine.Vector3 val_7 = UnityEngine.Vector3.op_Subtraction(a:  new UnityEngine.Vector3() {x = val_4.x, y = val_4.y, z = val_4.z}, b:  new UnityEngine.Vector3() {x = val_6.x, y = val_6.y, z = val_6.z});
        if((UnityEngine.Vector3.SqrMagnitude(vector:  new UnityEngine.Vector3() {x = val_7.x, y = val_7.y, z = val_7.z})) >= 0)
        {
                return;
        }
        
        this.EnterTeleport();
    }
    public void EnterTeleport()
    {
        InGameGUI val_7;
        var val_8;
        var val_9;
        var val_10;
        CheckpointController val_11;
        var val_12;
        var val_13;
        var val_14;
        var val_15;
        var val_16;
        val_7 = this;
        val_8 = null;
        val_8 = null;
        TrainingController.丏丛世丄丈丙不丄丞 = true;
        val_9 = null;
        val_9 = null;
        typeof(Player_move_c).__il2cppRuntimeField_628 + 456.enabled = false;
        丈丆丅丄与万丌世丂.世丟下丕丞丛丝丐丐(丒且丆丘丞丑业丅不:  20);
        if(this.丒一丄丗丞丗丄丐丂 == 0)
        {
                return;
        }
        
        if(this.丕七三上上一丆丈世 == 0)
        {
                return;
        }
        
        if(this.丆丑上不丂丞业万丟 == true)
        {
                return;
        }
        
        this.丆丑上不丂丞业万丟 = true;
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                val_10 = null;
            val_10 = null;
            if((System.String.op_Equality(a:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, b:  "Death_Escape_campaign4")) != false)
        {
                val_11 = 1152921505047793664;
            if(CheckpointController.丄丘七三上丕世丞业 != 0)
        {
                val_12 = null;
            val_12 = null;
            丅丌丝丘丐不丒丄专.三与且上丘丞上丕下 = false;
            丅丌丝丘丐不丒丄专.上丏丗丑丏丕且世上 = false;
            val_13 = null;
            val_13 = null;
            if(丛丑且业丗世丈丙丌.业丁丒丌不丌丞丒丛 > (int)CheckpointController.丄丘七三上丕世丞业.万与下丐丏丝三三丟)
        {
                val_14 = null;
            val_14 = null;
            丅丌丝丘丐不丒丄专.三与且上丘丞上丕下 = true;
        }
        
            val_15 = null;
            val_15 = null;
            val_11 = CheckpointController.丄丘七三上丕世丞业;
            if(丛丑且业丗世丈丙丌.丙专专丙七东下世万 > (int)CheckpointController.丄丘七三上丕世丞业.万与下丐丏丝三三丟)
        {
                val_16 = null;
            val_16 = null;
            丅丌丝丘丐不丒丄专.上丏丗丑丏丕且世上 = true;
        }
        
        }
        
        }
        
        }
        
        this.一与丛与丛一丂业世();
        val_7 = InGameGUI.丙丞专丌丁丞与不丐;
        if(val_7 == 0)
        {
                return;
        }
        
        InGameGUI.丙丞专丌丁丞与不丐.ExitingInCampaign = true;
        InGameGUI.丙丞专丌丁丞与不丐.SetEnablePerfectLabel(丝三丄专丗丞丄丄丌:  true);
    }
    private void OnDisable()
    {
        if(this.丐丆七且丞丏下三丙 == null)
        {
                return;
        }
        
        var val_2 = 0;
        val_2 = val_2 + 1;
        this.丐丆七且丞丏下三丙.Dispose();
        this.丐丆七且丞丏下三丙 = 0;
    }
    private void 丕丈丝丅且丙业丕丆()
    {
        if(UnityEngine.Application.isEditor == false)
        {
                return;
        }
        
        UnityEngine.Debug.Log(message:  "Ignoring [Escape] after touching the portal.");
    }
    private void 一与丛与丛一丂业世()
    {
        var val_11;
        if(this.丐丆七且丞丏下三丙 != null)
        {
                var val_10 = 0;
            val_10 = val_10 + 1;
            this.丐丆七且丞丏下三丙.Dispose();
        }
        
        this.丐丆七且丞丏下三丙 = Rilisoft.BackSystem.丑七不且上丗丁一世().Register(业丏丈世世世丞丒世:  new System.Action(object:  this, method:  System.Void GotToNextLevel::丕丈丝丅且丙业丕丆()), 与且专丈不万东一万:  "Touching the Portal");
        if(this.专丘丒丂三丂不丁丅 != null)
        {
                val_11 = null;
            val_11 = null;
            this.专丘丒丂三丂不丁丅.Invoke(sender:  this, e:  System.EventArgs.Empty);
        }
        
        UnityEngine.SceneManagement.Scene val_5 = UnityEngine.SceneManagement.SceneManager.GetActiveScene();
        if((val_5.m_Handle.name.Equals(value:  与丂丏丛丞丞丒丟丄.丗丄丛丆七丁丗丗专())) != false)
        {
                this.Invoke(methodName:  "BannerTrainingCompleteInvoke", time:  2f);
            UnityEngine.Color val_9 = UnityEngine.Color.white;
            AutoFade.三丒下丝东七且七丈(世三丏丑丙丅丌且下:  2.05f, 业三一丆丒与丘且业:  0f, 丅世丗丛万下下专丕:  0f, 一七专业丞丛世且丌:  new UnityEngine.Color() {r = val_9.r, g = val_9.g, b = val_9.b, a = val_9.a});
            TrainingController.丛丒丝丅丞丁且业上(丏丘丙丆三丕丕上丌:  6);
            return;
        }
        
        GotToNextLevel.下一三丁丘上下丁丐();
    }
    private void 东丙专且不丁丛一丁()
    {
        var val_16;
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().丏丞丑丈丛丌下丘丁(且丘丅丘丙丟万且丕:  145);
        UnityEngine.PlayerPrefs.Save();
        val_16 = null;
        val_16 = null;
        LevelCompleteLoader.专万丟三世业丙丈且 = 与丂丏丛丞丞丒丟丄.丕不丗丛丁丌丒万丐();
        MainMenuController.丑下上丙三丟世丒丂(丙业与丙丗丝不丈东:  true);
        Rilisoft.丝丄三业丙专丛与不.且上万专丐三业上丙(丝丏业丅丈东业丝丒:  "Training complete", 丛东不丒丏丈丄且丕:  new System.Collections.Generic.Dictionary<System.String, System.String>());
        TrainingController.与丅一丂专东丘丈世(丙业与丙丗丝不丈东:  new System.Nullable<System.Boolean>() {HasValue = false});
        new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丁丅丈丌丟世丗丗丟:  20, 丞丅上丏丂且下丅与:  "Armor_Army_1");
        PGCompany.丗丟丄丈东丝丕丄世 val_6 = PGCompany.世东三上七丂丌下丑.丑七不且上丗丁一世().丕丌丟三丝丕一三丌(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄(), 丝一三下丕且丅丟世:  new System.Nullable<PGCompany.丛丈下且丐丝不东丈>() {HasValue = true}, 业丏丈世世世丞丒世:  0);
        if(val_6 == null)
        {
                UnityEngine.Debug.LogErrorFormat(format:  "error obtaining armor in start of training", args:  System.Array.Empty<System.Object>());
        }
        
        丙丏丂丌丅丕丆三且.丑七不且上丗丁一世().丛上丑下丐丄丘丗七(下丅丙一丂丗丅丝七:  val_6);
        new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  333001);
        丙丏丂丌丅丕丆三且.丑七不且上丗丁一世().丛上丑下丐丄丘丗七(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄());
        new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  67001);
        丙丏丂丌丅丕丆三且.丑七不且上丗丁一世().丛上丑下丐丄丘丗七(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄());
        new PGCompany.三东丏不丗世丅丌丄() = new PGCompany.三东丏不丗世丅丌丄(丞世不丒下上上丝丑:  162001);
        丙丏丂丌丅丕丆三且.丑七不且上丗丁一世().丛上丑下丐丄丘丗七(丈丄不七三万丄丁不:  new PGCompany.三东丏不丗世丅丌丄());
        Progress.下丁下丂七丆丙七一.与一丅丝不丈业与丙().七丘三丟丌丏丄一万(丞万丕丏东与丑下丕:  0);
        UnityEngine.PlayerPrefs.Save();
    }
    private void BannerTrainingCompleteInvoke()
    {
        float val_16;
        float val_17;
        float val_18;
        var val_19;
        var val_20;
        var val_21;
        UnityEngine.GameObject.Find(name:  "Background_Training(Clone)").SetActive(value:  false);
        coinsShop.丌业不世上丘丙且业();
        gameObject.SetActive(value:  false);
        gameObject.SetActive(value:  false);
        丟丘且丝丟且专丌东(下下东且万业丞丅丒:  false);
        gameObject.SetActive(value:  false);
        UITexture val_6 = new UnityEngine.GameObject().AddComponent<UITexture>();
        UnityEngine.Texture val_7 = ConnectScene.丗丅专与丁丙且且丐();
        if(val_6 != null)
        {
                val_16 = 0f;
            val_17 = 1790f;
            val_18 = 0f;
            val_6.SetRect(三丟东丕丄丄下下丑:  val_16, 丒丒丄丁且丄丆丂丌:  val_18, 业与三万七丝不万东:  val_17, 丟丌丐丘丆丙丑丑一:  780f);
        }
        else
        {
                val_16 = 0f;
            val_17 = 1790f;
            val_18 = 0f;
            val_6.SetRect(三丟东丕丄丄下下丑:  val_16, 丒丒丄丁且丄丆丂丌:  val_18, 业与三万七丝不万东:  val_17, 丟丌丐丘丆丙丑丑一:  780f);
        }
        
        val_6.transform.SetParent(parent:  InGameGUI.丙丞专丌丁丞与不丐.transform.GetChild(index:  0), worldPositionStays:  false);
        UnityEngine.Vector3 val_12 = UnityEngine.Vector3.one;
        val_6.transform.localScale = new UnityEngine.Vector3() {x = val_12.x, y = val_12.y, z = val_12.z};
        UnityEngine.Vector3 val_14 = UnityEngine.Vector3.zero;
        val_6.transform.localPosition = new UnityEngine.Vector3() {x = val_14.x, y = val_14.y, z = val_14.z};
        val_19 = null;
        val_19 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayer != 0)
        {
                val_20 = null;
            val_20 = null;
            SetActive(value:  false);
        }
        
        东丙专且不丁丛一丁();
        ActivityIndicator.不丒丑丅业丞丘丐三(丙业与丙丗丝不丈东:  true);
        val_21 = null;
        val_21 = null;
        if(与丂丏丛丞丞丒丟丄.丁丑丅丏丒不七上丁 != false)
        {
                this.Invoke(methodName:  "LoadPromLevel", time:  0.4f);
            return;
        }
        
        LoadPromLevel();
    }
    private void LoadPromLevel()
    {
        Rilisoft.Singleton<Rilisoft.SceneLoader>.Instance.上丂丟丑丒上丄业丒(专万丟三世业丙丈且:  "LevelToCompleteProm");
    }
    internal static void 下一三丁丘上下丁丐()
    {
        var val_3;
        var val_4;
        var val_5;
        if(GameConnect.上丏丈七丘丁与丅丏() != false)
        {
                val_3 = null;
            val_3 = null;
            val_4 = null;
            val_4 = null;
            Rilisoft.一丟专且三万丞丁丂.万丒三丟业专丈不丁(丞与世丏丌东丞一下:  丅丌丝丘丐不丒丄专.丐下丆丌丈世三丈与, 下丛不丕七且三一丆:  丅丌丝丘丐不丒丄专.丂东丅丆上丒东丞万, 丐丞与丐世丗与下丗:  与丂丏丛丞丞丒丟丄.一丗丈丛丌专专世世, 丄上七业丒与丙三下:  false);
        }
        
        val_5 = null;
        val_5 = null;
        LevelCompleteLoader.七丐丅专且专七三丆 = 0;
        LevelCompleteLoader.专万丟三世业丙丈且 = "LevelComplete";
        UnityEngine.Color val_2 = UnityEngine.Color.white;
        AutoFade.上丅丏丑东丅丐一丈(丒丙业业丌丅丒丅丝:  "LevelToCompleteProm", 世三丏丑丙丅丌且下:  2f, 丅世丗丛万下下专丕:  0f, 一七专业丞丛世且丌:  new UnityEngine.Color() {r = val_2.r, g = val_2.g, b = val_2.b, a = val_2.a});
    }
    public GotToNextLevel()
    {
    
    }
    private static GotToNextLevel()
    {
    
    }
    private void 丐一丈不丂与丑丒世()
    {
        if(WeaponManager.丟丗丄业丘丗业丗七 == null)
        {
                null = null;
        }
        
        this.丒一丄丗丞丗丄丐丂 = WeaponManager.丟丗丄业丘丗业丗七.myPlayer;
        this.丕七三上上一丆丈世 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
    }

}
