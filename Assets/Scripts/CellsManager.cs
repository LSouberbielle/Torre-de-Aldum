using UnityEngine;
public class CellsManager : MonoBehaviour
{
    [SerializeField] private float timeToRingBell = 7;
    [SerializeField] private float timeToOpenCells = 19;
    [SerializeField] private AudioSource bellSounds;
    [SerializeField] private AudioSource cellSounds;
    [SerializeField] private AudioClip prisionBells;
    [SerializeField] private AudioClip cellsOpening;
    private void Update()
    {
        timeToRingBell -= Time.deltaTime;
        timeToOpenCells -= Time.deltaTime;
        RingBell();
        OpenCells();
    }

    private void RingBell()
    {
        if (timeToRingBell <= 0)
        {
            bellSounds.PlayOneShot(prisionBells);
        }
    }
    private void OpenCells()
    {
        if (timeToOpenCells <= 0)
        {
            cellSounds.PlayOneShot(cellsOpening);
            GameManager.Instance.cellsAreOpen = true;
        }
    }
}
