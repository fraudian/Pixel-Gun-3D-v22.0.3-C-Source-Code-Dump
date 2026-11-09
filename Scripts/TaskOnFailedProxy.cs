using UnityEngine;
private class AndroidTaskUtils.TaskOnFailedProxy : AndroidJavaProxy
{
    // Fields
    private System.Action<UnityEngine.AndroidJavaObject> mCallback;
    
    // Methods
    public AndroidTaskUtils.TaskOnFailedProxy(System.Action<UnityEngine.AndroidJavaObject> callback)
    {
        this.mCallback = callback;
    }
    public void onFailure(UnityEngine.AndroidJavaObject exception)
    {
        UnityEngine.AndroidJavaObject val_7 = exception;
        this.mCallback.Invoke(obj:  val_7 = exception);
        if(val_7 != null)
        {
                var val_7 = 0;
            val_7 = val_7 + 1;
            val_7.Dispose();
        }
        
        if(0 != 1)
        {
                return;
        }
        
        if(0 == 0)
        {
                return;
        }
        
        val_7 = ???;
    }

}
