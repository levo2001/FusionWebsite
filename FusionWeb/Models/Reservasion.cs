﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FusionWeb.Models
{
    public class Reservasion
    {

        public int Id { get; set; }


        public Client Client { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "תאריך")]
        [Range(0, 999.99)]
        public DateTime DateTime { get; set; }

        [Range(1, 10)]
        public int NumOfDinners { get; set; }


        public string Note { get; set; }


    }
}
