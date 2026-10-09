using UnityEngine;
using UnityEngine.UI;

public class MMInteract : MonoBehaviour
{
    [SerializeField] private Image MMUI;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        PlayerMovement player = collision.GetComponentInParent<PlayerMovement>();

        if (player != null)
        {
            Debug.Log("Entered");
            MMUI.gameObject.SetActive(true);
        }
    }
}
