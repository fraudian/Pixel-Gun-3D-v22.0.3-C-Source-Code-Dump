using UnityEngine;
internal sealed class OpenCloseDoorTriggerByPlayers : PGBehaviour
{
    // Fields
    private System.Collections.Generic.List<Player_move_c> 丑丁丞丘丂丛丗丙不;
    private System.Collections.Generic.List<OpenCloseDoor> doors;
    private System.Collections.Generic.List<UnityEngine.AudioSource> doorsAudioSource;
    private UnityEngine.AudioClip openDoorAudioClip;
    private UnityEngine.AudioClip closeDoorAudioClip;
    private UnityEngine.AudioClip forceCloseDoorAudioClip;
    private UnityEngine.AudioClip forceOpenDoorAudioClip;
    private bool 与丌东下丙丕业三且;
    private System.Collections.Generic.List<UnityEngine.GameObject> enableWhenForceClose;
    private System.Collections.Generic.List<UnityEngine.Collider> allDoorsColliders;
    private bool 丌上不丅丆且万丒丟;
    private bool 丑丅丆且丒万丟丑丏;
    private bool 业丑丅丗丆不不丈与;
    
    // Properties
    private int 丒丌丞丗且丂世专丗 { get; }
    
    // Methods
    private int 丗丐下丙丙丙业丘专()
    {
        if(this.丑丁丞丘丂丛丗丙不 != null)
        {
                return this.丑丁丞丘丂丛丗丙不.Count;
        }
        
        return this.丑丁丞丘丂丛丗丙不.Count;
    }
    private void Start()
    {
        var val_2;
        this.丑丅丆且丒万丟丑丏 = true;
        this.丝三下丒丅丌丒丐丐();
        val_2 = null;
        val_2 = null;
        GameController.mode.丛世丝一万丒世丁七(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void OpenCloseDoorTriggerByPlayers::丘上丐世丆丑且丞丒()));
    }
    private void 丘上丐世丆丑且丞丒()
    {
        this.业丑丅丗丆不不丈与 = false;
    }
    private void Update()
    {
        this.三丞丆七东与一专且();
    }
    private void OnTriggerEnter(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        var val_11;
        if((丘丛丏丘丝七世七丅.CompareTag(tag:  "BodyCollider")) == false)
        {
                return;
        }
        
        this.一丝丏且一不丆丟丂();
        SkinName val_5 = 丘丛丏丘丝七世七丅.transform.parent.gameObject.GetComponent<SkinName>();
        if(GameConnect.丙丌丒丈东七丒上丌() == false)
        {
            goto label_10;
        }
        
        val_11 = val_5.playerMoveC.丟丌下三七丁与丟丑();
        if(val_5.playerMoveC.丟三丏丅世一丟丟上.丑丈上东丗丐丆世上() == true)
        {
            goto label_13;
        }
        
        goto label_19;
        label_10:
        val_11 = val_5.playerMoveC.丟丌下三七丁与丟丑();
        label_13:
        this.世丁东丅丏丘世丌丝();
        if((this.丑丁丞丘丂丛丗丙不.Contains(item:  val_5.playerMoveC)) != true)
        {
                this.丑丁丞丘丂丛丗丙不.Add(item:  val_5.playerMoveC);
        }
        
        if(val_11 != false)
        {
                this.丌上不丅丆且万丒丟 = true;
        }
        
        label_19:
        this.丝三下丒丅丌丒丐丐();
    }
    private void OnTriggerExit(UnityEngine.Collider 丘丛丏丘丝七世七丅)
    {
        if((丘丛丏丘丝七世七丅.CompareTag(tag:  "BodyCollider")) == false)
        {
                return;
        }
        
        SkinName val_5 = 丘丛丏丘丝七世七丅.transform.parent.gameObject.GetComponent<SkinName>();
        if(GameConnect.丙丌丒丈东七丒上丌() != false)
        {
                if(val_5.playerMoveC.丟三丏丅世一丟丟上.丑丈上东丗丐丆世上() == false)
        {
            goto label_13;
        }
        
        }
        
        bool val_8 = this.丑丁丞丘丂丛丗丙不.Remove(item:  val_5.playerMoveC);
        this.世丁东丅丏丘世丌丝();
        label_13:
        this.丝三下丒丅丌丒丐丐();
        this.一丝丏且一不丆丟丂();
    }
    private void 丝三下丒丅丌丒丐丐()
    {
        if(this.丗丐下丙丙丙业丘专() != 0)
        {
                this.业世丁丛丅三一丛世();
            return;
        }
        
        this.丂万丟丏丗丈丗丕且(丞下丌丌七专丈与丆:  false);
    }
    private void 业世丁丛丅三一丛世()
    {
        var val_3;
        if(this.丑丅丆且丒万丟丑丏 == true)
        {
                return;
        }
        
        this.丑丅丆且丒万丟丑丏 = true;
        val_3 = 0;
        goto label_2;
        label_6:
        this.doors.Item[0].StartOpenDoor();
        val_3 = 1;
        label_2:
        if(val_3 < this.doors.Count)
        {
            goto label_6;
        }
        
        if(this.与丌东下丙丕业三且 != true)
        {
                this.下丛丏七下丑丂丌丘(丆与丈丏丟七丁东丛:  this.openDoorAudioClip);
        }
        
        this.与丌东下丙丕业三且 = false;
    }
    private void 丂万丟丏丗丈丗丕且(bool 丞下丌丌七专丈与丆 = False)
    {
        var val_3;
        UnityEngine.AudioClip val_4;
        if(this.丑丅丆且丒万丟丑丏 == false)
        {
                return;
        }
        
        this.丑丅丆且丒万丟丑丏 = false;
        val_3 = 0;
        goto label_2;
        label_6:
        this.doors.Item[0].StartCloseDoor();
        val_3 = 1;
        label_2:
        if(val_3 < this.doors.Count)
        {
            goto label_6;
        }
        
        if(丞下丌丌七专丈与丆 != false)
        {
                val_4 = this.forceCloseDoorAudioClip;
            this.与丌东下丙丕业三且 = true;
        }
        else
        {
                val_4 = this.closeDoorAudioClip;
        }
        
        this.下丛丏七下丑丂丌丘(丆与丈丏丟七丁东丛:  val_4);
    }
    private void 世丈不不丗丛且丐不()
    {
        System.Collections.Generic.List<UnityEngine.AudioSource> val_8;
        var val_9;
        val_8 = this.doorsAudioSource;
        if(val_8 == null)
        {
                return;
        }
        
        val_9 = 0;
        goto label_2;
        label_15:
        if(this.doorsAudioSource.Item[0] != 0)
        {
                if(this.doorsAudioSource.Item[0].clip != 0)
        {
                this.doorsAudioSource.Item[0].Stop();
        }
        
        }
        
        val_8 = this.doorsAudioSource;
        val_9 = 1;
        label_2:
        if(val_9 < val_8.Count)
        {
            goto label_15;
        }
    
    }
    private void 下丛丏七下丑丂丌丘(UnityEngine.AudioClip 丆与丈丏丟七丁东丛)
    {
        var val_7;
        System.Collections.Generic.List<UnityEngine.AudioSource> val_8;
        this.世丈不不丗丛且丐不();
        if(丆与丈丏丟七丁东丛 == 0)
        {
                return;
        }
        
        val_8 = this.doorsAudioSource;
        if(val_8 == null)
        {
                return;
        }
        
        val_7 = 0;
        goto label_5;
        label_15:
        if(this.doorsAudioSource.Item[0] != 0)
        {
                this.doorsAudioSource.Item[0].clip = 丆与丈丏丟七丁东丛;
            this.doorsAudioSource.Item[0].Play();
        }
        
        val_8 = this.doorsAudioSource;
        val_7 = 1;
        label_5:
        if(val_7 < val_8.Count)
        {
            goto label_15;
        }
    
    }
    internal void 丏专丆丌丕丒丌丁丘()
    {
        UnityEngine.Collider val_1 = this.GetComponent<UnityEngine.Collider>();
        if(val_1 != 0)
        {
                val_1.enabled = false;
        }
        
        this.世丁东丅丏丘世丌丝();
        this.丑丅丆且丒万丟丑丏 = true;
        this.丂万丟丏丗丈丗丕且(丞下丌丌七专丈与丆:  true);
        this.东丐三一且下丙业七(丒丌且丂丛丟丙丛丏:  true);
    }
    internal void 三世三东丕下丈万丛()
    {
        UnityEngine.Collider val_1 = this.GetComponent<UnityEngine.Collider>();
        if(val_1 != 0)
        {
                val_1.enabled = true;
        }
        
        this.东丐三一且下丙业七(丒丌且丂丛丟丙丛丏:  false);
        UnityEngine.Coroutine val_4 = this.StartCoroutine(routine:  this.下丈丈下丞世世丟三());
    }
    private System.Collections.IEnumerator 下丈丈下丞世世丟三()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new OpenCloseDoorTriggerByPlayers.东与丄丒丒世丂丈东();
    }
    private void 一丝丏且一不丆丟丂()
    {
        var val_5;
        var val_6;
        if(GameConnect.丙丌丒丈东七丒上丌() == false)
        {
                return;
        }
        
        val_5 = null;
        val_5 = null;
        if(丑丈上东丗丐丆世上() == true)
        {
                return;
        }
        
        val_6 = 0;
        goto label_9;
        label_13:
        this.allDoorsColliders.Item[0].enabled = false;
        val_6 = 1;
        label_9:
        if(val_6 < this.allDoorsColliders.Count)
        {
            goto label_13;
        }
    
    }
    private void 东丐三一且下丙业七(bool 丒丌且丂丛丟丙丛丏)
    {
        goto label_1;
        label_6:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.enableWhenForceClose.Item[0], 丏业丟一东丂东丘丛:  丒丌且丂丛丟丙丛丏);
        0 = 1;
        label_1:
        if(0 < this.enableWhenForceClose.Count)
        {
            goto label_6;
        }
    
    }
    private void 三丞丆七东与一专且()
    {
        Player_move_c val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        if(this.业丑丅丗丆不不丈与 == true)
        {
                return;
        }
        
        val_5 = 1152921505286238208;
        val_6 = null;
        val_6 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七 == 0)
        {
                return;
        }
        
        val_7 = null;
        val_7 = null;
        if(WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC == 0)
        {
                return;
        }
        
        val_8 = null;
        val_8 = null;
        if(丑丈上东丗丐丆世上() != false)
        {
                return;
        }
        
        this.业丑丅丗丆不不丈与 = true;
        if(this.丌上不丅丆且万丒丟 != false)
        {
                this.丌上不丅丆且万丒丟 = false;
            val_9 = null;
            val_9 = null;
            val_5 = mem[WeaponManager.丟丗丄业丘丗业丗七 + 72];
            val_5 = WeaponManager.丟丗丄业丘丗业丗七.myPlayerMoveC;
            bool val_4 = this.丑丁丞丘丂丛丗丙不.Remove(item:  val_5);
            this.世丁东丅丏丘世丌丝();
            if(this.与丌东下丙丕业三且 != true)
        {
                this.丝三下丒丅丌丒丐丐();
        }
        
        }
        
        this.一丝丏且一不丆丟丂();
    }
    private void 世丁东丅丏丘世丌丝()
    {
        var val_4;
        System.Func<Player_move_c, System.Boolean> val_6;
        val_4 = null;
        val_4 = null;
        val_6 = OpenCloseDoorTriggerByPlayers.<>c.<>9__31_0;
        if(val_6 == null)
        {
                System.Func<Player_move_c, System.Boolean> val_1 = null;
            val_6 = val_1;
            val_1 = new System.Func<Player_move_c, System.Boolean>(object:  OpenCloseDoorTriggerByPlayers.<>c.__il2cppRuntimeField_static_fields, method:  System.Boolean OpenCloseDoorTriggerByPlayers.<>c::丐不丞不丅丑丂丂丛(Player_move_c 三丟东丕丄丄下下丑));
            OpenCloseDoorTriggerByPlayers.<>c.<>9__31_0 = val_6;
        }
        
        this.丑丁丞丘丂丛丗丙不 = System.Linq.Enumerable.ToList<Player_move_c>(source:  System.Linq.Enumerable.Where<Player_move_c>(source:  this.丑丁丞丘丂丛丗丙不, predicate:  val_1));
    }
    public OpenCloseDoorTriggerByPlayers()
    {
        this.丑丁丞丘丂丛丗丙不 = new System.Collections.Generic.List<Player_move_c>();
        this.doors = new System.Collections.Generic.List<OpenCloseDoor>();
        this.doorsAudioSource = new System.Collections.Generic.List<UnityEngine.AudioSource>();
        this.enableWhenForceClose = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.allDoorsColliders = new System.Collections.Generic.List<UnityEngine.Collider>();
    }

}
