﻿using System;
using System.Collections.Generic;

namespace PinkPoint.ClimbingRoutes.DataAccess
{
    public class ClimbingSitesData
    {
        public static IEnumerable<ClimbingSite> ClimbingSites = new[]
        {
            new ClimbingSite
            {
                Id = Guid.NewGuid(),
                Name = "6a plus - Kletterhalle Winterthur",
                Address = new Address
                {
                    Street = "Klosterstrasse 17",
                    PostCode = "8406",
                    City ="Winterthur",
                    State = "Zürich",
                },
                Routes= new[]
                {
                    new ClimbingRoute
                    {
                        Id = Guid.NewGuid(),
                        Name = "Mamba",
                        Grade = "6a",
                        Type = ClimbingRouteType.SportClimbing,
                        ImageUri = "http://localhost",
                        Color = "#FF0000",
                    },
                    new ClimbingRoute
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zamba",
                        Grade = "5c",
                        Type = ClimbingRouteType.SportClimbing,
                        ImageUri = "http://localhost",
                        Color = "#228b22",
                    },
                    new ClimbingRoute
                    {
                        Id = Guid.NewGuid(),
                        Name = "Matterhorn",
                        Grade = "3b",
                        Type = ClimbingRouteType.SportClimbing,
                        ImageUri = "http://localhost",
                        Color = "#228b22",
                    },
                    new ClimbingRoute
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zahnweh",
                        Grade = "4b+",
                        Type = ClimbingRouteType.SportClimbing,
                        ImageUri = "http://localhost",
                        Color = "#228b22",
                    },
                    new ClimbingRoute
                    {
                        Id = Guid.NewGuid(),
                        Name = "Marsupilami",
                        Grade = "7c",
                        Type = ClimbingRouteType.SportClimbing,
                        ImageUri = "http://localhost",
                        Color = "#228b22",
                    },
                    new ClimbingRoute
                    {
                        Id = Guid.NewGuid(),
                        Name = "Affezoo",
                        Grade = "2b",
                        Type = ClimbingRouteType.SportClimbing,
                        ImageUri = "http://localhost",
                        Color = "#228b22",
                    },
                    new ClimbingRoute
                    {
                        Id = Guid.NewGuid(),
                        Name = "Rattenschwanz",
                        Grade = "5a+",
                        Type = ClimbingRouteType.SportClimbing,
                        ImageUri = "http://localhost",
                        Color = "#228b22",
                    },
                    new ClimbingRoute
                    {
                        Id = Guid.NewGuid(),
                        Name = "Frederic",
                        Grade = "6b",
                        Type = ClimbingRouteType.SportClimbing,
                        ImageUri = "http://localhost",
                        Color = "#228b22",
                    },
                    new ClimbingRoute
                    {
                        Id = Guid.NewGuid(),
                        Name = "Achnei",
                        Grade = "4c",
                        Type = ClimbingRouteType.SportClimbing,
                        ImageUri = "http://localhost",
                        Color = "#228b22",
                    },
                    new ClimbingRoute
                    {
                        Id = Guid.NewGuid(),
                        Name = "Blablup",
                        Grade = "3c+",
                        Type = ClimbingRouteType.SportClimbing,
                        ImageUri = "http://localhost",
                        Color = "#228b22",
                    },
                    new ClimbingRoute
                    {
                        Id = Guid.NewGuid(),
                        Name = "Steilaufstieg",
                        Grade = "6a",
                        Type = ClimbingRouteType.SportClimbing,
                        ImageUri = "http://localhost",
                        Color = "#228b22",
                    },
                    new ClimbingRoute
                    {
                        Id = Guid.NewGuid(),
                        Name = "Abgefahren",
                        Grade = "5a",
                        Type = ClimbingRouteType.SportClimbing,
                        ImageUri = "http://localhost",
                        Color = "#228b22",
                    },
                    new ClimbingRoute
                    {
                        Id = Guid.NewGuid(),
                        Name = "Zerschlissen",
                        Grade = "5a+",
                        Type = ClimbingRouteType.SportClimbing,
                        ImageUri = "http://localhost",
                        Color = "#228b22",
                    },
                }
            },
            new ClimbingSite
            {
                Id = Guid.NewGuid(),
                Name = "BLOCKFELD Boulderpark - Winterthur",
                Address = new Address
                {
                    Street = "Oberer Deutweg 4",
                    PostCode = "8400",
                    City ="Winterthur",
                    State = "Zürich",
                },
                Routes = new ClimbingRoute[0],
            },
            new ClimbingSite
            {
                Id = Guid.NewGuid(),
                Name = "Kletterzentrum Milandia Greifensee",
                Address = new Address
                {
                    Street = "Migros Sport- und Erlebnispark",
                    PostCode = "8606",
                    City ="Greifensee",
                    State = "Zürich",
                },
                Routes = new ClimbingRoute[0],
            },
            new ClimbingSite
            {
                Id = Guid.NewGuid(),
                Name = "Griffig Kletterhalle Uster",
                Address = new Address
                {
                    Street = "Hallenbadweg 2",
                    PostCode = "8610",
                    City ="Uster",
                    State = "Zürich",
                },
                Routes = new ClimbingRoute[0],
            },
            new ClimbingSite
            {
                Id = Guid.NewGuid(),
                Name = "Aranea Schaffhausen",
                Address = new Address
                {
                    Street = "Ebnatstrasse 65",
                    PostCode = "8201",
                    City ="Schafhausen",
                    State = "Schaffhausen",
                },
                Routes = new ClimbingRoute[0],
            },
            new ClimbingSite
            {
                Id = Guid.NewGuid(),
                Name = "Ap und Daun",
                Address = new Address
                {
                    Street = "Pulvermühlestrasse 8",
                    PostCode = "7000",
                    City ="Chur",
                    State = "Graubünden",
                },
                Routes = new ClimbingRoute[0],
            },
            new ClimbingSite
            {
                Id = Guid.NewGuid(),
                Name = "BLOCKFELD Boulders und Kletterwand",
                Address = new Address
                {
                    Street = "Hauptstrasse 98",
                    PostCode = "8264",
                    City ="Eschenz",
                    State = "Thurgau",
                },
                Routes = new ClimbingRoute[0],
            },
            new ClimbingSite
            {
                Id = Guid.NewGuid(),
                Name = "Minimum (Boulderhalle)",
                Address = new Address
                {
                    Street = "Flüelastrasse 31",
                    PostCode = "8047",
                    City ="Zürich",
                    State = "Zürich",
                },
                Routes = new ClimbingRoute[0],
            },
            new ClimbingSite
            {
                Id = Guid.NewGuid(),
                Name = "Boulderei Flums",
                Address = new Address
                {
                    Street = "Bergstrasse 31c",
                    PostCode = "8890",
                    City ="Flums",
                    State = "St. Gallen",
                },
                Routes = new ClimbingRoute[0],
            },
            new ClimbingSite
            {
                Id = Guid.NewGuid(),
                Name = "Bloczone, Salle d'escalade",
                Address = new Address
                {
                    Street = "Route Henri-Stephan 12",
                    PostCode = "1762",
                    City ="Givisiez",
                    State = "Freiburg",
                },
                Routes = new ClimbingRoute[0],
            },
            new ClimbingSite
            {
                Id = Guid.NewGuid(),
                Name = "boulder-gade in Arth",
                Address = new Address
                {
                    Street = "Luzernerstrasse 91",
                    PostCode = "6415",
                    City ="Arth",
                    State = "Schwyz",
                },
                Routes = new ClimbingRoute[0],
            },
            new ClimbingSite
            {
                Id = Guid.NewGuid(),
                Name = "Boulderraum Sportzentrum Grindelwald",
                Address = new Address
                {
                    Street = "Dorfstrasse 110",
                    PostCode = "3818",
                    City ="Grindelwald",
                    State = "Bern",
                },
                Routes = new ClimbingRoute[0],
            },
            new ClimbingSite
            {
                Id = Guid.NewGuid(),
                Name = "Boulderraum Altstadt Brugg",
                Address = new Address
                {
                    Street = "Hauptstrasse 19",
                    PostCode = "5200",
                    City ="Brugg",
                    State = "Aargau",
                },
                Routes = new ClimbingRoute[0],
            },
            new ClimbingSite
            {
                Id = Guid.NewGuid(),
                Name = "B2 Boulder & Bar",
                Address = new Address
                {
                    Street = "Brodtbeck Areal, Hardstrasse 46",
                    PostCode = "4133",
                    City ="Pratteln",
                    State = "Basel",
                },
                Routes = new ClimbingRoute[0],
            },
            new ClimbingSite
            {
                Id = Guid.NewGuid(),
                Name = "Nordwandhalle",
                Address = new Address
                {
                    Street = "Am Inselpark 20",
                    PostCode = "21109",
                    City ="Hamburg",
                    State = "Freie und Hansestadt Hamburg",
                },
                Routes = new ClimbingRoute[0],
            },
        };
    }
}