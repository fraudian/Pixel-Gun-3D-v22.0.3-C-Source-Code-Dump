using UnityEngine;
internal sealed class InGameGUIPart_PlantTheBomb : InGameGUIPartContainer
{
    // Fields
    private PlantingButton plantButton;
    private PlantingButton defuseButton;
    private UnityEngine.Color colBlue;
    private UnityEngine.Color colRed;
    private UnityEngine.Color colOrange;
    private UnityEngine.Color colWhite;
    public PlantTheBombScoresPanel scoresPanel;
    public PlantTheBombNotificationsSystem notificationsSystem;
    private UnityEngine.GameObject goalsContainer;
    private UnityEngine.GameObject goalIconBomb;
    private UnityEngine.GameObject goalIconCutters;
    public UnityEngine.GameObject enableOnSuccessfulCompletion;
    public bool needShowBombTween;
    private float 七丑与业东万丆上丞;
    
    // Methods
    private void Awake()
    {
        System.EventHandler val_14;
        InGameGUI.丙丞专丌丁丞与不丐.丕丏丕丟丗丝丂业丏 = this;
        if(this.plantButton != 0)
        {
                Rilisoft.ButtonHandler val_2 = this.plantButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_2 != 0)
        {
                System.EventHandler val_4 = null;
            val_14 = val_4;
            val_4 = new System.EventHandler(object:  this, method:  System.Void InGameGUIPart_PlantTheBomb::丐与与丝丛丕丄东专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_2.add_Clicked(丙业与丙丗丝不丈东:  val_4);
        }
        
            if(this.plantButton.transform.parent != 0)
        {
                丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.plantButton.transform.parent, 丏业丟一东丂东丘丛:  true);
        }
        
        }
        
        this.丗丐业万与丝丒三且(丙业与丙丗丝不丈东:  false, 不专丑一下且不万七:  false);
        if(this.defuseButton != 0)
        {
                Rilisoft.ButtonHandler val_11 = this.defuseButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_11 != 0)
        {
                System.EventHandler val_13 = null;
            val_14 = val_13;
            val_13 = new System.EventHandler(object:  this, method:  System.Void InGameGUIPart_PlantTheBomb::世丒上丘丏七七丅丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且));
            val_11.add_Clicked(丙业与丙丗丝不丈东:  val_13);
        }
        
        }
        
        this.丑下丌丆与丒丕丄丞(丙业与丙丗丝不丈东:  false);
    }
    private void 世丒上丘丏七七丅丂(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(GameConnect.丒丗丁丙丗丄丙不丐() == false)
        {
                return;
        }
        
        PlantTheBombController.丆丕丝丒不丙且丐丗.七丑与业丞业丂丘不();
    }
    private void 丐与与丝丛丕丄东专(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        if(GameConnect.丒丗丁丙丗丄丙不丐() == false)
        {
                return;
        }
        
        PlantTheBombController.丆丕丝丒不丙且丐丗.丛东与丘丆不丏丌专();
    }
    internal void 一且与丌且上下下七()
    {
        this.enableOnSuccessfulCompletion.gameObject.SetActive(value:  true);
        this.enableOnSuccessfulCompletion.gameObject.GetComponentInChildren<SimpleTweenePlayer>().Play();
    }
    internal void 丒丝丂业丙一丟丄万(PlantingZone 业丂万丈丝七一与专)
    {
        if(this.plantButton == 0)
        {
                return;
        }
        
        if(业丂万丈丝七一与专.上三丙专丁丂丞三与() != false)
        {
                this.plantButton.丕丕业七丙七丅丈丄(丂丟世与丁下业不专:  true, 上丕丈丞丌丘丅不与:  业丂万丈丝七一与专.专丙丅丏丆丂且三业());
            if(业丂万丈丝七一与专.专丙丅丏丆丂且三业() <= 0.97f)
        {
                return;
        }
        
            this.needShowBombTween = true;
            return;
        }
        
        this.plantButton.丕丕业七丙七丅丈丄(丂丟世与丁下业不专:  false, 上丕丈丞丌丘丅不与:  0f);
    }
    internal void 丕丆不丁与专丙上丝(PlantedBomb 业丝丝丛丕丅丈丘不)
    {
        var val_4;
        if(this.defuseButton == 0)
        {
                return;
        }
        
        if(业丝丝丛丕丅丈丘不.丅业丑丗下丑丘丌丗() != false)
        {
                float val_3 = 业丝丝丛丕丅丈丘不.业不丈三不丈丏丞丘();
            val_4 = 1;
        }
        else
        {
                val_4 = 0;
        }
        
        this.defuseButton.丕丕业七丙七丅丈丄(丂丟世与丁下业不专:  false, 上丕丈丞丌丘丅不与:  0f);
    }
    private void Update()
    {
        if(this.七丑与业东万丆上丞 > 0f)
        {
                if(UnityEngine.Time.time > this.七丑与业东万丆上丞)
        {
                this.七丑与业东万丆上丞 = -1f;
            this.plantButton.gameObject.SetActive(value:  false);
        }
        
        }
        
        if(this.plantButton.gameObject.activeSelf == true)
        {
                return;
        }
        
        this.七丑与业东万丆上丞 = -1f;
    }
    internal void 不丌不且与专丆丂世()
    {
        if(this.plantButton == 0)
        {
                return;
        }
        
        this.plantButton.丈下且东丅丝上丝不();
    }
    internal void 且丞丘与丕丌七丑丝()
    {
        if(this.defuseButton == 0)
        {
                return;
        }
        
        this.defuseButton.丈下且东丅丝上丝不();
    }
    internal void 丗丐业万与丝丒三且(bool 丙业与丙丗丝不丈东, bool 不专丑一下且不万七 = False)
    {
        bool val_5 = 不专丑一下且不万七;
        if(this.plantButton == 0)
        {
                return;
        }
        
        if(val_5 == false)
        {
            goto label_4;
        }
        
        if(丙业与丙丗丝不丈东 == false)
        {
            goto label_5;
        }
        
        this.plantButton.gameObject.SetActive(value:  true);
        goto label_8;
        label_4:
        val_5 = this.plantButton;
        val_5.丛丌丞下业业丞丗丂(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
        label_8:
        this.七丑与业东万丆上丞 = -1f;
        return;
        label_5:
        if(this.七丑与业东万丆上丞 >= 0)
        {
                return;
        }
        
        float val_4 = UnityEngine.Time.time;
        val_4 = val_4 + 0.2f;
        this.七丑与业东万丆上丞 = val_4;
    }
    internal void 丑下丌丆与丒丕丄丞(bool 丙业与丙丗丝不丈东)
    {
        if(this.defuseButton == 0)
        {
                return;
        }
        
        this.defuseButton.丛丌丞下业业丞丗丂(丙业与丙丗丝不丈东:  丙业与丙丗丝不丈东);
    }
    internal void 下丅丛丝万丂与丞七(bool 丛与丙丒丒下丌丟且, bool 业丝丝丛丕丅丈丘不 = True)
    {
        var val_8;
        var val_9;
        var val_10;
        var val_11;
        bool val_12;
        var val_13;
        val_8 = null;
        val_8 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
            goto label_11;
        }
        
        val_9 = null;
        val_9 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
            goto label_11;
        }
        
        val_10 = null;
        val_10 = null;
        val_11 = 丏下丙丞丕丕丏丕丞() ^ 1;
        goto label_16;
        label_11:
        val_11 = 1;
        label_16:
        val_12 = 0;
        if(((val_11 & 1) != 0) && (丛与丙丒丒下丌丟且 != false))
        {
                val_13 = null;
            val_13 = null;
            val_12 = (~Pauser.且三丝三七七丐丁丁.丟三东与三丒丛下东()) & 1;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goalsContainer, 丏业丟一东丂东丘丛:  val_12);
        if(丛与丙丒丒下丌丟且 == false)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goalIconBomb, 丏业丟一东丂东丘丛:  业丝丝丛丕丅丈丘不);
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.goalIconCutters, 丏业丟一东丂东丘丛:  (~业丝丝丛丕丅丈丘不) & 1);
    }
    public InGameGUIPart_PlantTheBomb()
    {
        this.七丑与业东万丆上丞 = -1f;
    }

}
