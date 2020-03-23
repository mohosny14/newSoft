﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Soft_Website.Models;
using System.Net.Mail;
using System.Net;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Contact(Contact contact)
        {

            var mail = new MailMessage();
            var loginInfo = new NetworkCredential("mohosny14@gmail.com", "mo..hamedAli14");
            mail.From = new MailAddress(contact.E_mail);
            mail.To.Add(new MailAddress("mohosny14@gmail.com"));

            mail.IsBodyHtml = true;
            string body = "Name : " + contact.name + "<br>" +
                            "Email: " + contact.E_mail + "<br>" +
                             " Message: <b>" + contact.message + "</b>";

            mail.Body = body;

            var smtpClient = new SmtpClient("smtp.gmail.com", 587); // 587 this is Gmail Port

            smtpClient.EnableSsl = true;

            smtpClient.Credentials = loginInfo;
            smtpClient.Send(mail);

            return RedirectToAction("Index");

        }
    }
}