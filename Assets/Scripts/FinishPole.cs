using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinishPole : MonoBehaviour
{
    public int scoreMultipler;
    public Rigidbody knifeRigidBody;

    public GameObject panelWinScreen;
    public WinScreen winScreen;

    private void Start()
    {
        panelWinScreen.SetActive(false);
    }
    private void OnCollisionEnter(Collision collision)
    {
        panelWinScreen.SetActive(true);
        knifeRigidBody.isKinematic = true;
        winScreen.SendValue(scoreMultipler);
    }
}
