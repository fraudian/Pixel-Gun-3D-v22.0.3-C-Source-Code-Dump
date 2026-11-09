using UnityEngine;
internal sealed class ClanTutorButtonHintLobbyV2 : PGBehaviour
{
    // Fields
    private UnityEngine.Transform tutorialHintParent;
    private UnityEngine.Transform tutorialHintPrefab;
    private UnityEngine.Coroutine 丙丗东丅丂丂丏丗丞;
    private UnityEngine.Transform 不丅丅丈下业丂丁一;
    
    // Methods
    private void Awake()
    {
        UnityEngine.Transform val_1 = UnityEngine.Object.Instantiate<UnityEngine.Transform>(original:  this.tutorialHintPrefab);
        this.不丅丅丈下业丂丁一 = val_1;
        val_1.parent = this.tutorialHintParent;
        this.不丅丅丈下业丂丁一.localPosition = new UnityEngine.Vector3() {x = 0f, y = 0f, z = 0f};
        UnityEngine.Quaternion val_2 = UnityEngine.Quaternion.identity;
        this.不丅丅丈下业丂丁一.localRotation = new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w};
        UnityEngine.Vector3 val_3 = UnityEngine.Vector3.one;
        this.不丅丅丈下业丂丁一.localScale = new UnityEngine.Vector3() {x = val_3.x, y = val_3.y, z = val_3.z};
        Rilisoft.与丄丁丄丙丞下下丙.世丙丆业世丝与丝七(万且万且丑丗且丌丆:  this.不丅丅丈下业丂丁一.gameObject, 不东丛三丂丌丑专丆:  this.tutorialHintParent.gameObject.layer);
        UIButton val_7 = this.不丅丅丈下业丂丁一.GetComponentInChildren<UIButton>(includeInactive:  true);
        EventDelegate.业丏丗丐丂业东丂丗(丝丘丑业丛万丞丌丝:  val_7.onClick, 丙不不丒丁丄丄与丛:  new EventDelegate(丞下万上三丘上与专:  this, 丑与丆丝丕东丛丄丝:  "HandleClicked"));
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.不丅丅丈下业丂丁一, 丏业丟一东丂东丘丛:  false);
    }
    public void HandleClicked()
    {
        NewLobbyUI.丑七不且上丗丁一世().LobbyButtonClicked(丟丒丞丐丐丘丒丄东:  this.tutorialHintParent.GetComponent<LobbyButton>());
    }
    private void OnEnable()
    {
        if(this.丙丗东丅丂丂丏丗丞 != null)
        {
                this.StopCoroutine(routine:  this.丙丗东丅丂丂丏丗丞);
            this.丙丗东丅丂丂丏丗丞 = 0;
        }
        
        if(与丂丅三丂且不不与.丑七不且上丗丁一世() != null)
        {
                与丂丅三丂且不不与.丑七不且上丗丁一世().丅丑丄丌丘业丌丛丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanTutorButtonHintLobbyV2::七专丌一丕丆世丟不()));
            与丂丅三丂且不不与.丑七不且上丗丁一世().丗七七丞世丆上丌丄(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanTutorButtonHintLobbyV2::七专丌一丕丆世丟不()));
            与丂丅三丂且不不与.丑七不且上丗丁一世().一与丅专不丑丂万丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanTutorButtonHintLobbyV2::丟且丂丕三万丆三专()));
            与丂丅三丂且不不与.丑七不且上丗丁一世().丞丝三丑丘专丝丙丘(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanTutorButtonHintLobbyV2::丟且丂丕三万丆三专()));
        }
        
        ClansController.七丙丟东三丈丌一丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanTutorButtonHintLobbyV2::丐丅专丗且丟丆丑七()));
        ClansController.丒世丒业丙丟丌世上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanTutorButtonHintLobbyV2::丐丅专丗且丟丆丑七()));
        this.丙丗东丅丂丂丏丗丞 = this.StartCoroutine(routine:  this.丄丈丙丁丂下且丞丅());
    }
    private void OnDisable()
    {
        if(this.丙丗东丅丂丂丏丗丞 != null)
        {
                this.StopCoroutine(routine:  this.丙丗东丅丂丂丏丗丞);
            this.丙丗东丅丂丂丏丗丞 = 0;
        }
        
        this.不与丞下业丑丒丙万();
    }
    private void OnDestroy()
    {
        this.不与丞下业丑丒丙万();
    }
    private void 不与丞下业丑丒丙万()
    {
        ClansController.七丙丟东三丈丌一丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanTutorButtonHintLobbyV2::丐丅专丗且丟丆丑七()));
        if(与丂丅三丂且不不与.丑七不且上丗丁一世() == null)
        {
                return;
        }
        
        与丂丅三丂且不不与.丑七不且上丗丁一世().丅丑丄丌丘业丌丛丙(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanTutorButtonHintLobbyV2::七专丌一丕丆世丟不()));
        与丂丅三丂且不不与.丑七不且上丗丁一世().一与丅专不丑丂万丗(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void ClanTutorButtonHintLobbyV2::丟且丂丕三万丆三专()));
    }
    private void 七专丌一丕丆世丟不()
    {
        this.丟专丂三丆丁丌丞丒();
    }
    private void 丐丅专丗且丟丆丑七()
    {
        this.丟专丂三丆丁丌丞丒();
    }
    private void 丟且丂丕三万丆三专()
    {
        var val_1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.不丅丅丈下业丂丁一, 丏业丟一东丂东丘丛:  false);
        val_1 = null;
        val_1 = null;
        ClansController.丑丏丛不丂丄上且丈 = false;
    }
    private void 丟专丂三丆丁丌丞丒()
    {
        bool val_5;
        var val_6;
        var val_7;
        val_5 = this;
        val_6 = null;
        val_6 = null;
        if(ExperienceController.sharedController == 0)
        {
                return;
        }
        
        if((丐丄丞世丂丄丛不一.世丕丕丗丗下丕丆世(丆万一不丌且东丐丐:  "feature.clans")) == false)
        {
                return;
        }
        
        val_5 = ClansTutorialController.上且世丘丝三丄丈丗() ^ 1;
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丆丐三三丏丘丈专丆:  this.不丅丅丈下业丂丁一, 丏业丟一东丂东丘丛:  val_5);
        val_7 = null;
        val_7 = null;
        ClansController.丑丏丛不丂丄上且丈 = val_5;
    }
    private System.Collections.IEnumerator 丄丈丙丁丂下且丞丅()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new ClanTutorButtonHintLobbyV2.一上丛万丆丙丛万丁();
    }
    public ClanTutorButtonHintLobbyV2()
    {
    
    }

}
