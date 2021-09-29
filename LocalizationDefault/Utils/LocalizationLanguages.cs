using LocalizationDefault.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizationDefault.Utils
{
    public static class LocalizationLanguages
    {
        //  Створення і ініціалізація колекції мов
        private static IList<LocalizationViewModel> Languages { get; set; } = new List<LocalizationViewModel> { 
            new LocalizationViewModel{
                locCode = "uk",
                locName = "Українська мова"
            },
            new LocalizationViewModel{
                locCode = "en",
                locName = "English language"
            }
        };
        public static List<LocalizationViewModel> GetLanguages() 
        {
            //  Повернення колеції мов
            return Languages.ToList();
        }
    }
}
