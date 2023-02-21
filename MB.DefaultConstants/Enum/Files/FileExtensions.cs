using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace MB.DefaultConstants.Enum.Files
{

    public enum FileExtensions
    {
        [Display(Name = "فایل فشرده rar")]
        rar,
        [Display(Name = "فایل فشرده zip")]
        zip,
        [Display(Name = "فایل Word")]
        doc,
        [Display(Name = "فایل Word")]
        docx,
        [Display(Name = "فایل متنی")]
        txt,
        [Display(Name = "اکسل")]
        xls,
        [Display(Name = "اکسل")]
        xlsx,
        [Display(Name = "pdf")]
        pdf,
        [Display(Name = "پاور پوینت")]
        ppt,
        [Display(Name = "پاور پوینت")]
        pptx,
        [Display(Name = "فیلم")]
        mp4,
        [Display(Name = "فیلم")]
        mov,
        [Display(Name = "فیلم")]
        wmv,
        [Display(Name = "فیلم")]
        webm,
        [Display(Name = "فیلم")]
        avi,
        [Display(Name = "فیلم")]
        flv,
        [Display(Name = "فیلم")]
        mkv,
        [Display(Name = "فیلم")]
        mts,

    }
}
