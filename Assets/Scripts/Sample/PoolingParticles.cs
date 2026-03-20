using UnityEngine;

public class PoolingParticles : Pooling
{
    public static PoolingParticles Instance;
    public Enemy enemyToListen;

    void OnEnable()
    {
        enemyToListen.OnDamageReceived += EnemyDamaged;
    }

    void OnDisable()
    {
        enemyToListen.OnDamageReceived -= EnemyDamaged;
    }

    void EnemyDamaged(Vector3 vectorReceived)
    {
        Debug.Log("Enemigo daniado");
    }

    void Awake()
    {
        Instance = this;
    }




}






