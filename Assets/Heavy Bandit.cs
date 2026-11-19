using UnityEngine;
using UnityEngine.InputSystem;

public class HeavyBandit : MonoBehaviour
{
    public Animator Controller;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.eKey.wasPressedThisFrame)
        {
            Controller.SetTrigger("Hurt");
        }
    }
}
