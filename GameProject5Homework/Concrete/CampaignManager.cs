using GameProject5Homework.Abstract;
using GameProject5Homework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject5Homework.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine( campaign.CampaignName + " Eklendi  " + " İndirim Oranı: " + campaign.DiscountRate + '\n');
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine(campaign.CampaignName + "'nın süresi dolduğundan kampanya silindi." + '\n');
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine( campaign.CampaignName + "  Güncellendi  " + " İndirim Oranı : " + campaign.DiscountRate + '\n');
        }
    }
}
