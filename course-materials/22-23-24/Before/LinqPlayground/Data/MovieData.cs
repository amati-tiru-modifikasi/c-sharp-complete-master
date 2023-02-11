using System.Collections.Generic;
using LinqPlayground.Entities;
using System;

namespace LinqPlayground.Data
{
    public class MovieData
    {
        public static List<Movie> GetMovies() => new List<Movie>
        {
            new Movie
            {
                Id =2093,
                ReleaseDate = DateTime.Parse("1983-05-25 00:00:00.0000000"),
                Budget = 32350000,
                Revenue = 572700000,
                Runtime = 135,
                Title = "Return of the Jedi",
                Overview = "Luke Skywalker leads a mission to rescue his friend Han Solo from the clutches of Jabba the Hutt, while the Emperor seeks to destroy the Rebellion once and for all with a second dreaded Death Star.",
                Popularity = 25,
                Tagline = "The Empire Falls...",
                VoteAverage = 7,
                VoteCount = 10992
            },
            new Movie
            {
                Id =2109,
                ReleaseDate = DateTime.Parse("1993-06-11 00:00:00.0000000"),
                Budget = 63000000,
                Revenue = 920100000,
                Runtime = 127,
                Title = "Jurassic Park",
                Overview = "A wealthy entrepreneur secretly creates a theme park featuring living dinosaurs drawn from prehistoric DNA. Before opening day, he invites a team of experts and his two eager grandchildren to experience the park and help calm anxious investors. However, the park is anything but amusing as the security systems go off-line and the dinosaurs escape.",
                Popularity = 24,
                Tagline = "An adventure 65 million years in the making.",
                VoteAverage = 7,
                VoteCount = 11856
            },
            new Movie
            {
                Id =2257,
                ReleaseDate = DateTime.Parse("2013-11-15 00:00:00.0000000"),
                Budget = 130000000,
                Revenue = 847423452,
                Runtime = 146,
                Title = "The Hunger Games: Catching Fire",
                Overview = "Katniss Everdeen has returned home safe after winning the 74th Annual Hunger Games along with fellow tribute Peeta Mellark. Winning means that they must turn around and leave their family and close friends, embarking on a \"Victor's Tour\" of the districts. Along the way Katniss senses that a rebellion is simmering, but the Capitol is still very much in control as President Snow prepares the 75th Annual Hunger Games (The Quarter Quell) - a competition that could change Panem forever.",
                Popularity = 35,
                Tagline = "Every revolution begins with a spark.",
                VoteAverage = 7,
                VoteCount = 13611
            },
            new Movie
            {
                Id =2271,
                ReleaseDate = DateTime.Parse("1985-07-03 00:00:00.0000000"),
                Budget = 19000000,
                Revenue = 381109762,
                Runtime = 116,
                Title = "Back to the Future",
                Overview = "Eighties teenager Marty McFly is accidentally sent back in time to 1955, inadvertently disrupting his parents' first meeting and attracting his mother's romantic interest. Marty must repair the damage to history by rekindling his parents' romance and - with the help of his eccentric inventor friend Doc Brown - return to 1985.",
                Popularity = 42,
                Tagline = "He's the only kid ever to get into trouble before he was born.",
                VoteAverage = 8,
                VoteCount = 14629
            },
            new Movie
            {
                Id =2323,
                ReleaseDate = DateTime.Parse("2016-12-14 00:00:00.0000000"),
                Budget = 200000000,
                Revenue = 1056057273,
                Runtime = 133,
                Title = "Rogue One: A Star Wars Story",
                Overview = "A rogue band of resistance fighters unite for a mission to steal the Death Star plans and bring a new hope to the galaxy.",
                Popularity = 48,
                Tagline = "A Rebellion Built on Hope",
                VoteAverage = 7,
                VoteCount = 11844
            },
            new Movie
            {
                Id =2327,
                ReleaseDate = DateTime.Parse("2013-06-12 00:00:00.0000000"),
                Budget = 225000000,
                Revenue = 754045518,
                Runtime = 143,
                Title = "Man of Steel",
                Overview = "A young boy learns that he has extraordinary powers and is not of this earth. As a young man, he journeys to discover where he came from and what he was sent here to do. But the hero in him must emerge if he is to save the world from annihilation and become the symbol of hope for all mankind.",
                Popularity = 52,
                Tagline = "You will believe that a man can fly.",
                VoteAverage = 6,
                VoteCount = 11798
            },
            new Movie
            {
                Id =2336,
                ReleaseDate = DateTime.Parse("2008-06-22 00:00:00.0000000"),
                Budget = 180000000,
                Revenue = 521311860,
                Runtime = 98,
                Title = "WALL·E",
                Overview = "WALL·E is the last robot left on an Earth that has been overrun with garbage and all humans have fled to outer space. For 700 years he has continued to try and clean up the mess, but has developed some rather interesting human-like qualities. When a ship arrives with a sleek new type of robot, WALL·E thinks he's finally found a friend and stows away on the ship when it leaves.",
                Popularity = 53,
                Tagline = "After 700 years of doing what he was built for, he'll discover what he was meant for.",
                VoteAverage = 8,
                VoteCount = 14011
            },
            new Movie
            {
                Id =2338,
                ReleaseDate = DateTime.Parse("1999-03-30 00:00:00.0000000"),
                Budget = 63000000,
                Revenue = 463517383,
                Runtime = 136,
                Title = "The Matrix",
                Overview = "Set in the 22nd century, The Matrix tells the story of a computer hacker who joins a group of underground insurgents fighting the vast and powerful computers who now rule the earth.",
                Popularity = 50,
                Tagline = "Welcome to the Real World.",
                VoteAverage = 8,
                VoteCount = 18722
            },
            new Movie
            {
                Id =2356,
                ReleaseDate = DateTime.Parse("2014-03-20 00:00:00.0000000"),
                Budget = 170000000,
                Revenue = 714766572,
                Runtime = 136,
                Title = "Captain America: The Winter Soldier",
                Overview = "After the cataclysmic events in New York with The Avengers, Steve Rogers, aka Captain America is living quietly in Washington, D.C. and trying to adjust to the modern world. But when a S.H.I.E.L.D. colleague comes under attack, Steve becomes embroiled in a web of intrigue that threatens to put the world at risk. Joining forces with the Black Widow, Captain America struggles to expose the ever-widening conspiracy while fighting off professional assassins sent to silence him at every turn. When the full scope of the villainous plot is revealed, Captain America and the Black Widow enlist the help of a new ally, the Falcon. However, they soon find themselves up against an unexpected and formidable enemy—the Winter Soldier.",
                Popularity = 45,
                Tagline = "In heroes we trust.",
                VoteAverage = 7,
                VoteCount = 14075
            },
            new Movie
            {
                Id =2366,
                ReleaseDate = DateTime.Parse("2014-07-30 00:00:00.0000000"),
                Budget = 170000000,
                Revenue = 772776600,
                Runtime = 121,
                Title = "Guardians of the Galaxy",
                Overview = "Light years from Earth, 26 years after being abducted, Peter Quill finds himself the prime target of a manhunt after discovering an orb wanted by Ronan the Accuser.",
                Popularity = 42,
                Tagline = "All heroes start somewhere.",
                VoteAverage = 7,
                VoteCount = 22029
            },
            new Movie
            {
                Id =2383,
                ReleaseDate = DateTime.Parse("2013-10-03 00:00:00.0000000"),
                Budget = 105000000,
                Revenue = 723192705,
                Runtime = 91,
                Title = "Gravity",
                Overview = "Dr. Ryan Stone, a brilliant medical engineer on her first Shuttle mission, with veteran astronaut Matt Kowalsky in command of his last flight before retiring. But on a seemingly routine spacewalk, disaster strikes. The Shuttle is destroyed, leaving Stone and Kowalsky completely alone-tethered to nothing but each other and spiraling out into the blackness of space. The deafening silence tells them they have lost any link to Earth and any chance for rescue. As fear turns to panic, every gulp of air eats away at what little oxygen is left. But the only way home may be to go further out into the terrifying expanse of space.",
                Popularity = 29,
                Tagline = "Don't Let Go",
                VoteAverage = 7,
                VoteCount = 12112
            },
            new Movie
            {
                Id =2423,
                ReleaseDate = DateTime.Parse("1980-05-20 00:00:00.0000000"),
                Budget = 18000000,
                Revenue = 538400000,
                Runtime = 124,
                Title = "The Empire Strikes Back",
                Overview = "The epic saga continues as Luke Skywalker, in hopes of defeating the evil Galactic Empire, learns the ways of the Jedi from aging master Yoda. But Darth Vader is more determined than ever to capture Luke. Meanwhile, rebel leader Princess Leia, cocky Han Solo, Chewbacca, and droids C-3PO and R2-D2 are thrown into various stages of capture, betrayal and despair.",
                Popularity = 27,
                Tagline = "The Adventure Continues...",
                VoteAverage = 8,
                VoteCount = 12653
            },
            new Movie
            {
                Id =2440,
                ReleaseDate = DateTime.Parse("2013-12-18 00:00:00.0000000"),
                Budget = 23000000,
                Revenue = 47351251,
                Runtime = 126,
                Title = "Her",
                Overview = "In the not so distant future, Theodore, a lonely writer purchases a newly developed operating system designed to meet the user's every needs. To Theodore's surprise, a romantic relationship develops between him and his operating system. This unconventional love story blends science fiction and romance in a sweet tale that explores the nature of love and the ways that technology isolates and connects us all.",
                Popularity = 33,
                Tagline = "A Spike Jonze Love Story",
                VoteAverage = 7,
                VoteCount = 10768
            },
            new Movie
            {
                Id =2458,
                ReleaseDate = DateTime.Parse("2012-03-12 00:00:00.0000000"),
                Budget = 75000000,
                Revenue = 691210692,
                Runtime = 142,
                Title = "The Hunger Games",
                Overview = "Every year in the ruins of what was once North America, the nation of Panem forces each of its twelve districts to send a teenage boy and girl to compete in the Hunger Games.  Part twisted entertainment, part government intimidation tactic, the Hunger Games are a nationally televised event in which “Tributes” must fight with one another until one survivor remains.  Pitted against highly-trained Tributes who have prepared for these Games their entire lives, Katniss is forced to rely upon her sharp instincts as well as the mentorship of drunken former victor Haymitch Abernathy.  If she’s ever to return home to District 12, Katniss must make impossible choices in the arena that weigh survival against humanity and life against love. The world will be watching.",
                Popularity = 35,
                Tagline = "May The Odds Be Ever In Your Favor.",
                VoteAverage = 7,
                VoteCount = 17530
            },
            new Movie
            {
                Id =2474,
                ReleaseDate = DateTime.Parse("1999-05-19 00:00:00.0000000"),
                Budget = 115000000,
                Revenue = 924317558,
                Runtime = 136,
                Title = "Star Wars: Episode I - The Phantom Menace",
                Overview = "Anakin Skywalker, a young slave strong with the Force, is discovered on Tatooine. Meanwhile, the evil Sith have returned, enacting their plot for revenge against the Jedi.",
                Popularity = 31,
                Tagline = "Every generation has a legend. Every journey has a first step. Every saga has a beginning.",
                VoteAverage = 6,
                VoteCount = 10746
            },
            new Movie
            {
                Id =2484,
                ReleaseDate = DateTime.Parse("2004-03-19 00:00:00.0000000"),
                Budget = 20000000,
                Revenue = 72258126,
                Runtime = 108,
                Title = "Eternal Sunshine of the Spotless Mind",
                Overview = "Joel Barish, heartbroken that his girlfriend underwent a procedure to erase him from her memory, decides to do the same. However, as he watches his memories of her fade away, he realises that he still loves her, and may be too late to correct his mistake.",
                Popularity = 32,
                Tagline = "You can erase someone from your mind. Getting them out of your heart is another story.",
                VoteAverage = 8,
                VoteCount = 10692
            },
            new Movie
            {
                Id =3506,
                ReleaseDate = DateTime.Parse("2015-04-22 00:00:00.0000000"),
                Budget = 250000000,
                Revenue = 1405403694,
                Runtime = 141,
                Title = "Avengers: Age of Ultron",
                Overview = "When Tony Stark tries to jumpstart a dormant peacekeeping program, things go awry and Earth’s Mightiest Heroes are put to the ultimate test as the fate of the planet hangs in the balance. As the villainous Ultron emerges, it is up to The Avengers to stop him from enacting his terrible plans, and soon uneasy alliances and unexpected action pave the way for an epic and unique global adventure.",
                Popularity = 174,
                Tagline = "A New Age Has Come.",
                VoteAverage = 7,
                VoteCount = 17375
            },
            new Movie
            {
                Id =3507,
                ReleaseDate = DateTime.Parse("2018-03-28 00:00:00.0000000"),
                Budget = 175000000,
                Revenue = 582890172,
                Runtime = 140,
                Title = "Ready Player One",
                Overview = "When the creator of a popular video game system dies, a virtual contest is created to compete for his fortune.",
                Popularity = 174,
                Tagline = "A better reality awaits.",
                VoteAverage = 7,
                VoteCount = 10956
            },
            new Movie
            {
                Id =3508,
                ReleaseDate = DateTime.Parse("2017-10-25 00:00:00.0000000"),
                Budget = 180000000,
                Revenue = 853977126,
                Runtime = 131,
                Title = "Thor: Ragnarok",
                Overview = "Thor is imprisoned on the other side of the universe and finds himself in a race against time to get back to Asgard to stop Ragnarok, the destruction of his home-world and the end of Asgardian civilization, at the hands of a powerful new threat, the ruthless Hela.",
                Popularity = 184,
                Tagline = "No Hammer. No Problem.",
                VoteAverage = 7,
                VoteCount = 15426
            },
            new Movie
            {
                Id =3521,
                ReleaseDate = DateTime.Parse("2019-03-06 00:00:00.0000000"),
                Budget = 152000000,
                Revenue = 1128276090,
                Runtime = 124,
                Title = "Captain Marvel",
                Overview = "The story follows Carol Danvers as she becomes one of the universe’s most powerful heroes when Earth is caught in the middle of a galactic war between two alien races. Set in the 1990s, Captain Marvel is an all-new adventure from a previously unseen period in the history of the Marvel Cinematic Universe.",
                Popularity = 292,
                Tagline = "Higher. Further. Faster.",
                VoteAverage = 7,
                VoteCount = 10876
            },
            new Movie
            {
                Id =3523,
                ReleaseDate = DateTime.Parse("2019-04-24 00:00:00.0000000"),
                Budget = 356000000,
                Revenue = 2797800564,
                Runtime = 181,
                Title = "Avengers: Endgame",
                Overview = "After the devastating events of Avengers: Infinity War, the universe is in ruins due to the efforts of the Mad Titan, Thanos. With the help of remaining allies, the Avengers must assemble once more in order to undo Thanos' actions and restore order to the universe once and for all, no matter what consequences may be in store.",
                Popularity = 351,
                Tagline = "Part of the journey is the end.",
                VoteAverage = 8,
                VoteCount = 17133
            },
            new Movie
            {
                Id =3529,
                ReleaseDate = DateTime.Parse("2018-02-13 00:00:00.0000000"),
                Budget = 200000000,
                Revenue = 1346739107,
                Runtime = 134,
                Title = "Black Panther",
                Overview = "King T'Challa returns home to the reclusive, technologically advanced African nation of Wakanda to serve as his country's new leader. However, T'Challa soon finds that he is challenged for the throne by factions within his own country as well as without. Using powers reserved to Wakandan kings, T'Challa assumes the Black Panther mantle to join with ex-girlfriend Nakia, the queen-mother, his princess-kid sister, members of the Dora Milaje (the Wakandan 'special forces') and an American secret agent, to prevent Wakanda from being dragged into a world war.",
                Popularity = 161,
                Tagline = "Long live the king.",
                VoteAverage = 7,
                VoteCount = 16883
            },
            new Movie
            {
                Id =3532,
                ReleaseDate = DateTime.Parse("2012-04-25 00:00:00.0000000"),
                Budget = 220000000,
                Revenue = 1518815515,
                Runtime = 143,
                Title = "The Avengers",
                Overview = "When an unexpected enemy emerges and threatens global safety and security, Nick Fury, director of the international peacekeeping agency known as S.H.I.E.L.D., finds himself in need of a team to pull the world back from the brink of disaster. Spanning the globe, a daring recruitment effort begins!",
                Popularity = 157,
                Tagline = "Some assembly required.",
                VoteAverage = 7,
                VoteCount = 24099
            },
            new Movie
            {
                Id =3537,
                ReleaseDate = DateTime.Parse("2016-04-27 00:00:00.0000000"),
                Budget = 250000000,
                Revenue = 1153296293,
                Runtime = 147,
                Title = "Captain America: Civil War",
                Overview = "Following the events of Age of Ultron, the collective governments of the world pass an act designed to regulate all superhuman activity. This polarizes opinion amongst the Avengers, causing two factions to side with Iron Man or Captain America, which causes an epic battle between former allies.",
                Popularity = 119,
                Tagline = "Divided We Fall",
                VoteAverage = 7,
                VoteCount = 17552
            },
            new Movie
            {
                Id =3542,
                ReleaseDate = DateTime.Parse("2014-11-05 00:00:00.0000000"),
                Budget = 165000000,
                Revenue = 675120017,
                Runtime = 169,
                Title = "Interstellar",
                Overview = "The adventures of a group of explorers who make use of a newly discovered wormhole to surpass the limitations on human space travel and conquer the vast distances involved in an interstellar voyage.",
                Popularity = 126,
                Tagline = "Mankind was born on Earth. It was never meant to die here.",
                VoteAverage = 8,
                VoteCount = 25127
            },
            new Movie
            {
                Id =3544,
                ReleaseDate = DateTime.Parse("2014-09-10 00:00:00.0000000"),
                Budget = 34000000,
                Revenue = 348319861,
                Runtime = 113,
                Title = "The Maze Runner",
                Overview = "Set in a post-apocalyptic world, young Thomas is deposited in a community of boys after his memory is erased, soon learning they're all trapped in a maze that will require him to join forces with fellow “runners” for a shot at escape.",
                Popularity = 128,
                Tagline = "Remember. Survive. Run.",
                VoteAverage = 7,
                VoteCount = 13126
            },
            new Movie
            {
                Id =3553,
                ReleaseDate = DateTime.Parse("2017-07-05 00:00:00.0000000"),
                Budget = 175000000,
                Revenue = 880166924,
                Runtime = 133,
                Title = "Spider-Man: Homecoming",
                Overview = "Following the events of Captain America: Civil War, Peter Parker, with the help of his mentor Tony Stark, tries to balance his life as an ordinary high school student in Queens, New York City, with fighting crime as his superhero alter ego Spider-Man as a new threat, the Vulture, emerges.",
                Popularity = 141,
                Tagline = "Homework can wait. The city can't.",
                VoteAverage = 7,
                VoteCount = 15680
            },
            new Movie
            {
                Id =3556,
                ReleaseDate = DateTime.Parse("2016-10-25 00:00:00.0000000"),
                Budget = 165000000,
                Revenue = 677700000,
                Runtime = 115,
                Title = "Doctor Strange",
                Overview = "After his career is destroyed, a brilliant but arrogant surgeon gets a new lease on life when a sorcerer takes him under her wing and trains him to defend the world against evil.",
                Popularity = 146,
                Tagline = "Open your mind. Change your reality.",
                VoteAverage = 7,
                VoteCount = 16477
            },
            new Movie
            {
                Id =3561,
                ReleaseDate = DateTime.Parse("2018-04-25 00:00:00.0000000"),
                Budget = 300000000,
                Revenue = 2046239637,
                Runtime = 149,
                Title = "Avengers: Infinity War",
                Overview = "As the Avengers and their allies have continued to protect the world from threats too large for any one hero to handle, a new danger has emerged from the cosmic shadows: Thanos. A despot of intergalactic infamy, his goal is to collect all six Infinity Stones, artifacts of unimaginable power, and use them to inflict his twisted will on all of reality. Everything the Avengers have fought for has led up to this moment - the fate of Earth and existence itself has never been more uncertain.",
                Popularity = 351,
                Tagline = "An entire universe. Once and for all.",
                VoteAverage = 8,
                VoteCount = 21048
            },
            new Movie
            {
                Id =3643,
                ReleaseDate = DateTime.Parse("2013-06-20 00:00:00.0000000"),
                Budget = 200000000,
                Revenue = 531865000,
                Runtime = 116,
                Title = "World War Z",
                Overview = "Life for former United Nations investigator Gerry Lane and his family seems content. Suddenly, the world is plagued by a mysterious infection turning whole human populations into rampaging mindless zombies. After barely escaping the chaos, Lane is persuaded to go on a mission to investigate this disease. What follows is a perilous trek around the world where Lane must brave horrific dangers and long odds to find answers before human civilization falls.",
                Popularity = 68,
                Tagline = "Remember Philly!",
                VoteAverage = 6,
                VoteCount = 11741
            },
            new Movie
            {
                Id =3650,
                ReleaseDate = DateTime.Parse("2014-07-25 00:00:00.0000000"),
                Budget = 40000000,
                Revenue = 458863600,
                Runtime = 89,
                Title = "Lucy",
                Overview = "A woman, accidentally caught in a dark deal, turns the tables on her captors and transforms into a merciless warrior evolved beyond human logic.",
                Popularity = 71,
                Tagline = "The average person uses 10% of their brain capacity. Imagine what she could do with 100%.",
                VoteAverage = 6,
                VoteCount = 12774
            },
            new Movie
            {
                Id =3653,
                ReleaseDate = DateTime.Parse("2015-09-30 00:00:00.0000000"),
                Budget = 108000000,
                Revenue = 630161890,
                Runtime = 144,
                Title = "The Martian",
                Overview = "During a manned mission to Mars, Astronaut Mark Watney is presumed dead after a fierce storm and left behind by his crew. But Watney has survived and finds himself stranded and alone on the hostile planet. With only meager supplies, he must draw upon his ingenuity, wit and spirit to subsist and find a way to signal to Earth that he is alive.",
                Popularity = 54,
                Tagline = "Bring Him Home",
                VoteAverage = 7,
                VoteCount = 15286
            },
            new Movie
            {
                Id =3659,
                ReleaseDate = DateTime.Parse("2016-11-10 00:00:00.0000000"),
                Budget = 47000000,
                Revenue = 203388186,
                Runtime = 116,
                Title = "Arrival",
                Overview = "Taking place after alien crafts land around the world, an expert linguist is recruited by the military to determine whether they come in peace or are a threat.",
                Popularity = 48,
                Tagline = "Why are they here?",
                VoteAverage = 7,
                VoteCount = 13422
            },
            new Movie
            {
                Id =3663,
                ReleaseDate = DateTime.Parse("2010-07-15 00:00:00.0000000"),
                Budget = 160000000,
                Revenue = 825532764,
                Runtime = 148,
                Title = "Inception",
                Overview = "Cobb, a skilled thief who commits corporate espionage by infiltrating the subconscious of his targets is offered a chance to regain his old life as payment for a task considered to be impossible: \"inception\", the implantation of another person's idea into a target's subconscious.",
                Popularity = 56,
                Tagline = "Your mind is the scene of the crime.",
                VoteAverage = 8,
                VoteCount = 28477
            },
            new Movie
            {
                Id =3668,
                ReleaseDate = DateTime.Parse("2011-07-22 00:00:00.0000000"),
                Budget = 140000000,
                Revenue = 370569774,
                Runtime = 124,
                Title = "Captain America: The First Avenger",
                Overview = "During World War II, Steve Rogers is a sickly man from Brooklyn who's transformed into super-soldier Captain America to aid in the war effort. Rogers must stop the Red Skull – Adolf Hitler's ruthless head of weaponry, and the leader of an organization that intends to use a mysterious device of untold powers for world domination.",
                Popularity = 52,
                Tagline = "When patriots become heroes",
                VoteAverage = 6,
                VoteCount = 16296
            },
            new Movie
            {
                Id =3671,
                ReleaseDate = DateTime.Parse("2016-08-03 00:00:00.0000000"),
                Budget = 175000000,
                Revenue = 746846894,
                Runtime = 123,
                Title = "Suicide Squad",
                Overview = "From DC Comics comes the Suicide Squad, an antihero team of incarcerated supervillains who act as deniable assets for the United States government, undertaking high-risk black ops missions in exchange for commuted prison sentences.",
                Popularity = 53,
                Tagline = "Worst Heroes Ever",
                VoteAverage = 5,
                VoteCount = 17014
            },
            new Movie
            {
                Id =3672,
                ReleaseDate = DateTime.Parse("2015-12-15 00:00:00.0000000"),
                Budget = 245000000,
                Revenue = 2068223624,
                Runtime = 136,
                Title = "Star Wars: The Force Awakens",
                Overview = "Thirty years after defeating the Galactic Empire, Han Solo and his allies face a new threat from the evil Kylo Ren and his army of Stormtroopers.",
                Popularity = 67,
                Tagline = "Every generation has a story.",
                VoteAverage = 7,
                VoteCount = 15524
            },
            new Movie
            {
                Id =3693,
                ReleaseDate = DateTime.Parse("2017-02-28 00:00:00.0000000"),
                Budget = 97000000,
                Revenue = 619021436,
                Runtime = 137,
                Title = "Logan",
                Overview = "In the near future, a weary Logan cares for an ailing Professor X in a hideout on the Mexican border. But Logan's attempts to hide from the world and his legacy are upended when a young mutant arrives, pursued by dark forces.",
                Popularity = 77,
                Tagline = "His time has come",
                VoteAverage = 7,
                VoteCount = 15335
            },
            new Movie
            {
                Id =3694,
                ReleaseDate = DateTime.Parse("2013-04-18 00:00:00.0000000"),
                Budget = 200000000,
                Revenue = 1214811252,
                Runtime = 130,
                Title = "Iron Man 3",
                Overview = "When Tony Stark's world is torn apart by a formidable terrorist called the Mandarin, he starts an odyssey of rebuilding and retribution.",
                Popularity = 90,
                Tagline = "Unleash the power behind the armor.",
                VoteAverage = 6,
                VoteCount = 17328
            },
            new Movie
            {
                Id =3695,
                ReleaseDate = DateTime.Parse("2015-06-06 00:00:00.0000000"),
                Budget = 150000000,
                Revenue = 1671713208,
                Runtime = 124,
                Title = "Jurassic World",
                Overview = "Twenty-two years after the events of Jurassic Park, Isla Nublar now features a fully functioning dinosaur theme park, Jurassic World, as originally envisioned by John Hammond.",
                Popularity = 92,
                Tagline = "The park is open.",
                VoteAverage = 6,
                VoteCount = 16542
            },
            new Movie
            {
                Id =3700,
                ReleaseDate = DateTime.Parse("2008-04-30 00:00:00.0000000"),
                Budget = 140000000,
                Revenue = 585174222,
                Runtime = 126,
                Title = "Iron Man",
                Overview = "After being held captive in an Afghan cave, billionaire engineer Tony Stark creates a unique weaponized suit of armor to fight evil.",
                Popularity = 93,
                Tagline = "Heroes aren't born. They're built.",
                VoteAverage = 7,
                VoteCount = 20056
            },
            new Movie
            {
                Id =3706,
                ReleaseDate = DateTime.Parse("2009-12-10 00:00:00.0000000"),
                Budget = 237000000,
                Revenue = 2787965087,
                Runtime = 162,
                Title = "Avatar",
                Overview = "In the 22nd century, a paraplegic Marine is dispatched to the moon Pandora on a unique mission, but becomes torn between following orders and protecting an alien civilization.",
                Popularity = 97,
                Tagline = "Enter the World of Pandora.",
                VoteAverage = 7,
                VoteCount = 22932
            },
            new Movie
            {
                Id =3717,
                ReleaseDate = DateTime.Parse("2007-12-12 00:00:00.0000000"),
                Budget = 150000000,
                Revenue = 585410052,
                Runtime = 101,
                Title = "I Am Legend",
                Overview = "Robert Neville is a scientist who was unable to stop the spread of the terrible virus that was incurable and man-made. Immune, Neville is now the last human survivor in what is left of New York City and perhaps the world. For three years, Neville has faithfully sent out daily radio messages, desperate to find any other survivors who might be out there. But he is not alone.",
                Popularity = 62,
                Tagline = "The last man on Earth is not alone",
                VoteAverage = 7,
                VoteCount = 11875
            },
            new Movie
            {
                Id =3718,
                ReleaseDate = DateTime.Parse("2014-11-19 00:00:00.0000000"),
                Budget = 125000000,
                Revenue = 752100229,
                Runtime = 123,
                Title = "The Hunger Games: Mockingjay - Part 1",
                Overview = "Katniss Everdeen reluctantly becomes the symbol of a mass rebellion against the autocratic Capitol.",
                Popularity = 84,
                Tagline = "Fire burns brighter in the darkness",
                VoteAverage = 6,
                VoteCount = 12349
            },
            new Movie
            {
                Id =3720,
                ReleaseDate = DateTime.Parse("2015-07-14 00:00:00.0000000"),
                Budget = 130000000,
                Revenue = 519311965,
                Runtime = 117,
                Title = "Ant-Man",
                Overview = "Armed with the astonishing ability to shrink in scale but increase in strength, master thief Scott Lang must embrace his inner-hero and help his mentor, Doctor Hank Pym, protect the secret behind his spectacular Ant-Man suit from a new generation of towering threats. Against seemingly insurmountable obstacles, Pym and Lang must plan and pull off a heist that will save the world.",
                Popularity = 74,
                Tagline = "Heroes don't get any bigger.",
                VoteAverage = 7,
                VoteCount = 15137
            },
            new Movie
            {
                Id =3722,
                ReleaseDate = DateTime.Parse("2015-05-13 00:00:00.0000000"),
                Budget = 150000000,
                Revenue = 378858340,
                Runtime = 121,
                Title = "Mad Max: Fury Road",
                Overview = "An apocalyptic story set in the furthest reaches of our planet, in a stark desert landscape where humanity is broken, and most everyone is crazed fighting for the necessities of life. Within this world exist two rebels on the run who just might be able to restore order.",
                Popularity = 75,
                Tagline = "What a Lovely Day.",
                VoteAverage = 7,
                VoteCount = 17647
            },
            new Movie
            {
                Id =3723,
                ReleaseDate = DateTime.Parse("1977-05-25 00:00:00.0000000"),
                Budget = 11000000,
                Revenue = 775398007,
                Runtime = 121,
                Title = "Star Wars",
                Overview = "Princess Leia is captured and held hostage by the evil Imperial forces in their effort to take over the galactic Empire. Venturesome Luke Skywalker and dashing captain Han Solo team together with the loveable robot duo R2-D2 and C-3PO to rescue the beautiful princess and restore peace and justice in the Empire.",
                Popularity = 75,
                Tagline = "A long time ago in a galaxy far, far away...",
                VoteAverage = 8,
                VoteCount = 15180
            },
            new Movie
            {
                Id =3731,
                ReleaseDate = DateTime.Parse("2010-04-28 00:00:00.0000000"),
                Budget = 200000000,
                Revenue = 623933331,
                Runtime = 124,
                Title = "Iron Man 2",
                Overview = "With the world now aware of his dual life as the armored superhero Iron Man, billionaire inventor Tony Stark faces pressure from the government, the press and the public to share his technology with the military. Unwilling to let go of his invention, Stark, with Pepper Potts and James 'Rhodey' Rhodes at his side, must forge new alliances – and confront powerful enemies.",
                Popularity = 78,
                Tagline = "It's not the armor that makes the hero, but the man inside.",
                VoteAverage = 6,
                VoteCount = 15685
            },
            new Movie
            {
                Id =3734,
                ReleaseDate = DateTime.Parse("2014-05-15 00:00:00.0000000"),
                Budget = 250000000,
                Revenue = 747862775,
                Runtime = 132,
                Title = "X-Men: Days of Future Past",
                Overview = "The ultimate X-Men ensemble fights a war for the survival of the species across two time periods as they join forces with their younger selves in an epic battle that must change the past – to save our future.",
                Popularity = 79,
                Tagline = "To save the future, they must alter the past",
                VoteAverage = 7,
                VoteCount = 12172
            },
            new Movie
            {
                Id =3740,
                ReleaseDate = DateTime.Parse("2017-12-13 00:00:00.0000000"),
                Budget = 200000000,
                Revenue = 1332539889,
                Runtime = 152,
                Title = "Star Wars: The Last Jedi",
                Overview = "Rey develops her newly discovered abilities with the guidance of Luke Skywalker, who is unsettled by the strength of her powers. Meanwhile, the Resistance prepares to do battle with the First Order.",
                Popularity = 81,
                Tagline = "Darkness rises... and light to meet it",
                VoteAverage = 6,
                VoteCount = 11659
            }
        };
    }
}