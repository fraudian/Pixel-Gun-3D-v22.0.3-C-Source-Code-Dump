using UnityEngine;
internal sealed class FreeplayModeRespawnManagerUI : PGBehaviour
{
    // Fields
    private FreeplayModeRespawnButtonUI respawnRandomAreaButton;
    private System.Collections.Generic.List<FreeplayModeRespawnButtonUI> respawnAreaButtons;
    private System.Collections.Generic.List<UITexture> respawnAreaTextures;
    private UnityEngine.GameObject respawnAreaObjects;
    private System.Collections.Generic.List<int> 世丛丏且万业丂丘丙;
    private int 三与丂丞丁丝丈丈丞;
    private const string 世丅三上专三三丑丕 = "FreePlaySpawnPreviews/0{0}";
    private bool isRespawnAfterDeathFreeplayPanel;
    
    // Methods
    private void Start()
    {
        if(GameConnect.丝丆世丕丂丄万东且() == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.respawnAreaObjects, 丏业丟一东丂东丘丛:  true);
        UnityEngine.Coroutine val_3 = this.StartCoroutine(routine:  this.丂专丛丆丄丛万丟三());
    }
    private void OnEnable()
    {
        if(GameConnect.丝丆世丕丂丄万东且() != false)
        {
                if(FreeplayModeSpawnController.丆丕丝丒不丙且丐丗 != 0)
        {
                FreeplayModeSpawnController.丆丕丝丒不丙且丐丗.forcePredictedSpawnPoint = false;
        }
        
        }
        
        if(this.isRespawnAfterDeathFreeplayPanel == false)
        {
                return;
        }
        
        this.Start();
    }
    private System.Collections.IEnumerator 丂专丛丆丄丛万丟三()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FreeplayModeRespawnManagerUI.丗丒万丑丌下丆丒万();
    }
    private void 万七专丛不丁丈丝丛()
    {
        int val_16;
        System.Collections.Generic.List<System.Int32> val_1 = FreeplayModeSpawnController.丆丕丝丒不丙且丐丗.世丂丛丕丌丁丟万丌();
        this.世丛丏且万业丂丘丙.Clear();
        val_16 = 0;
        goto label_3;
        label_17:
        .丝且与丝丒丟万丁专 = this;
        this.世丛丏且万业丂丘丙.Add(item:  val_1.Item[0]);
        .丞世不丒下上上丝丑 = val_16;
        this.respawnAreaButtons.Item[0].丘上丐世丆丑且丞丒(三丛丟东丑丌丄东丂:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  new FreeplayModeRespawnManagerUI.丗丛丘丑丐不丌丑丙(), 丛丌丙世专世东丕下:  System.Void FreeplayModeRespawnManagerUI.丗丛丘丑丐不丌丑丙::丅丄丙丕丄丈丒丆上())));
        int val_7 = val_1.Item[0];
        this.respawnAreaButtons.Item[0].万一且丐丝丙一丑万(业业万丆七丗不丁万:  FreeplayModeSpawnController.丆丕丝丒不丙且丐丗.丑丕与万七东丕丁丕(且丁丑丕东专丂七下:  val_7));
        丞东丑专丛丆丄丝世.丟不丏世丝丕与世丘(丞丏七丙丈丛丙世丘:  this.respawnAreaTextures.Item[0], 与万丆丛丒万丝丙丑:  UnityEngine.Resources.Load<UnityEngine.Texture>(path:  System.String.Format(format:  "FreePlaySpawnPreviews/0{0}", arg0:  val_7)));
        val_16 = 1;
        label_3:
        if(val_16 < this.respawnAreaButtons.Count)
        {
            goto label_17;
        }
        
        this.respawnRandomAreaButton.丘上丐世丆丑且丞丒(三丛丟东丑丌丄东丂:  new EventDelegate(丟丕丞丂一丙不丅丝:  new EventDelegate.丒万业丛丏东专世丟(三一丄丗专丌丛丘丅:  this, 丛丌丙世专世东丕下:  System.Void FreeplayModeRespawnManagerUI::丟丆七丗丄七万丙三())));
    }
    public void TapOnAreaButton(int 丞世不丒下上上丝丑)
    {
        int val_4;
        var val_5;
        val_4 = 丞世不丒下上上丝丑;
        if(val_4 != 1)
        {
                val_4 = this.世丛丏且万业丂丘丙.Item[val_4];
        }
        
        FreeplayModeSpawnController.丆丕丝丒不丙且丐丗.丟万业下丛丁东业一 = val_4;
        if(this.isRespawnAfterDeathFreeplayPanel != false)
        {
                RespawnWindow val_2 = RespawnWindow.丑七不且上丗丁一世();
            val_2.丅丗丌丅丐三丞丑万 = true;
            RespawnWindow.丑七不且上丗丁一世().OnBtnGoBattleClick();
            return;
        }
        
        val_5 = null;
        val_5 = null;
        不丅丗丂与丌与丐丒(与丁丟东丞丙丗丌丈:  0);
    }
    public FreeplayModeRespawnManagerUI()
    {
        this.世丛丏且万业丂丘丙 = new System.Collections.Generic.List<System.Int32>();
        this.三与丂丞丁丝丈丈丞 = 9;
    }
    private void 丟丆七丗丄七万丙三()
    {
        this.TapOnAreaButton(丞世不丒下上上丝丑:  0);
    }

}
