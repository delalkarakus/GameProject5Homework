using GameProject5Homework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject5Homework.Abstract
{
    interface IGamerValidationService
    {
        bool Validate(Gamer gamer);
    }
}
