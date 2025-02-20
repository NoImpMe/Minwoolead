using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GatchaManager : MonoBehaviour
{
    public int count;
    public TextMeshProUGUI countText;
    public int randomInt;
    public Button gatchaButton;
    public float m_roughness;
    public float m_magnitude;
    public Sprite first;
    public Sprite second;
    public Sprite third;
    public Sprite fourth;

    Vector3 originPos;
    public void OnEnable()
    {
        CancelInvoke("Shake");
        gatchaButton.GetComponent<Image>().sprite = first;
        count = 0;
        gatchaButton.interactable = true;
        countText.text = count.ToString();
        randomInt = Random.Range(0, 100) % 15 + 1;
        originPos = gatchaButton.transform.position;
    }

    public void GatchaClick()
    {
        count++;
        countText.text = count.ToString();
        if (count >= 3 && count < 6)
        {
            if(count == 3)
            {
                gatchaButton.GetComponent<Image>().sprite = second;
            }
            InvokeRepeating("Shake" , 0f, 0.8f);
        }
        if (count >= 6 && count < 9)
        {
            if(count == 6)
            {
                gatchaButton.GetComponent<Image>().sprite = third;
            }
            InvokeRepeating("Shake", 0f, 0.5f);
        }
        if (count >= 9)
        {
            if (count == 9)
            {
                gatchaButton.GetComponent<Image>().sprite = fourth;
            }
            InvokeRepeating("Shake", 0f, 0.2f);
        }
        
        if (count == randomInt) 
        {
            if (count < 3)
            {
                countText.text = "Rare!";
                gatchaButton.interactable = false;
                CancelInvoke("Shake");
            }
            else if (count < 6)
            {
                countText.text = "Epic";
                gatchaButton.interactable = false;
                CancelInvoke("Shake");
            }
            else if (count < 9)
            {
                countText.text = "Unique!";
                gatchaButton.interactable = false;
                CancelInvoke("Shake");
            }
            else
            {
                countText.text = "Legendary!";
                gatchaButton.interactable = false;
                CancelInvoke("Shake");
            }
        }
        
    }

    public void Shake()
    {
        float shakeRange = 30f;
        float buttonPosX = Random.value * shakeRange * 2 - shakeRange;
        float buttonPosY = Random.value * shakeRange * 2 - shakeRange;
        Vector3 buttonPos = originPos;
        buttonPos.x += buttonPosX;
        buttonPos.y += buttonPosY;
        gatchaButton.transform.position = buttonPos;
    }

    
}
