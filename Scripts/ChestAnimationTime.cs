using UnityEngine;
internal class ChestAnimationTime : MonoBehaviour
{
    // Fields
    private UnityEngine.Animation 业与丘丞丂专丘丗世;
    private double 丆上七丟不丟丆不专;
    
    // Methods
    private void Awake()
    {
        var val_8;
        var val_9;
        this.业与丘丞丂专丘丗世 = this.GetComponent<UnityEngine.Animation>();
        if(GameConnect.丟丆丏上丌一丝丟业() != false)
        {
                val_8 = 0;
            int val_3 = GameConnect.丈专且丗上丂丗丝丑();
        }
        else
        {
                if(GameConnect.丙丘不世专且万丄丐() != false)
        {
                val_8 = 240;
        }
        else
        {
                val_9 = null;
            val_9 = null;
            object val_7 = 丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且().丑丗三丛丛丆丟丌丆().Item[GameConnect.丟下丗丙丕丁丞丞丛];
            val_8 = -4611686017114292224;
        }
        
        }
        
        this.丆上七丟不丟丆不专 = -4.61168601842739E+18;
    }
    private void Update()
    {
        if(TimeGameController.丄丞丁丈与业上丞丟 == 0)
        {
                return;
        }
        
        if(TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 < 0f)
        {
                return;
        }
        
        double val_2 = TimeGameController.丄丞丁丈与业上丞丟.丁专不且丈丂丄且丞 / this.丆上七丟不丟丆不专;
        double val_10 = 1;
        val_2 = val_10 - val_2;
        float val_3 = System.Convert.ToSingle(value:  val_2);
        if(丅丒丗丑丒丙丛不丆.丄丐世丞东不丟丒且() == null)
        {
                return;
        }
        
        if(丅丒丗丑丒丙丛不丆.下丁丅丛丌东丟丆丄() == 0f)
        {
                return;
        }
        
        val_10 = this.业与丘丞丂专丘丗世.Item["Checkmate_effects"].normalizedTime - val_3;
        if(System.Math.Abs(val_10) <= 0.0005f)
        {
                return;
        }
        
        this.业与丘丞丂专丘丗世.Item["Checkmate_effects"].normalizedTime = val_3;
        bool val_9 = this.业与丘丞丂专丘丗世.Play();
    }
    public ChestAnimationTime()
    {
    
    }

}
