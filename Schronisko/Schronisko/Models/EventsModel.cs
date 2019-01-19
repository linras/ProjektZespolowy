﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Schronisko.Models
{
    public class EventsModel
    {

        public int id { get; set; }


        [DisplayName("Data rozpoczecia")]
        [Required(ErrorMessage = "Proszę wprowadzić datę rozpoczecia.")]
        public System.DateTime date { get; set; }


        [DisplayName("Czas rozpoczecia")]
        [Required(ErrorMessage = "Proszę wprowadzić czas rozpoczecia.")]
        public System.TimeSpan time { get; set; }


        [DisplayName("Opis Eventu")]
        [Required(ErrorMessage = "Proszę wprowadzić opis eventu.")]
        public string description { get; set; }


        [DisplayName("Pies")]
        [Required(ErrorMessage = "Proszę wybrać psa.")]
        public int? id_dog { get; set; }

        public Dogs dogs
        {
            get
            {
                pszczupakEntities ent = new pszczupakEntities();
                return ent.Dogs.Where(x => x.id == id_dog).FirstOrDefault();
            }
        }
    }
}