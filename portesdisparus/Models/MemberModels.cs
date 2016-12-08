using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeopLost.Web.Models
{
    public class MemberModels
    {
        /// <summary>
        /// Gets or sets the Member Guid
        /// </summary>
        public string MemberId { get; set; }

        [Display(Name = "Email")]
        public string Email { get; set; }

        [Display(Name = "BirthDay")]
        public string BirthDay { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        public string Phone { get; set; }

        [Display(Name = "Commune")]
        public string Commune { get; set; }
        
    }

    public class ListMemberViewModel
    {
        public IList<MemberModels> _Items{get;set;}

        public ListMemberViewModel()
        {
            this._Items = new List<MemberModels>();
            //this._listmemberViewModel.Add(new MemberModels() { 
            //    MemberId=0,
            //     FirstName="Koffi", LastName="Hermann", Gender="M", isAdmin=false, Email="xyz@peoplost.com", Phone="XX-XX-XX-XX"
            //});
            //this._listmemberViewModel.Add(new MemberModels()
            //{
            //    MemberId = 1,
            //    FirstName = "Koffi",
            //    LastName = "Hermann",
            //    Gender = "M",
            //    isAdmin = false,
            //    Email = "xyz@peoplost.com",
            //    Phone = "XX-XX-XX-XX",
            //    ImageUrl = "/Images/alexisdiaw.jpg"
            //});
            //this._listmemberViewModel.Add(new MemberModels()
            //{
            //    MemberId = 2,
            //    FirstName = "Kouakou",
            //    LastName = "Hermann",
            //    Gender = "M",
            //    isAdmin = false,
            //    Email = "xyz@peoplost.com",
            //    Phone = "XX-XX-XX-XX",
            //    ImageUrl = "/Images/alexisdiaw.jpg"
            //});
            //this._listmemberViewModel.Add(new MemberModels()
            //{
            //    MemberId = 3,
            //    FirstName = "Kouassi",
            //    LastName = "Hermann",
            //    Gender = "M",
            //    isAdmin = false,
            //    Email = "xyz@peoplost.com",
            //    Phone = "XX-XX-XX-XX",
            //    ImageUrl = "/Images/alexisdiaw.jpg"
            //});
            //this._listmemberViewModel.Add(new MemberModels()
            //{
            //    MemberId = 4,
            //    FirstName = "Kone",
            //    LastName = "Hermann",
            //    Gender = "M",
            //    isAdmin = false,
            //    Email = "xyz@peoplost.com",
            //    Phone = "XX-XX-XX-XX",
            //    ImageUrl = "/Images/alexisdiaw.jpg"
            //});
            //this._listmemberViewModel.Add(new MemberModels()
            //{
            //    MemberId = 5,
            //    FirstName = "Kouadio",
            //    LastName = "Hermann",
            //    Gender = "M",
            //    isAdmin = false,
            //    Email = "xyz@peoplost.com",
            //    Phone = "XX-XX-XX-XX",
            //    ImageUrl = "/Images/alexisdiaw.jpg"
            //});
        }
    }
}
