using GameProject5Homework.Abstract;
using GameProject5Homework.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject5Homework.Concrete
{
    class GamerManager : IGamerService
    {
        IGamerValidationService _gamerValidationService;
        public GamerManager(IGamerValidationService userValidationService)
        {
            _gamerValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerValidationService.Validate(gamer) == true)
            {
                Console.WriteLine(gamer.GamerFirstName + " " + gamer.GamerLastName + " Kayıt Oldu.");
            }
            else
            {
                Console.WriteLine(gamer.GamerFirstName + " " + gamer.GamerLastName + " Doğrulama başarısız. Kayıt Olmadı.");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " "+ gamer.GamerLastName + " Kaydı Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.GamerFirstName + " " + gamer.GamerLastName + " Kaydı Güncellendi");
        }
    }
}
