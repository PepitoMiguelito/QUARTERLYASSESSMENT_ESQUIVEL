using UnityEngine;
using TMPro;


public class PlayerTwo : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_Text;

    private int Age = 17;
    private int Height = 169;
    private float Weight = 101.4f;

    public void ButtonPressed()
    {
        m_Text.text = $"Name : Hong Eunchae \n Country : Korea \n Blood Type : A \n Group : Le Sserafim \n Age: {Age} \n Height: {Height} \n Weight: {Weight}";
    }

}
