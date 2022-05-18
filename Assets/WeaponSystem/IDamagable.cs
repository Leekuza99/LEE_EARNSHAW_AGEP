namespace WeaponSystem
{
    public interface IDamageable
    {
        //To deal damage at anything that can be damaged towards.
        void Damage(int damageTaken);
    }
}