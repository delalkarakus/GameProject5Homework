using GameProject5Homework.Abstract;
using GameProject5Homework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject5Homework.Concrete
{
    class SalesManager : ISalesService
    {
        public void CampaignSales(Game game, Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.GamerFirstName + " "+ gamer.GamerLastName +" " + game.GameName + " oyununu " + campaign.CampaignName + " ile aldı.");
        }

        public void Sales(Game game, Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName +" " + gamer.GamerLastName+ " " + game.GameName + " Oyununu Aldı");
        }
    }
}
