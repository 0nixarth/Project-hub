using UnityEngine;

public class TriggerNPCAnimation : MonoBehaviour
{
    public Animator npcAnimator; // Référence à l'Animator du NPC
    public string playAnimationParam = "PlayAnimation"; // Nom du paramètre booléen dans l'Animator pour activer/désactiver l'animation
    public string idleState = "Idle"; // Nom de l'animation ou Trigger pour l'état Idle

    private void OnTriggerEnter(Collider other)
    {
        // Vérifie si c'est le Player qui entre dans la zone de déclenchement
        if (other.CompareTag("Player"))
        {
            // Active le paramètre pour lancer l'animation
            npcAnimator.SetBool(playAnimationParam, true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Vérifie si c'est le Player qui quitte la zone de déclenchement
        if (other.CompareTag("Player"))
        {
            // Désactive le paramètre pour arrêter l'animation (retour à l'état idle)
            npcAnimator.SetBool(playAnimationParam, false);
        }
    }
}
