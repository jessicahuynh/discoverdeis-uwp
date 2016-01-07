using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discover_Deis.Models
{
    public class Coordinate
    {
        public double x { get; set; }
        public double y { get; set;  }
    }

    public class Point
    {
        public string id { get; set; }
        public Coordinate coordinate { get; set; }
        public string type { get; set; } // crossing, entrance, icrossing, ientrance
        public string getTo { get; set; }
        public bool singlepoint { get; set; }
    }

    public class Path
    {
        public Point start { get; set; }
        public Point end { get; set; }
        public string description { get; set; }
    }

    public class Loc
    {
        public string id { get; set; }
        public string name { get; set; }
        public string nickname { get; set; }
        public List<Coordinate> coordinates { get; set; }
        public string function { get; set; }
        public string description { get; set; }
        public List<string> category { get; set; } // academics, administrative, art, athletics, dining, dorm, health, landscape, library, offices, parking, student life, transportation, religious 
        public List<Point> entrances { get; set; }
        public List<Point> icrossings { get; set; }
        public List<Loc> nearby { get; set; }
        public List<string> area { get; set; }
            // north, east, mandel, libraries, chapels, science complex (upper campus)
            // rosenthal, ziv, ridgewood, massell, charles river (lower campus)
            // athletics, foster mods (athletic complex)
    }

    public class LocManager
    {
        public static List<Loc> GetLocList()
        {
            var locs = new List<Loc>();

            locs.Add(new Loc()
            {
                id = "fieldhouse",
                name = "Red Auerbach Arena",
                nickname = "The Fieldhouse",
                coordinates = new List<Coordinate>(){ new Coordinate(){ x = 42.364903, y = -71.255339 },
                                                     new Coordinate(){ x = 42.364476, y = -71.254855 },
                                                     new Coordinate(){ x = 42.364998, y = -71.253966 },
                                                     new Coordinate(){ x = 42.365444, y = -71.254475 }
                },
                function = "The Fieldhouse is home to Brandeis basketball and volleyball. Many events, such as graduation, are held here as well.",
                description = "test",
                category = new List<string> { "athletics", "student life" },
                area = new List<string> { "athletics", "athletic complex" }
            });
            locs.Add(new Loc()
            {
                id = "dharmic",
                name = "Dharmic Prayer Space",
                nickname = "D",
                coordinates = new List<Coordinate>(){ new Coordinate(){ x = 42.364903, y = -71.255339 },
                                                     new Coordinate(){ x = 42.364476, y = -71.254855 },
                                                     new Coordinate(){ x = 42.364998, y = -71.253966 },
                                                     new Coordinate(){ x = 42.365444, y = -71.254475 }
                },
                function = "The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come.",
                description = "test tes test The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come. test test test",
                category = new List<string> { "religious", "student life" },
                area = new List<string> { "lower campus" },
                
            });
            locs.Add(new Loc()
            {
                id = "dharmic",
                name = "Dharmic Prayer Space",
                nickname = "D",
                coordinates = new List<Coordinate>(){ new Coordinate(){ x = 42.364903, y = -71.255339 },
                                                     new Coordinate(){ x = 42.364476, y = -71.254855 },
                                                     new Coordinate(){ x = 42.364998, y = -71.253966 },
                                                     new Coordinate(){ x = 42.365444, y = -71.254475 }
                },
                function = "The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come.",
                description = "test tes test The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come. test test test",
                category = new List<string> { "religious", "student life" },
                area = new List<string> { "lower campus" },
                nearby = new List<Loc> { locs[0], locs[1], locs[0] }
            });
            locs.Add(new Loc()
            {
                id = "dharmic",
                name = "Dharmic Prayer Space",
                nickname = "D",
                coordinates = new List<Coordinate>(){ new Coordinate(){ x = 42.364903, y = -71.255339 },
                                                     new Coordinate(){ x = 42.364476, y = -71.254855 },
                                                     new Coordinate(){ x = 42.364998, y = -71.253966 },
                                                     new Coordinate(){ x = 42.365444, y = -71.254475 }
                },
                function = "The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come.",
                description = "test tes test The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come. test test test",
                category = new List<string> { "religious", "student life" },
                area = new List<string> { "lower campus" }
            });
            locs.Add(new Loc()
            {
                id = "dharmic",
                name = "Dharmic Prayer Space",
                nickname = "D",
                coordinates = new List<Coordinate>(){ new Coordinate(){ x = 42.364903, y = -71.255339 },
                                                     new Coordinate(){ x = 42.364476, y = -71.254855 },
                                                     new Coordinate(){ x = 42.364998, y = -71.253966 },
                                                     new Coordinate(){ x = 42.365444, y = -71.254475 }
                },
                function = "The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come.",
                description = "test tes test The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come. test test test",
                category = new List<string> { "religious", "student life" },
                area = new List<string> { "lower campus" }
            });
            locs.Add(new Loc()
            {
                id = "dharmic",
                name = "Dharmic Prayer Space",
                nickname = "D",
                coordinates = new List<Coordinate>(){ new Coordinate(){ x = 42.364903, y = -71.255339 },
                                                     new Coordinate(){ x = 42.364476, y = -71.254855 },
                                                     new Coordinate(){ x = 42.364998, y = -71.253966 },
                                                     new Coordinate(){ x = 42.365444, y = -71.254475 }
                },
                function = "The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come.",
                description = "test tes test The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come. test test test",
                category = new List<string> { "religious", "student life" },
                area = new List<string> { "lower campus" }
            });
            locs.Add(new Loc()
            {
                id = "dharmic",
                name = "Dharmic Prayer Space",
                nickname = "D",
                coordinates = new List<Coordinate>(){ new Coordinate(){ x = 42.364903, y = -71.255339 },
                                                     new Coordinate(){ x = 42.364476, y = -71.254855 },
                                                     new Coordinate(){ x = 42.364998, y = -71.253966 },
                                                     new Coordinate(){ x = 42.365444, y = -71.254475 }
                },
                function = "The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come.",
                description = "test tes test The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come. test test test",
                category = new List<string> { "religious", "student life" },
                area = new List<string> { "lower campus" }
            });
            locs.Add(new Loc()
            {
                id = "dharmic",
                name = "Dharmic Prayer Space",
                nickname = "D",
                coordinates = new List<Coordinate>(){ new Coordinate(){ x = 42.364903, y = -71.255339 },
                                                     new Coordinate(){ x = 42.364476, y = -71.254855 },
                                                     new Coordinate(){ x = 42.364998, y = -71.253966 },
                                                     new Coordinate(){ x = 42.365444, y = -71.254475 }
                },
                function = "The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come.",
                description = "test tes test The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come. test test test",
                category = new List<string> { "religious", "student life" },
                area = new List<string> { "lower campus" }
            });
            locs.Add(new Loc()
            {
                id = "dharmic",
                name = "Dharmic Prayer Space",
                nickname = "D",
                coordinates = new List<Coordinate>(){ new Coordinate(){ x = 42.364903, y = -71.255339 },
                                                     new Coordinate(){ x = 42.364476, y = -71.254855 },
                                                     new Coordinate(){ x = 42.364998, y = -71.253966 },
                                                     new Coordinate(){ x = 42.365444, y = -71.254475 }
                },
                function = "The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come.",
                description = "test tes test The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come. test test test",
                category = new List<string> { "religious", "student life" },
                area = new List<string> { "lower campus" }
            });
            locs.Add(new Loc()
            {
                id = "dharmic",
                name = "Dharmic Prayer Space",
                nickname = "D",
                coordinates = new List<Coordinate>(){ new Coordinate(){ x = 42.364903, y = -71.255339 },
                                                     new Coordinate(){ x = 42.364476, y = -71.254855 },
                                                     new Coordinate(){ x = 42.364998, y = -71.253966 },
                                                     new Coordinate(){ x = 42.365444, y = -71.254475 }
                },
                function = "The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come.",
                description = "test tes test The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come. test test test",
                category = new List<string> { "religious", "student life" },
                area = new List<string> { "lower campus" }
            });
            locs.Add(new Loc()
            {
                id = "dharmic",
                name = "Dharmic Prayer Space",
                nickname = "D",
                coordinates = new List<Coordinate>(){ new Coordinate(){ x = 42.364903, y = -71.255339 },
                                                     new Coordinate(){ x = 42.364476, y = -71.254855 },
                                                     new Coordinate(){ x = 42.364998, y = -71.253966 },
                                                     new Coordinate(){ x = 42.365444, y = -71.254475 }
                },
                function = "The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come.",
                description = "test tes test The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come. test test test",
                category = new List<string> { "religious", "student life" },
                area = new List<string> { "lower campus" }
            });
            locs.Add(new Loc()
            {
                id = "dharmic",
                name = "Dharmic Prayer Space",
                nickname = "D",
                coordinates = new List<Coordinate>(){ new Coordinate(){ x = 42.364903, y = -71.255339 },
                                                     new Coordinate(){ x = 42.364476, y = -71.254855 },
                                                     new Coordinate(){ x = 42.364998, y = -71.253966 },
                                                     new Coordinate(){ x = 42.365444, y = -71.254475 }
                },
                function = "The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come.",
                description = "test tes test The newly inaugurated Dharmic Prayer Center is home to Brandeis' Namaskar and Sangha clubs, which together encompass Hindus, Buddhists, Jains, and Sikhs on campus, although all are welcome to come. test test test",
                category = new List<string> { "religious", "student life" },
                area = new List<string> { "lower campus" }
            });

            return locs;
        }
    }
}
