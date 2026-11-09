using UnityEngine;

namespace PGCompany
{
    internal struct 丄丌丅世上一且世丁 : IEquatable<PGCompany.丄丌丅世上一且世丁>
    {
        // Fields
        private readonly Unity.Notifications.Android.AndroidNotificationChannel <上万三丅且丆丅三丙>k__BackingField;
        
        // Properties
        internal Unity.Notifications.Android.AndroidNotificationChannel 不丗丏丑东丛丆丘丄 { get; }
        
        // Methods
        internal Unity.Notifications.Android.AndroidNotificationChannel 丗丗丏丆一丟丝东丏()
        {
            Unity.Notifications.Android.AndroidNotificationChannel val_0;
            val_0.lockscreenVisibility = ;
            val_0.description = null;
            val_0.id = null;
            return val_0;
        }
        private 丄丌丅世上一且世丁(Unity.Notifications.Android.AndroidNotificationChannel 丒业丁丑丏丑丈丙一)
        {
            mem[1152921555894748608] = 丒业丁丑丏丑丈丙一.description;
            mem[1152921555894748624] = 丒业丁丑丏丑丈丙一.lockscreenVisibility;
            mem[1152921555894748592] = 丒业丁丑丏丑丈丙一.id;
        }
        internal static PGCompany.丄丌丅世上一且世丁 东丝七业丄丑丒世七(Unity.Notifications.Android.AndroidNotificationChannel 丒业丁丑丏丑丈丙一)
        {
            PGCompany.丄丌丅世上一且世丁 val_0;
            Unity.Notifications.Android.AndroidNotificationCenter.RegisterNotificationChannel(channel:  new Unity.Notifications.Android.AndroidNotificationChannel() {id = 丒业丁丑丏丑丈丙一.id, title = 丒业丁丑丏丑丈丙一.id, description = 丒业丁丑丏丑丈丙一.description, importance = -251390016, canBypassDnd = true, canShowBadge = true, enableLights = true, enableVibration = true, lockscreenVisibility = 丒业丁丑丏丑丈丙一.lockscreenVisibility});
            val_0.<上万三丅且丆丅三丙>k__BackingField.lockscreenVisibility = 丒业丁丑丏丑丈丙一.lockscreenVisibility;
            val_0.<上万三丅且丆丅三丙>k__BackingField.description = 丒业丁丑丏丑丈丙一.description;
            val_0.<上万三丅且丆丅三丙>k__BackingField.id = 丒业丁丑丏丑丈丙一.id;
            return val_0;
        }
        public bool Equals(PGCompany.丄丌丅世上一且世丁 丘丛丏丘丝七世七丅)
        {
            return false;
        }
        public override bool Equals(object 万且万且丑丗且丌丆)
        {
        
        }
        public override int GetHashCode()
        {
            mem2[0] = null;
            mem2[0] = null;
            mem2[0] = null;
            return (int)1152921555895577328;
        }
    
    }

}
