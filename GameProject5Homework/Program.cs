using GameProject5Homework.Concrete;
using GameProject5Homework.Entities;
using System;

namespace GameProject5Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager1 = new GamerManager(new GamerValidationManager());
            Gamer gamer1 = new Gamer() { GamerId = 1, GamerFirstName = "Delal", GamerLastName = "Karakuş", DateofBirth = 1995, NationalityId = "123456" };

            GamerManager gamerManager2 = new GamerManager(new GamerValidationManager());
            Gamer gamer2 = new Gamer() { GamerId = 2, GamerFirstName = "Murat", GamerLastName = "Altınok", DateofBirth = 1992, NationalityId = "522481" };
            
            GamerManager gamerManager = new GamerManager(new GamerValidationManager());
            gamerManager.Add(gamer1);
            gamerManager.Update(gamer1);
            gamerManager.Delete(gamer1);
            gamerManager.Add(gamer2);
            gamerManager.Update(gamer2);
            gamerManager.Delete(gamer2);

            Game game1 = new Game() { GameId = 1, GameName = "Dead by Daylight", GamePrice = 200 };
            Game game2 = new Game() { GameId = 2, GameName = "Life is Satrange", GamePrice = 150 };
            Game game3 = new Game() { GameId = 3, GameName = "Shadow of War", GamePrice = 300 };

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);
            gameManager.Update(game1);
            gameManager.Delete(game1);
            gameManager.Add(game2);
            gameManager.Update(game2);
            gameManager.Delete(game2);
            gameManager.Add(game3);
            gameManager.Update(game3);
            gameManager.Delete(game3);

            Campaign campaign1 = new Campaign() {CampaignId = 1, CampaignName = "Yılbaşı Kampanyası", DiscountRate = 25};
            Campaign campaign2 = new Campaign() { CampaignId = 2, CampaignName = "Yaz Kampanyası", DiscountRate = 15 };

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);
            campaignManager.Add(campaign2);
            campaignManager.Update(campaign1);
            campaignManager.Update(campaign2);
            campaignManager.Delete(campaign1);
            campaignManager.Delete(campaign2);

            SalesManager salesManager = new SalesManager();
            salesManager.Sales(game1, gamer2);
            salesManager.CampaignSales(game3, gamer1, campaign2);

            SalesManager salesmanager = new SalesManager();
            salesManager.Sales(game1,gamer1);
            salesManager.Sales(game2,gamer2);
            salesManager.CampaignSales(game3, gamer2, campaign1);
            salesManager.CampaignSales(game2, gamer1, campaign2);


        }
    }
}
