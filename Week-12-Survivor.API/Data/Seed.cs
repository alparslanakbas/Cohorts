using Week_12_Survivor.API.Models;

namespace Week_12_Survivor.API.Data
{
    public class Seed
    {
        public static void SeedData(Context context)
        {
            if (!context.Categories.Any())
            {
                var categories = new List<Category>
                {
                    new Category
                    {
                        Name = "Ünlüler",
                        IsDeleted = false,
                    },
                    new Category
                    {
                        Name = "Gönüllüler",
                        IsDeleted = false,
                    },
                };
                context.Categories.AddRange(categories);
                context.SaveChanges();
            }
            if (!context.Competitors.Any())
            {
                var competitors = new List<Competitor>
                {
                    new Competitor
                    {
                        FirstName = "Acun",
                        LastName = "Ilıcalı",
                        IsDeleted = false,
                        CategoryId = context.Categories.FirstOrDefault(c => c.Name == "Ünlüler").Id
                    },
                    new Competitor
                    {
                        FirstName = "Aleyna",
                        LastName = "Avcı",
                        CategoryId = context.Categories.FirstOrDefault(c => c.Name == "Ünlüler").Id
                    },
                    new Competitor
                    {
                        FirstName = "Hadise",
                        LastName = "Açıkgöz",
                        CategoryId = context.Categories.FirstOrDefault(c => c.Name == "Ünlüler").Id
                    },
                    new Competitor
                    {
                        FirstName = "Sertan",
                        LastName = "Bozkuş",
                        CategoryId = context.Categories.FirstOrDefault(c => c.Name == "Ünlüler").Id
                    },
                    new Competitor
                    {
                        FirstName = "Özge",
                        LastName = "Açık",
                        CategoryId = context.Categories.FirstOrDefault(c => c.Name == "Ünlüler").Id
                    },
                    new Competitor
                    {
                        FirstName = "Kıvanç",
                        LastName = "Tatlıtuğ",
                        CategoryId = context.Categories.FirstOrDefault(c => c.Name == "Ünlüler").Id
                    },
                    new Competitor
                    {
                        FirstName = "Ahmet",
                        LastName = "Yılmaz",
                        CategoryId = context.Categories.FirstOrDefault(c => c.Name == "Gönüllüler").Id
                    },
                    new Competitor
                    {
                        FirstName = "Elif",
                        LastName = "Demirtaş",
                        CategoryId = context.Categories.FirstOrDefault(c => c.Name == "Gönüllüler").Id
                    },
                    new Competitor
                    {
                        FirstName = "Cem",
                        LastName = "Öztürk",
                        CategoryId = context.Categories.FirstOrDefault(c => c.Name == "Gönüllüler").Id
                    }
                };
                context.Competitors.AddRange(competitors);
                context.SaveChanges();
            }
        }
    }
}
