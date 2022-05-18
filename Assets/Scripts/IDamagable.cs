namespace AGEP.Project.Player
{
    public interface IDamagable
    {
        //To deal damage at anything that can be damaged towards.
        void Damage(int damageTaken);
    }
}