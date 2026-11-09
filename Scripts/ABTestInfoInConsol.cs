using UnityEngine;
internal sealed class ABTestInfoInConsol : MonoBehaviour
{
    // Methods
    private void Update()
    {
        string val_16;
        var val_17;
        val_16 = "Текущие кагорты: ";
        if(与丂丏丛丞丞丒丟丄.东丏丕丁专丕万丆丑() != 0)
        {
                if(与丂丏丛丞丞丒丟丄.东丏丕丁专丕万丆丑() != 3)
        {
                val_16 = val_16 + 与丂丏丛丞丞丒丟丄.丏七三万不丘下丆丄() + " ";
        }
        
        }
        
        if(与丂丏丛丞丞丒丟丄.丆丈丛三丐不丏不丆() != 0)
        {
                if(与丂丏丛丞丞丒丟丄.丆丈丛三丐不丏不丆() != 3)
        {
                val_16 = val_16 + FriendsController.丏丏不丗丝丂万丆业() + " ";
        }
        
        }
        
        val_17 = null;
        val_17 = null;
        List.Enumerator<T> val_10 = ABTestController.丂丆丝丘丕丁东下丌.GetEnumerator();
        label_26:
        label_24:
        if(((-1804350440) & 1) == 0)
        {
            goto label_20;
        }
        
        string val_11 = 0.丐丏七丌丕丗业且上();
        if((val_11.与丄丞业不下世丄上() == 0) || (val_11.与丄丞业不下世丄上() == 3))
        {
            goto label_24;
        }
        
        string val_15 = val_16 + val_11.东丌业丕丙丕七丆丁() + " ";
        goto label_26;
        label_20:
        UnityEngine.XR.iOS.下丕丙丞丘丅丂丝丕.万三且三东东丁丁且(丙业与丙丗丝不丈东:  true);
        this.GetComponent<UILabel>().text = val_16;
    }
    public ABTestInfoInConsol()
    {
    
    }

}
