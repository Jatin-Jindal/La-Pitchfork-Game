using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericGunController : MonoBehaviour
{
    [SerializeField] Transform shootPosition;
    [Range(0.1f, 1)][SerializeField] float FireRate = 1;
    [SerializeField] float spread = 7;
    [SerializeField] GameObject bullet;
    float timeToFire;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (timeToFire <= Time.time && Input.GetKeyDown(KeyCode.Mouse0))
        {
            timeToFire = Time.time + 1 / FireRate;
            Shoot();
        }
    }

    void Shoot()
    {
        for (int i = 0; i < 12; i++)
        {
            GameObject bulletInstance = Instantiate(bullet, shootPosition.position, shootPosition.rotation);
            Vector3 rot = new Vector3(0, 0, Random.Range(i <= 6 ? -spread : 0, i > 6 ? 0 : spread));
            bulletInstance.transform.eulerAngles += rot;
        }
    }
}
