using UnityEngine;
public class PlusMinusController : MonoBehaviour
{
    // Fields
    public int stepValue;
    internal Rilisoft.丝丑丂丛万丐丈丘且 东丏丕丗丕丞丁三丌;
    internal Rilisoft.丝丑丂丛万丐丈丘且 世万丈与丑专丝一丞;
    internal Rilisoft.丝丑丂丛万丐丈丘且 丙业与丙丗丝不丈东;
    public UnityEngine.GameObject plusButton;
    public UnityEngine.GameObject minusButton;
    public UILabel countLabel;
    public UILabel headLabel;
    
    // Methods
    private void Awake()
    {
    
    }
    private void Start()
    {
        if(this.plusButton != 0)
        {
                Rilisoft.ButtonHandler val_2 = this.plusButton.GetComponent<Rilisoft.ButtonHandler>();
            if(val_2 != 0)
        {
                val_2.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PlusMinusController::下丗丏丐三七丕丗三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
        }
        
        }
        
        if(this.minusButton == 0)
        {
                return;
        }
        
        Rilisoft.ButtonHandler val_6 = this.minusButton.GetComponent<Rilisoft.ButtonHandler>();
        if(val_6 == 0)
        {
                return;
        }
        
        val_6.add_Clicked(丙业与丙丗丝不丈东:  new System.EventHandler(object:  this, method:  System.Void PlusMinusController::一丗丛丐丄与三丙不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)));
    }
    private void 下丗丏丐三七丕丗三(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_7 = this.丙业与丙丗丝不丈东;
        int val_1 = this.stepValue + val_7;
        if(val_7 <= this.世万丈与丑专丝一丞)
        {
                return;
        }
        
        val_7 = ???;
    }
    private void 一丗丛丐丄与三丙不(object 不丟丗丏丛丕不丁丌, System.EventArgs 丗丛不丁丑专专丂且)
    {
        Rilisoft.丝丑丂丛万丐丈丘且 val_7 = this.丙业与丙丗丝不丈东;
        Rilisoft.丝丑丂丛万丐丈丘且 val_1 = val_7 - this.stepValue;
        if(val_7 >= this.东丏丕丗丕丞丁三丌)
        {
                return;
        }
        
        val_7 = ???;
    }
    private void Update()
    {
        if(this.countLabel == 0)
        {
                return;
        }
        
        this = this.丙业与丙丗丝不丈东.ToString();
        this.countLabel.text = this;
    }
    public PlusMinusController()
    {
        this.stepValue = 1;
    }

}
