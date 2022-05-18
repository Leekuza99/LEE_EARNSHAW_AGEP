namespace AGEP.Project.Player
{
    
    public interface IWeapon
    {
        // Player to Weapon Interface
        void ChangeWeapon();
        void PickupWeapon();
        void ReloadWeapon();
        void ShootWeapon();  
    }
   
}