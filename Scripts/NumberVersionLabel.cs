using UnityEngine;
public class NumberVersionLabel : MonoBehaviour
{
    // Methods
    private void Start()
    {
        UILabel val_1 = this.GetComponent<UILabel>();
        if(val_1 == 0)
        {
                return;
        }
        
        System.Version val_4 = this.GetType().Version;
        object[] val_5 = new object[4];
        val_5[0] = val_4.Major;
        val_5[1] = val_4.Minor;
        val_5[2] = val_4.Build;
        val_5[3] = NumberVersionLabel.丙丄丄上上丆丐丘丄();
        val_1.text = System.String.Format(format:  "{0}.{1}.{2}.{3}", args:  val_5);
    }
    private static string 丙丄丄上上丆丐丘丄()
    {
        var val_7;
        if(UnityEngine.Application.platform == 11)
        {
                string val_4 = Rilisoft.丅丒三丐不丏业丛万.丙丄丄上上丆丐丘丄().ToString(provider:  System.Globalization.CultureInfo.InvariantCulture);
            return (string)val_7;
        }
        
        if(UnityEngine.Application.platform == 8)
        {
                string val_6 = 丂业一丟丝且一丑丈.丗七丙专丗丄三七丙();
            return (string)val_7;
        }
        
        val_7 = "0";
        return (string)val_7;
    }
    public NumberVersionLabel()
    {
    
    }

}
