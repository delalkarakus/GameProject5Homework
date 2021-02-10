using GameProject5Homework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject5Homework.Abstract
{
    interface ICampaignService
    {
        void Add(Campaign campaign);
        void Update(Campaign campaign);
        void Delete(Campaign campaign);
    }
}
