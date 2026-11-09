using UnityEngine;
public sealed class LastBulletsUI : PGBehaviour
{
    // Fields
    private WidgetLayout positionHolder;
    private System.Collections.Generic.List<UnityEngine.GameObject> bullets;
    private System.Collections.Generic.List<UnityEngine.GameObject> bulletsEnable;
    
    // Methods
    internal void 丒业丐丛与丌丈专与(int 东丛万丛丘丒一万丞, int 丟丈丞丝丙丞不丂专)
    {
        int val_12;
        int val_13;
        var val_14;
        System.Collections.Generic.List<UnityEngine.GameObject> val_15;
        val_12 = 丟丈丞丝丙丞不丂专;
        val_13 = 东丛万丛丘丒一万丞;
        if((val_12 - 2) >= 4)
        {
            goto label_1;
        }
        
        if(val_13 == 0)
        {
            goto label_2;
        }
        
        var val_3 = (this.bullets.Count >= val_13) ? 1 : 0;
        goto label_4;
        label_1:
        this.丆世与丑丆丅丐万且();
        return;
        label_2:
        val_14 = 0;
        label_4:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.positionHolder, 丏业丟一东丂东丘丛:  false);
        int val_5 = UnityEngine.Mathf.Min(a:  this.bullets.Count, b:  val_13);
        var val_12 = 0;
        do
        {
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bullets.Item[0], 丏业丟一东丂东丘丛:  true);
            val_12 = val_12 + 1;
        }
        while(val_12 != val_12);
        
        goto label_14;
        label_19:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bullets.Item[val_12], 丏业丟一东丂东丘丛:  false);
        val_12 = val_12 + 1;
        label_14:
        val_15 = this.bullets;
        if(val_12 < val_15.Count)
        {
            goto label_19;
        }
        
        if(val_5 < 1)
        {
            goto label_25;
        }
        
        var val_13 = 0;
        do
        {
            val_15 = this.bulletsEnable.Item[0];
            丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  val_15, 丏业丟一东丂东丘丛:  true);
            val_13 = val_13 + 1;
        }
        while(val_5 != val_13);
        
        goto label_25;
        label_30:
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(丝三丁东丈丒世丅业:  this.bulletsEnable.Item[val_13], 丏业丟一东丂东丘丛:  false);
        val_13 = val_13 + 1;
        label_25:
        if(val_13 < this.bulletsEnable.Count)
        {
            goto label_30;
        }
        
        this.positionHolder.Reposition();
    }
    internal void 丆世与丑丆丅丐万且()
    {
        丞东丑专丛丆丄丝世.丙上丂专丈丏丑专上(不丗上三丛丒上东丑:  this.positionHolder, 丏业丟一东丂东丘丛:  false);
    }
    public LastBulletsUI()
    {
        this.bullets = new System.Collections.Generic.List<UnityEngine.GameObject>();
        this.bulletsEnable = new System.Collections.Generic.List<UnityEngine.GameObject>();
    }

}
