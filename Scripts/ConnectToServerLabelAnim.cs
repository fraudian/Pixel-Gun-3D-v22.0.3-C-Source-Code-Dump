using UnityEngine;
public class ConnectToServerLabelAnim : MonoBehaviour
{
    // Fields
    public UILabel myLabel;
    public string startText;
    private int 丑丁丑丄一与世丅丛;
    private float 丙一丑丏丁一且丒业;
    private float 丞丁丘下丗丙丗七丆;
    
    // Methods
    private void Start()
    {
        this.丙一丑丏丁一且丒业 = this.丞丁丘下丗丙丗七丆;
    }
    private void OnEnable()
    {
        string val_1 = 丟丏下丂七三下丗丕.丒上世一丏丂丂上上();
        this.startText = val_1;
        this.myLabel.text = val_1;
    }
    private void Update()
    {
        string val_6;
        float val_1 = UnityEngine.Time.deltaTime;
        val_1 = this.丙一丑丏丁一且丒业 - val_1;
        this.丙一丑丏丁一且丒业 = val_1;
        if(val_1 >= 0)
        {
                return;
        }
        
        this.丙一丑丏丁一且丒业 = this.丞丁丘下丗丙丗七丆;
        int val_3 = ((this.丑丁丑丄一与世丅丛 + 1) >= 4) ? 0 : (this.丑丁丑丄一与世丅丛 + 1);
        this.丑丁丑丄一与世丅丛 = val_3;
        val_6 = "";
        if(val_3 >= 1)
        {
                var val_6 = 0;
            do
        {
            val_6 = val_6 + 1;
            val_6 = val_6 + ".";
        }
        while(val_6 < this.丑丁丑丄一与世丅丛);
        
        }
        
        this.myLabel.text = System.String.Format(format:  "{0} {1}", arg0:  this.startText, arg1:  val_6);
    }
    public ConnectToServerLabelAnim()
    {
        this.丞丁丘下丗丙丗七丆 = 1f;
    }

}
