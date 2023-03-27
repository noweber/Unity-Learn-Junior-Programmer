using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float JumpForce;

    public float GravityPower;

    public bool IsGameOver;

    public ParticleSystem ExplosionParticles;

    public ParticleSystem DirtParticles;

    public AudioClip JumpSound;

    public AudioClip CrashSound;

    private Rigidbody playerRigidbody;

    private bool isOnGround;

    private Animator playerAnimator;

    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
        Physics.gravity *= GravityPower;
        isOnGround = true;
        IsGameOver = false;
        playerAnimator = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !IsGameOver)
        {
            isOnGround = false;
            playerRigidbody.AddForce(Vector3.up *  JumpForce, ForceMode.Impulse);
            playerAnimator.SetTrigger("Jump_trig");
            DirtParticles.Stop();
            playerAudio.PlayOneShot(JumpSound, 1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
            DirtParticles.Play();
        } else if(collision.gameObject.CompareTag("Obstacle")) {
            IsGameOver = true;
            playerAnimator.SetBool("Death_b", true);
            playerAnimator.SetInteger("DeathType_int", 1);
            ExplosionParticles.Play();
            DirtParticles.Stop();
            playerAudio.PlayOneShot(CrashSound, 1.0f);
        }
    }
}
