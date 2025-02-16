using UnityEngine;

public class Rice : Trap
{
  public void OnDamaged2(float damagePoint)
  {
    if(HealthPoint - damagePoint <= 0)
    {
      //this.gameObject.GetComponent<Collider2D>().enabled = false;
      Destroy(this.gameObject);
      PlayerData.LifePoint--;
    }
    else
      HealthPoint -= damagePoint;
      //Debug.Log($"Rice Defense was Hit!!!");

  }

  public void OnDestroy()
  {
    Destroy(this.gameObject);
  }
}
