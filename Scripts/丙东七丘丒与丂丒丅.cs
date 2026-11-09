using UnityEngine;
private class TwitterController.丙东七丘丒与丂丒丅 : TwitterController.万丛丈丒丕丒东丆丂
{
    // Methods
    public override void 丘上丐世丆丑且丞丒(string 丏丕下东丛丘丐丐丕, string 下三丅丈丑不且万上)
    {
        Prime31.TwitterAndroid.init(consumerKey:  丏丕下东丛丘丐丐丕, consumerSecret:  下三丅丈丑不且万上, callbackUrlScheme:  "twitterplugin");
    }
    public override bool 丛七上三丘丙丙上业()
    {
        return Prime31.TwitterAndroid.isLoggedIn();
    }
    public override void 丑与东丒七丁丝三丁(string 丝丝不丝上丂三丌世)
    {
        Prime31.TwitterAndroid.postStatusUpdate(status:  丝丝不丝上丂三丌世);
    }
    public override void 丗丁丙东专丘下丅丘(System.Action 三丌丏丕丟世一业专)
    {
        Prime31.TwitterAndroid.showLoginDialog(useExternalBrowserForAuthentication:  false);
    }
    public override void 丛丗下世丆丕丟丟丒()
    {
        Prime31.TwitterAndroid.logout();
    }
    public TwitterController.丙东七丘丒与丂丒丅()
    {
        val_1 = new System.Object();
    }

}
