using UnityEngine;
using UnityEngine.UI;

public class car : MonoBehaviour
{
    public string otherCarTag = "OtherCar"; 
    public GameObject failedPanel;
    public GameObject carholder;
    public GameObject Acsil;
    public GameObject stearing;
    public GameObject breake;
    public GameObject reverse;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag(otherCarTag))
        {
            // Show the "Failed" panel
            failedPanel.SetActive(true);

            // Disable the car's movement script
            //  GetComponent<CarController>().enabled = false;
            Acsil.SetActive(false);
            stearing.SetActive(false);
            breake.SetActive(false);
            reverse.SetActive(false);
        }
    }
}
