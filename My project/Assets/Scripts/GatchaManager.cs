using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GatchaManager : MonoBehaviour
{
    public int count;
    public TextMeshProUGUI countText;
    public int randomInt;
    public Button gatchaButton;
    public void OnEnable()
    {
        count = 0;
        gatchaButton.interactable = true;
        countText.text = count.ToString();
        randomInt = Random.Range(0, 100) % 15 + 1;
        gatchaButton = GameObject.Find("Gatcha").GetComponent<Button>();
        gatchaButton.GetComponent<Image>().color = new Color(92f, 255f, 0f);
        Debug.Log(randomInt);

    }

    public void GatchaClick()
    {
        count++;
        countText.text = count.ToString();
        if (count == randomInt) 
        {
            if (count < 3)
            {
                countText.text = "Rare!";
                gatchaButton.interactable = false;
            }
            else if (count < 6)
            {
                countText.text = "Epic";
                gatchaButton.interactable = false;
            }
            else if (count < 9)
            {
                countText.text = "Unique!";
                gatchaButton.interactable = false;
            }
            else
            {
                countText.text = "Legendary!";
                gatchaButton.interactable = false;
            }
        }
        if(count >= 3)
        {
            gatchaButton.GetComponent<Image>().color = new Color(255f, 255f, 0f);
            if (count >= 6)
            {
                gatchaButton.GetComponent<Image>().color = new Color(255f, 167f, 0f);
                if (count >= 9)
                {
                    gatchaButton.GetComponent<Image>().color = new Color(255f, 0f, 0f);
                }
            }
        }
    }
}
