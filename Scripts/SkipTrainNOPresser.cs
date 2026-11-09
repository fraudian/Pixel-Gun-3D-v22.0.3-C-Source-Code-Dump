using UnityEngine;
public sealed class SkipTrainNOPresser : SkipTrainingButton
{
    // Fields
    public UnityEngine.GameObject skipButton;
    
    // Methods
    protected override void OnClick()
    {
        UnityEngine.Object val_13;
        this.gameObject.transform.parent.gameObject.SetActive(value:  false);
        this.skipButton.SetActive(value:  true);
        this.skipButton.OnClick();
        val_13 = UnityEngine.GameObject.FindGameObjectWithTag(tag:  "PlayerGun");
        if(((UnityEngine.Object.op_Implicit(exists:  val_13)) != false) && (val_13 != 0))
        {
                val_13 = val_13.transform.GetChild(index:  0);
            if((UnityEngine.Object.op_Implicit(exists:  val_13)) != false)
        {
                if(val_13 != 0)
        {
                val_13 = val_13.gameObject;
            val_13.SetActive(value:  true);
        }
        
        }
        
        }
        
        TrainingController.丗丙下丑丐不一世丝();
    }
    public SkipTrainNOPresser()
    {
        val_1 = new UnityEngine.MonoBehaviour();
    }

}
