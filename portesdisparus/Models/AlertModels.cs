using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeopLost.Web.Models
{

    public class AlertStatusModel
    {
        public string AlertId { get; set; }
        public bool ConcreteAlert { get; set; }

    }

    public class AlertsFoundModel
    {
        public string AlertId { get; set; }
        [Display(Name="Found or Not")]
        public bool Found { get; set; }

    }

    public class AlertModels
    {


        public AlertModels()
        {
            PersonId = Guid.NewGuid();
        }


        public Guid AlertId { get; set; }

        [Display(Name = "Comment")]
        [Required]
        public string Post { get; set; }

        public DateTime? DateAlert { get; set; }


        [Display(Name = "Day of the Disappearing")]
        [Required]
        public DateTime DayDisappear { get; set; }

        /// <summary>
        /// Gets or sets the User Id  
        /// </summary>
        public Guid UserId { get; set; }

        public string LooserAddress { get; set; }
        /// <summary>
        /// Gets or sets the Person Id
        /// </summary>
        public Guid PersonId { get; set; }

        public MemberModels Member { get; set; }

        public PersonModels Person { get; set; }

        /// <summary>
        /// Gets or sets the status of the alert: verified or not
        /// </summary>
        public bool ConcreteAlert { get; set; }

        /// <summary>
        /// Gets or sets the comments for this alert
        /// </summary>
        public IEnumerable<CommentModels> Comments { get; set; }

        public bool Found { get; set; }
    }

    public class ListAlertViewModel
    {
        public IList<AlertModels> Items { get; set; }

        public ListAlertViewModel()
        {
            Items = new List<AlertModels>();
            //this._listalertviewmodel = new List<AlertModels>(){
            //    new AlertModels()
            //    {
            //    AlertId = 0,
            //    PersonId = 0,
            //    Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
            //    DateAlert = DateTime.Now,
            //    ConcreteAlert = true,
            //    UserId = 0,
            //    Person = new PersonModels()
            //    {
            //        PersonId = 0,
            //        FirstName = "Koffi",
            //        LastName = "Hermann",
            //        Gender = "M",
            //        Country = "Cote d'ivoire",
            //        City = "Abidjan",
            //        YearsOld = 12,
            //        LooserAddress = "Abobo",
            //        DayDisappear = DateTime.Now,
            //        Caracteristics = "Peau claire, yeux bleu, chemise marron, un jean bleu",
            //        ImageUrl = "/Images/alexisdiaw.jpg"
            //    },
            //    Member = new MemberModels()
            //    {
            //        MemberId = 0,
            //        FirstName = "Anne",
            //        LastName = "Ndri",
            //        Gender = "F",
            //        isAdmin = false,
            //        Email = "xyz@peoplost.com",
            //        Phone = "XX-XX-XX-XX",
            //        ImageUrl = "/Images/annendri.gif"
            //    },
            //    Comments = new List<CommentModels>() 
            //    {
            //            new CommentModels(){
            //             AlertId=0,
            //              DatePost=DateTime.Now,
            //              MemberId=0,
            //             Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 0,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            }
            //}},
            //new AlertModels()
            //{
            //    AlertId=1,
            //    PersonId = 1,
            //    Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
            //    DateAlert = DateTime.Now,
            //    ConcreteAlert = true,
            //    UserId = 1,
            //    Person = new PersonModels()
            //    {
            //        PersonId = 1,
            //        FirstName = "Koffi",
            //        LastName = "Hermann",
            //        Gender = "M",
            //        Country = "Cote d'ivoire",
            //        City = "Abidjan",
            //        YearsOld = 12,
            //        LooserAddress = "Abobo",
            //        DayDisappear = DateTime.Now,
            //        Caracteristics = "Peau claire, yeux bleu, chemise marron, un jean bleu",
            //        ImageUrl = "/Images/alexisdiaw.jpg"
            //    },
            //    Member = new MemberModels()
            //    {
            //        MemberId = 1,
            //        FirstName = "Anne",
            //        LastName = "Ndri",
            //        Gender = "F",
            //        isAdmin = false,
            //        Email = "xyz@peoplost.com",
            //        Phone = "XX-XX-XX-XX",
            //        ImageUrl = "/Images/annendri.gif"
            //    },
            //    Comments = new List<CommentModels>() 
            //    {
            //            new CommentModels(){
            //             AlertId=0,
            //              DatePost=DateTime.Now,
            //              MemberId=0,
            //             Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 0,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            }
            //}},
            
            //new AlertModels()
            //{
            //    AlertId=2,
            //    PersonId = 2,
            //    Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
            //    DateAlert = DateTime.Now,
            //    ConcreteAlert = true,
            //    UserId = 0,
            //    Person = new PersonModels()
            //    {
            //        PersonId = 2,
            //        FirstName = "Koffi",
            //        LastName = "Hermann",
            //        Gender = "M",
            //        Country = "Cote d'ivoire",
            //        City = "Abidjan",
            //        YearsOld = 12,
            //        LooserAddress = "Abobo",
            //        DayDisappear = DateTime.Now,
            //        Caracteristics = "Peau claire, yeux bleu, chemise marron, un jean bleu",
            //        ImageUrl = "/Images/alexisdiaw.jpg"
            //    },
            //    Member = new MemberModels()
            //    {
            //        MemberId = 0,
            //        FirstName = "Anne",
            //        LastName = "Ndri",
            //        Gender = "F",
            //        isAdmin = false,
            //        Email = "xyz@peoplost.com",
            //        Phone = "XX-XX-XX-XX",
            //        ImageUrl = "/Images/annendri.gif"
            //    }
            //    ,
            //    Comments = new List<CommentModels>() 
            //    {
            //            new CommentModels(){
            //             AlertId=0,
            //              DatePost=DateTime.Now,
            //              MemberId=0,
            //             Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 0,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            }
            //}},
            
            //new AlertModels()
            //{
            //    AlertId=3,
            //    PersonId = 3,
            //    Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
            //    DateAlert = DateTime.Now,
            //    ConcreteAlert = true,
            //    UserId = 0,
            //    Person = new PersonModels()
            //    {
            //        PersonId = 3,
            //        FirstName = "Koffi",
            //        LastName = "Hermann",
            //        Gender = "M",
            //        Country = "Cote d'ivoire",
            //        City = "Abidjan",
            //        YearsOld = 12,
            //        LooserAddress = "Abobo",
            //        DayDisappear = DateTime.Now,
            //        Caracteristics = "Peau claire, yeux bleu, chemise marron, un jean bleu",
            //        ImageUrl = "/Images/alexisdiaw.jpg"
            //    },
            //    Member = new MemberModels()
            //    {
            //        MemberId = 0,
            //        FirstName = "Anne",
            //        LastName = "Ndri",
            //        Gender = "F",
            //        isAdmin = false,
            //        Email = "xyz@peoplost.com",
            //        Phone = "XX-XX-XX-XX",
            //        ImageUrl = "/Images/annendri.gif"
            //    }
            //    ,
            //    Comments = new List<CommentModels>() 
            //    {
            //            new CommentModels(){
            //             AlertId=0,
            //              DatePost=DateTime.Now,
            //              MemberId=0,
            //             Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 0,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            }
            //}},
            
            //new AlertModels()
            //{
            //    AlertId=4,
            //    PersonId = 4,
            //    Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
            //    DateAlert = DateTime.Now,
            //    ConcreteAlert = true,
            //    UserId = 2,
            //    Person = new PersonModels()
            //    {
            //        PersonId = 4,
            //        FirstName = "Koffi",
            //        LastName = "Hermann",
            //        Gender = "M",
            //        Country = "Cote d'ivoire",
            //        City = "Abidjan",
            //        YearsOld = 12,
            //        LooserAddress = "Abobo",
            //        DayDisappear = DateTime.Now,
            //        Caracteristics = "Peau claire, yeux bleu, chemise marron, un jean bleu",
            //        ImageUrl = "/Images/alexisdiaw.jpg"
            //    },
            //    Member = new MemberModels()
            //    {
            //        MemberId = 2,
            //        FirstName = "Anne",
            //        LastName = "Ndri",
            //        Gender = "F",
            //        isAdmin = false,
            //        Email = "xyz@peoplost.com",
            //        Phone = "XX-XX-XX-XX",
            //        ImageUrl = "/Images/annendri.gif"
            //    }
            //    ,
            //    Comments = new List<CommentModels>() 
            //    {
            //            new CommentModels(){
            //             AlertId=0,
            //              DatePost=DateTime.Now,
            //              MemberId=0,
            //             Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 0,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            }
            //}},
            
            //new AlertModels()
            //{
            //    AlertId=5,
            //    PersonId = 5,
            //    Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
            //    DateAlert = DateTime.Now,
            //    ConcreteAlert = true,
            //    UserId = 2,
            //    Person = new PersonModels()
            //    {
            //        PersonId = 5,
            //        FirstName = "Koffi",
            //        LastName = "Hermann",
            //        Gender = "M",
            //        Country = "Cote d'ivoire",
            //        City = "Abidjan",
            //        YearsOld = 12,
            //        LooserAddress = "Abobo",
            //        DayDisappear = DateTime.Now,
            //        Caracteristics = "Peau claire, yeux bleu, chemise marron, un jean bleu",
            //        ImageUrl = "/Images/alexisdiaw.jpg"
            //    },
            //    Member = new MemberModels()
            //    {
            //        MemberId = 2,
            //        FirstName = "Anne",
            //        LastName = "Ndri",
            //        Gender = "F",
            //        isAdmin = false,
            //        Email = "xyz@peoplost.com",
            //        Phone = "XX-XX-XX-XX",
            //        ImageUrl = "/Images/annendri.gif"
            //    }
            //    ,
            //    Comments = new List<CommentModels>() 
            //    {
            //            new CommentModels(){
            //             AlertId=0,
            //              DatePost=DateTime.Now,
            //              MemberId=0,
            //             Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 0,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            }
            //}},
            
            //new AlertModels()
            //{
            //    AlertId=6,
            //    PersonId = 6,
            //    Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
            //    DateAlert = DateTime.Now,
            //    ConcreteAlert = true,
            //    UserId = 1,
            //    Person = new PersonModels()
            //    {
            //        PersonId = 6,
            //        FirstName = "Koffi",
            //        LastName = "Hermann",
            //        Gender = "M",
            //        Country = "Cote d'ivoire",
            //        City = "Abidjan",
            //        YearsOld = 12,
            //        LooserAddress = "Abobo",
            //        DayDisappear = DateTime.Now,
            //        Caracteristics = "Peau claire, yeux bleu, chemise marron, un jean bleu",
            //        ImageUrl = "/Images/alexisdiaw.jpg"
            //    },
            //    Member = new MemberModels()
            //    {
            //        MemberId = 1,
            //        FirstName = "Anne",
            //        LastName = "Ndri",
            //        Gender = "F",
            //        isAdmin = false,
            //        Email = "xyz@peoplost.com",
            //        Phone = "XX-XX-XX-XX",
            //        ImageUrl = "/Images/annendri.gif"
            //    }
            //    ,
            //    Comments = new List<CommentModels>() 
            //    {
            //            new CommentModels(){
            //             AlertId=0,
            //              DatePost=DateTime.Now,
            //              MemberId=0,
            //             Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 0,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            }
            //}},
           
            //new AlertModels()
            //{
            //    AlertId=7,
            //    PersonId = 7,
            //    Post = "USPS Service Alerts provide information to consumers, small businesses and ... this website to learn if mail is being delivered, or if their Post Offices are open.",
            //    DateAlert = DateTime.Now,
            //    ConcreteAlert = true,
            //    UserId = 2,
            //    Person = new PersonModels()
            //    {
            //        PersonId = 7,
            //        FirstName = "Koffi",
            //        LastName = "Hermann",
            //        Gender = "M",
            //        Country = "Cote d'ivoire",
            //        City = "Abidjan",
            //        YearsOld = 12,
            //        LooserAddress = "Abobo",
            //        DayDisappear = DateTime.Now,
            //        Caracteristics = "Peau claire, yeux bleu, chemise marron, un jean bleu",
            //        ImageUrl = "/Images/alexisdiaw.jpg"
            //    },
            //    Member = new MemberModels()
            //    {
            //        MemberId = 2,
            //        FirstName = "Anne",
            //        LastName = "Ndri",
            //        Gender = "F",
            //        isAdmin = false,
            //        Email = "xyz@peoplost.com",
            //        Phone = "XX-XX-XX-XX",
            //        ImageUrl = "/Images/annendri.gif"
            //    }
            //    ,
            //    Comments = new List<CommentModels>() 
            //    {
            //            new CommentModels(){
            //             AlertId=0,
            //              DatePost=DateTime.Now,
            //              MemberId=0,
            //             Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },
            //            new CommentModels()
            //            {
            //                AlertId = 0,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 0,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 1,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            },

            //            new CommentModels()
            //            {
            //                AlertId = 1,
            //                DatePost = DateTime.Now,
            //                MemberId = 2,
            //                Post = "Canada Post would like to inform you of the following regarding our return to operations in Fort McMurray. Effective Monday June 13, 2016, we will be starting some mail services in the affected areas of Fort McMurray"
            //            }
            //}}
            
           //};
        }
    }
    
}
