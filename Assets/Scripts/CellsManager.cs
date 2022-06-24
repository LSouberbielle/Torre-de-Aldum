
using UnityEngine;
public class CellsManager : MonoBehaviour
{
    [SerializeField] private GameObject bells;
    [SerializeField] private AudioSource bellSounds;
    [SerializeField] private AudioSource cellSounds;
    [SerializeField] private AudioClip prisionBells;
    [SerializeField] private AudioClip cellsOpening;
    
    private void Update()
    {
        OpenCells();
    }

    private void OpenCells()
    {
        if (!GameManager.Instance.journalIsClosed) return;
        Invoke("RingBell", 7);
        Invoke("PlayJailAnim", 22);
        Destroy(gameObject, 25);
        Destroy(bells,25);
    }
    private void RingBell()
    {
        bellSounds.PlayOneShot(prisionBells);
    }
    private void PlayJailAnim()
    {
        {
            cellSounds.PlayOneShot(cellsOpening);
            GameManager.Instance.cellsAreOpen = true;
        }
    }
}
