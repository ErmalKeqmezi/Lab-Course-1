using API.Entities;
using Microsoft.AspNetCore.Identity;

namespace API.Data
{
    public static class DbInitializer
    {
        public static async Task Initialize(StoreContext context, UserManager<User> userManager)
        {

            if(!userManager.Users.Any()) 
            {
                var user = new User {
                    UserName = "ermal",
                    Email = "ermal@test.com"
                };

                await userManager.CreateAsync(user, "Pa$$w0rd");
                await userManager.AddToRoleAsync(user, "Member");

                 var admin = new User {
                    UserName = "admin",
                    Email = "admin@test.com"
                };

                await userManager.CreateAsync(admin, "Pa$$w0rd");
                await userManager.AddToRolesAsync(admin, new [] {"Member", "Admin"}); 
            }

            if (context.Products.Any()) return;

            var products = new List<Product>
            {
                new Product
                {
                    Name = "WOMEN'S NIKE GAMMA FORCE CASUAL SHOES",
                    Description =
                        "The iconic AF-1 model undergoes a timely transformation to bring forth the Women's Nike Gamma Force Casual Shoes. This newcomer comes well-equipped with premium material paneling and nuances like a Nike Grind outsole and a plasticized heel for a look and feel that is both proudly next-gen while staying true to its pristine predecessor. When the past and present join forces, anything is possible.",
                    Price = 9000,
                    PictureUrl = "/images/products/product1.jpg",
                    Brand = "Nike",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "MEN'S NIKE AIR FORCE 1 '07 LV8 NEXT NATURE CORK CASUAL SHOES",
                    Description = "Your favorite silhouette just got a “trash to treasure” upgrade. Slip into the Nike Air Force 1 '07 LV8 Next Nature Cork Casual Shoes for that classic and clean construction you love with added cork detailing for a top-shelf touch.",
                    Price = 13000,
                    PictureUrl = "/images/products/product2.jpg",
                    Brand = "Nike",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "GIRLS' BIG KIDS' NIKE DUNK LOW SE CASUAL SHOES",
                    Description =
                        "Wear an entire bouquet's worth of vibrant spring colors on your feet when you wear the Girls' Big Kids' Nike Dunk Low SE Casual Shoes. This SE version has plenty of Easter energy, and the crinkled Swoosh looks just like your favorite seasonal candy wrappers.",
                    Price = 9500,
                    PictureUrl = "/images/products/product3.jpg",
                    Brand = "Nike",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "BIG KIDS' AIR JORDAN RETRO 3 BASKETBALL SHOES",
                    Description =
                        "The Big Kids' Air Jordan Retro 3 Basketball Shoes were the first of the illustrious line designed by the legend himself, Tinker Hatfield. Inspired by Michael Jordan's love for luxury, Hatfield introduced the now-iconic Elephant Print, searched for the perfect leathers for the model and incorporated the Jumpman logo for the first time ever. Rocking the stylish model, Jordan earned his fourth All-Star bid, won his first MVP award and won his second straight Dunk Contest after jumping from the free throw line.",
                    Price = 15000,
                    PictureUrl = "/images/products/product4.jpg",
                    Brand = "Nike",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "MEN'S NIKE AIR FORCE 1 '07 LV8 SE CASUAL SHOES",
                    Description =
                        "A sneaker legend gets an upcycled upgrade with the Men's Nike Air Force 1 '07 LV8 SE Casual Shoes. A crisp mix of sustainable materials drapes the iconic design in an oh-so-clean, leveled-up look for any occasion.",
                    Price = 15000,
                    PictureUrl = "/images/products/product5.jpg",
                    Brand = "Nike",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "MEN'S NEW BALANCE 2002R CASUAL SHOES",
                    Description =
                        "A reintroduction of a 2010 running model, the Men's New Balance 2002R Casual Shoes bring sports style and smooth lines to your casual sneaker rotation. The suede uppers offer a premium look and feel while ABZORB midsole cushioning means every step is comfortable.",
                    Price = 14000,
                    PictureUrl = "/images/products/product6.jpg",
                    Brand = "New Balance",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "WOMEN'S AIR JORDAN RETRO 1 LOW SE CASUAL SHOES",
                    Description =
                        "The Women's Air Jordan Retro 1 Low SE Casual Shoes are yet another iconic iteration of the AJ 1 series. Elite embroidery and a muted colorway make these kicks an on and off-court classic that complement any look with legendary luster.",
                    Price = 12000,
                    PictureUrl = "/images/products/product7.jpg",
                    Brand = "Nike",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "AIR JORDAN RETRO 1 MID CASUAL SHOES",
                    Description =
                        "Continuing the legacy that goes back to 1985, the Air Jordan Retro 1 Mid Casual Shoes offer a look that ballers and sneakerheads everywhere just can't get enough of.",
                    Price = 12500,
                    PictureUrl = "/images/products/product8.jpg",
                    Brand = "Nike",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "AIR JORDAN RETRO 1 MID CASUAL SHOES",
                    Description =
                        "Continuing the legacy that goes back to 1985, the Air Jordan Retro 1 Mid Casual Shoes offer a look that ballers and sneakerheads everywhere just can't get enough of.",
                    Price = 12500,
                    PictureUrl = "/images/products/product9.jpg",
                    Brand = "Nike",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "MEN'S ADIDAS ORIGINALS NMD R1 CASUAL SHOES",
                    Description =
                        "A fusion of the best adidas Originals technologies and progressive street style collide on the Men's adidas Originals NMD Runner R1 Casual Shoes. If you are looking for the perfect kicks to stand up to your wardrobe look no further than the adidas Originals NMD R1 Casual Shoes.",
                    Price = 15000,
                    PictureUrl = "/images/products/product10.jpg",
                    Brand = "Adidas",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "MEN'S ADIDAS ORIGINALS NMD R1 CASUAL SHOES",
                    Description =
                        "FA fusion of the best adidas Originals technologies and progressive street style collide on the Men's adidas Originals NMD Runner R1 Casual Shoes. If you are looking for the perfect kicks to stand up to your wardrobe look no further than the adidas Originals NMD R1 Casual Shoes.",
                    Price = 15000,
                    PictureUrl = "/images/products/product11.jpg",
                    Brand = "Adidas",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "MEN'S ADIDAS ORIGINALS OZELIA CASUAL SHOES",
                    Description =
                        "Take a dive into the 90s adidas archives with the Men's adidas Originals Ozelia Casual Shoes. Rooted in an era full of loud, experimental looks, these chunky throwback kicks still look ahead of their time.",
                    Price = 10000,
                    PictureUrl = "/images/products/product12.jpg",
                    Brand = "Adidas",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "MEN'S ADIDAS ORIGINALS SUPERSTAR CASUAL SHOES",
                    Description =
                        "The adidas Superstar Shoes first stepped onto the basketball hardwood in 1970. It didn't take long for them to make the leap from athletic gear to streetwear staple. These shoes show off the materials, proportions and style that made the original such a legend. They've got a smooth leather upper with sporty 3-Stripes and a heel tab. They're finished off with the world-famous rubber shell toe. ",
                    Price = 10000,
                    PictureUrl = "/images/products/product13.jpg",
                    Brand = "Adidas",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "MEN'S PUMA ROMA BASIC CASUAL SHOES",
                    Description =
                        "With classic marks and a retro inspiration, the Mens Puma Roma Basic Casual Shoes are a must-have sneaker straight from the rich Puma archives. The sleek and timeless silhouette gets updated tech for modern comfort and arrives dipped in bold, fresh colors to bolster your everyday look.",
                    Price = 7000,
                    PictureUrl = "/images/products/product14.jpg",
                    Brand = "Puma",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "MEN'S PUMA RIDER FUTURE VINTAGE CASUAL SHOES",
                    Description =
                        "Elevate your everyday sneaker look with the Men's Puma Rider Future Vintage Casual Shoes. With the original Fast Rider serving as inspo, these slimmed-down sneakers feature contemporary materials and retro vibes for a laid-back look into the future.",
                    Price = 9000,
                    PictureUrl = "/images/products/product15.jpg",
                    Brand = "Puma",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "MEN'S REEBOK CLASSIC LEATHER CASUAL SHOES",
                    Description =
                        "Always ready for the ride, the Men's Reebok Classic Leather Casual Shoes bring a refined, timeless sportswear aesthetic to your everyday look. Bold color blocking, retro details and a reputation for timeless style after decades as a streetwear staple, the Reebok Classic Leather remains a must-have in any sneaker rotation.",
                    Price = 8000,
                    PictureUrl = "/images/products/product16.jpg",
                    Brand = "Reebok",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "MEN'S REEBOK CLUB C REVENGE VINTAGE CASUAL SHOES",
                    Description = "Inspired by the tennis courts of yesteryear, the Men's Reebok Club C Revenge Vintage Casual Shoes deliver an old-school look built for the streets of today. Slip into these stunners for a laidback look with a sporty edge.",
                    Price = 8000,
                    PictureUrl = "/images/products/product17.jpg",
                    Brand = "Reebok",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
                new Product
                {
                    Name = "MEN'S REEBOK ZIGWILD TRAIL 6 RUNNING SHOES",
                    Description =
                        "Take on your run with distinctive style in the Men's Reebok ZigWild Trail 6 Running Shoes. Inspired by '90s trail runners, their unique look and comfortable design won't let you down.",
                    Price = 11000,
                    PictureUrl = "/images/products/product18.jpg",
                    Brand = "Reebok",
                    Type = "Shoes",
                    QuantityInStock = 100
                },
            };
            
            foreach (var product in products)
            {
                context.Products.Add(product);
            }

            context.SaveChanges();
        }
    }
}