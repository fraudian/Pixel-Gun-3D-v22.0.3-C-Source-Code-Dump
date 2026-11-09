using UnityEngine;

namespace CoreHapticsUnity
{
    public static class CoreHapticsUnityProxy
    {
        // Fields
        public static CoreHapticsUnity.LogsLevel LogLevel;
        private static CoreHapticsUnity.CoreHapticsUnityProxy.HapticStoppedReasonDelegate OnHapticStopped;
        private static CoreHapticsUnity.CoreHapticsUnityProxy.HapticStoppedReasonDelegate OnPatternStopped;
        private static readonly bool isSupported;
        
        // Properties
        public static bool IsSupported { get; }
        
        // Methods
        public static void add_OnHapticStopped(CoreHapticsUnity.CoreHapticsUnityProxy.HapticStoppedReasonDelegate value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  CoreHapticsUnity.CoreHapticsUnityProxy.OnHapticStopped, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(CoreHapticsUnity.CoreHapticsUnityProxy.OnHapticStopped != 1152921505021067272);
        
        }
        public static void remove_OnHapticStopped(CoreHapticsUnity.CoreHapticsUnityProxy.HapticStoppedReasonDelegate value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  CoreHapticsUnity.CoreHapticsUnityProxy.OnHapticStopped, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(CoreHapticsUnity.CoreHapticsUnityProxy.OnHapticStopped != 1152921505021067272);
        
        }
        public static void add_OnPatternStopped(CoreHapticsUnity.CoreHapticsUnityProxy.HapticStoppedReasonDelegate value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Combine(a:  CoreHapticsUnity.CoreHapticsUnityProxy.OnPatternStopped, b:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(CoreHapticsUnity.CoreHapticsUnityProxy.OnPatternStopped != 1152921505021067280);
        
        }
        public static void remove_OnPatternStopped(CoreHapticsUnity.CoreHapticsUnityProxy.HapticStoppedReasonDelegate value)
        {
            var val_3;
            var val_4;
            var val_5;
            val_3 = null;
            val_3 = null;
            do
            {
                val_4 = System.Delegate.Remove(source:  CoreHapticsUnity.CoreHapticsUnityProxy.OnPatternStopped, value:  value);
                if((val_4 != null) && (null != null))
            {
                    val_4 = 0;
            }
            
                val_5 = null;
                val_5 = null;
            }
            while(CoreHapticsUnity.CoreHapticsUnityProxy.OnPatternStopped != 1152921505021067280);
        
        }
        public static void PlayContinuous(float intensity, float sharpness, float durationInSeconds)
        {
            null = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.isSupported == false)
            {
                    return;
            }
            
            CoreHapticsUnity.CoreHapticsUnityProxy._coreHapticsUnityPlayContinuous(intensity:  intensity, sharpness:  sharpness, durationInSeconds:  durationInSeconds);
        }
        public static void PlayContinuous()
        {
            CoreHapticsUnity.CoreHapticsUnityProxy.PlayContinuous(intensity:  0.5f, sharpness:  0.5f, durationInSeconds:  30f);
        }
        public static void PlayPattern(CoreHapticsUnity.HapticsPattern pattern)
        {
            var val_3;
            var val_4;
            val_3 = null;
            val_3 = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.isSupported == false)
            {
                    return;
            }
            
            string val_1 = Newtonsoft.Json.JsonConvert.SerializeObject(value:  pattern, formatting:  1);
            val_4 = null;
            val_4 = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.LogLevel >= 1)
            {
                    UnityEngine.Debug.Log(message:  "[CoreHapticUnity] " + val_1);
                val_4 = null;
            }
            
            CoreHapticsUnity.CoreHapticsUnityProxy.PlayPattern(json:  val_1);
        }
        public static void PlayPattern(string json)
        {
            null = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.isSupported == false)
            {
                    return;
            }
            
            CoreHapticsUnity.CoreHapticsUnityProxy._coreHapticsUnityplayWithDictionaryPattern(jsonDict:  json);
        }
        public static void PlayTransient(float intensity, float sharpness)
        {
            null = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.isSupported == false)
            {
                    return;
            }
            
            CoreHapticsUnity.CoreHapticsUnityProxy._coreHapticsUnityPlayTransient(intensity:  intensity, sharpness:  sharpness);
        }
        public static void PlayTransient()
        {
            CoreHapticsUnity.CoreHapticsUnityProxy.PlayTransient(intensity:  0.5f, sharpness:  0.5f);
        }
        public static void PlayFromFileWithName(string filename)
        {
            null = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.isSupported == false)
            {
                    return;
            }
            
            CoreHapticsUnity.CoreHapticsUnityProxy._coreHapticsUnityplayWIthAHAPFile(filename:  filename);
        }
        public static void PlayFromFileWithURL(string url)
        {
            null = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.isSupported == false)
            {
                    return;
            }
            
            CoreHapticsUnity.CoreHapticsUnityProxy._coreHapticsUnityplayWithAHAPFileFromURLAsString(url:  url);
        }
        public static void Stop()
        {
            null = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.isSupported == false)
            {
                    return;
            }
            
            CoreHapticsUnity.CoreHapticsUnityProxy._coreHapticsUnityStop();
        }
        public static void StopPlayer()
        {
            null = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.isSupported == false)
            {
                    return;
            }
            
            CoreHapticsUnity.CoreHapticsUnityProxy._coreHapticsUnityStopPlayer();
        }
        public static void UpdateContinuousValues(float intensity, float sharpness)
        {
            null = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.isSupported == false)
            {
                    return;
            }
            
            CoreHapticsUnity.CoreHapticsUnityProxy._coreHapticsUnityupdateContinuousHaptics(intensity:  CoreHapticsUnity.CoreHapticsUnityProxy.RoundToDigits(val:  intensity, digits:  3), sharpness:  CoreHapticsUnity.CoreHapticsUnityProxy.RoundToDigits(val:  sharpness, digits:  3));
        }
        public static bool get_IsSupported()
        {
            null = null;
            return (bool)CoreHapticsUnity.CoreHapticsUnityProxy.isSupported;
        }
        private static CoreHapticsUnityProxy()
        {
            CoreHapticsUnity.CoreHapticsUnityProxy.LogLevel = 1;
            UnityEngine.RuntimePlatform val_1 = UnityEngine.Application.platform;
            CoreHapticsUnity.CoreHapticsUnityProxy.isSupported = false;
            CoreHapticsUnity.CoreHapticsUnityProxy.LogLevel = 0;
            mem[1152921524131537248] = 0;
            mem[1152921524131537256] = static System.Void CoreHapticsUnity.CoreHapticsUnityProxy::PatternStoppedCallback(int code);
            mem[1152921524131537232] = static System.Void CoreHapticsUnity.CoreHapticsUnityProxy::PatternStoppedCallback(int code);
            mem[1152921524131541344] = 0;
            mem[1152921524131541352] = static System.Void CoreHapticsUnity.CoreHapticsUnityProxy::HapticStoppedCallback(int code);
            mem[1152921524131541328] = static System.Void CoreHapticsUnity.CoreHapticsUnityProxy::HapticStoppedCallback(int code);
        }
        private static float RoundToDigits(float val, int digits)
        {
            var val_1;
            var val_2;
            float val_3;
            float val_2 = val;
            val_2 = 10f * val_2;
            if(val_2 >= 0f)
            {
                goto label_3;
            }
            
            if((double)val_2 != (-0.5))
            {
                goto label_4;
            }
            
            val_2 = val_1;
            val_3 = -1f;
            goto label_5;
            label_3:
            if((double)val_2 != 0.5)
            {
                goto label_6;
            }
            
            val_2 = val_1;
            val_3 = 1f;
            label_5:
            float val_3 = (float)val_2;
            val_3 = val_3 + val_3;
            val_3 = (((long)val_2 & 1) != 0) ? (val_3) : (val_3);
            goto label_8;
            label_4:
            float val_4 = -0.5f;
            val_4 = val_2 + val_4;
            goto label_8;
            label_6:
            float val_5 = 0.5f;
            val_5 = val_2 + val_5;
            label_8:
            val_5 = val_5 / 10f;
            return (float)val_5;
        }
        private static void HapticStoppedCallback(int code)
        {
            null = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.OnHapticStopped == null)
            {
                    return;
            }
            
            CoreHapticsUnity.CoreHapticsUnityProxy.OnHapticStopped.Invoke(stopCode:  code);
        }
        private static void PatternStoppedCallback(int code)
        {
            null = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.OnPatternStopped == null)
            {
                    return;
            }
            
            CoreHapticsUnity.CoreHapticsUnityProxy.OnPatternStopped.Invoke(stopCode:  code);
        }
        private static void _coreHapticsUnityPlayContinuous(float intensity, float sharpness, float durationInSeconds)
        {
            System.Object[] val_5;
            var val_6;
            val_5 = 1152921505021063168;
            val_6 = null;
            val_6 = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.LogLevel < 1)
            {
                    return;
            }
            
            object[] val_1 = new object[3];
            val_5 = val_1;
            val_5[0] = intensity.ToString();
            val_5[1] = sharpness.ToString();
            val_5[2] = durationInSeconds.ToString();
            UnityEngine.Debug.LogFormat(format:  "[CoreHapticsUnity] Play Continuous with Intensity: {0} and Sharpness: {1} for {2} seconds", args:  val_1);
        }
        private static void _coreHapticsUnityPlayTransient(float intensity, float sharpness)
        {
            System.Object[] val_4;
            var val_5;
            val_4 = 1152921505021063168;
            val_5 = null;
            val_5 = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.LogLevel < 1)
            {
                    return;
            }
            
            object[] val_1 = new object[2];
            val_4 = val_1;
            val_4[0] = intensity.ToString();
            val_4[1] = sharpness.ToString();
            UnityEngine.Debug.LogFormat(format:  "[CoreHapticsUnity] Play Transient with Intensity: {0} and Sharpness: {1}", args:  val_1);
        }
        private static void _coreHapticsUnityStop()
        {
            null = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.LogLevel < 1)
            {
                    return;
            }
            
            UnityEngine.Debug.LogFormat(format:  "[CoreHapticsUnity] Stop", args:  System.Array.Empty<System.Object>());
        }
        private static void _coreHapticsUnityStopPlayer()
        {
            null = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.LogLevel < 1)
            {
                    return;
            }
            
            UnityEngine.Debug.LogFormat(format:  "[CoreHapticsUnity] Stop Player", args:  System.Array.Empty<System.Object>());
        }
        private static void _coreHapticsUnityupdateContinuousHaptics(float intensity, float sharpness)
        {
            System.Object[] val_4;
            var val_5;
            val_4 = 1152921505021063168;
            val_5 = null;
            val_5 = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.LogLevel < 1)
            {
                    return;
            }
            
            object[] val_1 = new object[2];
            val_4 = val_1;
            val_4[0] = intensity.ToString();
            val_4[1] = sharpness.ToString();
            UnityEngine.Debug.LogFormat(format:  "[CoreHapticsUnity] Update Continuous Params with Intensity: {0} and Sharpness: {1}", args:  val_1);
        }
        private static void _coreHapticsUnityplayWithDictionaryPattern(string jsonDict)
        {
            null = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.LogLevel < 1)
            {
                    return;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = jsonDict;
            UnityEngine.Debug.LogFormat(format:  "[CoreHapticsUnity] Play from Pattern: {0}", args:  val_1);
        }
        private static void _coreHapticsUnityplayWIthAHAPFile(string filename)
        {
            null = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.LogLevel < 1)
            {
                    return;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = filename;
            UnityEngine.Debug.LogFormat(format:  "[CoreHapticsUnity] Play from File with Name: {0}", args:  val_1);
        }
        private static void _coreHapticsUnityplayWithAHAPFileFromURLAsString(string url)
        {
            null = null;
            if(CoreHapticsUnity.CoreHapticsUnityProxy.LogLevel < 1)
            {
                    return;
            }
            
            object[] val_1 = new object[1];
            val_1[0] = url;
            UnityEngine.Debug.LogFormat(format:  "[CoreHapticsUnity] Play from File by URL: {0}", args:  val_1);
        }
        private static bool _coreHapticsUnityIsSupport()
        {
            return false;
        }
        private static void _coreHapticsRegisterCallback(CoreHapticsUnity.CoreHapticsUnityProxy.HapticStoppedDelegate patternFinishedCallback, CoreHapticsUnity.CoreHapticsUnityProxy.HapticStoppedDelegate engineStoppedCallback)
        {
        
        }
    
    }

}
