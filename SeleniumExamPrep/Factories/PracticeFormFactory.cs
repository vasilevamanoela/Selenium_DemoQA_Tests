using SeleniumExamPrep.Models;

namespace SeleniumExamPrep.Factories
{
    public static class PracticeFormFactory
    {
        public static PracticeFormModel Create()
        {
            return new PracticeFormModel
            {
                FirstName = "Pesho",
                LastName = "Peshov",
                UserEmail = "someemail@gmail.com",
                Gender = "Male",
                UserNumber = "12345678910",
                HobiesButtons = "Sports"
            };
        }
    }
}
