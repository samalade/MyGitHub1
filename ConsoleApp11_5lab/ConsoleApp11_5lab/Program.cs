﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace ConsoleApp11_5lab
{
    class Program
    {
        static void Main(string[] args)
        {
            SakilaContext sakila = new SakilaContext();
            Film war1917 = new Film("1917", "2019 War Drama By Director Sam Mendes", "2019", 3, 5.99m, 179, 19.99m, "R");
            Film joker = new Film("Joker", "Oscar-Nominated SuperHero Drama", "2019", 3, 6.99m, 182, 23.99m, "R");
            Film jarjarAbrams = new Film("Star Wars: The Rise of SkyWalker", "Trash Disney Fanfic", "2019", 3, 4.99m, 202, 21.99m, "PG-13");
            Film Inception = new Film("Inception", "Mind-bending thriller", "2010", 3, 8.99m, 228, 25.99m, "PG-13");
            Film Gladiator = new Film("Gladiator", "A millenium war drama directed by Ridley Scott", "2000", 3, 4.99m, 235, 9.99m, "R");


            sakila.Film.Add(war1917); 
            sakila.Film.Add(joker);  
            sakila.Film.Add(jarjarAbrams);
            sakila.Film.Add(Inception);
            sakila.Film.Add(Gladiator);
            sakila.SaveChanges();

            


            Film[] allfilms = sakila.Film.ToArray();
            
            var newfilms = allfilms.Where(x => x.release_year == "2019");

            StringBuilder html = new StringBuilder();
            html.Append("<html>\n");
            html.Append("  <head>");
            html.Append("    <title>Sakila New Films</title>\n");
            html.Append("  </head>\n");
            html.Append("  <body\n");
            html.Append("    <h1> New Films Coming Soon! </h1>\n");
            html.Append("      <ul>\n");
            foreach (var film in newfilms)
            {
                html.Append("<li>");
                html.Append(film.title + " " + film.description);
                html.Append("</li>");
            }


            html.Append("      </ul>\n");
            html.Append("  </body>\n");
            html.Append("</html>\n");

            string htmlFile = "C:\\output\\newfilms.html";
            File.WriteAllText(htmlFile, html.ToString());
        }
    }
}
