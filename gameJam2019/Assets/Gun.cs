
using System.Collections;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
            
        }
    }

    void Shoot()
    {
        muzzleFlash.Play();
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            
            Debug.Log(hit.transform.name);
            Debug.Log("Hit");
            Target1 target = hit.transform.GetComponent<Target1>();
            if(target != null)
            {
                target.TakeDamage(damage);
            }
            GameObject impactEffect1 = impactEffect;
            GameObject impactGO = Instantiate(impactEffect1, hit.point, Quaternion.LookRotation(hit.normal));

        }

    }
}
