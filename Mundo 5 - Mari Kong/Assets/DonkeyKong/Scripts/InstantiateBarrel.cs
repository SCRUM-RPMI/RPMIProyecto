using UnityEngine;

public class MonoController : MonoBehaviour
{
    public GameObject barrilPrefab; // Asigna el prefab del BarrilGiratorio en el Inspector
    private Animator animator;

    private string currentAnimationName; // Almacenar el nombre de la animaci�n actual

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Obtener el nombre de la animaci�n actual
        GetCurrentAnimationName();

        // Verificar si la animaci�n actual es "Barrel" y el sprite es "BarrelRight"
        if (currentAnimationName == "Barrel")
        {
            // Instanciar el BarrilGiratorio
            InstantiateBarril();
        }
    }

    void GetCurrentAnimationName()
    {
        // Obtener el nombre de la animaci�n actual desde el Animator
        AnimatorClipInfo[] clips = animator.GetCurrentAnimatorClipInfo(0);
        currentAnimationName = clips[0].clip.name;
    }


    void InstantiateBarril()
    {
        // Instanciar el BarrilGiratorio en la posici�n del mono
        Instantiate(barrilPrefab, transform.position, Quaternion.identity);
    }
}

