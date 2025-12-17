using Planeedid.Models;


namespace Planeedid.Services
{
    internal class PlanetsServices
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the first planet from the Sun and the smallest " +
                "in the Solar System. In English, it is named after the ancient Roman god " +
                "Mercurius (Mercury), god of commerce and communication, and the messenger " +
                "of the gods. Mercury is classified as a terrestrial planet, with roughly " +
                "the same surface gravity as Mars. The surface of Mercury is heavily " +
                "cratered, as a result of countless impact events that have accumulated " +
                "over billions of years.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/4/4a/Mercury_in_true_color.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/2/2e/Mercury_globe.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/b/b5/Mercury_MESSENGER.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/9/9c/Mercury_surface.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/d/d1/Mercury_transit.jpg"
                }
            },
            new()
            {
                Name = "Venus",
                Subtitle = "The pressure cooker",
                HeroImage = "venus.png",
                Description ="Venus is the second planet from the Sun. It is a terrestrial " +
                "planet and is the closest in mass and size to its orbital neighbour" +
                " Earth. Venus has by far the densest atmosphere of the terrestrial " +
                "planets, composed mostly of carbon dioxide with a thick, global " +
                "sulfuric acid cloud cover. At the surface it has a mean temperature " +
                "of 737 K (464 °C; 867 °F) and a pressure 92 times that of Earth's " +
                "at sea level.",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/e/e5/Venus-real_color.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/8/85/Venus_globe.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/2/24/Venus_atmosphere.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/0/08/Venus_surface.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/5/54/Venus_transit.jpg"
                }
            },
            new()
            {
                Name = "Earth",
                Subtitle = "The cradle of life",
                HeroImage = "earth.png",
                Description = "The Earth is the only planet known where life " +
                "exists. Almost 1.5 million species of animals and plants have been " +
                "discovered so far, and many more have yet to be found. While " +
                "other planets may have small amounts of ice or steam, the Earth " +
                "is 2/3 water. Earth has perfect conditions for a breathable atmosphere. ",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/9/97/The_Earth_seen_from_Apollo_17.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/c/cb/The_Blue_Marble_%28remastered%29.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/6/6f/Earth_Eastern_Hemisphere.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/5/5f/Earth_Western_Hemisphere.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/3/3f/Earthrise.jpg"
                }
            },
            new()
            {
                Name = "Mars",
                Subtitle = "The red beauty",
                HeroImage = "mars.png",
                Description = "No planet has sparked the imaginations of humans as much " +
                "as Mars. It may be the reddish color of Mars, or the fact that it can " +
                "often be easily seen in the night sky, that has caused people to wonder " +
                "about this close neighbor of ours. Tales of “Martians” invading Earth " +
                "have been around for well over fifty years. But is it likely that any " +
                "kind of life really does exist on Mars? ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/0/02/OSIRIS_Mars_true_color.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/5/56/Mars_Valles_Marineris.jpeg",
                    "https://upload.wikimedia.org/wikipedia/commons/7/70/Mars_surface.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/3/36/Mars_atmosphere.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/1/1b/Mars_sunset.jpg"
                }
            },
            new()
            {
                Name = "Jupiter",
                Subtitle = "The gas giant",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the " +
                "largest in the Solar System. It is a gas giant with a mass more " +
                "than 2.5 times that of all the other planets in the Solar System " +
                "combined, and slightly less than one-thousandth the mass of the " +
                "Sun. Its diameter is eleven times that of Earth, and a tenth " +
                "that of the Sun. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/e/e2/Jupiter.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/5/5a/Jupiter_and_its_shrunken_Great_Red_Spot.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/c/c1/Jupiter_New_Horizons.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/2/2b/Jupiter_clouds.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/6/6f/Jupiter_moons.jpg"
                }
            },
            new()
            {
                Name = "Saturn",
                Subtitle = "The ring planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and " +
                            "the second-largest in the Solar System, after " +
                            "Jupiter. It is a gas giant with an average " +
                            "radius of about nine and a half times that " +
                            "of Earth. It has only one-eighth the average " +
                            "density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/c/c7/Saturn_during_Equinox.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/2/29/Saturn_Storm.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/4/43/Saturn_rings.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/1/1e/Saturn_hexagon.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/9/9f/Saturn_moons.jpg"
                }
            },
            new()
            {
                Name = "Uranus",
                Subtitle = "The Herschel planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. " +
                            "It is named after Greek sky deity Uranus (Caelus), who in " +
                            "Greek mythology is the father of Cronus (Saturn), a grandfather " +
                            "of Zeus (Jupiter) and great-grandfather of Ares (Mars). Uranus " +
                            "has the third-largest planetary radius and fourth-largest " +
                            "planetary mass in the Solar System.",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/3/3d/Uranus2.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/4/4d/Uranus_and_rings.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/7/79/Uranus_clouds.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/0/01/Uranus_moons.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/b/b7/Uranus_atmosphere.jpg"
                }
            },
            new()
            {
                Name = "Neptune",
                Subtitle = "The god of the sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth planet from the Sun and " +
                            "the farthest known planet in the Solar System. It is the " +
                            "fourth-largest planet in the Solar System by diameter, the " +
                            "third-most-massive planet, and the densest giant planet. " +
                            "It is 17 times the mass of Earth, and slightly more " +
                            "massive than its near-twin Uranus.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/5/56/Neptune_Full.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/1/1b/Neptune_clouds.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/8/8b/Neptune_rings.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/2/27/Neptune_storm.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/9/9d/Neptune_moons.jpg"
                }
            },
            new()
            {
                Name = "Pluto",
                Subtitle = "The Fallen Planet",
                HeroImage = "pluto.png",
                Description = "Pluto is one of the most famous objects in our Solar System" +
                              " — not because of its size, but because of the controversy around it." +
                              "Discovered in 1930, Pluto was long considered the ninth planet " +
                              "until astronomers redefined what it means to be a planet in 2006." +
                              "Located deep in the icy Kuiper Belt beyond Neptune, Pluto is made mostly of rock and ice." +
                              "Despite being small, Pluto has a thin atmosphere and five known moons.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/2/2a/Pluto-01_Stern_03_Pluto_Color_TXT.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/4/4f/Pluto_and_Charon.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/9/9d/Pluto_surface.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/3/3a/Pluto_atmosphere.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/0/0c/Pluto_moons.jpg"
                }
            },
            new()
            {
                Name = "Ceres",
                Subtitle = "The hidden World of the Asteroid Belt",
                HeroImage = "ceres.png",
                Description = "Ceres is the largest object in the asteroid belt between Mars and Jupiter" +
                              " and the only dwarf planet found in the inner Solar System." +
                              "When it was discovered in 1801, it was first thought to be a planet," +
                              " then an asteroid, and finally reclassified as a dwarf planet." +
                              "Unlike most asteroids, Ceres is round and may contain a large amount of ice beneath its surface." +
                              "Scientists believe it could even harbor a subsurface ocean.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/5/5b/Ceres_-_RC3_-_Haulani_Crater_%282015%29.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/9/90/Ceres_Dawn.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/6/6e/Ceres_surface.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/4/4f/Ceres_map.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/1/1e/Ceres_ice.jpg"
                }
            },
            new()
            {
                Name = "Haumea",
                Subtitle = "The fast-spinning oddball",
                HeroImage = "haumea.png",
                Description = "" +
                              "Haumea is one of the most unusual dwarf planets in the Solar System. " +
                              "It spins so rapidly that it is stretched into an elongated, egg-like shape rather than a sphere. " +
                              "Located far beyond Neptune in the Kuiper Belt, Haumea is covered in bright, crystalline ice. " +
                              "Its extreme rotation creates strong temperature differences across its surface. " +
                              "Haumea also has a ring system and two known moons, making it a truly unique world.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/9/9c/Haumea_Rotation.gif",
                    "https://upload.wikimedia.org/wikipedia/commons/0/0d/Haumea_Artist_Concept.png",
                    "https://upload.wikimedia.org/wikipedia/commons/4/4b/Haumea_and_moons.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/7/7e/Haumea_ring.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/2/2c/Haumea_shape.jpg"
                }
            },
            new()
            {
                Name = "Makemake",
                Subtitle = "The icy ruler",
                HeroImage = "makemake.png",
                Description = "" +
              "Makemake is a bright, icy dwarf planet located far beyond Neptune in the Kuiper Belt. " +
              "Its surface is covered in frozen methane and nitrogen, allowing it to reflect large amounts of sunlight. " +
              "Discovered in 2005, Makemake played a key role in redefining what it means to be a planet. " +
              "Despite its size, it has no thick atmosphere and only one known moon, adding to its mystery.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/2/29/Makemake_artist_concept.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/1/1e/Makemake_and_moon_artist_concept.png",
                    "https://upload.wikimedia.org/wikipedia/commons/3/3a/Makemake_surface.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/5/59/Makemake_orbit.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/7/75/Makemake_reflection.jpg"
                }
            },
            new()
            {
                Name = "Eris",
                Subtitle = "The rule breaker",
                HeroImage = "eris.png",
                Description = "" +
              "Eris is the most massive known dwarf planet in the Solar System and was responsible for changing planetary definitions. " +
              "Its discovery sparked the debate that ultimately led to Pluto being reclassified as a dwarf planet. " +
              "Eris follows a highly eccentric orbit far beyond Neptune, where temperatures are extremely low. " +
              "Its surface is thought to be covered in reflective ice, making it one of the brightest distant objects we know.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                    "https://upload.wikimedia.org/wikipedia/commons/d/d8/Eris_and_dysnomia.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/5/56/Eris_artist_concept.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/4/4d/Eris_surface.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/1/12/Eris_orbit.jpg",
                    "https://upload.wikimedia.org/wikipedia/commons/9/9e/Eris_reflection.jpg"
                }
            },
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizePlanets = planets
                .OrderBy(item => random.Next());

            return randomizePlanets
                .Take(2)
                .ToList();
        }

        public static List<Planet> GetAllPlanets()
            => planets;
    }
}
