using System.Collections.Generic;
using WPF_TreeView.Models;

namespace WPF_TreeView.Helpers
{
    public static class DummyData
    {
        public static List<Country> GetDummyCountries()
        {
            return new List<Country>() {
                new Country()
                {
                    Name = "Vietnam",
                    Cities = new List<City>()
                    {
                        new City()
                        {
                            Name = "Ha Noi",
                            Universities = new List<University> {
                                new University { Name = "University HN1" },
                                new University { Name = "University HN2" },
                                new University { Name = "University HN3" }
                            },
                        },
                        new City()
                        {
                            Name = "Da Nang",
                            Universities = new List<University> {
                                new University { Name = "University DN1" },
                                new University { Name = "University DN2" },
                                new University { Name = "University DN3" }
                            },
                        },
                        new City()
                        {
                            Name = "Ho Chi Minh",
                            Universities = new List<University> {
                                new University { Name = "University HCM1" },
                                new University { Name = "University HCM2" },
                                new University { Name = "University HCM3" }
                            },
                        }
                    }
                },
                new Country()
                {
                    Name = "United States",
                    Cities = new List<City>()
                    {
                        new City()
                        {
                            Name = "New York",
                            Universities = new List<University> {
                                new University { Name = "University NY1" },
                                new University { Name = "University NY2" },
                                new University { Name = "University NY3" }
                            },
                        },
                        new City()
                        {
                            Name = "Los Angeles",
                            Universities = new List<University> {
                                new University { Name = "University LA1" },
                                new University { Name = "University LA2" },
                                new University { Name = "University LA3" }
                            },
                        },
                        new City()
                        {
                            Name = "Chicago",
                            Universities = new List<University> {
                                new University { Name = "University CH1" },
                                new University { Name = "University CH3" },
                                new University { Name = "University CH2" },
                            },
                        }
                    }
                }
            };
        }
    }
}
