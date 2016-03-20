using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarLight.Shared.AI.DaChu
{
  class BotMain : IWarLightAI
  {
    string IWarLightAI.Name()
    {
      return "DaChu 0.1";
    }

    public string Description()
    {
      return "DaChu bot version 0.1 Github: https://github.com/GlitterStar/WarLight.AI";
    }

    bool IWarLightAI.SupportsSettings(GameSettings settings, out string whyNot)
    {
      whyNot = null;
      return true; //Prod supports all settings
    }

    bool IWarLightAI.RecommendsSettings(GameSettings settings, out string whyNot)
    {
      var sb = new StringBuilder();

      if (settings.Cards.ContainsKey(CardType.Reinforcement.CardID))
        sb.AppendLine("This bot doesn't know Reinforcement cards.");
      if (settings.Cards.ContainsKey(CardType.Spy.CardID))
        sb.AppendLine("This bot doesn't know Spy cards.");
      if (settings.Cards.ContainsKey(CardType.EmergencyBlockade.CardID))
        sb.AppendLine("This bot doesn't know EmergencyBlockade cards.");
      if (settings.Cards.ContainsKey(CardType.OrderPriority.CardID))
        sb.AppendLine("This bot doesn't know OrderPriority cards.");
      if (settings.Cards.ContainsKey(CardType.OrderDelay.CardID))
        sb.AppendLine("This bot doesn't know OrderDelay cards.");
      if (settings.Cards.ContainsKey(CardType.Airlift.CardID))
        sb.AppendLine("This bot doesn't know Airlift cards.");
      if (settings.Cards.ContainsKey(CardType.Gift.CardID))
        sb.AppendLine("This bot doesn't know Gift cards.");
      if (settings.Cards.ContainsKey(CardType.Diplomacy.CardID))
        sb.AppendLine("This bot doesn't know Diplomacy cards.");
      if (settings.Cards.ContainsKey(CardType.Sanctions.CardID))
        sb.AppendLine("This bot doesn't know Sanctions cards.");
      if (settings.Cards.ContainsKey(CardType.Reconnaissance.CardID))
        sb.AppendLine("This bot doesn't know Reconnaissance cards.");
      if (settings.Cards.ContainsKey(CardType.Surveillance.CardID))
        sb.AppendLine("This bot doesn't know Surveillance cards.");
      if (settings.Cards.ContainsKey(CardType.Blockade.CardID))
        sb.AppendLine("This bot doesn't know Blockade cards.");
      if (settings.Cards.ContainsKey(CardType.Bomb.CardID))
        sb.AppendLine("This bot doesn't know Bomb cards.");

      whyNot = sb.ToString();
      return whyNot.Length == 0;
    }

    void IWarLightAI.Init(
     GameIDType gameID,
     PlayerIDType myPlayerID,
     Dictionary<PlayerIDType, GamePlayer> players,
     MapDetails map,
     GameStanding distributionStanding,
     GameSettings gameSettings,
     int numberOfTurns,
     Dictionary<PlayerIDType, PlayerIncome> incomes,
     GameOrder[] prevTurn,
     GameStanding latestTurnStanding,
     GameStanding previousTurnStanding,
     Dictionary<PlayerIDType, TeammateOrders> teammatesOrders,
     List<CardInstance> cards,
     int cardsMustPlay)
    {
      throw new NotImplementedException();
    }

    List<TerritoryIDType> IWarLightAI.GetPicks()
    {
      throw new NotImplementedException();
    }

    List<GameOrder> IWarLightAI.GetOrders()
    {
      throw new NotImplementedException();
    }
  }
}
