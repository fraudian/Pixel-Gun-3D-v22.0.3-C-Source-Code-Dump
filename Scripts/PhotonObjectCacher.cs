using UnityEngine;
internal class PhotonObjectCacher : MonoBehaviour
{
    // Fields
    internal static System.Collections.Generic.List<PhotonView> 上丗业丌三业东丂与;
    
    // Methods
    internal static void 且上丛丂三丛且丟下(UnityEngine.MonoBehaviour 万且万且丑丗且丌丆)
    {
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        var val_10;
        val_6 = static_value_081D9CF0;
        val_6 = static_value_081D9CF0;
        val_7 = 0;
        goto label_5;
        label_18:
        T val_6 = 万且万且丑丗且丌丆.GetComponents<Rilisoft.VTableHolder>()[0];
        if(val_6 != 0)
        {
                val_8 = static_value_081D9CF0;
            val_8 = static_value_081D9CF0;
            val_9 = mem[static_value_081D9CF0 + 184 + 88];
            val_9 = static_value_081D9CF0 + 184 + 88;
            if((val_9.Contains(item:  val_6)) != true)
        {
                val_10 = static_value_081D9CF0;
            val_10 = static_value_081D9CF0;
            val_9 = mem[static_value_081D9CF0 + 184 + 88];
            val_9 = static_value_081D9CF0 + 184 + 88;
            bool val_4 = val_9.Add(item:  val_6);
        }
        
        }
        
        val_7 = 1;
        label_5:
        if(val_7 < val_1.Length)
        {
            goto label_18;
        }
    
    }
    internal static void 下丘三丛丞且三丛万(UnityEngine.MonoBehaviour 万且万且丑丗且丌丆)
    {
        var val_4;
        var val_5;
        var val_6;
        var val_7;
        var val_8;
        var val_9;
        val_4 = 万且万且丑丗且丌丆;
        val_5 = static_value_081D9CF0;
        val_5 = static_value_081D9CF0;
        val_4 = val_4.GetComponents<Rilisoft.VTableHolder>();
        val_6 = 0;
        goto label_5;
        label_15:
        val_7 = static_value_081D9CF0;
        T val_4 = val_4[0];
        val_7 = static_value_081D9CF0;
        val_8 = mem[static_value_081D9CF0 + 184 + 88];
        val_8 = static_value_081D9CF0 + 184 + 88;
        if((val_8.Contains(item:  val_4)) != false)
        {
                val_9 = static_value_081D9CF0;
            val_9 = static_value_081D9CF0;
            val_8 = mem[static_value_081D9CF0 + 184 + 88];
            val_8 = static_value_081D9CF0 + 184 + 88;
            bool val_3 = val_8.Remove(item:  val_4);
        }
        
        val_6 = 1;
        label_5:
        if(val_6 < val_1.Length)
        {
            goto label_15;
        }
    
    }
    internal static void 丞万一世丁丛且丙丝(PhotonView 丁世丛业丟下丕三丟)
    {
        null = null;
        PhotonObjectCacher.上丗业丌三业东丂与.Add(item:  丁世丛业丟下丕三丟);
    }
    internal static void 丐丞丌丛七业东丝丟(PhotonView 万且万且丑丗且丌丆)
    {
        var val_3;
        var val_4;
        val_3 = null;
        val_3 = null;
        if((PhotonObjectCacher.上丗业丌三业东丂与.Contains(item:  万且万且丑丗且丌丆)) == false)
        {
                return;
        }
        
        val_4 = null;
        val_4 = null;
        bool val_2 = PhotonObjectCacher.上丗业丌三业东丂与.Remove(item:  万且万且丑丗且丌丆);
    }
    public PhotonObjectCacher()
    {
    
    }
    private static PhotonObjectCacher()
    {
        PhotonObjectCacher.上丗业丌三业东丂与 = new System.Collections.Generic.List<PhotonView>(capacity:  144);
    }

}
