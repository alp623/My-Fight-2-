using UnityEngine;
using UnityEngine.InputSystem;

public class Warrior : MonoBehaviour
{
    public Animator Controller;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            Controller.SetTrigger("Attack");
        }

    }
}
