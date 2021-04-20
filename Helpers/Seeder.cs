using FundacjaZawszeRazem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FundacjaZawszeRazem.Helpers
{
    public class Seeder
    {
        private readonly DataContext dataContext;

        public Seeder(DataContext _dataContext)
        {
            dataContext = _dataContext;
        }

        public void Seed()
        {
            if (dataContext.Database.CanConnect())
            {
                if (!dataContext.Pets.Any())
                {
                    InsertSampleData();
                }
            }
        }

        private void InsertSampleData()
        {
            var pets = new List<Pet>
            { 
                #region Dogs
                new Pet
                {
                    Name = "Max",
                    DateOfBirth = new DateTime(2018, 08, 01),
                    InShelter = new DateTime(2020, 09, 23),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Pies",
                    Gender = "Samiec",
                    Photo = "../../../assets/Images/Dogs/1-max.jpg"
                },

                new Pet
                {
                    Name = "Luna",
                    DateOfBirth = new DateTime(2018, 05, 01),
                    InShelter = new DateTime(2019, 09, 06),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Pies",
                    Gender = "Samica",
                    Photo = "../../../assets/Images/Dogs/2-luna.jpeg"
                },

                new Pet
                {
                    Name = "Sara",
                    DateOfBirth = new DateTime(2016, 09, 01),
                    InShelter = new DateTime(2020, 05, 13),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Pies",
                    Gender = "Samica",
                    Photo = "../../../assets/Images/Dogs/3-sara.jpg"
                },

                new Pet
                {
                    Name = "Diego",
                    DateOfBirth = new DateTime(2019, 07, 01),
                    InShelter = new DateTime(2020, 02, 18),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Pies",
                    Gender = "Samiec",
                    Photo = "../../../assets/Images/Dogs/4-diego.jpg"
                },

                new Pet
                {
                    Name = "Hugo",
                    DateOfBirth = new DateTime(2020, 12, 01),
                    InShelter = new DateTime(2021, 01, 26),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Pies",
                    Gender = "Samiec",
                    Photo = "../../../assets/Images/Dogs/5-hugo.jpeg"
                },

                new Pet
                {
                    Name = "Abi",
                    DateOfBirth = new DateTime(2019, 11, 01),
                    InShelter = new DateTime(2019, 02, 23),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Pies",
                    Gender = "Samica",
                    Photo = "../../../assets/Images/Dogs/6-abi.jpg"
                },

                new Pet
                {
                    Name = "Elza",
                    DateOfBirth = new DateTime(2017, 04, 01),
                    InShelter = new DateTime(2017, 10, 12),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Pies",
                    Gender = "Samica",
                    Photo = "../../../assets/Images/Dogs/7-elza.png"
                },

                new Pet
                {
                    Name = "Amor",
                    DateOfBirth = new DateTime(2015, 02, 01),
                    InShelter = new DateTime(2018, 11, 03),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Pies",
                    Gender = "Samiec",
                    Photo = "../../../assets/Images/Dogs/8-amor.jpg"
                },

                new Pet
                {
                    Name = "Reksio",
                    DateOfBirth = new DateTime(2016, 03, 01),
                    InShelter = new DateTime(2021, 03, 23),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Pies",
                    Gender = "Samiec",
                    Photo = "../../../assets/Images/Dogs/9-reksio.jpg"
                },

                new Pet
                {
                    Name = "Borys",
                    DateOfBirth = new DateTime(2016, 09, 01),
                    InShelter = new DateTime(2018, 12, 15),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Pies",
                    Gender = "Samiec",
                    Photo = "../../../assets/Images/Dogs/10-borys.jpg"
                },

                new Pet
                {
                    Name = "Kajtek",
                    DateOfBirth = new DateTime(2016, 11, 01),
                    InShelter = new DateTime(2021, 03, 19),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Pies",
                    Gender = "Samiec",
                    Photo = "../../../assets/Images/Dogs/11-kajtek.jpg"
                },
                    
                new Pet
                {
                    Name = "Cezar",
                    DateOfBirth = new DateTime(2014, 01, 01),
                    InShelter = new DateTime(2019, 08, 25),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Pies",
                    Gender = "Samiec",
                    Photo = "../../../assets/Images/Dogs/12-cezar.jpg"
                },
                #endregion

                #region Cats
                new Pet
                {
                    Name = "Jasiek",
                    DateOfBirth = new DateTime(2018, 02, 01),
                    InShelter = new DateTime(2020, 10, 06),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Kot",
                    Gender = "Samiec",
                    Photo = "../../../assets/Images/Cats/jasiek.jpg"
                },
                new Pet
                {
                    Name = "Hana",
                    DateOfBirth = new DateTime(2016, 07, 01),
                    InShelter = new DateTime(2017, 03, 16),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Kot",
                    Gender = "Samica",
                    Photo = "../../../assets/Images/Cats/hana.jpg"
                },
                new Pet
                {
                    Name = "Łatka",
                    DateOfBirth = new DateTime(2020, 05, 01),
                    InShelter = new DateTime(2021, 03, 04),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Kot",
                    Gender = "Samica",
                    Photo = "../../../assets/Images/Cats/łatka.jpg"
                },
                new Pet
                {
                    Name = "Major",
                    DateOfBirth = new DateTime(2019, 07, 01),
                    InShelter = new DateTime(2019, 08, 25),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Kot",
                    Gender = "Samiec",
                    Photo = "../../../assets/Images/Cats/major.jpg"
                },
                new Pet
                {
                    Name = "Nico",
                    DateOfBirth = new DateTime(2019, 02, 01),
                    InShelter = new DateTime(2019, 07, 30),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Kot",
                    Gender = "Samiec",
                    Photo = "./../../assets/Images/Cats/nico.jpg"
                },
                new Pet
                {
                    Name = "Pyza",
                    DateOfBirth = new DateTime(2019, 11, 01),
                    InShelter = new DateTime(2020, 07, 01),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Kot",
                    Gender = "Samica",
                    Photo = "../../../assets/Images/Cats/pyza.jpg"
                },
                new Pet
                {
                    Name = "Rusia",
                    DateOfBirth = new DateTime(2018, 04, 01),
                    InShelter = new DateTime(2018, 12, 06),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Kot",
                    Gender = "Samica",
                    Photo = "../../../assets/Images/Cats/rusia.jpg"
                },
                new Pet
                {
                    Name = "Ravi",
                    DateOfBirth = new DateTime(2015, 02, 01),
                    InShelter = new DateTime(2016, 10, 15),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Kot",
                    Gender = "Samiec",
                    Photo = "../../../assets/Images/Cats/ravi.jpg"
                },
                new Pet
                {
                    Name = "Stefan",
                    DateOfBirth = new DateTime(2016, 03, 01),
                    InShelter = new DateTime(2021, 03, 23),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Kot",
                    Gender = "Samiec",
                    Photo = "../../../assets/Images/Cats/stefan.jpg"
                },
                new Pet
                {
                    Name = "Szejk",
                    DateOfBirth = new DateTime(2016, 09, 01),
                    InShelter = new DateTime(2018, 12, 15),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Kot",
                    Gender = "Samiec",
                    Photo = "../../../assets/Images/Cats/szejk.jpg"
                },
                new Pet
                {
                    Name = "Tadek",
                    DateOfBirth = new DateTime(2016, 11, 01),
                    InShelter = new DateTime(2021, 03, 19),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Kot",
                    Gender = "Samiec",
                    Photo = "../../../assets/Images/Cats/tadek.jpg"
                },
                new Pet
                {
                    Name = "Typek",
                    DateOfBirth = new DateTime(2014, 01, 01),
                    InShelter = new DateTime(2019, 08, 25),
                    Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed maximus tellus hendrerit interdum cursus. Pellentesque scelerisque enim vel finibus condimentum. Nullam fermentum ultrices nibh, eu sodales lorem iaculis nec. Ut nec felis nec velit egestas tristique at a augue. Praesent risus erat, fringilla sit amet bibendum eget, bibendum condimentum augue. Nulla facilisi. Quisque quis turpis mi. Vivamus commodo odio vel consectetur gravida. Morbi consectetur suscipit rhoncus. Aliquam at porta nisi, in accumsan urna. Maecenas efficitur, nisl vel bibendum porta, nibh massa efficitur diam, non condimentum risus ante nec urna. Etiam eget vestibulum lorem. Cras at feugiat turpis, a semper mi. Duis sodales mollis tortor nec cursus.Mauris molestie augue nulla, nec tincidunt libero venenatis ac. Duis dapibus placerat diam vitae faucibus. Proin accumsan, lectus et ultrices rhoncus, tortor ipsum vulputate quam, blandit vehicula elit metus at arcu. Proin tincidunt ut magna non lobortis. Aliquam magna leo, iaculis laoreet ante dignissim, vestibulum auctor sem. Morbi lacinia quis ex eu dignissim. Suspendisse libero justo, placerat ut augue sed, semper semper metus. ",
                    Species = "Kot",
                    Gender = "Samiec",
                    Photo = "../../../assets/Images/Cats/typek.jpg"
                },
                #endregion
            };

            dataContext.AddRange(pets);
            dataContext.SaveChanges();

        }
    }
}
