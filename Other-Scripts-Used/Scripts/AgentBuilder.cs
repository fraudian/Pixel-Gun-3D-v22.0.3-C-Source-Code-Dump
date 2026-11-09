using UnityEngine;
public abstract class FlurryAgent.AgentBuilder
{
    // Methods
    public abstract void Build(string apiKey); // 0
    public abstract void WithCrashReporting(bool crashReporting); // 0
    public abstract void WithContinueSessionMillis(long sessionMillis); // 0
    public abstract void WithIncludeBackgroundSessionsInMetrics(bool includeBackgroundSessionsInMetrics); // 0
    public abstract void WithLogEnabled(bool enableLog); // 0
    public abstract void WithLogLevel(FlurrySDK.Flurry.LogLevel logLevel); // 0
    protected FlurryAgent.AgentBuilder()
    {
    
    }

}
