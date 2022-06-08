using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using MonProjetdotNET.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonProjetdotNET.Data
{
    public class AppDbInitializer
    {
        public static void seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope=applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();
                context.Database.EnsureCreated();


                //Parfums
                if (!context.Parfums.Any())
                {
                    context.Parfums.AddRange(new List<Parfum>()
                    {
                        new Parfum()
                        {
                            PictureURL ="https://www.olfastory.com/sites/www.olfastory.com/files/styles/400x400/public/caramel.jpg?itok=BCrZr3Jy",
                            FullName ="Caramel",
                            Description ="fabriqué en chauffant une gamme de sucres. Il peut être utilisé comme arôme dans les puddings et les desserts, comme garniture dans les bonbons ou comme garniture pour la crème glacée et la crème anglaise ou bien dans les sucreries."
                        },
                        new Parfum()
                        {
                            PictureURL ="https://www.olfastory.com/sites/www.olfastory.com/files/styles/400x400/public/chocolat.jpg?itok=QRcdGxRQ",
                            FullName ="Chocolat",
                            Description ="fabriqué en chauffant une gamme de sucres. Il peut être utilisé comme arôme dans les puddings et les desserts, comme garniture dans les bonbons ou comme garniture pour la crème glacée et la crème anglaise ou bien dans les sucreries."
                        },
                        new Parfum()
                        {
                            PictureURL ="https://www.olfastory.com/sites/www.olfastory.com/files/styles/400x400/public/dulce-de-leche-en-parfumerie.jpg?itok=w2_kLtqw",
                            FullName ="Dulce de Leche",
                            Description ="fabriqué en chauffant une gamme de sucres. Il peut être utilisé comme arôme dans les puddings et les desserts, comme garniture dans les bonbons ou comme garniture pour la crème glacée et la crème anglaise ou bien dans les sucreries."
                        },
                        new Parfum()
                        {
                            PictureURL ="https://www.olfastory.com/sites/www.olfastory.com/files/styles/400x400/public/guimauve.jpg?itok=1mjHnane",
                            FullName ="Guimauve",
                            Description ="fabriqué en chauffant une gamme de sucres. Il peut être utilisé comme arôme dans les puddings et les desserts, comme garniture dans les bonbons ou comme garniture pour la crème glacée et la crème anglaise ou bien dans les sucreries."
                        },
                        new Parfum()
                        {
                            PictureURL ="https://www.olfastory.com/sites/www.olfastory.com/files/styles/400x400/public/cappuccino-en-parfumerie.jpg?itok=O5NKzFU5",
                            FullName ="Cappuccino",
                            Description ="fabriqué en chauffant une gamme de sucres. Il peut être utilisé comme arôme dans les puddings et les desserts, comme garniture dans les bonbons ou comme garniture pour la crème glacée et la crème anglaise ou bien dans les sucreries."
                        }


                    });
                    context.SaveChanges();
                }
                //Chefs
                if (!context.Chefs.Any())
                {
                    context.Chefs.AddRange(new List<Chef>()
                    {
                        new Chef()
                        {
                            PictureURL ="https://www.olfastory.com/sites/www.olfastory.com/files/styles/400x400/public/caramel.jpg?itok=BCrZr3Jy",
                            FullName ="Caramel",
                            Bio ="fabriqué en chauffant une gamme de sucres. Il peut être utilisé comme arôme dans les puddings et les desserts, comme garniture dans les bonbons ou comme garniture pour la crème glacée et la crème anglaise ou bien dans les sucreries."
                        },
                        new Chef()
                        {
                            PictureURL ="https://www.olfastory.com/sites/www.olfastory.com/files/styles/400x400/public/chocolat.jpg?itok=QRcdGxRQ",
                            FullName ="Chocolat",
                            Bio ="fabriqué en chauffant une gamme de sucres. Il peut être utilisé comme arôme dans les puddings et les desserts, comme garniture dans les bonbons ou comme garniture pour la crème glacée et la crème anglaise ou bien dans les sucreries."
                        },
                        new Chef()
                        {
                            PictureURL ="https://www.olfastory.com/sites/www.olfastory.com/files/styles/400x400/public/dulce-de-leche-en-parfumerie.jpg?itok=w2_kLtqw",
                            FullName ="Dulce de Leche",
                            Bio ="fabriqué en chauffant une gamme de sucres. Il peut être utilisé comme arôme dans les puddings et les desserts, comme garniture dans les bonbons ou comme garniture pour la crème glacée et la crème anglaise ou bien dans les sucreries."
                        },
                        new Chef()
                        {
                            PictureURL ="https://www.olfastory.com/sites/www.olfastory.com/files/styles/400x400/public/guimauve.jpg?itok=1mjHnane",
                            FullName ="Guimauve",
                            Bio ="fabriqué en chauffant une gamme de sucres. Il peut être utilisé comme arôme dans les puddings et les desserts, comme garniture dans les bonbons ou comme garniture pour la crème glacée et la crème anglaise ou bien dans les sucreries."
                        },
                        new Chef()
                        {
                            PictureURL ="https://www.olfastory.com/sites/www.olfastory.com/files/styles/400x400/public/cappuccino-en-parfumerie.jpg?itok=O5NKzFU5",
                            FullName ="Cappuccino",
                            Bio ="fabriqué en chauffant une gamme de sucres. Il peut être utilisé comme arôme dans les puddings et les desserts, comme garniture dans les bonbons ou comme garniture pour la crème glacée et la crème anglaise ou bien dans les sucreries."
                        }


                    });
                    context.SaveChanges();

                }
                //Sweetmeat
                if (!context.Sweetmeats.Any())
                {
                    context.Sweetmeats.AddRange(new List<Sweetmeat>()
                    {
                        new Sweetmeat()
                        {
                            Name="Makrouth Asmar",
                            Description ="Parmi les classiques de la pâtisserie tunisienne (maghrébine généralement), le « makroudh » au dattes est parmi les plus connus. C’est aussi une délicieuse pâtisserie et pas compliqué à faire… ce qui est un vrai avantage: une vrai recette familiale!!!",
                            Price=10.2,
                            ImageURL="http://www.sfax-annuaire.com/galerie/12014-01-28-18-44-28img-8065.jpg",
                            SweetmeatCategory=SweetmeatCategory.Evenement,
                            ChefId=1
                        },
                        new Sweetmeat()
                        {
                            Name="Mlabes",
                            Description ="Parmi les classiques de la pâtisserie tunisienne , le « mlabes » est parmi les plus connus. C’est aussi une délicieuse pâtisserie et pas compliqué à faire… ce qui est un vrai avantage: une vrai recette familiale!!!",
                            Price=10.2,
                            ImageURL="https://www.gourmandise.com.tn/919/mlabess-amande.jpg",
                            SweetmeatCategory=(SweetmeatCategory)1,
                            ChefId=1
                        },
                        new Sweetmeat()
                        {
                            Name="Kaak warka ",
                            Description ="Parmi les classiques de la pâtisserie tunisienne , le « mlabes » est parmi les plus connus. C’est aussi une délicieuse pâtisserie et pas compliqué à faire… ce qui est un vrai avantage: une vrai recette familiale!!!",
                            Price=10.2,
                            ImageURL="http://www.patisserie.tn/wp-content/uploads/Kaak-Warka.jpg",
                            SweetmeatCategory=(SweetmeatCategory)1,
                            ChefId=1
                        }


                    });
                    context.SaveChanges();

                }
                //Parfums & Sweetmeat
                if (!context.Parfum_Sweetmeats.Any())
                {
                    context.Parfum_Sweetmeats.AddRange(new List<Parfum_Sweetmeat>()
                    {
                        new Parfum_Sweetmeat()
                        {
                            ParfumId=1,
                            SweetmeatId=2
                        },
                        new Parfum_Sweetmeat()
                        {
                            ParfumId=1,
                            SweetmeatId=1
                        },
                        new Parfum_Sweetmeat()
                        {
                            ParfumId=2,
                            SweetmeatId=2
                        },
                        new Parfum_Sweetmeat()
                        {
                            ParfumId=2,
                            SweetmeatId=1
                        },
                        new Parfum_Sweetmeat()
                        {
                            ParfumId=1,
                            SweetmeatId=3
                        }



                    });
                   
                }


            }
        }
    }
}
