using UnityEngine;
[Serializable]
public sealed class HiddenSettings : ScriptableObject
{
    // Fields
    public string appsFlyerAppKey;
    private string cloudSynchronizerKey;
    public string devtodevSecretAmazon;
    public string devtodevSecretGoogle;
    public string devtodevSecretIos;
    public string devtodevSecretWsa;
    public string flurryAmazonApiKey;
    public string flurryAmazonDevApiKey;
    public string flurryAndroidApiKey;
    public string flurryAndroidDevApiKey;
    public string flurryIosApiKey;
    public string flurryIosDevApiKey;
    private string persistentCacheManagerKey;
    public string PhotonAppIdEncoded;
    public string PhotonAppIdPad;
    public string PhotonAppIdSignatureEncoded;
    public string PhotonAppIdSignaturePad;
    public string PhotonAppIdSignatureZeroEncoded;
    public string PhotonAppIdZeroEncoded;
    public string PhotonAppIdBundlePad;
    public string PhotonAppIdBundleZeroEncoded;
    private string playerPrefsKey;
    
    // Properties
    public string PersistentCacheManagerKey { get; }
    public string CloudSynchronizerKey { get; }
    public string PlayerPrefsKey { get; }
    
    // Methods
    public string get_PersistentCacheManagerKey()
    {
        return (string)this.persistentCacheManagerKey;
    }
    public string get_CloudSynchronizerKey()
    {
        return (string)this.cloudSynchronizerKey;
    }
    public string get_PlayerPrefsKey()
    {
        return (string)this.playerPrefsKey;
    }
    public HiddenSettings()
    {
    
    }

}
