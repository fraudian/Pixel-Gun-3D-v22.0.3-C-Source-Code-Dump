using UnityEngine;
public class Sounds : MonoBehaviour
{
    // Fields
    public UnityEngine.AudioClip hurt;
    public UnityEngine.AudioClip voice;
    public UnityEngine.AudioClip bite;
    public UnityEngine.AudioClip death;
    public float notAttackingSpeed;
    public float attackingSpeed;
    public float health;
    public float attackDistance;
    public float timeToHit;
    public float detectRadius;
    public int damagePerHit;
    public int scorePerKill;
    public float[] attackingSpeedRandomRange;
    
    // Methods
    public Sounds()
    {
        int val_2;
        this.timeToHit = 2f;
        this.detectRadius = 17f;
        this.damagePerHit = 1;
        this.scorePerKill = 50;
        this.notAttackingSpeed = ;
        this.attackingSpeed = ;
        this.health = 100f;
        this.attackDistance = 3f;
        float[] val_1 = new float[2];
        val_2 = val_1.Length;
        if(val_2 == 0)
        {
                val_2 = val_1.Length;
        }
        
        val_1[0] = -0.5f;
        val_1[1] = 0.5f;
        this.attackingSpeedRandomRange = val_1;
    }

}
