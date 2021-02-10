using GameProject5Homework.Abstract;
using GameProject5Homework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject5Homework.Concrete
{
    class NewGamerValidationManager : IGamerValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
