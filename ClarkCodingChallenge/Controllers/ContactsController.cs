using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ClarkCodingChallenge.Models;
using ClarkCodingChallenge.Entities;
using System.Collections.Generic;
using ClarkCodingChallenge.DataAccess;
using System;
using System.Net;

namespace ClarkCodingChallenge.Controllers
{
    public class ContactsController : Controller
    {
        private readonly IContactsRepository _contactsService;

        public ContactsController(IContactsRepository contactsService)
        {
            _contactsService = contactsService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult<Contact> GetContactByEmail(string email)
        {
            var contact = _contactsService.GetContactByEmail(email);

            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _contactsService.AddContact(contact);
                }
                catch (Exception)
                {
                    return StatusCode(500);
                }

                return CreatedAtAction(
                    "GetContactByEmail",
                    new { email = contact.Email },
                    contact);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public ActionResult<IEnumerable<Contact>> GetMailingListEntries(
            string lastName, 
            string sortOrder = "asc")
        {
            var contacts = _contactsService.GetMailingListEntries(lastName, sortOrder);
        
            return Ok(contacts);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
