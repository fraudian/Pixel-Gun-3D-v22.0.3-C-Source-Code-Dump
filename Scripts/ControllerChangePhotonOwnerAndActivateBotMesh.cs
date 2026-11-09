using UnityEngine;
internal class ControllerChangePhotonOwnerAndActivateBotMesh : VTableHolder
{
    // Fields
    internal float 丑丟世万丁且一丅丆;
    private System.Collections.Generic.List<RilisoftBot.BotAiController> 丒丟下业东与东下丁;
    private System.Collections.Generic.List<FlasksDungeonObject> 三丆丅丛专丒丂专丆;
    private System.Collections.Generic.List<SpawnMobBaseDungeon> 丗七且丂丕丞专与上;
    private System.Collections.Generic.List<AltarePoint> 丏七丈丛丑丐一丅丛;
    private System.Collections.Generic.HashSet<RilisoftBot.BotAiController> 丙不丁东丏丐东三万;
    private System.Collections.Generic.HashSet<RilisoftBot.BotAiController> 东丒七丘丝丁丛三世;
    private PhotonView 丅丏三七丁丑丞丄丏;
    
    // Properties
    internal System.Collections.Generic.List<RilisoftBot.BotAiController> 世丏丞七专丄三丛丅 { get; }
    private PhotonView 丌丛三上七丘业丕世 { get; }
    internal int 丈丄东丌丘丘丛丆丟 { get; }
    
    // Methods
    internal System.Collections.Generic.List<RilisoftBot.BotAiController> 不丏不丝丙丏丆七一()
    {
        return (System.Collections.Generic.List<RilisoftBot.BotAiController>)this.丒丟下业东与东下丁;
    }
    private PhotonView 专丐不且且丒与丘万()
    {
        PhotonView val_4;
        if(this.丅丏三七丁丑丞丄丏 == 0)
        {
                this.丅丏三七丁丑丞丄丏 = this.gameObject.AddComponent<PhotonView>();
            return val_4;
        }
        
        val_4 = this.丅丏三七丁丑丞丄丏;
        return val_4;
    }
    internal int 且丅丐世专丒业丄一()
    {
        int val_3 = this.丗七且丂丕丞专与上.Count;
        val_3 = (this.三丆丅丛专丒丂专丆.Count + this.丒丟下业东与东下丁.Count) + val_3;
        return (int)val_3;
    }
    internal ControllerChangePhotonOwnerAndActivateBotMesh()
    {
        this.丑丟世万丁且一丅丆 = 60f;
        this.丒丟下业东与东下丁 = new System.Collections.Generic.List<RilisoftBot.BotAiController>();
        this.三丆丅丛专丒丂专丆 = new System.Collections.Generic.List<FlasksDungeonObject>();
        this.丗七且丂丕丞专与上 = new System.Collections.Generic.List<SpawnMobBaseDungeon>();
        this.丏七丈丛丑丐一丅丛 = new System.Collections.Generic.List<AltarePoint>();
        this.丙不丁东丏丐东三万 = new System.Collections.Generic.HashSet<RilisoftBot.BotAiController>();
        this.东丒七丘丝丁丛三世 = new System.Collections.Generic.HashSet<RilisoftBot.BotAiController>();
        Rilisoft.且三与世丁丏丂丌下 val_7 = this.与丑丌丌丌丁丌不丕();
        val_7.专不丐一丈丌丛丁丕 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void ControllerChangePhotonOwnerAndActivateBotMesh::OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
        Rilisoft.且三与世丁丏丂丌下 val_9 = this.与丑丌丌丌丁丌不丕();
        val_9.丈万丄与丈三丏丙丂 = new System.Action<与丅丕丈丘东丝世丟>(object:  this, method:  System.Void ControllerChangePhotonOwnerAndActivateBotMesh::OnDisconnectedFromPhoton(与丅丕丈丘东丝世丟 专丞上七七且丝七丗));
    }
    private void OnPhotonPlayerConnected(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
    
    }
    private void OnDisconnectedFromPhoton(与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
    
    }
    private void Awake()
    {
        PhotonObjectCacher.且上丛丂三丛且丟下(万且万且丑丗且丌丆:  this);
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丁不丟东丁丈丄业丐());
    }
    private void OnDestroy()
    {
        PhotonObjectCacher.下丘三丛丞且三丛万(万且万且丑丗且丌丆:  this);
    }
    internal void 不丅上丆万上丘丙东(System.Collections.Generic.List<RilisoftBot.BotAiController> 丞世不丗三丒丏丒专)
    {
        this.丒丟下业东与东下丁.AddRange(collection:  丞世不丗三丒丏丒专);
    }
    internal void 不丅上丆万上丘丙东(RilisoftBot.BotAiController 丛世丕丘七东下丌丄)
    {
        this.丒丟下业东与东下丁.Add(item:  丛世丕丘七东下丌丄);
    }
    internal void 丈丛且丗下万与丒丟(FlasksDungeonObject 丄七丌下不丐且丐丏)
    {
        this.三丆丅丛专丒丂专丆.Add(item:  丄七丌下不丐且丐丏);
    }
    internal void 丗三上七丂三业世丈(SpawnMobBaseDungeon 下世丈丗丟业丙与丒)
    {
        this.丗七且丂丕丞专与上.Add(item:  下世丈丗丟业丙与丒);
    }
    internal void 世丒三丙丌世专与业(AltarePoint 丏丄丝丞上丒丏丄下)
    {
        this.丏七丈丛丑丐一丅丛.Add(item:  丏丄丝丞上丒丏丄下);
    }
    private System.Collections.IEnumerator 丁不丟东丁丈丄业丐()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ControllerChangePhotonOwnerAndActivateBotMesh.丑丞下丅丞三三丄丁();
    }
    internal void 不丕丐丏业上丆丄上(int 丆三丅丆下上丑丞丅, 与丅丕丈丘东丝世丟 专丞上七七且丝七丗)
    {
        与丅丕丈丘东丝世丟 val_7;
        int val_8;
        object val_9;
        val_7 = 专丞上七七且丝七丗;
        val_8 = 丆三丅丆下上丑丞丅;
        if((val_8 - 1) > 2)
        {
                return;
        }
        
        List.Enumerator<T> val_2 = this.丒丟下业东与东下丁.GetEnumerator();
        val_9 = 0;
        val_8 = 0;
        goto label_8;
        label_9:
        string val_3 = 0.丐丏七丌丕丗业且上();
        if(val_3 != 0)
        {
                val_8 = 1;
            val_3.丘丝丌丌丟丄丁丒七(专丞上七七且丝七丗:  val_7);
            val_9 = 1;
        }
        
        label_8:
        if((1050737976 & 1) != 0)
        {
            goto label_9;
        }
        
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        val_7 = System.String.Format(format:  "Mob Distribution: Transfered owner from {0} group: {1} mobs (sum {2})", arg0:  val_8.ToString(), arg1:  val_9, arg2:  val_8);
        UnityEngine.Debug.Log(message:  val_7);
    }

}
