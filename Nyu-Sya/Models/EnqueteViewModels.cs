using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nyu_Sya.Models
{
    public class EnqueteViewModel
    {

        [Display(Name = "扶養家族の有無")]
        public bool fuyou { get; set; }

        [Display(Name="今年度給与所得の有無")]
        public bool syotoku { get; set; }

        [Display(Name = "住民税納付状況")]
        public int juminzei { get; set; }

        [Display(Name="雇用保険被保険者証の有無")]
        public bool koyouhoken { get; set; }
    }

    public class DocumentsViewModel
    {
        [Display(Name = "基礎年金番号(コピー)")]
        public bool kisonenkin { get; set; }

        [Display(Name = "給与振込先口座(コピー)")]
        public bool kyuyokoza { get; set; }

        [Display(Name = "機密保持誓約書(直筆受領)")]
        public bool kimitsuhoji { get; set; }

        [Display(Name = "誓約書(直筆受領)")]
        public bool seiyakusyo { get; set; }
    }
}