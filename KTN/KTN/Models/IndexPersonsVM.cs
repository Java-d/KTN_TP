using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using KTN.KTNServiceRef;

namespace KTN.Models
{
    public class IndexPersonsVM
    {
        public RegionDto[] Countries { get; set; }

        public RegionDto[] Cities { get; set; }

        public RegionDto[] Districts { get; set; }

        public PersonDto[] Citizens { get; set; }
    }
}