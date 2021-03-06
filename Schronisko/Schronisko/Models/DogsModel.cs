﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Schronisko.Models
{
    public class DogsModel
    {
        public HttpPostedFileBase Photo { get; set; }
        public int id { get; set; }

        [DisplayName("Imię psa")]
        [Required(ErrorMessage = "Proszę wprowadzić imię psa.")]
        [StringLength(50, ErrorMessage = "Max 50 znaków.")]
        public string name { get; set; }
        

        [DisplayName("Rok urodzenia psa")]
        [Required(ErrorMessage = "Proszę wprowadzić rok urodzenia psa.")]
        public int? year_of_birth { get; set; }



        [DisplayName("Zdjęcie psa")]
        
        public string photo_path { get; set; }


        [DisplayName("Opis psa")]
        [Required(ErrorMessage = "Proszę wprowadzić opis psa.")]
        public string description { get; set; }


        [DisplayName("Rasa psa")]
        [Required(ErrorMessage = "Proszę wprowadzić rasę psa.")]
        public int? id_race { get; set; }

        public Races races
        {
            get
            {
                pszczupakEntities ent = new pszczupakEntities();
                return ent.Races.Where(x => x.id == id_race).FirstOrDefault();
            }
        }


    }
}