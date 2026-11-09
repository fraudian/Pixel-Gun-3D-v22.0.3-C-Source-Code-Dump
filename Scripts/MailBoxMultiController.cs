using UnityEngine;
public class MailBoxMultiController : MonoBehaviour
{
    // Fields
    internal static MailBoxMultiController 丄丞丁丈与业上丞丟;
    private static readonly string 丌丏世丟丒丅东丏丁;
    internal static readonly string 丝万丐丟丛丄七上万;
    internal static readonly string 东专丐三丘丛丗丆丝;
    internal static readonly string 丘东且丑丂三专丑与;
    
    // Methods
    private void Awake()
    {
        null = null;
        MailBoxMultiController.丄丞丁丈与业上丞丟 = this;
    }
    internal object 丄一丅与丅丄丆丈与(string 丟丞东丄七丕丑丆丙)
    {
        null = null;
        string val_5 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  MailBoxMultiController.丌丏世丟丒丅东丏丁);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_5)) == true)
        {
                return 0;
        }
        
        object val_3 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_5);
        if(val_3 == null)
        {
                return 0;
        }
        
        val_5 = (((System.Object.__il2cppRuntimeField_typeHierarchy + (System.Collections.Generic.Dictionary<TKey, TValue>.__il2cppRuntimeField_typeHierarchyDepth) << 3) + -8) == null) ? (val_3) : 0;
        if((val_5.ContainsKey(key:  丟丞东丄七丕丑丆丙)) == false)
        {
                return 0;
        }
        
        return val_5.Item[丟丞东丄七丕丑丆丙];
    }
    internal void 七丕下丕丒丛万三丈(string 丟丞东丄七丕丑丆丙, object 丙业与丙丗丝不丈东)
    {
        var val_8;
        var val_9;
        object val_10;
        var val_11;
        val_8 = null;
        val_8 = null;
        string val_1 = 丌丝世丞世丛丆丅丟.下世丙上丈丏东与丙(下上丐丆丝丟丝丒不:  MailBoxMultiController.丌丏世丟丒丅东丏丁);
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  val_1)) != false)
        {
                val_9 = null;
        }
        else
        {
                val_10 = Rilisoft.MiniJson.下下丌不上丝丐三丆.丂东专丙丒丏且丛丁(丌且专不丙丕专丅万:  val_1);
            val_9 = null;
        }
        
        System.Collections.Generic.Dictionary<System.String, System.Object> val_4 = null;
        val_10 = val_4;
        val_4 = new System.Collections.Generic.Dictionary<System.String, System.Object>();
        if(val_10 == null)
        {
            goto label_12;
        }
        
        if((val_4.ContainsKey(key:  丟丞东丄七丕丑丆丙)) == false)
        {
            goto label_13;
        }
        
        label_15:
        val_4.set_Item(key:  丟丞东丄七丕丑丆丙, value:  丙业与丙丗丝不丈东);
        goto label_14;
        label_12:
        if((0.ContainsKey(key:  丟丞东丄七丕丑丆丙)) == true)
        {
            goto label_15;
        }
        
        label_13:
        val_4.Add(key:  丟丞东丄七丕丑丆丙, value:  丙业与丙丗丝不丈东);
        label_14:
        val_11 = null;
        val_11 = null;
        丌丝世丞世丛丆丅丟.专丟专且业丅丛下丂(下上丐丆丝丟丝丒不:  MailBoxMultiController.丌丏世丟丒丅东丏丁, 下下丏一丙不丘丌丞:  Rilisoft.MiniJson.下下丌不上丝丐三丆.丙业不丝丗丌丗世下(万且万且丑丗且丌丆:  val_4));
    }
    public MailBoxMultiController()
    {
    
    }
    private static MailBoxMultiController()
    {
        MailBoxMultiController.丌丏世丟丒丅东丏丁 = "MailBoxMultiSettings";
        MailBoxMultiController.丝万丐丟丛丄七上万 = "MailBoxRewardListStorager";
        MailBoxMultiController.东专丐三丘丛丗丆丝 = "MailBoxSettingsListStorager";
        MailBoxMultiController.丘东且丑丂三专丑与 = "MailBoxRewardInfoStorager";
    }

}
