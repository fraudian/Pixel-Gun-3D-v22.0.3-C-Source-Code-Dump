using UnityEngine;
internal sealed class TutorialTapToShootCont : PGBehaviour
{
    // Fields
    private UnityEngine.GameObject aimToTheEnemyHint;
    private UnityEngine.GameObject tapToShootHint;
    
    // Methods
    private void Start()
    {
    
    }
    private void Update()
    {
        var val_3;
        var val_4;
        UnityEngine.GameObject val_5;
        var val_6;
        val_3 = null;
        val_3 = null;
        if(TrainingController.丄丞丁丈与业上丞丟 == 0)
        {
            goto label_9;
        }
        
        val_4 = null;
        val_4 = null;
        if(TrainingController.丄丞丁丈与业上丞丟.tapToShootTextAllowed == false)
        {
            goto label_9;
        }
        
        this.aimToTheEnemyHint.SetActive(value:  false);
        val_5 = this.tapToShootHint;
        val_6 = 1;
        goto label_12;
        label_9:
        this.aimToTheEnemyHint.SetActive(value:  true);
        val_5 = this.tapToShootHint;
        val_6 = 0;
        label_12:
        val_5.SetActive(value:  false);
    }
    public TutorialTapToShootCont()
    {
    
    }

}
