using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour, IDamagable
{
    public SpriteRenderer thisSprite;
    public int health = 3;

    public delegate void DelegateDamageReceived(Vector3 position);
    public event DelegateDamageReceived OnDamageReceived;

    // Start

   public void ReceiveDamage()
    {
        // ? = if (OnDamageReceived != null)
        OnDamageReceived?.Invoke(transform.position);
        

        // 1
        health--;
        if (health < 0 )
        {
            // Aqui irian las particulas de muerte... si TUVIERA UNAS
            gameObject.SetActive(false );
        }
        else
        {
            StartCoroutine(RoutineChangeColor());
            // 3
        }
    }

   IEnumerator RoutineChangeColor()
   {
        // 2
        thisSprite.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        // 4
        thisSprite.color = Color.white;
    }
}
