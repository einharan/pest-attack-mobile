using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rice : MonoBehaviour
{

  public float HealthPoint = 50f;
  public float AttackPoint = 25f;

  public void OnDamaged(float damagePoint)
  {
    if(HealthPoint - damagePoint <= 0)
    {
        Destroy(this.gameObject);
        PlayerData.LifePoint--;
    }
    else
      HealthPoint -= damagePoint;
      //Debug.Log($"Rice Defense was Hit!!!");

  }

  public void OnDestroy()
  {
    this.gameObject.GetComponent<Collider2D>().enabled = false;
    Destroy(this.gameObject);
  }
}
