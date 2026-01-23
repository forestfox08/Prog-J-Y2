using UnityEngine;

public class Wizard : BattleEnemy
{
    private void Start()
    {
        gameObject.name = "Wise Wizard";
        health = 150f;
    }


    public override void TakeDamage(float damage)
    {
        base.TakeDamage(damage * 2f);
        health += 2f;

        Debug.Log($"Wizard neemt {damage * 2f} damage! en door een spell krijgt hij {health += 1f} HP erbij HP: {health}");
        if (health <= 0)
            Die();

    }

    public override void Attack(GameObject target)
    {
        base.Attack(target);
        Debug.Log($"Wizard voert een spell af op {target.name}");
    }


}