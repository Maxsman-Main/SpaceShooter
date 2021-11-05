using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerStatsController : MonoBehaviour
{
    [SerializeField]
    private StatField moneyPlace;
    [SerializeField]
    private StatField fuelPlace;
    [SerializeField]
    private StatField healthPlace;
    [SerializeField]
    private Player player;

    public void UpdatePlayerStats()
    {
        moneyPlace.UpdateTextField(player.Money);
        fuelPlace.UpdateTextField(player.Fuel);
        healthPlace.UpdateTextField(player.Health);
    }

    public void CheckHealth()
    {
        if(player.Health <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
}
