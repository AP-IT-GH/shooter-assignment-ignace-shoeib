using UnityEngine;
using UnityEngine.UI;
public class Shoot : MonoBehaviour
{
    public GameObject projectile;
    float timer = 10f;
    bool start = false;
    public float shootRate = 3f;
    public Text score;
    void Update()
    {
        float shoot = Input.GetAxis("Fire1");
        if (shoot == 1 && timer >= shootRate)
        {
            GameObject newProjectile = Instantiate(projectile, transform.position + transform.forward, transform.rotation);
            gameObject.GetComponent<AudioSource>().PlayOneShot(gameObject.GetComponent<AudioSource>().clip);
            newProjectile.GetComponent<Rigidbody>().AddForce(transform.forward * 500, ForceMode.VelocityChange);
            newProjectile.GetComponent<BulletKill>().score = score;
            start = true;
            timer = 0f;
        }

        if (start)
        {
            if (timer < shootRate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                timer = shootRate;
                start = false;
            }
        }
    }
}