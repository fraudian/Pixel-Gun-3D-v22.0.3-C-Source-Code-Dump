using UnityEngine;
[Serializable]
internal class RewardParticlesSource.Settings
{
    // Fields
    public float emmitDelay;
    public float moveDelay;
    public float radius;
    public int maxPacticlesCount;
    public float particlesSpeed;
    public float particlePositionDelta;
    
    // Methods
    public RewardParticlesSource.Settings()
    {
        this.emmitDelay = 0.1f;
        this.moveDelay = 0.5f;
        this.radius = 60f;
        this.maxPacticlesCount = 7;
        this.particlesSpeed = 1.6f;
        this.particlePositionDelta = 7.714148E-41f;
    }

}
