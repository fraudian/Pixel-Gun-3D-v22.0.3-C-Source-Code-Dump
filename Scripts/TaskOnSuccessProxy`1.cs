using UnityEngine;
private class AndroidTaskUtils.TaskOnSuccessProxy<T> : AndroidJavaProxy
{
    // Fields
    private System.Action<T> mCallback;
    private System.Action<UnityEngine.AndroidJavaObject> mCallback2;
    private bool mDisposeResult;
    
    // Methods
    public AndroidTaskUtils.TaskOnSuccessProxy<T>(System.Action<T> callback, bool disposeResult)
    {
        mem[1152921541822248080] = callback;
        mem[1152921541822248096] = disposeResult;
    }
    public void onSuccess(T result)
    {
        bool val_1 = result;
        bool val_2 = result;
    }

}
