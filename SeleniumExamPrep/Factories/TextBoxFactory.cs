using SeleniumExamPrep.Models;

namespace SeleniumExamPrep.Factories
{
    public static class TextBoxFactory
    {
        public static TextBoxModel Create()
        {
            return new TextBoxModel
            {
                UserName = "Pesho Peshov",
                UserEmail = "someemail@gmail.com",
                UserAdress = "Some Adress 1",
                OtherAdress = "Other Adress 2",
            };
        }

    }
}
