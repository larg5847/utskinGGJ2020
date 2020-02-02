using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rust_Behaviour : MonoBehaviour
{
    public ParticleSystem rustParticle;
    public ParticleSystem.Particle[] m_Particles;
    public CircleCollider2D collider;

    public float life = 100f;
    public bool isHited;

    // Start is called before the first frame update
    void Start()
    {
        rustParticle = transform.GetChild(0).GetComponent<ParticleSystem>();
        collider = GetComponent<CircleCollider2D>();

        m_Particles = new ParticleSystem.Particle[rustParticle.main.maxParticles];
    }

    private void LateUpdate()
    {
        // GetParticles is allocation free because we reuse the m_Particles buffer between updates
        int numParticlesAlive = rustParticle.GetParticles(m_Particles);

        // Change only the particles that are alive
        if (isHited)
        {
            for (int i = 0; i < numParticlesAlive; i++)
            {
                if(m_Particles[i].size >= 0)
                    m_Particles[i].size -= 0.01f;                
            }
        }

        // Apply the particle changes to the Particle System
        rustParticle.SetParticles(m_Particles, numParticlesAlive);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isHited)
        {
            var rad2 = rustParticle.shape;
            if (rad2.radius <= 5.0f) 
            {
                rad2.enabled = true;
                rad2.radius += 0.001f;
                collider.radius += 0.001f;

                rustParticle.GetParticles(m_Particles, 50);
                //rustParticle.Play();
            }
        }
        else if (isHited)
        {
            var rad2 = rustParticle.shape;
            rad2.enabled = true;
            rad2.radius -= 0.01f;
            collider.radius -= 0.01f;

            transform.localScale = new Vector3();
            life -= 0.5f;

           // rustParticle.Stop();
        }

        if (life <= 0) Destroy(gameObject);
    }
}
