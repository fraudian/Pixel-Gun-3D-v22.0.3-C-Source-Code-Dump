using UnityEngine;

namespace GooglePlayGames.Android
{
    internal class AndroidSnapshotMetadata : ISavedGameMetadata
    {
        // Fields
        private UnityEngine.AndroidJavaObject mJavaSnapshot;
        private UnityEngine.AndroidJavaObject mJavaMetadata;
        private UnityEngine.AndroidJavaObject mJavaContents;
        
        // Properties
        public UnityEngine.AndroidJavaObject JavaSnapshot { get; }
        public UnityEngine.AndroidJavaObject JavaMetadata { get; }
        public UnityEngine.AndroidJavaObject JavaContents { get; }
        public bool IsOpen { get; }
        public string Filename { get; }
        public string Description { get; }
        public string CoverImageURL { get; }
        public System.TimeSpan TotalTimePlayed { get; }
        public System.DateTime LastModifiedTimestamp { get; }
        
        // Methods
        public AndroidSnapshotMetadata(UnityEngine.AndroidJavaObject javaSnapshot)
        {
            this.mJavaSnapshot = javaSnapshot;
            this.mJavaMetadata = javaSnapshot.Call<UnityEngine.AndroidJavaObject>(methodName:  "getMetadata", args:  System.Array.Empty<System.Object>());
            this.mJavaContents = javaSnapshot.Call<UnityEngine.AndroidJavaObject>(methodName:  "getSnapshotContents", args:  System.Array.Empty<System.Object>());
        }
        public AndroidSnapshotMetadata(UnityEngine.AndroidJavaObject javaMetadata, UnityEngine.AndroidJavaObject javaContents)
        {
            val_1 = new System.Object();
            this.mJavaSnapshot = 0;
            this.mJavaMetadata = javaMetadata;
            this.mJavaContents = val_1;
        }
        public UnityEngine.AndroidJavaObject get_JavaSnapshot()
        {
            return (UnityEngine.AndroidJavaObject)this.mJavaSnapshot;
        }
        public UnityEngine.AndroidJavaObject get_JavaMetadata()
        {
            return (UnityEngine.AndroidJavaObject)this.mJavaMetadata;
        }
        public UnityEngine.AndroidJavaObject get_JavaContents()
        {
            return (UnityEngine.AndroidJavaObject)this.mJavaContents;
        }
        public bool get_IsOpen()
        {
            var val_4;
            if(this.mJavaContents != null)
            {
                    val_4 = (this.mJavaContents.Call<System.Boolean>(methodName:  "isClosed", args:  System.Array.Empty<System.Object>())) ^ 1;
                return (bool)val_4 & 1;
            }
            
            val_4 = 0;
            return (bool)val_4 & 1;
        }
        public string get_Filename()
        {
            if(this.mJavaMetadata != null)
            {
                    return this.mJavaMetadata.Call<System.String>(methodName:  "getUniqueName", args:  System.Array.Empty<System.Object>());
            }
            
            return this.mJavaMetadata.Call<System.String>(methodName:  "getUniqueName", args:  System.Array.Empty<System.Object>());
        }
        public string get_Description()
        {
            if(this.mJavaMetadata != null)
            {
                    return this.mJavaMetadata.Call<System.String>(methodName:  "getDescription", args:  System.Array.Empty<System.Object>());
            }
            
            return this.mJavaMetadata.Call<System.String>(methodName:  "getDescription", args:  System.Array.Empty<System.Object>());
        }
        public string get_CoverImageURL()
        {
            if(this.mJavaMetadata != null)
            {
                    return this.mJavaMetadata.Call<System.String>(methodName:  "getCoverImageUrl", args:  System.Array.Empty<System.Object>());
            }
            
            return this.mJavaMetadata.Call<System.String>(methodName:  "getCoverImageUrl", args:  System.Array.Empty<System.Object>());
        }
        public System.TimeSpan get_TotalTimePlayed()
        {
            return System.TimeSpan.FromTicks(value:  this.mJavaMetadata.Call<System.Int64>(methodName:  "getPlayedTime", args:  System.Array.Empty<System.Object>()));
        }
        public System.DateTime get_LastModifiedTimestamp()
        {
            return GooglePlayGames.Android.AndroidJavaConverter.ToDateTime(milliseconds:  this.mJavaMetadata.Call<System.Int64>(methodName:  "getLastModifiedTimestamp", args:  System.Array.Empty<System.Object>()));
        }
    
    }

}
