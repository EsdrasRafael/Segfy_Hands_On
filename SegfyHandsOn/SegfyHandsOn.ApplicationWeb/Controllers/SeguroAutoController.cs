using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SegfyHandsOn.Domain.Entities;
using SegfyHandsOn.Service.Validators;
using SegfyHandsOn.Service.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SegfyHandsOn.ApplicationWeb.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class SeguroAutoController : Controller
    {
        private SeguroAutoService seguroAutoService;
        public SeguroAutoController(SeguroAutoService _seguroAutoService)
        {
            seguroAutoService = _seguroAutoService;
        }

        public IActionResult Post([FromBody] SeguroAuto item)
        {
            try
            {
                seguroAutoService.Post<SeguroAutoValidator>(item);

                return new ObjectResult(item.Id);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public IActionResult Put([FromBody] SeguroAuto item)
        {
            try
            {
                seguroAutoService.Put<SeguroAutoValidator>(item);

                return new ObjectResult(item);
            }
            catch (ArgumentNullException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public IActionResult Delete(int id)
        {
            try
            {
                seguroAutoService.Remove(id);

                return new NoContentResult();
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public IActionResult Get()
        {
            try
            {
                return new ObjectResult(seguroAutoService.Get());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        public IActionResult Get(int id)
        {
            try
            {
                return new ObjectResult(seguroAutoService.Get(id));
            }
            catch (ArgumentException ex)
            {
                return NotFound(ex);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }
    }
}
