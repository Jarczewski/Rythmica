using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public abstract class Button : MonoBehaviour {
    Animator animator;

    public Camera mainCamera;

    public AudioManager am;

    public Engine engine;

    public void PlaySound()
    {
        am.PlayRandom();
    }

    public abstract void onClick();

	void Start () {
        animator = transform.GetComponent<Animator>();
    }
	
	void Update () {
        if (Input.GetMouseButtonDown(0))
        {
            Ray click_ray = mainCamera.ScreenPointToRay(Input.mousePosition);
            RaycastHit rhit;
            if (Physics.Raycast(click_ray, out rhit))
            {
                if(rhit.transform == transform)
                {
                    animator.Play("press");

                    onClick();

                }
            }
        }

    }
}
