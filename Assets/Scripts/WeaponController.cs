using UnityEngine;

public class WeaponController : MonoBehaviour
{
    public WeaponBase currentWeapon;
    public PlayerInputReader input;
    public ParticleSystem particle;

    
    void Update()
    {
        if (input.IsFiring && currentWeapon != null && currentWeapon.CanFire() && input.IsAiming)
        {
            Debug.Log("무기 발사 시도");
            currentWeapon.Fire();
            particle.Play();

        }
        else
        {
            particle.Stop(true);
        }
    }
}
