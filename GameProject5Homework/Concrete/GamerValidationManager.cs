using GameProject5Homework.Abstract;
using GameProject5Homework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject5Homework.Concrete
{
    class GamerValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.GamerId == 1 && gamer.GamerFirstName == "Delal" && gamer.GamerLastName== "Karakuş" && gamer.NationalityId== "123456" && gamer.DateofBirth == 1995)
            {
                return true;
            }
            else if (gamer.GamerId == 2 && gamer.GamerFirstName == "Murat" && gamer.GamerLastName == "Altınok" && gamer.NationalityId == "522481" && gamer.DateofBirth == 1992)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
