using UnityEngine;
internal static class 上丐丛丗丑三万丘专
{
    // Methods
    internal static void 丛丄丆一且丏丂下丆()
    {
        var val_3 = null;
        上丐丛丗丑三万丘专.丒丟丐丞丘丂专丘丙(丞丁丑丏丄丏七丂不:  PGCompany.丁东丌世与丕东丆上.丟三万不丁丝七丘丗(), 丈东丘丏与丌东东下:  transform, 丂丛丑东不丅丈一东:  2);
    }
    internal static void 丒丟丐丞丘丂专丘丙(string 丞丁丑丏丄丏七丂不, UnityEngine.Transform 丈东丘丏与丌东东下, Rilisoft.七丕丟丏三丈一丄世 丂丛丑东不丅丈一东 = 2)
    {
        UnityEngine.GameObject val_9;
        .丞丁丑丏丄丏七丂不 = 丞丁丑丏丄丏七丂不;
        UnityEngine.Object val_2 = UnityEngine.Resources.Load(path:  "ConnectPanel");
        if(val_2 != null)
        {
                val_2 = (null == null) ? (val_2) : 0;
        }
        else
        {
                val_9 = 0;
        }
        
        UnityEngine.GameObject val_3 = UnityEngine.Object.Instantiate<UnityEngine.GameObject>(original:  val_9);
        val_3.transform.SetParent(parent:  丈东丘丏与丌东东下, worldPositionStays:  false);
        val_3.SetActive(value:  false);
        ConnectionControl val_6 = 丈东丘丏与丌东东下.gameObject.AddComponent<ConnectionControl>();
        .丙不丅丝丙专丕世丐 = val_6;
        val_6.SetConnectPanel(丛丘下丗业丂一且业:  val_3.GetComponent<ConnectPanel>());
        GameConnect.世上万不丐丄丂且万(丏丂丞丙丘下一丆丝:  丂丛丑东不丅丈一东);
        (上丐丛丗丑三万丘专.丝丂下丂丐丄丁丑丄)[1152921538509008752].丙不丅丝丙专丕世丐.丆下丅丟下丂一不丙(万七一丗三丂东丅丒:  new System.Action(object:  new 上丐丛丗丑三万丘专.丝丂下丂丐丄丁丑丄(), method:  System.Void 上丐丛丗丑三万丘专.丝丂下丂丐丄丁丑丄::与丞丏丟世丟丗丈丂()), 丟丌丘世丟丛下万东:  false, 世丁丒丞丁丕一丟万:  false, 丐丝丛丂与专下丝丙:  false, 丅万丁丌一世下丐丑:  false, 丝丞丌丌不业丕七七:  0, 丛且丞与丕业下丏丞:  0, 丆丅丙丞丈丘丌万丙:  false);
    }

}
