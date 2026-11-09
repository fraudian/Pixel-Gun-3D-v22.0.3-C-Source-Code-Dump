using UnityEngine;
public class EggIncubatorManager : MonoBehaviour
{
    // Fields
    private const int 上丅下丛丘上丙丌三 = 4;
    private static EggIncubatorManager 丏丐丛丏丘东丛且丕;
    private System.Collections.Generic.List<EggIncubatorController> eggIncuatorList;
    private EggIncubatorController eggIncubator;
    public UITable eggIncubatorGrid;
    
    // Properties
    internal static EggIncubatorManager 丌丛丟丁丏丌且丛且 { get; }
    
    // Methods
    internal static EggIncubatorManager 且丕丈丙丛不业丂丗()
    {
        null = null;
        return (EggIncubatorManager)EggIncubatorManager.丏丐丛丏丘东丛且丕;
    }
    private void Awake()
    {
        null = null;
        EggIncubatorManager.丏丐丛丏丘东丛且丕 = this;
    }
    public void SetupIncubators()
    {
        System.Collections.Generic.List<EggIncubatorController> val_2 = new System.Collections.Generic.List<EggIncubatorController>(collection:  this.eggIncubatorGrid.GetComponentsInChildren<EggIncubatorController>());
        if(val_2 == null)
        {
                return;
        }
        
        int val_3 = val_2.Count;
    }
    private void 丁业不丄专丅丘不丗()
    {
    
    }
    private void 东丙与丟丂丅丂丏一()
    {
        UnityEngine.Coroutine val_2 = this.StartCoroutine(routine:  this.下业与丁丄丁丕丙下());
    }
    private System.Collections.IEnumerator 下业与丁丄丁丕丙下()
    {
        .丗丏丅丕丆世丁专丟 = 0;
        .丝且与丝丒丟万丁专 = this;
        return (System.Collections.IEnumerator)new EggIncubatorManager.丝丄下与与丁丐丝丒();
    }
    public void SetIncubatorActive()
    {
    
    }
    public void UpdateEggs()
    {
    
    }
    public EggIncubatorManager()
    {
    
    }
    private static EggIncubatorManager()
    {
    
    }

}
