using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWords : MonoBehaviour
{
    public static bool hasHelloCard, hasCatCard;
    public Transform A;
    List<Transform> GridRow = new List<Transform>();

    private void Start()
    {
        GridRow.Add(A);
    }

    public void PlayerGetWord()
    {
        if (A.childCount > 0)
        {
            if (A.GetChild(0).name == "Hello(Clone)")
            {
                if (!hasHelloCard)
                {
                    hasHelloCard = true;
                    var wordUIScript = GameObject.Find("WordUI").GetComponent<WordUI>();
                    wordUIScript.TurnOnExclamationsButton();
                    wordUIScript.TurnOnHelloButton();
                    SoundManager.playSound(SoundManager.effectPop);
                }
            }
            else if (A.GetChild(0).name == "Cat(Clone)")
            {
                if (!hasCatCard)
                {
                    hasCatCard = true;
                    var wordUIScript = GameObject.Find("WordUI").GetComponent<WordUI>();
                    wordUIScript.TurnOnNounsButton();
                    wordUIScript.TurnOnCatButton();
                    SoundManager.playSound(SoundManager.effectPop);
                }
            }
        }
    }

}
