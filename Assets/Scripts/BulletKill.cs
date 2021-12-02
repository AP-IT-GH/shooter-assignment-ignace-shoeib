using System;
using UnityEngine;
using UnityEngine.UI;
public class BulletKill : MonoBehaviour
{
    public Text score;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.SetActive(false);
            collision.transform.parent.GetComponent<AudioSource>().Play();
            var em = collision.transform.parent.GetComponent<ParticleSystem>().emission;
            em.enabled = true;
            collision.transform.parent.GetComponent<ParticleSystem>().Play();
            score.text = Convert.ToString(Convert.ToInt32(score.text) + 100);
        }
    }
}