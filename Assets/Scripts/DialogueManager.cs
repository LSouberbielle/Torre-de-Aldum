using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{

    public Text nameText;
    public Text dialogueText;

    public Animator dialogueAnimator;
    [SerializeField] private GameObject pressFToContinue;
    private Queue<string> sentences;
    private static readonly int IsOpen = Animator.StringToHash("IsOpen");

    void Start()
    {
        sentences = new Queue<string>();
    }

    private void Update()
    {
        if (dialogueAnimator && Input.GetKeyDown(KeyCode.F))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialogue(Dialogue dialogue)
    { 
        dialogueAnimator.SetBool(IsOpen, true);
        
        nameText.text = dialogue.name;
        
        sentences.Clear();
        
        pressFToContinue.SetActive(true);

        foreach (string sentece in dialogue.sentences)
        {
            sentences.Enqueue(sentece);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        dialogueText.text = "";
        foreach (var letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }
    void EndDialogue()
    {
        dialogueAnimator.SetBool(IsOpen, false);
        pressFToContinue.SetActive(false);
    }
}
