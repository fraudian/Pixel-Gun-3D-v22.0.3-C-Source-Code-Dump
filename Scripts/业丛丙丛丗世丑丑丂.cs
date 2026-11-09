using UnityEngine;
internal static class 业丛丙丛丗世丑丑丂
{
    // Fields
    internal static string 丌东丐七丗丛三上万;
    internal static string 丛丅丘丙丏下万下万;
    internal static string 与丙万丁丁与丗三丐;
    internal static string 丙丐专上三丘丕丝丝;
    
    // Methods
    internal static UnityEngine.GameObject 丄七丝丏丈丗业世业(丏丐丏丘下东丁丐一 丁丅丈丌丟世丗丗丟, UnityEngine.Transform 丂丁万丞万丆三一丒, string 丂东丄丏丕丕丅上一, object[] 一丐丗丁丞丆丅丟丄)
    {
        if((丁丅丈丌丟世丗丗丟 - 1) <= 3)
        {
                var val_10 = 106020528 + ((丁丅丈丌丟世丗丗丟 - 1)) << 2;
            val_10 = val_10 + 106020528;
        }
        else
        {
                UnityEngine.Debug.LogError(message:  System.String.Format(format:  "Transport spawn not implemented to type = {0}", arg0:  丁丅丈丌丟世丗丗丟));
            return 0;
        }
    
    }
    private static UnityEngine.GameObject 丄七丝丏丈丗业世业(string 丟丈一下东业一丝丆, UnityEngine.Transform 丂丁万丞万丆三一丒, string 丂东丄丏丕丕丅上一, object[] 一丐丗丁丞丆丅丟丄)
    {
        string val_7 = 丟丈一下东业一丝丆;
        UnityEngine.Vector3 val_1 = 丂丁万丞万丆三一丒.position;
        UnityEngine.Quaternion val_2 = 丂丁万丞万丆三一丒.rotation;
        UnityEngine.GameObject val_3 = 丅丒丗丑丒丙丛不丆.丛不三丛丂下丁丘丕(丟丈一下东业一丝丆:  val_7 = 丟丈一下东业一丝丆, 业丒丝丗与丐丛丟丏:  new UnityEngine.Vector3() {x = val_1.x, y = val_1.y, z = val_1.z}, 七丅丗丆丒丌丑丝不:  new UnityEngine.Quaternion() {x = val_2.x, y = val_2.y, z = val_2.z, w = val_2.w}, 不丝丄丒丌丐一一与:  0, 一丐丗丁丞丆丅丟丄:  一丐丗丁丞丆丅丟丄);
        VehicleController val_4 = val_3.GetComponent<VehicleController>();
        if(val_4 != null)
        {
                val_4.丗业丕丁丁且与丈丌();
        }
        
        if((丞东丑专丛丆丄丝世.丁三专上上业丝丘丁(下业七不丑丂丏丟东:  丂东丄丏丕丕丅上一)) == true)
        {
                return val_3;
        }
        
        val_7 = val_3.GetComponent<TransportControllerBase>();
        return val_3;
    }
    private static 业丛丙丛丗世丑丑丂()
    {
        业丛丙丛丗世丑丑丂.丌东丐七丗丛三上万 = "VehicleBattleRoyale/Helicopter_prefabs/freeplay_helicopter";
        业丛丙丛丗世丑丑丂.丛丅丘丙丏下万下万 = "FreePlayCar";
        业丛丙丛丗世丑丑丂.与丙万丁丁与丗三丐 = "FreePlayAtv";
        业丛丙丛丗世丑丑丂.丙丐专上三丘丕丝丝 = "FreePlaySnowmobile";
    }

}
