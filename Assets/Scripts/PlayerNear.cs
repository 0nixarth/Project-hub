using UnityEngine;

public class TriggerNPCAnimation : MonoBehaviour
{
    public Animator npcAnimator; // R�f�rence � l'Animator du NPC
    public string playAnimationParam = "PlayAnimation"; // Nom du param�tre bool�en dans l'Animator pour activer/d�sactiver l'animation
    public string idleState = "Idle"; // Nom de l'animation ou Trigger pour l'�tat Idle

    private void OnTriggerEnter(Collider other)
    {
        // V�rifie si c'est le Player qui entre dans la zone de d�clenchement
        if (other.CompareTag("Player"))
        {
            // Active le param�tre pour lancer l'animation
            npcAnimator.SetBool(playAnimationParam, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // V�rifie si c'est le Player qui quitte la zone de d�clenchement
        if (other.CompareTag("Player"))
        {
            // D�sactive le param�tre pour arr�ter l'animation (retour � l'�tat idle)
            npcAnimator.SetBool(playAnimationParam, false);
        }
    }
}
