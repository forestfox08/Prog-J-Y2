using UnityEngine;

public struct ItemStats
    {
        public float damage;
        public float armor;
        public float weight;

    public ItemStats(float damage, float armor, float weight)
    {
        this.damage = damage;
        this.armor = armor;
        this.weight = weight;
    }
}
