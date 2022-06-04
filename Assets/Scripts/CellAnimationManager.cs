using System;
using UnityEngine;

public class CellAnimationManager : MonoBehaviour
{
    [SerializeField] private Animator cells;
    [SerializeField] private string playerCellOpening = "Player_Door_Opening";
    [SerializeField] private Animation cellsOpening;
    private void Start()
    {
        cells = GetComponent<Animator>();
    }
    private void Update()
    {
        if (GameManager.Instance.cellsAreOpen)
        {
            cells.Play("Player_Door_Opening");
        }
    }
}
