using UnityEngine;
public class ScoreTableLabel : MonoBehaviour
{
    // Methods
    private void Start()
    {
        var val_6;
        string val_7;
        if(GameConnect.丙丘不世专且万丄丐() != false)
        {
                val_6 = this.GetComponent<UILabel>();
            val_7 = "Key_0190";
        }
        else
        {
                val_6 = this.GetComponent<UILabel>();
            if(GameConnect.丘丐丅丌上与丒丞万() != false)
        {
                val_7 = "Key_1006";
        }
        else
        {
                val_7 = "Key_0191";
        }
        
        }
        
        val_6.text = 丟丏下丂七三下丗丕.丐下下丅与上东丙丑(丝丐丟三业丟丏万且:  val_7);
    }
    private void Update()
    {
    
    }
    public ScoreTableLabel()
    {
    
    }

}
