using UnityEngine;

public class Enemy : MonoBehaviour, IDamagable
{
   public void ReceiveDamage()
   {
        Debug.Log("Danio recibido");
   }
}
