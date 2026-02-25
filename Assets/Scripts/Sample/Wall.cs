using UnityEngine;

public class Wall : MonoBehaviour, IDamagable
{
    public void ReceiveDamage()
    {
        Debug.Log("Bala choco con muro");
    }
}
