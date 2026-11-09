using UnityEngine;
public class FifthEggInLobbyController : MonoBehaviour
{
    // Fields
    private UnityEngine.Renderer _eggRenderer;
    private UnityEngine.GameObject egg;
    private TextMeshBounds eggTimer;
    private UnityEngine.GameObject empyIncubators;
    private UnityEngine.GameObject header;
    private TextMeshBounds lockLevelText;
    private UnityEngine.GameObject readyLabel;
    private UnityEngine.GameObject readyLapka;
    private UnityEngine.GameObject readyParticles;
    private static FifthEggInLobbyController <不丁丄七丛不丆丁丕>k__BackingField;
    
    // Properties
    internal static FifthEggInLobbyController 丆丕丝丒不丙且丐丗 { get; set; }
    
    // Methods
    internal static FifthEggInLobbyController 丑七不且上丗丁一世()
    {
        return (FifthEggInLobbyController)FifthEggInLobbyController.<不丁丄七丛不丆丁丕>k__BackingField;
    }
    private static void 丒且丒丗丗丟下丗丝(FifthEggInLobbyController 丙业与丙丗丝不丈东)
    {
        FifthEggInLobbyController.<不丁丄七丛不丆丁丕>k__BackingField = 丙业与丙丗丝不丈东;
    }
    private void OnEnable()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.丆万丏丝丐东与丞丈());
        this.丕丕业七丙七丅丈丄(丏业丟一东丂东丘丛:  0);
        Rilisoft.LobbyCraftController.东三世丟世业不丏上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FifthEggInLobbyController::下一万丝丏东业丈丛()));
        Rilisoft.LobbyCraftController.丈丈东三丙且丟丗下(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FifthEggInLobbyController::下一万丝丏东业丈丛()));
        FriendProfileView.世不丟丌丕丞丝丗丅(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void FifthEggInLobbyController::不丒丅与上丁丑东专(bool 万且万且丑丗且丌丆)));
        FriendProfileView.下不丅丈丑丝丁丅丗(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void FifthEggInLobbyController::不丒丅与上丁丑东专(bool 万且万且丑丗且丌丆)));
    }
    private void OnDisable()
    {
        this.StopCoroutine(routine:  this.丆万丏丝丐东与丞丈());
        Rilisoft.LobbyCraftController.东三世丟世业不丏上(丙业与丙丗丝不丈东:  new System.Action(object:  this, method:  System.Void FifthEggInLobbyController::下一万丝丏东业丈丛()));
        FriendProfileView.世不丟丌丕丞丝丗丅(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void FifthEggInLobbyController::不丒丅与上丁丑东专(bool 万且万且丑丗且丌丆)));
    }
    private void 下一万丝丏东业丈丛()
    {
    
    }
    private void 不丒丅与上丁丑东专(bool 万且万且丑丗且丌丆)
    {
    
    }
    private void 丕丕业七丙七丅丈丄(FifthEggInLobbyController.丁丘丅丝丑东万且且 丏业丟一东丂东丘丛)
    {
        if(丏业丟一东丂东丘丛 > 5)
        {
                return;
        }
        
        var val_60 = 106019724 + (丏业丟一东丂东丘丛) << 2;
        val_60 = val_60 + 106019724;
        goto (106019724 + (丏业丟一东丂东丘丛) << 2 + 106019724);
    }
    private System.Collections.IEnumerator 丆万丏丝丐东与丞丈()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new FifthEggInLobbyController.与东东丁丆且丂丕专();
    }
    private void 丌不丐丅丌丛丛丄丌()
    {
    
    }
    private void Awake()
    {
        FifthEggInLobbyController.<不丁丄七丛不丆丁丕>k__BackingField = this;
        Rilisoft.LobbyCraftController.丁丞丐丟丘丏丟与丂(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void FifthEggInLobbyController::一丁专与一世丈丐丐(bool 丄丟丞丈丁与丐丈丛)));
        Rilisoft.LobbyCraftController.上丙丛丅丁与专下一(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void FifthEggInLobbyController::一丁专与一世丈丐丐(bool 丄丟丞丈丁与丐丈丛)));
    }
    private void OnDestroy()
    {
        FifthEggInLobbyController.<不丁丄七丛不丆丁丕>k__BackingField = 0;
        Rilisoft.LobbyCraftController.丁丞丐丟丘丏丟与丂(丙业与丙丗丝不丈东:  new System.Action<System.Boolean>(object:  this, method:  System.Void FifthEggInLobbyController::一丁专与一世丈丐丐(bool 丄丟丞丈丁与丐丈丛)));
    }
    private void 一丁专与一世丈丐丐(bool 丄丟丞丈丁与丐丈丛)
    {
        if(this.gameObject == 0)
        {
                return;
        }
        
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.gameObject, 丏业丟一东丂东丘丛:  (~丄丟丞丈丁与丐丈丛) & 1);
    }
    public FifthEggInLobbyController()
    {
    
    }

}
