using UnityEngine;

public class CellAnimationManager : MonoBehaviour
{
    [SerializeField] private Animator cells;
    private void Start()
    {
        cells = GetComponent<Animator>();
    }
    private void Update()
    {
        PlayCellsAnim();
    }

    private void PlayCellsAnim()
    {
        if (GameManager.Instance.cellsAreOpen)
        {
            cells.Play("Player_Door_Opening");
            Destroy(this);
        }
    }
}
