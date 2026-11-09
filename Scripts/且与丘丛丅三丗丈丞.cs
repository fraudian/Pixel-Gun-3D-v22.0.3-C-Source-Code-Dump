using UnityEngine;
private sealed class PushNotificationReceiver.且与丘丛丅三丗丈丞 : IEnumerator<object>, IEnumerator, IDisposable
{
    // Fields
    private int 丗丏丅丕丆世丁专丟;
    private object 丒上七丌业七丟与丐;
    
    // Properties
    private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
    private object System.Collections.IEnumerator.Current { get; }
    
    // Methods
    public PushNotificationReceiver.且与丘丛丅三丗丈丞(int 丗丏丅丕丆世丁专丟)
    {
        this.丗丏丅丕丆世丁专丟 = 丗丏丅丕丆世丁专丟;
    }
    private void System.IDisposable.Dispose()
    {
    
    }
    private bool MoveNext()
    {
        Rilisoft.PushNotifications.PushNotificationHandler val_2;
        int val_3;
        val_2 = this;
        if(this.丗丏丅丕丆世丁专丟 == 1)
        {
            goto label_1;
        }
        
        if(this.丗丏丅丕丆世丁专丟 != 0)
        {
            goto label_2;
        }
        
        this.丗丏丅丕丆世丁专丟 = 0;
        goto label_3;
        label_1:
        this.丗丏丅丕丆世丁专丟 = 0;
        if((Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField) != 0)
        {
            goto label_7;
        }
        
        label_3:
        val_3 = 1;
        this.丒上七丌业七丟与丐 = 0;
        this.丗丏丅丕丆世丁专丟 = val_3;
        return (bool)val_3;
        label_7:
        val_2 = Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField;
        if((Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField.三与专与丐丟丗丏一) == false)
        {
            goto label_11;
        }
        
        label_2:
        val_3 = 0;
        return (bool)val_3;
        label_11:
        Rilisoft.PushNotifications.PushNotificationHandler.<不丁丄七丛不丆丁丕>k__BackingField.<丞丕丈一三丏七丒丈>k__BackingField = true;
        return (bool)val_3;
    }
    private object System.Collections.Generic.IEnumerator<System.Object>.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }
    private void System.Collections.IEnumerator.Reset()
    {
        System.NotSupportedException val_1 = new System.NotSupportedException();
    }
    private object System.Collections.IEnumerator.get_Current()
    {
        return (object)this.丒上七丌业七丟与丐;
    }

}
