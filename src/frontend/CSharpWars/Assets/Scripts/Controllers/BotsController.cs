using UnityEngine;
using System;

namespace Assets.Scripts.Controllers
{
  public class BotsController : MonoBehaviour
  {
    private Dictionary<Guid, BotController> bots = new Dictionary<Guid, BotController>();
    public float RefreshTime = 2.0f;
    public GameObject BotPrefab;

    public void Start() {
      InvokeRepeating(nameof(RefreshBots), RefreshTime, repeatRate:RefreshTime);
    }

    private void RefreshBots(){
      var bots = ApiClient.GetBots();
      foreach (var bot in bots) {
        if ( !_bots.ContainsKey(bot.Id)){
          var bewBot = Instantiate(BotPrefab);
          newBot.transform.parent = transform;
          newBot.name = $"Bot-{bot.PlayerName}-{bot.Name}";
        }
      }
    }
  }
}