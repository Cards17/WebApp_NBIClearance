﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NBILicenseProjectAPI.Models;

namespace NBILicenseProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        private readonly CustomerDbContext _context;

        public ApplicantController(CustomerDbContext context)
        {
            _context = context;
        }

        // GET: api/Applicant
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Applicant>>> GetApplicant()
        {
            return await _context.Applicant.ToListAsync();
        }

        // GET: api/Applicant/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Applicant>> GetApplicant(int id)
        {
            var applicant = await _context.Applicant.FindAsync(id);

            if (applicant == null)
            {
                return NotFound();
               
            }

            return applicant;
        }

        // PUT: api/Applicant/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutApplicant(int id, Applicant applicant)
        {
            if (id != applicant.Id)
            {
                return BadRequest();
            }

            _context.Entry(applicant).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ApplicantExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Applicant
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Applicant>> PostApplicant(Applicant applicant)
        {
            _context.Applicant.Add(applicant);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetApplicant", new { id = applicant.Id }, applicant);
        }

        // DELETE: api/Applicant/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Applicant>> DeleteApplicant(int id)
        {
            var applicant = await _context.Applicant.FindAsync(id);
            if (applicant == null)
            {
                return NotFound();
            }

            _context.Applicant.Remove(applicant);
            await _context.SaveChangesAsync();

            return applicant;
        }

        private bool ApplicantExists(int id)
        {
            return _context.Applicant.Any(e => e.Id == id);
        }
    }
}
