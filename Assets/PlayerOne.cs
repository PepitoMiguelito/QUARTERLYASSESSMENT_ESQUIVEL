using UnityEngine;
using TMPro;

public class PlayerOne : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI m_Text;

    private int Age = 25;
    private int Height = 170;
    private float Weight = 105.8f; 

    public void ButtonPressed()
    {
        m_Text.text = $"Name : Chou Tyuzu \n Country : Taiwan \n Blood Type : A \n Group : Twice \n Age: {Age} \n Height: {Height} \n Weight: {Weight}";
    }

}
